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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
       
        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
       static public string username;
        private void btnLogin_Click(object sender, EventArgs e)
        {
            Form main = new frmMain(this);
            try
            {
                if (txtUserName.Text.Length == 0||txtPassWord.Text.Length==0)
                {
                    MessageBox.Show("Ten nguoi dung hoac mau khau khong the trong, vui long nhap lai.", "Loi", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    this.Hide();
                    username = txtUserName.Text;
                    main.Show();
                }
            }
            catch
            {
                MessageBox.Show("Da xay ra loi, vui long thu lai.", "Loi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            
        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {

            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
