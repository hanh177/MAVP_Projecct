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
using System.Globalization;





namespace QuanLyBanVeChuyenBay
{
    public partial class frmNhanLich : Form
    {
        Form main;
        public frmNhanLich(Form frmMain)
        {
            InitializeComponent();
            this.main = frmMain;
        }

        string MACHUYENBAYCUOI;
        int TGDungToiDa;
        int TGDungToiThieu;
        int SoSBTGToida, thoigianquydinh, thoigianbay_min;

        string MaDoanhThuThang;
        //string strconn2 = @"Data Source=DESKTOP-JLJ2TBG;Initial Catalog=QLBanVeChuyenBay;Integrated Security=True";

        string strconn2 = @"Data Source=DESKTOP-TA2HS1O\SQLEXPRESS;Initial Catalog=QLBanVeChuyenBay;Integrated Security=True"; //cua ha anh

        private void Connection()
        {
            SqlConnection conn = new SqlConnection(strconn2);
            try
            {
                conn.Open();
                string sql = "SELECT * FROM SANBAY";
                SqlCommand command = new SqlCommand(sql, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable table = new DataTable();
                DataTable table2 = new DataTable();
                DataTable table3 = new DataTable();
                adapter.Fill(table);
                adapter.Fill(table2);
                adapter.Fill(table3);
              
                cmbSanBayDi.DataSource = table;
                cmbSanBayDi.DisplayMember = "TenSanBay";
                cmbSanBayDi.ValueMember = "MaSanBay";
              
                cmbSanBayDen.DataSource = table2;
                cmbSanBayDen.DisplayMember = "TenSanBay";
                cmbSanBayDen.ValueMember = "MaSanBay";

                cmbTenSBTG.DataSource = table3;
                cmbTenSBTG.DisplayMember = "TenSanBay";
                cmbTenSBTG.ValueMember = "MaSanBay";
                cmbTenSBTG.SelectedIndex = -1;

                command.ExecuteNonQuery();

                //Lay ma chuyen bay cuoi cung va cap nhat len 1
                string sql2 = "select Max(MaCB) as LastID from CHUYENBAY";
                SqlCommand command2 = new SqlCommand(sql2, conn);
                SqlDataAdapter adapter2 = new SqlDataAdapter(command2);
                DataSet dataSet = new DataSet();
                adapter2.Fill(dataSet, "MaCB");
                DataTable table4 = dataSet.Tables["MaCB"];
               
                    foreach (DataRow row in table4.Rows)
                    {
                        foreach (DataColumn col in table4.Columns)
                        {
                            MACHUYENBAYCUOI = row[col].ToString();
                        if (MACHUYENBAYCUOI == "") 
                            MACHUYENBAYCUOI = "CB00";
                        }
                    }
                    string macb = MACHUYENBAYCUOI.Substring(2);
                    int socb = Int32.Parse(macb);
                    socb = socb + 1;
                    bool flag = false;
                    if (socb < 10)
                        flag = true;
                if (flag == true)
                {
                    txtMaCB.Text = "CB0" + socb.ToString();

                }
                else
                {
                    txtMaCB.Text = "CB" + socb.ToString();
                }

                string sql3 = "Select * from THAMSO";
                SqlCommand cmd = new SqlCommand(sql3, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    SoSBTGToida= Int32.Parse(reader["SoSBTGToiDa"].ToString());
                    TGDungToiThieu = Int32.Parse(reader["TGDungToiThieu"].ToString());
                   TGDungToiDa = Int32.Parse(reader["TGDungToiDa"].ToString());
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
                MessageBox.Show("Ket noi xay ra loi hoac doc du lieu bi loi");
            }
            finally
            {
                //Dong ket noi sau khi thao tac ket thuc
                conn.Close();
            }
        }
       
   
        private void frmNhanLich_Load(object sender, EventArgs e)
        {
            Connection();
            DateTime dt = DateTime.Now;
            dateTimePicker1.MinDate = dt;
            if (quaquydinh == false)
                label12.Text = "*Lưu ý: Số sân bay trung gian không \nđược vượt quá " + SoSBTGToida + " theo qui định.";

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();           
        }

        private void tSbtnDanhSachCB_Click(object sender, EventArgs e)
        {
            Form danhsachcb = new frmDanSachCB(this);
            this.Hide();
            danhsachcb.ShowDialog();
            this.Show();
        }

        private void tSbtnDanhSachSB_Click(object sender, EventArgs e)
        {
            Form danhsachsb = new frmDanhSachSB(this);
            this.Hide();
            danhsachsb.ShowDialog();
            this.Connection();
            this.Show();
        }
        string str_MaDTCuoi, MaDoanhThuNam;
        private void btnThem_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(strconn2);
           
            try
            {
                conn.Open();
                string MACB = txtMaCB.Text;
                string SANBAYDI = cmbSanBayDi.SelectedValue.ToString();
                string SANBAYDEN = cmbSanBayDen.SelectedValue.ToString();
                int THOIGIANBAY = Int32.Parse(txtThGianBay.Text);
                int SOGHEH1 = Int32.Parse(txtSoGheH1.Text);
                int SOGHEH2 = Int32.Parse(txtSoGheH2.Text);
                int GIAVE = Int32.Parse(txtGiaVe.Text);
                DateTime NGAYBAY = dateTimePicker1.Value;

                //Lay nam cua chuyen bay
                string[] arr_tg = (NGAYBAY.ToString()).Split(' ');
                string[] arr_tg2 = arr_tg[0].Split('/');


                //Kiem tra tinh hop le cua ngay gio bay
                string ngaybay = NGAYBAY.ToString();
                DateTime d = DateTime.Now;
                string ngayhomnay = d.ToString();

                //Lay thoi gian quy dinh
                string sqlts = "select TGChamNhatDatVe,TGBayToiThieu from ThamSo where MaThamSo='TS01'";
                SqlCommand cmd = new SqlCommand(sqlts, conn);
                SqlDataAdapter adapter_tg = new SqlDataAdapter(cmd);
                DataTable table_tg = new DataTable();
                adapter_tg.Fill(table_tg);
                foreach (DataRow row in table_tg.Rows)
                {
                    foreach (DataColumn col in table_tg.Columns)
                    {
                        string s = row["TGChamNhatDatVe"].ToString();
                        string strtgbay_min = row["TGBayToiThieu"].ToString();
                        thoigianquydinh = Int32.Parse(s);
                        thoigianbay_min = Int32.Parse(strtgbay_min);
                    }
                }
                if (THOIGIANBAY < thoigianbay_min)
                {
                    MessageBox.Show("Thời gian bay phải >= " + thoigianbay_min + " phút.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    if (frmTraCuu.KiemTra(thoigianquydinh, ngayhomnay, ngaybay) == false)
                    {
                        MessageBox.Show("Không thể thêm chuyến bay có mã " + MACB + " vì thời gian nhận lịch phải trước " + thoigianquydinh + " (giờ) so với quy định.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;

                    }
                    else
                    {
                        String sqlQuery = "insert into [QLBanVeChuyenBay].[dbo].[CHUYENBAY] values ( " + "@MaCB, @SanBayDi, @SanBayDen,@NgayGio,@ThoiGianBay,@SLGheHang1,@SLGheHang2,@GiaVe)";
                        SqlCommand command = new SqlCommand(sqlQuery, conn);
                        command.Parameters.AddWithValue("@MaCB", MACB);
                        command.Parameters.AddWithValue("@SanBayDi", SANBAYDI);
                        command.Parameters.AddWithValue("@SanBayDen", SANBAYDEN);
                        command.Parameters.AddWithValue("@NgayGio", NGAYBAY);
                        command.Parameters.AddWithValue("@ThoiGianBay", THOIGIANBAY);
                        command.Parameters.AddWithValue("@SLGheHang1", SOGHEH1);
                        command.Parameters.AddWithValue("@SLGheHang2", SOGHEH2);
                        command.Parameters.AddWithValue("@GiaVe", GIAVE);
                        command.ExecuteNonQuery();


                        //Insert vao bang TRUNGGIAN

                        if (them == true)
                        {
                            int sodong = dataSanBayTG.RowCount;
                            string[] arrListStr = masb_tg.Split(',');
                            for (int i = 0; i < sodong; i++)
                            {
                                string MASB = arrListStr[i];
                                string MATG = dataSanBayTG.Rows[i].Cells[0].EditedFormattedValue.ToString();
                                string TGDUNG = dataSanBayTG.Rows[i].Cells[2].EditedFormattedValue.ToString();
                                string GHICHU = dataSanBayTG.Rows[i].Cells[3].EditedFormattedValue.ToString();
                                string sqlQuery2 = "insert into [QLBanVeChuyenBay].[dbo].[TRUNGGIAN] values ( " + "@MaTrungGian,@MaCB,@MaSanBay,@ThoiGianDung,@GhiChu)";
                                SqlCommand command3 = new SqlCommand(sqlQuery2, conn);
                                command3.Parameters.AddWithValue("@MaTrungGian", MATG);
                                command3.Parameters.AddWithValue("@MaCB", MACB);
                                command3.Parameters.AddWithValue("@MaSanBay", MASB);
                                command3.Parameters.AddWithValue("@ThoiGianDung", TGDUNG);
                                command3.Parameters.AddWithValue("@GhiChu", GHICHU);

                                command3.ExecuteNonQuery();
                            }

                        }


                      
                        

                        //Insert vao bang tinh trang
                        string MATT = "TT" + txtMaCB.Text.Substring(2);
                        string sqlQuery3 = "insert into[QLBanVeChuyenBay].[dbo].[TINHTRANG] values(" + "@MaTinhTrang, @MaCB, @SLGheTrongH1, @SLGheTrongH2,@TongSoGhe, @TongSoGheTrong,@TongSoGheDat)";
                        SqlCommand command4 = new SqlCommand(sqlQuery3, conn);
                        command4.Parameters.AddWithValue("@MaTinhTrang", MATT);
                        command4.Parameters.AddWithValue("@MaCB", MACB);
                        command4.Parameters.AddWithValue("@SLGheTrongH1", SOGHEH1);
                        command4.Parameters.AddWithValue("@SLGheTrongH2", SOGHEH2);
                        command4.Parameters.AddWithValue("@TongSoGhe", SOGHEH1 + SOGHEH2);
                        command4.Parameters.AddWithValue("@TongSoGheTrong", SOGHEH1 + SOGHEH2);
                        command4.Parameters.AddWithValue("@TongSoGheDat", 0);
                        command4.ExecuteNonQuery();


                        //Insert vao bang DOANHTHUTHANGCB


                        //Trước hết phải insert vào bảng TONGDOANHTHUNAM nếu chưa có
                        //Kiem tra xem da co muc doanh thu cua nam hien tai hay chua

                        string sqlQuery5 = "select MaDoanhThuNam from TONGDOANHTHUNAM where Nam = " + arr_tg2[2];
                        SqlCommand command5 = new SqlCommand(sqlQuery5, conn);
                        SqlDataAdapter adapter5 = new SqlDataAdapter(command5);
                        DataSet dataSet5 = new DataSet();
                        adapter5.Fill(dataSet5, "MaDoanhThuNam");
                        DataTable table5 = dataSet5.Tables["MaDoanhThuNam"];

                        if (table5.Rows.Count == 0)  //Chưa có thì tạo mới
                        {
                            MaDoanhThuNam = "DTN" + arr_tg2[2];
                            string sqlQuery6 = "insert into TONGDOANHTHUNAM values ( " + "@MaDoanhThuNam, @TongDoanhThu, @Nam, @TiLe) ";
                            SqlCommand command6 = new SqlCommand(sqlQuery6, conn);
                            command6.Parameters.AddWithValue("@MaDoanhThuNam", MaDoanhThuNam);
                            command6.Parameters.AddWithValue("@TongDoanhThu", 0);
                            command6.Parameters.AddWithValue("@Nam", arr_tg2[2]);
                            command6.Parameters.AddWithValue("@TiLe", 0.0);
                            command6.ExecuteNonQuery();
                        }
                        else//Đã có rồi thì lấy cái mã ra
                        {
                            foreach (DataRow row in table5.Rows)
                            {
                                foreach (DataColumn col in table5.Columns)
                                    MaDoanhThuNam = row["MaDoanhThuNam"].ToString();
                            }
                        }




                        //Insert vao bang DOANHTHUTHANG
                        //Nếu bảng DOANHTHUTHANG của tháng hiện tại mà chưa có thì phải insert vào mới không thì k cần
                        //LẤY MÃ DOANHTHUTHANG 

                        string sqlQuery7 = "select MaDoanhThuThang from TONGDOANHTHUTHANG where MaDoanhThuNam= '" + MaDoanhThuNam + "'" + " and Thang= " + arr_tg2[0];
                        SqlCommand command7 = new SqlCommand(sqlQuery7, conn);
                        SqlDataAdapter adapter7 = new SqlDataAdapter(command7);
                        DataSet dataSet7 = new DataSet();
                        adapter7.Fill(dataSet7, "MaDoanhThuThang");
                        DataTable table7 = dataSet7.Tables["MaDoanhThuThang"];
                        if (table7.Rows.Count == 0)
                        {
                            //Chưa có thì tạo mới
                            //Trước khi tạo mới phải lấy được cái mã cuối cùng của nó
                            string sqlQuery8 = "select Max(MaDoanhThuThang) as LastID from TONGDOANHTHUTHANG";
                            SqlCommand command8 = new SqlCommand(sqlQuery8, conn);
                            SqlDataAdapter adapter8 = new SqlDataAdapter(command8);
                            DataSet dataSet8 = new DataSet();
                            adapter8.Fill(dataSet8, "MaDoanhThuThang");
                            DataTable table8 = dataSet8.Tables["MaDoanhThuThang"];
                            foreach (DataRow row in table8.Rows)
                            {
                                foreach (DataColumn col in table8.Columns)
                                {
                                    str_MaDTCuoi = row[col].ToString();
                                    if (str_MaDTCuoi == "")
                                        str_MaDTCuoi = "DTT00";
                                }
                            }
                            string madt = str_MaDTCuoi.Substring(3);
                            int sodt = Int32.Parse(madt);
                            sodt = sodt + 1;
                            bool flag = false;
                            if (sodt < 10)
                                flag = true;
                            if (flag == true)
                            {
                                MaDoanhThuThang = "DTT0" + sodt.ToString();
                            }
                            else
                                MaDoanhThuThang = "DTT" + sodt.ToString();

                            //Tạo mới 
                            string sqlQuery9 = "insert into TONGDOANHTHUTHANG values ( " + "@MaDoanhThuThang, @MaDoanhThuNam, @SoChuyenBay, @TongDoanhThu, @TiLe, @Thang) ";
                            SqlCommand command9 = new SqlCommand(sqlQuery9, conn);
                            command9.Parameters.AddWithValue("@MaDoanhThuThang", MaDoanhThuThang);
                            command9.Parameters.AddWithValue("@MaDoanhThuNam", MaDoanhThuNam);
                            command9.Parameters.AddWithValue("@SoChuyenBay", 0);
                            command9.Parameters.AddWithValue("@TongDoanhThu", 0);
                            command9.Parameters.AddWithValue("@TiLe", 0.00);
                            command9.Parameters.AddWithValue("@Thang", arr_tg2[0]);
                            command9.ExecuteNonQuery();
                        }
                        else//Đã có rồi thì lấy cái mã ra
                        {
                            foreach (DataRow row in table7.Rows)
                            {
                                foreach (DataColumn col in table5.Columns)
                                    MaDoanhThuThang = row["MaDoanhThuThang"].ToString();
                            }
                        }



                        //Insert vao bang DOANHTHUTHANGCB
                        //Lay ma doanh thu thang cua chuyen bay
                        string MaDoanhThuThangCB = "DTTCB" + txtMaCB.Text.Substring(2);

                        string sqlQuery10 = "insert into DOANHTHUTHANGCB values ( " + "@MaDoanhThuCB, @MaDoanhThuThang, @MaCB, @SoVe, @DoanhThu, @TiLe) ";
                        SqlCommand command10 = new SqlCommand(sqlQuery10, conn);
                        command10.Parameters.AddWithValue("@MaDoanhThuCB", MaDoanhThuThangCB);
                        command10.Parameters.AddWithValue("@MaDoanhThuThang", MaDoanhThuThang);
                        command10.Parameters.AddWithValue("@MaCB", MACB);
                        command10.Parameters.AddWithValue("@SoVe", 0);
                        command10.Parameters.AddWithValue("@DoanhThu", 0);
                        command10.Parameters.AddWithValue("@TiLe", 0.00);
                        command10.ExecuteNonQuery();

                        //Update so chuyen bay trong bang TONGDOANHTHUTHANG thêm 1

                        string sqlQuery11 = "Update TONGDOANHTHUTHANG set SoChuyenBay= SoChuyenBay + 1 where MaDoanhThuThang= '" + MaDoanhThuThang + "'";
                        SqlCommand command11 = new SqlCommand(sqlQuery11, conn);
                        command11.ExecuteNonQuery();

                    }
                }
                MessageBox.Show("Thêm chuyến bay thành công.", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                string macb = MACB.Substring(2);
                int socb = Int32.Parse(macb);
                socb = socb + 1;
                 bool flag1 = false;
                if (socb < 10)
                    flag1 = true;
                if (flag1 == true)
                {
                    txtMaCB.Text = "CB0" + socb.ToString();

                }
                else
                {
                    txtMaCB.Text = "CB" + socb.ToString();
                }
                cmbSanBayDi.Text= "";
                cmbSanBayDen.Text = "";
                dateTimePicker1.Text = "";
                txtSoGheH1.Text = "";
                txtSoGheH2.Text = "";
                txtThGianBay.Text = "";
                txtGiaVe.Text = "";
                cmbSanBayDi.SelectedIndex = -1;
                cmbSanBayDen.SelectedIndex = -1;
                dataSanBayTG.Rows.Clear();
            }
            catch (InvalidOperationException ex)
            {
                //xu ly khi ket noi co van de
              //  MessageBox.Show("Khong the mo ket noi hoac ket noi da mo truoc do");
                MessageBox.Show(ex.Message);
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        bool them = false, quaquydinh = false;
        public string masb_tg;//dung luu cac ma sb trung gian duoc them vao
        private void btnThemTG_Click(object sender, EventArgs e)
        {
            if (txtMaSBTG.Text == "" || txtTGDung.Text == "" || cmbTenSBTG.SelectedIndex == -1)
            {
                MessageBox.Show("Sai cú pháp do điền thiếu trường dữ liệu.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                if (Int32.Parse(txtTGDung.Text) < TGDungToiThieu || Int32.Parse(txtTGDung.Text) > TGDungToiDa)
                {
                    MessageBox.Show("Thời gian dừng phải lớn hơn " + TGDungToiThieu + " và nhỏ hơn " + TGDungToiDa, "Thêm SBTG không thành công", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    //MessageBox.Show("Now: " + dataSanBayTG.Rows.Count);
                    if (dataSanBayTG.Rows.Count < SoSBTGToida)
                    {
                        dataSanBayTG.Rows.Add(1);
                        int indexRow = dataSanBayTG.Rows.Count - 1;
                        dataSanBayTG[0, indexRow].Value = txtMaSBTG.Text;
                        dataSanBayTG[1, indexRow].Value = cmbTenSBTG.Text;
                        dataSanBayTG[2, indexRow].Value = txtTGDung.Text;
                        dataSanBayTG[3, indexRow].Value = txtGhiChu.Text;
                        if (masb_tg == null)
                        {
                            masb_tg = cmbTenSBTG.SelectedValue.ToString();
                        }
                        else
                        {
                            masb_tg = masb_tg + "," + cmbTenSBTG.SelectedValue.ToString();
                        }

                        them = true;
                        txtMaSBTG.Text = "";
                        cmbTenSBTG.SelectedIndex = -1;
                        txtTGDung.Text = "";
                        txtGhiChu.Text = "";
                    }
                }

            }
            if (dataSanBayTG.Rows.Count >= SoSBTGToida)
            {
                label12.ForeColor = Color.Red;
                label12.Text = "Số sân bay trung gian đã đạt số lượng tối đa.";

                //MessageBox.Show("Không thể thêm Sân bay trung gian vì đã vượt quá qui định", "Thêm sân bay trung gian không thành công", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMaSBTG.Enabled = false;
                cmbTenSBTG.Enabled = false;
                txtTGDung.Enabled = false;
                txtGhiChu.Enabled = false;
                return;
            }
        }
        private bool nonNumberEntered = false;
        private void txtTGDung_KeyDown(object sender, KeyEventArgs e)
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

        private void txtTGDung_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (nonNumberEntered == true)
            {
                e.Handled = true;
                MessageBox.Show("Thời gian không thể là chữ, vui lòng nhập lại. ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTGDung.Text = "";
                return;
            }
        }

        string MACHUYENBAYTGCUOI;
        private void txtMaSBTG_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void txtThGianBay_KeyDown(object sender, KeyEventArgs e)
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

        private void txtThGianBay_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (nonNumberEntered == true)
            {
                e.Handled = true;
                MessageBox.Show("Thời gian không thể là chữ, vui lòng nhập lại. ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtThGianBay.Text = "";
                return;
            }
        }

        private void txtSoGheH1_KeyDown(object sender, KeyEventArgs e)
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

        private void txtSoGheH1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (nonNumberEntered == true)
            {
                e.Handled = true;
                MessageBox.Show("Số ghế không thể là chữ, vui lòng nhập lại. ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSoGheH1.Text = "";
                return;
            }
        }

        private void txtSoGheH2_KeyDown(object sender, KeyEventArgs e)
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

        private void txtSoGheH2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (nonNumberEntered == true)
            {
                e.Handled = true;
                MessageBox.Show("Số ghế không thể là chữ, vui lòng nhập lại. ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSoGheH2.Text = "";
                return;
            }

        }

        private void txtGiaVe_KeyDown(object sender, KeyEventArgs e)
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

        private void txtGiaVe_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (nonNumberEntered == true)
            {
                e.Handled = true;
                MessageBox.Show("Giá vé không thể là chữ, vui lòng nhập lại. ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtGiaVe.Text = "";
                return;
            }
        }

        private void txtMaSBTG_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(strconn2);
            try
            {
                if (quaquydinh == false)
                {
                    int sodong = dataSanBayTG.RowCount;
                    conn.Open();
                    if (dataSanBayTG.Rows.Count == 0)
                    {
                        string sql = "select Max(MaTrungGian) as LastID from TRUNGGIAN";
                        SqlCommand command = new SqlCommand(sql, conn);
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataSet dataSet = new DataSet();
                        adapter.Fill(dataSet, "MaTrungGian");
                        DataTable table = dataSet.Tables["MaTrungGian"];

                        foreach (DataRow row in table.Rows)
                        {
                            foreach (DataColumn col in table.Columns)
                            {
                                MACHUYENBAYTGCUOI = row[col].ToString();
                                if (MACHUYENBAYTGCUOI == "")
                                    MACHUYENBAYTGCUOI = "TG00";
                            }
                        }
                        string macb_tg = MACHUYENBAYTGCUOI.Substring(2);
                        int socb_tg = Int32.Parse(macb_tg);
                        socb_tg = socb_tg + 1;
                        bool flag = false;
                        if (socb_tg < 10)
                            flag = true;
                        if (flag == true)
                        {
                            txtMaSBTG.Text = "TG0" + socb_tg.ToString();
                        }
                        else
                            txtMaSBTG.Text = "TG" + socb_tg.ToString();
                    }
                    else//Da nhap them 1 hoac 2 san bay trung gian
                    {
                        string matg_data = dataSanBayTG.Rows[sodong - 1].Cells[0].EditedFormattedValue.ToString();//lay cai ma trung gian duoc nhap sau cung
                        string macb_tg2 = matg_data.Substring(2);
                        int socb_tg2 = Int32.Parse(macb_tg2);
                        socb_tg2 = socb_tg2 + 1;
                        bool flag2 = false;
                        if (socb_tg2 < 10)
                            flag2 = true;
                        if (flag2 == true)
                        {
                            txtMaSBTG.Text = "TG0" + socb_tg2.ToString();
                        }
                        else
                            txtMaSBTG.Text = "TG" + socb_tg2.ToString();
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
                MessageBox.Show("Ket noi xay ra loi hoac doc du lieu bi loi");
            }
            finally
            {
                //Dong ket noi sau khi thao tac ket thuc
                conn.Close();
            }
        }

        private void btnXoaSBTG_Click(object sender, EventArgs e)
        {
            try
            {
                int rowIndex = dataSanBayTG.CurrentCell.RowIndex;
                dataSanBayTG.Rows.RemoveAt(rowIndex);
            }
            catch { };
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }
    }
}
