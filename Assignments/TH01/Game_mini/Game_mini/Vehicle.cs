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
    public partial class Vehicle : Form
    {
        DataTable dt_animal = new DataTable();
        public Vehicle()
        {
            InitializeComponent();
        }

        private void Vehicle_Load(object sender, EventArgs e)
        {
            dt_animal.Columns.Add("ID", typeof(int));
            dt_animal.Columns.Add("En", typeof(string));


            dt_animal.Rows.Add(0, "bicycle");
            dt_animal.Rows.Add(1, "bus");
            dt_animal.Rows.Add(2, "car");
            dt_animal.Rows.Add(3, "motorcycle");
            dt_animal.Rows.Add(4, "scooter");
            dt_animal.Rows.Add(5, "subway");
            dt_animal.Rows.Add(6, "taxi");
            dt_animal.Rows.Add(7, "train");
            dt_animal.Rows.Add(8, "truck");
            dt_animal.Rows.Add(9, "van");
        }
    }
}
