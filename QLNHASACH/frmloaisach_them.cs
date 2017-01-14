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
    public partial class frmloaisach_them : Form
    {
        string cnStr;
        SqlConnection cn;
        SqlCommand cmd = new SqlCommand();
        DataTable chungloai;
        DataSet ds;
        public frmloaisach_them()
        {
            InitializeComponent();
        }
        private void frmloaisach_them_Load(object sender, EventArgs e)
        {
            cnStr = ConfigurationManager.ConnectionStrings["cnStr"].ConnectionString;
            cn = new SqlConnection(cnStr);
            string sql1 = "SELECT * FROM CHUNGLOAI";
            chungloai = getvalue(sql1).Tables[0];
            cbbchungloai.DataSource = chungloai;
            cbbchungloai.DisplayMember = "TENCHUNGLOAI";
            cbbchungloai.ValueMember = "MACHUNGLOAI";
        }
        private void bttadd_Click(object sender, EventArgs e)
        {
            if (txttenloai.Text == "")
            {
                MessageBox.Show("Tên Loại Sách không được để trống ! ", "Xác Nhận", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
            }
            else
            { 
                cn.Open();
            try
            {
                string sqladd = "insert into LOAISACH(TENLOAI,MACHUNGLOAI) VALUES (N'" + txttenloai.Text + "',N'"+ cbbchungloai.SelectedValue.ToString() +"')";
                SqlCommand cmd = new SqlCommand(sqladd, cn);
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Thêm Chủng Loại Thành Công ! ");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex + "");
                //throw;
            }
            } 
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
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
