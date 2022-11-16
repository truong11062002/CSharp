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
    public partial class itemHistory : UserControl
    {
        DataRow get_dtr;
        ResourceManager get_rm;
        private Form activeForm = null;
        public itemHistory()
        {
            InitializeComponent();
        }
        public itemHistory(ResourceManager rm, DataRow dtr) : this()
        {
            get_dtr = dtr;
            get_rm = rm;

            Bitmap myImage = (Bitmap)rm.GetObject(dtr["RECEIPT_DETAILS_PRODUCT"].ToString());

            history_pic.BackgroundImage = myImage;
            history_pic.BackgroundImageLayout = ImageLayout.Stretch;

            name_label.Text = dtr["PRODUCT_NAME"].ToString();
            size_label.Text = dtr["RECEIPT_DETAILS_SIZE"].ToString();
            quantity_label.Text = dtr["RECEIPT_DETAILS_QUATITY"].ToString();
            price_label.Text = dtr["PRODUCT_PRICE"].ToString() + " $";

            
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
    }
}
