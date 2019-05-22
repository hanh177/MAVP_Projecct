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

        string strconn2 = @"Data Source=DESKTOP-JLJ2TBG;Initial Catalog=QLBanVeChuyenBay;Integrated Security=True"; //cua Vuong

        //string strconn2 = @"Data Source=DESKTOP-TA2HS1O\SQLEXPRESS;Initial Catalog=QLBanVeChuyenBay;Integrated Security=True"; //cua ha anh
        private void Connection()
        {
            ///////////////////////////////////////////////////////////////////////////////////
            SqlConnection conn = new SqlConnection(strconn2);
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
            click_data = false;
            macb = "";
            DONGIA = 0;
            Connection();
            //dataDanhSachCB.ClearSelection();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();       
          
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
        DataTable table = new DataTable();
        private void btnTraCuu_Click(object sender, EventArgs e)
        {
            table.Clear();
            SqlConnection conn = new SqlConnection(strconn2);
            try
            {
                conn.Open();

                //Chi tim kiem bang MaCB
                if (cmbMaCB.SelectedIndex != -1 && cmbSanBayDi.SelectedIndex == -1 && cmbSanBayDen.SelectedIndex == -1 && txtNgayBay.Text == "")
               
                {
                    
                    string MACB = cmbMaCB.SelectedValue.ToString();
                    string sql = "select CB.MaCB, SBdi.TenSanBay SanBayDi, SBden.TenSanBay SanBayDen,CB.ThoiGianBay, SB_TG.TenSanBay SanBayTG, TG.ThoiGianDung, CB.NgayGio,  TT.TongSoGhe,  TT.TongSoGheTrong, CB.GiaVe, TT.SLGheTrongH1, TT.SLGheTrongH2 from(CHUYENBAY CB join SANBAY SBdi on CB.SanBayDi = SBdi.MaSanBay join SANBAY SBden on CB.SanBayden = SBden.MaSanBay) join(CHUYENBAY left join TRUNGGIAN TG on CHUYENBAY.MaCB = TG.MaCB left join SANBAY SB_TG on TG.MaSanBay = SB_TG.MaSanBay) on CB.MaCB = CHUYENBAY.MaCB join TINHTRANG TT on CB.MaCB = TT.MaCB where CB.MaCB=@MaCB";
                    SqlCommand command = new SqlCommand(sql, conn);
                    command.Parameters.AddWithValue("@MaCB", MACB);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(table);
                    dataDanhSachCB.DataSource = table;
                }

                //Chi tim kiem bang SanBayDi va SanBayDen
                else if (cmbSanBayDi.SelectedIndex != -1 && cmbSanBayDen.SelectedIndex != -1 && cmbMaCB.SelectedIndex == -1 && txtNgayBay.Text == "")
               
                {
                    string SANBAYDI = cmbSanBayDi.SelectedValue.ToString();
                    string SANBAYDEN = cmbSanBayDen.SelectedValue.ToString();
                    string sql = "select CB.MaCB, SBdi.TenSanBay SanBayDi, SBden.TenSanBay SanBayDen,CB.ThoiGianBay, SB_TG.TenSanBay SanBayTG, TG.ThoiGianDung, CB.NgayGio,  TT.TongSoGhe,  TT.TongSoGheTrong, CB.GiaVe, TT.SLGheTrongH1, TT.SLGheTrongH2 from(CHUYENBAY CB join SANBAY SBdi on CB.SanBayDi = SBdi.MaSanBay join SANBAY SBden on CB.SanBayden = SBden.MaSanBay) join(CHUYENBAY left join TRUNGGIAN TG on CHUYENBAY.MaCB = TG.MaCB left join SANBAY SB_TG on TG.MaSanBay = SB_TG.MaSanBay) on CB.MaCB = CHUYENBAY.MaCB join TINHTRANG TT on CB.MaCB = TT.MaCB where CB.SanBayDi=@SanBayDi and CB.SanBayDen=@SanBayDen";
                    SqlCommand command = new SqlCommand(sql, conn);
                    command.Parameters.AddWithValue("@SanBayDi", SANBAYDI);
                    command.Parameters.AddWithValue("@SanBayDen", SANBAYDEN);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(table);
                    if (table.Rows.Count == 0)
                    {
                        MessageBox.Show("Không tìm thấy thông tin mà bạn đang tìm kiếm.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        cmbSanBayDi.SelectedIndex = -1;
                        cmbSanBayDen.SelectedIndex = -1;
                        return;
                    }
                    dataDanhSachCB.DataSource = table;
                }

                //Chi tim kiem bang NgayBay
                else if (txtNgayBay.Text != "" && cmbMaCB.SelectedIndex == -1 && cmbSanBayDi.SelectedIndex == -1 && cmbSanBayDen.SelectedIndex == -1)
              
                {
                    DateTime NGAYBAY = DateTime.ParseExact(txtNgayBay.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                    string sql = "select CB.MaCB, SBdi.TenSanBay SanBayDi, SBden.TenSanBay SanBayDen,CB.ThoiGianBay, SB_TG.TenSanBay SanBayTG, TG.ThoiGianDung, CB.NgayGio,  TT.TongSoGhe,  TT.TongSoGheTrong, CB.GiaVe, TT.SLGheTrongH1, TT.SLGheTrongH2 from(CHUYENBAY CB join SANBAY SBdi on CB.SanBayDi = SBdi.MaSanBay join SANBAY SBden on CB.SanBayden = SBden.MaSanBay) join(CHUYENBAY left join TRUNGGIAN TG on CHUYENBAY.MaCB = TG.MaCB left join SANBAY SB_TG on TG.MaSanBay = SB_TG.MaSanBay) on CB.MaCB = CHUYENBAY.MaCB join TINHTRANG TT on CB.MaCB = TT.MaCB where  CB.NgayGio=@NgayGio";
                    SqlCommand command = new SqlCommand(sql, conn);
                    command.Parameters.AddWithValue("@NgayGio", NGAYBAY);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(table);
                    if (table.Rows.Count == 0)
                    {
                        MessageBox.Show("Không tìm thấy thông tin mà bạn đang tìm kiếm.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtNgayBay.Text = "";
                        return;
                    }
                    dataDanhSachCB.DataSource = table;
                }
                //chi tim kiem bang san bay di
                else if (cmbMaCB.SelectedIndex == -1 && cmbSanBayDi.SelectedIndex != -1 && cmbSanBayDen.SelectedIndex == -1 && txtNgayBay.Text == "")
               
                {
                    string SANBAYDI = cmbSanBayDi.SelectedValue.ToString();
                    string sql = "select CB.MaCB, SBdi.TenSanBay SanBayDi, SBden.TenSanBay SanBayDen,CB.ThoiGianBay, SB_TG.TenSanBay SanBayTG, TG.ThoiGianDung, CB.NgayGio,  TT.TongSoGhe,  TT.TongSoGheTrong, CB.GiaVe, TT.SLGheTrongH1, TT.SLGheTrongH2 from(CHUYENBAY CB join SANBAY SBdi on CB.SanBayDi = SBdi.MaSanBay join SANBAY SBden on CB.SanBayden = SBden.MaSanBay) join(CHUYENBAY left join TRUNGGIAN TG on CHUYENBAY.MaCB = TG.MaCB left join SANBAY SB_TG on TG.MaSanBay = SB_TG.MaSanBay) on CB.MaCB = CHUYENBAY.MaCB join TINHTRANG TT on CB.MaCB = TT.MaCB where CB.SanBayDi=@SanBayDi";
                    SqlCommand command = new SqlCommand(sql, conn);
                    command.Parameters.AddWithValue("@SanBayDi", SANBAYDI);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(table);
                    if (table.Rows.Count == 0)
                    {
                        MessageBox.Show("Không tìm thấy thông tin mà bạn đang tìm kiếm.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        cmbSanBayDi.SelectedIndex = -1;
                        return;
                    }
                    dataDanhSachCB.DataSource = table;
                }
                
                //chi tim kiem bang san bay den
                else if (cmbMaCB.SelectedIndex == -1 && cmbSanBayDi.SelectedIndex == -1 && cmbSanBayDen.SelectedIndex != -1 && txtNgayBay.Text == "")
              
                {
                    string SANBAYDEN = cmbSanBayDen.SelectedValue.ToString();
                    string sql = "select CB.MaCB, SBdi.TenSanBay SanBayDi, SBden.TenSanBay SanBayDen,CB.ThoiGianBay, SB_TG.TenSanBay SanBayTG, TG.ThoiGianDung, CB.NgayGio,  TT.TongSoGhe,  TT.TongSoGheTrong, CB.GiaVe, TT.SLGheTrongH1, TT.SLGheTrongH2 from(CHUYENBAY CB join SANBAY SBdi on CB.SanBayDi = SBdi.MaSanBay join SANBAY SBden on CB.SanBayden = SBden.MaSanBay) join(CHUYENBAY left join TRUNGGIAN TG on CHUYENBAY.MaCB = TG.MaCB left join SANBAY SB_TG on TG.MaSanBay = SB_TG.MaSanBay) on CB.MaCB = CHUYENBAY.MaCB join TINHTRANG TT on CB.MaCB = TT.MaCB where CB.SanBayDen=@SanBayDen";
                    SqlCommand command = new SqlCommand(sql, conn);
                    command.Parameters.AddWithValue("@SanBayDen", SANBAYDEN);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(table);
                    if (table.Rows.Count == 0)
                    {
                        MessageBox.Show("Không tìm thấy thông tin mà bạn đang tìm kiếm.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        cmbSanBayDen.SelectedIndex = -1;
                        return;
                    }
                    dataDanhSachCB.DataSource = table;
                }
                
                //Tim kiem bang MaCB va SanBayDen
                else if (cmbMaCB.SelectedIndex != -1 && cmbSanBayDi.SelectedIndex == -1 && cmbSanBayDen.SelectedIndex != -1 && txtNgayBay.Text == "")
              
                {
                    string MACB = cmbMaCB.SelectedValue.ToString();
                    string SANBAYDEN = cmbSanBayDen.SelectedValue.ToString();
                    string sql = "select CB.MaCB, SBdi.TenSanBay SanBayDi, SBden.TenSanBay SanBayDen,CB.ThoiGianBay, SB_TG.TenSanBay SanBayTG, TG.ThoiGianDung, CB.NgayGio,  TT.TongSoGhe,  TT.TongSoGheTrong, CB.GiaVe, TT.SLGheTrongH1, TT.SLGheTrongH2 from(CHUYENBAY CB join SANBAY SBdi on CB.SanBayDi = SBdi.MaSanBay join SANBAY SBden on CB.SanBayden = SBden.MaSanBay) join(CHUYENBAY left join TRUNGGIAN TG on CHUYENBAY.MaCB = TG.MaCB left join SANBAY SB_TG on TG.MaSanBay = SB_TG.MaSanBay) on CB.MaCB = CHUYENBAY.MaCB join TINHTRANG TT on CB.MaCB = TT.MaCB where CB.MaCB=@MaCB and CB.SanBayDen=@SanBayDen";
                    SqlCommand command = new SqlCommand(sql, conn);
                    command.Parameters.AddWithValue("@MaCB", MACB);
                    command.Parameters.AddWithValue("@SanBayDen", SANBAYDEN);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(table);
                    if (table.Rows.Count == 0)
                    {
                        MessageBox.Show("Không tìm thấy thông tin mà bạn đang tìm kiếm.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        cmbMaCB.SelectedIndex = -1;
                        cmbSanBayDen.SelectedIndex = -1;
                        return;
                    }
                    dataDanhSachCB.DataSource = table;
                }
                
                //Tim kiem bang MaCB va NgayBay
                else if (cmbMaCB.SelectedIndex != -1 && cmbSanBayDi.SelectedIndex == -1 && cmbSanBayDen.SelectedIndex == -1 && txtNgayBay.Text != "")
             
                {
                    string MACB = cmbMaCB.SelectedValue.ToString();
                    DateTime NGAYBAY = DateTime.ParseExact(txtNgayBay.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                    string sql = "select CB.MaCB, SBdi.TenSanBay SanBayDi, SBden.TenSanBay SanBayDen,CB.ThoiGianBay, SB_TG.TenSanBay SanBayTG, TG.ThoiGianDung, CB.NgayGio,  TT.TongSoGhe,  TT.TongSoGheTrong, CB.GiaVe, TT.SLGheTrongH1, TT.SLGheTrongH2 from(CHUYENBAY CB join SANBAY SBdi on CB.SanBayDi = SBdi.MaSanBay join SANBAY SBden on CB.SanBayden = SBden.MaSanBay) join(CHUYENBAY left join TRUNGGIAN TG on CHUYENBAY.MaCB = TG.MaCB left join SANBAY SB_TG on TG.MaSanBay = SB_TG.MaSanBay) on CB.MaCB = CHUYENBAY.MaCB join TINHTRANG TT on CB.MaCB = TT.MaCB where  CB.NgayGio=@NgayGio and CB.MaCB=@MaCB";
                    SqlCommand command = new SqlCommand(sql, conn);
                    command.Parameters.AddWithValue("@NgayGio", NGAYBAY);
                    command.Parameters.AddWithValue("@MaCB", MACB);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(table);
                    if(table.Rows.Count==0)
                    {
                        MessageBox.Show("Không tìm thấy thông tin mà bạn đang tìm kiếm.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        cmbMaCB.SelectedIndex = -1;
                        txtNgayBay.Text = "";
                        return;
                    }
                    dataDanhSachCB.DataSource = table;
                }
                
                //Tim kiem bang NgayBay va SanBayDen
                else if (cmbMaCB.SelectedIndex == -1 && cmbSanBayDi.SelectedIndex == -1 && cmbSanBayDen.SelectedIndex != -1 && txtNgayBay.Text != "")
               
                {
                    DateTime NGAYBAY = DateTime.ParseExact(txtNgayBay.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                    string SANBAYDEN = cmbSanBayDen.SelectedValue.ToString();
                    string sql = "select CB.MaCB, SBdi.TenSanBay SanBayDi, SBden.TenSanBay SanBayDen,CB.ThoiGianBay, SB_TG.TenSanBay SanBayTG, TG.ThoiGianDung, CB.NgayGio,  TT.TongSoGhe,  TT.TongSoGheTrong, CB.GiaVe, TT.SLGheTrongH1, TT.SLGheTrongH2 from(CHUYENBAY CB join SANBAY SBdi on CB.SanBayDi = SBdi.MaSanBay join SANBAY SBden on CB.SanBayden = SBden.MaSanBay) join(CHUYENBAY left join TRUNGGIAN TG on CHUYENBAY.MaCB = TG.MaCB left join SANBAY SB_TG on TG.MaSanBay = SB_TG.MaSanBay) on CB.MaCB = CHUYENBAY.MaCB join TINHTRANG TT on CB.MaCB = TT.MaCB where CB.SanBayDen=@SanBayDen and CB.NgayGio=@NgayGio";
                    SqlCommand command = new SqlCommand(sql, conn);
                    command.Parameters.AddWithValue("@SanBayDen", SANBAYDEN);
                    command.Parameters.AddWithValue("@NgayGio", NGAYBAY);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(table);
                    if (table.Rows.Count == 0)
                    {
                        MessageBox.Show("Không tìm thấy thông tin mà bạn đang tìm kiếm.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtNgayBay.Text = "";
                        cmbSanBayDen.SelectedIndex = -1;
                        return;
                    }
                    dataDanhSachCB.DataSource = table;
                }


               else
                    MessageBox.Show("Cú pháp tra cứu sai, vui lòng thực hiện lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        static public string macb="";
        int SLGHETRONG;
        static public  int DONGIA=0;
        bool click_data;
        private void dataDanhSachCB_Click(object sender, EventArgs e)
        {
            if (dataDanhSachCB.CurrentRow != null)
            {
                index = dataDanhSachCB.CurrentRow.Index;
                macb = dataDanhSachCB.Rows[index].Cells[0].Value.ToString();
                string dongia = dataDanhSachCB.Rows[index].Cells[9].Value.ToString();
                if (dongia != "")
                    DONGIA = Int32.Parse(dongia);
                string slghetrong = dataDanhSachCB.Rows[index].Cells[8].Value.ToString();
                if (slghetrong != "")
                    SLGHETRONG = Int32.Parse(slghetrong);
                else
                {
                    if (dongia == "") SLGHETRONG = -1;
                    
                }
                click_data = true;
            }
        }

        private void btnDatVe_Click(object sender, EventArgs e)
        {
 
            if(click_data==false)
                if (dataDanhSachCB.CurrentRow != null)
                {
                    index = 0;
                    macb = dataDanhSachCB.Rows[index].Cells[0].Value.ToString();
                    string dongia = dataDanhSachCB.Rows[index].Cells[9].Value.ToString();
                    if (dongia != "")
                        DONGIA = Int32.Parse(dongia);
                    string slghetrong = dataDanhSachCB.Rows[index].Cells[8].Value.ToString();
                    if (slghetrong != "")
                        SLGHETRONG = Int32.Parse(slghetrong);
                    else
                    {
                        if (dongia == "") SLGHETRONG = -1;

                    }
                    click_data = true;
                }
            if (dataDanhSachCB.CurrentRow==null || SLGHETRONG ==-1)
            {
                MessageBox.Show("Chưa chọn chuyến bay để đặt vé, vui lòng chọn 1 chuyến bay.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (SLGHETRONG > 0)
            {
                this.Hide();
                Form banve = new frmBanVe(this);
                banve.ShowDialog();
                this.Connection();
                this.Show();
                table.Clear();
            }
            else if( SLGHETRONG == 0  )
            {
                MessageBox.Show("Không thể đặt thêm vé vì chuyến bay đã hết ghế trống.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
           
        }
    }
}
