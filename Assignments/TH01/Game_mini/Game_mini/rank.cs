using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Game_mini
{
    public partial class rank : Form
    {
        public rank()
        {
            InitializeComponent();

            // Fruit
            string s1_fruit = Properties.Settings.Default.fruit_1st;
            string s2_fruit = Properties.Settings.Default.fruit_2nd;
            string s3_fruit = Properties.Settings.Default.fruit_3rd;

            if (s1_fruit.Length > 1)
            {
                string[] strscore = s1_fruit.Split('_');
                int score1 = Convert.ToInt32(strscore[strscore.Length - 1]);
                s1_fruit = strscore[0];
                for (int i = 1; i < strscore.Length - 1; i++)
                    s1_fruit = s1_fruit + "_" + strscore[i];
                lb_fruit_1st.Text = s1_fruit;
                lb_score1st_fruit.Text = strscore[strscore.Length - 1];
                if (s2_fruit.Length > 1)
                {
                    string[] strscore2 = s2_fruit.Split('_');
                    int score2 = Convert.ToInt32(strscore2[strscore2.Length - 1]);
                    s2_fruit = strscore2[0];
                    for (int i = 1; i < strscore2.Length - 1; i++)
                        s2_fruit = s2_fruit + "_" + strscore2[i];
                    lb_fruit_2nd.Text = s2_fruit;
                    lb_score2nd_fruit.Text = strscore2[strscore2.Length - 1];
                    if (s3_fruit.Length > 1)
                    {
                        string[] strscore3 = s3_fruit.Split('_');
                        int score3 = Convert.ToInt32(strscore3[strscore3.Length - 1]);
                        s3_fruit = strscore3[0];
                        for (int i = 1; i < strscore3.Length - 1; i++)
                            s3_fruit = s3_fruit + "_" + strscore3[i];
                        lb_fruit_3rd.Text = s3_fruit;
                        lb_score3rd_fruit.Text = strscore3[strscore3.Length - 1];
                    }
                    else
                    {

                        lb_score3rd_fruit.Hide();
                        lb_fruit_3rd.Hide();
                    }
                }
                else
                {
                    lb_score2nd_fruit.Hide();
                    lb_fruit_2nd.Hide();
                    lb_score3rd_fruit.Hide();
                    lb_fruit_3rd.Hide();
                }
            }
            else
            {
                lb_score1st_fruit.Hide();
                lb_fruit_1st.Hide();
                lb_score2nd_fruit.Hide();
                lb_fruit_2nd.Hide();
                lb_score3rd_fruit.Hide();
                lb_fruit_3rd.Hide();
            }


            // Animal
            string s1_animal= Properties.Settings.Default.animal_1st;
            string s2_animal = Properties.Settings.Default.animal_2nd;
            string s3_animal = Properties.Settings.Default.animal_3rd;

            if (s1_animal.Length > 1)
            {
                string[] strscore = s1_animal.Split('_');
                int score1 = Convert.ToInt32(strscore[strscore.Length - 1]);
                s1_animal = strscore[0];
                for (int i = 1; i < strscore.Length - 1; i++)
                    s1_animal = s1_animal + "_" + strscore[i];
                lb_animal_1st.Text = s1_animal;
                lb_score1st_animal.Text = strscore[strscore.Length - 1];
                if (s2_animal.Length > 1)
                {
                    string[] strscore2 = s2_animal.Split('_');
                    int score2 = Convert.ToInt32(strscore2[strscore2.Length - 1]);
                    s2_animal = strscore2[0];
                    for (int i = 1; i < strscore2.Length - 1; i++)
                        s2_animal = s2_animal + "_" + strscore2[i];
                    lb_animal_2nd.Text = s2_animal;
                    lb_score2nd_animal.Text = strscore2[strscore2.Length - 1];
                    if (s3_animal.Length > 1)
                    {
                        string[] strscore3 = s3_animal.Split('_');
                        int score3 = Convert.ToInt32(strscore3[strscore3.Length - 1]);
                        s3_animal = strscore3[0];
                        for (int i = 1; i < strscore3.Length - 1; i++)
                            s3_animal = s3_animal + "_" + strscore3[i];
                        lb_animal_3rd.Text = s3_animal;
                        lb_score3rd_animal.Text = strscore3[strscore3.Length - 1];
                    }
                    else
                    {

                        lb_score3rd_animal.Hide();
                        lb_animal_3rd.Hide();
                    }
                }
                else
                {
                    lb_score2nd_animal.Hide();
                    lb_animal_2nd.Hide();
                    lb_score3rd_animal.Hide();
                    lb_animal_3rd.Hide();
                }
            }
            else
            {
                lb_score1st_animal.Hide();
                lb_animal_1st.Hide();
                lb_score2nd_animal.Hide();
                lb_animal_2nd.Hide();
                lb_score3rd_animal.Hide();
                lb_animal_3rd.Hide();
            }

            // Vehicle
            string s1_vehicle = Properties.Settings.Default.vehicle_1st;
            string s2_vehicle = Properties.Settings.Default.vehicle_2nd;
            string s3_vehicle = Properties.Settings.Default.vehicle_3rd;

            if (s1_fruit.Length > 1)
            {
                string[] strscore = s1_vehicle.Split('_');
                int score1 = Convert.ToInt32(strscore[strscore.Length - 1]);
                s1_vehicle = strscore[0];
                for (int i = 1; i < strscore.Length - 1; i++)
                    s1_vehicle = s1_vehicle + "_" + strscore[i];
                lb_1st_vehicle.Text = s1_vehicle;
                lb_score1st_vehicle.Text = strscore[strscore.Length - 1];
                if (s2_vehicle.Length > 1)
                {
                    string[] strscore2 = s2_vehicle.Split('_');
                    int score2 = Convert.ToInt32(strscore2[strscore2.Length - 1]);
                    s2_vehicle = strscore2[0];
                    for (int i = 1; i < strscore2.Length - 1; i++)
                        s2_vehicle = s2_vehicle + "_" + strscore2[i];
                    lb_2nd_vehicle.Text = s2_vehicle;
                    lb_score2nd_vehicle.Text = strscore2[strscore2.Length - 1];
                    if (s3_vehicle.Length > 1)
                    {
                        string[] strscore3 = s3_vehicle.Split('_');
                        int score3 = Convert.ToInt32(strscore3[strscore3.Length - 1]);
                        s3_vehicle = strscore3[0];
                        for (int i = 1; i < strscore3.Length - 1; i++)
                            s3_vehicle = s3_vehicle + "_" + strscore3[i];
                        lb_3rd_vehicle.Text = s3_vehicle;
                        lb_score3rd_vehicle.Text = strscore3[strscore3.Length - 1];
                    }
                    else
                    {

                        lb_score3rd_vehicle.Hide();
                        lb_3rd_vehicle.Hide();
                    }
                }
                else
                {
                    lb_score2nd_vehicle.Hide();
                    lb_2nd_vehicle.Hide();
                    lb_score3rd_vehicle.Hide();
                    lb_3rd_vehicle.Hide();
                }
            }
            else
            {
                lb_score1st_vehicle.Hide();
                lb_1st_vehicle.Hide();
                lb_score2nd_vehicle.Hide();
                lb_2nd_vehicle.Hide();
                lb_score3rd_vehicle.Hide();
                lb_3rd_vehicle.Hide();
            }

            // Occupation
            string s1_occupation = Properties.Settings.Default.occupation_1st;
            string s2_occupation = Properties.Settings.Default.occupation_2nd;
            string s3_occupation = Properties.Settings.Default.occupation_3rd;

            if (s1_occupation.Length > 1)
            {
                string[] strscore = s1_occupation.Split('_');
                int score1 = Convert.ToInt32(strscore[strscore.Length - 1]);
                s1_occupation = strscore[0];
                for (int i = 1; i < strscore.Length - 1; i++)
                    s1_occupation = s1_occupation + "_" + strscore[i];
                lb_1st_occupation.Text = s1_occupation;
                lb_score1st_occupation.Text = strscore[strscore.Length - 1];
                if (s2_occupation.Length > 1)
                {
                    string[] strscore2 = s2_occupation.Split('_');
                    int score2 = Convert.ToInt32(strscore2[strscore2.Length - 1]);
                    s2_occupation = strscore2[0];
                    for (int i = 1; i < strscore2.Length - 1; i++)
                        s2_occupation = s2_occupation + "_" + strscore2[i];
                    lb_2nd_occupation.Text = s2_occupation;
                    lb_score2nd_occupation.Text = strscore2[strscore2.Length - 1];
                    if (s3_occupation.Length > 1)
                    {
                        string[] strscore3 = s3_occupation.Split('_');
                        int score3 = Convert.ToInt32(strscore3[strscore3.Length - 1]);
                        s3_occupation = strscore3[0];
                        for (int i = 1; i < strscore3.Length - 1; i++)
                            s3_occupation = s3_occupation + "_" + strscore3[i];
                        lb_3rd_occupation.Text = s3_occupation;
                        lb_score3rd_occupation.Text = strscore3[strscore3.Length - 1];
                    }
                    else
                    {

                        lb_score3rd_occupation.Hide();
                        lb_3rd_occupation.Hide();
                    }
                }
                else
                {
                    lb_score2nd_occupation.Hide();
                    lb_2nd_occupation.Hide();
                    lb_score3rd_occupation.Hide();
                    lb_3rd_occupation.Hide();
                }
            }
            else
            {
                lb_score1st_occupation.Hide();
                lb_1st_occupation.Hide();
                lb_score2nd_occupation.Hide();
                lb_2nd_occupation.Hide();
                lb_score3rd_occupation.Hide();
                lb_3rd_occupation.Hide();
            }
        }
        private void rank_Load(object sender, EventArgs e)
        {
            
        }

        private void data_rank_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
        
}
