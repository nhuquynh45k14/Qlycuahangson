using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLcuahangsonnuoc.Class;

namespace QLcuahangsonnuoc
{
    public partial class frmNguoiNH : Form
    {
        private DataTable tblNV; //Bảng nhân viên
        public frmNguoiNH()
        {
            InitializeComponent();

        }
        private void frmNguoiNH_Load(object sender, EventArgs e)
        {
            if (!Mainform.isManager)
            {
                MessageBox.Show("Nhân viên không có quyền truy cập", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();
                return;
            }

            txtMaNNH.Enabled = false;
            btnLuu.Enabled = false;
            btnReset.Enabled = false;
            LoadDataGridView();
        }
        private void LoadDataGridView()
        {
            string sql;
            sql = "SELECT * from NhanVien";
            tblNV = Functions.GetDataToTable(sql); //Lấy dữ liệu từ bảng
            dgvNhanVien.DataSource = tblNV; //Hiển thị vào dataGridView
            dgvNhanVien.Columns[0].HeaderText = "Mã nhân viên";
            dgvNhanVien.Columns[1].HeaderText = "Tên nhân viên";
            dgvNhanVien.Columns[2].HeaderText = "Số điện thoại";
            dgvNhanVien.Columns[3].HeaderText = "Địa chỉ";
            dgvNhanVien.Columns[0].Width = 150;
            dgvNhanVien.Columns[1].Width = 250;
            dgvNhanVien.Columns[2].Width = 150;
            dgvNhanVien.Columns[3].Width = 250;
            dgvNhanVien.AllowUserToAddRows = false;
            dgvNhanVien.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnReset.Enabled = true;
            btnLuu.Enabled = true;
            btnThem.Enabled = false;
            ResetValues();
            txtMaNNH.Enabled = true;
            txtMaNNH.Focus();
        }
        private void ResetValues()
        {
            txtMaNNH.Text = "";
            txtTenNNH.Text = "";
            txtDiaChi.Text = "";
            txtSoDienThoai.Text = "";
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql;
            //kiểm tra dữ liệu có hợp lệ hay ko
            if (txtMaNNH.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaNNH.Focus();
                return;
            }
            if (txtTenNNH.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenNNH.Focus();
                return;
            }
            if (txtDiaChi.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã màu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDiaChi.Focus();
                return;
            }
            if (txtSoDienThoai.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập số lượng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSoDienThoai.Focus();
                return;
            }

            //insert
            sql = "INSERT INTO NhanVien VALUES ('" + txtMaNNH.Text.Trim() +
                "',N'" + txtTenNNH.Text.Trim() + "','" + txtSoDienThoai.Text.Trim() + "',N'" + txtDiaChi.Text + "')";
            Functions.RunSql(sql);
            LoadDataGridView();
            ResetValues();

            btnXoa.Enabled = true;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnReset.Enabled = false;
            btnLuu.Enabled = false;
            txtMaNNH.Enabled = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblNV.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMaNNH.Text == "")
            {
                MessageBox.Show("Bạn phải chọn bản ghi cần sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtTenNNH.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenNNH.Focus();
                return;
            }
            if (txtDiaChi.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập địa chỉ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDiaChi.Focus();
                return;
            }
            if (txtSoDienThoai.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập số điện thoại ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSoDienThoai.Focus();
                return;
            }           ////loi
            sql = "UPDATE NhanVien SET TenNV=N'" + txtTenNNH.Text.Trim().ToString() + "',DiaChiNV=N'" +
                txtDiaChi.Text.Trim().ToString() + "',SoDienThoaiNV='" + txtSoDienThoai.Text.Trim().ToString() + "' WHERE MaNV=N'" + txtMaNNH.Text + "'";
            Functions.RunSql(sql);
            LoadDataGridView();
            ResetValues();
            btnReset.Enabled = false;

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblNV.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMaNNH.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xoá bản ghi này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                sql = "DELETE NhanVien WHERE MaNV=N'" + txtMaNNH.Text + "'";
                Functions.RunSql(sql);
                LoadDataGridView();
                ResetValues();
            }

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetValues();
            btnReset.Enabled = false;
            btnThem.Enabled = true;
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            btnLuu.Enabled = false;
            txtMaNNH.Enabled = false;
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvNhanVien_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (btnThem.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaNNH.Focus();
                return;
            }
            if (tblNV.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            txtMaNNH.Text = dgvNhanVien.CurrentRow.Cells["MaNV"].Value.ToString();
            txtTenNNH.Text = dgvNhanVien.CurrentRow.Cells["TenNV"].Value.ToString();
            txtSoDienThoai.Text = dgvNhanVien.CurrentRow.Cells["SoDienThoaiNV"].Value.ToString();
            txtDiaChi.Text = dgvNhanVien.CurrentRow.Cells["DiaChiNV"].Value.ToString();
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnReset.Enabled = true;
        }
    }
}
