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
    public partial class frmPhieuDatCho : Form
    {
        Form main;
        
        public frmPhieuDatCho(Form frmMain)
        {
            InitializeComponent();
            this.main = frmMain;
            
        }
        // string strconn2 = @"Data Source=DESKTOP-TA2HS1O\SQLEXPRESS;Initial Catalog=QLBanVeChuyenBay;Integrated Security=True"; //cua ha anh

        string strconn2 = @"Data Source=DESKTOP-JLJ2TBG;Initial Catalog=QLBanVeChuyenBay;Integrated Security=True";
        public void Connection()
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
            private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmPhieuDatCho_Load(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
            main.Show();
        }

        private void tSbtnDanhSachCB_Click(object sender, EventArgs e)
        {
            Form danhsachcb = new frmDanSachCB(this);
            this.Hide();
            danhsachcb.Show();
        }

        private void txtHangVe_TextChanged(object sender, EventArgs e)
        {

        }
        string NgayDat;
        private void btnXem_Click(object sender, EventArgs e)
        {
            
            
 
                SqlConnection conn = new SqlConnection(strconn2);
                try
                {
                    conn.Open();
                if (txtNhapMaVe.Text != "" && txtNhapTenKH.Text == "")
                {
                    string MaVe = txtNhapMaVe.Text;
                    string sqlQuery = "select HK.MaHanhKhach ,HK.SDT,HK.HoTen HoTen,HK.CMMD CMND,CB.MaCB , SBdi.TenSanBay SanBayDi, SBden.TenSanBay SanBayDen,VE.HangVe,VE.GiaVe  ,CB.NgayGio NgayBay from(CHUYENBAY CB join SANBAY SBdi on CB.SanBayDi = SBdi.MaSanBay join SANBAY SBden on CB.SanBayden = SBden.MaSanBay) join PHIEUDATCHO PH on CB.MaCB = PH.MaCB join VE on PH.MaVe = VE.MaVe join HANHKHACH HK on VE.MaHanhKhach = HK.MaHanhKhach where VE.MaVe=@MaVe";
                    SqlCommand command = new SqlCommand(sqlQuery, conn);
                    command.Parameters.AddWithValue("@MaVe", MaVe);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    if (table.Rows.Count == 0)
                    {
                        MessageBox.Show("Không tìm thấy thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtNhapMaVe.Text = "";
                        txtNhapTenKH.ReadOnly = false;
                        return;
                    }
                    foreach (DataRow row in table.Rows)
                    {
                        foreach (DataColumn column in table.Columns)
                        {
                            txtMaCB.Text = row["MaCB"].ToString();
                           
                            txtSanBayDi.Text = row["SanBayDi"].ToString();
                            txtSanBayDen.Text = row["SanBayDen"].ToString();
                            txtNgayBay.Text = row["NgayBay"].ToString();
                            txtMaKH.Text = row["MaHanhKhach"].ToString();
                            txtHoTenKH.Text = row["HoTen"].ToString();
                            txtCMND.Text = row["CMND"].ToString();
                            txtSDT.Text = row["SDT"].ToString();
                            txtMaVe.Text = MaVe;
                            txtHangVe.Text = row["HangVe"].ToString();
                            txtGiaVe.Text = row["GiaVe"].ToString();
                        }
                    }
                }
                else if(txtNhapMaVe.Text == "" && txtNhapTenKH.Text != "")
                {
                    string TenHK = txtNhapTenKH.Text;
                    string sqlQuery2 = "select HK.MaHanhKhach ,HK.SDT,HK.HoTen HoTen,HK.CMMD CMND,CB.MaCB , SBdi.TenSanBay SanBayDi, SBden.TenSanBay SanBayDen,VE.HangVe,VE.MaVe,VE.GiaVe  ,CB.NgayGio NgayBay,PH.NgayDat from(CHUYENBAY CB join SANBAY SBdi on CB.SanBayDi = SBdi.MaSanBay join SANBAY SBden on CB.SanBayden = SBden.MaSanBay) join PHIEUDATCHO PH on CB.MaCB = PH.MaCB join VE on PH.MaVe = VE.MaVe join HANHKHACH HK on VE.MaHanhKhach = HK.MaHanhKhach where HK.HoTen=@HoTen";
                    SqlCommand command2 = new SqlCommand(sqlQuery2, conn);
                    command2.Parameters.AddWithValue("@HoTen", TenHK);
                    SqlDataAdapter adapter2 = new SqlDataAdapter(command2);
                    DataTable table2 = new DataTable();
                    adapter2.Fill(table2);
                    if(table2.Rows.Count ==0)
                    {
                        MessageBox.Show("Không tìm thấy thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtNhapTenKH.Text = "";
                        txtNhapMaVe.ReadOnly = false;
                        rtxtPhieuDatCho.Clear();
                        rtxtPhieuDatCho.Text = "\n\n\n\t\t\tNGU QUÁ";
                        return;
                    }
                    foreach (DataRow row in table2.Rows)
                    {
                        foreach (DataColumn column in table2.Columns)
                        {
                            
                            txtMaCB.Text = row["MaCB"].ToString();
                            txtSanBayDi.Text = row["SanBayDi"].ToString();
                            txtSanBayDen.Text = row["SanBayDen"].ToString();
                            txtNgayBay.Text = row["NgayBay"].ToString();
                            txtMaKH.Text = row["MaHanhKhach"].ToString();
                            txtHoTenKH.Text = row["HoTen"].ToString();
                            txtCMND.Text = row["CMND"].ToString();
                            txtSDT.Text = row["SDT"].ToString();
                            txtMaVe.Text = row["MaVe"].ToString();
                            txtHangVe.Text = row["HangVe"].ToString();
                            txtGiaVe.Text = row["GiaVe"].ToString();
                            NgayDat = row["NgayDat"].ToString();
                        }
                    }
                }

                txtNhapMaVe.Text = "";
                txtNhapTenKH.Text = "";
                txtNhapMaVe.ReadOnly = false;
                txtNhapTenKH.ReadOnly = false;
                //Mặc dù hơi cùi nhưng thôi làm vậy cho nó đơn giản mình ạ...@@
                rtxtPhieuDatCho.ReadOnly = true;
                rtxtPhieuDatCho.Text = "\t\t\tPHIẾU ĐẶT CHỖ" + "\n\n\n\n  Họ và Tên: " + txtHoTenKH.Text + "\n\n  SDT: " + txtSDT.Text
                    + "\t\t\tCMND: " + txtCMND.Text + "\n\n  Đã đặt chuyến bay đi từ sân bay " + txtSanBayDi.Text + " đến sân bay " + txtSanBayDen.Text
                    + " vào lúc " + txtNgayBay.Text + "." + "\n\n  Mã số vé: " + txtMaVe.Text + "\t\t\tHạng vé: " + txtHangVe.Text + "\n\n  Giá vé: " + txtGiaVe.Text
                    + "\n\n  Tình trạng: Đã thanh toán." + "\n\n  Vui lòng mang phiếu này khi bạn chuẩn bị lên máy bay, chúng tôi sẽ đối chứng. Nếu trường hợp bị mất vui lòng liên hệ tới tổng đài 18001000 để được hỗ trợ."
                    + "\n\n \t\t\t\t\t\t\t\t\t\t\t Quản Lý Bán Vé " + "\n\t\t\t\t\t\t\t\t\t\t\t  " + frmLogin.username.ToString(); ;
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

        private void txtNhapMaVe_TextChanged(object sender, EventArgs e)
        {
            txtNhapTenKH.ReadOnly = true;
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void txtNhapTenKH_TextChanged(object sender, EventArgs e)
        {
            txtNhapMaVe.ReadOnly = true;
        }

        private void rtxtPhieuDatCho_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtGiaVe_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            
            SqlConnection conn = new SqlConnection(strconn2);
            try
            {
                conn.Open();
                string sqlQuery = "Update HANHKHACH set HoTen=@HoTen,SDT=@SDT, CMMD=@CMMD where MaHanhKhach=@MaHanhKhach";
                SqlCommand command = new SqlCommand(sqlQuery, conn);
                command.Parameters.AddWithValue("@MaHanhKhach", txtMaKH.Text);
                command.Parameters.AddWithValue("@SDT",txtSDT.Text);
                command.Parameters.AddWithValue("@CMMD",txtCMND.Text);
                command.Parameters.AddWithValue("@HoTen",txtHoTenKH.Text);
                command.ExecuteNonQuery();
                MessageBox.Show("Sua thong tin thanh cong.", "Thong Bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                rtxtPhieuDatCho.Text = "\t\t\tPHIẾU ĐẶT CHỖ" + "\n\n\n\n  Họ và Tên: " + txtHoTenKH.Text + "\n\n  SDT: " + txtSDT.Text
                   + "\t\t\tCMND: " + txtCMND.Text + "\n\n  Đã đặt chuyến bay đi từ sân bay " + txtSanBayDi.Text + " đến sân bay " + txtSanBayDen.Text
                   + " vào lúc " + txtNgayBay.Text + "." + "\n\n  Mã số vé: " + txtMaVe.Text + "\t\t\tHạng vé: " + txtHangVe.Text + "\n\n  Giá vé: " + txtGiaVe.Text
                   + "\n\n  Tình trạng: Đã thanh toán." + "\n\n  Vui lòng mang phiếu này khi bạn chuẩn bị lên máy bay, chúng tôi sẽ đối chứng. Nếu trường hợp bị mất vui lòng liên hệ tới tổng đài 18001000 để được hỗ trợ."
                   + "\n\n \t\t\t\t\t\t\t\t\t\t\t Quản Lý Bán Vé " + "\n\t\t\t\t\t\t\t\t\t\t\t  " + frmLogin.username.ToString(); ;
            }
            catch (InvalidOperationException ex)
            {
                //xu ly khi ket noi co van de
                MessageBox.Show("Khong the mo ket noi hoac ket noi da mo truoc do");
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

        private void btnInPhieu_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Vui lòng kết nối máy in.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }
    }
}
