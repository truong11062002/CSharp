using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShoppingOnline
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Man_Move(object sender, MouseEventArgs e)
        {
            pn_man.Visible = true;
            lb_man.ForeColor = Color.White;
        }

        private void Man_Leave(object sender, EventArgs e)
        {
            pn_man.Visible = false;
            lb_man.ForeColor = Color.Black;
        }

        private void pn_man_MouseMove(object sender, MouseEventArgs e)
        {
            pn_man.Visible = true;
        }

        private void pn_man_MouseLeave(object sender, EventArgs e)
        {
            pn_man.Visible = false;
        }
    }
}
