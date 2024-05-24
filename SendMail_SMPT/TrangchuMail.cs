using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MailKit;
using MailKit.Net.Imap;
using MailKit.Search;
using MimeKit;
using static SendMail_SMPT.DangNhap;

namespace SendMail_SMPT
{
    public partial class TrangchuMail : Form
    {
        private ImapClient mailClient;

        public TrangchuMail()
        {
            InitializeComponent();
            this.FormClosing += TrangchuMail_FormClosing; // Đảm bảo ngắt kết nối IMAP khi form đóng
            GetMail();
        }

        public class EmailInfo
        {
            public string Id { get; set; }
            public string From { get; set; }
            public DateTimeOffset TimeReceive { get; set; }
            public string Subject { get; set; }
            public string Body { get; set; }
            public string FileAttachment { get; set; }
        }

        private async void GetMail()
        {
            string textTK = MKTK.TaiKhoan;
            string textMK = MKTK.Matkhau;
            var listEmail = new List<EmailInfo>();

            mailClient = new ImapClient();
            await mailClient.ConnectAsync("imap.gmail.com", 993, true);
            await mailClient.AuthenticateAsync(textTK, textMK);

            var folder = await mailClient.GetFolderAsync("INBOX");
            await folder.OpenAsync(FolderAccess.ReadWrite);

            IList<UniqueId> emailIds = await folder.SearchAsync(SearchQuery.All);
            emailIds = emailIds.OrderByDescending(uid => folder.GetMessage(uid).Date).ToList();

            int emailCount = 0;
            foreach (UniqueId emailId in emailIds)
            {
                if (emailCount >= 20)
                {
                    break;
                }

                MimeMessage message = await folder.GetMessageAsync(emailId);
                var emailInfo = new EmailInfo
                {
                    Id = emailId.ToString(),
                    From = message.From.ToString(),
                    TimeReceive = message.Date,
                    Subject = message.Subject,
                    Body = !string.IsNullOrEmpty(message.HtmlBody) ? message.HtmlBody : message.TextBody
                };

                var fileAttachment = new List<string>();
                foreach (MimeEntity attachment in message.Attachments)
                {
                    var fileName = attachment.ContentDisposition?.FileName ?? attachment.ContentType.Name;
                    fileAttachment.Add(fileName);

                    using (var stream = new FileStream(fileName, FileMode.Create))
                    {
                        if (attachment is MessagePart rfc822)
                        {
                            await rfc822.Message.WriteToAsync(stream);
                        }
                        else if (attachment is MimePart part)
                        {
                            await part.Content.DecodeToAsync(stream);
                        }
                    }
                }
                emailInfo.FileAttachment = string.Join("; ", fileAttachment);
                listEmail.Add(emailInfo);
                emailCount++;
            }

            dataGridView1.DataSource = listEmail;
            dataGridView1.CellClick += DataGridView1_CellClick;
        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                var emailInfo = dataGridView1.Rows[e.RowIndex].DataBoundItem as EmailInfo;
                if (emailInfo != null)
                {
                    string emailHtml = GetEmailHtml(emailInfo);
                    webBrowser1.DocumentText = emailHtml;
                }
            }
        }

        private string GetEmailHtml(EmailInfo emailInfo)
        {
            return $@"
            <html>
            <head>
                <style>
                    body {{
                        font-family: Arial, sans-serif;
                        margin: 20px;
                    }}
                    .header {{
                        font-weight: bold;
                        margin-bottom: 10px;
                    }}
                    .body {{
                        margin-top: 20px;
                    }}
                </style>
            </head>
            <body>
                <div class='header'>From: {emailInfo.From}</div>
                <div class='header'>Subject: {emailInfo.Subject}</div>
                <div class='header'>Time Receive: {emailInfo.TimeReceive}</div>
                <hr/>
                <div class='body'>{emailInfo.Body}</div>
            </body>
            </html>";
        }

        private void TrangchuMail_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (mailClient != null && mailClient.IsConnected)
            {
                mailClient.Disconnect(true);
            }
        }

        private void btSendMail_Click(object sender, EventArgs e)
        {
            SendMail instanceSend = new SendMail();
            instanceSend.Show();
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            dataGridView1.Refresh();
            DialogResult result = MessageBox.Show("Bạn muốn đăng xuất chứ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            if (result == DialogResult.OK)
            {
                Program.closeAll();
            }
        }

        private void btnQuaylai2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Bạn có thể thêm logic cho sự kiện này nếu cần thiết
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
