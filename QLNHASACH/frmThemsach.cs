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
    public partial class frmThemsach : Form
    {
        string cnStr;
        SqlConnection cn;
        DataSet ds;
        DataTable chungloai, loai, nxb;
        SqlCommand cmd = new SqlCommand();
        public frmThemsach()
        {
            InitializeComponent();
        }

        private void frmThemsach_Load(object sender, EventArgs e)
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

            string sql1 = "SELECT TENCHUNGLOAI,MACHUNGLOAI FROM CHUNGLOAI";
            chungloai = getvalue(sql1).Tables[0];
            cbbchungloai.DataSource = chungloai;
            cbbchungloai.DisplayMember = "TENCHUNGLOAI";
            cbbchungloai.ValueMember = "MACHUNGLOAI";


            string sql2 = "SELECT * FROM LOAISACH "; //WHERE MALOAI=N'"+ cbbchungloai.SelectedValue.ToString() +"'";
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
        private void connect()
        {
            try
            {
                if (cn != null && cn.State == ConnectionState.Closed)
                    cn.Open();
                //MessageBox.Show("ket noi thanh cong", "login", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("loi ket noi \n" + ex.Message);
            }
        }
        private void disconnect()
        {
            if (cn != null && cn.State == ConnectionState.Open)
                cn.Close();
            // MessageBox.Show("dong ket noi");
        }
        private void btinsert_Click(object sender, EventArgs e)
        {
            if (txttensach.Text == "" || txtgia.Text == "" || txtsl.Text == "")
            {
                MessageBox.Show("Xin vui lòng nhập đầy đủ Tên, Giá và Số Lượng Sách ! ","Xác Nhận",MessageBoxButtons.RetryCancel,MessageBoxIcon.Warning);
            }
            else
            {
            connect();
            try
                {
                //string chuoi = "INSERT INTO SACH Values (N'" + txttensach.Text + "',N'" + txtgia.Text + "',N'" + cbbchungloai.Text + "',N'" + cbbloai.Text +"',N'"+ txttacgia.Text +"',N'"+ cbbnxb.Text +"',N'"+ txtmota.Text +"',N'"+ txtsl.Text + "' )";

                    string sq = "INSERT INTO [SACH]([TENSACH],[DONGIA],[MACHUNGLOAI],[MALOAI],[TACGIA],[MANXB],[MOTA],[SL]) VALUES(N'" + txttensach.Text + "',N'" + txtgia.Text + "',N'" + cbbchungloai.SelectedValue.ToString() + "',N'" + cbbloai.SelectedValue.ToString() + "',N'" + txttacgia.Text + "',N'" + cbbnxb.SelectedValue.ToString() + "',N'" + txtmota.Text + "',N'" + txtsl.Text + "')";

                SqlCommand cmd = new SqlCommand(sq, cn);
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Them sp thanh cong ");


                string sql = "SELECT * FROM SACH";
                SqlDataAdapter da = new SqlDataAdapter(sql, cn);
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
    
}
