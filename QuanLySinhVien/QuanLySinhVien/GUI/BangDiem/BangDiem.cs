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
    public partial class BangDiem : UserControl
    {
        #region Field
        /// <summary>
        /// khởi tạo đối tượng diemAttribute
        /// </summary>
        BangDiemAttribute diemAttribute = new BangDiemAttribute();

        /// <summary>
        /// khởi tạo đối tượng diemController
        /// </summary>
        BangDiemController diemController = new BangDiemController();

        /// <summary>
        /// khởi tạo biến _luu,nếu _luu==true thì thực hiện lưu thông tin điểm được thêm mới, _luu==false thực hiện lưu thông tin điểm được sửa đổi
        /// </summary>
        Boolean _luu = true;
        #endregion Field

        #region Constructor
        public BangDiem()
        {
            InitializeComponent();
        }
        #endregion Constructor

        #region Event
        private void OnBangDiemLoad(object sender, EventArgs e)
        {
            if (MainStudent.quyen == "admin" || MainStudent.quyen == "SV")
            {
                _btnLuuBangDiem.Enabled = false;
                _btnSuaBangDiem.Enabled = false;
                _btnThemBangDiem.Enabled = false;
                _btnXoaBangDiem.Enabled = false;
                _dgvBangDiem.DataSource = diemController.ShowBangDiemAdminSV();
            }
            else
            {
                _dgvBangDiem.DataSource = diemController.ShowBangDiem();
                _txtTongBanGhi.Text = _dgvBangDiem.Rows.Count.ToString();
                LoadMaSinhVien();
            }
        }

        private void OnCboMaSinhVienTTSelectedIndexChanged(object sender, EventArgs e)
        {
            diemAttribute.MaSV = _cboMaSinhVienTT.Text;
            foreach (DataRow item in diemController.GetSinhVienTT(diemAttribute).Rows)
            {
                _txtTenSinhVienTT.Text = item["TenSV"].ToString();
            }
        }

        private void OnBtnThemDiemClick(object sender, EventArgs e)
        {
            _luu = true;
            UnLockTextCombo();
        }

        private void OnBtnSuaBangDiemClick(object sender, EventArgs e)
        {
            _luu = false;
            UnLockTextCombo();
            _cboLanThucTap.Enabled = false;
            _cboMaSinhVienTT.Enabled = false;
        }

        private void OnBtnXoaBangDiemClick(object sender, EventArgs e)
        {
            if (_cboMaSinhVienTT.Text == string.Empty || _txtTenSinhVienTT.Text == string.Empty || _cboLanThucTap.Text == string.Empty || _txtDiem1.Text == string.Empty || _txtDiem2.Text == string.Empty || _txtDiem3.Text == string.Empty || _txtDiemBV.Text == string.Empty)
            {
                MessageDialog messageDialong = new MessageDialog(@"Bạn chưa chọn thông tin cần xóa!", MessageDialog.DialogType.Ok);
                messageDialong.ShowDialog();
            }
            else
            {
                diemAttribute.MaSV = _cboMaSinhVienTT.Text;
                diemAttribute.LanThucTap = Int32.Parse(_cboLanThucTap.Text);
                MessageDialog messageDialog = new MessageDialog(@"Bạn chắc chắn muốn xóa?", MessageDialog.DialogType.YesNo);
                messageDialog.SendValueDelegate = delegate(MessageDialog.DialogResultType result)
                {
                    if (result == MessageDialog.DialogResultType.Yes)
                    {
                        diemController.DeleTeDiem(diemAttribute);
                        MessageDialog messageDialong = new MessageDialog(@"Xóa thành công!", MessageDialog.DialogType.Ok);
                        messageDialong.ShowDialog();
                    }
                };
                messageDialog.ShowDialog();
                Refresh();
                OnBangDiemLoad(sender, e);
            }
        }

        private void OnBtnLuuBangDiemClick(object sender, EventArgs e)
        {
            if (_cboMaSinhVienTT.Text == string.Empty || _txtTenSinhVienTT.Text == string.Empty || _cboLanThucTap.Text == string.Empty || _txtDiem1.Text == string.Empty || _txtDiem2.Text == string.Empty || _txtDiem3.Text == string.Empty || _txtDiemBV.Text == string.Empty)
            {
                MessageDialog messageDialong = new MessageDialog(@"Mời bạn nhập đầy đủ thông tin!", MessageDialog.DialogType.Ok);
                messageDialong.ShowDialog();
            }
            else
            {
                try
                {
                    diemAttribute.MaSV = _cboMaSinhVienTT.Text;
                    diemAttribute.LanThucTap = Int32.Parse(_cboLanThucTap.Text);
                    diemAttribute.Diem1 = float.Parse(_txtDiem1.Text);
                    diemAttribute.Diem2 = float.Parse(_txtDiem2.Text);
                    diemAttribute.Diem3 = float.Parse(_txtDiem3.Text);
                    diemAttribute.DiemTB = float.Parse(_txtDiemTB.Text);
                    diemAttribute.DiemBaoVe = float.Parse(_txtDiemBV.Text);
                    diemAttribute.DiemTongKet = float.Parse(_txtDiemTong.Text);
                    diemAttribute.GhiChu = _txtGhiChu.Text;
                    if (_luu == true)
                    {
                        diemController.InsertDiem(diemAttribute);
                        MessageDialog messageDialong = new MessageDialog(@"Thêm thành công!", MessageDialog.DialogType.Ok);
                        messageDialong.ShowDialog();
                    }
                    if (_luu == false)
                    {
                        diemController.UpdateDiem(diemAttribute);
                        MessageDialog messageDialong = new MessageDialog(@"Sửa thành công!", MessageDialog.DialogType.Ok);
                        messageDialong.ShowDialog();
                    }
                    Refresh();
                    OnBangDiemLoad(sender, e);
                    LockTextBox();
                }
                catch (Exception ex)
                {
                    MessageDialog messageDialong = new MessageDialog(@"Error:  " + ex, MessageDialog.DialogType.Ok);
                    messageDialong.ShowDialog();
                }
            }
        }
        private void OnDgvBangDiemCellClick(object sender, DataGridViewCellEventArgs e)
        {
            _cboMaSinhVienTT.Text = _dgvBangDiem.CurrentRow.Cells[0].Value.ToString();
            _txtTenSinhVienTT.Text = _dgvBangDiem.CurrentRow.Cells[9].Value.ToString();
            _cboLanThucTap.Text = _dgvBangDiem.CurrentRow.Cells[7].Value.ToString();
            _txtDiem1.Text = _dgvBangDiem.CurrentRow.Cells[1].Value.ToString();
            _txtDiem2.Text = _dgvBangDiem.CurrentRow.Cells[2].Value.ToString();
            _txtDiem3.Text = _dgvBangDiem.CurrentRow.Cells[3].Value.ToString();
            _txtDiemTB.Text = _dgvBangDiem.CurrentRow.Cells[4].Value.ToString();
            _txtDiemBV.Text = _dgvBangDiem.CurrentRow.Cells[5].Value.ToString();
            _txtDiemTong.Text = _dgvBangDiem.CurrentRow.Cells[6].Value.ToString();
            _txtGhiChu.Text = _dgvBangDiem.CurrentRow.Cells[8].Value.ToString();
        }

        private void OnTxtDiem1TextChanged(object sender, EventArgs e)
        {
            try
            {
                if ((float.Parse(_txtDiem1.Text) < 0 || float.Parse(_txtDiem1.Text) > 10))
                {
                    MessageDialog messageDialong = new MessageDialog(@"Điểm phải nằm trong đoạn[0,10]!", MessageDialog.DialogType.Ok);
                    messageDialong.ShowDialog();
                }
                else
                {
                    try
                    {
                        _txtDiemTB.Text = Math.Round(((float.Parse(_txtDiem1.Text) + float.Parse(_txtDiem2.Text) + float.Parse(_txtDiem3.Text)) / 3), 1, MidpointRounding.AwayFromZero).ToString();
                    }
                    catch (Exception)
                    {
                    }
                }
            }
            catch { }
        }

        private void OnTxtDiem2TextChanged(object sender, EventArgs e)
        {
            try
            {
                if ((float.Parse(_txtDiem2.Text) < 0 || float.Parse(_txtDiem2.Text) > 10))
                {
                    MessageDialog messageDialong = new MessageDialog(@"Điểm phải nằm trong đoạn[0,10]!", MessageDialog.DialogType.Ok);
                    messageDialong.ShowDialog();
                }
                else
                {
                    try
                    {
                        _txtDiemTB.Text = Math.Round(((float.Parse(_txtDiem1.Text) + float.Parse(_txtDiem2.Text) + float.Parse(_txtDiem3.Text)) / 3), 1, MidpointRounding.AwayFromZero).ToString();
                    }
                    catch (Exception)
                    {
                    }
                }
            }
            catch {}
        }

        private void OnTxtDiem3TextChanged(object sender, EventArgs e)
        {
            try
            {
                if ((float.Parse(_txtDiem3.Text) < 0 || float.Parse(_txtDiem3.Text) > 10))
                {
                    MessageDialog messageDialong = new MessageDialog(@"Điểm phải nằm trong đoạn[0,10]!", MessageDialog.DialogType.Ok);
                    messageDialong.ShowDialog();
                }
                else
                {
                    try
                    {
                        _txtDiemTB.Text = Math.Round(((float.Parse(_txtDiem1.Text) + float.Parse(_txtDiem2.Text) + float.Parse(_txtDiem3.Text)) / 3), 1, MidpointRounding.AwayFromZero).ToString();
                    }
                    catch (Exception)
                    {
                    }
                }
            }
            catch{ }
        }
        private void OnTxtDiemBVTextChanged(object sender, EventArgs e)
        {
            try
            {
                if ((float.Parse(_txtDiemBV.Text) < 0 || float.Parse(_txtDiemBV.Text) > 10))
                {
                    MessageDialog messageDialong = new MessageDialog(@"Điểm phải nằm trong đoạn[0,10]!", MessageDialog.DialogType.Ok);
                    messageDialong.ShowDialog();
                }
                else
                {
                    try
                    {
                        _txtDiemTong.Text = Math.Round(((float.Parse(_txtDiemTB.Text) + float.Parse(_txtDiemBV.Text)) / 2), 1, MidpointRounding.AwayFromZero).ToString();
                    }
                    catch (Exception)
                    {
                    }
                }
            }
            catch {}
        }
        private void OnTxtDiemTongTextChanged(object sender, EventArgs e)
        {
            try
            {
                if (float.Parse(_txtDiemTong.Text) < 5)
                {
                    _txtGhiChu.Text = "Không Đạt";
                }
                else
                {
                    _txtGhiChu.Text = "Đạt";
                }
            }
            catch{ }
        }
        private void OnBtnTimKiemDiemClick(object sender, EventArgs e)
        {
            string maSV = _txtTimKiemDiem.Text.Trim();
            _dgvBangDiem.DataSource = diemController.SearchBangDiem(maSV);
            _txtTongBanGhi.Text = _dgvBangDiem.Rows.Count.ToString();

            if (_dgvBangDiem.Rows.Count > 0)
            {
                _cboMaSinhVienTT.Text = _dgvBangDiem.CurrentRow.Cells[0].Value.ToString();
                _txtTenSinhVienTT.Text = _dgvBangDiem.CurrentRow.Cells[9].Value.ToString();
                _cboLanThucTap.Text = _dgvBangDiem.CurrentRow.Cells[7].Value.ToString();
                _txtDiem1.Text = _dgvBangDiem.CurrentRow.Cells[1].Value.ToString();
                _txtDiem2.Text = _dgvBangDiem.CurrentRow.Cells[2].Value.ToString();
                _txtDiem3.Text = _dgvBangDiem.CurrentRow.Cells[3].Value.ToString();
                _txtDiemTB.Text = _dgvBangDiem.CurrentRow.Cells[4].Value.ToString();
                _txtDiemBV.Text = _dgvBangDiem.CurrentRow.Cells[5].Value.ToString();
                _txtDiemTong.Text = _dgvBangDiem.CurrentRow.Cells[6].Value.ToString();
                _txtGhiChu.Text = _dgvBangDiem.CurrentRow.Cells[8].Value.ToString();
            }
            else
            {
                MessageDialog messageDialong = new MessageDialog(@"Không tìm thấy thông tin được yêu cầu!", MessageDialog.DialogType.Ok);
                messageDialong.ShowDialog();
                Refresh();
                LockTextBox();
                OnBangDiemLoad(sender, e);
            }
        }
       
        private void OnCboLanThucTapChanged(object sender, EventArgs e)
        {
            try
            {
                if (Int32.Parse(_cboLanThucTap.Text) < 0 || Int32.Parse(_cboLanThucTap.Text) >= 3)
                {
                    MessageDialog messageDialong = new MessageDialog(@"Lần thực tập phải nằm trong đoạn[1,2]!", MessageDialog.DialogType.Ok);
                    messageDialong.ShowDialog();
                }
            }
            catch
            {
                //MessageDialog messageDialong = new MessageDialog(@"Error: " +ex, MessageDialog.DialogType.Ok);
                //messageDialong.ShowDialog();
            }
          
        }
        #endregion Event

        #region Method
        /// <summary>
        /// hàm khóa text
        /// </summary>
        public void LockTextBox()
        {
            _cboMaSinhVienTT.Enabled = false;
            _cboLanThucTap.Enabled = false;
            _txtDiem1.Enabled = false;
            _txtDiem2.Enabled = false;
            _txtDiem3.Enabled = false;
            _txtDiemBV.Enabled = false;
        }
        /// <summary>
        /// hàm mở khóa các textbox và combobox
        /// </summary>
        public void UnLockTextCombo()
        {
            _cboMaSinhVienTT.Enabled = true;
            _cboLanThucTap.Enabled = true;
            _txtDiem1.Enabled = true;
            _txtDiem2.Enabled = true;
            _txtDiem3.Enabled = true;
            _txtDiemBV.Enabled = true;
        }

        /// <summary>
        /// hàm load mã sinh viên thực tập
        /// </summary>
        public void LoadMaSinhVien()
        {
            _cboMaSinhVienTT.DataSource = diemController.LoadSinhVienThucTap();
            _cboMaSinhVienTT.DisplayMember = "MaSV";
            _cboMaSinhVienTT.ValueMember = "MaSV";
        }
        /// <summary>
        /// hàm thực hiện làm trống các textbox và combobox khi thực hiện lưu thông tin thành công
        /// </summary>
        public void Refresh()
        {
            _cboMaSinhVienTT.Text = string.Empty;
            _txtTenSinhVienTT.Text = string.Empty;
            _cboLanThucTap.Text = string.Empty;
            _txtDiem1.Text = string.Empty;
            _txtDiem2.Text = string.Empty;
            _txtDiem3.Text = string.Empty;
            _txtDiemTB.Text = string.Empty;
            _txtDiemBV.Text = string.Empty;
            _txtDiemTong.Text = string.Empty;
            _txtGhiChu.Text = null;
        }
        #endregion Method

    }
}
