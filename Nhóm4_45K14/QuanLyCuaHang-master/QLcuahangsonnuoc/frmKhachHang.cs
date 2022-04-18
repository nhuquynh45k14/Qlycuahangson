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
    public partial class frmKhachHang : Form
    {
        private DataTable tblKH; //Bảng khách hàng
        public frmKhachHang()
        {
            InitializeComponent();
            if (!Mainform.isManager)
            {
                btnXoa.Enabled = false;
                btnSua.Enabled = false;
            }
        }

        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            txtMaKhachHang.Enabled = false;
            btnLuu.Enabled = false;
            btnBoQua.Enabled = false;
            LoadDataGridView();
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

        private void LoadDataGridView()
        {
            string sql;
            sql = "SELECT * from KhachHang";
            tblKH = new DataTable();
            Functions.GetDataAdapter(sql).Fill(tblKH); //Lấy dữ liệu từ bảng
            dgvKhachHang.DataSource = tblKH; //Hiển thị vào dataGridView
            dgvKhachHang.Columns[0].HeaderText = "Mã khách";
            dgvKhachHang.Columns[1].HeaderText = "Tên khách";
            dgvKhachHang.Columns[2].HeaderText = "Địa chỉ";
            dgvKhachHang.Columns[3].HeaderText = "Điện thoại";
            dgvKhachHang.Columns[0].Width = 100;
            dgvKhachHang.Columns[1].Width = 150;
            dgvKhachHang.Columns[2].Width = 250;
            dgvKhachHang.Columns[3].Width = 150;
            dgvKhachHang.AllowUserToAddRows = false;
            dgvKhachHang.EditMode = DataGridViewEditMode.EditProgrammatically;
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
            btnBoQua.Enabled = true;
            btnLuu.Enabled = true;
            btnThem.Enabled = false;
            ResetValues();
            txtMaKhachHang.Enabled = true;
            txtHoVaTen.Focus();
            if (!Mainform.isManager)
            {
                btnXoa.Enabled = false;
                btnSua.Enabled = false;
            }
        }
        
        private void ResetValues()
        {
            txtMaKhachHang.Text = "";
            txtHoVaTen.Text = "";
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
            if (txtHoVaTen.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên khách", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtHoVaTen.Focus();
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
                MessageBox.Show("Bạn phải nhập điện thoại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSDT.Focus();
                return;
            }
            //Chèn thêm
            sql = "INSERT INTO KhachHang VALUES (N'" + txtMaKhachHang.Text.Trim() +
                "',N'" + txtHoVaTen.Text.Trim() + "',N'" + txtDiaChi.Text.Trim() + "','" + txtSDT.Text + "')";
            Functions.RunSql(sql);
            LoadDataGridView();
            ResetValues();

            btnXoa.Enabled = true;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnBoQua.Enabled = false;
            btnLuu.Enabled = false;
            txtMaKhachHang.Enabled = false;
            if (!Mainform.isManager)
            {
                btnXoa.Enabled = false;
                btnSua.Enabled = false;
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblKH.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMaKhachHang.Text == "")
            {
                MessageBox.Show("Bạn phải chọn bản ghi cần sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtHoVaTen.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên khách", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtHoVaTen.Focus();
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
                MessageBox.Show("Bạn phải nhập điện thoại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSDT.Focus();
                return;
            }
            sql = "UPDATE KhachHang SET TenKH=N'" + txtHoVaTen.Text.Trim().ToString() + "',DiaChiKH=N'" +
                txtDiaChi.Text.Trim().ToString() + "',SoDienThoaiKH='" + txtSDT.Text.Trim().ToString() +
                "' WHERE MaKH=N'" + txtMaKhachHang.Text + "'";
            Functions.RunSql(sql);
            LoadDataGridView();
            ResetValues();
            btnBoQua.Enabled = false;
            if (!Mainform.isManager)
            {
                btnXoa.Enabled = false;
                btnSua.Enabled = false;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblKH.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMaKhachHang.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xoá bản ghi này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                sql = "DELETE KhachHang WHERE MaKH=N'" + txtMaKhachHang.Text + "'";
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

        private void btnBoQua_Click(object sender, EventArgs e)
        {
            ResetValues();
            btnBoQua.Enabled = false;
            btnThem.Enabled = true;
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            btnLuu.Enabled = false;
            txtMaKhachHang.Enabled = false;
            if (!Mainform.isManager)
            {
                btnXoa.Enabled = false;
                btnSua.Enabled = false;
            }
        }
        
        private void dgvKhachHang_DoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (btnThem.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaKhachHang.Focus();
                return;
            }
            if (tblKH.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            txtMaKhachHang.Text = dgvKhachHang.CurrentRow.Cells["MaKH"].Value.ToString();
            txtHoVaTen.Text = dgvKhachHang.CurrentRow.Cells["TenKH"].Value.ToString();
            txtDiaChi.Text = dgvKhachHang.CurrentRow.Cells["DiaChiKH"].Value.ToString();
            txtSDT.Text = dgvKhachHang.CurrentRow.Cells["SoDienThoaiKH"].Value.ToString();
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnBoQua.Enabled = true;
            if (!Mainform.isManager)
            {
                btnXoa.Enabled = false;
                btnSua.Enabled = false;
            }
        }
    }
}
