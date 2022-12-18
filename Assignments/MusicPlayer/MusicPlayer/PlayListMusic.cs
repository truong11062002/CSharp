using MusicPlayer.DAO;
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

namespace MusicPlayer
{
    public partial class PlayListMusic : Form
    {
        public PlayListMusic()
        {
            InitializeComponent();
            Variables.ListFormPanel.ListFormsPanel.Add(flowLayoutPanel_music);
            Variables.ListFormPanel.ListFormsPanel.Add(flowLayoutPanel_playlist);
            Load_MyPlayList();
        }

        private void Load_MyPlayList()
        {
            string query = "SELECT * FROM PLAYLIST";

            DataProvider provider = new DataProvider();
            DataTable dtShowMyList = provider.ExecuteQuery(query);
            this.label_soluongLP.Text = dtShowMyList.Rows.Count.ToString();
            ResourceManager rm;
            if (dtShowMyList.Rows.Count > 0)
            {
                foreach (DataRow row in dtShowMyList.Rows)
                {
                    rm = image.ResourceManager;
                    Bitmap myImage = (Bitmap)rm.GetObject(row["playlist_logo"].ToString());

                    CustomControl.playlist item = new CustomControl.playlist(
                        myImage,
                        row
                    );
                    flowLayoutPanel_playlist.Controls.Add(item);
                }
            }
            else
            {
                //rm = CreateResources.Variables.rm_logo;
                //FlowLayoutPanel_OrderProduct.BackgroundImage = (Bitmap)rm.GetObject("No_product");
            }
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            this.panel_taomoi.Visible = true;
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            this.panel_taomoi.Visible = false;
            this.textBox1.Clear();
        }

        private void PlayListMusic_FormClosing(object sender, FormClosingEventArgs e)
        {
            Variables.ListFormPanel.ListFormsPanel.RemoveRange(Variables.ListFormPanel.ListFormsPanel.Count - 2, Variables.ListFormPanel.ListFormsPanel.Count - 1);
        }
    }
}
