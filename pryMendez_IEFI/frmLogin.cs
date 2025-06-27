namespace pryMendez_IEFI
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        public clsUser CurrentUser { get; set; }
        // usuario actual que se está utilizando en la sesión

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            
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
            // obtengo la contraseña hasheada del usuario ingresado

            if (hashedPassword == null)
            {
                MessageBox.Show("User does not exist.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool isValid = BCrypt.Net.BCrypt.Verify(password, hashedPassword);
            // verifico si la contraseña ingresada coincide con la hasheada

            if (isValid)
            {
                clsUser user = db.GetUserByUsername(username);

                if (user != null)
                {
                    user.StartSession(); // empiezo a contar el tiempo de sesión

                    MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Hide();
                    frmMain mainForm = new frmMain();
                    mainForm.CurrentUser = user; // paso el usuario actual al formulario principal
                    mainForm.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Could not retrieve user data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Incorrect password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
