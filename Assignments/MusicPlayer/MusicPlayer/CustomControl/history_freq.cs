using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicPlayer.CustomControl
{
    public partial class history_freq : UserControl
    {
        public history_freq()
        {
            InitializeComponent();
        }

        public history_freq(Bitmap bm, DataRow dr, int num): this()
        {
            pictureBox1.BackgroundImage = bm;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;

            label_tennhac.Text = dr["music_name"].ToString();
            label_tencasi.Text = dr["singer_name"].ToString();
            label_luotxem.Text = dr["music_freq"].ToString();

            if (num < 10)
                label_num.Text = "0" + num.ToString();
            else
                label_num.Text = num.ToString();
        }
    }
}
