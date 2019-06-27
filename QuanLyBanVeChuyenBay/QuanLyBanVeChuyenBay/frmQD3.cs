using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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

        string strconn2 = frmMain.strconn2;
        string TGChamNhatDatVe, TGChamNhatHuyVe;

        public void Connection()
        {

            SqlConnection conn = new SqlConnection(strconn2);
            try
            {
                conn.Open();
                string sql = "select * from THAMSO";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {

                    txtThgianDatVe.Text = reader["TGChamNhatDatVe"].ToString();
                    txtThGianHuyVe.Text = reader["TGChamNhatHuyve"].ToString();

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

        private void frmQD3_Load(object sender, EventArgs e)
        {
            Connection();
            
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(strconn2);
            try
            {
                conn.Open();
                TGChamNhatDatVe = txtThgianDatVe.Text;
                TGChamNhatHuyVe = txtThGianHuyVe.Text;
                if(TGChamNhatDatVe==""||TGChamNhatHuyVe=="")
                    MessageBox.Show("Vui lòng không để trống ô giá trị nào", "Sửa đổi không thành công", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    string sql = "update ThamSo set TGChamNhatDatVe=" + TGChamNhatDatVe + ",TGChamNhatHuyVe=" + TGChamNhatHuyVe + " where MaThamSo='TS01'";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Sửa đồi thành công");
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
                MessageBox.Show("Các giá trị sửa đổi phải là số, vui lòng nhập lại", "Sửa đổi không thành công", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                //Dong ket noi sau khi thao tac ket thuc
                conn.Close();
            }
            frmQD3_Load(sender, e);
        }

        private void tSbtnDanhSachSB_Clicked(object sender, EventArgs e)
        {
            Form danhsachsb = new frmDanhSachSB(this);
            this.Hide();
            danhsachsb.ShowDialog();
            this.Show();
        }
    }
}
