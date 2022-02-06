using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace MusicLibrarytest2
{
    public partial class Song_Library : Form
    {
        public Song_Library()
        {
            InitializeComponent();
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void Song_Library_Load(object sender, EventArgs e)
        {

        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Admin\Documents\AlbummusicplayerDB.mdf;Integrated Security=True;Connect Timeout=30");
        private void ShowUser()
        {
            con.Open();
            string Query = "selcet * from SAlbum";
            SqlDataAdapter sda = new SqlDataAdapter(Query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            
            
            con.Close();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into SAlbum (SngId,SngName,Singer,RDate,Genre) values(@SI,@SN,@S,@RD,@G)", con);
          
            cmd.Parameters.AddWithValue("@SngName", SngName.Text);
            cmd.Parameters.AddWithValue("@Singer", Singer.Text);
            cmd.Parameters.AddWithValue("@Rdate", RDate.Value.Date);
            cmd.Parameters.AddWithValue("@Genre", Genre.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Song Added");
           
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dashboard ds = new Dashboard();
            ds.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SINGER_ALBUM Obj = new SINGER_ALBUM();
            Obj.Show();
        }
    }
}
