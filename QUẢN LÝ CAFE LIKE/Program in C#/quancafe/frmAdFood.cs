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
    public partial class frmAdFood : Form
    {
        string oldname;
        public frmAdFood()
        {
            InitializeComponent();
        }

        private void frmAdFood_Load(object sender, EventArgs e)
        {
            load();
            setNameCategory();
        }
        //cap nhat category de chon
        private void setNameCategory()
        {
            DataProvider provider = new DataProvider();
            DataTable table = provider.loadCategory();
            for (int i = 0; i < table.Rows.Count; i++)
            {
                cbbAddCate.Items.Add(table.Rows[i][0].ToString());
            }
        }

        //ham load thong tin
        private void load()
        {
            try
            {
                DataProvider provider = new DataProvider();
                DataTable table = provider.loadAllFood();
                dgvResult.DataSource = table;
            }
            catch
            {
                MessageBox.Show("Tải cơ sở dữ liệu không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //reset
        private void clear()
        {
            txtAddName.ResetText();
            cbbAddCate.ResetText();
            nudAddPrice.Value = 1000;
            cbbAddCate.Focus();
        }
        //click table
        private void dgvResult_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = dgvResult.Rows[e.RowIndex];
                    txtAddName.Text = row.Cells[0].Value.ToString();
                    oldname = row.Cells[0].Value.ToString();
                    cbbAddCate.Text = row.Cells[1].Value.ToString();
                    nudAddPrice.Value = Int32.Parse(row.Cells[2].Value.ToString());
                }
            }
            catch
            {
                // xu ly ngoai le loi du lieu o day
                MessageBox.Show("Lỗi cơ sở dữ liệu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //su kien button click them mon
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string name = txtAddName.Text;
                string nameCate = cbbAddCate.Text;
                float price = Convert.ToInt64(nudAddPrice.Value);
                DataProvider provider = new DataProvider();// ham load du lieu
                provider.AddFood(nameCate, name, price);// them  du lieu vao (ten mon, danh muc, gia)
                // thong bao nguoi dung  them mon thanh cong khi nhap day du (ten mon , ten danh mục, gia)
                // va ten mon khong duoc trung voi ten mon da co.
                MessageBox.Show("Thêm món thành công", "Đã thêm", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clear();
                load();
            }
            catch
            {
                // thong bao loi them mon khong thanh cong khi nhap ten mon bi trung voi ten mon da co 
                // hoac khong nhap ten mon
                MessageBox.Show("Thêm món không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //su kien button click Xoa mon
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                //thong bao hoi ban có chac chan xoa khong 
                // neu xac nhan xoa thi nhan yes
                // neu khong muon xoa thi nhan no
                if (MessageBox.Show("Bạn có chắc chắn xóa món không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    //Nhan yes
                    string name = txtAddName.Text;
                    DataProvider provider = new DataProvider();// load du lieu
                    provider.DelFood(name); //xoa  du lieu theo theo ten
                    //thong bao xoa mon thanh cong 
                    MessageBox.Show("Xóa món thành công!", "Đã xóa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clear();
                    load();
                }
                //nhan no
            }
            catch
            {
                // thong bao xoa mon khong thanh cong khi nguoi dung nhap sai ten mon va danh muc.
                MessageBox.Show("Xóa món không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //su kien button click Sua mon
        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                string newname = txtAddName.Text;
                string nameCate = cbbAddCate.Text;
                float price = Convert.ToInt32(nudAddPrice.Value);
                DataProvider provider = new DataProvider();// load du lieu
                provider.UpdateFood(nameCate, newname, price, oldname); // cap nhap du lieu (ten danh muc, ten mon, gia)
                // khi nguoi dung chon ten mon va danh mục can sua hop le thì sua thanh cong 
                MessageBox.Show("Sửa món thành công!", "Đã sửa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clear();
                load();
            }
            catch
            {
                // thong bao sua khong thanh cong khi lay du lieu ten mon va danh muc khong hop le
                MessageBox.Show("Sửa món không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
