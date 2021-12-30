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
    public partial class frmAdCategory : Form
    {
        public frmAdCategory()
        {
            InitializeComponent();
        }
        private void frmAdCategory_Load(object sender, EventArgs e)
        {
            load();
        }
        //ham load thong tin
        private void load()
        {
            try
            {
                DataProvider provider = new DataProvider();
                DataTable table = provider.loadCategory(); // load du lieu bang category
                dgvResult.DataSource = table; // hien thi du lieu bang category
            }
            catch
            {
                // thong bao loi khong the load du lieu 
                MessageBox.Show("Không thể tải dữ liệu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // su kien button click them danh muc
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtName.Text != "")
                {
                    DataProvider provider = new DataProvider();
                    provider.AddCate(txtName.Text);//them ten danh muc vao csdl
                    // thong bao nguoi dung da them danh muc thanh cong
                    // khi nguoi dung nhap ten danh muc moi khong trung voi ten danh muc da co. 
                    MessageBox.Show("Bạn đã thêm danh mục thành công!", "Đã thêm", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtName.ResetText();
                    load();
                }
                else
                {
                    // thong bao nguoi dung chua nhap ten danh muc
                    MessageBox.Show("Tên danh mục trống!", "Thiếu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch
            {
                //thong bao loi nguoi dung nhap ten danh muc moi trung voi ten danh muc da co
                MessageBox.Show("Thêm danh mục không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //Khi click chon => datagidview
        private void dgvResult_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int t = dgvResult.CurrentCell.RowIndex;
            lblText.Text = dgvResult.Rows[t].Cells[0].Value.ToString();
        }
        //su kien button click Xoa 
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                //thong bao hoi ban có chac chan xoa khong 
                // neu xac nhan xoa thi nhan yes
                // neu khong muon xoa thi nhan no
                if (MessageBox.Show("Bạn có chắc xóa danh mục này không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    //Nhan yes
                    DataProvider provider = new DataProvider(); // load du lieu
                    provider.DelCate(lblText.Text);//lay du lieu cua category can xoa
                    //thong báo nguoi dung xoa danh mục thanh cong
                    MessageBox.Show("Bạn đã xóa danh mục thành công!", "Đã xóa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    load();
                }
                //nhan no
            }
            catch //xu ly truong hop ngoai le
            {
                // thong bao nguoi dung khong the xoa danh muc 
                MessageBox.Show("Không thể xóa danh mục này!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //su kien button click sua
        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                DataProvider provider = new DataProvider();// load du kieu 
                provider.UpdateCate(txtName.Text, lblText.Text);// update danh muc vao table category
                // thong bao nguoi dung da sua danh muc nguoi dung can sua thanh cong
                MessageBox.Show("Bạn đã sửa danh mục thành công!", "Đã sửa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                load();
                txtName.ResetText();
            }
            catch
            {
                // thong bao loi khong the sua danh muc vi nguoi dung nhap ten danh muc moi
                // da trung voi 1 ten danh muc nao do da co trong csdl
                MessageBox.Show("Không thể chỉnh sửa danh mục này!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmAdCategory_Load_1(object sender, EventArgs e)
        {
            load();
        }
    }
}
