using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLySinhVien.GUI
{
    class BangDiemAttribute
    {
        #region Field
        /// <summary>
        /// khai báo các thuộc tính cần sử dụng trong form BangDiem
        /// </summary>
        private string _maSV, _tenSV, _ghiChu;
        private int _lanThucTap;
        private float _diem1, _diem2, _diem3, _diemTB, _diemBaoVe, _diemTongKet;

        #endregion Field

        #region Property
        public string MaSV
        {
            get { return _maSV; }
            set { _maSV = value; }
        }

        public string TenSV
        {
            get { return _tenSV; }
            set { _tenSV = value; }
        }

        public string GhiChu
        {
            get { return _ghiChu; }
            set { _ghiChu = value; }
        }

        public int LanThucTap
        {
            get { return _lanThucTap; }
            set { _lanThucTap = value; }
        }

        public float Diem1
        {
            get { return _diem1; }
            set { _diem1 = value; }
        }

        public float Diem2
        {
            get { return _diem2; }
            set { _diem2 = value; }
        }

        public float Diem3
        {
            get { return _diem3; }
            set { _diem3 = value; }
        }

        public float DiemTB
        {
            get { return _diemTB; }
            set { _diemTB = value; }
        }

        public float DiemBaoVe
        {
            get { return _diemBaoVe; }
            set { _diemBaoVe = value; }
        }

        public float DiemTongKet
        {
            get { return _diemTongKet; }
            set { _diemTongKet = value; }
        }
        #endregion Property
    }
}
