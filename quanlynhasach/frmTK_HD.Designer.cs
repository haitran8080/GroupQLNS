namespace QLNHASACH
{
    partial class frmTK_HD
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txttk = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.txtms = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txttensach = new System.Windows.Forms.TextBox();
            this.txtsl = new System.Windows.Forms.TextBox();
            this.txtdg = new System.Windows.Forms.TextBox();
            this.txtslmua = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txttien = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bthuy = new System.Windows.Forms.Button();
            this.bttok = new System.Windows.Forms.Button();
            this.bttsavedh = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txttong = new System.Windows.Forms.TextBox();
            this.txtsodt = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txttenkh = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dgvtam = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvtam)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập vào tên sách cần tìm:";
            // 
            // txttk
            // 
            this.txttk.Location = new System.Drawing.Point(12, 38);
            this.txttk.Name = "txttk";
            this.txttk.Size = new System.Drawing.Size(208, 20);
            this.txttk.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 113);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(356, 304);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(16, 74);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Tìm Kiếm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtms
            // 
            this.txtms.Location = new System.Drawing.Point(98, 25);
            this.txtms.Name = "txtms";
            this.txtms.ReadOnly = true;
            this.txtms.Size = new System.Drawing.Size(100, 20);
            this.txtms.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã Sách:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tên Sách:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Số Lượng Tồn:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Đơn Giá";
            // 
            // txttensach
            // 
            this.txttensach.Location = new System.Drawing.Point(98, 58);
            this.txttensach.Name = "txttensach";
            this.txttensach.Size = new System.Drawing.Size(100, 20);
            this.txttensach.TabIndex = 4;
            // 
            // txtsl
            // 
            this.txtsl.Location = new System.Drawing.Point(98, 99);
            this.txtsl.Name = "txtsl";
            this.txtsl.Size = new System.Drawing.Size(100, 20);
            this.txtsl.TabIndex = 4;
            // 
            // txtdg
            // 
            this.txtdg.Location = new System.Drawing.Point(98, 131);
            this.txtdg.Name = "txtdg";
            this.txtdg.Size = new System.Drawing.Size(100, 20);
            this.txtdg.TabIndex = 4;
            // 
            // txtslmua
            // 
            this.txtslmua.Location = new System.Drawing.Point(338, 100);
            this.txtslmua.Name = "txtslmua";
            this.txtslmua.Size = new System.Drawing.Size(100, 20);
            this.txtslmua.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(228, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Số Lượng Mua:";
            // 
            // txttien
            // 
            this.txttien.Location = new System.Drawing.Point(338, 134);
            this.txttien.Name = "txttien";
            this.txttien.ReadOnly = true;
            this.txttien.Size = new System.Drawing.Size(100, 20);
            this.txttien.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(228, 138);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Thành Tiền:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txttien);
            this.groupBox1.Controls.Add(this.txtms);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtslmua);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txttensach);
            this.groupBox1.Controls.Add(this.txtsl);
            this.groupBox1.Controls.Add(this.txtdg);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(395, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(467, 180);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Hàng:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(276, 157);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(147, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Đưa vào giỏ  hàng";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.bthuy);
            this.groupBox2.Controls.Add(this.bttok);
            this.groupBox2.Controls.Add(this.bttsavedh);
            this.groupBox2.Controls.Add(this.dateTimePicker1);
            this.groupBox2.Controls.Add(this.txttong);
            this.groupBox2.Controls.Add(this.txtsodt);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.txttenkh);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(395, 209);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(467, 116);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông Tin Hóa Đơn:";
            // 
            // bthuy
            // 
            this.bthuy.Location = new System.Drawing.Point(363, 47);
            this.bthuy.Name = "bthuy";
            this.bthuy.Size = new System.Drawing.Size(75, 23);
            this.bthuy.TabIndex = 5;
            this.bthuy.Text = "Hủy Bỏ";
            this.bthuy.UseVisualStyleBackColor = true;
            this.bthuy.Click += new System.EventHandler(this.bthuy_Click);
            // 
            // bttok
            // 
            this.bttok.Location = new System.Drawing.Point(276, 47);
            this.bttok.Name = "bttok";
            this.bttok.Size = new System.Drawing.Size(75, 23);
            this.bttok.TabIndex = 4;
            this.bttok.Text = "Xác Nhận";
            this.bttok.UseVisualStyleBackColor = true;
            this.bttok.Click += new System.EventHandler(this.bttok_Click);
            // 
            // bttsavedh
            // 
            this.bttsavedh.Enabled = false;
            this.bttsavedh.Location = new System.Drawing.Point(276, 79);
            this.bttsavedh.Name = "bttsavedh";
            this.bttsavedh.Size = new System.Drawing.Size(119, 23);
            this.bttsavedh.TabIndex = 3;
            this.bttsavedh.Text = "Lưu Đơn Hàng";
            this.bttsavedh.UseVisualStyleBackColor = true;
            this.bttsavedh.Click += new System.EventHandler(this.bttsavedh_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(98, 82);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(128, 20);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // txttong
            // 
            this.txttong.Location = new System.Drawing.Point(311, 17);
            this.txttong.Name = "txttong";
            this.txttong.ReadOnly = true;
            this.txttong.Size = new System.Drawing.Size(100, 20);
            this.txttong.TabIndex = 1;
            // 
            // txtsodt
            // 
            this.txtsodt.Location = new System.Drawing.Point(112, 49);
            this.txtsodt.Name = "txtsodt";
            this.txtsodt.Size = new System.Drawing.Size(100, 20);
            this.txtsodt.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(239, 23);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "Tổng Tiền:";
            // 
            // txttenkh
            // 
            this.txttenkh.Location = new System.Drawing.Point(112, 20);
            this.txttenkh.Name = "txttenkh";
            this.txttenkh.Size = new System.Drawing.Size(100, 20);
            this.txttenkh.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(14, 89);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Ngày Lập:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(17, 53);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Số Dt:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Tên Khách Hàng:";
            // 
            // dgvtam
            // 
            this.dgvtam.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvtam.Location = new System.Drawing.Point(395, 336);
            this.dgvtam.Name = "dgvtam";
            this.dgvtam.Size = new System.Drawing.Size(467, 150);
            this.dgvtam.TabIndex = 8;
            // 
            // frmTK_HD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 498);
            this.Controls.Add(this.dgvtam);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txttk);
            this.Controls.Add(this.label1);
            this.Name = "frmTK_HD";
            this.Text = "Mua Hàng";
            this.Load += new System.EventHandler(this.frmTK_HD_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvtam)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txttk;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtms;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txttensach;
        private System.Windows.Forms.TextBox txtsl;
        private System.Windows.Forms.TextBox txtdg;
        private System.Windows.Forms.TextBox txtslmua;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txttien;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txttong;
        private System.Windows.Forms.TextBox txtsodt;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txttenkh;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dgvtam;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button bttsavedh;
        private System.Windows.Forms.Button bthuy;
        private System.Windows.Forms.Button bttok;
    }
}