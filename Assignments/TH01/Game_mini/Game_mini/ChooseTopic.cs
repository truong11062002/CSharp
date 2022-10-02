using System;
using System.Windows.Forms;

namespace Game_mini
{
    public partial class ChooseTopic : Form
    {
        public ChooseTopic()
        {
            InitializeComponent();
        }

        private void btn_Click_Close_Topic(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pic_Click_Back(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
