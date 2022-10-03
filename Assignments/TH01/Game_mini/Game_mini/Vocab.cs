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
    public partial class Vocab : Form
    {
        public Vocab()
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
            dt.Columns.Add("Topic", typeof(string));
            dt.Columns.Add("En", typeof(string));
            dt.Columns.Add("Vn", typeof(string));

            dt.Rows.Add("1", "Fruit", "apple", "Quả táo");
            dt.Rows.Add("2", "Fruit", "banana", "Quả chuối");
            dt.Rows.Add("3", "Fruit", "cherry", "Quả anh đào");
            dt.Rows.Add("4", "Fruit", "coconut", "Quả dừa");
            dt.Rows.Add("5", "Fruit", "grape", "Quả nho");
            dt.Rows.Add("6", "Fruit", "lemon", "Quả chanh");
            dt.Rows.Add("7", "Fruit", "mango", "Quả xoài");
            dt.Rows.Add("8", "Fruit", "orange", "Quả cam");
            dt.Rows.Add("9", "Fruit", "papaya", "Quả đu đủ");
            dt.Rows.Add("10", "Fruit", "pear", "Quả lê");

            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
