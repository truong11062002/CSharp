using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicPlayer
{
    public partial class DetailMusic : Form
    {
        public DetailMusic()
        {
            InitializeComponent();
        }

        public DetailMusic(Bitmap bm, DataTable dt) : this()
        {
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


    }
}
