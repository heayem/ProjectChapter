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
            if (decimal.TryParse(txtNumericGrade.Text, out decimal numericGrade))
            {
                numericGrade += 10;
                lblLetterGradeShow.Text = numericGrade.ToString();
            }
            else
            {
                MessageBox.Show("Please enter a valid numeric grade.");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
