namespace QuanLyBanVeChuyenBay
{
    partial class CaiDatTK
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CaiDatTK));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTaiKhoan = new System.Windows.Forms.TextBox();
            this.txtXNMatKhauMoi = new System.Windows.Forms.TextBox();
            this.txtMatKhauMoi = new System.Windows.Forms.TextBox();
            this.txtMauKhauCu = new System.Windows.Forms.TextBox();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnXem = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(205, 77);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên tài khoản:  ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(148, 239);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Xác nhận mật khẩu mới: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(205, 186);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mật khẩu mới:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(205, 134);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Mật khẩu cũ:";
            // 
            // txtTaiKhoan
            // 
            this.txtTaiKhoan.Location = new System.Drawing.Point(341, 69);
            this.txtTaiKhoan.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtTaiKhoan.Name = "txtTaiKhoan";
            this.txtTaiKhoan.ReadOnly = true;
            this.txtTaiKhoan.Size = new System.Drawing.Size(207, 21);
            this.txtTaiKhoan.TabIndex = 4;
            // 
            // txtXNMatKhauMoi
            // 
            this.txtXNMatKhauMoi.Location = new System.Drawing.Point(341, 231);
            this.txtXNMatKhauMoi.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtXNMatKhauMoi.Name = "txtXNMatKhauMoi";
            this.txtXNMatKhauMoi.Size = new System.Drawing.Size(207, 21);
            this.txtXNMatKhauMoi.TabIndex = 5;
            this.txtXNMatKhauMoi.UseSystemPasswordChar = true;
            // 
            // txtMatKhauMoi
            // 
            this.txtMatKhauMoi.Location = new System.Drawing.Point(341, 182);
            this.txtMatKhauMoi.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtMatKhauMoi.Name = "txtMatKhauMoi";
            this.txtMatKhauMoi.Size = new System.Drawing.Size(207, 21);
            this.txtMatKhauMoi.TabIndex = 6;
            this.txtMatKhauMoi.UseSystemPasswordChar = true;
            // 
            // txtMauKhauCu
            // 
            this.txtMauKhauCu.Location = new System.Drawing.Point(341, 126);
            this.txtMauKhauCu.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtMauKhauCu.Name = "txtMauKhauCu";
            this.txtMauKhauCu.Size = new System.Drawing.Size(207, 21);
            this.txtMauKhauCu.TabIndex = 7;
            this.txtMauKhauCu.UseSystemPasswordChar = true;
            // 
            // btnLuu
            // 
            this.btnLuu.Image = global::QuanLyBanVeChuyenBay.Properties.Resources.save__1_;
            this.btnLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuu.Location = new System.Drawing.Point(280, 316);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(113, 38);
            this.btnLuu.TabIndex = 8;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnThoat.Image = global::QuanLyBanVeChuyenBay.Properties.Resources.Thoat__1_2;
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThoat.Location = new System.Drawing.Point(491, 316);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(113, 38);
            this.btnThoat.TabIndex = 9;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnXem
            // 
            this.btnXem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnXem.Image = global::QuanLyBanVeChuyenBay.Properties.Resources.Xem__1_;
            this.btnXem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXem.Location = new System.Drawing.Point(572, 182);
            this.btnXem.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(84, 23);
            this.btnXem.TabIndex = 10;
            this.btnXem.Text = "Xem";
            this.btnXem.UseVisualStyleBackColor = false;
            this.btnXem.Click += new System.EventHandler(this.btnXem_Click);
            this.btnXem.MouseEnter += new System.EventHandler(this.btnXem_MouseEnter);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(319, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(207, 24);
            this.label5.TabIndex = 11;
            this.label5.Text = "CÀI ĐẶT TÀI KHOẢN";
            // 
            // CaiDatTK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QuanLyBanVeChuyenBay.Properties.Resources.blue_turquoise_gradient_polygon_shaped_background_zoomed_in_and_zoomed_out_in_one_motion_nj5dnqsrl__F0000;
            this.ClientSize = new System.Drawing.Size(833, 413);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnXem);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.txtMauKhauCu);
            this.Controls.Add(this.txtMatKhauMoi);
            this.Controls.Add(this.txtXNMatKhauMoi);
            this.Controls.Add(this.txtTaiKhoan);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "CaiDatTK";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CaiDatTK";
            this.Load += new System.EventHandler(this.CaiDatTK_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTaiKhoan;
        private System.Windows.Forms.TextBox txtXNMatKhauMoi;
        private System.Windows.Forms.TextBox txtMatKhauMoi;
        private System.Windows.Forms.TextBox txtMauKhauCu;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnXem;
        private System.Windows.Forms.Label label5;
    }
}