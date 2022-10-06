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
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        

        private void pic_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pic_Click_Vocab(object sender, EventArgs e)
        {
            Vocab f = new Vocab();
            f.Show(this);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            ChooseTopic f_Topic = new ChooseTopic();
            f_Topic.Show(this);
        }

        private void pic_Click_Play(object sender, EventArgs e)
        {
            ChooseTopic f_Topic = new ChooseTopic();
            f_Topic.Show(this);

            this.Hide();
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {

        }

        private void pic_Click_Rank(object sender, EventArgs e)
        {
            rank f_rank = new rank();
            f_rank.Show(this);
        }

        private void pic_Click_Close(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void main_Load(object sender, EventArgs e)
        {

        }

        private void txt_play_Mouse_Hover(object sender, EventArgs e)
        {
            txt_play.ForeColor = Color.DarkOrange;
        }

        private void txt_play_Mouse_Leave(object sender, EventArgs e)
        {
            txt_play.ForeColor = Color.DarkSlateGray;
        }

        private void txt_exit_Mouse_Hover(object sender, EventArgs e)
        {
            txt_exit.ForeColor = Color.DarkOrange;
        }

        private void txt_exit_Mouse_Leave(object sender, EventArgs e)
        {
            txt_exit.ForeColor = Color.DarkSlateGray;
        }
    }
}
