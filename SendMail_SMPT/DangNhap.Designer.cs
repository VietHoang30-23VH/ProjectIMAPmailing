namespace SendMail_SMPT
{
    partial class DangNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DangNhap));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txbTaikhoan = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnQuanLyThu = new System.Windows.Forms.Button();
            this.displayMk = new System.Windows.Forms.CheckBox();
            this.txbMatkhau = new System.Windows.Forms.TextBox();
            this.btnGuiThu = new System.Windows.Forms.Button();
            this.btnDN = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(270, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Đăng nhập";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(275, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tiếp tục với UIT-mail";
            // 
            // txbTaikhoan
            // 
            this.txbTaikhoan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbTaikhoan.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbTaikhoan.Location = new System.Drawing.Point(279, 147);
            this.txbTaikhoan.Multiline = true;
            this.txbTaikhoan.Name = "txbTaikhoan";
            this.txbTaikhoan.Size = new System.Drawing.Size(428, 35);
            this.txbTaikhoan.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(197, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 22);
            this.label3.TabIndex = 3;
            this.label3.Text = "Emaill:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(174, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 22);
            this.label4.TabIndex = 4;
            this.label4.Text = "Mật khẩu:";
            // 
            // btnQuanLyThu
            // 
            this.btnQuanLyThu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQuanLyThu.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuanLyThu.Location = new System.Drawing.Point(151, 353);
            this.btnQuanLyThu.Name = "btnQuanLyThu";
            this.btnQuanLyThu.Size = new System.Drawing.Size(134, 48);
            this.btnQuanLyThu.TabIndex = 8;
            this.btnQuanLyThu.Text = "Quản lí thư";
            this.btnQuanLyThu.UseVisualStyleBackColor = true;
            this.btnQuanLyThu.Click += new System.EventHandler(this.btnQuanLyThu_Click);
            // 
            // displayMk
            // 
            this.displayMk.AutoSize = true;
            this.displayMk.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayMk.Location = new System.Drawing.Point(279, 224);
            this.displayMk.Name = "displayMk";
            this.displayMk.Size = new System.Drawing.Size(169, 26);
            this.displayMk.TabIndex = 6;
            this.displayMk.Text = "Hiển thị mật khẩu";
            this.displayMk.UseVisualStyleBackColor = true;
            this.displayMk.CheckedChanged += new System.EventHandler(this.displayMk_CheckedChanged);
            // 
            // txbMatkhau
            // 
            this.txbMatkhau.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbMatkhau.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbMatkhau.Location = new System.Drawing.Point(279, 188);
            this.txbMatkhau.Name = "txbMatkhau";
            this.txbMatkhau.Size = new System.Drawing.Size(428, 28);
            this.txbMatkhau.TabIndex = 5;
            this.txbMatkhau.UseSystemPasswordChar = true;
            // 
            // btnGuiThu
            // 
            this.btnGuiThu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuiThu.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuiThu.Location = new System.Drawing.Point(410, 353);
            this.btnGuiThu.Name = "btnGuiThu";
            this.btnGuiThu.Size = new System.Drawing.Size(134, 48);
            this.btnGuiThu.TabIndex = 9;
            this.btnGuiThu.Text = "Gửi thư";
            this.btnGuiThu.UseVisualStyleBackColor = true;
            this.btnGuiThu.Click += new System.EventHandler(this.btnGuiThu_Click);
            // 
            // btnDN
            // 
            this.btnDN.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDN.Location = new System.Drawing.Point(279, 283);
            this.btnDN.Name = "btnDN";
            this.btnDN.Size = new System.Drawing.Size(134, 48);
            this.btnDN.TabIndex = 7;
            this.btnDN.Text = "Đăng nhập";
            this.btnDN.UseVisualStyleBackColor = true;
            this.btnDN.Click += new System.EventHandler(this.btnDN_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(46, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(137, 114);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // DangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 433);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnDN);
            this.Controls.Add(this.btnGuiThu);
            this.Controls.Add(this.txbMatkhau);
            this.Controls.Add(this.displayMk);
            this.Controls.Add(this.btnQuanLyThu);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txbTaikhoan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "DangNhap";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.DangNhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbTaikhoan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnQuanLyThu;
        private System.Windows.Forms.CheckBox displayMk;
        private System.Windows.Forms.TextBox txbMatkhau;
        private System.Windows.Forms.Button btnGuiThu;
        private System.Windows.Forms.Button btnDN;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}