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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_EmitirReciboProvisorio));
            btn_EmissaoReciboProvisorio = new Button();
            btn_Recentes = new Button();
            btn_Consulta = new Button();
            pnl_EmissaoReciboProvisorio = new Panel();
            lbl_ValorQuantidade = new Label();
            lbl_TotalRecibo = new Label();
            lbl_NomeAto = new Label();
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
            lbl_IdRecibo = new Label();
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
            // 
            // pnl_EmissaoReciboProvisorio
            // 
            pnl_EmissaoReciboProvisorio.Controls.Add(lbl_ValorQuantidade);
            pnl_EmissaoReciboProvisorio.Controls.Add(lbl_TotalRecibo);
            pnl_EmissaoReciboProvisorio.Controls.Add(lbl_NomeAto);
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
            // 
            // lbl_ValorQuantidade
            // 
            lbl_ValorQuantidade.Anchor = AnchorStyles.Left;
            lbl_ValorQuantidade.Font = new Font("JetBrains Mono Light", 9F);
            lbl_ValorQuantidade.ForeColor = Color.FromArgb(206, 212, 218);
            lbl_ValorQuantidade.Location = new Point(42, 204);
            lbl_ValorQuantidade.Name = "lbl_ValorQuantidade";
            lbl_ValorQuantidade.Size = new Size(168, 21);
            lbl_ValorQuantidade.TabIndex = 16;
            // 
            // lbl_TotalRecibo
            // 
            lbl_TotalRecibo.AutoSize = true;
            lbl_TotalRecibo.Font = new Font("JetBrains Mono Light", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_TotalRecibo.ForeColor = Color.FromArgb(206, 212, 218);
            lbl_TotalRecibo.Location = new Point(0, 315);
            lbl_TotalRecibo.Name = "lbl_TotalRecibo";
            lbl_TotalRecibo.Size = new Size(150, 21);
            lbl_TotalRecibo.TabIndex = 15;
            lbl_TotalRecibo.Text = "Total: R$ 0,00";
            // 
            // lbl_NomeAto
            // 
            lbl_NomeAto.Anchor = AnchorStyles.Left;
            lbl_NomeAto.Font = new Font("JetBrains Mono Light", 9F);
            lbl_NomeAto.ForeColor = Color.FromArgb(206, 212, 218);
            lbl_NomeAto.Location = new Point(42, 111);
            lbl_NomeAto.Name = "lbl_NomeAto";
            lbl_NomeAto.Size = new Size(168, 21);
            lbl_NomeAto.TabIndex = 14;
            // 
            // dgv_ReciboProvisorioAtos
            // 
            dgv_ReciboProvisorioAtos.AccessibleRole = AccessibleRole.List;
            dgv_ReciboProvisorioAtos.AllowUserToAddRows = false;
            dgv_ReciboProvisorioAtos.AllowUserToDeleteRows = false;
            dgv_ReciboProvisorioAtos.AllowUserToResizeRows = false;
            dgv_ReciboProvisorioAtos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_ReciboProvisorioAtos.BackgroundColor = Color.FromArgb(73, 80, 87);
            dgv_ReciboProvisorioAtos.BorderStyle = BorderStyle.None;
            dgv_ReciboProvisorioAtos.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgv_ReciboProvisorioAtos.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(108, 117, 125);
            dataGridViewCellStyle1.Font = new Font("JetBrains Mono Light", 9.75F);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(222, 226, 230);
            dataGridViewCellStyle1.SelectionBackColor = Color.OliveDrab;
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(222, 226, 230);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgv_ReciboProvisorioAtos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgv_ReciboProvisorioAtos.ColumnHeadersHeight = 20;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(108, 117, 125);
            dataGridViewCellStyle2.Font = new Font("JetBrains Mono Light", 9.75F);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(222, 226, 230);
            dataGridViewCellStyle2.SelectionBackColor = Color.OliveDrab;
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(222, 226, 230);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgv_ReciboProvisorioAtos.DefaultCellStyle = dataGridViewCellStyle2;
            dgv_ReciboProvisorioAtos.Dock = DockStyle.Fill;
            dgv_ReciboProvisorioAtos.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgv_ReciboProvisorioAtos.EnableHeadersVisualStyles = false;
            dgv_ReciboProvisorioAtos.ImeMode = ImeMode.Off;
            dgv_ReciboProvisorioAtos.Location = new Point(210, 62);
            dgv_ReciboProvisorioAtos.Name = "dgv_ReciboProvisorioAtos";
            dgv_ReciboProvisorioAtos.ReadOnly = true;
            dgv_ReciboProvisorioAtos.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(108, 117, 125);
            dataGridViewCellStyle3.Font = new Font("JetBrains Mono Light", 9.75F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(222, 226, 230);
            dataGridViewCellStyle3.SelectionBackColor = Color.OliveDrab;
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(222, 226, 230);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgv_ReciboProvisorioAtos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgv_ReciboProvisorioAtos.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(108, 117, 125);
            dataGridViewCellStyle4.Font = new Font("JetBrains Mono Light", 9.75F);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(222, 226, 230);
            dataGridViewCellStyle4.SelectionBackColor = Color.OliveDrab;
            dataGridViewCellStyle4.SelectionForeColor = Color.FromArgb(222, 226, 230);
            dgv_ReciboProvisorioAtos.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dgv_ReciboProvisorioAtos.Size = new Size(552, 389);
            dgv_ReciboProvisorioAtos.TabIndex = 13;
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
            txtbox_Quantidade.TextChanged += txtbox_Quantidade_TextChanged;
            txtbox_Quantidade.KeyPress += txtbox_Quantidade_KeyPress;
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
            txtbox_CPF.MaxLength = 14;
            txtbox_CPF.Name = "txtbox_CPF";
            txtbox_CPF.Size = new Size(210, 20);
            txtbox_CPF.TabIndex = 3;
            txtbox_CPF.TextChanged += txtbox_CPF_TextChanged;
            txtbox_CPF.KeyPress += txtbox_CPF_KeyPress;
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
            // 
            // reciboProvisorioAtoBindingSource
            // 
            reciboProvisorioAtoBindingSource.DataSource = typeof(Models.ReciboProvisorioAto);
            // 
            // lbl_IdRecibo
            // 
            lbl_IdRecibo.AutoSize = true;
            lbl_IdRecibo.Font = new Font("JetBrains Mono Light", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_IdRecibo.ForeColor = Color.FromArgb(206, 212, 218);
            lbl_IdRecibo.Location = new Point(590, 22);
            lbl_IdRecibo.Name = "lbl_IdRecibo";
            lbl_IdRecibo.Size = new Size(100, 21);
            lbl_IdRecibo.TabIndex = 14;
            lbl_IdRecibo.Text = "Recibo nº";
            // 
            // frm_EmitirReciboProvisorio
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(73, 80, 87);
            ClientSize = new Size(784, 526);
            Controls.Add(lbl_IdRecibo);
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
            PerformLayout();
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
        private Label lbl_IdRecibo;
        private Label lbl_NomeAto;
        private Label lbl_TotalRecibo;
        private Label lbl_ValorQuantidade;
    }
}