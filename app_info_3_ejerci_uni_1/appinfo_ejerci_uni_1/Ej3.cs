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
    public partial class Ej3 : Form
    {
        public Ej3()
        {
            InitializeComponent();
        }

        private void Ej3_Load(object sender, EventArgs e)
        {
            label3.Text = "3. Confeccione un programa para que calcule el perimetro y el area de un triangulo que se muestra en la fiugura, si se conoce el valor de la longitud de sus lados A y B.";
            label6.Visible = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            onChangeInputs();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            onChangeInputs();
        }

        private void onChangeInputs() {
            try
            {
                int a = int.Parse(textBox1.Text);
                int b = int.Parse(textBox2.Text);
                double resultado = Math.Sqrt(Math.Pow(a, 2) - Math.Pow(b, 2));
                if (resultado == 0) {
                    resultado = 1;
                }
                double result_perimetro = Math.Round((resultado + a + b), 2);
                if (Double.IsNaN(result_perimetro)) {
                    label5.Text = "...";
                    label7.Text = "...";
                    label6.Visible = true;
                    return;
                }
                label5.Text = result_perimetro + " U";
                label7.Text = Math.Round(resultado, 2) + " U";
                label6.Visible = false;
            }
            catch {
                label5.Text = "...";
                label6.Visible = true;
            }
            
        }
    }
}
