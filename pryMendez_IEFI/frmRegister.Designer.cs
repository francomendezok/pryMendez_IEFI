namespace pryMendez_IEFI
{
    partial class frmRegister
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegister));
            groupRegister = new GroupBox();
            dateRegisterBirthday = new DateTimePicker();
            opRegisterAdmin = new RadioButton();
            lblRegisterBirthday = new Label();
            lblRegisterEmail = new Label();
            txtRegisterEmail = new TextBox();
            btnRegister = new Button();
            lblRegisterPassword = new Label();
            txtRegisterPassword = new TextBox();
            lblRegisterUsername = new Label();
            txtRegisterUsername = new TextBox();
            groupRegister.SuspendLayout();
            SuspendLayout();
            // 
            // groupRegister
            // 
            groupRegister.Controls.Add(dateRegisterBirthday);
            groupRegister.Controls.Add(opRegisterAdmin);
            groupRegister.Controls.Add(lblRegisterBirthday);
            groupRegister.Controls.Add(lblRegisterEmail);
            groupRegister.Controls.Add(txtRegisterEmail);
            groupRegister.Controls.Add(btnRegister);
            groupRegister.Controls.Add(lblRegisterPassword);
            groupRegister.Controls.Add(txtRegisterPassword);
            groupRegister.Controls.Add(lblRegisterUsername);
            groupRegister.Controls.Add(txtRegisterUsername);
            groupRegister.Location = new Point(71, 42);
            groupRegister.Margin = new Padding(3, 2, 3, 2);
            groupRegister.Name = "groupRegister";
            groupRegister.Padding = new Padding(3, 2, 3, 2);
            groupRegister.Size = new Size(403, 241);
            groupRegister.TabIndex = 1;
            groupRegister.TabStop = false;
            groupRegister.Text = "Create Account";
            // 
            // dateRegisterBirthday
            // 
            dateRegisterBirthday.Format = DateTimePickerFormat.Short;
            dateRegisterBirthday.Location = new Point(184, 119);
            dateRegisterBirthday.Name = "dateRegisterBirthday";
            dateRegisterBirthday.Size = new Size(106, 23);
            dateRegisterBirthday.TabIndex = 10;
            // 
            // opRegisterAdmin
            // 
            opRegisterAdmin.AutoSize = true;
            opRegisterAdmin.Location = new Point(40, 163);
            opRegisterAdmin.Name = "opRegisterAdmin";
            opRegisterAdmin.Size = new Size(107, 19);
            opRegisterAdmin.TabIndex = 9;
            opRegisterAdmin.TabStop = true;
            opRegisterAdmin.Text = "Check If Admin";
            opRegisterAdmin.UseVisualStyleBackColor = true;
            // 
            // lblRegisterBirthday
            // 
            lblRegisterBirthday.AutoSize = true;
            lblRegisterBirthday.Location = new Point(181, 97);
            lblRegisterBirthday.Name = "lblRegisterBirthday";
            lblRegisterBirthday.Size = new Size(51, 15);
            lblRegisterBirthday.TabIndex = 8;
            lblRegisterBirthday.Text = "Birthday";
            // 
            // lblRegisterEmail
            // 
            lblRegisterEmail.AutoSize = true;
            lblRegisterEmail.Location = new Point(180, 38);
            lblRegisterEmail.Name = "lblRegisterEmail";
            lblRegisterEmail.Size = new Size(36, 15);
            lblRegisterEmail.TabIndex = 6;
            lblRegisterEmail.Text = "Email";
            // 
            // txtRegisterEmail
            // 
            txtRegisterEmail.Location = new Point(180, 56);
            txtRegisterEmail.Margin = new Padding(3, 2, 3, 2);
            txtRegisterEmail.Name = "txtRegisterEmail";
            txtRegisterEmail.Size = new Size(110, 23);
            txtRegisterEmail.TabIndex = 5;
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(39, 200);
            btnRegister.Margin = new Padding(3, 2, 3, 2);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(109, 22);
            btnRegister.TabIndex = 4;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = true;
            // 
            // lblRegisterPassword
            // 
            lblRegisterPassword.AutoSize = true;
            lblRegisterPassword.Location = new Point(40, 97);
            lblRegisterPassword.Name = "lblRegisterPassword";
            lblRegisterPassword.Size = new Size(57, 15);
            lblRegisterPassword.TabIndex = 3;
            lblRegisterPassword.Text = "Password";
            // 
            // txtRegisterPassword
            // 
            txtRegisterPassword.Location = new Point(39, 116);
            txtRegisterPassword.Margin = new Padding(3, 2, 3, 2);
            txtRegisterPassword.Name = "txtRegisterPassword";
            txtRegisterPassword.Size = new Size(110, 23);
            txtRegisterPassword.TabIndex = 2;
            // 
            // lblRegisterUsername
            // 
            lblRegisterUsername.AutoSize = true;
            lblRegisterUsername.Location = new Point(39, 38);
            lblRegisterUsername.Name = "lblRegisterUsername";
            lblRegisterUsername.Size = new Size(60, 15);
            lblRegisterUsername.TabIndex = 1;
            lblRegisterUsername.Text = "Username";
            // 
            // txtRegisterUsername
            // 
            txtRegisterUsername.Location = new Point(39, 56);
            txtRegisterUsername.Margin = new Padding(3, 2, 3, 2);
            txtRegisterUsername.Name = "txtRegisterUsername";
            txtRegisterUsername.Size = new Size(110, 23);
            txtRegisterUsername.TabIndex = 0;
            // 
            // frmRegister
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 192);
            ClientSize = new Size(566, 319);
            Controls.Add(groupRegister);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmRegister";
            Text = "Register";
            groupRegister.ResumeLayout(false);
            groupRegister.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupRegister;
        private DateTimePicker dateRegisterBirthday;
        private RadioButton opRegisterAdmin;
        private Label lblRegisterBirthday;
        private Label lblRegisterEmail;
        private TextBox txtRegisterEmail;
        private Button btnRegister;
        private Label lblRegisterPassword;
        private TextBox txtRegisterPassword;
        private Label lblRegisterUsername;
        private TextBox txtRegisterUsername;
    }
}