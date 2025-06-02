using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryMendez_IEFI
{
    public partial class frmMain : Form
    {
        public clsUser CurrentUser { get; set; }

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            if (CurrentUser != null)
            {
                MessageBox.Show($"Welcome, {CurrentUser.Username}!, {CurrentUser.Email}, {CurrentUser.Admin}, {CurrentUser.Age}", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lblMainUsername.Text = CurrentUser.Username;
                // Use other properties as needed
            }
            else
            {
               MessageBox.Show("No user is currently logged in.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lblMainUsername_Click(object sender, EventArgs e)
        {
        }
    }
}
