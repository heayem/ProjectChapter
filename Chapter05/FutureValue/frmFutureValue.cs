using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FutureValue
{
    public partial class frmFutureValue : Form
    {
        public frmFutureValue()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
             decimal monthlyInvestment = Convert.ToDecimal(txtMonthlyInvestment.Text);
             decimal yearlyInterestRate = Convert.ToDecimal(txtYearlyInterestRate.Text);
             int years = Convert.ToInt32(txtNumberOfYears.Text);

             int months = years * 12;
             decimal monthlyInterestRate = yearlyInterestRate / 12 / 100;
             decimal futureValue = 0m;
            int i = 0;
            while (i < months) { 
                futureValue = (futureValue + monthlyInvestment) * (1 + monthlyInterestRate);
                i++;
            }
            lblFutureValue.Text = futureValue.ToString("c");
            txtMonthlyInvestment.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
