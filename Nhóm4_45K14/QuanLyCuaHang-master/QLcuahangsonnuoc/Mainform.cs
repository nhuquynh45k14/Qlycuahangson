using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLcuahangsonnuoc
{
    public partial class Mainform : Form
    {

        public static bool isManager;

        public Mainform(bool isManager)
        {
            InitializeComponent();
            Mainform.isManager = isManager;
        }

        private void hoaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void hóaĐơnNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new frmNhap()).ShowDialog();
        }

        private void Mainform_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void mnuKhachHang_Click(object sender, EventArgs e)
        {
            (new frmKhachHang()).ShowDialog();
        }

        private void mnuNhanVien_Click(object sender, EventArgs e)
        {
            (new frmNguoiNH()).ShowDialog();
        }

        private void mnuHangHoa_Click(object sender, EventArgs e)
        {
            (new frmHang()).ShowDialog();
        }

        private void mnuHoaDonBan_Click(object sender, EventArgs e)
        {
            (new frmHoaDonBan()).ShowDialog();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void nccToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new frmNCC()).ShowDialog();
        }
        
    }
}
