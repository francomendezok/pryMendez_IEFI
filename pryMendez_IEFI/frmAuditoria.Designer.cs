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
            tabControlUserInfo = new TabControl();
            tabPageUserInfo = new TabPage();
            dgvUserInfo = new DataGridView();
            tabPageUserCredentials = new TabPage();
            dgvUserCredentials = new DataGridView();
            tabPageUserLogs = new TabPage();
            btnBackToMain = new Button();
            dgvUserLogs = new DataGridView();
            tabControlUserInfo.SuspendLayout();
            tabPageUserInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUserInfo).BeginInit();
            tabPageUserCredentials.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUserCredentials).BeginInit();
            tabPageUserLogs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUserLogs).BeginInit();
            SuspendLayout();
            // 
            // tabControlUserInfo
            // 
            tabControlUserInfo.Controls.Add(tabPageUserInfo);
            tabControlUserInfo.Controls.Add(tabPageUserCredentials);
            tabControlUserInfo.Controls.Add(tabPageUserLogs);
            tabControlUserInfo.Location = new Point(49, 21);
            tabControlUserInfo.Name = "tabControlUserInfo";
            tabControlUserInfo.SelectedIndex = 0;
            tabControlUserInfo.Size = new Size(645, 404);
            tabControlUserInfo.TabIndex = 0;
            // 
            // tabPageUserInfo
            // 
            tabPageUserInfo.Controls.Add(dgvUserInfo);
            tabPageUserInfo.Location = new Point(4, 29);
            tabPageUserInfo.Name = "tabPageUserInfo";
            tabPageUserInfo.Padding = new Padding(3);
            tabPageUserInfo.Size = new Size(637, 371);
            tabPageUserInfo.TabIndex = 0;
            tabPageUserInfo.Text = "User Info";
            tabPageUserInfo.UseVisualStyleBackColor = true;
            tabPageUserInfo.Click += tabPageUserInfo_Click;
            // 
            // dgvUserInfo
            // 
            dgvUserInfo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUserInfo.Location = new Point(6, 6);
            dgvUserInfo.Name = "dgvUserInfo";
            dgvUserInfo.RowHeadersWidth = 51;
            dgvUserInfo.Size = new Size(628, 365);
            dgvUserInfo.TabIndex = 0;
            // 
            // tabPageUserCredentials
            // 
            tabPageUserCredentials.Controls.Add(dgvUserCredentials);
            tabPageUserCredentials.Location = new Point(4, 29);
            tabPageUserCredentials.Name = "tabPageUserCredentials";
            tabPageUserCredentials.Padding = new Padding(3);
            tabPageUserCredentials.Size = new Size(637, 371);
            tabPageUserCredentials.TabIndex = 1;
            tabPageUserCredentials.Text = "User Credentials";
            tabPageUserCredentials.UseVisualStyleBackColor = true;
            // 
            // dgvUserCredentials
            // 
            dgvUserCredentials.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUserCredentials.Location = new Point(6, 6);
            dgvUserCredentials.Name = "dgvUserCredentials";
            dgvUserCredentials.RowHeadersWidth = 51;
            dgvUserCredentials.Size = new Size(625, 359);
            dgvUserCredentials.TabIndex = 0;
            // 
            // tabPageUserLogs
            // 
            tabPageUserLogs.Controls.Add(dgvUserLogs);
            tabPageUserLogs.Location = new Point(4, 29);
            tabPageUserLogs.Name = "tabPageUserLogs";
            tabPageUserLogs.Padding = new Padding(3);
            tabPageUserLogs.Size = new Size(637, 371);
            tabPageUserLogs.TabIndex = 2;
            tabPageUserLogs.Text = "User Logs";
            tabPageUserLogs.UseVisualStyleBackColor = true;
            // 
            // btnBackToMain
            // 
            btnBackToMain.Location = new Point(519, 443);
            btnBackToMain.Name = "btnBackToMain";
            btnBackToMain.Size = new Size(175, 29);
            btnBackToMain.TabIndex = 1;
            btnBackToMain.Text = "Back to Main";
            btnBackToMain.UseVisualStyleBackColor = true;
            btnBackToMain.Click += btnBackToMain_Click;
            // 
            // dgvUserLogs
            // 
            dgvUserLogs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUserLogs.Location = new Point(4, 3);
            dgvUserLogs.Name = "dgvUserLogs";
            dgvUserLogs.RowHeadersWidth = 51;
            dgvUserLogs.Size = new Size(628, 365);
            dgvUserLogs.TabIndex = 1;
            // 
            // frmAuditoria
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(803, 484);
            Controls.Add(btnBackToMain);
            Controls.Add(tabControlUserInfo);
            Name = "frmAuditoria";
            Text = "Admin Dashboard";
            tabControlUserInfo.ResumeLayout(false);
            tabPageUserInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvUserInfo).EndInit();
            tabPageUserCredentials.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvUserCredentials).EndInit();
            tabPageUserLogs.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvUserLogs).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControlUserInfo;
        private TabPage tabPageUserInfo;
        private TabPage tabPageUserCredentials;
        private TabPage tabPageUserLogs;
        private Button btnBackToMain;
        private DataGridView dgvUserInfo;
        private DataGridView dgvUserCredentials;
        private DataGridView dgvUserLogs;
    }
}