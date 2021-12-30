﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quancafe
{
    public partial class ChangePersional : Form
    {
        public ChangePersional()
        {
            InitializeComponent();
        }
        public ChangePersional(string user, string name, string pass) : this()
        {
            //load thog tin len
            txtUser.Text = user;
            txtName.Text = name;
            txtPass.Text = pass;
        }
        private void ChangePersional_Load(object sender, EventArgs e)
        {

        }
        //su kien button click Dong
        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //su kien button click xac nhan (luu lai thong tin moi)
        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            try
            {
                Save(txtUser.Text, txtName.Text, txtPass.Text);
                MessageBox.Show("Đã thay đổi", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch
            {
                MessageBox.Show("Thông tin không hợp lệ", "Lỗi...", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //Ham Luu tt moi
        private void Save(string user, string name, string pass)
        {
            DataProvider provider = new DataProvider();
            provider.resetAccount(name, pass, user);
        }
    }
}
