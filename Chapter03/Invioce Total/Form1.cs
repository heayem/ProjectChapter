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
    public partial class frmInvioce : Form
    {
        public frmInvioce()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            decimal subtotal = Convert.ToDecimal(TxtSubtotal.Text);
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
            TxtDiscountPercent.Text = disCountPercent.ToString("p1");
            TxtDiscountAmount.Text = disCountAmount.ToString("c");
            TxtTotal.Text = invoiceTotal.ToString("c");
            TxtTotal.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
