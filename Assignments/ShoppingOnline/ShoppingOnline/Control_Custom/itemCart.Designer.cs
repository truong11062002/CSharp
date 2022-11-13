
namespace ShoppingOnline.Control_Custom
{
    partial class itemCart
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(itemCart));
            this.price_label = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.name_label = new System.Windows.Forms.Label();
            this.size_label = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.quantity_label = new System.Windows.Forms.Label();
            this.pic_cart = new System.Windows.Forms.PictureBox();
            this.cButton2 = new ShoppingOnline.Control_Custom.CButton();
            this.cButton1 = new ShoppingOnline.Control_Custom.CButton();
            this.btn_remove = new ShoppingOnline.Control_Custom.CButton();
            ((System.ComponentModel.ISupportInitialize)(this.pic_cart)).BeginInit();
            this.SuspendLayout();
            // 
            // price_label
            // 
            this.price_label.AutoSize = true;
            this.price_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.price_label.ForeColor = System.Drawing.Color.Red;
            this.price_label.Location = new System.Drawing.Point(659, 97);
            this.price_label.Name = "price_label";
            this.price_label.Size = new System.Drawing.Size(100, 39);
            this.price_label.TabIndex = 2;
            this.price_label.Text = "Price";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(735, 36);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(52, 38);
            this.richTextBox1.TabIndex = 5;
            this.richTextBox1.Text = "";
            // 
            // name_label
            // 
            this.name_label.AutoSize = true;
            this.name_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_label.Location = new System.Drawing.Point(363, 14);
            this.name_label.Name = "name_label";
            this.name_label.Size = new System.Drawing.Size(57, 20);
            this.name_label.TabIndex = 7;
            this.name_label.Text = "Name";
            // 
            // size_label
            // 
            this.size_label.AutoSize = true;
            this.size_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.size_label.Location = new System.Drawing.Point(363, 55);
            this.size_label.Name = "size_label";
            this.size_label.Size = new System.Drawing.Size(46, 20);
            this.size_label.TabIndex = 8;
            this.size_label.Text = "Size";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(103, 66);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(18, 17);
            this.checkBox1.TabIndex = 9;
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // quantity_label
            // 
            this.quantity_label.AutoSize = true;
            this.quantity_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantity_label.Location = new System.Drawing.Point(363, 95);
            this.quantity_label.Name = "quantity_label";
            this.quantity_label.Size = new System.Drawing.Size(79, 20);
            this.quantity_label.TabIndex = 10;
            this.quantity_label.Text = "Quantity";
            this.quantity_label.Click += new System.EventHandler(this.quantity_label_Click);
            // 
            // pic_cart
            // 
            this.pic_cart.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pic_cart.BackgroundImage")));
            this.pic_cart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pic_cart.Location = new System.Drawing.Point(182, 3);
            this.pic_cart.Name = "pic_cart";
            this.pic_cart.Size = new System.Drawing.Size(160, 140);
            this.pic_cart.TabIndex = 11;
            this.pic_cart.TabStop = false;
            // 
            // cButton2
            // 
            this.cButton2.BackColor = System.Drawing.Color.Red;
            this.cButton2.BackgroundColor = System.Drawing.Color.Red;
            this.cButton2.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.cButton2.BorderRadius = 20;
            this.cButton2.BorderSize = 0;
            this.cButton2.FlatAppearance.BorderSize = 0;
            this.cButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cButton2.ForeColor = System.Drawing.Color.White;
            this.cButton2.Location = new System.Drawing.Point(802, 31);
            this.cButton2.Name = "cButton2";
            this.cButton2.Size = new System.Drawing.Size(52, 44);
            this.cButton2.TabIndex = 6;
            this.cButton2.Text = "+";
            this.cButton2.TextColor = System.Drawing.Color.White;
            this.cButton2.UseVisualStyleBackColor = false;
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
            this.cButton1.ForeColor = System.Drawing.Color.White;
            this.cButton1.Location = new System.Drawing.Point(666, 31);
            this.cButton1.Name = "cButton1";
            this.cButton1.Size = new System.Drawing.Size(52, 44);
            this.cButton1.TabIndex = 4;
            this.cButton1.Text = "-";
            this.cButton1.TextColor = System.Drawing.Color.White;
            this.cButton1.UseVisualStyleBackColor = false;
            // 
            // btn_remove
            // 
            this.btn_remove.BackColor = System.Drawing.Color.Red;
            this.btn_remove.BackgroundColor = System.Drawing.Color.Red;
            this.btn_remove.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_remove.BorderRadius = 20;
            this.btn_remove.BorderSize = 0;
            this.btn_remove.FlatAppearance.BorderSize = 0;
            this.btn_remove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_remove.ForeColor = System.Drawing.Color.White;
            this.btn_remove.Location = new System.Drawing.Point(1175, 55);
            this.btn_remove.Name = "btn_remove";
            this.btn_remove.Size = new System.Drawing.Size(64, 51);
            this.btn_remove.TabIndex = 1;
            this.btn_remove.Text = "Xóa";
            this.btn_remove.TextColor = System.Drawing.Color.White;
            this.btn_remove.UseVisualStyleBackColor = false;
            this.btn_remove.Click += new System.EventHandler(this.btn_remove_Click);
            // 
            // itemCart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.Controls.Add(this.pic_cart);
            this.Controls.Add(this.quantity_label);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.size_label);
            this.Controls.Add(this.name_label);
            this.Controls.Add(this.cButton2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.cButton1);
            this.Controls.Add(this.price_label);
            this.Controls.Add(this.btn_remove);
            this.Name = "itemCart";
            this.Size = new System.Drawing.Size(1258, 161);
            ((System.ComponentModel.ISupportInitialize)(this.pic_cart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private CButton btn_remove;
        private System.Windows.Forms.Label price_label;
        private CButton cButton1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private CButton cButton2;
        private System.Windows.Forms.Label name_label;
        private System.Windows.Forms.Label size_label;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label quantity_label;
        private System.Windows.Forms.PictureBox pic_cart;
    }
}
