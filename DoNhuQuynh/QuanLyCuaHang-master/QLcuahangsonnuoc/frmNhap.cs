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
    public partial class frmNhap : Form
    {
        DataSet dataSet = new DataSet("CDangIu"); //DataSet ảo 

        SqlDataAdapter dapNhap; //Kết nối bảng ở CSDL thật với DataSet ảo  
        SqlDataAdapter dapNhapChiTiet;

        public frmNhap()
        {
            InitializeComponent();

            dapNhap = Functions.GetDataAdapter("SELECT * FROM Nhap"); //Khởi tạo kết nối giữa CSDL thật với ảo 
            dapNhap.Fill(dataSet, "Nhap");
            dataGridView1.DataSource = dataSet.Tables["Nhap"]; //Hiển thị bảng Nhap lên DataGridView

            Functions.FillCombo("SELECT * FROM NhanVien", cmb_MaNV, "MaNV", "Mã Nhân Viên");
            Functions.FillCombo("SELECT * FROM NhaCungCap", cmb_MaNCC, "MaNCC", "Mã Nhà Cung Cấp");
            Functions.FillCombo("SELECT * FROM Hang", cmb_MaHang, "MaHH", "Mã Hàng Hoá");
            if (!Mainform.isManager)
            {
                btn_Sua.Enabled = false;
                btn_Xoa.Enabled = false;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txt_MaDNH.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mã Đơn Nhập Hàng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataRow newRow = dataSet.Tables["Nhap"].NewRow();
            newRow["MaDNH"] = txt_MaDNH.Text;
            newRow["MaNV"] = cmb_MaNV.Text;
            newRow["NgayNhap"] = dtp_NgayNhap.Value;
            newRow["Tong"] = int.Parse(txt_Tong.Text);

            double tongCong = int.Parse(txt_Tong.Text) * (1 - double.Parse(txt_ChietKhau.Text));
            newRow["TongCong"] = tongCong;
            newRow["MaNCC"] = cmb_MaNCC.Text;
            newRow["ChietKhau"] = double.Parse(txt_ChietKhau.Text);

            dataSet.Tables["Nhap"].Rows.Add(newRow); //Thêm row mới vào bảng Nhap 

            btn_Reset_Click(null, null);
            if (!Mainform.isManager)
            {
                btn_Sua.Enabled = false;
                btn_Xoa.Enabled = false;
            }
        }

        private void cmb_MaHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dataTable = new DataTable();
            Functions.GetDataAdapter(String.Format("SELECT * FROM Hang WHERE MaHH = '{0}'", cmb_MaHang.Text)).Fill(dataTable);

            if (dataTable.Rows.Count == 0)
                return;

            int donGia = (int)dataTable.Rows[0]["DonGiaNhap"];
            txt_DonGia.Text = donGia.ToString();

            DataRow[] foundedNhapChiTiet = dataSet.Tables["Nhap_ChiTiet"].Select(string.Format("MaHH = '{0}' AND MaDNH = '{1}'", dataTable.Rows[0]["MaHH"], txt_MaDNH.Text));

            if (foundedNhapChiTiet.Length != 0)
                txt_SoLuong.Value = decimal.Parse(foundedNhapChiTiet[0]["SoLuongNhap"].ToString());
            else
                txt_SoLuong.Value = 0;
            if (!Mainform.isManager)
            {
                btn_Sua.Enabled = false;
                btn_Xoa.Enabled = false;
            }
        }

        //Khi thay đổi số lượng thì thực hiện tính lại thành tiền và cập nhật lên bảng Nhap_ChiTiet
        private void txtSoLuong_TextChanged(object sender, EventArgs e)
        {
            int tt, sl, dg;
            sl = (int)txt_SoLuong.Value;
            dg = (int)txt_DonGia.Value;
            tt = sl * dg;
            txt_ThanhTien.Value = tt * (1 - txt_ChietKhau.Value);

            DataRow[] foundedRows = dataSet.Tables["Nhap_ChiTiet"].Select(string.Format("MaHH = '{0}'", cmb_MaHang.Text));

            if (sl == 0)
            {
                if (foundedRows.Length > 0)
                {
                    dataSet.Tables["Nhap_ChiTiet"].Rows.Remove(foundedRows[0]);
                    updateTong();
                }
                return;
            }

            DataRow updatingRow = null;
            if (foundedRows.Length == 0)
            {
                updatingRow = dataSet.Tables["Nhap_ChiTiet"].NewRow();
                updatingRow["MaDNH"] = txt_MaDNH.Text;
                updatingRow["MaHH"] = cmb_MaHang.Text;

                dataSet.Tables["Nhap_ChiTiet"].Rows.Add(updatingRow);
            }
            else
                updatingRow = foundedRows[0];

            updatingRow["SoLuongNhap"] = sl;
            updatingRow["ThanhTien"] = txt_ThanhTien.Value;

            updateTong();
            if (!Mainform.isManager)
            {
                btn_Sua.Enabled = false;
                btn_Xoa.Enabled = false;
            }
        }

        private void updateTong()
        {
            txt_Tong.Value = 0;
            foreach (DataRow row in dataSet.Tables["Nhap_ChiTiet"].Rows)
            {
                txt_Tong.Value += (int)row["ThanhTien"];
            }

            DataRow[] foundedRows = dataSet.Tables["Nhap"].Select(string.Format("MaDNH = '{0}'", txt_MaDNH.Text));
            if (foundedRows.Length > 0)
            {
                foundedRows[0]["MaDNH"] = txt_MaDNH.Text;
                foundedRows[0]["MaNV"] = cmb_MaNV.Text;
                foundedRows[0]["NgayNhap"] = dtp_NgayNhap.Value;
                foundedRows[0]["Tong"] = int.Parse(txt_Tong.Text);

                double tongCong = int.Parse(txt_Tong.Text) * (1 - double.Parse(txt_ChietKhau.Text));
                foundedRows[0]["TongCong"] = tongCong;
                foundedRows[0]["MaNCC"] = cmb_MaNCC.Text;
                foundedRows[0]["ChietKhau"] = double.Parse(txt_ChietKhau.Text);
            }
            if (!Mainform.isManager)
            {
                btn_Sua.Enabled = false;
                btn_Xoa.Enabled = false;
            }
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            txt_MaDNH.Text = "";
            cmb_MaHang.Text = "";
            txt_SoLuong.Value = 0;
            txt_ThanhTien.Value = 0;
            txt_Tong.Value = 0;
            cmb_MaNCC.Text = "";
            cmb_MaNV.Text = "";
            txt_ChietKhau.Value = 0;
            dtp_NgayNhap.Value = DateTime.Now;
            txt_DonGia.Value = 0;
            if (!Mainform.isManager)
            {
                btn_Sua.Enabled = false;
                btn_Xoa.Enabled = false;
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                removeRowInDataGridView(row);
            }
            if (!Mainform.isManager)
            {
                btn_Sua.Enabled = false;
                btn_Xoa.Enabled = false;
            }
        }

        private void removeRowInDataGridView(DataGridViewRow row)
        {
            string maDNH = row.Cells["MaDNH"].Value.ToString();
            getNhapChiTietTable(maDNH);

            foreach (DataRow need2DeleteNhapChiTiet in dataSet.Tables["Nhap_ChiTiet"].Rows)
                need2DeleteNhapChiTiet.Delete();

            DataRow need2DeleteNhapRow = dataSet.Tables["Nhap"].Select(string.Format("MaDNH = '{0}'", maDNH))[0];
            need2DeleteNhapRow.Delete();
            if (!Mainform.isManager)
            {
                btn_Sua.Enabled = false;
                btn_Xoa.Enabled = false;
            }
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            dapNhapChiTiet.Update(dataSet, "Nhap_ChiTiet");
            dapNhap.Update(dataSet, "Nhap");
            if (!Mainform.isManager)
            {
                btn_Sua.Enabled = false;
                btn_Xoa.Enabled = false;
            }
        }

        private void txt_MaDNH_TextChanged(object sender, EventArgs e)
        {
            getNhapChiTietTable(txt_MaDNH.Text);
            if (!Mainform.isManager)
            {
                btn_Sua.Enabled = false;
                btn_Xoa.Enabled = false;
            }
        }

        private void getNhapChiTietTable(string maDNH)
        {
            if (dataSet.Tables["Nhap_ChiTiet"] != null)
                dataSet.Tables["Nhap_ChiTiet"].Clear();

            dapNhapChiTiet = Functions.GetDataAdapter(string.Format("SELECT * FROM Nhap_ChiTiet WHERE MaDNH = '{0}'", maDNH));
            dapNhapChiTiet.Fill(dataSet, "Nhap_ChiTiet");
            if (!Mainform.isManager)
            {
                btn_Sua.Enabled = false;
                btn_Xoa.Enabled = false;
            }
        }

        private void btn_QuayLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dtp_TimKiemTheoNgay_ValueChanged(object sender, EventArgs e)
        {
            dataSet = new DataSet();
            dapNhap = Functions.GetDataAdapter(string.Format("SELECT * FROM Nhap WHERE DATEDIFF(DAY, NgayNhap, '{0}') = 0", dtp_TimKiemTheoNgay.Value.ToShortDateString()));
            dapNhap.Fill(dataSet, "Nhap");
            dataGridView1.DataSource = dataSet.Tables["Nhap"];
            if (!Mainform.isManager)
            {
                btn_Sua.Enabled = false;
                btn_Xoa.Enabled = false;
            }
        }

        private void btn_XoaTimKiem_Click(object sender, EventArgs e)
        {
            dtp_TimKiemTheoNgay.Value = DateTime.Now;

            dataSet = new DataSet();
            dapNhap = Functions.GetDataAdapter("SELECT * FROM Nhap");
            dapNhap.Fill(dataSet, "Nhap");
            dataGridView1.DataSource = dataSet.Tables["Nhap"];
            if (!Mainform.isManager)
            {
                btn_Sua.Enabled = false;
                btn_Xoa.Enabled = false;
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView1.SelectedRows[0];
            txt_MaDNH.Text = row.Cells["MaDNH"].Value.ToString();
            cmb_MaNV.Text = row.Cells["MaNV"].Value.ToString();
            cmb_MaNCC.Text = row.Cells["MaNCC"].Value.ToString();
            dtp_NgayNhap.Value = (DateTime)row.Cells["NgayNhap"].Value;
            txt_ChietKhau.Value = decimal.Parse(row.Cells["ChietKhau"].Value.ToString());
            if (!Mainform.isManager)
            {
                btn_Sua.Enabled = false;
                btn_Xoa.Enabled = false;
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btn_Sua.Enabled = true;
            if (!Mainform.isManager)
            {
                btn_Sua.Enabled = false;
                btn_Xoa.Enabled = false;
            }
        }
    }
}