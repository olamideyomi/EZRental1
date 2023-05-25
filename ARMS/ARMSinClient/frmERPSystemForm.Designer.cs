
namespace ARMSinClient
{
    partial class frmERPSystemForm
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
            this.lbITitle = new System.Windows.Forms.Label();
            this.btnCreditCardMS = new System.Windows.Forms.Button();
            this.btnVehicleInventoryMS = new System.Windows.Forms.Button();
            this.btnCRM = new System.Windows.Forms.Button();
            this.btnHR = new System.Windows.Forms.Button();
            this.btnFinanceOperationMS = new System.Windows.Forms.Button();
            this.btnMarketingMS = new System.Windows.Forms.Button();
            this.btnCustomerFieldServicesMS = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbITitle
            // 
            this.lbITitle.AutoSize = true;
            this.lbITitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbITitle.Location = new System.Drawing.Point(219, 46);
            this.lbITitle.Name = "lbITitle";
            this.lbITitle.Size = new System.Drawing.Size(293, 13);
            this.lbITitle.TabIndex = 0;
            this.lbITitle.Text = "Enterprise Resource Planning (ERP) System Portal";
            this.lbITitle.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnCreditCardMS
            // 
            this.btnCreditCardMS.Location = new System.Drawing.Point(149, 101);
            this.btnCreditCardMS.Name = "btnCreditCardMS";
            this.btnCreditCardMS.Size = new System.Drawing.Size(417, 47);
            this.btnCreditCardMS.TabIndex = 1;
            this.btnCreditCardMS.Text = "Credit Card Management System";
            this.btnCreditCardMS.UseVisualStyleBackColor = true;
            this.btnCreditCardMS.Click += new System.EventHandler(this.btnCreditCardMS_Click);
            // 
            // btnVehicleInventoryMS
            // 
            this.btnVehicleInventoryMS.Location = new System.Drawing.Point(149, 163);
            this.btnVehicleInventoryMS.Name = "btnVehicleInventoryMS";
            this.btnVehicleInventoryMS.Size = new System.Drawing.Size(417, 47);
            this.btnVehicleInventoryMS.TabIndex = 2;
            this.btnVehicleInventoryMS.Text = "Vehicle Inventory Management System (Coming soon)";
            this.btnVehicleInventoryMS.UseVisualStyleBackColor = true;
            // 
            // btnCRM
            // 
            this.btnCRM.Location = new System.Drawing.Point(149, 230);
            this.btnCRM.Name = "btnCRM";
            this.btnCRM.Size = new System.Drawing.Size(417, 47);
            this.btnCRM.TabIndex = 3;
            this.btnCRM.Text = "Customer Relationship Management (CRM) System(Coming soon)";
            this.btnCRM.UseVisualStyleBackColor = true;
            // 
            // btnHR
            // 
            this.btnHR.Location = new System.Drawing.Point(149, 298);
            this.btnHR.Name = "btnHR";
            this.btnHR.Size = new System.Drawing.Size(417, 47);
            this.btnHR.TabIndex = 4;
            this.btnHR.Text = "Human Resource Management System (Coming soon)";
            this.btnHR.UseVisualStyleBackColor = true;
            // 
            // btnFinanceOperationMS
            // 
            this.btnFinanceOperationMS.Location = new System.Drawing.Point(149, 370);
            this.btnFinanceOperationMS.Name = "btnFinanceOperationMS";
            this.btnFinanceOperationMS.Size = new System.Drawing.Size(417, 47);
            this.btnFinanceOperationMS.TabIndex = 5;
            this.btnFinanceOperationMS.Text = "Finance & Operation Management System (Coming soon)";
            this.btnFinanceOperationMS.UseVisualStyleBackColor = true;
            // 
            // btnMarketingMS
            // 
            this.btnMarketingMS.Location = new System.Drawing.Point(149, 441);
            this.btnMarketingMS.Name = "btnMarketingMS";
            this.btnMarketingMS.Size = new System.Drawing.Size(417, 47);
            this.btnMarketingMS.TabIndex = 6;
            this.btnMarketingMS.Text = "Marketing Management System (Coming soon)";
            this.btnMarketingMS.UseVisualStyleBackColor = true;
            // 
            // btnCustomerFieldServicesMS
            // 
            this.btnCustomerFieldServicesMS.Location = new System.Drawing.Point(149, 515);
            this.btnCustomerFieldServicesMS.Name = "btnCustomerFieldServicesMS";
            this.btnCustomerFieldServicesMS.Size = new System.Drawing.Size(417, 47);
            this.btnCustomerFieldServicesMS.TabIndex = 7;
            this.btnCustomerFieldServicesMS.Text = "Customer & Field Service Management System (Coming soon)";
            this.btnCustomerFieldServicesMS.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(284, 594);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(117, 38);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "Exit ERP";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmERPSystemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 850);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCustomerFieldServicesMS);
            this.Controls.Add(this.btnMarketingMS);
            this.Controls.Add(this.btnFinanceOperationMS);
            this.Controls.Add(this.btnHR);
            this.Controls.Add(this.btnCRM);
            this.Controls.Add(this.btnVehicleInventoryMS);
            this.Controls.Add(this.btnCreditCardMS);
            this.Controls.Add(this.lbITitle);
            this.Name = "frmERPSystemForm";
            this.Text = "Enterprise Resource Planning (ERP) System Portal";
            this.Load += new System.EventHandler(this.frmERPSystemForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbITitle;
        private System.Windows.Forms.Button btnCreditCardMS;
        private System.Windows.Forms.Button btnVehicleInventoryMS;
        private System.Windows.Forms.Button btnCRM;
        private System.Windows.Forms.Button btnHR;
        private System.Windows.Forms.Button btnFinanceOperationMS;
        private System.Windows.Forms.Button btnMarketingMS;
        private System.Windows.Forms.Button btnCustomerFieldServicesMS;
        private System.Windows.Forms.Button btnExit;
    }
}