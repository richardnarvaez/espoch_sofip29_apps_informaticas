using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using synapse.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace synapse
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel4.Location = new Point(65, -2);
            escondertodo();
            panel2.Visible = true;
            label8.Text = "Seccion Video";
            label9.Text = "Aqui podras ver tutoriales y ejercicios dictados por profesores o estudiantes que te ayudaran\na mejorar en tu rendimiento.";
            axWindowsMediaPlayer1.Ctlcontrols.pause();
            /*GameForm game = new GameForm();
            this.Hide();
            game.ShowDialog();
            this.Show();*/
        }

        public void escondertodo()
        {
            panel2.Visible = false;
            panel_game.Visible = false;
            panel_exam.Visible = false;
            panel_settigns.Visible = false;
            panel_lectura.Visible = false;
        }

        int itempos = 10;

        public class Video
        {
            public Guid Id { get; set; }
            public string Title { get; set; }
            public string Description { get; set; }
            public string Url { get; set; }
            public string Thumbnail { get; set; }

        }

        private async void MainForm_Load(object sender, EventArgs e)
        {

            label1.Text = "" + Settings.Default.User;
            label2.Text = "" + Settings.Default.Email;
           // if (await GetInfoAsync() == 0) {
                //Nada
                //MessageBox.Show("Bienvenido a Omega, ahora podras aprender Circuitos de una forma facil.", "VERSION BETA", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            //}
            //var res = new WebClient().DownloadString("https://top-yotutube-music.firebaseio.com/tuto.json");
            //dynamic data = JsonConvert.DeserializeObject<dynamic>(res);
            //var list = new List<User>();
            


        }

        async Task<int> GetInfoAsync()
        {
            int pos = 0;
            ItemVideo item;
            for (pos = 0; pos <= 5; pos++)
            {
                switch (pos)
                {
                    case 0:
                        item = new synapse.ItemVideo("Video No.1",
                      "Historia de Georg Ohm",
                      "https://i.ytimg.com/vi/0hXfUy4FwB4/maxresdefault.jpg",
                      "https://www.youtube.com/watch?v=0hXfUy4FwB4",
                      pos);

                        break;

                    case 1:
                        item = new synapse.ItemVideo("Video No.2",
                       "¿Qué es la resistencia?",
                       "https://i.ytimg.com/vi/UOBZBtGlZuQ/maxresdefault.jpg",
                       "https://www.youtube.com/watch?v=UOBZBtGlZuQ",
                       pos);
                        break;

                    case 2:
                        item = new synapse.ItemVideo("Video No.3",
                       "¿Qué es el Amperaje?",
                       "https://i.ytimg.com/vi/K0OpLggKjRw/maxresdefault.jpg",
                       "https://www.youtube.com/watch?v=K0OpLggKjRw",
                       pos);
                        break;

                    case 3:
                        item = new synapse.ItemVideo("Video No.4",
                       "¿Qué es el Voltaje?",
                       "https://i.ytimg.com/vi/jVgDQEb5dlk/maxresdefault.jpg",
                       "https://www.youtube.com/watch?v=jVgDQEb5dlk",
                       pos);
                        break;
                    case 4:
                        item = new synapse.ItemVideo("Video No.5",
                       "LEy de Ohm",
                       "https://i.ytimg.com/vi/_o26cIegIfs/maxresdefault.jpg",
                       "https://www.youtube.com/watch?v=_o26cIegIfs",
                       pos);
                        break;
                    case 5:
                        item = new synapse.ItemVideo("Video No.6",
                       "Ejercicios de ejemplo.",
                       "https://www.insbright.com/wp-content/uploads/3205/study-hard-pictures-1280x640.jpg",
                       "https://www.youtube.com/watch?v=wsGiiyYrKzM",
                       pos);
                        break;
                    default:
                        item = new synapse.ItemVideo("Titulo",
                       "Descripcion",
                       "https://www.insbright.com/wp-content/uploads/3205/study-hard-pictures-1280x640.jpg",
                       "https://www.youtube.com/watch?v=wsGiiyYrKzM",
                       pos);
                        break;

                }


                panel2.Controls.Add(item);
                item.Top = itempos;
                itempos = (item.Top + item.Height + 10);
                
                //list.Add(JsonConvert.DeserializeObject<User>(((JProperty)itemDynamic).Value.ToString()));
                /*var userGetting = (JsonConvert.DeserializeObject<Video>(((JProperty)itemDynamic).Value.ToString()));
               
                    ItemVideo item = new synapse.ItemVideo(userGetting.Title, 
                        userGetting.Description, 
                        userGetting.Thumbnail,
                        userGetting.Url,
                        pos
                        );
                pos += 1;
                panel2.Controls.Add(item);
                    item.Top = itempos;
                    itempos = (item.Top + item.Height + 10);*/

            }
            return 0;
        }
        public void apagarTB()
        {
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            textBox4.Enabled = false;
            textBox5.Enabled = false;
            textBox6.Enabled = false;
        }



        private void pictureBox3_Click(object sender, EventArgs e)
        {
            DialogResult = MessageBox.Show("¿Desea salir de Omega?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogResult == DialogResult.Yes) {
                Application.Exit();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("¿Estas seguro de cerrar sesión?, Asegurate de cerrar todo correctamente ya que al ser una prueba BETA puede existir algun problema.","Cerrar Sesión", MessageBoxButtons.YesNo,MessageBoxIcon.Question);

            if (res == DialogResult.Yes) { 
            Settings.Default.CheckSession = false;
            Settings.Default.User = "";
            Settings.Default.Email = "";
            Settings.Default.Save();
            axWindowsMediaPlayer1.Ctlcontrols.stop();
            Acceso mF = new Acceso();
            this.Hide();
            mF.Show();
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Aviso", "Actualmente se encuentra desabilitado debido a que es una version BETA.");
        }

        bool menu = false;
        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (!menu)
            {
                menu = true;
                panel1.Width = 215;
                pictureBox5.Image = Resources.arrow_left;
            }
            else {
                pictureBox5.Image = Resources.menu__1_;
                menu = false;
                panel1.Width = 70;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel4.Location = new Point(65, 86);
            escondertodo();
            panel_lectura.Visible = true;
            label8.Text = "Lectura y Audio";
            label9.Text = "Informate acerca de la materia de circuitos.";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel4.Location = new Point(65, 172);
            escondertodo();
            axWindowsMediaPlayer1.Ctlcontrols.pause();
            panel_game.Visible = true;
            label8.Text = "Simulador";
            label9.Text = "Prueba datos y calcula para comprobar tus resultados.";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            panel4.Location = new Point(65, 258);
            escondertodo();
            panel_exam.Visible = true;
            label8.Text = "Examen";
            axWindowsMediaPlayer1.Ctlcontrols.pause();
            label9.Text = "Ahora podras saber cuantos conocimientos as adquirido.";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            panel4.Location = new Point(65, 621);
            escondertodo();
            panel_settigns.Visible = true;
            label8.Text = "Ajuste";
            axWindowsMediaPlayer1.Ctlcontrols.pause();
            label9.Text = "Esta pantalla tiene informacion importante sobre este programa";
        }

        private void button13_Click(object sender, EventArgs e)
        {
           Test exam = new  Test();
           exam.ShowDialog();

        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (Convert.ToDecimal(textBox6.Text) != 0)
            {
                apagarTB();
                textBox5.Enabled = true;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            apagarTB();
            textBox4.Enabled = true;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            apagarTB();
            textBox1.Enabled = true;
            textBox2.Enabled = true;
            textBox3.Enabled = true;
        }

        private void bunifuCards4_Paint(object sender, PaintEventArgs e)
        {//
        }

        private void bunifuCards4_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = @"D:\Dropbox\PROYECTO SYNAPSE\synapse\synapse\Resources\voltaje.wav";
            richTextBox1.Text = "Voltaje (o Diferencia de Potencial): Representa la “fuerza que tiene la energía eléctrica” entre los polos positivo y negativo. Es similar a la que existe entre los polos de los imanes, en los que las fuerzas de atracción y repulsión son invisibles, pero están presentes. La fuerza representada por el voltaje impulsa la electricidad por los conductores y componentes electrónicos de un circuito, haciéndolo funcionar. Se mide en Voltios.";
        }

        private void bunifuCards2_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = @"D:\Dropbox\PROYECTO SYNAPSE\synapse\synapse\Resources\resistencia.wav";
            richTextBox1.Text = "Se le denomina resistencia eléctrica a la oposición al flujo de electrones al moverse a través de un conductor. La unidad de resistencia en el Sistema Internacional es el ohmio, que se representa con la letra griega omega (Ω), en honor al físico alemán Georg Simon Ohm, quien descubrió el principio que ahora lleva su nombre.";
        }

        private void bunifuCards3_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = @"D:\Dropbox\PROYECTO SYNAPSE\synapse\synapse\Resources\intensidad.wav";
            richTextBox1.Text = "La corriente eléctrica es el flujo de carga eléctrica que recorre un material. Se debe al movimiento de las cargas (normalmente electrones) en el interior del mismo. Al caudal de corriente (cantidad de carga por unidad de tiempo) se lo denomina intensidad de corriente eléctrica. En el Sistema Internacional de Unidades se expresa en C/s (culombios sobre segundo), unidad que se denomina amperio (A). Una corriente eléctrica, puesto que se trata de un movimiento de cargas, produce un campo magnético, un fenómeno que puede aprovecharse en el electroimán. El instrumento usado para medir la intensidad de la corriente eléctrica es el galvanómetro que, calibrado en amperios, se llama amperímetro, colocado en serie con el conductor por el que circula la corriente que se desea medir. La intensidad de corriente eléctrica viene dada por la siguiente fórmula I es igual a la carga eléctrica  Q sobre el tiempo de expresado en segundos T";
        }

        private void bunifuCards6_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = @"D:\Dropbox\PROYECTO SYNAPSE\synapse\synapse\Resources\historia.wav";
            richTextBox1.Text = "Georg Simon Ohm 16 de marzo de 1789-Múnich,  6 de julio de 1854) fue un físico y matemático alemán que aportó a la teoría de la electricidad la ley de Ohm. Conocido principalmente por su investigación sobre las corrientes eléctricas, estudió la relación que existe entre la intensidad de una corriente eléctrica, su fuerza electromotriz y la resistencia, formulando en 1827 la ley que lleva su nombre que establece que I = V/R. También se interesó por la acústica, la polarización de las pilas y las interferencias luminosas. La unidad de resistencia eléctrica, el ohmio, recibe este nombre en su honor. Terminó ocupando el puesto de conservador del gabinete de Física de la Academia de Ciencias de Baviera.";
        }

        private void bunifuCards7_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = @"D:\Dropbox\PROYECTO SYNAPSE\synapse\synapse\Resources\ohm.wav";
            richTextBox1.Text = "La Ley de Ohm, postulada por el físico y matemático alemán Georg Simon Ohm, es una de las leyes fundamentales de la electrodinámica, estrechamente vinculada a los valores de las unidades básicas presentes en cualquier circuito eléctrico como son: Tensión o voltaje E, en volt (V).Intensidad de la corriente I , en ampere(A).Resistencia R en ohm() de la carga o consumidor conectado al circuito.Postulado general de la Ley de Ohm. El flujo de corriente en ampere que circula por un circuito eléctrico cerrado, es directamente proporcional a la tensión o voltaje aplicado, e inversamente proporcional a la resistencia en ohm de la carga que tiene conectada. Su formula es la siguiente El voltaje es igual a la intensidad de corriente por la resistencia de la misma.";
        }

        private void bunifuCards5_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = @"D:\Dropbox\PROYECTO SYNAPSE\synapse\synapse\Resources\circuito.wav";
            richTextBox1.Text = "Un circuito es una red electrónica (fuentes, interruptores y semiconductores) que contiene al menos una trayectoria cerrada. Un circuito lineal, que consta de fuentes, componentes lineales (resistencias, condensadores, inductores) y elementos de distribución lineales (líneas de transmisión o cables), tiene la propiedad de la superposición lineal. Además, son más fáciles de analizar, usando métodos en el dominio de la frecuencia, para determinar su respuesta en corriente directa, en corriente alterna y transitoria. Un circuito resistivo es un circuito que contiene solo resistencias y fuentes de voltaje y corriente. El análisis de circuitos resistivos es menos complicado que el análisis de circuitos que contienen capacitores e inductores. Si las fuentes son de corriente directa(corriente continua), se denomina circuito de corriente directa (o continua). Un circuito que tiene componentes electrónicos se denomina circuito electrónico. Generalmente, estas redes son no lineales y requieren diseños y herramientas de análisis mucho más complejos. En fin un circuito eléctrico es el recorrido preestablecido por el que se desplazan las cargas eléctricas.";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "")
            {
                textBox6.Text = Convert.ToString(Convert.ToDecimal(textBox1.Text) +
                    Convert.ToDecimal(textBox2.Text) +
                    Convert.ToDecimal(textBox3.Text));
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "")
            {
                textBox6.Text = Convert.ToString(Convert.ToDecimal(textBox1.Text) +
                    Convert.ToDecimal(textBox2.Text) +
                    Convert.ToDecimal(textBox3.Text));
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "")
            {
                textBox6.Text = Convert.ToString(Convert.ToDecimal(textBox1.Text) +
                    Convert.ToDecimal(textBox2.Text) +
                    Convert.ToDecimal(textBox3.Text));
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            textBox5.Text = Convert.ToString(Convert.ToDecimal(textBox4.Text)
                / Convert.ToDecimal(textBox6.Text));
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox4.Text))
            {
                textBox4.Text = Convert.ToString(Convert.ToDecimal(textBox5.Text)
                    * Convert.ToDecimal(textBox6.Text));
            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            if (Convert.ToDecimal(textBox6.Text) != 0)
            {
                //apagarTB();
                button9.Enabled = true;
                button8.Enabled = true;
            }
            else
            {
                button9.Enabled = false;
                button8.Enabled = false;
            }
        }

        private void panel_game_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuCards2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label29_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = @"D:\Dropbox\PROYECTO SYNAPSE\synapse\synapse\Resources\resistencia.wav";
            richTextBox1.Text = "Se le denomina resistencia eléctrica a la oposición al flujo de electrones al moverse a través de un conductor. La unidad de resistencia en el Sistema Internacional es el ohmio, que se representa con la letra griega omega (Ω), en honor al físico alemán Georg Simon Ohm, quien descubrió el principio que ahora lleva su nombre.";

        }

        private void bunifuCards3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label30_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = @"D:\Dropbox\PROYECTO SYNAPSE\synapse\synapse\Resources\intensidad.wav";
            richTextBox1.Text = "La corriente eléctrica es el flujo de carga eléctrica que recorre un material. Se debe al movimiento de las cargas (normalmente electrones) en el interior del mismo. Al caudal de corriente (cantidad de carga por unidad de tiempo) se lo denomina intensidad de corriente eléctrica. En el Sistema Internacional de Unidades se expresa en C/s (culombios sobre segundo), unidad que se denomina amperio (A). Una corriente eléctrica, puesto que se trata de un movimiento de cargas, produce un campo magnético, un fenómeno que puede aprovecharse en el electroimán. El instrumento usado para medir la intensidad de la corriente eléctrica es el galvanómetro que, calibrado en amperios, se llama amperímetro, colocado en serie con el conductor por el que circula la corriente que se desea medir. La intensidad de corriente eléctrica viene dada por la siguiente fórmula I es igual a la carga eléctrica  Q sobre el tiempo de expresado en segundos T";

        }

        private void label31_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = @"D:\Dropbox\PROYECTO SYNAPSE\synapse\synapse\Resources\voltaje.wav";
            richTextBox1.Text = "Voltaje (o Diferencia de Potencial): Representa la “fuerza que tiene la energía eléctrica” entre los polos positivo y negativo. Es similar a la que existe entre los polos de los imanes, en los que las fuerzas de atracción y repulsión son invisibles, pero están presentes. La fuerza representada por el voltaje impulsa la electricidad por los conductores y componentes electrónicos de un circuito, haciéndolo funcionar. Se mide en Voltios.";

        }

        private void label34_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = @"D:\Dropbox\PROYECTO SYNAPSE\synapse\synapse\Resources\circuito.wav";
            richTextBox1.Text = "Un circuito es una red electrónica (fuentes, interruptores y semiconductores) que contiene al menos una trayectoria cerrada. Un circuito lineal, que consta de fuentes, componentes lineales (resistencias, condensadores, inductores) y elementos de distribución lineales (líneas de transmisión o cables), tiene la propiedad de la superposición lineal. Además, son más fáciles de analizar, usando métodos en el dominio de la frecuencia, para determinar su respuesta en corriente directa, en corriente alterna y transitoria. Un circuito resistivo es un circuito que contiene solo resistencias y fuentes de voltaje y corriente. El análisis de circuitos resistivos es menos complicado que el análisis de circuitos que contienen capacitores e inductores. Si las fuentes son de corriente directa(corriente continua), se denomina circuito de corriente directa (o continua). Un circuito que tiene componentes electrónicos se denomina circuito electrónico. Generalmente, estas redes son no lineales y requieren diseños y herramientas de análisis mucho más complejos. En fin un circuito eléctrico es el recorrido preestablecido por el que se desplazan las cargas eléctricas.";

        }

        private void label33_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = @"D:\Dropbox\PROYECTO SYNAPSE\synapse\synapse\Resources\historia.wav";
            richTextBox1.Text = "Georg Simon Ohm 16 de marzo de 1789-Múnich,  6 de julio de 1854) fue un físico y matemático alemán que aportó a la teoría de la electricidad la ley de Ohm. Conocido principalmente por su investigación sobre las corrientes eléctricas, estudió la relación que existe entre la intensidad de una corriente eléctrica, su fuerza electromotriz y la resistencia, formulando en 1827 la ley que lleva su nombre que establece que I = V/R. También se interesó por la acústica, la polarización de las pilas y las interferencias luminosas. La unidad de resistencia eléctrica, el ohmio, recibe este nombre en su honor. Terminó ocupando el puesto de conservador del gabinete de Física de la Academia de Ciencias de Baviera.";

        }

        private void label32_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = @"D:\Dropbox\PROYECTO SYNAPSE\synapse\synapse\Resources\ohm.wav";
            richTextBox1.Text = "La Ley de Ohm, postulada por el físico y matemático alemán Georg Simon Ohm, es una de las leyes fundamentales de la electrodinámica, estrechamente vinculada a los valores de las unidades básicas presentes en cualquier circuito eléctrico como son: Tensión o voltaje E, en volt (V).Intensidad de la corriente I , en ampere(A).Resistencia R en ohm() de la carga o consumidor conectado al circuito.Postulado general de la Ley de Ohm. El flujo de corriente en ampere que circula por un circuito eléctrico cerrado, es directamente proporcional a la tensión o voltaje aplicado, e inversamente proporcional a la resistencia en ohm de la carga que tiene conectada. Su formula es la siguiente El voltaje es igual a la intensidad de corriente por la resistencia de la misma.";

        }

        private void bunifuCards1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
