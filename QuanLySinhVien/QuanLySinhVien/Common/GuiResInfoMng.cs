using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using QuanLySinhVien.GUI;

namespace QuanLySinhVien.Common
{
    /// <summary>
    /// class quản lý toàn bộ hoạt động của hệ thống
    /// </summary>
    class GuiResInfoMng
    {
        #region Delegate
        /// <summary>
        /// delegate truyền thông điệp đến các form
        /// </summary>
        /// <param name="e">Event ID</param>
        /// <param name="data">dữ liệu bất kỳ</param>
        internal delegate void DelegateGuiEvent(GuiEventID e, object data);
        /// <summary>
        /// Event quản lý việc truyền dữ liệu
        /// </summary>
        public static event DelegateGuiEvent GuiEventHandle;
        #endregion Delegate

        #region Enum
        /// <summary>
        /// định nghĩa các form/màn hình
        /// </summary>
        public enum ScreenID
        {
            None,
            SinhVienThucTapScreen,
            GiaoVienHuongDanScreen,
            DeTaiThucTapScreen,
            DangKyDeTaiScreen,
            HuyDeTaiDangKyScreen,
            BangDiemScreen,
            BaoCaoThongKeScreen,
            TroGiupScreen,
            TrangChuScreen,
            CapLaiMatKhauScreen
        }
        #endregion Enum

        #region Inner Class
        /// <summary>
        /// class định nghĩa EventID
        /// </summary>
        internal class GuiEventID
        {
             /// <summary>
            /// Định nghĩa các event ID
            /// </summary>
             internal enum EventID
            {
                /// <summary>
                /// None
                /// </summary>
                None,

                /// <summary>
                /// Event thay đổi màn hình
                /// </summary>
                ChangeScreen,

            }
             /// <summary>
             /// ID của event
             /// </summary>
             public EventID ID = EventID.None; 
        }

        #endregion Inner Class

        #region Field

        private static List<ScreenID> _listScreenID;
        private const string _SCREEN_ID_NOT_FOUND = @"Not found screen";

        #endregion Field

         #region Method
        /// <summary>
        /// Hàm thay đổi màn hình
        /// </summary>
        /// <param name="screenID">ID của màn hình</param>
        public static void ChangeScreen(ScreenID screenID)
        {
            //Nếu màn hình muốn thay đổi chính là màn hình hiện tại thỉ bỏ qua
            if (GetCurrentScreen() == screenID)
            {
                return;
            }

            //Lấy ra tên của màn hình
            string screenName = GetScreenName(screenID);

            //Lấy ra handle của màn hình
            UserControl userControl = GetIntanceScreen(screenID);

            //Lấy ra form main hiện hành
            MainStudent mainStudent = Program.MainForm as MainStudent;

            if (mainStudent != null)
            {
                //Thay đổi màn hình
                mainStudent.ChangeControlOfPanel(userControl);

                //Thông báo đến cho các màn hình khác là có sự thay đổi màn hình
                SendInternalEvent(new GuiEventID()
                {
                    ID = GuiEventID.EventID.ChangeScreen
                }, screenName);
            }
        }

         /// <summary>
        /// Hàm lấy tên của màn hình thông qua ID
        /// </summary>
        /// <param name="screenID">ScreenID của màn hình</param>
        /// <returns>Tên màn hình</returns>
        public static string GetScreenName(ScreenID screenID)
        {
            string str = "";
            switch (screenID)
            {
                case ScreenID.SinhVienThucTapScreen:
                    str = @"Quản lý sinh viên thực tập";
                    break;
                case ScreenID.GiaoVienHuongDanScreen:
                    str = @"Quản lý giáo viên hướng dẫn";
                    break;
                case ScreenID.DeTaiThucTapScreen:
                    str = @"Quản lý đề tài thực tập";
                    break;
                case ScreenID. DangKyDeTaiScreen:
                    str = @"Quản lý đăng ký đề tài thực tập";
                    break;
                case ScreenID.HuyDeTaiDangKyScreen:
                    str = @"Quản lý hủy đề tài đăng ký";
                    break;
                case ScreenID.BangDiemScreen:
                    str = @"Quản lý bảng điểm";
                    break;
                case ScreenID.BaoCaoThongKeScreen:
                    str = @"Quản lý báo cáo thống kê";
                    break;
                case ScreenID. TroGiupScreen:
                    str = @"Trợ giúp";
                    break;
                case ScreenID.TrangChuScreen:
                    str=@"Trang chủ";
                    break;
                default:
                    throw new ArgumentOutOfRangeException(_SCREEN_ID_NOT_FOUND);
            }
            return str;
        }

        /// <summary>
        /// Hàm lấy ra handle của screen
        /// </summary>
        /// <param name="screenID">ScreenID tương ứng</param>
        /// <returns>Handle của screenID</returns>
        private static UserControl GetIntanceScreen(ScreenID screenID)
        {
            UserControl intance = null;
            switch (screenID)
            {
                case ScreenID.SinhVienThucTapScreen:
                    intance = new SinhVienThucTap();
                    break;
                case ScreenID.GiaoVienHuongDanScreen:
                    intance = new GiaoVienHuongDan();
                    break;
                case ScreenID.DeTaiThucTapScreen:
                    intance = new DeTaiThucTap();
                    break;
                case ScreenID.DangKyDeTaiScreen:
                    intance = new DangKyDeTai();
                    break;
                case ScreenID.HuyDeTaiDangKyScreen:
                    intance = new HuyDeTaiDangKy();
                    break;
                case ScreenID.BangDiemScreen:
                    intance = new BangDiem();
                    break;
                case ScreenID.BaoCaoThongKeScreen:
                    intance = new BaoCaoThongKe();
                    break;
                case ScreenID.TroGiupScreen:
                    intance = new TroGiup();
                    break;
                case ScreenID.TrangChuScreen:
                    intance = new TrangChu();
                    break;
                default:
                    throw new ArgumentOutOfRangeException(_SCREEN_ID_NOT_FOUND);
            }
            return intance;
        }

        /// <summary>
        /// Hàm gửi event đến toàn bộ các form
        /// </summary>
        /// <param name="e">EventID muốn thông báo</param>
        /// <param name="data">Nội dung muốn thông báo</param>
        public static void SendInternalEvent(GuiEventID e, object data)
        {
            if (GuiEventHandle != null)
            {
                GuiEventHandle(e, data);
            }
        }

        public static MainStudent GetMainStuden()
        {
            MainStudent mainStudent = Program.MainForm as MainStudent;
            return mainStudent;
        }

        /// <summary>
        /// Hàm lấy screenID hiện tại
        /// </summary>
        /// <returns>ScreenID</returns>
        public static ScreenID GetCurrentScreen()
        {
            if (null == _listScreenID || _listScreenID.Count == 0)
            {
                return ScreenID.None;
            }
            return _listScreenID[_listScreenID.Count - 1];
        }
       #endregion Method
    }
}
