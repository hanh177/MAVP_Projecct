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
    public partial class frmQD1 : Form
    {
        Form suadoiqd;
        public frmQD1(Form frmSuaDoiQD)
        {
            InitializeComponent();
            this.suadoiqd = frmSuaDoiQD;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        string strconn2 = frmMain.strconn2;
        string TGBayToiThieu, SoSBToiDa, SoSBTGToiDa, TGDungToiThieu, TGDungToiDa;

        public void Connection()
        {

            SqlConnection conn = new SqlConnection(strconn2);
            try
            {
                conn.Open();
                string sql = "select * from THAMSO";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                  
                    txtSBmax.Text = reader["SoSBToiDa"].ToString();
                    txtSNTGMax.Text = reader["SoSBTGToiDa"].ToString();
                    txtThGianMin.Text = reader["TGBayToiThieu"].ToString();
                    txtThGianTGmax.Text = reader["TGDungToiDa"].ToString();
                    txtThGianTGmin.Text = reader["TGDungToiThieu"].ToString();
                    
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
        private void frmQD1_Load(object sender, EventArgs e)
        {
            Connection();
            TGDungToiThieu = txtThGianTGmin.Text;
            TGDungToiDa = txtThGianTGmax.Text;
            TGBayToiThieu = txtThGianMin.Text;
            SoSBTGToiDa = txtSNTGMax.Text;
            SoSBToiDa = txtSBmax.Text;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
  
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(strconn2);
            try
            {
                conn.Open();
                TGDungToiThieu = txtThGianTGmin.Text;
                TGDungToiDa = txtThGianTGmax.Text;
                TGBayToiThieu = txtThGianMin.Text;
                SoSBTGToiDa = txtSNTGMax.Text;
                SoSBToiDa = txtSBmax.Text;
                if(TGBayToiThieu==""||TGDungToiDa==""||TGDungToiThieu==""||SoSBTGToiDa==""||SoSBToiDa=="")
                    MessageBox.Show("Vui lòng không để trống ô giá trị nào", "Sửa đổi không thành công", MessageBoxButtons.OK, MessageBoxIcon.Error);
               else {
                    string sql = "update ThamSo set TGBayToiThieu =" + TGBayToiThieu + ",SoSBToiDa=" + SoSBToiDa + ",SoSBTGToiDa=" + SoSBTGToiDa + ", TGDungToiDa= " + TGDungToiDa + ",TGDungToiThieu=" + TGDungToiThieu + " where MaThamSo='TS01'";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Sửa đồi thành công");
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
                MessageBox.Show("Các giá trị sửa đổi phải là số, vui lòng nhập lại", "Sửa đổi không thành công", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            finally
            {
                //Dong ket noi sau khi thao tac ket thuc
                conn.Close();
            }
            frmQD1_Load(sender, e);
        }
    }
}
