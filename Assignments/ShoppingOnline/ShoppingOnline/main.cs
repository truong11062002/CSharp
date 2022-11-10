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

namespace ShoppingOnline
{
    public partial class main : Form
    {
        public bool isClicked_Man = false;
        public bool isClicked_Women = false;
        public string prevState = "";
        public string State = "pant";

        public DataTable dt;

        public main()
        {
            InitializeComponent();
            Loading();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Man_Move(object sender, MouseEventArgs e)
        {
            
            lb_man.ForeColor = Color.White;
        }

        private void Man_Leave(object sender, EventArgs e)
        {
            
            lb_man.ForeColor = Color.Black;
        }

        private void pn_man_MouseMove(object sender, MouseEventArgs e)
        {
            
        }

        private void pn_man_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void onClickMan(object sender, EventArgs e)
        {
            isClicked_Man = !isClicked_Man;
            pn_man.Visible = isClicked_Man;
        }

        private void main_Load(object sender, EventArgs e)
        {
            showItem();
        }

        private void onClickWomen(object sender, EventArgs e)
        {
            isClicked_Women = !isClicked_Women;
            pn_women.Visible = isClicked_Women;
        }

        private void Women_move(object sender, MouseEventArgs e)
        {
            lb_women.ForeColor = Color.White;
        }

        private void Women_leave(object sender, EventArgs e)
        {
            lb_women.ForeColor = Color.Black;
        }

        private void onClick_Product(object sender, EventArgs e)
        {
            //ProductScreen f_product = new ProductScreen();
            //f_product.Show();
        }

        private void sw_move(object sender, MouseEventArgs e)
        {
            lb_sw.ForeColor = Color.Blue;
        }

        private void sw_leave(object sender, EventArgs e)
        {
            lb_sw.ForeColor = Color.Black;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Loading()
        {
            string query = "select * from PRODUCT where PRODUCT_ID like '"+State+"%'";
            
            Data_Provider provider = new Data_Provider();
            dt = new DataTable();
            dt = provider.ExecuteQuery(query);
        }

        private void pant_move(object sender, MouseEventArgs e)
        {
            lb_pant.ForeColor = Color.Blue;
        }

        private void pant_leave(object sender, MouseEventArgs e)
        {
            lb_pant.ForeColor = Color.Black;
        }

        private void clickPant(object sender, EventArgs e)
        {
            prevState = State;
            State = "pant";
            showItem();
        }
        private void showItem()
        {
            flowLayoutPanel1.Controls.Clear();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string id = dt.Rows[i]["PRODUCT_ID"].ToString();
                id = id.Replace(" ", "");

                string name = dt.Rows[i]["PRODUCT_NAME"].ToString();
                int price = Convert.ToInt32(dt.Rows[i]["PRODUCT_PRICE"]);

                Control_Custom.Item it = new Control_Custom.Item(id, name, price.ToString());

                flowLayoutPanel1.Controls.Add(it);
            }
        }
    }
}
