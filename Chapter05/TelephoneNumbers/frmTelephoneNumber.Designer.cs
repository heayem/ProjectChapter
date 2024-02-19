
namespace TelephoneNumbers
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAlphanumeric = new System.Windows.Forms.TextBox();
            this.lblNumerice = new System.Windows.Forms.TextBox();
            this.btnConvert = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Alphanumeric Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Numerice Only";
            // 
            // txtAlphanumeric
            // 
            this.txtAlphanumeric.Location = new System.Drawing.Point(221, 78);
            this.txtAlphanumeric.Name = "txtAlphanumeric";
            this.txtAlphanumeric.Size = new System.Drawing.Size(100, 20);
            this.txtAlphanumeric.TabIndex = 0;
            // 
            // lblNumerice
            // 
            this.lblNumerice.Location = new System.Drawing.Point(221, 124);
            this.lblNumerice.Name = "lblNumerice";
            this.lblNumerice.ReadOnly = true;
            this.lblNumerice.Size = new System.Drawing.Size(100, 20);
            this.lblNumerice.TabIndex = 9;
            this.lblNumerice.TabStop = false;
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(72, 185);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(85, 49);
            this.btnConvert.TabIndex = 1;
            this.btnConvert.Text = "Convert to numeric only";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(236, 185);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(85, 49);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "&Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmTelephoneNumber
            // 
            this.AcceptButton = this.btnConvert;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(427, 259);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.lblNumerice);
            this.Controls.Add(this.txtAlphanumeric);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmTelephoneNumber";
            this.Text = "Telephone Numbers";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAlphanumeric;
        private System.Windows.Forms.TextBox lblNumerice;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.Button btnExit;
    }
}

