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
            numRegisterAge = new NumericUpDown();
            lblRegisterAge = new Label();
            lblRegisterCity = new Label();
            txtRegisterCity = new TextBox();
            dateRegisterBirthday = new DateTimePicker();
            optRegisterAdmin = new RadioButton();
            lblRegisterBirthday = new Label();
            lblRegisterEmail = new Label();
            txtRegisterEmail = new TextBox();
            btnRegister = new Button();
            lblRegisterPassword = new Label();
            txtRegisterPassword = new TextBox();
            lblRegisterUsername = new Label();
            txtRegisterUsername = new TextBox();
            groupRegister.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numRegisterAge).BeginInit();
            SuspendLayout();
            // 
            // groupRegister
            // 
            groupRegister.Controls.Add(numRegisterAge);
            groupRegister.Controls.Add(lblRegisterAge);
            groupRegister.Controls.Add(lblRegisterCity);
            groupRegister.Controls.Add(txtRegisterCity);
            groupRegister.Controls.Add(dateRegisterBirthday);
            groupRegister.Controls.Add(optRegisterAdmin);
            groupRegister.Controls.Add(lblRegisterBirthday);
            groupRegister.Controls.Add(lblRegisterEmail);
            groupRegister.Controls.Add(txtRegisterEmail);
            groupRegister.Controls.Add(btnRegister);
            groupRegister.Controls.Add(lblRegisterPassword);
            groupRegister.Controls.Add(txtRegisterPassword);
            groupRegister.Controls.Add(lblRegisterUsername);
            groupRegister.Controls.Add(txtRegisterUsername);
            groupRegister.Location = new Point(81, 56);
            groupRegister.Name = "groupRegister";
            groupRegister.Size = new Size(528, 321);
            groupRegister.TabIndex = 1;
            groupRegister.TabStop = false;
            groupRegister.Text = "Create Account";
            // 
            // numRegisterAge
            // 
            numRegisterAge.Location = new Point(353, 155);
            numRegisterAge.Name = "numRegisterAge";
            numRegisterAge.Size = new Size(125, 27);
            numRegisterAge.TabIndex = 5;
            numRegisterAge.Value = new decimal(new int[] { 18, 0, 0, 0 });
            // 
            // lblRegisterAge
            // 
            lblRegisterAge.AutoSize = true;
            lblRegisterAge.Location = new Point(353, 129);
            lblRegisterAge.Name = "lblRegisterAge";
            lblRegisterAge.Size = new Size(36, 20);
            lblRegisterAge.TabIndex = 13;
            lblRegisterAge.Text = "Age";
            // 
            // lblRegisterCity
            // 
            lblRegisterCity.AutoSize = true;
            lblRegisterCity.Location = new Point(353, 51);
            lblRegisterCity.Name = "lblRegisterCity";
            lblRegisterCity.Size = new Size(34, 20);
            lblRegisterCity.TabIndex = 12;
            lblRegisterCity.Text = "City";
            // 
            // txtRegisterCity
            // 
            txtRegisterCity.Location = new Point(353, 75);
            txtRegisterCity.Name = "txtRegisterCity";
            txtRegisterCity.Size = new Size(125, 27);
            txtRegisterCity.TabIndex = 2;
            // 
            // dateRegisterBirthday
            // 
            dateRegisterBirthday.Format = DateTimePickerFormat.Short;
            dateRegisterBirthday.Location = new Point(210, 159);
            dateRegisterBirthday.Margin = new Padding(3, 4, 3, 4);
            dateRegisterBirthday.Name = "dateRegisterBirthday";
            dateRegisterBirthday.Size = new Size(121, 27);
            dateRegisterBirthday.TabIndex = 4;
            // 
            // optRegisterAdmin
            // 
            optRegisterAdmin.AutoSize = true;
            optRegisterAdmin.Location = new Point(46, 217);
            optRegisterAdmin.Margin = new Padding(3, 4, 3, 4);
            optRegisterAdmin.Name = "optRegisterAdmin";
            optRegisterAdmin.Size = new Size(130, 24);
            optRegisterAdmin.TabIndex = 6;
            optRegisterAdmin.TabStop = true;
            optRegisterAdmin.Text = "Check If Admin";
            optRegisterAdmin.UseVisualStyleBackColor = true;
            // 
            // lblRegisterBirthday
            // 
            lblRegisterBirthday.AutoSize = true;
            lblRegisterBirthday.Location = new Point(207, 129);
            lblRegisterBirthday.Name = "lblRegisterBirthday";
            lblRegisterBirthday.Size = new Size(64, 20);
            lblRegisterBirthday.TabIndex = 8;
            lblRegisterBirthday.Text = "Birthday";
            // 
            // lblRegisterEmail
            // 
            lblRegisterEmail.AutoSize = true;
            lblRegisterEmail.Location = new Point(206, 51);
            lblRegisterEmail.Name = "lblRegisterEmail";
            lblRegisterEmail.Size = new Size(46, 20);
            lblRegisterEmail.TabIndex = 6;
            lblRegisterEmail.Text = "Email";
            // 
            // txtRegisterEmail
            // 
            txtRegisterEmail.Location = new Point(206, 75);
            txtRegisterEmail.Name = "txtRegisterEmail";
            txtRegisterEmail.Size = new Size(125, 27);
            txtRegisterEmail.TabIndex = 1;
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(45, 267);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(125, 29);
            btnRegister.TabIndex = 7;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // lblRegisterPassword
            // 
            lblRegisterPassword.AutoSize = true;
            lblRegisterPassword.Location = new Point(46, 129);
            lblRegisterPassword.Name = "lblRegisterPassword";
            lblRegisterPassword.Size = new Size(70, 20);
            lblRegisterPassword.TabIndex = 3;
            lblRegisterPassword.Text = "Password";
            // 
            // txtRegisterPassword
            // 
            txtRegisterPassword.Location = new Point(45, 155);
            txtRegisterPassword.Name = "txtRegisterPassword";
            txtRegisterPassword.Size = new Size(125, 27);
            txtRegisterPassword.TabIndex = 3;
            txtRegisterPassword.TextChanged += txtRegisterPassword_TextChanged;
            // 
            // lblRegisterUsername
            // 
            lblRegisterUsername.AutoSize = true;
            lblRegisterUsername.Location = new Point(45, 51);
            lblRegisterUsername.Name = "lblRegisterUsername";
            lblRegisterUsername.Size = new Size(75, 20);
            lblRegisterUsername.TabIndex = 1;
            lblRegisterUsername.Text = "Username";
            // 
            // txtRegisterUsername
            // 
            txtRegisterUsername.Location = new Point(45, 75);
            txtRegisterUsername.Name = "txtRegisterUsername";
            txtRegisterUsername.Size = new Size(125, 27);
            txtRegisterUsername.TabIndex = 0;
            // 
            // frmRegister
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 192);
            ClientSize = new Size(647, 425);
            Controls.Add(groupRegister);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmRegister";
            Text = "Register";
            Load += frmRegister_Load;
            groupRegister.ResumeLayout(false);
            groupRegister.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numRegisterAge).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupRegister;
        private DateTimePicker dateRegisterBirthday;
        private RadioButton optRegisterAdmin;
        private Label lblRegisterBirthday;
        private Label lblRegisterEmail;
        private TextBox txtRegisterEmail;
        private Button btnRegister;
        private Label lblRegisterPassword;
        private TextBox txtRegisterPassword;
        private Label lblRegisterUsername;
        private TextBox txtRegisterUsername;
        private Label lblRegisterCity;
        private TextBox txtRegisterCity;
        private Label lblRegisterAge;
        private NumericUpDown numRegisterAge;
    }
}