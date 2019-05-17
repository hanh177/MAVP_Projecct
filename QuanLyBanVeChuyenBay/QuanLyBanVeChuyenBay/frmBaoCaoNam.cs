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
    public partial class frmBaoCaoNam : Form
    {
        Form baocaothang;
        public frmBaoCaoNam(Form frmBaoCaoThang)
        {
            InitializeComponent();
            this.baocaothang = frmBaoCaoThang;
        }

       
        private void frmBaoCaoNam_Load(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
            baocaothang.Show();
        }
    }
}
