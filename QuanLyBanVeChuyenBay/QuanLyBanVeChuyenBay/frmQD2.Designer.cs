namespace QuanLyBanVeChuyenBay
{
    partial class cmbMaCB
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cmbMaCB));
            this.label1 = new System.Windows.Forms.Label();
            this.txtSoGheH1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSoGheh2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.cmbMaChuyenBay = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(100, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã chuyến bay:";
            // 
            // txtSoGheH1
            // 
            this.txtSoGheH1.Location = new System.Drawing.Point(264, 81);
            this.txtSoGheH1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtSoGheH1.Name = "txtSoGheH1";
            this.txtSoGheH1.Size = new System.Drawing.Size(132, 21);
            this.txtSoGheH1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(37, 89);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nhập số lượng vé hạng 1:";
            // 
            // txtSoGheh2
            // 
            this.txtSoGheh2.Location = new System.Drawing.Point(264, 127);
            this.txtSoGheh2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtSoGheh2.Name = "txtSoGheh2";
            this.txtSoGheh2.Size = new System.Drawing.Size(132, 21);
            this.txtSoGheh2.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(37, 135);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nhập số lượng vé hạng 2:";
            // 
            // btnLuu
            // 
            this.btnLuu.Image = global::QuanLyBanVeChuyenBay.Properties.Resources.save__1_;
            this.btnLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuu.Location = new System.Drawing.Point(164, 211);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(100, 33);
            this.btnLuu.TabIndex = 6;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnThoat.Image = global::QuanLyBanVeChuyenBay.Properties.Resources.Thoat__1_1;
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThoat.Location = new System.Drawing.Point(325, 206);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(100, 38);
            this.btnThoat.TabIndex = 7;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // cmbMaChuyenBay
            // 
            this.cmbMaChuyenBay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMaChuyenBay.FormattingEnabled = true;
            this.cmbMaChuyenBay.Location = new System.Drawing.Point(264, 37);
            this.cmbMaChuyenBay.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmbMaChuyenBay.Name = "cmbMaChuyenBay";
            this.cmbMaChuyenBay.Size = new System.Drawing.Size(132, 23);
            this.cmbMaChuyenBay.TabIndex = 8;
            this.cmbMaChuyenBay.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // cmbMaCB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QuanLyBanVeChuyenBay.Properties.Resources.blue_turquoise_gradient_polygon_shaped_background_zoomed_in_and_zoomed_out_in_one_motion_nj5dnqsrl__F0000;
            this.ClientSize = new System.Drawing.Size(481, 288);
            this.Controls.Add(this.cmbMaChuyenBay);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.txtSoGheh2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSoGheH1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "cmbMaCB";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sửa Đổi Qui Định 2";
            this.Load += new System.EventHandler(this.frmQD2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSoGheH1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSoGheh2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.ComboBox cmbMaChuyenBay;
    }
}