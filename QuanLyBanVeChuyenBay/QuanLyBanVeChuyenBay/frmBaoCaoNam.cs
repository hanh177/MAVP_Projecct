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
    public partial class frmBaoCaoNam : Form
    {
        Form baocaothang;
        public frmBaoCaoNam(Form frmBaoCaoThang)
        {
            InitializeComponent();
            this.baocaothang = frmBaoCaoThang;
        }

        string strconn2 = @"Data Source=DESKTOP-TA2HS1O\SQLEXPRESS;Initial Catalog=QLBanVeChuyenBay;Integrated Security=True"; //cua ha anh

        //string strconn2 = @"Data Source=DESKTOP-JLJ2TBG;Initial Catalog=QLBanVeChuyenBay;Integrated Security=True"; //cua Vuong
        string MaDoanhThuNam;
        private void Connection()
        {

            SqlConnection conn = new SqlConnection(strconn2);
            try
            {
                conn.Open();
                string sql = "select MaDoanhThuNam from TONGDOANHTHUNAM";
                SqlCommand command1 = new SqlCommand(sql, conn);
                SqlDataAdapter adapter1 = new SqlDataAdapter(command1);
                DataTable table1 = new DataTable();
                adapter1.Fill(table1);
                foreach (DataRow row in table1.Rows)
                {
                    foreach (DataColumn col in table1.Columns)
                    {
                        MaDoanhThuNam = row["MaDoanhThuNam"].ToString();
                        cmbNam.Items.Add(MaDoanhThuNam.Substring(3));
                    }
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

        private void frmBaoCaoNam_Load(object sender, EventArgs e)
        {
            Connection();
            cmbNam.SelectedIndex = -1;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
            baocaothang.Show();
        }
        DataTable table1 = new DataTable();
        private void btnXem_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(strconn2);
            try
            {
                table1.Clear();
                conn.Open();
                string str_sql = "select DTT.Thang,SoChuyenBay,DTT.TongDoanhThu,DTT.TiLe " +
                "from TONGDOANHTHUTHANG DTT join TONGDOANHTHUNAM DTN on DTT.MaDoanhThuNam=DTN.MaDoanhThuNam where DTN.MaDoanhThuNam= '";
                string sqlQuery1 = "", str_nam = "";
                if (cmbNam.SelectedIndex == -1)
                {
                    lblTieuDe.Text = "DOANH THU CỦA NĂM ";
                    txtTongDoanhThu.Text = "";
                    txtTiLe.Text = "";
                    MessageBox.Show("Lỗi cú pháp, vui lòng kiểm tra lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    
                }
                else
                {
                    lblTieuDe.Text = "DOANH THU CỦA NĂM " + cmbNam.SelectedItem.ToString();
                    str_nam = "DTN" + cmbNam.SelectedItem.ToString() + "'";
                    sqlQuery1 = str_sql + str_nam;
                    SqlCommand command1 = new SqlCommand(sqlQuery1, conn);
                    SqlDataAdapter adapter1 = new SqlDataAdapter(command1);
                  
                    adapter1.Fill(table1);
                    dataDoanhThuNam.DataSource = table1;

                    //insert vao may cai textbox
                    string sqlQuery2 = "select TongDoanhThu,TiLe from TONGDOANHTHUNAM where MaDoanhThuNam= '" + str_nam;
                    SqlCommand command2 = new SqlCommand(sqlQuery2, conn);
                    SqlDataAdapter adapter2 = new SqlDataAdapter(command2);
                    DataTable table2 = new DataTable();
                    adapter2.Fill(table2);
                    foreach (DataRow row in table2.Rows)
                    {
                        foreach (DataColumn col in table2.Columns)
                        {
                            txtTongDoanhThu.Text = row["TongDoanhThu"].ToString();
                            txtTiLe.Text = row["TiLe"].ToString();
                        }
                    }
                }
                str_nam = sqlQuery1 = "";
                cmbNam.SelectedIndex = -1;
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
    }
}
