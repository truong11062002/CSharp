using ShoppingOnline.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShoppingOnline.Control_Custom
{
    public partial class itemCart : UserControl
    {

        DataRow get_dtr;
        ResourceManager get_rm;
        private Form activeForm = null;
        public itemCart()
        {
            InitializeComponent();
        }

        public itemCart(ResourceManager rm, DataRow dtr): this()
        {
            get_dtr = dtr;
            get_rm = rm;

            Bitmap myImage = (Bitmap)rm.GetObject(dtr["RECEIPT_DETAILS_PRODUCT"].ToString());

            pic_cart.BackgroundImage = myImage;
            pic_cart.BackgroundImageLayout = ImageLayout.Stretch;

            name_label.Text = dtr["PRODUCT_NAME"].ToString();
            size_label.Text = dtr["RECEIPT_DETAILS_SIZE"].ToString();
            quantity_label.Text = dtr["RECEIPT_DETAILS_QUATITY"].ToString();
            price_label.Text = dtr["PRODUCT_PRICE"].ToString() + " $";
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            Data_Provider provider = new Data_Provider();
            string query = 
                "delete from RECEIPT_DETAILS " +
                $"where RECEIPT_DETAILS_ID = '{get_dtr["RECEIPT_DETAILS_ID"]}' " +
                $"and RECEIPT_DETAILS_PRODUCT = '{get_dtr["RECEIPT_DETAILS_PRODUCT"]}' " +
                $"and RECEIPT_DETAILS_SIZE = '{get_dtr["RECEIPT_DETAILS_SIZE"]}'";

            int a = provider.ExecuteNonQuery(query);
            openChildForm(new CartScreen());


        }

        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            Variable.ListControls[0].Controls.Add(childForm);
            Variable.ListControls[0].Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void quantity_label_Click(object sender, EventArgs e)
        {

        }
    }
}
