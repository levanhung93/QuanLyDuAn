using System;
using System.Collections.Generic;
using System.Text;
using QuanLySinhVien.Common;
using System.Data;
namespace QuanLySinhVien.GUI
{
    class DangKyDeTaiController
    {
        /// <summary>
        /// hàm lấy thông tin đề tài và thông tin giáo viên thực tập
        /// </summary>
        /// <param name="DKDTAtt"></param>
        public DataTable LayDeTai()
        {
            string query = "SELECT DETAI.MaDeTai, DETAI.TenDeTai, DETAI.MaGV, GIAOVIENHUONGDAN.TenGV FROM DETAI, GIAOVIENHUONGDAN WHERE DETAI.MaGV = GIAOVIENHUONGDAN.MaGV";
            return DatabaseCore.GetDatatable(query);
        }
        /// <summary>
        /// hàm chèn mã sinh viên và mã đề tài vào bảng SINHVIEN_DETAI
        /// </summary>
        public void Insert_SinhVien_DeTai(DangKyDeTaiAttribute DKDT)
        {
            string query = "INSERT INTO SINHVIEN_DETAI VALUES ('" + DKDT.MaSV + "','" + DKDT.MaDT + "')";
            DatabaseCore.ExecuteQuery(query);
        }
        /// <summary>
        /// hàm chèn địa điểm thực tập của sinh viên
        /// </summary>
        /// <param name="DKDT"></param>
        public void Insert_DiaDiemTT(DangKyDeTaiAttribute DKDT)
        {
            string query = "INSERT INTO DIADIEMTHUCTAP VALUES ('" + DKDT.MaSV + "','" + DKDT.TenCoQuanTT + "','" + DKDT.DiaChiCQ + "','" + DKDT.SdtCQ + "','" + DKDT.EmailCQ + "')";
            DatabaseCore.ExecuteQuery(query);
        }
        /// <summary>
        /// hàm tìm kiếm thông tin đề tài
        /// </summary>
        /// <param name="TenDT"></param>
        /// <returns></returns>
        public DataTable Search(string TenDT)
        {
            string query = "SELECT * FROM DETAI, GIAOVIENHUONGDAN WHERE DETAI.MaGV = GIAOVIENHUONGDAN.MaGV AND TenDeTai='" + TenDT + "' OR GIAOVIENHUONGDAN.TenGV='" + TenDT + "'";
            return DatabaseCore.GetDatatable(query);
        }
        /// <summary>
        /// Hàm kiểm tra sinh viên đã đăng ký hay chưa
        /// </summary>
        /// <param name="huyDT"></param>
        /// <returns></returns>
        public DataTable KiemTra(DangKyDeTaiAttribute DKDT)
        {
            string query = "SELECT * FROM SINHVIEN_DETAI WHERE MaSV='" + DKDT.MaSV + "'";
            return DatabaseCore.GetDatatable(query);
        }
    }
}
