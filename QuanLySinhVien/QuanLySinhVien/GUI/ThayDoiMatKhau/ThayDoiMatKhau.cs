using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using QuanLySinhVien.Common;

namespace QuanLySinhVien.GUI
{
    public partial class _frmThayDoiMatKhau : Form
    {
        #region Field
        /// <summary>
        /// khởi tạo đối tượng dmkAttribute
        /// </summary>
        ThayDoiMatKhauAttribute dmkAttribute = new ThayDoiMatKhauAttribute();

        /// <summary>
        /// khởi tạo đối tượng dmkController
        /// </summary>
        ThayDoiMatKhauController dmkController = new ThayDoiMatKhauController();
        #endregion Field

        #region Constructor
        public _frmThayDoiMatKhau()
        {
            InitializeComponent();
        }
        #endregion Constuctor

        #region Event
        private void OnLblThayDoiMKClick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OnCloseMouseLeave(object sender, EventArgs e)
        {
            _lblClose.BackColor = Color.White;
        }

        private void OnCloseMouseMove(object sender, MouseEventArgs e)
        {
            _lblClose.BackColor = Color.Firebrick;
        }

        private void OnThayDoiMatKhauFormClosing(object sender, FormClosingEventArgs e)
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

        private void OnThayDoiMatKhauLoad(object sender, EventArgs e)
        {
            _txtTenDangNhap.Text = MainStudent.userName;
        }
        private void OnBtnThayDoiClick(object sender, EventArgs e)
        {
            //kiểm tra mật khẩu cũ đã được nhập chưa
            if (_txtMatKhauCu.Text == string.Empty)
            {
                MessageDialog messageDialog = new MessageDialog(@"Mời bạn nhập đầy đủ thông tin!", MessageDialog.DialogType.Ok);
                messageDialog.ShowDialog();
            }
            //kiểm tra mật khẩu mới đã được nhập chưa
            else if (_txtMatKhauMoi.Text == string.Empty)
            {
                MessageDialog messageDialog = new MessageDialog(@"Mời bạn nhập đầy đủ thông tin!", MessageDialog.DialogType.Ok);
                messageDialog.ShowDialog();
            }
            //kiểm tra đã nhập lại mật khẩu mới chưa
            else if (_txtNhapLaiMatKhauMoi.Text == string.Empty)
            {
                MessageDialog messageDialog = new MessageDialog(@"Mời bạn nhập đầy đủ thông tin!", MessageDialog.DialogType.Ok);
                messageDialog.ShowDialog();
            }
            //kiểm tra mật khẩu mới và nhập lại mật khẩu mới có trùng hợp nhau hay không
            else if (_txtMatKhauMoi.Text != _txtNhapLaiMatKhauMoi.Text)
            {
                MessageDialog messageDialog = new MessageDialog(@"Mật khẩu không trùng hợp!", MessageDialog.DialogType.Ok);
                messageDialog.ShowDialog();
            }
            //kiểm tra mật khẩu cũ có chính xác không
            else if (_txtMatKhauCu.Text != MainStudent.pass)
            {
                MessageDialog messageDialog = new MessageDialog(@"Mật khẩu cũ không chính xác!", MessageDialog.DialogType.Ok);
                messageDialog.ShowDialog();
            }
            //thực hiện đổi mật khẩu
            else
            {
                dmkAttribute.TenDangNhap = _txtTenDangNhap.Text;
                dmkAttribute.MatKhauCu = _txtMatKhauCu.Text;
                dmkAttribute.MatKhauMoi = _txtMatKhauMoi.Text;

                MessageDialog messageDialog = new MessageDialog(@"Bạn chắc chắn muốn thay đổi?", MessageDialog.DialogType.YesNo);
                messageDialog.SendValueDelegate = delegate(MessageDialog.DialogResultType result)
                {
                    if (result == MessageDialog.DialogResultType.Yes)
                    {
                        dmkController.UpdatePass(dmkAttribute);
                        MessageDialog messageDialong = new MessageDialog(@"Đổi mật khẩu thành công!", MessageDialog.DialogType.Ok);
                        messageDialong.ShowDialog();
                        DatabaseCore.ReleaseConnect();
                        this.Hide();
                        DangNhap dn = new DangNhap();
                        dn.Show();
                    }
                };
                messageDialog.ShowDialog();
            }
        }

        private void OnThayDoiMatKhauKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                _btnThayDoi.PerformClick();
            }
        }
        #endregion Event

    }
}
