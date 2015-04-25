namespace QuanLySinhVien.GUI
{
    partial class BangDiem
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
            this._dgvBangDiem = new System.Windows.Forms.DataGridView();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._grbDatBangDiem = new System.Windows.Forms.GroupBox();
            this._grbThongTinSinhVien = new System.Windows.Forms.GroupBox();
            this._cboLanThucTap = new System.Windows.Forms.ComboBox();
            this._txtGhiChu = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this._txtDiemTong = new System.Windows.Forms.TextBox();
            this._txtDiemBV = new System.Windows.Forms.TextBox();
            this._txtDiemTB = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this._txtDiem3 = new System.Windows.Forms.TextBox();
            this._txtDiem2 = new System.Windows.Forms.TextBox();
            this._txtDiem1 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this._cboMaSinhVienTT = new System.Windows.Forms.ComboBox();
            this._txtTenSinhVienTT = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this._btnTimKiemDiem = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._txtTimKiemDiem = new System.Windows.Forms.TextBox();
            this._btnLuuBangDiem = new System.Windows.Forms.Label();
            this._btnXoaBangDiem = new System.Windows.Forms.Label();
            this._btnSuaBangDiem = new System.Windows.Forms.Label();
            this._btnThemBangDiem = new System.Windows.Forms.Label();
            this._txtTongBanGhi = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this._dgvBangDiem)).BeginInit();
            this._grbDatBangDiem.SuspendLayout();
            this._grbThongTinSinhVien.SuspendLayout();
            this.SuspendLayout();
            // 
            // _dgvBangDiem
            // 
            this._dgvBangDiem.AllowUserToAddRows = false;
            this._dgvBangDiem.BackgroundColor = System.Drawing.SystemColors.Control;
            this._dgvBangDiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._dgvBangDiem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10,
            this.Column11,
            this.Column12,
            this.Column13,
            this.Column14});
            this._dgvBangDiem.Location = new System.Drawing.Point(33, 21);
            this._dgvBangDiem.Name = "_dgvBangDiem";
            this._dgvBangDiem.Size = new System.Drawing.Size(917, 134);
            this._dgvBangDiem.TabIndex = 0;
            this._dgvBangDiem.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.OnDgvBangDiemCellClick);
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
            this.Column7.DataPropertyName = "LanThucTap";
            this.Column7.HeaderText = "Lần thực tập";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "Diem1";
            this.Column8.HeaderText = "Điểm 1";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "Diem2";
            this.Column9.HeaderText = "Điểm 2";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            // 
            // Column10
            // 
            this.Column10.DataPropertyName = "Diem3";
            this.Column10.HeaderText = "Điểm 3";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            // 
            // Column11
            // 
            this.Column11.DataPropertyName = "DiemTB";
            this.Column11.HeaderText = "Điểm TB";
            this.Column11.Name = "Column11";
            this.Column11.ReadOnly = true;
            // 
            // Column12
            // 
            this.Column12.DataPropertyName = "DiemBaoVe";
            this.Column12.HeaderText = "Điểm Bảo Vệ";
            this.Column12.Name = "Column12";
            this.Column12.ReadOnly = true;
            // 
            // Column13
            // 
            this.Column13.DataPropertyName = "DiemTongKet";
            this.Column13.HeaderText = "Điểm Tổng";
            this.Column13.Name = "Column13";
            this.Column13.ReadOnly = true;
            // 
            // Column14
            // 
            this.Column14.DataPropertyName = "GhiChu";
            this.Column14.HeaderText = "Ghi chú";
            this.Column14.Name = "Column14";
            this.Column14.ReadOnly = true;
            // 
            // _grbDatBangDiem
            // 
            this._grbDatBangDiem.Controls.Add(this._dgvBangDiem);
            this._grbDatBangDiem.Location = new System.Drawing.Point(30, 303);
            this._grbDatBangDiem.Name = "_grbDatBangDiem";
            this._grbDatBangDiem.Size = new System.Drawing.Size(964, 173);
            this._grbDatBangDiem.TabIndex = 32;
            this._grbDatBangDiem.TabStop = false;
            this._grbDatBangDiem.Text = "Thông tin ";
            // 
            // _grbThongTinSinhVien
            // 
            this._grbThongTinSinhVien.Controls.Add(this._cboLanThucTap);
            this._grbThongTinSinhVien.Controls.Add(this._txtGhiChu);
            this._grbThongTinSinhVien.Controls.Add(this.label12);
            this._grbThongTinSinhVien.Controls.Add(this._txtDiemTong);
            this._grbThongTinSinhVien.Controls.Add(this._txtDiemBV);
            this._grbThongTinSinhVien.Controls.Add(this._txtDiemTB);
            this._grbThongTinSinhVien.Controls.Add(this.label9);
            this._grbThongTinSinhVien.Controls.Add(this.label10);
            this._grbThongTinSinhVien.Controls.Add(this.label11);
            this._grbThongTinSinhVien.Controls.Add(this._txtDiem3);
            this._grbThongTinSinhVien.Controls.Add(this._txtDiem2);
            this._grbThongTinSinhVien.Controls.Add(this._txtDiem1);
            this._grbThongTinSinhVien.Controls.Add(this.label8);
            this._grbThongTinSinhVien.Controls.Add(this.label5);
            this._grbThongTinSinhVien.Controls.Add(this.label7);
            this._grbThongTinSinhVien.Controls.Add(this._cboMaSinhVienTT);
            this._grbThongTinSinhVien.Controls.Add(this._txtTenSinhVienTT);
            this._grbThongTinSinhVien.Controls.Add(this.label4);
            this._grbThongTinSinhVien.Controls.Add(this.label3);
            this._grbThongTinSinhVien.Controls.Add(this.label2);
            this._grbThongTinSinhVien.Location = new System.Drawing.Point(30, 44);
            this._grbThongTinSinhVien.Name = "_grbThongTinSinhVien";
            this._grbThongTinSinhVien.Size = new System.Drawing.Size(964, 167);
            this._grbThongTinSinhVien.TabIndex = 24;
            this._grbThongTinSinhVien.TabStop = false;
            this._grbThongTinSinhVien.Text = "Thông tin bảng điểm";
            // 
            // _cboLanThucTap
            // 
            this._cboLanThucTap.Enabled = false;
            this._cboLanThucTap.FormattingEnabled = true;
            this._cboLanThucTap.Items.AddRange(new object[] {
            "1",
            "2"});
            this._cboLanThucTap.Location = new System.Drawing.Point(118, 101);
            this._cboLanThucTap.Name = "_cboLanThucTap";
            this._cboLanThucTap.Size = new System.Drawing.Size(142, 24);
            this._cboLanThucTap.TabIndex = 36;
            this._cboLanThucTap.TextChanged += new System.EventHandler(this.OnCboLanThucTapChanged);
            // 
            // _txtGhiChu
            // 
            this._txtGhiChu.Enabled = false;
            this._txtGhiChu.Location = new System.Drawing.Point(711, 136);
            this._txtGhiChu.Name = "_txtGhiChu";
            this._txtGhiChu.Size = new System.Drawing.Size(142, 22);
            this._txtGhiChu.TabIndex = 35;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(596, 136);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(52, 16);
            this.label12.TabIndex = 34;
            this.label12.Text = "Ghi chú";
            // 
            // _txtDiemTong
            // 
            this._txtDiemTong.Enabled = false;
            this._txtDiemTong.Location = new System.Drawing.Point(711, 101);
            this._txtDiemTong.Name = "_txtDiemTong";
            this._txtDiemTong.Size = new System.Drawing.Size(142, 22);
            this._txtDiemTong.TabIndex = 33;
            this._txtDiemTong.TextChanged += new System.EventHandler(this.OnTxtDiemTongTextChanged);
            // 
            // _txtDiemBV
            // 
            this._txtDiemBV.Enabled = false;
            this._txtDiemBV.Location = new System.Drawing.Point(711, 69);
            this._txtDiemBV.Name = "_txtDiemBV";
            this._txtDiemBV.Size = new System.Drawing.Size(142, 22);
            this._txtDiemBV.TabIndex = 32;
            this._txtDiemBV.TextChanged += new System.EventHandler(this.OnTxtDiemBVTextChanged);
            // 
            // _txtDiemTB
            // 
            this._txtDiemTB.Enabled = false;
            this._txtDiemTB.Location = new System.Drawing.Point(711, 31);
            this._txtDiemTB.Name = "_txtDiemTB";
            this._txtDiemTB.Size = new System.Drawing.Size(142, 22);
            this._txtDiemTB.TabIndex = 31;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(596, 101);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 16);
            this.label9.TabIndex = 30;
            this.label9.Text = "Điểm tổng";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(596, 69);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(84, 16);
            this.label10.TabIndex = 29;
            this.label10.Text = "Điểm bảo vệ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(596, 34);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(99, 16);
            this.label11.TabIndex = 28;
            this.label11.Text = "Điểm trung bình";
            // 
            // _txtDiem3
            // 
            this._txtDiem3.Enabled = false;
            this._txtDiem3.Location = new System.Drawing.Point(394, 104);
            this._txtDiem3.Name = "_txtDiem3";
            this._txtDiem3.Size = new System.Drawing.Size(142, 22);
            this._txtDiem3.TabIndex = 27;
            this._txtDiem3.TextChanged += new System.EventHandler(this.OnTxtDiem3TextChanged);
            // 
            // _txtDiem2
            // 
            this._txtDiem2.Enabled = false;
            this._txtDiem2.Location = new System.Drawing.Point(394, 72);
            this._txtDiem2.Name = "_txtDiem2";
            this._txtDiem2.Size = new System.Drawing.Size(142, 22);
            this._txtDiem2.TabIndex = 26;
            this._txtDiem2.TextChanged += new System.EventHandler(this.OnTxtDiem2TextChanged);
            // 
            // _txtDiem1
            // 
            this._txtDiem1.Enabled = false;
            this._txtDiem1.Location = new System.Drawing.Point(394, 37);
            this._txtDiem1.Name = "_txtDiem1";
            this._txtDiem1.Size = new System.Drawing.Size(142, 22);
            this._txtDiem1.TabIndex = 25;
            this._txtDiem1.TextChanged += new System.EventHandler(this.OnTxtDiem1TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(321, 104);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 16);
            this.label8.TabIndex = 23;
            this.label8.Text = "Điểm 3";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(321, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 16);
            this.label5.TabIndex = 21;
            this.label5.Text = "Điểm 2";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(321, 37);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 16);
            this.label7.TabIndex = 19;
            this.label7.Text = "Điểm 1";
            // 
            // _cboMaSinhVienTT
            // 
            this._cboMaSinhVienTT.Enabled = false;
            this._cboMaSinhVienTT.FormattingEnabled = true;
            this._cboMaSinhVienTT.Location = new System.Drawing.Point(118, 34);
            this._cboMaSinhVienTT.Name = "_cboMaSinhVienTT";
            this._cboMaSinhVienTT.Size = new System.Drawing.Size(142, 24);
            this._cboMaSinhVienTT.TabIndex = 7;
            this._cboMaSinhVienTT.SelectedIndexChanged += new System.EventHandler(this.OnCboMaSinhVienTTSelectedIndexChanged);
            // 
            // _txtTenSinhVienTT
            // 
            this._txtTenSinhVienTT.Enabled = false;
            this._txtTenSinhVienTT.Location = new System.Drawing.Point(118, 66);
            this._txtTenSinhVienTT.Name = "_txtTenSinhVienTT";
            this._txtTenSinhVienTT.Size = new System.Drawing.Size(142, 22);
            this._txtTenSinhVienTT.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Lần thực tập";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tên sinh viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã sinh viên";
            // 
            // _btnTimKiemDiem
            // 
            this._btnTimKiemDiem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._btnTimKiemDiem.Cursor = System.Windows.Forms.Cursors.Hand;
            this._btnTimKiemDiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnTimKiemDiem.Location = new System.Drawing.Point(907, 20);
            this._btnTimKiemDiem.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this._btnTimKiemDiem.Name = "_btnTimKiemDiem";
            this._btnTimKiemDiem.Size = new System.Drawing.Size(73, 22);
            this._btnTimKiemDiem.TabIndex = 31;
            this._btnTimKiemDiem.Text = "Tìm";
            this._btnTimKiemDiem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this._btnTimKiemDiem.Click += new System.EventHandler(this.OnBtnTimKiemDiemClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(655, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 16);
            this.label6.TabIndex = 25;
            this.label6.Text = "Tìm kiếm";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(421, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 16);
            this.label1.TabIndex = 23;
            this.label1.Text = "BẢNG ĐIỂM THỰC TẬP";
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
            // _txtTimKiemDiem
            // 
            this._txtTimKiemDiem.Location = new System.Drawing.Point(725, 18);
            this._txtTimKiemDiem.Name = "_txtTimKiemDiem";
            this._txtTimKiemDiem.Size = new System.Drawing.Size(169, 22);
            this._txtTimKiemDiem.TabIndex = 26;
            this._txtTimKiemDiem.Text = "nhập mã sinh viên tìm kiếm...";
            // 
            // _btnLuuBangDiem
            // 
            this._btnLuuBangDiem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._btnLuuBangDiem.Cursor = System.Windows.Forms.Cursors.Hand;
            this._btnLuuBangDiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnLuuBangDiem.Location = new System.Drawing.Point(783, 221);
            this._btnLuuBangDiem.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this._btnLuuBangDiem.Name = "_btnLuuBangDiem";
            this._btnLuuBangDiem.Size = new System.Drawing.Size(125, 39);
            this._btnLuuBangDiem.TabIndex = 30;
            this._btnLuuBangDiem.Text = "Lưu điểm";
            this._btnLuuBangDiem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this._btnLuuBangDiem.Click += new System.EventHandler(this.OnBtnLuuBangDiemClick);
            // 
            // _btnXoaBangDiem
            // 
            this._btnXoaBangDiem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._btnXoaBangDiem.Cursor = System.Windows.Forms.Cursors.Hand;
            this._btnXoaBangDiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnXoaBangDiem.Location = new System.Drawing.Point(577, 221);
            this._btnXoaBangDiem.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this._btnXoaBangDiem.Name = "_btnXoaBangDiem";
            this._btnXoaBangDiem.Size = new System.Drawing.Size(125, 39);
            this._btnXoaBangDiem.TabIndex = 29;
            this._btnXoaBangDiem.Text = "Xóa điểm";
            this._btnXoaBangDiem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this._btnXoaBangDiem.Click += new System.EventHandler(this.OnBtnXoaBangDiemClick);
            // 
            // _btnSuaBangDiem
            // 
            this._btnSuaBangDiem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._btnSuaBangDiem.Cursor = System.Windows.Forms.Cursors.Hand;
            this._btnSuaBangDiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnSuaBangDiem.Location = new System.Drawing.Point(354, 221);
            this._btnSuaBangDiem.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this._btnSuaBangDiem.Name = "_btnSuaBangDiem";
            this._btnSuaBangDiem.Size = new System.Drawing.Size(125, 39);
            this._btnSuaBangDiem.TabIndex = 28;
            this._btnSuaBangDiem.Text = "Sửa điểm";
            this._btnSuaBangDiem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this._btnSuaBangDiem.Click += new System.EventHandler(this.OnBtnSuaBangDiemClick);
            // 
            // _btnThemBangDiem
            // 
            this._btnThemBangDiem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._btnThemBangDiem.Cursor = System.Windows.Forms.Cursors.Hand;
            this._btnThemBangDiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnThemBangDiem.Location = new System.Drawing.Point(131, 221);
            this._btnThemBangDiem.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this._btnThemBangDiem.Name = "_btnThemBangDiem";
            this._btnThemBangDiem.Size = new System.Drawing.Size(125, 39);
            this._btnThemBangDiem.TabIndex = 27;
            this._btnThemBangDiem.Text = "Thêm điểm";
            this._btnThemBangDiem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this._btnThemBangDiem.Click += new System.EventHandler(this.OnBtnThemDiemClick);
            // 
            // _txtTongBanGhi
            // 
            this._txtTongBanGhi.Enabled = false;
            this._txtTongBanGhi.Location = new System.Drawing.Point(256, 284);
            this._txtTongBanGhi.Name = "_txtTongBanGhi";
            this._txtTongBanGhi.Size = new System.Drawing.Size(82, 22);
            this._txtTongBanGhi.TabIndex = 38;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(145, 284);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(105, 16);
            this.label13.TabIndex = 37;
            this.label13.Text = "Tổng số bản ghi";
            // 
            // BangDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this._txtTongBanGhi);
            this.Controls.Add(this.label13);
            this.Controls.Add(this._grbDatBangDiem);
            this.Controls.Add(this._grbThongTinSinhVien);
            this.Controls.Add(this._btnTimKiemDiem);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._txtTimKiemDiem);
            this.Controls.Add(this._btnLuuBangDiem);
            this.Controls.Add(this._btnXoaBangDiem);
            this.Controls.Add(this._btnSuaBangDiem);
            this.Controls.Add(this._btnThemBangDiem);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "BangDiem";
            this.Size = new System.Drawing.Size(1024, 486);
            this.Load += new System.EventHandler(this.OnBangDiemLoad);
            ((System.ComponentModel.ISupportInitialize)(this._dgvBangDiem)).EndInit();
            this._grbDatBangDiem.ResumeLayout(false);
            this._grbThongTinSinhVien.ResumeLayout(false);
            this._grbThongTinSinhVien.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView _dgvBangDiem;
        private System.Windows.Forms.GroupBox _grbDatBangDiem;
        private System.Windows.Forms.GroupBox _grbThongTinSinhVien;
        private System.Windows.Forms.TextBox _txtDiemTong;
        private System.Windows.Forms.TextBox _txtDiemBV;
        private System.Windows.Forms.TextBox _txtDiemTB;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox _txtDiem3;
        private System.Windows.Forms.TextBox _txtDiem2;
        private System.Windows.Forms.TextBox _txtDiem1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox _cboMaSinhVienTT;
        private System.Windows.Forms.TextBox _txtTenSinhVienTT;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label _btnTimKiemDiem;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.TextBox _txtTimKiemDiem;
        private System.Windows.Forms.Label _btnLuuBangDiem;
        private System.Windows.Forms.Label _btnXoaBangDiem;
        private System.Windows.Forms.Label _btnSuaBangDiem;
        private System.Windows.Forms.Label _btnThemBangDiem;
        private System.Windows.Forms.TextBox _txtGhiChu;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox _cboLanThucTap;
        private System.Windows.Forms.TextBox _txtTongBanGhi;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column13;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column14;
    }
}
