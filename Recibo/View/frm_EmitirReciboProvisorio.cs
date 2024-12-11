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

            // Add columns for Descricao of Ato, Descricao and Quantidade of ReciboProvisorioAto
            dgv_ReciboProvisorioAtos.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Ato.Descricao",
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
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_EmissaoReciboProvisorio_Click(object sender, EventArgs e)
        {

        }

        private void lbl_Requerente_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dgv_ListaAtos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void frm_EmitirReciboProvisorio_Load(object sender, EventArgs e)
        {

        }

        private void txtbox_Requerente_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Adicionar_Click(object sender, EventArgs e)
        {
            try
            {
                var novoAto = new ReciboProvisorioAto
                {
                    Descricao = txtbox_Descricao.Text,
                    Quantidade = Convert.ToInt32(txtbox_Quantidade.Text),
                    Ato = new Ato { Descricao = txtbox_CodigoAto.Text }
                };

                _reciboProvisorioVM.Atos.Add(novoAto);

                txtbox_CodigoAto.Clear();
                txtbox_Descricao.Clear();
                txtbox_Quantidade.Clear();

                dgv_ReciboProvisorioAtos.DataSource = null;
                dgv_ReciboProvisorioAtos.DataSource = _reciboProvisorioVM.Atos;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtbox_CodigoAto_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Salvar_Click(object sender, EventArgs e)
        {
            _reciboProvisorioVM.SaveChanges();
        }

        private void dgv_ReciboProvisorioAtos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
