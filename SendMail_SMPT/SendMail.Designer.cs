namespace SendMail_SMPT
{
    partial class SendMail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SendMail));
            this.txbTo = new System.Windows.Forms.TextBox();
            this.txbSubject = new System.Windows.Forms.TextBox();
            this.txbMessage = new System.Windows.Forms.TextBox();
            this.btSend = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.locationfile = new System.Windows.Forms.Label();
            this.btnDangXuat = new System.Windows.Forms.Button();
            this.btnQuaylai = new System.Windows.Forms.Button();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2GroupBox2 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.guna2PictureBox2 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2GroupBox3 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.guna2PictureBox3 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2GroupBox4 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.guna2GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.guna2GroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).BeginInit();
            this.guna2GroupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox3)).BeginInit();
            this.guna2GroupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // txbTo
            // 
            this.txbTo.Location = new System.Drawing.Point(3, 43);
            this.txbTo.Name = "txbTo";
            this.txbTo.Size = new System.Drawing.Size(841, 30);
            this.txbTo.TabIndex = 0;
            // 
            // txbSubject
            // 
            this.txbSubject.Location = new System.Drawing.Point(3, 43);
            this.txbSubject.Name = "txbSubject";
            this.txbSubject.Size = new System.Drawing.Size(844, 30);
            this.txbSubject.TabIndex = 0;
            // 
            // txbMessage
            // 
            this.txbMessage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbMessage.Location = new System.Drawing.Point(3, 43);
            this.txbMessage.Multiline = true;
            this.txbMessage.Name = "txbMessage";
            this.txbMessage.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txbMessage.Size = new System.Drawing.Size(838, 345);
            this.txbMessage.TabIndex = 0;
            // 
            // btSend
            // 
            this.btSend.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btSend.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btSend.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSend.ForeColor = System.Drawing.Color.White;
            this.btSend.Location = new System.Drawing.Point(32, 652);
            this.btSend.Name = "btSend";
            this.btSend.Size = new System.Drawing.Size(115, 49);
            this.btSend.TabIndex = 0;
            this.btSend.Text = "Gửi ";
            this.btSend.UseVisualStyleBackColor = false;
            this.btSend.Click += new System.EventHandler(this.btSend_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.Color.Transparent;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(3, 394);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(137, 26);
            this.checkBox1.TabIndex = 2;
            this.checkBox1.Text = "Đính kèm tệp";
            this.checkBox1.UseVisualStyleBackColor = false;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // locationfile
            // 
            this.locationfile.AutoSize = true;
            this.locationfile.BackColor = System.Drawing.Color.Transparent;
            this.locationfile.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.locationfile.Location = new System.Drawing.Point(293, 395);
            this.locationfile.Name = "locationfile";
            this.locationfile.Size = new System.Drawing.Size(0, 23);
            this.locationfile.TabIndex = 1;
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDangXuat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDangXuat.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangXuat.ForeColor = System.Drawing.Color.White;
            this.btnDangXuat.Location = new System.Drawing.Point(767, 652);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Size = new System.Drawing.Size(115, 49);
            this.btnDangXuat.TabIndex = 4;
            this.btnDangXuat.Text = "Đăng xuất ";
            this.btnDangXuat.UseVisualStyleBackColor = false;
            this.btnDangXuat.Click += new System.EventHandler(this.btnDangXuat_Click);
            // 
            // btnQuaylai
            // 
            this.btnQuaylai.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnQuaylai.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQuaylai.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuaylai.ForeColor = System.Drawing.Color.White;
            this.btnQuaylai.Location = new System.Drawing.Point(646, 652);
            this.btnQuaylai.Name = "btnQuaylai";
            this.btnQuaylai.Size = new System.Drawing.Size(115, 49);
            this.btnQuaylai.TabIndex = 2;
            this.btnQuaylai.Text = "Quay lại";
            this.btnQuaylai.UseVisualStyleBackColor = false;
            this.btnQuaylai.Click += new System.EventHandler(this.btnQuaylai_Click);
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.Controls.Add(this.guna2PictureBox1);
            this.guna2GroupBox1.Controls.Add(this.txbTo);
            this.guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2GroupBox1.Location = new System.Drawing.Point(32, 56);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.Size = new System.Drawing.Size(847, 77);
            this.guna2GroupBox1.TabIndex = 1;
            this.guna2GroupBox1.Text = "Người nhận:";
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(793, 0);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(51, 37);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 2;
            this.guna2PictureBox1.TabStop = false;
            // 
            // guna2GroupBox2
            // 
            this.guna2GroupBox2.Controls.Add(this.guna2PictureBox2);
            this.guna2GroupBox2.Controls.Add(this.txbSubject);
            this.guna2GroupBox2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GroupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2GroupBox2.Location = new System.Drawing.Point(32, 132);
            this.guna2GroupBox2.Name = "guna2GroupBox2";
            this.guna2GroupBox2.Size = new System.Drawing.Size(847, 77);
            this.guna2GroupBox2.TabIndex = 5;
            this.guna2GroupBox2.Text = "Tiêu đề:";
            // 
            // guna2PictureBox2
            // 
            this.guna2PictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox2.Image")));
            this.guna2PictureBox2.ImageRotate = 0F;
            this.guna2PictureBox2.Location = new System.Drawing.Point(793, 0);
            this.guna2PictureBox2.Name = "guna2PictureBox2";
            this.guna2PictureBox2.Size = new System.Drawing.Size(51, 37);
            this.guna2PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox2.TabIndex = 3;
            this.guna2PictureBox2.TabStop = false;
            // 
            // guna2GroupBox3
            // 
            this.guna2GroupBox3.Controls.Add(this.guna2PictureBox3);
            this.guna2GroupBox3.Controls.Add(this.txbMessage);
            this.guna2GroupBox3.Controls.Add(this.checkBox1);
            this.guna2GroupBox3.Controls.Add(this.locationfile);
            this.guna2GroupBox3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GroupBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2GroupBox3.Location = new System.Drawing.Point(35, 215);
            this.guna2GroupBox3.Name = "guna2GroupBox3";
            this.guna2GroupBox3.Size = new System.Drawing.Size(847, 431);
            this.guna2GroupBox3.TabIndex = 3;
            this.guna2GroupBox3.Text = "Nội dung:";
            // 
            // guna2PictureBox3
            // 
            this.guna2PictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox3.Image")));
            this.guna2PictureBox3.ImageRotate = 0F;
            this.guna2PictureBox3.Location = new System.Drawing.Point(793, 0);
            this.guna2PictureBox3.Name = "guna2PictureBox3";
            this.guna2PictureBox3.Size = new System.Drawing.Size(51, 37);
            this.guna2PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox3.TabIndex = 4;
            this.guna2PictureBox3.TabStop = false;
            // 
            // guna2GroupBox4
            // 
            this.guna2GroupBox4.Controls.Add(this.guna2GroupBox3);
            this.guna2GroupBox4.Controls.Add(this.btSend);
            this.guna2GroupBox4.Controls.Add(this.guna2GroupBox1);
            this.guna2GroupBox4.Controls.Add(this.guna2GroupBox2);
            this.guna2GroupBox4.Controls.Add(this.btnDangXuat);
            this.guna2GroupBox4.Controls.Add(this.btnQuaylai);
            this.guna2GroupBox4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2GroupBox4.CustomBorderColor = System.Drawing.Color.Black;
            this.guna2GroupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2GroupBox4.FillColor = System.Drawing.Color.Transparent;
            this.guna2GroupBox4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GroupBox4.ForeColor = System.Drawing.Color.White;
            this.guna2GroupBox4.Location = new System.Drawing.Point(0, 0);
            this.guna2GroupBox4.Name = "guna2GroupBox4";
            this.guna2GroupBox4.Size = new System.Drawing.Size(918, 724);
            this.guna2GroupBox4.TabIndex = 0;
            this.guna2GroupBox4.Text = "Thư mới";
            // 
            // SendMail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 724);
            this.Controls.Add(this.guna2GroupBox4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SendMail";
            this.Text = "SendForm";
            this.guna2GroupBox1.ResumeLayout(false);
            this.guna2GroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.guna2GroupBox2.ResumeLayout(false);
            this.guna2GroupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).EndInit();
            this.guna2GroupBox3.ResumeLayout(false);
            this.guna2GroupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox3)).EndInit();
            this.guna2GroupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txbTo;
        private System.Windows.Forms.TextBox txbSubject;
        private System.Windows.Forms.TextBox txbMessage;
        private System.Windows.Forms.Button btSend;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label locationfile;
        private System.Windows.Forms.Button btnDangXuat;
        private System.Windows.Forms.Button btnQuaylai;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox2;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox3;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox4;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox2;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox3;
    }
}