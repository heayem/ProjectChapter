
namespace TelephoneNumber
{
    partial class frmTelephoneNumber
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
            this.lblNumericOnly = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnConvertToNumberOnly = new System.Windows.Forms.Button();
            this.txtAlphanumericNumber = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblNumericOnly
            // 
            this.lblNumericOnly.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblNumericOnly.Location = new System.Drawing.Point(249, 107);
            this.lblNumericOnly.Name = "lblNumericOnly";
            this.lblNumericOnly.Size = new System.Drawing.Size(100, 18);
            this.lblNumericOnly.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(131, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Numeric Only";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(131, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Alphanumeric Number";
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(249, 171);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(76, 49);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "&Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // btnConvertToNumberOnly
            // 
            this.btnConvertToNumberOnly.Location = new System.Drawing.Point(134, 171);
            this.btnConvertToNumberOnly.Name = "btnConvertToNumberOnly";
            this.btnConvertToNumberOnly.Size = new System.Drawing.Size(66, 49);
            this.btnConvertToNumberOnly.TabIndex = 1;
            this.btnConvertToNumberOnly.Text = "&Convert to Number Only";
            this.btnConvertToNumberOnly.UseVisualStyleBackColor = true;
            // 
            // txtAlphanumericNumber
            // 
            this.txtAlphanumericNumber.Location = new System.Drawing.Point(249, 63);
            this.txtAlphanumericNumber.Name = "txtAlphanumericNumber";
            this.txtAlphanumericNumber.Size = new System.Drawing.Size(100, 20);
            this.txtAlphanumericNumber.TabIndex = 0;
            // 
            // frmTelephoneNumber
            // 
            this.AcceptButton = this.btnExit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(438, 302);
            this.Controls.Add(this.txtAlphanumericNumber);
            this.Controls.Add(this.lblNumericOnly);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnConvertToNumberOnly);
            this.Name = "frmTelephoneNumber";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Telephone Number";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumericOnly;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnConvertToNumberOnly;
        private System.Windows.Forms.TextBox txtAlphanumericNumber;
    }
}

