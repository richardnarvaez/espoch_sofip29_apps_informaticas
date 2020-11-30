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
    public partial class Ej1 : Form
    {
        public Ej1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string value = ((TextBox)sender).Text;
            try {
                int cc = (int)(Math.Log(int.Parse(value)) / Math.Log(10) + 1);
                this.label5.Text = cc >= 0 ? cc.ToString() : "Err_1";
            } catch {
                this.label5.Text = "...";
                MessageBox.Show("The number is incorrect or extremely long", "Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
