using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace synapse
{
    public partial class ItemVideo : UserControl
    {
        int video_num;
        string url;
        public ItemVideo()
        {
            InitializeComponent();
        }

        public ItemVideo(String title, String description, String thumnail, String url, int nm)
        {
            InitializeComponent();
            axWindowsMediaPlayer1.Visible = false;
            txt_v_title.Text = title;
            txt_v_description.Text = description;
            try{
                pictureBox1.Load(thumnail);
            }
            catch (Exception e){

            }
            this.video_num = nm;
            this.url = url;
        }

        private void ItemVideo_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (video_num) {
                case 0:
                    axWindowsMediaPlayer1.URL = @"D:\Dropbox\PROYECTO SYNAPSE\synapse\synapse\Resources\qes-1.mp4";
                    axWindowsMediaPlayer1.Visible = true;
                    break;
                case 1:
                    axWindowsMediaPlayer1.URL = @"D:\Dropbox\PROYECTO SYNAPSE\synapse\synapse\Resources\qes-resistencia.mp4";
                    axWindowsMediaPlayer1.Visible = true;
                    break;
                case 2:
                    axWindowsMediaPlayer1.URL = @"D:\Dropbox\PROYECTO SYNAPSE\synapse\synapse\Resources\qes-3.mp4";
                    axWindowsMediaPlayer1.Visible = true;
                    break;
                case 3:
                    axWindowsMediaPlayer1.URL = @"D:\Dropbox\PROYECTO SYNAPSE\synapse\synapse\Resources\qes-4.mp4";
                    axWindowsMediaPlayer1.Visible = true;
                    break;
                case 4:
                    axWindowsMediaPlayer1.URL = @"D:\Dropbox\PROYECTO SYNAPSE\synapse\synapse\Resources\qes-5.mp4";
                    axWindowsMediaPlayer1.Visible = true;
                    break;
                case 5:
                    axWindowsMediaPlayer1.URL = @"D:\Dropbox\PROYECTO SYNAPSE\synapse\synapse\Resources\qes-6.mp4";
                    axWindowsMediaPlayer1.Visible = true;
                    break;

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.pause();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.stop();
            axWindowsMediaPlayer1.Visible = false;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.play();
            axWindowsMediaPlayer1.Visible = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(url);
        }
    }
}
