using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Invioce_Total
{
    public partial class frmInvioceTotal : Form
    {
        public frmInvioceTotal()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        int numberOfInvoices = 0;
        decimal totalOfInvoices = 0m;
        decimal invoiceAverage = 0m;

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            decimal subtotal = Convert.ToDecimal(txtEnterSubtotal.Text);
            decimal disCountPercent =0m;

            if(subtotal >= 500)
            {
                disCountPercent = .2m;
            }
            else if (subtotal >= 250 && subtotal < 500)
            {
                disCountPercent = 1.5m;
            }
            else if (subtotal >= 100 && subtotal < 250)
            {
                disCountPercent = .1m;
            }

            decimal disCountAmount = subtotal * disCountPercent;
            decimal invoiceTotal = subtotal - disCountAmount;

            textSubTotal.Text = subtotal.ToString("c");
            TxtDiscountPercent.Text = disCountPercent.ToString("p1");
            TxtDiscountAmount.Text = disCountAmount.ToString("c");
            TxtTotal.Text = invoiceTotal.ToString("c");

            numberOfInvoices++;
            totalOfInvoices += invoiceTotal;
            invoiceAverage = totalOfInvoices / numberOfInvoices;

            txtNumberOfInvoices.Text = numberOfInvoices.ToString();
            txtTotalOfInvoices.Text = totalOfInvoices.ToString("c");
            txtInvoiceAverage.Text = invoiceAverage.ToString("c");

            txtEnterSubtotal.Text = "";
            txtEnterSubtotal.Focus();

            TxtTotal.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClearTotal_Click(object sender, EventArgs e)
        {
            numberOfInvoices = 0;
            totalOfInvoices = 0m;
            invoiceAverage = 0m;

            txtNumberOfInvoices.Text = "";
            txtTotalOfInvoices.Text = "";
            txtInvoiceAverage.Text = "";


        }
    }
}
