
namespace ShoppingOnline.Control_Custom
{
    partial class DetailProduct
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DetailProduct));
            this.lb_ten = new System.Windows.Forms.Label();
            this.lb_gia = new System.Windows.Forms.Label();
            this.lb_chatlieu = new System.Windows.Forms.Label();
            this.cb_size = new System.Windows.Forms.ComboBox();
            this.lb_soluong = new System.Windows.Forms.Label();
            this.lb_quocgia = new System.Windows.Forms.Label();
            this.pic_detail = new System.Windows.Forms.PictureBox();
            this.pic_close = new System.Windows.Forms.PictureBox();
            this.quantity_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.first_pictureBox = new System.Windows.Forms.PictureBox();
            this.second_pictureBox = new System.Windows.Forms.PictureBox();
            this.cButton1 = new ShoppingOnline.Control_Custom.CButton();
            ((System.ComponentModel.ISupportInitialize)(this.pic_detail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantity_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.first_pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.second_pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_ten
            // 
            this.lb_ten.AutoSize = true;
            this.lb_ten.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ten.Location = new System.Drawing.Point(465, 58);
            this.lb_ten.Name = "lb_ten";
            this.lb_ten.Size = new System.Drawing.Size(71, 25);
            this.lb_ten.TabIndex = 24;
            this.lb_ten.Text = "tenSP";
            // 
            // lb_gia
            // 
            this.lb_gia.AutoSize = true;
            this.lb_gia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_gia.ForeColor = System.Drawing.Color.Red;
            this.lb_gia.Location = new System.Drawing.Point(465, 14);
            this.lb_gia.Name = "lb_gia";
            this.lb_gia.Size = new System.Drawing.Size(41, 25);
            this.lb_gia.TabIndex = 18;
            this.lb_gia.Text = "gia";
            // 
            // lb_chatlieu
            // 
            this.lb_chatlieu.AutoSize = true;
            this.lb_chatlieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_chatlieu.Location = new System.Drawing.Point(709, 105);
            this.lb_chatlieu.Name = "lb_chatlieu";
            this.lb_chatlieu.Size = new System.Drawing.Size(79, 25);
            this.lb_chatlieu.TabIndex = 22;
            this.lb_chatlieu.Text = "chatlieu";
            // 
            // cb_size
            // 
            this.cb_size.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_size.FormattingEnabled = true;
            this.cb_size.Items.AddRange(new object[] {
            "S",
            "M",
            "L"});
            this.cb_size.Location = new System.Drawing.Point(470, 242);
            this.cb_size.Name = "cb_size";
            this.cb_size.Size = new System.Drawing.Size(100, 33);
            this.cb_size.TabIndex = 20;
            this.cb_size.Text = "S";
            // 
            // lb_soluong
            // 
            this.lb_soluong.AutoSize = true;
            this.lb_soluong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_soluong.Location = new System.Drawing.Point(709, 148);
            this.lb_soluong.Name = "lb_soluong";
            this.lb_soluong.Size = new System.Drawing.Size(81, 25);
            this.lb_soluong.TabIndex = 19;
            this.lb_soluong.Text = "soluong";
            // 
            // lb_quocgia
            // 
            this.lb_quocgia.AutoSize = true;
            this.lb_quocgia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_quocgia.Location = new System.Drawing.Point(709, 195);
            this.lb_quocgia.Name = "lb_quocgia";
            this.lb_quocgia.Size = new System.Drawing.Size(81, 25);
            this.lb_quocgia.TabIndex = 21;
            this.lb_quocgia.Text = "quocgia";
            // 
            // pic_detail
            // 
            this.pic_detail.Location = new System.Drawing.Point(25, 15);
            this.pic_detail.Name = "pic_detail";
            this.pic_detail.Size = new System.Drawing.Size(406, 447);
            this.pic_detail.TabIndex = 17;
            this.pic_detail.TabStop = false;
            // 
            // pic_close
            // 
            this.pic_close.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pic_close.BackgroundImage")));
            this.pic_close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pic_close.Location = new System.Drawing.Point(1013, 3);
            this.pic_close.Name = "pic_close";
            this.pic_close.Size = new System.Drawing.Size(38, 36);
            this.pic_close.TabIndex = 25;
            this.pic_close.TabStop = false;
            this.pic_close.Click += new System.EventHandler(this.pic_close_Click);
            // 
            // quantity_numericUpDown
            // 
            this.quantity_numericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantity_numericUpDown.Location = new System.Drawing.Point(470, 305);
            this.quantity_numericUpDown.Name = "quantity_numericUpDown";
            this.quantity_numericUpDown.Size = new System.Drawing.Size(108, 27);
            this.quantity_numericUpDown.TabIndex = 27;
            this.quantity_numericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.quantity_numericUpDown.ValueChanged += new System.EventHandler(this.upDown_ValueChange);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(465, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 25);
            this.label1.TabIndex = 30;
            this.label1.Text = "Chất liệu sản phẩm: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(465, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 25);
            this.label2.TabIndex = 28;
            this.label2.Text = "Số lượng còn lại: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(465, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(181, 25);
            this.label3.TabIndex = 29;
            this.label3.Text = "Quốc gia sản xuất: ";
            // 
            // first_pictureBox
            // 
            this.first_pictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("first_pictureBox.BackgroundImage")));
            this.first_pictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.first_pictureBox.Location = new System.Drawing.Point(662, 387);
            this.first_pictureBox.Name = "first_pictureBox";
            this.first_pictureBox.Size = new System.Drawing.Size(78, 63);
            this.first_pictureBox.TabIndex = 31;
            this.first_pictureBox.TabStop = false;
            this.first_pictureBox.Click += new System.EventHandler(this.first_pictureBox_Click);
            // 
            // second_pictureBox
            // 
            this.second_pictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("second_pictureBox.BackgroundImage")));
            this.second_pictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.second_pictureBox.Location = new System.Drawing.Point(662, 387);
            this.second_pictureBox.Name = "second_pictureBox";
            this.second_pictureBox.Size = new System.Drawing.Size(78, 63);
            this.second_pictureBox.TabIndex = 32;
            this.second_pictureBox.TabStop = false;
            this.second_pictureBox.Visible = false;
            this.second_pictureBox.Click += new System.EventHandler(this.second_pictureBox_Click);
            // 
            // cButton1
            // 
            this.cButton1.BackColor = System.Drawing.Color.Red;
            this.cButton1.BackgroundColor = System.Drawing.Color.Red;
            this.cButton1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.cButton1.BorderRadius = 20;
            this.cButton1.BorderSize = 0;
            this.cButton1.FlatAppearance.BorderSize = 0;
            this.cButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cButton1.ForeColor = System.Drawing.Color.White;
            this.cButton1.Location = new System.Drawing.Point(470, 387);
            this.cButton1.Name = "cButton1";
            this.cButton1.Size = new System.Drawing.Size(150, 63);
            this.cButton1.TabIndex = 26;
            this.cButton1.Text = "Add to cart";
            this.cButton1.TextColor = System.Drawing.Color.White;
            this.cButton1.UseVisualStyleBackColor = false;
            this.cButton1.Click += new System.EventHandler(this.cButton1_Click);
            // 
            // DetailProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.Controls.Add(this.second_pictureBox);
            this.Controls.Add(this.first_pictureBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.quantity_numericUpDown);
            this.Controls.Add(this.cButton1);
            this.Controls.Add(this.pic_close);
            this.Controls.Add(this.lb_ten);
            this.Controls.Add(this.lb_gia);
            this.Controls.Add(this.pic_detail);
            this.Controls.Add(this.lb_chatlieu);
            this.Controls.Add(this.cb_size);
            this.Controls.Add(this.lb_soluong);
            this.Controls.Add(this.lb_quocgia);
            this.Name = "DetailProduct";
            this.Size = new System.Drawing.Size(1054, 517);
            this.Load += new System.EventHandler(this.DetailProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_detail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantity_numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.first_pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.second_pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lb_ten;
        private System.Windows.Forms.Label lb_gia;
        private System.Windows.Forms.PictureBox pic_detail;
        private System.Windows.Forms.Label lb_chatlieu;
        private System.Windows.Forms.ComboBox cb_size;
        private System.Windows.Forms.Label lb_soluong;
        private System.Windows.Forms.Label lb_quocgia;
        public System.Windows.Forms.PictureBox pic_close;
        private CButton cButton1;
        private System.Windows.Forms.NumericUpDown quantity_numericUpDown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox first_pictureBox;
        private System.Windows.Forms.PictureBox second_pictureBox;
    }
}
