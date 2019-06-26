namespace QuanLyBanVeChuyenBay
{
    partial class frmDanhSachSB
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDanhSachSB));
            this.dataDanhSachSB = new System.Windows.Forms.DataGridView();
            this.ColMaSB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTenSb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnThemSB = new System.Windows.Forms.Button();
            this.txtSBmax = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnXoaSanBay = new System.Windows.Forms.Button();
            this.txtTenSB = new System.Windows.Forms.TextBox();
            this.txtMaSB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataDanhSachSB)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataDanhSachSB
            // 
            this.dataDanhSachSB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataDanhSachSB.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColMaSB,
            this.ColTenSb});
            this.dataDanhSachSB.Location = new System.Drawing.Point(12, 156);
            this.dataDanhSachSB.Name = "dataDanhSachSB";
            this.dataDanhSachSB.ReadOnly = true;
            this.dataDanhSachSB.Size = new System.Drawing.Size(468, 213);
            this.dataDanhSachSB.TabIndex = 0;
            this.dataDanhSachSB.Click += new System.EventHandler(this.dataDanhSachSB_Click);
            // 
            // ColMaSB
            // 
            this.ColMaSB.DataPropertyName = "MaSanBay";
            this.ColMaSB.HeaderText = "Mã SB";
            this.ColMaSB.Name = "ColMaSB";
            this.ColMaSB.ReadOnly = true;
            this.ColMaSB.Width = 120;
            // 
            // ColTenSb
            // 
            this.ColTenSb.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColTenSb.DataPropertyName = "TenSanBay";
            this.ColTenSb.HeaderText = "Tên SB";
            this.ColTenSb.Name = "ColTenSb";
            this.ColTenSb.ReadOnly = true;
            // 
            // btnThemSB
            // 
            this.btnThemSB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThemSB.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemSB.Location = new System.Drawing.Point(365, 14);
            this.btnThemSB.Name = "btnThemSB";
            this.btnThemSB.Size = new System.Drawing.Size(92, 23);
            this.btnThemSB.TabIndex = 1;
            this.btnThemSB.Text = "Thêm Sân Bay";
            this.btnThemSB.UseVisualStyleBackColor = true;
            this.btnThemSB.Click += new System.EventHandler(this.btnThemSB_Click);
            // 
            // txtSBmax
            // 
            this.txtSBmax.Enabled = false;
            this.txtSBmax.Location = new System.Drawing.Point(431, 18);
            this.txtSBmax.Name = "txtSBmax";
            this.txtSBmax.Size = new System.Drawing.Size(49, 20);
            this.txtSBmax.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(318, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Số sân bay tối đa:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btnXoaSanBay);
            this.groupBox1.Controls.Add(this.txtTenSB);
            this.groupBox1.Controls.Add(this.txtMaSB);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnThemSB);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Arial Narrow", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(468, 89);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thêm sân bay";
            // 
            // btnXoaSanBay
            // 
            this.btnXoaSanBay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoaSanBay.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaSanBay.Location = new System.Drawing.Point(365, 52);
            this.btnXoaSanBay.Name = "btnXoaSanBay";
            this.btnXoaSanBay.Size = new System.Drawing.Size(92, 23);
            this.btnXoaSanBay.TabIndex = 4;
            this.btnXoaSanBay.Text = "Xoá Sân Bay";
            this.btnXoaSanBay.UseVisualStyleBackColor = true;
            this.btnXoaSanBay.Click += new System.EventHandler(this.btnXoaSanBay_Click);
            // 
            // txtTenSB
            // 
            this.txtTenSB.Location = new System.Drawing.Point(104, 49);
            this.txtTenSB.Name = "txtTenSB";
            this.txtTenSB.Size = new System.Drawing.Size(206, 22);
            this.txtTenSB.TabIndex = 3;
            // 
            // txtMaSB
            // 
            this.txtMaSB.Location = new System.Drawing.Point(104, 17);
            this.txtMaSB.Name = "txtMaSB";
            this.txtMaSB.Size = new System.Drawing.Size(206, 22);
            this.txtMaSB.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tên Sân bay";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã Sân bay";
            // 
            // btnThoat
            // 
            this.btnThoat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThoat.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.Image")));
            this.btnThoat.Location = new System.Drawing.Point(387, 383);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(82, 32);
            this.btnThoat.TabIndex = 5;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // frmDanhSachSB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QuanLyBanVeChuyenBay.Properties.Resources.blue_turquoise_gradient_polygon_shaped_background_zoomed_in_and_zoomed_out_in_one_motion_nj5dnqsrl__F00001;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(492, 418);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSBmax);
            this.Controls.Add(this.dataDanhSachSB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "frmDanhSachSB";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh Sách Sân Bay";
            this.Load += new System.EventHandler(this.frmDanhSachSB_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataDanhSachSB)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataDanhSachSB;
        private System.Windows.Forms.Button btnThemSB;
        private System.Windows.Forms.TextBox txtSBmax;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtTenSB;
        private System.Windows.Forms.TextBox txtMaSB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColMaSB;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTenSb;
        private System.Windows.Forms.Button btnXoaSanBay;
    }
}