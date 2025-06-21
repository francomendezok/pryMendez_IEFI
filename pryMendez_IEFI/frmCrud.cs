namespace pryMendez_IEFI
{

    public partial class frmCrud : Form
    {
        public clsUser CurrentUser { get; set; }

        public frmCrud()
        {
            InitializeComponent();
            this.Load += frmCrud_Load;
            dgvCrudOperations.CellValueChanged += dgvCrudOperations_CellValueChanged;
        }

        private void frmCrud_Load(object sender, EventArgs e)
        {
            LoadUsers();
            dgvCrudOperations.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCrudOperations.AllowUserToAddRows = false;
            dgvCrudOperations.ReadOnly = false; // Allow editing

            // Add Delete button column if not already added
            if (dgvCrudOperations.Columns["btnDelete"] == null)
            {
                DataGridViewButtonColumn btnDelete = new DataGridViewButtonColumn();
                btnDelete.Name = "btnDelete";
                btnDelete.HeaderText = "Delete";
                btnDelete.Text = "Delete";
                btnDelete.UseColumnTextForButtonValue = true;
                dgvCrudOperations.Columns.Add(btnDelete);
            }

            dgvCrudOperations.CellClick += dgvCrudOperations_CellClick;
        }

        private void btnBackToMainCrud_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMain mainForm = new frmMain();
            mainForm.CurrentUser = this.CurrentUser; // Pasa el usuario actual
            mainForm.ShowDialog();
        }

        private void LoadUsers()
        {
            clsConnection db = new clsConnection();
            dgvCrudOperations.DataSource = db.GetCompleteUserInfo(); // Assumes GetAllUserInfo returns all columns you want
        }

        private void dgvCrudOperations_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvCrudOperations.Rows[e.RowIndex];
                int userId = Convert.ToInt32(row.Cells["ID"].Value);

                // Get updated values
                string username = row.Cells["Username"].Value?.ToString();
                string email = row.Cells["Email"].Value?.ToString();
                string city = row.Cells["City"].Value?.ToString();
                DateTime birthday = Convert.ToDateTime(row.Cells["Birthday"].Value);
                int age = Convert.ToInt32(row.Cells["Age"].Value);
                bool admin = Convert.ToBoolean(row.Cells["Admin"].Value);

                clsConnection db = new clsConnection();
                db.UpdateUser(userId, username, email, city, birthday, age, admin);

                MessageBox.Show("User updated successfully.", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            if (dgvCrudOperations.SelectedRows.Count > 0)
            {
                int userId = Convert.ToInt32(dgvCrudOperations.SelectedRows[0].Cells["ID"].Value);
                clsConnection db = new clsConnection();
                db.DeleteUser(userId);
                MessageBox.Show("User deleted successfully.", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadUsers();
            }
        }

        private void dgvCrudOperations_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check if the Delete button column was clicked
            if (e.RowIndex >= 0 && dgvCrudOperations.Columns[e.ColumnIndex].Name == "btnDelete")
            {
                int userId = Convert.ToInt32(dgvCrudOperations.Rows[e.RowIndex].Cells["ID"].Value);

                var confirmResult = MessageBox.Show("Are you sure to delete this user?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirmResult == DialogResult.Yes)
                {
                    clsConnection db = new clsConnection();
                    db.DeleteUser(userId);
                    MessageBox.Show("User deleted successfully.", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadUsers();
                }
            }
        }
    }
}
