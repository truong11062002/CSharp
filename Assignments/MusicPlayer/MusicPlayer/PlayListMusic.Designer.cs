
namespace MusicPlayer
{
    partial class PlayListMusic
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.flowLayoutPanel_playlist = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel_music = new System.Windows.Forms.FlowLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.label_soluongLP = new System.Windows.Forms.Label();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.panel_taomoi = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.iconButton3 = new FontAwesome.Sharp.IconButton();
            this.label6 = new System.Windows.Forms.Label();
            this.iconButton4 = new FontAwesome.Sharp.IconButton();
            this.panel_taomoi.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 38);
            this.label1.TabIndex = 2;
            this.label1.Text = "PLAYLIST";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label2.Location = new System.Drawing.Point(830, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(329, 38);
            this.label2.TabIndex = 3;
            this.label2.Text = "DANH SÁCH NHẠC";
            // 
            // flowLayoutPanel_playlist
            // 
            this.flowLayoutPanel_playlist.AutoScroll = true;
            this.flowLayoutPanel_playlist.BackColor = System.Drawing.SystemColors.ControlLight;
            this.flowLayoutPanel_playlist.Location = new System.Drawing.Point(9, 68);
            this.flowLayoutPanel_playlist.Name = "flowLayoutPanel_playlist";
            this.flowLayoutPanel_playlist.Size = new System.Drawing.Size(753, 513);
            this.flowLayoutPanel_playlist.TabIndex = 4;
            // 
            // flowLayoutPanel_music
            // 
            this.flowLayoutPanel_music.AutoScroll = true;
            this.flowLayoutPanel_music.BackColor = System.Drawing.SystemColors.ControlLight;
            this.flowLayoutPanel_music.Location = new System.Drawing.Point(768, 68);
            this.flowLayoutPanel_music.Name = "flowLayoutPanel_music";
            this.flowLayoutPanel_music.Size = new System.Drawing.Size(444, 513);
            this.flowLayoutPanel_music.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(550, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 29);
            this.label3.TabIndex = 6;
            this.label3.Text = "Số lượng:";
            // 
            // label_soluongLP
            // 
            this.label_soluongLP.AutoSize = true;
            this.label_soluongLP.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_soluongLP.Location = new System.Drawing.Point(678, 31);
            this.label_soluongLP.Name = "label_soluongLP";
            this.label_soluongLP.Size = new System.Drawing.Size(27, 29);
            this.label_soluongLP.TabIndex = 9;
            this.label_soluongLP.Text = "0";
            // 
            // iconButton2
            // 
            this.iconButton2.BackColor = System.Drawing.Color.Red;
            this.iconButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButton2.IconColor = System.Drawing.Color.Black;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.Location = new System.Drawing.Point(787, 614);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(215, 55);
            this.iconButton2.TabIndex = 8;
            this.iconButton2.Text = "Xóa playlist";
            this.iconButton2.UseVisualStyleBackColor = false;
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.Goldenrod;
            this.iconButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.Location = new System.Drawing.Point(9, 614);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(215, 55);
            this.iconButton1.TabIndex = 7;
            this.iconButton1.Text = "Tạo mới playlist";
            this.iconButton1.UseVisualStyleBackColor = false;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // panel_taomoi
            // 
            this.panel_taomoi.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel_taomoi.Controls.Add(this.iconButton4);
            this.panel_taomoi.Controls.Add(this.label6);
            this.panel_taomoi.Controls.Add(this.iconButton3);
            this.panel_taomoi.Controls.Add(this.panel2);
            this.panel_taomoi.Controls.Add(this.label5);
            this.panel_taomoi.Location = new System.Drawing.Point(260, 67);
            this.panel_taomoi.Name = "panel_taomoi";
            this.panel_taomoi.Size = new System.Drawing.Size(682, 565);
            this.panel_taomoi.TabIndex = 10;
            this.panel_taomoi.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(31, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 25);
            this.label5.TabIndex = 10;
            this.label5.Text = "Tên Playlist";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Location = new System.Drawing.Point(183, 148);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(314, 51);
            this.panel2.TabIndex = 11;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(3, 9);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(308, 38);
            this.textBox1.TabIndex = 0;
            // 
            // iconButton3
            // 
            this.iconButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton3.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButton3.IconColor = System.Drawing.Color.Black;
            this.iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton3.Location = new System.Drawing.Point(209, 501);
            this.iconButton3.Name = "iconButton3";
            this.iconButton3.Size = new System.Drawing.Size(254, 61);
            this.iconButton3.TabIndex = 12;
            this.iconButton3.Text = "Tạo mới";
            this.iconButton3.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label6.Font = new System.Drawing.Font("Cooper Black", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label6.Location = new System.Drawing.Point(149, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(392, 39);
            this.label6.TabIndex = 13;
            this.label6.Text = "TẠO PLAYLIST NHẠC";
            // 
            // iconButton4
            // 
            this.iconButton4.BackColor = System.Drawing.Color.Transparent;
            this.iconButton4.IconChar = FontAwesome.Sharp.IconChar.XmarkCircle;
            this.iconButton4.IconColor = System.Drawing.Color.Black;
            this.iconButton4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton4.Location = new System.Drawing.Point(629, 3);
            this.iconButton4.Name = "iconButton4";
            this.iconButton4.Size = new System.Drawing.Size(50, 50);
            this.iconButton4.TabIndex = 14;
            this.iconButton4.UseVisualStyleBackColor = false;
            this.iconButton4.Click += new System.EventHandler(this.iconButton4_Click);
            // 
            // PlayListMusic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1224, 681);
            this.Controls.Add(this.panel_taomoi);
            this.Controls.Add(this.iconButton2);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.flowLayoutPanel_music);
            this.Controls.Add(this.label_soluongLP);
            this.Controls.Add(this.flowLayoutPanel_playlist);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "PlayListMusic";
            this.Text = "PlayListMusic";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PlayListMusic_FormClosing);
            this.panel_taomoi.ResumeLayout(false);
            this.panel_taomoi.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_playlist;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_music;
        private System.Windows.Forms.Label label3;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton iconButton2;
        private System.Windows.Forms.Label label_soluongLP;
        private System.Windows.Forms.Panel panel_taomoi;
        private System.Windows.Forms.Label label6;
        private FontAwesome.Sharp.IconButton iconButton3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
        private FontAwesome.Sharp.IconButton iconButton4;
    }
}