
namespace ShoppingOnline
{
    partial class paymentScreen
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.price_num_label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cButton1 = new ShoppingOnline.Control_Custom.CButton();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.price_num_label);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cButton1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1279, 100);
            this.panel1.TabIndex = 2;
            // 
            // price_num_label
            // 
            this.price_num_label.AutoSize = true;
            this.price_num_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.price_num_label.Location = new System.Drawing.Point(187, 45);
            this.price_num_label.Name = "price_num_label";
            this.price_num_label.Size = new System.Drawing.Size(126, 29);
            this.price_num_label.TabIndex = 3;
            this.price_num_label.Text = "price_num";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Thành tiền:";
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
            this.cButton1.Location = new System.Drawing.Point(1059, 24);
            this.cButton1.Name = "cButton1";
            this.cButton1.Size = new System.Drawing.Size(134, 54);
            this.cButton1.TabIndex = 1;
            this.cButton1.Text = "Thanh toán";
            this.cButton1.TextColor = System.Drawing.Color.White;
            this.cButton1.UseVisualStyleBackColor = false;
            this.cButton1.Click += new System.EventHandler(this.cButton1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(520, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(278, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thanh toán";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 100);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1279, 453);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // paymentScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1279, 553);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "paymentScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "paymentScreen";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label price_num_label;
        private System.Windows.Forms.Label label2;
        private Control_Custom.CButton cButton1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}