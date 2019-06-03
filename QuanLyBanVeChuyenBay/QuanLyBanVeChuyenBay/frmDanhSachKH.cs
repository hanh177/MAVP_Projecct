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

        //   string strconn2 = @"Data Source=DESKTOP-JLJ2TBG;Initial Catalog=QLBanVeChuyenBay;Integrated Security=True";

        int thoigianquidinh;
        string ngaybay, ngayhuy;
        int tongsoghe, thang, nam;
        public  void Connection()
        {

            SqlConnection conn = new SqlConnection(strconn2);
            try
            {
                conn.Open();
                string sql = "select HK.MaHanhKhach ,HoTen,CMMD,SDT,CB.MaCB,VE.MaVe from(CHUYENBAY CB join SANBAY SBdi on CB.SanBayDi = SBdi.MaSanBay join SANBAY SBden on CB.SanBayden = SBden.MaSanBay) join PHIEUDATCHO PH on CB.MaCB = PH.MaCB join VE on PH.MaVe = VE.MaVe join HANHKHACH HK on VE.MaHanhKhach = HK.MaHanhKhach";

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
 
                cmbMaCB.DataSource = table1;
                cmbMaCB.DisplayMember = "MaCB";
                cmbMaCB.ValueMember = "MaCB";
                cmbMaCB.SelectedIndex = -1;

                string sql2 = "select * from Hanhkhach";
                SqlCommand command2 = new SqlCommand(sql2, conn);
                SqlDataAdapter adapter2 = new SqlDataAdapter(command2);
                DataTable table2= new DataTable();
                adapter2.Fill(table2);

                cmbMaKH.DataSource = table2;
                cmbMaKH.DisplayMember = "MaHanhKhach";
                cmbMaKH.ValueMember = "MaHanhKhach";
                cmbMaKH.SelectedIndex = -1;
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
            btnLoadLai.Enabled = true;
            click_data = false;
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

        public int tinhSoNgayTrongThang(int nMonth, int nYear)
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
        public void Cong1Ngay(ref int nDay, ref int nMonth, ref int nYear)
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
        public string Cong(string ngaydat, int thamso)
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
        public bool KiemTra(int thamso, string ngaygiodat, string ngaygiobay)
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
        void reload()
        {
            this.Connection();
            this.Show();
        }
        private void btnLoadLai_Click(object sender, EventArgs e)
        {
            Connection();
            cmbMaKH.SelectedIndex=-1;
            cmbMaCB.SelectedIndex = -1;
            txtHoTen.Clear();
            txtCMND.Clear();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        string hangve;
        int gheh1=0, gheh2=0, sove;
        int giave;
       
        private void btnHuyVe_Click(object sender, EventArgs e)
        {
            try
            {
                mahk= dataDSKH.Rows[index].Cells[0].Value.ToString();
                mave = dataDSKH.Rows[index].Cells[5].Value.ToString();
                macb = dataDSKH.Rows[index].Cells[4].Value.ToString();
            }
            catch { mave = "none"; }
            if (mave != "none")
            {
                SqlConnection conn = new SqlConnection(strconn2);
                try
                {
                    conn.Open();
                    //
                    string sql = "select * from ThamSo where MaThamSo='TS01'";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        string s = reader["TGChamNhatHuyVe"].ToString();
                        thoigianquidinh = Int32.Parse(s);
                    }
                    conn.Close();
                    conn.Open();
                    string sql2 = "select* from ChuyenBay where macb='" + macb + "'";
                    SqlCommand cmd2 = new SqlCommand(sql2, conn);
                    SqlDataReader r = cmd2.ExecuteReader();
                    while (r.Read())
                    {
                        ngaybay = r["NGAYGIO"].ToString();
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
                conn.Close();
                if (click_data == false)
                {
                    index = 0;

                }
                else
                {
                    index = dataDSKH.CurrentRow.Index;
                }


                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn hủy vé có mã khách hàng " + mahk + " chứ?", "Chú ý", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    DateTime d = DateTime.Now;
                    ngayhuy = d.ToString();

                    if (KiemTra(thoigianquidinh, ngayhuy, ngaybay) == false)
                    {
                        MessageBox.Show("Không thể hủy vé của hành khách " + mahk + " vì đã quá thời gian chậm nhất hủy vé(" + thoigianquidinh + " giờ)");
                        return;
                    }
                    try
                    {
                        conn.Open();


                        //lay gia ve
                        string s="";
                        string sql1 = "select * from ve where mahanhkhach='" + mahk + "'";
                        SqlCommand cmd1 = new SqlCommand(sql1, conn);
                        SqlDataReader reader = cmd1.ExecuteReader();
                        while (reader.Read())
                        {
                            s = reader["GiaVe"].ToString();
                            giave = int.Parse(s);

                        }

                        conn.Close();

                        //lay tongsoghe, thang, nam
                        conn.Open();

                        string sql2 = "select SLGheHang1+SLGheHang2 as tongsoghe, YEAR(Ngaygio) as Nam, MONTH(ngaygio) as Thang from CHUYENBAY where macb= '" + macb + "'";
                        SqlCommand cmd2 = new SqlCommand(sql2, conn);
                        SqlDataReader reader2 = cmd2.ExecuteReader();
                        while (reader2.Read())
                        {
                            tongsoghe = int.Parse(reader2["tongsoghe"].ToString());
                            thang = int.Parse(reader2["thang"].ToString());
                            nam = int.Parse(reader2["nam"].ToString());
                        }
                        //MessageBox.Show(s+" "+ tongsoghe.ToString() + " " + thang.ToString() + " " + nam.ToString());
                        conn.Close();

                        //update  DOANHTHUTHANGCB
                        conn.Open();
                        string sql3 = "update DOANHTHUTHANGCB set sove= sove - 1, DoanhThu = DoanhThu - " + giave + ", TiLe = cast(round(100.0*(SoVe-1)/" + tongsoghe + ",2) as numeric(36,2))  where MaCB = '" + macb + "'";
                        SqlCommand cmd3 = new SqlCommand(sql3, conn);
                        cmd3.ExecuteNonQuery();

                        // //update TONGDOANHTHUTHANG

                        //Lay ra doanh thu cua chuyen bay thang nay
                        string MaDoanhThuThang = "";
                        string sql = "select DoanhThu, MaDoanhThuThang  from DOANHTHUTHANGCB where MaCB= '" + macb + "'";
                        SqlCommand cmd = new SqlCommand(sql, conn);
                        SqlDataAdapter adapter2 = new SqlDataAdapter(cmd);
                        DataTable table2 = new DataTable();
                        adapter2.Fill(table2);
                        foreach (DataRow row in table2.Rows)
                        {
                            foreach (DataColumn col in table2.Columns)
                            {
                                string doanhthuthangcb = row["DoanhThu"].ToString();
                                string[] arr_doanhthu = doanhthuthangcb.Split('.');
                                //tongdoanhthuthangcb = Int32.Parse(arr_doanhthu[0]);
                                MaDoanhThuThang = row["MaDoanhThuThang"].ToString();
                            }
                        }

                        string SQL = "select cast(round( sum(tile),2 ) as numeric(36,2)) tongTiLe, count(madoanhthuCB) tongsoCB  from DOANHTHUTHANGCB where  MaDoanhThuThang  = '" + MaDoanhThuThang+"'";
                        SqlCommand CMD = new SqlCommand(SQL, conn);
                        SqlDataReader read = CMD.ExecuteReader();
                        float TongTiLe = 0.0f;
                        int socb = 0;
                        while (read.Read())
                        {
                            string t = read["tongTiLe"].ToString();
                            TongTiLe = float.Parse(t);
                            socb = int.Parse(read["tongsoCB"].ToString());
                        }

                        float tilethang = TongTiLe / socb;
                        //MessageBox.Show(tilethang.ToString());
                        conn.Close();

                        conn.Open();

                        string sql4 = "Update TONGDOANHTHUTHANG set TongDoanhThu = TongDoanhThu - " + giave + ", TiLe = cast(round(" + tilethang + ",2) as numeric(36,2))   where thang= "+thang;
                        SqlCommand cmd4 = new SqlCommand(sql4, conn);
                        cmd4.ExecuteNonQuery();


                        // update TONGDOANHTHUNAM


                        //Lay ra ma doanh thu cua thang va doanh thu cua thang trong nam

                        string sqlQuery9 = "select TongDoanhThu,MaDoanhThuNam  from TONGDOANHTHUTHANG where MaDoanhThuThang= '" + MaDoanhThuThang + "'";
                        SqlCommand command9 = new SqlCommand(sqlQuery9, conn);
                        SqlDataAdapter adapter3 = new SqlDataAdapter(command9);
                        DataTable table3 = new DataTable();
                        adapter3.Fill(table3);
                        string MaDoanhThuNam = "";
                        foreach (DataRow row in table3.Rows)
                        {
                            foreach (DataColumn col in table3.Columns)
                            {
                                string TongDoanhThuThang = row["TongDoanhThu"].ToString();
                                string[] arr_doanhthuthang = TongDoanhThuThang.Split('.');
                               // TongDoanhThu = Int32.Parse(arr_doanhthuthang[0]);
                                MaDoanhThuNam = row["MaDoanhThuNam"].ToString();
                            }
                        }

                        string SQL2 = "select cast(round( sum(tile),2 ) as numeric(36,2)) tongTiLe, count(MaDoanhThuThang) tongsoThang  from TONGDOANHTHUTHANG where MaDoanhThuNam= '" + MaDoanhThuNam + "'";
                        SqlCommand CMD2 = new SqlCommand(SQL2, conn);
                        SqlDataReader read3 = CMD2.ExecuteReader();
                        float TongTiLe2 = 0.0f;
                        int sothang = 0;
                        while (read3.Read())
                        {
                            string t = read3["tongTiLe"].ToString();
                            TongTiLe2 = float.Parse(t);
                            sothang = int.Parse(read3["tongsoThang"].ToString());
                        }

                        float tilenam = TongTiLe2 / sothang;
                        MessageBox.Show("ti le nam: " + tilenam.ToString());
                        conn.Close();

                        conn.Open();

                        string sql5 = "Update TONGDOANHTHUNAM set TongDoanhThu = TongDoanhThu - " + giave + ", TiLe = cast(round(" + tilenam + ",2) as numeric(36,2)) where MaDoanhThuNam = '" + MaDoanhThuNam + "'";
                        SqlCommand cmd5 = new SqlCommand(sql5, conn);
                        cmd5.ExecuteNonQuery();

                        //Xoa phieu dat cho
                        string sqlQuery3 = "delete from PHIEUDATCHO where MaHanhKhach=@MaHanhKhach";
                        SqlCommand command3 = new SqlCommand(sqlQuery3, conn);
                        command3.Parameters.AddWithValue("@MaHanhKhach", mahk);
                        command3.ExecuteNonQuery();



                        //Xoa ve
                        //Trk khi xoa ve phai lay duoc hang ve
                        string sqlQuery4 = "Select HangVe from VE where MaVe=@MaVe";
                        SqlCommand command4 = new SqlCommand(sqlQuery4, conn);
                        command4.Parameters.AddWithValue("@MaVe", mave);
                        SqlDataAdapter adapter = new SqlDataAdapter(command4);
                        DataTable table = new DataTable();
                        adapter.Fill(table);
                        foreach (DataRow row in table.Rows)
                        {
                            foreach (DataColumn column in table.Columns)
                            {
                                hangve = row["HangVe"].ToString();

                            }
                        }
                        sove = Int32.Parse(hangve);
                        if (sove == 1)
                            gheh1 = 1;
                        else
                            gheh2 = 1;
                        string sqlQuery5 = "delete from VE where MaVe=@MaVe";
                        SqlCommand command5 = new SqlCommand(sqlQuery5, conn);
                        command5.Parameters.AddWithValue("@MaVe", mave);
                        command5.ExecuteNonQuery();

                        //Xoa Hanh Khach
                        string sqlQuery6 = "delete from HANHKHACH where MaHanhKhach=@MaHanhKhach";
                        SqlCommand command6 = new SqlCommand(sqlQuery6, conn);
                        command6.Parameters.AddWithValue("@MaHanhKhach", mahk);
                        command6.ExecuteNonQuery();

                        //Cap nhat bang TINHTRANG
                        string sqlQuery7 = "Update TINHTRANG set SLGheTrongH1 = SLGheTrongH1 + " + gheh1 +
                           ", SLGheTrongH2 = SLGheTrongH2 +" + gheh2 +
                           ", TongSoGhe = TongSoGhe, TongSoGheTrong = TongSoGheTrong + 1, TongSoGheDat =TongSoGheDat - 1 where MaCB =@MaCB";
                        SqlCommand command7 = new SqlCommand(sqlQuery7, conn);
                        command7.Parameters.AddWithValue("@MaCB", macb);
                        command7.ExecuteNonQuery();


                        MessageBox.Show("Xóa hành khách thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //table.Clear();
                        Connection();

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
                }
            }
            else { MessageBox.Show("Không có hành khách nào được chọn");
                return;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataDSKH_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        int index;
        bool click_data = false;
        static public string mahk = "";
        string mave = "";
        string macb = "";
        private void dataDSKH_Click(object sender, EventArgs e)
        {
            if (dataDSKH.CurrentRow != null)
            {
                index = dataDSKH.CurrentRow.Index;
                mahk = dataDSKH.Rows[index].Cells[0].Value.ToString();
                mave= dataDSKH.Rows[index].Cells[5].Value.ToString();
                macb= dataDSKH.Rows[index].Cells[4].Value.ToString();
                click_data = true;
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(strconn2);
            try
            {
                conn.Open();

                string str1 = "select hk.MaHanhKhach, HoTen, CMMD,SDT, v.MaVe, cb.MaCB from ve v join CHUYENBAY cb on v.MaCB=cb.MaCB join HANHKHACH hk on hk.MaHanhKhach=v.MaHanhKhach where ";
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

                if (cmbMaKH.Text != "")
                {
                    if(str2!=""||str3!="")
                    str4 = "and hk.MaHanhKhach= '" + cmbMaKH.Text + "'";
                    else str4 = " hk.MaHanhKhach= '" + cmbMaKH.Text + "'";
                }
                else str4 = "";

                if (cmbMaCB.Text != "")
                {
                    if (str2 != "" || str3 != "" || str4 != "")
                        str5 = "and cb.MaCB= '" + cmbMaCB.Text + "'";
                    else str5 = " cb.MaCB= '" + cmbMaCB.Text + "'";
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
                    if(table.Rows.Count==0)
                        MessageBox.Show("Không tìm thấy bất cứ thông tin nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataDSKH.DataSource = table;
                    btnLoadLai.Enabled = true;
                    btnHuyVe.Enabled = true;
                    btnPhieuDat.Enabled = true;
                }
                txtHoTen.Text = "";
                txtCMND.Text = "";
                cmbMaCB.SelectedIndex = -1;
                cmbMaKH.SelectedIndex = -1;
                
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
            main.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnPhieuDat_Click(object sender, EventArgs e)
        {
            try
            {
                if (click_data == false)
                {
                    index = dataDSKH.CurrentRow.Index;
                    mahk = dataDSKH.Rows[index].Cells[0].Value.ToString();
                }
                frmPhieuDatCho phieu = new frmPhieuDatCho(this);
                phieu.Button_Clicked += new EventHandler(frm_Button_Clicked);
                this.Hide();
                phieu.Show();
            }catch
            {

                MessageBox.Show("Không có hành khách nào được chọn.");
                return;
            }
        }
        void frm_Button_Clicked(object sender, EventArgs e)
        {
            this.btnLoadLai_Click(btnLoadLai, EventArgs.Empty);
        }
    }
}
