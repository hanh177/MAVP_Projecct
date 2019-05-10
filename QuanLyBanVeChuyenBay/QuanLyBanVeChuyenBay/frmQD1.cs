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
    public partial class frmQD1 : Form
    {
        Form suadoiqd;
        public frmQD1(Form frmSuaDoiQD)
        {
            InitializeComponent();
            this.suadoiqd = frmSuaDoiQD;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void frmQD1_Load(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
            suadoiqd.Show();
        }
    }
}
