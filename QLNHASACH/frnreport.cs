using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.Reporting.WinForms;
using System.Configuration;
//using System.Data.SqlClient;
//using System.Configuration;


namespace QLNHASACH
{
    public partial class frnreport : Form
    {
        string cnStr;
        SqlConnection cn;
        DataSet ds;
        DataTable dh;
        public frnreport()
        {
            InitializeComponent();
        }

        private void frnreport_Load(object sender, EventArgs e)
        {
            cnStr = ConfigurationManager.ConnectionStrings["cnStr"].ConnectionString;
            cn = new SqlConnection(cnStr);
            string sql2 = "SELECT * FROM DONHANG";
            dh = getvalue(sql2).Tables[0];
            comboBox1.DataSource = dh;
            comboBox1.DisplayMember = "IDDH";
            comboBox1.ValueMember = "IDDH";
            // TODO: This line of code loads data into the 'QLBANSACHDataSet.DONHANGCHITIET' table. You can move, or remove it, as needed.
            //this.DONHANGCHITIETTableAdapter.Fill(this.QLBANSACHDataSet.DONHANGCHITIET,);

            //this.reportViewer1.RefreshReport();
            //try
            //{
            //    cnStr = ConfigurationManager.ConnectionStrings["cnStr"].ConnectionString;
            //    cn = new SqlConnection(cnStr);
            //    string sql = "Select * from CHITIETDONHANG";
            //    DataTable dtKhachHang = new DataTable();
            //    SqlDataAdapter da = new SqlDataAdapter(sql, cn);
            //    da.Fill(dtKhachHang);

            //    ReportDataSource rptSource = new ReportDataSource("DataSetDHCT", dtKhachHang);
            //    reportViewer1.LocalReport.DataSources.Clear();
            //    reportViewer1.LocalReport.DataSources.Add(rptSource);
            //    reportViewer1.LocalReport.ReportPath = @"../../Report2.rdlc";

            //    this.reportViewer1.RefreshReport();
            //}
            //catch (Exception)
            //{

            //    throw;

            //}
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
             this.DONHANGCHITIETTableAdapter.Fill(this.QLBANSACHDataSet.DONHANGCHITIET,Convert.ToInt32(comboBox1.Text));

            this.reportViewer1.RefreshReport();

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
    }
}
