namespace QuanLyBanVeChuyenBay
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnTraCuu = new System.Windows.Forms.Button();
            this.btnBanVe = new System.Windows.Forms.Button();
            this.btnPhieuDatCho = new System.Windows.Forms.Button();
            this.btnDoanhThu = new System.Windows.Forms.Button();
            this.btnNhanLich = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.frontChữToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.màuNềnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.etcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripDropDownButton();
            this.nhậnLịchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bánVéToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Location = new System.Drawing.Point(12, 48);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(523, 176);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnDoanhThu);
            this.groupBox2.Controls.Add(this.btnPhieuDatCho);
            this.groupBox2.Controls.Add(this.btnBanVe);
            this.groupBox2.Controls.Add(this.btnNhanLich);
            this.groupBox2.Controls.Add(this.btnTraCuu);
            this.groupBox2.Location = new System.Drawing.Point(12, 230);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(523, 172);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Bán vé";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(92, 136);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(122, 20);
            this.textBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(174, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bán Vé Máy Bay";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tài khoản:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnTraCuu
            // 
            this.btnTraCuu.Location = new System.Drawing.Point(215, 72);
            this.btnTraCuu.Name = "btnTraCuu";
            this.btnTraCuu.Size = new System.Drawing.Size(91, 47);
            this.btnTraCuu.TabIndex = 1;
            this.btnTraCuu.Text = "Tra cứu chuyến bay";
            this.btnTraCuu.UseVisualStyleBackColor = true;
            // 
            // btnBanVe
            // 
            this.btnBanVe.Location = new System.Drawing.Point(75, 102);
            this.btnBanVe.Name = "btnBanVe";
            this.btnBanVe.Size = new System.Drawing.Size(91, 47);
            this.btnBanVe.TabIndex = 1;
            this.btnBanVe.Text = "Bán vé";
            this.btnBanVe.UseVisualStyleBackColor = true;
            // 
            // btnPhieuDatCho
            // 
            this.btnPhieuDatCho.Location = new System.Drawing.Point(366, 33);
            this.btnPhieuDatCho.Name = "btnPhieuDatCho";
            this.btnPhieuDatCho.Size = new System.Drawing.Size(91, 47);
            this.btnPhieuDatCho.TabIndex = 1;
            this.btnPhieuDatCho.Text = "Phiểu đặt chỗ";
            this.btnPhieuDatCho.UseVisualStyleBackColor = true;
            // 
            // btnDoanhThu
            // 
            this.btnDoanhThu.Location = new System.Drawing.Point(366, 102);
            this.btnDoanhThu.Name = "btnDoanhThu";
            this.btnDoanhThu.Size = new System.Drawing.Size(91, 47);
            this.btnDoanhThu.TabIndex = 1;
            this.btnDoanhThu.Text = "Báo cáo doanh thu";
            this.btnDoanhThu.UseVisualStyleBackColor = true;
            // 
            // btnNhanLich
            // 
            this.btnNhanLich.Location = new System.Drawing.Point(75, 33);
            this.btnNhanLich.Name = "btnNhanLich";
            this.btnNhanLich.Size = new System.Drawing.Size(91, 47);
            this.btnNhanLich.TabIndex = 1;
            this.btnNhanLich.Text = "Nhận lịch chuyến bay";
            this.btnNhanLich.UseVisualStyleBackColor = true;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton4});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(547, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(80, 22);
            this.toolStripButton4.Text = "&Đãng xuất";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.frontChữToolStripMenuItem,
            this.màuNềnToolStripMenuItem,
            this.etcToolStripMenuItem});
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(73, 22);
            this.toolStripButton1.Text = "&Cài đặt";
            // 
            // frontChữToolStripMenuItem
            // 
            this.frontChữToolStripMenuItem.Name = "frontChữToolStripMenuItem";
            this.frontChữToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.frontChữToolStripMenuItem.Text = "Front chữ";
            this.frontChữToolStripMenuItem.Click += new System.EventHandler(this.frontChữToolStripMenuItem_Click);
            // 
            // màuNềnToolStripMenuItem
            // 
            this.màuNềnToolStripMenuItem.Name = "màuNềnToolStripMenuItem";
            this.màuNềnToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.màuNềnToolStripMenuItem.Text = "Màu nền";
            // 
            // etcToolStripMenuItem
            // 
            this.etcToolStripMenuItem.Name = "etcToolStripMenuItem";
            this.etcToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.etcToolStripMenuItem.Text = "etc";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nhậnLịchToolStripMenuItem,
            this.bánVéToolStripMenuItem,
            this.ectToolStripMenuItem});
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(61, 22);
            this.toolStripButton2.Text = "Help";
            // 
            // nhậnLịchToolStripMenuItem
            // 
            this.nhậnLịchToolStripMenuItem.Name = "nhậnLịchToolStripMenuItem";
            this.nhậnLịchToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.nhậnLịchToolStripMenuItem.Text = "Nhận lịch ";
            // 
            // bánVéToolStripMenuItem
            // 
            this.bánVéToolStripMenuItem.Name = "bánVéToolStripMenuItem";
            this.bánVéToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.bánVéToolStripMenuItem.Text = "Bán vé";
            // 
            // ectToolStripMenuItem
            // 
            this.ectToolStripMenuItem.Name = "ectToolStripMenuItem";
            this.ectToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.ectToolStripMenuItem.Text = "ect";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 414);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmMain";
            this.Text = "Trang chủ";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnTraCuu;
        private System.Windows.Forms.Button btnDoanhThu;
        private System.Windows.Forms.Button btnPhieuDatCho;
        private System.Windows.Forms.Button btnBanVe;
        private System.Windows.Forms.Button btnNhanLich;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripButton1;
        private System.Windows.Forms.ToolStripMenuItem frontChữToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem màuNềnToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripMenuItem etcToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton toolStripButton2;
        private System.Windows.Forms.ToolStripMenuItem nhậnLịchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bánVéToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ectToolStripMenuItem;
    }
}