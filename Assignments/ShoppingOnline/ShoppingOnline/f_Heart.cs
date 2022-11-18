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
    public partial class f_Heart : Form
    {
        public f_Heart()
        {
            InitializeComponent();
        }

        private void f_Heart_Load(object sender, EventArgs e)
        {
            Random rd = new Random();
            DataTable dt = main.lovelist;
            flowLayoutPanel1.Controls.Clear();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string id = dt.Rows[i]["ID"].ToString();
                id = id.Replace(" ", "");

                string name = dt.Rows[i]["Name"].ToString();

                Control_Custom.Item it = new Control_Custom.Item(id, name, "0");
                it.BackColor = Color.FromArgb(rd.Next(0, 255), rd.Next(0, 255), rd.Next(0, 255));
                it.label2.Visible = false;
                flowLayoutPanel1.Controls.Add(it);
            }
        }
    }
}
