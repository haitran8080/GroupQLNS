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
    public partial class frmnxb_them : Form
    {
        string cnStr;
        SqlConnection cn;
        SqlCommand cmd = new SqlCommand();
        public frmnxb_them()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmnxb_them_Load(object sender, EventArgs e)
        {
            cnStr = ConfigurationManager.ConnectionStrings["cnStr"].ConnectionString;
            cn = new SqlConnection(cnStr);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cn.Open();

            try
            {
                string sqladd = "insert into NXB(TENNXB,DIACHI,GIOITHIEU) VALUES (N'" + txttennxb.Text + "',N'"+ txtdc.Text + "',N'"+ txtmota.Text  + "')";
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
}
