using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Diagnostics.Eventing.Reader;
using MailKit.Net.Imap;
using static SendMail_SMPT.TrangchuMail;
using static System.Net.Mime.MediaTypeNames;

namespace SendMail_SMPT
{
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }
        public static class MKTK
        {
            public static string TaiKhoan { get; set; }
            public static string Matkhau { get; set; }
        }
        private void btnQuanLyThu_Click(object sender, EventArgs e)
        {
            try
            {
                MKTK.TaiKhoan = txbTaikhoan.Text;
                MKTK.Matkhau = txbMatkhau.Text;
                SmtpClient smtpClient = new SmtpClient("smtp.gmail.com");
                smtpClient.Port = 587;
                smtpClient.UseDefaultCredentials = false;
                smtpClient.Credentials = new System.Net.NetworkCredential(MKTK.TaiKhoan,MKTK.Matkhau);
                smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtpClient.EnableSsl = true;
                TrangchuMail instancemail = new TrangchuMail();
                instancemail.Show();
            }
            catch 
            {
                MessageBox.Show("Sai tài khoản hoặc mật khẩu. Vui lòng kiểm tra lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void displayMk_CheckedChanged(object sender, EventArgs e)
        {
            if (displayMk.Checked)
            {
                txbMatkhau.UseSystemPasswordChar = PasswordPropertyTextAttribute.No.Password;
            }
            else
            {
                txbMatkhau.UseSystemPasswordChar = PasswordPropertyTextAttribute.Yes.Password;
            }
        }

        private void btnGuiThu_Click(object sender, EventArgs e)
        {
            MKTK.TaiKhoan = txbTaikhoan.Text;
            MKTK.Matkhau = txbMatkhau.Text;
            var listEmail = new List<EmailInfo>();
            var mailClient = new ImapClient();
            mailClient.Connect("imap.gmail.com", 993);
            mailClient.Authenticate(MKTK.TaiKhoan, MKTK.Matkhau);
            SmtpClient smtpClient = new SmtpClient("smtp.gmail.com");
            smtpClient.Port = 587;
            smtpClient.UseDefaultCredentials = false;
            smtpClient.Credentials = new System.Net.NetworkCredential(MKTK.TaiKhoan, MKTK.Matkhau);
            smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtpClient.EnableSsl = true;
            SendMail sendMail = new SendMail();
            sendMail.ShowDialog();
        }

        private void DangNhap_Load(object sender, EventArgs e)
        {
            btnGuiThu.Enabled = false;
            btnQuanLyThu.Enabled = false;
        }

        private void btnDN_Click(object sender, EventArgs e)
        {
            try
            {
                MKTK.TaiKhoan = txbTaikhoan.Text;
                MKTK.Matkhau = txbMatkhau.Text;
                var listEmail = new List<EmailInfo>();
                var mailClient = new ImapClient();
                SmtpClient smtpClient = new SmtpClient("smtp.gmail.com");
                mailClient.Connect("imap.gmail.com", 993);
                mailClient.Authenticate(MKTK.TaiKhoan, MKTK.Matkhau);
                smtpClient.Port = 587;
                smtpClient.UseDefaultCredentials = false;
                smtpClient.Credentials = new System.Net.NetworkCredential(MKTK.TaiKhoan, MKTK.Matkhau);
                smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtpClient.EnableSsl = true;
                MessageBox.Show("Đăng nhập thành công.","Thông bá0",MessageBoxButtons.OK,MessageBoxIcon.Information);
                btnGuiThu.Enabled = true;
                btnQuanLyThu.Enabled = true;
                btnDN.Enabled = false;
                txbMatkhau.ReadOnly = true;
                txbTaikhoan.ReadOnly = true;
            }
            catch
            {
                MessageBox.Show("Sai tài khoản hoặc mật khẩu. Vui lòng kiểm tra lại.");
                txbMatkhau.Text = "";
                txbTaikhoan.Text = "";
            }
        }
    }
}
