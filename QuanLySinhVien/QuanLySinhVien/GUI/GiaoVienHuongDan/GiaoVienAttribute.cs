using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLySinhVien.GUI
{
    class GiaoVienAttribute
    {
        #region Field

        /// <summary>
        /// khởi tạo các thuộc tính cần sử dụng trong form GiaoVienHuongDan
        /// </summary>
        private string _maGV, _tenGV, _gioiTinh, _diaChi, _dienThoai, _email;
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

        public string MaGV
        {
            get { return _maGV; }
            set { _maGV = value; }
        }

        public string TenGV
        {
            get { return _tenGV; }
            set { _tenGV = value; }
        }

        public string GioiTinh
        {
            get { return _gioiTinh; }
            set { _gioiTinh = value; }
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
