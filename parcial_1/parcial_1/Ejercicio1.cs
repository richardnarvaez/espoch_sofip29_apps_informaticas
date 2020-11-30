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
    public partial class Ejercicio1 : UserControl
    {
        public Ejercicio1()
        {
            InitializeComponent();
        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            try
            {
                int altura_p = int.Parse(input_1.Text);
                int base_p = int.Parse(input_2.Text);
                double Ab = base_p * base_p;
                double volumen = (Ab * altura_p) / 3;

                label1.Text = Math.Round(volumen, 2) + "m^3";
                label3.Visible = false;
            }
            catch
            {
                label1.Text = "...";
                label3.Visible = true;
            }
        }

        private void Ejercicio1_Load(object sender, EventArgs e)
        {

        }
    }
}
