using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanVeChuyenBay
{
    public partial class frmMain : Form
    {
        Form login;
        public frmMain(Form frmLogin)
        {
            InitializeComponent();
            this.login = frmLogin;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
       
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frontChữToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            
            label3.Text= frmLogin.username.ToString(); 
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            this.Close();
            login.Show();
           
        }

        private void btnNhanLich_Click(object sender, EventArgs e)
        {
            Form nhanlich = new frmNhanLich(this);
            this.Hide();
            nhanlich.ShowDialog();
            this.Show();
        }

        private void btnDanhSach_Click(object sender, EventArgs e)
        {
            Form danhsachcb = new frmDanSachCB(this);
            this.Hide();
            danhsachcb.ShowDialog();
            this.Show();
        }

         private void btnXemPhieuDatCho_Click(object sender, EventArgs e)
        {
            
        }

        private void btnTraCuu_Click(object sender, EventArgs e)
        {
            Form tracuu = new frmTraCuu(this);
            this.Hide();
            tracuu.ShowDialog();
            this.Show();
        }

        private void btnSuaDoiQD_Click(object sender, EventArgs e)
        {
            Form suadoiqd = new frmSuaDoiQD(this);
            this.Hide();
            suadoiqd.ShowDialog();
            this.Show();
        }

        private void btnDoanhThu_Click(object sender, EventArgs e)
        {
            Form baocaothang = new frmBaoCaoThang(this);
            this.Hide();
            baocaothang.ShowDialog();
            this.Show();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void btnDSKH_Click(object sender, EventArgs e)
        {
            
        }

        private void btnDSKH_Click_1(object sender, EventArgs e)
        {
            Form dskh = new frmDanhSachKH(this);
            this.Hide();
            dskh.Show();
        }
    }
}
