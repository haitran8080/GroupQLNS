namespace QLNHASACH
{
    partial class frmchungloai_them
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
            this.txttencl = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.The = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txttencl
            // 
            this.txttencl.Location = new System.Drawing.Point(120, 21);
            this.txttencl.Name = "txttencl";
            this.txttencl.Size = new System.Drawing.Size(143, 20);
            this.txttencl.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên Chủng Loại:";
            // 
            // button2
            // 
            this.button2.AutoSize = true;
            this.button2.Image = global::QLNHASACH.Properties.Resources.exit;
            this.button2.Location = new System.Drawing.Point(148, 52);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(92, 54);
            this.button2.TabIndex = 7;
            this.button2.Text = "Đóng";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // The
            // 
            this.The.AutoSize = true;
            this.The.Image = global::QLNHASACH.Properties.Resources.add2;
            this.The.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.The.Location = new System.Drawing.Point(24, 52);
            this.The.Name = "The";
            this.The.Size = new System.Drawing.Size(92, 54);
            this.The.TabIndex = 6;
            this.The.Text = "Thêm";
            this.The.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.The.UseVisualStyleBackColor = true;
            this.The.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmchungloai_them
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 112);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.The);
            this.Controls.Add(this.txttencl);
            this.Controls.Add(this.label2);
            this.Name = "frmchungloai_them";
            this.Text = "Thêm Chủng Loại";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txttencl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button The;
        private System.Windows.Forms.Button button2;
    }
}