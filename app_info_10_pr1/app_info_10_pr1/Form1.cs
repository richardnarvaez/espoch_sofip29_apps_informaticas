using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace app_info_10_pr1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int v1 = int.Parse(textBox1.Text);
            int v2 = int.Parse(textBox2.Text);
            int v3 = int.Parse(textBox3.Text);

            label1.Text = "El mayor es: " +(v1 > v2 ? v1 : v2 > v3 ? v2 : v3);
        }
    }
}
