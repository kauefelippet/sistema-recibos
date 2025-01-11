namespace Recibo
{
    partial class Home
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            pnl_Principal = new Panel();
            btn_ReciboProvisorioConsulta = new Button();
            btn_ReciboProvisorioRecentes = new Button();
            lbl_ReciboProvisorio = new Label();
            btn_ReciboDefinitivoConsulta = new Button();
            btn_ReciboDefinitivoRecentes = new Button();
            lbl_ReciboDefinitivo = new Label();
            btn_Sair = new Button();
            btn_Atos = new Button();
            btn_ReciboProvisorio = new Button();
            btn_ReciboDefinitivo = new Button();
            pnl_Logo = new Panel();
            pic_Logo = new PictureBox();
            pnl_Form = new Panel();
            label1 = new Label();
            lbl_Home = new Label();
            pnl_Principal.SuspendLayout();
            pnl_Logo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pic_Logo).BeginInit();
            pnl_Form.SuspendLayout();
            SuspendLayout();
            // 
            // pnl_Principal
            // 
            pnl_Principal.BackColor = Color.FromArgb(108, 117, 125);
            pnl_Principal.Controls.Add(btn_ReciboProvisorioConsulta);
            pnl_Principal.Controls.Add(btn_ReciboProvisorioRecentes);
            pnl_Principal.Controls.Add(lbl_ReciboProvisorio);
            pnl_Principal.Controls.Add(btn_ReciboDefinitivoConsulta);
            pnl_Principal.Controls.Add(btn_ReciboDefinitivoRecentes);
            pnl_Principal.Controls.Add(lbl_ReciboDefinitivo);
            pnl_Principal.Controls.Add(btn_Sair);
            pnl_Principal.Controls.Add(btn_Atos);
            pnl_Principal.Controls.Add(btn_ReciboProvisorio);
            pnl_Principal.Controls.Add(btn_ReciboDefinitivo);
            pnl_Principal.Controls.Add(pnl_Logo);
            pnl_Principal.Dock = DockStyle.Left;
            pnl_Principal.Location = new Point(0, 0);
            pnl_Principal.Name = "pnl_Principal";
            pnl_Principal.Size = new Size(200, 526);
            pnl_Principal.TabIndex = 0;
            // 
            // btn_ReciboProvisorioConsulta
            // 
            btn_ReciboProvisorioConsulta.BackColor = Color.FromArgb(73, 80, 87);
            btn_ReciboProvisorioConsulta.BackgroundImageLayout = ImageLayout.None;
            btn_ReciboProvisorioConsulta.Cursor = Cursors.Hand;
            btn_ReciboProvisorioConsulta.FlatAppearance.BorderSize = 0;
            btn_ReciboProvisorioConsulta.FlatAppearance.MouseDownBackColor = Color.FromArgb(73, 80, 87);
            btn_ReciboProvisorioConsulta.FlatAppearance.MouseOverBackColor = Color.FromArgb(52, 58, 64);
            btn_ReciboProvisorioConsulta.FlatStyle = FlatStyle.Flat;
            btn_ReciboProvisorioConsulta.Font = new Font("JetBrains Mono Light", 12F);
            btn_ReciboProvisorioConsulta.ForeColor = Color.FromArgb(206, 212, 218);
            btn_ReciboProvisorioConsulta.ImageAlign = ContentAlignment.MiddleLeft;
            btn_ReciboProvisorioConsulta.Location = new Point(0, 363);
            btn_ReciboProvisorioConsulta.Name = "btn_ReciboProvisorioConsulta";
            btn_ReciboProvisorioConsulta.Size = new Size(200, 45);
            btn_ReciboProvisorioConsulta.TabIndex = 10;
            btn_ReciboProvisorioConsulta.Text = "CONSULTA";
            btn_ReciboProvisorioConsulta.TextAlign = ContentAlignment.MiddleLeft;
            btn_ReciboProvisorioConsulta.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_ReciboProvisorioConsulta.UseVisualStyleBackColor = false;
            // 
            // btn_ReciboProvisorioRecentes
            // 
            btn_ReciboProvisorioRecentes.BackColor = Color.FromArgb(73, 80, 87);
            btn_ReciboProvisorioRecentes.BackgroundImageLayout = ImageLayout.None;
            btn_ReciboProvisorioRecentes.Cursor = Cursors.Hand;
            btn_ReciboProvisorioRecentes.FlatAppearance.BorderSize = 0;
            btn_ReciboProvisorioRecentes.FlatAppearance.MouseDownBackColor = Color.FromArgb(73, 80, 87);
            btn_ReciboProvisorioRecentes.FlatAppearance.MouseOverBackColor = Color.FromArgb(52, 58, 64);
            btn_ReciboProvisorioRecentes.FlatStyle = FlatStyle.Flat;
            btn_ReciboProvisorioRecentes.Font = new Font("JetBrains Mono Light", 12F);
            btn_ReciboProvisorioRecentes.ForeColor = Color.FromArgb(206, 212, 218);
            btn_ReciboProvisorioRecentes.ImageAlign = ContentAlignment.MiddleLeft;
            btn_ReciboProvisorioRecentes.Location = new Point(0, 312);
            btn_ReciboProvisorioRecentes.Name = "btn_ReciboProvisorioRecentes";
            btn_ReciboProvisorioRecentes.Size = new Size(200, 45);
            btn_ReciboProvisorioRecentes.TabIndex = 9;
            btn_ReciboProvisorioRecentes.Text = "RECENTES";
            btn_ReciboProvisorioRecentes.TextAlign = ContentAlignment.MiddleLeft;
            btn_ReciboProvisorioRecentes.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_ReciboProvisorioRecentes.UseVisualStyleBackColor = false;
            btn_ReciboProvisorioRecentes.Click += btn_ReciboProvisorioRecentes_Click;
            // 
            // lbl_ReciboProvisorio
            // 
            lbl_ReciboProvisorio.AutoSize = true;
            lbl_ReciboProvisorio.Font = new Font("JetBrains Mono", 12F, FontStyle.Bold);
            lbl_ReciboProvisorio.ForeColor = Color.FromArgb(206, 212, 218);
            lbl_ReciboProvisorio.Location = new Point(12, 237);
            lbl_ReciboProvisorio.Name = "lbl_ReciboProvisorio";
            lbl_ReciboProvisorio.Size = new Size(180, 21);
            lbl_ReciboProvisorio.TabIndex = 8;
            lbl_ReciboProvisorio.Text = "RECIBO PROVISÓRIO";
            // 
            // btn_ReciboDefinitivoConsulta
            // 
            btn_ReciboDefinitivoConsulta.BackColor = Color.FromArgb(73, 80, 87);
            btn_ReciboDefinitivoConsulta.BackgroundImageLayout = ImageLayout.None;
            btn_ReciboDefinitivoConsulta.Cursor = Cursors.Hand;
            btn_ReciboDefinitivoConsulta.FlatAppearance.BorderSize = 0;
            btn_ReciboDefinitivoConsulta.FlatAppearance.MouseDownBackColor = Color.FromArgb(73, 80, 87);
            btn_ReciboDefinitivoConsulta.FlatAppearance.MouseOverBackColor = Color.FromArgb(52, 58, 64);
            btn_ReciboDefinitivoConsulta.FlatStyle = FlatStyle.Flat;
            btn_ReciboDefinitivoConsulta.Font = new Font("JetBrains Mono Light", 12F);
            btn_ReciboDefinitivoConsulta.ForeColor = Color.FromArgb(206, 212, 218);
            btn_ReciboDefinitivoConsulta.ImageAlign = ContentAlignment.MiddleLeft;
            btn_ReciboDefinitivoConsulta.Location = new Point(0, 189);
            btn_ReciboDefinitivoConsulta.Name = "btn_ReciboDefinitivoConsulta";
            btn_ReciboDefinitivoConsulta.Size = new Size(200, 45);
            btn_ReciboDefinitivoConsulta.TabIndex = 7;
            btn_ReciboDefinitivoConsulta.Text = "CONSULTA";
            btn_ReciboDefinitivoConsulta.TextAlign = ContentAlignment.MiddleLeft;
            btn_ReciboDefinitivoConsulta.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_ReciboDefinitivoConsulta.UseVisualStyleBackColor = false;
            // 
            // btn_ReciboDefinitivoRecentes
            // 
            btn_ReciboDefinitivoRecentes.BackColor = Color.FromArgb(73, 80, 87);
            btn_ReciboDefinitivoRecentes.BackgroundImageLayout = ImageLayout.None;
            btn_ReciboDefinitivoRecentes.Cursor = Cursors.Hand;
            btn_ReciboDefinitivoRecentes.FlatAppearance.BorderSize = 0;
            btn_ReciboDefinitivoRecentes.FlatAppearance.MouseDownBackColor = Color.FromArgb(73, 80, 87);
            btn_ReciboDefinitivoRecentes.FlatAppearance.MouseOverBackColor = Color.FromArgb(52, 58, 64);
            btn_ReciboDefinitivoRecentes.FlatStyle = FlatStyle.Flat;
            btn_ReciboDefinitivoRecentes.Font = new Font("JetBrains Mono Light", 12F);
            btn_ReciboDefinitivoRecentes.ForeColor = Color.FromArgb(206, 212, 218);
            btn_ReciboDefinitivoRecentes.ImageAlign = ContentAlignment.MiddleLeft;
            btn_ReciboDefinitivoRecentes.Location = new Point(0, 138);
            btn_ReciboDefinitivoRecentes.Name = "btn_ReciboDefinitivoRecentes";
            btn_ReciboDefinitivoRecentes.Size = new Size(200, 45);
            btn_ReciboDefinitivoRecentes.TabIndex = 6;
            btn_ReciboDefinitivoRecentes.Text = "RECENTES";
            btn_ReciboDefinitivoRecentes.TextAlign = ContentAlignment.MiddleLeft;
            btn_ReciboDefinitivoRecentes.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_ReciboDefinitivoRecentes.UseVisualStyleBackColor = false;
            // 
            // lbl_ReciboDefinitivo
            // 
            lbl_ReciboDefinitivo.AutoSize = true;
            lbl_ReciboDefinitivo.Font = new Font("JetBrains Mono", 12F, FontStyle.Bold);
            lbl_ReciboDefinitivo.ForeColor = Color.FromArgb(206, 212, 218);
            lbl_ReciboDefinitivo.Location = new Point(12, 63);
            lbl_ReciboDefinitivo.Name = "lbl_ReciboDefinitivo";
            lbl_ReciboDefinitivo.Size = new Size(180, 21);
            lbl_ReciboDefinitivo.TabIndex = 5;
            lbl_ReciboDefinitivo.Text = "RECIBO DEFINITIVO";
            // 
            // btn_Sair
            // 
            btn_Sair.BackColor = Color.FromArgb(73, 80, 87);
            btn_Sair.BackgroundImageLayout = ImageLayout.None;
            btn_Sair.Cursor = Cursors.Hand;
            btn_Sair.FlatAppearance.BorderSize = 0;
            btn_Sair.FlatAppearance.MouseDownBackColor = Color.FromArgb(73, 80, 87);
            btn_Sair.FlatAppearance.MouseOverBackColor = Color.FromArgb(52, 58, 64);
            btn_Sair.FlatStyle = FlatStyle.Flat;
            btn_Sair.Font = new Font("JetBrains Mono Light", 12F);
            btn_Sair.ForeColor = Color.FromArgb(206, 212, 218);
            btn_Sair.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Sair.Location = new Point(0, 478);
            btn_Sair.Name = "btn_Sair";
            btn_Sair.Size = new Size(200, 45);
            btn_Sair.TabIndex = 4;
            btn_Sair.Text = "SAIR";
            btn_Sair.TextAlign = ContentAlignment.MiddleLeft;
            btn_Sair.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_Sair.UseVisualStyleBackColor = false;
            btn_Sair.Click += btn_Sair_Click;
            // 
            // btn_Atos
            // 
            btn_Atos.BackColor = Color.FromArgb(73, 80, 87);
            btn_Atos.BackgroundImageLayout = ImageLayout.None;
            btn_Atos.Cursor = Cursors.Hand;
            btn_Atos.FlatAppearance.BorderSize = 0;
            btn_Atos.FlatAppearance.MouseDownBackColor = Color.FromArgb(73, 80, 87);
            btn_Atos.FlatAppearance.MouseOverBackColor = Color.FromArgb(52, 58, 64);
            btn_Atos.FlatStyle = FlatStyle.Flat;
            btn_Atos.Font = new Font("JetBrains Mono Light", 12F);
            btn_Atos.ForeColor = Color.FromArgb(206, 212, 218);
            btn_Atos.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Atos.Location = new Point(0, 427);
            btn_Atos.Name = "btn_Atos";
            btn_Atos.Size = new Size(200, 45);
            btn_Atos.TabIndex = 3;
            btn_Atos.Text = "ATOS";
            btn_Atos.TextAlign = ContentAlignment.MiddleLeft;
            btn_Atos.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_Atos.UseVisualStyleBackColor = false;
            btn_Atos.Click += btn_Atos_Click;
            // 
            // btn_ReciboProvisorio
            // 
            btn_ReciboProvisorio.BackColor = Color.FromArgb(73, 80, 87);
            btn_ReciboProvisorio.BackgroundImageLayout = ImageLayout.None;
            btn_ReciboProvisorio.Cursor = Cursors.Hand;
            btn_ReciboProvisorio.FlatAppearance.BorderSize = 0;
            btn_ReciboProvisorio.FlatAppearance.MouseDownBackColor = Color.FromArgb(73, 80, 87);
            btn_ReciboProvisorio.FlatAppearance.MouseOverBackColor = Color.FromArgb(52, 58, 64);
            btn_ReciboProvisorio.FlatStyle = FlatStyle.Flat;
            btn_ReciboProvisorio.Font = new Font("JetBrains Mono Light", 12F);
            btn_ReciboProvisorio.ForeColor = Color.FromArgb(206, 212, 218);
            btn_ReciboProvisorio.ImageAlign = ContentAlignment.MiddleLeft;
            btn_ReciboProvisorio.Location = new Point(0, 261);
            btn_ReciboProvisorio.Name = "btn_ReciboProvisorio";
            btn_ReciboProvisorio.Size = new Size(200, 45);
            btn_ReciboProvisorio.TabIndex = 2;
            btn_ReciboProvisorio.Text = "EMISSÃO";
            btn_ReciboProvisorio.TextAlign = ContentAlignment.MiddleLeft;
            btn_ReciboProvisorio.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_ReciboProvisorio.UseVisualStyleBackColor = false;
            btn_ReciboProvisorio.Click += btn_ReciboProvisorio_Click;
            // 
            // btn_ReciboDefinitivo
            // 
            btn_ReciboDefinitivo.BackColor = Color.FromArgb(73, 80, 87);
            btn_ReciboDefinitivo.BackgroundImageLayout = ImageLayout.None;
            btn_ReciboDefinitivo.Cursor = Cursors.Hand;
            btn_ReciboDefinitivo.FlatAppearance.BorderSize = 0;
            btn_ReciboDefinitivo.FlatAppearance.MouseDownBackColor = Color.FromArgb(73, 80, 87);
            btn_ReciboDefinitivo.FlatAppearance.MouseOverBackColor = Color.FromArgb(52, 58, 64);
            btn_ReciboDefinitivo.FlatStyle = FlatStyle.Flat;
            btn_ReciboDefinitivo.Font = new Font("JetBrains Mono Light", 12F);
            btn_ReciboDefinitivo.ForeColor = Color.FromArgb(206, 212, 218);
            btn_ReciboDefinitivo.ImageAlign = ContentAlignment.MiddleLeft;
            btn_ReciboDefinitivo.Location = new Point(0, 87);
            btn_ReciboDefinitivo.Name = "btn_ReciboDefinitivo";
            btn_ReciboDefinitivo.Size = new Size(200, 45);
            btn_ReciboDefinitivo.TabIndex = 1;
            btn_ReciboDefinitivo.Text = "EMISSÃO";
            btn_ReciboDefinitivo.TextAlign = ContentAlignment.MiddleLeft;
            btn_ReciboDefinitivo.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_ReciboDefinitivo.UseVisualStyleBackColor = false;
            btn_ReciboDefinitivo.Click += btn_ReciboDefinitivo_Click;
            // 
            // pnl_Logo
            // 
            pnl_Logo.BackColor = Color.FromArgb(108, 117, 125);
            pnl_Logo.Controls.Add(pic_Logo);
            pnl_Logo.Dock = DockStyle.Top;
            pnl_Logo.Location = new Point(0, 0);
            pnl_Logo.Name = "pnl_Logo";
            pnl_Logo.Size = new Size(200, 60);
            pnl_Logo.TabIndex = 0;
            // 
            // pic_Logo
            // 
            pic_Logo.Cursor = Cursors.Hand;
            pic_Logo.Dock = DockStyle.Fill;
            pic_Logo.Image = (Image)resources.GetObject("pic_Logo.Image");
            pic_Logo.Location = new Point(0, 0);
            pic_Logo.Name = "pic_Logo";
            pic_Logo.Size = new Size(200, 60);
            pic_Logo.SizeMode = PictureBoxSizeMode.Zoom;
            pic_Logo.TabIndex = 0;
            pic_Logo.TabStop = false;
            pic_Logo.Click += pic_Logo_Click;
            // 
            // pnl_Form
            // 
            pnl_Form.BackColor = Color.FromArgb(108, 117, 125);
            pnl_Form.Controls.Add(label1);
            pnl_Form.Controls.Add(lbl_Home);
            pnl_Form.Dock = DockStyle.Fill;
            pnl_Form.Location = new Point(200, 0);
            pnl_Form.Name = "pnl_Form";
            pnl_Form.Size = new Size(784, 526);
            pnl_Form.TabIndex = 1;
            pnl_Form.Paint += pnl_Form_Paint;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("JetBrains Mono ExtraLight", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(52, 58, 64);
            label1.ImageAlign = ContentAlignment.TopCenter;
            label1.Location = new Point(515, 508);
            label1.Name = "label1";
            label1.Size = new Size(269, 18);
            label1.TabIndex = 1;
            label1.Text = "Sistema de emissão de recibos";
            label1.TextAlign = ContentAlignment.MiddleRight;
            label1.Click += label1_Click;
            // 
            // lbl_Home
            // 
            lbl_Home.Dock = DockStyle.Top;
            lbl_Home.FlatStyle = FlatStyle.Flat;
            lbl_Home.Font = new Font("JetBrains Mono Medium", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_Home.ForeColor = Color.FromArgb(52, 58, 64);
            lbl_Home.ImageAlign = ContentAlignment.TopCenter;
            lbl_Home.Location = new Point(0, 0);
            lbl_Home.Name = "lbl_Home";
            lbl_Home.Size = new Size(784, 62);
            lbl_Home.TabIndex = 0;
            lbl_Home.Text = "Oficial de Registro Civil das Pessoas Naturais e de Interdições e Tutelas de Itu";
            lbl_Home.TextAlign = ContentAlignment.TopCenter;
            lbl_Home.Click += lbl_Home_Click;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(206, 212, 218);
            ClientSize = new Size(984, 526);
            Controls.Add(pnl_Form);
            Controls.Add(pnl_Principal);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Home";
            Text = "Recibos";
            Load += Recibo_Load;
            pnl_Principal.ResumeLayout(false);
            pnl_Principal.PerformLayout();
            pnl_Logo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pic_Logo).EndInit();
            pnl_Form.ResumeLayout(false);
            pnl_Form.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnl_Principal;
        private Panel pnl_Logo;
        private Button btn_ReciboDefinitivo;
        private PictureBox pic_Logo;
        private Button btn_Atos;
        private Button btn_ReciboProvisorio;
        private Panel pnl_Form;
        private Label lbl_Home;
        private Label label1;
        private Button btn_Sair;
        private Label lbl_ReciboProvisorio;
        private Button btn_ReciboDefinitivoConsulta;
        private Button btn_ReciboDefinitivoRecentes;
        private Label lbl_ReciboDefinitivo;
        private Button btn_ReciboProvisorioConsulta;
        private Button btn_ReciboProvisorioRecentes;
    }
}
