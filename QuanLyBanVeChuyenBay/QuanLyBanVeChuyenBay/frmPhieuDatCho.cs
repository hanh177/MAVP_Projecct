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
    public partial class frmPhieuDatCho : Form
    {
        Form main;
        
        public frmPhieuDatCho(Form frmMain)
        {
            InitializeComponent();
            this.main = frmMain;
            
        }
       
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmPhieuDatCho_Load(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
            main.Show();
        }

        private void tSbtnDanhSachCB_Click(object sender, EventArgs e)
        {
            Form danhsachcb = new frmDanSachCB(this);
            this.Hide();
            danhsachcb.Show();
        }

        private void txtHangVe_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
