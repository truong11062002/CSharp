using ShoppingOnline.Control_Custom;
using ShoppingOnline.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ShoppingOnline
{
    public partial class CartScreen : Form
    {
        public static DataTable shopping;
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

        private void cButton1_Click(object sender, EventArgs e)
        {
            SaveData(main.shopping);
            receipt f_receipt = new receipt();
            f_receipt.Show();
        }

        private void CartScreen_Load(object sender, EventArgs e)
        {
            shopping = main.shopping;
        }

        private void SaveData(DataTable dt)
        {
            string connectionString = "Data Source=DESKTOP-IUEIHA4;Initial Catalog=ShoppingOnline;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlBulkCopy bulkCopy = new SqlBulkCopy(connection))
                {
                    foreach (DataColumn c in dt.Columns)
                        bulkCopy.ColumnMappings.Add(c.ColumnName, c.ColumnName);

                    bulkCopy.DestinationTableName = "SHOPPINGPRODUCT";
                    bulkCopy.WriteToServer(dt);
                }
            }
        }
    }
}
