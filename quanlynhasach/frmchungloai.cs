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
    public partial class frmchungloai : Form
    {
        string cnStr;
        SqlConnection cn;
        DataSet ds;
       // DataTable chungloai;
        SqlCommand cmd = new SqlCommand();
        public frmchungloai()
        {
            InitializeComponent();
        }

        private void frmchungloai_Load(object sender, EventArgs e)
        {
            cnStr = ConfigurationManager.ConnectionStrings["cnStr"].ConnectionString;
            cn = new SqlConnection(cnStr);
          string sql = "SELECT * FROM CHUNGLOAI";

          dgvchungloai.DataSource = hienthi(sql).Tables[0];
          dgvchungloai.Columns[0].HeaderText = "Mã Chủng Loại";
          dgvchungloai.Columns[0].Width = 110;
          dgvchungloai.Columns[1].HeaderText = "Tên Chủng Loại";
          dgvchungloai.Columns[1].Width = 200;
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
        private void dgvchungloai_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int index = e.RowIndex;
                txtmacl.Text = dgvchungloai.Rows[index].Cells[0].Value.ToString();
                txttencl.Text = dgvchungloai.Rows[index].Cells[1].Value.ToString();
            }
            catch 
            {
              //  MessageBox.Show(ex + "");
                //throw;
            }
        }

        private void btadd_Click(object sender, EventArgs e)
        {
            frmchungloai_them newFrm = new frmchungloai_them();
            newFrm.ShowDialog();

            string sql = "SELECT * FROM CHUNGLOAI";
            dgvchungloai.DataSource = hienthi(sql).Tables[0];
        }

        private void btdel_Click(object sender, EventArgs e)
        {
            cn.Open();
            try
            {
                string sqldel = "delete from CHUNGLOAI where MACHUNGLOAI='" + txtmacl.Text + "'";
                SqlCommand cmd = new SqlCommand(sqldel, cn);
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Xóa Chủng Loại Thành Công ! ");

                string sql = "SELECT * FROM CHUNGLOAI";
                dgvchungloai.DataSource = hienthi(sql).Tables[0];
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

        private void btupdate_Click(object sender, EventArgs e)
        {
            cn.Open();
            try
            {
                string sqlupda = "update CHUNGLOAI set TENCHUNGLOAI=N'"+ txttencl.Text + "' where MACHUNGLOAI='" + txtmacl.Text + "'";
                SqlCommand cmd = new SqlCommand(sqlupda, cn);
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Sửa Chủng Loại Thành Công ! ");

                string sql = "SELECT * FROM CHUNGLOAI";
                dgvchungloai.DataSource = hienthi(sql).Tables[0];
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
    }
}
