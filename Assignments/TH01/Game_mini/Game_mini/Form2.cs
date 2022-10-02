using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_mini
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btn_Click_Close(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("ID", typeof(string));
            dt.Columns.Add("En", typeof(string));
            dt.Columns.Add("Vn", typeof(string));

            dt.Rows.Add("1", "Apple", "Quả Táo");
            dt.Rows.Add("2", "Apple", "Quả Táo");
            dt.Rows.Add("3", "Apple", "Quả Táo");
            dt.Rows.Add("4", "Apple", "Quả Táo");
            dt.Rows.Add("5", "Apple", "Quả Táo");
            dt.Rows.Add("6", "Apple", "Quả Táo");
            dt.Rows.Add("7", "Apple", "Quả Táo");
            dt.Rows.Add("8", "Apple", "Quả Táo");
            dt.Rows.Add("9", "Apple", "Quả Táo");
            dt.Rows.Add("10", "Apple", "Quả Táo");

            dataGridView1.DataSource = dt;
        }
    }
}
