using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace QuanLySinhVien.Common
{
    partial class DatabaseCore
    {
        #region Method
        /// <summary>
        /// thực hiện câu lệnh tạo các bảng dữ liệu
        /// </summary>
        private static void ExecuteCreateDatabase()
        {
            CreateSinhVien();
            CreateSinhVienThucTap();
            CreateGiaoVien();
            CreateGiaoVienHuongDan();
            CreateLop();
            CreateKhoaHoc();
            CreateDeTai();
            CreateDiem();
            CreateDiaDiemThucTap();
            CreateSinhVienDT();
            CreateTaiKhoan();
        }

        /// <summary>
        /// thực hiện tạo bảng SinhVien
        /// </summary>
        private static void CreateSinhVien()
        {
            string query = "CREATE TABLE SINHVIEN (MaSV VARCHAR(10),TenSV NVARCHAR(50),Ngay INT,Thang INT,Nam INT,DiaChi NVARCHAR(200),DienThoai NCHAR(11),GioiTinh NVARCHAR(5),Email NVARCHAR(200),MaLop VARCHAR(10) )";
            ExecuteQuery(query);
        }

        /// <summary>
        /// thực hiện tạo bảng SinhVienThucTap
        /// </summary>
        private static void CreateSinhVienThucTap()
        {
            string query = "CREATE TABLE SINHVIENTHUCTAP (MaSV VARCHAR(10),TenSV NVARCHAR(50),Ngay INT,Thang INT,Nam INT,DiaChi NVARCHAR(200),DienThoai NCHAR(11),GioiTinh NVARCHAR(5),Email NVARCHAR(200),MaLop VARCHAR(10) )";
            ExecuteQuery(query);
        }

        /// <summary>
        /// thực hiện tạo bảng GiaoVien
        /// </summary>
        private static void CreateGiaoVien()
        {
            string query = "CREATE TABLE GIAOVIEN (MaGV VARCHAR(10),TenGV NVARCHAR(50),Ngay INT,Thang INT,Nam INT,DiaChi NVARCHAR(200),DienThoai NCHAR(11),GioiTinh NVARCHAR(5),Email NVARCHAR(200))";
            ExecuteQuery(query);
        }

        /// <summary>
        /// thực hiện tạo bảng GiaoVienHuongDan
        /// </summary>
        private static void CreateGiaoVienHuongDan()
        {
            string query = "CREATE TABLE GIAOVIENHUONGDAN (MaGV VARCHAR(10),TenGV NVARCHAR(50),Ngay INT,Thang INT,Nam INT,DiaChi NVARCHAR(200),DienThoai NCHAR(11),GioiTinh NVARCHAR(5),Email NVARCHAR(200))";
            ExecuteQuery(query);
        }

        /// <summary>
        /// thực hiện tạo bảng Lop
        /// </summary>
        private static void CreateLop()
        {
            string query = "CREATE TABLE LOP (MaLop VARCHAR(10),TenLop NVARCHAR(50),MaKhoa VARCHAR(10) )";
            ExecuteQuery(query);
        }

        /// <summary>
        /// thực hiện tạo bảng KhoaHoc
        /// </summary>
        private static void CreateKhoaHoc()
        {
            string query = "CREATE TABLE KHOAHOC (MaKhoa VARCHAR(10),KhoaHoc NVARCHAR(50))";
            ExecuteQuery(query);
        }

        /// <summary>
        /// thực hiện tạo bảng DeTai
        /// </summary>
        private static void CreateDeTai()
        {
            string query = "CREATE TABLE DETAI (MaDT VARCHAR(10),TenDT TEXT,MaGV VARCHAR(10) )";
            ExecuteQuery(query);
        }

        /// <summary>
        /// thực hiện tạo bảng Diem
        /// </summary>
        private static void CreateDiem()
        {
            string query = "CREATE TABLE DIEM (MaSV VARCHAR(10),Diem1 FLOAT, Diem2 FLOAT, Diem3 FLOAT,DiemTB FLOAT, DiemBaoVe FLOAT, DiemTongKet FLOAT, LanThucTap INT, GhiChu NVARCHAR(50))";
            ExecuteQuery(query);
        }

        /// <summary>
        /// thực hiện tạo bảng DiaDiemThucTap
        /// </summary>
        private static void CreateDiaDiemThucTap()
        {
            string query = "CREATE TABLE DIADIEMTHUCTAP (MaSV VARCHAR(10),TenDiaDiem NVARCHAR(200),DiaChi NVARCHAR(200),DienThoai NCHAR(11),Email NVARCHAR(200))";
            ExecuteQuery(query);
        }

        /// <summary>
        /// thực hiện tạo bảng SinhVien_DeTai
        /// </summary>
        private static void CreateSinhVienDT()
        {
            string query = "CREATE TABLE SINHVIEN_DETAI (MaSV VARCHAR(10),MaDeTai VARCHAR(10) )";
            ExecuteQuery(query);
        }

        /// <summary>
        /// thực hiện tạo bảng TaiKhoan
        /// </summary>
        private static void CreateTaiKhoan()
        {
            string query = "CREATE TABLE TAIKHOAN (TaiKhoan NVARCHAR(200),MatKhau NVARCHAR(200),Quyen NVARCHAR(50))";
            ExecuteQuery(query);
        }

        #endregion Method
    }
}
