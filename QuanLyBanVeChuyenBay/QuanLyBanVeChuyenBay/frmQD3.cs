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
    public partial class frmQD3 : Form
    {
        Form suadoiqd;
        public frmQD3(Form frmSuaDoiQD)
        {
            InitializeComponent();
            this.suadoiqd = frmSuaDoiQD;
        }

        private void frmQD3_Load(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
            suadoiqd.Show();
        }

        private void tSbtnDanhSachSB_Clicked(object sender, EventArgs e)
        {
            Form danhsachsb = new frmDanhSachSB(this);
            this.Hide();
            danhsachsb.Show();
        }
    }
}
