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
            this.Help = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
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
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton3,
            this.Help});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(740, 25);
            this.toolStrip1.TabIndex = 60;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // Help
            // 
            this.Help.Image = ((System.Drawing.Image)(resources.GetObject("Help.Image")));
            this.Help.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Help.Name = "Help";
            this.Help.Size = new System.Drawing.Size(52, 22);
            this.Help.Text = "&Help";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(93, 22);
            this.toolStripButton1.Text = "Đặt Vé C.Bay";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(91, 22);
            this.toolStripButton2.Text = "Thêm C.Bay";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(101, 22);
            this.toolStripButton3.Text = "Tra Cứu C.Bay";
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(540, 417);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 51);
            this.btnThoat.TabIndex = 65;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
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
            // 
            // btnThemCB
            // 
            this.btnThemCB.Location = new System.Drawing.Point(233, 417);
            this.btnThemCB.Name = "btnThemCB";
            this.btnThemCB.Size = new System.Drawing.Size(75, 51);
            this.btnThemCB.TabIndex = 62;
            this.btnThemCB.Text = "Thêm chuyến bay";
            this.btnThemCB.UseVisualStyleBackColor = true;
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
            this.Text = "Danh Sách Chuyến Bay";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataDanhSachCB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton Help;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
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
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
    }
}