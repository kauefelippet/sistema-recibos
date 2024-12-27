namespace Recibo.View
{
    partial class frm_Atos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Atos));
            pnl_EmissaoReciboProvisorio = new Panel();
            txtbox_CustasOficial = new TextBox();
            lbl_CustasOficial = new Label();
            txtbox_CustasIss = new TextBox();
            lbl_CustasIss = new Label();
            dgv_Atos = new DataGridView();
            btn_Excluir = new Button();
            btn_CriarAto = new Button();
            txtbox_CustasIpesp = new TextBox();
            lbl_CustasIpesp = new Label();
            txtbox_DescricaoAto = new TextBox();
            lbl_DescricaoAto = new Label();
            txtbox_CodigoAto = new TextBox();
            lbl_CodigoAto = new Label();
            lbl_Atos = new Label();
            reciboProvisorioAtoBindingSource = new BindingSource(components);
            pnl_EmissaoReciboProvisorio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_Atos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)reciboProvisorioAtoBindingSource).BeginInit();
            SuspendLayout();
            // 
            // pnl_EmissaoReciboProvisorio
            // 
            pnl_EmissaoReciboProvisorio.Controls.Add(txtbox_CustasOficial);
            pnl_EmissaoReciboProvisorio.Controls.Add(lbl_CustasOficial);
            pnl_EmissaoReciboProvisorio.Controls.Add(txtbox_CustasIss);
            pnl_EmissaoReciboProvisorio.Controls.Add(lbl_CustasIss);
            pnl_EmissaoReciboProvisorio.Controls.Add(dgv_Atos);
            pnl_EmissaoReciboProvisorio.Controls.Add(btn_Excluir);
            pnl_EmissaoReciboProvisorio.Controls.Add(btn_CriarAto);
            pnl_EmissaoReciboProvisorio.Controls.Add(txtbox_CustasIpesp);
            pnl_EmissaoReciboProvisorio.Controls.Add(lbl_CustasIpesp);
            pnl_EmissaoReciboProvisorio.Controls.Add(txtbox_DescricaoAto);
            pnl_EmissaoReciboProvisorio.Controls.Add(lbl_DescricaoAto);
            pnl_EmissaoReciboProvisorio.Controls.Add(txtbox_CodigoAto);
            pnl_EmissaoReciboProvisorio.Controls.Add(lbl_CodigoAto);
            pnl_EmissaoReciboProvisorio.Controls.Add(lbl_Atos);
            pnl_EmissaoReciboProvisorio.Location = new Point(10, 12);
            pnl_EmissaoReciboProvisorio.Name = "pnl_EmissaoReciboProvisorio";
            pnl_EmissaoReciboProvisorio.Size = new Size(762, 502);
            pnl_EmissaoReciboProvisorio.TabIndex = 11;
            // 
            // txtbox_CustasOficial
            // 
            txtbox_CustasOficial.AcceptsTab = true;
            txtbox_CustasOficial.BackColor = Color.FromArgb(108, 117, 125);
            txtbox_CustasOficial.BorderStyle = BorderStyle.None;
            txtbox_CustasOficial.Cursor = Cursors.IBeam;
            txtbox_CustasOficial.Font = new Font("JetBrains Mono Light", 11F);
            txtbox_CustasOficial.ForeColor = Color.FromArgb(222, 226, 230);
            txtbox_CustasOficial.Location = new Point(0, 297);
            txtbox_CustasOficial.MaxLength = 10;
            txtbox_CustasOficial.Name = "txtbox_CustasOficial";
            txtbox_CustasOficial.Size = new Size(100, 20);
            txtbox_CustasOficial.TabIndex = 10;
            // 
            // lbl_CustasOficial
            // 
            lbl_CustasOficial.AutoSize = true;
            lbl_CustasOficial.Font = new Font("JetBrains Mono Light", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_CustasOficial.ForeColor = Color.FromArgb(206, 212, 218);
            lbl_CustasOficial.Location = new Point(0, 273);
            lbl_CustasOficial.Name = "lbl_CustasOficial";
            lbl_CustasOficial.Size = new Size(150, 21);
            lbl_CustasOficial.TabIndex = 9;
            lbl_CustasOficial.Text = "Custas Oficial";
            // 
            // txtbox_CustasIss
            // 
            txtbox_CustasIss.AcceptsTab = true;
            txtbox_CustasIss.BackColor = Color.FromArgb(108, 117, 125);
            txtbox_CustasIss.BorderStyle = BorderStyle.None;
            txtbox_CustasIss.Cursor = Cursors.IBeam;
            txtbox_CustasIss.Font = new Font("JetBrains Mono Light", 11F);
            txtbox_CustasIss.ForeColor = Color.FromArgb(222, 226, 230);
            txtbox_CustasIss.Location = new Point(0, 250);
            txtbox_CustasIss.MaxLength = 10;
            txtbox_CustasIss.Name = "txtbox_CustasIss";
            txtbox_CustasIss.Size = new Size(100, 20);
            txtbox_CustasIss.TabIndex = 8;
            // 
            // lbl_CustasIss
            // 
            lbl_CustasIss.AutoSize = true;
            lbl_CustasIss.Font = new Font("JetBrains Mono Light", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_CustasIss.ForeColor = Color.FromArgb(206, 212, 218);
            lbl_CustasIss.Location = new Point(0, 226);
            lbl_CustasIss.Name = "lbl_CustasIss";
            lbl_CustasIss.Size = new Size(110, 21);
            lbl_CustasIss.TabIndex = 7;
            lbl_CustasIss.Text = "Custas ISS";
            // 
            // dgv_Atos
            // 
            dgv_Atos.AllowUserToAddRows = false;
            dgv_Atos.AllowUserToDeleteRows = false;
            dgv_Atos.AllowUserToResizeRows = false;
            dgv_Atos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgv_Atos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgv_Atos.BackgroundColor = Color.FromArgb(73, 80, 87);
            dgv_Atos.BorderStyle = BorderStyle.None;
            dgv_Atos.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgv_Atos.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(108, 117, 125);
            dataGridViewCellStyle1.Font = new Font("JetBrains Mono Light", 9F);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(222, 226, 230);
            dataGridViewCellStyle1.SelectionBackColor = Color.OliveDrab;
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(222, 226, 230);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgv_Atos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgv_Atos.ColumnHeadersHeight = 20;
            dgv_Atos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(108, 117, 125);
            dataGridViewCellStyle2.Font = new Font("JetBrains Mono Light", 9F);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(222, 226, 230);
            dataGridViewCellStyle2.SelectionBackColor = Color.OliveDrab;
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(222, 226, 230);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgv_Atos.DefaultCellStyle = dataGridViewCellStyle2;
            dgv_Atos.EnableHeadersVisualStyles = false;
            dgv_Atos.Location = new Point(210, 3);
            dgv_Atos.Name = "dgv_Atos";
            dgv_Atos.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(108, 117, 125);
            dataGridViewCellStyle3.Font = new Font("JetBrains Mono Light", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(222, 226, 230);
            dataGridViewCellStyle3.SelectionBackColor = Color.OliveDrab;
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(222, 226, 230);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgv_Atos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgv_Atos.RowHeadersVisible = false;
            dgv_Atos.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(108, 117, 125);
            dataGridViewCellStyle4.Font = new Font("JetBrains Mono Light", 9F);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(222, 226, 230);
            dataGridViewCellStyle4.SelectionBackColor = Color.OliveDrab;
            dataGridViewCellStyle4.SelectionForeColor = Color.FromArgb(222, 226, 230);
            dgv_Atos.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dgv_Atos.Size = new Size(552, 496);
            dgv_Atos.TabIndex = 13;
            // 
            // btn_Excluir
            // 
            btn_Excluir.BackColor = Color.FromArgb(52, 58, 64);
            btn_Excluir.BackgroundImageLayout = ImageLayout.None;
            btn_Excluir.Cursor = Cursors.Hand;
            btn_Excluir.FlatAppearance.BorderSize = 0;
            btn_Excluir.FlatAppearance.MouseDownBackColor = Color.FromArgb(73, 80, 87);
            btn_Excluir.FlatAppearance.MouseOverBackColor = Color.FromArgb(52, 58, 64);
            btn_Excluir.FlatStyle = FlatStyle.Flat;
            btn_Excluir.Font = new Font("JetBrains Mono Light", 11F);
            btn_Excluir.ForeColor = Color.FromArgb(206, 212, 218);
            btn_Excluir.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Excluir.Location = new Point(90, 325);
            btn_Excluir.Margin = new Padding(5);
            btn_Excluir.Name = "btn_Excluir";
            btn_Excluir.Size = new Size(80, 30);
            btn_Excluir.TabIndex = 12;
            btn_Excluir.Text = "EXCLUIR";
            btn_Excluir.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_Excluir.UseVisualStyleBackColor = false;
            btn_Excluir.Click += btn_ExcluirAto_Click;
            // 
            // btn_CriarAto
            // 
            btn_CriarAto.BackColor = Color.FromArgb(52, 58, 64);
            btn_CriarAto.BackgroundImageLayout = ImageLayout.None;
            btn_CriarAto.Cursor = Cursors.Hand;
            btn_CriarAto.FlatAppearance.BorderSize = 0;
            btn_CriarAto.FlatAppearance.MouseDownBackColor = Color.FromArgb(73, 80, 87);
            btn_CriarAto.FlatAppearance.MouseOverBackColor = Color.FromArgb(52, 58, 64);
            btn_CriarAto.FlatStyle = FlatStyle.Flat;
            btn_CriarAto.Font = new Font("JetBrains Mono Light", 11F);
            btn_CriarAto.ForeColor = Color.FromArgb(206, 212, 218);
            btn_CriarAto.ImageAlign = ContentAlignment.MiddleLeft;
            btn_CriarAto.Location = new Point(0, 325);
            btn_CriarAto.Margin = new Padding(5);
            btn_CriarAto.Name = "btn_CriarAto";
            btn_CriarAto.Size = new Size(80, 30);
            btn_CriarAto.TabIndex = 10;
            btn_CriarAto.Text = "CRIAR";
            btn_CriarAto.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_CriarAto.UseVisualStyleBackColor = false;
            btn_CriarAto.Click += btn_CriarAto_Click;
            // 
            // txtbox_CustasIpesp
            // 
            txtbox_CustasIpesp.AcceptsTab = true;
            txtbox_CustasIpesp.BackColor = Color.FromArgb(108, 117, 125);
            txtbox_CustasIpesp.BorderStyle = BorderStyle.None;
            txtbox_CustasIpesp.Cursor = Cursors.IBeam;
            txtbox_CustasIpesp.Font = new Font("JetBrains Mono Light", 11F);
            txtbox_CustasIpesp.ForeColor = Color.FromArgb(222, 226, 230);
            txtbox_CustasIpesp.Location = new Point(0, 203);
            txtbox_CustasIpesp.MaxLength = 10;
            txtbox_CustasIpesp.Name = "txtbox_CustasIpesp";
            txtbox_CustasIpesp.Size = new Size(100, 20);
            txtbox_CustasIpesp.TabIndex = 6;
            // 
            // lbl_CustasIpesp
            // 
            lbl_CustasIpesp.AutoSize = true;
            lbl_CustasIpesp.Font = new Font("JetBrains Mono Light", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_CustasIpesp.ForeColor = Color.FromArgb(206, 212, 218);
            lbl_CustasIpesp.Location = new Point(0, 179);
            lbl_CustasIpesp.Name = "lbl_CustasIpesp";
            lbl_CustasIpesp.Size = new Size(130, 21);
            lbl_CustasIpesp.TabIndex = 5;
            lbl_CustasIpesp.Text = "Custas IPESP";
            // 
            // txtbox_DescricaoAto
            // 
            txtbox_DescricaoAto.AcceptsTab = true;
            txtbox_DescricaoAto.BackColor = Color.FromArgb(108, 117, 125);
            txtbox_DescricaoAto.BorderStyle = BorderStyle.None;
            txtbox_DescricaoAto.Cursor = Cursors.IBeam;
            txtbox_DescricaoAto.Font = new Font("JetBrains Mono Light", 11F);
            txtbox_DescricaoAto.ForeColor = Color.FromArgb(222, 226, 230);
            txtbox_DescricaoAto.Location = new Point(0, 156);
            txtbox_DescricaoAto.MaxLength = 127;
            txtbox_DescricaoAto.Name = "txtbox_DescricaoAto";
            txtbox_DescricaoAto.Size = new Size(210, 20);
            txtbox_DescricaoAto.TabIndex = 4;
            // 
            // lbl_DescricaoAto
            // 
            lbl_DescricaoAto.AutoSize = true;
            lbl_DescricaoAto.Font = new Font("JetBrains Mono Light", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_DescricaoAto.ForeColor = Color.FromArgb(206, 212, 218);
            lbl_DescricaoAto.Location = new Point(0, 132);
            lbl_DescricaoAto.Name = "lbl_DescricaoAto";
            lbl_DescricaoAto.Size = new Size(100, 21);
            lbl_DescricaoAto.TabIndex = 3;
            lbl_DescricaoAto.Text = "Descrição";
            // 
            // txtbox_CodigoAto
            // 
            txtbox_CodigoAto.AcceptsTab = true;
            txtbox_CodigoAto.BackColor = Color.FromArgb(108, 117, 125);
            txtbox_CodigoAto.BorderStyle = BorderStyle.None;
            txtbox_CodigoAto.Cursor = Cursors.IBeam;
            txtbox_CodigoAto.Font = new Font("JetBrains Mono Light", 11F);
            txtbox_CodigoAto.ForeColor = Color.FromArgb(222, 226, 230);
            txtbox_CodigoAto.Location = new Point(0, 109);
            txtbox_CodigoAto.MaxLength = 3;
            txtbox_CodigoAto.Name = "txtbox_CodigoAto";
            txtbox_CodigoAto.Size = new Size(40, 20);
            txtbox_CodigoAto.TabIndex = 2;
            // 
            // lbl_CodigoAto
            // 
            lbl_CodigoAto.AutoSize = true;
            lbl_CodigoAto.Font = new Font("JetBrains Mono Light", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_CodigoAto.ForeColor = Color.FromArgb(206, 212, 218);
            lbl_CodigoAto.Location = new Point(0, 85);
            lbl_CodigoAto.Name = "lbl_CodigoAto";
            lbl_CodigoAto.Size = new Size(140, 21);
            lbl_CodigoAto.TabIndex = 1;
            lbl_CodigoAto.Text = "Código do Ato";
            // 
            // lbl_Atos
            // 
            lbl_Atos.AutoSize = true;
            lbl_Atos.Dock = DockStyle.Top;
            lbl_Atos.Font = new Font("JetBrains Mono Light", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_Atos.ForeColor = Color.FromArgb(206, 212, 218);
            lbl_Atos.Location = new Point(0, 0);
            lbl_Atos.Name = "lbl_Atos";
            lbl_Atos.Size = new Size(50, 21);
            lbl_Atos.TabIndex = 0;
            lbl_Atos.Text = "Atos";
            // 
            // reciboProvisorioAtoBindingSource
            // 
            reciboProvisorioAtoBindingSource.DataSource = typeof(Models.ReciboProvisorioAto);
            // 
            // frm_Atos
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(73, 80, 87);
            ClientSize = new Size(784, 526);
            Controls.Add(pnl_EmissaoReciboProvisorio);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frm_Atos";
            Text = "frm_Atos";
            Load += frm_Atos_Load;
            pnl_EmissaoReciboProvisorio.ResumeLayout(false);
            pnl_EmissaoReciboProvisorio.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_Atos).EndInit();
            ((System.ComponentModel.ISupportInitialize)reciboProvisorioAtoBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnl_EmissaoReciboProvisorio;
        private Label lbl_Atos;
        private BindingSource reciboProvisorioAtoBindingSource;
        private Label lbl_CodigoAto;
        private Label lbl_CustasIpesp;
        private Label lbl_DescricaoAto;
        private TextBox txtbox_DescricaoAto;
        private TextBox txtbox_CodigoAto;
        private TextBox txtbox_CustasIpesp;
        private Button btn_CriarAto;
        private Button btn_Excluir;
        private DataGridView dgv_Atos;
        private TextBox txtbox_CustasOficial;
        private Label lbl_CustasOficial;
        private TextBox txtbox_CustasIss;
        private Label lbl_CustasIss;
    }
}