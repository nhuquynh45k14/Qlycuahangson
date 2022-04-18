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
    public partial class frmHoaDonBan : Form
    {
        private DataTable tblHDB;
        public frmHoaDonBan()
        {
            InitializeComponent();
            if (!Mainform.isManager)
            {
                btnXoa.Enabled = false;
            }
        }

        private void frmHoaDonBan_Load(object sender, EventArgs e)
        {
            btnThem.Enabled = true;
            btnLuu.Enabled = false;
            btnXoa.Enabled = false;
            txtMaHDBan.Enabled = false;
            txtTenHang.ReadOnly = true;
            txtDonGiaBan.ReadOnly = true;
            txtThanhTien.ReadOnly = true;
            txtTongTien.ReadOnly = true;
            txtTongTien.Text = "0";
            Functions.FillCombo("SELECT MaKH FROM KhachHang", cboMaKhach, "MaKH", "MaKH");
            cboMaKhach.SelectedIndex = -1;
            Functions.FillCombo("SELECT MaNV FROM NhanVien", cboMaNV, "MaNV", "MaNV");
            cboMaNV.SelectedIndex = -1;
            Functions.FillCombo("SELECT MaHH FROM Hang", cboMaHang, "MaHH", "MaHH");
            cboMaHang.SelectedIndex = -1;
            Functions.FillCombo("SELECT MaDBH FROM Xuat", cboMaHDB, "MaDBH", "MaDBH");
            cboMaHDB.SelectedIndex = -1;
            LoadDataGridView();
        }
        private void LoadDataGridView()
        {

            string sql;

            sql = "SELECT a.MaHH, b.TenHang, a.SoLuongBan, b.DonGiaBan,a.ThanhTien FROM Xuat_ChiTiet AS a, Hang AS b WHERE a.MaDBH = N'" + txtMaHDBan.Text + "' AND a.MaHH=b.MaHH";
            tblHDB = Functions.GetDataToTable(sql);
            dgvHDBanHang.DataSource = tblHDB;
            dgvHDBanHang.Columns[0].HeaderText = "Mã hàng";
            dgvHDBanHang.Columns[1].HeaderText = "Tên hàng";
            dgvHDBanHang.Columns[2].HeaderText = "Số lượng";
            dgvHDBanHang.Columns[3].HeaderText = "Đơn giá";
            dgvHDBanHang.Columns[4].HeaderText = "Thành tiền";
            dgvHDBanHang.Columns[0].Width = 90;
            dgvHDBanHang.Columns[1].Width = 150;
            dgvHDBanHang.Columns[2].Width = 70;
            dgvHDBanHang.Columns[3].Width = 110;
            dgvHDBanHang.Columns[4].Width = 170;
            dgvHDBanHang.AllowUserToAddRows = false;
            dgvHDBanHang.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            ResetValuesHang();
            if (cboMaHDB.Text == "")
            {
                MessageBox.Show("Bạn phải chọn một mã hóa đơn để tìm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboMaHDB.Focus();
                return;
            }
            txtMaHDBan.Text = cboMaHDB.Text;
            LoadInfoHoaDon();
            LoadDataGridView();
            btnThem.Enabled = true;
            btnXoa.Enabled = true;
            btnLuu.Enabled = true;
            btnReset.Enabled = true;
            btnLuu.Enabled = false;
            cboMaHDB.SelectedIndex = -1;
            if (!Mainform.isManager)
            {
                btnXoa.Enabled = false;
            }
        }

        private void ResetValues()
        {
            txtMaHDBan.Text = "";
            dtpNgayBan.Value = DateTime.Now;
            cboMaNV.SelectedIndex = -1;
            cboMaKhach.SelectedIndex = -1;
            txtTongTien.Text = "0";
            cboMaHang.SelectedIndex = -1;
            txtSoLuong.Text = "";
            txtThanhTien.Text = "0";
            txtTenHang.Text = "";
            txtDonGiaBan.Text = "";

            if (!Mainform.isManager)
            {
                btnXoa.Enabled = false;
            }
        }

        private void ResetValuesHang()
        {
            cboMaHang.SelectedIndex = -1;
            txtSoLuong.Text = "";
            txtThanhTien.Text = "0";
            txtTenHang.Text = "";
            txtDonGiaBan.Text = "";

            if (!Mainform.isManager)
            {
                btnXoa.Enabled = false;
            }
        }

        private void LoadInfoHoaDon()
        {
            string str;
            str = "SELECT NgayBan FROM Xuat WHERE MaDBH = N'" + txtMaHDBan.Text + "'";
            dtpNgayBan.Value = DateTime.Parse(Functions.GetFieldValues(str));
            str = "SELECT MaNV FROM Xuat WHERE MaDBH = N'" + txtMaHDBan.Text + "'";
            cboMaNV.SelectedValue = Functions.GetFieldValues(str);
            str = "SELECT MaKH FROM Xuat WHERE MaDBH = N'" + txtMaHDBan.Text + "'";
            cboMaKhach.SelectedValue = Functions.GetFieldValues(str);
            str = "SELECT Tong FROM Xuat WHERE MaDBH = N'" + txtMaHDBan.Text + "'";
            txtTongTien.Text = Functions.GetFieldValues(str);

            if (!Mainform.isManager)
            {
                btnXoa.Enabled = false;
            }
        }

        private void cboMaHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            string str;
            if (cboMaHang.Text == "")
            {
                txtTenHang.Text = "";
                txtDonGiaBan.Text = "";
            }
            // Khi chọn mã hàng thì các thông tin về hàng hiện ra
            str = "SELECT TenHang FROM Hang WHERE MaHH =N'" + cboMaHang.SelectedValue + "'";
            txtTenHang.Text = Functions.GetFieldValues(str);
            str = "SELECT DonGiaBan FROM Hang WHERE MaHH =N'" + cboMaHang.SelectedValue + "'";
            txtDonGiaBan.Text = Functions.GetFieldValues(str);

            if (!Mainform.isManager)
            {
                btnXoa.Enabled = false;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnXoa.Enabled = false;
            btnLuu.Enabled = true;
            btnReset.Enabled = true;
            btnThem.Enabled = false;
            btnTimKiem.Enabled = false;
            ResetValues();
            txtMaHDBan.Enabled = true;
            LoadDataGridView();

            if (!Mainform.isManager)
            {
                btnXoa.Enabled = false;
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql;
            double sl, SLcon, tong, Tongmoi;
            sql = "SELECT MaHDBan FROM HoaDonBan WHERE MaHDBan=N'" + txtMaHDBan.Text + "'";

            if (txtMaHDBan.Text.Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã hóa đơn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaHDBan.Focus();
                return;
            }
            if (cboMaKhach.Text.Length == 0)
            {
                MessageBox.Show("Bạn phải nhập khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboMaNV.Focus();
                return;
            }
            if (cboMaNV.Text.Length == 0)
            {
                MessageBox.Show("Bạn phải nhập nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboMaKhach.Focus();
                return;
            }
            sql = "INSERT INTO Xuat(MaDBH,MaKH,MaNV,Tong,NgayBan) VALUES ('" + txtMaHDBan.Text.Trim() + "','" + cboMaKhach.Text.Trim() + "','" + cboMaNV.Text.Trim() + "','" + txtTongTien.Text.Trim() + "','" + dtpNgayBan.Value.ToString() + "')";

            Functions.RunSql(sql);
            // Lưu thông tin của các mặt hàng
            if (cboMaHang.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboMaHang.Focus();
                return;
            }
            if ((txtSoLuong.Text.Trim().Length == 0) || (txtSoLuong.Text == "0"))
            {
                MessageBox.Show("Bạn phải nhập số lượng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSoLuong.Text = "";
                txtSoLuong.Focus();
                return;
            }
            // Kiểm tra xem số lượng hàng còn đủ để cung cấp không?
            sl = Convert.ToDouble(Functions.GetFieldValues("SELECT SoLuong FROM Hang WHERE MaHH = '" + cboMaHang.SelectedValue + "'"));
            if (Convert.ToDouble(txtSoLuong.Text) > sl)
            {
                MessageBox.Show("Số lượng mặt hàng này chỉ còn " + sl, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSoLuong.Text = "";
                txtSoLuong.Focus();
                return;
            }

            sql = "INSERT INTO Xuat_ChiTiet(MaDBH,MaHH,SoLuongBan,ThanhTien) VALUES('" + txtMaHDBan.Text.Trim() + "',N'" + cboMaHang.SelectedValue + "'," + txtSoLuong.Text + "," + txtThanhTien.Text + ")";
            Functions.RunSql(sql);
            LoadDataGridView();
            //// Cập nhật lại số lượng của mặt hàng vào bảng Hang
            //SLcon = sl - Convert.ToDouble(txtSoLuong.Text);
            //sql = "UPDATE Hang SET SoLuong =" + SLcon + " WHERE MaHH= '" + cboMaHang.SelectedValue + "'";
            //Functions.RunSql(sql);
            // Cập nhật lại tổng tiền cho hóa đơn bán
            //tong = Convert.ToDouble(Functions.GetFieldValues("SELECT Tong FROM Xuat WHERE MaDBH = '" + txtMaHDBan.Text + "'"));
            //Tongmoi = tong + Convert.ToDouble(txtThanhTien.Text);
            //sql = "UPDATE Xuat SET Tong =" + Tongmoi + " WHERE MaDBH = '" + txtMaHDBan.Text + "'";
            //Functions.RunSql(sql);

            ResetValuesHang();
            btnXoa.Enabled = true;
            btnThem.Enabled = true;

            if (!Mainform.isManager)
            {
                btnXoa.Enabled = false;
            }

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            double sl, slcon, sldele;
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string sql = "SELECT MaHH,SoLuongBan FROM Xuat_ChiTiet WHERE MaDBH = N'" + txtMaHDBan.Text + "'";
                DataTable tblHang = Functions.GetDataToTable(sql);
                for (int hang = 0; hang <= tblHang.Rows.Count - 1; hang++)
                {
                    // Cập nhật lại số lượng cho các mặt hàng
                    sl = Convert.ToDouble(Functions.GetFieldValues("SELECT SoLuong FROM Hang WHERE MaHH = N'" + tblHang.Rows[hang][0].ToString() + "'"));
                    sldele = Convert.ToDouble(tblHang.Rows[hang][1].ToString());
                    slcon = sl + sldele;
                    sql = "UPDATE Hang SET SoLuong =" + slcon + " WHERE MaHH= N'" + tblHang.Rows[hang][0].ToString() + "'";
                    Functions.RunSql(sql);
                }

                //Xóa chi tiết hóa đơn
                sql = "DELETE Xuat_ChiTiet WHERE MaDBH=N'" + txtMaHDBan.Text + "'";
                Functions.RunSql(sql);

                //Xóa hóa đơn
                sql = "DELETE Xuat WHERE MaDBH=N'" + txtMaHDBan.Text + "'";
                Functions.RunSql(sql);
                ResetValues();
                LoadDataGridView();
                btnXoa.Enabled = false;
            }
            if (!Mainform.isManager)
            {
                btnXoa.Enabled = false;
            }
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtSoLuong_TextChanged(object sender, EventArgs e)
        {
            //Khi thay đổi số lượng thì  tính lại thành tiền
            double ttien, sluong, dg;
            if (txtSoLuong.Text == "")
                sluong = 0;
            else
                sluong = Convert.ToDouble(txtSoLuong.Text);
            if (txtDonGiaBan.Text == "")
                dg = 0;
            else
                dg = Convert.ToDouble(txtDonGiaBan.Text);
            ttien = sluong * dg;
            txtThanhTien.Text = ttien.ToString();
        }
        //Phương thức này cập nhật lại danh sách các mã hóa đơn bán và lưu vào cboMaHDBan mỗi khi người dùng nháy chuột vào nút đổ xuống của cbo.
        private void cboMaHDBan_DropDown(object sender, EventArgs e)
        {
            Functions.FillCombo("SELECT MaDBH FROM Xuat", cboMaHDB, "MaDBH", "MaDBH");
            cboMaHDB.SelectedIndex = -1;
        }

        private void dgvHDBanHang_DoubleClick(object sender, EventArgs e)
        {
            string MaHangmx, sql;
            Double ThanhTienmx, SoLuongmx, sl, slcon, tong, tongmoi;
            if (tblHDB.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if ((MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
            {
                //Xóa hàng và cập nhật lại số lượng hàng 
                MaHangmx = dgvHDBanHang.CurrentRow.Cells["MaHH"].Value.ToString();
                SoLuongmx = Convert.ToDouble(dgvHDBanHang.CurrentRow.Cells["SoLuongBan"].Value.ToString());
                ThanhTienmx = Convert.ToDouble(dgvHDBanHang.CurrentRow.Cells["ThanhTien"].Value.ToString());
                sql = "DELETE Xuat_ChiTiet WHERE MaDBH=N'" + txtMaHDBan.Text + "' AND MaHH = N'" + MaHangmx + "'";
                Functions.RunSql(sql);
                // Cập nhật lại số lượng cho các mặt hàng
                sl = Convert.ToDouble(Functions.GetFieldValues("SELECT SoLuong FROM Hang WHERE MaHH = N'" + MaHangmx + "'"));
                slcon = sl + SoLuongmx;
                sql = "UPDATE Hang SET SoLuong =" + slcon + " WHERE MaHH= N'" + MaHangmx + "'";
                Functions.RunSql(sql);
                // Cập nhật lại tổng tiền cho hóa đơn bán
                tong = Convert.ToDouble(Functions.GetFieldValues("SELECT Tong FROM Xuat WHERE MaDBH = N'" + txtMaHDBan.Text + "'"));
                tongmoi = tong - ThanhTienmx;
                sql = "UPDATE Xuat SET Tong =" + tongmoi + " WHERE MaDBH = N'" + txtMaHDBan.Text + "'";
                Functions.RunSql(sql);
                txtTongTien.Text = tongmoi.ToString();
                LoadDataGridView();
            }
            if (!Mainform.isManager)
            {
                btnXoa.Enabled = false;
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetValues();
            btnReset.Enabled = false;
            btnThem.Enabled = true;
            btnXoa.Enabled = true;
            btnTimKiem.Enabled = true;
            btnLuu.Enabled = false;
            txtMaHDBan.Enabled = false;
            LoadDataGridView();
            if (!Mainform.isManager)
            {
                btnXoa.Enabled = false;
            }
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

    }
}
