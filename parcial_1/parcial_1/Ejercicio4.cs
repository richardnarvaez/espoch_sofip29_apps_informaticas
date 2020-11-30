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
    public partial class Ejercicio4 : UserControl
    {
        public Ejercicio4()
        {
            InitializeComponent();
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            if (int.Parse(label3.Text) == 0) {
                MessageBox.Show("No puedes jugar con $0");
                return;
            }
            label3.Text = "" + (int.Parse(label3.Text) - 2);
            Animate(5);
        }

        async  void Animate(int delay)
        {
            for (int i = 1; i < 10; ++i)
            {
                Random ram = new Random();
                int a = ram.Next(1, 9);
                int b = ram.Next(1, 9);
                int c = ram.Next(1, 9);
                label4.Text = "" + a;
                label6.Text = "" + b;
                label7.Text = "" + c;
                await Task.Delay(delay);
                delay = delay * 2;
            }
            if (label4.Text == label6.Text && label4.Text == label7.Text)
            {
                MessageBox.Show("Ganaste 5$");
                label3.Text = "" + (int.Parse(label3.Text) + 5);
            }
            else if(label4.Text == label6.Text ||
                label6.Text == label7.Text ||
                label4.Text == label7.Text)
            {
                MessageBox.Show("Ganaste 2$");
                label3.Text = "" + (int.Parse(label3.Text) + 2);
            }
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            label3.Text = "" + (int.Parse(label3.Text) + 10);
        }
    }
}
