namespace Recibo.View
{
    partial class frm_ConsultarReciboProvisorio
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
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_ConsultarReciboProvisorio));
            pnl_RecentesReciboProvisorio = new Panel();
            dateTimePicker_Data = new Util.CustomDateTimePicker();
            dgv_RecibosProvisorios = new DataGridView();
            btn_Imprimir = new Button();
            btn_Buscar = new Button();
            txtbox_ID = new TextBox();
            txtbox_CPF = new TextBox();
            textBox1 = new TextBox();
            txtbox_Requerente = new TextBox();
            lbl_Data = new Label();
            lbl_ID = new Label();
            lbl_CPF = new Label();
            lbl_Requerente = new Label();
            dgv_RecibosProvisoriosAtos = new DataGridView();
            reciboProvisorioAtoBindingSource = new BindingSource(components);
            pnl_RecentesReciboProvisorio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_RecibosProvisorios).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgv_RecibosProvisoriosAtos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)reciboProvisorioAtoBindingSource).BeginInit();
            SuspendLayout();
            // 
            // pnl_RecentesReciboProvisorio
            // 
            pnl_RecentesReciboProvisorio.Controls.Add(dateTimePicker_Data);
            pnl_RecentesReciboProvisorio.Controls.Add(dgv_RecibosProvisorios);
            pnl_RecentesReciboProvisorio.Controls.Add(btn_Imprimir);
            pnl_RecentesReciboProvisorio.Controls.Add(btn_Buscar);
            pnl_RecentesReciboProvisorio.Controls.Add(txtbox_ID);
            pnl_RecentesReciboProvisorio.Controls.Add(txtbox_CPF);
            pnl_RecentesReciboProvisorio.Controls.Add(textBox1);
            pnl_RecentesReciboProvisorio.Controls.Add(txtbox_Requerente);
            pnl_RecentesReciboProvisorio.Controls.Add(lbl_Data);
            pnl_RecentesReciboProvisorio.Controls.Add(lbl_ID);
            pnl_RecentesReciboProvisorio.Controls.Add(lbl_CPF);
            pnl_RecentesReciboProvisorio.Controls.Add(lbl_Requerente);
            pnl_RecentesReciboProvisorio.Controls.Add(dgv_RecibosProvisoriosAtos);
            pnl_RecentesReciboProvisorio.Location = new Point(10, 12);
            pnl_RecentesReciboProvisorio.Name = "pnl_RecentesReciboProvisorio";
            pnl_RecentesReciboProvisorio.Size = new Size(762, 502);
            pnl_RecentesReciboProvisorio.TabIndex = 5;
            // 
            // dateTimePicker_Data
            // 
            this.dateTimePicker_Data.BackColor = Color.FromArgb(108, 117, 125);
            this.dateTimePicker_Data.CalendarFont = new Font("JetBrains Mono", 10F);
            this.dateTimePicker_Data.CalendarForeColor = Color.FromArgb(206, 212, 218);
            this.dateTimePicker_Data.CalendarMonthBackground = Color.FromArgb(108, 117, 125);
            this.dateTimePicker_Data.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker_Data.Font = new Font("JetBrains Mono", 9F);
            this.dateTimePicker_Data.ForeColor = Color.FromArgb(206, 212, 218);
            this.dateTimePicker_Data.Format = DateTimePickerFormat.Short;
            this.dateTimePicker_Data.Location = new Point(53, 42);
            this.dateTimePicker_Data.Name = "dateTimePicker_Data";
            this.dateTimePicker_Data.ShowCheckBox = true;
            this.dateTimePicker_Data.Size = new Size(181, 23);
            this.dateTimePicker_Data.TabIndex = 4;
            this.dateTimePicker_Data.ValueChanged += new System.EventHandler(this.dateTimePicker_Data_ValueChanged);
            // 
            // dgv_RecibosProvisorios
            // 
            dgv_RecibosProvisorios.AccessibleRole = AccessibleRole.List;
            dgv_RecibosProvisorios.AllowUserToAddRows = false;
            dgv_RecibosProvisorios.AllowUserToDeleteRows = false;
            dgv_RecibosProvisorios.AllowUserToResizeRows = false;
            dgv_RecibosProvisorios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_RecibosProvisorios.BackgroundColor = Color.FromArgb(73, 80, 87);
            dgv_RecibosProvisorios.BorderStyle = BorderStyle.None;
            dgv_RecibosProvisorios.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgv_RecibosProvisorios.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(108, 117, 125);
            dataGridViewCellStyle1.Font = new Font("JetBrains Mono Light", 9.75F);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(222, 226, 230);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(173, 181, 189);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(222, 226, 230);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgv_RecibosProvisorios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgv_RecibosProvisorios.ColumnHeadersHeight = 20;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(108, 117, 125);
            dataGridViewCellStyle2.Font = new Font("JetBrains Mono Light", 9.75F);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(222, 226, 230);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(173, 181, 189);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(222, 226, 230);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgv_RecibosProvisorios.DefaultCellStyle = dataGridViewCellStyle2;
            dgv_RecibosProvisorios.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgv_RecibosProvisorios.EnableHeadersVisualStyles = false;
            dgv_RecibosProvisorios.ImeMode = ImeMode.Off;
            dgv_RecibosProvisorios.Location = new Point(0, 71);
            dgv_RecibosProvisorios.MultiSelect = false;
            dgv_RecibosProvisorios.Name = "dgv_RecibosProvisorios";
            dgv_RecibosProvisorios.ReadOnly = true;
            dgv_RecibosProvisorios.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(108, 117, 125);
            dataGridViewCellStyle3.Font = new Font("JetBrains Mono Light", 9.75F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(222, 226, 230);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(173, 181, 189);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(222, 226, 230);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgv_RecibosProvisorios.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgv_RecibosProvisorios.RowHeadersVisible = false;
            dgv_RecibosProvisorios.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(108, 117, 125);
            dataGridViewCellStyle4.Font = new Font("JetBrains Mono Light", 9.75F);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(222, 226, 230);
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(173, 181, 189);
            dataGridViewCellStyle4.SelectionForeColor = Color.FromArgb(222, 226, 230);
            dgv_RecibosProvisorios.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dgv_RecibosProvisorios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_RecibosProvisorios.Size = new Size(762, 192);
            dgv_RecibosProvisorios.TabIndex = 7;
            dgv_RecibosProvisorios.CellClick += dgv_RecibosProvisorios_CellClick;
            // 
            // btn_Imprimir
            // 
            btn_Imprimir.BackColor = Color.FromArgb(52, 58, 64);
            btn_Imprimir.BackgroundImageLayout = ImageLayout.None;
            btn_Imprimir.Cursor = Cursors.Hand;
            btn_Imprimir.FlatAppearance.BorderSize = 0;
            btn_Imprimir.FlatAppearance.MouseDownBackColor = Color.FromArgb(73, 80, 87);
            btn_Imprimir.FlatAppearance.MouseOverBackColor = Color.FromArgb(52, 58, 64);
            btn_Imprimir.FlatStyle = FlatStyle.Flat;
            btn_Imprimir.Font = new Font("JetBrains Mono Light", 11F);
            btn_Imprimir.ForeColor = Color.FromArgb(206, 212, 218);
            btn_Imprimir.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Imprimir.Location = new Point(352, 21);
            btn_Imprimir.Margin = new Padding(5);
            btn_Imprimir.Name = "btn_Imprimir";
            btn_Imprimir.Size = new Size(100, 44);
            btn_Imprimir.TabIndex = 6;
            btn_Imprimir.Text = "IMPRIMIR";
            btn_Imprimir.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_Imprimir.UseVisualStyleBackColor = false;
            // 
            // btn_Buscar
            // 
            btn_Buscar.BackColor = Color.FromArgb(52, 58, 64);
            btn_Buscar.BackgroundImageLayout = ImageLayout.None;
            btn_Buscar.Cursor = Cursors.Hand;
            btn_Buscar.FlatAppearance.BorderSize = 0;
            btn_Buscar.FlatAppearance.MouseDownBackColor = Color.FromArgb(73, 80, 87);
            btn_Buscar.FlatAppearance.MouseOverBackColor = Color.FromArgb(52, 58, 64);
            btn_Buscar.FlatStyle = FlatStyle.Flat;
            btn_Buscar.Font = new Font("JetBrains Mono Light", 11F);
            btn_Buscar.ForeColor = Color.FromArgb(206, 212, 218);
            btn_Buscar.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Buscar.Location = new Point(242, 21);
            btn_Buscar.Margin = new Padding(5);
            btn_Buscar.Name = "btn_Buscar";
            btn_Buscar.Size = new Size(100, 44);
            btn_Buscar.TabIndex = 5;
            btn_Buscar.Text = "BUSCAR";
            btn_Buscar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_Buscar.UseVisualStyleBackColor = false;
            btn_Buscar.Click += btn_Buscar_Click;
            // 
            // txtbox_ID
            // 
            txtbox_ID.BackColor = Color.FromArgb(108, 117, 125);
            txtbox_ID.BorderStyle = BorderStyle.None;
            txtbox_ID.Font = new Font("JetBrains Mono", 10F);
            txtbox_ID.ForeColor = Color.FromArgb(206, 212, 218);
            txtbox_ID.Location = new Point(652, 0);
            txtbox_ID.MaxLength = 14;
            txtbox_ID.Name = "txtbox_ID";
            txtbox_ID.Size = new Size(110, 18);
            txtbox_ID.TabIndex = 2;
            txtbox_ID.TextChanged += txtbox_ID_TextChanged;
            // 
            // txtbox_CPF
            // 
            txtbox_CPF.BackColor = Color.FromArgb(108, 117, 125);
            txtbox_CPF.BorderStyle = BorderStyle.None;
            txtbox_CPF.Font = new Font("JetBrains Mono", 10F);
            txtbox_CPF.ForeColor = Color.FromArgb(206, 212, 218);
            txtbox_CPF.Location = new Point(43, 21);
            txtbox_CPF.MaxLength = 14;
            txtbox_CPF.Name = "txtbox_CPF";
            txtbox_CPF.Size = new Size(191, 18);
            txtbox_CPF.TabIndex = 3;
            txtbox_CPF.TextChanged += txtbox_CPF_TextChanged;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(108, 117, 125);
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("JetBrains Mono", 12F);
            textBox1.ForeColor = Color.FromArgb(206, 212, 218);
            textBox1.Location = new Point(79, 111);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(0, 22);
            textBox1.TabIndex = 21;
            // 
            // txtbox_Requerente
            // 
            txtbox_Requerente.BackColor = Color.FromArgb(108, 117, 125);
            txtbox_Requerente.BorderStyle = BorderStyle.None;
            txtbox_Requerente.Font = new Font("JetBrains Mono", 10F);
            txtbox_Requerente.ForeColor = Color.FromArgb(206, 212, 218);
            txtbox_Requerente.Location = new Point(113, 0);
            txtbox_Requerente.MaxLength = 127;
            txtbox_Requerente.Name = "txtbox_Requerente";
            txtbox_Requerente.Size = new Size(495, 18);
            txtbox_Requerente.TabIndex = 1;
            txtbox_Requerente.TextChanged += txtbox_Requerente_TextChanged;
            // 
            // lbl_Data
            // 
            lbl_Data.AutoSize = true;
            lbl_Data.Font = new Font("JetBrains Mono", 12F);
            lbl_Data.ForeColor = Color.FromArgb(206, 212, 218);
            lbl_Data.Location = new Point(0, 42);
            lbl_Data.Name = "lbl_Data";
            lbl_Data.Size = new Size(60, 21);
            lbl_Data.TabIndex = 20;
            lbl_Data.Text = "Data:";
            lbl_Data.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lbl_ID
            // 
            lbl_ID.AutoSize = true;
            lbl_ID.Font = new Font("JetBrains Mono", 12F);
            lbl_ID.ForeColor = Color.FromArgb(206, 212, 218);
            lbl_ID.Location = new Point(614, 0);
            lbl_ID.Name = "lbl_ID";
            lbl_ID.Size = new Size(40, 21);
            lbl_ID.TabIndex = 19;
            lbl_ID.Text = "ID:";
            lbl_ID.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lbl_CPF
            // 
            lbl_CPF.AutoSize = true;
            lbl_CPF.Font = new Font("JetBrains Mono", 12F);
            lbl_CPF.ForeColor = Color.FromArgb(206, 212, 218);
            lbl_CPF.Location = new Point(0, 21);
            lbl_CPF.Name = "lbl_CPF";
            lbl_CPF.Size = new Size(50, 21);
            lbl_CPF.TabIndex = 17;
            lbl_CPF.Text = "CPF:";
            lbl_CPF.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lbl_Requerente
            // 
            lbl_Requerente.AutoSize = true;
            lbl_Requerente.Font = new Font("JetBrains Mono", 12F);
            lbl_Requerente.ForeColor = Color.FromArgb(206, 212, 218);
            lbl_Requerente.Location = new Point(0, 0);
            lbl_Requerente.Name = "lbl_Requerente";
            lbl_Requerente.Size = new Size(120, 21);
            lbl_Requerente.TabIndex = 16;
            lbl_Requerente.Text = "Requerente:";
            lbl_Requerente.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // dgv_RecibosProvisoriosAtos
            // 
            dgv_RecibosProvisoriosAtos.AccessibleRole = AccessibleRole.List;
            dgv_RecibosProvisoriosAtos.AllowUserToAddRows = false;
            dgv_RecibosProvisoriosAtos.AllowUserToDeleteRows = false;
            dgv_RecibosProvisoriosAtos.AllowUserToResizeRows = false;
            dgv_RecibosProvisoriosAtos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_RecibosProvisoriosAtos.BackgroundColor = Color.FromArgb(73, 80, 87);
            dgv_RecibosProvisoriosAtos.BorderStyle = BorderStyle.None;
            dgv_RecibosProvisoriosAtos.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgv_RecibosProvisoriosAtos.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(108, 117, 125);
            dataGridViewCellStyle5.Font = new Font("JetBrains Mono Light", 9.75F);
            dataGridViewCellStyle5.ForeColor = Color.FromArgb(222, 226, 230);
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(108, 117, 125);
            dataGridViewCellStyle5.SelectionForeColor = Color.FromArgb(222, 226, 230);
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dgv_RecibosProvisoriosAtos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dgv_RecibosProvisoriosAtos.ColumnHeadersHeight = 20;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(108, 117, 125);
            dataGridViewCellStyle6.Font = new Font("JetBrains Mono Light", 9.75F);
            dataGridViewCellStyle6.ForeColor = Color.FromArgb(222, 226, 230);
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(108, 117, 125);
            dataGridViewCellStyle6.SelectionForeColor = Color.FromArgb(222, 226, 230);
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dgv_RecibosProvisoriosAtos.DefaultCellStyle = dataGridViewCellStyle6;
            dgv_RecibosProvisoriosAtos.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgv_RecibosProvisoriosAtos.EnableHeadersVisualStyles = false;
            dgv_RecibosProvisoriosAtos.ImeMode = ImeMode.Off;
            dgv_RecibosProvisoriosAtos.Location = new Point(0, 269);
            dgv_RecibosProvisoriosAtos.MultiSelect = false;
            dgv_RecibosProvisoriosAtos.Name = "dgv_RecibosProvisoriosAtos";
            dgv_RecibosProvisoriosAtos.ReadOnly = true;
            dgv_RecibosProvisoriosAtos.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = Color.FromArgb(108, 117, 125);
            dataGridViewCellStyle7.Font = new Font("JetBrains Mono Light", 9.75F);
            dataGridViewCellStyle7.ForeColor = Color.FromArgb(222, 226, 230);
            dataGridViewCellStyle7.SelectionBackColor = Color.FromArgb(108, 117, 125);
            dataGridViewCellStyle7.SelectionForeColor = Color.FromArgb(222, 226, 230);
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            dgv_RecibosProvisoriosAtos.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dgv_RecibosProvisoriosAtos.RowHeadersVisible = false;
            dgv_RecibosProvisoriosAtos.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle8.BackColor = Color.FromArgb(108, 117, 125);
            dataGridViewCellStyle8.Font = new Font("JetBrains Mono Light", 9.75F);
            dataGridViewCellStyle8.ForeColor = Color.FromArgb(222, 226, 230);
            dataGridViewCellStyle8.SelectionBackColor = Color.FromArgb(108, 117, 125);
            dataGridViewCellStyle8.SelectionForeColor = Color.FromArgb(222, 226, 230);
            dgv_RecibosProvisoriosAtos.RowsDefaultCellStyle = dataGridViewCellStyle8;
            dgv_RecibosProvisoriosAtos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_RecibosProvisoriosAtos.Size = new Size(762, 230);
            dgv_RecibosProvisoriosAtos.TabIndex = 8;
            // 
            // reciboProvisorioAtoBindingSource
            // 
            reciboProvisorioAtoBindingSource.DataSource = typeof(Models.ReciboProvisorioAto);
            // 
            // frm_ConsultarReciboProvisorio
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(73, 80, 87);
            ClientSize = new Size(784, 526);
            Controls.Add(pnl_RecentesReciboProvisorio);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frm_ConsultarReciboProvisorio";
            Text = "Consultar Recibo Provisório";
            Load += frm_ConsultarReciboProvisorio_Load;
            pnl_RecentesReciboProvisorio.ResumeLayout(false);
            pnl_RecentesReciboProvisorio.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_RecibosProvisorios).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgv_RecibosProvisoriosAtos).EndInit();
            ((System.ComponentModel.ISupportInitialize)reciboProvisorioAtoBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel pnl_RecentesReciboProvisorio;
        private BindingSource reciboProvisorioAtoBindingSource;
        private Label lbl_Requerente;
        private Label lbl_ID;
        private Label lbl_CPF;
        private Label lbl_Data;
        private TextBox txtbox_Requerente;
        private TextBox textBox1;
        private TextBox txtbox_CPF;
        private DataGridView dgv_RecibosProvisoriosAtos;
        private TextBox txtbox_ID;
        private Button btn_Imprimir;
        private Button btn_Buscar;
        private DataGridView dgv_RecibosProvisorios;
        private Util.CustomDateTimePicker dateTimePicker_Data;
    }
}