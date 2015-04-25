using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SQLite;
using QuanLySinhVien.Common;

namespace QuanLySinhVien.GUI
{
    class BangDiemController
    {
        /// <summary>
        /// hàm load thông tin sinh viên thực tập
        /// </summary>
        /// <returns></returns>
        public DataTable LoadSinhVienThucTap()
        {
            string query = "SELECT SINHVIEN_DETAI.MaSV, TenSV FROM SINHVIENTHUCTAP,SINHVIEN_DETAI,DETAI WHERE SINHVIENTHUCTAP.MaSV=SINHVIEN_DETAI.MaSV AND DETAI.MaDeTai=SINHVIEN_DETAI.MaDeTai AND DETAI.MaGV='" + MainStudent.taiKhoan + "'";
            return DatabaseCore.GetDatatable(query);
        }

        /// <summary>
        /// hàm lấy thông tin sinh viên thực tập
        /// </summary>
        /// <param name="diemAttribute"></param>
        /// <returns></returns>
        public DataTable GetSinhVienTT(BangDiemAttribute diemAttribute)
        {
            string query = "SELECT MaSV, TenSV FROM SINHVIENTHUCTAP WHERE MaSV='"+diemAttribute.MaSV+"'";
            return DatabaseCore.GetDatatable(query);
        }

        /// <summary>
        /// hàm thêm điểm của sinh viên thực tập vào bảng điểm
        /// </summary>
        /// <param name="diemAttribute"></param>
        public void InsertDiem(BangDiemAttribute diemAttribute)
        {
            string query = "INSERT INTO DIEM VALUES ('"+diemAttribute.MaSV+"','"+diemAttribute.Diem1+"','"+diemAttribute.Diem2+"','"+diemAttribute.Diem3+"','"+diemAttribute.DiemTB+"','"+diemAttribute.DiemBaoVe+"','"+diemAttribute.DiemTongKet+"','"+diemAttribute.LanThucTap+"','"+diemAttribute.GhiChu+"')";
            DatabaseCore.ExecuteQuery(query);
        }

        /// <summary>
        /// hàm sửa đổi thông tin điểm của sinh viên thực tập
        /// </summary>
        /// <param name="diemAttribute"></param>
        public void UpdateDiem(BangDiemAttribute diemAttribute)
        {
            string query = "UPDATE DIEM SET Diem1='" + diemAttribute.Diem1 + "',Diem2='" + diemAttribute.Diem2 + "',Diem3='" + diemAttribute.Diem3 + "',DiemTB='" + diemAttribute.DiemTB + "',DiemBaoVe='" + diemAttribute.DiemBaoVe + "',DiemTongKet='" + diemAttribute.DiemTongKet + "',GhiChu='" + diemAttribute.GhiChu + "' WHERE MaSV='" + diemAttribute.MaSV + "' AND LanThucTap='" + diemAttribute.LanThucTap + "'";
            DatabaseCore.ExecuteQuery(query);
        }

        /// <summary>
        /// hàm xóa thông tin điểm của sinh viên thực tập
        /// </summary>
        /// <param name="diemAtribuete"></param>
        public void DeleTeDiem(BangDiemAttribute diemAtribuete)
        {
            string query = "DELETE FROM DIEM WHERE MaSV='" + diemAtribuete.MaSV + "' AND LanThucTap='" + diemAtribuete.LanThucTap + "'";
            DatabaseCore.ExecuteQuery(query);
        }
        
        /// <summary>
        /// hàm hiển thị thông tin bảng điểm
        /// </summary>
        /// <returns></returns>
        public DataTable ShowBangDiem()
        {
            string query = "SELECT DIEM.*, TenSV FROM SINHVIENTHUCTAP, DIEM, DETAI,SINHVIEN_DETAI WHERE DIEM.MaSV=SINHVIENTHUCTAP.MaSV AND DIEM.MaSV=SINHVIEN_DETAI.MASV AND DETAI.MaDeTai=SINHVIEN_DETAI.MaDeTai AND DETAI.MaGV='" + MainStudent.taiKhoan + "'";
            return DatabaseCore.GetDatatable(query);
        }
        /// <summary>
        /// hàm tìm kiếm bảng điểm của sinh viên theo mã sinh viên
        /// </summary>
        /// <param name="bangDiem"></param>
        /// <returns></returns>
        public DataTable SearchBangDiem(String maSV)
        {
            string query = "SELECT DIEM.*, TenSV FROM SINHVIENTHUCTAP, DIEM, DETAI,SINHVIEN_DETAI WHERE DIEM.MaSV=SINHVIENTHUCTAP.MaSV AND DIEM.MaSV=SINHVIEN_DETAI.MASV AND DETAI.MaDeTai=SINHVIEN_DETAI.MaDeTai AND DETAI.MaGV='" + MainStudent.taiKhoan + "' AND DIEM.MaSV='"+maSV+"'";
            return DatabaseCore.GetDatatable(query);
        }

        /// <summary>
        /// hàm hiển thị thông tin bảng điểm cho admin và sinh viên thực tập xem
        /// </summary>
        /// <returns></returns>
        public DataTable ShowBangDiemAdminSV()
        {
            string query = "SELECT DIEM.*, TenSV FROM SINHVIENTHUCTAP, DIEM WHERE DIEM.MaSV=SINHVIENTHUCTAP.MaSV";
            return DatabaseCore.GetDatatable(query);
        }
    }
}
