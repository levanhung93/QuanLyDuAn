namespace QuanLySinhVien.GUI
{
    partial class GiaoVienHuongDan
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
            this.label1 = new System.Windows.Forms.Label();
            this._btnTimKiemGiaoVienHD = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._txtTimKiemGiaoVienHD = new System.Windows.Forms.TextBox();
            this._btnLuuGV = new System.Windows.Forms.Label();
            this._btnXoaGV = new System.Windows.Forms.Label();
            this._btnThemGV = new System.Windows.Forms.Label();
            this._cboMaGiaoVienHD = new System.Windows.Forms.ComboBox();
            this._txtTenGiaoVienHD = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this._grbThongTinGiaoVienHD = new System.Windows.Forms.GroupBox();
            this._txtNamSinhGV = new System.Windows.Forms.TextBox();
            this._txtThangSinhGV = new System.Windows.Forms.TextBox();
            this._txtNgaySinhGV = new System.Windows.Forms.TextBox();
            this._txtEmailGV = new System.Windows.Forms.TextBox();
            this._txtDienThoaiGV = new System.Windows.Forms.TextBox();
            this._txtDiachiGV = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this._txtGioiTinhGV = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this._grbDatGiaoVien = new System.Windows.Forms.GroupBox();
            this._dgvGiaoVien = new System.Windows.Forms.DataGridView();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._txtTongBanGhi = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this._grbThongTinGiaoVienHD.SuspendLayout();
            this._grbDatGiaoVien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._dgvGiaoVien)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(422, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "THÔNG TIN GIÁO VIÊN HƯỚNG DẪN";
            // 
            // _btnTimKiemGiaoVienHD
            // 
            this._btnTimKiemGiaoVienHD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._btnTimKiemGiaoVienHD.Cursor = System.Windows.Forms.Cursors.Hand;
            this._btnTimKiemGiaoVienHD.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnTimKiemGiaoVienHD.Location = new System.Drawing.Point(908, 44);
            this._btnTimKiemGiaoVienHD.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this._btnTimKiemGiaoVienHD.Name = "_btnTimKiemGiaoVienHD";
            this._btnTimKiemGiaoVienHD.Size = new System.Drawing.Size(73, 22);
            this._btnTimKiemGiaoVienHD.TabIndex = 21;
            this._btnTimKiemGiaoVienHD.Text = "Tìm";
            this._btnTimKiemGiaoVienHD.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this._btnTimKiemGiaoVienHD.Click += new System.EventHandler(this._btnTimKiemGiaoVienHD_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(656, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 16);
            this.label6.TabIndex = 15;
            this.label6.Text = "Tìm kiếm";
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
            // _txtTimKiemGiaoVienHD
            // 
            this._txtTimKiemGiaoVienHD.Location = new System.Drawing.Point(726, 44);
            this._txtTimKiemGiaoVienHD.Name = "_txtTimKiemGiaoVienHD";
            this._txtTimKiemGiaoVienHD.Size = new System.Drawing.Size(169, 22);
            this._txtTimKiemGiaoVienHD.TabIndex = 16;
            this._txtTimKiemGiaoVienHD.Text = "Nhập tên Giáo Viên cần tìm";
            // 
            // _btnLuuGV
            // 
            this._btnLuuGV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._btnLuuGV.Cursor = System.Windows.Forms.Cursors.Hand;
            this._btnLuuGV.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnLuuGV.Location = new System.Drawing.Point(708, 240);
            this._btnLuuGV.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this._btnLuuGV.Name = "_btnLuuGV";
            this._btnLuuGV.Size = new System.Drawing.Size(125, 39);
            this._btnLuuGV.TabIndex = 20;
            this._btnLuuGV.Text = "Lưu giáo viên";
            this._btnLuuGV.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this._btnLuuGV.Click += new System.EventHandler(this.OnBtnLuuGVClick);
            // 
            // _btnXoaGV
            // 
            this._btnXoaGV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._btnXoaGV.Cursor = System.Windows.Forms.Cursors.Hand;
            this._btnXoaGV.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnXoaGV.Location = new System.Drawing.Point(480, 240);
            this._btnXoaGV.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this._btnXoaGV.Name = "_btnXoaGV";
            this._btnXoaGV.Size = new System.Drawing.Size(125, 39);
            this._btnXoaGV.TabIndex = 19;
            this._btnXoaGV.Text = "Xóa giáo viên";
            this._btnXoaGV.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this._btnXoaGV.Click += new System.EventHandler(this._btnXoaGV_Click);
            // 
            // _btnThemGV
            // 
            this._btnThemGV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._btnThemGV.Cursor = System.Windows.Forms.Cursors.Hand;
            this._btnThemGV.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnThemGV.Location = new System.Drawing.Point(239, 236);
            this._btnThemGV.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this._btnThemGV.Name = "_btnThemGV";
            this._btnThemGV.Size = new System.Drawing.Size(125, 39);
            this._btnThemGV.TabIndex = 17;
            this._btnThemGV.Text = "Thêm giáo viên";
            this._btnThemGV.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this._btnThemGV.Click += new System.EventHandler(this.OnBtnThemGVClick);
            // 
            // _cboMaGiaoVienHD
            // 
            this._cboMaGiaoVienHD.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this._cboMaGiaoVienHD.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this._cboMaGiaoVienHD.Enabled = false;
            this._cboMaGiaoVienHD.FormattingEnabled = true;
            this._cboMaGiaoVienHD.Location = new System.Drawing.Point(190, 34);
            this._cboMaGiaoVienHD.Name = "_cboMaGiaoVienHD";
            this._cboMaGiaoVienHD.Size = new System.Drawing.Size(221, 24);
            this._cboMaGiaoVienHD.TabIndex = 7;
            this._cboMaGiaoVienHD.SelectedIndexChanged += new System.EventHandler(this.OnCboMaGiaoVienSelectedIndexChanged);
            // 
            // _txtTenGiaoVienHD
            // 
            this._txtTenGiaoVienHD.Enabled = false;
            this._txtTenGiaoVienHD.Location = new System.Drawing.Point(190, 66);
            this._txtTenGiaoVienHD.Name = "_txtTenGiaoVienHD";
            this._txtTenGiaoVienHD.Size = new System.Drawing.Size(221, 22);
            this._txtTenGiaoVienHD.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(507, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 16);
            this.label5.TabIndex = 3;
            this.label5.Text = "Địa chỉ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(89, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Giới tính";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(89, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tên giáo viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(89, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã giáo viên";
            // 
            // _grbThongTinGiaoVienHD
            // 
            this._grbThongTinGiaoVienHD.Controls.Add(this._txtNamSinhGV);
            this._grbThongTinGiaoVienHD.Controls.Add(this._txtThangSinhGV);
            this._grbThongTinGiaoVienHD.Controls.Add(this._txtNgaySinhGV);
            this._grbThongTinGiaoVienHD.Controls.Add(this._txtEmailGV);
            this._grbThongTinGiaoVienHD.Controls.Add(this._txtDienThoaiGV);
            this._grbThongTinGiaoVienHD.Controls.Add(this._txtDiachiGV);
            this._grbThongTinGiaoVienHD.Controls.Add(this.label9);
            this._grbThongTinGiaoVienHD.Controls.Add(this._txtGioiTinhGV);
            this._grbThongTinGiaoVienHD.Controls.Add(this.label8);
            this._grbThongTinGiaoVienHD.Controls.Add(this.label7);
            this._grbThongTinGiaoVienHD.Controls.Add(this._cboMaGiaoVienHD);
            this._grbThongTinGiaoVienHD.Controls.Add(this._txtTenGiaoVienHD);
            this._grbThongTinGiaoVienHD.Controls.Add(this.label5);
            this._grbThongTinGiaoVienHD.Controls.Add(this.label4);
            this._grbThongTinGiaoVienHD.Controls.Add(this.label3);
            this._grbThongTinGiaoVienHD.Controls.Add(this.label2);
            this._grbThongTinGiaoVienHD.Location = new System.Drawing.Point(31, 66);
            this._grbThongTinGiaoVienHD.Name = "_grbThongTinGiaoVienHD";
            this._grbThongTinGiaoVienHD.Size = new System.Drawing.Size(964, 167);
            this._grbThongTinGiaoVienHD.TabIndex = 14;
            this._grbThongTinGiaoVienHD.TabStop = false;
            this._grbThongTinGiaoVienHD.Text = "Thông tin giáo viên hướng dẫn";
            // 
            // _txtNamSinhGV
            // 
            this._txtNamSinhGV.Enabled = false;
            this._txtNamSinhGV.Location = new System.Drawing.Point(347, 100);
            this._txtNamSinhGV.Name = "_txtNamSinhGV";
            this._txtNamSinhGV.Size = new System.Drawing.Size(66, 22);
            this._txtNamSinhGV.TabIndex = 21;
            // 
            // _txtThangSinhGV
            // 
            this._txtThangSinhGV.Enabled = false;
            this._txtThangSinhGV.Location = new System.Drawing.Point(267, 100);
            this._txtThangSinhGV.Name = "_txtThangSinhGV";
            this._txtThangSinhGV.Size = new System.Drawing.Size(66, 22);
            this._txtThangSinhGV.TabIndex = 20;
            // 
            // _txtNgaySinhGV
            // 
            this._txtNgaySinhGV.Enabled = false;
            this._txtNgaySinhGV.Location = new System.Drawing.Point(190, 100);
            this._txtNgaySinhGV.Name = "_txtNgaySinhGV";
            this._txtNgaySinhGV.Size = new System.Drawing.Size(66, 22);
            this._txtNgaySinhGV.TabIndex = 19;
            // 
            // _txtEmailGV
            // 
            this._txtEmailGV.Enabled = false;
            this._txtEmailGV.Location = new System.Drawing.Point(608, 106);
            this._txtEmailGV.Name = "_txtEmailGV";
            this._txtEmailGV.Size = new System.Drawing.Size(221, 22);
            this._txtEmailGV.TabIndex = 18;
            // 
            // _txtDienThoaiGV
            // 
            this._txtDienThoaiGV.Enabled = false;
            this._txtDienThoaiGV.Location = new System.Drawing.Point(608, 72);
            this._txtDienThoaiGV.Name = "_txtDienThoaiGV";
            this._txtDienThoaiGV.Size = new System.Drawing.Size(221, 22);
            this._txtDienThoaiGV.TabIndex = 17;
            // 
            // _txtDiachiGV
            // 
            this._txtDiachiGV.Enabled = false;
            this._txtDiachiGV.Location = new System.Drawing.Point(608, 42);
            this._txtDiachiGV.Name = "_txtDiachiGV";
            this._txtDiachiGV.Size = new System.Drawing.Size(221, 22);
            this._txtDiachiGV.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(507, 106);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 16);
            this.label9.TabIndex = 15;
            this.label9.Text = "Email";
            // 
            // _txtGioiTinhGV
            // 
            this._txtGioiTinhGV.Enabled = false;
            this._txtGioiTinhGV.Location = new System.Drawing.Point(190, 133);
            this._txtGioiTinhGV.Name = "_txtGioiTinhGV";
            this._txtGioiTinhGV.Size = new System.Drawing.Size(221, 22);
            this._txtGioiTinhGV.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(507, 72);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 16);
            this.label8.TabIndex = 13;
            this.label8.Text = "Điện thoại";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(89, 98);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 16);
            this.label7.TabIndex = 9;
            this.label7.Text = "Ngày sinh";
            // 
            // _grbDatGiaoVien
            // 
            this._grbDatGiaoVien.Controls.Add(this._dgvGiaoVien);
            this._grbDatGiaoVien.Location = new System.Drawing.Point(31, 310);
            this._grbDatGiaoVien.Name = "_grbDatGiaoVien";
            this._grbDatGiaoVien.Size = new System.Drawing.Size(964, 173);
            this._grbDatGiaoVien.TabIndex = 22;
            this._grbDatGiaoVien.TabStop = false;
            this._grbDatGiaoVien.Text = "Thông tin ";
            // 
            // _dgvGiaoVien
            // 
            this._dgvGiaoVien.AllowUserToAddRows = false;
            this._dgvGiaoVien.BackgroundColor = System.Drawing.SystemColors.Control;
            this._dgvGiaoVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._dgvGiaoVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10,
            this.Column11,
            this.Column12,
            this.Column13});
            this._dgvGiaoVien.Location = new System.Drawing.Point(27, 22);
            this._dgvGiaoVien.Name = "_dgvGiaoVien";
            this._dgvGiaoVien.Size = new System.Drawing.Size(917, 134);
            this._dgvGiaoVien.TabIndex = 0;
            this._dgvGiaoVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DSGV_CellClick);
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "MaGV";
            this.Column5.HeaderText = "Mã giáo viên";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "TenGV";
            this.Column6.HeaderText = "Tên giáo viên";
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
            // _txtTongBanGhi
            // 
            this._txtTongBanGhi.Enabled = false;
            this._txtTongBanGhi.Location = new System.Drawing.Point(240, 291);
            this._txtTongBanGhi.Name = "_txtTongBanGhi";
            this._txtTongBanGhi.Size = new System.Drawing.Size(82, 22);
            this._txtTongBanGhi.TabIndex = 32;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(129, 291);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(100, 16);
            this.label11.TabIndex = 31;
            this.label11.Text = "Tổng số bản ghi";
            // 
            // GiaoVienHuongDan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this._txtTongBanGhi);
            this.Controls.Add(this.label11);
            this.Controls.Add(this._grbDatGiaoVien);
            this.Controls.Add(this._btnTimKiemGiaoVienHD);
            this.Controls.Add(this.label6);
            this.Controls.Add(this._txtTimKiemGiaoVienHD);
            this.Controls.Add(this._btnLuuGV);
            this.Controls.Add(this._btnXoaGV);
            this.Controls.Add(this._btnThemGV);
            this.Controls.Add(this._grbThongTinGiaoVienHD);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "GiaoVienHuongDan";
            this.Size = new System.Drawing.Size(1024, 486);
            this.Load += new System.EventHandler(this.OnGiaoVienHuongDanLoad);
            this._grbThongTinGiaoVienHD.ResumeLayout(false);
            this._grbThongTinGiaoVienHD.PerformLayout();
            this._grbDatGiaoVien.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._dgvGiaoVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label _btnTimKiemGiaoVienHD;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.TextBox _txtTimKiemGiaoVienHD;
        private System.Windows.Forms.Label _btnLuuGV;
        private System.Windows.Forms.Label _btnXoaGV;
        private System.Windows.Forms.Label _btnThemGV;
        private System.Windows.Forms.ComboBox _cboMaGiaoVienHD;
        private System.Windows.Forms.TextBox _txtTenGiaoVienHD;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox _grbThongTinGiaoVienHD;
        private System.Windows.Forms.GroupBox _grbDatGiaoVien;
        private System.Windows.Forms.DataGridView _dgvGiaoVien;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox _txtGioiTinhGV;
        private System.Windows.Forms.TextBox _txtEmailGV;
        private System.Windows.Forms.TextBox _txtDienThoaiGV;
        private System.Windows.Forms.TextBox _txtDiachiGV;
        private System.Windows.Forms.TextBox _txtTongBanGhi;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox _txtNamSinhGV;
        private System.Windows.Forms.TextBox _txtThangSinhGV;
        private System.Windows.Forms.TextBox _txtNgaySinhGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column13;
    }
}
