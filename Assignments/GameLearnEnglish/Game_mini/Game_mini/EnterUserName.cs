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
    public partial class EnterUserName : Form
    {
        public EnterUserName()
        {
            InitializeComponent();
        }

        private void Username_Keypress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                ChooseTopic f_Topic = new ChooseTopic(tb_username.Text);
                f_Topic.Show();
                this.Hide();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Form f_main = System.Windows.Forms.Application.OpenForms["main"];
            f_main.Show();
            this.Hide();
        }
    }
}
