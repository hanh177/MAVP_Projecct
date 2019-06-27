namespace QuanLyBanVeChuyenBay
{
    partial class frmQD3
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
            this.txtThgianDatVe = new System.Windows.Forms.TextBox();
            this.txtThGianHuyVe = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tSbtnDanhSachSB = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(66, 57);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thời gian chậm nhất khi đặt vé:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(63, 118);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(210, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Thời gian chậm nhất hủy đặt vé:";
            // 
            // txtThgianDatVe
            // 
            this.txtThgianDatVe.Location = new System.Drawing.Point(299, 51);
            this.txtThgianDatVe.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtThgianDatVe.Name = "txtThgianDatVe";
            this.txtThgianDatVe.Size = new System.Drawing.Size(132, 21);
            this.txtThgianDatVe.TabIndex = 2;
            // 
            // txtThGianHuyVe
            // 
            this.txtThGianHuyVe.Location = new System.Drawing.Point(299, 114);
            this.txtThGianHuyVe.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtThGianHuyVe.Name = "txtThGianHuyVe";
            this.txtThGianHuyVe.Size = new System.Drawing.Size(132, 21);
            this.txtThGianHuyVe.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(440, 57);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "(giờ)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(440, 120);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "(giờ)";
            // 
            // btnLuu
            // 
            this.btnLuu.Image = global::QuanLyBanVeChuyenBay.Properties.Resources.save__1_;
            this.btnLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuu.Location = new System.Drawing.Point(170, 186);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(100, 35);
            this.btnLuu.TabIndex = 6;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnThoat.Image = global::QuanLyBanVeChuyenBay.Properties.Resources.Thoat__1_2;
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThoat.Location = new System.Drawing.Point(409, 186);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(100, 35);
            this.btnThoat.TabIndex = 7;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tSbtnDanhSachSB});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(586, 25);
            this.toolStrip1.TabIndex = 8;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tSbtnDanhSachSB
            // 
            this.tSbtnDanhSachSB.Image = global::QuanLyBanVeChuyenBay.Properties.Resources.DanhSachCB1;
            this.tSbtnDanhSachSB.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSbtnDanhSachSB.Name = "tSbtnDanhSachSB";
            this.tSbtnDanhSachSB.Size = new System.Drawing.Size(114, 22);
            this.tSbtnDanhSachSB.Text = "&Danh Sách S.Bay";
            this.tSbtnDanhSachSB.Click += new System.EventHandler(this.tSbtnDanhSachSB_Clicked);
            // 
            // frmQD3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QuanLyBanVeChuyenBay.Properties.Resources.blue_turquoise_gradient_polygon_shaped_background_zoomed_in_and_zoomed_out_in_one_motion_nj5dnqsrl__F0000;
            this.ClientSize = new System.Drawing.Size(586, 262);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtThGianHuyVe);
            this.Controls.Add(this.txtThgianDatVe);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "frmQD3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thay Đổi Qui Định 3";
            this.Load += new System.EventHandler(this.frmQD3_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtThgianDatVe;
        private System.Windows.Forms.TextBox txtThGianHuyVe;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tSbtnDanhSachSB;
    }
}