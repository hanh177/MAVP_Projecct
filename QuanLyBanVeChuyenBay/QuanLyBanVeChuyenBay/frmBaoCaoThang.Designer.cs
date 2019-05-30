namespace QuanLyBanVeChuyenBay
{
    partial class frmBaoCaoThang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBaoCaoThang));
            this.dataDoanhThuThang = new System.Windows.Forms.DataGridView();
            this.ColMaCB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColSoVe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDoanhThu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTiLe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnXem = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.cmbThang = new System.Windows.Forms.ComboBox();
            this.cmbNam = new System.Windows.Forms.ComboBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnBaoCaoNam = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataDoanhThuThang)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataDoanhThuThang
            // 
            this.dataDoanhThuThang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataDoanhThuThang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColMaCB,
            this.ColSoVe,
            this.ColDoanhThu,
            this.ColTiLe});
            this.dataDoanhThuThang.Location = new System.Drawing.Point(12, 84);
            this.dataDoanhThuThang.Name = "dataDoanhThuThang";
            this.dataDoanhThuThang.Size = new System.Drawing.Size(603, 287);
            this.dataDoanhThuThang.TabIndex = 0;
            // 
            // ColMaCB
            // 
            this.ColMaCB.HeaderText = "Mã CB";
            this.ColMaCB.Name = "ColMaCB";
            // 
            // ColSoVe
            // 
            this.ColSoVe.HeaderText = "Số vé";
            this.ColSoVe.Name = "ColSoVe";
            // 
            // ColDoanhThu
            // 
            this.ColDoanhThu.HeaderText = "Doanh thu";
            this.ColDoanhThu.Name = "ColDoanhThu";
            // 
            // ColTiLe
            // 
            this.ColTiLe.HeaderText = "Tỉ lệ";
            this.ColTiLe.Name = "ColTiLe";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Chọn tháng:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(237, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Chọn năm:";
            // 
            // btnXem
            // 
            this.btnXem.Location = new System.Drawing.Point(409, 30);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(75, 23);
            this.btnXem.TabIndex = 5;
            this.btnXem.Text = "Xem";
            this.btnXem.UseVisualStyleBackColor = true;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(513, 384);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 6;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // cmbThang
            // 
            this.cmbThang.FormattingEnabled = true;
            this.cmbThang.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cmbThang.Location = new System.Drawing.Point(140, 29);
            this.cmbThang.Name = "cmbThang";
            this.cmbThang.Size = new System.Drawing.Size(80, 21);
            this.cmbThang.TabIndex = 7;
            // 
            // cmbNam
            // 
            this.cmbNam.FormattingEnabled = true;
            this.cmbNam.Location = new System.Drawing.Point(302, 30);
            this.cmbNam.Name = "cmbNam";
            this.cmbNam.Size = new System.Drawing.Size(72, 21);
            this.cmbNam.TabIndex = 8;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnBaoCaoNam});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(632, 25);
            this.toolStrip1.TabIndex = 9;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnBaoCaoNam
            // 
            this.btnBaoCaoNam.Image = ((System.Drawing.Image)(resources.GetObject("btnBaoCaoNam.Image")));
            this.btnBaoCaoNam.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnBaoCaoNam.Name = "btnBaoCaoNam";
            this.btnBaoCaoNam.Size = new System.Drawing.Size(100, 22);
            this.btnBaoCaoNam.Text = "&Báo Cáo Năm";
            this.btnBaoCaoNam.Click += new System.EventHandler(this.btnBaoCaoNam_Click);
            // 
            // frmBaoCaoThang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 419);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.cmbNam);
            this.Controls.Add(this.cmbThang);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXem);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataDoanhThuThang);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmBaoCaoThang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Báo Cáo Doanh Thu Tháng";
            this.Load += new System.EventHandler(this.frmBaoCaoThang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataDoanhThuThang)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataDoanhThuThang;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColMaCB;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColSoVe;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDoanhThu;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTiLe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnXem;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.ComboBox cmbThang;
        private System.Windows.Forms.ComboBox cmbNam;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnBaoCaoNam;
    }
}