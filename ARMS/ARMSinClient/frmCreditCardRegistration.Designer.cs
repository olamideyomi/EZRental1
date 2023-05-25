
namespace ARMSinClient
{
    partial class frmCreditCardRegistration
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblMerchantCode = new System.Windows.Forms.Label();
            this.cbActivationStatus = new System.Windows.Forms.ComboBox();
            this.btnApply = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.cbCountry = new System.Windows.Forms.ComboBox();
            this.cbState = new System.Windows.Forms.ComboBox();
            this.dtpExpDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.lblActiveStatus = new System.Windows.Forms.Label();
            this.txtCreditCardBalance = new System.Windows.Forms.TextBox();
            this.lblCCBalance = new System.Windows.Forms.Label();
            this.txtCreditCardLimit = new System.Windows.Forms.TextBox();
            this.lblCCLimit = new System.Windows.Forms.Label();
            this.lblCountry = new System.Windows.Forms.Label();
            this.txtZipCode = new System.Windows.Forms.TextBox();
            this.lblZipCode = new System.Windows.Forms.Label();
            this.lblState = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.lblCity = new System.Windows.Forms.Label();
            this.txtAddr2 = new System.Windows.Forms.TextBox();
            this.lblAddr2 = new System.Windows.Forms.Label();
            this.txtAddr1 = new System.Windows.Forms.TextBox();
            this.lblAddr1 = new System.Windows.Forms.Label();
            this.lblExpDate = new System.Windows.Forms.Label();
            this.txtCCCompany = new System.Windows.Forms.TextBox();
            this.lblCCCompany = new System.Windows.Forms.Label();
            this.txtCOName = new System.Windows.Forms.TextBox();
            this.lblCOName = new System.Windows.Forms.Label();
            this.lblSTitle2 = new System.Windows.Forms.Label();
            this.txtCCNumber = new System.Windows.Forms.TextBox();
            this.lblCCNumber = new System.Windows.Forms.Label();
            this.cbMerchantCode = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblMerchantCode
            // 
            this.lblMerchantCode.AutoSize = true;
            this.lblMerchantCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMerchantCode.Location = new System.Drawing.Point(13, 153);
            this.lblMerchantCode.Name = "lblMerchantCode";
            this.lblMerchantCode.Size = new System.Drawing.Size(80, 13);
            this.lblMerchantCode.TabIndex = 98;
            this.lblMerchantCode.Text = "Merchant Code";
            // 
            // cbActivationStatus
            // 
            this.cbActivationStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbActivationStatus.FormattingEnabled = true;
            this.cbActivationStatus.Location = new System.Drawing.Point(151, 412);
            this.cbActivationStatus.Name = "cbActivationStatus";
            this.cbActivationStatus.Size = new System.Drawing.Size(121, 21);
            this.cbActivationStatus.TabIndex = 97;
            this.cbActivationStatus.SelectedIndexChanged += new System.EventHandler(this.cbActivationStatus_SelectedIndexChanged);
            // 
            // btnApply
            // 
            this.btnApply.Location = new System.Drawing.Point(390, 443);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(75, 23);
            this.btnApply.TabIndex = 96;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(276, 443);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 95;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // cbCountry
            // 
            this.cbCountry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCountry.FormattingEnabled = true;
            this.cbCountry.Location = new System.Drawing.Point(151, 334);
            this.cbCountry.Name = "cbCountry";
            this.cbCountry.Size = new System.Drawing.Size(121, 21);
            this.cbCountry.TabIndex = 94;
            // 
            // cbState
            // 
            this.cbState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbState.FormattingEnabled = true;
            this.cbState.Location = new System.Drawing.Point(151, 281);
            this.cbState.Name = "cbState";
            this.cbState.Size = new System.Drawing.Size(121, 21);
            this.cbState.TabIndex = 93;
            this.cbState.SelectedIndexChanged += new System.EventHandler(this.cbState_SelectedIndexChanged);
            // 
            // dtpExpDate
            // 
            this.dtpExpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpExpDate.Location = new System.Drawing.Point(151, 178);
            this.dtpExpDate.Name = "dtpExpDate";
            this.dtpExpDate.Size = new System.Drawing.Size(121, 20);
            this.dtpExpDate.TabIndex = 92;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 20);
            this.label1.TabIndex = 91;
            this.label1.Text = "Credit Card Registration";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblActiveStatus
            // 
            this.lblActiveStatus.AutoSize = true;
            this.lblActiveStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActiveStatus.Location = new System.Drawing.Point(13, 415);
            this.lblActiveStatus.Name = "lblActiveStatus";
            this.lblActiveStatus.Size = new System.Drawing.Size(87, 13);
            this.lblActiveStatus.TabIndex = 90;
            this.lblActiveStatus.Text = "Activation Status";
            // 
            // txtCreditCardBalance
            // 
            this.txtCreditCardBalance.Location = new System.Drawing.Point(151, 386);
            this.txtCreditCardBalance.Name = "txtCreditCardBalance";
            this.txtCreditCardBalance.Size = new System.Drawing.Size(100, 20);
            this.txtCreditCardBalance.TabIndex = 89;
            this.txtCreditCardBalance.Text = "3000.00";
            // 
            // lblCCBalance
            // 
            this.lblCCBalance.AutoSize = true;
            this.lblCCBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCCBalance.Location = new System.Drawing.Point(13, 389);
            this.lblCCBalance.Name = "lblCCBalance";
            this.lblCCBalance.Size = new System.Drawing.Size(101, 13);
            this.lblCCBalance.TabIndex = 88;
            this.lblCCBalance.Text = "Credit Card Balance";
            // 
            // txtCreditCardLimit
            // 
            this.txtCreditCardLimit.Location = new System.Drawing.Point(151, 360);
            this.txtCreditCardLimit.Name = "txtCreditCardLimit";
            this.txtCreditCardLimit.Size = new System.Drawing.Size(100, 20);
            this.txtCreditCardLimit.TabIndex = 87;
            this.txtCreditCardLimit.Text = "3000.00";
            // 
            // lblCCLimit
            // 
            this.lblCCLimit.AutoSize = true;
            this.lblCCLimit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCCLimit.Location = new System.Drawing.Point(13, 363);
            this.lblCCLimit.Name = "lblCCLimit";
            this.lblCCLimit.Size = new System.Drawing.Size(83, 13);
            this.lblCCLimit.TabIndex = 86;
            this.lblCCLimit.Text = "Credit Card Limit";
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountry.Location = new System.Drawing.Point(13, 337);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(43, 13);
            this.lblCountry.TabIndex = 85;
            this.lblCountry.Text = "Country";
            // 
            // txtZipCode
            // 
            this.txtZipCode.Location = new System.Drawing.Point(151, 308);
            this.txtZipCode.Name = "txtZipCode";
            this.txtZipCode.Size = new System.Drawing.Size(100, 20);
            this.txtZipCode.TabIndex = 84;
            // 
            // lblZipCode
            // 
            this.lblZipCode.AutoSize = true;
            this.lblZipCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblZipCode.Location = new System.Drawing.Point(13, 311);
            this.lblZipCode.Name = "lblZipCode";
            this.lblZipCode.Size = new System.Drawing.Size(50, 13);
            this.lblZipCode.TabIndex = 83;
            this.lblZipCode.Text = "Zip Code";
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblState.Location = new System.Drawing.Point(13, 285);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(32, 13);
            this.lblState.TabIndex = 82;
            this.lblState.Text = "State";
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(151, 256);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(100, 20);
            this.txtCity.TabIndex = 81;
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCity.Location = new System.Drawing.Point(13, 259);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(24, 13);
            this.lblCity.TabIndex = 80;
            this.lblCity.Text = "City";
            // 
            // txtAddr2
            // 
            this.txtAddr2.Location = new System.Drawing.Point(151, 230);
            this.txtAddr2.Name = "txtAddr2";
            this.txtAddr2.Size = new System.Drawing.Size(100, 20);
            this.txtAddr2.TabIndex = 79;
            // 
            // lblAddr2
            // 
            this.lblAddr2.AutoSize = true;
            this.lblAddr2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddr2.Location = new System.Drawing.Point(13, 233);
            this.lblAddr2.Name = "lblAddr2";
            this.lblAddr2.Size = new System.Drawing.Size(71, 13);
            this.lblAddr2.TabIndex = 78;
            this.lblAddr2.Text = "AddressLine2";
            // 
            // txtAddr1
            // 
            this.txtAddr1.Location = new System.Drawing.Point(151, 204);
            this.txtAddr1.Name = "txtAddr1";
            this.txtAddr1.Size = new System.Drawing.Size(100, 20);
            this.txtAddr1.TabIndex = 77;
            // 
            // lblAddr1
            // 
            this.lblAddr1.AutoSize = true;
            this.lblAddr1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddr1.Location = new System.Drawing.Point(13, 207);
            this.lblAddr1.Name = "lblAddr1";
            this.lblAddr1.Size = new System.Drawing.Size(77, 13);
            this.lblAddr1.TabIndex = 76;
            this.lblAddr1.Text = "Address Line 1";
            // 
            // lblExpDate
            // 
            this.lblExpDate.AutoSize = true;
            this.lblExpDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExpDate.Location = new System.Drawing.Point(13, 181);
            this.lblExpDate.Name = "lblExpDate";
            this.lblExpDate.Size = new System.Drawing.Size(79, 13);
            this.lblExpDate.TabIndex = 75;
            this.lblExpDate.Text = "Expiration Date";
            // 
            // txtCCCompany
            // 
            this.txtCCCompany.Location = new System.Drawing.Point(151, 120);
            this.txtCCCompany.Name = "txtCCCompany";
            this.txtCCCompany.Size = new System.Drawing.Size(100, 20);
            this.txtCCCompany.TabIndex = 74;
            // 
            // lblCCCompany
            // 
            this.lblCCCompany.AutoSize = true;
            this.lblCCCompany.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCCCompany.Location = new System.Drawing.Point(13, 123);
            this.lblCCCompany.Name = "lblCCCompany";
            this.lblCCCompany.Size = new System.Drawing.Size(112, 13);
            this.lblCCCompany.TabIndex = 73;
            this.lblCCCompany.Text = "Card Issuing Company";
            // 
            // txtCOName
            // 
            this.txtCOName.Location = new System.Drawing.Point(151, 94);
            this.txtCOName.Name = "txtCOName";
            this.txtCOName.Size = new System.Drawing.Size(100, 20);
            this.txtCOName.TabIndex = 72;
            // 
            // lblCOName
            // 
            this.lblCOName.AutoSize = true;
            this.lblCOName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCOName.Location = new System.Drawing.Point(13, 97);
            this.lblCOName.Name = "lblCOName";
            this.lblCOName.Size = new System.Drawing.Size(94, 13);
            this.lblCOName.TabIndex = 71;
            this.lblCOName.Text = "Card Owner Name";
            // 
            // lblSTitle2
            // 
            this.lblSTitle2.AutoSize = true;
            this.lblSTitle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSTitle2.Location = new System.Drawing.Point(13, 41);
            this.lblSTitle2.Name = "lblSTitle2";
            this.lblSTitle2.Size = new System.Drawing.Size(175, 13);
            this.lblSTitle2.TabIndex = 70;
            this.lblSTitle2.Text = "Enter Credit Card Information:";
            // 
            // txtCCNumber
            // 
            this.txtCCNumber.Location = new System.Drawing.Point(151, 68);
            this.txtCCNumber.Name = "txtCCNumber";
            this.txtCCNumber.Size = new System.Drawing.Size(100, 20);
            this.txtCCNumber.TabIndex = 69;
            // 
            // lblCCNumber
            // 
            this.lblCCNumber.AutoSize = true;
            this.lblCCNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCCNumber.Location = new System.Drawing.Point(13, 71);
            this.lblCCNumber.Name = "lblCCNumber";
            this.lblCCNumber.Size = new System.Drawing.Size(117, 13);
            this.lblCCNumber.TabIndex = 68;
            this.lblCCNumber.Text = "Credit Card Number";
            // 
            // cbMerchantCode
            // 
            this.cbMerchantCode.FormattingEnabled = true;
            this.cbMerchantCode.Location = new System.Drawing.Point(151, 150);
            this.cbMerchantCode.Name = "cbMerchantCode";
            this.cbMerchantCode.Size = new System.Drawing.Size(100, 21);
            this.cbMerchantCode.TabIndex = 99;
            // 
            // frmCreditCardRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 593);
            this.Controls.Add(this.cbMerchantCode);
            this.Controls.Add(this.lblMerchantCode);
            this.Controls.Add(this.cbActivationStatus);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.cbCountry);
            this.Controls.Add(this.cbState);
            this.Controls.Add(this.dtpExpDate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblActiveStatus);
            this.Controls.Add(this.txtCreditCardBalance);
            this.Controls.Add(this.lblCCBalance);
            this.Controls.Add(this.txtCreditCardLimit);
            this.Controls.Add(this.lblCCLimit);
            this.Controls.Add(this.lblCountry);
            this.Controls.Add(this.txtZipCode);
            this.Controls.Add(this.lblZipCode);
            this.Controls.Add(this.lblState);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.txtAddr2);
            this.Controls.Add(this.lblAddr2);
            this.Controls.Add(this.txtAddr1);
            this.Controls.Add(this.lblAddr1);
            this.Controls.Add(this.lblExpDate);
            this.Controls.Add(this.txtCCCompany);
            this.Controls.Add(this.lblCCCompany);
            this.Controls.Add(this.txtCOName);
            this.Controls.Add(this.lblCOName);
            this.Controls.Add(this.lblSTitle2);
            this.Controls.Add(this.txtCCNumber);
            this.Controls.Add(this.lblCCNumber);
            this.Name = "frmCreditCardRegistration";
            this.Text = "frmCreditCardRegistration";
            this.Load += new System.EventHandler(this.frmCreditCardRegistration_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblMerchantCode;
        private System.Windows.Forms.ComboBox cbActivationStatus;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ComboBox cbCountry;
        private System.Windows.Forms.ComboBox cbState;
        private System.Windows.Forms.DateTimePicker dtpExpDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblActiveStatus;
        private System.Windows.Forms.TextBox txtCreditCardBalance;
        private System.Windows.Forms.Label lblCCBalance;
        private System.Windows.Forms.TextBox txtCreditCardLimit;
        private System.Windows.Forms.Label lblCCLimit;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.TextBox txtZipCode;
        private System.Windows.Forms.Label lblZipCode;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.TextBox txtAddr2;
        private System.Windows.Forms.Label lblAddr2;
        private System.Windows.Forms.TextBox txtAddr1;
        private System.Windows.Forms.Label lblAddr1;
        private System.Windows.Forms.Label lblExpDate;
        private System.Windows.Forms.TextBox txtCCCompany;
        private System.Windows.Forms.Label lblCCCompany;
        private System.Windows.Forms.TextBox txtCOName;
        private System.Windows.Forms.Label lblCOName;
        private System.Windows.Forms.Label lblSTitle2;
        private System.Windows.Forms.TextBox txtCCNumber;
        private System.Windows.Forms.Label lblCCNumber;
        private System.Windows.Forms.ComboBox cbMerchantCode;
    }
}