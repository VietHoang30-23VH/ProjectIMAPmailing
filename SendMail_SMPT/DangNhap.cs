using System;
using System.Windows.Forms;
using System.Net.Mail;
using MailKit.Net.Imap;

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
        private void DangNhapHeThong()
        {
            MKTK.TaiKhoan = txbTaikhoan.Text;
            MKTK.Matkhau = txbMatkhau.Text;
        }
        private void btnQuanLyThu_Click(object sender, EventArgs e)
        {
            try
            {
                DangNhapHeThong();
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
            txbMatkhau.UseSystemPasswordChar = !displayMk.Checked;
        }

        private void btnGuiThu_Click(object sender, EventArgs e)
        {
            DangNhapHeThong();
            var mailClient = new ImapClient();
            mailClient.Connect("imap.gmail.com", 993);
            mailClient.Authenticate(MKTK.TaiKhoan, MKTK.Matkhau);
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
                DangNhapHeThong();
                var mailClient = new ImapClient();
                mailClient.Connect("imap.gmail.com", 993);
                mailClient.Authenticate(MKTK.TaiKhoan, MKTK.Matkhau);
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
