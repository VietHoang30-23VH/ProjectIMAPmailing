using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MailKit;
using MailKit.Net.Imap;
using MimeKit;
using static SendMail_SMPT.DangNhap;

namespace SendMail_SMPT
{
    public partial class TrangchuMail : Form
    {
        private ImapClient mailClient;
        List<EmailInfo> emailDataList = new List<EmailInfo>();
        public TrangchuMail()
        {
            InitializeComponent();
            this.FormClosing += TrangchuMail_FormClosing;
            dataGridView1.Columns.Add("","");
            dataGridView1.Columns[""].Width = 0;
        }
        private void btnGetMail_Click(object sender, EventArgs e)
        {
            string textTK = MKTK.TaiKhoan;
            string textMK = MKTK.Matkhau;
            try
            {
                var client = new ImapClient();
                client.Connect("imap.gmail.com", 993, true);
                client.Authenticate(textTK, textMK);
                var inbox = client.Inbox;
                inbox.Open(FolderAccess.ReadOnly);
                lbTotal.Text = (inbox.Count - 1).ToString();
                int sequenceNumber = 1;
                List<EmailInfo> emailList = new List<EmailInfo>();

                for (int i = inbox.Count - 1; i > 0; i--)
                {
                    var mess = inbox.GetMessage(i);
                    var emailInfo = CreateEmailInfoFromMimeMessage(mess, sequenceNumber);
                    emailList.Add(emailInfo);

                    dataGridView1.Rows.Add(sequenceNumber, mess.Subject, mess.From.ToString(), mess.Date.ToString("dd-MM-yyyy HH:mm:ss"));
                    sequenceNumber++;
                }
                dataGridView1.DataSource = emailList; 
                dataGridView1.CellClick += DataGridView1_CellClick;
                btnGetMail.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}");
            }
        }
        private EmailInfo CreateEmailInfoFromMimeMessage(MimeMessage message, int sequenceNumber)
        {
            return new EmailInfo
            {
                SequenceNumber = sequenceNumber,
                From = message.From.ToString(),
                TimeReceive = message.Date.DateTime,
                Subject = message.Subject,
                Body = !string.IsNullOrEmpty(message.HtmlBody) ? message.HtmlBody : message.TextBody
            };
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
                lbPresent.Text = (e.RowIndex+1).ToString();
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
        private class EmailInfo
        {
            public int SequenceNumber { get; set; }
            public string From { get; set; }    
            public string Subject { get; set; }
            public DateTimeOffset TimeReceive { get; set; }
            public string Body { get; set; }

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
    }
}
