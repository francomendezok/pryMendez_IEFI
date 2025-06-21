namespace pryMendez_IEFI
{
    public partial class frmMain : Form
    {
        public clsUser CurrentUser { get; set; }

        public frmMain()
        {
            InitializeComponent();
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
                MessageBox.Show("You do not have permission to access this feature.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            else
            {
                this.Hide();
                frmCrud crudForm = new frmCrud();
                crudForm.CurrentUser = this.CurrentUser; // Pass the current user to the CRUD form
                crudForm.ShowDialog();
            }

        }

        private void btnMainLogout_Click(object sender, EventArgs e)
        {
            if (CurrentUser != null)
            {
                CurrentUser.EndSession(); // show total time //
                this.Hide();
                frmLogin loginForm = new frmLogin();
                loginForm.CurrentUser = this.CurrentUser;
                loginForm.ShowDialog();

                // close main form after login form is closed //
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


