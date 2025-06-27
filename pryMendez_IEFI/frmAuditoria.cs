namespace pryMendez_IEFI
{
    public partial class frmAuditoria : Form
    {
        public clsUser CurrentUser { get; set; }
        private clsConnection connection;

        public frmAuditoria()
        {
            InitializeComponent();
            this.Load += frmAuditoria_Load;
        }

        private void btnBackToMain_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMain mainForm = new frmMain();
            mainForm.CurrentUser = this.CurrentUser; // Pasa el usuario actual
            mainForm.ShowDialog();
        }

        private void tabPageUserInfo_Click(object sender, EventArgs e)
        {
        }

        private void frmAuditoria_Load(object sender, EventArgs e)
        {
            // lleno las tabla con mi base de datos, ajusto la vista de cada dgv
            clsConnection db = new clsConnection();
            dgvUserInfo.DataSource = db.GetAllUserInfo();
            dgvUserCredentials.DataSource = db.GetAllUserCredentials();
            dgvUserLogs.DataSource = db.GetAllUserLogs();
            ReframeDataGridViewColumns();
        }

        private void ReframeDataGridViewColumns()
        {
            int logsColumns = dgvUserLogs.Width / 3;
            int credentialsColumns = dgvUserCredentials.Width / 2;
            int userInfoColumns = dgvUserInfo.Width / 5;
            foreach (DataGridViewColumn col in dgvUserLogs.Columns)
            {
                col.Width = logsColumns;
            }
            foreach (DataGridViewColumn col in dgvUserCredentials.Columns)
            {
                col.Width = credentialsColumns;
            }
            foreach (DataGridViewColumn col in dgvUserInfo.Columns)
            {
                col.Width = userInfoColumns;
            }
        }
    }
}


