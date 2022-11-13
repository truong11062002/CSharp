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
        public DetailProduct()
        {
            InitializeComponent();
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
            lb_gia.Text = dt.Rows[0]["PRODUCT_PRICE"].ToString() + " $";
            quantity_numericUpDown.ValueChanged += new EventHandler(ChangeQuantity);
            lb_ten.Text = dt.Rows[0]["PRODUCT_NAME"].ToString();
            lb_chatlieu.Text = dt.Rows[0]["PRODUCT_MATERIAL"].ToString();
            lb_quocgia.Text = dt.Rows[0]["PRODUCT_FROM"].ToString();
            lb_soluong.Text = dt.Rows[0]["PRODUCT_QUANTITY"].ToString();

        }

        private void ChangeQuantity(object sender, EventArgs e)
        {
            //------------------- Đang fix ---------------------
            lb_gia.Text = dt.Rows[0]["PRODUCT_PRICE"].ToString() + " $";
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

                MessageBox.Show("Thêm dữ liệu thành công!");
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
                MessageBox.Show("Cập nhật dữ liệu thành công!");
            }
        }
    }
}
