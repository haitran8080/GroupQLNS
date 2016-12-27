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
    public partial class frmloaisach : Form
    {
        string cnStr;
        SqlConnection cn;
        DataSet ds;
        DataTable chungloai;
        SqlCommand cmd = new SqlCommand();
        public frmloaisach()
        {
            InitializeComponent();
        }

       

        private void frmloaisach_Load(object sender, EventArgs e)
        {
            cnStr = ConfigurationManager.ConnectionStrings["cnStr"].ConnectionString;
            cn = new SqlConnection(cnStr);
            string sql = "SELECT * FROM LOAISACH";

            string sql1 = "SELECT * FROM CHUNGLOAI";
            chungloai = hienthi(sql1).Tables[0];
            cbbcl.DataSource = chungloai;
            cbbcl.DisplayMember = "TENCHUNGLOAI";
            cbbcl.ValueMember = "MACHUNGLOAI";

            dataGridView1.DataSource = hienthi(sql).Tables[0];
            dataGridView1.Columns[0].HeaderText = "Mã Loại";
            dataGridView1.Columns[0].Width = 80;
            dataGridView1.Columns[1].HeaderText = "Tên Loại";
            dataGridView1.Columns[1].Width = 200;
            dataGridView1.Columns[2].HeaderText = "Mã Chủng Loại";
            dataGridView1.Columns[2].Width = 100;
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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int index = e.RowIndex;
                txtml.Text = dataGridView1.Rows[index].Cells[0].Value.ToString();
                txttenl.Text = dataGridView1.Rows[index].Cells[1].Value.ToString();

                string sql2 = "SELECT * FROM CHUNGLOAI WHERE MACHUNGLOAI='" + dataGridView1.Rows[index].Cells[2].Value.ToString() + "'";
                chungloai = hienthi(sql2).Tables[0];
                DataRow dr1 = chungloai.Rows[0];
                cbbcl.Text = dr1["TENCHUNGLOAI"].ToString();
               // cbbcl.Text = dataGridView1.Rows[index].Cells[2].Value.ToString();
            }
            catch
            {
                //  MessageBox.Show(ex + "");
                //throw;
            }
        }

        private void bttDel_Click(object sender, EventArgs e)
        {
            cn.Open();
            try
            {
                string sqldel = "delete from LOAISACH where MALOAI='" + txtml.Text + "'";
                SqlCommand cmd = new SqlCommand(sqldel, cn);
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Xóa Chủng Loại Thành Công ! ");

                string sql = "SELECT * FROM LOAISACH";
                dataGridView1.DataSource = hienthi(sql).Tables[0];
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

        private void bttAdd_Click(object sender, EventArgs e)
        {
            frmloaisach_them newFrm = new frmloaisach_them();
            newFrm.ShowDialog();

            string sql = "SELECT * FROM LOAISACH";
            dataGridView1.DataSource = hienthi(sql).Tables[0];
        }

        private void bttupdate_Click(object sender, EventArgs e)
        {
            cn.Open();
            try
            {
                string sqlupda = "update LOAISACH set TENLOAI=N'" + txttenl.Text + "',MACHUNGLOAI=N'"+ cbbcl.SelectedValue.ToString() +"' where MALOAI='" + txtml.Text + "'";
                SqlCommand cmd = new SqlCommand(sqlupda, cn);
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Sửa Loại Sách Thành Công ! ");

                string sql = "SELECT * FROM LOAISACH";
                dataGridView1.DataSource = hienthi(sql).Tables[0];
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
