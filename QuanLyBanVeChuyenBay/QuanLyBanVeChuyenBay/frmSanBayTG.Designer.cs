namespace QuanLyBanVeChuyenBay
{
    partial class frmSanBayTG
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSanBayTG));
            this.dataDSSBTG = new System.Windows.Forms.DataGridView();
            this.colMATG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenSB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colThoiGianDung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGhiChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataDSSBTG)).BeginInit();
            this.SuspendLayout();
            // 
            // dataDSSBTG
            // 
            this.dataDSSBTG.BackgroundColor = System.Drawing.Color.CornflowerBlue;
            this.dataDSSBTG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataDSSBTG.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMATG,
            this.colTenSB,
            this.colThoiGianDung,
            this.colGhiChu});
            this.dataDSSBTG.Location = new System.Drawing.Point(16, 82);
            this.dataDSSBTG.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataDSSBTG.Name = "dataDSSBTG";
            this.dataDSSBTG.Size = new System.Drawing.Size(731, 293);
            this.dataDSSBTG.TabIndex = 0;
            // 
            // colMATG
            // 
            this.colMATG.DataPropertyName = "MaTrungGian";
            this.colMATG.HeaderText = "Mã TG";
            this.colMATG.Name = "colMATG";
            this.colMATG.ReadOnly = true;
            this.colMATG.Width = 120;
            // 
            // colTenSB
            // 
            this.colTenSB.DataPropertyName = "TenSanBay";
            this.colTenSB.HeaderText = "Tên Sân Bay";
            this.colTenSB.Name = "colTenSB";
            this.colTenSB.ReadOnly = true;
            this.colTenSB.Width = 150;
            // 
            // colThoiGianDung
            // 
            this.colThoiGianDung.DataPropertyName = "ThoiGianDung";
            this.colThoiGianDung.HeaderText = "Thời Gian Dừng";
            this.colThoiGianDung.Name = "colThoiGianDung";
            this.colThoiGianDung.ReadOnly = true;
            this.colThoiGianDung.Width = 120;
            // 
            // colGhiChu
            // 
            this.colGhiChu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colGhiChu.DataPropertyName = "GhiChu";
            this.colGhiChu.HeaderText = "Ghi Chú";
            this.colGhiChu.Name = "colGhiChu";
            this.colGhiChu.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(235, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "DANH SÁCH SÂN BAY TRUNG GIAN";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Image = global::QuanLyBanVeChuyenBay.Properties.Resources.Thoat__1_2;
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThoat.Location = new System.Drawing.Point(647, 400);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(100, 43);
            this.btnThoat.TabIndex = 2;
            this.btnThoat.Text = "Trở về";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // frmSanBayTG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QuanLyBanVeChuyenBay.Properties.Resources.blue_turquoise_gradient_polygon_shaped_background_zoomed_in_and_zoomed_out_in_one_motion_nj5dnqsrl__F00001;
            this.ClientSize = new System.Drawing.Size(761, 480);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataDSSBTG);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "frmSanBayTG";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông Tin Sân Bay Trung Gian";
            this.Load += new System.EventHandler(this.frmSanBayTG_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataDSSBTG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataDSSBTG;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMATG;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenSB;
        private System.Windows.Forms.DataGridViewTextBoxColumn colThoiGianDung;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGhiChu;
    }
}