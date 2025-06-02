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
            dgvMainTasks = new DataGridView();
            lblMainTasks = new Label();
            lblMainWelcome = new Label();
            toolStrip1 = new ToolStrip();
            stripMainUsers = new ToolStripLabel();
            stripMainAuditoria = new ToolStripLabel();
            btnMainLogout = new Button();
            groupFooter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMainTasks).BeginInit();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // groupFooter
            // 
            groupFooter.Controls.Add(lblMainDate);
            groupFooter.Controls.Add(lblMainUsername);
            groupFooter.Location = new Point(14, 536);
            groupFooter.Margin = new Padding(3, 4, 3, 4);
            groupFooter.Name = "groupFooter";
            groupFooter.Padding = new Padding(3, 4, 3, 4);
            groupFooter.Size = new Size(887, 48);
            groupFooter.TabIndex = 0;
            groupFooter.TabStop = false;
            // 
            // lblMainDate
            // 
            lblMainDate.AutoSize = true;
            lblMainDate.Location = new Point(770, 24);
            lblMainDate.Name = "lblMainDate";
            lblMainDate.Size = new Size(116, 20);
            lblMainDate.TabIndex = 1;
            lblMainDate.Text = "5/31/2025 15:07";
            // 
            // lblMainUsername
            // 
            lblMainUsername.AutoSize = true;
            lblMainUsername.Location = new Point(54, 24);
            lblMainUsername.Name = "lblMainUsername";
            lblMainUsername.Size = new Size(75, 20);
            lblMainUsername.TabIndex = 0;
            lblMainUsername.Text = "Username";
            lblMainUsername.Click += lblMainUsername_Click;
            // 
            // lblMainUserStatus
            // 
            lblMainUserStatus.AutoSize = true;
            lblMainUserStatus.Location = new Point(784, 43);
            lblMainUserStatus.Name = "lblMainUserStatus";
            lblMainUserStatus.Size = new Size(131, 20);
            lblMainUserStatus.TabIndex = 2;
            lblMainUserStatus.Text = "User status: Admin";
            // 
            // dgvMainTasks
            // 
            dgvMainTasks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMainTasks.Location = new Point(67, 96);
            dgvMainTasks.Margin = new Padding(3, 4, 3, 4);
            dgvMainTasks.Name = "dgvMainTasks";
            dgvMainTasks.RowHeadersWidth = 51;
            dgvMainTasks.Size = new Size(274, 413);
            dgvMainTasks.TabIndex = 4;
            // 
            // lblMainTasks
            // 
            lblMainTasks.AutoSize = true;
            lblMainTasks.Location = new Point(67, 67);
            lblMainTasks.Name = "lblMainTasks";
            lblMainTasks.Size = new Size(77, 20);
            lblMainTasks.TabIndex = 5;
            lblMainTasks.Text = "Your tasks:";
            // 
            // lblMainWelcome
            // 
            lblMainWelcome.AutoSize = true;
            lblMainWelcome.Location = new Point(67, 43);
            lblMainWelcome.Name = "lblMainWelcome";
            lblMainWelcome.Size = new Size(228, 20);
            lblMainWelcome.TabIndex = 6;
            lblMainWelcome.Text = "Welcome back, francomendezok!";
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { stripMainUsers, stripMainAuditoria });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.RightToLeft = RightToLeft.Yes;
            toolStrip1.Size = new Size(914, 25);
            toolStrip1.TabIndex = 7;
            toolStrip1.Text = "toolStrip1";
            // 
            // stripMainUsers
            // 
            stripMainUsers.Name = "stripMainUsers";
            stripMainUsers.Size = new Size(44, 22);
            stripMainUsers.Text = "Users";
            // 
            // stripMainAuditoria
            // 
            stripMainAuditoria.Name = "stripMainAuditoria";
            stripMainAuditoria.Size = new Size(71, 22);
            stripMainAuditoria.Text = "Auditoria";
            // 
            // btnMainLogout
            // 
            btnMainLogout.Location = new Point(784, 497);
            btnMainLogout.Margin = new Padding(3, 4, 3, 4);
            btnMainLogout.Name = "btnMainLogout";
            btnMainLogout.Size = new Size(117, 31);
            btnMainLogout.TabIndex = 8;
            btnMainLogout.Text = "Log Out";
            btnMainLogout.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(914, 600);
            Controls.Add(btnMainLogout);
            Controls.Add(toolStrip1);
            Controls.Add(lblMainWelcome);
            Controls.Add(lblMainTasks);
            Controls.Add(dgvMainTasks);
            Controls.Add(lblMainUserStatus);
            Controls.Add(groupFooter);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmMain";
            Text = "frmMain";
            groupFooter.ResumeLayout(false);
            groupFooter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMainTasks).EndInit();
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
        private DataGridView dgvMainTasks;
        private Label lblMainTasks;
        private Label lblMainWelcome;
        private ToolStrip toolStrip1;
        private ToolStripLabel stripMainUsers;
        private ToolStripLabel stripMainAuditoria;
        private Button btnMainLogout;
    }
}