using MusicPlayer.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicPlayer
{
    public partial class DetailMusic : Form
    {
        DataTable dt_global;
        string status;
        private Form activeForm = null;
        public DetailMusic()
        {
            InitializeComponent();
        }

        public DetailMusic(Bitmap bm, DataTable dt) : this()
        {
            dt_global = dt;
            DataRow dr = dt.Rows[0];

            music_pictureBox.BackgroundImage = bm;
            music_pictureBox.BackgroundImageLayout = ImageLayout.Stretch;

            label_tennhac.Text = dr["music_name"].ToString();
            label_tacgia.Text = dr["music_author"].ToString();
            label_tencasi.Text = dr["singer_name"].ToString();
            label_theloai.Text = dr["music_category"].ToString();
            label_thoiluong.Text = dr["music_time"].ToString();
            label_namsx.Text = dr["music_release"].ToString();
            label_luotnghe.Text = dr["music_freq"].ToString();
            label_quocgia.Text = dr["music_country"].ToString();
            richTextBox_loibaihat.Text = dr["music_lyric"].ToString();

        }
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            Variables.ListFormPanel.ListFormsPanel[0].Controls.Add(childForm);
            Variables.ListFormPanel.ListFormsPanel[0].Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void cButton1_Click(object sender, EventArgs e)
        {
            openChildForm(new PlayMusic(dt_global));
        }

        private void cButton2_Click(object sender, EventArgs e)
        {
            DataRow dr = dt_global.Rows[0];
            OpenFileDialog folderBrowser = new OpenFileDialog();
            folderBrowser.ValidateNames = false;
            folderBrowser.CheckFileExists = false;
            folderBrowser.CheckPathExists = true;
            folderBrowser.FileName = "Folder Selection";

            if (folderBrowser.ShowDialog() == DialogResult.OK)
            {
                string folderPath = Path.GetDirectoryName(folderBrowser.FileName);
                using (var client = new WebClient())
                {
                    client.DownloadFile($"MusicData/{dr["music_id"]}.mp3", folderPath + $"/{dr["music_id"]}.mp3");
                }
                MessageBox.Show("Tải phim thành công!");
            }
            else
                MessageBox.Show("Tải phim thất bại!");
        }

        private void UpdateStatusLove(string id)
        {
            DataProvider provider = new DataProvider();
            string query = $"select * from MUSIC where music_id = '{id}'";
            DataTable dt = provider.ExecuteQuery(query);

            DataRow dr = dt.Rows[0];
            if (dr["music_love_status"].ToString() == "0")
            {
                status = "0";
                btn_love.Text = "Yêu thích";
                btn_love.BackColor = Color.Red;
            }
            else
            {
                status = "1";
                btn_love.Text = "Bỏ yêu thích";
                btn_love.BackColor = Color.Green;
            }
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            DataRow dr = dt_global.Rows[0];
            DataProvider provider = new DataProvider();
            int i;
            if (status == "1") i = 0;
            else i = 1;
            string query = $"update MUSIC set music_love_status = {i} where music_id = '{dr["music_id"]}'";

            provider.ExecuteNonQuery(query);
            if (status == "1") status = "0";
            else status = "1";
            UpdateStatusLove(dr["music_id"].ToString());
        }
    }
}
