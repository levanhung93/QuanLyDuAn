using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLySinhVien.GUI
{
    class DangKyDeTaiAttribute
    {
        #region Property
        string _maGV, _tenGV, _maDT, _tenDT, _tenCoQuanTT, _diaChiCQ, _sdtCQ, _emailCQ, _maSV;

        public string MaDT
        {
            get { return _maDT; }
            set { _maDT = value; }
        }

        public string MaSV
        {
            get { return _maSV; }
            set { _maSV = value; }
        }

        public string EmailCQ
        {
            get { return _emailCQ; }
            set { _emailCQ = value; }
        }

        public string SdtCQ
        {
            get { return _sdtCQ; }
            set { _sdtCQ = value; }
        }

        public string DiaChiCQ
        {
            get { return _diaChiCQ; }
            set { _diaChiCQ = value; }
        }

        public string TenCoQuanTT
        {
            get { return _tenCoQuanTT; }
            set { _tenCoQuanTT = value; }
        }

        public string TenDT
        {
            get { return _tenDT; }
            set { _tenDT = value; }
        }

        public string TenGV
        {
            get { return _tenGV; }
            set { _tenGV = value; }
        }

        public string MaGV
        {
            get { return _maGV; }
            set { _maGV = value; }
        }


        #endregion Property
    }
}
