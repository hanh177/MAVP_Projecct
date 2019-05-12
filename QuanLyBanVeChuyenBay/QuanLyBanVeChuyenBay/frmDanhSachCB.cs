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
        string strconn = @"Data Source=DESKTOP-TA2HS1O\SQLEXPRESS;Initial Catalog=QLBanVeChuyenBay;Integrated Security=True";
        private void Connection()
        {
            SqlConnection conn = new SqlConnection(strconn);
            try
            {
                conn.Open();
                string sql = "select CB.MaCB, SBdi.TenSanBay SanBayDi, SBden.TenSanBay SanBayDen,CB.ThoiGianBay, SB_TG.TenSanBay SanBayTG, TG.ThoiGianDung, CB.NgayGio,  TT.TongSoGhe,  TT.TongSoGheTrong, CB.GiaVe, TT.SLGheTrongH1, TT.SLGheTrongH2 from(CHUYENBAY CB join SANBAY SBdi on CB.SanBayDi = SBdi.MaSanBay join SANBAY SBden on CB.SanBayden = SBden.MaSanBay) join(CHUYENBAY left join TRUNGGIAN TG on CHUYENBAY.MaCB = TG.MaCB left join SANBAY SB_TG on TG.MaSanBay = SB_TG.MaSanBay) on CB.MaCB = CHUYENBAY.MaCB join TINHTRANG TT on CB.MaCB = TT.MaCB";
                SqlCommand command = new SqlCommand(sql, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable table = new DataTable();
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

        private void frmDanSachCB_Load(object sender, EventArgs e)
        {
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
            tracuucb.Show();
        }

        private void btnTraCuu_Click(object sender, EventArgs e)
        {
            this.tSbtnTraCuuCB_Click(sender, e);
        }

      

        private void tSbtnThemCB_Clicked(object sender, EventArgs e)
        {
            Form nhanlich = new frmNhanLich(this);
            this.Hide();
            nhanlich.Show();
        }

        private void tSbtnDatVeCB_Clicked(object sender, EventArgs e)
        {
            Form banve = new frmBanVe(this);
            this.Hide();
            banve.Show();
            
        }

        private void btnThemCB_Click(object sender, EventArgs e)
        {
            tSbtnThemCB_Clicked(sender, e);
        }

        private void btnDatVe_Click(object sender, EventArgs e)
        {
            tSbtnDatVeCB_Clicked(sender, e);
        }
    }
}
