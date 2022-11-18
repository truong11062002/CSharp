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
    public partial class DetailProduct : UserControl
    {
        static DataTable dt;
        string get_id;
        public long number;
        public DetailProduct()
        {
            InitializeComponent();
        }

        private int total()
        {
            int total = 0;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                total += Int32.Parse(dt.Rows[i]["PRODUCT_PRICE"].ToString());
            }
            return total;
        }
        public DetailProduct(string id) : this()
        {
            get_id = id;
            //----------------------------------------
            Bitmap bm1 = (Bitmap)Resources.pants.ResourceManager.GetObject(id);
            pic_detail.BackgroundImage = bm1;
            pic_detail.BackgroundImageLayout = ImageLayout.Stretch;
            //----------------------------------------
            string query = "select * from PRODUCT where PRODUCT_ID like '" + id + "%'";
            Data_Provider provider = new Data_Provider();
            dt = new DataTable();
            dt = provider.ExecuteQuery(query);
            //----------------------------------------
            lb_gia.Name = dt.Rows[0]["PRODUCT_PRICE"].ToString();
            lb_gia.Text = dt.Rows[0]["PRODUCT_PRICE"].ToString() + " $";
            lb_ten.Text = dt.Rows[0]["PRODUCT_NAME"].ToString();
            lb_chatlieu.Text = dt.Rows[0]["PRODUCT_MATERIAL"].ToString();
            lb_quocgia.Text = dt.Rows[0]["PRODUCT_FROM"].ToString();
            lb_soluong.Text = dt.Rows[0]["PRODUCT_QUANTITY"].ToString();
            //----------------------------------------
            number = Convert.ToInt64(dt.Rows[0]["PRODUCT_PRICE"]);

        }



        private void cButton1_Click(object sender, EventArgs e)
        {
            Data_Provider provider = new Data_Provider();

            string queryCondition =
                "select * from RECEIPT_DETAILS INNER JOIN PRODUCT on RECEIPT_DETAILS.RECEIPT_DETAILS_PRODUCT = PRODUCT.PRODUCT_ID " +
                $"where RECEIPT_DETAILS.RECEIPT_DETAILS_ID = 're01' " +
                $"and RECEIPT_DETAILS_ID = 're01' " +
                $"and RECEIPT_DETAILS_PRODUCT = '{get_id}' " +
                $"and RECEIPT_DETAILS_SIZE = '{quantity_numericUpDown.Text}'";

            DataTable dt_condition = provider.ExecuteQuery(queryCondition);
            if (dt_condition.Rows.Count == 0)
            {
                // -------------------
                string query =
                    $"insert into RECEIPT_DETAILS values('re01','{get_id}','{cb_size.Text}',{quantity_numericUpDown.Text}, 0)";

                int tmp = provider.ExecuteNonQuery(query);

                MessageBox.Show("Thêm giỏ hàng thành công!");
            }
            else
            {
                string query =
                    $"update RECEIPT_DETAILS " +
                    $"set RECEIPT_DETAILS_QUATITY = RECEIPT_DETAILS_QUATITY + {quantity_numericUpDown.Text} " +
                    $"where RECEIPT_DETAILS_ID = 're01' " +
                    $"and RECEIPT_DETAILS_PRODUCT = '{get_id}' " +
                    $"and RECEIPT_DETAILS_SIZE = '{cb_size.Text}'";

                int tmp = provider.ExecuteNonQuery(query);
                MessageBox.Show("Cập nhật giỏ hàng thành công!");
            }

            // ----------------------------------------------------------------------
            string id = pic_detail.Name;
            string ten = lb_ten.Text;
            string size = cb_size.SelectedItem.ToString();
            string quantity = Convert.ToInt32(quantity_numericUpDown.Value).ToString();
            int price = Convert.ToInt32(lb_gia.Name);
            main.shopping.Rows.Add(id, ten, size, quantity, price);
        }
        Decimal OldValue = 1;
        private void upDown_ValueChange(object sender, EventArgs e)
        {
            if (quantity_numericUpDown.Value > OldValue)
            {
                number = number + Convert.ToInt64(dt.Rows[0]["PRODUCT_PRICE"]);
                lb_gia.Text = number.ToString() + " $";
                //value increased, handle accordingly
            }
            else if (quantity_numericUpDown.Value < OldValue)
            {
                number -= Convert.ToInt64(dt.Rows[0]["PRODUCT_PRICE"]);
                lb_gia.Text = number.ToString() + " $";
            }
            else if(quantity_numericUpDown.Value == 0)
            {
                lb_gia.Text = "0 $";
            }
            else
            {
                return;
            }
            OldValue = quantity_numericUpDown.Value;
        }

        private void first_pictureBox_Click(object sender, EventArgs e)
        {
            second_pictureBox.Visible = true;
            first_pictureBox.Visible = false;
            
        }

        private void second_pictureBox_Click(object sender, EventArgs e)
        {
            first_pictureBox.Visible = true;
            second_pictureBox.Visible = false;
        }

        private void pic_close_Click(object sender, EventArgs e)
        {
            if (second_pictureBox.Visible == true)
                main.lovelist.Rows.Add(get_id, lb_ten.Text);
        }

        private void DetailProduct_Load(object sender, EventArgs e)
        {
            foreach (DataRow row in main.lovelist.Rows)
                if (get_id == row["ID"].ToString())
                {
                    second_pictureBox.Visible = true;
                    first_pictureBox.Visible = false;
                }
        }
    }
}
