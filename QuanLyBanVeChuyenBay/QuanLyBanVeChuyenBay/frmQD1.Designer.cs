namespace QuanLyBanVeChuyenBay
{
    partial class frmQD1
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtSBmax = new System.Windows.Forms.TextBox();
            this.txtSNTGMax = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtThGianMin = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtThGianTGmin = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtThGianTGmax = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số sân bay tối đa:";
            // 
            // txtSBmax
            // 
            this.txtSBmax.Location = new System.Drawing.Point(235, 34);
            this.txtSBmax.Name = "txtSBmax";
            this.txtSBmax.Size = new System.Drawing.Size(176, 20);
            this.txtSBmax.TabIndex = 1;
            // 
            // txtSNTGMax
            // 
            this.txtSNTGMax.Location = new System.Drawing.Point(235, 140);
            this.txtSNTGMax.Name = "txtSNTGMax";
            this.txtSNTGMax.Size = new System.Drawing.Size(176, 20);
            this.txtSNTGMax.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Số sân bay trung gian tối đa:\r\n";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtThGianMin
            // 
            this.txtThGianMin.Location = new System.Drawing.Point(235, 84);
            this.txtThGianMin.Name = "txtThGianMin";
            this.txtThGianMin.Size = new System.Drawing.Size(176, 20);
            this.txtThGianMin.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Thời gian bay tối thiểu:";
            // 
            // txtThGianTGmin
            // 
            this.txtThGianTGmin.Location = new System.Drawing.Point(235, 191);
            this.txtThGianTGmin.Name = "txtThGianTGmin";
            this.txtThGianTGmin.Size = new System.Drawing.Size(176, 20);
            this.txtThGianTGmin.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(167, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Thời gian dừng tối thiểu tại SBTG:";
            // 
            // txtThGianTGmax
            // 
            this.txtThGianTGmax.Location = new System.Drawing.Point(235, 238);
            this.txtThGianTGmax.Name = "txtThGianTGmax";
            this.txtThGianTGmax.Size = new System.Drawing.Size(176, 20);
            this.txtThGianTGmax.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 245);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(157, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Thời gian dừng tối đa tại SBTG:";
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(235, 316);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 23);
            this.btnLuu.TabIndex = 10;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(345, 316);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 11;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // frmQD1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 351);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.txtThGianTGmax);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtThGianTGmin);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtThGianMin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSNTGMax);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSBmax);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmQD1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sửa Đổi Qui Định 1";
            this.Load += new System.EventHandler(this.frmQD1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSBmax;
        private System.Windows.Forms.TextBox txtSNTGMax;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtThGianMin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtThGianTGmin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtThGianTGmax;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnThoat;
    }
}