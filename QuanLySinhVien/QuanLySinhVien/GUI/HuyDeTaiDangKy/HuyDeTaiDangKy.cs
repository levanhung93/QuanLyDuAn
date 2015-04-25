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
    public partial class HuyDeTaiDangKy : UserControl
    {
        #region Constructor
        public HuyDeTaiDangKy()
        {
            InitializeComponent();
        }
        #endregion Constructor

        #region Field
        /// <summary>
        /// khởi tạo đối tượng huyDT
        /// </summary>
        HuyDTDKAtt huyDTAtt = new HuyDTDKAtt();
        /// <summary>
        /// khơi tạo đối tượng huyDTCtrol
        /// </summary>
        HuyDTDKCtrol huyDTCtrol = new HuyDTDKCtrol();
        #endregion Field

        #region event



        private void HuyDeTaiDangKy_Load_1(object sender, EventArgs e)
        {
            if (MainStudent.quyen == "admin" || MainStudent.quyen == "GV")
            _btnHuyDeTai.Enabled = false;
            huyDTAtt.MaSV = MainStudent.taiKhoan.ToString();
            _dgvThongTinDeTaiDaDangKy.DataSource = huyDTCtrol.loadTTDT(huyDTAtt);
            _txtDiaChiCQ.Enabled = false;
            _txtDienThoaiCQ.Enabled = false;
            _txtEmailCQ.Enabled = false;
            _txtMaDeTai.Enabled = false;
            _txtMaGiaoVienHD.Enabled = false;
            _txtTenCoQuan.Enabled = false;
            _txtTenDeTai.Enabled = false;
            _txtTenGiaoVienHD.Enabled = false;
        }
        private void _btnHuyDeTai_Click(object sender, EventArgs e)
        {
            if (_txtMaGiaoVienHD.Text == "" || _txtMaDeTai.Text == "")
            {
                MessageDialog messageDialog = new MessageDialog(@"Bạn chưa chọn đề tài muốn hủy!", MessageDialog.DialogType.Ok);
                messageDialog.ShowDialog();
            }
            else
            {
                huyDTAtt.MaSV = MainStudent.taiKhoan.ToString();
                MessageDialog messageDialog = new MessageDialog(@"Bạn chắc chắn muốn hủy đề tài đã chọn?", MessageDialog.DialogType.YesNo);
                messageDialog.SendValueDelegate = delegate(MessageDialog.DialogResultType result)
                {
                    if (result == MessageDialog.DialogResultType.Yes)
                    {
                        huyDTCtrol.Delete_DiaDiemTT(huyDTAtt);
                        huyDTCtrol.Delete_SV_DT(huyDTAtt);
                        _btnHuyDeTai.Enabled = false;
                        MessageDialog messageDialog1 = new MessageDialog(@"Đã hủy đề tài!", MessageDialog.DialogType.Ok);
                        messageDialog1.ShowDialog();
                    }
                };
                messageDialog.ShowDialog();
                Refresh();
                HuyDeTaiDangKy_Load_1(sender, e);
            }
        }

        private void DSDeTaiDaDK_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _txtMaGiaoVienHD.Text = _dgvThongTinDeTaiDaDangKy.CurrentRow.Cells[2].Value.ToString();
            _txtTenGiaoVienHD.Text = _dgvThongTinDeTaiDaDangKy.CurrentRow.Cells[7].Value.ToString();
            _txtMaDeTai.Text = _dgvThongTinDeTaiDaDangKy.CurrentRow.Cells[0].Value.ToString();
            _txtTenDeTai.Text = _dgvThongTinDeTaiDaDangKy.CurrentRow.Cells[1].Value.ToString();
            _txtTenCoQuan.Text = _dgvThongTinDeTaiDaDangKy.CurrentRow.Cells[3].Value.ToString();
            _txtDiaChiCQ.Text = _dgvThongTinDeTaiDaDangKy.CurrentRow.Cells[4].Value.ToString();
            _txtEmailCQ.Text = _dgvThongTinDeTaiDaDangKy.CurrentRow.Cells[6].Value.ToString();
            _txtDienThoaiCQ.Text = _dgvThongTinDeTaiDaDangKy.CurrentRow.Cells[5].Value.ToString();
        }
        #endregion event
    }
}
