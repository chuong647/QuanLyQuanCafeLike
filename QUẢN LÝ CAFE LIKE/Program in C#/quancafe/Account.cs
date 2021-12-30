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
    public partial class frmAdAccount : Form
    {
        string oldusername;
        public frmAdAccount()
        {
            InitializeComponent();
        }

        private void frmAdAccount_Load(object sender, EventArgs e)
        {

        }
        private void Account_Load(object sender, EventArgs e)
        {
            load();
        }
        //ham load thong tin
        private void load()
        {
            DataProvider provider = new DataProvider();
            DataTable table = provider.loadAccount();// lay du lieu bang Account
            dgvResult.DataSource = table;  //hien thi du lieu bang Account
        }
        // Don rac 
        private void clear()
        {
            txtUsername.ResetText();
            txtDisplayname.ResetText();
            txtPassword.ResetText();
            ckbAdmin.Checked = false;
        }

        private void dgvResult_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvResult.Rows[e.RowIndex];
                txtUsername.Text = row.Cells[0].Value.ToString();
                oldusername = row.Cells[0].Value.ToString();
                txtDisplayname.Text = row.Cells[1].Value.ToString();
                txtPassword.Text = row.Cells[2].Value.ToString();
                if (row.Cells[3].Value.ToString() == "ADMIN")
                    ckbAdmin.Checked = true;
                else if (row.Cells[3].Value.ToString() == "CASHIER")
                    ckbAdmin.Checked = false;
            }
        }
        //su kien button click them tai khoan
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string username = txtUsername.Text;
                string displayname = txtDisplayname.Text;
                string password = txtPassword.Text;
                string type = "CASHIER";
                // neu nguoi dung them Account ma khong tich vao phan quyen Admin
                // thi he thong tu dong chon phan quyen Cashier
                if (ckbAdmin.Checked == true)
                {
                    type = "ADMIN"; // phan quyen Quan ly
                }
                DataProvider provider = new DataProvider();// load du lieu
                provider.AddAccount(username, displayname, password, type); // them du lieu vao(username, displayname, password, type)
                // thong bao nguoi dung da them account thanh cong
                // khi nguoi dung nhap (username, displayname) khong trung voi nguoi dung khac
                MessageBox.Show("Bạn đã thêm thành công!\n Tài khoản " + displayname + " đã được thêm.", "Đã thêm", MessageBoxButtons.OK, MessageBoxIcon.Information);
                load();
                clear();
            }
            catch
            {
                // thong bao nguoi dung khong the them Account
                // khi nguoi dung nhap (username, displayname) trung voi nguoi dung khac
                MessageBox.Show("Không thể thêm tài khoản được", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //su kien button xoa tai khoan
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                //thong bao hoi ban có chac chan xoa khong 
                // neu xac nhan xoa thi nhan yes
                // neu khong muon xoa thi nhan no
                if (MessageBox.Show("Bạn có chắc xóa tài khoản " + oldusername + " không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    //Nhan yes
                    string name = txtUsername.Text;
                    DataProvider provider = new DataProvider();
                    provider.DelAccount(name); // lay du lieu trong bang Account can xoa
                    // thong bao nguoi dung da xoa tai khoan thanh cong
                    MessageBox.Show("Bạn đã xóa thành công!\n Tài khoản " + name + " đã được xóa.", "Đã xóa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    load();
                    clear();
                }
                //nhan no
            }
            catch
            {
                // thong bao nguoi dung khong xoa duoc
                // neu nguoi dung xoa Account hien dang dang nhap vao he thong thi khong xoa duoc
                MessageBox.Show("Không xóa được", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //Su kien button sua tai khoan
        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                string newusername = txtUsername.Text;
                string newdisplayname = txtDisplayname.Text;
                string newpassword = txtPassword.Text;
                string type = "CASHIER"; //CASHIER => Thu ngân
                // neu nguoi dung sua Account ma khong tich vao phan quyen Admin
                // thi he thong tu dong chon phan quyen Cashier va nguoc lai
                if (ckbAdmin.Checked == true)
                {
                    type = "ADMIN";// Admin => Quản lý
                }
                DataProvider provider = new DataProvider();
                provider.UpdateAccount(newusername, newdisplayname, newpassword, type, oldusername);//cap nhat du lieu moi vao(newusername,newdisplay,newpassword, type,oldusername)
                // thong bao chinh sua Account thanh cong  khi newusername, displayname nguoi dung 
                // khong duoc trung voi username, displayname cua nguoi dung khac
                MessageBox.Show("Bạn đã chỉnh sửa thành công!\n Tài khoản " + oldusername + " đã chỉnh sửa.", "Đã sửa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                load();
                clear();
            }
            catch
            {
                // thong bao chinh sua Account khong thanh cong khi newusername, displayname nguoi dung 
                // da trung voi username, displayname cua nguoi dung khac
                MessageBox.Show("Không sữa được!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
