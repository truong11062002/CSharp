
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Score = new System.Windows.Forms.Label();
            this.txt_right = new System.Windows.Forms.Label();
            this.pic_Fruit = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Result = new System.Windows.Forms.RichTextBox();
            this.pic_Next = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WMPMusic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Mute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Volume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Fruit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Next)).BeginInit();
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
            this.pic_Close.BackColor = System.Drawing.Color.Transparent;
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
            this.WMPMusic.Location = new System.Drawing.Point(89, 542);
            this.WMPMusic.Name = "WMPMusic";
            this.WMPMusic.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("WMPMusic.OcxState")));
            this.WMPMusic.Size = new System.Drawing.Size(39, 45);
            this.WMPMusic.TabIndex = 7;
            this.WMPMusic.Visible = false;
            // 
            // pic_Mute
            // 
            this.pic_Mute.BackColor = System.Drawing.Color.Transparent;
            this.pic_Mute.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pic_Mute.BackgroundImage")));
            this.pic_Mute.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pic_Mute.Location = new System.Drawing.Point(2, 530);
            this.pic_Mute.Name = "pic_Mute";
            this.pic_Mute.Size = new System.Drawing.Size(77, 67);
            this.pic_Mute.TabIndex = 8;
            this.pic_Mute.TabStop = false;
            this.pic_Mute.Click += new System.EventHandler(this.pic_NoVolume_Click);
            // 
            // pic_Volume
            // 
            this.pic_Volume.BackColor = System.Drawing.Color.Transparent;
            this.pic_Volume.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pic_Volume.BackgroundImage")));
            this.pic_Volume.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pic_Volume.Location = new System.Drawing.Point(2, 530);
            this.pic_Volume.Name = "pic_Volume";
            this.pic_Volume.Size = new System.Drawing.Size(77, 67);
            this.pic_Volume.TabIndex = 9;
            this.pic_Volume.TabStop = false;
            this.pic_Volume.Click += new System.EventHandler(this.pic_Volume_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(784, 271);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 23);
            this.label1.TabIndex = 13;
            this.label1.Text = "Score: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(784, 311);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 23);
            this.label2.TabIndex = 14;
            this.label2.Text = "Right: ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txt_Score
            // 
            this.txt_Score.AutoSize = true;
            this.txt_Score.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Score.Location = new System.Drawing.Point(865, 271);
            this.txt_Score.Name = "txt_Score";
            this.txt_Score.Size = new System.Drawing.Size(24, 26);
            this.txt_Score.TabIndex = 15;
            this.txt_Score.Text = "0";
            // 
            // txt_right
            // 
            this.txt_right.AutoSize = true;
            this.txt_right.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_right.Location = new System.Drawing.Point(857, 311);
            this.txt_right.Name = "txt_right";
            this.txt_right.Size = new System.Drawing.Size(24, 26);
            this.txt_right.TabIndex = 16;
            this.txt_right.Text = "0";
            // 
            // pic_Fruit
            // 
            this.pic_Fruit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pic_Fruit.Location = new System.Drawing.Point(271, 74);
            this.pic_Fruit.Name = "pic_Fruit";
            this.pic_Fruit.Size = new System.Drawing.Size(457, 290);
            this.pic_Fruit.TabIndex = 17;
            this.pic_Fruit.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(463, 398);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 30);
            this.label4.TabIndex = 18;
            this.label4.Text = "label4";
            this.label4.Visible = false;
            // 
            // txt_Result
            // 
            this.txt_Result.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Result.Location = new System.Drawing.Point(271, 459);
            this.txt_Result.Name = "txt_Result";
            this.txt_Result.Size = new System.Drawing.Size(457, 52);
            this.txt_Result.TabIndex = 19;
            this.txt_Result.Text = "";
            this.txt_Result.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Enter_KeyPress);
            // 
            // pic_Next
            // 
            this.pic_Next.BackColor = System.Drawing.Color.Transparent;
            this.pic_Next.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pic_Next.BackgroundImage")));
            this.pic_Next.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pic_Next.Location = new System.Drawing.Point(882, 512);
            this.pic_Next.Name = "pic_Next";
            this.pic_Next.Size = new System.Drawing.Size(86, 81);
            this.pic_Next.TabIndex = 20;
            this.pic_Next.TabStop = false;
            this.pic_Next.Click += new System.EventHandler(this.pic_Click_Next);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(899, 311);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 26);
            this.label3.TabIndex = 21;
            this.label3.Text = "10";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(877, 310);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 26);
            this.label5.TabIndex = 22;
            this.label5.Text = "/";
            // 
            // Fruit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(973, 599);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pic_Next);
            this.Controls.Add(this.txt_Result);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pic_Fruit);
            this.Controls.Add(this.txt_right);
            this.Controls.Add(this.txt_Score);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pic_Volume);
            this.Controls.Add(this.pic_Mute);
            this.Controls.Add(this.WMPMusic);
            this.Controls.Add(this.pic_Close);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Fruit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Fruit";
            this.Load += new System.EventHandler(this.Fruit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WMPMusic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Mute)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Volume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Fruit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Next)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pic_Close;
        private AxWMPLib.AxWindowsMediaPlayer WMPMusic;
        private System.Windows.Forms.PictureBox pic_Mute;
        private System.Windows.Forms.PictureBox pic_Volume;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label txt_Score;
        private System.Windows.Forms.Label txt_right;
        private System.Windows.Forms.PictureBox pic_Fruit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox txt_Result;
        private System.Windows.Forms.PictureBox pic_Next;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
    }
}