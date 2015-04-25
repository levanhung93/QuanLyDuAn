namespace QuanLySinhVien.GUI
{
    partial class DangKyDeTai
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
            this._grbDatGiaoVien = new System.Windows.Forms.GroupBox();
            this._dgvDSDeTai_GiaoVien = new System.Windows.Forms.DataGridView();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this._txtTimKiemDeTaiDK = new System.Windows.Forms.TextBox();
            this._btnDangKyDeTai = new System.Windows.Forms.Label();
            this._grbThongTinGiaoVienHD = new System.Windows.Forms.GroupBox();
            this._txtDienThoaiCQ = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this._txtTenDeTai = new System.Windows.Forms.TextBox();
            this._txtMaDeTai = new System.Windows.Forms.TextBox();
            this._txtEmailCQ = new System.Windows.Forms.TextBox();
            this._txtDiaChiCQ = new System.Windows.Forms.TextBox();
            this._txtTenCoQuanTT = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this._cboMaGiaoVienHD = new System.Windows.Forms.ComboBox();
            this._txtTenGiaoVienHD = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this._btnTimKiemDeTaiDK = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this._txtTongBanGhi = new System.Windows.Forms.TextBox();
            this._grbDatGiaoVien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._dgvDSDeTai_GiaoVien)).BeginInit();
            this._grbThongTinGiaoVienHD.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(432, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "ĐĂNG KÝ ĐỀ TÀI THỰC TẬP";
            // 
            // _grbDatGiaoVien
            // 
            this._grbDatGiaoVien.Controls.Add(this._dgvDSDeTai_GiaoVien);
            this._grbDatGiaoVien.Location = new System.Drawing.Point(30, 305);
            this._grbDatGiaoVien.Name = "_grbDatGiaoVien";
            this._grbDatGiaoVien.Size = new System.Drawing.Size(964, 173);
            this._grbDatGiaoVien.TabIndex = 27;
            this._grbDatGiaoVien.TabStop = false;
            this._grbDatGiaoVien.Text = "Thông tin ";
            // 
            // _dgvDSDeTai_GiaoVien
            // 
            this._dgvDSDeTai_GiaoVien.AllowUserToAddRows = false;
            this._dgvDSDeTai_GiaoVien.BackgroundColor = System.Drawing.SystemColors.Control;
            this._dgvDSDeTai_GiaoVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._dgvDSDeTai_GiaoVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column7,
            this.Column8,
            this.Column5,
            this.Column6});
            this._dgvDSDeTai_GiaoVien.Location = new System.Drawing.Point(27, 22);
            this._dgvDSDeTai_GiaoVien.Name = "_dgvDSDeTai_GiaoVien";
            this._dgvDSDeTai_GiaoVien.Size = new System.Drawing.Size(917, 134);
            this._dgvDSDeTai_GiaoVien.TabIndex = 0;
            this._dgvDSDeTai_GiaoVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DSDeTai_GiaoVien_CellClick);
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "MaDeTai";
            this.Column7.HeaderText = "Mã đề tài";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "TenDeTai";
            this.Column8.HeaderText = "Tên đề tài";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Width = 420;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "MaGV";
            this.Column5.HeaderText = "Mã giáo viên";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 150;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "TenGV";
            this.Column6.HeaderText = "Tên giáo viên";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 203;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(655, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 16);
            this.label6.TabIndex = 24;
            this.label6.Text = "Tìm kiếm";
            // 
            // _txtTimKiemDeTaiDK
            // 
            this._txtTimKiemDeTaiDK.Location = new System.Drawing.Point(725, 24);
            this._txtTimKiemDeTaiDK.Name = "_txtTimKiemDeTaiDK";
            this._txtTimKiemDeTaiDK.Size = new System.Drawing.Size(169, 22);
            this._txtTimKiemDeTaiDK.TabIndex = 25;
            this._txtTimKiemDeTaiDK.Text = "nhập tên đề tài tìm kiếm...";
            // 
            // _btnDangKyDeTai
            // 
            this._btnDangKyDeTai.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._btnDangKyDeTai.Cursor = System.Windows.Forms.Cursors.Hand;
            this._btnDangKyDeTai.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnDangKyDeTai.Location = new System.Drawing.Point(435, 251);
            this._btnDangKyDeTai.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this._btnDangKyDeTai.Name = "_btnDangKyDeTai";
            this._btnDangKyDeTai.Size = new System.Drawing.Size(125, 39);
            this._btnDangKyDeTai.TabIndex = 26;
            this._btnDangKyDeTai.Text = "Đăng ký đề tài";
            this._btnDangKyDeTai.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this._btnDangKyDeTai.Click += new System.EventHandler(this._btnDangKyDeTai_Click);
            // 
            // _grbThongTinGiaoVienHD
            // 
            this._grbThongTinGiaoVienHD.Controls.Add(this._txtDienThoaiCQ);
            this._grbThongTinGiaoVienHD.Controls.Add(this.label10);
            this._grbThongTinGiaoVienHD.Controls.Add(this._txtTenDeTai);
            this._grbThongTinGiaoVienHD.Controls.Add(this._txtMaDeTai);
            this._grbThongTinGiaoVienHD.Controls.Add(this._txtEmailCQ);
            this._grbThongTinGiaoVienHD.Controls.Add(this._txtDiaChiCQ);
            this._grbThongTinGiaoVienHD.Controls.Add(this._txtTenCoQuanTT);
            this._grbThongTinGiaoVienHD.Controls.Add(this.label9);
            this._grbThongTinGiaoVienHD.Controls.Add(this.label8);
            this._grbThongTinGiaoVienHD.Controls.Add(this.label7);
            this._grbThongTinGiaoVienHD.Controls.Add(this._cboMaGiaoVienHD);
            this._grbThongTinGiaoVienHD.Controls.Add(this._txtTenGiaoVienHD);
            this._grbThongTinGiaoVienHD.Controls.Add(this.label5);
            this._grbThongTinGiaoVienHD.Controls.Add(this.label4);
            this._grbThongTinGiaoVienHD.Controls.Add(this.label3);
            this._grbThongTinGiaoVienHD.Controls.Add(this.label2);
            this._grbThongTinGiaoVienHD.Location = new System.Drawing.Point(30, 46);
            this._grbThongTinGiaoVienHD.Name = "_grbThongTinGiaoVienHD";
            this._grbThongTinGiaoVienHD.Size = new System.Drawing.Size(964, 201);
            this._grbThongTinGiaoVienHD.TabIndex = 23;
            this._grbThongTinGiaoVienHD.TabStop = false;
            this._grbThongTinGiaoVienHD.Text = "Thông tin giáo viên hướng dẫn";
            // 
            // _txtDienThoaiCQ
            // 
            this._txtDienThoaiCQ.Location = new System.Drawing.Point(628, 139);
            this._txtDienThoaiCQ.Name = "_txtDienThoaiCQ";
            this._txtDienThoaiCQ.Size = new System.Drawing.Size(221, 22);
            this._txtDienThoaiCQ.TabIndex = 22;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(507, 139);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(118, 16);
            this.label10.TabIndex = 21;
            this.label10.Text = "Điện thoại cơ quan";
            // 
            // _txtTenDeTai
            // 
            this._txtTenDeTai.Enabled = false;
            this._txtTenDeTai.Location = new System.Drawing.Point(190, 124);
            this._txtTenDeTai.Multiline = true;
            this._txtTenDeTai.Name = "_txtTenDeTai";
            this._txtTenDeTai.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this._txtTenDeTai.Size = new System.Drawing.Size(221, 49);
            this._txtTenDeTai.TabIndex = 20;
            // 
            // _txtMaDeTai
            // 
            this._txtMaDeTai.Enabled = false;
            this._txtMaDeTai.Location = new System.Drawing.Point(190, 96);
            this._txtMaDeTai.Name = "_txtMaDeTai";
            this._txtMaDeTai.Size = new System.Drawing.Size(221, 22);
            this._txtMaDeTai.TabIndex = 19;
            // 
            // _txtEmailCQ
            // 
            this._txtEmailCQ.Location = new System.Drawing.Point(628, 103);
            this._txtEmailCQ.Name = "_txtEmailCQ";
            this._txtEmailCQ.Size = new System.Drawing.Size(221, 22);
            this._txtEmailCQ.TabIndex = 18;
            // 
            // _txtDiaChiCQ
            // 
            this._txtDiaChiCQ.Location = new System.Drawing.Point(628, 72);
            this._txtDiaChiCQ.Name = "_txtDiaChiCQ";
            this._txtDiaChiCQ.Size = new System.Drawing.Size(221, 22);
            this._txtDiaChiCQ.TabIndex = 17;
            // 
            // _txtTenCoQuanTT
            // 
            this._txtTenCoQuanTT.Location = new System.Drawing.Point(628, 39);
            this._txtTenCoQuanTT.Name = "_txtTenCoQuanTT";
            this._txtTenCoQuanTT.Size = new System.Drawing.Size(221, 22);
            this._txtTenCoQuanTT.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(507, 103);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 16);
            this.label9.TabIndex = 15;
            this.label9.Text = "Email cơ quan";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(507, 72);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 16);
            this.label8.TabIndex = 13;
            this.label8.Text = "Địa chỉ cơ quan";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(89, 98);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 16);
            this.label7.TabIndex = 9;
            this.label7.Text = "Mã đề tài";
            // 
            // _cboMaGiaoVienHD
            // 
            this._cboMaGiaoVienHD.Enabled = false;
            this._cboMaGiaoVienHD.FormattingEnabled = true;
            this._cboMaGiaoVienHD.Location = new System.Drawing.Point(190, 34);
            this._cboMaGiaoVienHD.Name = "_cboMaGiaoVienHD";
            this._cboMaGiaoVienHD.Size = new System.Drawing.Size(221, 24);
            this._cboMaGiaoVienHD.TabIndex = 7;
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
            this.label5.Size = new System.Drawing.Size(111, 16);
            this.label5.TabIndex = 3;
            this.label5.Text = "Cơ quan thực tập";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(89, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Tên đề tài";
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
            // _btnTimKiemDeTaiDK
            // 
            this._btnTimKiemDeTaiDK.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._btnTimKiemDeTaiDK.Cursor = System.Windows.Forms.Cursors.Hand;
            this._btnTimKiemDeTaiDK.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnTimKiemDeTaiDK.Location = new System.Drawing.Point(913, 25);
            this._btnTimKiemDeTaiDK.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this._btnTimKiemDeTaiDK.Name = "_btnTimKiemDeTaiDK";
            this._btnTimKiemDeTaiDK.Size = new System.Drawing.Size(73, 22);
            this._btnTimKiemDeTaiDK.TabIndex = 28;
            this._btnTimKiemDeTaiDK.Text = "Tìm";
            this._btnTimKiemDeTaiDK.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this._btnTimKiemDeTaiDK.Click += new System.EventHandler(this._btnTimKiemDeTaiDK_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(124, 286);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(100, 16);
            this.label11.TabIndex = 29;
            this.label11.Text = "Tổng số bản ghi";
            // 
            // _txtTongBanGhi
            // 
            this._txtTongBanGhi.Enabled = false;
            this._txtTongBanGhi.Location = new System.Drawing.Point(235, 286);
            this._txtTongBanGhi.Name = "_txtTongBanGhi";
            this._txtTongBanGhi.Size = new System.Drawing.Size(82, 22);
            this._txtTongBanGhi.TabIndex = 30;
            // 
            // DangKyDeTai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this._txtTongBanGhi);
            this.Controls.Add(this.label11);
            this.Controls.Add(this._btnTimKiemDeTaiDK);
            this.Controls.Add(this._grbDatGiaoVien);
            this.Controls.Add(this.label6);
            this.Controls.Add(this._txtTimKiemDeTaiDK);
            this.Controls.Add(this._btnDangKyDeTai);
            this.Controls.Add(this._grbThongTinGiaoVienHD);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DangKyDeTai";
            this.Size = new System.Drawing.Size(1024, 486);
            this.Load += new System.EventHandler(this.DangKyDeTai_Load);
            this._grbDatGiaoVien.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._dgvDSDeTai_GiaoVien)).EndInit();
            this._grbThongTinGiaoVienHD.ResumeLayout(false);
            this._grbThongTinGiaoVienHD.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox _grbDatGiaoVien;
        private System.Windows.Forms.DataGridView _dgvDSDeTai_GiaoVien;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox _txtTimKiemDeTaiDK;
        private System.Windows.Forms.Label _btnDangKyDeTai;
        private System.Windows.Forms.GroupBox _grbThongTinGiaoVienHD;
        private System.Windows.Forms.TextBox _txtEmailCQ;
        private System.Windows.Forms.TextBox _txtDiaChiCQ;
        private System.Windows.Forms.TextBox _txtTenCoQuanTT;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox _cboMaGiaoVienHD;
        private System.Windows.Forms.TextBox _txtTenGiaoVienHD;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label _btnTimKiemDeTaiDK;
        private System.Windows.Forms.TextBox _txtMaDeTai;
        private System.Windows.Forms.TextBox _txtDienThoaiCQ;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox _txtTenDeTai;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox _txtTongBanGhi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
    }
}
