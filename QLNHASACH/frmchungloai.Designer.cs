namespace QLNHASACH
{
    partial class frmchungloai
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
            this.dgvchungloai = new System.Windows.Forms.DataGridView();
            this.txtmacl = new System.Windows.Forms.TextBox();
            this.txttencl = new System.Windows.Forms.TextBox();
            this.btupdate = new System.Windows.Forms.Button();
            this.btdel = new System.Windows.Forms.Button();
            this.btadd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvchungloai)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Chủng Loại:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(79, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên Chủng Loại:";
            // 
            // dgvchungloai
            // 
            this.dgvchungloai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvchungloai.Location = new System.Drawing.Point(35, 118);
            this.dgvchungloai.Name = "dgvchungloai";
            this.dgvchungloai.Size = new System.Drawing.Size(374, 150);
            this.dgvchungloai.TabIndex = 2;
            this.dgvchungloai.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvchungloai_CellClick);
            // 
            // txtmacl
            // 
            this.txtmacl.Location = new System.Drawing.Point(178, 30);
            this.txtmacl.Name = "txtmacl";
            this.txtmacl.ReadOnly = true;
            this.txtmacl.Size = new System.Drawing.Size(125, 20);
            this.txtmacl.TabIndex = 1;
            // 
            // txttencl
            // 
            this.txttencl.Location = new System.Drawing.Point(178, 68);
            this.txttencl.Name = "txttencl";
            this.txttencl.Size = new System.Drawing.Size(125, 20);
            this.txttencl.TabIndex = 1;
            // 
            // btupdate
            // 
            this.btupdate.AutoSize = true;
            this.btupdate.Image = global::QLNHASACH.Properties.Resources.system_software_update;
            this.btupdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btupdate.Location = new System.Drawing.Point(305, 283);
            this.btupdate.Name = "btupdate";
            this.btupdate.Size = new System.Drawing.Size(104, 54);
            this.btupdate.TabIndex = 3;
            this.btupdate.Text = "Sửa";
            this.btupdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btupdate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btupdate.UseVisualStyleBackColor = true;
            this.btupdate.Click += new System.EventHandler(this.btupdate_Click);
            // 
            // btdel
            // 
            this.btdel.AutoSize = true;
            this.btdel.Image = global::QLNHASACH.Properties.Resources.delete;
            this.btdel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btdel.Location = new System.Drawing.Point(165, 283);
            this.btdel.Name = "btdel";
            this.btdel.Size = new System.Drawing.Size(104, 54);
            this.btdel.TabIndex = 3;
            this.btdel.Text = "Xóa";
            this.btdel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btdel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btdel.UseVisualStyleBackColor = true;
            this.btdel.Click += new System.EventHandler(this.btdel_Click);
            // 
            // btadd
            // 
            this.btadd.AutoSize = true;
            this.btadd.Image = global::QLNHASACH.Properties.Resources.add2;
            this.btadd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btadd.Location = new System.Drawing.Point(33, 282);
            this.btadd.Name = "btadd";
            this.btadd.Size = new System.Drawing.Size(104, 54);
            this.btadd.TabIndex = 3;
            this.btadd.Text = "Thêm";
            this.btadd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btadd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btadd.UseVisualStyleBackColor = true;
            this.btadd.Click += new System.EventHandler(this.btadd_Click);
            // 
            // frmchungloai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 361);
            this.Controls.Add(this.btupdate);
            this.Controls.Add(this.btdel);
            this.Controls.Add(this.btadd);
            this.Controls.Add(this.dgvchungloai);
            this.Controls.Add(this.txttencl);
            this.Controls.Add(this.txtmacl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmchungloai";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chủng Loại";
            this.Load += new System.EventHandler(this.frmchungloai_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvchungloai)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvchungloai;
        private System.Windows.Forms.TextBox txtmacl;
        private System.Windows.Forms.TextBox txttencl;
        private System.Windows.Forms.Button btadd;
        private System.Windows.Forms.Button btdel;
        private System.Windows.Forms.Button btupdate;
    }
}