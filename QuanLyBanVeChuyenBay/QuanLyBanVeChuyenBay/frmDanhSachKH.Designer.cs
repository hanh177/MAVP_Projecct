namespace QuanLyBanVeChuyenBay
{
    partial class frmDanhSachKH
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
            this.dataDSKH = new System.Windows.Forms.DataGridView();
            this.btnPhieuDat = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.colMaKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCMND = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaVe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaCB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnHuyVe = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.txtCMND = new System.Windows.Forms.TextBox();
            this.btnLoadLai = new System.Windows.Forms.Button();
            this.txtMaKH = new System.Windows.Forms.ComboBox();
            this.txtMaCB = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataDSKH)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataDSKH
            // 
            this.dataDSKH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataDSKH.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaKH,
            this.colHoTen,
            this.colCMND,
            this.colMaVe,
            this.colMaCB});
            this.dataDSKH.Location = new System.Drawing.Point(26, 194);
            this.dataDSKH.Name = "dataDSKH";
            this.dataDSKH.Size = new System.Drawing.Size(652, 206);
            this.dataDSKH.TabIndex = 0;
            // 
            // btnPhieuDat
            // 
            this.btnPhieuDat.Location = new System.Drawing.Point(380, 418);
            this.btnPhieuDat.Name = "btnPhieuDat";
            this.btnPhieuDat.Size = new System.Drawing.Size(114, 32);
            this.btnPhieuDat.TabIndex = 1;
            this.btnPhieuDat.Text = "Xem phiếu đặt chỗ";
            this.btnPhieuDat.UseVisualStyleBackColor = true;
            this.btnPhieuDat.Click += new System.EventHandler(this.btnPhieuDat_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(533, 418);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 32);
            this.btnThoat.TabIndex = 2;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(486, 95);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(75, 23);
            this.btnTimKiem.TabIndex = 3;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // colMaKH
            // 
            this.colMaKH.DataPropertyName = "MaHanhKhach";
            this.colMaKH.FillWeight = 91.97324F;
            this.colMaKH.HeaderText = "Mã Khách Hàng";
            this.colMaKH.Name = "colMaKH";
            // 
            // colHoTen
            // 
            this.colHoTen.DataPropertyName = "HoTen";
            this.colHoTen.FillWeight = 68.85513F;
            this.colHoTen.HeaderText = "Họ Tên";
            this.colHoTen.Name = "colHoTen";
            this.colHoTen.Width = 170;
            // 
            // colCMND
            // 
            this.colCMND.DataPropertyName = "CMMD";
            this.colCMND.FillWeight = 78.57214F;
            this.colCMND.HeaderText = "CMND";
            this.colCMND.Name = "colCMND";
            this.colCMND.Width = 140;
            // 
            // colMaVe
            // 
            this.colMaVe.DataPropertyName = "MaVe";
            this.colMaVe.FillWeight = 88.4464F;
            this.colMaVe.HeaderText = "Mã vé";
            this.colMaVe.Name = "colMaVe";
            // 
            // colMaCB
            // 
            this.colMaCB.DataPropertyName = "MaCB";
            this.colMaCB.FillWeight = 172.1531F;
            this.colMaCB.HeaderText = "Mã Chuyến Bay";
            this.colMaCB.Name = "colMaCB";
            // 
            // btnHuyVe
            // 
            this.btnHuyVe.Location = new System.Drawing.Point(246, 418);
            this.btnHuyVe.Name = "btnHuyVe";
            this.btnHuyVe.Size = new System.Drawing.Size(98, 32);
            this.btnHuyVe.TabIndex = 4;
            this.btnHuyVe.Text = "Hủy Đặt Vé";
            this.btnHuyVe.UseVisualStyleBackColor = true;
            this.btnHuyVe.Click += new System.EventHandler(this.btnHuyVe_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtMaCB);
            this.groupBox1.Controls.Add(this.txtMaKH);
            this.groupBox1.Controls.Add(this.txtCMND);
            this.groupBox1.Controls.Add(this.txtHoTen);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnTimKiem);
            this.groupBox1.Location = new System.Drawing.Point(38, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(624, 130);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm Kiếm Khách Hàng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Harlow Solid Italic", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(242, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "Danh Sách Khách Hàng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Họ tên:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(385, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Mã chuyến bay:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "CMND:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(381, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Mã Khách Hàng:";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(80, 32);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(207, 20);
            this.txtHoTen.TabIndex = 8;
            // 
            // txtCMND
            // 
            this.txtCMND.Location = new System.Drawing.Point(80, 61);
            this.txtCMND.Name = "txtCMND";
            this.txtCMND.Size = new System.Drawing.Size(137, 20);
            this.txtCMND.TabIndex = 11;
            // 
            // btnLoadLai
            // 
            this.btnLoadLai.Location = new System.Drawing.Point(102, 418);
            this.btnLoadLai.Name = "btnLoadLai";
            this.btnLoadLai.Size = new System.Drawing.Size(113, 32);
            this.btnLoadLai.TabIndex = 7;
            this.btnLoadLai.Text = "Load lại danh sách";
            this.btnLoadLai.UseVisualStyleBackColor = true;
            this.btnLoadLai.Click += new System.EventHandler(this.btnLoadLai_Click);
            // 
            // txtMaKH
            // 
            this.txtMaKH.FormattingEnabled = true;
            this.txtMaKH.Location = new System.Drawing.Point(475, 32);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Size = new System.Drawing.Size(121, 21);
            this.txtMaKH.TabIndex = 12;
            // 
            // txtMaCB
            // 
            this.txtMaCB.FormattingEnabled = true;
            this.txtMaCB.Location = new System.Drawing.Point(474, 61);
            this.txtMaCB.Name = "txtMaCB";
            this.txtMaCB.Size = new System.Drawing.Size(121, 21);
            this.txtMaCB.TabIndex = 13;
            this.txtMaCB.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // frmDanhSachKH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 459);
            this.Controls.Add(this.btnLoadLai);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnHuyVe);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnPhieuDat);
            this.Controls.Add(this.dataDSKH);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmDanhSachKH";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh Sách Khách Hàng";
            this.Load += new System.EventHandler(this.frmDanhSachKH_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataDSKH)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataDSKH;
        private System.Windows.Forms.Button btnPhieuDat;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCMND;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaVe;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaCB;
        private System.Windows.Forms.Button btnHuyVe;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtCMND;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLoadLai;
        private System.Windows.Forms.ComboBox txtMaCB;
        private System.Windows.Forms.ComboBox txtMaKH;
    }
}