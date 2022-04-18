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
    public partial class frmHang : Form
    {

        private DataTable tblHangHoa;

        public frmHang()
        {
            InitializeComponent();

            if (!Mainform.isManager)
            {
                btnSua.Enabled = false;
                btnXoa.Enabled = false;
            }
        }
      

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblHangHoa.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMaHang.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xoá bản ghi này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                sql = "DELETE Hang WHERE MaHH=N'" + txtMaHang.Text + "'";
                Functions.RunSql(sql);
                LoadDataGridView();
                ResetValues();
            }
        }

        private void frmHang_Load(object sender, EventArgs e)
        {
            txtMaHang.Enabled = false;
            btnLuu.Enabled = false;
            btnReset.Enabled = false;
            Functions.FillCombo("SELECT MaHH FROM Hang", cboMaHang, "MaHH", "MaHH");
            cboMaHang.SelectedIndex = -1;
            LoadDataGridView();
        }
        private void LoadDataGridView()
        {
            string sql;
            sql = "SELECT * from Hang";
            tblHangHoa = Functions.GetDataToTable(sql); //Lấy dữ liệu từ bảng
            dgvHangHoa.DataSource = tblHangHoa; //Hiển thị vào dataGridView
            dgvHangHoa.Columns[0].HeaderText = "Mã Hàng";
            dgvHangHoa.Columns[1].HeaderText = "Mã Màu";
            dgvHangHoa.Columns[2].HeaderText = "Tên Hàng";
            dgvHangHoa.Columns[3].HeaderText = "Số Lượng";
            dgvHangHoa.Columns[4].HeaderText = "Đơn Gía Nhập";
            dgvHangHoa.Columns[5].HeaderText = "Đơn Gía Bán";
            dgvHangHoa.Columns[0].Width = 100;
            dgvHangHoa.Columns[1].Width = 100;
            dgvHangHoa.Columns[2].Width = 200;
            dgvHangHoa.Columns[3].Width = 100;
            dgvHangHoa.Columns[4].Width = 150;
            dgvHangHoa.Columns[5].Width = 150;
            dgvHangHoa.AllowUserToAddRows = false;
            dgvHangHoa.EditMode = DataGridViewEditMode.EditProgrammatically;
        }
        private void cboMaHang_DropDown(object sender, EventArgs e)
        {
            Functions.FillCombo("SELECT MaHH FROM Hang", cboMaHang, "MaHH", "MaHH");
            cboMaHang.SelectedIndex = -1;
            //Phương thức này dùng để cập nhật lại danh sách các mã hàng và lưu vào combobox mỗi khi nháy chuột và nút đổ cuống của combobox
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnReset.Enabled = true;
            btnLuu.Enabled = true;
            btnThem.Enabled = false;
            ResetValues();
            txtMaHang.Enabled = true;
            txtMaHang.Focus();

            if (!Mainform.isManager)
            {
                btnSua.Enabled = false;
                btnXoa.Enabled = false;
            }
        }
        private void ResetValues()
        {
            txtMaHang.Text = "";
            txtTenHang.Text = "";
            txtMaMau.Text = "";
            txtSoLuong.Text = "";
            txtDonGiaBan.Text = "";
            txtDonGiaNhap.Text = "";
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblHangHoa.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMaHang.Text == "")
            {
                MessageBox.Show("Bạn phải chọn bản ghi cần sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtTenHang.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenHang.Focus();
                return;
            }
            if (txtMaMau.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã màu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaMau.Focus();
                return;
            }
            if (txtSoLuong.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập số lượng ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSoLuong.Focus();
                return;
            }
            if (txtDonGiaBan.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập đơn giá bán", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDonGiaBan.Focus();
                return;
            }
            if (txtDonGiaNhap.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập đơn giá nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDonGiaNhap.Focus();
                return;
            }
            sql = "UPDATE Hang SET TenHang=N'" + txtTenHang.Text.Trim().ToString() + "',MaMau=N'" +
                txtMaMau.Text.Trim().ToString() + "',SoLuong='" + txtSoLuong.Text.Trim().ToString() +
                "',DonGiaNhap='"+txtDonGiaNhap.Text.Trim().ToString()+"',DonGiaBan='"+txtDonGiaBan.Text.Trim().ToString()+
                "' WHERE MaHH=N'" + txtMaHang.Text + "'";
            Functions.RunSql(sql);
            LoadDataGridView();
            ResetValues();
            btnReset.Enabled = false;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql;
            //kiểm tra dữ liệu có hợp lệ hay ko
            if (txtMaHang.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaHang.Focus();
                return;
            }
                if (txtTenHang.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập tên hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtTenHang.Focus();
                    return;
                }
                if (txtMaMau.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập mã màu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtMaMau.Focus();
                    return;
                }
                if (txtSoLuong.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập số lượng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtSoLuong.Focus();
                    return;
                }
                if (txtDonGiaBan.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập đơn giá bán", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtSoLuong.Focus();
                    return;
                }
                if (txtDonGiaNhap.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập đơn giá nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtSoLuong.Focus();
                    return;
                }
                //insert
                sql = "INSERT INTO Hang VALUES (N'" + txtMaHang.Text.Trim() +
                    "',N'" + txtMaMau.Text.Trim() + "',N'" + txtTenHang.Text.Trim() + "','" + txtSoLuong.Text + "','" + txtDonGiaBan.Text.Trim() + "','" 
                    + txtDonGiaNhap.Text.Trim() + "')";
                Functions.RunSql(sql);
                LoadDataGridView();
                ResetValues();

                btnXoa.Enabled = true;
                btnThem.Enabled = true;
                btnSua.Enabled = true;
                btnReset.Enabled = false;
                btnLuu.Enabled = false;
                txtMaHang.Enabled = false;

                if (!Mainform.isManager)
                {
                    btnSua.Enabled = false;
                    btnXoa.Enabled = false;
                }
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetValues();
            btnReset.Enabled = false;
            btnThem.Enabled = true;
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            btnLuu.Enabled = false;
            txtMaHang.Enabled = false;
            LoadDataGridView();

            if (!Mainform.isManager)
            {
                btnSua.Enabled = false;
                btnXoa.Enabled = false;
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            ResetValues();
            if (cboMaHang.Text == "")
            {
                MessageBox.Show("Bạn phải chọn một mã hàng để tìm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboMaHang.Focus();
                return;
            }

            txtMaHang.Text = cboMaHang.Text;

            btnReset.Enabled = true;
            btnThem.Enabled = true;
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            btnLuu.Enabled = false;
            txtMaHang.Enabled = false;
            LoadDataGridViewHang();
            cboMaHang.SelectedIndex = -1; //Thường thì combobox sẽ lấy số chỉ mục đầu tiên là 0 để hiện lên combobox , viết -1 là để nó lấy số chỉ mục -1, và khi hiện lên ô combobox sẽ trống 

            if (!Mainform.isManager)
            {
                btnSua.Enabled = false;
                btnXoa.Enabled = false;
            }
        }
        private void LoadDataGridViewHang()
        {
            string sql;
            sql = "SELECT * FROM Hang WHERE MaHH = N'" + txtMaHang.Text + "'";
            tblHangHoa = Functions.GetDataToTable(sql); // lấy dữ liệu
            dgvHangHoa.DataSource = tblHangHoa; //Hiển thị vào dataGridView
            dgvHangHoa.Columns[0].HeaderText = "Mã Hàng";
            dgvHangHoa.Columns[1].HeaderText = "Mã Màu";
            dgvHangHoa.Columns[2].HeaderText = "Tên Hàng";
            dgvHangHoa.Columns[3].HeaderText = "Số Lượng";
            dgvHangHoa.Columns[4].HeaderText = "Đơn Gía Nhập";
            dgvHangHoa.Columns[5].HeaderText = "Đơn Gía Bán";
            dgvHangHoa.Columns[0].Width = 100;
            dgvHangHoa.Columns[1].Width = 100;
            dgvHangHoa.Columns[2].Width = 200;
            dgvHangHoa.Columns[3].Width = 100;
            dgvHangHoa.Columns[4].Width = 150;
            dgvHangHoa.Columns[5].Width = 150;
            dgvHangHoa.AllowUserToAddRows = false;
            dgvHangHoa.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void dgvHangHoa_DoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (btnThem.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaHang.Focus();
                return;
            }
            if (tblHangHoa.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            txtMaHang.Text = dgvHangHoa.CurrentRow.Cells["MaHH"].Value.ToString();
            txtMaMau.Text = dgvHangHoa.CurrentRow.Cells["MaMau"].Value.ToString();
            txtTenHang.Text = dgvHangHoa.CurrentRow.Cells["TenHang"].Value.ToString();
            txtSoLuong.Text = dgvHangHoa.CurrentRow.Cells["SoLuong"].Value.ToString();
            txtDonGiaNhap.Text = dgvHangHoa.CurrentRow.Cells["DonGiaNhap"].Value.ToString();
            txtDonGiaBan.Text = dgvHangHoa.CurrentRow.Cells["DonGiaBan"].Value.ToString();

            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnReset.Enabled = true;

            if (!Mainform.isManager)
            {
                btnSua.Enabled = false;
                btnXoa.Enabled = false;
            }
        }

    }
}
