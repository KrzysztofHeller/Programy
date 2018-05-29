using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NAudio.Wave;
using System.Data.Sql;
using System.Data.SqlClient;

namespace MusicPlayer
{
    public partial class Form1 : Form
    {
        public SqlConnection cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=I:\4semestr\Programowanie\MusicPlayerfinall\MusicPlayer\DatabaseMusic.mdf;Integrated Security=True");

        public Form1()
        {
            InitializeComponent();
        }


        private AudioFileReader stream = null;
        private WaveOutEvent output = null;
        string curTime;


        private void Loadbutton_Click(object sender, EventArgs e)
        {
            SQL.LoadList(listView1, cn);
        }


        private void Resetbutton_Click(object sender, EventArgs e)
        {
            MusicControl.ResetMusic(stream, output);
        }


        private void Playbutton_Click(object sender, EventArgs e)
        {
            MusicControl.PlayMusic(output, Playbutton);
        }

        
        private void Form1_Shown(object sender, EventArgs e)
        {
            try
            {
                cn.Open();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.ExitThread();
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(output!=null)
            {
                output.Pause();
                MusicControl.DisposeWave(output);
            }        
        }

        private void listView1_ItemActivate(object sender, EventArgs e)
        {
            ListView.SelectedIndexCollection sel = listView1.SelectedIndices;
            if (sel.Count == 1)
            {
                ListViewItem selItem = listView1.Items[sel[0]];
                Playaudio(selItem.SubItems[2].Text);
                textBox1.Text = selItem.SubItems[2].Text;
            }
        }

        private void Update_MouseClick(object sender, MouseEventArgs e)
        {
            SQL.AddMusic(cn);
        }

      
        private void Deleteallbutton_Click(object sender, EventArgs e)
                {
                    SqlCommand cm = new SqlCommand("DELETE FROM Utwory", cn);
                    cm.ExecuteNonQuery();
                }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            output.Volume = trackBar1.Value / 100f;
        }


        private void Pasekpozycji_Scroll(object sender, EventArgs e)
        {
            //stream.CurrentTime = TimeSpan.FromSeconds(stream.TotalTime.TotalSeconds / Pasekpozycji.Value );
            stream.CurrentTime = TimeSpan.FromSeconds((stream.TotalTime.TotalSeconds * (Pasekpozycji.Value / stream.TotalTime.TotalSeconds)));
        }
        

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (output != null)
            {
                if (output.PlaybackState == PlaybackState.Playing)
                {
                    curTime = stream.CurrentTime.ToString("mm\\:ss");
                    Pasekpozycji.Value = (int)stream.CurrentTime.TotalSeconds;
                    label1.Text = stream.CurrentTime.ToString("mm\\:ss") + "/" + stream.TotalTime.ToString("mm\\:ss");
                }
            }
        }

        void Playaudio(string patch)
        {
            MusicControl.DisposeWave(output);
            stream = new AudioFileReader(patch);
            output = new WaveOutEvent();
            output.Init(stream);
            MusicControl.Pasekpozycjiinit(stream, Pasekpozycji);
            MusicControl.Tracbarinit(trackBar1);
            Playbutton.Image = Image.FromFile(@"2.png");
            output.Play();
            Playbutton.Enabled = true;
        }

    }
}


