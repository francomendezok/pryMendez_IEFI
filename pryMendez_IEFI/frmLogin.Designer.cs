namespace pryMendez_IEFI
{
    partial class frmLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            groupLogin = new GroupBox();
            lblRegisterInfo = new Label();
            btnGoRegister = new Button();
            btnLogin = new Button();
            label1 = new Label();
            txtPassword = new TextBox();
            lblUsername = new Label();
            txtUsername = new TextBox();
            groupLogin.SuspendLayout();
            SuspendLayout();
            // 
            // groupLogin
            // 
            groupLogin.Controls.Add(lblRegisterInfo);
            groupLogin.Controls.Add(btnGoRegister);
            groupLogin.Controls.Add(btnLogin);
            groupLogin.Controls.Add(label1);
            groupLogin.Controls.Add(txtPassword);
            groupLogin.Controls.Add(lblUsername);
            groupLogin.Controls.Add(txtUsername);
            groupLogin.Location = new Point(112, 59);
            groupLogin.Name = "groupLogin";
            groupLogin.Size = new Size(459, 332);
            groupLogin.TabIndex = 0;
            groupLogin.TabStop = false;
            groupLogin.Text = "Login";
            groupLogin.Enter += groupBox1_Enter;
            // 
            // lblRegisterInfo
            // 
            lblRegisterInfo.AutoSize = true;
            lblRegisterInfo.Location = new Point(45, 285);
            lblRegisterInfo.Name = "lblRegisterInfo";
            lblRegisterInfo.Size = new Size(281, 20);
            lblRegisterInfo.TabIndex = 6;
            lblRegisterInfo.Text = "Don't have an account yet? Register here:";
            // 
            // btnGoRegister
            // 
            btnGoRegister.Location = new Point(342, 283);
            btnGoRegister.Name = "btnGoRegister";
            btnGoRegister.Size = new Size(94, 29);
            btnGoRegister.TabIndex = 5;
            btnGoRegister.Text = "Register";
            btnGoRegister.UseVisualStyleBackColor = true;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(45, 220);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(125, 29);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(46, 131);
            label1.Name = "label1";
            label1.Size = new Size(70, 20);
            label1.TabIndex = 3;
            label1.Text = "Password";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(45, 155);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(125, 27);
            txtPassword.TabIndex = 2;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Location = new Point(45, 52);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(75, 20);
            lblUsername.TabIndex = 1;
            lblUsername.Text = "Username";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(45, 75);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(125, 27);
            txtUsername.TabIndex = 0;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 255);
            ClientSize = new Size(682, 433);
            Controls.Add(groupLogin);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmLogin";
            Text = "Login";
            Load += frmLogin_Load;
            groupLogin.ResumeLayout(false);
            groupLogin.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupLogin;
        private Label lblUsername;
        private TextBox txtUsername;
        private Button btnLogin;
        private Label label1;
        private TextBox txtPassword;
        private Label lblRegisterInfo;
        private Button btnGoRegister;
    }
}
