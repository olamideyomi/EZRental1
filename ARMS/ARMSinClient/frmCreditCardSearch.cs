using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ARMSBOLayer;

namespace ARMSinClient
{
    public partial class frmCreditCardSearch : Form
    {
        public frmCreditCardSearch()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                CreditCard objCreditCard = new CreditCard();


                if (objCreditCard.Load(txtCardNumberSearch.Text.Trim()))
                {
                    txtCardNumberSearch.Text = objCreditCard.CreditCardNumber;
                    txtCCNumber.Text = objCreditCard.CreditCardNumber;
                    txtCOName.Text = objCreditCard.CreditCardOwnerName;
                    txtCCCompany.Text = objCreditCard.CreditCardIssuingCompany;
                    txtMerchantName.Text = objCreditCard.MerchantName;
                    txtExpDate.Text = objCreditCard.ExpDate.ToString();
                    txtAddr1.Text = objCreditCard.AddressLine1;
                    txtAddr2.Text = objCreditCard.AddressLine2;
                    txtCity.Text = objCreditCard.City;
                    txtState.Text = objCreditCard.StateCode;
                    txtZipCode.Text = objCreditCard.ZipCode;
                    txtCountry.Text = objCreditCard.Country;
                    txtCCLimit.Text = objCreditCard.CreditCardLimit.ToString();
                    txtCCBalance.Text = objCreditCard.CreditCardBalance.ToString();
                    cbActivationStatus.Text = objCreditCard.ActivationStatus.ToString();
                }
                else
                {
                    MessageBox.Show("Credit Card Not Found");

                }
            }

            catch (Exception objE)
            {
                //Step C- Respond to user with message;
                MessageBox.Show("Error in search!" + objE);
            }
        }

        private void frmCreditCardSearch_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnPrint_Click(object sender, EventArgs e)
        {
            CreditCard objCreditCard = new CreditCard();
            try
            {

                if (objCreditCard.Load(txtCardNumberSearch.Text.Trim()))
                {
                    objCreditCard.Print();
                }
                else
                {
                    MessageBox.Show("not Found");
                }
            }
            catch (System.Exception)
            {
                MessageBox.Show("Error in your search");
            }
        }


        private void txtExpDate_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void txtCCCompany_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}
    
