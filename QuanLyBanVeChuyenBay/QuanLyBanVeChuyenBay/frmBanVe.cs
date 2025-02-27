﻿using System;
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
    public partial class frmBanVe : Form
    {
        Form tracuu;

        public frmBanVe(Form frmTraCuu)
        {
            InitializeComponent();
            this.tracuu = frmTraCuu;
        }


        string strconn2 = frmMain.strconn2;
        double DonGia;
        int GheTrongH1, GheTrongH2, tongsoghe;
        int tongdoanhthuthangcb = 0;
        bool ConGheH1 , ConGheH2,  DatVe = true;
        string MAVE, MAKH, MAPHIEU, thang, nam, MaDoanhThuThang, MaDoanhThuNam;
        double TongDoanhThu;//MAVE luu gia tri ma ve cuoi cung.
        private void Connection()
        {
            
            SqlConnection conn = new SqlConnection(strconn2);

            try
            {
                conn.Open();
                //Lay ma ve cuoi cung va cap nhat them 1

                string sql = "select Max(MaVe) as LastID from VE";
                SqlCommand command = new SqlCommand(sql, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataSet dataSet = new DataSet();
                adapter.Fill(dataSet, "MaVe");
                DataTable table = dataSet.Tables["MaVe"];
                    foreach (DataRow row in table.Rows)
                    {
                        foreach (DataColumn col in table.Columns)
                        {
                            MAVE = row[col].ToString();
                            if (MAVE == "")
                                MAVE = "VE00";
                        }
                    }
                string mave = MAVE.Substring(2);
                int sove= Int32.Parse(mave);
                sove = sove + 1;
                bool flag = false;
                if (sove < 10)
                    flag = true;
                if (flag == true)
                {
                    txtMaVe.Text = "VE0" + sove.ToString();
                }
                else
                    txtMaVe.Text = "VE" + sove.ToString();

                //Lay ma hanh khach cuoi cung va cap nhat len 1
                string sql2 = "select Max(MaHanhKhach) as LastID from HANHKHACH";
                SqlCommand command2 = new SqlCommand(sql2, conn);
                SqlDataAdapter adapter2 = new SqlDataAdapter(command2);
                DataSet dataSet2 = new DataSet();
                adapter2.Fill(dataSet2, "MaHanhKhach");
                DataTable table2 = dataSet2.Tables["MaHanhKhach"];
                foreach (DataRow row in table2.Rows)
                {
                    foreach (DataColumn col in table2.Columns)
                    {
                        MAKH = row[col].ToString();
                      if (MAKH == "")
                            MAKH = "KH00";
                    }
                }
                string makh = MAKH.Substring(2);
                int sokh = Int32.Parse(makh);
                sokh = sokh + 1;
                bool flagkh = false;
                if (sokh < 10)
                    flagkh = true;
                if (flagkh == true)
                {
                    txtMaKH.Text = "KH0" + sokh.ToString();
                }
                else
                    txtMaKH.Text = "KH" + sokh.ToString();
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
           
            ConGheH1 = true;
            ConGheH2 = true;
           
            DatVe = true;
            if (frmTraCuu.macb.ToString() != "")
            { txtMaCB.Text = frmTraCuu.macb.ToString();
                DonGia = frmTraCuu.DONGIA; }
            else if (frmDanSachCB.macb.ToString()!="")
            {
                txtMaCB.Text = frmDanSachCB.macb.ToString();
                DonGia = frmDanSachCB.DONGIA;
            }
        }
        

        private void btnDanhSachCB_Click(object sender, EventArgs e)
        {
            Form danhsachcb = new frmDanSachCB(this);
            this.Hide();
            danhsachcb.Show();
        }

        private void txtCMND_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCMND_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (nonNumberEntered == true)
            {
                e.Handled = true;
                MessageBox.Show("CMND sai cú pháp. ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCMND.Text = "";
                return;
            }
        }
        private bool nonNumberEntered = false;
        private void txtCMND_KeyDown(object sender, KeyEventArgs e)
        {
            nonNumberEntered = false;

            if (e.KeyCode < Keys.D0 || e.KeyCode > Keys.D9)
            {
                if (e.KeyCode < Keys.NumPad0 || e.KeyCode > Keys.NumPad9)
                {
                    if (e.KeyCode != Keys.Back)
                    {
                        nonNumberEntered = true;
                    }
                }
            }
            //If shift key was pressed, it's not a number.
            if (Control.ModifierKeys == Keys.Shift)
            {
                nonNumberEntered = true;
            }
        }

        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (nonNumberEntered == true)
            {
                e.Handled = true;
                MessageBox.Show("SDT không thể có chữ, vui lòng nhập lại. ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSDT.Text = "";
                return;
            }
        }

        private void txtSDT_KeyDown(object sender, KeyEventArgs e)
        {
            nonNumberEntered = false;

            if (e.KeyCode < Keys.D0 || e.KeyCode > Keys.D9)
            {
                if (e.KeyCode < Keys.NumPad0 || e.KeyCode > Keys.NumPad9)
                {
                    if (e.KeyCode != Keys.Back)
                    {
                        nonNumberEntered = true;
                    }
                }
            }
            //If shift key was pressed, it's not a number.
            if (Control.ModifierKeys == Keys.Shift)
            {
                nonNumberEntered = true;
            }
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void tSbtnPhieuDatCho_Click(object sender, EventArgs e)
        {
            Form phieudatcho = new frmPhieuDatCho(this);
            this.Hide();
            phieudatcho.Show();
        }

        private void btnThoat_Click_1(object sender, EventArgs e)
        {     
            this.Close();
         
        }

        private void tSbtnDanhSachCB_Click(object sender, EventArgs e)
        {
            Form danhsachcb = new frmDanSachCB(this);
            this.Hide();
            danhsachcb.Show();
        }

        
       
        private void btnDatVe_Click(object sender, EventArgs e)
        {
            if (txtCMND.Text == "" || txtHoTen.Text == "" || txtSDT.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin hành khách", "Đặt vé không thành công", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                SqlConnection conn = new SqlConnection(strconn2);

                try
                {
                    string MaVe = txtMaVe.Text;
                    int HangVe = Int32.Parse(cmbHangVe.SelectedItem.ToString());
                    float GiaVe = Int32.Parse(txtGiaVe.Text);
                    string MaHanhKhach = txtMaKH.Text;
                    string HoTen = txtHoTen.Text;
                    string CMND = txtCMND.Text;
                    string SDT = txtSDT.Text;
                    string MaCB = txtMaCB.Text;
                    string NgayDat = System.DateTime.Now.ToShortDateString();

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

                        else
                        {
                            MessageBox.Show("Không còn ghế trống.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                    if (DatVe == true)
                    {
                        //insert hanh khach

                        String sqlQuery1 = "insert into [QLBanVeChuyenBay].[dbo].[HANHKHACH] values ( " + "@MaHanhKhach, @HoTen, @CMND, @SDT, @MaCB)";
                        SqlCommand command1 = new SqlCommand(sqlQuery1, conn);
                        command1.Parameters.AddWithValue("@MaHanhKhach", MaHanhKhach);
                        command1.Parameters.AddWithValue("@HoTen", HoTen);
                        command1.Parameters.AddWithValue("@CMND", CMND);
                        command1.Parameters.AddWithValue("@SDT", SDT);
                        command1.Parameters.AddWithValue("@MaCB", MaCB);
                        command1.ExecuteNonQuery();


                        //insert ve

                        String sqlQuery2 = "insert into [QLBanVeChuyenBay].[dbo].[Ve] values ( " + "@MaVe, @MaHanhKhach, @MaCB, @GiaVe, @HangVe)";
                        SqlCommand command2 = new SqlCommand(sqlQuery2, conn);
                        command2.Parameters.AddWithValue("@MaVe", MaVe);
                        command2.Parameters.AddWithValue("@MaHanhKhach", MaHanhKhach);
                        command2.Parameters.AddWithValue("@MaCB", txtMaCB.Text);
                        command2.Parameters.AddWithValue("@GiaVe", GiaVe);
                        command2.Parameters.AddWithValue("@HangVe", HangVe);
                        
                        command2.ExecuteNonQuery();

                        MessageBox.Show("Đặt vé thành công", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);



                        // Cap nhat bang TINHTRANG

                        string sqlQuery3 = "Update TINHTRANG set SLGheTrongH1 = SLGheTrongH1 - " + GheDatH1 +
                            ", SLGheTrongH2 = SLGheTrongH2 -" + GheDatH2 +
                            ", TongSoGhe = TongSoGhe, TongSoGheTrong = TongSoGheTrong - 1, TongSoGheDat =TongSoGheDat + 1 where MaCB = '"
                            + txtMaCB.Text + "' ";
                        SqlCommand command3 = new SqlCommand(sqlQuery3, conn);
                        command3.ExecuteNonQuery();



                        // insert vao bang PHIEUDATCHO
                        //Lay MaPhieu
                        string MaPhieu;
                        string sqlQuery4 = "select Max(MaPhieu) as LastID from PHIEUDATCHO";
                        SqlCommand command4 = new SqlCommand(sqlQuery4, conn);
                        SqlDataAdapter adapter = new SqlDataAdapter(command4);
                        DataSet dataSet = new DataSet();
                        adapter.Fill(dataSet, "MaPhieu");
                        DataTable table = dataSet.Tables["MaPhieu"];
                        foreach (DataRow row in table.Rows)
                        {
                            foreach (DataColumn col in table.Columns)
                            {
                                MAPHIEU = row[col].ToString();
                                if (MAPHIEU == "")
                                    MAPHIEU = "PH00";
                            }
                        }
                        string maphieu = MAPHIEU.Substring(2);
                        int sophieu = Int32.Parse(maphieu);
                        sophieu = sophieu + 1;
                        bool flag = false;
                        if (sophieu < 10)
                            flag = true;
                        if (flag == true)
                        {
                            MaPhieu = "PH0" + sophieu.ToString();
                        }
                        else
                            MaPhieu = "PH" + sophieu.ToString();

                        string sqlQuery5 = "insert into PHIEUDATCHO values ( " + "@MaPhieu, @MaCB, @MaHanhKhach, @MaVe,@NgayDat) ";
                        SqlCommand command5 = new SqlCommand(sqlQuery5, conn);
                        command5.Parameters.AddWithValue("@MaPhieu", MaPhieu);
                        command5.Parameters.AddWithValue("@MaCB", MaCB);
                        command5.Parameters.AddWithValue("@MaHanhKhach", MaHanhKhach);
                        command5.Parameters.AddWithValue("@MaVe", MaVe);
                        command5.Parameters.AddWithValue("@NgayDat", NgayDat);
                        command5.ExecuteNonQuery();


                        //Update bảng DOANHTHUTHANGCB 

                        if(frmTraCuu.tongsoghe!=0)
                        {
                            tongsoghe = frmTraCuu.tongsoghe;
                            thang = frmTraCuu.thang;
                            nam = frmTraCuu.nam;
                        }
                        if (frmDanSachCB.tongsoghe != 0)
                        {
                            tongsoghe = frmDanSachCB.tongsoghe;
                            thang = frmDanSachCB.thang;
                            nam = frmDanSachCB.nam;
                        }
                       // MessageBox.Show(tongsoghe.ToString());
                        string sqlQuery6 = "Update DOANHTHUTHANGCB set SoVe = SoVe + 1, DoanhThu = DoanhThu + " + GiaVe + ", TiLe = cast(round(100.0*(SoVe+1)/"+tongsoghe +",2) as numeric(36,2))  where MaCB = '" + MaCB + "'";
                        SqlCommand command6 = new SqlCommand(sqlQuery6, conn);
                        command6.ExecuteNonQuery();

                        //Lay ra doanh thu cua chuyen bay thang nay
                        
                        string sqlQuery7 = "select DoanhThu, MaDoanhThuThang  from DOANHTHUTHANGCB where MaCB= '" + MaCB + "'";
                        SqlCommand command7 = new SqlCommand(sqlQuery7, conn);
                        SqlDataAdapter adapter2 = new SqlDataAdapter(command7);
                        DataTable table2 = new DataTable();
                        adapter2.Fill(table2);
                        foreach (DataRow row in table2.Rows)
                        {
                            foreach (DataColumn col in table2.Columns)
                            {
                                string doanhthuthangcb = row["DoanhThu"].ToString();
                                string[] arr_doanhthu = doanhthuthangcb.Split('.');
                                tongdoanhthuthangcb = Int32.Parse(arr_doanhthu[0]);
                                MaDoanhThuThang = row["MaDoanhThuThang"].ToString();
                            }
                        }

                        //update Doanhthuthang, doanhthunam: OK

                        //update từ form DanhsachCB: OK

                        //update Hủy vé : OK
                       

                        //Update bang DoanhThuThang 

                        string sql = "select cast(round( sum(tile),2 ) as numeric(36,2)) tongTiLe, count(madoanhthuCB) tongsoCB  from DOANHTHUTHANGCB where  MaDoanhThuThang= '" + MaDoanhThuThang + "'";
                        SqlCommand cmd = new SqlCommand(sql, conn);
                        SqlDataReader read = cmd.ExecuteReader();
                        float TongTiLe = 0.0f;
                        int socb = 0;
                        while (read.Read())
                        {
                            string t = read["tongTiLe"].ToString();
                            TongTiLe = float.Parse(t);
                            socb = int.Parse(read["tongsoCB"].ToString());
                        }

                        float tilethang = TongTiLe / socb;
                        //  MessageBox.Show("ti le thang: " + tilethang.ToString());
                        conn.Close();
                        conn.Open();


                        string sqlQuery8 = "Update TONGDOANHTHUTHANG set TongDoanhThu = TongDoanhThu + " + GiaVe + ", TiLe = cast(round("+tilethang+",2) as numeric(36,2))   where MaDoanhThuThang= '" + MaDoanhThuThang + "'";
                        SqlCommand command8 = new SqlCommand(sqlQuery8, conn);
                        command8.ExecuteNonQuery();

                        //Lay ra ma doanh thu cua thang va doanh thu cua thang trong nam

                        string sqlQuery9 = "select TongDoanhThu,MaDoanhThuNam  from TONGDOANHTHUTHANG where MaDoanhThuThang= '" + MaDoanhThuThang + "'";
                        SqlCommand command9 = new SqlCommand(sqlQuery9, conn);
                        SqlDataAdapter adapter3 = new SqlDataAdapter(command9);
                        DataTable table3 = new DataTable();
                        adapter3.Fill(table3);
                        foreach (DataRow row in table3.Rows)
                        {
                            foreach (DataColumn col in table3.Columns)
                            {
                                string TongDoanhThuThang= row["TongDoanhThu"].ToString();
                                string[] arr_doanhthuthang = TongDoanhThuThang.Split('.');
                                TongDoanhThu = Int32.Parse(arr_doanhthuthang[0]);
                                MaDoanhThuNam = row["MaDoanhThuNam"].ToString();
                            }
                        }

                        //Update bang TONGDOANHTHUNAM

                        string sql2 = "select cast(round( sum(tile),2 ) as numeric(36,2)) tongTiLe, count(MaDoanhThuThang) tongsoThang  from TONGDOANHTHUTHANG where MaDoanhThuNam= '" + MaDoanhThuNam + "'";
                        SqlCommand cmd2 = new SqlCommand(sql2, conn);
                        SqlDataReader read2 = cmd2.ExecuteReader();
                        float TongTiLe2 = 0.0f;
                        int sothang = 0;
                        while (read2.Read())
                        {
                            string t = read2["tongTiLe"].ToString();
                            TongTiLe2 = float.Parse(t);
                            sothang = int.Parse(read2["tongsoThang"].ToString());
                        }

                        float tilenam = TongTiLe2 / sothang;
                        //MessageBox.Show("ti le nam: " + tilenam.ToString());
                        conn.Close();

                        conn.Open();

                        string sqlQuery10 = "Update TONGDOANHTHUNAM set TongDoanhThu = TongDoanhThu + " + GiaVe + ", TiLe = cast(round(" + tilenam + ",2) as numeric(36,2))    where MaDoanhThuNam = '" + MaDoanhThuNam + "'";
                        SqlCommand command10 = new SqlCommand(sqlQuery10, conn);
                        command10.ExecuteNonQuery();


                        this.Hide();
                        //tracuu.Show();
                    }
                    else MessageBox.Show("Không còn ghế trống hạng " + HangVe + " để đặt");
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
        }

        private void cmbHangVe_SelectedIndexChanged(object sender, EventArgs e)
        {
            ////////////////////////////////////////////////////////////////////////
             SqlConnection conn = new SqlConnection(strconn2);

            try
            {
                conn.Open();

                //Kiem tra con ghe trong de dat hay khong

                string sqlQuery = "select SLGheTrongH1, SLGheTrongH2 from TINHTRANG where MaCB =@MaCB";
                SqlCommand command = new SqlCommand(sqlQuery, conn);
                command.Parameters.AddWithValue("@MaCB", txtMaCB.Text);
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
                    double h1 = DonGia * 1.05;

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
