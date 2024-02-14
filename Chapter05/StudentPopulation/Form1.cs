using System;
using System.Windows.Forms;

namespace StudentPopulation
{
    public partial class frmStudentPopulation : Form
    {
        public frmStudentPopulation()
        {
            InitializeComponent();
        }

        private void btnProjectStudentPopulation_Click(object sender, EventArgs e)
        {
            decimal numberOfStudentsToday = Convert.ToDecimal(txtNumberOfStudentsToday.Text);
            decimal annualGrowthRate = Convert.ToDecimal(txtAnnualGrowthRate.Text);
            decimal numberOfYears = Convert.ToDecimal(txtNumberOfYears.Text);

            for (int year = 1; year <= numberOfYears; year++)
                numberOfStudentsToday = Math.Round(numberOfStudentsToday * (1 + annualGrowthRate));

            lblProjectedNumberOfStudents.Text = numberOfStudentsToday.ToString("N0");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
