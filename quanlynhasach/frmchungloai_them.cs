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
    public partial class frmchungloai_them : Form
    {
        string cnStr;
        SqlConnection cn;
        SqlCommand cmd = new SqlCommand();
        
        public frmchungloai_them()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txttencl.Text == "")
            {
                MessageBox.Show("Tên Chủng Loại không được để trống ! ", "Xác Nhận", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
            }
            else
            {
                cn.Open();

            try
            {
                string sqladd = "insert into CHUNGLOAI(TENCHUNGLOAI) VALUES (N'" + txttencl.Text + "')";
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

        private void Form2_Load(object sender, EventArgs e)
        {
            cnStr = ConfigurationManager.ConnectionStrings["cnStr"].ConnectionString;
            cn = new SqlConnection(cnStr);
        }
    }
}
