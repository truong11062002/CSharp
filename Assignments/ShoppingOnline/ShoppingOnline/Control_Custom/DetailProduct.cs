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
        public DetailProduct()
        {
            InitializeComponent();
        }

        public DetailProduct(string id) : this()
        {
            Bitmap bm1 = (Bitmap)Resources.pants.ResourceManager.GetObject(id);

            pic_detail.BackgroundImage = bm1;
            pic_detail.BackgroundImageLayout = ImageLayout.Stretch;

            string query = "select * from PRODUCT where PRODUCT_ID like '" + id + "%'";
            Data_Provider provider = new Data_Provider();
            dt = new DataTable();
            dt = provider.ExecuteQuery(query);

            lb_gia.Text = dt.Rows[0]["PRODUCT_PRICE"].ToString() + " $";
            lb_ten.Text = dt.Rows[0]["PRODUCT_NAME"].ToString();
            lb_chatlieu.Text = dt.Rows[0]["PRODUCT_MATERIAL"].ToString();
            lb_quocgia.Text = dt.Rows[0]["PRODUCT_FROM"].ToString();
            lb_soluong.Text = dt.Rows[0]["PRODUCT_QUANTITY"].ToString();

        }

    }
}
