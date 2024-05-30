using System;
using System.Windows.Forms;

namespace SendMail_SMPT
{
    public partial class Manage : Form
    {
        public Manage()
        {
            InitializeComponent();
        }

        private void btnBatDau_Click(object sender, EventArgs e)
        {
            DangNhap dangNhap = new DangNhap();
            dangNhap.ShowDialog();
        }

        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
