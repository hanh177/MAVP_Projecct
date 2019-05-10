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
        string strconn = @"Data Source=DESKTOP-JLJ2TBG;Initial Catalog=QLBanVeChuyenBay;Integrated Security=True";
        private void Connection()
        {
            SqlConnection conn = new SqlConnection(strconn);
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

                cmbTenSBTrungGian.DataSource = table3;
                cmbTenSBTrungGian.DisplayMember = "TenSanBay";
                cmbTenSBTrungGian.ValueMember = "MaSanBay";

                command.ExecuteNonQuery();

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
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

       

        private void frmNhanLich_Load(object sender, EventArgs e)
        {
            Connection();
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

        private void tSbtnDanhSachSB_Click(object sender, EventArgs e)
        {
            Form danhsachsb = new frmDanhSachSB(this);
            this.Hide();
            danhsachsb.Show();
        }

        private void cmbSanBayDi_ValueMemberChanged(object sender, EventArgs e)
        {
            
        }

        private void dataSanBayTG_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public virtual string ValueMember { get; set; }
       

        private void btnThem_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(strconn);
           
            try
            {
                string MACB = txtMaCB.Text;
                string SANBAYDI = cmbSanBayDi.SelectedValue.ToString();
                string SANBAYDEN = cmbSanBayDen.SelectedValue.ToString();
                int THOIGIANBAY = Int32.Parse(txtThGianBay.Text);
                int SOGHEH1 = Int32.Parse(txtSoGheH1.Text);
                int SOGHEH2 = Int32.Parse(txtSoGheH2.Text);
                int GIAVE = Int32.Parse(txtGiaVe.Text);
                DateTime NGAYBAY = DateTime.ParseExact(txtNgayBay.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);

                
                conn.Open();
                String sqlQuery = "insert into [QLBanVeChuyenBay].[dbo].[CHUYENBAY] values ( " + "@MaCB, @SanBayDi, @SanBayDen,@NgayGio,@ThoiGianBay,@SLGheHang1,@SLGheHang2,@GiaVe)";
                SqlCommand commnad = new SqlCommand(sqlQuery, conn);
                commnad.Parameters.AddWithValue("@MaCB", MACB);
                commnad.Parameters.AddWithValue("@SanBayDi", SANBAYDI);
                commnad.Parameters.AddWithValue("@SanBayDen", SANBAYDEN);
                commnad.Parameters.AddWithValue("@NgayGio", NGAYBAY);
                commnad.Parameters.AddWithValue("@ThoiGianBay", THOIGIANBAY);
                commnad.Parameters.AddWithValue("@SLGheHang1", SOGHEH1);
                commnad.Parameters.AddWithValue("@SLGheHang2", SOGHEH2);
                commnad.Parameters.AddWithValue("@GiaVe", GIAVE);
                commnad.ExecuteNonQuery();

                string TENSBTG = dataSanBayTG.CurrentRow.Cells[1].EditedFormattedValue.ToString();

                string sql = "SELECT * FROM SANBAY WHERE @TenSanBay=TENSBTG";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@TenSanBay", TENSBTG);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable table = new DataTable();
                adapter.Fill(table);
                object value = cmd.ExecuteScalar();
                string MASB = table.Rows[0].ItemArray.ToString();

                string MATG = dataSanBayTG.CurrentRow.Cells[0].EditedFormattedValue.ToString();
                string TGDUNG= dataSanBayTG.CurrentRow.Cells[2].EditedFormattedValue.ToString();
                string GHICHU= dataSanBayTG.CurrentRow.Cells[3].EditedFormattedValue.ToString();
                string sqlQuery2 = "insert into [QLBanVeChuyenBay].[dbo].[TRUNGGIAN] values ( " + "@MaTrungGian,@MaCB,@MaSanBay,@ThoiGianDung,@GhiChu)";
                SqlCommand commnad3 = new SqlCommand(sqlQuery2, conn);
                commnad3.Parameters.AddWithValue("@MaTrungGian", MATG);
                commnad3.Parameters.AddWithValue("@MaCB", MACB);
                commnad3.Parameters.AddWithValue("@MaSanBay", MASB);
                commnad3.Parameters.AddWithValue("@ThoiGianDung", TGDUNG);
                commnad3.Parameters.AddWithValue("@GhiChu", GHICHU);
               
                commnad3.ExecuteNonQuery();

                MessageBox.Show("Thêm chuyến bay thành công.", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
    }
}
