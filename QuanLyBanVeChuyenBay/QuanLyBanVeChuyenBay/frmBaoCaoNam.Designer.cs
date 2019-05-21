namespace QuanLyBanVeChuyenBay
{
    partial class frmBaoCaoNam
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
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnXem = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dataDoanhThuNam = new System.Windows.Forms.DataGridView();
            this.ColThang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColSoCB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDoanhThu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTiLe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbNam = new System.Windows.Forms.ComboBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            ((System.ComponentModel.ISupportInitialize)(this.dataDoanhThuNam)).BeginInit();
            this.SuspendLayout();
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(531, 384);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 13;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnXem
            // 
            this.btnXem.Location = new System.Drawing.Point(351, 25);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(75, 23);
            this.btnXem.TabIndex = 12;
            this.btnXem.Text = "Xem";
            this.btnXem.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(148, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Chọn năm:";
            // 
            // dataDoanhThuNam
            // 
            this.dataDoanhThuNam.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataDoanhThuNam.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColThang,
            this.ColSoCB,
            this.ColDoanhThu,
            this.ColTiLe});
            this.dataDoanhThuNam.Location = new System.Drawing.Point(30, 84);
            this.dataDoanhThuNam.Name = "dataDoanhThuNam";
            this.dataDoanhThuNam.Size = new System.Drawing.Size(603, 287);
            this.dataDoanhThuNam.TabIndex = 7;
            // 
            // ColThang
            // 
            this.ColThang.HeaderText = "Tháng";
            this.ColThang.Name = "ColThang";
            // 
            // ColSoCB
            // 
            this.ColSoCB.HeaderText = "Số chuyến bay";
            this.ColSoCB.Name = "ColSoCB";
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
            // cmbNam
            // 
            this.cmbNam.FormattingEnabled = true;
            this.cmbNam.Location = new System.Drawing.Point(213, 25);
            this.cmbNam.Name = "cmbNam";
            this.cmbNam.Size = new System.Drawing.Size(121, 21);
            this.cmbNam.TabIndex = 14;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(663, 25);
            this.toolStrip1.TabIndex = 15;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // frmBaoCaoNam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 414);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.cmbNam);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXem);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataDoanhThuNam);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmBaoCaoNam";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Báo Cáo Doanh Thu Năm";
            this.Load += new System.EventHandler(this.frmBaoCaoNam_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataDoanhThuNam)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnXem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataDoanhThuNam;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColThang;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColSoCB;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDoanhThu;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTiLe;
        private System.Windows.Forms.ComboBox cmbNam;
        private System.Windows.Forms.ToolStrip toolStrip1;
    }
}