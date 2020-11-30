using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Recognition;

namespace parcial_1
{
    public partial class Ejercicio2 : UserControl
    {
        SpeechRecognitionEngine objVoice = new SpeechRecognitionEngine();
        Boolean is_record = false;
        public Ejercicio2()
        {
            InitializeComponent();
        }

        private void Ejercicio2_Load(object sender, EventArgs e)
        {
            guna2PictureBox2.Visible = false;
        }

        private void iniciarReconocimientoVoz()
        {
            is_record = true;
            guna2GradientButton2.Text = "Stop";
            label1.Text = "Reconocioendo...";
            objVoice.SetInputToDefaultAudioDevice();
            objVoice.LoadGrammar(new DictationGrammar());
            objVoice.SpeechRecognized += enlazar;
            objVoice.RecognizeAsync(RecognizeMode.Multiple);
        }

        private void pararReconocimientoVoz() {
            is_record = false;
            guna2GradientButton2.Text = "Reconocer";
            objVoice.RecognizeAsyncStop();
            
        }

        void enlazar(object sender, SpeechRecognizedEventArgs e)
        {
            label1.Text = e.Result.Text;
            if (label1.Text.Contains("Forest"))
            {
                guna2PictureBox2.Visible = true;
            }
        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            if (is_record)
            {
                pararReconocimientoVoz();
            }
            else {

                iniciarReconocimientoVoz();
            }
        }
    }
}
