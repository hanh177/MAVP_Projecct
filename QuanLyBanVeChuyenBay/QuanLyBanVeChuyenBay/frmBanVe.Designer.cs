namespace QuanLyBanVeChuyenBay
{
    partial class frmBanVe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBanVe));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtMaCB = new System.Windows.Forms.TextBox();
            this.cmbHangVe = new System.Windows.Forms.ComboBox();
            this.txtGiaVe = new System.Windows.Forms.TextBox();
            this.txtMaVe = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtMaKH = new System.Windows.Forms.TextBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.txtCMND = new System.Windows.Forms.TextBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnDatVe = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnDanhSachCB = new System.Windows.Forms.ToolStripDropDownButton();
            this.tSbtnHelp = new System.Windows.Forms.ToolStripButton();
            this.tSbtnPhieuDatCho = new System.Windows.Forms.ToolStripButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtMaCB);
            this.groupBox1.Controls.Add(this.cmbHangVe);
            this.groupBox1.Controls.Add(this.txtGiaVe);
            this.groupBox1.Controls.Add(this.txtMaVe);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(285, 277);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Vé";
            // 
            // txtMaCB
            // 
            this.txtMaCB.Location = new System.Drawing.Point(149, 82);
            this.txtMaCB.Name = "txtMaCB";
            this.txtMaCB.ReadOnly = true;
            this.txtMaCB.Size = new System.Drawing.Size(100, 20);
            this.txtMaCB.TabIndex = 9;
            // 
            // cmbHangVe
            // 
            this.cmbHangVe.FormattingEnabled = true;
            this.cmbHangVe.Items.AddRange(new object[] {
            "1",
            "2"});
            this.cmbHangVe.Location = new System.Drawing.Point(149, 129);
            this.cmbHangVe.Name = "cmbHangVe";
            this.cmbHangVe.Size = new System.Drawing.Size(100, 21);
            this.cmbHangVe.TabIndex = 8;
            this.cmbHangVe.SelectedIndexChanged += new System.EventHandler(this.cmbHangVe_SelectedIndexChanged);
            // 
            // txtGiaVe
            // 
            this.txtGiaVe.Location = new System.Drawing.Point(149, 183);
            this.txtGiaVe.Name = "txtGiaVe";
            this.txtGiaVe.ReadOnly = true;
            this.txtGiaVe.Size = new System.Drawing.Size(100, 20);
            this.txtGiaVe.TabIndex = 5;
            // 
            // txtMaVe
            // 
            this.txtMaVe.Location = new System.Drawing.Point(149, 37);
            this.txtMaVe.Name = "txtMaVe";
            this.txtMaVe.ReadOnly = true;
            this.txtMaVe.Size = new System.Drawing.Size(100, 20);
            this.txtMaVe.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Mã Chuyến Bay:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Hạng Vé:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Giá Vé:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Vé:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtMaKH);
            this.groupBox2.Controls.Add(this.txtHoTen);
            this.groupBox2.Controls.Add(this.txtCMND);
            this.groupBox2.Controls.Add(this.txtSDT);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(303, 45);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(258, 277);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Hành Khách";
            // 
            // txtMaKH
            // 
            this.txtMaKH.Location = new System.Drawing.Point(122, 37);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.ReadOnly = true;
            this.txtMaKH.Size = new System.Drawing.Size(100, 20);
            this.txtMaKH.TabIndex = 8;
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(122, 85);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(100, 20);
            this.txtHoTen.TabIndex = 7;
            this.txtHoTen.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // txtCMND
            // 
            this.txtCMND.Location = new System.Drawing.Point(122, 130);
            this.txtCMND.Name = "txtCMND";
            this.txtCMND.Size = new System.Drawing.Size(100, 20);
            this.txtCMND.TabIndex = 6;
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(122, 176);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(100, 20);
            this.txtSDT.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(28, 44);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Mã Khách Hàng:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 138);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "CMND:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 92);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Họ Tên:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "SĐT:";
            // 
            // btnDatVe
            // 
            this.btnDatVe.Location = new System.Drawing.Point(241, 353);
            this.btnDatVe.Name = "btnDatVe";
            this.btnDatVe.Size = new System.Drawing.Size(83, 41);
            this.btnDatVe.TabIndex = 2;
            this.btnDatVe.Text = "Đặt Vé";
            this.btnDatVe.UseVisualStyleBackColor = true;
            this.btnDatVe.Click += new System.EventHandler(this.btnDatVe_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnDanhSachCB,
            this.tSbtnHelp,
            this.tSbtnPhieuDatCho});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(594, 25);
            this.toolStrip1.TabIndex = 29;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnDanhSachCB
            // 
            this.btnDanhSachCB.Image = ((System.Drawing.Image)(resources.GetObject("btnDanhSachCB.Image")));
            this.btnDanhSachCB.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDanhSachCB.Name = "btnDanhSachCB";
            this.btnDanhSachCB.Size = new System.Drawing.Size(83, 22);
            this.btnDanhSachCB.Text = "&DS C.Bay";
            this.btnDanhSachCB.Click += new System.EventHandler(this.tSbtnDanhSachCB_Click);
            // 
            // tSbtnHelp
            // 
            this.tSbtnHelp.Image = ((System.Drawing.Image)(resources.GetObject("tSbtnHelp.Image")));
            this.tSbtnHelp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSbtnHelp.Name = "tSbtnHelp";
            this.tSbtnHelp.Size = new System.Drawing.Size(52, 22);
            this.tSbtnHelp.Text = "&Help";
            // 
            // tSbtnPhieuDatCho
            // 
            this.tSbtnPhieuDatCho.Image = ((System.Drawing.Image)(resources.GetObject("tSbtnPhieuDatCho.Image")));
            this.tSbtnPhieuDatCho.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSbtnPhieuDatCho.Name = "tSbtnPhieuDatCho";
            this.tSbtnPhieuDatCho.Size = new System.Drawing.Size(103, 22);
            this.tSbtnPhieuDatCho.Text = "&Phiếu Đặt Chỗ";
            this.tSbtnPhieuDatCho.Click += new System.EventHandler(this.tSbtnPhieuDatCho_Click);
            // 
            // frmBanVe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 423);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.btnDatVe);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmBanVe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bán Vé";
            this.Load += new System.EventHandler(this.frmBanVe_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtGiaVe;
        private System.Windows.Forms.TextBox txtMaVe;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtMaKH;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.TextBox txtCMND;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnDatVe;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton btnDanhSachCB;
        private System.Windows.Forms.ToolStripButton tSbtnHelp;
        private System.Windows.Forms.ToolStripButton tSbtnPhieuDatCho;
        private System.Windows.Forms.ComboBox cmbHangVe;
        private System.Windows.Forms.TextBox txtMaCB;
    }
}