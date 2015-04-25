using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SQLite;
using QuanLySinhVien.Common;

namespace QuanLySinhVien.GUI
{
    class DangNhapController
    {
        /// <summary>
        /// hàm lấy thông tin tài khoản theo tên đăng nhập và mật khẩu
        /// </summary>
        /// <param name="tkAttribute"></param>
        /// <returns></returns>
        public DataTable GetTaiKhoan(TaiKhoanAttribute tkAttribute)
        {
            string query = "SELECT TaiKhoan,MatKhau FROM TAIKHOAN WHERE TaiKhoan='" + tkAttribute.TenDangNhap + "' AND MatKhau='" + tkAttribute.MatKhau + "'";
            return DatabaseCore.GetDatatable(query);
        }

        /// <summary>
        /// hàm lấy quyền truy nhập theo tên đăng nhập và mật khẩu
        /// </summary>
        /// <param name="tkAttribute"></param>
        /// <returns></returns>
        public DataTable GetQuyen(TaiKhoanAttribute tkAttribute)
        {
            string query = "SELECT Quyen FROM TAIKHOAN WHERE TaiKhoan='" + tkAttribute.TenDangNhap + "' AND MatKhau='" + tkAttribute.MatKhau + "'";
            return DatabaseCore.GetDatatable(query);
        }

        /// <summary>
        /// hàm lấy tên sinh viên thực tập dựa vào tên đăng nhập, mật khẩu
        /// </summary>
        /// <param name="tkAttribute"></param>
        /// <returns></returns>
        public DataTable GetUserNameSinhVien(TaiKhoanAttribute tkAttribute)
        {
            string query = "SELECT TenSV FROM SINHVIENTHUCTAP,TAIKHOAN WHERE TaiKhoan='" + tkAttribute.TenDangNhap + "' AND MatKhau='" + tkAttribute.MatKhau + "' AND SINHVIENTHUCTAP.MaSV=TAIKHOAN.TaiKhoan";
            return DatabaseCore.GetDatatable(query);
        }

        /// <summary>
        /// hàm lấy tên giáo viên hướng dẫn dựa vào tên đăng nhập và mật khẩu
        /// </summary>
        /// <param name="tkAttribute"></param>
        /// <returns></returns>
        public DataTable GetUserNameGiaoVien(TaiKhoanAttribute tkAttribute)
        {
            string query = "SELECT TenGV FROM GIAOVIENHUONGDAN,TAIKHOAN WHERE TaiKhoan='" + tkAttribute.TenDangNhap + "' AND MatKhau='" + tkAttribute.MatKhau + "' AND GIAOVIENHUONGDAN.MaGV=TAIKHOAN.TaiKhoan";
            return DatabaseCore.GetDatatable(query);
        }
    }
}
