using synapse.Properties;
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
    public partial class SplashScreen : Form
    {

       /* protected override CreateParams CreateParams
        {
            get
            {
                const int CS_DROPSHADOW = 0x20000;
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CS_DROPSHADOW;
                return cp;
            }
        }*/

        private int porcentaje,num;
        public SplashScreen()
        {
            InitializeComponent();
            porcentaje = 0;
            timer1.Enabled = true;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void bunifuProgressBar1_progressChanged(object sender, EventArgs e)
        {

        }
        private int tic=0;

        private void bunifuGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object snder, EventArgs e)
        {
            tic += 1;
            porcentaje = tic * 100 / 500;
            if (porcentaje % 2==0)
            {
                num = new Random().Next(0,3);
                
            }
            switch (num)
            {
                case 0:
                    label3.Text = "BASE DE DATOS";
                    break;
                case 1:
                    label3.Text = "CARGANDO IMAGENES";
                    break;
                case 2:
                    label3.Text = "COMPROBANDO DISPONIBLIDAD DE RED";
                    break;
                case 3:
                    label3.Text = "CARGANDO ARCHIVOS";
                    break;


            }

            if (porcentaje >=90) {
                label3.Text = "FINALIZANDO ANALISIS...";
            }
             

            
            label1.Text = "cargando... " + porcentaje + "%";
            bunifuProgressBar1.Value = porcentaje;
            if(porcentaje>=100)
            {
                timer1.Enabled = false;
                if (Settings.Default.CheckSession)
                {
                    MainForm main = new MainForm();
                    this.Hide();
                    main.Show();
                }
                else {
                    /* Primera pantalla */
                    Acceso a = new Acceso();
                    this.Hide();
                    a.Show();
                }
            

            }
        }
    }
}
