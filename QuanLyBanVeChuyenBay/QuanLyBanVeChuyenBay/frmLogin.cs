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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        string strconn2 = frmMain.strconn2;
        private void Connection()
        {

            SqlConnection conn = new SqlConnection(strconn2);
            try
            {
                conn.Open();
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
                    SqlConnection conn = new SqlConnection(strconn2);
                    try
                    {
                        conn.Open();
                        string sql = "select * from TAIKHOAN where TenTaiKhoan= '" + txtUserName.Text + "'" + " and MatKhau= '" + txtPassWord.Text + "'";
                        SqlCommand command = new SqlCommand(sql,conn);
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable table = new DataTable();
                        adapter.Fill(table);
                        if (table.Rows.Count == 0)
                        {
                            MessageBox.Show("Tên tài khoản hoặc mắt khẩu không chính xác, vui lòng kiểm tra lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtPassWord.Text = "";
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

       

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
