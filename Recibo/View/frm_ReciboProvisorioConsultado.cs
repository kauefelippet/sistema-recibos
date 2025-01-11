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
    public partial class frm_ReciboProvisorioConsultado : Form
    {
        private recibos_dbContext _context;
        private BindingSource _bindingSource = new();
        public int ReciboProvisorioId { get; set; }

        public frm_ReciboProvisorioConsultado(recibos_dbContext context)
        {
            InitializeComponent();
            _context = context;
        }

        private void frm_ConsultarReciboProvisorio_Load(object sender, EventArgs e)
        {

        }

        public void BindData()
        {
            var recibosProvisoriosAtos = _context.ReciboProvisorioAtos
                .Where(r => r.ReciboProvisorioId == this.ReciboProvisorioId)
                .ToList();

            // Bind the RecibosProvisorios to the DataGridView
            _bindingSource.DataSource = recibosProvisoriosAtos;
            dgv_Atos.DataSource = _bindingSource;

            // Configure the DataGridView columns
            dgv_Atos.AutoGenerateColumns = false;
            dgv_Atos.Columns.Clear();

            // Add columns for Quantidade, Ato, Descricao, and Total
            dgv_Atos.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Quantidade",
                HeaderText = "Qtd",
                Name = "Quantidade"
            });

            dgv_Atos.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "AtoNome",
                HeaderText = "Ato",
                Name = "AtoNome"
            });

            dgv_Atos.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Descricao",
                HeaderText = "Descrição",
                Name = "Descricao"
            });

            dgv_Atos.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Total",
                HeaderText = "Total",
                Name = "Total"
            });

            // Set the labels to the ReciboProvisorio values
            var reciboProvisorio = _context.RecibosProvisorios.FirstOrDefault(r => r.Id == ReciboProvisorioId);
            lbl_Requerente.Text = "Requerente: " + reciboProvisorio.Requerente;
            lbl_CPF.Text = "CPF: " + reciboProvisorio.Cpf;
            lbl_Data.Text = "Data: " + reciboProvisorio.Data.ToString();
            lbl_Total.Text = "Total: R$" + reciboProvisorio.Total.ToString();
            lbl_ID.Text = "ID: " + reciboProvisorio.Id.ToString();
        }
    }
}
