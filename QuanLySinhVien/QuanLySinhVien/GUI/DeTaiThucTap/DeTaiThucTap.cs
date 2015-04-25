using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using QuanLySinhVien.Common;

namespace QuanLySinhVien.GUI
{
    public partial class DeTaiThucTap : UserControl
    {
        #region Field
        /// <summary>
        /// khởi tạo đối tượng detaiAttribute
        /// </summary>
        DeTaiThucTapAttribute detaiAttribute = new DeTaiThucTapAttribute();

        /// <summary>
        /// khởi tạo đối tượng detaiController
        /// </summary>
        DeTaiThucTapController detaiController = new DeTaiThucTapController();

        /// <summary>
        /// khởi tạo biến _luu, nếu _luu==true thì thực hiện lưu thông tin đề tài được thêm mới, nếu _luu==false thì thực hiện lưu thông tin đề tài được thay dổi
        /// </summary>
        Boolean _luu = true;
        #endregion Field

        #region Constructor
        public DeTaiThucTap()
        {
            InitializeComponent();
        }
        #endregion Constructor

        #region Event
        private void OnBtnThemDeTaiClick(object sender, EventArgs e)
        {
            _luu = true;
            UnLockTextBox();
            MaTuDongTang();
        }

        private void OnBtnsuaDeTaiClick(object sender, EventArgs e)
        {
            _luu = false;
            UnLockTextBox();
        }
        private void OnCboMaGiaoVienHDSelectedIndexChanged(object sender, EventArgs e)
        {
            detaiAttribute.MaGiaoVienHD = _cboMaGiaoVienHD.Text;
            foreach (DataRow item in detaiController.GetGiaoVien(detaiAttribute).Rows)
            {
                _txtTenGiaoVienHD.Text = item["TenGV"].ToString();
            }
        }

        private void OnBtnLuuDeTaiClick(object sender, EventArgs e)
        {
            if (_txtMaDeTai.Text == string.Empty || _txtTenDeTai.Text == string.Empty || _cboMaGiaoVienHD.Text == string.Empty || _txtTenDeTai.Text == string.Empty)
            {
                MessageDialog messageDialong = new MessageDialog(@"Mời bạn nhập đầy đủ thông tin!", MessageDialog.DialogType.Ok);
                messageDialong.ShowDialog();
            }
            else
            {
                try
                {
                    detaiAttribute.MaDeTai = _txtMaDeTai.Text;
                    detaiAttribute.TenDeTai = _txtTenDeTai.Text;
                    detaiAttribute.MaGiaoVienHD = _cboMaGiaoVienHD.Text;
                    if (_luu == true)
                    {
                        detaiController.InsertDeTai(detaiAttribute);
                        MessageDialog messageDialong = new MessageDialog(@"Thêm thành công!", MessageDialog.DialogType.Ok);
                        messageDialong.ShowDialog();
                    }
                    if (_luu == false)
                    {
                        detaiController.UpdateDeTai(detaiAttribute);
                        MessageDialog messageDialong = new MessageDialog(@"Sửa thành công!", MessageDialog.DialogType.Ok);
                        messageDialong.ShowDialog();
                    }
                    Refresh();
                    OnDeTaiThucTapLoad(sender, e);
                    LockTextBox();
                }
                catch (Exception ex)
                {
                    MessageDialog messageDialong = new MessageDialog(@"Error:  " + ex, MessageDialog.DialogType.Ok);
                    messageDialong.ShowDialog();
                }
            }
        }

        private void OnBtnXoaDeTaiClick(object sender, EventArgs e)
        {
            if (_txtMaDeTai.Text == string.Empty || _txtTenDeTai.Text == string.Empty || _cboMaGiaoVienHD.Text == string.Empty || _txtTenDeTai.Text == string.Empty)
            {
                MessageDialog messageDialong = new MessageDialog(@"Bạn chưa chọn thông tin cần xóa!", MessageDialog.DialogType.Ok);
                messageDialong.ShowDialog();
            }
            else
            {
                detaiAttribute.MaDeTai = _txtMaDeTai.Text;
                MessageDialog messageDialog = new MessageDialog(@"Bạn chắc chắn muốn xóa?", MessageDialog.DialogType.YesNo);
                messageDialog.SendValueDelegate = delegate(MessageDialog.DialogResultType result)
                {
                    if (result == MessageDialog.DialogResultType.Yes)
                    {
                        detaiController.DeleteDeTai(detaiAttribute);
                        MessageDialog messageDialong = new MessageDialog(@"Xóa đề tài thành công!", MessageDialog.DialogType.Ok);
                        messageDialong.ShowDialog();
                    }
                };
                messageDialog.ShowDialog();
                Refresh();
                OnDeTaiThucTapLoad(sender, e);
            }
        }

        private void OnBtnTimKiemDeTaiClick(object sender, EventArgs e)
        {
            string TenDeTai = _txtTimKiemDeTai.Text.Trim();
            _dgvDeTai.DataSource = detaiController.ShowSearchDeTai(TenDeTai);
            _txtTongBanGhi.Text = _dgvDeTai.Rows.Count.ToString();

            if (_dgvDeTai.Rows.Count > 0)
            {
                _txtMaDeTai.Text = _dgvDeTai.CurrentRow.Cells[0].Value.ToString();
                _txtTenDeTai.Text = _dgvDeTai.CurrentRow.Cells[1].Value.ToString();
                _cboMaGiaoVienHD.Text = _dgvDeTai.CurrentRow.Cells[2].Value.ToString();
                _txtTenGiaoVienHD.Text = _dgvDeTai.CurrentRow.Cells[3].Value.ToString();
            }
            else
            {
                MessageDialog messageDialong = new MessageDialog(@"Không tìm thấy thông tin được yêu cầu!", MessageDialog.DialogType.Ok);
                messageDialong.ShowDialog();
                Refresh();
                LockTextBox();
                OnDeTaiThucTapLoad(sender, e);
            }
        }
        private void OnDeTaiThucTapLoad(object sender, EventArgs e)
        {
            if (MainStudent.quyen == "GV" || MainStudent.quyen == "SV")
            {
                _btnLuuDeTai.Enabled = false;
                _btnSuaDeTai.Enabled = false;
                _btnThemDeTai.Enabled = false;
                _btnXoaDeTai.Enabled = false;
            }
            _dgvDeTai.DataSource = detaiController.ShowDeTai();
            _txtTongBanGhi.Text = _dgvDeTai.Rows.Count.ToString();
            LoadGiaoVien();
        }

        private void OnDgvDeTaiCellClick(object sender, DataGridViewCellEventArgs e)
        {
            _txtMaDeTai.Text = _dgvDeTai.CurrentRow.Cells[0].Value.ToString();
            _txtTenDeTai.Text = _dgvDeTai.CurrentRow.Cells[1].Value.ToString();
            _cboMaGiaoVienHD.Text = _dgvDeTai.CurrentRow.Cells[2].Value.ToString();
            _txtTenGiaoVienHD.Text = _dgvDeTai.CurrentRow.Cells[3].Value.ToString();
        }
        #endregion Event

        #region Method
        /// <summary>
        /// hàm load mã giáo viên hướng dẫn
        /// </summary>
        public void LoadGiaoVien()
        {
            _cboMaGiaoVienHD.DataSource = detaiController.LoadGiaoVienHD();
            _cboMaGiaoVienHD.DisplayMember = "MaGV";
            _cboMaGiaoVienHD.ValueMember = "MaGV";
        }

        /// <summary>
        /// hàm mở khóa text
        /// </summary>
        public void UnLockTextBox()
        {
            _txtTenDeTai.Enabled = true;
            _cboMaGiaoVienHD.Enabled = true;
        }

        /// <summary>
        /// hàm khóa text
        /// </summary>
        public void LockTextBox()
        {
            _txtTenDeTai.Enabled = false;
            _cboMaGiaoVienHD.Enabled = false;
        }
        /// <summary>
        /// hàm thực hiện làm trống các textbox và combobox khi thực hiện lưu thông tin thành công
        /// </summary>
        public void Refresh()
        {
            _txtMaDeTai.Text = null;
            _txtTenDeTai.Text = null;
            _cboMaGiaoVienHD.Text = null;
            _txtTenGiaoVienHD.Text = null;
        }
        /// <summary>
        /// hàm thực hiện tự động tăng mã
        /// </summary>
        public void MaTuDongTang()
        {
            string s = "";
            if (detaiController.LoadMaDeTai().Rows.Count <= 0)
            {
                s = "DT0001";
            }
            else
            {
                s = "DT";
                string number = detaiController.LoadMaDeTai().Rows[detaiController.LoadMaDeTai().Rows.Count - 1][0].ToString().Substring(2);
                int numberHD = 1;
                if (int.TryParse(number, out numberHD))
                {
                    numberHD++;
                    s = s + numberHD.ToString("0000");
                }
            }
            _txtMaDeTai.Text = s;
        }
        #endregion Method

    }
}
