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

    public partial class frmCrud : Form
    {
        public clsUser CurrentUser { get; set; }

        public frmCrud()
        {
            InitializeComponent();
        }

        private void frmCrud_Load(object sender, EventArgs e)
        {

        }

        private void btnBackToMainCrud_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMain mainForm = new frmMain();
            mainForm.CurrentUser = this.CurrentUser; // Pasa el usuario actual
            mainForm.ShowDialog();
        }
    }
}
