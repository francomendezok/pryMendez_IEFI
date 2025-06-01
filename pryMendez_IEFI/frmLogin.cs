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
            clsConnection conn = new clsConnection();
            conn.Connect();
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
            //bool isValid = BCrypt.Net.BCrypt.Verify(plainPassword, hashedPasswordFromDb);
        }
    }
}
