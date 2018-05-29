using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data;

namespace MusicPlayer
{
    public static class SQL 
    {
        public static void LoadList(ListView listView1, SqlConnection cn)
        {
            string zapis = null;
            listView1.Items.Clear();
            listView1.FullRowSelect = true;
            SqlCommand cm = new SqlCommand("SELECT * FROM Utwory ORDER BY ID", cn);
            int i = 1;
            try
            {
                SqlDataReader dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    ListViewItem item = new ListViewItem(i.ToString());
                    item.SubItems.Add(dr["Tytuł"] + " " + dr["Wykonawca"].ToString());
                    zapis = @"Muzyka";
                    item.SubItems.Add(dr["Sciezka"].ToString());
                    //item.SubItems.Add(zapis + @"\" + dr["Tytuł"].ToString());
                    item.Checked = true;


                    listView1.Items.Add(item);
                    i++;
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        public static void AddMusic(SqlConnection cn)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Audio File (*.mp3;*.wav)|*.mp3;*.wav;";
            if (open.ShowDialog() != DialogResult.OK) return;

            SqlCommand cmd = cn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            string sciezka = @"Muzyka\";
            sciezka += open.SafeFileName;
            cmd.CommandText = "INSERT INTO Utwory(Tytuł,Wykonawca,Sciezka) VALUES('" + open.SafeFileName + "','" + null + "','" + sciezka + "')";
            cmd.ExecuteNonQuery();
        }
            


    }

}
