namespace pryMendez_IEFI
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            //clsConnection conn = new clsConnection();
            //conn.Connect();
        }

        private void btnGoRegister_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmRegister registerForm = new frmRegister();
            registerForm.ShowDialog();
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = '*';
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            clsConnection db = new clsConnection();
            string hashedPassword = db.GetHashedPassword(username);

            if (hashedPassword == null)
            {
                MessageBox.Show("User does not exist.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool isValid = BCrypt.Net.BCrypt.Verify(password, hashedPassword);

            if (isValid)
            {
                MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clsConnection conn = new clsConnection();
                clsUser user = conn.GetUserByUsername(username);

                this.Hide();
                frmMain mainForm = new frmMain();
                mainForm.CurrentUser = user; // Pass the user via property
                mainForm.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Incorrect password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
