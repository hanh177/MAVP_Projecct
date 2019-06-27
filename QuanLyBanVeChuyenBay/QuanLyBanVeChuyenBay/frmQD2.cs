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
    public partial class cmbMaCB : Form
    {
        Form suadoiqd;

        public cmbMaCB(Form frmSuaDoiQD)
        {
            InitializeComponent();
            this.suadoiqd = frmSuaDoiQD;
        }
        string strconn2 = frmMain.strconn2;
        string macb;
        int SoGheH1suadoi, SoGheH2suadoi;
        int SoGheTrongH1, SoGheTrongH2;
        int SoGheH1dadat, SoGheH2dadat;
        int sogheh1, sogheh2;
        int tongsoghe, tongghetrong;
        private void Connection()
        {
            ///////////////////////////////////////////////////////////////////////////////////
            SqlConnection conn = new SqlConnection(strconn2);
            try
            {
                conn.Open();
               

                string sql = "select * from CHUYENBAY";
                SqlCommand command = new SqlCommand(sql, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable table = new DataTable();
                adapter.Fill(table);
                cmbMaChuyenBay.DataSource = table;
                cmbMaChuyenBay.DisplayMember = "MaCB";
                cmbMaChuyenBay.ValueMember = "MaCB";
                cmbMaChuyenBay.SelectedIndex = 0;
                
            }
            catch (InvalidOperationException ex)
            {
                //xu ly khi ket noi co van de
                MessageBox.Show("Khong the mo ket noi hoac ket noi da mo truoc do");
            }
            catch (Exception ex)
            {
                //xu ly khi ket noi co van de
                MessageBox.Show("Ket noi xay ra lỗi hoac doc du lieu bi loi");
            }
            finally
            {
                //Dong ket noi sau khi thao tac ket thuc
                conn.Close();
            }
        }
        private void frmQD2_Load(object sender, EventArgs e)
        {
            Connection();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            macb = cmbMaChuyenBay.Text;
            SqlConnection conn = new SqlConnection(strconn2);
            try
            {
                conn.Open();


                string sql = "select * from CHUYENBAY where macb= '" + macb + "'";
                SqlCommand command = new SqlCommand(sql, conn);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    txtSoGheH1.Text = reader["SLGheHang1"].ToString();
                    txtSoGheh2.Text = reader["SLGheHang2"].ToString();
                    SoGheTrongH1 = Int32.Parse(reader["SLGheTrongH1"].ToString());
                    SoGheTrongH2 = Int32.Parse(reader["SLGheTrongH2"].ToString());
                }

                sogheh1 = Int32.Parse(txtSoGheH1.Text);
                sogheh2 = Int32.Parse(txtSoGheh2.Text);
            }
            catch (InvalidOperationException ex)
            {
                //xu ly khi ket noi co van de
                MessageBox.Show("Khong the mo ket noi hoac ket noi da mo truoc do");
            }
            catch (Exception ex)
            {
                //xu ly khi ket noi co van de
               // MessageBox.Show("Ket noi xảy ra loi hoac doc du lieu bi loi");
            }
            finally
            {
                //Dong ket noi sau khi thao tac ket thuc
                conn.Close();
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {

            bool sdh1 = false;
            bool sdh2 = false;
           
            SqlConnection conn = new SqlConnection(strconn2);
            try
            {
                conn.Open();

                if (txtSoGheH1.Text == "" || txtSoGheh2.Text == "")
                    MessageBox.Show("Vui lòng không để trống ô giá trị nào", "Sửa đổi không thành công", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {

                    SoGheH1suadoi = Int32.Parse(txtSoGheH1.Text);
                    SoGheH2suadoi = Int32.Parse(txtSoGheh2.Text);
                    SoGheTrongH1 = 28;
                    SoGheTrongH2 = 34;
                    SoGheH1dadat = sogheh1 - SoGheTrongH1;
                    SoGheH2dadat = sogheh2 - SoGheTrongH2;

                    if ( SoGheH1suadoi > SoGheH1dadat)
                    {
                        if(SoGheH1suadoi >= sogheh1)
                        {
                            SoGheTrongH1 += SoGheH1suadoi - sogheh1;                     
                        }
                        if (SoGheH1suadoi < sogheh1)
                        {
                            SoGheTrongH1 -=  sogheh1 - SoGheH1suadoi ;
                        }
                        sdh1 = true;
                    }
                    if ( SoGheH2suadoi > SoGheH2dadat)
                    {
                        if (SoGheH2suadoi >= sogheh2)
                        {
                            SoGheTrongH2 += SoGheH2suadoi - sogheh2;
                        }
                        if (SoGheH2suadoi < sogheh1)
                        {
                            SoGheTrongH2 -= sogheh2 - SoGheH2suadoi;
                        }
                        sdh2 = true;
                    }

                    if (sdh1 == true && sdh2 == true)
                    {
                        tongsoghe = SoGheH1suadoi + SoGheH2suadoi;
                        tongghetrong = SoGheTrongH1 + SoGheTrongH2;
                      
                       string query = "update CHUYENBAY set SLGhehang1 = " + SoGheH1suadoi + " , SLGheHang2 = " + SoGheH2suadoi + " where MaCB = '" + macb + "'";
                       SqlCommand  cmd = new SqlCommand(query, conn);
                        cmd.ExecuteNonQuery();
                        query = "update TinhTrang set SLGheTrongH1=@gheTrongH1, SLGheTrongH2=@GhetrongH2, TongSoGhe=@tongsoghe, TongSoGheTrong=@tongghetrong where macb=@macb";
                        cmd = new SqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@macb", macb);
                        cmd.Parameters.AddWithValue("@gheTrongH1", SoGheTrongH1);
                        cmd.Parameters.AddWithValue("@GhetrongH2", SoGheTrongH2);
                        cmd.Parameters.AddWithValue("@tongghetrong", tongghetrong);
                        cmd.Parameters.AddWithValue("@tongsoghe", tongsoghe);
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Sửa đổi thành công");
                    }

                    else MessageBox.Show("Vé đặt của chuyến bay không cho phép sứa đổi", "Sửa đổi không thành công", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("Các giá trị sửa đổi phải là số, vui lòng nhập lại", "Sửa đổi không thành công", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                //Dong ket noi sau khi thao tac ket thuc
                conn.Close();
            }
        }
    }
}

