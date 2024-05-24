using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static SendMail_SMPT.DangNhap;

namespace SendMail_SMPT
{
    public partial class SendMail : Form
    {
        public SendMail()
        {
            InitializeComponent();
        }
        private void btSend_Click(object sender, EventArgs e)
        {
            string textTK = MKTK.TaiKhoan;
            string textMK = MKTK.Matkhau; 

            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient smtpClient = new SmtpClient("smtp.gmail.com");
                mail.From = new MailAddress(textTK);
                mail.To.Add(txbTo.Text);
                mail.Subject = txbSubject.Text;
                mail.Body = txbMessage.Text;
                if (checkBox1.Checked && !string.IsNullOrEmpty(locationfile.Text))
                {
                    System.Net.Mail.Attachment attach = new System.Net.Mail.Attachment(locationfile.Text);
                    mail.Attachments.Add(attach);
                }
                smtpClient.Port = 587;
                smtpClient.EnableSsl = true;
                smtpClient.Credentials = new System.Net.NetworkCredential(textTK, textMK);
                smtpClient.Send(mail);
                MessageBox.Show("Gửi mail thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked)
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.ShowDialog();
                locationfile.Text = openFileDialog.FileName;
            }
        }
        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn muốn đăng xuất chứ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            if (result == DialogResult.OK)
            {
                Program.closeAll();
            }
        }
        private void btnQuaylai_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
