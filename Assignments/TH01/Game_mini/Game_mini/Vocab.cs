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


            // ------> Animal <--------
            dt.Rows.Add("1", "Animal", "cat", "Con mèo");
            dt.Rows.Add("2", "Animal", "chicken", "Con gà");
            dt.Rows.Add("3", "Animal", "cow", "Con bò sữa");
            dt.Rows.Add("4", "Animal", "dog", "Con chó");
            dt.Rows.Add("5", "Animal", "duck", "Con vịt");
            dt.Rows.Add("6", "Animal", "frog", "Con ếch");
            dt.Rows.Add("7", "Animal", "horse", "Con ngựa");
            dt.Rows.Add("8", "Animal", "pig", "Con heo");
            dt.Rows.Add("9", "Animal", "rabbit", "Con thỏ");
            dt.Rows.Add("10", "Animal", "sheep", "Con cừu");

            // ------> Vehicle <--------
            dt.Rows.Add("1", "Vehicle", "bicycle", "Xe đạp");
            dt.Rows.Add("2", "Vehicle", "bus", "Xe bus");
            dt.Rows.Add("3", "Vehicle", "car", "Xe hơi");
            dt.Rows.Add("4", "Vehicle", "motorcycle", "Xe moto");
            dt.Rows.Add("5", "Vehicle", "scooter", "Xe tay ga");
            dt.Rows.Add("6", "Vehicle", "subway", "Tàu điện ngầm");
            dt.Rows.Add("7", "Vehicle", "taxi", "Taxi");
            dt.Rows.Add("8", "Vehicle", "train", "Xe lửa");
            dt.Rows.Add("9", "Vehicle", "truck", "Xe tải");
            dt.Rows.Add("10", "Vehicle", "van", "Xe tải van");

            // ------> Occupation <--------
            dt.Rows.Add("1", "Occupation", "builder", "Người xây dựng");
            dt.Rows.Add("2", "Occupation", "carpenter", "Thợ mọc");
            dt.Rows.Add("3", "Occupation", "dentist", "Nha sĩ");
            dt.Rows.Add("4", "Occupation", "docter", "Bác sĩ");
            dt.Rows.Add("5", "Occupation", "farmer", "Nông dân");
            dt.Rows.Add("6", "Occupation", "policeman", "Cảnh sát");
            dt.Rows.Add("7", "Occupation", "singer", "Ca sĩ");
            dt.Rows.Add("8", "Occupation", "teacher", "Giáo viên");
            dt.Rows.Add("9", "Occupation", "pilot", "Phi công");
            dt.Rows.Add("10", "Occupation", "chef", "Đầu bếp");

            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
