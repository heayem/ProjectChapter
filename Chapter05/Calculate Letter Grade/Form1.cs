using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculate_Letter_Grade
{
    public partial class frmCalculateLetterGrade : Form
    {
        public frmCalculateLetterGrade()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCalculateLetterGrade_Click(object sender, EventArgs e)
        {
            decimal numeric = Convert.ToDecimal(txtNumericGrade.Text);
            if (numeric >= 90 && numeric <= 100)
            {
                lblLetterGradeShow.Text = "A";
            }
            else if (numeric >= 80 && numeric <= 89)
            {
                lblLetterGradeShow.Text = "B";

            }
            else if (numeric >= 70 && numeric <= 79)
            {
                lblLetterGradeShow.Text = "C";

            }
            else if (numeric >= 60 && numeric <= 69)
            {
                lblLetterGradeShow.Text = "D";
            }
            else if ( numeric < 60)
            {
                lblLetterGradeShow.Text = "F";
            }
            else
            {
                MessageBox.Show("Please enter a numeric value between 0 and 100.");
            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
