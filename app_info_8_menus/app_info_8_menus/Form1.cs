using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace app_info_8_menus
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void abrirArchivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Bitmap.FromFile(openFileDialog1.FileName);
            }
            else {
                MessageBox.Show("No selecciono nada.", "Mensaje", MessageBoxButtons.OK);
            }

        }

        private void seleccionarColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            label1.ForeColor = colorDialog1.Color;
        }

        private void colorFondoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            label1.BackColor = colorDialog1.Color;
        }

        private void fechaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.ToString("yyyy/MM/dd");
        }

        private void horaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label3.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void formularioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Form2().Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void ayudaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(new Uri(@"file://" + Environment.SpecialFolder.Desktop + "/ayuda.html"));
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }
    }
}
