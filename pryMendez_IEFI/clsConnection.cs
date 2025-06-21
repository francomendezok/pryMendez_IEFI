using System.Data.OleDb;
using System.Data;
 

namespace pryMendez_IEFI
{
    internal class clsConnection
    {
        private OleDbConnection connection;
        private static string dbPath = null;

        public void Connect()
        {
            try
            {
                if (string.IsNullOrEmpty(dbPath))
                {
                    using (OpenFileDialog openFileDialog = new OpenFileDialog())
                    {
                        openFileDialog.Title = "Select Access Database";
                        openFileDialog.Filter = "Access Database (*.accdb)|*.accdb|All Files (*.*)|*.*";
                        openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

                        if (openFileDialog.ShowDialog() == DialogResult.OK)
                        {
                            dbPath = openFileDialog.FileName;
                        }
                        else
                        {
                            MessageBox.Show("No database file selected.", "Connection Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }
                }

                string connectionString = $@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={dbPath}";
                connection = new OleDbConnection(connectionString);
                connection.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        public bool InsertUser(string username, string password, string email, DateTime birthday, string city, decimal age, bool admin)
        {
            DateTime fecha = birthday;
            fecha = new DateTime(fecha.Year, fecha.Month, fecha.Day);
            string hashedPassword = BCrypt.Net.BCrypt.HashPassword(password);

            try
            {
                Connect();
                string query = "INSERT INTO Users (Username, [Password], Email, Birthday, City, Age, Admin, Elapsed_Total_Time) VALUES (?, ?, ?, ?, ?, ?, ?, ?)";
                using (OleDbCommand cmd = new OleDbCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("?", username);
                    cmd.Parameters.AddWithValue("?", hashedPassword);
                    cmd.Parameters.AddWithValue("?", email);
                    cmd.Parameters.AddWithValue("?", fecha);
                    cmd.Parameters.AddWithValue("?", city);
                    cmd.Parameters.AddWithValue("?", age);
                    cmd.Parameters.AddWithValue("?", admin);
                    cmd.Parameters.AddWithValue("?", "0");     

                    cmd.ExecuteNonQuery();
                }
                connection.Close();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inserting user: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (connection != null && connection.State == ConnectionState.Open)
                    connection.Close();
                return false;
            }
        }

        public bool UserExists(string username)
        {
            try
            {
                Connect();
                string query = "SELECT COUNT(*) FROM Users WHERE Username = ?";
                using (OleDbCommand cmd = new OleDbCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("?", username);
                    int count = (int)cmd.ExecuteScalar();
                    connection.Close();
                    return count > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error checking user: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (connection != null && connection.State == ConnectionState.Open)
                    connection.Close();
                return false;
            }
        }

        public string GetHashedPassword(string username)
        {
            try
            {
                Connect();
                string query = "SELECT [Password] FROM Users WHERE Username = ?";
                using (OleDbCommand cmd = new OleDbCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("?", username);
                    object result = cmd.ExecuteScalar();
                    connection.Close();
                    return result != null ? result.ToString() : null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving user: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (connection != null && connection.State == ConnectionState.Open)
                    connection.Close();
                return null;
            }
        }

        public clsUser GetUserByUsername(string username)
        {
            clsUser user = null;
            OleDbCommand cmd = null;
            OleDbDataReader reader = null;
            try
            {
                Connect();
                string query = "SELECT ID, Username, Email, City, Birthday, Age, Admin FROM Users WHERE Username = ?";
                cmd = new OleDbCommand(query, connection);
                cmd.Parameters.AddWithValue("?", username);
                reader = cmd.ExecuteReader(); // read db and gets data // 
                if (reader.Read())
                {
                    user = new clsUser
                    {
                        Id = reader.GetInt32(reader.GetOrdinal("ID")),
                        Username = reader.GetString(reader.GetOrdinal("Username")),
                        Email = reader.GetString(reader.GetOrdinal("Email")),
                        City = reader.GetString(reader.GetOrdinal("City")),
                        Birthday = reader.GetDateTime(reader.GetOrdinal("Birthday")),
                        Age = reader.GetInt32(reader.GetOrdinal("Age")),
                        Admin = reader.GetBoolean(reader.GetOrdinal("Admin")),
                        Tasks = new List<string>()
                    };
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error fetching user: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (reader != null && !reader.IsClosed)
                    reader.Close();
                if (connection != null && connection.State == ConnectionState.Open)
                    connection.Close();
                if (cmd != null)
                    cmd.Dispose();
            }
            return user;
        }

        public void UpdateElapsedTime(string username, string sessionElapsedTime)
        {
            try
            {
                Connect();

                // 1. Get current elapsed time from DB
                string selectQuery = "SELECT Elapsed_Total_Time FROM Users WHERE Username = ?";
                string currentElapsed = "00:00:00";
                using (var selectCmd = new OleDbCommand(selectQuery, connection))
                {
                    selectCmd.Parameters.AddWithValue("?", username);
                    object result = selectCmd.ExecuteScalar();
                    if (result != null && result != DBNull.Value)
                        currentElapsed = result.ToString();
                }

                // 2. Convert both times to TimeSpan and sum
                TimeSpan previous = TimeSpan.TryParse(currentElapsed, out var prev) ? prev : TimeSpan.Zero;
                TimeSpan current = TimeSpan.TryParse(sessionElapsedTime, out var curr) ? curr : TimeSpan.Zero;
                TimeSpan total = previous + current;
                string totalElapsed = total.ToString(@"hh\:mm\:ss");

                // 3. Update DB with new total
                string updateQuery = "UPDATE Users SET Elapsed_Total_Time = ? WHERE Username = ?";
                using (var updateCmd = new OleDbCommand(updateQuery, connection))
                {
                    updateCmd.Parameters.AddWithValue("?", totalElapsed);
                    updateCmd.Parameters.AddWithValue("?", username);
                    updateCmd.ExecuteNonQuery();
                }

                DateTime fecha = DateTime.Now;
                fecha = new DateTime(fecha.Year, fecha.Month, fecha.Day);

                // 4. Insert into Logs table
                string insertLogQuery = "INSERT INTO Logs (Username, Elapsed_Time, Date_Actual_Time) VALUES (?, ?, ?)";
                using (var logCmd = new OleDbCommand(insertLogQuery, connection))
                {
                    logCmd.Parameters.AddWithValue("?", username);
                    logCmd.Parameters.AddWithValue("?", sessionElapsedTime);
                    logCmd.Parameters.AddWithValue("?", fecha);
                    logCmd.ExecuteNonQuery();
                }

                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating elapsed time: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (connection != null && connection.State == ConnectionState.Open)
                    connection.Close();
            }
        }

        public DataTable GetAllUserInfo()
        {
            DataTable dt = new DataTable();
            try
            {
                Connect();
                string query = "SELECT Email, Birthday, City, Age, Admin FROM Users";
                using (OleDbCommand cmd = new OleDbCommand(query, connection))
                using (OleDbDataAdapter adapter = new OleDbDataAdapter(cmd))
                {
                    adapter.Fill(dt);
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error fetching users: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (connection != null && connection.State == ConnectionState.Open)
                    connection.Close();
            }
            return dt;
        }
        public DataTable GetCompleteUserInfo()
        {
            DataTable dt = new DataTable();
            try
            {
                Connect();
                string query = "SELECT * FROM Users";
                using (OleDbCommand cmd = new OleDbCommand(query, connection))
                using (OleDbDataAdapter adapter = new OleDbDataAdapter(cmd))
                {
                    adapter.Fill(dt);
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error fetching users: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (connection != null && connection.State == ConnectionState.Open)
                    connection.Close();
            }
            return dt;
        }
        public DataTable GetAllUserCredentials()
        {
            DataTable dt = new DataTable();
            try
            {
                Connect();
                string query = "SELECT Username, Password FROM Users";
                using (OleDbCommand cmd = new OleDbCommand(query, connection))
                using (OleDbDataAdapter adapter = new OleDbDataAdapter(cmd))
                {
                    adapter.Fill(dt);
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error fetching users: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (connection != null && connection.State == ConnectionState.Open)
                    connection.Close();
            }
            return dt;
        }
        public DataTable GetAllUserLogs()
        {
            DataTable dt = new DataTable();
            try
            {
                Connect();
                string query = "SELECT Username, Elapsed_Time, Date_Actual_Time FROM Logs";
                using (OleDbCommand cmd = new OleDbCommand(query, connection))
                using (OleDbDataAdapter adapter = new OleDbDataAdapter(cmd))
                {
                    adapter.Fill(dt);
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error fetching users: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (connection != null && connection.State == ConnectionState.Open)
                    connection.Close();
            }
            return dt;
        }

        public void UpdateUser(int id, string username, string email, string city, DateTime birthday, int age, bool admin)
        {
            try
            {
                Connect();
                string query = "UPDATE Users SET Username=?, Email=?, City=?, Birthday=?, Age=?, Admin=? WHERE ID=?";
                using (OleDbCommand cmd = new OleDbCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("?", username);
                    cmd.Parameters.AddWithValue("?", email);
                    cmd.Parameters.AddWithValue("?", city);
                    cmd.Parameters.AddWithValue("?", birthday);
                    cmd.Parameters.AddWithValue("?", age);
                    cmd.Parameters.AddWithValue("?", admin);
                    cmd.Parameters.AddWithValue("?", id);
                    cmd.ExecuteNonQuery();
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating user: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (connection != null && connection.State == ConnectionState.Open)
                    connection.Close();
            }
        }

        public void DeleteUser(int id)
        {
            try
            {
                Connect();
                string query = "DELETE FROM Users WHERE ID=?";
                using (OleDbCommand cmd = new OleDbCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("?", id);
                    cmd.ExecuteNonQuery();
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting user: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (connection != null && connection.State == ConnectionState.Open)
                    connection.Close();
            }
        }
    }
}
