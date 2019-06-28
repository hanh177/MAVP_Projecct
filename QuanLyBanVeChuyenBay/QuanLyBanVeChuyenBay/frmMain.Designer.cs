namespace QuanLyBanVeChuyenBay
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSuaDoiQD = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnDoanhThu = new System.Windows.Forms.Button();
            this.btnDSKH = new System.Windows.Forms.Button();
            this.btnTraCuu = new System.Windows.Forms.Button();
            this.btnNhanLich = new System.Windows.Forms.Button();
            this.btnDanhSach = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tSbtnDangXuat = new System.Windows.Forms.ToolStripButton();
            this.tSbtnCaiDatTK = new System.Windows.Forms.ToolStripButton();
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox1.BackgroundImage")));
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 48);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(659, 198);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin ";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(108, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "label3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(28, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tài khoản:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Harlow Solid Italic", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(236, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 35);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bán Vé Máy Bay";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox2.BackgroundImage")));
            this.groupBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.groupBox2.Controls.Add(this.btnSuaDoiQD);
            this.groupBox2.Controls.Add(this.btnDoanhThu);
            this.groupBox2.Controls.Add(this.btnDSKH);
            this.groupBox2.Controls.Add(this.btnTraCuu);
            this.groupBox2.Controls.Add(this.btnNhanLich);
            this.groupBox2.Controls.Add(this.btnDanhSach);
            this.groupBox2.Location = new System.Drawing.Point(12, 252);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(659, 222);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // btnSuaDoiQD
            // 
            this.btnSuaDoiQD.BackColor = System.Drawing.Color.SkyBlue;
            this.btnSuaDoiQD.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSuaDoiQD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaDoiQD.ForeColor = System.Drawing.Color.Maroon;
            this.btnSuaDoiQD.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnSuaDoiQD.ImageIndex = 5;
            this.btnSuaDoiQD.ImageList = this.imageList1;
            this.btnSuaDoiQD.Location = new System.Drawing.Point(241, 120);
            this.btnSuaDoiQD.Name = "btnSuaDoiQD";
            this.btnSuaDoiQD.Size = new System.Drawing.Size(158, 56);
            this.btnSuaDoiQD.TabIndex = 2;
            this.btnSuaDoiQD.Text = "Sửa Đổi QĐ";
            this.btnSuaDoiQD.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSuaDoiQD.UseVisualStyleBackColor = false;
            this.btnSuaDoiQD.Click += new System.EventHandler(this.btnSuaDoiQD_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "NhanLich.ico");
            this.imageList1.Images.SetKeyName(1, "TimKiem.ico");
            this.imageList1.Images.SetKeyName(2, "DSCB.ico");
            this.imageList1.Images.SetKeyName(3, "DSKH.ico");
            this.imageList1.Images.SetKeyName(4, "BaoCaoDT.ico");
            this.imageList1.Images.SetKeyName(5, "SuaDoi.ico");
            // 
            // btnDoanhThu
            // 
            this.btnDoanhThu.BackColor = System.Drawing.Color.SkyBlue;
            this.btnDoanhThu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDoanhThu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoanhThu.ForeColor = System.Drawing.Color.Maroon;
            this.btnDoanhThu.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnDoanhThu.ImageIndex = 4;
            this.btnDoanhThu.ImageList = this.imageList1;
            this.btnDoanhThu.Location = new System.Drawing.Point(454, 120);
            this.btnDoanhThu.Name = "btnDoanhThu";
            this.btnDoanhThu.Size = new System.Drawing.Size(158, 56);
            this.btnDoanhThu.TabIndex = 1;
            this.btnDoanhThu.Text = "Báo cáo doanh thu";
            this.btnDoanhThu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDoanhThu.UseVisualStyleBackColor = false;
            this.btnDoanhThu.Click += new System.EventHandler(this.btnDoanhThu_Click);
            // 
            // btnDSKH
            // 
            this.btnDSKH.BackColor = System.Drawing.Color.SkyBlue;
            this.btnDSKH.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDSKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDSKH.ForeColor = System.Drawing.Color.Maroon;
            this.btnDSKH.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnDSKH.ImageIndex = 3;
            this.btnDSKH.ImageList = this.imageList1;
            this.btnDSKH.Location = new System.Drawing.Point(454, 30);
            this.btnDSKH.Name = "btnDSKH";
            this.btnDSKH.Size = new System.Drawing.Size(158, 56);
            this.btnDSKH.TabIndex = 1;
            this.btnDSKH.Text = "Danh Sách Khách Hàng";
            this.btnDSKH.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDSKH.UseVisualStyleBackColor = false;
            this.btnDSKH.Click += new System.EventHandler(this.btnDSKH_Click_1);
            // 
            // btnTraCuu
            // 
            this.btnTraCuu.BackColor = System.Drawing.Color.SkyBlue;
            this.btnTraCuu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTraCuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTraCuu.ForeColor = System.Drawing.Color.Maroon;
            this.btnTraCuu.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnTraCuu.ImageIndex = 1;
            this.btnTraCuu.ImageList = this.imageList1;
            this.btnTraCuu.Location = new System.Drawing.Point(24, 129);
            this.btnTraCuu.Name = "btnTraCuu";
            this.btnTraCuu.Size = new System.Drawing.Size(150, 47);
            this.btnTraCuu.TabIndex = 1;
            this.btnTraCuu.Text = "Tra Cứu";
            this.btnTraCuu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTraCuu.UseVisualStyleBackColor = false;
            this.btnTraCuu.Click += new System.EventHandler(this.btnTraCuu_Click);
            // 
            // btnNhanLich
            // 
            this.btnNhanLich.BackColor = System.Drawing.Color.SkyBlue;
            this.btnNhanLich.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNhanLich.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhanLich.ForeColor = System.Drawing.Color.Maroon;
            this.btnNhanLich.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnNhanLich.ImageIndex = 0;
            this.btnNhanLich.ImageList = this.imageList1;
            this.btnNhanLich.Location = new System.Drawing.Point(24, 30);
            this.btnNhanLich.Name = "btnNhanLich";
            this.btnNhanLich.Size = new System.Drawing.Size(150, 56);
            this.btnNhanLich.TabIndex = 1;
            this.btnNhanLich.Text = "Nhận lịch chuyến bay";
            this.btnNhanLich.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNhanLich.UseVisualStyleBackColor = false;
            this.btnNhanLich.Click += new System.EventHandler(this.btnNhanLich_Click);
            // 
            // btnDanhSach
            // 
            this.btnDanhSach.BackColor = System.Drawing.Color.SkyBlue;
            this.btnDanhSach.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDanhSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDanhSach.ForeColor = System.Drawing.Color.Maroon;
            this.btnDanhSach.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnDanhSach.ImageIndex = 2;
            this.btnDanhSach.ImageList = this.imageList1;
            this.btnDanhSach.Location = new System.Drawing.Point(241, 30);
            this.btnDanhSach.Name = "btnDanhSach";
            this.btnDanhSach.Size = new System.Drawing.Size(158, 56);
            this.btnDanhSach.TabIndex = 1;
            this.btnDanhSach.Text = "Danh Sách Chuyến Bay";
            this.btnDanhSach.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDanhSach.UseVisualStyleBackColor = false;
            this.btnDanhSach.Click += new System.EventHandler(this.btnDanhSach_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tSbtnDangXuat,
            this.tSbtnCaiDatTK});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(683, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // tSbtnDangXuat
            // 
            this.tSbtnDangXuat.Image = ((System.Drawing.Image)(resources.GetObject("tSbtnDangXuat.Image")));
            this.tSbtnDangXuat.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSbtnDangXuat.Name = "tSbtnDangXuat";
            this.tSbtnDangXuat.Size = new System.Drawing.Size(80, 22);
            this.tSbtnDangXuat.Text = "&Đăng xuất";
            this.tSbtnDangXuat.Click += new System.EventHandler(this.btnDangXuat_Click);
            // 
            // tSbtnCaiDatTK
            // 
            this.tSbtnCaiDatTK.Image = global::QuanLyBanVeChuyenBay.Properties.Resources.caidat;
            this.tSbtnCaiDatTK.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSbtnCaiDatTK.Name = "tSbtnCaiDatTK";
            this.tSbtnCaiDatTK.Size = new System.Drawing.Size(81, 22);
            this.tSbtnCaiDatTK.Text = "Cài đặt TK";
            this.tSbtnCaiDatTK.Click += new System.EventHandler(this.tSbtnCaiDatTK_Click);
            // 
            // imageList2
            // 
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList2.Images.SetKeyName(0, "logout.ico");
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(683, 486);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trang chủ";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnDanhSach;
        private System.Windows.Forms.Button btnDoanhThu;
        private System.Windows.Forms.Button btnDSKH;
        private System.Windows.Forms.Button btnNhanLich;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tSbtnDangXuat;
        private System.Windows.Forms.Button btnSuaDoiQD;
        private System.Windows.Forms.Button btnTraCuu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ImageList imageList2;
        private System.Windows.Forms.ToolStripButton tSbtnCaiDatTK;
    }
}