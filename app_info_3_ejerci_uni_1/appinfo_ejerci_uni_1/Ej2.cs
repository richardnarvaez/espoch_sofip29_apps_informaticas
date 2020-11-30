using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appinfo_ejerci_uni_1
{
    public partial class Ej2 : Form
    {
        public Ej2()
        {
            InitializeComponent();
        }

        private void Ej2_Load(object sender, EventArgs e)
        {
            label3.Text = "2. Halle el volumen de una piramide de base cuadrada conociendo que su altura es H metros y que uno de sus lados de la base mide L metros.";
            label_aviso.Visible = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            onChangeInputText();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            onChangeInputText();
        }

        private void onChangeInputText() {
            try
            {
                int altura_p = int.Parse(input_altura.Text);
                int base_p = int.Parse(input_lado.Text);
                double Ab = base_p * base_p;
                double volumen = (Ab * altura_p)/3;

                label_resultado.Text = Math.Round(volumen, 2) + "m^3";
                label_aviso.Visible = false;
            }
            catch {
                label_resultado.Text = "...";
                label_aviso.Visible = true;
            }
        }
    }
}
