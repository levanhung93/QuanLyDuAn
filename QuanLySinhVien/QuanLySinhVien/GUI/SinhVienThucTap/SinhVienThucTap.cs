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
    public partial class SinhVienThucTap : UserControl
    {
        #region Field
        /// <summary>
        /// khởi tạo đối tượng SinhVienAttribute
        /// </summary>
        SinhVienAttribute svAttribute = new SinhVienAttribute();
        /// <summary>
        /// khởi tạo đối tượng SinhVienController
        /// </summary>
        SinhVienController svController = new SinhVienController();

        #endregion Field

        #region Constructor
        public SinhVienThucTap()
        {
            InitializeComponent();
        }
        #endregion Constructor

        #region Event
        private void OnBtnThemSVClick(object sender, EventArgs e)
        {
            UnLockCombobox();
            LoadMaSinhVien();
        }

        private void OnCboSinhVienSelecdIndexChanged(object sender, EventArgs e)
        {
            svAttribute.MaSV = _cboMaSinhVien.Text;
            foreach (DataRow item in svController.GetFullSinhVien(svAttribute).Rows)
            {
                _txtTenSinhVien.Text = item["TenSV"].ToString();
                _txtNgaySinhSV.Text = item["Ngay"].ToString();
                _txtThangSinhSV.Text = item["Thang"].ToString();
                _txtNamSinhSV.Text = item["Nam"].ToString();
                _txtGioiTinhSV.Text = item["GioiTinh"].ToString();
                _txtDiachiSV.Text = item["DiaChi"].ToString();
                _txtDienThoaiSV.Text = item["DienThoai"].ToString();
                _txtEmailSV.Text = item["Email"].ToString();
            }
            _cbLop.DataSource = svController.GetFullSinhVien(svAttribute);
            _cbLop.DisplayMember = "TenLop";
            _cbLop.ValueMember = "MaLop";
            _cbKhoaHoc.DataSource = svController.GetFullSinhVien(svAttribute);
            _cbKhoaHoc.DisplayMember = "KhoaHoc";
        }

        private void OnSinhVienThucTapLoad(object sender, EventArgs e)
        {
            if (MainStudent.quyen == "SV")
            {
                _btnLuuSV.Enabled = false;
                _btnThemSV.Enabled = false;
                _btnXoaSV.Enabled = false;
            }
            _dgvSinhVien.DataSource = svController.ShowSinhVien();
            _txtTongBanGhi.Text = _dgvSinhVien.Rows.Count.ToString();
        }

        private void OnBtnLuuSVClick(object sender, EventArgs e)
        {
            if (_cboMaSinhVien.Text=="")
            {
                 MessageDialog messageDialong = new MessageDialog(@"Mời bạn nhập đầy đủ thông tin!", MessageDialog.DialogType.Ok);
                messageDialong.ShowDialog();
            }
            else
            {
                try
                {
                    svAttribute.MaSV = _cboMaSinhVien.Text;
                    svAttribute.TenSV = _txtTenSinhVien.Text;
                    svAttribute.NgaySinh = Int32.Parse(_txtNgaySinhSV.Text);
                    svAttribute.ThangSinh = Int32.Parse(_txtThangSinhSV.Text);
                    svAttribute.NamSinh = Int32.Parse(_txtNamSinhSV.Text);
                    svAttribute.GioiTinh = _txtGioiTinhSV.Text;
                    svAttribute.Lop = _cbLop.SelectedValue.ToString();
                    svAttribute.DiaChi = _txtDiachiSV.Text;
                    svAttribute.DienThoai = _txtDienThoaiSV.Text;
                    svAttribute.Email = _txtEmailSV.Text;
                    svController.InsertSinhVien(svAttribute);
                    svController.InsertTaiKhoan(svAttribute);
                    MessageDialog messageDialong = new MessageDialog(@"Thêm thành công!", MessageDialog.DialogType.Ok);
                    messageDialong.ShowDialog();
                    Refresh();
                    OnSinhVienThucTapLoad(sender, e);
                    LockTextBox();
                }
                catch (Exception ex)
                {
                    MessageDialog messageDialong = new MessageDialog(@"Error:  " + ex, MessageDialog.DialogType.Ok);
                    messageDialong.ShowDialog();
                }
            }
        }
        private void _btnXoaSV_Click(object sender, EventArgs e)
        {
            if (_cboMaSinhVien.Text == "")
            {
                MessageDialog messageDialog = new MessageDialog(@"Bạn chưa chọn thông tin cần xóa!", MessageDialog.DialogType.Ok);
                messageDialog.ShowDialog();
            }
            else
            {
                svAttribute.MaSV = _cboMaSinhVien.Text;
                MessageDialog messageDialog = new MessageDialog(@"Bạn chắc chắn muốn xóa?", MessageDialog.DialogType.YesNo);
                messageDialog.SendValueDelegate = delegate(MessageDialog.DialogResultType result)
                {
                    if (result == MessageDialog.DialogResultType.Yes)
                    {
                        svController.DeleteSinhVienTT(svAttribute);
                        svController.DeleteTaiKhoan(svAttribute);
                        svController.DeleteBangDiem(svAttribute);
                        MessageDialog messageDialog1 = new MessageDialog(@"Xóa thành công!", MessageDialog.DialogType.Ok);
                        messageDialog1.ShowDialog();
                    }
                };
                messageDialog.ShowDialog();
                Refresh();
                OnSinhVienThucTapLoad(sender, e);
            }
        }
        private int _dong;
        private void DSSV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _dong = e.RowIndex;
            _cboMaSinhVien.Text = _dgvSinhVien.Rows[_dong].Cells[0].Value.ToString();
            _txtTenSinhVien.Text = _dgvSinhVien.Rows[_dong].Cells[1].Value.ToString();
            _txtNgaySinhSV.Text = _dgvSinhVien.Rows[_dong].Cells[2].Value.ToString();
            _txtThangSinhSV.Text =_dgvSinhVien.Rows[_dong].Cells[3].Value.ToString();
            _txtNamSinhSV.Text = _dgvSinhVien.Rows[_dong].Cells[4].Value.ToString();
            _txtGioiTinhSV.Text = _dgvSinhVien.Rows[_dong].Cells[5].Value.ToString();
            _cbLop.Text = _dgvSinhVien.Rows[_dong].Cells[8].Value.ToString();
            _cbKhoaHoc.Text = _dgvSinhVien.Rows[_dong].Cells[9].Value.ToString();
            _txtDiachiSV.Text = _dgvSinhVien.Rows[_dong].Cells[6].Value.ToString();
            _txtDienThoaiSV.Text =_dgvSinhVien.Rows[_dong].Cells[7].Value.ToString();
            _txtEmailSV.Text = _dgvSinhVien.Rows[_dong].Cells[10].Value.ToString();
        }
        private void _btnTimKiemSinhVienTT_Click(object sender, EventArgs e)
        {
            string tenSV = _txtTimKiemSinhVienTT.Text;
            _dgvSinhVien.DataSource = svController.SearchSinhVienTT(tenSV);
            _txtTongBanGhi.Text = _dgvSinhVien.Rows.Count.ToString();

            if (_dgvSinhVien.Rows.Count > 0)
            {
                _cboMaSinhVien.Text = _dgvSinhVien.CurrentRow.Cells[0].Value.ToString();
                _txtTenSinhVien.Text = _dgvSinhVien.CurrentRow.Cells[1].Value.ToString();
                _txtNgaySinhSV.Text = _dgvSinhVien.CurrentRow.Cells[2].Value.ToString();
                _txtThangSinhSV.Text = _dgvSinhVien.CurrentRow.Cells[3].Value.ToString();
                _txtNamSinhSV.Text = _dgvSinhVien.CurrentRow.Cells[4].Value.ToString();
                _txtGioiTinhSV.Text = _dgvSinhVien.CurrentRow.Cells[5].Value.ToString();
                _cbLop.Text = _dgvSinhVien.CurrentRow.Cells[8].Value.ToString();
                _cbKhoaHoc.Text = _dgvSinhVien.CurrentRow.Cells[9].Value.ToString();
                _txtDiachiSV.Text = _dgvSinhVien.CurrentRow.Cells[6].Value.ToString();
                _txtDienThoaiSV.Text = _dgvSinhVien.CurrentRow.Cells[7].Value.ToString();
                _txtEmailSV.Text = _dgvSinhVien.CurrentRow.Cells[10].Value.ToString();
            }
            else
            {
                MessageDialog messageDialog1 = new MessageDialog(@"Không tìm thấy thông tin yêu cầu!", MessageDialog.DialogType.Ok);
                messageDialog1.ShowDialog();
                Refresh();
                OnSinhVienThucTapLoad(sender, e);
            }
        }

        #endregion Event

        #region Method
        /// <summary>
        /// thực hiện việc load Mã sinh viên lên _cboMaSinhVien
        /// </summary>
        public void LoadMaSinhVien()
        {
            _cboMaSinhVien.DataSource = svController.LoadMaSinhVien(svAttribute);
            _cboMaSinhVien.DisplayMember = "MaSV";
            _cboMaSinhVien.ValueMember = "MaSV";
        }

        public void UnLockCombobox()
        {
            _cboMaSinhVien.Enabled = true;
        }

        public void LockTextBox()
        {
            _cboMaSinhVien.Enabled = false;
        }
        public void Refresh()
        {
            _cboMaSinhVien.Text = null;
            _txtTenSinhVien.Text = null;
            _txtNgaySinhSV.Text = null;
            _txtThangSinhSV.Text = null;
            _txtNamSinhSV.Text = null;
            _cbLop.Text = null;
            _cbKhoaHoc.Text = null;
            _txtDiachiSV.Text = null;
            _txtDienThoaiSV.Text = null;
            _txtEmailSV.Text = null;
            _txtGioiTinhSV.Text = null;
        }
        #endregion Method

    }
}
