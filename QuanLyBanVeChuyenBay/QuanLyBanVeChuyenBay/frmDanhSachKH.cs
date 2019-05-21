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
    public partial class frmDanhSachKH : Form
    {
        Form main;
        public frmDanhSachKH(Form frmMain)
        {
            InitializeComponent();
            this.main = frmMain;
        }

        string strconn2 = @"Data Source=DESKTOP-TA2HS1O\SQLEXPRESS;Initial Catalog=QLBanVeChuyenBay;Integrated Security=True"; //cua ha anh

        // string strconn2 = @"Data Source=DESKTOP-JLJ2TBG;Initial Catalog=QLBanVeChuyenBay;Integrated Security=True";

        public void Connection()
        {

            SqlConnection conn = new SqlConnection(strconn2);
            try
            {
                conn.Open();
                string sql = "select hk.MaHanhKhach, HoTen, CMMD, v.MaVe, cb.MaCB from ve v join CHUYENBAY cb on v.MaCB=cb.MaCB join HANHKHACH hk on hk.MaHanhKhach=v.MaHanhKhach";
                SqlCommand command = new SqlCommand(sql, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dataDSKH.DataSource = table;
                dataDSKH.AutoGenerateColumns = true;



                string sql1 = "select * from CHUYENBAY";
                SqlCommand command1 = new SqlCommand(sql1, conn);
                SqlDataAdapter adapter1 = new SqlDataAdapter(command1);
                DataTable table1 = new DataTable();
                adapter1.Fill(table1);
 
                txtMaCB.DataSource = table1;
                txtMaCB.DisplayMember = "MaCB";
                txtMaCB.ValueMember = "MaCB";
                txtMaCB.SelectedIndex = -1;

                string sql2 = "select * from Hanhkhach";
                SqlCommand command2 = new SqlCommand(sql2, conn);
                SqlDataAdapter adapter2 = new SqlDataAdapter(command2);
                DataTable table2= new DataTable();
                adapter2.Fill(table2);

                txtMaKH.DataSource = table2;
                txtMaKH.DisplayMember = "MaHanhKhach";
                txtMaKH.ValueMember = "MaHanhKhach";
                txtMaKH.SelectedIndex = -1;
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
            btnLoadLai.Enabled = false;
           
        }
        private void frmDanhSachKH_Load(object sender, EventArgs e)
        {
            Connection();
            btnLoadLai.Enabled = false;
        }

        string MaKH, HoTen, CMND, MaVe, MaCB;

        private void btnLoadLai_Click(object sender, EventArgs e)
        {
            Connection();
            txtMaKH.SelectedIndex=-1;
            txtMaCB.SelectedIndex = -1;
            txtHoTen.Clear();
            txtCMND.Clear();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnHuyVe_Click(object sender, EventArgs e)
        {
           //DialogResult r =  MessageBox.Show("Bạn có chắc chắn muốn hủy vé này?", "Chú ý",  MessageBoxButtons.YesNo);
           // if(r==DialogResult.Yes)
           // {
           //     int index = dataDSKH.CurrentRow.Index;
           //     string mave = dataDSKH.Rows[index].Cells[3].Value.ToString();
           //     string makh = dataDSKH.Rows[index].Cells[0].Value.ToString();
           //     //string makh = "KH35";
           //     //string mave = "VE07";
           //     string macb = "";
           //     string hangve ="";
           //     SqlConnection conn = new SqlConnection(strconn2);
           //     try
           //     {
           //         conn.Open();
           //         //xoa phieu dat cho
           //         string query = "delete from PHIEUDATCHO where mave ='" + mave + "'";
           //         SqlCommand cmd = new SqlCommand(query, conn);
           //         cmd.ExecuteNonQuery();

           //         //lay macb, hangve tu ve de cap nhat tinh trang
           //         string query1 = "select macb from ve where mave= '" + mave + "'";
           //         SqlCommand cmd1 = new SqlCommand(query1, conn);
           //         SqlDataReader re = cmd1.ExecuteReader();
           //         while (re.Read())
           //         {
           //             macb = re.GetValue(0).ToString();
           //         }

           //         string query2 = "select hangve from ve where mave= '" + mave + "'";
           //         SqlCommand cmd2 = new SqlCommand(query2, conn);
                   
           //         re = cmd2.ExecuteReader();
           //         while (re.Read())
           //         {
           //             hangve = re.GetValue(0).ToString();
           //         }
           //         MessageBox.Show(macb, hangve);
           //         //xoa ve
           //         string query3 = "delete from ve where mave= '" + mave + "'";
           //         SqlCommand cmd3 = new SqlCommand(query3, conn);
           //         cmd3.ExecuteNonQuery();

           //         //xoa hanh khach
           //         string query4 = "delete from Hanhkhach where mahanhkhach= '" + makh + "'";
           //         SqlCommand cmd4 = new SqlCommand(query4, conn);
           //         cmd4.ExecuteNonQuery();


           //         //cap nhat bang tinh trang

           //         string query5, s;
           //         if (hangve == "1") s = "SLGheTrongH1 = SLGheTrong1 + 1,";
           //         else s = "SLGheTrongH2 = SLGheTrong2 + 1,";
           //         query5 = "update TINHTRANG set " + s + "  Tongsoghetrong = tongsoghetrong + 1, tongsoghedat = tongsoghedat - 1,   where macb ='" + macb + "' ";
           //         SqlCommand cmd5 = new SqlCommand(query5, conn);
           //         cmd5.ExecuteNonQuery();


           //         MessageBox.Show("Hủy vé thành công !");
           //         Connection();
           //     }
           //     catch (InvalidOperationException ex)
           //     {
           //         //xu ly khi ket noi co van de
           //         MessageBox.Show("Khong the mo ket noi hoac ket noi da mo truoc do");
           //     }
           //     catch (Exception ex)
           //     {
           //         //xu ly khi ket noi co van de
           //         MessageBox.Show("Ket noi xay ra loi hoac doc du lieu bi loi");
           //     }
           //     finally
           //     {
           //         //Dong ket noi sau khi thao tac ket thuc
           //         conn.Close();
           //     }
           // }

        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(strconn2);
            try
            {
                conn.Open();

                string str1 = "select hk.MaHanhKhach, HoTen, CMMD, v.MaVe, cb.MaCB from ve v join CHUYENBAY cb on v.MaCB=cb.MaCB join HANHKHACH hk on hk.MaHanhKhach=v.MaHanhKhach where ";
                string str2, str3, str4, str5;

                if (txtHoTen.Text != "")
                    str2 = "hk.HoTen= '" + txtHoTen.Text + "'";
                else str2 = "";

                if (txtCMND.Text != "")
                {
                    if(str2!="")
                    str3 = "and hk.CMMD = '" + txtCMND.Text + "'";
                    else str3 = " hk.CMMD = '" + txtCMND.Text + "'";
                }
                else str3 = "";

                if (txtMaKH.Text != "")
                {
                    if(str2!=""||str3!="")
                    str4 = "and hk.MaHanhKhach= '" + txtMaKH.Text + "'";
                    else str4 = " hk.MaHanhKhach= '" + txtMaKH.Text + "'";
                }
                else str4 = "";

                if (txtMaCB.Text != "")
                {
                    if (str2 != "" || str3 != "" || str4 != "")
                        str5 = "and cb.MaCB= '" + txtMaCB.Text + "'";
                    else str5 = " cb.MaCB= '" + txtMaCB.Text + "'";
                }
                else str5 = "";
                if (str2 == "" && str3 == "" && str4 == "" && str5 == "")
                    MessageBox.Show("Vui lòng chọn thông tin tìm kiếm!", "Lỗi");
                else
                {
                    string query = str1 + str2 + str3 + str4 + str5;
                    SqlCommand command = new SqlCommand(query, conn);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    dataDSKH.DataSource = table;
                    btnLoadLai.Enabled = true;
                    btnHuyVe.Enabled = true;
                    btnPhieuDat.Enabled = true;
                }
            }
            catch (InvalidOperationException ex)
            {
                //xu ly khi ket noi co van de
                //MessageBox.Show("Khong the mo ket noi hoac ket noi da mo truoc do");
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                //xu ly khi ket noi co van de
                //MessageBox.Show("Ket noi xay ra loi hoac doc du lieu bi loi");
                MessageBox.Show(ex.Message);
            }
            finally
            {
                //Dong ket noi sau khi thao tac ket thuc
                conn.Close();
            }

        }
    


        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnPhieuDat_Click(object sender, EventArgs e)
        {

            this.Hide();
            Form phieu = new frmPhieuDatCho(this);
            phieu.ShowDialog();
            this.Connection();
            this.Show();
        }
    }
}
