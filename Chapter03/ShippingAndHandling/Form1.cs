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
                orderTotal += 10;

                txtGrandeTotal.Text = orderTotal.ToString();
            }
            else
            {
                MessageBox.Show("Please enter a valid Order Total .");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
