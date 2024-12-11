using Recibo.Models;
using Recibo.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Recibo.View
{
    public partial class frm_Atos : Form
    {
        private AtosVM _atosVM;
        public frm_Atos()
        {
            InitializeComponent();
            _atosVM = new AtosVM();
            BindData();
        }

        private void BindData()
        {
            using (var context = new recibos_dbContext())
            {
                // Set the DataSource of the DataGridView to the Atos database table
                dgv_Atos.DataSource = context.Atos.ToList();
            }

            // Configure the DataGridView columns
            dgv_Atos.AutoGenerateColumns = false;
            dgv_Atos.Columns.Clear();

            // Set the AutoSizeColumnsMode to AllCells
            dgv_Atos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            // Add columns for Descricao of Ato, Descricao and Quantidade of ReciboProvisorioAto
            dgv_Atos.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Codigo",
                HeaderText = "Código",
                ReadOnly = true
            });

            dgv_Atos.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Descricao",
                HeaderText = "Descrição"
            });

            dgv_Atos.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Total",
                HeaderText = "Total"
            });

            dgv_Atos.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "CustasIpesp",
                HeaderText = "IPESP"
            });

            dgv_Atos.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "CustasIss",
                HeaderText = "ISS"
            });

            dgv_Atos.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "CustasOficial",
                HeaderText = "Oficial"
            });
        }
        private void btn_CriarAto_Click(object sender, EventArgs e)
        {
            try
            {
                _atosVM.CreateAto(txtbox_CodigoAto.Text, txtbox_DescricaoAto.Text, Convert.ToDecimal(txtbox_CustasIpesp.Text), Convert.ToDecimal(txtbox_CustasIss.Text), Convert.ToDecimal(txtbox_CustasOficial.Text));

                BindData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_ExcluirAto_Click(object sender, EventArgs e)
        {
            try
            {
                _atosVM.DeleteAto(txtbox_CodigoAto.Text);

                BindData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void frm_Atos_Load(object sender, EventArgs e)
        {

        }
    }
}
