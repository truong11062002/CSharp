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
using ShoppingOnline.Control_Custom;

namespace ShoppingOnline
{
    public partial class main : Form
    {
        public bool isClicked_Man = false;
        public bool isClicked_Women = false;
        public string prevState = "";
        public string State = "pant";
        static DataTable dt_search;


        static DataTable dt;

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

            // Load and show item for each image
            pn_detail.Visible = false;
            pn_detail.Controls.Clear();
            Loading();
        }

        private void main_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'shoppingOnlineDataSet.PRODUCT' table. You can move, or remove it, as needed.
            this.pRODUCTTableAdapter.FillBy(this.shoppingOnlineDataSet.PRODUCT);
            showItem();
        }

        private void onClickWomen(object sender, EventArgs e)
        {
            isClicked_Women = !isClicked_Women;
            pn_women.Visible = isClicked_Women;

            // Load and show item for each image
            pn_detail.Visible = false;
            pn_detail.Controls.Clear();
            Loading();

        }

        private void Women_move(object sender, MouseEventArgs e)
        {
            lb_women.ForeColor = Color.White;
        }

        private void Women_leave(object sender, EventArgs e)
        {
            lb_women.ForeColor = Color.Black;
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
            string query = "select * from PRODUCT where PRODUCT_ID like '" + State + "%'";

            Data_Provider provider = new Data_Provider();
            dt = new DataTable();
            dt = provider.ExecuteQuery(query);
        }

        private void pant_move(object sender, MouseEventArgs e)
        {
            lb_pant.ForeColor = Color.Blue;
        }


        private void pant_leave(object sender, EventArgs e)
        {
            lb_pant.ForeColor = Color.Black;
        }
        private void jacket_leave(object sender, EventArgs e)
        {
            lb_jacket.ForeColor = Color.Black;
        }

        private void jacket_move(object sender, MouseEventArgs e)
        {
            lb_jacket.ForeColor = Color.Blue;
        }

        private void ts_move(object sender, MouseEventArgs e)
        {
            lb_ts.ForeColor = Color.Blue;
        }

        private void ts_leave(object sender, EventArgs e)
        {
            lb_ts.ForeColor = Color.Black;
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

                it.btn_detail.Click += new EventHandler(ClickDetail);
                flowLayoutPanel1.Controls.Add(it);
            }
        }

        private void ClickDetail(object sender, EventArgs e)
        {

            CButton bt = (CButton)sender;
            DetailProduct dp = new DetailProduct(bt.Name);

            pn_detail.Controls.Add(dp);
            pn_detail.Visible = true;
        }
        private void clickPant(object sender, EventArgs e)
        {
            prevState = State;
            State = "pant";

            Loading();
            showItem();
        }

        private void clickSw(object sender, EventArgs e)
        {
            prevState = State;
            State = "sw";
            Loading();
            showItem();
        }
        private void clickJacket(object sender, EventArgs e)
        {
            prevState = State;
            State = "jacket";
            Loading();
            showItem();
        }

        private void clickTs(object sender, EventArgs e)
        {
            prevState = State;
            State = "ts";
            Loading();
            showItem();
        }
        private DataTable SearchProduct(string txt_search)
        {
            string query = "select * from PRODUCT where PRODUCT_NAME like '%" + txt_search + "%'";
            Data_Provider provider = new Data_Provider();
            dt_search = new DataTable();
            dt_search = provider.ExecuteQuery(query);
            return dt_search;
        }

        private void ShowProductSearch(DataTable dt_search)
        {
            flowLayoutPanel1.Controls.Clear();
            for (int i = 0; i < dt_search.Rows.Count; i++)
            {

                string id = dt_search.Rows[i]["PRODUCT_ID"].ToString();
                id = id.Replace(" ", "");

                string name = dt_search.Rows[i]["PRODUCT_NAME"].ToString();
                int price = Convert.ToInt32(dt_search.Rows[i]["PRODUCT_PRICE"]);

                Control_Custom.Item it = new Control_Custom.Item(id, name, price.ToString());

                it.btn_detail.Click += new EventHandler(ClickDetail);
                flowLayoutPanel1.Controls.Add(it);
            }
        }

        private void onClickSearch(object sender, EventArgs e)
        {
            dt_search = SearchProduct(txt_search.Text);
            if (dt_search.Rows.Count == 0)
            {
                MessageBox.Show("Không có sản phẩm bạn cần tìm!");
            }
            else
            {
                ShowProductSearch(dt_search);
            }
        }


        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.pRODUCTTableAdapter.FillBy(this.shoppingOnlineDataSet.PRODUCT);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void valueChangeCountry(object sender, EventArgs e)
        {
            if(cb_filter.Text.ToString() == "Vietnam")
            {
                MessageBox.Show("Vietnam");
            }

            if (cb_filter.Text.ToString() == "Thailand")
            {
                MessageBox.Show("Thailand");
            }
        }
    }
}
