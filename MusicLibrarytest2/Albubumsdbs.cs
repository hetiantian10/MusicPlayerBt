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
    public partial class Albubumsdbs : Form
    {
        public Albubumsdbs()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dashboard ds = new Dashboard();
            ds.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }
    }
}
