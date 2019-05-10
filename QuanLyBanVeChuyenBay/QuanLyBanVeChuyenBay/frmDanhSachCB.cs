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
    public partial class frmDanSachCB : Form
    {
        Form main;
        public frmDanSachCB(Form frmMain)
        {
            InitializeComponent();
            this.main = frmMain;
        }

        private void frmDanSachCB_Load(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
            main.Show();
        }

       

        private void tSbtnTraCuuCB_Click(object sender, EventArgs e)
        {
            Form tracuucb = new frmTraCuu(this);
            this.Hide();
            tracuucb.Show();
        }

        private void btnTraCuu_Click(object sender, EventArgs e)
        {
            this.tSbtnTraCuuCB_Click(sender, e);
        }

      

        private void tSbtnThemCB_Clicked(object sender, EventArgs e)
        {
            Form nhanlich = new frmNhanLich(this);
            this.Hide();
            nhanlich.Show();
        }

        private void tSbtnDatVeCB_Clicked(object sender, EventArgs e)
        {
            Form banve = new frmBanVe(this);
            this.Hide();
            banve.Show();
        }

        private void btnThemCB_Click(object sender, EventArgs e)
        {
            tSbtnThemCB_Clicked(sender, e);
        }

        private void btnDatVe_Click(object sender, EventArgs e)
        {
            tSbtnDatVeCB_Clicked(sender, e);
        }
    }
}
