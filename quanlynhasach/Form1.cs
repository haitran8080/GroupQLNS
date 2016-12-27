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
    public partial class Form1 : Form
    {
        string cnStr;
        SqlConnection cn;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cnStr = ConfigurationManager.ConnectionStrings["cnStr"].ConnectionString;
            cn = new SqlConnection(cnStr);
            string sql = "SELECT * FROM SACH";
            SqlDataAdapter da = new SqlDataAdapter(sql, cn);
            DataSet ds = new DataSet();
            da.Fill(ds);
          //  dataGridView1.DataSource = ds.Tables[0];
           
        }

        private void áđasaToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void asdasdToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //if (!Functions.isFocusForm(typeof(InputScores.frmNhapDiem_TCUEH), this))
            //{
                frmSach sach = new frmSach();
                sach.MdiParent = this;
                sach.Show();
           // }

        }

        private void chủngLoạiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmchungloai chungloai = new frmchungloai();
            chungloai.MdiParent = this;
            chungloai.Show();
        }

        private void loạiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmloaisach loaisach = new frmloaisach();
            loaisach.MdiParent = this;
            loaisach.Show();
        }

        private void nhàXToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmnxb nxb = new frmnxb();
            nxb.MdiParent = this;
            nxb.Show();
        }

        private void thêmSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmThemsach themsach = new frmThemsach();
            themsach.MdiParent = this;
            themsach.Show();
        }

        private void hóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTK_HD timkiem = new frmTK_HD();
            timkiem.MdiParent = this;
            timkiem.Show();
        }

        private void thốngKêToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmthongke thongke = new frmthongke();
            thongke.MdiParent = this;
            thongke.Show();
        }

        private void hóaĐơnToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frnreport report = new frnreport();
            report.MdiParent = this;
            report.Show();

        }

    }
}
