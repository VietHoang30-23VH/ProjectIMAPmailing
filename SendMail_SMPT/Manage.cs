﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SendMail_SMPT
{
    public partial class Manage : Form
    {
        public Manage()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            DangNhap dangNhap = new DangNhap();
            dangNhap.ShowDialog();
        }
    }
}
