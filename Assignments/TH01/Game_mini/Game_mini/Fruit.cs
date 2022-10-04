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
        Int32 num_right = 0;

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
            dt.Rows.Add("6", "mango");
            dt.Rows.Add("7", "orange");
            dt.Rows.Add("8", "papaya");
            dt.Rows.Add("9", "pear");

        }

        private void pic_Close_Fruit(object sender, EventArgs e)
        {
            
            DialogResult result = MessageBox.Show("Do you want to exit?", "Confirmation", MessageBoxButtons.YesNoCancel);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
            else if (result == DialogResult.No)
            {
                
            }

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
                case 4:
                    pic_Fruit.BackgroundImage = global::Game_mini.Properties.Resources.nho;
                    break;
                case 5:
                    pic_Fruit.BackgroundImage = global::Game_mini.Properties.Resources.chanh;
                    break;
                case 6:
                    pic_Fruit.BackgroundImage = global::Game_mini.Properties.Resources.xoai;
                    break;
                case 7:
                    pic_Fruit.BackgroundImage = global::Game_mini.Properties.Resources.cam;
                    break;
                case 8:
                    pic_Fruit.BackgroundImage = global::Game_mini.Properties.Resources.dudu;
                    break;
                case 9:
                    pic_Fruit.BackgroundImage = global::Game_mini.Properties.Resources.quale;
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
                ChangeImage(currID);
            }
            else
            {
                string temp = "Chúc mừng bạn đã hoàn thành bài test với kết quả: " + txt_right.Text + "/ 10 và số điểm đạt được là: " + txt_Score.Text;
                MessageBox.Show(temp, "Result", MessageBoxButtons.OKCancel);
            }
        }
      
        public string getVocab(Int32 ID)
        {
            return Convert.ToString(dt.Rows[ID][1]);
        }

        
        private void txt_Enter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter)
            {
                if(currID < dt.Rows.Count - 1)
                {
                    if (txt_Result.Text.Trim() == getVocab(currID))
                    {
                        score += 2;
                        num_right += 1;
                    }

                    currID++;
                    txt_Score.Text = Convert.ToString(score);
                    txt_right.Text = Convert.ToString(num_right);
                    txt_Result.Clear();

                    ChangeImage(currID);
                }
                else
                {
                    string temp = "Chúc mừng bạn đã hoàn thành bài test với kết quả: " + txt_right.Text + "/ 10 và số điểm đạt được là: " + txt_Score.Text;
                    MessageBox.Show(temp, "Result", MessageBoxButtons.OKCancel);

                }
                
                
            }
        }
    }
}
