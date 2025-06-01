using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;

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
                MessageBox.Show("Conexión exitosa.");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
