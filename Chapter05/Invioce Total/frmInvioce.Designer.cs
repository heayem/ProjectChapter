
namespace Invioce_Total
{
    partial class frmInvioce
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.TextBox();
            this.lblDiscountAmount = new System.Windows.Forms.TextBox();
            this.lblDiscountPercent = new System.Windows.Forms.TextBox();
            this.txtSubtotal = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCustomerType = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(70, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 38;
            this.label3.Text = "Total:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 37;
            this.label2.Text = "Discount Amount:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 36;
            this.label1.Text = "Discount Percent: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(70, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 35;
            this.label5.Text = "&Subtotal:";
            // 
            // lblTotal
            // 
            this.lblTotal.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblTotal.Location = new System.Drawing.Point(174, 185);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.ReadOnly = true;
            this.lblTotal.ShortcutsEnabled = false;
            this.lblTotal.Size = new System.Drawing.Size(107, 20);
            this.lblTotal.TabIndex = 6;
            this.lblTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblDiscountAmount
            // 
            this.lblDiscountAmount.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblDiscountAmount.Location = new System.Drawing.Point(174, 152);
            this.lblDiscountAmount.Name = "lblDiscountAmount";
            this.lblDiscountAmount.ReadOnly = true;
            this.lblDiscountAmount.ShortcutsEnabled = false;
            this.lblDiscountAmount.Size = new System.Drawing.Size(107, 20);
            this.lblDiscountAmount.TabIndex = 5;
            this.lblDiscountAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblDiscountPercent
            // 
            this.lblDiscountPercent.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblDiscountPercent.Location = new System.Drawing.Point(174, 113);
            this.lblDiscountPercent.Name = "lblDiscountPercent";
            this.lblDiscountPercent.ReadOnly = true;
            this.lblDiscountPercent.ShortcutsEnabled = false;
            this.lblDiscountPercent.Size = new System.Drawing.Size(107, 20);
            this.lblDiscountPercent.TabIndex = 4;
            this.lblDiscountPercent.Text = "10.0%";
            this.lblDiscountPercent.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.BackColor = System.Drawing.Color.White;
            this.txtSubtotal.Location = new System.Drawing.Point(174, 80);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.ShortcutsEnabled = false;
            this.txtSubtotal.Size = new System.Drawing.Size(107, 20);
            this.txtSubtotal.TabIndex = 2;
            this.txtSubtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(73, 243);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(101, 35);
            this.btnCalculate.TabIndex = 2;
            this.btnCalculate.Text = "&Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(180, 243);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(101, 35);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(70, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 40;
            this.label4.Text = "Customer type";
            // 
            // txtCustomerType
            // 
            this.txtCustomerType.BackColor = System.Drawing.Color.White;
            this.txtCustomerType.Location = new System.Drawing.Point(174, 45);
            this.txtCustomerType.Name = "txtCustomerType";
            this.txtCustomerType.ShortcutsEnabled = false;
            this.txtCustomerType.Size = new System.Drawing.Size(107, 20);
            this.txtCustomerType.TabIndex = 1;
            this.txtCustomerType.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // frmInvioce
            // 
            this.AcceptButton = this.btnCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(350, 315);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCustomerType);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblDiscountAmount);
            this.Controls.Add(this.lblDiscountPercent);
            this.Controls.Add(this.txtSubtotal);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.btnExit);
            this.Name = "frmInvioce";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Invoice Total";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox lblTotal;
        private System.Windows.Forms.TextBox lblDiscountAmount;
        private System.Windows.Forms.TextBox lblDiscountPercent;
        private System.Windows.Forms.TextBox txtSubtotal;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCustomerType;
    }
}

