using System;
using System.Collections.Generic;
using System.Text;
using QuanLySinhVien.Common;
using System.Data;
namespace QuanLySinhVien.GUI
{
    class HuyDTDKCtrol
    {
        /// <summary>
        /// hàm xóa thông tin sinh viên đã đăng ký đề tài
        /// </summary>
        /// <param name="huyDT"></param>
        public void Delete_SV_DT(HuyDTDKAtt huyDT)
        {
            string query = "DELETE FROM SINHVIEN_DETAI WHERE MaSV='" + huyDT.MaSV + "'";
            DatabaseCore.ExecuteQuery(query);
        }
        /// <summary>
        /// hàm xóa thông tin địa điểm thực tập của sinh viên
        /// </summary>
        /// <param name="huyDT"></param>
        public void Delete_DiaDiemTT(HuyDTDKAtt huyDT)
        {
            string query = "DELETE FROM DIADIEMTHUCTAP WHERE MaSV='" + huyDT.MaSV + "'";
            DatabaseCore.ExecuteQuery(query);
        }
        /// <summary>
        /// hàm lấy thông tin đề tài mà các sinh viên đã đăng ký
        /// </summary>
        /// <returns></returns>
        public DataTable loadTTDT(HuyDTDKAtt huyDT)
        {
            string query = "SELECT DETAI.MaDeTai, DETAI.TenDeTai, DETAI.MaGV, DIADIEMTHUCTAP.TenDiaDiem, DIADIEMTHUCTAP.DiaChi, DIADIEMTHUCTAP.DienThoai, DIADIEMTHUCTAP.Email, TenGV FROM DIADIEMTHUCTAP, SINHVIEN_DETAI, GIAOVIENHUONGDAN, DETAI WHERE DIADIEMTHUCTAP.MaSV=SINHVIEN_DETAI.MaSV and SINHVIEN_DETAI.MaDeTai=DETAI.MaDeTai AND DETAI.MaGV = GIAOVIENHUONGDAN.MaGV AND SINHVIEN_DETAI.MaSV = '" + huyDT.MaSV + "'";
            return DatabaseCore.GetDatatable(query);
        }


    }
}
