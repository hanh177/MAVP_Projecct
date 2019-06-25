using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanVeChuyenBay
{
    public partial class frmMain : Form
    {
        Form login;
        public frmMain(Form frmLogin)
        {
            InitializeComponent();
            this.login = frmLogin;
        }


        //string strconn2 = @"Data Source=DESKTOP-TA2HS1O\SQLEXPRESS;Initial Catalog=QLBanVeChuyenBay;Integrated Security=True"; //cua ha anh

        string strconn2 = @"Data Source=DESKTOP-JLJ2TBG;Initial Catalog=QLBanVeChuyenBay;Integrated Security=True"; //cua Vuong
        SqlCommand cmd;
        string query;
        private void Connection() //xóa sổ các chuyến bay đã khởi hành
        {

            SqlConnection conn = new SqlConnection(strconn2);
            DateTime now = DateTime.Now;
            string Now = now.ToString(); // vd: 6/2/2019 10:00:00 AM   ----  mm//dd/yyyy
            string[] s = Now.Split(' ');  // s[0] = 6/2/2019
            string[] d = s[0].Split('/');
            int thang =int.Parse( d[0]);
            int ngay = int.Parse(d[1]);
            int nam = int.Parse(d[2]);
            try
            {
                conn.Open();
                //xoa DOANHTHUTHANGCB
                query = "delete from DOANHTHUTHANGCB where MaCB in ( select MaCB from CHUYENBAY where Year(ngayGio) < " + nam + " )";
                cmd = new SqlCommand(query, conn);

                cmd.ExecuteNonQuery();
                query = "delete from DOANHTHUTHANGCB where MaCB in ( select MaCB from CHUYENBAY where Year(ngayGio) = " + nam + " and Month(ngayGio) < " + thang + " )";
                cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();

                query = "delete from DOANHTHUTHANGCB  where MaCB in ( select MaCB from CHUYENBAY where Year(ngayGio) = " + nam + " and Month(ngayGio) = " + thang + " and day(NgayGio) < " + ngay + " )";
                cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();

                //xóa PhieuDatCho
                query = "delete from PHIEUDATCHO where MaCB in ( select MaCB from CHUYENBAY where Year(ngayGio) < " + nam + " )";
                cmd = new SqlCommand(query, conn);

                cmd.ExecuteNonQuery();
                query = "delete from PHIEUDATCHO where MaCB in ( select MaCB from CHUYENBAY where Year(ngayGio) = " + nam + " and Month(ngayGio) < " + thang + " )";
                cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();

                query = "delete from PHIEUDATCHO  where MaCB in ( select MaCB from CHUYENBAY where Year(ngayGio) = " + nam + " and Month(ngayGio) = " + thang + " and day(NgayGio) < " + ngay + " )";
                cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();

                //Xóa VE
                query = "delete from VE where MaCB in ( select MaCB from CHUYENBAY where Year(ngayGio) < " + nam + " )";
                cmd = new SqlCommand(query, conn);

                cmd.ExecuteNonQuery();
                query = "delete from VE where MaCB in ( select MaCB from CHUYENBAY where Year(ngayGio) = " + nam + " and Month(ngayGio) < " + thang + " )";
                cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();

                query = "delete from VE  where MaCB in ( select MaCB from CHUYENBAY where Year(ngayGio) = " + nam + " and Month(ngayGio) = " + thang + " and day(NgayGio) < " + ngay + " )";
                cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();

                //Xóa HanhKhach
                query = "delete from HanhKhach where MaCB in ( select MaCB from CHUYENBAY where Year(ngayGio) < " + nam + " )";
                cmd = new SqlCommand(query, conn);

                cmd.ExecuteNonQuery();
                query = "delete from HanhKhach where MaCB in ( select MaCB from CHUYENBAY where Year(ngayGio) = " + nam + " and Month(ngayGio) < " + thang + " )";
                cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();

                query = "delete from HanhKhach  where MaCB in ( select MaCB from CHUYENBAY where Year(ngayGio) = " + nam + " and Month(ngayGio) = " + thang + " and day(NgayGio) < " + ngay + " )";
                cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();

                //xóa TINHTRANG

                query = "delete from TINHTRANG where MaCB in ( select MaCB from CHUYENBAY where Year(ngayGio) < " + nam + " )";
                cmd = new SqlCommand(query, conn);

                cmd.ExecuteNonQuery();
                query = "delete from TINHTRANG where MaCB in ( select MaCB from CHUYENBAY where Year(ngayGio) = " + nam + " and Month(ngayGio) < " + thang + " )";
                cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();

                query = "delete from TINHTRANG  where MaCB in ( select MaCB from CHUYENBAY where Year(ngayGio) = " + nam + " and Month(ngayGio) = " + thang + " and day(NgayGio) < " + ngay + " )";
                cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();

                //xóa CHUYENBAY

                query = "delete from CHUYENBAY where MaCB in ( select MaCB from CHUYENBAY where Year(ngayGio) < " + nam + " )";
                cmd = new SqlCommand(query, conn);

                cmd.ExecuteNonQuery();
                query = "delete from CHUYENBAY where MaCB in ( select MaCB from CHUYENBAY where Year(ngayGio) = " + nam + " and Month(ngayGio) < " + thang + " )";
                cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();

                query = "delete from CHUYENBAY  where MaCB in ( select MaCB from CHUYENBAY where Year(ngayGio) = " + nam + " and Month(ngayGio) = " + thang + " and day(NgayGio) < " + ngay + " )";
                cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();

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

        private void label2_Click(object sender, EventArgs e)
        {

        }
       
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frontChữToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            Connection();
            
            label3.Text= frmLogin.username.ToString(); 
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            this.Close();
            login.Show();
           
        }

        private void btnNhanLich_Click(object sender, EventArgs e)
        {
            Form nhanlich = new frmNhanLich(this);
            this.Hide();
            nhanlich.ShowDialog();
            this.Show();
        }

        private void btnDanhSach_Click(object sender, EventArgs e)
        {
            Form danhsachcb = new frmDanSachCB(this);
            this.Hide();
            danhsachcb.ShowDialog();
            this.Show();
        }

         private void btnXemPhieuDatCho_Click(object sender, EventArgs e)
        {
            
        }

        private void btnTraCuu_Click(object sender, EventArgs e)
        {
            Form tracuu = new frmTraCuu(this);
            this.Hide();
            tracuu.ShowDialog();
            this.Show();
        }

        private void btnSuaDoiQD_Click(object sender, EventArgs e)
        {
            Form suadoiqd = new frmSuaDoiQD(this);
            this.Hide();
            suadoiqd.ShowDialog();
            this.Show();
        }

        private void btnDoanhThu_Click(object sender, EventArgs e)
        {
            Form baocaothang = new frmBaoCaoThang(this);
            this.Hide();
            baocaothang.ShowDialog();
            this.Show();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void btnDSKH_Click(object sender, EventArgs e)
        {
            
        }

        private void btnDSKH_Click_1(object sender, EventArgs e)
        {
            Form dskh = new frmDanhSachKH(this);
            this.Hide();
            dskh.Show();
        }
    }
}
