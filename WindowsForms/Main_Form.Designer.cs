namespace WindowsForms
{
    partial class Main_Form
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
            this.btSanpham = new System.Windows.Forms.Button();
            this.btNhanvien = new System.Windows.Forms.Button();
            this.btDonhang = new System.Windows.Forms.Button();
            this.btKhachhang = new System.Windows.Forms.Button();
            this.btDanhmuc = new System.Windows.Forms.Button();
            this.lbUser = new System.Windows.Forms.Label();
            this.btLogout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("SketchFlow Print", 33.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(128, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(475, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN LÝ CỬA HÀNG";
            // 
            // btSanpham
            // 
            this.btSanpham.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btSanpham.Image = global::WindowsForms.Properties.Resources.bakery;
            this.btSanpham.Location = new System.Drawing.Point(9, 373);
            this.btSanpham.Name = "btSanpham";
            this.btSanpham.Size = new System.Drawing.Size(137, 72);
            this.btSanpham.TabIndex = 1;
            this.btSanpham.Text = "Sản phẩm";
            this.btSanpham.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btSanpham.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btSanpham.UseVisualStyleBackColor = true;
            this.btSanpham.Click += new System.EventHandler(this.btSanpham_Click);
            // 
            // btNhanvien
            // 
            this.btNhanvien.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btNhanvien.Image = global::WindowsForms.Properties.Resources.staff;
            this.btNhanvien.Location = new System.Drawing.Point(299, 373);
            this.btNhanvien.Name = "btNhanvien";
            this.btNhanvien.Size = new System.Drawing.Size(137, 72);
            this.btNhanvien.TabIndex = 2;
            this.btNhanvien.Text = "Nhân viên";
            this.btNhanvien.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btNhanvien.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btNhanvien.UseVisualStyleBackColor = true;
            this.btNhanvien.Click += new System.EventHandler(this.btNhanvien_Click);
            // 
            // btDonhang
            // 
            this.btDonhang.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btDonhang.Image = global::WindowsForms.Properties.Resources.order;
            this.btDonhang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btDonhang.Location = new System.Drawing.Point(444, 373);
            this.btDonhang.Name = "btDonhang";
            this.btDonhang.Size = new System.Drawing.Size(138, 72);
            this.btDonhang.TabIndex = 3;
            this.btDonhang.Text = "Đơn hàng";
            this.btDonhang.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btDonhang.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btDonhang.UseVisualStyleBackColor = true;
            this.btDonhang.Click += new System.EventHandler(this.btDonhang_Click);
            // 
            // btKhachhang
            // 
            this.btKhachhang.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btKhachhang.Image = global::WindowsForms.Properties.Resources.customer;
            this.btKhachhang.Location = new System.Drawing.Point(588, 373);
            this.btKhachhang.Name = "btKhachhang";
            this.btKhachhang.Size = new System.Drawing.Size(137, 72);
            this.btKhachhang.TabIndex = 4;
            this.btKhachhang.Text = "Khách hàng";
            this.btKhachhang.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btKhachhang.UseVisualStyleBackColor = true;
            this.btKhachhang.Click += new System.EventHandler(this.btKhachhang_Click);
            // 
            // btDanhmuc
            // 
            this.btDanhmuc.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btDanhmuc.Image = global::WindowsForms.Properties.Resources.option;
            this.btDanhmuc.Location = new System.Drawing.Point(155, 373);
            this.btDanhmuc.Name = "btDanhmuc";
            this.btDanhmuc.Size = new System.Drawing.Size(137, 72);
            this.btDanhmuc.TabIndex = 5;
            this.btDanhmuc.Text = "Quản lý";
            this.btDanhmuc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btDanhmuc.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btDanhmuc.UseVisualStyleBackColor = true;
            this.btDanhmuc.Click += new System.EventHandler(this.btDanhmuc_Click);
            // 
            // lbUser
            // 
            this.lbUser.AutoSize = true;
            this.lbUser.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUser.ForeColor = System.Drawing.Color.Red;
            this.lbUser.Location = new System.Drawing.Point(581, 9);
            this.lbUser.Name = "lbUser";
            this.lbUser.Size = new System.Drawing.Size(48, 19);
            this.lbUser.TabIndex = 6;
            this.lbUser.Text = "label2";
            // 
            // btLogout
            // 
            this.btLogout.Image = global::WindowsForms.Properties.Resources.logout;
            this.btLogout.Location = new System.Drawing.Point(685, 42);
            this.btLogout.Name = "btLogout";
            this.btLogout.Size = new System.Drawing.Size(37, 29);
            this.btLogout.TabIndex = 7;
            this.btLogout.UseVisualStyleBackColor = true;
            this.btLogout.Click += new System.EventHandler(this.btLogout_Click);
            // 
            // Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = global::WindowsForms.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(729, 447);
            this.Controls.Add(this.btLogout);
            this.Controls.Add(this.lbUser);
            this.Controls.Add(this.btDanhmuc);
            this.Controls.Add(this.btKhachhang);
            this.Controls.Add(this.btDonhang);
            this.Controls.Add(this.btNhanvien);
            this.Controls.Add(this.btSanpham);
            this.Controls.Add(this.label1);
            this.Name = "Main_Form";
            this.Text = "Quản Lý Hệ Thống";
            this.Load += new System.EventHandler(this.Main_Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btSanpham;
        private System.Windows.Forms.Button btNhanvien;
        private System.Windows.Forms.Button btDonhang;
        private System.Windows.Forms.Button btKhachhang;
        private System.Windows.Forms.Button btDanhmuc;
        private System.Windows.Forms.Label lbUser;
        private System.Windows.Forms.Button btLogout;
    }
}