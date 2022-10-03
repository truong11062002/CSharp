using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_mini
{
    public partial class Fruit : Form
    {
        public Fruit()
        {
            InitializeComponent();
            WMPMusic.URL = "Faded.mp3";
        }

        private void pic_Close_Fruit(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void pic_Click_Home(object sender, EventArgs e)
        {
            Form1 f_Main = new Form1();
            f_Main.Show();
        }

        private void pic_Click_Back(object sender, EventArgs e)
        {
            this.Close();
            ChooseTopic f_chooseTopic = new ChooseTopic();
            f_chooseTopic.Show();
        }

        public void pic_Volume_Click(object sender, EventArgs e)
        {
            pic_Volume.Visible = false;
            pic_Mute.Visible = true;
            WMPMusic.Ctlcontrols.stop();
        }

        private void pic_NoVolume_Click(object sender, EventArgs e)
        {
            pic_Volume.Visible = true;
            pic_Mute.Visible = false;
            WMPMusic.URL = "Faded.mp3"; 
        }

        private void Fruit_Load(object sender, EventArgs e)
        {

        }
    }
}
