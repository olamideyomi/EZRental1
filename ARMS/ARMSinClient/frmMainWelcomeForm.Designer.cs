
namespace ARMSinClient
{
    partial class frmMainWelcomeForm
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
            this.btnPOS = new System.Windows.Forms.Button();
            this.btnERP = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbITitle
            // 
            this.lbITitle.AutoSize = true;
            this.lbITitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbITitle.Location = new System.Drawing.Point(307, 57);
            this.lbITitle.Name = "lbITitle";
            this.lbITitle.Size = new System.Drawing.Size(133, 13);
            this.lbITitle.TabIndex = 0;
            this.lbITitle.Text = "EZRental POS System";
            this.lbITitle.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnPOS
            // 
            this.btnPOS.Location = new System.Drawing.Point(55, 113);
            this.btnPOS.Name = "btnPOS";
            this.btnPOS.Size = new System.Drawing.Size(574, 63);
            this.btnPOS.TabIndex = 1;
            this.btnPOS.Text = "Point-of-Sale & Rentals";
            this.btnPOS.UseVisualStyleBackColor = true;
            // 
            // btnERP
            // 
            this.btnERP.Location = new System.Drawing.Point(55, 205);
            this.btnERP.Name = "btnERP";
            this.btnERP.Size = new System.Drawing.Size(574, 63);
            this.btnERP.TabIndex = 2;
            this.btnERP.Text = "Enterprise Resource Planning (ERP) System Portal";
            this.btnERP.UseVisualStyleBackColor = true;
            this.btnERP.Click += new System.EventHandler(this.btnERP_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(204, 308);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(273, 60);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit Application";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmMainWelcomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnERP);
            this.Controls.Add(this.btnPOS);
            this.Controls.Add(this.lbITitle);
            this.Name = "frmMainWelcomeForm";
            this.Text = "EZRental POS System";
            this.Load += new System.EventHandler(this.frmMainWelcomeForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbITitle;
        private System.Windows.Forms.Button btnPOS;
        private System.Windows.Forms.Button btnERP;
        private System.Windows.Forms.Button btnExit;
    }
}

