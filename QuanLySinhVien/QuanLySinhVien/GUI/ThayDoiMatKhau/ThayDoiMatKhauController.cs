using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SQLite;
using QuanLySinhVien.Common;

namespace QuanLySinhVien.GUI
{
    class ThayDoiMatKhauController
    {

        public void UpdatePass(ThayDoiMatKhauAttribute dmkAttribute)
        {
            string query = "UPDATE TAIKHOAN SET MatKhau='" + dmkAttribute.MatKhauMoi + "' WHERE MatKhau='" + dmkAttribute.MatKhauCu + "' AND TaiKhoan='" + MainStudent.taiKhoan + "'";
            DatabaseCore.ExecuteQuery(query);
        }
    }
}
