using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLySinhVien.GUI
{
    class SinhVienAttribute
    {
        #region Field
        /// <summary>
        /// khai báo các thuộc tính cần sử dụng trong form SinhVienThucTap
        /// </summary>
        private string _maSV, _tenSV, _gioiTinh, _lop, _khoaHoc, _diaChi, _dienThoai, _email;
        private int _ngaySinh, _thangSinh, _namSinh;
        #endregion Field

        #region Property
        public int NgaySinh
        {
            get { return _ngaySinh; }
            set { _ngaySinh = value; }
        }

        public int ThangSinh
        {
            get { return _thangSinh; }
            set { _thangSinh = value; }
        }

        public int NamSinh
        {
            get { return _namSinh; }
            set { _namSinh = value; }
        }

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

        public string GioiTinh
        {
            get { return _gioiTinh; }
            set { _gioiTinh = value; }
        }

        public string Lop
        {
            get { return _lop; }
            set { _lop = value; }
        }

        public string KhoaHoc
        {
            get { return _khoaHoc; }
            set { _khoaHoc = value; }
        }

        public string DiaChi
        {
            get { return _diaChi; }
            set { _diaChi = value; }
        }

        public string DienThoai
        {
            get { return _dienThoai; }
            set { _dienThoai = value; }
        }

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }
        #endregion Property
    }
}
