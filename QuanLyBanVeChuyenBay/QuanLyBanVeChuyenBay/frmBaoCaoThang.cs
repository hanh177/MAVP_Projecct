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
    public partial class frmBaoCaoThang : Form
    {
        Form main;
        public frmBaoCaoThang(Form frmMain)
        {
            InitializeComponent();
            this.main = frmMain;
        }

        private void frmBaoCaoThang_Load(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
            main.Show();
        }

        private void btnBaoCaoNam_Click(object sender, EventArgs e)
        {
            Form baocaonam = new frmBaoCaoNam(this);
            this.Hide();
            baocaonam.Show();
        }
    }
}
