﻿
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
            this.cButton1 = new ShoppingOnline.Control_Custom.CButton();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.pic_detail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
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
            this.lb_chatlieu.Location = new System.Drawing.Point(465, 105);
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
            // 
            // lb_soluong
            // 
            this.lb_soluong.AutoSize = true;
            this.lb_soluong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_soluong.Location = new System.Drawing.Point(465, 148);
            this.lb_soluong.Name = "lb_soluong";
            this.lb_soluong.Size = new System.Drawing.Size(81, 25);
            this.lb_soluong.TabIndex = 19;
            this.lb_soluong.Text = "soluong";
            // 
            // lb_quocgia
            // 
            this.lb_quocgia.AutoSize = true;
            this.lb_quocgia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_quocgia.Location = new System.Drawing.Point(465, 195);
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
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown1.Location = new System.Drawing.Point(470, 305);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(108, 27);
            this.numericUpDown1.TabIndex = 27;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // DetailProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.Controls.Add(this.numericUpDown1);
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
            ((System.ComponentModel.ISupportInitialize)(this.pic_detail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
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
        private System.Windows.Forms.NumericUpDown numericUpDown1;
    }
}
