
namespace StudentPopulation
{
    partial class frmStudentPopulatio
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
            this.lblProjectedNumberOfStudents = new System.Windows.Forms.Label();
            this.txtAnnualGrowthRate = new System.Windows.Forms.TextBox();
            this.txtNumberOfStudentsToday = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnProjectStudentPopulation = new System.Windows.Forms.Button();
            this.txtNumberOfYears = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblProjectedNumberOfStudents
            // 
            this.lblProjectedNumberOfStudents.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblProjectedNumberOfStudents.Location = new System.Drawing.Point(268, 160);
            this.lblProjectedNumberOfStudents.Name = "lblProjectedNumberOfStudents";
            this.lblProjectedNumberOfStudents.Size = new System.Drawing.Size(158, 22);
            this.lblProjectedNumberOfStudents.TabIndex = 22;
            this.lblProjectedNumberOfStudents.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtAnnualGrowthRate
            // 
            this.txtAnnualGrowthRate.Location = new System.Drawing.Point(271, 91);
            this.txtAnnualGrowthRate.Name = "txtAnnualGrowthRate";
            this.txtAnnualGrowthRate.Size = new System.Drawing.Size(155, 20);
            this.txtAnnualGrowthRate.TabIndex = 1;
            this.txtAnnualGrowthRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtNumberOfStudentsToday
            // 
            this.txtNumberOfStudentsToday.Location = new System.Drawing.Point(271, 58);
            this.txtNumberOfStudentsToday.Name = "txtNumberOfStudentsToday";
            this.txtNumberOfStudentsToday.Size = new System.Drawing.Size(155, 20);
            this.txtNumberOfStudentsToday.TabIndex = 0;
            this.txtNumberOfStudentsToday.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(66, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Projected number of students";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(66, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Number of years";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Annual growth rate";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Number of students today ";
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(268, 234);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(76, 49);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // btnProjectStudentPopulation
            // 
            this.btnProjectStudentPopulation.Location = new System.Drawing.Point(153, 234);
            this.btnProjectStudentPopulation.Name = "btnProjectStudentPopulation";
            this.btnProjectStudentPopulation.Size = new System.Drawing.Size(76, 49);
            this.btnProjectStudentPopulation.TabIndex = 3;
            this.btnProjectStudentPopulation.Text = "&Project Student Population";
            this.btnProjectStudentPopulation.UseVisualStyleBackColor = true;
            // 
            // txtNumberOfYears
            // 
            this.txtNumberOfYears.Location = new System.Drawing.Point(271, 125);
            this.txtNumberOfYears.Name = "txtNumberOfYears";
            this.txtNumberOfYears.Size = new System.Drawing.Size(155, 20);
            this.txtNumberOfYears.TabIndex = 2;
            this.txtNumberOfYears.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // frmStudentPopulatio
            // 
            this.AcceptButton = this.btnProjectStudentPopulation;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(487, 333);
            this.Controls.Add(this.txtNumberOfYears);
            this.Controls.Add(this.lblProjectedNumberOfStudents);
            this.Controls.Add(this.txtAnnualGrowthRate);
            this.Controls.Add(this.txtNumberOfStudentsToday);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnProjectStudentPopulation);
            this.Name = "frmStudentPopulatio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student Populatio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProjectedNumberOfStudents;
        private System.Windows.Forms.TextBox txtAnnualGrowthRate;
        private System.Windows.Forms.TextBox txtNumberOfStudentsToday;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnProjectStudentPopulation;
        private System.Windows.Forms.TextBox txtNumberOfYears;
    }
}

