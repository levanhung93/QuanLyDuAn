using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLySinhVien.GUI
{
    class ThayDoiMatKhauAttribute
    {
        #region Field
        /// <summary>
        /// khởi tạo các thuộc tính cần sử dụng trong form ThayDoiMatKhau
        /// </summary>
        private string _tenDangNhap, _matKhauCu, _matKhauMoi, _nhapLaiMKMoi;
        #endregion Field

        #region Property
        public string TenDangNhap
        {
            get { return _tenDangNhap; }
            set { _tenDangNhap = value; }
        }

        public string MatKhauCu
        {
            get { return _matKhauCu; }
            set { _matKhauCu = value; }
        }

        public string MatKhauMoi
        {
            get { return _matKhauMoi; }
            set { _matKhauMoi = value; }
        }

        public string NhapLaiMKMoi
        {
            get { return _nhapLaiMKMoi; }
            set { _nhapLaiMKMoi = value; }
        }
        #endregion Property
    }
}
