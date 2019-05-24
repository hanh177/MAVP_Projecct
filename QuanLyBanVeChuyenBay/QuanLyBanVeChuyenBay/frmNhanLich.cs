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




//cái mã khi click thì nó tự ra nha mk...ngta nghĩ v thôi ok ủa mk sao cài mấy cái combobox cho thành readonly đc nhờ..ngta tìm k thấy
//ngta kiếm trên mạng. quên rồi hihi, để đó mai mốt ngta làm lại ok..hèn j nay tìm lòih :v
//mk thử tự chạy nếu k hiểu ý tưởng thì ns ngta nha ok chạy luôn giờ hảừa
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
        int SoSBTGToida;
       // string strconn2 = @"Data Source=DESKTOP-JLJ2TBG;Initial Catalog=QLBanVeChuyenBay;Integrated Security=True";

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
                        txtMaCB.Text = "CB" + socb.ToString();

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
  
        public virtual string ValueMember { get; set; }

        string MASB;


        private void btnThem_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(strconn2);
           
            try
            {
                string MACB = txtMaCB.Text;
                string SANBAYDI = cmbSanBayDi.SelectedValue.ToString();
                string SANBAYDEN = cmbSanBayDen.SelectedValue.ToString();
                int THOIGIANBAY = Int32.Parse(txtThGianBay.Text);
                int SOGHEH1 = Int32.Parse(txtSoGheH1.Text);
                int SOGHEH2 = Int32.Parse(txtSoGheH2.Text);
                int GIAVE = Int32.Parse(txtGiaVe.Text);
                // DateTime NGAYBAY = DateTime.ParseExact(dateTimePicker1.Text, "dd/MM/yyyy hh:mm:ss", CultureInfo.InvariantCulture);
                DateTime NGAYBAY = dateTimePicker1.Value;
               
                conn.Open();
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
                
                if (them==true)
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
                

                MessageBox.Show("Thêm chuyến bay thành công.", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);


                string MATT = "TT" + txtMaCB.Text.Substring(2);
                string sqlQuery3 = "insert into[QLBanVeChuyenBay].[dbo].[TINHTRANG] values(" + "@MaTinhTrang, @MaCB, @SLGheTrongH1, @SLGheTrongH2,@TongSoGhe, @TongSoGheTrong,@TongSoGheDat)";
                SqlCommand command4= new SqlCommand(sqlQuery3, conn);
                command4.Parameters.AddWithValue("@MaTinhTrang", MATT);
                command4.Parameters.AddWithValue("@MaCB", MACB);
                command4.Parameters.AddWithValue("@SLGheTrongH1", SOGHEH1);
                command4.Parameters.AddWithValue("@SLGheTrongH2", SOGHEH2);
                command4.Parameters.AddWithValue("@TongSoGhe", SOGHEH1 + SOGHEH2);
                command4.Parameters.AddWithValue("@TongSoGheTrong", SOGHEH1+ SOGHEH2);
                command4.Parameters.AddWithValue("@TongSoGheDat", 0);
                command4.ExecuteNonQuery();

                txtMaCB.Text = "";
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        bool them = false;
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
                    }else { MessageBox.Show("Không thể thêm Sân bay trung gian vì đã vượt quá qui định", "Thêm sân bay trung gian không thành công", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                }
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

        private void txtMaSBTG_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(strconn2);
            try
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
                    string matg_data= dataSanBayTG.Rows[sodong-1].Cells[0].EditedFormattedValue.ToString();//lay cai ma trung gian duoc nhap sau cung
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
    }
}
