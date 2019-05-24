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
    public partial class frmSuaDoiQD : Form
    {
        Form main;
        public frmSuaDoiQD(Form frmMain)
        {
            InitializeComponent();
            this.main = frmMain;
        }

        private void frmSuaDoiQD_Load(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnQD1_Click(object sender, EventArgs e)
        {
            Form qd1 = new frmQD1(this);
            this.Hide();
            qd1.ShowDialog();
            this.Show();
        }

        private void btnQD2_Click(object sender, EventArgs e)
        {
            Form qd2 = new cmbMaCB(this);
            this.Hide();
            qd2.ShowDialog();
            this.Show();
        }

        private void btnQD3_Click(object sender, EventArgs e)
        {
            Form qd3=new frmQD3(this);
            this.Hide();
            qd3.ShowDialog();
            this.Show();
        }
    }
}
