
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
            this.TxtTotal = new System.Windows.Forms.TextBox();
            this.TxtDiscountAmount = new System.Windows.Forms.TextBox();
            this.TxtDiscountPercent = new System.Windows.Forms.TextBox();
            this.TxtSubtotal = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(70, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 38;
            this.label3.Text = "Total:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 37;
            this.label2.Text = "Discount Amount:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 36;
            this.label1.Text = "Discount Percent: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(70, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 35;
            this.label5.Text = "&Subtotol:";
            // 
            // TxtTotal
            // 
            this.TxtTotal.BackColor = System.Drawing.SystemColors.ControlLight;
            this.TxtTotal.Location = new System.Drawing.Point(174, 145);
            this.TxtTotal.Name = "TxtTotal";
            this.TxtTotal.ReadOnly = true;
            this.TxtTotal.ShortcutsEnabled = false;
            this.TxtTotal.Size = new System.Drawing.Size(107, 20);
            this.TxtTotal.TabIndex = 3;
            this.TxtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtDiscountAmount
            // 
            this.TxtDiscountAmount.BackColor = System.Drawing.SystemColors.ControlLight;
            this.TxtDiscountAmount.Location = new System.Drawing.Point(174, 112);
            this.TxtDiscountAmount.Name = "TxtDiscountAmount";
            this.TxtDiscountAmount.ReadOnly = true;
            this.TxtDiscountAmount.ShortcutsEnabled = false;
            this.TxtDiscountAmount.Size = new System.Drawing.Size(107, 20);
            this.TxtDiscountAmount.TabIndex = 2;
            this.TxtDiscountAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtDiscountPercent
            // 
            this.TxtDiscountPercent.BackColor = System.Drawing.SystemColors.ControlLight;
            this.TxtDiscountPercent.Location = new System.Drawing.Point(174, 73);
            this.TxtDiscountPercent.Name = "TxtDiscountPercent";
            this.TxtDiscountPercent.ReadOnly = true;
            this.TxtDiscountPercent.ShortcutsEnabled = false;
            this.TxtDiscountPercent.Size = new System.Drawing.Size(107, 20);
            this.TxtDiscountPercent.TabIndex = 1;
            this.TxtDiscountPercent.Text = "10.0%";
            this.TxtDiscountPercent.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtSubtotal
            // 
            this.TxtSubtotal.BackColor = System.Drawing.Color.White;
            this.TxtSubtotal.Location = new System.Drawing.Point(174, 40);
            this.TxtSubtotal.Name = "TxtSubtotal";
            this.TxtSubtotal.ShortcutsEnabled = false;
            this.TxtSubtotal.Size = new System.Drawing.Size(107, 20);
            this.TxtSubtotal.TabIndex = 0;
            this.TxtSubtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(73, 203);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(101, 35);
            this.btnCalculate.TabIndex = 4;
            this.btnCalculate.Text = "&Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(180, 203);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(101, 35);
            this.btnExit.TabIndex = 29;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // frmInvioce
            // 
            this.AcceptButton = this.btnCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(350, 278);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TxtTotal);
            this.Controls.Add(this.TxtDiscountAmount);
            this.Controls.Add(this.TxtDiscountPercent);
            this.Controls.Add(this.TxtSubtotal);
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
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtTotal;
        private System.Windows.Forms.TextBox TxtDiscountAmount;
        private System.Windows.Forms.TextBox TxtDiscountPercent;
        private System.Windows.Forms.TextBox TxtSubtotal;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnExit;
    }
}

