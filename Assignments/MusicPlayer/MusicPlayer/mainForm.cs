using MusicPlayer.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicPlayer
{
    public partial class mainForm : Form
    {
        DataTable dt;
        private Form activeForm = null;
        public mainForm()
        {
            InitializeComponent();
            Variables.ListFormPanel.ListFormsPanel.Add(main_panel);
            Loading();
            ShowAllMusic("select * from MUSIC");
        }

        private void iconButton1_MouseMove(object sender, MouseEventArgs e)
        {
            iconButton1.BackColor = Color.CadetBlue;
        }

        private void iconButton1_MouseLeave(object sender, EventArgs e)
        {
            iconButton1.BackColor = Color.AliceBlue;
        }

        private void iconButton2_MouseMove(object sender, MouseEventArgs e)
        {
            iconButton2.BackColor = Color.CadetBlue;
        }

        private void iconButton2_MouseLeave(object sender, EventArgs e)
        {
            iconButton2.BackColor = Color.AliceBlue;
        }

        private void iconButton3_MouseMove(object sender, MouseEventArgs e)
        {
            iconButton3.BackColor = Color.CadetBlue;
        }

        private void iconButton3_MouseLeave(object sender, EventArgs e)
        {
            iconButton3.BackColor = Color.AliceBlue;
        }

        private void iconButton4_MouseMove(object sender, MouseEventArgs e)
        {
            iconButton4.BackColor = Color.CadetBlue;
        }

        private void iconButton4_MouseLeave(object sender, EventArgs e)
        {
            iconButton4.BackColor = Color.AliceBlue;
        }

        private void iconButton5_MouseMove(object sender, MouseEventArgs e)
        {
            iconButton5.BackColor = Color.CadetBlue;
        }

        private void iconButton5_MouseLeave(object sender, EventArgs e)
        {
            iconButton5.BackColor = Color.AliceBlue;
        }

        private void iconButton6_MouseMove(object sender, MouseEventArgs e)
        {
            iconButton6.BackColor = Color.CadetBlue;
        }

        private void iconButton6_MouseLeave(object sender, EventArgs e)
        {
            iconButton6.BackColor = Color.AliceBlue;
        }

        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            label1.ForeColor = Color.White;
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            label1.ForeColor = Color.Black;
        }

        private void label2_MouseMove(object sender, MouseEventArgs e)
        {
            label2.ForeColor = Color.White;
        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {
            label2.ForeColor = Color.Black;
        }

        private void label3_MouseMove(object sender, MouseEventArgs e)
        {
            label3.ForeColor = Color.White;
        }

        private void label3_MouseLeave(object sender, EventArgs e)
        {
            label3.ForeColor = Color.Black;
        }

        private void label4_MouseMove(object sender, MouseEventArgs e)
        {
            label4.ForeColor = Color.White;
        }

        private void label4_MouseLeave(object sender, EventArgs e)
        {
            label4.ForeColor = Color.Black;
        }

        private void label5_MouseMove(object sender, MouseEventArgs e)
        {
            label5.ForeColor = Color.White;
        }

        private void label5_MouseLeave(object sender, EventArgs e)
        {
            label5.ForeColor = Color.Black;
        }

        private void Loading()
        {
            string query = "select * from MUSIC";

            DataProvider provider = new DataProvider();
            dt = new DataTable();
            dt = provider.ExecuteQuery(query);
        }


        private void ShowAllMusic(string query)
        {
            foreach (Control item in main_panel.Controls.OfType<FlowLayoutPanel>().ToList())
                Variables.ListFormPanel.ListFormsPanel[0].Controls.Remove(item);
            foreach (Control item in main_panel.Controls.OfType<Form>().ToList())
                Variables.ListFormPanel.ListFormsPanel[0].Controls.Remove(item);
            FlowLayoutPanel flpShowProduct = new FlowLayoutPanel();
            Variables.ListFormPanel.ListFormsPanel[0].Controls.Add(flpShowProduct);
            flpShowProduct.Dock = DockStyle.Fill;
            flpShowProduct.AutoScroll = true;

            DataProvider provider = new DataProvider();
            DataTable dtShowProduct = provider.ExecuteQuery(query);

            foreach (DataRow row in dtShowProduct.Rows)
            {

                CustomControl.item items = new CustomControl.item(
                    row["music_id"].ToString(),
                    row["music_name"].ToString(),
                    row["singer_name"].ToString()
                );
                flpShowProduct.Controls.Add(items);
            }
        }

        private void FilterMusic()
        {
            string query = "select * from MUSIC ";
            if (TextBox_MusicSearch.Text == "Tên bài hát, tên ca sĩ, ...")
                query += "where (dbo.LanguageComprehension(music_name) like N'%" + "" + "%' " +
                         "or music_name like N'%" + "" + "%') " +
                         "or (dbo.LanguageComprehension(singer_name) like N'%" + "" + "%' " +
                         "or singer_name like N'%" + "" + "%')";
            else
            {
                query += "where (dbo.LanguageComprehension(music_name) like N'%" + TextBox_MusicSearch.Text + "%' " +
                         "or music_name like N'%" + TextBox_MusicSearch.Text + "%') " +
                         "or (dbo.LanguageComprehension(singer_name) like N'%" + TextBox_MusicSearch.Text + "%' " +
                         "or singer_name like N'%" + TextBox_MusicSearch.Text + "%')";
            }
            
            ShowAllMusic(query);
        }

        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            Variables.ListFormPanel.ListFormsPanel[0].Controls.Add(childForm);
            Variables.ListFormPanel.ListFormsPanel[0].Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void iconButton6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            Loading();
            ShowAllMusic("select * from MUSIC");
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            

        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (TextBox_MusicSearch.Text == "Tên bài hát, tên ca sĩ, ..." && TextBox_MusicSearch.ForeColor == Color.Gray)
            {
                TextBox_MusicSearch.Text = "";
                TextBox_MusicSearch.ForeColor = Color.Black;
            }
        }

        private void TextBox_MusicSearch_Leave(object sender, EventArgs e)
        {
            if (TextBox_MusicSearch.Text == "")
            {
                TextBox_MusicSearch.Text = "Tên bài hát, tên ca sĩ, ...";
                TextBox_MusicSearch.ForeColor = Color.Gray;
            }
        }

        private void iconButton7_Click(object sender, EventArgs e)
        {
            FilterMusic();
        }

        private void TextBox_MusicSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (ch == (char)13)
                FilterMusic();
        }
    }
}
