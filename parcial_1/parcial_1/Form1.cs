using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace parcial_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            unselectMenu();
            ocultarEjercicios();
            verEjercicio(1);
            guna2Button1.Checked = true;
            label1.Text = "Ejercicio I";
            label2.Text = "Parcial I - Volumen de un pirámide de base cuadrada";
            label4.Text = "Halle el volumen de una piramide de base cuadrada conociendo que su altura es H metros y que uno de sus lados de la base mide L metros.";
         }

        private void verEjercicio(int position)
        {
            switch (position) {
                case 1:
                    ejercicio11.Visible = true;
                    ejercicio11.Width = 375;
                    ejercicio11.Height = 561;
                    ejercicio11.Location = new Point(0, 0);
                    break;
                case 2:
                    ejercicio21.Visible = true;
                    ejercicio21.Width = 375;
                    ejercicio21.Height = 561;
                    ejercicio21.Location = new Point(0, 0);

                    break;
                case 3:
                    ejercicio31.Visible = true;
                    ejercicio31.Width = 375;
                    ejercicio31.Height = 561;
                    ejercicio31.Location = new Point(0, 0);

                    break;
                case 4:
                    ejercicio41.Visible = true;
                    ejercicio41.Width = 375;
                    ejercicio41.Height = 561;
                    ejercicio41.Location = new Point(0, 0);
                    break;
                case 5:
                    ejercicio51.Visible = true;
                    ejercicio51.Width = 375;
                    ejercicio51.Height = 561;
                    ejercicio51.Location = new Point(0, 0);
                    break;
                case 6:
                    ejercicio61.Visible = true;
                    ejercicio61.Width = 375;
                    ejercicio61.Height = 561;
                    ejercicio61.Location = new Point(0, 0);
                    break;case 7:
                    ejercicio71.Visible = true;
                    ejercicio71.Width = 375;
                    ejercicio71.Height = 561;
                    ejercicio71.Location = new Point(0, 0);
                    break;case 8:
                    ejercicio81.Visible = true;
                    ejercicio81.Width = 375;
                    ejercicio81.Height = 561;
                    ejercicio81.Location = new Point(0, 0);
                    break;
                default:
                    break;
            }
            
        }

        private void ocultarEjercicios() {
            ejercicio11.Visible = false;
            ejercicio21.Visible = false;
            ejercicio31.Visible = false;
            ejercicio41.Visible = false;
            ejercicio51.Visible = false;
            ejercicio61.Visible = false;
            ejercicio71.Visible = false;
            ejercicio81.Visible = false;
        }
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            unselectMenu();
            ocultarEjercicios();
            verEjercicio(1);
            guna2Button1.Checked = true;
            label1.Text = "Ejercicio I";
            label2.Text = "Parcial I - Volumen de un pirámide de base cuadrada";
            label4.Text = "Halle el volumen de una piramide de base cuadrada conociendo que su altura es H metros y que uno de sus lados de la base mide L metros.";
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            unselectMenu();
            guna2Button2.Checked = true;
            ocultarEjercicios();
            verEjercicio(2);
            label1.Text = "Ejercicio II";
            label2.Text = "Parcial I - La voz";
            label4.Text = "Mostrar una imagen al reconocer la voz mediante la libreria SPEECH";
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            unselectMenu();
            ocultarEjercicios();
            verEjercicio(3);
            guna2Button3.Checked = true;
            label1.Text = "Ejercicio III";
            label2.Text = "Parcial I - La calculadora, librerías Math";
            label4.Text = "Crear una calculadora con todas las funciones de Math";
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            unselectMenu();
            ocultarEjercicios();
            verEjercicio(4);
            guna2Button4.Checked = true;
            label1.Text = "Ejercicio IV";
            label2.Text = "Parcial I - Juego";
            label4.Text = "Crear un juego. En este apratado se creo un juego de azar. Si salen dos o tres numeros iguales ganas puntos.";
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            unselectMenu();
            ocultarEjercicios();
            verEjercicio(5);
            guna2Button5.Checked = true;
            label1.Text = "Ejercicio V";
            label2.Text = "Parcial I - Compra";
            label4.Text = "Lista de productos y checkout";
        }

        private void unselectMenu() {
            guna2Button1.Checked = false;
            guna2Button2.Checked = false;
            guna2Button3.Checked = false;
            guna2Button4.Checked = false; 
            guna2Button5.Checked = false;
            guna2Button6.Checked = false;
            guna2Button7.Checked = false;
            guna2Button8.Checked = false;
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            unselectMenu();
            ocultarEjercicios();
            verEjercicio(6);
            guna2Button6.Checked = true;
            label1.Text = "Ejercicio VI";
            label2.Text = "Parcial I - Editor";
            label4.Text = "Crear un editor de texto simple.";
        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            unselectMenu();
            ocultarEjercicios();
            verEjercicio(7);
            guna2Button7.Checked = true;
            label1.Text = "Ejercicio VII";
            label2.Text = "Parcial I - Serie";
            label4.Text = "Esto es un cambio";

        }

        private void guna2Button8_Click(object sender, EventArgs e)
        {
            unselectMenu();
            ocultarEjercicios();
            verEjercicio(8);
            guna2Button8.Checked = true;
            label1.Text = "Ejercicio VIII";
            label2.Text = "Parcial I - Arreglos";
            label4.Text = "Ejercicio de Arreglos de Objetos: Realizar un programa  para ingresar y listar(datagridview) los datos de un cliente, utilice get y set";
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            if (guna2TextBox1.Text == "")
            {
                MessageBox.Show("Debes introducir un nombre valido", "Error",
       MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
                    }
            label3.Text = guna2TextBox1.Text + " - Parcial I";
            guna2GradientPanel1.Visible = false;
        }
    }
}
