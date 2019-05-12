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
    public partial class frmTraCuu : Form
    {
        Form danhsachcb;
        public frmTraCuu(Form frmDanSachCB)
        {
            InitializeComponent();
            this.danhsachcb = frmDanSachCB;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void frmTraCuu_Load(object sender, EventArgs e)
        {
            dateTimePickerNgayBay.Text = "";
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {

            this.Close();
            danhsachcb.Show();
        }

        private void btnDanhSach_Click(object sender, EventArgs e)
        {
            Form danhsachcb = new frmDanSachCB(this);
            this.Hide();
            danhsachcb.Show();

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
