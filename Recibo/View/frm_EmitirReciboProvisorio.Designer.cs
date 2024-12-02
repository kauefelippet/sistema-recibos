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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_EmitirReciboProvisorio));
            btn_EmissaoReciboProvisorio = new Button();
            btn_Recentes = new Button();
            btn_Consulta = new Button();
            pnl_EmissaoReciboProvisorio = new Panel();
            SuspendLayout();
            // 
            // btn_EmissaoReciboProvisorio
            // 
            btn_EmissaoReciboProvisorio.BackColor = Color.FromArgb(52, 58, 64);
            btn_EmissaoReciboProvisorio.BackgroundImageLayout = ImageLayout.None;
            btn_EmissaoReciboProvisorio.Cursor = Cursors.Hand;
            btn_EmissaoReciboProvisorio.FlatAppearance.BorderSize = 0;
            btn_EmissaoReciboProvisorio.FlatAppearance.MouseDownBackColor = Color.FromArgb(73, 80, 87);
            btn_EmissaoReciboProvisorio.FlatAppearance.MouseOverBackColor = Color.FromArgb(52, 58, 64);
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
            btn_Consulta.Click += button1_Click;
            // 
            // pnl_EmissaoReciboProvisorio
            // 
            pnl_EmissaoReciboProvisorio.Location = new Point(10, 63);
            pnl_EmissaoReciboProvisorio.Name = "pnl_EmissaoReciboProvisorio";
            pnl_EmissaoReciboProvisorio.Size = new Size(762, 451);
            pnl_EmissaoReciboProvisorio.TabIndex = 5;
            pnl_EmissaoReciboProvisorio.Paint += panel1_Paint;
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
            ResumeLayout(false);
        }

        #endregion

        private Button btn_EmissaoReciboProvisorio;
        private Button btn_Recentes;
        private Button btn_Consulta;
        private Panel pnl_EmissaoReciboProvisorio;
    }
}