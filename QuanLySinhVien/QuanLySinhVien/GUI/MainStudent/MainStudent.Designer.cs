namespace QuanLySinhVien
{
    partial class MainStudent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainStudent));
            this._panelTop = new System.Windows.Forms.Panel();
            this._lblMiniMize = new System.Windows.Forms.Label();
            this._lblClose = new System.Windows.Forms.Label();
            this._panelBottom = new System.Windows.Forms.Panel();
            this._lbScreenInfo = new System.Windows.Forms.Label();
            this._lbTime = new System.Windows.Forms.Label();
            this._panelTopRight = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this._btnBaoCao = new System.Windows.Forms.Label();
            this._btnTroGiup = new System.Windows.Forms.Label();
            this._btnDeTaiTT = new System.Windows.Forms.Label();
            this._btnDangKyDeTai = new System.Windows.Forms.Label();
            this._btnHuyDeTai = new System.Windows.Forms.Label();
            this._btnDiem = new System.Windows.Forms.Label();
            this._btnSinhVienTT = new System.Windows.Forms.Label();
            this._btnGiaoVienHD = new System.Windows.Forms.Label();
            this._menuTaiKhoan = new System.Windows.Forms.MenuStrip();
            this._taiKhoan = new System.Windows.Forms.ToolStripMenuItem();
            this._menuThayDoiMK = new System.Windows.Forms.ToolStripMenuItem();
            this._menuDangXuat = new System.Windows.Forms.ToolStripMenuItem();
            this._panelMain = new System.Windows.Forms.Panel();
            this._panelTop.SuspendLayout();
            this._panelBottom.SuspendLayout();
            this._panelTopRight.SuspendLayout();
            this._menuTaiKhoan.SuspendLayout();
            this.SuspendLayout();
            // 
            // _panelTop
            // 
            this._panelTop.BackgroundImage = global::QuanLySinhVien.Properties.Resources.header;
            this._panelTop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._panelTop.Controls.Add(this._lblMiniMize);
            this._panelTop.Controls.Add(this._lblClose);
            this._panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this._panelTop.Location = new System.Drawing.Point(0, 0);
            this._panelTop.Name = "_panelTop";
            this._panelTop.Size = new System.Drawing.Size(1024, 40);
            this._panelTop.TabIndex = 0;
            this._panelTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnPanelTopMouseDown);
            this._panelTop.MouseMove += new System.Windows.Forms.MouseEventHandler(this.OnPanelTopMouseMove);
            this._panelTop.MouseUp += new System.Windows.Forms.MouseEventHandler(this.OnPanelTopMouseUp);
            // 
            // _lblMiniMize
            // 
            this._lblMiniMize.Cursor = System.Windows.Forms.Cursors.Hand;
            this._lblMiniMize.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblMiniMize.Location = new System.Drawing.Point(935, 7);
            this._lblMiniMize.Name = "_lblMiniMize";
            this._lblMiniMize.Size = new System.Drawing.Size(40, 26);
            this._lblMiniMize.TabIndex = 1;
            this._lblMiniMize.Text = "-";
            this._lblMiniMize.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this._lblMiniMize.Click += new System.EventHandler(this.OnMiniMizeClick);
            this._lblMiniMize.MouseLeave += new System.EventHandler(this.OnMiniMizeMouseLeave);
            this._lblMiniMize.MouseMove += new System.Windows.Forms.MouseEventHandler(this.OnMiniMizeMouseMove);
            // 
            // _lblClose
            // 
            this._lblClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this._lblClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblClose.Location = new System.Drawing.Point(981, 7);
            this._lblClose.Name = "_lblClose";
            this._lblClose.Size = new System.Drawing.Size(40, 26);
            this._lblClose.TabIndex = 0;
            this._lblClose.Text = "X";
            this._lblClose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this._lblClose.Click += new System.EventHandler(this.OnCloseClick);
            this._lblClose.MouseLeave += new System.EventHandler(this.OnCloseMouseLeave);
            this._lblClose.MouseMove += new System.Windows.Forms.MouseEventHandler(this.OnCloseMouseMove);
            // 
            // _panelBottom
            // 
            this._panelBottom.BackColor = System.Drawing.Color.White;
            this._panelBottom.BackgroundImage = global::QuanLySinhVien.Properties.Resources.footer;
            this._panelBottom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._panelBottom.Controls.Add(this._lbScreenInfo);
            this._panelBottom.Controls.Add(this._lbTime);
            this._panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this._panelBottom.Location = new System.Drawing.Point(0, 620);
            this._panelBottom.Name = "_panelBottom";
            this._panelBottom.Size = new System.Drawing.Size(1024, 30);
            this._panelBottom.TabIndex = 1;
            // 
            // _lbScreenInfo
            // 
            this._lbScreenInfo.ForeColor = System.Drawing.Color.White;
            this._lbScreenInfo.Image = global::QuanLySinhVien.Properties.Resources.footer;
            this._lbScreenInfo.Location = new System.Drawing.Point(140, 6);
            this._lbScreenInfo.Name = "_lbScreenInfo";
            this._lbScreenInfo.Size = new System.Drawing.Size(353, 19);
            this._lbScreenInfo.TabIndex = 2;
            this._lbScreenInfo.Text = "Chức năng: ";
            this._lbScreenInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // _lbTime
            // 
            this._lbTime.ForeColor = System.Drawing.Color.White;
            this._lbTime.Image = global::QuanLySinhVien.Properties.Resources.footer;
            this._lbTime.Location = new System.Drawing.Point(656, 5);
            this._lbTime.Name = "_lbTime";
            this._lbTime.Size = new System.Drawing.Size(353, 19);
            this._lbTime.TabIndex = 1;
            this._lbTime.Text = "00 : 00 : 00";
            this._lbTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // _panelTopRight
            // 
            this._panelTopRight.BackgroundImage = global::QuanLySinhVien.Properties.Resources.background_top;
            this._panelTopRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._panelTopRight.Controls.Add(this.label1);
            this._panelTopRight.Controls.Add(this._btnBaoCao);
            this._panelTopRight.Controls.Add(this._btnTroGiup);
            this._panelTopRight.Controls.Add(this._btnDeTaiTT);
            this._panelTopRight.Controls.Add(this._btnDangKyDeTai);
            this._panelTopRight.Controls.Add(this._btnHuyDeTai);
            this._panelTopRight.Controls.Add(this._btnDiem);
            this._panelTopRight.Controls.Add(this._btnSinhVienTT);
            this._panelTopRight.Controls.Add(this._btnGiaoVienHD);
            this._panelTopRight.Controls.Add(this._menuTaiKhoan);
            this._panelTopRight.Dock = System.Windows.Forms.DockStyle.Top;
            this._panelTopRight.Location = new System.Drawing.Point(0, 40);
            this._panelTopRight.Name = "_panelTopRight";
            this._panelTopRight.Size = new System.Drawing.Size(1024, 94);
            this._panelTopRight.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Image = global::QuanLySinhVien.Properties.Resources.background_top;
            this.label1.Location = new System.Drawing.Point(37, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Xin chào:";
            // 
            // _btnBaoCao
            // 
            this._btnBaoCao.BackColor = System.Drawing.Color.Transparent;
            this._btnBaoCao.Cursor = System.Windows.Forms.Cursors.Hand;
            this._btnBaoCao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnBaoCao.Image = global::QuanLySinhVien.Properties.Resources.report;
            this._btnBaoCao.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this._btnBaoCao.Location = new System.Drawing.Point(823, 12);
            this._btnBaoCao.Name = "_btnBaoCao";
            this._btnBaoCao.Size = new System.Drawing.Size(100, 60);
            this._btnBaoCao.TabIndex = 7;
            this._btnBaoCao.Text = "Báo cáo";
            this._btnBaoCao.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this._btnBaoCao.Click += new System.EventHandler(this.OnBtnBaoCaoClick);
            this._btnBaoCao.MouseLeave += new System.EventHandler(this.OnLblBaoCaoMouseLeave);
            this._btnBaoCao.MouseMove += new System.Windows.Forms.MouseEventHandler(this.OnLblBaoCaoMouseMove);
            // 
            // _btnTroGiup
            // 
            this._btnTroGiup.BackColor = System.Drawing.Color.Transparent;
            this._btnTroGiup.Cursor = System.Windows.Forms.Cursors.Hand;
            this._btnTroGiup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnTroGiup.Image = global::QuanLySinhVien.Properties.Resources.help;
            this._btnTroGiup.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this._btnTroGiup.Location = new System.Drawing.Point(912, 12);
            this._btnTroGiup.Name = "_btnTroGiup";
            this._btnTroGiup.Size = new System.Drawing.Size(100, 60);
            this._btnTroGiup.TabIndex = 6;
            this._btnTroGiup.Text = "Trợ giúp";
            this._btnTroGiup.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this._btnTroGiup.Click += new System.EventHandler(this.OnBtnTroGiupClick);
            this._btnTroGiup.MouseLeave += new System.EventHandler(this.OnLblTroGiupMouseLeave);
            this._btnTroGiup.MouseMove += new System.Windows.Forms.MouseEventHandler(this.OnLblTroGiupMouseMove);
            // 
            // _btnDeTaiTT
            // 
            this._btnDeTaiTT.BackColor = System.Drawing.Color.Transparent;
            this._btnDeTaiTT.Cursor = System.Windows.Forms.Cursors.Hand;
            this._btnDeTaiTT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnDeTaiTT.Image = global::QuanLySinhVien.Properties.Resources.abc;
            this._btnDeTaiTT.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this._btnDeTaiTT.Location = new System.Drawing.Point(181, 12);
            this._btnDeTaiTT.Name = "_btnDeTaiTT";
            this._btnDeTaiTT.Size = new System.Drawing.Size(100, 60);
            this._btnDeTaiTT.TabIndex = 5;
            this._btnDeTaiTT.Text = "Đề tài thực tập";
            this._btnDeTaiTT.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this._btnDeTaiTT.Click += new System.EventHandler(this.OnBtnDeTaiTTClick);
            this._btnDeTaiTT.MouseLeave += new System.EventHandler(this.OnLblDeTaiTTMouseLeave);
            this._btnDeTaiTT.MouseMove += new System.Windows.Forms.MouseEventHandler(this.OnLblDeTaiTTMouseMove);
            // 
            // _btnDangKyDeTai
            // 
            this._btnDangKyDeTai.BackColor = System.Drawing.Color.Transparent;
            this._btnDangKyDeTai.Cursor = System.Windows.Forms.Cursors.Hand;
            this._btnDangKyDeTai.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnDangKyDeTai.Image = global::QuanLySinhVien.Properties.Resources.clipboard_paste1;
            this._btnDangKyDeTai.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this._btnDangKyDeTai.Location = new System.Drawing.Point(287, 12);
            this._btnDangKyDeTai.Name = "_btnDangKyDeTai";
            this._btnDangKyDeTai.Size = new System.Drawing.Size(100, 60);
            this._btnDangKyDeTai.TabIndex = 4;
            this._btnDangKyDeTai.Text = "Đăng ký đề tai";
            this._btnDangKyDeTai.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this._btnDangKyDeTai.Click += new System.EventHandler(this.OnBtnDangKyDeTaiClick);
            this._btnDangKyDeTai.MouseLeave += new System.EventHandler(this.OnLblDangKyDeTaiMouseLeave);
            this._btnDangKyDeTai.MouseMove += new System.Windows.Forms.MouseEventHandler(this.OnLblDangKyDeTaiMouseMove);
            // 
            // _btnHuyDeTai
            // 
            this._btnHuyDeTai.BackColor = System.Drawing.Color.Transparent;
            this._btnHuyDeTai.Cursor = System.Windows.Forms.Cursors.Hand;
            this._btnHuyDeTai.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnHuyDeTai.Image = global::QuanLySinhVien.Properties.Resources.clipboard_paste;
            this._btnHuyDeTai.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this._btnHuyDeTai.Location = new System.Drawing.Point(393, 12);
            this._btnHuyDeTai.Name = "_btnHuyDeTai";
            this._btnHuyDeTai.Size = new System.Drawing.Size(100, 60);
            this._btnHuyDeTai.TabIndex = 3;
            this._btnHuyDeTai.Text = "Hủy đề tài";
            this._btnHuyDeTai.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this._btnHuyDeTai.Click += new System.EventHandler(this.OnBtnHuyDeTaiClick);
            this._btnHuyDeTai.MouseLeave += new System.EventHandler(this.OnLblHuyDeTaiMouseLeave);
            this._btnHuyDeTai.MouseMove += new System.Windows.Forms.MouseEventHandler(this.OnLblHuyDeTaiMouseMove);
            // 
            // _btnDiem
            // 
            this._btnDiem.BackColor = System.Drawing.Color.Transparent;
            this._btnDiem.Cursor = System.Windows.Forms.Cursors.Hand;
            this._btnDiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnDiem.Image = global::QuanLySinhVien.Properties.Resources.e;
            this._btnDiem.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this._btnDiem.Location = new System.Drawing.Point(509, 12);
            this._btnDiem.Name = "_btnDiem";
            this._btnDiem.Size = new System.Drawing.Size(100, 60);
            this._btnDiem.TabIndex = 2;
            this._btnDiem.Text = "Điểm thực tập";
            this._btnDiem.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this._btnDiem.Click += new System.EventHandler(this.OnBtnDiemClick);
            this._btnDiem.MouseLeave += new System.EventHandler(this.OnLblDiemMouseLeave);
            this._btnDiem.MouseMove += new System.Windows.Forms.MouseEventHandler(this.OnLblDiemMouseMove);
            // 
            // _btnSinhVienTT
            // 
            this._btnSinhVienTT.BackColor = System.Drawing.Color.Transparent;
            this._btnSinhVienTT.Cursor = System.Windows.Forms.Cursors.Hand;
            this._btnSinhVienTT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnSinhVienTT.Image = global::QuanLySinhVien.Properties.Resources.f;
            this._btnSinhVienTT.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this._btnSinhVienTT.Location = new System.Drawing.Point(613, 12);
            this._btnSinhVienTT.Name = "_btnSinhVienTT";
            this._btnSinhVienTT.Size = new System.Drawing.Size(100, 60);
            this._btnSinhVienTT.TabIndex = 1;
            this._btnSinhVienTT.Text = "SV thực tập";
            this._btnSinhVienTT.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this._btnSinhVienTT.Click += new System.EventHandler(this.OnBtnSinhVienTTClick);
            this._btnSinhVienTT.MouseLeave += new System.EventHandler(this.OnLblSinhVienTTMouseLeave);
            this._btnSinhVienTT.MouseMove += new System.Windows.Forms.MouseEventHandler(this.OnLblSinhVienTTMouseMove);
            // 
            // _btnGiaoVienHD
            // 
            this._btnGiaoVienHD.BackColor = System.Drawing.Color.Transparent;
            this._btnGiaoVienHD.Cursor = System.Windows.Forms.Cursors.Hand;
            this._btnGiaoVienHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnGiaoVienHD.Image = global::QuanLySinhVien.Properties.Resources.d;
            this._btnGiaoVienHD.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this._btnGiaoVienHD.Location = new System.Drawing.Point(719, 12);
            this._btnGiaoVienHD.Name = "_btnGiaoVienHD";
            this._btnGiaoVienHD.Size = new System.Drawing.Size(100, 60);
            this._btnGiaoVienHD.TabIndex = 0;
            this._btnGiaoVienHD.Text = "GV hướng dẫn";
            this._btnGiaoVienHD.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this._btnGiaoVienHD.Click += new System.EventHandler(this.OnBtnGiaoVienHDClick);
            this._btnGiaoVienHD.MouseLeave += new System.EventHandler(this.OnLblGiaoVienHDMouseLeave);
            this._btnGiaoVienHD.MouseMove += new System.Windows.Forms.MouseEventHandler(this.OnLblGiaoVienHDMouseMove);
            // 
            // _menuTaiKhoan
            // 
            this._menuTaiKhoan.BackgroundImage = global::QuanLySinhVien.Properties.Resources.background_top;
            this._menuTaiKhoan.Dock = System.Windows.Forms.DockStyle.None;
            this._menuTaiKhoan.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._taiKhoan});
            this._menuTaiKhoan.Location = new System.Drawing.Point(19, 48);
            this._menuTaiKhoan.Name = "_menuTaiKhoan";
            this._menuTaiKhoan.Size = new System.Drawing.Size(88, 24);
            this._menuTaiKhoan.TabIndex = 8;
            this._menuTaiKhoan.Text = "menuStrip1";
            // 
            // _taiKhoan
            // 
            this._taiKhoan.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._menuThayDoiMK,
            this._menuDangXuat});
            this._taiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._taiKhoan.Name = "_taiKhoan";
            this._taiKhoan.Size = new System.Drawing.Size(80, 20);
            this._taiKhoan.Text = "Tài khoản";
            // 
            // _menuThayDoiMK
            // 
            this._menuThayDoiMK.Image = global::QuanLySinhVien.Properties.Resources.doipass;
            this._menuThayDoiMK.Name = "_menuThayDoiMK";
            this._menuThayDoiMK.Size = new System.Drawing.Size(186, 22);
            this._menuThayDoiMK.Text = "Thay đổi mật khẩu";
            this._menuThayDoiMK.Click += new System.EventHandler(this.OnMenuThayDoiMKClick);
            // 
            // _menuDangXuat
            // 
            this._menuDangXuat.Image = global::QuanLySinhVien.Properties.Resources.logout_2;
            this._menuDangXuat.Name = "_menuDangXuat";
            this._menuDangXuat.Size = new System.Drawing.Size(186, 22);
            this._menuDangXuat.Text = "Đăng xuất";
            this._menuDangXuat.Click += new System.EventHandler(this.OnMenuDangXuatClick);
            // 
            // _panelMain
            // 
            this._panelMain.BackgroundImage = global::QuanLySinhVien.Properties.Resources.background_software;
            this._panelMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._panelMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this._panelMain.Location = new System.Drawing.Point(0, 134);
            this._panelMain.Name = "_panelMain";
            this._panelMain.Size = new System.Drawing.Size(1024, 486);
            this._panelMain.TabIndex = 6;
            // 
            // MainStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QuanLySinhVien.Properties.Resources.image_blue_background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1024, 650);
            this.Controls.Add(this._panelMain);
            this.Controls.Add(this._panelTopRight);
            this.Controls.Add(this._panelBottom);
            this.Controls.Add(this._panelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this._menuTaiKhoan;
            this.Name = "MainStudent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý sinh viên thực tập";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OnMainStudentFormClosing);
            this.Load += new System.EventHandler(this.MainStuden_Load);
            this._panelTop.ResumeLayout(false);
            this._panelBottom.ResumeLayout(false);
            this._panelTopRight.ResumeLayout(false);
            this._panelTopRight.PerformLayout();
            this._menuTaiKhoan.ResumeLayout(false);
            this._menuTaiKhoan.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel _panelTop;
        private System.Windows.Forms.Label _lblClose;
        private System.Windows.Forms.Label _lblMiniMize;
        private System.Windows.Forms.Panel _panelBottom;
        private System.Windows.Forms.Label _lbTime;
        private System.Windows.Forms.Panel _panelTopRight;
        private System.Windows.Forms.Label _btnBaoCao;
        private System.Windows.Forms.Label _btnTroGiup;
        private System.Windows.Forms.Label _btnDeTaiTT;
        private System.Windows.Forms.Label _btnDangKyDeTai;
        private System.Windows.Forms.Label _btnHuyDeTai;
        private System.Windows.Forms.Label _btnDiem;
        private System.Windows.Forms.Label _btnSinhVienTT;
        private System.Windows.Forms.Label _btnGiaoVienHD;
        private System.Windows.Forms.Panel _panelMain;
        private System.Windows.Forms.MenuStrip _menuTaiKhoan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem _taiKhoan;
        private System.Windows.Forms.ToolStripMenuItem _menuThayDoiMK;
        private System.Windows.Forms.ToolStripMenuItem _menuDangXuat;
        private System.Windows.Forms.Label _lbScreenInfo;
    }
}

