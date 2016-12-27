namespace QLNHASACH
{
    partial class frmloaisach
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
            this.txtml = new System.Windows.Forms.TextBox();
            this.txttenl = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bttAdd = new System.Windows.Forms.Button();
            this.bttDel = new System.Windows.Forms.Button();
            this.bttupdate = new System.Windows.Forms.Button();
            this.cbbcl = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Loại:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên Loại Sách:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(271, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Chủng Loại:";
            // 
            // txtml
            // 
            this.txtml.Location = new System.Drawing.Point(133, 37);
            this.txtml.Name = "txtml";
            this.txtml.ReadOnly = true;
            this.txtml.Size = new System.Drawing.Size(100, 20);
            this.txtml.TabIndex = 1;
            // 
            // txttenl
            // 
            this.txttenl.Location = new System.Drawing.Point(133, 109);
            this.txttenl.Name = "txttenl";
            this.txttenl.Size = new System.Drawing.Size(177, 20);
            this.txttenl.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(40, 152);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(429, 150);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // bttAdd
            // 
            this.bttAdd.AutoSize = true;
            this.bttAdd.Image = global::QLNHASACH.Properties.Resources.add2;
            this.bttAdd.Location = new System.Drawing.Point(39, 321);
            this.bttAdd.Name = "bttAdd";
            this.bttAdd.Size = new System.Drawing.Size(92, 54);
            this.bttAdd.TabIndex = 3;
            this.bttAdd.Text = "Thêm";
            this.bttAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bttAdd.UseVisualStyleBackColor = true;
            this.bttAdd.Click += new System.EventHandler(this.bttAdd_Click);
            // 
            // bttDel
            // 
            this.bttDel.AutoSize = true;
            this.bttDel.Image = global::QLNHASACH.Properties.Resources.delete;
            this.bttDel.Location = new System.Drawing.Point(209, 321);
            this.bttDel.Name = "bttDel";
            this.bttDel.Size = new System.Drawing.Size(92, 54);
            this.bttDel.TabIndex = 3;
            this.bttDel.Text = "Xóa";
            this.bttDel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bttDel.UseVisualStyleBackColor = true;
            this.bttDel.Click += new System.EventHandler(this.bttDel_Click);
            // 
            // bttupdate
            // 
            this.bttupdate.AutoSize = true;
            this.bttupdate.Image = global::QLNHASACH.Properties.Resources.system_software_update;
            this.bttupdate.Location = new System.Drawing.Point(377, 321);
            this.bttupdate.Name = "bttupdate";
            this.bttupdate.Size = new System.Drawing.Size(92, 54);
            this.bttupdate.TabIndex = 3;
            this.bttupdate.Text = "Sửa";
            this.bttupdate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bttupdate.UseVisualStyleBackColor = true;
            this.bttupdate.Click += new System.EventHandler(this.bttupdate_Click);
            // 
            // cbbcl
            // 
            this.cbbcl.FormattingEnabled = true;
            this.cbbcl.Location = new System.Drawing.Point(348, 36);
            this.cbbcl.Name = "cbbcl";
            this.cbbcl.Size = new System.Drawing.Size(142, 21);
            this.cbbcl.TabIndex = 4;
            // 
            // frmloaisach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 391);
            this.Controls.Add(this.cbbcl);
            this.Controls.Add(this.bttupdate);
            this.Controls.Add(this.bttDel);
            this.Controls.Add(this.bttAdd);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txttenl);
            this.Controls.Add(this.txtml);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmloaisach";
            this.Text = "Loại Sách";
            this.Load += new System.EventHandler(this.frmloaisach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtml;
        private System.Windows.Forms.TextBox txttenl;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button bttAdd;
        private System.Windows.Forms.Button bttDel;
        private System.Windows.Forms.Button bttupdate;
        private System.Windows.Forms.ComboBox cbbcl;
    }
}