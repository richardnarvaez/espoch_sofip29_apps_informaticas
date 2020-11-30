using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace parcial_1
{
    public partial class Ejercicio7 : UserControl
    {
        public Ejercicio7()
        {
            InitializeComponent();
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            label2.Text = "Serie: ";
            double result = 0;
            int nega = -1;
            long up = 1;
            long down = 2;
            int exp = 0;

            double auxUp = 0;
            double auxDown = 0;

            for (int i = 1; i<=int.Parse(guna2TextBox1.Text) ; i++) {
                nega = nega * -1;
                exp += 1;

                auxDown = fact(down);
                auxUp = Math.Pow(up, exp);

                if (i % 2 == 0) {
                    result += nega * (auxDown/auxUp);
                    label2.Text = label2.Text + (nega < 0 ? " - " : " + ") +  "("+ down + "!/"+ up +"^" + exp + ")";
                }
                else
                {
                    result += nega * (auxUp/auxDown);
                    label2.Text = label2.Text + (nega < 0 ? " - " : " + ") + "(" + up + "^"+ exp +"/" + down+ "!)";
                }

                
                up += 2;
                down += 2;
            }
            label1.Text = "El valor es: " + result;
        }

        public static long fact(long n)
        {
            if (n == 1)
                return 1;
            return n * fact(n - 1);
        }
    }
}
