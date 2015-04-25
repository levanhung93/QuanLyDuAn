using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using QuanLySinhVien.Common;

namespace QuanLySinhVien.GUI
{
    public partial class DangNhap : Form
    {
        #region Field 
        /// <summary>
        /// Biến đánh dấu lần chạy đầu tiên
        /// </summary>
        private bool _isFirstRun = true;
        private bool _isMousePress = false;
        private Point _lastPoint;

        /// <summary>
        /// khởi tạo đối tượng tkAttribute
        /// </summary>
        TaiKhoanAttribute tkAttribute = new TaiKhoanAttribute();

        /// <summary>
        /// khởi tạo đối tượng dnController
        /// </summary>
        DangNhapController dnController = new DangNhapController();
        #endregion Field

        #region Constructor
        public DangNhap()
        {
            InitializeComponent();
        }
        #endregion Constructor

        #region Event
        private void OnCloseClick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OnBtnDangNhapClick(object sender, EventArgs e)
        {
            tkAttribute.TenDangNhap = _txtTenDangNhap.Text.Trim();
            tkAttribute.MatKhau = _txtMatKhau.Text.Trim();

            if (_txtTenDangNhap.Text != string.Empty || _txtMatKhau.Text != string.Empty)
            {
                if (_isFirstRun)
                {
                    _isFirstRun = false;
                    Thread thread = new Thread(InitDatabase);
                    thread.Start();
                }
                if (dnController.GetTaiKhoan(tkAttribute).Rows.Count != 0)
                {
                    MainStudent.quyen = dnController.GetQuyen(tkAttribute).Rows[0][0].ToString();
                    MainStudent.pass = dnController.GetTaiKhoan(tkAttribute).Rows[0][1].ToString();
                    MainStudent.taiKhoan = dnController.GetTaiKhoan(tkAttribute).Rows[0][0].ToString();

                    if (MainStudent.quyen == "SV")
                    {
                        MainStudent.userName = dnController.GetUserNameSinhVien(tkAttribute).Rows[0][0].ToString();
                    }
                    if (MainStudent.quyen == "GV")
                    {
                        MainStudent.userName = dnController.GetUserNameGiaoVien(tkAttribute).Rows[0][0].ToString();
                    }
                    if (MainStudent.quyen == "admin")
                    {
                        MainStudent.userName = dnController.GetTaiKhoan(tkAttribute).Rows[0][0].ToString();
                    }
                    MainStudent mainStudent = new MainStudent();
                    mainStudent.Show();
                    this.Hide();
                }
                else
                {
                    MessageDialog messageDialog = new MessageDialog(@"Bạn nhập sai thông tin tài khoản!", MessageDialog.DialogType.Ok);
                    messageDialog.ShowDialog();
                }
            }
            else
            {
                MessageDialog messageDialog = new MessageDialog(@"Bạn chưa nhập thông tin đăng nhập!", MessageDialog.DialogType.Ok);
                messageDialog.ShowDialog();
            }
        }

        private void OnDangNhapKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                _btnDangNhap.PerformClick();
            }
        }

        private void OnHuyClick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OnCloseMouseMove(object sender, MouseEventArgs e)
        {
            _lblClose.BackColor = Color.Firebrick;
        }

        private void OnCloseMouseLeave(object sender, EventArgs e)
        {
            _lblClose.BackColor = Color.White;
        }

        private void OnPanelDangNhapMouseDown(object sender, MouseEventArgs e)
        {
            _isMousePress = true;
            _lastPoint = e.Location;
        }

        private void OnPanelDangNhapMouseUp(object sender, MouseEventArgs e)
        {
            _isMousePress = false;
        }

        private void OnPanelDangNhapMouseMove(object sender, MouseEventArgs e)
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

        private void OnDangNhapFormClosing(object sender, FormClosingEventArgs e)
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
        private void InitDatabase()
        {
            DatabaseCore.CreateDatabase();
        }
        #endregion Event

    }
}
