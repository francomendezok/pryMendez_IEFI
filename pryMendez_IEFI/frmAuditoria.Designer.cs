namespace pryMendez_IEFI
{
    partial class frmAuditoria
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
            lblAuditoriaForUser = new Label();
            dgvAuditoria = new DataGridView();
            lblAuditoriaUsername = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)dgvAuditoria).BeginInit();
            SuspendLayout();
            // 
            // lblAuditoriaForUser
            // 
            lblAuditoriaForUser.AutoSize = true;
            lblAuditoriaForUser.Location = new Point(280, 59);
            lblAuditoriaForUser.Name = "lblAuditoriaForUser";
            lblAuditoriaForUser.Size = new Size(102, 15);
            lblAuditoriaForUser.TabIndex = 7;
            lblAuditoriaForUser.Text = "Auditoria for user:";
            // 
            // dgvAuditoria
            // 
            dgvAuditoria.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAuditoria.Location = new Point(280, 81);
            dgvAuditoria.Name = "dgvAuditoria";
            dgvAuditoria.Size = new Size(240, 310);
            dgvAuditoria.TabIndex = 6;
            // 
            // lblAuditoriaUsername
            // 
            lblAuditoriaUsername.AutoSize = true;
            lblAuditoriaUsername.Location = new Point(388, 59);
            lblAuditoriaUsername.Name = "lblAuditoriaUsername";
            lblAuditoriaUsername.Size = new Size(96, 15);
            lblAuditoriaUsername.TabIndex = 8;
            lblAuditoriaUsername.Text = "francomendezok";
            // 
            // frmAuditoria
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(800, 450);
            Controls.Add(lblAuditoriaUsername);
            Controls.Add(lblAuditoriaForUser);
            Controls.Add(dgvAuditoria);
            Name = "frmAuditoria";
            Text = "Auditoria";
            ((System.ComponentModel.ISupportInitialize)dgvAuditoria).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAuditoriaForUser;
        private DataGridView dgvAuditoria;
        private Label lblAuditoriaUsername;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}