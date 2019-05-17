namespace QuanLyBanVeChuyenBay
{
    partial class frmNhanLich
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNhanLich));
            this.MaCB = new System.Windows.Forms.Label();
            this.txtMaCB = new System.Windows.Forms.TextBox();
            this.SanBayDi = new System.Windows.Forms.Label();
            this.btnSanBayDen = new System.Windows.Forms.Label();
            this.txtThGianBay = new System.Windows.Forms.TextBox();
            this.cmbSanBayDi = new System.Windows.Forms.ComboBox();
            this.cmbSanBayDen = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSoGheH1 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtSoGheH2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tSbtnDanhSachCB = new System.Windows.Forms.ToolStripDropDownButton();
            this.tSbtnDanhSachSB = new System.Windows.Forms.ToolStripButton();
            this.tSbtnHelp = new System.Windows.Forms.ToolStripButton();
            this.label2 = new System.Windows.Forms.Label();
            this.txtGiaVe = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.qLBanVeChuyenBayDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.qLBanVeChuyenBayDataSet = new QuanLyBanVeChuyenBay.QLBanVeChuyenBayDataSet();
            this.label3 = new System.Windows.Forms.Label();
            this.qLBanVeChuyenBayDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSanBayTG = new System.Windows.Forms.DataGridView();
            this.MaTrungGian = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbTenSBTrungGian = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.ColTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColNote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qLBanVeChuyenBayDataSetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLBanVeChuyenBayDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLBanVeChuyenBayDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSanBayTG)).BeginInit();
            this.SuspendLayout();
            // 
            // MaCB
            // 
            this.MaCB.AutoSize = true;
            this.MaCB.Location = new System.Drawing.Point(31, 74);
            this.MaCB.Name = "MaCB";
            this.MaCB.Size = new System.Drawing.Size(85, 13);
            this.MaCB.TabIndex = 1;
            this.MaCB.Text = "&Mã Chuyến Bay:";
            // 
            // txtMaCB
            // 
            this.txtMaCB.Location = new System.Drawing.Point(152, 74);
            this.txtMaCB.Name = "txtMaCB";
            this.txtMaCB.ReadOnly = true;
            this.txtMaCB.Size = new System.Drawing.Size(191, 20);
            this.txtMaCB.TabIndex = 2;
            // 
            // SanBayDi
            // 
            this.SanBayDi.AutoSize = true;
            this.SanBayDi.Location = new System.Drawing.Point(31, 123);
            this.SanBayDi.Name = "SanBayDi";
            this.SanBayDi.Size = new System.Drawing.Size(63, 13);
            this.SanBayDi.TabIndex = 8;
            this.SanBayDi.Text = "&Sân Bay Đi:";
            // 
            // btnSanBayDen
            // 
            this.btnSanBayDen.AutoSize = true;
            this.btnSanBayDen.Location = new System.Drawing.Point(31, 175);
            this.btnSanBayDen.Name = "btnSanBayDen";
            this.btnSanBayDen.Size = new System.Drawing.Size(73, 13);
            this.btnSanBayDen.TabIndex = 9;
            this.btnSanBayDen.Text = "Sân Bay Đến:";
            // 
            // txtThGianBay
            // 
            this.txtThGianBay.Location = new System.Drawing.Point(152, 220);
            this.txtThGianBay.Name = "txtThGianBay";
            this.txtThGianBay.Size = new System.Drawing.Size(191, 20);
            this.txtThGianBay.TabIndex = 12;
            // 
            // cmbSanBayDi
            // 
            this.cmbSanBayDi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSanBayDi.FormattingEnabled = true;
            this.cmbSanBayDi.Location = new System.Drawing.Point(152, 120);
            this.cmbSanBayDi.Name = "cmbSanBayDi";
            this.cmbSanBayDi.Size = new System.Drawing.Size(191, 21);
            this.cmbSanBayDi.TabIndex = 13;
            // 
            // cmbSanBayDen
            // 
            this.cmbSanBayDen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSanBayDen.FormattingEnabled = true;
            this.cmbSanBayDen.Location = new System.Drawing.Point(152, 172);
            this.cmbSanBayDen.Name = "cmbSanBayDen";
            this.cmbSanBayDen.Size = new System.Drawing.Size(191, 21);
            this.cmbSanBayDen.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(385, 227);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Ngày Bay(D/M/Y):";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(31, 227);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Tổng Thời Gian Bay:";
            // 
            // txtSoGheH1
            // 
            this.txtSoGheH1.Location = new System.Drawing.Point(488, 71);
            this.txtSoGheH1.Name = "txtSoGheH1";
            this.txtSoGheH1.Size = new System.Drawing.Size(191, 20);
            this.txtSoGheH1.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(385, 74);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "SL Ghế Hạng 1:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(385, 128);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "SL Ghế Hạng 2:";
            // 
            // txtSoGheH2
            // 
            this.txtSoGheH2.Location = new System.Drawing.Point(488, 120);
            this.txtSoGheH2.Name = "txtSoGheH2";
            this.txtSoGheH2.Size = new System.Drawing.Size(191, 20);
            this.txtSoGheH2.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(306, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "NHẬN LỊCH CHUYẾN BAY";
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(238, 428);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 41);
            this.btnThem.TabIndex = 25;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(388, 428);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 41);
            this.btnThoat.TabIndex = 26;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tSbtnDanhSachCB,
            this.tSbtnDanhSachSB,
            this.tSbtnHelp});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(723, 25);
            this.toolStrip1.TabIndex = 28;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tSbtnDanhSachCB
            // 
            this.tSbtnDanhSachCB.Image = ((System.Drawing.Image)(resources.GetObject("tSbtnDanhSachCB.Image")));
            this.tSbtnDanhSachCB.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSbtnDanhSachCB.Name = "tSbtnDanhSachCB";
            this.tSbtnDanhSachCB.Size = new System.Drawing.Size(83, 22);
            this.tSbtnDanhSachCB.Text = "&DS C.Bay";
            this.tSbtnDanhSachCB.Click += new System.EventHandler(this.tSbtnDanhSachCB_Click);
            // 
            // tSbtnDanhSachSB
            // 
            this.tSbtnDanhSachSB.Image = ((System.Drawing.Image)(resources.GetObject("tSbtnDanhSachSB.Image")));
            this.tSbtnDanhSachSB.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSbtnDanhSachSB.Name = "tSbtnDanhSachSB";
            this.tSbtnDanhSachSB.Size = new System.Drawing.Size(114, 22);
            this.tSbtnDanhSachSB.Text = "&Danh Sách S.Bay";
            this.tSbtnDanhSachSB.Click += new System.EventHandler(this.tSbtnDanhSachSB_Click);
            // 
            // tSbtnHelp
            // 
            this.tSbtnHelp.Image = ((System.Drawing.Image)(resources.GetObject("tSbtnHelp.Image")));
            this.tSbtnHelp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSbtnHelp.Name = "tSbtnHelp";
            this.tSbtnHelp.Size = new System.Drawing.Size(52, 22);
            this.tSbtnHelp.Text = "&Help";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(385, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "Giá Vé:";
            // 
            // txtGiaVe
            // 
            this.txtGiaVe.Location = new System.Drawing.Point(488, 173);
            this.txtGiaVe.Name = "txtGiaVe";
            this.txtGiaVe.Size = new System.Drawing.Size(191, 20);
            this.txtGiaVe.TabIndex = 30;
            // 
            // qLBanVeChuyenBayDataSetBindingSource1
            // 
            this.qLBanVeChuyenBayDataSetBindingSource1.DataSource = this.qLBanVeChuyenBayDataSet;
            this.qLBanVeChuyenBayDataSetBindingSource1.Position = 0;
            // 
            // qLBanVeChuyenBayDataSet
            // 
            this.qLBanVeChuyenBayDataSet.DataSetName = "QLBanVeChuyenBayDataSet";
            this.qLBanVeChuyenBayDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 262);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 13);
            this.label3.TabIndex = 47;
            this.label3.Text = "Thông tin sân bay trung gian:\r\n";
            // 
            // qLBanVeChuyenBayDataSetBindingSource
            // 
            this.qLBanVeChuyenBayDataSetBindingSource.DataSource = this.qLBanVeChuyenBayDataSet;
            this.qLBanVeChuyenBayDataSetBindingSource.Position = 0;
            // 
            // dataSanBayTG
            // 
            this.dataSanBayTG.AutoGenerateColumns = false;
            this.dataSanBayTG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataSanBayTG.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaTrungGian,
            this.cmbTenSBTrungGian,
            this.ColTime,
            this.ColNote});
            this.dataSanBayTG.DataSource = this.qLBanVeChuyenBayDataSet;
            this.dataSanBayTG.Location = new System.Drawing.Point(34, 290);
            this.dataSanBayTG.Name = "dataSanBayTG";
            this.dataSanBayTG.Size = new System.Drawing.Size(645, 124);
            this.dataSanBayTG.TabIndex = 46;
            // 
            // MaTrungGian
            // 
            this.MaTrungGian.HeaderText = "Mã Sân Bay Trung Gian";
            this.MaTrungGian.Name = "MaTrungGian";
            // 
            // cmbTenSBTrungGian
            // 
            this.cmbTenSBTrungGian.HeaderText = "Tên sân bay trung gian";
            this.cmbTenSBTrungGian.Name = "cmbTenSBTrungGian";
            this.cmbTenSBTrungGian.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cmbTenSBTrungGian.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.cmbTenSBTrungGian.Width = 150;
            // 
            // ColTime
            // 
            this.ColTime.HeaderText = "Thời gian dừng";
            this.ColTime.Name = "ColTime";
            this.ColTime.Width = 150;
            // 
            // ColNote
            // 
            this.ColNote.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColNote.HeaderText = "Ghi chú";
            this.ColNote.Name = "ColNote";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd/MM/yyyy  hh:mm tt";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(487, 221);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(191, 20);
            this.dateTimePicker1.TabIndex = 48;
            // 
            // frmNhanLich
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 481);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataSanBayTG);
            this.Controls.Add(this.txtGiaVe);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSoGheH2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtSoGheH1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbSanBayDen);
            this.Controls.Add(this.cmbSanBayDi);
            this.Controls.Add(this.txtThGianBay);
            this.Controls.Add(this.btnSanBayDen);
            this.Controls.Add(this.SanBayDi);
            this.Controls.Add(this.txtMaCB);
            this.Controls.Add(this.MaCB);
            this.Name = "frmNhanLich";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nhận Lịch Chuyến Bay";
            this.Load += new System.EventHandler(this.frmNhanLich_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qLBanVeChuyenBayDataSetBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLBanVeChuyenBayDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLBanVeChuyenBayDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSanBayTG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label MaCB;
        private System.Windows.Forms.TextBox txtMaCB;
        private System.Windows.Forms.Label SanBayDi;
        private System.Windows.Forms.Label btnSanBayDen;
        private System.Windows.Forms.TextBox txtThGianBay;
        private System.Windows.Forms.ComboBox cmbSanBayDi;
        private System.Windows.Forms.ComboBox cmbSanBayDen;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSoGheH1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtSoGheH2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tSbtnHelp;
        private System.Windows.Forms.ToolStripDropDownButton tSbtnDanhSachCB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtGiaVe;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripButton tSbtnDanhSachSB;
        private QLBanVeChuyenBayDataSet qLBanVeChuyenBayDataSet;
        private System.Windows.Forms.BindingSource qLBanVeChuyenBayDataSetBindingSource;
        private System.Windows.Forms.BindingSource qLBanVeChuyenBayDataSetBindingSource1;
        private System.Windows.Forms.DataGridView dataSanBayTG;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaTrungGian;
        private System.Windows.Forms.DataGridViewComboBoxColumn cmbTenSBTrungGian;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNote;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}