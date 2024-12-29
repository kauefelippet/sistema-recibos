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
    public partial class frm_EmitirReciboProvisorio : Form
    {
        private ReciboProvisorioVM _reciboProvisorioVM;
        private recibos_dbContext _context;
        private BindingSource _bindingSource = new();

        public frm_EmitirReciboProvisorio(ReciboProvisorioVM reciboProvisorioVM, recibos_dbContext context)
        {
            InitializeComponent();
            _reciboProvisorioVM = reciboProvisorioVM;
            _context = context;
            BindData();
        }

        private void BindData()
        {
            // Bind the ReciboProvisorioVM to the form
            _bindingSource.DataSource = _reciboProvisorioVM.Atos;
            dgv_ReciboProvisorioAtos.DataSource = _bindingSource;

            // Configure the DataGridView columns
            dgv_ReciboProvisorioAtos.AutoGenerateColumns = false;
            dgv_ReciboProvisorioAtos.Columns.Clear();

            // Add columns for Ato, Descricao, Quantidade and Total of ReciboProvisorioAto
            dgv_ReciboProvisorioAtos.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "AtoNome",
                HeaderText = "Ato",
                ReadOnly = true
            });

            dgv_ReciboProvisorioAtos.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Descricao",
                HeaderText = "Descrição"
            });

            dgv_ReciboProvisorioAtos.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Quantidade",
                HeaderText = "Quantidade"
            });

            dgv_ReciboProvisorioAtos.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Total",
                HeaderText = "Total"
            });
        }

        private void frm_EmitirReciboProvisorio_Load(object sender, EventArgs e)
        {
            var latestReciboProvisorio = _context.RecibosProvisorios.OrderByDescending(r => r.Id).FirstOrDefault();
            int nextReciboProvisorioId = latestReciboProvisorio != null ? latestReciboProvisorio.Id + 1 : 1;
            lbl_IdRecibo.Text = "Recibo nº " + nextReciboProvisorioId;
        }

        private void btn_Adicionar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtbox_CodigoAto.Text))
                    throw new Exception("O código do Ato não foi informado.");
                if (string.IsNullOrEmpty(txtbox_Quantidade.Text))
                    throw new Exception("A quantidade deve ser maior que zero.");

                var ato = _context.Atos.FirstOrDefault(a => a.Codigo == txtbox_CodigoAto.Text) ?? throw new Exception("O código do Ato informado não existe.");
                var novoAto = new ReciboProvisorioAto
                {
                    Descricao = txtbox_Descricao.Text,
                    Quantidade = Convert.ToInt32(txtbox_Quantidade.Text),
                    Ato = ato
                };

                _reciboProvisorioVM.Atos.Add(novoAto);

                txtbox_CodigoAto.Clear();
                txtbox_Descricao.Clear();
                txtbox_Quantidade.Clear();

                // Refresh the BindingSource
                _bindingSource.ResetBindings(false);

                // Updates the total value of the ReciboProvisorio
                var total = _reciboProvisorioVM.Atos.Sum(a => a.Total);
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
                if (_reciboProvisorioVM.Atos.Count == 0)
                    throw new Exception("O Recibo Provisório deve conter ao menos um Ato.");
                if (string.IsNullOrEmpty(txtbox_Requerente.Text))
                {
                    throw new Exception("O nome do Requerente deve ser informado.");
                }

                _reciboProvisorioVM.Requerente = txtbox_Requerente.Text;
                _reciboProvisorioVM.Cpf = txtbox_CPF.Text.Replace(".", "").Replace("-", "");

                _reciboProvisorioVM.SaveChanges();

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
            _reciboProvisorioVM.Atos.Clear();

            // Re-fetch the data from the database if necessary
            var latestReciboProvisorio = _context.RecibosProvisorios.OrderByDescending(r => r.Id).FirstOrDefault();
            int nextReciboProvisorioId = latestReciboProvisorio != null ? latestReciboProvisorio.Id + 1 : 1;
            lbl_IdRecibo.Text = "Recibo nº " + nextReciboProvisorioId;

            // Re-bind the data to the form controls
            _bindingSource.DataSource = _reciboProvisorioVM.Atos;
            dgv_ReciboProvisorioAtos.DataSource = _bindingSource;

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
    }
}
