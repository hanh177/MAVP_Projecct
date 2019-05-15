using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Globalization;

namespace QuanLyBanVeChuyenBay
{
    public partial class frmTraCuu : Form
    {
        Form main;
        public frmTraCuu(Form frmMain)
        {
            InitializeComponent();
            this.main = frmMain;
        }
        string strconn = @"Data Source=DESKTOP-JLJ2TBG;Initial Catalog=QLBanVeChuyenBay;Integrated Security=True";
        private void Connection()
        {
            SqlConnection conn = new SqlConnection(strconn);
            try
            {
                conn.Open();
                string sql = "select * from SANBAY";
                SqlCommand command = new SqlCommand(sql, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable table1 = new DataTable();
                DataTable table2 = new DataTable();
                adapter.Fill(table1);
                adapter.Fill(table2);

                string sql2 = "select * from CHUYENBAY";
                SqlCommand command2 = new SqlCommand(sql2, conn);
                SqlDataAdapter adapter2 = new SqlDataAdapter(command2);
                DataTable table3 = new DataTable();
                adapter2.Fill(table3);

                cmbSanBayDi.DataSource = table1;
                cmbSanBayDi.DisplayMember = "TenSanBay";
                cmbSanBayDi.ValueMember = "MaSanBay";
                cmbSanBayDi.SelectedIndex = -1;

                cmbSanBayDen.DataSource = table2;
                cmbSanBayDen.DisplayMember = "TenSanBay";
                cmbSanBayDen.ValueMember = "MaSanBay";
                cmbSanBayDen.SelectedIndex = -1;

                cmbMaCB.DataSource = table3;
                cmbMaCB.DisplayMember = "MaCB";
                cmbMaCB.ValueMember = "MaCB";
                cmbMaCB.SelectedIndex = -1;

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
        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void frmTraCuu_Load(object sender, EventArgs e)
        {
           
            Connection();
            dataDanhSachCB.DataSource="";
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {

            this.Close();
            main.Show();
        }

        private void btnDanhSach_Click(object sender, EventArgs e)
        {
            Form danhsachcb = new frmDanSachCB(this);
            this.Hide();
            danhsachcb.Show();

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
         
        private void btnTraCuu_Click(object sender, EventArgs e)
        {

           

            SqlConnection conn = new SqlConnection(strconn);
            try
            {
                conn.Open();
                if (cmbMaCB.SelectedIndex!=-1 && cmbSanBayDi.SelectedIndex == -1 && cmbSanBayDen.SelectedIndex == -1 && txtNgayBay.Text=="")
               //Chi tim kiem bang MaCB
                {
                    string MACB = cmbMaCB.SelectedValue.ToString();
                    string sql = "select CB.MaCB, SBdi.TenSanBay SanBayDi, SBden.TenSanBay SanBayDen,CB.ThoiGianBay, SB_TG.TenSanBay SanBayTG, TG.ThoiGianDung, CB.NgayGio,  TT.TongSoGhe,  TT.TongSoGheTrong, CB.GiaVe, TT.SLGheTrongH1, TT.SLGheTrongH2 from(CHUYENBAY CB join SANBAY SBdi on CB.SanBayDi = SBdi.MaSanBay join SANBAY SBden on CB.SanBayden = SBden.MaSanBay) join(CHUYENBAY left join TRUNGGIAN TG on CHUYENBAY.MaCB = TG.MaCB left join SANBAY SB_TG on TG.MaSanBay = SB_TG.MaSanBay) on CB.MaCB = CHUYENBAY.MaCB join TINHTRANG TT on CB.MaCB = TT.MaCB where CB.MaCB=@MaCB";
                    SqlCommand command = new SqlCommand(sql, conn);
                    command.Parameters.AddWithValue("@MaCB",MACB);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                   dataDanhSachCB.DataSource = table; 
                }
                else if(cmbSanBayDi.SelectedIndex!=-1 &&cmbSanBayDen.SelectedIndex!=-1 && cmbMaCB.SelectedIndex == -1 && txtNgayBay.Text == "")
                //Chi tim kiem bang SanBayDi va SanBayDen
                {
                    string SANBAYDI = cmbSanBayDi.SelectedValue.ToString();
                    string SANBAYDEN = cmbSanBayDen.SelectedValue.ToString();
                    string sql = "select CB.MaCB, SBdi.TenSanBay SanBayDi, SBden.TenSanBay SanBayDen,CB.ThoiGianBay, SB_TG.TenSanBay SanBayTG, TG.ThoiGianDung, CB.NgayGio,  TT.TongSoGhe,  TT.TongSoGheTrong, CB.GiaVe, TT.SLGheTrongH1, TT.SLGheTrongH2 from(CHUYENBAY CB join SANBAY SBdi on CB.SanBayDi = SBdi.MaSanBay join SANBAY SBden on CB.SanBayden = SBden.MaSanBay) join(CHUYENBAY left join TRUNGGIAN TG on CHUYENBAY.MaCB = TG.MaCB left join SANBAY SB_TG on TG.MaSanBay = SB_TG.MaSanBay) on CB.MaCB = CHUYENBAY.MaCB join TINHTRANG TT on CB.MaCB = TT.MaCB where CB.SanBayDi=@SanBayDi and CB.SanBayDen=@SanBayDen";
                    SqlCommand command = new SqlCommand(sql, conn);
                    command.Parameters.AddWithValue("@SanBayDi", SANBAYDI);
                    command.Parameters.AddWithValue("@SanBayDen", SANBAYDEN);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                  
                    dataDanhSachCB.DataSource = table;
                }
                 else if(txtNgayBay.Text!="" && cmbMaCB.SelectedIndex == -1 && cmbSanBayDi.SelectedIndex == -1 && cmbSanBayDen.SelectedIndex == -1)
                //Chi tim kiem bang NgayBay
                 {
                     DateTime NGAYBAY = DateTime.ParseExact(txtNgayBay.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                     //string NGAYBAY = txtNgayBay.Text;
                     string sql = "select CB.MaCB, SBdi.TenSanBay SanBayDi, SBden.TenSanBay SanBayDen,CB.ThoiGianBay, SB_TG.TenSanBay SanBayTG, TG.ThoiGianDung, CB.NgayGio,  TT.TongSoGhe,  TT.TongSoGheTrong, CB.GiaVe, TT.SLGheTrongH1, TT.SLGheTrongH2 from(CHUYENBAY CB join SANBAY SBdi on CB.SanBayDi = SBdi.MaSanBay join SANBAY SBden on CB.SanBayden = SBden.MaSanBay) join(CHUYENBAY left join TRUNGGIAN TG on CHUYENBAY.MaCB = TG.MaCB left join SANBAY SB_TG on TG.MaSanBay = SB_TG.MaSanBay) on CB.MaCB = CHUYENBAY.MaCB join TINHTRANG TT on CB.MaCB = TT.MaCB where  CB.NgayGio=@NgayGio";
                     SqlCommand command = new SqlCommand(sql, conn);
                     command.Parameters.AddWithValue("@NgayGio", NGAYBAY);

                     SqlDataAdapter adapter = new SqlDataAdapter(command);
                     DataTable table = new DataTable();
                     adapter.Fill(table);
                     dataDanhSachCB.DataSource = table;
                 }
                 else if(cmbMaCB.SelectedIndex != -1 && cmbSanBayDi.SelectedIndex == -1 && cmbSanBayDen.SelectedIndex != -1 && txtNgayBay.Text=="")
                //Tim kiem bang MaCB va SanBayDen
                 {
                    string MACB = cmbMaCB.SelectedValue.ToString();
                    string SANBAYDEN = cmbSanBayDen.SelectedValue.ToString();
                    string sql = "select CB.MaCB, SBdi.TenSanBay SanBayDi, SBden.TenSanBay SanBayDen,CB.ThoiGianBay, SB_TG.TenSanBay SanBayTG, TG.ThoiGianDung, CB.NgayGio,  TT.TongSoGhe,  TT.TongSoGheTrong, CB.GiaVe, TT.SLGheTrongH1, TT.SLGheTrongH2 from(CHUYENBAY CB join SANBAY SBdi on CB.SanBayDi = SBdi.MaSanBay join SANBAY SBden on CB.SanBayden = SBden.MaSanBay) join(CHUYENBAY left join TRUNGGIAN TG on CHUYENBAY.MaCB = TG.MaCB left join SANBAY SB_TG on TG.MaSanBay = SB_TG.MaSanBay) on CB.MaCB = CHUYENBAY.MaCB join TINHTRANG TT on CB.MaCB = TT.MaCB where CB.MaCB=@MaCB and CB.SanBayDen=@SanBayDen";
                     SqlCommand command = new SqlCommand(sql, conn);
                     command.Parameters.AddWithValue("@MaCB", MACB);
                     command.Parameters.AddWithValue("@SanBayDen", SANBAYDEN);
                     SqlDataAdapter adapter = new SqlDataAdapter(command);
                     DataTable table = new DataTable();
                     adapter.Fill(table);
                     dataDanhSachCB.DataSource = table;
                 }
                 else if(cmbMaCB.SelectedIndex != -1 && cmbSanBayDi.SelectedIndex == -1 && cmbSanBayDen.SelectedIndex == -1 && txtNgayBay.Text != "")
                 //Tim kiem bang MaCB va NgayBay
                 {
                    string MACB = cmbMaCB.SelectedValue.ToString();
                    DateTime NGAYBAY = DateTime.ParseExact(txtNgayBay.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                     string sql = "select CB.MaCB, SBdi.TenSanBay SanBayDi, SBden.TenSanBay SanBayDen,CB.ThoiGianBay, SB_TG.TenSanBay SanBayTG, TG.ThoiGianDung, CB.NgayGio,  TT.TongSoGhe,  TT.TongSoGheTrong, CB.GiaVe, TT.SLGheTrongH1, TT.SLGheTrongH2 from(CHUYENBAY CB join SANBAY SBdi on CB.SanBayDi = SBdi.MaSanBay join SANBAY SBden on CB.SanBayden = SBden.MaSanBay) join(CHUYENBAY left join TRUNGGIAN TG on CHUYENBAY.MaCB = TG.MaCB left join SANBAY SB_TG on TG.MaSanBay = SB_TG.MaSanBay) on CB.MaCB = CHUYENBAY.MaCB join TINHTRANG TT on CB.MaCB = TT.MaCB where  CB.NgayGio=@NgayGio and CB.MaCB=@MaCB";
                     SqlCommand command = new SqlCommand(sql, conn);
                     command.Parameters.AddWithValue("@NgayGio", NGAYBAY);
                     command.Parameters.AddWithValue("@MaCB", MACB);
                     SqlDataAdapter adapter = new SqlDataAdapter(command);
                     DataTable table = new DataTable();
                     adapter.Fill(table);
                     dataDanhSachCB.DataSource = table;
                 }
                 else if (cmbMaCB.SelectedIndex == -1 && cmbSanBayDi.SelectedIndex == -1 && cmbSanBayDen.SelectedIndex != -1 && txtNgayBay.Text != "")
                 //Tim kiem bang NgayBay va SanBayDen
                 {
                     DateTime NGAYBAY = DateTime.ParseExact(txtNgayBay.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                    string SANBAYDEN = cmbSanBayDen.SelectedValue.ToString();
                    string sql = "select CB.MaCB, SBdi.TenSanBay SanBayDi, SBden.TenSanBay SanBayDen,CB.ThoiGianBay, SB_TG.TenSanBay SanBayTG, TG.ThoiGianDung, CB.NgayGio,  TT.TongSoGhe,  TT.TongSoGheTrong, CB.GiaVe, TT.SLGheTrongH1, TT.SLGheTrongH2 from(CHUYENBAY CB join SANBAY SBdi on CB.SanBayDi = SBdi.MaSanBay join SANBAY SBden on CB.SanBayden = SBden.MaSanBay) join(CHUYENBAY left join TRUNGGIAN TG on CHUYENBAY.MaCB = TG.MaCB left join SANBAY SB_TG on TG.MaSanBay = SB_TG.MaSanBay) on CB.MaCB = CHUYENBAY.MaCB join TINHTRANG TT on CB.MaCB = TT.MaCB where CB.SanBayDen=@SanBayDen and CB.NgayGio=@NgayGio";
                     SqlCommand command = new SqlCommand(sql, conn);
                     command.Parameters.AddWithValue("@SanBayDen", SANBAYDEN);
                     command.Parameters.AddWithValue("@NgayGio", NGAYBAY);
                     SqlDataAdapter adapter = new SqlDataAdapter(command);
                     DataTable table = new DataTable();
                     adapter.Fill(table);
                     dataDanhSachCB.DataSource = table;
                 }
                cmbMaCB.SelectedIndex = -1;
                txtNgayBay.Text = "";
                cmbSanBayDi.SelectedIndex = -1;
                cmbSanBayDen.SelectedIndex = -1;
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

        private void dataDanhSachCB_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        int index;
        static public string macb;
        int SLGHETRONG;
        static public  int DONGIA;
        private void dataDanhSachCB_Click(object sender, EventArgs e)
        {
            index = dataDanhSachCB.CurrentRow.Index;
            macb = dataDanhSachCB.Rows[index].Cells[0].Value.ToString();
           string slghetrong= dataDanhSachCB.Rows[index].Cells[8].Value.ToString();
           SLGHETRONG= Int32.Parse(slghetrong);
           string dongia= dataDanhSachCB.Rows[index].Cells[9].Value.ToString();
            DONGIA= Int32.Parse(dongia);
        }

        private void btnDatVe_Click(object sender, EventArgs e)
        {
            Form banve = new frmBanVe(this);
            if(macb==null)
            {
                MessageBox.Show("Chưa chọn chuyến bay để đặt vé, vui lòng chọn 1 chuyến bay.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (SLGHETRONG > 0)
            {
                this.Close();
                banve.Show();
            }
            else
            {
                MessageBox.Show("Không thể đặt thêm vé vì đã hết ghế trống.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
