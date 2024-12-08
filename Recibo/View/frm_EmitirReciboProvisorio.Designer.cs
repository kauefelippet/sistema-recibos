namespace Recibo.View
{
    partial class frm_EmitirReciboProvisorio
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
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_EmitirReciboProvisorio));
            btn_EmissaoReciboProvisorio = new Button();
            btn_Recentes = new Button();
            btn_Consulta = new Button();
            pnl_EmissaoReciboProvisorio = new Panel();
            dgv_ReciboProvisorioAtos = new DataGridView();
            btn_Salvar = new Button();
            btn_Adicionar = new Button();
            txtbox_Quantidade = new TextBox();
            lbl_Quantidade = new Label();
            txtbox_Descricao = new TextBox();
            lbl_DescricaoAto = new Label();
            txtbox_CodigoAto = new TextBox();
            lbl_CodigoAto = new Label();
            txtbox_CPF = new TextBox();
            lbl_Cpf = new Label();
            txtbox_Requerente = new TextBox();
            lbl_Requerente = new Label();
            reciboProvisorioAtoBindingSource = new BindingSource(components);
            pnl_EmissaoReciboProvisorio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_ReciboProvisorioAtos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)reciboProvisorioAtoBindingSource).BeginInit();
            SuspendLayout();
            // 
            // btn_EmissaoReciboProvisorio
            // 
            btn_EmissaoReciboProvisorio.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btn_EmissaoReciboProvisorio.BackColor = Color.FromArgb(33, 37, 41);
            btn_EmissaoReciboProvisorio.BackgroundImageLayout = ImageLayout.None;
            btn_EmissaoReciboProvisorio.Cursor = Cursors.Hand;
            btn_EmissaoReciboProvisorio.FlatAppearance.BorderSize = 0;
            btn_EmissaoReciboProvisorio.FlatAppearance.MouseDownBackColor = Color.FromArgb(33, 37, 41);
            btn_EmissaoReciboProvisorio.FlatAppearance.MouseOverBackColor = Color.FromArgb(33, 37, 41);
            btn_EmissaoReciboProvisorio.FlatStyle = FlatStyle.Flat;
            btn_EmissaoReciboProvisorio.Font = new Font("JetBrains Mono Light", 12F);
            btn_EmissaoReciboProvisorio.ForeColor = Color.FromArgb(206, 212, 218);
            btn_EmissaoReciboProvisorio.ImageAlign = ContentAlignment.MiddleLeft;
            btn_EmissaoReciboProvisorio.Location = new Point(10, 10);
            btn_EmissaoReciboProvisorio.Margin = new Padding(5);
            btn_EmissaoReciboProvisorio.Name = "btn_EmissaoReciboProvisorio";
            btn_EmissaoReciboProvisorio.Size = new Size(100, 45);
            btn_EmissaoReciboProvisorio.TabIndex = 2;
            btn_EmissaoReciboProvisorio.Text = "EMISSÃO";
            btn_EmissaoReciboProvisorio.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_EmissaoReciboProvisorio.UseVisualStyleBackColor = false;
            btn_EmissaoReciboProvisorio.Click += btn_EmissaoReciboProvisorio_Click;
            // 
            // btn_Recentes
            // 
            btn_Recentes.BackColor = Color.FromArgb(52, 58, 64);
            btn_Recentes.BackgroundImageLayout = ImageLayout.None;
            btn_Recentes.Cursor = Cursors.Hand;
            btn_Recentes.FlatAppearance.BorderSize = 0;
            btn_Recentes.FlatAppearance.MouseDownBackColor = Color.FromArgb(73, 80, 87);
            btn_Recentes.FlatAppearance.MouseOverBackColor = Color.FromArgb(52, 58, 64);
            btn_Recentes.FlatStyle = FlatStyle.Flat;
            btn_Recentes.Font = new Font("JetBrains Mono Light", 12F);
            btn_Recentes.ForeColor = Color.FromArgb(206, 212, 218);
            btn_Recentes.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Recentes.Location = new Point(120, 10);
            btn_Recentes.Margin = new Padding(5);
            btn_Recentes.Name = "btn_Recentes";
            btn_Recentes.Size = new Size(100, 45);
            btn_Recentes.TabIndex = 3;
            btn_Recentes.Text = "RECENTES";
            btn_Recentes.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_Recentes.UseVisualStyleBackColor = false;
            // 
            // btn_Consulta
            // 
            btn_Consulta.BackColor = Color.FromArgb(52, 58, 64);
            btn_Consulta.BackgroundImageLayout = ImageLayout.None;
            btn_Consulta.Cursor = Cursors.Hand;
            btn_Consulta.FlatAppearance.BorderSize = 0;
            btn_Consulta.FlatAppearance.MouseDownBackColor = Color.FromArgb(73, 80, 87);
            btn_Consulta.FlatAppearance.MouseOverBackColor = Color.FromArgb(52, 58, 64);
            btn_Consulta.FlatStyle = FlatStyle.Flat;
            btn_Consulta.Font = new Font("JetBrains Mono Light", 12F);
            btn_Consulta.ForeColor = Color.FromArgb(206, 212, 218);
            btn_Consulta.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Consulta.Location = new Point(230, 10);
            btn_Consulta.Margin = new Padding(5);
            btn_Consulta.Name = "btn_Consulta";
            btn_Consulta.Size = new Size(100, 45);
            btn_Consulta.TabIndex = 4;
            btn_Consulta.Text = "CONSULTA";
            btn_Consulta.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_Consulta.UseVisualStyleBackColor = false;
            btn_Consulta.Click += button1_Click;
            // 
            // pnl_EmissaoReciboProvisorio
            // 
            pnl_EmissaoReciboProvisorio.Controls.Add(dgv_ReciboProvisorioAtos);
            pnl_EmissaoReciboProvisorio.Controls.Add(btn_Salvar);
            pnl_EmissaoReciboProvisorio.Controls.Add(btn_Adicionar);
            pnl_EmissaoReciboProvisorio.Controls.Add(txtbox_Quantidade);
            pnl_EmissaoReciboProvisorio.Controls.Add(lbl_Quantidade);
            pnl_EmissaoReciboProvisorio.Controls.Add(txtbox_Descricao);
            pnl_EmissaoReciboProvisorio.Controls.Add(lbl_DescricaoAto);
            pnl_EmissaoReciboProvisorio.Controls.Add(txtbox_CodigoAto);
            pnl_EmissaoReciboProvisorio.Controls.Add(lbl_CodigoAto);
            pnl_EmissaoReciboProvisorio.Controls.Add(txtbox_CPF);
            pnl_EmissaoReciboProvisorio.Controls.Add(lbl_Cpf);
            pnl_EmissaoReciboProvisorio.Controls.Add(txtbox_Requerente);
            pnl_EmissaoReciboProvisorio.Controls.Add(lbl_Requerente);
            pnl_EmissaoReciboProvisorio.Location = new Point(10, 63);
            pnl_EmissaoReciboProvisorio.Name = "pnl_EmissaoReciboProvisorio";
            pnl_EmissaoReciboProvisorio.Size = new Size(762, 451);
            pnl_EmissaoReciboProvisorio.TabIndex = 5;
            pnl_EmissaoReciboProvisorio.Paint += panel1_Paint;
            // 
            // dgv_ReciboProvisorioAtos
            // 
            dgv_ReciboProvisorioAtos.AllowUserToOrderColumns = true;
            dgv_ReciboProvisorioAtos.AllowUserToResizeRows = false;
            dgv_ReciboProvisorioAtos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_ReciboProvisorioAtos.BackgroundColor = Color.FromArgb(73, 80, 87);
            dgv_ReciboProvisorioAtos.BorderStyle = BorderStyle.None;
            dgv_ReciboProvisorioAtos.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgv_ReciboProvisorioAtos.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(108, 117, 125);
            dataGridViewCellStyle5.Font = new Font("JetBrains Mono Light", 9.75F);
            dataGridViewCellStyle5.ForeColor = Color.FromArgb(222, 226, 230);
            dataGridViewCellStyle5.SelectionBackColor = Color.OliveDrab;
            dataGridViewCellStyle5.SelectionForeColor = Color.FromArgb(222, 226, 230);
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dgv_ReciboProvisorioAtos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dgv_ReciboProvisorioAtos.ColumnHeadersHeight = 20;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(108, 117, 125);
            dataGridViewCellStyle6.Font = new Font("JetBrains Mono Light", 9.75F);
            dataGridViewCellStyle6.ForeColor = Color.FromArgb(222, 226, 230);
            dataGridViewCellStyle6.SelectionBackColor = Color.OliveDrab;
            dataGridViewCellStyle6.SelectionForeColor = Color.FromArgb(222, 226, 230);
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dgv_ReciboProvisorioAtos.DefaultCellStyle = dataGridViewCellStyle6;
            dgv_ReciboProvisorioAtos.Dock = DockStyle.Fill;
            dgv_ReciboProvisorioAtos.EnableHeadersVisualStyles = false;
            dgv_ReciboProvisorioAtos.Location = new Point(210, 62);
            dgv_ReciboProvisorioAtos.Name = "dgv_ReciboProvisorioAtos";
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle7.BackColor = Color.FromArgb(108, 117, 125);
            dataGridViewCellStyle7.Font = new Font("JetBrains Mono Light", 9.75F);
            dataGridViewCellStyle7.ForeColor = Color.FromArgb(222, 226, 230);
            dataGridViewCellStyle7.SelectionBackColor = Color.OliveDrab;
            dataGridViewCellStyle7.SelectionForeColor = Color.FromArgb(222, 226, 230);
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            dgv_ReciboProvisorioAtos.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dataGridViewCellStyle8.BackColor = Color.FromArgb(108, 117, 125);
            dataGridViewCellStyle8.Font = new Font("JetBrains Mono Light", 9.75F);
            dataGridViewCellStyle8.ForeColor = Color.FromArgb(222, 226, 230);
            dataGridViewCellStyle8.SelectionBackColor = Color.OliveDrab;
            dataGridViewCellStyle8.SelectionForeColor = Color.FromArgb(222, 226, 230);
            dgv_ReciboProvisorioAtos.RowsDefaultCellStyle = dataGridViewCellStyle8;
            dgv_ReciboProvisorioAtos.Size = new Size(552, 389);
            dgv_ReciboProvisorioAtos.TabIndex = 13;
            dgv_ReciboProvisorioAtos.CellContentClick += dgv_ReciboProvisorioAtos_CellContentClick;
            // 
            // btn_Salvar
            // 
            btn_Salvar.BackColor = Color.FromArgb(52, 58, 64);
            btn_Salvar.BackgroundImageLayout = ImageLayout.None;
            btn_Salvar.Cursor = Cursors.Hand;
            btn_Salvar.FlatAppearance.BorderSize = 0;
            btn_Salvar.FlatAppearance.MouseDownBackColor = Color.FromArgb(73, 80, 87);
            btn_Salvar.FlatAppearance.MouseOverBackColor = Color.FromArgb(52, 58, 64);
            btn_Salvar.FlatStyle = FlatStyle.Flat;
            btn_Salvar.Font = new Font("JetBrains Mono Light", 11F);
            btn_Salvar.ForeColor = Color.FromArgb(206, 212, 218);
            btn_Salvar.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Salvar.Location = new Point(0, 271);
            btn_Salvar.Margin = new Padding(5);
            btn_Salvar.Name = "btn_Salvar";
            btn_Salvar.Size = new Size(100, 30);
            btn_Salvar.TabIndex = 11;
            btn_Salvar.Text = "SALVAR";
            btn_Salvar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_Salvar.UseVisualStyleBackColor = false;
            btn_Salvar.Click += btn_Salvar_Click;
            // 
            // btn_Adicionar
            // 
            btn_Adicionar.BackColor = Color.FromArgb(52, 58, 64);
            btn_Adicionar.BackgroundImageLayout = ImageLayout.None;
            btn_Adicionar.Cursor = Cursors.Hand;
            btn_Adicionar.FlatAppearance.BorderSize = 0;
            btn_Adicionar.FlatAppearance.MouseDownBackColor = Color.FromArgb(73, 80, 87);
            btn_Adicionar.FlatAppearance.MouseOverBackColor = Color.FromArgb(52, 58, 64);
            btn_Adicionar.FlatStyle = FlatStyle.Flat;
            btn_Adicionar.Font = new Font("JetBrains Mono Light", 11F);
            btn_Adicionar.ForeColor = Color.FromArgb(206, 212, 218);
            btn_Adicionar.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Adicionar.Location = new Point(0, 231);
            btn_Adicionar.Margin = new Padding(5);
            btn_Adicionar.Name = "btn_Adicionar";
            btn_Adicionar.Size = new Size(100, 30);
            btn_Adicionar.TabIndex = 10;
            btn_Adicionar.Text = "ADICIONAR";
            btn_Adicionar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_Adicionar.UseVisualStyleBackColor = false;
            btn_Adicionar.Click += btn_Adicionar_Click;
            // 
            // txtbox_Quantidade
            // 
            txtbox_Quantidade.AcceptsTab = true;
            txtbox_Quantidade.BackColor = Color.FromArgb(108, 117, 125);
            txtbox_Quantidade.BorderStyle = BorderStyle.None;
            txtbox_Quantidade.Cursor = Cursors.IBeam;
            txtbox_Quantidade.Font = new Font("JetBrains Mono Light", 11F);
            txtbox_Quantidade.ForeColor = Color.FromArgb(222, 226, 230);
            txtbox_Quantidade.Location = new Point(0, 203);
            txtbox_Quantidade.MaxLength = 3;
            txtbox_Quantidade.Name = "txtbox_Quantidade";
            txtbox_Quantidade.Size = new Size(40, 20);
            txtbox_Quantidade.TabIndex = 9;
            // 
            // lbl_Quantidade
            // 
            lbl_Quantidade.AutoSize = true;
            lbl_Quantidade.Font = new Font("JetBrains Mono Light", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_Quantidade.ForeColor = Color.FromArgb(206, 212, 218);
            lbl_Quantidade.Location = new Point(0, 179);
            lbl_Quantidade.Name = "lbl_Quantidade";
            lbl_Quantidade.Size = new Size(110, 21);
            lbl_Quantidade.TabIndex = 8;
            lbl_Quantidade.Text = "Quantidade";
            // 
            // txtbox_Descricao
            // 
            txtbox_Descricao.AcceptsTab = true;
            txtbox_Descricao.BackColor = Color.FromArgb(108, 117, 125);
            txtbox_Descricao.BorderStyle = BorderStyle.None;
            txtbox_Descricao.Cursor = Cursors.IBeam;
            txtbox_Descricao.Font = new Font("JetBrains Mono Light", 11F);
            txtbox_Descricao.ForeColor = Color.FromArgb(222, 226, 230);
            txtbox_Descricao.Location = new Point(0, 156);
            txtbox_Descricao.MaxLength = 127;
            txtbox_Descricao.Name = "txtbox_Descricao";
            txtbox_Descricao.Size = new Size(210, 20);
            txtbox_Descricao.TabIndex = 7;
            // 
            // lbl_DescricaoAto
            // 
            lbl_DescricaoAto.AutoSize = true;
            lbl_DescricaoAto.Font = new Font("JetBrains Mono Light", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_DescricaoAto.ForeColor = Color.FromArgb(206, 212, 218);
            lbl_DescricaoAto.Location = new Point(0, 132);
            lbl_DescricaoAto.Name = "lbl_DescricaoAto";
            lbl_DescricaoAto.Size = new Size(100, 21);
            lbl_DescricaoAto.TabIndex = 6;
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
            txtbox_CodigoAto.TabIndex = 5;
            txtbox_CodigoAto.TextChanged += txtbox_CodigoAto_TextChanged;
            // 
            // lbl_CodigoAto
            // 
            lbl_CodigoAto.AutoSize = true;
            lbl_CodigoAto.Font = new Font("JetBrains Mono Light", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_CodigoAto.ForeColor = Color.FromArgb(206, 212, 218);
            lbl_CodigoAto.Location = new Point(0, 85);
            lbl_CodigoAto.Name = "lbl_CodigoAto";
            lbl_CodigoAto.Size = new Size(140, 21);
            lbl_CodigoAto.TabIndex = 4;
            lbl_CodigoAto.Text = "Código do Ato";
            lbl_CodigoAto.Click += label1_Click_1;
            // 
            // txtbox_CPF
            // 
            txtbox_CPF.AcceptsTab = true;
            txtbox_CPF.BackColor = Color.FromArgb(108, 117, 125);
            txtbox_CPF.BorderStyle = BorderStyle.None;
            txtbox_CPF.Cursor = Cursors.IBeam;
            txtbox_CPF.Dock = DockStyle.Left;
            txtbox_CPF.Font = new Font("JetBrains Mono Light", 11F);
            txtbox_CPF.ForeColor = Color.FromArgb(222, 226, 230);
            txtbox_CPF.Location = new Point(0, 62);
            txtbox_CPF.MaxLength = 11;
            txtbox_CPF.Name = "txtbox_CPF";
            txtbox_CPF.Size = new Size(210, 20);
            txtbox_CPF.TabIndex = 3;
            // 
            // lbl_Cpf
            // 
            lbl_Cpf.AutoSize = true;
            lbl_Cpf.Dock = DockStyle.Top;
            lbl_Cpf.Font = new Font("JetBrains Mono Light", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_Cpf.ForeColor = Color.FromArgb(206, 212, 218);
            lbl_Cpf.Location = new Point(0, 41);
            lbl_Cpf.Name = "lbl_Cpf";
            lbl_Cpf.Size = new Size(40, 21);
            lbl_Cpf.TabIndex = 2;
            lbl_Cpf.Text = "CPF";
            // 
            // txtbox_Requerente
            // 
            txtbox_Requerente.AcceptsTab = true;
            txtbox_Requerente.BackColor = Color.FromArgb(108, 117, 125);
            txtbox_Requerente.BorderStyle = BorderStyle.None;
            txtbox_Requerente.CharacterCasing = CharacterCasing.Upper;
            txtbox_Requerente.Cursor = Cursors.IBeam;
            txtbox_Requerente.Dock = DockStyle.Top;
            txtbox_Requerente.Font = new Font("JetBrains Mono Light", 11F);
            txtbox_Requerente.ForeColor = Color.FromArgb(222, 226, 230);
            txtbox_Requerente.Location = new Point(0, 21);
            txtbox_Requerente.MaxLength = 127;
            txtbox_Requerente.Name = "txtbox_Requerente";
            txtbox_Requerente.Size = new Size(762, 20);
            txtbox_Requerente.TabIndex = 1;
            txtbox_Requerente.TextChanged += txtbox_Requerente_TextChanged;
            // 
            // lbl_Requerente
            // 
            lbl_Requerente.AutoSize = true;
            lbl_Requerente.Dock = DockStyle.Top;
            lbl_Requerente.Font = new Font("JetBrains Mono Light", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_Requerente.ForeColor = Color.FromArgb(206, 212, 218);
            lbl_Requerente.Location = new Point(0, 0);
            lbl_Requerente.Name = "lbl_Requerente";
            lbl_Requerente.Size = new Size(110, 21);
            lbl_Requerente.TabIndex = 0;
            lbl_Requerente.Text = "Requerente";
            lbl_Requerente.Click += lbl_Requerente_Click;
            // 
            // reciboProvisorioAtoBindingSource
            // 
            reciboProvisorioAtoBindingSource.DataSource = typeof(Models.ReciboProvisorioAto);
            // 
            // frm_EmitirReciboProvisorio
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(73, 80, 87);
            ClientSize = new Size(784, 526);
            Controls.Add(pnl_EmissaoReciboProvisorio);
            Controls.Add(btn_Consulta);
            Controls.Add(btn_Recentes);
            Controls.Add(btn_EmissaoReciboProvisorio);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frm_EmitirReciboProvisorio";
            Text = "frm_EmitirReciboProvisorio";
            Load += frm_EmitirReciboProvisorio_Load;
            pnl_EmissaoReciboProvisorio.ResumeLayout(false);
            pnl_EmissaoReciboProvisorio.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_ReciboProvisorioAtos).EndInit();
            ((System.ComponentModel.ISupportInitialize)reciboProvisorioAtoBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btn_EmissaoReciboProvisorio;
        private Button btn_Recentes;
        private Button btn_Consulta;
        private Panel pnl_EmissaoReciboProvisorio;
        private Label lbl_Requerente;
        private Label lbl_Cpf;
        private TextBox txtbox_Requerente;
        private BindingSource reciboProvisorioAtoBindingSource;
        private TextBox txtbox_CPF;
        private Label lbl_CodigoAto;
        private Label lbl_Quantidade;
        private Label lbl_DescricaoAto;
        private TextBox txtbox_Descricao;
        private TextBox txtbox_CodigoAto;
        private TextBox txtbox_Quantidade;
        private Button btn_Adicionar;
        private Button btn_Salvar;
        private DataGridView dgv_ReciboProvisorioAtos;
    }
}