namespace QuanLyBanVeChuyenBay
{
    partial class frmTraCuu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTraCuu));
            this.btnTraCuu = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbMaCB = new System.Windows.Forms.ComboBox();
            this.txtNgayBay = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbSanBayDen = new System.Windows.Forms.ComboBox();
            this.cmbSanBayDi = new System.Windows.Forms.ComboBox();
            this.btnSanBayDen = new System.Windows.Forms.Label();
            this.SanBayDi = new System.Windows.Forms.Label();
            this.MaCB = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnDanhSach = new System.Windows.Forms.ToolStripDropDownButton();
            this.Help = new System.Windows.Forms.ToolStripButton();
            this.dataDanhSachCB = new System.Windows.Forms.DataGridView();
            this.btnDatVe = new System.Windows.Forms.Button();
            this.ColMaCB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColSanBayDi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColSanBayDen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColThGianBay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColSLSBTG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColNgayGio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTongGhe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColSoGheTrong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColGheTrongh1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColGheTrongH2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataDanhSachCB)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTraCuu
            // 
            this.btnTraCuu.Image = global::QuanLyBanVeChuyenBay.Properties.Resources.find__1_;
            this.btnTraCuu.Location = new System.Drawing.Point(714, 92);
            this.btnTraCuu.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnTraCuu.Name = "btnTraCuu";
            this.btnTraCuu.Size = new System.Drawing.Size(100, 38);
            this.btnTraCuu.TabIndex = 50;
            this.btnTraCuu.Text = "Tra cứu";
            this.btnTraCuu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTraCuu.UseVisualStyleBackColor = true;
            this.btnTraCuu.Click += new System.EventHandler(this.btnTraCuu_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.cmbMaCB);
            this.groupBox1.Controls.Add(this.txtNgayBay);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cmbSanBayDen);
            this.groupBox1.Controls.Add(this.btnTraCuu);
            this.groupBox1.Controls.Add(this.cmbSanBayDi);
            this.groupBox1.Controls.Add(this.btnSanBayDen);
            this.groupBox1.Controls.Add(this.SanBayDi);
            this.groupBox1.Controls.Add(this.MaCB);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(17, 38);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(864, 136);
            this.groupBox1.TabIndex = 52;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Tra Cứu";
            // 
            // cmbMaCB
            // 
            this.cmbMaCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMaCB.FormattingEnabled = true;
            this.cmbMaCB.Location = new System.Drawing.Point(185, 20);
            this.cmbMaCB.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmbMaCB.Name = "cmbMaCB";
            this.cmbMaCB.Size = new System.Drawing.Size(179, 23);
            this.cmbMaCB.TabIndex = 53;
            // 
            // txtNgayBay
            // 
            this.txtNgayBay.Location = new System.Drawing.Point(185, 70);
            this.txtNgayBay.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtNgayBay.Name = "txtNgayBay";
            this.txtNgayBay.Size = new System.Drawing.Size(179, 21);
            this.txtNgayBay.TabIndex = 52;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 73);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(156, 15);
            this.label6.TabIndex = 51;
            this.label6.Text = "Ngày Bay (dd/MM/yyyy):";
            // 
            // cmbSanBayDen
            // 
            this.cmbSanBayDen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSanBayDen.FormattingEnabled = true;
            this.cmbSanBayDen.Location = new System.Drawing.Point(631, 63);
            this.cmbSanBayDen.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmbSanBayDen.Name = "cmbSanBayDen";
            this.cmbSanBayDen.Size = new System.Drawing.Size(183, 23);
            this.cmbSanBayDen.TabIndex = 49;
            // 
            // cmbSanBayDi
            // 
            this.cmbSanBayDi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSanBayDi.FormattingEnabled = true;
            this.cmbSanBayDi.Location = new System.Drawing.Point(631, 23);
            this.cmbSanBayDi.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmbSanBayDi.Name = "cmbSanBayDi";
            this.cmbSanBayDi.Size = new System.Drawing.Size(183, 23);
            this.cmbSanBayDi.TabIndex = 48;
            // 
            // btnSanBayDen
            // 
            this.btnSanBayDen.AutoSize = true;
            this.btnSanBayDen.Location = new System.Drawing.Point(535, 71);
            this.btnSanBayDen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.btnSanBayDen.Name = "btnSanBayDen";
            this.btnSanBayDen.Size = new System.Drawing.Size(93, 15);
            this.btnSanBayDen.TabIndex = 47;
            this.btnSanBayDen.Text = "Sân Bay Đến:";
            // 
            // SanBayDi
            // 
            this.SanBayDi.AutoSize = true;
            this.SanBayDi.Location = new System.Drawing.Point(535, 31);
            this.SanBayDi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SanBayDi.Name = "SanBayDi";
            this.SanBayDi.Size = new System.Drawing.Size(81, 15);
            this.SanBayDi.TabIndex = 46;
            this.SanBayDi.Text = "&Sân Bay Đi:";
            // 
            // MaCB
            // 
            this.MaCB.AutoSize = true;
            this.MaCB.Location = new System.Drawing.Point(8, 31);
            this.MaCB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MaCB.Name = "MaCB";
            this.MaCB.Size = new System.Drawing.Size(109, 15);
            this.MaCB.TabIndex = 44;
            this.MaCB.Text = "&Mã Chuyến Bay:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(391, 178);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 16);
            this.label1.TabIndex = 53;
            this.label1.Text = "Danh Sách Chuyến Bay";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnThoat.Image = global::QuanLyBanVeChuyenBay.Properties.Resources.Thoat__1_2;
            this.btnThoat.Location = new System.Drawing.Point(648, 584);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(120, 58);
            this.btnThoat.TabIndex = 57;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackgroundImage = global::QuanLyBanVeChuyenBay.Properties.Resources.blue_turquoise_gradient_polygon_shaped_background_zoomed_in_and_zoomed_out_in_one_motion_nj5dnqsrl__F0000;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnDanhSach,
            this.Help});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(904, 25);
            this.toolStrip1.TabIndex = 59;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // btnDanhSach
            // 
            this.btnDanhSach.Image = ((System.Drawing.Image)(resources.GetObject("btnDanhSach.Image")));
            this.btnDanhSach.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDanhSach.Name = "btnDanhSach";
            this.btnDanhSach.Size = new System.Drawing.Size(83, 22);
            this.btnDanhSach.Text = "&DS C.Bay";
            this.btnDanhSach.Click += new System.EventHandler(this.btnDanhSach_Click);
            // 
            // Help
            // 
            this.Help.Image = ((System.Drawing.Image)(resources.GetObject("Help.Image")));
            this.Help.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Help.Name = "Help";
            this.Help.Size = new System.Drawing.Size(52, 22);
            this.Help.Text = "&Help";
            // 
            // dataDanhSachCB
            // 
            this.dataDanhSachCB.BackgroundColor = System.Drawing.Color.CornflowerBlue;
            this.dataDanhSachCB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataDanhSachCB.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColMaCB,
            this.ColSanBayDi,
            this.ColSanBayDen,
            this.ColThGianBay,
            this.ColSLSBTG,
            this.ColNgayGio,
            this.ColTongGhe,
            this.ColSoGheTrong,
            this.ColDonGia,
            this.ColGheTrongh1,
            this.ColGheTrongH2});
            this.dataDanhSachCB.Location = new System.Drawing.Point(16, 200);
            this.dataDanhSachCB.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataDanhSachCB.Name = "dataDanhSachCB";
            this.dataDanhSachCB.ReadOnly = true;
            this.dataDanhSachCB.Size = new System.Drawing.Size(865, 373);
            this.dataDanhSachCB.TabIndex = 60;
            this.dataDanhSachCB.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataDanhSachCB_CellContentClick);
            this.dataDanhSachCB.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataDanhSachCB_CellDoubleClick);
            this.dataDanhSachCB.Click += new System.EventHandler(this.dataDanhSachCB_Click);
            // 
            // btnDatVe
            // 
            this.btnDatVe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnDatVe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDatVe.Image = global::QuanLyBanVeChuyenBay.Properties.Resources.DatVe__1_2;
            this.btnDatVe.Location = new System.Drawing.Point(252, 585);
            this.btnDatVe.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnDatVe.Name = "btnDatVe";
            this.btnDatVe.Size = new System.Drawing.Size(120, 58);
            this.btnDatVe.TabIndex = 61;
            this.btnDatVe.Text = "Đặt Vé";
            this.btnDatVe.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDatVe.UseVisualStyleBackColor = false;
            this.btnDatVe.Click += new System.EventHandler(this.btnDatVe_Click);
            // 
            // ColMaCB
            // 
            this.ColMaCB.DataPropertyName = "MaCB";
            this.ColMaCB.HeaderText = "Mã chuyến bay";
            this.ColMaCB.Name = "ColMaCB";
            this.ColMaCB.ReadOnly = true;
            this.ColMaCB.Width = 60;
            // 
            // ColSanBayDi
            // 
            this.ColSanBayDi.DataPropertyName = "SanBayDi";
            this.ColSanBayDi.HeaderText = "Sân bay đi";
            this.ColSanBayDi.Name = "ColSanBayDi";
            this.ColSanBayDi.ReadOnly = true;
            this.ColSanBayDi.Width = 80;
            // 
            // ColSanBayDen
            // 
            this.ColSanBayDen.DataPropertyName = "SanBayDen";
            this.ColSanBayDen.HeaderText = "Sân bay đến";
            this.ColSanBayDen.Name = "ColSanBayDen";
            this.ColSanBayDen.ReadOnly = true;
            this.ColSanBayDen.Width = 80;
            // 
            // ColThGianBay
            // 
            this.ColThGianBay.DataPropertyName = "ThoiGianBay";
            this.ColThGianBay.HeaderText = "Thời gian bay";
            this.ColThGianBay.Name = "ColThGianBay";
            this.ColThGianBay.ReadOnly = true;
            this.ColThGianBay.Width = 60;
            // 
            // ColSLSBTG
            // 
            this.ColSLSBTG.DataPropertyName = "SLSBTG";
            this.ColSLSBTG.HeaderText = "Số lượng sân bay TG";
            this.ColSLSBTG.Name = "ColSLSBTG";
            this.ColSLSBTG.ReadOnly = true;
            this.ColSLSBTG.Width = 60;
            // 
            // ColNgayGio
            // 
            this.ColNgayGio.DataPropertyName = "NgayGio";
            this.ColNgayGio.HeaderText = "Ngày giờ bay";
            this.ColNgayGio.Name = "ColNgayGio";
            this.ColNgayGio.ReadOnly = true;
            this.ColNgayGio.Width = 120;
            // 
            // ColTongGhe
            // 
            this.ColTongGhe.DataPropertyName = "TongSoGhe";
            this.ColTongGhe.HeaderText = "Tổng số ghế";
            this.ColTongGhe.Name = "ColTongGhe";
            this.ColTongGhe.ReadOnly = true;
            this.ColTongGhe.Width = 65;
            // 
            // ColSoGheTrong
            // 
            this.ColSoGheTrong.DataPropertyName = "TongSoGheTrong";
            this.ColSoGheTrong.HeaderText = "Số ghế trống";
            this.ColSoGheTrong.Name = "ColSoGheTrong";
            this.ColSoGheTrong.ReadOnly = true;
            this.ColSoGheTrong.Width = 65;
            // 
            // ColDonGia
            // 
            this.ColDonGia.DataPropertyName = "GiaVe";
            this.ColDonGia.HeaderText = "Đơn giá";
            this.ColDonGia.Name = "ColDonGia";
            this.ColDonGia.ReadOnly = true;
            // 
            // ColGheTrongh1
            // 
            this.ColGheTrongh1.DataPropertyName = "SLGheTrongH1";
            this.ColGheTrongh1.HeaderText = "Số ghế trống hạng 1";
            this.ColGheTrongh1.Name = "ColGheTrongh1";
            this.ColGheTrongh1.ReadOnly = true;
            this.ColGheTrongh1.Width = 60;
            // 
            // ColGheTrongH2
            // 
            this.ColGheTrongH2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColGheTrongH2.DataPropertyName = "SLGheTrongH2";
            this.ColGheTrongH2.HeaderText = "Số ghế trống hạng 2";
            this.ColGheTrongH2.Name = "ColGheTrongH2";
            this.ColGheTrongH2.ReadOnly = true;
            // 
            // frmTraCuu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QuanLyBanVeChuyenBay.Properties.Resources.blue_turquoise_gradient_polygon_shaped_background_zoomed_in_and_zoomed_out_in_one_motion_nj5dnqsrl__F0000;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(904, 655);
            this.Controls.Add(this.btnDatVe);
            this.Controls.Add(this.dataDanhSachCB);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "frmTraCuu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tra cứu thông tin chuyến bay";
            this.Load += new System.EventHandler(this.frmTraCuu_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataDanhSachCB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnTraCuu;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbSanBayDen;
        private System.Windows.Forms.ComboBox cmbSanBayDi;
        private System.Windows.Forms.Label btnSanBayDen;
        private System.Windows.Forms.Label SanBayDi;
        private System.Windows.Forms.Label MaCB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton btnDanhSach;
        private System.Windows.Forms.ToolStripButton Help;
        private System.Windows.Forms.DataGridView dataDanhSachCB;
        private System.Windows.Forms.TextBox txtNgayBay;
        private System.Windows.Forms.ComboBox cmbMaCB;
        private System.Windows.Forms.Button btnDatVe;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColMaCB;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColSanBayDi;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColSanBayDen;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColThGianBay;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColSLSBTG;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNgayGio;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTongGhe;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColSoGheTrong;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColGheTrongh1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColGheTrongH2;
    }
}