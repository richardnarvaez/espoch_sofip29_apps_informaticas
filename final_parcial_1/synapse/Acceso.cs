using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Text;
using Firebase.Database;
using Newtonsoft.Json;
using System.IO;
using synapse.Properties;
using System.Windows.Interop;

namespace synapse
{
    public partial class Acceso : Form
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

        public Acceso()
        {
            InitializeComponent();
   
        }



        private void pictureBox3_MouseEnter(object sender, EventArgs e)
        {
            pictureBox3.Image = Properties.Resources.bt_exit;
            pictureBox3.Refresh();
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            pictureBox3.Image = Properties.Resources.bt_exit_none;
            pictureBox3.Refresh();
        }

        private void pictureBox6_MouseEnter(object sender, EventArgs e)
        {
            pictureBox6.Image = Properties.Resources.bt_min;
            pictureBox6.Refresh();
        }

        private void pictureBox6_MouseLeave(object sender, EventArgs e)
        {
            pictureBox6.Image = Properties.Resources.bt_min_none;
            pictureBox6.Refresh();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal) {
                this.WindowState = FormWindowState.Maximized;
            }
            else {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

      

        bool reg = true;
        private void label4_Click(object sender, EventArgs e)
        {
            if (reg)
            {
                label4.Text = "INICIAR SESION";
                button1.Enabled = false;
                button1.Visible = false;

                button2.Enabled = true;
                button2.Visible = true;

                bunifuMaterialTextbox3.Enabled = true;
                bunifuMaterialTextbox3.Visible = true;
                reg = false;
            }
            else {
                label4.Text = "REGISTRARSE";

                button2.Enabled = false;
                button2.Visible = false;

                button1.Enabled = true;
                button1.Visible = true;
                

                bunifuMaterialTextbox3.Enabled = false;
                bunifuMaterialTextbox3.Visible = false;
                reg = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainForm mF = new MainForm();
          
            this.Hide();
            mF.Show();
            /*if (DataBase.SignIn(bunifuMaterialTextbox1.Text, bunifuMaterialTextbox2.Text))
            {
                Settings.Default.CheckSession = checkBox1.Checked;
                Settings.Default.User = bunifuMaterialTextbox1.Text;
                Settings.Default.Save();
                MainForm mF = new MainForm();
                this.Hide();
                mF.Show();
            }
            else
            {
                MessageBox.Show("El Usuario ingresado es incorrecto.");
            }*/
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MainForm mF = new MainForm();
            this.Hide();
            mF.Show();

           /* bool state = DataBase.registerUser(bunifuMaterialTextbox1.Text, bunifuMaterialTextbox2.Text, bunifuMaterialTextbox3.Text);

            if (!state
                && bunifuMaterialTextbox1.Text.Length >=4
                && bunifuMaterialTextbox2.Text.Length >= 4
                && bunifuMaterialTextbox3.Text.Length >= 4)
            {
                Settings.Default.CheckSession = checkBox1.Checked;
                Settings.Default.Save();
                MainForm mF = new MainForm();
                this.Hide();
                mF.Show();
            }
            else {
                MessageBox.Show("El Usuario ingresado es incorrecto o ya existe.");
            }*/
        }

        private void bunifuMaterialTextbox1_TextChanged(object sender, EventArgs e)
        {
           ///
        }

        private void bunifuMaterialTextbox2_TextChanged(object sender, EventArgs e)
        {
            ///
        }

        private void bunifuMaterialTextbox1_Click(object sender, EventArgs e)
        {
            bunifuMaterialTextbox1.Text = "";
        }

        private void bunifuMaterialTextbox2_Click(object sender, EventArgs e)
        {
            bunifuMaterialTextbox2.Text = "";
        }
    }
}
