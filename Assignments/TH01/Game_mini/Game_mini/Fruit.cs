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
        DataTable dt = new DataTable();
        Int32 currID = 0;
        Int32 score = 0;

        public Fruit()
        {
            InitializeComponent();

            dt.Columns.Add("ID", typeof(int));
            dt.Columns.Add("En", typeof(string));
            

            dt.Rows.Add("0", "apple");
            dt.Rows.Add("1", "banana");
            dt.Rows.Add("2", "cherry");
            dt.Rows.Add("3", "coconut");
            dt.Rows.Add("4", "grape");
            dt.Rows.Add("5", "lemon");


        }

        private void pic_Close_Fruit(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void pic_Click_Home(object sender, EventArgs e)
        {
            this.Hide();
            main f_Main = new main();
            f_Main.Show();
        }

        private void pic_Click_Back(object sender, EventArgs e)
        {
            this.Hide();
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

        Int32 curr_pic = 0;
        private void Fruit_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            WMPMusic.URL = "Faded.mp3";
            pic_Fruit.BackgroundImage = global::Game_mini.Properties.Resources.tao;

        }

        
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void ChangeImage(Int32 currID)
        {
            switch (currID)
            {
                case 0:
                    pic_Fruit.BackgroundImage = global::Game_mini.Properties.Resources.tao;
                    break;
                case 1:
                    pic_Fruit.BackgroundImage = global::Game_mini.Properties.Resources.chuoi;
                    break;
                case 2:
                    pic_Fruit.BackgroundImage = global::Game_mini.Properties.Resources.anhdao;
                    break;
                case 3:
                    pic_Fruit.BackgroundImage = global::Game_mini.Properties.Resources.dua;
                    break;
                default:
                    break;
            }
        }
        private void pic_Click_Next(object sender, EventArgs e)
        {
            if(currID < dt.Rows.Count - 1)
            {
                currID++;
            }

            ChangeImage(currID);
        }
      
        public string getVocab(Int32 ID)
        {
            return Convert.ToString(dt.Rows[ID][1]);
        }

        
        private void txt_Enter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter)
            {
                if (txt_Result.Text.Trim() == getVocab(currID))
                {
                    score += 2;
                }

                currID++;
                txt_Score.Text = Convert.ToString(score);
                txt_Result.Clear();

                ChangeImage(currID);
            }
        }
    }
}
