using System;
using System.Linq;
using System.Text;
using QLHS.Entities;
using QLHS.Business.Components;
using QLHS.Utility;
using QLHS.Presenations;
using System.Drawing;
namespace QLHS.Presenations
{
    #region Giao diện menu 
    public class MenuChinh
    {
        Paint pt = new Paint(100, 45);
        FormHS fhs = new FormHS();
        FormLop fl = new FormLop();
        FormGVCN fgv = new FormGVCN();
        FormBangDiem fbd = new FormBangDiem();
        FormTimKiem ftk = new FormTimKiem();
        FormThongKe fthk = new FormThongKe();
        ThongTinPM tt = new ThongTinPM();
        FormMonHoc mh = new FormMonHoc();
        public static  FormDN dn = new FormDN();
        public static FormBia fb = new FormBia();
        #region Tạo menu chính
        public void MenuChinh1()
        {
            pt.pnt("┏", 4, 5);
            pt.pnt("┗", 4, 46);
            pt.pnt("┓", 95, 5);
            pt.pnt("┛", 95, 46);

            pt.pnt("━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━", 5, 5);
            pt.pnt("━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━", 5, 46);
            pt.pnt("                                TRƯỜNG ĐẠI HỌC SƯ PHẠM KỸ THUẬT HƯNG YÊN ",0,1);
            pt.pnt("                                      KHOA CÔNG NGHỆ THÔNG TIN ", 1, 2);
            pt.pnt("                                     ------- ○○○○ -------", 3, 3);
            // Vẽ 2 cột ngoài
            for (int i = 6; i < 46; ++i)
            {
                pt.pnt("┃", 4, i);
                pt.pnt("┃", 95, i);
            }
            #region Chữ ký
            Console.ForegroundColor = ConsoleColor.Red;
            pt.pnt("D", 5, 45);
            Console.ForegroundColor = ConsoleColor.White;
            pt.pnt("e", 6, 45);
            Console.ForegroundColor = ConsoleColor.Cyan;
            pt.pnt("s", 7, 45);
            Console.ForegroundColor = ConsoleColor.Green;
            pt.pnt("i", 8, 45);
            Console.ForegroundColor = ConsoleColor.Yellow;
            pt.pnt("g", 9, 45);
            Console.ForegroundColor = ConsoleColor.Gray;
            pt.pnt("n", 10, 45);
            Console.ForegroundColor = ConsoleColor.Magenta;
            pt.pnt("e", 11, 45);
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            pt.pnt("d", 12, 45);
            Console.ForegroundColor = ConsoleColor.DarkRed;
            pt.pnt("b", 14, 45);
            Console.ForegroundColor = ConsoleColor.Yellow;
            pt.pnt("y", 15, 45);
            Console.ForegroundColor = ConsoleColor.Red;
            pt.pnt("T", 17, 45);
            Console.ForegroundColor = ConsoleColor.Yellow;
            pt.pnt("e", 18, 45);
            Console.ForegroundColor = ConsoleColor.Green;
            pt.pnt("a", 19, 45);
            Console.ForegroundColor = ConsoleColor.Red;
            pt.pnt("m", 20, 45);
            Console.ForegroundColor = ConsoleColor.Magenta;
            pt.pnt("T", 22, 45);
            Console.ForegroundColor = ConsoleColor.Yellow;
            pt.pnt("™", 23, 45);
            Console.ForegroundColor = ConsoleColor.White;
            #endregion
            Console.ForegroundColor = ConsoleColor.Green;
            pt.pnt(" CHƯƠNG TRÌNH QUẢN LÝ HỌC SINH", 34, 6);
            Console.ForegroundColor = ConsoleColor.White;

            pt.pnt("┏", 19, 12);
            pt.pnt("┓", 79, 12);
            pt.pnt("───────────────────────────────────────────────────────────", 20, 12);
            pt.pnt("┛", 79, 36);
            pt.pnt("┗", 19, 36);

            // Vẽ 2 cột trong
            for (int i = 13; i < 36; ++i)
            {
                pt.pnt("┃", 19, i);
                pt.pnt("┃", 79, i);
            }
            for (int i = 16; i < 36; i += 2)
            {
                pt.pnt("┠", 19, i);
            }
            for (int i = 16; i < 36; i += 2)
            {
                pt.pnt("┨", 79, i);
            }
            pt.pnt("━━━━━┳━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━", 20, 16);
            pt.pnt("───────────────────────────────────────────────────────────", 20, 18);
            pt.pnt("───────────────────────────────────────────────────────────", 20, 20);
            pt.pnt("───────────────────────────────────────────────────────────", 20, 22);
            pt.pnt("───────────────────────────────────────────────────────────", 20, 24);
            pt.pnt("───────────────────────────────────────────────────────────", 20, 26);
            pt.pnt("───────────────────────────────────────────────────────────", 20, 28);
            pt.pnt("───────────────────────────────────────────────────────────", 20, 30);
            pt.pnt("───────────────────────────────────────────────────────────", 20, 32);
            pt.pnt("───────────────────────────────────────────────────────────", 20, 34);
            pt.pnt("━━━━━┻━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━", 20, 36);



            for (int i = 17; i < 36; ++i)
            {
                pt.pnt("┃", 25, i);
            }

            Console.ForegroundColor = ConsoleColor.Yellow;
            pt.pnt("            CHỨC NĂNG CỦA CHƯƠNG TRÌNH               ", 25, 14);
            Console.ForegroundColor = ConsoleColor.Green;
            pt.pnt("F1", 21, 17);
            pt.pnt("F2", 21, 19);
            pt.pnt("F3", 21, 21);
            pt.pnt("F4", 21, 23);
            pt.pnt("F5", 21, 25);
            pt.pnt("F6", 21, 27);
            pt.pnt("F7", 21, 29);
            pt.pnt("F8", 21, 31);
            pt.pnt("F9", 21, 33);
            pt.pnt("F10", 21, 35);
            Console.ForegroundColor = ConsoleColor.White;
            pt.pnt("Quản lý Học Sinh", 32, 17);
            pt.pnt("Quản lý Lớp Học ", 32, 19);
            pt.pnt("Quản lý Giáo Viên", 32, 21);
            pt.pnt("Quản lý Bảng Điểm ", 32, 23);
            pt.pnt("Quản lý Môn Học", 32, 25);
            pt.pnt("Tìm kiếm", 32, 27);
            pt.pnt("Thống kê", 32, 29);
            pt.pnt("Thông tin phần mềm", 32, 31);
            pt.pnt("Tài liệu tham khảo", 32, 33);
            pt.pnt("Hướng dẫn sử dụng phần mềm", 32, 35);

            pt.pnt("Mời bạn chọn chức năng : ", 60, 40);
            Console.ForegroundColor = ConsoleColor.Yellow;
            pt.pnt("Hoặc  ↓↑", 60, 41);
            Console.ForegroundColor = ConsoleColor.White;
            pt.pnt("Nhấn", 60,42);
            Console.ForegroundColor = ConsoleColor.Green;
            pt.pnt(" H ", 65, 42);
            Console.ForegroundColor = ConsoleColor.White;
            pt.pnt("để mở cửa sổ trợ giúp", 69, 42);

            pt.pnt("Nhấn ", 60,43);
            Console.ForegroundColor = ConsoleColor.Green;
            pt.pnt("Tab", 65, 43);
            Console.ForegroundColor = ConsoleColor.White;
            pt.pnt("để quay lại", 69, 43);

            pt.pnt("Nhấn", 60, 44);
            Console.ForegroundColor = ConsoleColor.Green;
            pt.pnt("Esc", 65, 44);
            Console.ForegroundColor = ConsoleColor.White;
            pt.pnt("để thoát khỏi chương trình", 69, 44);
            pt.pnt("", 85, 40);
    label1: ConsoleKeyInfo kt = Console.ReadKey();
            Console.ForegroundColor = ConsoleColor.White;
            switch (kt.Key)
            {
                case ConsoleKey.F1:
                    Console.Clear();
                    fhs.themhs();
                    break;
                case ConsoleKey.F2:
                    Console.Clear();
                    fl.Themlop();
                    break;
                case ConsoleKey.F3:
                    Console.Clear();
                    fgv.themgv();
                    break;
                case ConsoleKey.F4:
                    Console.Clear();
                    fbd.themdiem();
                    break;
                case ConsoleKey.F5:
                    Console.Clear();
                    mh.themmh();
                    break;
                case ConsoleKey.F6:
                    Console.Clear();
                    ftk.chucnangtk();
                    break;
                case ConsoleKey.F7:
                    Console.Clear();
                    fthk.chucnangthk();
                    break;
                case ConsoleKey.F8:
                    Console.Clear();
                    tt.thongtinpm();
                    break;
                case ConsoleKey.F9:
                    Console.Clear();
                    tt.tailieutk();
                    break;
                case ConsoleKey.F10:
                    Console.Clear();
                    tt.huongdansd();
                    break;
                case ConsoleKey.H:
                    Console.Clear();
                    tt.trungtamtrogiup();
                    break;
                case ConsoleKey.Tab:
                    Console.Clear();
                    dn.dangnhap();
                    break;
                case ConsoleKey.Escape:
                    Environment.Exit(0);
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    pt.pnt("       ", 85, 40);
                    pt.pnt("Bạn nhập sai xin mời nhập lại", 60, 45);
                    pt.pnt("", 85, 40);
                    goto label1;
            }
        }
        #endregion
    }
    #endregion
}
