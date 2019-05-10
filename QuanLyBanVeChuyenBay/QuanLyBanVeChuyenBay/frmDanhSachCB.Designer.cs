namespace QuanLyBanVeChuyenBay
{
    partial class frmDanSachCB
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDanSachCB));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tSbtnDatVeCB = new System.Windows.Forms.ToolStripButton();
            this.tSbtnThemCB = new System.Windows.Forms.ToolStripButton();
            this.tSbtnTraCuuCB = new System.Windows.Forms.ToolStripButton();
            this.tSbtnHelp = new System.Windows.Forms.ToolStripButton();
            this.btnThoat = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTraCuu = new System.Windows.Forms.Button();
            this.dataDanhSachCB = new System.Windows.Forms.DataGridView();
            this.ColMaCB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColSanBayDi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColSanBayDen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColThGianBay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColSanBayTG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colThGianDung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTongGhe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColSoGheTrong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColGheTrongh1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColGheTrongH2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDatVe = new System.Windows.Forms.Button();
            this.btnThemCB = new System.Windows.Forms.Button();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataDanhSachCB)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tSbtnDatVeCB,
            this.tSbtnThemCB,
            this.tSbtnTraCuuCB,
            this.tSbtnHelp});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(740, 25);
            this.toolStrip1.TabIndex = 60;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tSbtnDatVeCB
            // 
            this.tSbtnDatVeCB.Image = ((System.Drawing.Image)(resources.GetObject("tSbtnDatVeCB.Image")));
            this.tSbtnDatVeCB.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSbtnDatVeCB.Name = "tSbtnDatVeCB";
            this.tSbtnDatVeCB.Size = new System.Drawing.Size(93, 22);
            this.tSbtnDatVeCB.Text = "&Đặt Vé C.Bay";
            this.tSbtnDatVeCB.Click += new System.EventHandler(this.tSbtnDatVeCB_Clicked);
            // 
            // tSbtnThemCB
            // 
            this.tSbtnThemCB.Image = ((System.Drawing.Image)(resources.GetObject("tSbtnThemCB.Image")));
            this.tSbtnThemCB.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSbtnThemCB.Name = "tSbtnThemCB";
            this.tSbtnThemCB.Size = new System.Drawing.Size(91, 22);
            this.tSbtnThemCB.Text = "&Thêm C.Bay";
            this.tSbtnThemCB.Click += new System.EventHandler(this.tSbtnThemCB_Clicked);
            // 
            // tSbtnTraCuuCB
            // 
            this.tSbtnTraCuuCB.Image = ((System.Drawing.Image)(resources.GetObject("tSbtnTraCuuCB.Image")));
            this.tSbtnTraCuuCB.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSbtnTraCuuCB.Name = "tSbtnTraCuuCB";
            this.tSbtnTraCuuCB.Size = new System.Drawing.Size(101, 22);
            this.tSbtnTraCuuCB.Text = "&Tra Cứu C.Bay";
            this.tSbtnTraCuuCB.Click += new System.EventHandler(this.tSbtnTraCuuCB_Click);
            // 
            // tSbtnHelp
            // 
            this.tSbtnHelp.Image = ((System.Drawing.Image)(resources.GetObject("tSbtnHelp.Image")));
            this.tSbtnHelp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSbtnHelp.Name = "tSbtnHelp";
            this.tSbtnHelp.Size = new System.Drawing.Size(52, 22);
            this.tSbtnHelp.Text = "&Help";
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(540, 417);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 51);
            this.btnThoat.TabIndex = 65;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(275, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 13);
            this.label1.TabIndex = 55;
            this.label1.Text = "Danh Sách Chuyến Bay";
            // 
            // btnTraCuu
            // 
            this.btnTraCuu.Location = new System.Drawing.Point(131, 417);
            this.btnTraCuu.Name = "btnTraCuu";
            this.btnTraCuu.Size = new System.Drawing.Size(75, 51);
            this.btnTraCuu.TabIndex = 61;
            this.btnTraCuu.Text = "Tra cứu";
            this.btnTraCuu.UseVisualStyleBackColor = true;
            this.btnTraCuu.Click += new System.EventHandler(this.btnTraCuu_Click);
            // 
            // dataDanhSachCB
            // 
            this.dataDanhSachCB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataDanhSachCB.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColMaCB,
            this.ColSanBayDi,
            this.ColSanBayDen,
            this.ColThGianBay,
            this.ColSanBayTG,
            this.colThGianDung,
            this.ColTongGhe,
            this.ColSoGheTrong,
            this.ColDonGia,
            this.ColGheTrongh1,
            this.ColGheTrongH2});
            this.dataDanhSachCB.Location = new System.Drawing.Point(24, 66);
            this.dataDanhSachCB.Name = "dataDanhSachCB";
            this.dataDanhSachCB.Size = new System.Drawing.Size(691, 323);
            this.dataDanhSachCB.TabIndex = 54;
            // 
            // ColMaCB
            // 
            this.ColMaCB.HeaderText = "Mã chuyến bay";
            this.ColMaCB.Name = "ColMaCB";
            this.ColMaCB.Width = 50;
            // 
            // ColSanBayDi
            // 
            this.ColSanBayDi.HeaderText = "Sân bay đi";
            this.ColSanBayDi.Name = "ColSanBayDi";
            this.ColSanBayDi.Width = 80;
            // 
            // ColSanBayDen
            // 
            this.ColSanBayDen.HeaderText = "Sân bay đến";
            this.ColSanBayDen.Name = "ColSanBayDen";
            this.ColSanBayDen.Width = 80;
            // 
            // ColThGianBay
            // 
            this.ColThGianBay.HeaderText = "Thời gian bay";
            this.ColThGianBay.Name = "ColThGianBay";
            this.ColThGianBay.Width = 50;
            // 
            // ColSanBayTG
            // 
            this.ColSanBayTG.HeaderText = "Sân bay trung gian";
            this.ColSanBayTG.Name = "ColSanBayTG";
            this.ColSanBayTG.Width = 80;
            // 
            // colThGianDung
            // 
            this.colThGianDung.HeaderText = "Thời gian dừng";
            this.colThGianDung.Name = "colThGianDung";
            this.colThGianDung.Width = 40;
            // 
            // ColTongGhe
            // 
            this.ColTongGhe.HeaderText = "Tổng số ghế";
            this.ColTongGhe.Name = "ColTongGhe";
            this.ColTongGhe.Width = 40;
            // 
            // ColSoGheTrong
            // 
            this.ColSoGheTrong.HeaderText = "Số ghế trống";
            this.ColSoGheTrong.Name = "ColSoGheTrong";
            this.ColSoGheTrong.Width = 40;
            // 
            // ColDonGia
            // 
            this.ColDonGia.HeaderText = "Đơn giá";
            this.ColDonGia.Name = "ColDonGia";
            this.ColDonGia.Width = 80;
            // 
            // ColGheTrongh1
            // 
            this.ColGheTrongh1.HeaderText = "Số ghế trống hạng 1";
            this.ColGheTrongh1.Name = "ColGheTrongh1";
            this.ColGheTrongh1.Width = 40;
            // 
            // ColGheTrongH2
            // 
            this.ColGheTrongH2.HeaderText = "Số ghế trống hạng 2";
            this.ColGheTrongH2.Name = "ColGheTrongH2";
            this.ColGheTrongH2.Width = 40;
            // 
            // btnDatVe
            // 
            this.btnDatVe.Location = new System.Drawing.Point(439, 417);
            this.btnDatVe.Name = "btnDatVe";
            this.btnDatVe.Size = new System.Drawing.Size(75, 51);
            this.btnDatVe.TabIndex = 64;
            this.btnDatVe.Text = "Đặt vé chuyến bay";
            this.btnDatVe.UseVisualStyleBackColor = true;
            this.btnDatVe.Click += new System.EventHandler(this.btnDatVe_Click);
            // 
            // btnThemCB
            // 
            this.btnThemCB.Location = new System.Drawing.Point(233, 417);
            this.btnThemCB.Name = "btnThemCB";
            this.btnThemCB.Size = new System.Drawing.Size(75, 51);
            this.btnThemCB.TabIndex = 62;
            this.btnThemCB.Text = "Thêm chuyến bay";
            this.btnThemCB.UseVisualStyleBackColor = true;
            this.btnThemCB.Click += new System.EventHandler(this.btnThemCB_Click);
            // 
            // frmDanSachCB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 489);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnDatVe);
            this.Controls.Add(this.btnThemCB);
            this.Controls.Add(this.btnTraCuu);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataDanhSachCB);
            this.Name = "frmDanSachCB";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh Sách Chuyến Bay";
            this.Load += new System.EventHandler(this.frmDanSachCB_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataDanhSachCB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tSbtnHelp;
        private System.Windows.Forms.ToolStripButton tSbtnDatVeCB;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTraCuu;
        private System.Windows.Forms.DataGridView dataDanhSachCB;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColMaCB;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColSanBayDi;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColSanBayDen;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColThGianBay;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColSanBayTG;
        private System.Windows.Forms.DataGridViewTextBoxColumn colThGianDung;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTongGhe;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColSoGheTrong;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColGheTrongh1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColGheTrongH2;
        private System.Windows.Forms.Button btnDatVe;
        private System.Windows.Forms.Button btnThemCB;
        private System.Windows.Forms.ToolStripButton tSbtnThemCB;
        private System.Windows.Forms.ToolStripButton tSbtnTraCuuCB;
    }
}