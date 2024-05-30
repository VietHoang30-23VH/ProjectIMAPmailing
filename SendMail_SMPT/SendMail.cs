using System;
using System.IO;
using System.Net.Mail;
using System.Windows.Forms;
using static SendMail_SMPT.DangNhap;

namespace SendMail_SMPT
{
    public partial class SendMail : Form
    {
        private string selectedFilePath = string.Empty;
        public SendMail()
        {
            InitializeComponent();
        }
        private void btSend_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txbTo.Text) && !string.IsNullOrEmpty(txbMessage.Text) && !string.IsNullOrEmpty(txbSubject.Text))
            {
                try
                {
                    MailMessage mail = new MailMessage();
                    if (txbTo.Text == MKTK.TaiKhoan)
                    {
                        MessageBox.Show("Bạn không thể gửi thư cho chính mình");
                        return;
                    }
                    else
                    {
                        mail.From = new MailAddress(MKTK.TaiKhoan);
                        mail.To.Add(txbTo.Text);
                        mail.Subject = txbSubject.Text;
                        mail.Body = txbMessage.Text;
                    }

                    if (checkBox1.Checked && !string.IsNullOrEmpty(selectedFilePath))
                    {
                        if (File.Exists(selectedFilePath))
                        {
                            Attachment attach = new Attachment(selectedFilePath);
                            mail.Attachments.Add(attach);
                        }
                        else
                        {
                            MessageBox.Show("Đường dẫn tệp không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                    SmtpClient smtpClient = new SmtpClient("smtp.gmail.com")
                    {
                        Port = 587,
                        EnableSsl = true,
                        Credentials = new System.Net.NetworkCredential(MKTK.TaiKhoan, MKTK.Matkhau),
                    };

                    smtpClient.Send(mail);
                    txbTo.Text = string.Empty;
                    txbMessage.Text = string.Empty;
                    txbSubject.Text = string.Empty;
                    selectedFilePath = string.Empty;
                    locationfile.Text = string.Empty;
                    checkBox1.Checked = false;
                    MessageBox.Show("Gửi mail thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Có lỗi xảy ra: " + ex.Message + Environment.NewLine + ex.StackTrace, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Bạn điền thiếu thông tin gửi!", "Thông báo");
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    selectedFilePath = openFileDialog.FileName;
                    locationfile.Text = "Location: " + selectedFilePath;
                }
                else
                {
                    checkBox1.Checked = false; 
                }
            }
            else
            {
                selectedFilePath = string.Empty;
                locationfile.Text = string.Empty;
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
    }
}
