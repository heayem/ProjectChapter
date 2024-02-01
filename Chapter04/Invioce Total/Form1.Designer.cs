
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
            this.lblEnterSubtotal = new System.Windows.Forms.Label();
            this.TxtTotal = new System.Windows.Forms.TextBox();
            this.TxtDiscountAmount = new System.Windows.Forms.TextBox();
            this.TxtDiscountPercent = new System.Windows.Forms.TextBox();
            this.txtEnterSubtotal = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnClearTotal = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textSubTotal = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNumberOfInvoices = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtInvoiceAverage = new System.Windows.Forms.TextBox();
            this.txtTotalOfInvoices = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(70, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 38;
            this.label3.Text = "Total:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 37;
            this.label2.Text = "Discount Amount:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 36;
            this.label1.Text = "Discount Percent: ";
            // 
            // lblEnterSubtotal
            // 
            this.lblEnterSubtotal.AutoSize = true;
            this.lblEnterSubtotal.Location = new System.Drawing.Point(70, 47);
            this.lblEnterSubtotal.Name = "lblEnterSubtotal";
            this.lblEnterSubtotal.Size = new System.Drawing.Size(77, 13);
            this.lblEnterSubtotal.TabIndex = 35;
            this.lblEnterSubtotal.Text = "Enter Subtotal:";
            // 
            // TxtTotal
            // 
            this.TxtTotal.BackColor = System.Drawing.SystemColors.ControlLight;
            this.TxtTotal.Location = new System.Drawing.Point(174, 179);
            this.TxtTotal.Name = "TxtTotal";
            this.TxtTotal.ReadOnly = true;
            this.TxtTotal.ShortcutsEnabled = false;
            this.TxtTotal.Size = new System.Drawing.Size(107, 20);
            this.TxtTotal.TabIndex = 6;
            this.TxtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtDiscountAmount
            // 
            this.TxtDiscountAmount.BackColor = System.Drawing.SystemColors.ControlLight;
            this.TxtDiscountAmount.Location = new System.Drawing.Point(174, 146);
            this.TxtDiscountAmount.Name = "TxtDiscountAmount";
            this.TxtDiscountAmount.ReadOnly = true;
            this.TxtDiscountAmount.ShortcutsEnabled = false;
            this.TxtDiscountAmount.Size = new System.Drawing.Size(107, 20);
            this.TxtDiscountAmount.TabIndex = 5;
            this.TxtDiscountAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtDiscountPercent
            // 
            this.TxtDiscountPercent.BackColor = System.Drawing.SystemColors.ControlLight;
            this.TxtDiscountPercent.Location = new System.Drawing.Point(174, 107);
            this.TxtDiscountPercent.Name = "TxtDiscountPercent";
            this.TxtDiscountPercent.ReadOnly = true;
            this.TxtDiscountPercent.ShortcutsEnabled = false;
            this.TxtDiscountPercent.Size = new System.Drawing.Size(107, 20);
            this.TxtDiscountPercent.TabIndex = 4;
            this.TxtDiscountPercent.Text = "10.0%";
            this.TxtDiscountPercent.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtEnterSubtotal
            // 
            this.txtEnterSubtotal.BackColor = System.Drawing.Color.White;
            this.txtEnterSubtotal.Location = new System.Drawing.Point(174, 40);
            this.txtEnterSubtotal.Name = "txtEnterSubtotal";
            this.txtEnterSubtotal.ShortcutsEnabled = false;
            this.txtEnterSubtotal.Size = new System.Drawing.Size(107, 20);
            this.txtEnterSubtotal.TabIndex = 0;
            this.txtEnterSubtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(209, 228);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(101, 35);
            this.btnCalculate.TabIndex = 1;
            this.btnCalculate.Text = "&Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(423, 228);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(101, 35);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnClearTotal
            // 
            this.btnClearTotal.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClearTotal.Location = new System.Drawing.Point(316, 228);
            this.btnClearTotal.Name = "btnClearTotal";
            this.btnClearTotal.Size = new System.Drawing.Size(101, 35);
            this.btnClearTotal.TabIndex = 2;
            this.btnClearTotal.Text = "Clear Totals";
            this.btnClearTotal.UseVisualStyleBackColor = true;
            this.btnClearTotal.Click += new System.EventHandler(this.btnClearTotal_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(69, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 40;
            this.label4.Text = "&Subtotal:";
            // 
            // textSubTotal
            // 
            this.textSubTotal.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textSubTotal.Location = new System.Drawing.Point(173, 72);
            this.textSubTotal.Name = "textSubTotal";
            this.textSubTotal.ShortcutsEnabled = false;
            this.textSubTotal.Size = new System.Drawing.Size(107, 20);
            this.textSubTotal.TabIndex = 1;
            this.textSubTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(308, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 13);
            this.label5.TabIndex = 46;
            this.label5.Text = "Number of Invoices";
            // 
            // txtNumberOfInvoices
            // 
            this.txtNumberOfInvoices.BackColor = System.Drawing.Color.White;
            this.txtNumberOfInvoices.Location = new System.Drawing.Point(414, 70);
            this.txtNumberOfInvoices.Name = "txtNumberOfInvoices";
            this.txtNumberOfInvoices.ShortcutsEnabled = false;
            this.txtNumberOfInvoices.Size = new System.Drawing.Size(107, 20);
            this.txtNumberOfInvoices.TabIndex = 41;
            this.txtNumberOfInvoices.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(309, 151);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 13);
            this.label6.TabIndex = 45;
            this.label6.Text = "Invoice Average";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(309, 112);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 13);
            this.label7.TabIndex = 44;
            this.label7.Text = "Total of Invoice";
            // 
            // txtInvoiceAverage
            // 
            this.txtInvoiceAverage.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtInvoiceAverage.Location = new System.Drawing.Point(413, 144);
            this.txtInvoiceAverage.Name = "txtInvoiceAverage";
            this.txtInvoiceAverage.ReadOnly = true;
            this.txtInvoiceAverage.ShortcutsEnabled = false;
            this.txtInvoiceAverage.Size = new System.Drawing.Size(107, 20);
            this.txtInvoiceAverage.TabIndex = 43;
            this.txtInvoiceAverage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTotalOfInvoices
            // 
            this.txtTotalOfInvoices.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtTotalOfInvoices.Location = new System.Drawing.Point(413, 105);
            this.txtTotalOfInvoices.Name = "txtTotalOfInvoices";
            this.txtTotalOfInvoices.ReadOnly = true;
            this.txtTotalOfInvoices.ShortcutsEnabled = false;
            this.txtTotalOfInvoices.Size = new System.Drawing.Size(107, 20);
            this.txtTotalOfInvoices.TabIndex = 42;
            this.txtTotalOfInvoices.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // frmInvioce
            // 
            this.AcceptButton = this.btnCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(619, 304);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtNumberOfInvoices);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtInvoiceAverage);
            this.Controls.Add(this.txtTotalOfInvoices);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textSubTotal);
            this.Controls.Add(this.btnClearTotal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblEnterSubtotal);
            this.Controls.Add(this.TxtTotal);
            this.Controls.Add(this.TxtDiscountAmount);
            this.Controls.Add(this.TxtDiscountPercent);
            this.Controls.Add(this.txtEnterSubtotal);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.btnExit);
            this.Name = "frmInvioce";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Invoice";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblEnterSubtotal;
        private System.Windows.Forms.TextBox TxtTotal;
        private System.Windows.Forms.TextBox TxtDiscountAmount;
        private System.Windows.Forms.TextBox TxtDiscountPercent;
        private System.Windows.Forms.TextBox txtEnterSubtotal;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnClearTotal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textSubTotal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNumberOfInvoices;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtInvoiceAverage;
        private System.Windows.Forms.TextBox txtTotalOfInvoices;
    }
}

