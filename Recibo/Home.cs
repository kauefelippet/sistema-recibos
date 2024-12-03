using Recibo.View;

namespace Recibo
{
    public partial class Home : Form
    {
        private Form? frmAtivo;
        public Home()
        {
            InitializeComponent();
        }

        private void FormShow(Form frm)
        {
            ActiveFormClose();
            frmAtivo = frm;
            frm.TopLevel = false;
            pnl_Form.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();
        }

        private void ActiveFormClose()
        {
            if (frmAtivo != null)
            {
                frmAtivo.Close();
            }
        }

        private void ActiveButton(Button? frmAtivo)
        {
            foreach (Control ctrl in pnl_Principal.Controls)
            {
                ctrl.ForeColor = Color.FromArgb(206, 212, 218);
            }
            if (frmAtivo != null)
            {
                frmAtivo.ForeColor = Color.FromArgb(108, 117, 125);
            }
        }

        private void btn_ReciboDefinitivo_Click(object sender, EventArgs e)
        {
            ActiveButton(btn_ReciboDefinitivo);
             // implementar e chamar a tela de ReciboDefinitivo
        }

        private void Recibo_Load(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void lbl_Logo_Click(object sender, EventArgs e)
        {

        }

        private void pic_Logo_Click(object sender, EventArgs e)
        {
            ActiveButton(null);
            ActiveFormClose();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pnl_Form_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_Sair_Click(object sender, EventArgs e)
        {
            ActiveButton(btn_Sair);
            ActiveFormClose();
            Application.Exit();
        }

        private void lbl_Home_Click(object sender, EventArgs e)
        {

        }

        private void btn_ReciboProvisorio_Click(object sender, EventArgs e)
        {
            ActiveButton(btn_ReciboProvisorio);
            FormShow(new frm_EmitirReciboProvisorio());
        }
    }
}
