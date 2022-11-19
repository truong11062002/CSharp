
namespace Game_mini
{
    partial class ChooseTopic
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChooseTopic));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txt_Occupation = new System.Windows.Forms.Label();
            this.txt_Animal = new System.Windows.Forms.Label();
            this.text_Vehicle = new System.Windows.Forms.Label();
            this.text_Fruit = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btn_Vehicle = new System.Windows.Forms.Button();
            this.btn_Fruit = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(971, 71);
            this.panel1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Location = new System.Drawing.Point(295, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(414, 45);
            this.label1.TabIndex = 19;
            this.label1.Text = "CHỌN CHỦ ĐỀ CHO BÉ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Location = new System.Drawing.Point(895, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(73, 65);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.btn_Click_Close_Topic);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Location = new System.Drawing.Point(3, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(71, 65);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pic_Click_Back);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.txt_Occupation);
            this.panel2.Controls.Add(this.txt_Animal);
            this.panel2.Controls.Add(this.text_Vehicle);
            this.panel2.Controls.Add(this.text_Fruit);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.btn_Vehicle);
            this.panel2.Controls.Add(this.btn_Fruit);
            this.panel2.Location = new System.Drawing.Point(7, 84);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(961, 501);
            this.panel2.TabIndex = 7;
            // 
            // txt_Occupation
            // 
            this.txt_Occupation.AutoSize = true;
            this.txt_Occupation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txt_Occupation.Font = new System.Drawing.Font("Imprint MT Shadow", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Occupation.ForeColor = System.Drawing.Color.Brown;
            this.txt_Occupation.Location = new System.Drawing.Point(594, 436);
            this.txt_Occupation.Name = "txt_Occupation";
            this.txt_Occupation.Size = new System.Drawing.Size(226, 33);
            this.txt_Occupation.TabIndex = 18;
            this.txt_Occupation.Text = "OCCUPATION";
            this.txt_Occupation.Click += new System.EventHandler(this.txt_Click_Occupation);
            // 
            // txt_Animal
            // 
            this.txt_Animal.AutoSize = true;
            this.txt_Animal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txt_Animal.Font = new System.Drawing.Font("Imprint MT Shadow", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Animal.ForeColor = System.Drawing.Color.Brown;
            this.txt_Animal.Location = new System.Drawing.Point(197, 445);
            this.txt_Animal.Name = "txt_Animal";
            this.txt_Animal.Size = new System.Drawing.Size(140, 33);
            this.txt_Animal.TabIndex = 17;
            this.txt_Animal.Text = "ANIMAL";
            this.txt_Animal.Click += new System.EventHandler(this.txt_Click_Animal);
            // 
            // text_Vehicle
            // 
            this.text_Vehicle.AutoSize = true;
            this.text_Vehicle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.text_Vehicle.Font = new System.Drawing.Font("Imprint MT Shadow", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_Vehicle.ForeColor = System.Drawing.Color.Brown;
            this.text_Vehicle.Location = new System.Drawing.Point(621, 206);
            this.text_Vehicle.Name = "text_Vehicle";
            this.text_Vehicle.Size = new System.Drawing.Size(158, 33);
            this.text_Vehicle.TabIndex = 16;
            this.text_Vehicle.Text = "VEHICLE";
            this.text_Vehicle.Click += new System.EventHandler(this.txt_Click_Vehicle);
            // 
            // text_Fruit
            // 
            this.text_Fruit.AutoSize = true;
            this.text_Fruit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.text_Fruit.Font = new System.Drawing.Font("Imprint MT Shadow", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_Fruit.ForeColor = System.Drawing.Color.Brown;
            this.text_Fruit.Location = new System.Drawing.Point(197, 206);
            this.text_Fruit.Name = "text_Fruit";
            this.text_Fruit.Size = new System.Drawing.Size(115, 33);
            this.text_Fruit.TabIndex = 15;
            this.text_Fruit.Text = "FRUIT";
            this.text_Fruit.Click += new System.EventHandler(this.txt_Click_Fruit);
            // 
            // button4
            // 
            this.button4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button4.BackgroundImage")));
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button4.Location = new System.Drawing.Point(549, 267);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(299, 166);
            this.button4.TabIndex = 14;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.btn_Click_Occupation);
            // 
            // button3
            // 
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.Location = new System.Drawing.Point(113, 267);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(299, 166);
            this.button3.TabIndex = 13;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.btn_Click_Animal);
            // 
            // btn_Vehicle
            // 
            this.btn_Vehicle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Vehicle.BackgroundImage")));
            this.btn_Vehicle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Vehicle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Vehicle.Location = new System.Drawing.Point(549, 23);
            this.btn_Vehicle.Name = "btn_Vehicle";
            this.btn_Vehicle.Size = new System.Drawing.Size(299, 166);
            this.btn_Vehicle.TabIndex = 12;
            this.btn_Vehicle.UseVisualStyleBackColor = true;
            this.btn_Vehicle.Click += new System.EventHandler(this.btn_Click_Vehicle);
            // 
            // btn_Fruit
            // 
            this.btn_Fruit.BackColor = System.Drawing.Color.Transparent;
            this.btn_Fruit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Fruit.BackgroundImage")));
            this.btn_Fruit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Fruit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Fruit.Location = new System.Drawing.Point(113, 23);
            this.btn_Fruit.Name = "btn_Fruit";
            this.btn_Fruit.Size = new System.Drawing.Size(299, 166);
            this.btn_Fruit.TabIndex = 11;
            this.btn_Fruit.UseVisualStyleBackColor = false;
            this.btn_Fruit.Click += new System.EventHandler(this.btn_Click_Fruit);
            // 
            // ChooseTopic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(973, 599);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ChooseTopic";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChooseTopic";
            this.Load += new System.EventHandler(this.ChooseTopic_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label txt_Occupation;
        private System.Windows.Forms.Label txt_Animal;
        private System.Windows.Forms.Label text_Vehicle;
        private System.Windows.Forms.Label text_Fruit;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btn_Vehicle;
        private System.Windows.Forms.Button btn_Fruit;
        private System.Windows.Forms.Label label1;
    }
}