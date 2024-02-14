
namespace ShippingAndHandling
{
    partial class frmShippingAndHandling
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
            this.btnCalculateGrandTotal = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtOrdTotal = new System.Windows.Forms.TextBox();
            this.textCustomerType = new System.Windows.Forms.TextBox();
            this.lblShippingCost = new System.Windows.Forms.TextBox();
            this.lblSaleTax = new System.Windows.Forms.TextBox();
            this.lblGrandeTotal = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCalculateGrandTotal
            // 
            this.btnCalculateGrandTotal.Location = new System.Drawing.Point(145, 220);
            this.btnCalculateGrandTotal.Name = "btnCalculateGrandTotal";
            this.btnCalculateGrandTotal.Size = new System.Drawing.Size(76, 49);
            this.btnCalculateGrandTotal.TabIndex = 3;
            this.btnCalculateGrandTotal.Text = "&Calculate Grand Total";
            this.btnCalculateGrandTotal.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(260, 220);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(76, 49);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Order Total";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(241, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Customer Type (P= Preferred N = None-Preferred)";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(210, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Shipping Cost (Free for Preferred Customer)";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(58, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Sale Tax (7%)";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(58, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Grande Total";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtOrdTotal
            // 
            this.txtOrdTotal.Location = new System.Drawing.Point(318, 44);
            this.txtOrdTotal.Name = "txtOrdTotal";
            this.txtOrdTotal.Size = new System.Drawing.Size(100, 20);
            this.txtOrdTotal.TabIndex = 1;
            this.txtOrdTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textCustomerType
            // 
            this.textCustomerType.Location = new System.Drawing.Point(318, 77);
            this.textCustomerType.Name = "textCustomerType";
            this.textCustomerType.Size = new System.Drawing.Size(100, 20);
            this.textCustomerType.TabIndex = 2;
            this.textCustomerType.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblShippingCost
            // 
            this.lblShippingCost.Location = new System.Drawing.Point(318, 115);
            this.lblShippingCost.Name = "lblShippingCost";
            this.lblShippingCost.ReadOnly = true;
            this.lblShippingCost.Size = new System.Drawing.Size(100, 20);
            this.lblShippingCost.TabIndex = 12;
            this.lblShippingCost.TabStop = false;
            this.lblShippingCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblSaleTax
            // 
            this.lblSaleTax.Location = new System.Drawing.Point(318, 148);
            this.lblSaleTax.Name = "lblSaleTax";
            this.lblSaleTax.ReadOnly = true;
            this.lblSaleTax.Size = new System.Drawing.Size(100, 20);
            this.lblSaleTax.TabIndex = 13;
            this.lblSaleTax.TabStop = false;
            this.lblSaleTax.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblGrandeTotal
            // 
            this.lblGrandeTotal.Location = new System.Drawing.Point(318, 183);
            this.lblGrandeTotal.Name = "lblGrandeTotal";
            this.lblGrandeTotal.ReadOnly = true;
            this.lblGrandeTotal.Size = new System.Drawing.Size(100, 20);
            this.lblGrandeTotal.TabIndex = 14;
            this.lblGrandeTotal.TabStop = false;
            this.lblGrandeTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // frmShippingAndHandling
            // 
            this.AcceptButton = this.btnCalculateGrandTotal;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(480, 309);
            this.Controls.Add(this.lblGrandeTotal);
            this.Controls.Add(this.lblSaleTax);
            this.Controls.Add(this.lblShippingCost);
            this.Controls.Add(this.textCustomerType);
            this.Controls.Add(this.txtOrdTotal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCalculateGrandTotal);
            this.Name = "frmShippingAndHandling";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Shiping and Handling";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalculateGrandTotal;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtOrdTotal;
        private System.Windows.Forms.TextBox textCustomerType;
        private System.Windows.Forms.TextBox lblShippingCost;
        private System.Windows.Forms.TextBox lblSaleTax;
        private System.Windows.Forms.TextBox lblGrandeTotal;
    }
}

