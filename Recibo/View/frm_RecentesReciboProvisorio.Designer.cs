﻿namespace Recibo.View
{
    partial class frm_RecentesReciboProvisorio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_RecentesReciboProvisorio));
            pnl_RecentesReciboProvisorio = new Panel();
            btn_Consultar = new Button();
            dgv_Recentes = new DataGridView();
            reciboProvisorioAtoBindingSource = new BindingSource(components);
            pnl_RecentesReciboProvisorio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_Recentes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)reciboProvisorioAtoBindingSource).BeginInit();
            SuspendLayout();
            // 
            // pnl_RecentesReciboProvisorio
            // 
            pnl_RecentesReciboProvisorio.Controls.Add(btn_Consultar);
            pnl_RecentesReciboProvisorio.Controls.Add(dgv_Recentes);
            pnl_RecentesReciboProvisorio.Location = new Point(10, 12);
            pnl_RecentesReciboProvisorio.Name = "pnl_RecentesReciboProvisorio";
            pnl_RecentesReciboProvisorio.Size = new Size(762, 502);
            pnl_RecentesReciboProvisorio.TabIndex = 5;
            // 
            // btn_Consultar
            // 
            btn_Consultar.BackColor = Color.FromArgb(52, 58, 64);
            btn_Consultar.BackgroundImageLayout = ImageLayout.None;
            btn_Consultar.Cursor = Cursors.Hand;
            btn_Consultar.FlatAppearance.BorderSize = 0;
            btn_Consultar.FlatAppearance.MouseDownBackColor = Color.FromArgb(73, 80, 87);
            btn_Consultar.FlatAppearance.MouseOverBackColor = Color.FromArgb(52, 58, 64);
            btn_Consultar.FlatStyle = FlatStyle.Flat;
            btn_Consultar.Font = new Font("JetBrains Mono Light", 12F);
            btn_Consultar.ForeColor = Color.FromArgb(206, 212, 218);
            btn_Consultar.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Consultar.Location = new Point(5, 452);
            btn_Consultar.Margin = new Padding(5);
            btn_Consultar.Name = "btn_Consultar";
            btn_Consultar.Size = new Size(110, 45);
            btn_Consultar.TabIndex = 15;
            btn_Consultar.Text = "CONSULTAR";
            btn_Consultar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_Consultar.UseVisualStyleBackColor = false;
            btn_Consultar.Click += btn_Consultar_Click;
            // 
            // dgv_Recentes
            // 
            dgv_Recentes.AccessibleRole = AccessibleRole.List;
            dgv_Recentes.AllowUserToAddRows = false;
            dgv_Recentes.AllowUserToDeleteRows = false;
            dgv_Recentes.AllowUserToResizeRows = false;
            dgv_Recentes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_Recentes.BackgroundColor = Color.FromArgb(73, 80, 87);
            dgv_Recentes.BorderStyle = BorderStyle.None;
            dgv_Recentes.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgv_Recentes.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(108, 117, 125);
            dataGridViewCellStyle1.Font = new Font("JetBrains Mono Light", 9.75F);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(222, 226, 230);
            dataGridViewCellStyle1.SelectionBackColor = Color.OliveDrab;
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(222, 226, 230);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgv_Recentes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgv_Recentes.ColumnHeadersHeight = 20;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(108, 117, 125);
            dataGridViewCellStyle2.Font = new Font("JetBrains Mono Light", 9.75F);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(222, 226, 230);
            dataGridViewCellStyle2.SelectionBackColor = Color.OliveDrab;
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(222, 226, 230);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgv_Recentes.DefaultCellStyle = dataGridViewCellStyle2;
            dgv_Recentes.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgv_Recentes.EnableHeadersVisualStyles = false;
            dgv_Recentes.ImeMode = ImeMode.Off;
            dgv_Recentes.Location = new Point(0, 0);
            dgv_Recentes.MinimumSize = new Size(762, 394);
            dgv_Recentes.MultiSelect = false;
            dgv_Recentes.Name = "dgv_Recentes";
            dgv_Recentes.ReadOnly = true;
            dgv_Recentes.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(108, 117, 125);
            dataGridViewCellStyle3.Font = new Font("JetBrains Mono Light", 9.75F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(222, 226, 230);
            dataGridViewCellStyle3.SelectionBackColor = Color.OliveDrab;
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(222, 226, 230);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgv_Recentes.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgv_Recentes.RowHeadersVisible = false;
            dgv_Recentes.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(108, 117, 125);
            dataGridViewCellStyle4.Font = new Font("JetBrains Mono Light", 9.75F);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(222, 226, 230);
            dataGridViewCellStyle4.SelectionBackColor = Color.OliveDrab;
            dataGridViewCellStyle4.SelectionForeColor = Color.FromArgb(222, 226, 230);
            dgv_Recentes.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dgv_Recentes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_Recentes.Size = new Size(762, 444);
            dgv_Recentes.TabIndex = 0;
            dgv_Recentes.CellClick += dgv_Recentes_CellClick;
            // 
            // reciboProvisorioAtoBindingSource
            // 
            reciboProvisorioAtoBindingSource.DataSource = typeof(Models.ReciboProvisorioAto);
            // 
            // frm_RecentesReciboProvisorio
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(73, 80, 87);
            ClientSize = new Size(784, 526);
            Controls.Add(pnl_RecentesReciboProvisorio);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frm_RecentesReciboProvisorio";
            Text = "frm_RecentesReciboProvisorio";
            Load += frm_RecentesReciboProvisorio_Load;
            pnl_RecentesReciboProvisorio.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv_Recentes).EndInit();
            ((System.ComponentModel.ISupportInitialize)reciboProvisorioAtoBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel pnl_RecentesReciboProvisorio;
        private BindingSource reciboProvisorioAtoBindingSource;
        private DataGridView dgv_Recentes;
        private Button btn_Consultar;
    }
}