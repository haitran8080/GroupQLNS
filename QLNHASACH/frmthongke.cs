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
    public partial class frmthongke : Form
    {
        string cnStr;
        SqlConnection cn;
        DataTable sach;
        SqlCommand cmd = new SqlCommand();
        public frmthongke()
        {
            InitializeComponent();
        }

        private void frmthongke_Load(object sender, EventArgs e)
        {
            cnStr = ConfigurationManager.ConnectionStrings["cnStr"].ConnectionString;
            cn = new SqlConnection(cnStr);
            string sql = "SELECT TENSACH,DONGIA,TACGIA,MOTA,SL FROM SACH";
            SqlDataAdapter da = new SqlDataAdapter(sql, cn);
            DataTable ds = new DataTable();
            da.Fill(ds);
            ds.Columns.Add("TinhTrang", typeof(string));
            foreach(DataRow dr in ds.Rows)
            {
                if(10<Convert.ToInt32(dr["SL"].ToString()))
                {
                    dr["TinhTrang"]="Còn hàng";
                }
                else   if(0<Convert.ToInt32(dr["SL"].ToString()) &&Convert.ToInt32(dr["SL"].ToString()) <=10)
                         dr["TinhTrang"] = "Sắp Hết Hàng";
                         else
                             dr["TinhTrang"] = "Hết Hàng";
             
            }
            dataGridView1.DataSource = ds;
            //dataGridView1.Columns[1].HeaderText = "Tên Sách";
            //dataGridView1.Columns[1].Width = 140;
            //dataGridView1.Columns[2].HeaderText = "Đơn Giá";
            //dataGridView1.Columns[2].Width = 70;

            //dataGridView1.Columns[5].HeaderText = "Tác Giả";
            //dataGridView1.Columns[6].HeaderText = "Mã NXB";
            //dataGridView1.Columns[8].HeaderText = "Số Lượng";
            //dataGridView1.Columns[7].HeaderText = "Mô Tả";


        }
    }
}
