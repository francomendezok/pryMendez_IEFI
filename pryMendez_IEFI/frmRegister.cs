using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryMendez_IEFI
{
    public partial class frmRegister : Form
    {
        public frmRegister()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (!ValidateRegisterFields() || !ValidateLengthFields())
            {
                return;
            }

            else
            {
                clsConnection db = new clsConnection();
                bool success = db.InsertUser(
                    txtRegisterUsername.Text,
                    txtRegisterPassword.Text,
                    txtRegisterEmail.Text,
                    dateRegisterBirthday.Value,
                    txtRegisterCity.Text,
                    numRegisterAge.Value,
                    optRegisterAdmin.Checked
                );

                if (success)
                {
                    MessageBox.Show("User registered successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    frmLogin loginForm = new frmLogin();
                    loginForm.ShowDialog();
                }
            }
        }

        private bool ValidateRegisterFields()
        {
            // 1. Username: not empty and does not already exist in the database //
            if (string.IsNullOrWhiteSpace(txtRegisterUsername.Text))
            {
                MessageBox.Show("Username is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else
            {
                clsConnection db = new clsConnection();
                if (db.UserExists(txtRegisterUsername.Text))
                {
                    MessageBox.Show("Username already exists.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }

            // 2. Email: not empty and valid format //
            if (string.IsNullOrWhiteSpace(txtRegisterEmail.Text))
            {
                MessageBox.Show("Email is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else
            {
                var emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
                if (!System.Text.RegularExpressions.Regex.IsMatch(txtRegisterEmail.Text, emailPattern))
                {
                    MessageBox.Show("Email format is invalid.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }

            // 3. Password: not empty and strong (min 8 chars, 1 special char) //
            if (string.IsNullOrWhiteSpace(txtRegisterPassword.Text))
            {
                MessageBox.Show("Password is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else
            {
                var password = txtRegisterPassword.Text;
                if (password.Length < 8 || !password.Any(ch => !char.IsLetterOrDigit(ch)))
                {
                    MessageBox.Show("Password must be at least 8 characters and contain a special character.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }

            // 4. Age: not empty, valid number, and > 0 //
            if (string.IsNullOrWhiteSpace(numRegisterAge.Text) || !int.TryParse(numRegisterAge.Text, out int age) || age <= 0)
            {
                MessageBox.Show("Age must be a valid positive number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // 5. Birthday: valid date and < today //
            if (dateRegisterBirthday.Value >= DateTime.Today)
            {
                MessageBox.Show("Birthday must be a valid date before today.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // 6. City: not empty //
            if (string.IsNullOrWhiteSpace(txtRegisterCity.Text))
            {
                MessageBox.Show("City is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private bool ValidateLengthFields()
        {
            if (txtRegisterUsername.Text.Length < 3 || txtRegisterUsername.Text.Length > 20)
            {
                MessageBox.Show("Username must be between 3 and 20 characters.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (txtRegisterPassword.Text.Length < 8 || txtRegisterPassword.Text.Length > 16)
            {
                MessageBox.Show("Password must be between 8 and 16 characters.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (txtRegisterCity.Text.Length < 2 || txtRegisterCity.Text.Length > 20)
            {
                MessageBox.Show("City must be between 2 and 20 characters.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
        private void txtRegisterPassword_TextChanged(object sender, EventArgs e)
        {
            txtRegisterPassword.PasswordChar = '*';
        }

        private void frmRegister_Load(object sender, EventArgs e)
        {

        }
    }
}
