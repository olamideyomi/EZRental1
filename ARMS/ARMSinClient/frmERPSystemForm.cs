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
    public partial class frmERPSystemForm : Form
    {
        public frmERPSystemForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmERPSystemForm_Load(object sender, EventArgs e)
        {

        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnCreditCardMS_Click(object sender, EventArgs e)
        {
            frmCreditCardMSForm objCMS = new frmCreditCardMSForm();

            this.Hide();

            objCMS.ShowDialog();

            this.Show();
        }

    }
}
