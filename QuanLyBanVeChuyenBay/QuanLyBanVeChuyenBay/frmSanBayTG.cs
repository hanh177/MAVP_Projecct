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
    public partial class frmSanBayTG : Form
    {
        Form danhsachcb;
        public frmSanBayTG(Form frmDanhSachCB)
        {
            InitializeComponent();
            this.danhsachcb = frmDanhSachCB;
        }

        string strconn2 = @"Data Source=DESKTOP-JLJ2TBG;Initial Catalog=QLBanVeChuyenBay;Integrated Security=True"; //cua Vuong

        //string strconn2 = @"Data Source=DESKTOP-TA2HS1O\SQLEXPRESS;Initial Catalog=QLBanVeChuyenBay;Integrated Security=True"; //cua ha anh
        string MaCB;
        private void Connection()
        {
            ///////////////////////////////////////////////////////////////////////////////////
            SqlConnection conn = new SqlConnection(strconn2);
            try
            {
                conn.Open();
                string sql = "select TG.MaTrungGian,SB.TenSanBay,TG.ThoiGianDung,Ghichu from TRUNGGIAN TG join SANBAY SB on TG.MaSanBay = SB.MaSanBay where TG.MaCB=@MaCB";
                SqlCommand command = new SqlCommand(sql, conn);
                command.Parameters.AddWithValue("@MaCB", MaCB);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dataDSSBTG.DataSource = table;
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
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmSanBayTG_Load(object sender, EventArgs e)
        {
            if (frmDanSachCB.macb != "")
                MaCB = frmDanSachCB.macb;
            if (frmTraCuu.macb != "")
                MaCB = frmTraCuu.macb;

            Connection();
            label1.Text = "DANH SÁCH SÂN BAY TRUNG GIAN CỦA CHUYẾN BAY CÓ MÃ " + MaCB; 
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Hide();
            danhsachcb.Show();
        }
    }
}
