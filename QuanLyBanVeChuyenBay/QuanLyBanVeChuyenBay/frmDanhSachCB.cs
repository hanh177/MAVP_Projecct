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
    public partial class frmDanSachCB : Form
    {
        Form main;
        public frmDanSachCB(Form frmMain)
        {
            InitializeComponent();
            this.main = frmMain;
        }
        //string strconn2 = @"Data Source=DESKTOP-TA2HS1O\SQLEXPRESS;Initial Catalog=QLBanVeChuyenBay;Integrated Security=True"; //cua ha anh

         string strconn2 = @"Data Source=DESKTOP-JLJ2TBG;Initial Catalog=QLBanVeChuyenBay;Integrated Security=True";
        int index;
         public static string macb = "";
         public string ngaybay = "";
         public string ngaydat = "";
        int SLGHETRONG;
        static public int DONGIA = 0;
        int thoigianquidinh;
        bool click_data;
        public static string thang, nam;
        public static int tongsoghe;
        DataTable table = new DataTable();
        DataTable table2=new DataTable();
        public void Connection()
        {
          
            SqlConnection conn = new SqlConnection(strconn2);
            try
            {
                conn.Open();
                string sql = "select distinct CB.MaCB, SBdi.TenSanBay SanBayDi, SBden.TenSanBay SanBayDen,CB.ThoiGianBay, A.SLSBTG,CB.NgayGio, TT.TongSoGhe,  TT.TongSoGheTrong, CB.GiaVe, TT.SLGheTrongH1, TT.SLGheTrongH2 from(CHUYENBAY CB join SANBAY SBdi on CB.SanBayDi = SBdi.MaSanBay join SANBAY SBden on CB.SanBayden = SBden.MaSanBay) join(CHUYENBAY left join TRUNGGIAN TG on CHUYENBAY.MaCB = TG.MaCB left join SANBAY SB_TG on TG.MaSanBay = SB_TG.MaSanBay) on CB.MaCB = CHUYENBAY.MaCB join TINHTRANG TT on CB.MaCB = TT.MaCB" +
                    " left join  (select count(MaCB) SLSBTG ,MaCB from TRUNGGIAN group by MaCB) A on A.MaCB=TT.MaCB";
                SqlCommand command = new SqlCommand(sql, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(command);              
                adapter.Fill(table);
                dataDanhSachCB.DataSource = table;
                dataDanhSachCB.AutoGenerateColumns = true;


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


        public bool laNamNhuan(int nYear)
        {
            if ((nYear % 4 == 0 && nYear % 100 != 0) || nYear % 400 == 0)
            {
                return true;
            }
            return false;

            // <=> return ((nYear % 4 == 0 && nYear % 100 != 0) || nYear % 400 == 0);
        }

        public  int tinhSoNgayTrongThang(int nMonth, int nYear)
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
        public  void Cong1Ngay(ref int nDay, ref int nMonth, ref int nYear)
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
        public  string Cong(string ngaydat, int thamso)
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
        public  bool KiemTra(int thamso, string ngaygiodat, string ngaygiobay)
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
        void KiemTraDanhSach()
        {
            SqlConnection conn = new SqlConnection(strconn2);
            try
            {
                conn.Open();
                string sqlQuery = "select * from CHUYENBAY";

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
      private void frmDanSachCB_Load(object sender, EventArgs e)
        {
            click_data = false;
            macb = "";
            DONGIA = 0;
            Connection();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
            main.Show();
        }


        private void tSbtnTraCuuCB_Click(object sender, EventArgs e)
        {
            Form tracuucb = new frmTraCuu(this);
            this.Hide();
            tracuucb.ShowDialog();
            table.Clear();
            this.reload();
        }
        void reload()
        {
            this.Connection();
            this.Show();
        }
        private void btnTraCuu_Click(object sender, EventArgs e)
        {          
            this.tSbtnTraCuuCB_Click(sender, e);
        }
   

        private void tSbtnThemCB_Clicked(object sender, EventArgs e)
        {
            Form nhanlich = new frmNhanLich(this);
            this.Hide();          
            nhanlich.ShowDialog();
            table.Clear();
            this.reload();
        }

        private void tSbtnDatVeCB_Clicked(object sender, EventArgs e)
        {
            this.Hide();
            Form banve = new frmBanVe(this);
            DialogResult re = banve.ShowDialog();
            table.Clear();
            this.reload();
        }

        private void btnThemCB_Click(object sender, EventArgs e)
        {
            tSbtnThemCB_Clicked(sender, e);
        }
        
        private void dataDanhSachCB_CellClick(object sender, DataGridViewCellEventArgs e)
        {
          //  index = e.RowIndex;
          
        }

        private void dataDanhSachCB_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataDanhSachCB.CurrentRow.Index>=0)
                {

                    index = dataDanhSachCB.CurrentRow.Index;
                    macb = dataDanhSachCB.Rows[index].Cells[0].Value.ToString();
                    string dongia = dataDanhSachCB.Rows[index].Cells[8].Value.ToString();
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


            if (click_data == false)
            {
                index = 0;
                macb = dataDanhSachCB.Rows[index].Cells[0].Value.ToString();
                string dongia = dataDanhSachCB.Rows[index].Cells[8].Value.ToString();
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
            }
            catch { }

             if (KiemTra(thoigianquidinh, ngaydat, ngaybay)==false)
                {
                MessageBox.Show("Không thể đặt vé chuyến bay " + macb + " vì đã quá thời gian chậm nhất đặt vé(" + thoigianquidinh + " giờ)");
                    return;
                }
                
            if (dataDanhSachCB.CurrentRow == null || SLGHETRONG == -1)
                {
                    MessageBox.Show("Chưa chọn chuyến bay để đặt vé, vui lòng chọn 1 chuyến bay.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (SLGHETRONG > 0)
                {
                string tongSoGhe = dataDanhSachCB.Rows[index].Cells[6].Value.ToString();
                string NgayGioBay = dataDanhSachCB.Rows[index].Cells[5].Value.ToString();
                string[] arr_tg = NgayGioBay.Split(' ');
                string[] arr_tg2 = arr_tg[0].Split('/');
                thang = arr_tg2[0];
                nam = arr_tg2[2];
                tongsoghe = Int32.Parse(tongSoGhe);
                Form banve = new frmBanVe(this);
                this.Hide();
                DialogResult re = banve.ShowDialog();
                table.Clear();
                this.reload();

            }
            else if (SLGHETRONG == 0)
                {
                    MessageBox.Show("Không thể đặt thêm vé vì chuyến bay đã hết ghế trống.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
          

        }
        private void dataDanhSachCB_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataDanhSachCB.CurrentRow != null)
            {
                index = dataDanhSachCB.CurrentRow.Index;
                string slsbtg = dataDanhSachCB.Rows[index].Cells[4].EditedFormattedValue.ToString();
                if (slsbtg != "")
                {
                    frmSanBayTG sbtg = new frmSanBayTG(this);
                    this.Hide();
                    sbtg.ShowDialog();
                }
                else
                {
                    return;
                }
            }
        }
    }
}
