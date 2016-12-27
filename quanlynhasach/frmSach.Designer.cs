namespace QLNHASACH
{
    partial class frmSach
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtmasach = new System.Windows.Forms.TextBox();
            this.txttensach = new System.Windows.Forms.TextBox();
            this.txtgia = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txttacgia = new System.Windows.Forms.TextBox();
            this.txtsl = new System.Windows.Forms.TextBox();
            this.txtmota = new System.Windows.Forms.TextBox();
            this.cbbchungloai = new System.Windows.Forms.ComboBox();
            this.cbbloai = new System.Windows.Forms.ComboBox();
            this.cbbnxb = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.bttdel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(28, 229);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(737, 234);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã Sách:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên Sách:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Đơn Giá:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Chủng Loại:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Loại:";
            // 
            // txtmasach
            // 
            this.txtmasach.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtmasach.Location = new System.Drawing.Point(113, 12);
            this.txtmasach.Name = "txtmasach";
            this.txtmasach.ReadOnly = true;
            this.txtmasach.Size = new System.Drawing.Size(100, 20);
            this.txtmasach.TabIndex = 2;
            // 
            // txttensach
            // 
            this.txttensach.Location = new System.Drawing.Point(113, 49);
            this.txttensach.Name = "txttensach";
            this.txttensach.Size = new System.Drawing.Size(191, 20);
            this.txttensach.TabIndex = 2;
            // 
            // txtgia
            // 
            this.txtgia.Location = new System.Drawing.Point(113, 79);
            this.txtgia.Name = "txtgia";
            this.txtgia.Size = new System.Drawing.Size(100, 20);
            this.txtgia.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(425, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Tác Giả:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(425, 56);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Nhà Xuất Bản:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(425, 90);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Số Lượng:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(425, 121);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Mô Tả:";
            // 
            // txttacgia
            // 
            this.txttacgia.Location = new System.Drawing.Point(517, 24);
            this.txttacgia.Name = "txttacgia";
            this.txttacgia.Size = new System.Drawing.Size(168, 20);
            this.txttacgia.TabIndex = 2;
            // 
            // txtsl
            // 
            this.txtsl.Location = new System.Drawing.Point(517, 87);
            this.txtsl.Name = "txtsl";
            this.txtsl.Size = new System.Drawing.Size(100, 20);
            this.txtsl.TabIndex = 2;
            // 
            // txtmota
            // 
            this.txtmota.Location = new System.Drawing.Point(517, 121);
            this.txtmota.Multiline = true;
            this.txtmota.Name = "txtmota";
            this.txtmota.Size = new System.Drawing.Size(197, 52);
            this.txtmota.TabIndex = 3;
            // 
            // cbbchungloai
            // 
            this.cbbchungloai.FormattingEnabled = true;
            this.cbbchungloai.Location = new System.Drawing.Point(113, 112);
            this.cbbchungloai.Name = "cbbchungloai";
            this.cbbchungloai.Size = new System.Drawing.Size(152, 21);
            this.cbbchungloai.TabIndex = 4;
            // 
            // cbbloai
            // 
            this.cbbloai.FormattingEnabled = true;
            this.cbbloai.Location = new System.Drawing.Point(113, 142);
            this.cbbloai.Name = "cbbloai";
            this.cbbloai.Size = new System.Drawing.Size(152, 21);
            this.cbbloai.TabIndex = 4;
            // 
            // cbbnxb
            // 
            this.cbbnxb.FormattingEnabled = true;
            this.cbbnxb.Location = new System.Drawing.Point(517, 53);
            this.cbbnxb.Name = "cbbnxb";
            this.cbbnxb.Size = new System.Drawing.Size(121, 21);
            this.cbbnxb.TabIndex = 4;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(263, 19);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 13);
            this.label10.TabIndex = 5;
            this.label10.Text = "label10";
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.Image = global::QLNHASACH.Properties.Resources.system_software_update;
            this.button1.Location = new System.Drawing.Point(245, 169);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 54);
            this.button1.TabIndex = 6;
            this.button1.Text = "Sửa";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // bttdel
            // 
            this.bttdel.AutoSize = true;
            this.bttdel.Image = global::QLNHASACH.Properties.Resources.delete;
            this.bttdel.Location = new System.Drawing.Point(397, 169);
            this.bttdel.Name = "bttdel";
            this.bttdel.Size = new System.Drawing.Size(84, 54);
            this.bttdel.TabIndex = 7;
            this.bttdel.Text = "Xóa";
            this.bttdel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bttdel.UseVisualStyleBackColor = true;
            this.bttdel.Click += new System.EventHandler(this.bttdel_Click);
            // 
            // frmSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 475);
            this.Controls.Add(this.bttdel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cbbnxb);
            this.Controls.Add(this.cbbloai);
            this.Controls.Add(this.cbbchungloai);
            this.Controls.Add(this.txtmota);
            this.Controls.Add(this.txtgia);
            this.Controls.Add(this.txttensach);
            this.Controls.Add(this.txtsl);
            this.Controls.Add(this.txttacgia);
            this.Controls.Add(this.txtmasach);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmSach";
            this.Text = "Sách";
            this.Load += new System.EventHandler(this.frmSach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtmasach;
        private System.Windows.Forms.TextBox txttensach;
        private System.Windows.Forms.TextBox txtgia;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txttacgia;
        private System.Windows.Forms.TextBox txtsl;
        private System.Windows.Forms.TextBox txtmota;
        private System.Windows.Forms.ComboBox cbbchungloai;
        private System.Windows.Forms.ComboBox cbbloai;
        private System.Windows.Forms.ComboBox cbbnxb;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button bttdel;
    }
}