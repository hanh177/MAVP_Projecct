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
    public partial class frmBaoCaoThang : Form
    {
        Form main;
        public frmBaoCaoThang(Form frmMain)
        {
            InitializeComponent();
            this.main = frmMain;
        }
        string MaDoanhThuNam;
        string strconn2 = frmMain.strconn2;
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

        private void frmBaoCaoThang_Load(object sender, EventArgs e)
        {
            Connection(); 
            cmbThang.SelectedIndex = -1;
            cmbNam.SelectedIndex = -1;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
            main.Show();
        }

        private void btnBaoCaoNam_Click(object sender, EventArgs e)
        {
            Form baocaonam = new frmBaoCaoNam(this);
            this.Hide();
            baocaonam.ShowDialog();
        }

        //Ham kiem tra thang da qua hay chua
        public bool KiemtraThang(DateTime date,string thangkiemtra,string namkiemtra)
        {
            string hientai = date.ToString();
            string[] arr_tg = (hientai).Split(' ');
            string[] arr_tg2 = arr_tg[0].Split('/');//mang chua thang/ngay/nam cua hien tai
            string thanghientai = arr_tg2[0];
            string namhientai = arr_tg2[2];
            if (Int32.Parse(namhientai) > Int32.Parse(namkiemtra))
                return true;
            else
            {
                if (Int32.Parse(namhientai) == Int32.Parse(namkiemtra))
                {
                    if (Int32.Parse(thanghientai) > Int32.Parse(thangkiemtra))
                        return true;
                    else
                        return false;
                }
                else//nam hien tai be hon nam kiem tra
                    return false;
            }


            return false;
        }
        DataTable table1 = new DataTable();
        bool flag_thang = true;
        private void btnXem_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(strconn2);
            try
            {
                table1.Clear();
                string str = "select DTCB.MaCB, SoVe, DoanhThu,DTCB.TiLe" +
                " from DOANHTHUTHANGCB DTCB join TONGDOANHTHUTHANG DTT on DTCB.MaDoanhThuThang = DTT.MaDoanhThuThang join TONGDOANHTHUNAM DTN on DTT.MaDoanhThuNam = DTN.MaDoanhThuNam where ";
                string str_thang = "", str_nam = "", sqlQuery = "";
               
                if (cmbThang.SelectedIndex==-1|| cmbNam.SelectedIndex == -1)
                {
                    lblTieuDe.Text = "DOANH THU THÁNG CỦA NĂM";
                    txtTongCB.Text = "";
                    txtDoanhThu.Text = "";
                    txtTiLe.Text = "";
                    MessageBox.Show("Cú pháp sai, vui lòng kiểm tra lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    
                    return;
                }
                else
                {
                    str_thang = "DTT.Thang= '" + cmbThang.SelectedItem.ToString() + "'";
                    str_nam = " and DTN.MaDoanhThuNam= '" + "DTN" + cmbNam.SelectedItem.ToString() + "'";
                    //Kiem tra dieu kien da qua thang moi hien thi bang doanh thu
                    DateTime d = DateTime.Now;
                    if (KiemtraThang(d, cmbThang.SelectedItem.ToString(), cmbNam.SelectedItem.ToString()) == false)
                    {
                        flag_thang = false;
                    }
                    else
                    {
                        lblTieuDe.Text = "DOANH THU THÁNG " + Int32.Parse(cmbThang.SelectedItem.ToString()) + " CỦA NĂM " + Int32.Parse(cmbNam.SelectedItem.ToString());
                        sqlQuery = str + str_thang + str_nam;
                        SqlCommand command1 = new SqlCommand(sqlQuery, conn);
                        SqlDataAdapter adapter1 = new SqlDataAdapter(command1);
                        adapter1.Fill(table1);
                    }
                    if (table1.Rows.Count == 0||flag_thang==false)
                    {
                        MessageBox.Show("Không có dữ liệu được tìm thấy.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtTongCB.Text = "";
                        txtDoanhThu.Text = "";
                        txtTiLe.Text = "";
                    }
                    else
                    {
                        dataDoanhThuThang.DataSource = table1;
                        str_thang = "";
                        str_nam = "";


                        //insert vao may cai textbox
                        string sqlQuery2 = "select DTT.SoChuyenBay,DTT.TongDoanhThu,DTT.TiLe from TONGDOANHTHUTHANG DTT " +
                        "join TONGDOANHTHUNAM DTN on DTT.MaDoanhThuNam=DTN.MaDoanhThuNam where DTT.Thang= '" + cmbThang.SelectedItem.ToString() + "'";
                        SqlCommand command2 = new SqlCommand(sqlQuery2, conn);
                        SqlDataAdapter adapter2 = new SqlDataAdapter(command2);
                        DataTable table2 = new DataTable();
                        adapter2.Fill(table2);
                        foreach (DataRow row in table2.Rows)
                        {
                            foreach (DataColumn col in table2.Columns)
                            {
                                txtTongCB.Text = row["SoChuyenBay"].ToString();
                                txtDoanhThu.Text = row["TongDoanhThu"].ToString();
                                txtTiLe.Text = row["TiLe"].ToString();
                            }
                        }

                    }
                }
            cmbThang.SelectedIndex = -1;
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
