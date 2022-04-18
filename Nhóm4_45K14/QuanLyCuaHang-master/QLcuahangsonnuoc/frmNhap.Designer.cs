namespace QLcuahangsonnuoc
{
    partial class frmNhap
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
            this.lbl_HoaDonNhap = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_MaDNH = new System.Windows.Forms.TextBox();
            this.lbl_MaNhanVien = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.splitContainer4 = new System.Windows.Forms.SplitContainer();
            this.dtp_NgayNhap = new System.Windows.Forms.DateTimePicker();
            this.txt_ChietKhau = new System.Windows.Forms.NumericUpDown();
            this.cmb_MaNCC = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmb_MaNV = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_DonGia = new System.Windows.Forms.NumericUpDown();
            this.txt_Tong = new System.Windows.Forms.NumericUpDown();
            this.txt_ThanhTien = new System.Windows.Forms.NumericUpDown();
            this.txt_SoLuong = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cmb_MaHang = new System.Windows.Forms.ComboBox();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.splitContainer6 = new System.Windows.Forms.SplitContainer();
            this.dtp_TimKiemTheoNgay = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_XoaTimKiem = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_Them = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Luu = new System.Windows.Forms.Button();
            this.btn_QuayLai = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Reset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).BeginInit();
            this.splitContainer4.Panel1.SuspendLayout();
            this.splitContainer4.Panel2.SuspendLayout();
            this.splitContainer4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_ChietKhau)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_DonGia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Tong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_ThanhTien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_SoLuong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer6)).BeginInit();
            this.splitContainer6.Panel1.SuspendLayout();
            this.splitContainer6.Panel2.SuspendLayout();
            this.splitContainer6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_HoaDonNhap
            // 
            this.lbl_HoaDonNhap.AutoSize = true;
            this.lbl_HoaDonNhap.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lbl_HoaDonNhap.Location = new System.Drawing.Point(269, 9);
            this.lbl_HoaDonNhap.Name = "lbl_HoaDonNhap";
            this.lbl_HoaDonNhap.Size = new System.Drawing.Size(285, 32);
            this.lbl_HoaDonNhap.TabIndex = 0;
            this.lbl_HoaDonNhap.Text = "HÓA ĐƠN NHẬP HÀNG";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label2.Location = new System.Drawing.Point(16, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã Đơn Nhập Hàng";
            // 
            // txt_MaDNH
            // 
            this.txt_MaDNH.Location = new System.Drawing.Point(163, 13);
            this.txt_MaDNH.Name = "txt_MaDNH";
            this.txt_MaDNH.Size = new System.Drawing.Size(235, 20);
            this.txt_MaDNH.TabIndex = 2;
            this.txt_MaDNH.TextChanged += new System.EventHandler(this.txt_MaDNH_TextChanged);
            // 
            // lbl_MaNhanVien
            // 
            this.lbl_MaNhanVien.AutoSize = true;
            this.lbl_MaNhanVien.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MaNhanVien.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lbl_MaNhanVien.Location = new System.Drawing.Point(16, 48);
            this.lbl_MaNhanVien.Name = "lbl_MaNhanVien";
            this.lbl_MaNhanVien.Size = new System.Drawing.Size(97, 16);
            this.lbl_MaNhanVien.TabIndex = 3;
            this.lbl_MaNhanVien.Text = "Mã Nhân Viên";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label4.Location = new System.Drawing.Point(16, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Ngày Nhập";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label5.Location = new System.Drawing.Point(10, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Mã Hàng";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label6.Location = new System.Drawing.Point(10, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "Số Lượng";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label8.Location = new System.Drawing.Point(10, 111);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 16);
            this.label8.TabIndex = 11;
            this.label8.Text = "Thành Tiền";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer3);
            this.splitContainer1.Size = new System.Drawing.Size(836, 628);
            this.splitContainer1.SplitterDistance = 244;
            this.splitContainer1.TabIndex = 21;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.lbl_HoaDonNhap);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.splitContainer4);
            this.splitContainer2.Size = new System.Drawing.Size(836, 244);
            this.splitContainer2.SplitterDistance = 49;
            this.splitContainer2.TabIndex = 1;
            // 
            // splitContainer4
            // 
            this.splitContainer4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer4.Location = new System.Drawing.Point(0, 0);
            this.splitContainer4.Name = "splitContainer4";
            // 
            // splitContainer4.Panel1
            // 
            this.splitContainer4.Panel1.Controls.Add(this.dtp_NgayNhap);
            this.splitContainer4.Panel1.Controls.Add(this.txt_ChietKhau);
            this.splitContainer4.Panel1.Controls.Add(this.cmb_MaNCC);
            this.splitContainer4.Panel1.Controls.Add(this.label7);
            this.splitContainer4.Panel1.Controls.Add(this.cmb_MaNV);
            this.splitContainer4.Panel1.Controls.Add(this.label9);
            this.splitContainer4.Panel1.Controls.Add(this.txt_MaDNH);
            this.splitContainer4.Panel1.Controls.Add(this.label4);
            this.splitContainer4.Panel1.Controls.Add(this.label2);
            this.splitContainer4.Panel1.Controls.Add(this.lbl_MaNhanVien);
            // 
            // splitContainer4.Panel2
            // 
            this.splitContainer4.Panel2.Controls.Add(this.txt_DonGia);
            this.splitContainer4.Panel2.Controls.Add(this.txt_Tong);
            this.splitContainer4.Panel2.Controls.Add(this.txt_ThanhTien);
            this.splitContainer4.Panel2.Controls.Add(this.txt_SoLuong);
            this.splitContainer4.Panel2.Controls.Add(this.label1);
            this.splitContainer4.Panel2.Controls.Add(this.label10);
            this.splitContainer4.Panel2.Controls.Add(this.cmb_MaHang);
            this.splitContainer4.Panel2.Controls.Add(this.label5);
            this.splitContainer4.Panel2.Controls.Add(this.label6);
            this.splitContainer4.Panel2.Controls.Add(this.label8);
            this.splitContainer4.Size = new System.Drawing.Size(836, 191);
            this.splitContainer4.SplitterDistance = 423;
            this.splitContainer4.TabIndex = 0;
            // 
            // dtp_NgayNhap
            // 
            this.dtp_NgayNhap.Location = new System.Drawing.Point(163, 111);
            this.dtp_NgayNhap.Name = "dtp_NgayNhap";
            this.dtp_NgayNhap.Size = new System.Drawing.Size(235, 20);
            this.dtp_NgayNhap.TabIndex = 18;
            // 
            // txt_ChietKhau
            // 
            this.txt_ChietKhau.DecimalPlaces = 2;
            this.txt_ChietKhau.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.txt_ChietKhau.Location = new System.Drawing.Point(163, 147);
            this.txt_ChietKhau.Maximum = new decimal(new int[] {
            -1486618624,
            232830643,
            0,
            0});
            this.txt_ChietKhau.Name = "txt_ChietKhau";
            this.txt_ChietKhau.Size = new System.Drawing.Size(235, 20);
            this.txt_ChietKhau.TabIndex = 21;
            this.txt_ChietKhau.ThousandsSeparator = true;
            this.txt_ChietKhau.ValueChanged += new System.EventHandler(this.txtSoLuong_TextChanged);
            // 
            // cmb_MaNCC
            // 
            this.cmb_MaNCC.FormattingEnabled = true;
            this.cmb_MaNCC.Location = new System.Drawing.Point(163, 78);
            this.cmb_MaNCC.Name = "cmb_MaNCC";
            this.cmb_MaNCC.Size = new System.Drawing.Size(235, 21);
            this.cmb_MaNCC.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label7.Location = new System.Drawing.Point(16, 81);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 16);
            this.label7.TabIndex = 16;
            this.label7.Text = "Mã NCC";
            // 
            // cmb_MaNV
            // 
            this.cmb_MaNV.FormattingEnabled = true;
            this.cmb_MaNV.Location = new System.Drawing.Point(163, 45);
            this.cmb_MaNV.Name = "cmb_MaNV";
            this.cmb_MaNV.Size = new System.Drawing.Size(235, 21);
            this.cmb_MaNV.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label9.Location = new System.Drawing.Point(16, 147);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 16);
            this.label9.TabIndex = 16;
            this.label9.Text = "Chiết Khấu ";
            // 
            // txt_DonGia
            // 
            this.txt_DonGia.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txt_DonGia.InterceptArrowKeys = false;
            this.txt_DonGia.Location = new System.Drawing.Point(119, 46);
            this.txt_DonGia.Maximum = new decimal(new int[] {
            -727379968,
            232,
            0,
            0});
            this.txt_DonGia.Name = "txt_DonGia";
            this.txt_DonGia.ReadOnly = true;
            this.txt_DonGia.Size = new System.Drawing.Size(260, 20);
            this.txt_DonGia.TabIndex = 21;
            // 
            // txt_Tong
            // 
            this.txt_Tong.Location = new System.Drawing.Point(119, 145);
            this.txt_Tong.Maximum = new decimal(new int[] {
            -1486618624,
            232830643,
            0,
            0});
            this.txt_Tong.Name = "txt_Tong";
            this.txt_Tong.ReadOnly = true;
            this.txt_Tong.Size = new System.Drawing.Size(260, 20);
            this.txt_Tong.TabIndex = 21;
            // 
            // txt_ThanhTien
            // 
            this.txt_ThanhTien.Location = new System.Drawing.Point(119, 111);
            this.txt_ThanhTien.Maximum = new decimal(new int[] {
            -1981284352,
            -1966660860,
            0,
            0});
            this.txt_ThanhTien.Name = "txt_ThanhTien";
            this.txt_ThanhTien.ReadOnly = true;
            this.txt_ThanhTien.Size = new System.Drawing.Size(260, 20);
            this.txt_ThanhTien.TabIndex = 21;
            this.txt_ThanhTien.ValueChanged += new System.EventHandler(this.txtSoLuong_TextChanged);
            // 
            // txt_SoLuong
            // 
            this.txt_SoLuong.Location = new System.Drawing.Point(119, 78);
            this.txt_SoLuong.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.txt_SoLuong.Name = "txt_SoLuong";
            this.txt_SoLuong.Size = new System.Drawing.Size(260, 20);
            this.txt_SoLuong.TabIndex = 21;
            this.txt_SoLuong.ValueChanged += new System.EventHandler(this.txtSoLuong_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label1.Location = new System.Drawing.Point(10, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 16);
            this.label1.TabIndex = 19;
            this.label1.Text = "Đơn Giá";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label10.Location = new System.Drawing.Point(10, 145);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 16);
            this.label10.TabIndex = 18;
            this.label10.Text = "Tổng";
            // 
            // cmb_MaHang
            // 
            this.cmb_MaHang.FormattingEnabled = true;
            this.cmb_MaHang.Location = new System.Drawing.Point(119, 9);
            this.cmb_MaHang.Name = "cmb_MaHang";
            this.cmb_MaHang.Size = new System.Drawing.Size(260, 21);
            this.cmb_MaHang.TabIndex = 15;
            this.cmb_MaHang.SelectedIndexChanged += new System.EventHandler(this.cmb_MaHang_SelectedIndexChanged);
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.splitContainer6);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.flowLayoutPanel1);
            this.splitContainer3.Size = new System.Drawing.Size(836, 380);
            this.splitContainer3.SplitterDistance = 317;
            this.splitContainer3.TabIndex = 16;
            // 
            // splitContainer6
            // 
            this.splitContainer6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer6.Location = new System.Drawing.Point(0, 0);
            this.splitContainer6.Name = "splitContainer6";
            this.splitContainer6.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer6.Panel1
            // 
            this.splitContainer6.Panel1.Controls.Add(this.dtp_TimKiemTheoNgay);
            this.splitContainer6.Panel1.Controls.Add(this.label3);
            this.splitContainer6.Panel1.Controls.Add(this.btn_XoaTimKiem);
            // 
            // splitContainer6.Panel2
            // 
            this.splitContainer6.Panel2.Controls.Add(this.dataGridView1);
            this.splitContainer6.Size = new System.Drawing.Size(836, 317);
            this.splitContainer6.SplitterDistance = 46;
            this.splitContainer6.TabIndex = 18;
            // 
            // dtp_TimKiemTheoNgay
            // 
            this.dtp_TimKiemTheoNgay.Location = new System.Drawing.Point(163, 10);
            this.dtp_TimKiemTheoNgay.Name = "dtp_TimKiemTheoNgay";
            this.dtp_TimKiemTheoNgay.Size = new System.Drawing.Size(527, 20);
            this.dtp_TimKiemTheoNgay.TabIndex = 16;
            this.dtp_TimKiemTheoNgay.ValueChanged += new System.EventHandler(this.dtp_TimKiemTheoNgay_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label3.Location = new System.Drawing.Point(12, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 16);
            this.label3.TabIndex = 17;
            this.label3.Text = "Tìm Kiếm Theo Ngày ";
            // 
            // btn_XoaTimKiem
            // 
            this.btn_XoaTimKiem.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_XoaTimKiem.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_XoaTimKiem.Location = new System.Drawing.Point(696, 7);
            this.btn_XoaTimKiem.Name = "btn_XoaTimKiem";
            this.btn_XoaTimKiem.Size = new System.Drawing.Size(110, 25);
            this.btn_XoaTimKiem.TabIndex = 29;
            this.btn_XoaTimKiem.Text = "Xóa Tìm Kiếm";
            this.btn_XoaTimKiem.UseVisualStyleBackColor = true;
            this.btn_XoaTimKiem.Click += new System.EventHandler(this.btn_XoaTimKiem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Default;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(836, 267);
            this.dataGridView1.TabIndex = 15;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btn_Them);
            this.flowLayoutPanel1.Controls.Add(this.btn_Xoa);
            this.flowLayoutPanel1.Controls.Add(this.btn_Luu);
            this.flowLayoutPanel1.Controls.Add(this.btn_QuayLai);
            this.flowLayoutPanel1.Controls.Add(this.btn_Sua);
            this.flowLayoutPanel1.Controls.Add(this.btn_Reset);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(70, 8, 8, 8);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(836, 59);
            this.flowLayoutPanel1.TabIndex = 18;
            // 
            // btn_Them
            // 
            this.btn_Them.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Them.Location = new System.Drawing.Point(73, 11);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(110, 33);
            this.btn_Them.TabIndex = 16;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Xoa.Location = new System.Drawing.Point(189, 11);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(110, 33);
            this.btn_Xoa.TabIndex = 18;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Luu
            // 
            this.btn_Luu.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Luu.Location = new System.Drawing.Point(305, 11);
            this.btn_Luu.Name = "btn_Luu";
            this.btn_Luu.Size = new System.Drawing.Size(110, 33);
            this.btn_Luu.TabIndex = 19;
            this.btn_Luu.Text = "Lưu ";
            this.btn_Luu.UseVisualStyleBackColor = true;
            this.btn_Luu.Click += new System.EventHandler(this.btn_Luu_Click);
            // 
            // btn_QuayLai
            // 
            this.btn_QuayLai.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_QuayLai.Location = new System.Drawing.Point(421, 11);
            this.btn_QuayLai.Name = "btn_QuayLai";
            this.btn_QuayLai.Size = new System.Drawing.Size(110, 33);
            this.btn_QuayLai.TabIndex = 20;
            this.btn_QuayLai.Text = "Quay Lại";
            this.btn_QuayLai.UseVisualStyleBackColor = true;
            this.btn_QuayLai.Click += new System.EventHandler(this.btn_QuayLai_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.Enabled = false;
            this.btn_Sua.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sua.Location = new System.Drawing.Point(537, 11);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(110, 33);
            this.btn_Sua.TabIndex = 17;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = true;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Reset
            // 
            this.btn_Reset.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_Reset.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_Reset.Location = new System.Drawing.Point(653, 11);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(110, 33);
            this.btn_Reset.TabIndex = 29;
            this.btn_Reset.Text = "Reset";
            this.btn_Reset.UseVisualStyleBackColor = true;
            this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click);
            // 
            // frmNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(836, 628);
            this.Controls.Add(this.splitContainer1);
            this.Name = "frmNhap";
            this.Text = "frmNhap";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.splitContainer4.Panel1.ResumeLayout(false);
            this.splitContainer4.Panel1.PerformLayout();
            this.splitContainer4.Panel2.ResumeLayout(false);
            this.splitContainer4.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).EndInit();
            this.splitContainer4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txt_ChietKhau)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_DonGia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Tong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_ThanhTien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_SoLuong)).EndInit();
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.splitContainer6.Panel1.ResumeLayout(false);
            this.splitContainer6.Panel1.PerformLayout();
            this.splitContainer6.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer6)).EndInit();
            this.splitContainer6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_HoaDonNhap;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_MaDNH;
        private System.Windows.Forms.Label lbl_MaNhanVien;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.SplitContainer splitContainer4;
        private System.Windows.Forms.ComboBox cmb_MaNV;
        private System.Windows.Forms.ComboBox cmb_MaHang;
        private System.Windows.Forms.ComboBox cmb_MaNCC;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtp_NgayNhap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown txt_SoLuong;
        private System.Windows.Forms.NumericUpDown txt_DonGia;
        private System.Windows.Forms.NumericUpDown txt_ThanhTien;
        private System.Windows.Forms.NumericUpDown txt_Tong;
        private System.Windows.Forms.NumericUpDown txt_ChietKhau;
        private System.Windows.Forms.SplitContainer splitContainer6;
        private System.Windows.Forms.DateTimePicker dtp_TimKiemTheoNgay;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_XoaTimKiem;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Luu;
        private System.Windows.Forms.Button btn_QuayLai;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Reset;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}