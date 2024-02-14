using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TelephoneNumbers
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private char MapCharToDigit(char inputChar)
        {
            if (inputChar >= 'A' && inputChar <= 'C') return '2';
            else if (inputChar >= 'D' && inputChar <= 'F') return '3';
            else if (inputChar >= 'G' && inputChar <= 'I') return '4';
            else if (inputChar >= 'J' && inputChar <= 'L') return '5';
            else if (inputChar >= 'M' && inputChar <= 'O') return '6';
            else if (inputChar >= 'P' && inputChar <= 'S') return '7';
            else if (inputChar >= 'T' && inputChar <= 'V') return '8';
            else if (inputChar >= 'W' && inputChar <= 'Z') return '9';
            else return inputChar;
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {

            string alphanumeric = txtAlphanumeric.Text.ToUpper();
            string NumericOnly = "";

            for (int i = 0; i < alphanumeric.Length; i++)
            {
                char currentChar = alphanumeric[i];
                NumericOnly += MapCharToDigit(currentChar);
            }

            lblNumerice.Text = NumericOnly;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
