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
    public partial class frmCreditCardMSForm : Form
    {
        public frmCreditCardMSForm()
        {
            InitializeComponent();
        }

        private void frmCreditCardMSForm_Load(object sender, EventArgs e)
        {

        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            frmCreditCardSearch objCSearch = new frmCreditCardSearch();

            this.Hide();

            objCSearch.ShowDialog();

            this.Show();
        }
        private void btnRegistration_Click(object sender, EventArgs e)
        {
            frmCreditCardRegistration objCRegister = new frmCreditCardRegistration();

            this.Hide();

            objCRegister.ShowDialog();

            this.Show();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
