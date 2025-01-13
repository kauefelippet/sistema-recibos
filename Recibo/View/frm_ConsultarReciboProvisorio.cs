using Microsoft.EntityFrameworkCore;
using Recibo.Models;
using System.Data;

namespace Recibo.View
{
    public partial class frm_ConsultarReciboProvisorio : Form
    {
        private recibos_dbContext _context;
        private BindingSource ReciboProvisorioBindingSource = new();
        private BindingSource ReciboProvisorioAtosBindingSource = new();
        public int ReciboProvisorioId { get; set; }

        public frm_ConsultarReciboProvisorio(recibos_dbContext context)
        {
            InitializeComponent();
            _context = context;
        }

        private void frm_ConsultarReciboProvisorio_Load(object sender, EventArgs e)
        {

        }

        private void BindReciboProvisorioAtosData()
        {
            var recibosProvisoriosAtos = _context.ReciboProvisorioAtos
                .Where(r => r.ReciboProvisorioId == this.ReciboProvisorioId)
                .Include(r => r.Ato)
                .ToList();

            // Bind the RecibosProvisorios to the DataGridView
            ReciboProvisorioAtosBindingSource.DataSource = recibosProvisoriosAtos;
            dgv_RecibosProvisoriosAtos.DataSource = ReciboProvisorioAtosBindingSource;

            // Configure the DataGridView columns
            dgv_RecibosProvisoriosAtos.AutoGenerateColumns = false;
            dgv_RecibosProvisoriosAtos.Columns.Clear();

            // Add columns for Quantidade, Ato, Descricao, and Total
            dgv_RecibosProvisoriosAtos.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Quantidade",
                HeaderText = "Qtd",
                Name = "Quantidade"
            });

            dgv_RecibosProvisoriosAtos.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "AtoNome",
                HeaderText = "Ato",
                Name = "AtoNome"
            });

            dgv_RecibosProvisoriosAtos.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Descricao",
                HeaderText = "Descrição",
                Name = "Descricao"
            });

            dgv_RecibosProvisoriosAtos.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Total",
                HeaderText = "Total",
                Name = "Total"
            });
        }

        private void BindReciboProvisorioData()
        {
            List<ReciboProvisorio> reciboProvisorio = new();

            // Identify which of the textboxes has been filled
            if (txtbox_Requerente.Text != "")
            {
                reciboProvisorio = _context.RecibosProvisorios
                    .Where(r => r.Requerente.Contains(txtbox_Requerente.Text))
                    .ToList();
            }
            else if (txtbox_CPF.Text != "")
            {
                // Remove special characters from CPF
                var cpf = txtbox_CPF.Text.Replace(".", "").Replace("-", "");

                reciboProvisorio = _context.RecibosProvisorios
                    .Where(r => r.Cpf.Contains(cpf))
                    .ToList();
            }
            else if (dateTimePicker_Data.Value != DateTime.MinValue)
            {
                var selectedDate = dateTimePicker_Data.Value.Date;
                reciboProvisorio = _context.RecibosProvisorios
                    .Where(r => r.Data.HasValue && r.Data.Value.Date == selectedDate)
                    .ToList();
            }
            else if (txtbox_ID.Text != "")
            {
                if (int.TryParse(txtbox_ID.Text, out int id))
                {
                    reciboProvisorio = _context.RecibosProvisorios
                        .Where(r => r.Id == id)
                        .ToList();
                }
            }

            // Bind the RecibosProvisorios to the DataGridView
            ReciboProvisorioBindingSource.DataSource = reciboProvisorio;
            dgv_RecibosProvisorios.DataSource = ReciboProvisorioBindingSource;

            // Configure the DataGridView columns
            dgv_RecibosProvisorios.AutoGenerateColumns = false;
            dgv_RecibosProvisorios.Columns.Clear();

            // Add columns for Id, Requerente, Cpf, Data, and Total
            dgv_RecibosProvisorios.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Id",
                HeaderText = "Id",
                Name = "Id"
            });

            dgv_RecibosProvisorios.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Requerente",
                HeaderText = "Requerente",
                Name = "Requerente"
            });

            dgv_RecibosProvisorios.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Cpf",
                HeaderText = "CPF",
                Name = "Cpf"
            });

            dgv_RecibosProvisorios.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Data",
                HeaderText = "Data",
                Name = "Data"
            });

            dgv_RecibosProvisorios.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Total",
                HeaderText = "Total",
                Name = "Total"
            });
        }

        private void txtbox_Requerente_TextChanged(object sender, EventArgs e)
        {
            // Make the other textboxes inacessible
            txtbox_CPF.Enabled = false;
            dateTimePicker_Data.Enabled = false;
            txtbox_ID.Enabled = false;

            // If the textbox is empty, make the other textboxes accessible
            if (txtbox_Requerente.Text == "")
            {
                txtbox_CPF.Enabled = true;
                dateTimePicker_Data.Enabled = true;
                txtbox_ID.Enabled = true;
            }
        }

        private void txtbox_CPF_TextChanged(object sender, EventArgs e)
        {
            // Make the other textboxes inacessible
            txtbox_Requerente.Enabled = false;
            dateTimePicker_Data.Enabled = false;
            txtbox_ID.Enabled = false;

            // If the textbox is empty, make the other textboxes accessible
            if (txtbox_CPF.Text == "")
            {
                txtbox_Requerente.Enabled = true;
                dateTimePicker_Data.Enabled = true;
                txtbox_ID.Enabled = true;
            }
        }

        private void txtbox_ID_TextChanged(object sender, EventArgs e)
        {
            // Make the other textboxes inacessible
            txtbox_Requerente.Enabled = false;
            txtbox_CPF.Enabled = false;
            dateTimePicker_Data.Enabled = false;

            // If the textbox is empty, make the other textboxes accessible
            if (txtbox_ID.Text == "")
            {
                txtbox_Requerente.Enabled = true;
                txtbox_CPF.Enabled = true;
                dateTimePicker_Data.Enabled = true;
            }
        }

        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            BindReciboProvisorioData();
        }

        private void dgv_RecibosProvisorios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Ensure the row index is valid
            {
                int selectedRowIndex = e.RowIndex;
                DataGridViewRow selectedRow = dgv_RecibosProvisorios.Rows[selectedRowIndex];

                // Get the ReciboProvisorioId from the selected row
                ReciboProvisorioId = Convert.ToInt32(selectedRow.Cells["Id"].Value);
            }

            BindReciboProvisorioAtosData();
        }

        private void dateTimePicker_Data_ValueChanged(object sender, EventArgs e)
        {
            // Make the other textboxes inaccessible
            txtbox_Requerente.Enabled = false;
            txtbox_CPF.Enabled = false;
            txtbox_ID.Enabled = false;

            // If the DateTimePicker is reset, make the other textboxes accessible
            if (dateTimePicker_Data.Value == DateTime.MinValue)
            {
                txtbox_Requerente.Enabled = true;
                txtbox_CPF.Enabled = true;
                txtbox_ID.Enabled = true;
            }
        }
    }
}
