using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QuanLyBanVeChuyenBay
{
    public partial class CaiDatTK : Form
    {
        Form main;
        public CaiDatTK(Form frmMain)
        {
            InitializeComponent();
            this.main = frmMain;
        }
        string strconn2 = frmMain.strconn2;
        string matkhau;
        private void btnLuu_Click(object sender, EventArgs e)
        {

            txtXNMatKhauMoi.UseSystemPasswordChar = true;
            txtMatKhauMoi.UseSystemPasswordChar = true;
            SqlConnection conn = new SqlConnection(strconn2);
            try
            {
                conn.Open();
                string sql = "select * from TAIKHOAN where TenTaiKhoan= '" + txtTaiKhoan.Text + "'";
                SqlCommand command = new SqlCommand(sql, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable table = new DataTable();
                adapter.Fill(table);
                foreach (DataRow row in table.Rows)
                {
                    foreach (DataColumn col in table.Columns)
                    {
                        matkhau = row["MatKhau"].ToString();
                    }
                }
                if (txtMatKhauMoi.Text.Length >= 6)
                {
                    if (string.Compare(matkhau, txtMauKhauCu.Text, false) == 0)
                    {
                        if (string.Compare(txtXNMatKhauMoi.Text, txtMatKhauMoi.Text, false) == 0)
                        {
                            string sql2 = "UPDATE TAIKHOAN set MatKhau= '" + txtMatKhauMoi.Text + "' where TenTaiKhoan= '" + txtTaiKhoan.Text + "'";
                            SqlCommand command2 = new SqlCommand(sql2, conn);
                            command2.ExecuteNonQuery();
                            MessageBox.Show("Đổi mật khẩu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtMauKhauCu.Text = "";
                            txtMatKhauMoi.Text = "";
                            txtXNMatKhauMoi.Text = "";
                            return;
                        }
                        else
                        {
                            MessageBox.Show("Xác nhận mật khẩu mới không chính xác.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Mật khẩu không chính xác.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Mật khẩu phải dài hơn 6 kí tự.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            catch (InvalidOperationException ex)
            {
                //xu ly khi ket noi co van de
                MessageBox.Show("Khong the mo ket noi hoac ket noi da mo truoc do");
            }
            catch (Exception ex)
            {
                //xu ly khi ket noi co van de
                MessageBox.Show("Ket noi xay ra loi hoac doc du lieu bi loi");
            }
            finally
            {
                //Dong ket noi sau khi thao tac ket thuc
                conn.Close();
            }
        }

            private void CaiDatTK_Load(object sender, EventArgs e)
        {
            txtTaiKhoan.Text = frmLogin.username;

        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            if (txtXNMatKhauMoi.Text == "" || txtMatKhauMoi.Text == "")
                return;
            txtXNMatKhauMoi.UseSystemPasswordChar = false;
            txtMatKhauMoi.UseSystemPasswordChar = false;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Hide();
            main.ShowDialog();
        }

       
        private void btnXem_MouseEnter(object sender, EventArgs e)
        {
            
        }
    }
}
