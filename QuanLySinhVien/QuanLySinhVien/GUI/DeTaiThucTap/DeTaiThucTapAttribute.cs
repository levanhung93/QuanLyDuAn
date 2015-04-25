using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLySinhVien.GUI
{
    class DeTaiThucTapAttribute
    {
        #region Field
        /// <summary>
        /// khởi tạo các thuộc tính cần sử dụng trong form DeTaiThucTap
        /// </summary>
        private string _maDeTai, _tenDeTai, _maGiaoVienHD, _tenGiaoVienHD;
        #endregion Field

        #region Property

        public string MaDeTai
        {
            get { return _maDeTai; }
            set { _maDeTai = value; }
        }

        public string TenDeTai
        {
            get { return _tenDeTai; }
            set { _tenDeTai = value; }
        }

        public string MaGiaoVienHD
        {
            get { return _maGiaoVienHD; }
            set { _maGiaoVienHD = value; }
        }

        public string TenGiaoVienHD
        {
            get { return _tenGiaoVienHD; }
            set { _tenGiaoVienHD = value; }
        }
        #endregion Property
    }
}
