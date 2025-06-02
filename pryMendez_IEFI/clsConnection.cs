using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;
using System.Windows.Forms;
using BCrypt.Net; 

namespace pryMendez_IEFI
{
    internal class clsConnection
    {
        private OleDbConnection connection;

        public void Connect()
        {
            try
            {
                // Corrected connection string with proper escaping of backslashes
                string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\PCFRANCO\Desktop\pryMendez_IEFI\pryMendez_IEFI\bin\Debug\iefi.accdb";

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
                string query = "INSERT INTO Users (Username, [Password], Email, Birthday, City, Age, Admin, Elapsed_Time) VALUES (?, ?, ?, ?, ?, ?, ?, ?)";
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
    }
}
