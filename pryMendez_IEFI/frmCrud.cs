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
            // agrego el evento CellValueChanged para detectar cambios en las celdas
            // y actualizar la informacion del usuario en el CRUD
        }

        private void frmCrud_Load(object sender, EventArgs e)
        {
            LoadUsers(); // muestra la lista de usuarios al cargar el formulario
            dgvCrudOperations.SelectionMode = DataGridViewSelectionMode.FullRowSelect; // permite seleccionar filas completas
            dgvCrudOperations.AllowUserToAddRows = false; // no permite agregar filas nuevas directamente
            dgvCrudOperations.ReadOnly = false; // permite editar las celdas de la grilla

            // agrego las columnas delete
            if (dgvCrudOperations.Columns["btnDelete"] == null)
            {
                DataGridViewButtonColumn btnDelete = new DataGridViewButtonColumn();
                btnDelete.Name = "btnDelete";
                btnDelete.HeaderText = "Delete";
                btnDelete.Text = "Delete";
                btnDelete.UseColumnTextForButtonValue = true; // permite que el texto del boton sea "Delete"
                dgvCrudOperations.Columns.Add(btnDelete);
            }

            dgvCrudOperations.CellClick += dgvCrudOperations_CellClick; // evento para detectar cuando se hace click en el boton de eliminar
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
            dgvCrudOperations.DataSource = db.GetCompleteUserInfo(); // lleno la grilla con la informacion de los usuarios
        }

        private void dgvCrudOperations_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // uso el evento global
            {
                DataGridViewRow row = dgvCrudOperations.Rows[e.RowIndex];
                int userId = Convert.ToInt32(row.Cells["ID"].Value);

                // obtengo los valores de las celdas editadas
                string username = row.Cells["Username"].Value?.ToString();
                string email = row.Cells["Email"].Value?.ToString();
                string city = row.Cells["City"].Value?.ToString();
                DateTime birthday = Convert.ToDateTime(row.Cells["Birthday"].Value);
                int age = Convert.ToInt32(row.Cells["Age"].Value);
                bool admin = Convert.ToBoolean(row.Cells["Admin"].Value);

                clsConnection db = new clsConnection();
                // actualizo la informacion del usuario en la base de datos
                db.UpdateUser(userId, username, email, city, birthday, age, admin);

                MessageBox.Show("User updated successfully.", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            if (dgvCrudOperations.SelectedRows.Count > 0) // si hay una fila seleccionada
            {
                int userId = Convert.ToInt32(dgvCrudOperations.SelectedRows[0].Cells["ID"].Value);
                clsConnection db = new clsConnection();
                // elimino el usuario seleccionado
                db.DeleteUser(userId);
                MessageBox.Show("User deleted successfully.", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // recargo la lista de usuarios
                LoadUsers();
            }
        }

        private void dgvCrudOperations_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // chequeo si se hizo click en el boton de eliminar
            if (e.RowIndex >= 0 && dgvCrudOperations.Columns[e.ColumnIndex].Name == "btnDelete")
            {
                int userId = Convert.ToInt32(dgvCrudOperations.Rows[e.RowIndex].Cells["ID"].Value);

                var confirmResult = MessageBox.Show("Are you sure to delete this user?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirmResult == DialogResult.Yes) // si le doy si al eliminar
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
