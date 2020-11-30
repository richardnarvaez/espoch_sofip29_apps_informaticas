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
    public partial class Ejercicio5 : UserControl
    {
        public Ejercicio5()
        {
            InitializeComponent();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            label3.Text = "0";
            for (int i =0 ; i< checkedListBox1.Items.Count; i++) {
                if (checkedListBox1.GetItemChecked(i)) {
                    listView1.Items.Add(checkedListBox1.Items[i].ToString());
                    label3.Text = "" + (int.Parse(label3.Text) + new Random().Next(1,50));
                }

            }
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                checkedListBox1.SetItemChecked(i, false);

            }
            listView1.Items.Clear();
            label3.Text = "0";

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (label3.Text == "0")
            {
                MessageBox.Show("No se puede comprar, la lista esta vacia.");
            }
            else {
                MessageBox.Show("Compra exitosa.");
                for (int i = 0; i < checkedListBox1.Items.Count; i++)
                {
                    checkedListBox1.SetItemChecked(i, false);
                }
                listView1.Items.Clear();
                label3.Text = "0";
            }
        }
    }
}
