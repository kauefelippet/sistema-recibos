using Recibo.Models;
using System.Data;

namespace Recibo.View
{
    public partial class frm_ReciboDefinitivoConsultado : Form
    {
        private recibos_dbContext _context;
        private BindingSource _bindingSource = new();
        public int ReciboId { get; set; }

        public frm_ReciboDefinitivoConsultado(recibos_dbContext context)
        {
            InitializeComponent();
            _context = context;
        }

        private void frm_ConsultarReciboDefinitivo_Load(object sender, EventArgs e)
        {

        }

        public void BindData()
        {
            // Verify if the ReciboId is set
            if (this.ReciboId == 0)
            {
                return;
            }

            var recibosAtos = _context.ReciboAtos
                            .Where(r => r.ReciboId == this.ReciboId)
                            .ToList();

            // Bind the Recibos to the DataGridView
            _bindingSource.DataSource = recibosAtos;
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

            // Set the labels to the Recibo values
            var recibo = _context.Recibos.FirstOrDefault(r => r.Id == ReciboId);
            lbl_Requerente.Text = "Requerente: " + recibo.Requerente;
            lbl_CPF.Text = "CPF: " + recibo.Cpf;
            lbl_Data.Text = "Data: " + recibo.Data.ToString();
            lbl_Total.Text = "Total: R$" + recibo.Total.ToString();
            lbl_ID.Text = "ID: " + recibo.Id.ToString();
        }
    }
}
