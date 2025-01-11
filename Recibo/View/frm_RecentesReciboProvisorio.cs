using Microsoft.EntityFrameworkCore;
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
    public partial class frm_RecentesReciboProvisorio : Form
    {
        private recibos_dbContext _context;
        private BindingSource _bindingSource = new();
        private int ClickedReciboProvisorioId;

        public frm_RecentesReciboProvisorio(recibos_dbContext context)
        {
            InitializeComponent();
            _context = context;
            BindData();
        }

        private void frm_RecentesReciboProvisorio_Load(object sender, EventArgs e)
        {

        }

        private void BindData()
        {
            // Include the related ReciboProvisorioAtos when querying the RecibosProvisorios
            var recibosProvisorios = _context.RecibosProvisorios
                .Include(r => r.ReciboProvisorioAtos)
                .ThenInclude(a => a.Ato)
                .ToList();

            // Bind the RecibosProvisorios to the DataGridView
            _bindingSource.DataSource = recibosProvisorios;
            dgv_Recentes.DataSource = _bindingSource;

            // Configure the DataGridView columns
            dgv_Recentes.AutoGenerateColumns = false;
            dgv_Recentes.Columns.Clear();

            // Add columns for Id, Requerente, Cpf, Data, and Total
            dgv_Recentes.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Id",
                HeaderText = "Id",
                Name = "Id"
            });

            dgv_Recentes.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Requerente",
                HeaderText = "Requerente",
                Name = "Requerente"
            });

            dgv_Recentes.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Cpf",
                HeaderText = "CPF",
                Name = "Cpf"
            });

            dgv_Recentes.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Data",
                HeaderText = "Data",
                Name = "Data"
            });

            dgv_Recentes.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Total",
                HeaderText = "Total",
                Name = "Total"
            });
        }

        private void btn_Consultar_Click(object sender, EventArgs e)
        {
            var frm_Consulta = new frm_ReciboProvisorioConsultado(_context);
            frm_Consulta.ReciboProvisorioId = ClickedReciboProvisorioId;

            // Shows the ConsultarReciboProvisorio form
            frm_Consulta.Show();
            frm_Consulta.BindData();
        }

        private void dgv_Recentes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Ensure the row index is valid
            {
                int selectedRowIndex = e.RowIndex;
                DataGridViewRow selectedRow = dgv_Recentes.Rows[selectedRowIndex];

                // Get the ReciboProvisorioId from the selected row
                ClickedReciboProvisorioId = Convert.ToInt32(selectedRow.Cells["Id"].Value);
            }
        }
    }
}
