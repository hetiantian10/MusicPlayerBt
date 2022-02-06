using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicLibrarytest2
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure ?","Confirm",MessageBoxButtons.YesNo,MessageBoxIcon.Warning) ==DialogResult.Yes)
            Application.Exit();
        }

        private void Youtube_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/channel/UC-9-kyTW8ZkZNDHQJ6FgpwQ");
        }

        private void Instagram_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.instagram.com/?hl=en");
        }

        private void Facebook_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/");
        }

        private void hipToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.universalproductionmusic.com/en-us/discover/genres/hip-hop");
        }

        private void kPopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.library.illinois.edu/ias/koreancollection/kpop/");
        }

        private void classicalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.classicfm.com/discover-music/classical-studying-music-for-brain-power/");
        }

        private void countryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=Y3c-9CYGXmw");
        }

        private void unisexToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void favoritesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Favorites ds = new Favorites();
            ds.Show();
        }

        private void albumToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Albubumsdbs ds = new Albubumsdbs();
            ds.Show();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Song_Library Obj = new Song_Library();
            Obj.Show();
        }
    }
    
}
