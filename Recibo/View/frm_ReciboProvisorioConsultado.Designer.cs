namespace Recibo.View
{
    partial class frm_ReciboProvisorioConsultado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_ReciboProvisorioConsultado));
            pnl_RecentesReciboProvisorio = new Panel();
            lbl_Data = new Label();
            lbl_ID = new Label();
            lbl_Total = new Label();
            lbl_CPF = new Label();
            lbl_Requerente = new Label();
            dgv_Atos = new DataGridView();
            reciboProvisorioAtoBindingSource = new BindingSource(components);
            pnl_RecentesReciboProvisorio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_Atos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)reciboProvisorioAtoBindingSource).BeginInit();
            SuspendLayout();
            // 
            // pnl_RecentesReciboProvisorio
            // 
            pnl_RecentesReciboProvisorio.Controls.Add(lbl_Data);
            pnl_RecentesReciboProvisorio.Controls.Add(lbl_ID);
            pnl_RecentesReciboProvisorio.Controls.Add(lbl_Total);
            pnl_RecentesReciboProvisorio.Controls.Add(lbl_CPF);
            pnl_RecentesReciboProvisorio.Controls.Add(lbl_Requerente);
            pnl_RecentesReciboProvisorio.Controls.Add(dgv_Atos);
            pnl_RecentesReciboProvisorio.Location = new Point(10, 12);
            pnl_RecentesReciboProvisorio.Name = "pnl_RecentesReciboProvisorio";
            pnl_RecentesReciboProvisorio.Size = new Size(762, 502);
            pnl_RecentesReciboProvisorio.TabIndex = 5;
            // 
            // lbl_Data
            // 
            lbl_Data.AutoSize = true;
            lbl_Data.Font = new Font("JetBrains Mono", 12F);
            lbl_Data.ForeColor = Color.FromArgb(206, 212, 218);
            lbl_Data.Location = new Point(0, 63);
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
            // lbl_Total
            // 
            lbl_Total.AutoSize = true;
            lbl_Total.Font = new Font("JetBrains Mono", 12F);
            lbl_Total.ForeColor = Color.FromArgb(206, 212, 218);
            lbl_Total.Location = new Point(0, 42);
            lbl_Total.Name = "lbl_Total";
            lbl_Total.Size = new Size(70, 21);
            lbl_Total.TabIndex = 18;
            lbl_Total.Text = "Total:";
            lbl_Total.TextAlign = ContentAlignment.MiddleLeft;
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
            // dgv_Atos
            // 
            dgv_Atos.AccessibleRole = AccessibleRole.List;
            dgv_Atos.AllowUserToAddRows = false;
            dgv_Atos.AllowUserToDeleteRows = false;
            dgv_Atos.AllowUserToResizeRows = false;
            dgv_Atos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_Atos.BackgroundColor = Color.FromArgb(73, 80, 87);
            dgv_Atos.BorderStyle = BorderStyle.None;
            dgv_Atos.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgv_Atos.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(108, 117, 125);
            dataGridViewCellStyle1.Font = new Font("JetBrains Mono Light", 9.75F);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(222, 226, 230);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(108, 117, 125);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(222, 226, 230);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgv_Atos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgv_Atos.ColumnHeadersHeight = 20;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(108, 117, 125);
            dataGridViewCellStyle2.Font = new Font("JetBrains Mono Light", 9.75F);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(222, 226, 230);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(108, 117, 125);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(222, 226, 230);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgv_Atos.DefaultCellStyle = dataGridViewCellStyle2;
            dgv_Atos.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgv_Atos.EnableHeadersVisualStyles = false;
            dgv_Atos.ImeMode = ImeMode.Off;
            dgv_Atos.Location = new Point(0, 89);
            dgv_Atos.MultiSelect = false;
            dgv_Atos.Name = "dgv_Atos";
            dgv_Atos.ReadOnly = true;
            dgv_Atos.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(108, 117, 125);
            dataGridViewCellStyle3.Font = new Font("JetBrains Mono Light", 9.75F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(222, 226, 230);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(108, 117, 125);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(222, 226, 230);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgv_Atos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgv_Atos.RowHeadersVisible = false;
            dgv_Atos.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(108, 117, 125);
            dataGridViewCellStyle4.Font = new Font("JetBrains Mono Light", 9.75F);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(222, 226, 230);
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(108, 117, 125);
            dataGridViewCellStyle4.SelectionForeColor = Color.FromArgb(222, 226, 230);
            dgv_Atos.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dgv_Atos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_Atos.Size = new Size(762, 413);
            dgv_Atos.TabIndex = 0;
            // 
            // reciboProvisorioAtoBindingSource
            // 
            reciboProvisorioAtoBindingSource.DataSource = typeof(Models.ReciboProvisorioAto);
            // 
            // frm_ReciboProvisorioConsultado
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(73, 80, 87);
            ClientSize = new Size(784, 526);
            Controls.Add(pnl_RecentesReciboProvisorio);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frm_ReciboProvisorioConsultado";
            Load += frm_ConsultarReciboProvisorio_Load;
            pnl_RecentesReciboProvisorio.ResumeLayout(false);
            pnl_RecentesReciboProvisorio.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_Atos).EndInit();
            ((System.ComponentModel.ISupportInitialize)reciboProvisorioAtoBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel pnl_RecentesReciboProvisorio;
        private BindingSource reciboProvisorioAtoBindingSource;
        private DataGridView dgv_Atos;
        private Label lbl_Requerente;
        private Label lbl_ID;
        private Label lbl_Total;
        private Label lbl_CPF;
        private Label lbl_Data;
    }
}