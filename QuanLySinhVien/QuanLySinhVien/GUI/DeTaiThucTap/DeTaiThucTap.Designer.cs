namespace QuanLySinhVien.GUI
{
    partial class DeTaiThucTap
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
            this._grbThongTinDeTai = new System.Windows.Forms.GroupBox();
            this._cboMaGiaoVienHD = new System.Windows.Forms.ComboBox();
            this._txtTenGiaoVienHD = new System.Windows.Forms.TextBox();
            this._txtTenDeTai = new System.Windows.Forms.TextBox();
            this._txtMaDeTai = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this._btnThemDeTai = new System.Windows.Forms.Label();
            this._btnSuaDeTai = new System.Windows.Forms.Label();
            this._btnXoaDeTai = new System.Windows.Forms.Label();
            this._btnLuuDeTai = new System.Windows.Forms.Label();
            this._grbDataDeTai = new System.Windows.Forms.GroupBox();
            this._dgvDeTai = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this._txtTimKiemDeTai = new System.Windows.Forms.TextBox();
            this._btnTimKiemDeTai = new System.Windows.Forms.Label();
            this._txtTongBanGhi = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this._grbThongTinDeTai.SuspendLayout();
            this._grbDataDeTai.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._dgvDeTai)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(437, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "THÔNG TIN ĐỀ TÀI THỰC TẬP";
            // 
            // _grbThongTinDeTai
            // 
            this._grbThongTinDeTai.Controls.Add(this._cboMaGiaoVienHD);
            this._grbThongTinDeTai.Controls.Add(this._txtTenGiaoVienHD);
            this._grbThongTinDeTai.Controls.Add(this._txtTenDeTai);
            this._grbThongTinDeTai.Controls.Add(this._txtMaDeTai);
            this._grbThongTinDeTai.Controls.Add(this.label5);
            this._grbThongTinDeTai.Controls.Add(this.label4);
            this._grbThongTinDeTai.Controls.Add(this.label3);
            this._grbThongTinDeTai.Controls.Add(this.label2);
            this._grbThongTinDeTai.Location = new System.Drawing.Point(31, 58);
            this._grbThongTinDeTai.Name = "_grbThongTinDeTai";
            this._grbThongTinDeTai.Size = new System.Drawing.Size(964, 167);
            this._grbThongTinDeTai.TabIndex = 1;
            this._grbThongTinDeTai.TabStop = false;
            this._grbThongTinDeTai.Text = "Thông tin đề tài";
            // 
            // _cboMaGiaoVienHD
            // 
            this._cboMaGiaoVienHD.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this._cboMaGiaoVienHD.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this._cboMaGiaoVienHD.Enabled = false;
            this._cboMaGiaoVienHD.FormattingEnabled = true;
            this._cboMaGiaoVienHD.Location = new System.Drawing.Point(683, 34);
            this._cboMaGiaoVienHD.Name = "_cboMaGiaoVienHD";
            this._cboMaGiaoVienHD.Size = new System.Drawing.Size(221, 24);
            this._cboMaGiaoVienHD.TabIndex = 7;
            this._cboMaGiaoVienHD.SelectedIndexChanged += new System.EventHandler(this.OnCboMaGiaoVienHDSelectedIndexChanged);
            // 
            // _txtTenGiaoVienHD
            // 
            this._txtTenGiaoVienHD.Enabled = false;
            this._txtTenGiaoVienHD.Location = new System.Drawing.Point(683, 79);
            this._txtTenGiaoVienHD.Name = "_txtTenGiaoVienHD";
            this._txtTenGiaoVienHD.Size = new System.Drawing.Size(221, 22);
            this._txtTenGiaoVienHD.TabIndex = 6;
            // 
            // _txtTenDeTai
            // 
            this._txtTenDeTai.Enabled = false;
            this._txtTenDeTai.Location = new System.Drawing.Point(187, 73);
            this._txtTenDeTai.Multiline = true;
            this._txtTenDeTai.Name = "_txtTenDeTai";
            this._txtTenDeTai.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this._txtTenDeTai.Size = new System.Drawing.Size(221, 77);
            this._txtTenDeTai.TabIndex = 5;
            // 
            // _txtMaDeTai
            // 
            this._txtMaDeTai.Enabled = false;
            this._txtMaDeTai.Location = new System.Drawing.Point(187, 34);
            this._txtMaDeTai.Name = "_txtMaDeTai";
            this._txtMaDeTai.Size = new System.Drawing.Size(221, 22);
            this._txtMaDeTai.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(507, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(156, 16);
            this.label5.TabIndex = 3;
            this.label5.Text = "Tên giáo viên hướng dẫn";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(507, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Mã giáo viên hướng dẫn";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(89, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tên đề tài";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(89, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã đề tài";
            // 
            // _btnThemDeTai
            // 
            this._btnThemDeTai.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._btnThemDeTai.Cursor = System.Windows.Forms.Cursors.Hand;
            this._btnThemDeTai.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnThemDeTai.Location = new System.Drawing.Point(132, 234);
            this._btnThemDeTai.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this._btnThemDeTai.Name = "_btnThemDeTai";
            this._btnThemDeTai.Size = new System.Drawing.Size(125, 39);
            this._btnThemDeTai.TabIndex = 9;
            this._btnThemDeTai.Text = "Thêm đề tài";
            this._btnThemDeTai.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this._btnThemDeTai.Click += new System.EventHandler(this.OnBtnThemDeTaiClick);
            // 
            // _btnSuaDeTai
            // 
            this._btnSuaDeTai.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._btnSuaDeTai.Cursor = System.Windows.Forms.Cursors.Hand;
            this._btnSuaDeTai.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnSuaDeTai.Location = new System.Drawing.Point(355, 234);
            this._btnSuaDeTai.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this._btnSuaDeTai.Name = "_btnSuaDeTai";
            this._btnSuaDeTai.Size = new System.Drawing.Size(125, 39);
            this._btnSuaDeTai.TabIndex = 10;
            this._btnSuaDeTai.Text = "Sửa đề tài";
            this._btnSuaDeTai.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this._btnSuaDeTai.Click += new System.EventHandler(this.OnBtnsuaDeTaiClick);
            // 
            // _btnXoaDeTai
            // 
            this._btnXoaDeTai.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._btnXoaDeTai.Cursor = System.Windows.Forms.Cursors.Hand;
            this._btnXoaDeTai.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnXoaDeTai.Location = new System.Drawing.Point(578, 234);
            this._btnXoaDeTai.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this._btnXoaDeTai.Name = "_btnXoaDeTai";
            this._btnXoaDeTai.Size = new System.Drawing.Size(125, 39);
            this._btnXoaDeTai.TabIndex = 11;
            this._btnXoaDeTai.Text = "Xóa đề tài";
            this._btnXoaDeTai.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this._btnXoaDeTai.Click += new System.EventHandler(this.OnBtnXoaDeTaiClick);
            // 
            // _btnLuuDeTai
            // 
            this._btnLuuDeTai.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._btnLuuDeTai.Cursor = System.Windows.Forms.Cursors.Hand;
            this._btnLuuDeTai.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnLuuDeTai.Location = new System.Drawing.Point(784, 234);
            this._btnLuuDeTai.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this._btnLuuDeTai.Name = "_btnLuuDeTai";
            this._btnLuuDeTai.Size = new System.Drawing.Size(125, 39);
            this._btnLuuDeTai.TabIndex = 12;
            this._btnLuuDeTai.Text = "Lưu đề tài";
            this._btnLuuDeTai.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this._btnLuuDeTai.Click += new System.EventHandler(this.OnBtnLuuDeTaiClick);
            // 
            // _grbDataDeTai
            // 
            this._grbDataDeTai.Controls.Add(this._dgvDeTai);
            this._grbDataDeTai.Location = new System.Drawing.Point(31, 306);
            this._grbDataDeTai.Name = "_grbDataDeTai";
            this._grbDataDeTai.Size = new System.Drawing.Size(964, 173);
            this._grbDataDeTai.TabIndex = 8;
            this._grbDataDeTai.TabStop = false;
            this._grbDataDeTai.Text = "Thông tin đề tài";
            // 
            // _dgvDeTai
            // 
            this._dgvDeTai.AllowUserToAddRows = false;
            this._dgvDeTai.BackgroundColor = System.Drawing.SystemColors.Control;
            this._dgvDeTai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._dgvDeTai.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this._dgvDeTai.Location = new System.Drawing.Point(27, 22);
            this._dgvDeTai.Name = "_dgvDeTai";
            this._dgvDeTai.Size = new System.Drawing.Size(917, 134);
            this._dgvDeTai.TabIndex = 0;
            this._dgvDeTai.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.OnDgvDeTaiCellClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MaDeTai";
            this.Column1.HeaderText = "Mã đề tài";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "TenDeTai";
            this.Column2.HeaderText = "Tên đề tài";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 420;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "MaGV";
            this.Column3.HeaderText = "Mã giáo viên hướng dẫn";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 153;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "TenGV";
            this.Column4.HeaderText = "Tên giáo viên hướng dẫn";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 200;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(656, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 16);
            this.label6.TabIndex = 8;
            this.label6.Text = "Tìm kiếm";
            // 
            // _txtTimKiemDeTai
            // 
            this._txtTimKiemDeTai.Location = new System.Drawing.Point(726, 36);
            this._txtTimKiemDeTai.Name = "_txtTimKiemDeTai";
            this._txtTimKiemDeTai.Size = new System.Drawing.Size(169, 22);
            this._txtTimKiemDeTai.TabIndex = 8;
            this._txtTimKiemDeTai.Text = "nhập tên đề tài tìm kiếm...";
            // 
            // _btnTimKiemDeTai
            // 
            this._btnTimKiemDeTai.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._btnTimKiemDeTai.Cursor = System.Windows.Forms.Cursors.Hand;
            this._btnTimKiemDeTai.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnTimKiemDeTai.Location = new System.Drawing.Point(908, 36);
            this._btnTimKiemDeTai.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this._btnTimKiemDeTai.Name = "_btnTimKiemDeTai";
            this._btnTimKiemDeTai.Size = new System.Drawing.Size(73, 22);
            this._btnTimKiemDeTai.TabIndex = 13;
            this._btnTimKiemDeTai.Text = "Tìm";
            this._btnTimKiemDeTai.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this._btnTimKiemDeTai.Click += new System.EventHandler(this.OnBtnTimKiemDeTaiClick);
            // 
            // _txtTongBanGhi
            // 
            this._txtTongBanGhi.Enabled = false;
            this._txtTongBanGhi.Location = new System.Drawing.Point(303, 287);
            this._txtTongBanGhi.Name = "_txtTongBanGhi";
            this._txtTongBanGhi.Size = new System.Drawing.Size(82, 22);
            this._txtTongBanGhi.TabIndex = 36;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(192, 287);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(105, 16);
            this.label11.TabIndex = 35;
            this.label11.Text = "Tổng số bản ghi";
            // 
            // DeTaiThucTap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this._txtTongBanGhi);
            this.Controls.Add(this.label11);
            this.Controls.Add(this._btnTimKiemDeTai);
            this.Controls.Add(this._txtTimKiemDeTai);
            this.Controls.Add(this.label6);
            this.Controls.Add(this._grbDataDeTai);
            this.Controls.Add(this._btnLuuDeTai);
            this.Controls.Add(this._btnXoaDeTai);
            this.Controls.Add(this._btnSuaDeTai);
            this.Controls.Add(this._btnThemDeTai);
            this.Controls.Add(this._grbThongTinDeTai);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DeTaiThucTap";
            this.Size = new System.Drawing.Size(1024, 486);
            this.Load += new System.EventHandler(this.OnDeTaiThucTapLoad);
            this._grbThongTinDeTai.ResumeLayout(false);
            this._grbThongTinDeTai.PerformLayout();
            this._grbDataDeTai.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._dgvDeTai)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox _grbThongTinDeTai;
        private System.Windows.Forms.ComboBox _cboMaGiaoVienHD;
        private System.Windows.Forms.TextBox _txtTenGiaoVienHD;
        private System.Windows.Forms.TextBox _txtTenDeTai;
        private System.Windows.Forms.TextBox _txtMaDeTai;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label _btnThemDeTai;
        private System.Windows.Forms.Label _btnSuaDeTai;
        private System.Windows.Forms.Label _btnXoaDeTai;
        private System.Windows.Forms.Label _btnLuuDeTai;
        private System.Windows.Forms.GroupBox _grbDataDeTai;
        private System.Windows.Forms.DataGridView _dgvDeTai;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox _txtTimKiemDeTai;
        private System.Windows.Forms.Label _btnTimKiemDeTai;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.TextBox _txtTongBanGhi;
        private System.Windows.Forms.Label label11;
    }
}
