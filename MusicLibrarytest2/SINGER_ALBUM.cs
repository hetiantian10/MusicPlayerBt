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
    public partial class SINGER_ALBUM : Form
    {
        public SINGER_ALBUM()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dashboard ds = new Dashboard();
            ds.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Song_Library ds = new Song_Library();
            ds.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        
           

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Song Added ! ");
                Application.Exit();
        }

        private void SName_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void SINGER_ALBUM_Load(object sender, EventArgs e)
        {
            
        }
    }
}
