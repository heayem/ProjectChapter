using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShippingAndHandling
{
    public partial class frmShippingAndHandling : Form
    {
        public frmShippingAndHandling()
        {
            InitializeComponent();
        }

        private void btnCalculateGrandTotal_Click(object sender, EventArgs e)
        {

            if (decimal.TryParse(txtOrderTotal.Text, out decimal orderTotal))
            {
                decimal tax;
                String costumerType = txtComstumerType.Text;
                decimal shipping=0m;
                tax = calculateTax((orderTotal + shipping), 0.07m);

                if (costumerType == "P" || costumerType == "p")
                {
                    lblShippingCost.Text = shipping.ToString("C");
                    lblSaleTax.Text = tax.ToString("C");
                    txtGrandeTotal.Text = ((orderTotal + shipping) + tax).ToString("C");
                }
                else if (costumerType == "N" || costumerType == "n")
                {
                    shipping = shippingCost(orderTotal);
                    lblShippingCost.Text = shipping.ToString("C");
                    lblSaleTax.Text = tax.ToString("C");
                    txtGrandeTotal.Text = ((orderTotal + shipping) + tax).ToString("C");
                }

            }
            else
            {
                MessageBox.Show("Please enter a valid Order Total .");
            }
        }
        private decimal calculateTax(decimal total,decimal tax)
        {
            return (total * tax);
        }
        private decimal shippingCost(decimal order)
        {
            if (order <= 25.00m)
            {
                lblShippingCost.Text = " 5.00m";
                return 5.00m;
            }
            else if (order <= 500.00m)
            {
                lblShippingCost.Text = " 8.00m";
                return 8.00m;
            }
            else if (order <= 1000.00m)
            {
                lblShippingCost.Text = " 10.00m";
                return 10.00m;
            }
            else if (order <= 5000.00m)
            {
                lblShippingCost.Text = " 15.00m";
                return 15.00m;
            }
            else
            {
                lblShippingCost.Text = " 20.00m";
                return 20.00m;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
