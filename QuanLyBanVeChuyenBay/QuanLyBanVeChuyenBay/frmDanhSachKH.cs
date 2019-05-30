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

        //string strconn2 = @"Data Source=DESKTOP-TA2HS1O\SQLEXPRESS;Initial Catalog=QLBanVeChuyenBay;Integrated Security=True"; //cua ha anh

         string strconn2 = @"Data Source=DESKTOP-JLJ2TBG;Initial Catalog=QLBanVeChuyenBay;Integrated Security=True";

        int thoigianquidinh;
        string ngaybay, ngayhuy;
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
        
       
        private void btnHuyVe_Click(object sender, EventArgs e)
        {
            mave = dataDSKH.Rows[index].Cells[5].Value.ToString();
            macb = dataDSKH.Rows[index].Cells[4].Value.ToString();

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
                    string s = reader["TGChamNhatHuyVe"].ToString();
                    thoigianquidinh = Int32.Parse(s);
                }
                conn.Close();
                conn.Open();
                string sql2 = "select* from ChuyenBay where macb='" + macb + "'";
                SqlCommand cmd2 = new SqlCommand(sql2, conn);
                SqlDataReader r = cmd2.ExecuteReader();
                while(r.Read())
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
            if (click_data == false)
            {
                index = dataDSKH.CurrentRow.Index;
                mahk = dataDSKH.Rows[index].Cells[0].Value.ToString();
            }
            frmPhieuDatCho phieu = new frmPhieuDatCho(this);
            phieu.Button_Clicked += new EventHandler(frm_Button_Clicked);
            this.Hide();
            phieu.Show();
        }
        void frm_Button_Clicked(object sender, EventArgs e)
        {
            this.btnLoadLai_Click(btnLoadLai, EventArgs.Empty);
        }
    }
}
