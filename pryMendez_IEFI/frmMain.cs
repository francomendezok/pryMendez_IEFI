namespace pryMendez_IEFI
{
    public partial class frmMain : Form
    {
        public clsUser CurrentUser { get; set; }

        public frmMain()
        {
            InitializeComponent();
            // override y piso el metodo Load del formulario, le hago un append
            this.FormClosing += frmMain_FormClosing;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            lblMainUsername.Text = $"Username: {CurrentUser.Username}";
            lblWelcome.Text = $"Welcome back, {CurrentUser.Username}!";
            lblMainUserStatus.Text = $"User Status: {(CurrentUser.Admin ? "Admin" : "User")}";
            lblMainDate.Text = $"Date: {DateTime.Now.ToShortDateString()}";
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (CurrentUser != null)
            {
                // al cerrar el formulario, se finaliza la sesion del usuario
                CurrentUser.EndSession();
            }
        }

        private void lblMainUsername_Click(object sender, EventArgs e)
        {
        }

        private void stripMainCrud_Click(object sender, EventArgs e)
        {
            if (CurrentUser == null)
            {
                MessageBox.Show("No user is currently logged in.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (!CurrentUser.Admin)
            {
                // solo los administradores pueden acceder a la funcionalidad de CRUD
                MessageBox.Show("You do not have permission to access this feature.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            else
            {
                this.Hide();
                frmCrud crudForm = new frmCrud();
                // paso el usuario actual al formulario de CRUD
                crudForm.CurrentUser = this.CurrentUser; 
                crudForm.ShowDialog();
            }

        }

        private void btnMainLogout_Click(object sender, EventArgs e)
        {
            if (CurrentUser != null)
            {
                CurrentUser.EndSession(); // muestra el tiempo de sesion al cerrar el formulario
                this.Hide();
                frmLogin loginForm = new frmLogin();
                loginForm.CurrentUser = this.CurrentUser;
                loginForm.ShowDialog();

                //cierra form main al cerrar el formulario de login, 
                this.Close();
            }
            else
            {
                MessageBox.Show("No user is currently logged in.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void stripMainAuditoria_Click(object sender, EventArgs e)
        {
            if (CurrentUser == null)
            {
                MessageBox.Show("No user is currently logged in.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (!CurrentUser.Admin)
            {
                MessageBox.Show("You do not have permission to access this feature.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            else
            {
                this.Hide();
                frmAuditoria auditoriaForm = new frmAuditoria();
                auditoriaForm.CurrentUser = this.CurrentUser;
                auditoriaForm.ShowDialog();
            }
        }
    }
}


