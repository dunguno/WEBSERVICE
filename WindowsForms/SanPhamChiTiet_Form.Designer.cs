namespace WindowsForms
{
    partial class SanPhamChiTiet_Form
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
            this.btDelImage = new System.Windows.Forms.Button();
            this.btPre = new System.Windows.Forms.Button();
            this.btSaveImage = new System.Windows.Forms.Button();
            this.btNext = new System.Windows.Forms.Button();
            this.btAddImage = new System.Windows.Forms.Button();
            this.pictureBoxSP = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btSave = new System.Windows.Forms.Button();
            this.btRefresh = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.panel4 = new System.Windows.Forms.Panel();
            this.cbDanhmuc = new System.Windows.Forms.ComboBox();
            this.txtGia = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMota = new System.Windows.Forms.RichTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTenSP = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtMaSP = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSP)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btDelImage);
            this.panel1.Controls.Add(this.btPre);
            this.panel1.Controls.Add(this.btSaveImage);
            this.panel1.Controls.Add(this.btNext);
            this.panel1.Controls.Add(this.btAddImage);
            this.panel1.Controls.Add(this.pictureBoxSP);
            this.panel1.Location = new System.Drawing.Point(12, 72);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(298, 296);
            this.panel1.TabIndex = 0;
            // 
            // btDelImage
            // 
            this.btDelImage.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btDelImage.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btDelImage.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btDelImage.Location = new System.Drawing.Point(213, 248);
            this.btDelImage.Name = "btDelImage";
            this.btDelImage.Size = new System.Drawing.Size(75, 32);
            this.btDelImage.TabIndex = 8;
            this.btDelImage.Text = "Xóa Ảnh";
            this.btDelImage.UseVisualStyleBackColor = false;
            this.btDelImage.Click += new System.EventHandler(this.btDelImage_Click);
            // 
            // btPre
            // 
            this.btPre.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btPre.Location = new System.Drawing.Point(8, 111);
            this.btPre.Name = "btPre";
            this.btPre.Size = new System.Drawing.Size(30, 29);
            this.btPre.TabIndex = 2;
            this.btPre.Text = "<";
            this.btPre.UseVisualStyleBackColor = true;
            this.btPre.Click += new System.EventHandler(this.btPre_Click);
            // 
            // btSaveImage
            // 
            this.btSaveImage.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btSaveImage.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btSaveImage.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btSaveImage.Location = new System.Drawing.Point(113, 248);
            this.btSaveImage.Name = "btSaveImage";
            this.btSaveImage.Size = new System.Drawing.Size(75, 32);
            this.btSaveImage.TabIndex = 7;
            this.btSaveImage.Text = "Lưu ảnh";
            this.btSaveImage.UseVisualStyleBackColor = false;
            this.btSaveImage.Click += new System.EventHandler(this.btSaveImage_Click);
            // 
            // btNext
            // 
            this.btNext.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btNext.Location = new System.Drawing.Point(258, 111);
            this.btNext.Name = "btNext";
            this.btNext.Size = new System.Drawing.Size(30, 29);
            this.btNext.TabIndex = 1;
            this.btNext.Text = ">";
            this.btNext.UseVisualStyleBackColor = true;
            this.btNext.Click += new System.EventHandler(this.btNext_Click);
            // 
            // btAddImage
            // 
            this.btAddImage.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btAddImage.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btAddImage.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btAddImage.Location = new System.Drawing.Point(8, 248);
            this.btAddImage.Name = "btAddImage";
            this.btAddImage.Size = new System.Drawing.Size(75, 31);
            this.btAddImage.TabIndex = 6;
            this.btAddImage.Text = "Thêm ảnh";
            this.btAddImage.UseVisualStyleBackColor = false;
            this.btAddImage.Click += new System.EventHandler(this.btAddImage_Click);
            // 
            // pictureBoxSP
            // 
            this.pictureBoxSP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBoxSP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxSP.ErrorImage = null;
            this.pictureBoxSP.Image = global::WindowsForms.Properties.Resources.no_image;
            this.pictureBoxSP.InitialImage = global::WindowsForms.Properties.Resources.no_image;
            this.pictureBoxSP.Location = new System.Drawing.Point(46, 19);
            this.pictureBoxSP.Name = "pictureBoxSP";
            this.pictureBoxSP.Size = new System.Drawing.Size(205, 215);
            this.pictureBoxSP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxSP.TabIndex = 0;
            this.pictureBoxSP.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.Location = new System.Drawing.Point(199, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(337, 32);
            this.label6.TabIndex = 3;
            this.label6.Text = "THÔNG TIN SẢN PHẨM";
            // 
            // btSave
            // 
            this.btSave.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btSave.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btSave.Location = new System.Drawing.Point(631, 388);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(80, 33);
            this.btSave.TabIndex = 4;
            this.btSave.Text = "Lưu";
            this.btSave.UseVisualStyleBackColor = false;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // btRefresh
            // 
            this.btRefresh.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btRefresh.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btRefresh.Location = new System.Drawing.Point(527, 388);
            this.btRefresh.Name = "btRefresh";
            this.btRefresh.Size = new System.Drawing.Size(80, 33);
            this.btRefresh.TabIndex = 5;
            this.btRefresh.Text = "Làm lại";
            this.btRefresh.UseVisualStyleBackColor = false;
            this.btRefresh.Click += new System.EventHandler(this.btRefresh_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.cbDanhmuc);
            this.panel4.Controls.Add(this.txtGia);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.txtMota);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Controls.Add(this.txtTenSP);
            this.panel4.Controls.Add(this.label10);
            this.panel4.Controls.Add(this.txtMaSP);
            this.panel4.Controls.Add(this.label11);
            this.panel4.Location = new System.Drawing.Point(316, 72);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(397, 296);
            this.panel4.TabIndex = 2;
            // 
            // cbDanhmuc
            // 
            this.cbDanhmuc.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbDanhmuc.FormattingEnabled = true;
            this.cbDanhmuc.Location = new System.Drawing.Point(129, 198);
            this.cbDanhmuc.Name = "cbDanhmuc";
            this.cbDanhmuc.Size = new System.Drawing.Size(244, 27);
            this.cbDanhmuc.TabIndex = 11;
            this.cbDanhmuc.Text = "-- Chọn --";
            this.cbDanhmuc.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cbDanhmuc_MouseClick);
            // 
            // txtGia
            // 
            this.txtGia.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtGia.Location = new System.Drawing.Point(129, 248);
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(244, 26);
            this.txtGia.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.Location = new System.Drawing.Point(29, 255);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 19);
            this.label7.TabIndex = 9;
            this.label7.Text = "Giá:";
            // 
            // txtMota
            // 
            this.txtMota.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtMota.Location = new System.Drawing.Point(129, 118);
            this.txtMota.Name = "txtMota";
            this.txtMota.Size = new System.Drawing.Size(244, 64);
            this.txtMota.TabIndex = 8;
            this.txtMota.Text = "";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label8.Location = new System.Drawing.Point(29, 206);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 19);
            this.label8.TabIndex = 6;
            this.label8.Text = "Danh mục:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label9.Location = new System.Drawing.Point(29, 121);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 19);
            this.label9.TabIndex = 4;
            this.label9.Text = "Mô tả:";
            // 
            // txtTenSP
            // 
            this.txtTenSP.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTenSP.Location = new System.Drawing.Point(129, 67);
            this.txtTenSP.Name = "txtTenSP";
            this.txtTenSP.Size = new System.Drawing.Size(244, 26);
            this.txtTenSP.TabIndex = 3;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label10.Location = new System.Drawing.Point(29, 74);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(96, 19);
            this.label10.TabIndex = 2;
            this.label10.Text = "Tên sản phẩm:";
            // 
            // txtMaSP
            // 
            this.txtMaSP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtMaSP.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtMaSP.Location = new System.Drawing.Point(129, 19);
            this.txtMaSP.Name = "txtMaSP";
            this.txtMaSP.ReadOnly = true;
            this.txtMaSP.Size = new System.Drawing.Size(63, 26);
            this.txtMaSP.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label11.Location = new System.Drawing.Point(29, 26);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(94, 19);
            this.label11.TabIndex = 0;
            this.label11.Text = "Mã sản phẩm:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(335, 388);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SanPhamChiTiet_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 433);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btRefresh);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Name = "SanPhamChiTiet_Form";
            this.Text = "Thông tin sản phẩm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SanPhamChiTiet_Form_FormClosed);
            this.Load += new System.EventHandler(this.SanPhamChiTiet_Form_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSP)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBoxSP;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.Button btRefresh;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ComboBox cbDanhmuc;
        private System.Windows.Forms.TextBox txtGia;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox txtMota;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTenSP;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtMaSP;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btNext;
        private System.Windows.Forms.Button btPre;
        private System.Windows.Forms.Button btDelImage;
        private System.Windows.Forms.Button btSaveImage;
        private System.Windows.Forms.Button btAddImage;
        private System.Windows.Forms.Button button1;
    }
}