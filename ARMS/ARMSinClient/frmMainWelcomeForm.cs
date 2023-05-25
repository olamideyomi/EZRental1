using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ARMSinClient
{
    public partial class frmMainWelcomeForm : Form
    {
        public frmMainWelcomeForm()
        {
            InitializeComponent();
        }

        private void frmMainWelcomeForm_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnERP_Click(object sender, EventArgs e)
        {
            frmERPSystemForm objERP = new frmERPSystemForm();

            this.Hide();

            objERP.ShowDialog();

            this.Show();
        }
    }
}
