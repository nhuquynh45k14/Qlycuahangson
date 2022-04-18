using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient; //Sử dụng thư viện để làm việc SQL server
using QLcuahangsonnuoc.Class;

namespace QLcuahangsonnuoc
{
    public partial class DangNhap : Form
    {
        DataSet dataSet = new DataSet("TaiKhoanCDangIu");
        SqlDataAdapter accountAdapter;

        public DangNhap()
        {
            InitializeComponent();
        }

        private void DangNhap_Load(object sender, EventArgs e)
        {
            accountAdapter = Functions.GetDataAdapter("SELECT * FROM TAIKHOAN");
            accountAdapter.Fill(dataSet, "TAIKHOAN");
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if ((txtTaiKhoan.Text == "") && (txtMatKhau.Text == ""))
            {
                MessageBox.Show("Chưa nhập tài khoản!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                DataRow[] foundedAccounts = dataSet.Tables["TAIKHOAN"].Select(string.Format("TaiKhoan = '{0}'", txtTaiKhoan.Text));
                if (foundedAccounts.Length == 0)
                {
                    MessageBox.Show("Không tìm thấy Tài Khoản này!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (foundedAccounts[0]["MatKhau"].ToString() != txtMatKhau.Text)
                {
                    MessageBox.Show("Sai mật khẩu!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Functions.Disconnect();
                Functions.Connect(foundedAccounts[0]["TaiKhoan"].ToString(), foundedAccounts[0]["MatKhau"].ToString());

                (new Mainform(foundedAccounts[0]["KieuTK"].ToString() == "1")).Show();
                this.Hide();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }
    }
}
