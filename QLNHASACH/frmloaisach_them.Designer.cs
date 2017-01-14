namespace QLNHASACH
{
    partial class frmloaisach_them
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
            this.txttenloai = new System.Windows.Forms.TextBox();
            this.cbbchungloai = new System.Windows.Forms.ComboBox();
            this.bttadd = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên Loại";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Chủng Loại";
            // 
            // txttenloai
            // 
            this.txttenloai.Location = new System.Drawing.Point(85, 23);
            this.txttenloai.Name = "txttenloai";
            this.txttenloai.Size = new System.Drawing.Size(138, 20);
            this.txttenloai.TabIndex = 1;
            // 
            // cbbchungloai
            // 
            this.cbbchungloai.FormattingEnabled = true;
            this.cbbchungloai.Location = new System.Drawing.Point(85, 68);
            this.cbbchungloai.Name = "cbbchungloai";
            this.cbbchungloai.Size = new System.Drawing.Size(121, 21);
            this.cbbchungloai.TabIndex = 2;
            // 
            // bttadd
            // 
            this.bttadd.AutoSize = true;
            this.bttadd.Image = global::QLNHASACH.Properties.Resources.add2;
            this.bttadd.Location = new System.Drawing.Point(27, 136);
            this.bttadd.Name = "bttadd";
            this.bttadd.Size = new System.Drawing.Size(92, 54);
            this.bttadd.TabIndex = 3;
            this.bttadd.Text = "Thêm";
            this.bttadd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bttadd.UseVisualStyleBackColor = true;
            this.bttadd.Click += new System.EventHandler(this.bttadd_Click);
            // 
            // button2
            // 
            this.button2.AutoSize = true;
            this.button2.Image = global::QLNHASACH.Properties.Resources.exit;
            this.button2.Location = new System.Drawing.Point(148, 136);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(92, 54);
            this.button2.TabIndex = 4;
            this.button2.Text = "Đóng";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // frmloaisach_them
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 219);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.bttadd);
            this.Controls.Add(this.cbbchungloai);
            this.Controls.Add(this.txttenloai);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmloaisach_them";
            this.Text = "Thêm Loại Sách";
            this.Load += new System.EventHandler(this.frmloaisach_them_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txttenloai;
        private System.Windows.Forms.ComboBox cbbchungloai;
        private System.Windows.Forms.Button bttadd;
        private System.Windows.Forms.Button button2;
    }
}