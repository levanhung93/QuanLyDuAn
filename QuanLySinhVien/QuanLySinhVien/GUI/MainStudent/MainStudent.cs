using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using QuanLySinhVien.Common;
using QuanLySinhVien.GUI;

namespace QuanLySinhVien
{
    public partial class MainStudent : Form
    {
        #region Field
        public static string userName = string.Empty;
        public static string quyen = string.Empty;
        public static string pass = string.Empty;
        public static string taiKhoan = string.Empty;
        private Timer _timDisplay;
        private bool _isMousePress = false;
        private Point _lastPoint;
        #endregion Field

        #region Method
        public MainStudent()
        {
            InitializeComponent();
            HandleCreated += OnHandleCreated;
            HandleDestroyed += OnHandleDestroyed;
        }
        #endregion Method

        #region Event
        private void OnHandleDestroyed(object sender, EventArgs e)
        {
            GuiResInfoMng.GuiEventHandle -= OnGuiEvent;
        }

        private void OnHandleCreated(object sender, EventArgs e)
        {
            _timDisplay = new Timer();
            _timDisplay.Interval = 1;
            _timDisplay.Tick += OnTimerTick;
            _timDisplay.Enabled = true;
            GuiResInfoMng.GuiEventHandle += OnGuiEvent;
        }

        private void OnGuiEvent(GuiResInfoMng.GuiEventID e, object data)
        {
            switch (e.ID)
            {
                case GuiResInfoMng.GuiEventID.EventID.None:
                    break;
                case GuiResInfoMng.GuiEventID.EventID.ChangeScreen:
                    string screenName = data as string;
                    _lbScreenInfo.Text = @"Chức năng: " + screenName;
                    break;
            }
        }
        private void OnTimerTick(object sender, EventArgs e)
        {
            _timDisplay.Interval = 1000;
            DateTime dateTime = DateTime.Now;
            _lbTime.Text = string.Format("{0}",
                dateTime.ToString("F"));
        }

        private void OnPanelTopMouseMove(object sender, MouseEventArgs e)
        {
            if (_isMousePress)
            {
                //quyết định cho form chui ra ngoài màn hình
                Point currentPoint = e.Location;
                Point mainLocation = this.Location;
                int scaleX = currentPoint.X - _lastPoint.X;
                int scaleY = currentPoint.Y - _lastPoint.Y;
                this.Location = new Point(mainLocation.X + scaleX, mainLocation.Y + scaleY);
            }
        }

        private void OnPanelTopMouseUp(object sender, MouseEventArgs e)
        {
            _isMousePress = false;
        }

        private void OnPanelTopMouseDown(object sender, MouseEventArgs e)
        {
            _isMousePress = true;
            _lastPoint = e.Location;
        }

        private void OnCloseClick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OnCloseMouseMove(object sender, MouseEventArgs e)
        {
            _lblClose.BackColor = Color.Firebrick;
        }

        private void OnCloseMouseLeave(object sender, EventArgs e)
        {
            _lblClose.BackColor = Color.WhiteSmoke;
        }
        private void OnMiniMizeClick(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void OnMiniMizeMouseMove(object sender, MouseEventArgs e)
        {
            _lblMiniMize.BackColor = Color.White;
        }

        private void OnMiniMizeMouseLeave(object sender, EventArgs e)
        {
            _lblMiniMize.BackColor = Color.WhiteSmoke;
        }

        private void OnLblTroGiupMouseMove(object sender, MouseEventArgs e)
        {
            _btnTroGiup.BackColor = Color.PaleTurquoise;
        }

        private void OnLblTroGiupMouseLeave(object sender, EventArgs e)
        {
            _btnTroGiup.BackColor = Color.Transparent;
        }

        private void OnLblBaoCaoMouseMove(object sender, MouseEventArgs e)
        {
            _btnBaoCao.BackColor = Color.PaleTurquoise;
        }

        private void OnLblBaoCaoMouseLeave(object sender, EventArgs e)
        {
            _btnBaoCao.BackColor = Color.Transparent;
        }

        private void OnLblGiaoVienHDMouseMove(object sender, MouseEventArgs e)
        {
            _btnGiaoVienHD.BackColor = Color.PaleTurquoise;
        }

        private void OnLblGiaoVienHDMouseLeave(object sender, EventArgs e)
        {
            _btnGiaoVienHD.BackColor = Color.Transparent;
        }

        private void OnLblSinhVienTTMouseMove(object sender, MouseEventArgs e)
        {
            _btnSinhVienTT.BackColor = Color.PaleTurquoise;
        }

        private void OnLblSinhVienTTMouseLeave(object sender, EventArgs e)
        {
            _btnSinhVienTT.BackColor = Color.Transparent;
        }

        private void OnLblDiemMouseMove(object sender, MouseEventArgs e)
        {
            _btnDiem.BackColor = Color.PaleTurquoise;
        }

        private void OnLblDiemMouseLeave(object sender, EventArgs e)
        {
            _btnDiem.BackColor = Color.Transparent;
        }

        private void OnLblHuyDeTaiMouseMove(object sender, MouseEventArgs e)
        {
            _btnHuyDeTai.BackColor = Color.PaleTurquoise;
        }

        private void OnLblHuyDeTaiMouseLeave(object sender, EventArgs e)
        {
            _btnHuyDeTai.BackColor = Color.Transparent;
        }

        private void OnLblDangKyDeTaiMouseMove(object sender, MouseEventArgs e)
        {
            _btnDangKyDeTai.BackColor = Color.PaleTurquoise;
        }

        private void OnLblDangKyDeTaiMouseLeave(object sender, EventArgs e)
        {
            _btnDangKyDeTai.BackColor = Color.Transparent;
        }

        private void OnLblDeTaiTTMouseMove(object sender, MouseEventArgs e)
        {
            _btnDeTaiTT.BackColor = Color.PaleTurquoise;
        }

        private void OnLblDeTaiTTMouseLeave(object sender, EventArgs e)
        {
            _btnDeTaiTT.BackColor = Color.Transparent;
        }

        private void MainStuden_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(userName))
                this._taiKhoan.Text = userName;

            //gọi form trang chủ lên
            GuiResInfoMng.ChangeScreen(GuiResInfoMng.ScreenID.TrangChuScreen);
            this._panelMain.Controls.Clear();
            TrangChu trangChu = new TrangChu();
            this._panelMain.Controls.Add(trangChu);
            trangChu.Show();
        }

        private void OnBtnDeTaiTTClick(object sender, EventArgs e)
        {
            GuiResInfoMng.ChangeScreen(GuiResInfoMng.ScreenID.DeTaiThucTapScreen);

            this._panelMain.Controls.Clear();
            DeTaiThucTap dt = new DeTaiThucTap();
            this._panelMain.Controls.Add(dt);
            dt.Show();
        }

        private void OnBtnDangKyDeTaiClick(object sender, EventArgs e)
        {
            GuiResInfoMng.ChangeScreen(GuiResInfoMng.ScreenID.DangKyDeTaiScreen);

            this._panelMain.Controls.Clear();
            DangKyDeTai dkdt = new DangKyDeTai();
            this._panelMain.Controls.Add(dkdt);
            dkdt.Show();
        }

        private void OnBtnHuyDeTaiClick(object sender, EventArgs e)
        {
            GuiResInfoMng.ChangeScreen(GuiResInfoMng.ScreenID.HuyDeTaiDangKyScreen);

            this._panelMain.Controls.Clear();
            HuyDeTaiDangKy huydt = new HuyDeTaiDangKy();
            this._panelMain.Controls.Add(huydt);
            huydt.Show();
        }

        private void OnBtnDiemClick(object sender, EventArgs e)
        {
            GuiResInfoMng.ChangeScreen(GuiResInfoMng.ScreenID.BangDiemScreen);

            this._panelMain.Controls.Clear();
            BangDiem diem = new BangDiem();
            this._panelMain.Controls.Add(diem);
            diem.Show();
        }

        private void OnBtnSinhVienTTClick(object sender, EventArgs e)
        {
            GuiResInfoMng.ChangeScreen(GuiResInfoMng.ScreenID.SinhVienThucTapScreen);

            this._panelMain.Controls.Clear();
            SinhVienThucTap sv = new SinhVienThucTap();
            this._panelMain.Controls.Add(sv);
            sv.Show();
        }

        private void OnBtnGiaoVienHDClick(object sender, EventArgs e)
        {
            GuiResInfoMng.ChangeScreen(GuiResInfoMng.ScreenID.GiaoVienHuongDanScreen);

            this._panelMain.Controls.Clear();
            GiaoVienHuongDan gv = new GiaoVienHuongDan();
            this._panelMain.Controls.Add(gv);
            gv.Show();
        }

        private void OnBtnBaoCaoClick(object sender, EventArgs e)
        {
            GuiResInfoMng.ChangeScreen(GuiResInfoMng.ScreenID.BaoCaoThongKeScreen);

            this._panelMain.Controls.Clear();
            BaoCaoThongKe bctk = new BaoCaoThongKe();
            this._panelMain.Controls.Add(bctk);
            bctk.Show();
        }

        private void OnBtnTroGiupClick(object sender, EventArgs e)
        {
            GuiResInfoMng.ChangeScreen(GuiResInfoMng.ScreenID.TroGiupScreen);

            this._panelMain.Controls.Clear();
            TroGiup tg = new TroGiup();
            this._panelMain.Controls.Add(tg);
            tg.Show();
        }

        private void OnMenuThayDoiMKClick(object sender, EventArgs e)
        {
            MessageDialog messageDialog = new MessageDialog(@"Bạn thực sự muốn thay đổi mật khẩu?", MessageDialog.DialogType.YesNo);
            messageDialog.SendValueDelegate = delegate(MessageDialog.DialogResultType result)
            {
                if (result == MessageDialog.DialogResultType.Yes)
                {
                    DatabaseCore.ReleaseConnect();
                    this.Hide();
                    _frmThayDoiMatKhau tdmk = new _frmThayDoiMatKhau();
                    tdmk.Show();
                }

            };
            messageDialog.ShowDialog();
        }
        private void OnMenuDangXuatClick(object sender, EventArgs e)
        {
            MessageDialog messageDialog = new MessageDialog(@"Bạn thực sự muốn đăng xuất?", MessageDialog.DialogType.YesNo);
            messageDialog.SendValueDelegate = delegate(MessageDialog.DialogResultType result)
            {
                if (result == MessageDialog.DialogResultType.Yes)
                {
                    DatabaseCore.ReleaseConnect();
                    this.Hide();
                    DangNhap dn = new DangNhap();
                    dn.Show();
                }

            };
            messageDialog.ShowDialog();
        }

        private void OnMainStudentFormClosing(object sender, FormClosingEventArgs e)
        {
            MessageDialog messageDialog = new MessageDialog(@"Bạn thực sự muốn thoát?", MessageDialog.DialogType.YesNo);
            messageDialog.SendValueDelegate = delegate(MessageDialog.DialogResultType result)
            {
                if (result == MessageDialog.DialogResultType.No)
                {
                    e.Cancel = true;
                }
                else if (result == MessageDialog.DialogResultType.Yes)
                {
                    DatabaseCore.ReleaseConnect();
                }

            };
            messageDialog.ShowDialog();
        }
        #endregion Event

        #region Method
        public void ChangeControlOfPanel(UserControl userControl)
        {
            /*
             * Dispose control trước khi thêm 1 control vào panel
             * Sau khi dispose thành công thì ta sẽ add control
             * */
            if (userControl != null)
            {
                if (_panelMain.Controls.Count > 0)
                {
                    UserControl uc = _panelMain.Controls[0] as UserControl;

                    if (null != uc)
                    {
                        uc.Dispose();
                    }
                }
                _panelMain.Controls.Clear();
                _panelMain.Controls.Add(userControl);
            }
        }
        #endregion Method

    }
}
