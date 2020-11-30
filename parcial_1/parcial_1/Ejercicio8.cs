using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace parcial_1
{
    public partial class Ejercicio8 : UserControl
    {
        public Ejercicio8()
        {
            InitializeComponent();
        }

        private void Ejercicio8_Load(object sender, EventArgs e)
        {

        }

        ArrayList list = new ArrayList();
        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            if (guna2TextBox1.Text != "" &&
                guna2TextBox2.Text != "" &&
                guna2TextBox3.Text != "" &&
                guna2TextBox4.Text != "" &&
                guna2TextBox5.Text != ""
                )
            {
                Cliente cliente = new Cliente();
                cliente.Name = guna2TextBox1.Text;
                cliente.Email = guna2TextBox5.Text;
                cliente.Address = guna2TextBox4.Text;
                cliente.CodePost = guna2TextBox3.Text;
                cliente.Phone = guna2TextBox2.Text;
                list.Add(cliente);
            }
            else {
                MessageBox.Show("Debes introducir todos los datos", "Error",
    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            guna2DataGridView1.Rows.Clear();
            foreach (Cliente item in list)
                guna2DataGridView1.Rows.Add(item.Name, item.Address, item.Phone, item.CodePost, item.Email);
        }
    }

}
