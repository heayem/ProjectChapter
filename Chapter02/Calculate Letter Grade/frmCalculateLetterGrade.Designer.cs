
namespace Calculate_Letter_Grade
{
    partial class frmCalculateLetterGrade
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
            this.lblNumericGrade = new System.Windows.Forms.Label();
            this.lblLetterGrade = new System.Windows.Forms.Label();
            this.txtNumericGrade = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnCalculateLetterGrade = new System.Windows.Forms.Button();
            this.lblLetterGradeShow = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblNumericGrade
            // 
            this.lblNumericGrade.AutoSize = true;
            this.lblNumericGrade.Location = new System.Drawing.Point(125, 60);
            this.lblNumericGrade.Name = "lblNumericGrade";
            this.lblNumericGrade.Size = new System.Drawing.Size(78, 13);
            this.lblNumericGrade.TabIndex = 0;
            this.lblNumericGrade.Text = "Numeric Grade";
            this.lblNumericGrade.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblLetterGrade
            // 
            this.lblLetterGrade.AutoSize = true;
            this.lblLetterGrade.Location = new System.Drawing.Point(125, 115);
            this.lblLetterGrade.Name = "lblLetterGrade";
            this.lblLetterGrade.Size = new System.Drawing.Size(66, 13);
            this.lblLetterGrade.TabIndex = 1;
            this.lblLetterGrade.Text = "Letter Grade";
            this.lblLetterGrade.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtNumericGrade
            // 
            this.txtNumericGrade.BackColor = System.Drawing.Color.White;
            this.txtNumericGrade.Location = new System.Drawing.Point(214, 53);
            this.txtNumericGrade.Name = "txtNumericGrade";
            this.txtNumericGrade.Size = new System.Drawing.Size(100, 20);
            this.txtNumericGrade.TabIndex = 1;
            this.txtNumericGrade.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(251, 178);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(63, 64);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = false;
            // 
            // btnCalculateLetterGrade
            // 
            this.btnCalculateLetterGrade.BackColor = System.Drawing.Color.Transparent;
            this.btnCalculateLetterGrade.Location = new System.Drawing.Point(128, 178);
            this.btnCalculateLetterGrade.Name = "btnCalculateLetterGrade";
            this.btnCalculateLetterGrade.Size = new System.Drawing.Size(63, 64);
            this.btnCalculateLetterGrade.TabIndex = 2;
            this.btnCalculateLetterGrade.Text = "&Calculate Letter Grade";
            this.btnCalculateLetterGrade.UseVisualStyleBackColor = false;
            // 
            // lblLetterGradeShow
            // 
            this.lblLetterGradeShow.BackColor = System.Drawing.Color.White;
            this.lblLetterGradeShow.Location = new System.Drawing.Point(214, 115);
            this.lblLetterGradeShow.Name = "lblLetterGradeShow";
            this.lblLetterGradeShow.Size = new System.Drawing.Size(100, 20);
            this.lblLetterGradeShow.TabIndex = 5;
            this.lblLetterGradeShow.TabStop = false;
            this.lblLetterGradeShow.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // frmCalculateLetterGrade
            // 
            this.AcceptButton = this.btnCalculateLetterGrade;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(437, 298);
            this.Controls.Add(this.lblLetterGradeShow);
            this.Controls.Add(this.btnCalculateLetterGrade);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.txtNumericGrade);
            this.Controls.Add(this.lblLetterGrade);
            this.Controls.Add(this.lblNumericGrade);
            this.Name = "frmCalculateLetterGrade";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculate Letter Grade";
            this.TransparencyKey = System.Drawing.Color.White;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumericGrade;
        private System.Windows.Forms.Label lblLetterGrade;
        private System.Windows.Forms.TextBox txtNumericGrade;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnCalculateLetterGrade;
        private System.Windows.Forms.TextBox lblLetterGradeShow;
    }
}

