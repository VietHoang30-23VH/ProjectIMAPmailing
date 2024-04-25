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
            this.label1 = new System.Windows.Forms.Label();
            this.txbTo = new System.Windows.Forms.TextBox();
            this.txbSubject = new System.Windows.Forms.TextBox();
            this.txbMessage = new System.Windows.Forms.TextBox();
            this.btSend = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.locationfile = new System.Windows.Forms.Label();
            this.btnDangXuat = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnQuaylai = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Constantia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Đến :";
            // 
            // txbTo
            // 
            this.txbTo.Location = new System.Drawing.Point(138, 16);
            this.txbTo.Name = "txbTo";
            this.txbTo.Size = new System.Drawing.Size(786, 22);
            this.txbTo.TabIndex = 1;
            // 
            // txbSubject
            // 
            this.txbSubject.Location = new System.Drawing.Point(138, 63);
            this.txbSubject.Name = "txbSubject";
            this.txbSubject.Size = new System.Drawing.Size(786, 22);
            this.txbSubject.TabIndex = 3;
            // 
            // txbMessage
            // 
            this.txbMessage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbMessage.Location = new System.Drawing.Point(138, 113);
            this.txbMessage.Multiline = true;
            this.txbMessage.Name = "txbMessage";
            this.txbMessage.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txbMessage.Size = new System.Drawing.Size(786, 289);
            this.txbMessage.TabIndex = 4;
            // 
            // btSend
            // 
            this.btSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSend.Location = new System.Drawing.Point(668, 408);
            this.btSend.Name = "btSend";
            this.btSend.Size = new System.Drawing.Size(115, 49);
            this.btSend.TabIndex = 5;
            this.btSend.Text = "Gửi ";
            this.btSend.UseVisualStyleBackColor = true;
            this.btSend.Click += new System.EventHandler(this.btSend_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackgroundImage = global::SendMail_SMPT.Properties.Resources.attachment;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(138, 427);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(137, 26);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Text = "Đính kèm tệp";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // locationfile
            // 
            this.locationfile.AutoSize = true;
            this.locationfile.Location = new System.Drawing.Point(318, 433);
            this.locationfile.Name = "locationfile";
            this.locationfile.Size = new System.Drawing.Size(0, 16);
            this.locationfile.TabIndex = 7;
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangXuat.Location = new System.Drawing.Point(789, 408);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Size = new System.Drawing.Size(115, 49);
            this.btnDangXuat.TabIndex = 8;
            this.btnDangXuat.Text = "Đăng xuất ";
            this.btnDangXuat.UseVisualStyleBackColor = true;
            this.btnDangXuat.Click += new System.EventHandler(this.btnDangXuat_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Constantia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 28);
            this.label2.TabIndex = 9;
            this.label2.Text = "Tiêu đề :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Constantia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(-1, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 28);
            this.label3.TabIndex = 10;
            this.label3.Text = "Nội dung :";
            // 
            // btnQuaylai
            // 
            this.btnQuaylai.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuaylai.Location = new System.Drawing.Point(547, 408);
            this.btnQuaylai.Name = "btnQuaylai";
            this.btnQuaylai.Size = new System.Drawing.Size(115, 49);
            this.btnQuaylai.TabIndex = 11;
            this.btnQuaylai.Text = "Quay lại";
            this.btnQuaylai.UseVisualStyleBackColor = true;
            this.btnQuaylai.Click += new System.EventHandler(this.btnQuaylai_Click);
            // 
            // SendMail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 476);
            this.Controls.Add(this.btnQuaylai);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnDangXuat);
            this.Controls.Add(this.locationfile);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.btSend);
            this.Controls.Add(this.txbMessage);
            this.Controls.Add(this.txbSubject);
            this.Controls.Add(this.txbTo);
            this.Controls.Add(this.label1);
            this.Name = "SendMail";
            this.Text = "SendForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbTo;
        private System.Windows.Forms.TextBox txbSubject;
        private System.Windows.Forms.TextBox txbMessage;
        private System.Windows.Forms.Button btSend;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label locationfile;
        private System.Windows.Forms.Button btnDangXuat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnQuaylai;
    }
}