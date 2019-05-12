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
    public partial class frmBanVe : Form
    {
        Form main;
        public event EventHandler Button_Clicked;
        public frmBanVe(Form frmMain)
        {
            InitializeComponent();
            this.main = frmMain;
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        string strconn = @"Data Source=DESKTOP-TA2HS1O\SQLEXPRESS;Initial Catalog=QLBanVeChuyenBay;Integrated Security=True";
        float DonGia;
        int GheTrongH1, GheTrongH2 ;
        bool ConGheH1 , ConGheH2,  DatVe = true;
        private void Connection()
        {
            SqlConnection conn = new SqlConnection(strconn);

            try
            {
                conn.Open();
                string sql = "SELECT MaCB FROM CHUYENBAY";
                SqlCommand command = new SqlCommand(sql, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable table = new DataTable();             
                adapter.Fill(table);
                foreach (DataRow row in table.Rows)
                {
                    cmbMaCB.Items.Add(row["MaCB"].ToString());
                }              
               command.ExecuteNonQuery();
          
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

        private void frmBanVe_Load(object sender, EventArgs e)
        {
            Connection();
            GheTrongH1 = 0;
            GheTrongH2 = 0;
            DonGia = 0;
            ConGheH1 = true;
            ConGheH2 = true;
            DatVe = true;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
            main.Show();
        }

        private void btnDanhSachCB_Click(object sender, EventArgs e)
        {
            Form danhsachcb = new frmDanSachCB(this);
            this.Hide();
            danhsachcb.Show();
        }

        private void tSbtnPhieuDatCho_Click(object sender, EventArgs e)
        {
            Form phieudatcho = new frmPhieuDatCho(this);
            this.Hide();
            phieudatcho.Show();
        }

        private void tSbtnDanhSachCB_Click(object sender, EventArgs e)
        {
            Form danhsachcb = new frmDanSachCB(this);
            this.Hide();
            danhsachcb.Show();
        }

   

        private void btnDatVe_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(strconn);

            try
            {




                string MaCB = cmbMaCB.SelectedItem.ToString();
                string MaVe = txtMaVe.Text;
                int HangVe = Int32.Parse(cmbHangVe.SelectedItem.ToString());
                float GiaVe = Int32.Parse(txtGiaVe.Text);
                string MaHanhKhach = txtMaKH.Text;
                string HoTen = txtHoTen.Text;
                string CMND = txtCMND.Text;
                string SDT = txtSDT.Text;




                conn.Open();

                //Kiem tra con ghe trong de dat hay khong
                int GheDatH1 = 0;
                int GheDatH2 = 0;

                if (HangVe == 1 && ConGheH1 == true)
                {
                    GheDatH1 = 1;
                    DatVe = true;
                }
                else
                {
                    if (HangVe == 2 && ConGheH2 == true)
                    {
                        GheDatH2 = 1;
                        DatVe = true;
                    }

                    else MessageBox.Show("Không còn ghế");
                }
                if (DatVe == true)
                {
                    //insert hanh khach

                    String sqlQuery1 = "insert into [QLBanVeChuyenBay].[dbo].[HANHKHACH] values ( " + "@MaHanhKhach, @HoTen, @CMND, @SDT)";
                    SqlCommand command1 = new SqlCommand(sqlQuery1, conn);
                    command1.Parameters.AddWithValue("@MaHanhKhach", MaHanhKhach);
                    command1.Parameters.AddWithValue("@HoTen", HoTen);
                    command1.Parameters.AddWithValue("@CMND", CMND);
                    command1.Parameters.AddWithValue("@SDT", SDT);
                    command1.ExecuteNonQuery();


                    //insert ve

                    String sqlQuery2 = "insert into [QLBanVeChuyenBay].[dbo].[Ve] values ( " + "@MaVe, @MaHanhKhach, @MaCB, @GiaVe, @HangVe)";
                    SqlCommand command2 = new SqlCommand(sqlQuery2, conn);
                    command2.Parameters.AddWithValue("@MaVe", MaVe);
                    command2.Parameters.AddWithValue("@MaHanhKhach", MaHanhKhach);
                    command2.Parameters.AddWithValue("@MaCB", MaCB);
                    command2.Parameters.AddWithValue("@GiaVe", GiaVe);
                    command2.Parameters.AddWithValue("@HangVe", HangVe);
                    command2.ExecuteNonQuery();

                    MessageBox.Show("Đặt vé thành công", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    // Cap nhat bang TINHTRANG

                    string sqlQuery3 = "Update TINHTRANG set SLGheTrongH1 = SLGheTrongH1 - " + GheDatH1 +
                        ", SLGheTrongH2 = SLGheTrongH2 -" + GheDatH2 +
                        ", TongSoGhe = TongSoGhe - 1, TongSoGheTrong = TongSoGheTrong - 1, TongSoGheDat =TongSoGheDat + 1 where MaCB = '"
                        + MaCB + "' ";
                    SqlCommand command3 = new SqlCommand(sqlQuery3, conn);
                    command3.ExecuteNonQuery();



                    txtCMND.Text = "";
                    txtGiaVe.Text = "";
                    txtHoTen.Text = "";
                    txtMaKH.Text = "";
                    txtMaVe.Text = "";
                    txtSDT.Text = "";
                    cmbHangVe.Text = "";
                    cmbMaCB.Text = "";

                }
                else MessageBox.Show("Không còn ghế trống hạng "+ HangVe +" để đặt");
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


        private void cmbMaCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            string MaCB = cmbMaCB.SelectedItem.ToString();
            SqlConnection conn = new SqlConnection(strconn);
            try
            {
                String sqlQuery = "Select GiaVe  from CHUYENBAY where MaCB = '" + MaCB + "'";
                SqlCommand command = new SqlCommand(sqlQuery, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable table = new DataTable();
                adapter.Fill(table);
                string s = "";
                foreach (DataRow row in table.Rows)
                {

                    s = row["GiaVe"].ToString();
                }
                DonGia = Int32.Parse(s);
               
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

        private void cmbHangVe_SelectedIndexChanged(object sender, EventArgs e)
        {
            
                SqlConnection conn = new SqlConnection(strconn);

            try
            {
                conn.Open();

                //Kiem tra con ghe trong de dat hay khong

                string sqlQuery = "select SLGheTrongH1, SLGheTrongH2 from TINHTRANG where MaCB ='" + cmbMaCB.SelectedItem.ToString() + "'";
                SqlCommand command = new SqlCommand(sqlQuery, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable table = new DataTable();
                adapter.Fill(table);
                foreach (DataRow row in table.Rows)
                {
                    foreach (DataColumn column in table.Columns)
                    {
                        GheTrongH1 = Int32.Parse(row["SLGheTrongH1"].ToString());
                        GheTrongH2 = Int32.Parse(row["SLGheTrongH2"].ToString());
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
                // MessageBox.Show("Ket noi xay ra loi hoac doc du lieu bi loi");
                MessageBox.Show(ex.Message);
            }
            finally
            {
                //Dong ket noi sau khi thao tac ket thuc
                conn.Close();
            }
            if (cmbHangVe.SelectedItem.ToString() == "1")
            {
                if (GheTrongH1 == 0)
                {
                    MessageBox.Show("Chuyến bay không còn ghế trống hạng 1", "Lỗi");
                    ConGheH1 = false;
                }
                else
                {
                    float h1 = DonGia * (float)1.05;

                    txtGiaVe.Text = h1.ToString();
                }
            }
            if (cmbHangVe.SelectedItem.ToString() == "2")
            {
                if (GheTrongH2 == 0)
                {
                    MessageBox.Show("Chuyến bay không còn ghế trống hạng 2", "Lỗi");
                    ConGheH2 = false;
                }
                else
                    txtGiaVe.Text = DonGia.ToString();
            }

        }
    }
}
