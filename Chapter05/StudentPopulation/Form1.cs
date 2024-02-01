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
            // Validation
            if (!decimal.TryParse(txtNumberOfStudentsToday.Text, out decimal numberOfStudentsToday)
                || !decimal.TryParse(txtAnnualGrowthRate.Text, out decimal annualGrowthRate)
                || !decimal.TryParse(txtNumberOfYears.Text, out decimal numberOfYears))
            {
                MessageBox.Show("Invalid input. Please enter valid numeric values.");
                return;
            }

            // Calculation with compounding
            decimal growthFactor = 1 + annualGrowthRate; // Compounding factor
            numberOfStudentsToday *= (decimal)Math.Pow((double)growthFactor, (double)numberOfYears);

            // Display result
            lblProjectedNumberOfStudents.Text = numberOfStudentsToday.ToString("F2"); // Display with 2 decimal places
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
