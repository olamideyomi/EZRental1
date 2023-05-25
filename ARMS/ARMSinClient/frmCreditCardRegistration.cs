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
    public partial class frmCreditCardRegistration : Form
    {
        public frmCreditCardRegistration()
        {
            InitializeComponent();
        }

        private void frmCreditCardRegistration_Load(object sender, EventArgs e)
        {
            cbState.DataSource = USState.GetAllUSStates();
            cbState.DisplayMember = "StateName";
            cbState.ValueMember = "StateCode";

            cbCountry.DataSource = Country.GetAllCountries();
            cbCountry.DisplayMember = "CountryName";
            cbCountry.ValueMember = "CountryName";

            cbMerchantCode.DataSource = CreditCardMerchant.GetAllCreditCardMerchants();
            cbMerchantCode.DisplayMember = "MerchantCode";
            cbMerchantCode.ValueMember = "MerchantCode";

            CreditCard objCreditCard = new CreditCard();
            txtCreditCardBalance.Text = Convert.ToString(objCreditCard.CreditCardLimit); ;
            txtCreditCardLimit.Text = Convert.ToString(objCreditCard.CreditCardBalance);

            cbActivationStatus.Items.Add("Activate");
            cbActivationStatus.Items.Add("Deactivate");

            cbActivationStatus.SelectedText = "Activate";
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbState_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbActivationStatus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            try
            {
                CreditCard objCreditCard = new CreditCard();

                objCreditCard.CreditCardNumber = txtCCNumber.Text.Trim();
                objCreditCard.CreditCardOwnerName = txtCOName.Text.Trim();
                objCreditCard.CreditCardIssuingCompany = txtCCCompany.Text.Trim();
                objCreditCard.MerchantCode = Convert.ToByte(cbMerchantCode.SelectedValue);
                objCreditCard.ExpDate = Convert.ToDateTime(dtpExpDate.Text);
                objCreditCard.AddressLine1 = txtAddr1.Text.Trim();
                objCreditCard.AddressLine2 = txtAddr2.Text.Trim();
                objCreditCard.City = txtCity.Text.Trim();
                objCreditCard.StateCode = cbState.SelectedValue.ToString();
                objCreditCard.ZipCode = txtZipCode.Text.Trim();
                objCreditCard.Country = cbCountry.SelectedValue.ToString();
                objCreditCard.CreditCardLimit = Convert.ToDecimal(txtCreditCardLimit.Text);
                objCreditCard.CreditCardBalance = Convert.ToDecimal(txtCreditCardBalance.Text);

                string activationStatus = Convert.ToString(cbActivationStatus.SelectedItem);
                if (activationStatus == "Activate")
                {
                    objCreditCard.Activate();
                }
                else
                {
                    objCreditCard.Deactivate();
                }

                bool success = objCreditCard.Insert();

                if (success)
                {
                    MessageBox.Show("Credit Card Succefully inserted");

                    txtCCNumber.Text = "";
                    txtCOName.Text = "";
                    txtCCCompany.Text = "";
                    cbMerchantCode.Text = "";
                    dtpExpDate.Text = "";
                    txtAddr1.Text = "";
                    txtAddr2.Text = "";
                    txtCity.Text = "";
                    cbState.Text = "";
                    txtZipCode.Text = "";
                    cbCountry.Text = "";
                    txtCreditCardLimit.Text = "";
                    txtCreditCardBalance.Text = "";
                    cbActivationStatus.Text = "";

                }
                else
                {
                    MessageBox.Show("Error! Credit Card was not added, please contact administrator");
                }
            }
            catch (Exception ObjE)
            {
                MessageBox.Show("Error! Credit Card was not added!" + ObjE);
            }
        }

    }
}

    
