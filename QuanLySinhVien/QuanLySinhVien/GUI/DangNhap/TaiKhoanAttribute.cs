using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLySinhVien.GUI
{
    class TaiKhoanAttribute
    {
        #region Field
        /// <summary>
        /// khởi tạo các thuộc tính cần sử dụng trong form DangNhap
        /// </summary>
        private string _tenDangNhap, _matKhau;

        #endregion Field

        #region Property
        public string TenDangNhap
        {
            get { return _tenDangNhap; }
            set { _tenDangNhap = value; }
        }

        public string MatKhau
        {
            get { return _matKhau; }
            set { _matKhau = value; }
        }
        #endregion Property
    }
}
