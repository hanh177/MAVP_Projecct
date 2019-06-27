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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDanhSachKH));
            this.dataDSKH = new System.Windows.Forms.DataGridView();
            this.colMaKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCMND = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaVe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaCB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnPhieuDat = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnHuyVe = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbMaCB = new System.Windows.Forms.ComboBox();
            this.cmbMaKH = new System.Windows.Forms.ComboBox();
            this.txtCMND = new System.Windows.Forms.TextBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLoadLai = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataDSKH)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataDSKH
            // 
            this.dataDSKH.BackgroundColor = System.Drawing.Color.CornflowerBlue;
            this.dataDSKH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataDSKH.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaKH,
            this.colHoTen,
            this.colCMND,
            this.SDT,
            this.colMaVe,
            this.colMaCB});
            this.dataDSKH.Location = new System.Drawing.Point(35, 224);
            this.dataDSKH.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataDSKH.Name = "dataDSKH";
            this.dataDSKH.ReadOnly = true;
            this.dataDSKH.Size = new System.Drawing.Size(877, 238);
            this.dataDSKH.TabIndex = 0;
            this.dataDSKH.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataDSKH_CellContentClick);
            this.dataDSKH.Click += new System.EventHandler(this.dataDSKH_Click);
            // 
            // colMaKH
            // 
            this.colMaKH.DataPropertyName = "MaHanhKhach";
            this.colMaKH.FillWeight = 91.97324F;
            this.colMaKH.HeaderText = "Mã Khách Hàng";
            this.colMaKH.Name = "colMaKH";
            this.colMaKH.ReadOnly = true;
            // 
            // colHoTen
            // 
            this.colHoTen.DataPropertyName = "HoTen";
            this.colHoTen.FillWeight = 68.85513F;
            this.colHoTen.HeaderText = "Họ Tên";
            this.colHoTen.Name = "colHoTen";
            this.colHoTen.ReadOnly = true;
            this.colHoTen.Width = 170;
            // 
            // colCMND
            // 
            this.colCMND.DataPropertyName = "CMMD";
            this.colCMND.FillWeight = 78.57214F;
            this.colCMND.HeaderText = "CMND";
            this.colCMND.Name = "colCMND";
            this.colCMND.ReadOnly = true;
            this.colCMND.Width = 140;
            // 
            // SDT
            // 
            this.SDT.DataPropertyName = "SDT";
            this.SDT.HeaderText = "SDT";
            this.SDT.Name = "SDT";
            this.SDT.ReadOnly = true;
            this.SDT.Width = 120;
            // 
            // colMaVe
            // 
            this.colMaVe.DataPropertyName = "MaVe";
            this.colMaVe.FillWeight = 88.4464F;
            this.colMaVe.HeaderText = "Mã vé";
            this.colMaVe.Name = "colMaVe";
            this.colMaVe.ReadOnly = true;
            // 
            // colMaCB
            // 
            this.colMaCB.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colMaCB.DataPropertyName = "MaCB";
            this.colMaCB.FillWeight = 172.1531F;
            this.colMaCB.HeaderText = "Mã Chuyến Bay";
            this.colMaCB.Name = "colMaCB";
            this.colMaCB.ReadOnly = true;
            // 
            // btnPhieuDat
            // 
            this.btnPhieuDat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPhieuDat.Image = global::QuanLyBanVeChuyenBay.Properties.Resources.see_document_512__1_1;
            this.btnPhieuDat.Location = new System.Drawing.Point(521, 488);
            this.btnPhieuDat.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnPhieuDat.Name = "btnPhieuDat";
            this.btnPhieuDat.Size = new System.Drawing.Size(176, 42);
            this.btnPhieuDat.TabIndex = 1;
            this.btnPhieuDat.Text = "Xem phiếu đặt chỗ";
            this.btnPhieuDat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPhieuDat.UseVisualStyleBackColor = true;
            this.btnPhieuDat.Click += new System.EventHandler(this.btnPhieuDat_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThoat.Image = global::QuanLyBanVeChuyenBay.Properties.Resources.Thoat__1_2;
            this.btnThoat.Location = new System.Drawing.Point(754, 488);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(119, 42);
            this.btnThoat.TabIndex = 2;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnHuyVe
            // 
            this.btnHuyVe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnHuyVe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHuyVe.Image = global::QuanLyBanVeChuyenBay.Properties.Resources.HuyDatVe__1_1;
            this.btnHuyVe.Location = new System.Drawing.Point(347, 488);
            this.btnHuyVe.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnHuyVe.Name = "btnHuyVe";
            this.btnHuyVe.Size = new System.Drawing.Size(131, 42);
            this.btnHuyVe.TabIndex = 4;
            this.btnHuyVe.Text = "Hủy Đặt Vé";
            this.btnHuyVe.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHuyVe.UseVisualStyleBackColor = false;
            this.btnHuyVe.Click += new System.EventHandler(this.btnHuyVe_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.cmbMaCB);
            this.groupBox1.Controls.Add(this.cmbMaKH);
            this.groupBox1.Controls.Add(this.txtCMND);
            this.groupBox1.Controls.Add(this.txtHoTen);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnTimKiem);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(51, 28);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(861, 150);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm Kiếm Khách Hàng";
            // 
            // cmbMaCB
            // 
            this.cmbMaCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMaCB.FormattingEnabled = true;
            this.cmbMaCB.Location = new System.Drawing.Point(628, 76);
            this.cmbMaCB.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmbMaCB.Name = "cmbMaCB";
            this.cmbMaCB.Size = new System.Drawing.Size(225, 23);
            this.cmbMaCB.TabIndex = 13;
            this.cmbMaCB.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // cmbMaKH
            // 
            this.cmbMaKH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMaKH.FormattingEnabled = true;
            this.cmbMaKH.Location = new System.Drawing.Point(628, 37);
            this.cmbMaKH.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmbMaKH.Name = "cmbMaKH";
            this.cmbMaKH.Size = new System.Drawing.Size(224, 23);
            this.cmbMaKH.TabIndex = 12;
            // 
            // txtCMND
            // 
            this.txtCMND.Location = new System.Drawing.Point(139, 76);
            this.txtCMND.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtCMND.Multiline = true;
            this.txtCMND.Name = "txtCMND";
            this.txtCMND.Size = new System.Drawing.Size(224, 28);
            this.txtCMND.TabIndex = 11;
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(139, 40);
            this.txtHoTen.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtHoTen.Multiline = true;
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(224, 28);
            this.txtHoTen.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(486, 40);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = "Mã Khách Hàng:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 88);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "CMND:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(493, 79);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Mã chuyến bay:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 44);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Họ tên:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.Color.Cyan;
            this.btnTimKiem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTimKiem.Image = global::QuanLyBanVeChuyenBay.Properties.Resources.unnamed1;
            this.btnTimKiem.Location = new System.Drawing.Point(692, 107);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(151, 37);
            this.btnTimKiem.TabIndex = 3;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTimKiem.UseCompatibleTextRendering = true;
            this.btnTimKiem.UseVisualStyleBackColor = false;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Harlow Solid Italic", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(427, 181);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "Danh Sách Khách Hàng";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnLoadLai
            // 
            this.btnLoadLai.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnLoadLai.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLoadLai.Image = global::QuanLyBanVeChuyenBay.Properties.Resources.refresh;
            this.btnLoadLai.Location = new System.Drawing.Point(115, 488);
            this.btnLoadLai.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnLoadLai.Name = "btnLoadLai";
            this.btnLoadLai.Size = new System.Drawing.Size(169, 42);
            this.btnLoadLai.TabIndex = 7;
            this.btnLoadLai.Text = "Load lại danh sách";
            this.btnLoadLai.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLoadLai.UseVisualStyleBackColor = false;
            this.btnLoadLai.Click += new System.EventHandler(this.btnLoadLai_Click);
            // 
            // frmDanhSachKH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::QuanLyBanVeChuyenBay.Properties.Resources.blue_turquoise_gradient_polygon_shaped_background_zoomed_in_and_zoomed_out_in_one_motion_nj5dnqsrl__F00001;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(936, 555);
            this.Controls.Add(this.btnLoadLai);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnHuyVe);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnPhieuDat);
            this.Controls.Add(this.dataDSKH);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
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
        private System.Windows.Forms.ComboBox cmbMaCB;
        private System.Windows.Forms.ComboBox cmbMaKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCMND;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaVe;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaCB;
    }
}