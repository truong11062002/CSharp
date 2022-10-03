
namespace Game_mini
{
    partial class Fruit
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fruit));
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pic_Close = new System.Windows.Forms.PictureBox();
            this.WMPMusic = new AxWMPLib.AxWindowsMediaPlayer();
            this.pic_Mute = new System.Windows.Forms.PictureBox();
            this.pic_Volume = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WMPMusic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Mute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Volume)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox5.BackgroundImage")));
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox5.Location = new System.Drawing.Point(89, 3);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(71, 65);
            this.pictureBox5.TabIndex = 4;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pic_Click_Back);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Location = new System.Drawing.Point(2, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(71, 65);
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pic_Click_Home);
            // 
            // pic_Close
            // 
            this.pic_Close.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pic_Close.BackgroundImage")));
            this.pic_Close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pic_Close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_Close.Location = new System.Drawing.Point(899, 3);
            this.pic_Close.Name = "pic_Close";
            this.pic_Close.Size = new System.Drawing.Size(73, 65);
            this.pic_Close.TabIndex = 5;
            this.pic_Close.TabStop = false;
            this.pic_Close.Click += new System.EventHandler(this.pic_Close_Fruit);
            // 
            // WMPMusic
            // 
            this.WMPMusic.Enabled = true;
            this.WMPMusic.Location = new System.Drawing.Point(870, 520);
            this.WMPMusic.Name = "WMPMusic";
            this.WMPMusic.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("WMPMusic.OcxState")));
            this.WMPMusic.Size = new System.Drawing.Size(37, 28);
            this.WMPMusic.TabIndex = 7;
            this.WMPMusic.Visible = false;
            // 
            // pic_Mute
            // 
            this.pic_Mute.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pic_Mute.BackgroundImage")));
            this.pic_Mute.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pic_Mute.Location = new System.Drawing.Point(2, 520);
            this.pic_Mute.Name = "pic_Mute";
            this.pic_Mute.Size = new System.Drawing.Size(77, 67);
            this.pic_Mute.TabIndex = 8;
            this.pic_Mute.TabStop = false;
            this.pic_Mute.Click += new System.EventHandler(this.pic_NoVolume_Click);
            // 
            // pic_Volume
            // 
            this.pic_Volume.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pic_Volume.BackgroundImage")));
            this.pic_Volume.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pic_Volume.Location = new System.Drawing.Point(2, 520);
            this.pic_Volume.Name = "pic_Volume";
            this.pic_Volume.Size = new System.Drawing.Size(77, 67);
            this.pic_Volume.TabIndex = 9;
            this.pic_Volume.TabStop = false;
            this.pic_Volume.Click += new System.EventHandler(this.pic_Volume_Click);
            // 
            // Fruit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 599);
            this.Controls.Add(this.pic_Volume);
            this.Controls.Add(this.pic_Mute);
            this.Controls.Add(this.WMPMusic);
            this.Controls.Add(this.pic_Close);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Fruit";
            this.Text = "Fruit";
            this.Load += new System.EventHandler(this.Fruit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WMPMusic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Mute)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Volume)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pic_Close;
        private AxWMPLib.AxWindowsMediaPlayer WMPMusic;
        private System.Windows.Forms.PictureBox pic_Mute;
        private System.Windows.Forms.PictureBox pic_Volume;
    }
}