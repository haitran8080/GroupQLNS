using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using System.Data.Common;
namespace QLNHASACH
{
    public partial class frmSach : Form
    {
        string cnStr;
        SqlConnection cn;
        DataSet ds;
        DataTable chungloai,loai,nxb;
        SqlCommand cmd = new SqlCommand();
        public frmSach()
        {
            InitializeComponent();
        }

        private void frmSach_Load(object sender, EventArgs e)
        {
            cnStr = ConfigurationManager.ConnectionStrings["cnStr"].ConnectionString;
            cn = new SqlConnection(cnStr);
            string sql = "SELECT * FROM SACH";
            SqlDataAdapter da = new SqlDataAdapter(sql, cn);
            DataSet ds = new DataSet();
            
            cn.ConnectionString = cnStr;
            cn.Open();
           
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];

            dataGridView1.Columns[0].HeaderText = "Mã Sách";
            dataGridView1.Columns[0].Width = 70;
            dataGridView1.Columns[1].HeaderText = "Tên Sách";
            dataGridView1.Columns[1].Width = 140;
            dataGridView1.Columns[2].HeaderText = "Đơn Giá";
            dataGridView1.Columns[2].Width = 70;
            dataGridView1.Columns[3].HeaderText = "Mã Chủng Loại";
            dataGridView1.Columns[4].HeaderText = "Mã Loại";
            dataGridView1.Columns[5].HeaderText = "Tác Giả";
            dataGridView1.Columns[6].HeaderText = "Mã NXB";
            dataGridView1.Columns[8].HeaderText = "Số Lượng";
            dataGridView1.Columns[7].HeaderText = "Mô Tả";


            string sql1 = "SELECT * FROM CHUNGLOAI";
            chungloai = getvalue(sql1).Tables[0];
           cbbchungloai.DataSource = chungloai;
           cbbchungloai.DisplayMember = "TENCHUNGLOAI";
            cbbchungloai.ValueMember = "MACHUNGLOAI";

            string sql2 = "SELECT * FROM LOAISACH";
            loai = getvalue(sql2).Tables[0];
           cbbloai.DataSource = loai;
            cbbloai.DisplayMember = "TENLOAI";
            cbbloai.ValueMember = "MALOAI";

            string sql3 = "SELECT * FROM NXB";
            nxb = getvalue(sql3).Tables[0];
           cbbnxb.DataSource = nxb;
            cbbnxb.DisplayMember = "TENNXB";
            cbbnxb.ValueMember = "MANXB";
        }
        private DataSet getvalue(string sql)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter(sql, cn);
                ds = new DataSet();
                da.Fill(ds);

                return ds;
            }
            catch (SqlException ex)
            {
                MessageBox.Show("" + ex);
                return null;
            }
            finally
            {
                cn.Close();
            }
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int index = e.RowIndex;
                txtmasach.Text = dataGridView1.Rows[index].Cells[0].Value.ToString();
                label10.Text = dataGridView1.Rows[index].Cells[0].Value.ToString();
                txttensach.Text = dataGridView1.Rows[index].Cells[1].Value.ToString();
                txtgia.Text = dataGridView1.Rows[index].Cells[2].Value.ToString();

                string sql1 = "SELECT * FROM CHUNGLOAI WHERE MACHUNGLOAI='" + dataGridView1.Rows[index].Cells[3].Value.ToString() + "'";
                chungloai = getvalue(sql1).Tables[0];
                DataRow dr1 = chungloai.Rows[0];
                cbbchungloai.Text = dr1["TENCHUNGLOAI"].ToString();
                //cbbchungloai.Text = dataGridView1.Rows[index].Cells[3].Value.ToString();

                string sql2 = "SELECT * FROM  LOAISACH WHERE MALOAI='" + dataGridView1.Rows[index].Cells[4].Value.ToString() + "'";
                loai = getvalue(sql2).Tables[0];
                DataRow dr2 = loai.Rows[0];
                cbbloai.Text = dr2["TENLOAI"].ToString();
                // cbbloai.Text = dataGridView1.Rows[index].Cells[4].Value.ToString();


                txttacgia.Text = dataGridView1.Rows[index].Cells[5].Value.ToString();

                string sql3 = "SELECT * FROM NXB WHERE MANXB='" + dataGridView1.Rows[index].Cells[6].Value.ToString() + "'";
                nxb = getvalue(sql3).Tables[0];
                DataRow dr3 = nxb.Rows[0];
                cbbnxb.Text = dr3["TENNXB"].ToString();
                //cbbnxb.Text = dataGridView1.Rows[index].Cells[6].Value.ToString();

                txtsl.Text = dataGridView1.Rows[index].Cells[8].Value.ToString();
                txtmota.Text = dataGridView1.Rows[index].Cells[7].Value.ToString();
            }
            catch  
            {
            }          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cnStr = ConfigurationManager.ConnectionStrings["cnStr"].ConnectionString;
                cn = new SqlConnection(cnStr); 
            try
            {
                      
                cn.ConnectionString = cnStr;
                cn.Open();
                 string sql = "";
              
                 cmd.Connection = cn;
                 sql = "UPDATE SACH SET TENSACH =N'" + txttensach.Text + "', DONGIA ='" + txtgia.Text + "', MACHUNGLOAI =N'" + cbbchungloai.SelectedValue.ToString() +
                    "', MALOAI ='" + cbbloai.SelectedValue.ToString() + "', TACGIA =N'" + txttacgia.Text + "', MANXB ='"+ cbbnxb.SelectedValue.ToString() +"', MOTA =N'"+
                    txtmota.Text + "',SL ='" +txtsl.Text + "' WHERE MASACH ='" + txtmasach.Text +"'";
                
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Cập Nhật Thành Công");

                string sql1 = "SELECT * FROM SACH";
                SqlDataAdapter da = new SqlDataAdapter(sql1, cn);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
               // cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex+"");
               // throw;
            }
        }


         private void bttdel_Click(object sender, EventArgs e)
         {
             cnStr = ConfigurationManager.ConnectionStrings["cnStr"].ConnectionString;
             cn = new SqlConnection(cnStr);
             cn.ConnectionString = cnStr;
             cn.Open();
             try
             {
                cmd.Connection = cn;
                string sqldel= "DELETE FROM [dbo].[SACH] WHERE MASACH='" + txtmasach.Text + "'";
                cmd.CommandText = sqldel;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Xóa Nhật Thành Công");

                string sql1 = "SELECT * FROM SACH";
                SqlDataAdapter da = new SqlDataAdapter(sql1, cn);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];

             }
             catch (Exception ex)
             {
                 MessageBox.Show(ex + "");
                 //throw;
             }
         }
    }
}
