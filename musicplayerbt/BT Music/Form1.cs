using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BT_Music
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lblVolume2.Text = "10";
            
        }
        string[] paths, files;

        private void btnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Multiselect = true;
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                files = ofd.FileNames;
                paths = ofd.FileNames;
                for (int i = 0; i < files.Length; i++)
                {
                    trackList.Items.Add(files[i]);
                }
            }
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void trackList_SelectedIndexChanged(object sender, EventArgs e)
        {
            player.URL = paths[trackList.SelectedIndex];
            player.Ctlcontrols.play();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            player.Ctlcontrols.stop();
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            player.Ctlcontrols.pause();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            player.Ctlcontrols.play();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if(trackList.SelectedIndex<trackList.Items.Count-1)
            {
                trackList.SelectedIndex = trackList.SelectedIndex + 1;
            }
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            if(trackList.SelectedIndex>0)
            {
                trackList.SelectedIndex = trackList.SelectedIndex - 1;
            }
        }

       

        private void timer1_Tick(object sender, EventArgs e)
        {

            if (player.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                pBar.Maximum = (int)player.Ctlcontrols.currentItem.duration;
                pBar.Value = (int)player.Ctlcontrols.currentPosition;
            }
            try
            {
                lblTrackStart.Text = player.Ctlcontrols.currentPositionString;
                lblTrackEnd.Text = player.Ctlcontrols.currentItem.durationString;
               
            }
            catch
            {

            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Multiselect = true;
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                files = ofd.FileNames;
                paths = ofd.FileNames;
                for (int i = 0; i < files.Length; i++)
                {
                    trackList.Items.Add(files[i]);
                }
            }
        }

        private void trackVolumeScroll_Scroll(object sender, EventArgs e)
        {
            player.settings.volume = trackVolume.Value;
            lblVolume2.Text = trackVolume.Value.ToString() + "";
           

        }


    }
}
