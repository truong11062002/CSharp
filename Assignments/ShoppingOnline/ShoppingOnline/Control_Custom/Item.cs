using ShoppingOnline.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShoppingOnline.Control_Custom
{
    public partial class Item : UserControl
    {
        public Item()
        {
            InitializeComponent();
        }

        public Item (string id,string s1, string s2) : this()
        {
            Bitmap bm1 = (Bitmap)Resources.pants.ResourceManager.GetObject(id);

            pictureBox1.BackgroundImage = bm1;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;


            label1.Text = s1;
            label2.Text = s2 +"$";

            btn_detail.Name = id;
        }
    }
}
