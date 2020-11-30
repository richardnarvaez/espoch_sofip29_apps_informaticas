using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Recognition;

namespace appinfo_5_voice
{
    public partial class Form1 : Form
    {
        SpeechRecognitionEngine objVoice = new SpeechRecognitionEngine();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnInciar_Click(object sender, EventArgs e)
        {
            objVoice.SetInputToDefaultAudioDevice();
            objVoice.LoadGrammar(new DictationGrammar());
            objVoice.SpeechRecognized += enlazar;
            objVoice.RecognizeAsync(RecognizeMode.Multiple);
        }

        void enlazar(object sender, SpeechRecognizedEventArgs e) {
            textBox1.Text = e.Result.Text;
        }

        private void btnPausar_Click(object sender, EventArgs e)
        {
            objVoice.RecognizeAsyncStop();
        }
    }
}
