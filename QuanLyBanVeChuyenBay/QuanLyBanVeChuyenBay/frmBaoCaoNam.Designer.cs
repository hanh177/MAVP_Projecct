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
            this.cmbNam = new System.Windows.Forms.ComboBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.txtTongDoanhThu = new System.Windows.Forms.TextBox();
            this.txtTiLe = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ColThang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColSoCB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDoanhThu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTiLe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTieuDe = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataDoanhThuNam)).BeginInit();
            this.SuspendLayout();
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(558, 408);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 38);
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
            this.btnXem.Click += new System.EventHandler(this.btnXem_Click);
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
            this.dataDoanhThuNam.Location = new System.Drawing.Point(30, 102);
            this.dataDoanhThuNam.Name = "dataDoanhThuNam";
            this.dataDoanhThuNam.ReadOnly = true;
            this.dataDoanhThuNam.Size = new System.Drawing.Size(603, 287);
            this.dataDoanhThuNam.TabIndex = 7;
            // 
            // cmbNam
            // 
            this.cmbNam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
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
            // txtTongDoanhThu
            // 
            this.txtTongDoanhThu.Location = new System.Drawing.Point(106, 418);
            this.txtTongDoanhThu.Name = "txtTongDoanhThu";
            this.txtTongDoanhThu.ReadOnly = true;
            this.txtTongDoanhThu.Size = new System.Drawing.Size(201, 20);
            this.txtTongDoanhThu.TabIndex = 16;
            // 
            // txtTiLe
            // 
            this.txtTiLe.Location = new System.Drawing.Point(437, 418);
            this.txtTiLe.Name = "txtTiLe";
            this.txtTiLe.ReadOnly = true;
            this.txtTiLe.Size = new System.Drawing.Size(94, 20);
            this.txtTiLe.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 421);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Tổng doanh thu:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(391, 421);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Tỉ lệ:";
            // 
            // ColThang
            // 
            this.ColThang.DataPropertyName = "Thang";
            this.ColThang.HeaderText = "Tháng";
            this.ColThang.Name = "ColThang";
            this.ColThang.ReadOnly = true;
            this.ColThang.Width = 120;
            // 
            // ColSoCB
            // 
            this.ColSoCB.DataPropertyName = "SoChuyenBay";
            this.ColSoCB.HeaderText = "Số chuyến bay";
            this.ColSoCB.Name = "ColSoCB";
            this.ColSoCB.ReadOnly = true;
            this.ColSoCB.Width = 120;
            // 
            // ColDoanhThu
            // 
            this.ColDoanhThu.DataPropertyName = "TongDoanhThu";
            this.ColDoanhThu.HeaderText = "Doanh thu";
            this.ColDoanhThu.Name = "ColDoanhThu";
            this.ColDoanhThu.ReadOnly = true;
            this.ColDoanhThu.Width = 220;
            // 
            // ColTiLe
            // 
            this.ColTiLe.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColTiLe.DataPropertyName = "TiLe";
            this.ColTiLe.HeaderText = "Tỉ lệ";
            this.ColTiLe.Name = "ColTiLe";
            this.ColTiLe.ReadOnly = true;
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.AutoSize = true;
            this.lblTieuDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTieuDe.Location = new System.Drawing.Point(210, 68);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(170, 16);
            this.lblTieuDe.TabIndex = 20;
            this.lblTieuDe.Text = "DOANH THU CỦA NĂM";
            // 
            // frmBaoCaoNam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 458);
            this.Controls.Add(this.lblTieuDe);
            this.Controls.Add(this.dataDoanhThuNam);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTiLe);
            this.Controls.Add(this.txtTongDoanhThu);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.cmbNam);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXem);
            this.Controls.Add(this.label2);
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
        private System.Windows.Forms.ComboBox cmbNam;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.TextBox txtTongDoanhThu;
        private System.Windows.Forms.TextBox txtTiLe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColThang;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColSoCB;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDoanhThu;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTiLe;
        private System.Windows.Forms.Label lblTieuDe;
    }
}