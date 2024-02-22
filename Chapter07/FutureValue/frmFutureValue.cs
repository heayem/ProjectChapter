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
        private decimal CalculateFutureValue( decimal monthlyInvestment, decimal monthlyInterestRate,int months)
        {
            decimal futureValue = 0m;
            for (int i = 0; i < months; i++)
            {
                futureValue = (futureValue + monthlyInvestment)
                            * (1 + monthlyInterestRate);
            }
            return futureValue;
        }
   
        public bool IsValidData()
        {
            return
                IsPresent(
                    txtMonthlyInvestment, "Monthly Investment") &&
                IsDecimal(
                    txtMonthlyInvestment, "Monthly Investment") &&
                IsWithinRange(txtMonthlyInvestment,
                    "Monthly Investment", 1, 1000) &&
                IsPresent(txtYearlyInterestRate, "Yearly Interest Rate") &&
                IsDecimal(txtYearlyInterestRate, "Yearly Interest Rate") &&
                IsWithinRange(txtYearlyInterestRate,
                    "Yearly Interest Rate", 1, 20) &&
                IsPresent(txtNumberOfYears, "Number of Years") &&
                IsInt32(txtNumberOfYears, "Number of Years") &&
                IsWithinRange(txtNumberOfYears, "Number of Years", 1, 40);
        }
        public bool IsPresent(TextBox textBox, string name)
        {
            if (textBox.Text == "")
            {
                MessageBox.Show(name + " is a required field.",
                    "Entry Error");
                textBox.Focus();
                return false;
            }
            return true;
        }
        public bool IsDecimal(TextBox textBox, string name)
        {
            try
            {
                Convert.ToDecimal(textBox.Text);
                return true;
            }
            catch (FormatException)
            {
                MessageBox.Show(name + " must be a decimal value.",
                    "Entry Error");
                textBox.Focus();
                return false;
            }
        }
        public bool IsInt32(TextBox textBox, string name)
        {
            try
            {
                Convert.ToInt32(textBox.Text);
                return true;
            }
            catch (FormatException)
            {
                MessageBox.Show(name + " must be an integer.",
                    "Entry Error");
                textBox.Focus();
                return false;
            }
        }
        public bool IsWithinRange(TextBox textBox, string name,
            decimal min, decimal max)
        {
            decimal number = Convert.ToDecimal(textBox.Text);
            if (number < min || number > max)
            {
                MessageBox.Show(name + " must be between " +
                    min + " and " + max + ".",
                    "Entry Error");
                textBox.Focus();
                return false;
            }
            return true;
        }


        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                if (IsValidData())
                {
                    decimal monthlyInvestment =
                        Convert.ToDecimal(txtMonthlyInvestment.Text);
                    decimal yearlyInterestRate =
                        Convert.ToDecimal(txtYearlyInterestRate.Text);
                    int years = Convert.ToInt32(txtNumberOfYears.Text);

                    int months = years * 12;
                    decimal monthlyInterestRate =
                        yearlyInterestRate / 12 / 100;
                    decimal futureValue = CalculateFutureValue(
                        monthlyInvestment, monthlyInterestRate,
                        months);
                    lblFutureValue.Text = futureValue.ToString("c");
                    txtMonthlyInvestment.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n\n" +
                    ex.GetType().ToString() + "\n" +
                    ex.StackTrace, "Exception");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
