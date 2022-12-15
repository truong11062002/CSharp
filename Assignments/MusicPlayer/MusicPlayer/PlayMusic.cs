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
    public partial class PlayMusic : Form
    {
        
        public PlayMusic()
        {
            InitializeComponent();
        }



        public PlayMusic(DataTable dt) : this()
        {
            DataRow dr = dt.Rows[0];

            axWindowsMediaPlayer.URL = "MusicData/" + dr["music_id"] + ".mp3";
            axWindowsMediaPlayer.Ctlcontrols.play();

            label_tennhac.Text = dr["music_name"].ToString();
            label_tencasi.Text = dr["singer_name"].ToString();
            richTextBox_loibaihat.Text = dr["music_lyric"].ToString();
        }
    }
}
