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
    public partial class frmTK_HD : Form
    {
        SqlConnection cn;
        SqlCommand cmd = new SqlCommand();
        string cnStr;
        DataTable ds = new DataTable();
       // DataSet ds;
        //DataTable dt;
        DataTable BANGTAM = new DataTable();
        public frmTK_HD()
        {
            InitializeComponent();
        }

        private void frmTK_HD_Load(object sender, EventArgs e)
        {
            getdata();
        }
        private void getdata()
        {
             cnStr = ConfigurationManager.ConnectionStrings["cnStr"].ConnectionString;
            cn = new SqlConnection(cnStr);
            //cn.Open();
            string sql = "SELECT MASACH,TENSACH,DONGIA,SL FROM SACH";
            SqlDataAdapter da = new SqlDataAdapter(sql, cn);         
            da.Fill(ds);

            dataGridView1.DataSource = ds;
            dataGridView1.Columns[0].HeaderText = "Mã Sách";
            dataGridView1.Columns[0].Width = 75;
            dataGridView1.Columns[1].HeaderText = "Tên Sách";
            dataGridView1.Columns[2].HeaderText = "Đơn Giá";
            dataGridView1.Columns[2].Width = 80;
            dataGridView1.Columns[3].HeaderText = "Số Lượng";

           
            BANGTAM.Columns.Add("MASACH", typeof(string));
            BANGTAM.Columns.Add("TENSACH", typeof(string));
            BANGTAM.Columns.Add("SL", typeof(string));
            BANGTAM.Columns.Add("DONGIA", typeof(string));
            BANGTAM.Columns.Add("THANHTIEN", typeof(string));
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string sqlsearch = "SELECT MASACH,TENSACH,DONGIA,SL FROM SACH WHERE TENSACH LIKE N'%"+ txttk.Text + "%'";
            SqlDataAdapter da = new SqlDataAdapter(sqlsearch, cn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int index = e.RowIndex;
                txtms.Text = dataGridView1.Rows[index].Cells[0].Value.ToString();
                txttensach.Text = dataGridView1.Rows[index].Cells[1].Value.ToString();
                txtsl.Text = dataGridView1.Rows[index].Cells[3].Value.ToString();
                txtdg.Text = dataGridView1.Rows[index].Cells[2].Value.ToString();
                //txtmasach.Text = dataGridView1.Rows[index].Cells[0].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex + "");
                //throw;
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtslmua.Text == "")
            {
                MessageBox.Show("ban chua nhap vao so luong can mua ! ");
            }
            else {
            int dongia = Convert.ToInt32(txtdg.Text);
            int soluongmua = Convert.ToInt32(txtslmua.Text);
            int soluongton= Convert.ToInt32(txtsl.Text);
            if (soluongmua > soluongton)
            {
                MessageBox.Show("k đủ hàng để mua, vui lòng thử lại", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            else { 
                int thanhtien = dongia * soluongmua;
                int slcon= soluongton - soluongmua;
                txtsl.Text = slcon.ToString();
                txttien.Text = thanhtien.ToString();
                ////bảng tạm ////
                DataRow RowTB_TAM = BANGTAM.NewRow();
                
                RowTB_TAM["MASACH"] = txtms.Text;
                RowTB_TAM["TENSACH"] = txttensach.Text;
                RowTB_TAM["SL"] = txtslmua.Text;
                RowTB_TAM["DONGIA"] = txtdg.Text;
                RowTB_TAM["THANHTIEN"] = txttien.Text;
                BANGTAM.Rows.Add(RowTB_TAM);
                dgvtam.DataSource = BANGTAM;
            }
            }
            ///GIONG CAI NAY PHAI K ?
            ///
            //string sql = "SELECT * FROM DONHANGCHITIET";
            //SqlDataAdapter da = new SqlDataAdapter(sql, cn);
            //DataSet ds = new DataSet();
            //da.Fill(ds);
            //dgvtam.DataSource = ds.Tables[0];
            ////bảng tạm ////
       
          
           // vi du ak 




            
           //// MessageBox.Show("Them sp thanh cong ");
          

        }
        private void bttok_Click(object sender, EventArgs e)
        {
            int sc = dgvtam.Rows.Count;
            int tongtien=0;
            for (int i = 0; i < sc - 1; i++) {
            tongtien += int.Parse(dgvtam.Rows[i].Cells["THANHTIEN"].Value.ToString());
            }
            txttong.Text = tongtien.ToString();
            bttsavedh.Enabled = true;
        }
        private void bttsavedh_Click(object sender, EventArgs e)
        {
            if (txttenkh.Text == "" || txtsodt.Text == "")
            {
                MessageBox.Show("Ban chua nhap vao ten KH va So dt !", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            else
            {
                cn.Open();
                SqlCommand cmd, cmd1, cmd2;
                try
                {
                    string sq = "INSERT INTO DONHANG([HOTEN],[SDT],[NGAYLAPHD],[TONGTIEN]) " +
                    "VALUES(N'" + txttenkh.Text + "',N'" + txtsodt.Text + "','" + dateTimePicker1.Text + "','" + txttong.Text + "') ";

                    cmd = new SqlCommand(sq, cn);
                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();

                    string sq1 = "SELECT SCOPE_IDENTITY();";
                    cmd = new SqlCommand(sq1, cn);
                    cmd.CommandType = CommandType.Text;
                    string insertedID = cmd.ExecuteScalar().ToString();


                    //them vao don hang chi tiet:
                    int sc = dgvtam.Rows.Count;
                    for (int i = 0; i < sc - 1; i++)
                    {

                        string MASACH = Convert.ToString(dgvtam.Rows[i].Cells["MASACH"].Value);
                        string TENSACH = Convert.ToString(dgvtam.Rows[i].Cells["TENSACH"].Value);
                        string SL = Convert.ToString(dgvtam.Rows[i].Cells["SL"].Value);
                        string DONGIA = Convert.ToString(dgvtam.Rows[i].Cells["DONGIA"].Value);
                        string THANHTIEN = Convert.ToString(dgvtam.Rows[i].Cells["THANHTIEN"].Value);

                        string sqldhct = "insert into DONHANGCHITIET(IDDH,MASACH,TENSACH,SL,DONGIA,THANHTIEN)" +
                        "VALUES('" + insertedID.ToString() + "',N'" + MASACH.ToString() + "',N'" + TENSACH.ToString() + "',N'" + SL.ToString() + "','" + DONGIA.ToString() + "','" + THANHTIEN.ToString() + "')";
                        cmd1 = new SqlCommand(sqldhct, cn);
                        cmd1.CommandType = CommandType.Text;
                        cmd1.ExecuteNonQuery();

                        DataRow dr;
                        dr = (DataRow)ds.Select("MASACH='" + MASACH + "'").GetValue(0);
                        int SLmoi = Int32.Parse(SL), a = Int32.Parse(dr["SL"].ToString()) - SLmoi;

                        string sqlupdate = "update SACH set SL='" + a.ToString() + "' WHERE MASACH='" + MASACH.ToString() + "'";
                        cmd2 = new SqlCommand(sqlupdate, cn);
                        cmd2.CommandType = CommandType.Text;
                        cmd2.ExecuteNonQuery();
                    }
                    MessageBox.Show("Thêm vào đơn hàng chi tiết thành công !");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex + "");
                    //throw;
                }
                try
                {
                    ds.Rows.Clear();
                    getdata();
                }
                catch { }
            }
        }
        private void bthuy_Click(object sender, EventArgs e)
        {
            try
            {
     
                BANGTAM.Rows.Clear();
                dgvtam.DataSource = BANGTAM;
                txttenkh.Text = "";
                txttensach.Text = "";
                txttong.Text = "";
                txtsodt.Text = "";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex + "");
                //throw;
            }

           

        }

     
    }
}
