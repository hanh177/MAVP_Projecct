using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Globalization;

namespace QuanLyBanVeChuyenBay
{
    public partial class frmTraCuu : Form
    {
        Form main;
        public frmTraCuu(Form frmMain)
        {
            InitializeComponent();
            this.main = frmMain;
        }

        string strconn2 = @"Data Source=DESKTOP-JLJ2TBG;Initial Catalog=QLBanVeChuyenBay;Integrated Security=True"; //cua Vuong

        //string strconn2 = @"Data Source=DESKTOP-TA2HS1O\SQLEXPRESS;Initial Catalog=QLBanVeChuyenBay;Integrated Security=True"; //cua ha anh

        int index;
        static public string macb = "";
        int SLGHETRONG;
        static public int DONGIA = 0;
        bool click_data;

        private void Connection()
        {
            ///////////////////////////////////////////////////////////////////////////////////
            SqlConnection conn = new SqlConnection(strconn2);
            try
            {
                conn.Open();
                string sql = "select * from SANBAY";
                SqlCommand command = new SqlCommand(sql, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable table1 = new DataTable();
                DataTable table2 = new DataTable();
                adapter.Fill(table1);
                adapter.Fill(table2);

                string sql2 = "select * from CHUYENBAY";
                SqlCommand command2 = new SqlCommand(sql2, conn);
                SqlDataAdapter adapter2 = new SqlDataAdapter(command2);
                DataTable table3 = new DataTable();
                adapter2.Fill(table3);

                cmbSanBayDi.DataSource = table1;
                cmbSanBayDi.DisplayMember = "TenSanBay";
                cmbSanBayDi.ValueMember = "MaSanBay";
                cmbSanBayDi.SelectedIndex = -1;

                cmbSanBayDen.DataSource = table2;
                cmbSanBayDen.DisplayMember = "TenSanBay";
                cmbSanBayDen.ValueMember = "MaSanBay";
                cmbSanBayDen.SelectedIndex = -1;

                cmbMaCB.DataSource = table3;
                cmbMaCB.DisplayMember = "MaCB";
                cmbMaCB.ValueMember = "MaCB";
                cmbMaCB.SelectedIndex = -1;

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

        private void frmTraCuu_Load(object sender, EventArgs e)
        {
            click_data = false;
            macb = "";
            DONGIA = 0;
            Connection();
            //dataDanhSachCB.ClearSelection();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();       
          
        }

        private void btnDanhSach_Click(object sender, EventArgs e)
        {
            Form danhsachcb = new frmDanSachCB(this);
            this.Hide();
            danhsachcb.Show();

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
        DataTable table = new DataTable();
        string str1, str2, str3, str4, str5, str6, str7, str8, str_sql;
        private void btnTraCuu_Click(object sender, EventArgs e)
        {
            table.Clear();
            SqlConnection conn = new SqlConnection(strconn2);
            try
            {
                conn.Open();

                string str= "select distinct CB.MaCB, SBdi.TenSanBay SanBayDi, SBden.TenSanBay SanBayDen,CB.ThoiGianBay,A.SLSBTG, CB.NgayGio,  TT.TongSoGhe,  TT.TongSoGheTrong, CB.GiaVe, TT.SLGheTrongH1, TT.SLGheTrongH2 from(CHUYENBAY CB join SANBAY SBdi on CB.SanBayDi = SBdi.MaSanBay join SANBAY SBden on CB.SanBayden = SBden.MaSanBay) join(CHUYENBAY left join TRUNGGIAN TG on CHUYENBAY.MaCB = TG.MaCB left join SANBAY SB_TG on TG.MaSanBay = SB_TG.MaSanBay) on CB.MaCB = CHUYENBAY.MaCB join TINHTRANG TT on CB.MaCB = TT.MaCB" +
                         " left join  (select count(MaCB) SLSBTG ,MaCB from TRUNGGIAN group by MaCB) A on A.MaCB=TT.MaCB where ";
             
                //Chi tim kiem bang MaCB
                if (cmbMaCB.SelectedIndex != -1 && cmbSanBayDi.SelectedIndex == -1 && cmbSanBayDen.SelectedIndex == -1 && txtNgayBay.Text == "")

                {

                    str1 = " CB.MaCB= '" + cmbMaCB.SelectedValue.ToString() + "'";
                }

                //Chi tim kiem bang SanBayDi va SanBayDen
                else if (cmbSanBayDi.SelectedIndex != -1 && cmbSanBayDen.SelectedIndex != -1 && cmbMaCB.SelectedIndex == -1 && txtNgayBay.Text == "")
                {
                   str2 = "CB.SanBayDi= '" + cmbSanBayDi.SelectedValue.ToString() + "' and CB.SanBayDen= '" + cmbSanBayDen.SelectedValue.ToString() + "'";
                }

                //Chi tim kiem bang NgayBay
                else if (txtNgayBay.Text != "" && cmbMaCB.SelectedIndex == -1 && cmbSanBayDi.SelectedIndex == -1 && cmbSanBayDen.SelectedIndex == -1)
                {
                    try
                    {
                        string NGAYBAY = txtNgayBay.Text;
                        string[] arrListStr = NGAYBAY.Split('/');
                        str3 = "Day(CB.NgayGio)= '" + arrListStr[0] + "' and Month(CB.NgayGio)= '" + arrListStr[1] + "' and Year(CB.NgayGio)= '" + arrListStr[2] + "'";
                    }
                    catch
                    {
                        MessageBox.Show("Tim kiem ngu qua", "Loi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtNgayBay.Text = "";
                        return;
                    }
                }
                //chi tim kiem bang san bay di
                else if (cmbMaCB.SelectedIndex == -1 && cmbSanBayDi.SelectedIndex != -1 && cmbSanBayDen.SelectedIndex == -1 && txtNgayBay.Text == "")
                {
                    str4 = "CB.SanBayDi= '" + cmbSanBayDi.SelectedValue.ToString() + "'";
                }

                //chi tim kiem bang san bay den
                else if (cmbMaCB.SelectedIndex == -1 && cmbSanBayDi.SelectedIndex == -1 && cmbSanBayDen.SelectedIndex != -1 && txtNgayBay.Text == "")
                {
                    str5 = "CB.SanBayDen= '" + cmbSanBayDen.SelectedValue.ToString() + "'";
                }

                //Tim kiem bang MaCB va SanBayDen
                else if (cmbMaCB.SelectedIndex != -1 && cmbSanBayDi.SelectedIndex == -1 && cmbSanBayDen.SelectedIndex != -1 && txtNgayBay.Text == "")

                {
                    str6 = " CB.MaCB= '" + cmbMaCB.SelectedValue.ToString() + "' and CB.SanBayDen= '" + cmbSanBayDi.SelectedValue.ToString() + "'";
                }

                //Tim kiem bang MaCB va NgayBay
                else if (cmbMaCB.SelectedIndex != -1 && cmbSanBayDi.SelectedIndex == -1 && cmbSanBayDen.SelectedIndex == -1 && txtNgayBay.Text != "")
                {
                    string NGAYBAY = txtNgayBay.Text;
                    string[] arrListStr = NGAYBAY.Split('/');
                    str7 = " CB.MaCB= '" + cmbMaCB.SelectedValue.ToString() + "' and Day(CB.NgayGio)= '" + arrListStr[0] + "' and Month(CB.NgayGio)= '" + arrListStr[1] + "' and Year(CB.NgayGio)= '" + arrListStr[2] + "'";
                }

                //Tim kiem bang NgayBay va SanBayDen
                else if (cmbMaCB.SelectedIndex == -1 && cmbSanBayDi.SelectedIndex == -1 && cmbSanBayDen.SelectedIndex != -1 && txtNgayBay.Text != "")
                {
                    string NGAYBAY = txtNgayBay.Text;
                    string[] arrListStr = NGAYBAY.Split('/');
                    str8 = "Day(CB.NgayGio)= '" + arrListStr[0] + "' and Month(CB.NgayGio)= '" + arrListStr[1] + "' and Year(CB.NgayGio)= '" + arrListStr[2] + "' and CB.SanBayDen= '" + cmbSanBayDen.SelectedValue.ToString() + "'";
                }


                else
                {
                    MessageBox.Show("Cú pháp tra cứu sai, vui lòng thực hiện lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cmbMaCB.SelectedIndex = -1;
                    txtNgayBay.Text = "";
                    cmbSanBayDi.SelectedIndex = -1;
                    cmbSanBayDen.SelectedIndex = -1;
                    return;
                }
                str_sql = str + str1 + str2 + str3 + str4 + str5 + str6 + str7 + str8;
                SqlCommand command = new SqlCommand(str_sql, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(table);
                if (table.Rows.Count == 0)
                {
                    MessageBox.Show("Không tìm thấy thông tin bạn đang tìm kiếm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cmbMaCB.SelectedIndex = -1;
                    txtNgayBay.Text = "";
                    cmbSanBayDi.SelectedIndex = -1;
                    cmbSanBayDen.SelectedIndex = -1;

                }
                else
                    dataDanhSachCB.DataSource = table;
                str1 = str2 = str3 = str4 = str5 = str6 = str7 = str8 = null;
                cmbMaCB.SelectedIndex = -1;
                txtNgayBay.Text = "";
                cmbSanBayDi.SelectedIndex = -1;
                cmbSanBayDen.SelectedIndex = -1;
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

        private void dataDanhSachCB_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
       
        private void dataDanhSachCB_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataDanhSachCB.CurrentRow != null)
                {
                    index = dataDanhSachCB.CurrentRow.Index;
                    macb = dataDanhSachCB.Rows[index].Cells[0].Value.ToString();
                    string dongia = dataDanhSachCB.Rows[index].Cells[9].Value.ToString();
                    if (dongia != "")
                        DONGIA = Int32.Parse(dongia);
                    string slghetrong = dataDanhSachCB.Rows[index].Cells[8].Value.ToString();
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
 
            if(click_data==false)
                if (dataDanhSachCB.CurrentRow != null)
                {
                    index = 0;
                    macb = dataDanhSachCB.Rows[index].Cells[0].Value.ToString();
                    string dongia = dataDanhSachCB.Rows[index].Cells[9].Value.ToString();
                    if (dongia != "")
                        DONGIA = Int32.Parse(dongia);
                    string slghetrong = dataDanhSachCB.Rows[index].Cells[8].Value.ToString();
                    if (slghetrong != "")
                        SLGHETRONG = Int32.Parse(slghetrong);
                    else
                    {
                        if (dongia == "") SLGHETRONG = -1;

                    }
                    click_data = true;
                }
            if (dataDanhSachCB.CurrentRow==null || SLGHETRONG ==-1)
            {
                MessageBox.Show("Chưa chọn chuyến bay để đặt vé, vui lòng chọn 1 chuyến bay.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (SLGHETRONG > 0)
            {
                this.Hide();
                Form banve = new frmBanVe(this);
                banve.ShowDialog();
                this.Connection();
                this.Show();
                table.Clear();
                click_data = false;
            }
            else if( SLGHETRONG == 0  )
            {
                MessageBox.Show("Không thể đặt thêm vé vì chuyến bay đã hết ghế trống.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
           
        }
        
        private void dataDanhSachCB_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dataDanhSachCB.CurrentRow!=null)
            {
                index = dataDanhSachCB.CurrentRow.Index;
                string slsbtg = dataDanhSachCB.Rows[index].Cells[4].EditedFormattedValue.ToString();
                if (slsbtg != "")
                {
                    Form sbtg = new frmSanBayTG(this);
                    this.Hide();
                    sbtg.ShowDialog();
                    table.Clear();
                }
                else
                    return;
            }
        }
    }
}
