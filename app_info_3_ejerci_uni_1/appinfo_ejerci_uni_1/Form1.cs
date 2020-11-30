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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Ej1().Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Ej2().Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new Ej3().Show();
        }
    }
}
