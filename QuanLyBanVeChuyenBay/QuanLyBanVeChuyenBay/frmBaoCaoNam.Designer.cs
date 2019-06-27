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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBaoCaoNam));
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnXem = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dataDoanhThuNam = new System.Windows.Forms.DataGridView();
            this.cmbNam = new System.Windows.Forms.ComboBox();
            this.txtTongDoanhThu = new System.Windows.Forms.TextBox();
            this.txtTiLe = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.ColThang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColSoCB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDoanhThu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTiLe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataDoanhThuNam)).BeginInit();
            this.SuspendLayout();
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnThoat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThoat.Image = global::QuanLyBanVeChuyenBay.Properties.Resources.Thoat__1_2;
            this.btnThoat.Location = new System.Drawing.Point(744, 474);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(100, 40);
            this.btnThoat.TabIndex = 13;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnXem
            // 
            this.btnXem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXem.Image = ((System.Drawing.Image)(resources.GetObject("btnXem.Image")));
            this.btnXem.Location = new System.Drawing.Point(525, 14);
            this.btnXem.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(100, 32);
            this.btnXem.TabIndex = 12;
            this.btnXem.Text = "Xem";
            this.btnXem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnXem.UseVisualStyleBackColor = true;
            this.btnXem.Click += new System.EventHandler(this.btnXem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(266, 28);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Chọn năm:";
            // 
            // dataDoanhThuNam
            // 
            this.dataDoanhThuNam.BackgroundColor = System.Drawing.Color.CornflowerBlue;
            this.dataDoanhThuNam.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataDoanhThuNam.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColThang,
            this.ColSoCB,
            this.ColDoanhThu,
            this.ColTiLe});
            this.dataDoanhThuNam.Location = new System.Drawing.Point(40, 118);
            this.dataDoanhThuNam.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataDoanhThuNam.Name = "dataDoanhThuNam";
            this.dataDoanhThuNam.ReadOnly = true;
            this.dataDoanhThuNam.Size = new System.Drawing.Size(804, 331);
            this.dataDoanhThuNam.TabIndex = 7;
            // 
            // cmbNam
            // 
            this.cmbNam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNam.FormattingEnabled = true;
            this.cmbNam.Location = new System.Drawing.Point(341, 23);
            this.cmbNam.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmbNam.Name = "cmbNam";
            this.cmbNam.Size = new System.Drawing.Size(160, 23);
            this.cmbNam.TabIndex = 14;
            // 
            // txtTongDoanhThu
            // 
            this.txtTongDoanhThu.Location = new System.Drawing.Point(184, 474);
            this.txtTongDoanhThu.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtTongDoanhThu.Multiline = true;
            this.txtTongDoanhThu.Name = "txtTongDoanhThu";
            this.txtTongDoanhThu.ReadOnly = true;
            this.txtTongDoanhThu.Size = new System.Drawing.Size(243, 40);
            this.txtTongDoanhThu.TabIndex = 16;
            // 
            // txtTiLe
            // 
            this.txtTiLe.Location = new System.Drawing.Point(525, 474);
            this.txtTiLe.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtTiLe.Multiline = true;
            this.txtTiLe.Name = "txtTiLe";
            this.txtTiLe.ReadOnly = true;
            this.txtTiLe.Size = new System.Drawing.Size(180, 40);
            this.txtTiLe.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(63, 489);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Tổng doanh thu:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(485, 489);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Tỉ lệ:";
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.AutoSize = true;
            this.lblTieuDe.BackColor = System.Drawing.Color.Transparent;
            this.lblTieuDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTieuDe.Location = new System.Drawing.Point(338, 85);
            this.lblTieuDe.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(170, 16);
            this.lblTieuDe.TabIndex = 20;
            this.lblTieuDe.Text = "DOANH THU CỦA NĂM";
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
            this.ColSoCB.Width = 140;
            // 
            // ColDoanhThu
            // 
            this.ColDoanhThu.DataPropertyName = "TongDoanhThu";
            this.ColDoanhThu.HeaderText = "Doanh thu";
            this.ColDoanhThu.Name = "ColDoanhThu";
            this.ColDoanhThu.ReadOnly = true;
            this.ColDoanhThu.Width = 250;
            // 
            // ColTiLe
            // 
            this.ColTiLe.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColTiLe.DataPropertyName = "TiLe";
            this.ColTiLe.HeaderText = "Tỉ lệ";
            this.ColTiLe.Name = "ColTiLe";
            this.ColTiLe.ReadOnly = true;
            // 
            // frmBaoCaoNam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QuanLyBanVeChuyenBay.Properties.Resources.blue_turquoise_gradient_polygon_shaped_background_zoomed_in_and_zoomed_out_in_one_motion_nj5dnqsrl__F00001;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(884, 528);
            this.Controls.Add(this.lblTieuDe);
            this.Controls.Add(this.dataDoanhThuNam);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTiLe);
            this.Controls.Add(this.txtTongDoanhThu);
            this.Controls.Add(this.cmbNam);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXem);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
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
        private System.Windows.Forms.TextBox txtTongDoanhThu;
        private System.Windows.Forms.TextBox txtTiLe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColThang;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColSoCB;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDoanhThu;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTiLe;
    }
}