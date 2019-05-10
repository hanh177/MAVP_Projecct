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
    public partial class frmBanVe : Form
    {
        Form main;
        public event EventHandler Button_Clicked;
        public frmBanVe(Form frmMain)
        {
            InitializeComponent();
            this.main = frmMain;
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmBanVe_Load(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
            main.Show();
        }

        private void btnDanhSachCB_Click(object sender, EventArgs e)
        {
            Form danhsachcb = new frmDanSachCB(this);
            this.Hide();
            danhsachcb.Show();
        }

        private void tSbtnPhieuDatCho_Click(object sender, EventArgs e)
        {
            Form phieudatcho = new frmPhieuDatCho(this);
            this.Hide();
            phieudatcho.Show();
        }

        private void tSbtnDanhSachCB_Click(object sender, EventArgs e)
        {
            Form danhsachcb = new frmDanSachCB(this);
            this.Hide();
            danhsachcb.Show();
        }
    }
}
