﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiNhanSu
{
    public partial class frmThemTaiKhoan : Form
    {
        public frmThemTaiKhoan()
        {
            InitializeComponent();
        }

      

        private void labelX3_Click(object sender, EventArgs e)
        {

        }

        private void btnThemMoi_Click_1(object sender, EventArgs e)
        {
            DangNhap temp = new DangNhap(txtmanv.Text, txtTenDN.Text, txtMK.Text);

            ConnectDatabase.ThemTaiKhoan(temp);
        }
    }
}
