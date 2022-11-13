using ShoppingOnline.Control_Custom;
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
    public partial class CartScreen : Form
    {
        private string numberProduct;
        public CartScreen()
        {
            InitializeComponent();
            Load_MyCart();
        }
        private void Load_MyCart()
        {
            string query =
                "select * from RECEIPT_DETAILS INNER JOIN PRODUCT on RECEIPT_DETAILS.RECEIPT_DETAILS_PRODUCT = PRODUCT.PRODUCT_ID " +
                $"where RECEIPT_DETAILS.RECEIPT_DETAILS_ID = 're01'";

            Data_Provider provider = new Data_Provider();
            DataTable dtShowMyCart = provider.ExecuteQuery(query);


            foreach (DataRow row in dtShowMyCart.Rows)
            {
                itemCart item = new itemCart(Variable.rm, row);
                flowLayoutPanel1.Controls.Add(item);
            };
        }
    }
}
