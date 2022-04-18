using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using QLcuahangsonnuoc.Class;

namespace QLcuahangsonnuoc
{
    public partial class frmNCC : Form
    {
        private DataTable tblNCC;
        public frmNCC()
        {
            InitializeComponent();
            if (!Mainform.isManager)
            {
                btnXoa.Enabled = false;
                btnSua.Enabled = false;
            }
        }

        private void frmNCC_Load(object sender, EventArgs e)
        {
            txtMaNCC.Enabled = false;
            btnLuu.Enabled = false;
            btnReset.Enabled = false;
            LoadDataGridView();
            if (!Mainform.isManager)
            {
                btnXoa.Enabled = false;
                btnSua.Enabled = false;
            }
        }
        private void LoadDataGridView()
        {
            string sql;
            sql = "SELECT * from NhaCungCap";
            tblNCC = Functions.GetDataToTable(sql); //Lấy dữ liệu từ bảng
            dgvNCC.DataSource = tblNCC; //Hiển thị vào dataGridView
            dgvNCC.Columns[0].HeaderText = "Mã NCC";
            dgvNCC.Columns[1].HeaderText = "Tên NCC";
            dgvNCC.Columns[2].HeaderText = "Địa chỉ";
            dgvNCC.Columns[3].HeaderText = "Điện thoại";
            dgvNCC.Columns[0].Width = 150;
            dgvNCC.Columns[1].Width = 200;
            dgvNCC.Columns[2].Width = 350;
            dgvNCC.Columns[3].Width = 150;
            dgvNCC.AllowUserToAddRows = false;
            dgvNCC.EditMode = DataGridViewEditMode.EditProgrammatically;
            if (!Mainform.isManager)
            {
                btnXoa.Enabled = false;
                btnSua.Enabled = false;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnReset.Enabled = true;
            btnLuu.Enabled = true;
            btnThem.Enabled = false;
            ResetValues();
            txtMaNCC.Enabled = true;
            txtTenNCC.Focus();
            if (!Mainform.isManager)
            {
                btnXoa.Enabled = false;
                btnSua.Enabled = false;
            }
        }
        private void ResetValues()
        {
            txtMaNCC.Text = "";
            txtTenNCC.Text = "";
            txtDiaChi.Text = "";
            txtSDT.Text = "";
            if (!Mainform.isManager)
            {
                btnXoa.Enabled = false;
                btnSua.Enabled = false;
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql;
            //kiểm tra dữ liệu có hợp lệ hay ko
            if (txtMaNCC.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã nhà cung cấp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaNCC.Focus();
                return;
            }
            if (txtTenNCC.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên nhà cung cấp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenNCC.Focus();
                return;
            }
            if (txtDiaChi.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập địa chỉ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDiaChi.Focus();
                return;
            }
            if (txtSDT.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập số điện thoại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSDT.Focus();
                return;
            }
            //Chèn thêm
            sql = "INSERT INTO NhaCungCap VALUES (N'" + txtMaNCC.Text.Trim() +
                "',N'" + txtTenNCC.Text.Trim() + "',N'" + txtDiaChi.Text.Trim() + "','" + txtSDT.Text + "')";
            Functions.RunSql(sql);
            LoadDataGridView();
            ResetValues();

            btnXoa.Enabled = true;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnReset.Enabled = false;
            btnLuu.Enabled = false;
            txtMaNCC.Enabled = false;
            if (!Mainform.isManager)
            {
                btnXoa.Enabled = false;
                btnSua.Enabled = false;
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblNCC.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMaNCC.Text == "")
            {
                MessageBox.Show("Bạn phải chọn bản ghi cần sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtTenNCC.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên nhà cung cấp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenNCC.Focus();
                return;
            }
            if (txtDiaChi.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập địa chỉ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDiaChi.Focus();
                return;
            }
            if (txtSDT.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập số điện thoại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSDT.Focus();
                return;
            }
            sql = "UPDATE NhaCungCap SET TenNCC=N'" + txtTenNCC.Text.Trim().ToString() + "',DiaChiNCC=N'" +
                txtDiaChi.Text.Trim().ToString() + "',SoDienThoaiNCC='" + txtSDT.Text.Trim().ToString() +
                "' WHERE MaNCC=N'" + txtMaNCC.Text + "'";
            Functions.RunSql(sql);
            LoadDataGridView();
            ResetValues();
            btnReset.Enabled = false;
            txtMaNCC.Enabled = false;
            if (!Mainform.isManager)
            {
                btnXoa.Enabled = false;
                btnSua.Enabled = false;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblNCC.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMaNCC.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xoá bản ghi này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                sql = "DELETE NhaCungCap WHERE MaNCC=N'" + txtMaNCC.Text + "'";
                Functions.RunSql(sql);
                LoadDataGridView();
                ResetValues();
            }
            if (!Mainform.isManager)
            {
                btnXoa.Enabled = false;
                btnSua.Enabled = false;
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
            txtMaNCC.Enabled = false;
            if (!Mainform.isManager)
            {
                btnXoa.Enabled = false;
                btnSua.Enabled = false;
            }
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvNCC_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (btnThem.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaNCC.Focus();
                return;
            }
            if (tblNCC.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            txtMaNCC.Text = dgvNCC.CurrentRow.Cells["MaNCC"].Value.ToString();
            txtTenNCC.Text = dgvNCC.CurrentRow.Cells["TenNCC"].Value.ToString();
            txtDiaChi.Text = dgvNCC.CurrentRow.Cells["DiaChiNCC"].Value.ToString();
            txtSDT.Text = dgvNCC.CurrentRow.Cells["SoDienThoaiNCC"].Value.ToString();
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnReset.Enabled = true;
            if (!Mainform.isManager)
            {
                btnXoa.Enabled = false;
                btnSua.Enabled = false;
            }
        }
    }
}
