using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SQLite;
using QuanLySinhVien.Common;

namespace QuanLySinhVien.GUI
{
    class DeTaiThucTapController
    {
        /// <summary>
        /// hàm load mã giáo viên hướng dẫn
        /// </summary>
        /// <returns></returns>
        public DataTable LoadGiaoVienHD()
        {
            string query = "SELECT MaGV FROM GIAOVIENHUONGDAN";
            return DatabaseCore.GetDatatable(query);
        }
        /// <summary>
        /// hàm lấy tên giáo viên theo mã giáo viên được chọn từ _cboMaGiaoVienHD
        /// </summary>
        /// <param name="detaiAttribute"></param>
        /// <returns></returns>
        public DataTable GetGiaoVien(DeTaiThucTapAttribute detaiAttribute)
        {
            string query = "SELECT MaGV,TenGV FROM GIAOVIENHUONGDAN WHERE MaGV='" + detaiAttribute.MaGiaoVienHD + "'";
            return DatabaseCore.GetDatatable(query);
        }
        /// <summary>
        /// hàm load mã đề tài
        /// </summary>
        /// <returns></returns>
        public DataTable LoadMaDeTai()
        {
            string query = "SELECT MaDeTai FROM DETAI";
            return DatabaseCore.GetDatatable(query);
        }

        public DataTable ShowDeTai()
        {
            string query = "SELECT MaDeTai,TenDeTai,DETAI.MaGV,TenGV FROM GIAOVIENHUONGDAN,DETAI WHERE GIAOVIENHUONGDAN.MaGV=DETAI.MaGV";
            return DatabaseCore.GetDatatable(query);
        }
        /// <summary>
        /// hàm thêm thông tin đề tài vào csdl
        /// </summary>
        /// <param name="detaiAttribute"></param>
        public void InsertDeTai(DeTaiThucTapAttribute detaiAttribute)
        {
            string query = "INSERT INTO DETAI VALUES ('" + detaiAttribute.MaDeTai + "', '" + detaiAttribute.TenDeTai + "','" + detaiAttribute.MaGiaoVienHD + "')";
            DatabaseCore.ExecuteQuery(query);
        }
        /// <summary>
        /// hàm thực hiện sửa thông tin đề tài
        /// </summary>
        /// <param name="detaiAttribute"></param>
        public void UpdateDeTai(DeTaiThucTapAttribute detaiAttribute)
        {
            string query = "UPDATE DETAI SET TenDeTai='" + detaiAttribute.TenDeTai + "',MaGV='" + detaiAttribute.MaGiaoVienHD + "' WHERE MaDeTai='" + detaiAttribute.MaDeTai + "'";
            DatabaseCore.ExecuteQuery(query);
        }
        /// <summary>
        /// hàm thực hiện xóa thông tin đề tài
        /// </summary>
        /// <param name="detaiAttribute"></param>
        public void DeleteDeTai(DeTaiThucTapAttribute detaiAttribute)
        {
            string query = "DELETE FROM DETAI WHERE MaDeTai='" + detaiAttribute.MaDeTai + "'";
            DatabaseCore.ExecuteQuery(query);
        }
        /// <summary>
        /// hàm hiển thị các thông tin được tìm kiếm theo tên đề tài
        /// </summary>
        /// <param name="TenDeTai"></param>
        /// <returns></returns>
        public DataTable ShowSearchDeTai(String TenDeTai)
        {
            string query = "SELECT MaDeTai,TenDeTai,DETAI.MaGV,TenGV FROM GIAOVIENHUONGDAN,DETAI WHERE GIAOVIENHUONGDAN.MaGV=DETAI.MaGV AND TenDeTai = '" + TenDeTai + "' ";
            return DatabaseCore.GetDatatable(query);
        }

    }
}
