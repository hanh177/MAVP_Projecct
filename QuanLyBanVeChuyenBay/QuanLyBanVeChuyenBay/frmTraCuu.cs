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

        // string strconn2 = @"Data Source=DESKTOP-JLJ2TBG;Initial Catalog=QLBanVeChuyenBay;Integrated Security=True"; //cua Vuong

        string strconn2 = @"Data Source=DESKTOP-TA2HS1O\SQLEXPRESS;Initial Catalog=QLBanVeChuyenBay;Integrated Security=True"; //cua ha anh

        int index;
        static public string macb = "";
        int SLGHETRONG;
        static public int DONGIA = 0;
        bool click_data;
        public static string thang, nam; 
        string ngaydat, ngaybay;
        public static int tongsoghe, thoigianquidinh;
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
        string str1, str2, str3, str4, str5, str6, str7, str8, str_sql;
        private void btnTraCuu_Click(object sender, EventArgs e)
        {
            table.Clear();
            SqlConnection conn = new SqlConnection(strconn2);
            try
            {
                conn.Open();

                string str= "select distinct CB.MaCB, SBdi.TenSanBay SanBayDi, SBden.TenSanBay SanBayDen,CB.ThoiGianBay,A.SLSBTG, CB.NgayGio,  TT.TongSoGhe,  TT.TongSoGheTrong, CB.GiaVe, TT.SLGheTrongH1, TT.SLGheTrongH2 from(CHUYENBAY CB join SANBAY SBdi on CB.SanBayDi = SBdi.MaSanBay join SANBAY SBden on CB.SanBayden = SBden.MaSanBay) join(CHUYENBAY left join TRUNGGIAN TG on CHUYENBAY.MaCB = TG.MaCB left join SANBAY SB_TG on TG.MaSanBay = SB_TG.MaSanBay) on CB.MaCB = CHUYENBAY.MaCB join TINHTRANG TT on CB.MaCB = TT.MaCB" +
                         " left join  (select count(MaCB) SLSBTG ,MaCB from TRUNGGIAN group by MaCB) A on A.MaCB=TT.MaCB where ";
             
                //Chi tim kiem bang MaCB
                if (cmbMaCB.SelectedIndex != -1 && cmbSanBayDi.SelectedIndex == -1 && cmbSanBayDen.SelectedIndex == -1 && txtNgayBay.Text == "")

                {

                    str1 = " CB.MaCB= '" + cmbMaCB.SelectedValue.ToString() + "'";
                }

                //Chi tim kiem bang SanBayDi va SanBayDen
                else if (cmbSanBayDi.SelectedIndex != -1 && cmbSanBayDen.SelectedIndex != -1 && cmbMaCB.SelectedIndex == -1 && txtNgayBay.Text == "")
                {
                   str2 = "CB.SanBayDi= '" + cmbSanBayDi.SelectedValue.ToString() + "' and CB.SanBayDen= '" + cmbSanBayDen.SelectedValue.ToString() + "'";
                }

                //Chi tim kiem bang NgayBay
                else if (txtNgayBay.Text != "" && cmbMaCB.SelectedIndex == -1 && cmbSanBayDi.SelectedIndex == -1 && cmbSanBayDen.SelectedIndex == -1)
                {
                    try
                    {
                        string NGAYBAY = txtNgayBay.Text;
                        string[] arrListStr = NGAYBAY.Split('/');
                        str3 = "Day(CB.NgayGio)= '" + arrListStr[0] + "' and Month(CB.NgayGio)= '" + arrListStr[1] + "' and Year(CB.NgayGio)= '" + arrListStr[2] + "'";
                    }
                    catch
                    {
                        MessageBox.Show("Tim kiem ngu qua", "Loi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtNgayBay.Text = "";
                        return;
                    }
                }
                //chi tim kiem bang san bay di
                else if (cmbMaCB.SelectedIndex == -1 && cmbSanBayDi.SelectedIndex != -1 && cmbSanBayDen.SelectedIndex == -1 && txtNgayBay.Text == "")
                {
                    str4 = "CB.SanBayDi= '" + cmbSanBayDi.SelectedValue.ToString() + "'";
                }

                //chi tim kiem bang san bay den
                else if (cmbMaCB.SelectedIndex == -1 && cmbSanBayDi.SelectedIndex == -1 && cmbSanBayDen.SelectedIndex != -1 && txtNgayBay.Text == "")
                {
                    str5 = "CB.SanBayDen= '" + cmbSanBayDen.SelectedValue.ToString() + "'";
                }

                //Tim kiem bang MaCB va SanBayDen
                else if (cmbMaCB.SelectedIndex != -1 && cmbSanBayDi.SelectedIndex == -1 && cmbSanBayDen.SelectedIndex != -1 && txtNgayBay.Text == "")

                {
                    str6 = " CB.MaCB= '" + cmbMaCB.SelectedValue.ToString() + "' and CB.SanBayDen= '" + cmbSanBayDi.SelectedValue.ToString() + "'";
                }

                //Tim kiem bang MaCB va NgayBay
                else if (cmbMaCB.SelectedIndex != -1 && cmbSanBayDi.SelectedIndex == -1 && cmbSanBayDen.SelectedIndex == -1 && txtNgayBay.Text != "")
                {
                    string NGAYBAY = txtNgayBay.Text;
                    string[] arrListStr = NGAYBAY.Split('/');
                    str7 = " CB.MaCB= '" + cmbMaCB.SelectedValue.ToString() + "' and Day(CB.NgayGio)= '" + arrListStr[0] + "' and Month(CB.NgayGio)= '" + arrListStr[1] + "' and Year(CB.NgayGio)= '" + arrListStr[2] + "'";
                }

                //Tim kiem bang NgayBay va SanBayDen
                else if (cmbMaCB.SelectedIndex == -1 && cmbSanBayDi.SelectedIndex == -1 && cmbSanBayDen.SelectedIndex != -1 && txtNgayBay.Text != "")
                {
                    string NGAYBAY = txtNgayBay.Text;
                    string[] arrListStr = NGAYBAY.Split('/');
                    str8 = "Day(CB.NgayGio)= '" + arrListStr[0] + "' and Month(CB.NgayGio)= '" + arrListStr[1] + "' and Year(CB.NgayGio)= '" + arrListStr[2] + "' and CB.SanBayDen= '" + cmbSanBayDen.SelectedValue.ToString() + "'";
                }


                else
                {
                    MessageBox.Show("Cú pháp tra cứu sai, vui lòng thực hiện lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cmbMaCB.SelectedIndex = -1;
                    txtNgayBay.Text = "";
                    cmbSanBayDi.SelectedIndex = -1;
                    cmbSanBayDen.SelectedIndex = -1;
                    return;
                }
                str_sql = str + str1 + str2 + str3 + str4 + str5 + str6 + str7 + str8;
                SqlCommand command = new SqlCommand(str_sql, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(table);
                if (table.Rows.Count == 0)
                {
                    MessageBox.Show("Không tìm thấy thông tin bạn đang tìm kiếm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cmbMaCB.SelectedIndex = -1;
                    txtNgayBay.Text = "";
                    cmbSanBayDi.SelectedIndex = -1;
                    cmbSanBayDen.SelectedIndex = -1;

                }
                else
                    dataDanhSachCB.DataSource = table;
                str1 = str2 = str3 = str4 = str5 = str6 = str7 = str8 = null;
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

        public static bool laNamNhuan(int nYear)
        {
            if ((nYear % 4 == 0 && nYear % 100 != 0) || nYear % 400 == 0)
            {
                return true;
            }
            return false;

            // <=> return ((nYear % 4 == 0 && nYear % 100 != 0) || nYear % 400 == 0);
        }

        public static int tinhSoNgayTrongThang(int nMonth, int nYear)
        {
            int nNumOfDays = 0;

            switch (nMonth)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    nNumOfDays = 31;
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    nNumOfDays = 30;
                    break;
                case 2:
                    if (laNamNhuan(nYear))
                    {
                        nNumOfDays = 29;
                    }
                    else
                    {
                        nNumOfDays = 28;
                    }
                    break;
            }

            return nNumOfDays;
        }
        public static void Cong1Ngay(ref int nDay, ref int nMonth, ref int nYear)
        {

            nDay++;
            if (nDay > tinhSoNgayTrongThang(nMonth, nYear))
            {
                nDay = 1;
                nMonth++;
                if (nMonth > 12)
                {
                    nMonth = 1;
                    nYear++;
                }
            }

        }
        public static string Cong(string ngaydat, int thamso)
        {
            string[] dat = ngaydat.Split(' ');

            string[] Ngaydat = dat[0].Split('/');//mang luu  thang ngay nam

            string[] GioDat = dat[1].Split(':');//mang luu gio phut giay

            string str = "";
            int ngay = int.Parse(Ngaydat[1]);
            int thang = int.Parse(Ngaydat[0]);
            int nam = int.Parse(Ngaydat[2]);

            int gio = int.Parse(GioDat[0]);
            if (dat[2] == "PM") gio += 12;
            int phut = int.Parse(GioDat[1]);

            int giomoi = gio + thamso;
            int ngaycong = 0;
            if (giomoi > 24)
            {
                ngaycong = giomoi / 24;
                giomoi = giomoi - (24 * ngaycong);
            }
            for (int i = 0; i < ngaycong; i++)
            {
                Cong1Ngay(ref ngay, ref thang, ref nam);
            }
            str = thang + "/" + ngay + "/" + nam + " " + giomoi + ":" + phut + ":" + GioDat[2];
            return str;
        }
        public static bool KiemTra(int thamso, string ngaygiodat, string ngaygiobay)
        {
            string[] bay = ngaygiobay.Split(' ');

            string[] Ngaybay = bay[0].Split('/');//mang luu  thang ngay nam

            string[] GioBay = bay[1].Split(':');//mang luu gio phut giay


            int ngaybay = int.Parse(Ngaybay[1]);
            int thangbay = int.Parse(Ngaybay[0]);
            int nambay = int.Parse(Ngaybay[2]);
            int giobay = int.Parse(GioBay[0]);
            if (bay[2] == "PM")
                giobay += 12;
            int phutbay = int.Parse(GioBay[1]);




            string NgayGioDatMoi = Cong(ngaygiodat, thamso);

            string[] moi = NgayGioDatMoi.Split(' ');

            string[] Ngaymoi = moi[0].Split('/');//mang luu  thang ngay nam

            string[] Giomoi = moi[1].Split(':');//mang luu gio phut giay

            int ngaymoi = int.Parse(Ngaymoi[1]);
            int thangmoi = int.Parse(Ngaymoi[0]);
            int nammoi = int.Parse(Ngaymoi[2]);
            int giomoi = int.Parse(Giomoi[0]);
            int phutmoi = int.Parse(Giomoi[1]);


            if (nambay > nammoi) return true;
            else
            {
                if (thangbay > thangmoi)
                    return true;
                else
                {
                    if (ngaybay > ngaymoi)
                        return true;
                    else //cung ngay
                    {
                        if (ngaybay == ngaymoi)
                        {
                            if (giobay > giomoi) return true;
                            else
                            {
                                if (phutbay > phutmoi) return true;
                                else return false;
                            }
                        }
                        else
                            return false;
                    }


                }
            }
        }

        private void dataDanhSachCB_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
       
        private void dataDanhSachCB_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataDanhSachCB.CurrentRow != null)
                {
                    index = dataDanhSachCB.CurrentRow.Index;
                    macb = dataDanhSachCB.Rows[index].Cells[0].Value.ToString();
                    string dongia = dataDanhSachCB.Rows[index].Cells[8].Value.ToString();
                    string tongSoGhe = dataDanhSachCB.Rows[index].Cells[6].Value.ToString();
                    string NgayGioBay=dataDanhSachCB.Rows[index].Cells[5].Value.ToString();
                    string[] arr_tg = NgayGioBay.Split(' ');
                    string[] arr_tg2 = arr_tg[0].Split('/');
                    thang = arr_tg2[0];
                    nam = arr_tg2[2];
                    tongsoghe = Int32.Parse(tongSoGhe);
                    if (dongia != "")
                        DONGIA = Int32.Parse(dongia);
                    string slghetrong = dataDanhSachCB.Rows[index].Cells[7].Value.ToString();
                    if (slghetrong != "")
                        SLGHETRONG = Int32.Parse(slghetrong);
                    else
                    {
                        if (dongia == "") SLGHETRONG = -1;

                    }
                    click_data = true;
                }
            }
            catch { };
        }

        private void btnDatVe_Click(object sender, EventArgs e)
        {

            SqlConnection conn = new SqlConnection(strconn2);
            try
            {
                conn.Open();
                //Xoa phieu dat cho
                string sql = "select * from ThamSo where MaThamSo='TS01'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string s = reader["TGChamNhatDatVe"].ToString();
                    thoigianquidinh = Int32.Parse(s);
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
                //  MessageBox.Show("Ket noi xay ra loi hoac doc du lieu bi loi");
                MessageBox.Show(ex.Message);
            }
            finally
            {
                //Dong ket noi sau khi thao tac ket thuc
                conn.Close();
            }

            if (click_data==false)
                if (dataDanhSachCB.CurrentRow != null)
                {
                    index = 0;
                    index = dataDanhSachCB.CurrentRow.Index;
                    macb = dataDanhSachCB.Rows[index].Cells[0].Value.ToString();
                    string dongia = dataDanhSachCB.Rows[index].Cells[8].Value.ToString();
                    string tongSoGhe = dataDanhSachCB.Rows[index].Cells[6].Value.ToString();
                    string NgayGioBay = dataDanhSachCB.Rows[index].Cells[5].Value.ToString();
                    string[] arr_tg = NgayGioBay.Split(' ');
                    string[] arr_tg2 = arr_tg[0].Split('/');
                    thang = arr_tg2[0];
                    nam = arr_tg2[2];
                    tongsoghe = Int32.Parse(tongSoGhe);
                    if (dongia != "")
                        DONGIA = Int32.Parse(dongia);
                    string slghetrong = dataDanhSachCB.Rows[index].Cells[7].Value.ToString();
                    if (slghetrong != "")
                        SLGHETRONG = Int32.Parse(slghetrong);
                    else
                    {
                        if (dongia == "") SLGHETRONG = -1;

                    }
                    click_data = true;
                }

            try
            {
                ngaybay = dataDanhSachCB.Rows[index].Cells[5].Value.ToString();
                DateTime d = DateTime.Now;
                ngaydat = d.ToString();

                if (KiemTra(thoigianquidinh, ngaydat, ngaybay) == false)
                {
                    MessageBox.Show("Không thể đặt vé chuyến bay " + macb + " vì đã quá thời gian chậm nhất đặt vé(" + thoigianquidinh + " giờ)");
                    return;
                }

            }
            catch { }


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
                click_data = false;
            }
            else if( SLGHETRONG == 0  )
            {
                MessageBox.Show("Không thể đặt thêm vé vì chuyến bay đã hết ghế trống.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
           
        }
        
        private void dataDanhSachCB_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dataDanhSachCB.CurrentRow!=null)
            {
                index = dataDanhSachCB.CurrentRow.Index;
                string slsbtg = dataDanhSachCB.Rows[index].Cells[4].EditedFormattedValue.ToString();
                if (slsbtg != "")
                {
                    Form sbtg = new frmSanBayTG(this);
                    this.Hide();
                    sbtg.ShowDialog();
                    table.Clear();
                }
                else
                    return;
            }
        }
    }
}
