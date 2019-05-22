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
using System.Globalization;


namespace QuanLyBanVeChuyenBay
{

    public partial class frmDanhSachSB : Form
    {
        Form nhanlich;
        public frmDanhSachSB(Form frmNhanLich)
        {
            InitializeComponent();
            this.nhanlich = frmNhanLich;
        }

        //string strconn2 = @"Data Source=DESKTOP-TA2HS1O\SQLEXPRESS;Initial Catalog=QLBanVeChuyenBay;Integrated Security=True"; //cua ha anh

        string strconn2 = @"Data Source=DESKTOP-JLJ2TBG;Initial Catalog=QLBanVeChuyenBay;Integrated Security=True";


        private void Connection()
        {
            SqlConnection conn = new SqlConnection(strconn2);
            try
            {
                conn.Open();
                string sql = "SELECT * FROM SANBAY";
                SqlCommand command = new SqlCommand(sql, conn);  
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dataDanhSachSB.DataSource = table;
                dataDanhSachSB.AutoGenerateColumns = true;
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
       
        private void frmDanhSachSB_Load(object sender, EventArgs e)
        {
            Connection();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
            nhanlich.Show();
        }

        private void btnThemSB_Click(object sender, EventArgs e)
        {
            if (txtMaSB.Text.Length != 0 && txtTenSB.Text.Length!=0)
            {
                SqlConnection conn = new SqlConnection(strconn2);
                string MASB = txtMaSB.Text;
                string TENSB = txtTenSB.Text;

                try
                {
                    conn.Open();
                    String sqlQuery = "insert into [QLBanVeChuyenBay].[dbo].[SANBAY] values ( " + "@MaSanBay, @TenSanBay)";
                    SqlCommand commnad = new SqlCommand(sqlQuery, conn);
                    commnad.Parameters.AddWithValue("MaSanBay", MASB);
                    commnad.Parameters.AddWithValue("TenSanBay", TENSB);

                    commnad.ExecuteNonQuery();
                    MessageBox.Show("Thêm sân bay thành công", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    string sql = "SELECT * FROM SANBAY";
                    SqlCommand command = new SqlCommand(sql, conn);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    dataDanhSachSB.DataSource = table;
                    txtMaSB.Text = "";
                    txtTenSB.Text = "";
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
            else
            {
                MessageBox.Show("Mã sân bay hoặc tên sân bay không thể trống.", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btnXoaSanBay_Click(object sender, EventArgs e)
        {

            SqlConnection conn = new SqlConnection(strconn2);
           
            
            try
            {
                string masb = txtMaSB.Text;
                conn.Open();
                string strsql = "DELETE FROM SANBAY WHERE MaSanBay=@MaSanBay";
                SqlCommand command = new SqlCommand(strsql, conn);
                command.Parameters.AddWithValue("@MaSanBay", masb);
                command.ExecuteNonQuery();
                MessageBox.Show("Đã xóa thành công.", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                string sql = "SELECT * FROM SANBAY";
                SqlCommand command1 = new SqlCommand(sql, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(command1);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dataDanhSachSB.DataSource = table;
                txtMaSB.Text = "";
                txtTenSB.Text = "";
            }
            catch (InvalidOperationException ex)
            {
                //xu ly khi ket noi co van de
                MessageBox.Show("Khong the mo ket noi hoac ket noi da mo truoc do");
            }
            catch (Exception ex)
            {
                //xu ly khi ket noi co van de
                // MessageBox.Show("Ket noi xay ra loi hoac doc du lieu bi loi");
                MessageBox.Show(ex.Message);
            }
            finally
            {
                //Dong ket noi sau khi thao tac ket thuc
                conn.Close();
            }
        }
        int index;
        private void dataDanhSachSB_Click(object sender, EventArgs e)
        {
            index = dataDanhSachSB.CurrentRow.Index;
            txtMaSB.Text = dataDanhSachSB.Rows[index].Cells[0].Value.ToString();
            txtTenSB.Text = dataDanhSachSB.Rows[index].Cells[1].Value.ToString();
            
        }
    }
}
