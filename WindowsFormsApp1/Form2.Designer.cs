namespace WindowsFormsApp1
{
    partial class Form2
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
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnThemLop = new System.Windows.Forms.Button();
            this.btnSuaLop = new System.Windows.Forms.Button();
            this.btnXoaLop = new System.Windows.Forms.Button();
            this.btnLamMoiLop = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtMaLop = new System.Windows.Forms.TextBox();
            this.txtTenLop = new System.Windows.Forms.TextBox();
            this.txtTimKiemLop = new System.Windows.Forms.TextBox();
            this.btnTimKiemLop = new System.Windows.Forms.Button();
            this.dgvLopHoc = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnThem = new System.Windows.Forms.Button();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDiem = new System.Windows.Forms.TextBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cbbLop = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.radNam = new System.Windows.Forms.RadioButton();
            this.dgvSinhVien = new System.Windows.Forms.DataGridView();
            this.radNu = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTrangTruoc = new System.Windows.Forms.Button();
            this.btnTrangSau = new System.Windows.Forms.Button();
            this.lblTrang = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLopHoc)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSinhVien)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.button4);
            this.tabPage2.Controls.Add(this.button5);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.dgvLopHoc);
            this.tabPage2.Controls.Add(this.btnTimKiemLop);
            this.tabPage2.Controls.Add(this.txtTimKiemLop);
            this.tabPage2.Controls.Add(this.txtTenLop);
            this.tabPage2.Controls.Add(this.txtMaLop);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.btnLamMoiLop);
            this.tabPage2.Controls.Add(this.btnXoaLop);
            this.tabPage2.Controls.Add(this.btnSuaLop);
            this.tabPage2.Controls.Add(this.btnThemLop);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(1180, 487);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "QLLH";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 16);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "Mã lớp";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 68);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 16);
            this.label8.TabIndex = 1;
            this.label8.Text = "Tên Lớp";
            // 
            // btnThemLop
            // 
            this.btnThemLop.Location = new System.Drawing.Point(25, 144);
            this.btnThemLop.Margin = new System.Windows.Forms.Padding(4);
            this.btnThemLop.Name = "btnThemLop";
            this.btnThemLop.Size = new System.Drawing.Size(100, 28);
            this.btnThemLop.TabIndex = 4;
            this.btnThemLop.Text = "Thêm";
            this.btnThemLop.UseVisualStyleBackColor = true;
            this.btnThemLop.Click += new System.EventHandler(this.btnThemLop_Click);
            // 
            // btnSuaLop
            // 
            this.btnSuaLop.Location = new System.Drawing.Point(163, 144);
            this.btnSuaLop.Margin = new System.Windows.Forms.Padding(4);
            this.btnSuaLop.Name = "btnSuaLop";
            this.btnSuaLop.Size = new System.Drawing.Size(100, 28);
            this.btnSuaLop.TabIndex = 5;
            this.btnSuaLop.Text = "Sửa";
            this.btnSuaLop.UseVisualStyleBackColor = true;
            this.btnSuaLop.Click += new System.EventHandler(this.btnSuaLop_Click);
            // 
            // btnXoaLop
            // 
            this.btnXoaLop.Location = new System.Drawing.Point(25, 202);
            this.btnXoaLop.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoaLop.Name = "btnXoaLop";
            this.btnXoaLop.Size = new System.Drawing.Size(100, 28);
            this.btnXoaLop.TabIndex = 6;
            this.btnXoaLop.Text = "Xoá";
            this.btnXoaLop.UseVisualStyleBackColor = true;
            this.btnXoaLop.Click += new System.EventHandler(this.btnXoaLop_Click);
            // 
            // btnLamMoiLop
            // 
            this.btnLamMoiLop.Location = new System.Drawing.Point(163, 202);
            this.btnLamMoiLop.Margin = new System.Windows.Forms.Padding(4);
            this.btnLamMoiLop.Name = "btnLamMoiLop";
            this.btnLamMoiLop.Size = new System.Drawing.Size(100, 28);
            this.btnLamMoiLop.TabIndex = 7;
            this.btnLamMoiLop.Text = "Làm mới";
            this.btnLamMoiLop.UseVisualStyleBackColor = true;
            this.btnLamMoiLop.Click += new System.EventHandler(this.btnLamMoiLop_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(311, 15);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(176, 16);
            this.label9.TabIndex = 8;
            this.label9.Text = "tìm kiếm theo mã/tên lớp học";
            // 
            // txtMaLop
            // 
            this.txtMaLop.Location = new System.Drawing.Point(25, 37);
            this.txtMaLop.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaLop.Name = "txtMaLop";
            this.txtMaLop.Size = new System.Drawing.Size(236, 22);
            this.txtMaLop.TabIndex = 2;
            // 
            // txtTenLop
            // 
            this.txtTenLop.Location = new System.Drawing.Point(25, 89);
            this.txtTenLop.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenLop.Name = "txtTenLop";
            this.txtTenLop.Size = new System.Drawing.Size(236, 22);
            this.txtTenLop.TabIndex = 3;
            // 
            // txtTimKiemLop
            // 
            this.txtTimKiemLop.Location = new System.Drawing.Point(315, 37);
            this.txtTimKiemLop.Margin = new System.Windows.Forms.Padding(4);
            this.txtTimKiemLop.Name = "txtTimKiemLop";
            this.txtTimKiemLop.Size = new System.Drawing.Size(403, 22);
            this.txtTimKiemLop.TabIndex = 9;
            // 
            // btnTimKiemLop
            // 
            this.btnTimKiemLop.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnTimKiemLop.Location = new System.Drawing.Point(740, 34);
            this.btnTimKiemLop.Margin = new System.Windows.Forms.Padding(4);
            this.btnTimKiemLop.Name = "btnTimKiemLop";
            this.btnTimKiemLop.Size = new System.Drawing.Size(100, 28);
            this.btnTimKiemLop.TabIndex = 10;
            this.btnTimKiemLop.Text = "Tìm kiếm";
            this.btnTimKiemLop.UseVisualStyleBackColor = false;
            this.btnTimKiemLop.Click += new System.EventHandler(this.btnTimKiemLop_Click);
            // 
            // dgvLopHoc
            // 
            this.dgvLopHoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLopHoc.Location = new System.Drawing.Point(315, 69);
            this.dgvLopHoc.Margin = new System.Windows.Forms.Padding(4);
            this.dgvLopHoc.Name = "dgvLopHoc";
            this.dgvLopHoc.RowHeadersWidth = 51;
            this.dgvLopHoc.Size = new System.Drawing.Size(525, 321);
            this.dgvLopHoc.TabIndex = 11;
            this.dgvLopHoc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLopHoc_CellClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(25, 264);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(238, 51);
            this.button1.TabIndex = 12;
            this.button1.Text = "Xem danh sách sinh viên lớp học";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnXemDSSV_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button5.Location = new System.Drawing.Point(315, 427);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 25;
            this.button5.Text = "<<";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button4.Location = new System.Drawing.Point(515, 427);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 26;
            this.button4.Text = ">>";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(426, 430);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 16);
            this.label11.TabIndex = 27;
            this.label11.Text = "trang 1/5";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lblTrang);
            this.tabPage1.Controls.Add(this.btnTrangSau);
            this.tabPage1.Controls.Add(this.btnTrangTruoc);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.radNu);
            this.tabPage1.Controls.Add(this.dgvSinhVien);
            this.tabPage1.Controls.Add(this.radNam);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.cbbLop);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.btnTimKiem);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.txtTimKiem);
            this.tabPage1.Controls.Add(this.txtId);
            this.tabPage1.Controls.Add(this.txtHoTen);
            this.tabPage1.Controls.Add(this.txtDiem);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.btnLamMoi);
            this.tabPage1.Controls.Add(this.btnXoa);
            this.tabPage1.Controls.Add(this.btnSua);
            this.tabPage1.Controls.Add(this.dtpNgaySinh);
            this.tabPage1.Controls.Add(this.btnThem);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(1180, 487);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "QLSV";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(23, 348);
            this.btnThem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(100, 28);
            this.btnThem.TabIndex = 11;
            this.btnThem.Text = "Them";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.Location = new System.Drawing.Point(24, 141);
            this.dtpNgaySinh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(237, 22);
            this.dtpNgaySinh.TabIndex = 10;
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(160, 348);
            this.btnSua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(100, 28);
            this.btnSua.TabIndex = 12;
            this.btnSua.Text = "Sua";
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(23, 414);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(100, 28);
            this.btnXoa.TabIndex = 13;
            this.btnXoa.Text = "Xoa";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Location = new System.Drawing.Point(160, 414);
            this.btnLamMoi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(100, 28);
            this.btnLamMoi.TabIndex = 14;
            this.btnLamMoi.Text = "Lam Moi";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(311, 15);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(165, 16);
            this.label6.TabIndex = 15;
            this.label6.Text = "Search theo Tên/mssv/lớp";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 255);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Diem";
            // 
            // txtDiem
            // 
            this.txtDiem.Location = new System.Drawing.Point(23, 282);
            this.txtDiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDiem.Name = "txtDiem";
            this.txtDiem.Size = new System.Drawing.Size(237, 22);
            this.txtDiem.TabIndex = 9;
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(24, 89);
            this.txtHoTen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(236, 22);
            this.txtHoTen.TabIndex = 7;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(25, 37);
            this.txtId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(236, 22);
            this.txtId.TabIndex = 6;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(314, 38);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(4);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(403, 22);
            this.txtTimKiem.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Lop";
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnTimKiem.Location = new System.Drawing.Point(995, 38);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(4);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(100, 28);
            this.btnTimKiem.TabIndex = 18;
            this.btnTimKiem.Text = "Tìm Kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = false;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ngay Sinh";
            // 
            // cbbLop
            // 
            this.cbbLop.FormattingEnabled = true;
            this.cbbLop.Location = new System.Drawing.Point(23, 227);
            this.cbbLop.Margin = new System.Windows.Forms.Padding(4);
            this.cbbLop.Name = "cbbLop";
            this.cbbLop.Size = new System.Drawing.Size(236, 24);
            this.cbbLop.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "HoTen";
            // 
            // radNam
            // 
            this.radNam.AutoSize = true;
            this.radNam.Checked = true;
            this.radNam.Location = new System.Drawing.Point(23, 310);
            this.radNam.Margin = new System.Windows.Forms.Padding(4);
            this.radNam.Name = "radNam";
            this.radNam.Size = new System.Drawing.Size(57, 20);
            this.radNam.TabIndex = 20;
            this.radNam.TabStop = true;
            this.radNam.Text = "Nam";
            this.radNam.UseVisualStyleBackColor = true;
            // 
            // dgvSinhVien
            // 
            this.dgvSinhVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSinhVien.Location = new System.Drawing.Point(314, 71);
            this.dgvSinhVien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvSinhVien.Name = "dgvSinhVien";
            this.dgvSinhVien.RowHeadersWidth = 51;
            this.dgvSinhVien.RowTemplate.Height = 24;
            this.dgvSinhVien.Size = new System.Drawing.Size(807, 346);
            this.dgvSinhVien.TabIndex = 0;
            // 
            // radNu
            // 
            this.radNu.AutoSize = true;
            this.radNu.Location = new System.Drawing.Point(140, 310);
            this.radNu.Margin = new System.Windows.Forms.Padding(4);
            this.radNu.Name = "radNu";
            this.radNu.Size = new System.Drawing.Size(45, 20);
            this.radNu.TabIndex = 21;
            this.radNu.Text = "Nữ";
            this.radNu.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Id";
            // 
            // btnTrangTruoc
            // 
            this.btnTrangTruoc.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnTrangTruoc.Location = new System.Drawing.Point(314, 446);
            this.btnTrangTruoc.Name = "btnTrangTruoc";
            this.btnTrangTruoc.Size = new System.Drawing.Size(75, 23);
            this.btnTrangTruoc.TabIndex = 22;
            this.btnTrangTruoc.Text = "<<";
            this.btnTrangTruoc.UseVisualStyleBackColor = false;
            this.btnTrangTruoc.Click += new System.EventHandler(this.btnTrangTruoc_Click);
            // 
            // btnTrangSau
            // 
            this.btnTrangSau.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnTrangSau.Location = new System.Drawing.Point(514, 446);
            this.btnTrangSau.Name = "btnTrangSau";
            this.btnTrangSau.Size = new System.Drawing.Size(75, 23);
            this.btnTrangSau.TabIndex = 23;
            this.btnTrangSau.Text = ">>";
            this.btnTrangSau.UseVisualStyleBackColor = false;
            this.btnTrangSau.Click += new System.EventHandler(this.btnTrangSau_Click);
            // 
            // lblTrang
            // 
            this.lblTrang.AutoSize = true;
            this.lblTrang.Location = new System.Drawing.Point(425, 449);
            this.lblTrang.Name = "lblTrang";
            this.lblTrang.Size = new System.Drawing.Size(58, 16);
            this.lblTrang.TabIndex = 24;
            this.lblTrang.Text = "trang 1/5";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(-5, 2);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1188, 516);
            this.tabControl1.TabIndex = 22;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1199, 524);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load_1);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLopHoc)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSinhVien)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgvLopHoc;
        private System.Windows.Forms.Button btnTimKiemLop;
        private System.Windows.Forms.TextBox txtTimKiemLop;
        private System.Windows.Forms.TextBox txtTenLop;
        private System.Windows.Forms.TextBox txtMaLop;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnLamMoiLop;
        private System.Windows.Forms.Button btnXoaLop;
        private System.Windows.Forms.Button btnSuaLop;
        private System.Windows.Forms.Button btnThemLop;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label lblTrang;
        private System.Windows.Forms.Button btnTrangSau;
        private System.Windows.Forms.Button btnTrangTruoc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radNu;
        private System.Windows.Forms.DataGridView dgvSinhVien;
        private System.Windows.Forms.RadioButton radNam;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbbLop;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.TextBox txtDiem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TabControl tabControl1;
    }
}