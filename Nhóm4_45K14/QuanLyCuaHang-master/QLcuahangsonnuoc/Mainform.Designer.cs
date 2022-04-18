namespace QLcuahangsonnuoc
{
    partial class Mainform
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuDanhMục = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuKhachHang = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNhanVien = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHangHoa = new System.Windows.Forms.ToolStripMenuItem();
            this.nhàCungCấpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hoaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHoaDonBan = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHoaDonNhap = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblThongBao = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuDanhMục,
            this.hoaToolStripMenuItem,
            this.thoátToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(838, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuDanhMục
            // 
            this.mnuDanhMục.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuKhachHang,
            this.mnuNhanVien,
            this.mnuHangHoa,
            this.nhàCungCấpToolStripMenuItem});
            this.mnuDanhMục.Name = "mnuDanhMục";
            this.mnuDanhMục.Size = new System.Drawing.Size(74, 20);
            this.mnuDanhMục.Text = "Danh Mục";
            // 
            // mnuKhachHang
            // 
            this.mnuKhachHang.Name = "mnuKhachHang";
            this.mnuKhachHang.Size = new System.Drawing.Size(152, 22);
            this.mnuKhachHang.Text = "Khách Hàng";
            this.mnuKhachHang.Click += new System.EventHandler(this.mnuKhachHang_Click);
            // 
            // mnuNhanVien
            // 
            this.mnuNhanVien.Name = "mnuNhanVien";
            this.mnuNhanVien.Size = new System.Drawing.Size(152, 22);
            this.mnuNhanVien.Text = "Nhân Viên";
            this.mnuNhanVien.Click += new System.EventHandler(this.mnuNhanVien_Click);
            // 
            // mnuHangHoa
            // 
            this.mnuHangHoa.Name = "mnuHangHoa";
            this.mnuHangHoa.Size = new System.Drawing.Size(152, 22);
            this.mnuHangHoa.Text = "Hàng Hóa";
            this.mnuHangHoa.Click += new System.EventHandler(this.mnuHangHoa_Click);
            // 
            // nhàCungCấpToolStripMenuItem
            // 
            this.nhàCungCấpToolStripMenuItem.Name = "nhàCungCấpToolStripMenuItem";
            this.nhàCungCấpToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.nhàCungCấpToolStripMenuItem.Text = "Nhà Cung Cấp";
            this.nhàCungCấpToolStripMenuItem.Click += new System.EventHandler(this.nccToolStripMenuItem_Click);
            // 
            // hoaToolStripMenuItem
            // 
            this.hoaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuHoaDonBan,
            this.mnuHoaDonNhap});
            this.hoaToolStripMenuItem.Name = "hoaToolStripMenuItem";
            this.hoaToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.hoaToolStripMenuItem.Text = "Hóa Đơn";
            this.hoaToolStripMenuItem.Click += new System.EventHandler(this.hoaToolStripMenuItem_Click);
            // 
            // mnuHoaDonBan
            // 
            this.mnuHoaDonBan.Name = "mnuHoaDonBan";
            this.mnuHoaDonBan.Size = new System.Drawing.Size(153, 22);
            this.mnuHoaDonBan.Text = "Hóa Đơn Bán";
            this.mnuHoaDonBan.Click += new System.EventHandler(this.mnuHoaDonBan_Click);
            // 
            // mnuHoaDonNhap
            // 
            this.mnuHoaDonNhap.Name = "mnuHoaDonNhap";
            this.mnuHoaDonNhap.Size = new System.Drawing.Size(153, 22);
            this.mnuHoaDonNhap.Text = "Hóa Đơn Nhập";
            this.mnuHoaDonNhap.Click += new System.EventHandler(this.hóaĐơnNhậpToolStripMenuItem_Click);
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.thoátToolStripMenuItem.Text = "Thoát ";
            this.thoátToolStripMenuItem.Click += new System.EventHandler(this.thoátToolStripMenuItem_Click);
            // 
            // lblThongBao
            // 
            this.lblThongBao.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblThongBao.AutoSize = true;
            this.lblThongBao.Font = new System.Drawing.Font("Segoe UI Light", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThongBao.Location = new System.Drawing.Point(290, 145);
            this.lblThongBao.Name = "lblThongBao";
            this.lblThongBao.Size = new System.Drawing.Size(215, 65);
            this.lblThongBao.TabIndex = 1;
            this.lblThongBao.Text = "QUẢN LÝ";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(176, 210);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(443, 71);
            this.label1.TabIndex = 2;
            this.label1.Text = "CỬA HÀNG SƠN";
            // 
            // Mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(838, 469);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblThongBao);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Mainform";
            this.Text = "Mainform";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Mainform_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hoaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuHoaDonBan;
        private System.Windows.Forms.ToolStripMenuItem mnuHoaDonNhap;
        private System.Windows.Forms.ToolStripMenuItem mnuDanhMục;
        private System.Windows.Forms.ToolStripMenuItem mnuKhachHang;
        private System.Windows.Forms.ToolStripMenuItem mnuNhanVien;
        private System.Windows.Forms.ToolStripMenuItem mnuHangHoa;
        private System.Windows.Forms.ToolStripMenuItem nhàCungCấpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
        private System.Windows.Forms.Label lblThongBao;
        private System.Windows.Forms.Label label1;
    }
}

