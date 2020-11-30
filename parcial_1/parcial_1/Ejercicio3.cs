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
    public partial class Ejercicio3 : UserControl
    {
        public Ejercicio3()
        {
            InitializeComponent();
        }

        private void Ejercicio3_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            try {
                Double numero = Double.Parse(guna2TextBox1.Text);
                label2.Text = "Resultado Absoluto: " + Math.Abs(numero);
            }
            catch {
                label2.Text = "Number invalid";
            }
         }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            try
            {
                Double numero = Double.Parse(guna2TextBox1.Text);
                label2.Text = "Resultado ArcoCoseno: " + Math.Acos(numero);
            }
            catch
            {
                label2.Text = "Number invalid";
            }
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            try
            {
                Double numero = Double.Parse(guna2TextBox1.Text);
                label2.Text = "Resultado ArcoSeno: " + Math.Asin(numero);
            }
            catch
            {
                label2.Text = "Number invalid";
            }
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            try
            {
                Double numero = Double.Parse(guna2TextBox1.Text);
                label2.Text = "Resultado ArcoTAngente: " + Math.Atan(numero);
            }
            catch
            {
                label2.Text = "Number invalid";
            }
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {

        }

        private void guna2GradientButton3_Click(object sender, EventArgs e)
        {
            try
            {
                Double numero = Double.Parse(guna2TextBox1.Text);
                label2.Text = "Resultado Tangente: " + Math.Tan(numero);
            }
            catch
            {
                label2.Text = "Number invalid";
            }
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            try
            {
                Double numero = Double.Parse(guna2TextBox1.Text);
                label2.Text = "Resultado redondeado a entero: " + Math.Ceiling(numero);
            }
            catch
            {
                label2.Text = "Number invalid";
            }
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            try
            {
                Double numero = Double.Parse(guna2TextBox1.Text);
                label2.Text = "Resultado Coseno: " + Math.Cos(numero);
            }
            catch
            {
                label2.Text = "Number invalid";
            }
        }

        private void guna2Button8_Click(object sender, EventArgs e)
        {
            try
            {
                Double numero = Double.Parse(guna2TextBox1.Text);
                label2.Text = "Resultado CosenoHiperbolico: " + Math.Cosh(numero);
            }
            catch
            {
                label2.Text = "Number invalid";
            }
        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            try
            {
                Double numero = Double.Parse(guna2TextBox1.Text);
                label2.Text = "Resultado Exponencial: " + Math.Exp(numero);
            }
            catch
            {
                label2.Text = "Number invalid";
            }
        }

        private void guna2Button12_Click(object sender, EventArgs e)
        {
            try
            {
                Double numero = Double.Parse(guna2TextBox1.Text);
                label2.Text = "Resultado Mayor valor entero al numero: " + Math.Floor(numero);
            }
            catch
            {
                label2.Text = "Number invalid";
            }
        }

        private void guna2Button11_Click(object sender, EventArgs e)
        {
            try
            {
                Double numero = Double.Parse(guna2TextBox1.Text);
                label2.Text = "Resultado Logaritmo natural: " + Math.Log(numero);
            }
            catch
            {
                label2.Text = "Number invalid";
            }
        }

        private void guna2Button10_Click(object sender, EventArgs e)
        {
            try
            {
                Double numero = Double.Parse(guna2TextBox1.Text);
                label2.Text = "Resultado Logaritmo base 10: " + Math.Log10(numero);
            }
            catch
            {
                label2.Text = "Number invalid";
            }
        }

        private void guna2Button15_Click(object sender, EventArgs e)
        {
            try
            {
                Double numero = Double.Parse(guna2TextBox1.Text);
                label2.Text = "Resultado Exponente2: " + Math.Pow(numero, 2);
            }
            catch
            {
                label2.Text = "Number invalid";
            }
        }

        private void guna2Button14_Click(object sender, EventArgs e)
        {
            try
            {
                Double numero = Double.Parse(guna2TextBox1.Text);
                label2.Text = "Resultado Redondeado a dos decimales: " + Math.Round(numero, 2);
            }
            catch
            {
                label2.Text = "Number invalid";
            }
        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            try
            {
                Double numero = Double.Parse(guna2TextBox1.Text);
                label2.Text = "Resultado Seno: " + Math.Sin(numero);
            }
            catch
            {
                label2.Text = "Number invalid";
            }
        }

        private void guna2Button18_Click(object sender, EventArgs e)
        {
            try
            {
                Double numero = Double.Parse(guna2TextBox1.Text);
                label2.Text = "Resultado SenoHiperbolico: " + Math.Sinh(numero);
            }
            catch
            {
                label2.Text = "Number invalid";
            }
        }

        private void guna2Button17_Click(object sender, EventArgs e)
        {
            try
            {
                Double numero = Double.Parse(guna2TextBox1.Text);
                label2.Text = "Resultado Raiz: " + Math.Sqrt(numero);
            }
            catch
            {
                label2.Text = "Number invalid";
            }
        }

        private void guna2Button16_Click(object sender, EventArgs e)
        {
            try
            {
                Double numero = Double.Parse(guna2TextBox1.Text);
                label2.Text = "Resultado TAngente Hiperbolico: " + Math.Tan(numero);
            }
            catch
            {
                label2.Text = "Number invalid";
            }
        }
    }
}
