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

namespace QLNHASACH
{
    public partial class frmnxb : Form
    {
        string cnStr;
        SqlConnection cn;
        DataSet ds;
        // DataTable chungloai;
        SqlCommand cmd = new SqlCommand();
        public frmnxb()
        {
            InitializeComponent();
        }

        private void frmnxb_Load(object sender, EventArgs e)
        {
            cnStr = ConfigurationManager.ConnectionStrings["cnStr"].ConnectionString;
            cn = new SqlConnection(cnStr);
            string sql = "SELECT * FROM NXB";

            dgvnxb.DataSource = hienthi(sql).Tables[0];
            dgvnxb.Columns[0].HeaderText = "Mã NXB";
            dgvnxb.Columns[0].Width = 75;
            dgvnxb.Columns[1].HeaderText = "Tên Nhà Xuất Bản";
            dgvnxb.Columns[1].Width = 200;
            dgvnxb.Columns[2].HeaderText = "Địa Chỉ";
            dgvnxb.Columns[3].HeaderText = "Giới Thiệu";



        }
        private DataSet hienthi(string sql)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter(sql, cn);
                ds = new DataSet();
                da.Fill(ds);
                return ds;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex + "");
                // throw;
                return null;
            }
        }

        private void dgvnxb_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int index = e.RowIndex;
                txtmanxb.Text = dgvnxb.Rows[index].Cells[0].Value.ToString();
                txttennxb.Text = dgvnxb.Rows[index].Cells[1].Value.ToString();
                txtdc.Text = dgvnxb.Rows[index].Cells[2].Value.ToString();
                txtmota.Text = dgvnxb.Rows[index].Cells[3].Value.ToString();
              
            }
            catch
            {
                //  MessageBox.Show(ex + "");
                //throw;
            }
        }

        private void btdel_Click(object sender, EventArgs e)
        {
            cn.Open();
            try
            {
                string sqldel = "delete from NXB where MANXB='" + txtmanxb.Text + "'";
                SqlCommand cmd = new SqlCommand(sqldel, cn);
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Xóa Nhà Xuất Bản Thành Công ! ");

                string sql = "SELECT * FROM NXB";
                dgvnxb.DataSource = hienthi(sql).Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex + "");
                // throw;
            }
            finally
            {
                cn.Close();
            }
        }

        private void bttsua_Click(object sender, EventArgs e)
        {
            cn.Open();
            try
            {
                string sqlupda = "update NXB set TENNXB= N'"+txttennxb.Text+"', DIACHI= N'"+ txtdc.Text +"', GIOITHIEU = N'"+ txtmota.Text +"' where MANXB = N'"+ txtmanxb.Text +"'";
                    
                SqlCommand cmd = new SqlCommand(sqlupda, cn);
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Sửa Nhà Xuất Bản Thành Công ! ");

                string sql = "SELECT * FROM NXB";
                dgvnxb.DataSource = hienthi(sql).Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex + "");
                //throw;
            }
            finally
            {
                cn.Close();
            }
        }

        private void btadd_Click(object sender, EventArgs e)
        {
            frmnxb_them newFrm = new frmnxb_them();
            newFrm.ShowDialog();

            string sql = "SELECT * FROM NXB";
            dgvnxb.DataSource = hienthi(sql).Tables[0];
        }
    }
}
