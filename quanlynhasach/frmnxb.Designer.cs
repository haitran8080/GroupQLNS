namespace QLNHASACH
{
    partial class frmnxb
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtmanxb = new System.Windows.Forms.TextBox();
            this.txttennxb = new System.Windows.Forms.TextBox();
            this.txtdc = new System.Windows.Forms.TextBox();
            this.dgvnxb = new System.Windows.Forms.DataGridView();
            this.btdel = new System.Windows.Forms.Button();
            this.bttsua = new System.Windows.Forms.Button();
            this.btadd = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtmota = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvnxb)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã NXB:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên NXB:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Địa Chỉ:";
            // 
            // txtmanxb
            // 
            this.txtmanxb.Location = new System.Drawing.Point(123, 17);
            this.txtmanxb.Name = "txtmanxb";
            this.txtmanxb.ReadOnly = true;
            this.txtmanxb.Size = new System.Drawing.Size(100, 20);
            this.txtmanxb.TabIndex = 1;
            // 
            // txttennxb
            // 
            this.txttennxb.Location = new System.Drawing.Point(123, 61);
            this.txttennxb.Name = "txttennxb";
            this.txttennxb.Size = new System.Drawing.Size(100, 20);
            this.txttennxb.TabIndex = 1;
            // 
            // txtdc
            // 
            this.txtdc.Location = new System.Drawing.Point(123, 109);
            this.txtdc.Name = "txtdc";
            this.txtdc.Size = new System.Drawing.Size(100, 20);
            this.txtdc.TabIndex = 1;
            // 
            // dgvnxb
            // 
            this.dgvnxb.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvnxb.Location = new System.Drawing.Point(41, 145);
            this.dgvnxb.Name = "dgvnxb";
            this.dgvnxb.Size = new System.Drawing.Size(512, 161);
            this.dgvnxb.TabIndex = 3;
            this.dgvnxb.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvnxb_CellClick);
            // 
            // btdel
            // 
            this.btdel.AutoSize = true;
            this.btdel.Image = global::QLNHASACH.Properties.Resources.delete;
            this.btdel.Location = new System.Drawing.Point(247, 327);
            this.btdel.Name = "btdel";
            this.btdel.Size = new System.Drawing.Size(101, 54);
            this.btdel.TabIndex = 2;
            this.btdel.Text = "Xóa";
            this.btdel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btdel.UseVisualStyleBackColor = true;
            this.btdel.Click += new System.EventHandler(this.btdel_Click);
            // 
            // bttsua
            // 
            this.bttsua.AutoSize = true;
            this.bttsua.Image = global::QLNHASACH.Properties.Resources.system_software_update;
            this.bttsua.Location = new System.Drawing.Point(408, 327);
            this.bttsua.Name = "bttsua";
            this.bttsua.Size = new System.Drawing.Size(101, 54);
            this.bttsua.TabIndex = 2;
            this.bttsua.Text = "Sửa";
            this.bttsua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bttsua.UseVisualStyleBackColor = true;
            this.bttsua.Click += new System.EventHandler(this.bttsua_Click);
            // 
            // btadd
            // 
            this.btadd.AutoSize = true;
            this.btadd.Image = global::QLNHASACH.Properties.Resources.add2;
            this.btadd.Location = new System.Drawing.Point(85, 327);
            this.btadd.Name = "btadd";
            this.btadd.Size = new System.Drawing.Size(101, 54);
            this.btadd.TabIndex = 2;
            this.btadd.Text = "Thêm";
            this.btadd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btadd.UseVisualStyleBackColor = true;
            this.btadd.Click += new System.EventHandler(this.btadd_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(270, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Giới Thiệu:";
            // 
            // txtmota
            // 
            this.txtmota.Location = new System.Drawing.Point(330, 17);
            this.txtmota.Multiline = true;
            this.txtmota.Name = "txtmota";
            this.txtmota.Size = new System.Drawing.Size(252, 98);
            this.txtmota.TabIndex = 1;
            // 
            // frmnxb
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 393);
            this.Controls.Add(this.dgvnxb);
            this.Controls.Add(this.btdel);
            this.Controls.Add(this.bttsua);
            this.Controls.Add(this.btadd);
            this.Controls.Add(this.txtmota);
            this.Controls.Add(this.txtdc);
            this.Controls.Add(this.txttennxb);
            this.Controls.Add(this.txtmanxb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmnxb";
            this.Text = "Nhà Xuất Bản";
            this.Load += new System.EventHandler(this.frmnxb_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvnxb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtmanxb;
        private System.Windows.Forms.TextBox txttennxb;
        private System.Windows.Forms.TextBox txtdc;
        private System.Windows.Forms.Button btadd;
        private System.Windows.Forms.Button bttsua;
        private System.Windows.Forms.Button btdel;
        private System.Windows.Forms.DataGridView dgvnxb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtmota;
    }
}