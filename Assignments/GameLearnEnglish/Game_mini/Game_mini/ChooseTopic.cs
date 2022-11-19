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
    public partial class ChooseTopic : Form
    {
        public string username;
        public ChooseTopic(string username)
        {
            InitializeComponent();
            this.username = username;
        }

        private void btn_Click_Close_Topic(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pic_Click_Back(object sender, EventArgs e)
        {
            this.Close();
            System.Windows.Forms.Form f_main = System.Windows.Forms.Application.OpenForms["main"];
            f_main.Show();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_Click_Fruit(object sender, EventArgs e)
        {
            sharedForm f_Fruit = new sharedForm("fruit", username);
            f_Fruit.Show(this);
        }

        private void btn_Click_Vehicle(object sender, EventArgs e)
        {
            sharedForm f_Vehicle = new sharedForm("vehicle", username);
            f_Vehicle.Show(this);
        }

        private void btn_Click_Animal(object sender, EventArgs e)
        {
            sharedForm f_Animal = new sharedForm("animal", username);
            f_Animal.Show(this);
        }

        private void btn_Click_Occupation(object sender, EventArgs e)
        {
            sharedForm f_Occupation = new sharedForm("occupation", username);
            f_Occupation.Show(this);
        }

        private void shipBtn_Fruit_MouseHover(object sender, EventArgs e)
        {
            btn_Fruit.BackColor = Color.LightSkyBlue;
        }

        private void shipBtn_Fruit_MouseLeave(object sender, EventArgs e)
        {
            btn_Fruit.BackColor = Color.Transparent;
        }

        private void shipBtn_Vehicle_MouseHover(object sender, EventArgs e)
        {
            btn_Vehicle.BackColor = Color.LightSkyBlue;
        }

        private void shipBtn_Vehicle_MouseLeave(object sender, EventArgs e)
        {
            btn_Vehicle.BackColor = Color.Transparent;
        }

        private void txt_Click_Fruit(object sender, EventArgs e)
        {
            sharedForm f_Fruit = new sharedForm("fruit", username);
            f_Fruit.Show(this);
        }

        private void txt_Click_Vehicle(object sender, EventArgs e)
        {
            sharedForm f_Vehicle = new sharedForm("vehicle", username);
            f_Vehicle.Show(this);
        }

        private void txt_Click_Animal(object sender, EventArgs e)
        {
            sharedForm f_Animal = new sharedForm("animal", username);
            f_Animal.Show(this);
        }

        private void txt_Click_Occupation(object sender, EventArgs e)
        {
            sharedForm f_Occupation = new sharedForm("occupation", username);
            f_Occupation.Show(this);
        }

        private void ChooseTopic_Load(object sender, EventArgs e)
        {
            
        }
    }
}
