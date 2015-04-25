using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SQLite;
using QuanLySinhVien.Common;

namespace QuanLySinhVien.GUI
{
    class GiaoVienController
    {
        /// <summary>
        /// hàm load mã giáo viên lên _cboGiaoVien
        /// </summary>
        /// <param name="gvAttribute"></param>
        /// <returns></returns>
        public DataTable LoadGiaoVien()
        {
            string query = "SELECT MaGV FROM GIAOVIEN WHERE MaGV NOT IN (SELECT MaGV FROM GIAOVIENHUONGDAN)";
            return DatabaseCore.GetDatatable(query);
        }

        /// <summary>
        /// hàm lấy toàn bộ thông tin giáo viên theo mã giáo viên được chọn từ _cboGiaoVien
        /// </summary>
        /// <param name="gvAttribute"></param>
        /// <returns></returns>
        public DataTable GetFullGiaoVien(GiaoVienAttribute gvAttribute)
        {
            string query = "SELECT * FROM GIAOVIEN WHERE MaGV='" + gvAttribute.MaGV + "'";
            return DatabaseCore.GetDatatable(query);
        }

        /// <summary>
        /// hàm thực hiện thêm giáo viên vào GIAOVIENHUONGDAN
        /// </summary>
        /// <param name="gvAttribute"></param>
        public void InsertGiaoVien(GiaoVienAttribute gvAttribute)
        {
            string query = "INSERT INTO GIAOVIENHUONGDAN VALUES ('" + gvAttribute.MaGV + "','" + gvAttribute.TenGV + "','" +gvAttribute.NgaySinh + "', '" + gvAttribute.ThangSinh + "','" + gvAttribute.NamSinh + "','" + gvAttribute.DiaChi + "','" + gvAttribute.DienThoai + "','" + gvAttribute.GioiTinh + "','" + gvAttribute.Email + "') ";
            DatabaseCore.ExecuteQuery(query);
        }

        /// <summary>
        /// hàm thực hiện thêm tài khoản, mật khẩu và quyền cho giáo viên
        /// </summary>
        /// <param name="gvAttribute"></param>
        public void InsertTaiKhoan(GiaoVienAttribute gvAttribute)
        {
            string query = "INSERT INTO TAIKHOAN VALUES ('" + gvAttribute.MaGV + "','" + gvAttribute.MaGV + "','GV')";
            DatabaseCore.ExecuteQuery(query);
        }

        /// <summary>
        /// hàm hiển thị thông tin giáo viên hướng dẫn lên _dgvGiaoVien
        /// </summary>
        /// <returns></returns>
        public DataTable ShowGiaoVien()
        {
            string query = "SELECT * FROM GIAOVIENHUONGDAN ";
            return DatabaseCore.GetDatatable(query);
        }
        /// <summary>
        /// hàm xóa thông tin giáo viên hướng dẫn khỏi danh sách
        /// </summary>
        /// <param name="gvAttribute"></param>
        public void DeleteGiaoVienHD(GiaoVienAttribute gvAttribute)
        {
            string query="DELETE FROM GIAOVIENHUONGDAN WHERE MaGV='"+gvAttribute.MaGV+"'";
            DatabaseCore.ExecuteQuery(query);
        }
        /// <summary>
        /// hàm thực hiện xóa tài khoản giáo viên hướng dẫn khi giao viên hướng dẫn bị xóa bỏ
        /// </summary>
        /// <param name="gvAttribute"></param>
        public void DeleteTaiKhoan(GiaoVienAttribute gvAttribute)
        {
            string query = "DELETE FROM TAIKHOAN WHERE TaiKhoan='" + gvAttribute.MaGV + "'";
            DatabaseCore.ExecuteQuery(query);
        }
        /// <summary>
        /// hàm tìm kiếm thông tin giáo viên hướng dẫn
        /// </summary>
        /// <param name="tenGV"></param>
        public DataTable SearchGiaoVienHD(string tenGV)
        {
            string query = "SELECT * FROM GIAOVIENHUONGDAN WHERE TenGV = '" + tenGV + "' ";
            return DatabaseCore.GetDatatable(query);
        }
    }
}
