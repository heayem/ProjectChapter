
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
            this.txtOrderTotal = new System.Windows.Forms.TextBox();
            this.txtComstumerType = new System.Windows.Forms.TextBox();
            this.lblShippingCost = new System.Windows.Forms.Label();
            this.lblSaleTax = new System.Windows.Forms.Label();
            this.txtGrandeTotal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCalculateGrandTotal
            // 
            this.btnCalculateGrandTotal.Location = new System.Drawing.Point(145, 220);
            this.btnCalculateGrandTotal.Name = "btnCalculateGrandTotal";
            this.btnCalculateGrandTotal.Size = new System.Drawing.Size(76, 49);
            this.btnCalculateGrandTotal.TabIndex = 2;
            this.btnCalculateGrandTotal.Text = "&Calculate Grand Total";
            this.btnCalculateGrandTotal.UseVisualStyleBackColor = true;
            this.btnCalculateGrandTotal.Click += new System.EventHandler(this.btnCalculateGrandTotal_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(260, 220);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(76, 49);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Order Total";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(238, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Customer Type (P= Preferred N = None-Preferred";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(210, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Shipping Cost (Free for Preferred Customer)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(58, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Sale Tax (7%)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(58, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Grande Total";
            // 
            // txtOrderTotal
            // 
            this.txtOrderTotal.Location = new System.Drawing.Point(318, 44);
            this.txtOrderTotal.Name = "txtOrderTotal";
            this.txtOrderTotal.Size = new System.Drawing.Size(100, 20);
            this.txtOrderTotal.TabIndex = 0;
            this.txtOrderTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtComstumerType
            // 
            this.txtComstumerType.Location = new System.Drawing.Point(318, 77);
            this.txtComstumerType.Name = "txtComstumerType";
            this.txtComstumerType.Size = new System.Drawing.Size(100, 20);
            this.txtComstumerType.TabIndex = 1;
            this.txtComstumerType.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblShippingCost
            // 
            this.lblShippingCost.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblShippingCost.Location = new System.Drawing.Point(315, 111);
            this.lblShippingCost.Name = "lblShippingCost";
            this.lblShippingCost.Size = new System.Drawing.Size(103, 20);
            this.lblShippingCost.TabIndex = 9;
            this.lblShippingCost.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSaleTax
            // 
            this.lblSaleTax.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblSaleTax.Location = new System.Drawing.Point(315, 146);
            this.lblSaleTax.Name = "lblSaleTax";
            this.lblSaleTax.Size = new System.Drawing.Size(103, 22);
            this.lblSaleTax.TabIndex = 10;
            this.lblSaleTax.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtGrandeTotal
            // 
            this.txtGrandeTotal.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtGrandeTotal.Location = new System.Drawing.Point(315, 181);
            this.txtGrandeTotal.Name = "txtGrandeTotal";
            this.txtGrandeTotal.Size = new System.Drawing.Size(103, 18);
            this.txtGrandeTotal.TabIndex = 11;
            this.txtGrandeTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // frmShippingAndHandling
            // 
            this.AcceptButton = this.btnCalculateGrandTotal;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(480, 309);
            this.Controls.Add(this.txtGrandeTotal);
            this.Controls.Add(this.lblSaleTax);
            this.Controls.Add(this.lblShippingCost);
            this.Controls.Add(this.txtComstumerType);
            this.Controls.Add(this.txtOrderTotal);
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
        private System.Windows.Forms.TextBox txtOrderTotal;
        private System.Windows.Forms.TextBox txtComstumerType;
        private System.Windows.Forms.Label lblShippingCost;
        private System.Windows.Forms.Label lblSaleTax;
        private System.Windows.Forms.Label txtGrandeTotal;
    }
}

