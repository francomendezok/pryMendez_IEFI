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
            // valido que los campos de registro y su longitud sean correctos 
            if (!ValidateRegisterFields() || !ValidateLengthFields())
            {
                return;
            }

            else
            {
                // si esta todo bien, insert el usuario en la base de datos 
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
                    // se puede loguear
                    loginForm.ShowDialog();
                }
            }
        }

        private bool ValidateRegisterFields()
        {
            // 1. valido usuario
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
                    // ya existe el usuario 
                    MessageBox.Show("Username already exists.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }

            // 2. valido email
            if (string.IsNullOrWhiteSpace(txtRegisterEmail.Text))
            {
                MessageBox.Show("Email is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else
            {
                // regex validacion
                var emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
                if (!System.Text.RegularExpressions.Regex.IsMatch(txtRegisterEmail.Text, emailPattern))
                {
                    MessageBox.Show("Email format is invalid.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }

            // 3. valido contraseña (min 8 chars, 1 special char) 
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

            // 4. valido edad
            if (string.IsNullOrWhiteSpace(numRegisterAge.Text) || !int.TryParse(numRegisterAge.Text, out int age) || age <= 0)
            {
                MessageBox.Show("Age must be a valid positive number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // 5. valido fecha de nacimiento
            if (dateRegisterBirthday.Value >= DateTime.Today)
            {
                MessageBox.Show("Birthday must be a valid date before today.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // 6. valido ciudad
            if (string.IsNullOrWhiteSpace(txtRegisterCity.Text))
            {
                MessageBox.Show("City is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private bool ValidateLengthFields()
        {
            // valido que los campos tengan la longitud correcta
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
            // por seguridad, oculto la contraseña
            txtRegisterPassword.PasswordChar = '*';
        }
    }
}
