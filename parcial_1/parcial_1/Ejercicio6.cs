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
    public partial class Ejercicio6 : UserControl
    {
        public Ejercicio6()
        {
            InitializeComponent();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK) {
                richTextBox1.BackColor = colorDialog1.Color;
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.ForeColor = colorDialog1.Color;
            }
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            var new_style = richTextBox1.SelectionFont.Style;
            if (richTextBox1.SelectionFont.Bold)
            {
                new_style &= ~FontStyle.Bold;
            }
            else {
                new_style |= FontStyle.Bold;
            }

            richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, new_style);
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            var new_style = richTextBox1.SelectionFont.Style;
            if (richTextBox1.SelectionFont.Italic)
            {
                new_style &= ~FontStyle.Italic;
            }
            else
            {
                new_style |= FontStyle.Italic;
            }

            richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, new_style);

        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            var new_style = richTextBox1.SelectionFont.Style;
            if (richTextBox1.SelectionFont.Underline)
            {
                new_style &= ~FontStyle.Underline;
            }
            else
            {
                new_style |= FontStyle.Underline;
            }

            richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, new_style);

        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void guna2Button3_Click_1(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Left;
        }

        private void guna2Button8_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Right;
        }

        private void guna2Button9_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "File Teks Berformat (*.rtf)|*.rtf|File Teks (*.txt)|*.txt";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK && !String.IsNullOrWhiteSpace(saveFileDialog1.FileName)) {
                if (saveFileDialog1.FilterIndex == 1)
                {
                    richTextBox1.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.RichText);
                }
                else {
                    richTextBox1.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.PlainText);
                }
            }
        }
    }
}
