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
            this.dataDanhSachSB = new System.Windows.Forms.DataGridView();
            this.ColMaSB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTenSb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnThemSB = new System.Windows.Forms.Button();
            this.txtSBmax = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTenSB = new System.Windows.Forms.TextBox();
            this.txtMaSB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
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
            this.dataDanhSachSB.Size = new System.Drawing.Size(468, 213);
            this.dataDanhSachSB.TabIndex = 0;
            // 
            // ColMaSB
            // 
            this.ColMaSB.HeaderText = "Mã SB";
            this.ColMaSB.Name = "ColMaSB";
            // 
            // ColTenSb
            // 
            this.ColTenSb.HeaderText = "Tên SB";
            this.ColTenSb.Name = "ColTenSb";
            // 
            // btnThemSB
            // 
            this.btnThemSB.Location = new System.Drawing.Point(358, 52);
            this.btnThemSB.Name = "btnThemSB";
            this.btnThemSB.Size = new System.Drawing.Size(92, 23);
            this.btnThemSB.TabIndex = 1;
            this.btnThemSB.Text = "Thêm sân bay";
            this.btnThemSB.UseVisualStyleBackColor = true;
            // 
            // txtSBmax
            // 
            this.txtSBmax.Location = new System.Drawing.Point(420, 18);
            this.txtSBmax.Name = "txtSBmax";
            this.txtSBmax.Size = new System.Drawing.Size(60, 20);
            this.txtSBmax.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(321, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Số sân bay tối đa:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtTenSB);
            this.groupBox1.Controls.Add(this.txtMaSB);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnThemSB);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(468, 89);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thêm sân bay";
            // 
            // txtTenSB
            // 
            this.txtTenSB.Location = new System.Drawing.Point(104, 49);
            this.txtTenSB.Name = "txtTenSB";
            this.txtTenSB.Size = new System.Drawing.Size(206, 20);
            this.txtTenSB.TabIndex = 3;
            // 
            // txtMaSB
            // 
            this.txtMaSB.Location = new System.Drawing.Point(104, 17);
            this.txtMaSB.Name = "txtMaSB";
            this.txtMaSB.Size = new System.Drawing.Size(206, 20);
            this.txtMaSB.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tên Sân bay";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã Sân bay";
            // 
            // frmDanhSachSB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 381);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSBmax);
            this.Controls.Add(this.dataDanhSachSB);
            this.Name = "frmDanhSachSB";
            this.Text = "Danh Sách Sân Bay";
            ((System.ComponentModel.ISupportInitialize)(this.dataDanhSachSB)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataDanhSachSB;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColMaSB;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTenSb;
        private System.Windows.Forms.Button btnThemSB;
        private System.Windows.Forms.TextBox txtSBmax;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtTenSB;
        private System.Windows.Forms.TextBox txtMaSB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}