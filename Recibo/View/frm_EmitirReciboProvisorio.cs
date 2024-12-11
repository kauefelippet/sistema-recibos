using Recibo.Models;
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
        private recibos_dbContext _context = new recibos_dbContext();
        public frm_EmitirReciboProvisorio()
        {
            InitializeComponent();
            _reciboProvisorioVM = new ReciboProvisorioVM();
            BindData();
        }

        private void BindData()
        {
            // Set the DataSource of the DataGridView to the ObservableCollection
            dgv_ReciboProvisorioAtos.DataSource = _reciboProvisorioVM.Atos;

            // Configure the DataGridView columns
            dgv_ReciboProvisorioAtos.AutoGenerateColumns = false;
            dgv_ReciboProvisorioAtos.Columns.Clear();

            // Add columns for Ato, Descricao, Quantidade and Total of ReciboProvisorioAto
            dgv_ReciboProvisorioAtos.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "AtoDescricao",
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

        }

        private void btn_Adicionar_Click(object sender, EventArgs e)
        {
            try
            {
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

                // Refresh the DataGridView
                dgv_ReciboProvisorioAtos.DataSource = null;
                dgv_ReciboProvisorioAtos.DataSource = _reciboProvisorioVM.Atos;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Salvar_Click(object sender, EventArgs e)
        {
            _reciboProvisorioVM.SaveChanges();
        }
    }
}
