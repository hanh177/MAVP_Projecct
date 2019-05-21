namespace QuanLyBanVeChuyenBay
{
    partial class frmSuaDoiQD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSuaDoiQD));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnQD3 = new System.Windows.Forms.Button();
            this.btnQD1 = new System.Windows.Forms.Button();
            this.btnQD2 = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(445, 149);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin qui định";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(418, 78);
            this.label1.TabIndex = 0;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnQD3);
            this.groupBox2.Controls.Add(this.btnQD1);
            this.groupBox2.Controls.Add(this.btnQD2);
            this.groupBox2.Location = new System.Drawing.Point(12, 158);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(445, 107);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // btnQD3
            // 
            this.btnQD3.Location = new System.Drawing.Point(301, 48);
            this.btnQD3.Name = "btnQD3";
            this.btnQD3.Size = new System.Drawing.Size(75, 23);
            this.btnQD3.TabIndex = 3;
            this.btnQD3.Text = "Qui định 3";
            this.btnQD3.UseVisualStyleBackColor = true;
            this.btnQD3.Click += new System.EventHandler(this.btnQD3_Click);
            // 
            // btnQD1
            // 
            this.btnQD1.Location = new System.Drawing.Point(72, 48);
            this.btnQD1.Name = "btnQD1";
            this.btnQD1.Size = new System.Drawing.Size(75, 23);
            this.btnQD1.TabIndex = 0;
            this.btnQD1.Text = "Qui định 1";
            this.btnQD1.UseVisualStyleBackColor = true;
            this.btnQD1.Click += new System.EventHandler(this.btnQD1_Click);
            // 
            // btnQD2
            // 
            this.btnQD2.Location = new System.Drawing.Point(185, 48);
            this.btnQD2.Name = "btnQD2";
            this.btnQD2.Size = new System.Drawing.Size(75, 23);
            this.btnQD2.TabIndex = 1;
            this.btnQD2.Text = "Qui định 2";
            this.btnQD2.UseVisualStyleBackColor = true;
            this.btnQD2.Click += new System.EventHandler(this.btnQD2_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(364, 271);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 2;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // frmSuaDoiQD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 300);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmSuaDoiQD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sửa Đổi Qui Định";
            this.Load += new System.EventHandler(this.frmSuaDoiQD_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnQD3;
        private System.Windows.Forms.Button btnQD1;
        private System.Windows.Forms.Button btnQD2;
        private System.Windows.Forms.Button btnThoat;
    }
}