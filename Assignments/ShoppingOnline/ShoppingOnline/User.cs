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
    public partial class User : Form
    {
        public static string name, address, phone;

        
        public User()
        {
            InitializeComponent();
        }

        private void cButton1_Click(object sender, EventArgs e)
        {
            name = textBox1.Text;
            address = textBox2.Text;
            phone = textBox3.Text;

            receipt f_receipt = new receipt();
            
            f_receipt.Show();

        }
    }
}
