namespace QuanLySinhVien.GUI
{
    partial class SinhVienThucTap
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this._dgvSinhVien = new System.Windows.Forms.DataGridView();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenLop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KhoaHoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._grbDatSinhVienTT = new System.Windows.Forms.GroupBox();
            this._grbThongTinSinhVienTT = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this._txtNamSinhSV = new System.Windows.Forms.TextBox();
            this._txtThangSinhSV = new System.Windows.Forms.TextBox();
            this._txtNgaySinhSV = new System.Windows.Forms.TextBox();
            this._txtEmailSV = new System.Windows.Forms.TextBox();
            this._txtDienThoaiSV = new System.Windows.Forms.TextBox();
            this._txtDiachiSV = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this._txtGioiTinhSV = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this._cbLop = new System.Windows.Forms.ComboBox();
            this._cbKhoaHoc = new System.Windows.Forms.ComboBox();
            this._cboMaSinhVien = new System.Windows.Forms.ComboBox();
            this._txtTenSinhVien = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this._btnTimKiemSinhVienTT = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._txtTimKiemSinhVienTT = new System.Windows.Forms.TextBox();
            this._btnLuuSV = new System.Windows.Forms.Label();
            this._btnXoaSV = new System.Windows.Forms.Label();
            this._btnThemSV = new System.Windows.Forms.Label();
            this._txtTongBanGhi = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this._dgvSinhVien)).BeginInit();
            this._grbDatSinhVienTT.SuspendLayout();
            this._grbThongTinSinhVienTT.SuspendLayout();
            this.SuspendLayout();
            // 
            // _dgvSinhVien
            // 
            this._dgvSinhVien.AllowUserToAddRows = false;
            this._dgvSinhVien.BackgroundColor = System.Drawing.SystemColors.Control;
            this._dgvSinhVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._dgvSinhVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10,
            this.TenLop,
            this.KhoaHoc,
            this.Column11,
            this.Column12,
            this.Column13});
            this._dgvSinhVien.Location = new System.Drawing.Point(27, 22);
            this._dgvSinhVien.Name = "_dgvSinhVien";
            this._dgvSinhVien.Size = new System.Drawing.Size(917, 134);
            this._dgvSinhVien.TabIndex = 0;
            this._dgvSinhVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DSSV_CellClick);
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "MaSV";
            this.Column5.HeaderText = "Mã sinh viên";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "TenSV";
            this.Column6.HeaderText = "Tên sinh viên";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "Ngay";
            this.Column7.HeaderText = "Ngày sinh";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "Thang";
            this.Column8.HeaderText = "Tháng sinh";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "Nam";
            this.Column9.HeaderText = "Năm sinh";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            // 
            // Column10
            // 
            this.Column10.DataPropertyName = "GioiTinh";
            this.Column10.HeaderText = "Giới tính";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            // 
            // TenLop
            // 
            this.TenLop.DataPropertyName = "TenLop";
            this.TenLop.HeaderText = "Lớp";
            this.TenLop.Name = "TenLop";
            this.TenLop.ReadOnly = true;
            // 
            // KhoaHoc
            // 
            this.KhoaHoc.DataPropertyName = "KhoaHoc";
            this.KhoaHoc.HeaderText = "Khóa học";
            this.KhoaHoc.Name = "KhoaHoc";
            this.KhoaHoc.ReadOnly = true;
            // 
            // Column11
            // 
            this.Column11.DataPropertyName = "DiaChi";
            this.Column11.HeaderText = "Địa chỉ";
            this.Column11.Name = "Column11";
            this.Column11.ReadOnly = true;
            // 
            // Column12
            // 
            this.Column12.DataPropertyName = "DienThoai";
            this.Column12.HeaderText = "Điện thoại";
            this.Column12.Name = "Column12";
            this.Column12.ReadOnly = true;
            // 
            // Column13
            // 
            this.Column13.DataPropertyName = "Email";
            this.Column13.HeaderText = "Email";
            this.Column13.Name = "Column13";
            this.Column13.ReadOnly = true;
            // 
            // _grbDatSinhVienTT
            // 
            this._grbDatSinhVienTT.Controls.Add(this._dgvSinhVien);
            this._grbDatSinhVienTT.Location = new System.Drawing.Point(30, 303);
            this._grbDatSinhVienTT.Name = "_grbDatSinhVienTT";
            this._grbDatSinhVienTT.Size = new System.Drawing.Size(964, 173);
            this._grbDatSinhVienTT.TabIndex = 32;
            this._grbDatSinhVienTT.TabStop = false;
            this._grbDatSinhVienTT.Text = "Thông tin ";
            // 
            // _grbThongTinSinhVienTT
            // 
            this._grbThongTinSinhVienTT.Controls.Add(this.label12);
            this._grbThongTinSinhVienTT.Controls.Add(this.label10);
            this._grbThongTinSinhVienTT.Controls.Add(this._txtNamSinhSV);
            this._grbThongTinSinhVienTT.Controls.Add(this._txtThangSinhSV);
            this._grbThongTinSinhVienTT.Controls.Add(this._txtNgaySinhSV);
            this._grbThongTinSinhVienTT.Controls.Add(this._txtEmailSV);
            this._grbThongTinSinhVienTT.Controls.Add(this._txtDienThoaiSV);
            this._grbThongTinSinhVienTT.Controls.Add(this._txtDiachiSV);
            this._grbThongTinSinhVienTT.Controls.Add(this.label9);
            this._grbThongTinSinhVienTT.Controls.Add(this._txtGioiTinhSV);
            this._grbThongTinSinhVienTT.Controls.Add(this.label8);
            this._grbThongTinSinhVienTT.Controls.Add(this.label7);
            this._grbThongTinSinhVienTT.Controls.Add(this._cbLop);
            this._grbThongTinSinhVienTT.Controls.Add(this._cbKhoaHoc);
            this._grbThongTinSinhVienTT.Controls.Add(this._cboMaSinhVien);
            this._grbThongTinSinhVienTT.Controls.Add(this._txtTenSinhVien);
            this._grbThongTinSinhVienTT.Controls.Add(this.label5);
            this._grbThongTinSinhVienTT.Controls.Add(this.label4);
            this._grbThongTinSinhVienTT.Controls.Add(this.label3);
            this._grbThongTinSinhVienTT.Controls.Add(this.label2);
            this._grbThongTinSinhVienTT.Location = new System.Drawing.Point(30, 48);
            this._grbThongTinSinhVienTT.Name = "_grbThongTinSinhVienTT";
            this._grbThongTinSinhVienTT.Size = new System.Drawing.Size(964, 167);
            this._grbThongTinSinhVienTT.TabIndex = 24;
            this._grbThongTinSinhVienTT.TabStop = false;
            this._grbThongTinSinhVienTT.Text = "Thông tin sinh viên thực tập";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(89, 139);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(31, 16);
            this.label12.TabIndex = 24;
            this.label12.Text = "Lớp";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(507, 37);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 16);
            this.label10.TabIndex = 22;
            this.label10.Text = "Khóa học";
            // 
            // _txtNamSinhSV
            // 
            this._txtNamSinhSV.Enabled = false;
            this._txtNamSinhSV.Location = new System.Drawing.Point(354, 81);
            this._txtNamSinhSV.Name = "_txtNamSinhSV";
            this._txtNamSinhSV.Size = new System.Drawing.Size(57, 22);
            this._txtNamSinhSV.TabIndex = 21;
            // 
            // _txtThangSinhSV
            // 
            this._txtThangSinhSV.Enabled = false;
            this._txtThangSinhSV.Location = new System.Drawing.Point(272, 79);
            this._txtThangSinhSV.Name = "_txtThangSinhSV";
            this._txtThangSinhSV.Size = new System.Drawing.Size(57, 22);
            this._txtThangSinhSV.TabIndex = 20;
            // 
            // _txtNgaySinhSV
            // 
            this._txtNgaySinhSV.Enabled = false;
            this._txtNgaySinhSV.Location = new System.Drawing.Point(190, 79);
            this._txtNgaySinhSV.Name = "_txtNgaySinhSV";
            this._txtNgaySinhSV.Size = new System.Drawing.Size(57, 22);
            this._txtNgaySinhSV.TabIndex = 19;
            // 
            // _txtEmailSV
            // 
            this._txtEmailSV.Enabled = false;
            this._txtEmailSV.Location = new System.Drawing.Point(608, 131);
            this._txtEmailSV.Name = "_txtEmailSV";
            this._txtEmailSV.Size = new System.Drawing.Size(221, 22);
            this._txtEmailSV.TabIndex = 18;
            // 
            // _txtDienThoaiSV
            // 
            this._txtDienThoaiSV.Enabled = false;
            this._txtDienThoaiSV.Location = new System.Drawing.Point(608, 99);
            this._txtDienThoaiSV.Name = "_txtDienThoaiSV";
            this._txtDienThoaiSV.Size = new System.Drawing.Size(221, 22);
            this._txtDienThoaiSV.TabIndex = 17;
            // 
            // _txtDiachiSV
            // 
            this._txtDiachiSV.Enabled = false;
            this._txtDiachiSV.Location = new System.Drawing.Point(608, 66);
            this._txtDiachiSV.Name = "_txtDiachiSV";
            this._txtDiachiSV.Size = new System.Drawing.Size(221, 22);
            this._txtDiachiSV.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(507, 131);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 16);
            this.label9.TabIndex = 15;
            this.label9.Text = "Email";
            // 
            // _txtGioiTinhSV
            // 
            this._txtGioiTinhSV.Enabled = false;
            this._txtGioiTinhSV.Location = new System.Drawing.Point(190, 107);
            this._txtGioiTinhSV.Name = "_txtGioiTinhSV";
            this._txtGioiTinhSV.Size = new System.Drawing.Size(221, 22);
            this._txtGioiTinhSV.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(507, 99);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 16);
            this.label8.TabIndex = 13;
            this.label8.Text = "Điện thoại";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(89, 79);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 16);
            this.label7.TabIndex = 9;
            this.label7.Text = "Ngày sinh";
            // 
            // _cbLop
            // 
            this._cbLop.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this._cbLop.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this._cbLop.Enabled = false;
            this._cbLop.FormattingEnabled = true;
            this._cbLop.Location = new System.Drawing.Point(190, 136);
            this._cbLop.Name = "_cbLop";
            this._cbLop.Size = new System.Drawing.Size(221, 24);
            this._cbLop.TabIndex = 7;
            this._cbLop.SelectedIndexChanged += new System.EventHandler(this.OnCboSinhVienSelecdIndexChanged);
            // 
            // _cbKhoaHoc
            // 
            this._cbKhoaHoc.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this._cbKhoaHoc.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this._cbKhoaHoc.Enabled = false;
            this._cbKhoaHoc.FormattingEnabled = true;
            this._cbKhoaHoc.Location = new System.Drawing.Point(608, 34);
            this._cbKhoaHoc.Name = "_cbKhoaHoc";
            this._cbKhoaHoc.Size = new System.Drawing.Size(221, 24);
            this._cbKhoaHoc.TabIndex = 7;
            this._cbKhoaHoc.SelectedIndexChanged += new System.EventHandler(this.OnCboSinhVienSelecdIndexChanged);
            // 
            // _cboMaSinhVien
            // 
            this._cboMaSinhVien.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this._cboMaSinhVien.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this._cboMaSinhVien.Enabled = false;
            this._cboMaSinhVien.FormattingEnabled = true;
            this._cboMaSinhVien.Location = new System.Drawing.Point(190, 23);
            this._cboMaSinhVien.Name = "_cboMaSinhVien";
            this._cboMaSinhVien.Size = new System.Drawing.Size(221, 24);
            this._cboMaSinhVien.TabIndex = 7;
            this._cboMaSinhVien.SelectedIndexChanged += new System.EventHandler(this.OnCboSinhVienSelecdIndexChanged);
            // 
            // _txtTenSinhVien
            // 
            this._txtTenSinhVien.Enabled = false;
            this._txtTenSinhVien.Location = new System.Drawing.Point(190, 53);
            this._txtTenSinhVien.Name = "_txtTenSinhVien";
            this._txtTenSinhVien.Size = new System.Drawing.Size(221, 22);
            this._txtTenSinhVien.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(507, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 16);
            this.label5.TabIndex = 3;
            this.label5.Text = "Địa chỉ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(89, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Giới tính";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(89, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tên sinh viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(89, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã sinh viên";
            // 
            // _btnTimKiemSinhVienTT
            // 
            this._btnTimKiemSinhVienTT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._btnTimKiemSinhVienTT.Cursor = System.Windows.Forms.Cursors.Hand;
            this._btnTimKiemSinhVienTT.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnTimKiemSinhVienTT.Location = new System.Drawing.Point(907, 25);
            this._btnTimKiemSinhVienTT.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this._btnTimKiemSinhVienTT.Name = "_btnTimKiemSinhVienTT";
            this._btnTimKiemSinhVienTT.Size = new System.Drawing.Size(73, 22);
            this._btnTimKiemSinhVienTT.TabIndex = 31;
            this._btnTimKiemSinhVienTT.Text = "Tìm";
            this._btnTimKiemSinhVienTT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this._btnTimKiemSinhVienTT.Click += new System.EventHandler(this._btnTimKiemSinhVienTT_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(655, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 16);
            this.label6.TabIndex = 25;
            this.label6.Text = "Tìm kiếm";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(421, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 16);
            this.label1.TabIndex = 23;
            this.label1.Text = "THÔNG TIN SINH VIÊN THỰC TẬP";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Tên giáo viên hướng dẫn";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 200;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Mã giáo viên hướng dẫn";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 153;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Tên đề tài";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 420;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Mã đề tài";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // _txtTimKiemSinhVienTT
            // 
            this._txtTimKiemSinhVienTT.Location = new System.Drawing.Point(725, 25);
            this._txtTimKiemSinhVienTT.Name = "_txtTimKiemSinhVienTT";
            this._txtTimKiemSinhVienTT.Size = new System.Drawing.Size(169, 22);
            this._txtTimKiemSinhVienTT.TabIndex = 26;
            this._txtTimKiemSinhVienTT.Text = "Nhập tên sinh viên...";
            // 
            // _btnLuuSV
            // 
            this._btnLuuSV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._btnLuuSV.Cursor = System.Windows.Forms.Cursors.Hand;
            this._btnLuuSV.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnLuuSV.Location = new System.Drawing.Point(695, 225);
            this._btnLuuSV.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this._btnLuuSV.Name = "_btnLuuSV";
            this._btnLuuSV.Size = new System.Drawing.Size(125, 39);
            this._btnLuuSV.TabIndex = 30;
            this._btnLuuSV.Text = "Lưu sinh viên";
            this._btnLuuSV.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this._btnLuuSV.Click += new System.EventHandler(this.OnBtnLuuSVClick);
            // 
            // _btnXoaSV
            // 
            this._btnXoaSV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._btnXoaSV.Cursor = System.Windows.Forms.Cursors.Hand;
            this._btnXoaSV.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnXoaSV.Location = new System.Drawing.Point(454, 225);
            this._btnXoaSV.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this._btnXoaSV.Name = "_btnXoaSV";
            this._btnXoaSV.Size = new System.Drawing.Size(125, 39);
            this._btnXoaSV.TabIndex = 29;
            this._btnXoaSV.Text = "Xóa sinh viên";
            this._btnXoaSV.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this._btnXoaSV.Click += new System.EventHandler(this._btnXoaSV_Click);
            // 
            // _btnThemSV
            // 
            this._btnThemSV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._btnThemSV.Cursor = System.Windows.Forms.Cursors.Hand;
            this._btnThemSV.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnThemSV.Location = new System.Drawing.Point(234, 225);
            this._btnThemSV.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this._btnThemSV.Name = "_btnThemSV";
            this._btnThemSV.Size = new System.Drawing.Size(125, 39);
            this._btnThemSV.TabIndex = 27;
            this._btnThemSV.Text = "Thêm sinh viên";
            this._btnThemSV.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this._btnThemSV.Click += new System.EventHandler(this.OnBtnThemSVClick);
            // 
            // _txtTongBanGhi
            // 
            this._txtTongBanGhi.Enabled = false;
            this._txtTongBanGhi.Location = new System.Drawing.Point(239, 284);
            this._txtTongBanGhi.Name = "_txtTongBanGhi";
            this._txtTongBanGhi.Size = new System.Drawing.Size(82, 22);
            this._txtTongBanGhi.TabIndex = 34;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(128, 284);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(100, 16);
            this.label11.TabIndex = 33;
            this.label11.Text = "Tổng số bản ghi";
            // 
            // SinhVienThucTap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this._txtTongBanGhi);
            this.Controls.Add(this.label11);
            this.Controls.Add(this._grbDatSinhVienTT);
            this.Controls.Add(this._grbThongTinSinhVienTT);
            this.Controls.Add(this._btnTimKiemSinhVienTT);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._txtTimKiemSinhVienTT);
            this.Controls.Add(this._btnLuuSV);
            this.Controls.Add(this._btnXoaSV);
            this.Controls.Add(this._btnThemSV);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SinhVienThucTap";
            this.Size = new System.Drawing.Size(1024, 486);
            this.Load += new System.EventHandler(this.OnSinhVienThucTapLoad);
            ((System.ComponentModel.ISupportInitialize)(this._dgvSinhVien)).EndInit();
            this._grbDatSinhVienTT.ResumeLayout(false);
            this._grbThongTinSinhVienTT.ResumeLayout(false);
            this._grbThongTinSinhVienTT.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView _dgvSinhVien;
        private System.Windows.Forms.GroupBox _grbDatSinhVienTT;
        private System.Windows.Forms.GroupBox _grbThongTinSinhVienTT;
        private System.Windows.Forms.TextBox _txtEmailSV;
        private System.Windows.Forms.TextBox _txtDienThoaiSV;
        private System.Windows.Forms.TextBox _txtDiachiSV;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox _txtGioiTinhSV;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox _cboMaSinhVien;
        private System.Windows.Forms.TextBox _txtTenSinhVien;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label _btnTimKiemSinhVienTT;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.TextBox _txtTimKiemSinhVienTT;
        private System.Windows.Forms.Label _btnLuuSV;
        private System.Windows.Forms.Label _btnXoaSV;
        private System.Windows.Forms.Label _btnThemSV;
        private System.Windows.Forms.TextBox _txtTongBanGhi;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox _txtNamSinhSV;
        private System.Windows.Forms.TextBox _txtThangSinhSV;
        private System.Windows.Forms.TextBox _txtNgaySinhSV;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox _cbLop;
        private System.Windows.Forms.ComboBox _cbKhoaHoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenLop;
        private System.Windows.Forms.DataGridViewTextBoxColumn KhoaHoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column13;
    }
}
