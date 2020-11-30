using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace app_info_12_factorial
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int value = int.Parse(textBox1.Text);
                label2.Text = value 
                    + (MathPlus.esPrimo(value) ? "" : " no") 
                    + " es primo, y su factorial es: " 
                    + MathPlus.factorial(value);
            }
            catch {
                label2.Text = "...";
            }
        }

    }
}
