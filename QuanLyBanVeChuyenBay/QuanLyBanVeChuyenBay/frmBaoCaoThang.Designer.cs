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
            this.dataDoanhThuThang = new System.Windows.Forms.DataGridView();
            this.ColMaCB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColSoVe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDoanhThu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTiLe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtThang = new System.Windows.Forms.TextBox();
            this.txtNam = new System.Windows.Forms.TextBox();
            this.btnXem = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataDoanhThuThang)).BeginInit();
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
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nhập tháng:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(256, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nhập năm:";
            // 
            // txtThang
            // 
            this.txtThang.Location = new System.Drawing.Point(140, 27);
            this.txtThang.Name = "txtThang";
            this.txtThang.Size = new System.Drawing.Size(100, 20);
            this.txtThang.TabIndex = 3;
            // 
            // txtNam
            // 
            this.txtNam.Location = new System.Drawing.Point(321, 27);
            this.txtNam.Name = "txtNam";
            this.txtNam.Size = new System.Drawing.Size(100, 20);
            this.txtNam.TabIndex = 4;
            // 
            // btnXem
            // 
            this.btnXem.Location = new System.Drawing.Point(452, 27);
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
            // 
            // frmBaoCaoThang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 419);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXem);
            this.Controls.Add(this.txtNam);
            this.Controls.Add(this.txtThang);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataDoanhThuThang);
            this.Name = "frmBaoCaoThang";
            this.Text = "Báo Cáo Doanh Thu Tháng";
            ((System.ComponentModel.ISupportInitialize)(this.dataDoanhThuThang)).EndInit();
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
        private System.Windows.Forms.TextBox txtThang;
        private System.Windows.Forms.TextBox txtNam;
        private System.Windows.Forms.Button btnXem;
        private System.Windows.Forms.Button btnThoat;
    }
}