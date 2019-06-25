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
            this.label1 = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tSbtnDanhSachCB = new System.Windows.Forms.ToolStripDropDownButton();
            this.tSbtnDanhSachSB = new System.Windows.Forms.ToolStripButton();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.qLBanVeChuyenBayDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.qLBanVeChuyenBayDataSet = new QuanLyBanVeChuyenBay.QLBanVeChuyenBayDataSet();
            this.label3 = new System.Windows.Forms.Label();
            this.qLBanVeChuyenBayDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSanBayTG = new System.Windows.Forms.DataGridView();
            this.colMaTrungGian = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenSBTrungGian = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTGDung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColGhiChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cmbTenSBTG = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.txtTGDung = new System.Windows.Forms.TextBox();
            this.txtMaSBTG = new System.Windows.Forms.TextBox();
            this.btnThemTG = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtGiaVe = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSoGheH2 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSoGheH1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbSanBayDen = new System.Windows.Forms.ComboBox();
            this.cmbSanBayDi = new System.Windows.Forms.ComboBox();
            this.txtThGianBay = new System.Windows.Forms.TextBox();
            this.btnSanBayDen = new System.Windows.Forms.Label();
            this.SanBayDi = new System.Windows.Forms.Label();
            this.txtMaCB = new System.Windows.Forms.TextBox();
            this.MaCB = new System.Windows.Forms.Label();
            this.btnXoaSBTG = new System.Windows.Forms.Button();
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qLBanVeChuyenBayDataSetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLBanVeChuyenBayDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLBanVeChuyenBayDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSanBayTG)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Harlow Solid Italic", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(294, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(310, 24);
            this.label1.TabIndex = 24;
            this.label1.Text = "NHẬN LỊCH CHUYẾN BAY";
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.Transparent;
            this.btnThem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnThem.BackgroundImage")));
            this.btnThem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ImageIndex = 2;
            this.btnThem.ImageList = this.imageList2;
            this.btnThem.Location = new System.Drawing.Point(60, 369);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(137, 65);
            this.btnThem.TabIndex = 25;
            this.btnThem.Text = "Thêm Chuyến Bay";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnThoat.BackgroundImage")));
            this.btnThoat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ImageIndex = 1;
            this.btnThoat.ImageList = this.imageList2;
            this.btnThoat.Location = new System.Drawing.Point(60, 460);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(137, 65);
            this.btnThoat.TabIndex = 26;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.RoyalBlue;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tSbtnDanhSachCB,
            this.tSbtnDanhSachSB});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(992, 25);
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
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(267, 323);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(193, 15);
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
            this.dataSanBayTG.AllowUserToAddRows = false;
            this.dataSanBayTG.BackgroundColor = System.Drawing.Color.CornflowerBlue;
            this.dataSanBayTG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataSanBayTG.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaTrungGian,
            this.colTenSBTrungGian,
            this.ColTGDung,
            this.ColGhiChu});
            this.dataSanBayTG.Location = new System.Drawing.Point(270, 349);
            this.dataSanBayTG.Name = "dataSanBayTG";
            this.dataSanBayTG.ReadOnly = true;
            this.dataSanBayTG.Size = new System.Drawing.Size(709, 164);
            this.dataSanBayTG.TabIndex = 46;
            // 
            // colMaTrungGian
            // 
            this.colMaTrungGian.HeaderText = "Mã Sân Bay Trung Gian";
            this.colMaTrungGian.Name = "colMaTrungGian";
            this.colMaTrungGian.ReadOnly = true;
            // 
            // colTenSBTrungGian
            // 
            this.colTenSBTrungGian.HeaderText = "Tên sân bay trung gian";
            this.colTenSBTrungGian.Name = "colTenSBTrungGian";
            this.colTenSBTrungGian.ReadOnly = true;
            this.colTenSBTrungGian.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colTenSBTrungGian.Width = 150;
            // 
            // ColTGDung
            // 
            this.ColTGDung.HeaderText = "Thời gian dừng";
            this.ColTGDung.Name = "ColTGDung";
            this.ColTGDung.ReadOnly = true;
            this.ColTGDung.Width = 150;
            // 
            // ColGhiChu
            // 
            this.ColGhiChu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColGhiChu.HeaderText = "Ghi chú";
            this.ColGhiChu.Name = "ColGhiChu";
            this.ColGhiChu.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.cmbTenSBTG);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtGhiChu);
            this.groupBox1.Controls.Add(this.txtTGDung);
            this.groupBox1.Controls.Add(this.txtMaSBTG);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(663, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(317, 240);
            this.groupBox1.TabIndex = 49;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sân Bay Trung Gian";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label12.Location = new System.Drawing.Point(20, 25);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(296, 32);
            this.label12.TabIndex = 8;
            this.label12.Text = "*Lưu ý: Số sân bay trung gian không được \r\nvượt quá qui đinh";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // cmbTenSBTG
            // 
            this.cmbTenSBTG.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTenSBTG.FormattingEnabled = true;
            this.cmbTenSBTG.Location = new System.Drawing.Point(123, 115);
            this.cmbTenSBTG.Name = "cmbTenSBTG";
            this.cmbTenSBTG.Size = new System.Drawing.Size(169, 23);
            this.cmbTenSBTG.TabIndex = 7;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(4, 121);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(113, 15);
            this.label11.TabIndex = 6;
            this.label11.Text = "Tên Sân Bay TG:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(9, 168);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(111, 15);
            this.label10.TabIndex = 5;
            this.label10.Text = "Thời Gian Dừng:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(55, 219);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ghi Chú:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Mã Sân Bay TG:";
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Location = new System.Drawing.Point(123, 209);
            this.txtGhiChu.Multiline = true;
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(169, 25);
            this.txtGhiChu.TabIndex = 2;
            // 
            // txtTGDung
            // 
            this.txtTGDung.Location = new System.Drawing.Point(123, 156);
            this.txtTGDung.Multiline = true;
            this.txtTGDung.Name = "txtTGDung";
            this.txtTGDung.Size = new System.Drawing.Size(169, 25);
            this.txtTGDung.TabIndex = 1;
            this.txtTGDung.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.txtTGDung.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTGDung_KeyDown);
            this.txtTGDung.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTGDung_KeyPress);
            // 
            // txtMaSBTG
            // 
            this.txtMaSBTG.Location = new System.Drawing.Point(123, 60);
            this.txtMaSBTG.Multiline = true;
            this.txtMaSBTG.Name = "txtMaSBTG";
            this.txtMaSBTG.ReadOnly = true;
            this.txtMaSBTG.Size = new System.Drawing.Size(169, 25);
            this.txtMaSBTG.TabIndex = 0;
            this.txtMaSBTG.Click += new System.EventHandler(this.txtMaSBTG_Click);
            this.txtMaSBTG.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txtMaSBTG.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMaSBTG_KeyPress);
            // 
            // btnThemTG
            // 
            this.btnThemTG.BackColor = System.Drawing.Color.Transparent;
            this.btnThemTG.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnThemTG.BackgroundImage")));
            this.btnThemTG.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnThemTG.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemTG.ForeColor = System.Drawing.Color.Black;
            this.btnThemTG.ImageIndex = 0;
            this.btnThemTG.ImageList = this.imageList1;
            this.btnThemTG.Location = new System.Drawing.Point(735, 305);
            this.btnThemTG.Name = "btnThemTG";
            this.btnThemTG.Size = new System.Drawing.Size(75, 38);
            this.btnThemTG.TabIndex = 50;
            this.btnThemTG.Text = "Thêm SBTG";
            this.btnThemTG.UseVisualStyleBackColor = false;
            this.btnThemTG.Click += new System.EventHandler(this.btnThemTG_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Them.ico");
            this.imageList1.Images.SetKeyName(1, "Xoa.ico");
            this.imageList1.Images.SetKeyName(2, "Them2.ico");
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.dateTimePicker1);
            this.groupBox2.Controls.Add(this.txtGiaVe);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtSoGheH2);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtSoGheH1);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.cmbSanBayDen);
            this.groupBox2.Controls.Add(this.cmbSanBayDi);
            this.groupBox2.Controls.Add(this.txtThGianBay);
            this.groupBox2.Controls.Add(this.btnSanBayDen);
            this.groupBox2.Controls.Add(this.SanBayDi);
            this.groupBox2.Controls.Add(this.txtMaCB);
            this.groupBox2.Controls.Add(this.MaCB);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(24, 52);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(633, 240);
            this.groupBox2.TabIndex = 51;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin chuyến bay";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(295, 205);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(39, 15);
            this.label13.TabIndex = 65;
            this.label13.Text = "(phút)";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.CustomFormat = "dd/MM/yyyy  hh:mm tt";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(455, 199);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(157, 21);
            this.dateTimePicker1.TabIndex = 64;
            // 
            // txtGiaVe
            // 
            this.txtGiaVe.Location = new System.Drawing.Point(456, 151);
            this.txtGiaVe.Multiline = true;
            this.txtGiaVe.Name = "txtGiaVe";
            this.txtGiaVe.Size = new System.Drawing.Size(156, 25);
            this.txtGiaVe.TabIndex = 63;
            this.txtGiaVe.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtGiaVe_KeyDown);
            this.txtGiaVe.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGiaVe_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(394, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 15);
            this.label2.TabIndex = 62;
            this.label2.Text = "Giá Vé:";
            // 
            // txtSoGheH2
            // 
            this.txtSoGheH2.Location = new System.Drawing.Point(456, 98);
            this.txtSoGheH2.Multiline = true;
            this.txtSoGheH2.Name = "txtSoGheH2";
            this.txtSoGheH2.Size = new System.Drawing.Size(156, 25);
            this.txtSoGheH2.TabIndex = 61;
            this.txtSoGheH2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSoGheH2_KeyDown);
            this.txtSoGheH2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoGheH2_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(339, 106);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(108, 15);
            this.label9.TabIndex = 60;
            this.label9.Text = "SL Ghế Hạng 2:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(339, 52);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 15);
            this.label8.TabIndex = 59;
            this.label8.Text = "SL Ghế Hạng 1:";
            // 
            // txtSoGheH1
            // 
            this.txtSoGheH1.Location = new System.Drawing.Point(456, 49);
            this.txtSoGheH1.Multiline = true;
            this.txtSoGheH1.Name = "txtSoGheH1";
            this.txtSoGheH1.Size = new System.Drawing.Size(156, 25);
            this.txtSoGheH1.TabIndex = 58;
            this.txtSoGheH1.TextChanged += new System.EventHandler(this.txtSoGheH1_TextChanged);
            this.txtSoGheH1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSoGheH1_KeyDown);
            this.txtSoGheH1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoGheH1_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(-3, 205);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 13);
            this.label7.TabIndex = 57;
            this.label7.Text = "Tổng Thời Gian Bay:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(331, 205);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 15);
            this.label6.TabIndex = 56;
            this.label6.Text = "Ngày Bay(D/M/Y):";
            // 
            // cmbSanBayDen
            // 
            this.cmbSanBayDen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSanBayDen.FormattingEnabled = true;
            this.cmbSanBayDen.Location = new System.Drawing.Point(120, 150);
            this.cmbSanBayDen.Name = "cmbSanBayDen";
            this.cmbSanBayDen.Size = new System.Drawing.Size(169, 23);
            this.cmbSanBayDen.TabIndex = 55;
            // 
            // cmbSanBayDi
            // 
            this.cmbSanBayDi.BackColor = System.Drawing.SystemColors.Window;
            this.cmbSanBayDi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSanBayDi.FormattingEnabled = true;
            this.cmbSanBayDi.Location = new System.Drawing.Point(120, 98);
            this.cmbSanBayDi.Name = "cmbSanBayDi";
            this.cmbSanBayDi.Size = new System.Drawing.Size(169, 23);
            this.cmbSanBayDi.TabIndex = 54;
            // 
            // txtThGianBay
            // 
            this.txtThGianBay.Location = new System.Drawing.Point(120, 195);
            this.txtThGianBay.Multiline = true;
            this.txtThGianBay.Name = "txtThGianBay";
            this.txtThGianBay.Size = new System.Drawing.Size(169, 25);
            this.txtThGianBay.TabIndex = 53;
            this.txtThGianBay.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtThGianBay_KeyDown);
            this.txtThGianBay.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtThGianBay_KeyPress);
            // 
            // btnSanBayDen
            // 
            this.btnSanBayDen.AutoSize = true;
            this.btnSanBayDen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSanBayDen.Location = new System.Drawing.Point(18, 152);
            this.btnSanBayDen.Name = "btnSanBayDen";
            this.btnSanBayDen.Size = new System.Drawing.Size(93, 15);
            this.btnSanBayDen.TabIndex = 52;
            this.btnSanBayDen.Text = "Sân Bay Đến:";
            // 
            // SanBayDi
            // 
            this.SanBayDi.AutoSize = true;
            this.SanBayDi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SanBayDi.Location = new System.Drawing.Point(30, 106);
            this.SanBayDi.Name = "SanBayDi";
            this.SanBayDi.Size = new System.Drawing.Size(81, 15);
            this.SanBayDi.TabIndex = 51;
            this.SanBayDi.Text = "&Sân Bay Đi:";
            // 
            // txtMaCB
            // 
            this.txtMaCB.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtMaCB.Location = new System.Drawing.Point(120, 51);
            this.txtMaCB.Multiline = true;
            this.txtMaCB.Name = "txtMaCB";
            this.txtMaCB.ReadOnly = true;
            this.txtMaCB.Size = new System.Drawing.Size(169, 25);
            this.txtMaCB.TabIndex = 50;
            this.txtMaCB.TextChanged += new System.EventHandler(this.txtMaCB_TextChanged);
            // 
            // MaCB
            // 
            this.MaCB.AutoSize = true;
            this.MaCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaCB.Location = new System.Drawing.Point(6, 52);
            this.MaCB.Name = "MaCB";
            this.MaCB.Size = new System.Drawing.Size(109, 15);
            this.MaCB.TabIndex = 49;
            this.MaCB.Text = "&Mã Chuyến Bay:";
            // 
            // btnXoaSBTG
            // 
            this.btnXoaSBTG.BackColor = System.Drawing.Color.Transparent;
            this.btnXoaSBTG.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnXoaSBTG.BackgroundImage")));
            this.btnXoaSBTG.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnXoaSBTG.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaSBTG.ImageIndex = 1;
            this.btnXoaSBTG.ImageList = this.imageList1;
            this.btnXoaSBTG.Location = new System.Drawing.Point(904, 305);
            this.btnXoaSBTG.Name = "btnXoaSBTG";
            this.btnXoaSBTG.Size = new System.Drawing.Size(75, 38);
            this.btnXoaSBTG.TabIndex = 52;
            this.btnXoaSBTG.Text = "Xóa SBTG";
            this.btnXoaSBTG.UseVisualStyleBackColor = false;
            this.btnXoaSBTG.Click += new System.EventHandler(this.btnXoaSBTG_Click);
            // 
            // imageList2
            // 
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList2.Images.SetKeyName(0, "Them2.ico");
            this.imageList2.Images.SetKeyName(1, "Thoat.ico");
            this.imageList2.Images.SetKeyName(2, "Them.ico");
            // 
            // frmNhanLich
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(992, 528);
            this.Controls.Add(this.btnXoaSBTG);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnThemTG);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataSanBayTG);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
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
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton tSbtnDanhSachCB;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripButton tSbtnDanhSachSB;
        private QLBanVeChuyenBayDataSet qLBanVeChuyenBayDataSet;
        private System.Windows.Forms.BindingSource qLBanVeChuyenBayDataSetBindingSource;
        private System.Windows.Forms.BindingSource qLBanVeChuyenBayDataSetBindingSource1;
        private System.Windows.Forms.DataGridView dataSanBayTG;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.TextBox txtTGDung;
        private System.Windows.Forms.TextBox txtMaSBTG;
        private System.Windows.Forms.ComboBox cmbTenSBTG;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaTrungGian;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenSBTrungGian;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTGDung;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColGhiChu;
        private System.Windows.Forms.Button btnThemTG;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txtGiaVe;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSoGheH2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtSoGheH1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbSanBayDen;
        private System.Windows.Forms.ComboBox cmbSanBayDi;
        private System.Windows.Forms.TextBox txtThGianBay;
        private System.Windows.Forms.Label btnSanBayDen;
        private System.Windows.Forms.Label SanBayDi;
        private System.Windows.Forms.TextBox txtMaCB;
        private System.Windows.Forms.Label MaCB;
        private System.Windows.Forms.Button btnXoaSBTG;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ImageList imageList2;
    }
}