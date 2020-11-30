using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace synapse
{
    public partial class Test : Form
    {

        protected override CreateParams CreateParams
        {
            get
            {
                const int CS_DROPSHADOW = 0x20000;
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CS_DROPSHADOW;
                return cp;
            }
        }


        public Test()
        {
            InitializeComponent();
            apagarPanel();
        }

        private void GameForm_Load(object sender, EventArgs e)
        {
            timer1.Enabled =  true;
        }
        

        
        
        
        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        int i = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            i += 1;
            if (i >= 25) {
                timer1.Enabled = false;
                i = 0;
                panel1.Visible = false;
            }
            
        }

        private void bunifuCards1_Paint(object sender, PaintEventArgs e)
        {

        }

        int pregun = 1;
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (pregun < 10)
            {
                pregun += 1;
            }
            else
            {
                pregun = 1;
            }
            pregunta();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (pregun > 1){
                pregun -= 1;
            }
            else
            {
                pregun = 10;
            }

            pregunta();
        }

        public void pregunta() {
            switch (pregun) {
                case 1:
                    labels.Text = "¿En un circuito al aumentar la I, si la R es constante que le sucede a V.?";
                    apagarPanel();
                    panelP1.Visible = true;
                    break;
                case 2:
                    labels.Text = "Un circuito eléctrico tiene una resistencia de 25 ohm y se le aplica a una tension de 125v. Calcular la intesidad de la corriente que circula. ";
                    apagarPanel();
                    panelP2.Visible = true;
                    break;
                case 3:
                    labels.Text = "¿La corriente electrica se mide en?";
                    apagarPanel();
                    panelP3.Visible = true;
                    break;
                case 4:
                    labels.Text = "Por un conductor grueso podra circular ________ intensidad que por uno delgado.";
                    apagarPanel();
                    panelP4.Visible = true;
                    break;
                case 5:
                    labels.Text = "Cules son las varialble que intervienen en la formula de la Ley de Ohm.";
                    apagarPanel();
                    panelP5.Visible = true;
                    break;
                case 6:
                    labels.Text = "La resitencia en un circuito es ________ proporcional a su corriente.";
                    apagarPanel();
                    panelP6.Visible = true;
                    break;
                case 7:
                    labels.Text = "La intensidad en uncircuito es ________ proporcional a la tensión";
                    apagarPanel();
                    panelP7.Visible = true;
                    break;
                case 8:
                    labels.Text = "La unidad de la untesidad en el SI es:";
                    apagarPanel();
                    panelP8.Visible = true;
                    break;
                case 9:
                    labels.Text = "En un circuito al aumentar la resistencia, dispminuye _________ ";
                    apagarPanel();
                    panelP9.Visible = true;
                    break;
                case 10:
                    labels.Text = "La unidad del Voltaje en el SI";
                    apagarPanel();
                    panelP10.Visible = true;
                    break;
            }
        }

       public void apagarPanel()
        {
            panelP2.Visible = false;
            panelP1.Visible = false;
            panelP3.Visible = false;
            panelP4.Visible = false;
            panelP5.Visible = false;
            panelP6.Visible = false;
            panelP7.Visible = false;
            panelP8.Visible = false;
            panelP9.Visible = false;
            panelP10.Visible = false;
        }

        private void panelP5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            panel2.Visible = true;
            if (radioButton5.Checked == true)
            {
                nota += 1;
            }
            if (radioButton3.Checked == true)
            {
                nota += 1;
            }
            if (radioButton9.Checked == true)
            {
                nota += 1;
            }

            if (radioButton11.Checked == true)
            {
                nota += 1;
            }

            if (radioButton15.Checked == true)
            {
                nota += 1;
            }

            if (radioButton17.Checked == true)
            {
                nota += 1;
            }
            if (textBox7.Text == "mayor")
            {
                nota += 1;
            }

            if (radioButton19.Checked == true)
            {
                nota += 1;
            }
            if (radioButton23.Checked == true)
            {
                nota += 1;
            }
            if (checkBox1.Checked == true && checkBox2.Checked == false && checkBox3.Checked == false && checkBox4.Checked == true && checkBox5.Checked == true)
            {
                nota += 1;
            }

            timer2.Enabled = true;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
          
        }

        int nota = 0;
        private void timer2_Tick(object sender, EventArgs e)
        {
            i += 1;
            if (i >= 30)
            {
                timer2.Enabled = false;
                i = 0;
                label12.Text = "" + nota;
                pictureBox2.Visible = false;
                label11.Visible = true;
                label12.Visible = true;
            }
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
