using System;
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
    public partial class frmLogin : Form
    {
        string name;
        string type;
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
        // Su kien click btnThoat
        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult ms = MessageBox.Show("Bạn có muốn thoát không? ", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ms == DialogResult.Yes)
            {
                this.Close(); // thoát khỏi giao dien login
            }
        }
        //Ham kiem tra Dang nhap
        private bool CheckLogin(string username, string password, string typeA)
        {
            DataProvider provider = new DataProvider();
            DataTable table = provider.loadAccount();
            for (int i = 0; i < table.Rows.Count; i++)
            {
                if (table.Rows[i][0].ToString() == username && table.Rows[i][2].ToString() == password && table.Rows[i][3].ToString() == typeA)
                {
                    name = table.Rows[i][1].ToString();
                    type = table.Rows[i][3].ToString();
                    // thong bao nguoi dung dang nhap thanh cong
                    MessageBox.Show("Xin chào " + name + " :)", "Đăng nhập thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
            }
            return false;
        }
        //Su kien click btnLogin
        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string user = txtUsername.Text;
                string pass = txtPassword.Text;
                string type = "CASHIER"; //CASHIER => Thu ngân
                if (rdbAdmin.Checked == true)
                {
                    type = "ADMIN"; // Admin => Quản lý
                }
                if (CheckLogin(user, pass, type) == true)
                {
                    frmMain main = new frmMain(user, name, pass, type);
                    this.Hide();
                    main.ShowDialog(); // hien thi giao dien chinh cua he thong
                    this.Show();
                }
                else
                {
                    //thong bao nguoi dung da nhap sai tai khoan hoac mat khau 
                    MessageBox.Show("Sai tài khoản hoặc mật khẩu", "Lỗi...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                //neu chua co co so du lieu 
                MessageBox.Show("Cơ sở dữ liệu không tồn tại. Vui lòng tạo mới cơ sở dữ liệu", "Lỗi...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        // su kiện click LblRegistration (Dang ky)
        private void lblRegistration_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            fRegistration f = new fRegistration();
            this.Hide();
            f.Show(); // hien thi giao dien Registration (Dang ky)
        }
    }
}
