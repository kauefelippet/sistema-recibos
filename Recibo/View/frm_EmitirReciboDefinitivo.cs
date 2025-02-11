using Recibo.Models;
using Recibo.Util;
using Recibo.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Recibo.View
{
    public partial class frm_EmitirReciboDefinitivo : Form
    {
        private ReciboDefinitivoVM _reciboDefinitivoVM;
        private recibos_dbContext _context;
        private BindingSource _bindingSource = new();
        private readonly PdfService _pdfService;
        private int selectedRowIndex;

        public frm_EmitirReciboDefinitivo(ReciboDefinitivoVM reciboDefinitivoVM, recibos_dbContext context, PdfService pdfService)
        {
            InitializeComponent();
            _reciboDefinitivoVM = reciboDefinitivoVM;
            _context = context;
            _pdfService = pdfService;
            BindData();
        }

        private void BindData()
        {
            // Bind the ReciboVM to the form
            _bindingSource.DataSource = _reciboDefinitivoVM.Atos;
            dgv_ReciboAtos.DataSource = _bindingSource;

            // Configure the DataGridView columns
            dgv_ReciboAtos.AutoGenerateColumns = false;
            dgv_ReciboAtos.Columns.Clear();

            // Add columns for Ato, Descricao, Quantidade and Total of ReciboAto
            dgv_ReciboAtos.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "AtoNome",
                HeaderText = "Ato",
                Name = "AtoNome",
                ReadOnly = true
            });

            dgv_ReciboAtos.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Descricao",
                HeaderText = "Descrição",
                Name = "Descricao"
            });

            dgv_ReciboAtos.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Quantidade",
                HeaderText = "Quantidade",
                Name = "Quantidade"
            });

            dgv_ReciboAtos.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Total",
                HeaderText = "Total",
                Name = "Total"
            });
        }

        private void frm_EmitirReciboDefinitivo_Load(object sender, EventArgs e)
        {
            var latestRecibo = _context.Recibos.OrderByDescending(r => r.Id).FirstOrDefault();
            int nextReciboId = latestRecibo != null ? latestRecibo.Id + 1 : 1;
            lbl_IdRecibo.Text = "Recibo nº " + nextReciboId;
        }

        private void btn_Adicionar_Click(object sender, EventArgs e)
        {
            try
            {
                // Binds the textboxes data to the ReciboVM
                _reciboDefinitivoVM.CodigoAto = txtbox_CodigoAto.Text;
                _reciboDefinitivoVM.Descricao = txtbox_Descricao.Text;
                _reciboDefinitivoVM.Quantidade = int.Parse(txtbox_Quantidade.Text);

                // Adds the Ato to the ReciboVM
                _reciboDefinitivoVM.AddAto();

                // Clear the textboxes
                txtbox_CodigoAto.Clear();
                txtbox_Descricao.Clear();
                txtbox_Quantidade.Clear();

                // Refresh the BindingSource
                _bindingSource.ResetBindings(false);

                // Updates the total value of the Recibo
                var total = _reciboDefinitivoVM.Atos.Sum(a => a.Total);
                lbl_TotalRecibo.Text = "Total: R$ " + total.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Salvar_Click(object sender, EventArgs e)
        {
            try
            {
                if (_reciboDefinitivoVM.Atos.Count == 0)
                    throw new Exception("O Recibo deve conter ao menos um Ato.");
                if (string.IsNullOrEmpty(txtbox_Requerente.Text))
                {
                    throw new Exception("O nome do Requerente deve ser informado.");
                }

                _reciboDefinitivoVM.Requerente = txtbox_Requerente.Text;
                _reciboDefinitivoVM.Cpf = txtbox_CPF.Text.Replace(".", "").Replace("-", "");

                _reciboDefinitivoVM.SaveChanges();

                // Generate the PDF file
                int reciboId = _context.Recibos.OrderByDescending(r => r.Id).FirstOrDefault().Id;
                string outputPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), $"ReciboDefinitivo_{reciboId}.pdf");

                // _pdfService.GenerateReciboDefinitivoPdf(reciboId, outputPath); TODO: Implement this method

                MessageBox.Show("PDF gerado com sucesso!", "Emissão bem sucedida", MessageBoxButtons.OK, MessageBoxIcon.Information);

                RefreshForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RefreshForm()
        {
            // Clear the current data bindings
            _bindingSource.DataSource = null;

            // Clear the Atos collection
            _reciboDefinitivoVM.Atos.Clear();

            // Re-fetch the data from the database if necessary
            var latestRecibo = _context.Recibos.OrderByDescending(r => r.Id).FirstOrDefault();
            int nextReciboId = latestRecibo != null ? latestRecibo.Id + 1 : 1;
            lbl_IdRecibo.Text = "Recibo nº " + nextReciboId;

            // Re-bind the data to the form controls
            _bindingSource.DataSource = _reciboDefinitivoVM.Atos;
            dgv_ReciboAtos.DataSource = _bindingSource;

            // Clear the form fields
            txtbox_Requerente.Clear();
            txtbox_CPF.Clear();
            txtbox_CodigoAto.Clear();
            txtbox_Descricao.Clear();
            txtbox_Quantidade.Clear();
            lbl_ValorQuantidade.Text = "";
            lbl_NomeAto.Text = "";
            lbl_TotalRecibo.Text = "Total: R$ 0,00";
        }

        private void txtbox_CPF_TextChanged(object sender, EventArgs e)
        {
            try
            {
                TextBox txtCpf = (TextBox)sender;

                if (txtCpf == null) return;

                // Removes all non-numeric characters from the text
                string formattedCpf = new string(txtCpf.Text.Where(char.IsDigit).ToArray());

                // Formats the CPF with the correct mask
                if (formattedCpf.Length > 6)
                    formattedCpf = formattedCpf.Insert(6, ".");

                if (formattedCpf.Length > 3)
                    formattedCpf = formattedCpf.Insert(3, ".");

                if (formattedCpf.Length > 11)
                    formattedCpf = formattedCpf.Insert(11, "-");

                // Updates the text in the TextBox
                txtCpf.Text = formattedCpf;

                // Positions the cursor at the end of the text
                txtCpf.SelectionStart = formattedCpf.Length;

                // Validates the CPF and changes the text color accordingly
                if (Validation.ValidarCPF(formattedCpf))
                {
                    txtbox_CPF.ForeColor = Color.FromArgb(153, 204, 51);
                }
                else
                {
                    txtbox_CPF.ForeColor = Color.FromArgb(238, 68, 102);

                    if (txtbox_CPF.TextLength == 14)
                    {
                        txtbox_CPF.Clear();
                        throw new Exception("CPF inválido.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtbox_CodigoAto_TextChanged(object sender, EventArgs e)
        {
            if (txtbox_CodigoAto.TextLength == 3)
            {
                try
                {
                    var ato = _context.Atos.FirstOrDefault(a => a.Codigo == txtbox_CodigoAto.Text) ?? throw new Exception("O código do Ato informado não existe.");
                    lbl_NomeAto.Text = ato.Nome;
                }
                catch (Exception ex)
                {
                    txtbox_CodigoAto.Clear();
                    MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (txtbox_CodigoAto.TextLength < 3)
            {
                lbl_NomeAto.Text = "";
            }

        }
        private void txtbox_CPF_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permits only numbers
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void txtbox_Quantidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permits only numbers
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void txtbox_Quantidade_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtbox_Quantidade.Text) && !string.IsNullOrEmpty(txtbox_CodigoAto.Text))
            {
                try
                {
                    var ato = _context.Atos.FirstOrDefault(a => a.Codigo == txtbox_CodigoAto.Text);
                    if (ato != null && int.TryParse(txtbox_Quantidade.Text, out int quantidade))
                    {
                        lbl_ValorQuantidade.Text = "* " + ato.Total + " = " + (ato.Total * quantidade);
                    }
                    else
                    {
                        lbl_ValorQuantidade.Text = "";
                        if (ato == null)
                        {
                            throw new Exception("O código do Ato informado não existe.");
                        }
                        else
                        {
                            throw new Exception("A quantidade deve ser um número válido.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                lbl_ValorQuantidade.Text = "";
            }
        }

        private void dgv_ReciboAtos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Ensure the row index is valid
            {
                selectedRowIndex = e.RowIndex;
                DataGridViewRow selectedRow = dgv_ReciboAtos.Rows[selectedRowIndex];

                // Get the Ato by searching on the database
                var ato = _context.Atos.FirstOrDefault(a => a.Nome == selectedRow.Cells["AtoNome"].Value.ToString());

                // Set the textboxes with the corresponding values from the DataGridView
                txtbox_CodigoAto.Text = ato.Codigo;
                txtbox_Descricao.Text = selectedRow.Cells["Descricao"].Value.ToString();
                txtbox_Quantidade.Text = selectedRow.Cells["Quantidade"].Value.ToString();
            }
        }

        private void btn_Excluir_Click(object sender, EventArgs e)
        {
            // Ensure the selectedRowIndex is valid
            if (selectedRowIndex >= 0)
            {
                // Get the selected row
                DataGridViewRow selectedRow = dgv_ReciboAtos.Rows[selectedRowIndex];

                // Get the Ato by searching on the database
                var ato = _context.Atos.FirstOrDefault(a => a.Nome == selectedRow.Cells["AtoNome"].Value.ToString());

                // Remove the Ato from the ReciboProvisorioVM
                _reciboDefinitivoVM.RemoveAto(selectedRowIndex);

                // Refresh the BindingSource
                _bindingSource.ResetBindings(false);

                // Updates the total value of the ReciboProvisorio
                var total = _reciboDefinitivoVM.Atos.Sum(a => a.Total);
                lbl_TotalRecibo.Text = "Total: R$ " + total.ToString();

                // Clear the textboxes
                txtbox_CodigoAto.Clear();
                txtbox_Descricao.Clear();
                txtbox_Quantidade.Clear();
            }
        }

        private void btn_Editar_Click(object sender, EventArgs e)
        {
            // Ensure the selectedRowIndex is valid
            if (selectedRowIndex >= 0)
            {
                try
                {
                    // Get the selected row
                    DataGridViewRow selectedRow = dgv_ReciboAtos.Rows[selectedRowIndex];

                    // Binds the textboxes data to the ReciboProvisorioVM
                    _reciboDefinitivoVM.CodigoAto = txtbox_CodigoAto.Text;
                    _reciboDefinitivoVM.Descricao = txtbox_Descricao.Text;
                    _reciboDefinitivoVM.Quantidade = int.Parse(txtbox_Quantidade.Text);

                    // Edit the Ato based on the selectedRowIndex
                    _reciboDefinitivoVM.EditAto(selectedRowIndex);

                    // Refresh the BindingSource
                    _bindingSource.ResetBindings(false);

                    // Updates the total value of the ReciboProvisorio
                    var total = _reciboDefinitivoVM.Atos.Sum(a => a.Total);
                    lbl_TotalRecibo.Text = "Total: R$ " + total.ToString();

                    // Clear the textboxes
                    txtbox_CodigoAto.Clear();
                    txtbox_Descricao.Clear();
                    txtbox_Quantidade.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btn_Vincular_Click(object sender, EventArgs e)
        {
            // if txtbox_IdReciboProvisorio is not empty, then the user wants to link the ReciboProvisorio to the ReciboDefinitivo
            if (btn_Vincular.Enabled)
            {
                try
                {
                    if (string.IsNullOrEmpty(txtbox_IdReciboProvisorio.Text))
                    {
                        throw new Exception("O Id do Recibo Provisório deve ser informado.");
                    }
                    int reciboProvisorioId = int.Parse(txtbox_IdReciboProvisorio.Text);

                    _reciboDefinitivoVM.FillFromReciboProvisorio(reciboProvisorioId);
                    MessageBox.Show("Recibo Provisório vinculado com sucesso!", "Vínculo bem sucedido", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Clear the textboxes
                    txtbox_CodigoAto.Clear();
                    txtbox_Descricao.Clear();
                    txtbox_Quantidade.Clear();

                    // Fill the Requerente and CPF textboxes with the ReciboProvisorio data
                    txtbox_Requerente.Text = _reciboDefinitivoVM.Requerente;
                    txtbox_CPF.Text = _reciboDefinitivoVM.Cpf;

                    // Refresh the BindingSource
                    _bindingSource.ResetBindings(false);

                    // Updates the total value of the Recibo
                    var total = _reciboDefinitivoVM.Atos.Sum(a => a.Total);
                    lbl_TotalRecibo.Text = "Total: R$ " + total.ToString();


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txtbox_IdReciboProvisorio_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permits only numbers
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }

            // If the user presses Enter, then the Vincular button is clicked
            if (e.KeyChar == (char)13)
            {
                btn_Vincular.PerformClick();
            }
        }
    }
}
