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
    public partial class DangKyDeTai : UserControl
    {
        public DangKyDeTai()
        {
            InitializeComponent();
        }

        #region field
        /// <summary>
        /// khởi tạo đối tượng DKDTAtt
        /// </summary>
        DangKyDeTaiAttribute DKDTAtt = new DangKyDeTaiAttribute();
        /// <summary>
        /// khởi tạo đối tượng DKDTCtrol
        /// </summary>
        DangKyDeTaiController DKDTCtrol = new DangKyDeTaiController();
        #endregion field

        #region event
        private void DangKyDeTai_Load(object sender, EventArgs e)
        {
            if (MainStudent.quyen == "admin" || MainStudent.quyen == "GV")
                _btnDangKyDeTai.Enabled = false;
            _dgvDSDeTai_GiaoVien.DataSource = DKDTCtrol.LayDeTai();
            _txtTongBanGhi.Text = _dgvDSDeTai_GiaoVien.Rows.Count.ToString();
            _cboMaGiaoVienHD.Enabled = false;
            _txtTongBanGhi.Enabled = false;
            _txtTenGiaoVienHD.Enabled = false;
            _txtMaDeTai.Enabled = false;
            _txtTenDeTai.Enabled = false;
        }

        private void _btnDangKyDeTai_Click(object sender, EventArgs e)
        {
            DKDTAtt.MaSV = MainStudent.taiKhoan.ToString();
            _dgvDSDeTai_GiaoVien.DataSource = DKDTCtrol.KiemTra(DKDTAtt);
            if (_cboMaGiaoVienHD.Text == "" || _txtTenDeTai.Text == "" || _txtDiaChiCQ.Text == "" || _txtDienThoaiCQ.Text == "" || _txtTenCoQuanTT.Text == "" || _txtEmailCQ.Text == "")
            {
                MessageDialog messageDialog = new MessageDialog(@"Bạn chưa điền đầy đủ thông tin!", MessageDialog.DialogType.Ok);
                messageDialog.ShowDialog();
                DangKyDeTai_Load(sender, e);
            }
            else
            {
                try
                {
                    if (_dgvDSDeTai_GiaoVien.Rows.Count > 0)
                    {
                        MessageDialog messageDialog2 = new MessageDialog(@"Bạn đã đăng ký đề tài! Nếu muốn đổi đề tài, hãy hủy đề tài đã đăng ký sau đó đăng ký đề tài khác!", MessageDialog.DialogType.Ok);
                        messageDialog2.ShowDialog();
                        /* _btnDangKyDeTai.Enabled = false;
                         _txtEmailCQ.Enabled = false;
                         _txtTenCoQuanTT.Enabled = false;
                         _txtDienThoaiCQ.Enabled = false;
                         _txtDiaChiCQ.Enabled = false;*/
                        _txtTenCoQuanTT.Text = null;
                        _txtDiaChiCQ.Text = null;
                        _txtDienThoaiCQ.Text = null;
                        _txtEmailCQ.Text = null;
                        DangKyDeTai_Load(sender, e);

                    }
                    else
                    {
                        DKDTAtt.TenCoQuanTT = _txtTenCoQuanTT.Text;
                        DKDTAtt.DiaChiCQ = _txtDiaChiCQ.Text;
                        DKDTAtt.EmailCQ = _txtEmailCQ.Text;
                        DKDTAtt.SdtCQ = _txtDienThoaiCQ.Text;
                        DKDTAtt.MaSV = MainStudent.taiKhoan.ToString();
                        DKDTAtt.MaDT = _txtMaDeTai.Text;
                        MessageDialog messageDialog = new MessageDialog(@"Bạn chắc chắn đăng ký đề tài này?", MessageDialog.DialogType.YesNo);
                        messageDialog.SendValueDelegate = delegate(MessageDialog.DialogResultType result)
                        {
                            if (result == MessageDialog.DialogResultType.Yes)
                            {
                                DKDTCtrol.Insert_DiaDiemTT(DKDTAtt);
                                DKDTCtrol.Insert_SinhVien_DeTai(DKDTAtt);
                                _btnDangKyDeTai.Enabled = false;
                                _txtEmailCQ.Enabled = false;
                                _txtTenCoQuanTT.Enabled = false;
                                _txtDienThoaiCQ.Enabled = false;
                                _txtDiaChiCQ.Enabled = false;
                                MessageDialog messageDialog1 = new MessageDialog(@"Đăng ký thành công!", MessageDialog.DialogType.Ok);
                                messageDialog1.ShowDialog();
                                DangKyDeTai_Load(sender, e);

                            }
                        };
                        messageDialog.ShowDialog();
                        Refresh();
                    }
                }
                catch (Exception ex)
                {
                    MessageDialog messageDialog = new MessageDialog(@"Error: " + ex, MessageDialog.DialogType.Ok);
                    messageDialog.ShowDialog();
                }
               
            }
        }

        private void DSDeTai_GiaoVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _cboMaGiaoVienHD.Text = _dgvDSDeTai_GiaoVien.CurrentRow.Cells[2].Value.ToString();
            _txtTenGiaoVienHD.Text = _dgvDSDeTai_GiaoVien.CurrentRow.Cells[3].Value.ToString();
            _txtMaDeTai.Text = _dgvDSDeTai_GiaoVien.CurrentRow.Cells[0].Value.ToString();
            _txtTenDeTai.Text = _dgvDSDeTai_GiaoVien.CurrentRow.Cells[1].Value.ToString();
        }

        private void _btnTimKiemDeTaiDK_Click(object sender, EventArgs e)
        {
            string key = _txtTimKiemDeTaiDK.Text;
            _dgvDSDeTai_GiaoVien.DataSource = DKDTCtrol.Search(key);
            _txtTongBanGhi.Text = _dgvDSDeTai_GiaoVien.Rows.Count.ToString();

            if (_dgvDSDeTai_GiaoVien.Rows.Count > 0)
            {
                _cboMaGiaoVienHD.Text = _dgvDSDeTai_GiaoVien.CurrentRow.Cells[2].Value.ToString();
                _txtTenGiaoVienHD.Text = _dgvDSDeTai_GiaoVien.CurrentRow.Cells[4].Value.ToString();
                _txtMaDeTai.Text = _dgvDSDeTai_GiaoVien.CurrentRow.Cells[0].Value.ToString();
                _txtTenDeTai.Text = _dgvDSDeTai_GiaoVien.CurrentRow.Cells[1].Value.ToString();
            }
            else
            {
                MessageDialog messageDialog1 = new MessageDialog(@"Không tìm thấy thông tin được yêu cầu!", MessageDialog.DialogType.Ok);
                messageDialog1.ShowDialog();
                DangKyDeTai_Load(sender, e);
            }

        }
        #endregion event


    }
}
