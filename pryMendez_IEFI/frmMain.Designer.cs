namespace pryMendez_IEFI
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            groupFooter = new GroupBox();
            lblMainDate = new Label();
            lblMainUsername = new Label();
            lblMainUserStatus = new Label();
            lblMainWelcome = new Label();
            toolStrip1 = new ToolStrip();
            stripMainCrud = new ToolStripLabel();
            stripMainAuditoria = new ToolStripLabel();
            btnMainLogout = new Button();
            groupFooter.SuspendLayout();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // groupFooter
            // 
            groupFooter.Controls.Add(lblMainDate);
            groupFooter.Controls.Add(lblMainUsername);
            groupFooter.Location = new Point(12, 402);
            groupFooter.Name = "groupFooter";
            groupFooter.Size = new Size(776, 36);
            groupFooter.TabIndex = 0;
            groupFooter.TabStop = false;
            // 
            // lblMainDate
            // 
            lblMainDate.AutoSize = true;
            lblMainDate.Location = new Point(674, 18);
            lblMainDate.Name = "lblMainDate";
            lblMainDate.Size = new Size(89, 15);
            lblMainDate.TabIndex = 1;
            lblMainDate.Text = "5/31/2025 15:07";
            // 
            // lblMainUsername
            // 
            lblMainUsername.AutoSize = true;
            lblMainUsername.Location = new Point(47, 18);
            lblMainUsername.Name = "lblMainUsername";
            lblMainUsername.Size = new Size(60, 15);
            lblMainUsername.TabIndex = 0;
            lblMainUsername.Text = "Username";
            lblMainUsername.Click += lblMainUsername_Click;
            // 
            // lblMainUserStatus
            // 
            lblMainUserStatus.AutoSize = true;
            lblMainUserStatus.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMainUserStatus.Location = new Point(268, 168);
            lblMainUserStatus.Name = "lblMainUserStatus";
            lblMainUserStatus.Size = new Size(168, 25);
            lblMainUserStatus.TabIndex = 2;
            lblMainUserStatus.Text = "User status: Admin";
            // 
            // lblMainWelcome
            // 
            lblMainWelcome.AutoSize = true;
            lblMainWelcome.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMainWelcome.Location = new Point(268, 121);
            lblMainWelcome.Name = "lblMainWelcome";
            lblMainWelcome.Size = new Size(320, 30);
            lblMainWelcome.TabIndex = 6;
            lblMainWelcome.Text = "Welcome back, francomendezok!";
            lblMainWelcome.Click += lblMainWelcome_Click;
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { stripMainCrud, stripMainAuditoria });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.RightToLeft = RightToLeft.No;
            toolStrip1.Size = new Size(800, 25);
            toolStrip1.TabIndex = 7;
            toolStrip1.Text = "toolStrip1";
            // 
            // stripMainCrud
            // 
            stripMainCrud.Name = "stripMainCrud";
            stripMainCrud.Size = new Size(58, 22);
            stripMainCrud.Text = "Edit Users";
            stripMainCrud.Click += stripMainCrud_Click;
            // 
            // stripMainAuditoria
            // 
            stripMainAuditoria.Name = "stripMainAuditoria";
            stripMainAuditoria.Size = new Size(56, 22);
            stripMainAuditoria.Text = "Auditoria";
            stripMainAuditoria.Click += stripMainAuditoria_Click;
            // 
            // btnMainLogout
            // 
            btnMainLogout.Location = new Point(686, 373);
            btnMainLogout.Name = "btnMainLogout";
            btnMainLogout.Size = new Size(102, 23);
            btnMainLogout.TabIndex = 8;
            btnMainLogout.Text = "Log Out";
            btnMainLogout.UseVisualStyleBackColor = true;
            btnMainLogout.Click += btnMainLogout_Click;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(800, 450);
            Controls.Add(btnMainLogout);
            Controls.Add(toolStrip1);
            Controls.Add(lblMainWelcome);
            Controls.Add(lblMainUserStatus);
            Controls.Add(groupFooter);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmMain";
            Text = "Users Application";
            Load += frmMain_Load;
            groupFooter.ResumeLayout(false);
            groupFooter.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupFooter;
        private Label lblMainDate;
        private Label lblMainUsername;
        private Label lblMainUserStatus;
        private Label lblMainWelcome;
        private ToolStrip toolStrip1;
        private ToolStripLabel stripMainCrud;
        private ToolStripLabel stripMainAuditoria;
        private Button btnMainLogout;
    }
}