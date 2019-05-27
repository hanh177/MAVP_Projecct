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
        static public string macb = "";
        int SLGHETRONG;
        static public int DONGIA = 0;
        bool click_data;

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

                /*//Xu ly san bay trung gian
                string sql2 = "select TG.MaCB,SB.TenSanBay from TRUNGGIAN TG join SANBAY SB on TG.MaSanBay=SB.MaSanBay";
                SqlCommand command2 = new SqlCommand(sql2,conn);
                SqlDataAdapter adapter2 = new SqlDataAdapter(command2);
                adapter2.Fill(table2);
                foreach(DataRow row in table2.Rows)//Chay tung dong trong table2
                {
                    foreach(var item in row.ItemArray)//Chay tung cot trong ddong hien tai
                    {
                        for(int i=0;i<dataDanhSachCB.Rows.Count;i++)//xet cac dong cua dataDSCB
                        {
                            if (String.Compare(dataDanhSachCB.Rows[i].Cells[0].EditedFormattedValue.ToString(),item.ToString(),true)==0)
                            {
                               dataDanhSachCB.
                                break;
                            }
                           
                        }
                    }
                }

                */
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
            if (dataDanhSachCB.CurrentRow == null || SLGHETRONG == -1)
            {
                MessageBox.Show("Chưa chọn chuyến bay để đặt vé, vui lòng chọn 1 chuyến bay.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (SLGHETRONG > 0)
            {
               
                Form banve = new frmBanVe(this);
                this.Hide();
                DialogResult re =  banve.ShowDialog();
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
