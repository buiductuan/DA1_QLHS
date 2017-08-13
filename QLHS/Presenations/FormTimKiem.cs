using System;
using System.Linq;
using System.Text;
using QLHS.Utility;
using QLHS.Presenations;
using QLHS.Entities;
using QLHS.Business.Components;
using QLHS.DataAccessLayer;
namespace QLHS.Presenations
{
    public class FormTimKiem
    {
        #region Giao diện và chức năng tìm kiếm
        Paint pt = new Paint(140, 55);
        HocSinhBLL hsbll = new HocSinhBLL();
        GVCNBLL gvbll = new GVCNBLL();
        BangDiemBLL bdbll = new BangDiemBLL();
        BangDiemDAL bdda = new BangDiemDAL();
        HocSinhDAL hsda = new HocSinhDAL();
        GVCNDAL gvda = new GVCNDAL();
        public static MenuChinh mn = new MenuChinh();
        #region Chức năng tìm kiếm
        public void chucnangtk()
        {
            pt.pnt("┏", 4, 8);
            pt.pnt("┗", 4, 33);
            pt.pnt("┓", 95, 8);
            pt.pnt("┛", 95, 33);

            pt.pnt("━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━", 5, 8);
            pt.pnt("━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━", 5, 33);
            pt.pnt("                                TRƯỜNG ĐẠI HỌC SƯ PHẠM KỸ THUẬT HƯNG YÊN ", 0, 4);
            pt.pnt("                                      KHOA CÔNG NGHỆ THÔNG TIN ", 1, 5);
            pt.pnt("                                     ------- ○○○○ -------", 3, 6);
            for (int i = 9; i < 33; ++i)
            {
                pt.pnt("┃", 4, i);
                pt.pnt("┃", 95, i);
            }
            Console.ForegroundColor = ConsoleColor.Red;
            #region Chữ ký
            Console.ForegroundColor = ConsoleColor.Red;
            pt.pnt("D", 5, 32);
            Console.ForegroundColor = ConsoleColor.White;
            pt.pnt("e", 6, 32);
            Console.ForegroundColor = ConsoleColor.Cyan;
            pt.pnt("s", 7, 32);
            Console.ForegroundColor = ConsoleColor.Green;
            pt.pnt("i", 8, 32);
            Console.ForegroundColor = ConsoleColor.Yellow;
            pt.pnt("g", 9, 32);
            Console.ForegroundColor = ConsoleColor.Gray;
            pt.pnt("n", 10, 32);
            Console.ForegroundColor = ConsoleColor.Magenta;
            pt.pnt("e", 11, 32);
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            pt.pnt("d", 12, 32);
            Console.ForegroundColor = ConsoleColor.DarkRed;
            pt.pnt("b", 14, 32);
            Console.ForegroundColor = ConsoleColor.Yellow;
            pt.pnt("y", 15, 32);
            Console.ForegroundColor = ConsoleColor.Red;
            pt.pnt("T", 17, 32);
            Console.ForegroundColor = ConsoleColor.Yellow;
            pt.pnt("e", 18, 32);
            Console.ForegroundColor = ConsoleColor.Green;
            pt.pnt("a", 19, 32);
            Console.ForegroundColor = ConsoleColor.Red;
            pt.pnt("m", 20, 32);
            Console.ForegroundColor = ConsoleColor.Magenta;
            pt.pnt("T", 22, 32);
            Console.ForegroundColor = ConsoleColor.Yellow;
            pt.pnt("™", 23, 32);
            Console.ForegroundColor = ConsoleColor.White;
            #endregion
            Console.ForegroundColor = ConsoleColor.Green;
            pt.pnt(" CHƯƠNG TRÌNH QUẢN LÝ HỌC SINH", 34, 9);
            Console.ForegroundColor = ConsoleColor.White;
            pt.pnt("┏", 19, 14);
            pt.pnt("┓", 79, 14);
            pt.pnt("━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━", 20, 14);
            pt.pnt("┛", 79, 24);
            pt.pnt("┗", 19, 24);
            for (int i = 15; i < 24; ++i)
            {
                pt.pnt("┃", 19, i);
                pt.pnt("┃", 79, i);
            }
            pt.pnt("┠", 19, 18);
            pt.pnt("┠", 19, 20);
            pt.pnt("┠", 19, 22);

            pt.pnt("┨", 79, 18);
            pt.pnt("┨", 79, 20);
            pt.pnt("┨", 79, 22);

            pt.pnt("━━━━━┳━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━", 20, 18);
            pt.pnt("━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━", 20, 20);
            pt.pnt("━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━", 20, 22);
            pt.pnt("━━━━━┻━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━", 20, 24);



            for (int i = 19; i < 24; ++i)
            {
                pt.pnt("┃", 25, i);
            }

            Console.ForegroundColor = ConsoleColor.Yellow;
            pt.pnt("                CHỨC NĂNG TÌM KIẾM               ", 25, 16);
            Console.ForegroundColor = ConsoleColor.Magenta;
            pt.pnt("F1", 22, 19);
            pt.pnt("F2", 22, 21);
            pt.pnt("F3", 22, 23);
            Console.ForegroundColor = ConsoleColor.White;
            pt.pnt("Tìm kiếm học sinh", 32, 19);
            pt.pnt("Tìm kiếm giáo viên chủ nhiệm ", 32, 21);
            pt.pnt("Tìm kiếm bảng điểm học sinh", 32, 23);
            Console.ForegroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Yellow;
            pt.pnt("Hoặc ↓↑", 60, 29);
            Console.ForegroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.White;
            pt.pnt("Nhấn", 60, 30);
            Console.ForegroundColor = ConsoleColor.Green;
            pt.pnt("Tab", 65, 30);
            Console.ForegroundColor = ConsoleColor.White;
            pt.pnt("để quay lại", 69, 30);
            pt.pnt("Nhấn", 60, 31);
            Console.ForegroundColor = ConsoleColor.Green;
            pt.pnt("Esc", 65, 31);
            Console.ForegroundColor = ConsoleColor.White;
            pt.pnt("để thoát khỏi chương trình", 69, 31);
            pt.pnt("Mời bạn chọn chức năng : ", 60, 28);
        den1: ConsoleKeyInfo kt = Console.ReadKey();
            Console.ForegroundColor = ConsoleColor.White;
            switch (kt.Key)

            {
                case ConsoleKey.F1:
                    Console.Clear();
                    chucnangtimhs();
                    break;
                case ConsoleKey.F2:
                    Console.Clear();
                    chucnangtimgv();
                    break;
                case ConsoleKey.F3:
                    Console.Clear();
                    timdiem();
                    break;
                case ConsoleKey.Tab:
                    Console.Clear();
                    mn.MenuChinh1();
                    break;
                case ConsoleKey.Escape:
                    Environment.Exit(0);
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    pt.pnt("      ", 85, 28);
                    pt.pnt("Bạn nhập sai xin nhập lại", 60, 32);
                    pt.pnt("", 85, 28);
                    goto den1;
            }
        }
        #endregion
        #region Chức năng tìm kiếm học sinh
        public void chucnangtimhs()
        {
            pt.pnt("┏", 4, 8);
            pt.pnt("┗", 4, 33);
            pt.pnt("┓", 95, 8);
            pt.pnt("┛", 95, 33);

            pt.pnt("━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━", 5, 8);
            pt.pnt("━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━", 5, 33);
            pt.pnt("                                TRƯỜNG ĐẠI HỌC SƯ PHẠM KỸ THUẬT HƯNG YÊN ", 0, 4);
            pt.pnt("                                      KHOA CÔNG NGHỆ THÔNG TIN ", 1, 5);
            pt.pnt("                                     ------- ○○○○ -------", 3, 6);
            for (int i = 9; i < 33; ++i)
            {
                pt.pnt("┃", 4, i);
                pt.pnt("┃", 95, i);
            }
            Console.ForegroundColor = ConsoleColor.Red;
            #region Chữ ký
            Console.ForegroundColor = ConsoleColor.Red;
            pt.pnt("D", 5, 32);
            Console.ForegroundColor = ConsoleColor.White;
            pt.pnt("e", 6, 32);
            Console.ForegroundColor = ConsoleColor.Cyan;
            pt.pnt("s", 7, 32);
            Console.ForegroundColor = ConsoleColor.Green;
            pt.pnt("i", 8, 32);
            Console.ForegroundColor = ConsoleColor.Yellow;
            pt.pnt("g", 9, 32);
            Console.ForegroundColor = ConsoleColor.Gray;
            pt.pnt("n", 10, 32);
            Console.ForegroundColor = ConsoleColor.Magenta;
            pt.pnt("e", 11, 32);
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            pt.pnt("d", 12, 32);
            Console.ForegroundColor = ConsoleColor.DarkRed;
            pt.pnt("b", 14, 32);
            Console.ForegroundColor = ConsoleColor.Yellow;
            pt.pnt("y", 15, 32);
            Console.ForegroundColor = ConsoleColor.Red;
            pt.pnt("T", 17, 32);
            Console.ForegroundColor = ConsoleColor.Yellow;
            pt.pnt("e", 18, 32);
            Console.ForegroundColor = ConsoleColor.Green;
            pt.pnt("a", 19, 32);
            Console.ForegroundColor = ConsoleColor.Red;
            pt.pnt("m", 20, 32);
            Console.ForegroundColor = ConsoleColor.Magenta;
            pt.pnt("T", 22, 32);
            Console.ForegroundColor = ConsoleColor.Yellow;
            pt.pnt("™", 23, 32);
            Console.ForegroundColor = ConsoleColor.White;
            #endregion
            Console.ForegroundColor = ConsoleColor.Green;
            pt.pnt(" CHƯƠNG TRÌNH QUẢN LÝ HỌC SINH", 34, 9);
            Console.ForegroundColor = ConsoleColor.White;
            pt.pnt("┏", 19, 14);
            pt.pnt("┓", 79, 14);
            pt.pnt("━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━", 20, 14);
            pt.pnt("┛", 79, 24);
            pt.pnt("┗", 19, 24);
            for (int i = 15; i < 24; ++i)
            {
                pt.pnt("┃", 19, i);
                pt.pnt("┃", 79, i);
            }
            pt.pnt("┠", 19, 18);
            pt.pnt("┠", 19, 20);
            pt.pnt("┠", 19, 22);

            pt.pnt("┨", 79, 18);
            pt.pnt("┨", 79, 20);
            pt.pnt("┨", 79, 22);

            pt.pnt("━━━━━┳━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━", 20, 18);
            pt.pnt("━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━", 20, 20);
            pt.pnt("━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━", 20, 22);
            pt.pnt("━━━━━┻━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━", 20, 24);



            for (int i = 19; i < 24; ++i)
            {
                pt.pnt("┃", 25, i);
            }

            pt.pnt("                 TÌM KIẾM HỌC SINH              ", 25, 16);
            pt.pnt("F1", 22, 19);
            pt.pnt("F2", 22, 21);
            pt.pnt("F3", 22, 23);
            pt.pnt("Tìm kiếm học sinh theo mã học sinh", 32, 19);
            pt.pnt("Tìm kiếm học sinh theo tên ", 32, 21);
            pt.pnt("Tìm kiếm học sinh theo mã lớp", 32, 23);
            pt.pnt("Nhấn Tab để quay lại ", 60, 29);
            pt.pnt("Thoát khỏi chương trình nhấn Esc", 60, 30);
            pt.pnt("Mời bạn chọn chức năng : ", 60, 31);
        den1: ConsoleKeyInfo kt = Console.ReadKey();
            Console.ForegroundColor = ConsoleColor.White;
            switch (kt.Key)

            {
                case ConsoleKey.F1:
                    Console.Clear();
                    timmahs();
                    break;
                case ConsoleKey.F2:
                    Console.Clear();
                    timtenhs();
                    break;
                case ConsoleKey.F3:
                    Console.Clear();
                    timhsml();
                    break;
                case ConsoleKey.Tab:
                    Console.Clear();
                    chucnangtk();
                    break;
                case ConsoleKey.Escape:
                    Environment.Exit(0);
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    pt.pnt("Bạn nhập sai xin nhập lại : ", 60, 32);
                    goto den1;
            }
        }
        #endregion
        #region Tìm theo mã học sinh
        public void timmahs()
        {
            Paint pt = new Paint(140, 55);
            // Vẽ trang 
            pt.pnt1("┏", 4, 8);
            pt.pnt1("┗", 4, 52);
            pt.pnt1("┓", 133, 8);
            pt.pnt1("┛", 133, 52);

            pt.pnt1("━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━", 5, 8);
            pt.pnt1("━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━", 5, 52);
            pt.pnt1("                                              TRƯỜNG ĐẠI HỌC SƯ PHẠM KỸ THUẬT HƯNG YÊN ", 0, 1);
            pt.pnt1("                                                      KHOA CÔNG NGHỆ THÔNG TIN ", 1, 2);
            pt.pnt1("                                                     ------- ○○○○ -------", 3, 3);
            for (int i = 9; i < 52; ++i)
            {
                pt.pnt1("┃", 4, i);
                pt.pnt1("┃", 133, i);
            }
            pt.pnt1("━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━", 5, 17);
            pt.pnt1(" Tìm học sinh ", 56, 8);
            pt.pnt1("━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━", 6, 19);
            for (int i = 19; i < 42; i++)
            {
                pt.pnt1("┃", 5, i);
                pt.pnt1("┃", 132, i);
            }

            pt.pnt1("┏", 5, 19);
            pt.pnt1("┗", 5, 42);
            pt.pnt1("┓", 132, 19);
            pt.pnt1("┛", 132, 42);

            pt.pnt1("┠", 4, 17);
            pt.pnt1("┨", 133, 17);
            pt.pnt1("┠", 5, 22);
            pt.pnt1("┠", 5, 24);
            pt.pnt1("┨", 132, 22);
            pt.pnt1("┨", 132, 24);

            Console.ForegroundColor = ConsoleColor.Magenta;
            #region Chữ ký
            Console.ForegroundColor = ConsoleColor.Red;
            pt.pnt("D", 5, 51);
            Console.ForegroundColor = ConsoleColor.White;
            pt.pnt("e", 6, 51);
            Console.ForegroundColor = ConsoleColor.Cyan;
            pt.pnt("s", 7, 51);
            Console.ForegroundColor = ConsoleColor.Green;
            pt.pnt("i", 8, 51);
            Console.ForegroundColor = ConsoleColor.Yellow;
            pt.pnt("g", 9, 51);
            Console.ForegroundColor = ConsoleColor.Gray;
            pt.pnt("n", 10, 51);
            Console.ForegroundColor = ConsoleColor.Magenta;
            pt.pnt("e", 11, 51);
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            pt.pnt("d", 12, 51);
            Console.ForegroundColor = ConsoleColor.DarkRed;
            pt.pnt("b", 14, 51);
            Console.ForegroundColor = ConsoleColor.Yellow;
            pt.pnt("y", 15, 51);
            Console.ForegroundColor = ConsoleColor.Red;
            pt.pnt("T", 17, 51);
            Console.ForegroundColor = ConsoleColor.Yellow;
            pt.pnt("e", 18, 51);
            Console.ForegroundColor = ConsoleColor.Green;
            pt.pnt("a", 19, 51);
            Console.ForegroundColor = ConsoleColor.Red;
            pt.pnt("m", 20, 51);
            Console.ForegroundColor = ConsoleColor.Magenta;
            pt.pnt("T", 22, 51);
            Console.ForegroundColor = ConsoleColor.Yellow;
            pt.pnt("™", 23, 51);
            Console.ForegroundColor = ConsoleColor.White;
            #endregion
            Console.ForegroundColor = ConsoleColor.White;
            pt.pnt1("━━━━━━━━━━┳━━━━━━━━━━━━━━━━━━━━┳━━━━━━━━━━━━━━┳━━━━━━━┳━━━━━━━━━━━━━━━━━━━━━━┳━━━━━━━━━━━━━━━━┳━━━━━━━━━━━━━━━┳━━━━━━━━━━━━━━━", 6, 22);
            pt.pnt1("━━━━━━━━━━┻━━━━━━━━━━━━━━━━━━━━┻━━━━━━━━━━━━━━┻━━━━━━━┻━━━━━━━━━━━━━━━━━━━━━━┻━━━━━━━━━━━━━━━━┻━━━━━━━━━━━━━━━┻━━━━━━━━━━━━━━━", 6, 24);

            pt.pnt1("━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━", 6, 42);


            for (int i = 23; i < 24; i++)
            {
                pt.pnt1("┃", 16, i);
                pt.pnt1("┃", 37, i);
                pt.pnt1("┃", 52, i);
                pt.pnt1("┃", 60, i);
                pt.pnt1("┃", 83, i);
                pt.pnt1("┃", 100, i);
                pt.pnt1("┃", 116, i);
            }

            pt.pnt1("DANH SÁCH HỌC SINH ", 61, 20);
            pt.pnt1(" Mã HS ", 8, 23);
            pt.pnt1(" Tên HS", 22, 23);
            pt.pnt1(" Ngày sinh", 40, 23);
            pt.pnt1(" GT", 54, 23);
            pt.pnt1(" Địa chỉ", 67, 23);
            pt.pnt1(" SĐT(bố/mẹ)", 87, 23);
            pt.pnt1(" Năm học", 104, 23);
            pt.pnt1(" Mã lớp", 120, 23);
            Console.ForegroundColor = ConsoleColor.Yellow;
            pt.pnt1("Nhập mã học sinh cần tìm: ", 47, 13);
            Console.ForegroundColor = ConsoleColor.White;
        label: pt.pnt1("", 72, 13);
            string mahs = Console.ReadLine();
            if (mahs == "")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                pt.pnt1("Mã không được rỗng ! Nhấn phím bất kỳ nhập lại ", 60, 46);
                pt.pnt1("Nhấn Tab để quay lại ", 60, 47);
                Console.ForegroundColor = ConsoleColor.White;
                ConsoleKeyInfo kt = Console.ReadKey();
                switch (kt.Key)
                {
                    case ConsoleKey.Tab:
                        Console.Clear();
                        chucnangtimhs();
                        break;
                    default:
                        pt.pnt1("                                                  ", 60, 46);
                        pt.pnt1("                               ", 60, 47);
                        goto label;
                }
            }
            HocSinh hs = new HocSinh();
            hs.Mahs = mahs;
            if (hsbll.KTmahs(mahs) == false)
            {
                List<HocSinh> list = hsbll.Timhs(hs);
                for(int i = 0; i < list.Count; ++i)
                {
                    pt.pnt1(list[i].Mahs, 9, 25);
                    pt.pnt1(list[i].Tenhs, 19, 25);
                    pt.pnt1(list[i].Ngaysinh, 40, 25);
                    pt.pnt1(list[i].Gioitinh, 55, 25);
                    pt.pnt1(list[i].Diachi, 67, 25);
                    pt.pnt1(list[i].Sdtbome, 88, 25);
                    pt.pnt1(list[i].Namhoc, 104, 25);
                    pt.pnt1(list[i].Malop, 122, 25);
                }
                pt.pnt1("Nhấn Enter để tìm kiểm tiếp ", 60, 45);
                pt.pnt1("Nhấn S để lưu ra file và tìm tiếp", 60, 46);
                pt.pnt1("Nhấn Tab để quay lại ", 60, 47);
                pt.pnt1("Nhấn ESC để thoát", 60, 48);
            label1:
                ConsoleKeyInfo kt = Console.ReadKey();
                switch (kt.Key)
                {
                    case ConsoleKey.Enter:
                        pt.pnt1("        ", 72, 13);
                        pt.pnt1("                              ", 60, 45);
                        pt.pnt1("                                      ", 60, 46);
                        pt.pnt1("                         ", 60, 47);
                        pt.pnt1("                       ", 60, 48);

                        pt.pnt1("        ", 9, 25);
                        pt.pnt1("                  ", 19, 25);
                        pt.pnt1("                  ", 40, 25);
                        pt.pnt1("                ", 55, 25);
                        pt.pnt1("                ", 67, 25);
                        pt.pnt1("                 ", 88, 25);
                        pt.pnt1("              ", 104, 25);
                        pt.pnt1("        ", 122, 25);
                        goto label;
                    case ConsoleKey.S:
                        hsda.SearchHS(list);
                        pt.pnt1("        ", 72, 13);
                        pt.pnt1("                              ", 60, 45);
                        pt.pnt1("                                      ", 60, 46);
                        pt.pnt1("                         ", 60, 47);
                        pt.pnt1("                       ", 60, 48);

                        pt.pnt1("        ", 9, 25);
                        pt.pnt1("                  ", 19, 25);
                        pt.pnt1("                  ", 40, 25);
                        pt.pnt1("                ", 55, 25);
                        pt.pnt1("                ", 67, 25);
                        pt.pnt1("                 ", 88, 25);
                        pt.pnt1("              ", 104, 25);
                        pt.pnt1("        ", 122, 25);
                        goto label;
                    case ConsoleKey.Tab:
                        Console.Clear();
                        chucnangtimhs();
                        break;
                    case ConsoleKey.Escape:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        pt.pnt1("Bạn nhập sai ! Nhập lại ", 60, 49);
                        Console.ForegroundColor = ConsoleColor.White;
                        goto label1;
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                pt.pnt1("Mã học sinh không tồn tại ! Nhập lại ", 60, 46);
                pt.pnt1("Nhấn Tab để quay lại ", 60, 47);
                Console.ForegroundColor = ConsoleColor.White;
                ConsoleKeyInfo ktt = Console.ReadKey();
                switch (ktt.Key)
                {
                    case ConsoleKey.Tab:
                        Console.Clear();
                        chucnangtimhs();
                        break;
                    default:
                        pt.pnt1("                                        ", 60, 46);
                        pt.pnt1("                                   ", 60, 47);
                        pt.pnt1("                   ", 72, 13);
                        goto label;
                }
            }
        }
        #endregion
        #region Tìm theo tên học sinh
        public void timtenhs()
        {
            Paint pt = new Paint(140, 55);
            // Vẽ trang 
            pt.pnt1("┏", 4, 8);
            pt.pnt1("┗", 4, 52);
            pt.pnt1("┓", 133, 8);
            pt.pnt1("┛", 133, 52);

            pt.pnt1("━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━", 5, 8);
            pt.pnt1("━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━", 5, 52);
            pt.pnt1("                                              TRƯỜNG ĐẠI HỌC SƯ PHẠM KỸ THUẬT HƯNG YÊN ", 0, 1);
            pt.pnt1("                                                      KHOA CÔNG NGHỆ THÔNG TIN ", 1, 2);
            pt.pnt1("                                                     ------- ○○○○ -------", 3, 3);
            for (int i = 9; i < 52; ++i)
            {
                pt.pnt1("┃", 4, i);
                pt.pnt1("┃", 133, i);
            }
            pt.pnt1("━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━", 5, 17);
            pt.pnt1(" Tìm học sinh ", 56, 8);
            pt.pnt1("━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━", 6, 19);
            for (int i = 19; i < 42; i++)
            {
                pt.pnt1("┃", 5, i);
                pt.pnt1("┃", 132, i);
            }

            pt.pnt1("┏", 5, 19);
            pt.pnt1("┗", 5, 42);
            pt.pnt1("┓", 132, 19);
            pt.pnt1("┛", 132, 42);

            pt.pnt1("┠", 4, 17);
            pt.pnt1("┨", 133, 17);
            pt.pnt1("┠", 5, 22);
            pt.pnt1("┠", 5, 24);
            pt.pnt1("┨", 132, 22);
            pt.pnt1("┨", 132, 24);

            Console.ForegroundColor = ConsoleColor.Magenta;
            #region Chữ ký
            Console.ForegroundColor = ConsoleColor.Red;
            pt.pnt("D", 5, 51);
            Console.ForegroundColor = ConsoleColor.White;
            pt.pnt("e", 6, 51);
            Console.ForegroundColor = ConsoleColor.Cyan;
            pt.pnt("s", 7, 51);
            Console.ForegroundColor = ConsoleColor.Green;
            pt.pnt("i", 8, 51);
            Console.ForegroundColor = ConsoleColor.Yellow;
            pt.pnt("g", 9, 51);
            Console.ForegroundColor = ConsoleColor.Gray;
            pt.pnt("n", 10, 51);
            Console.ForegroundColor = ConsoleColor.Magenta;
            pt.pnt("e", 11, 51);
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            pt.pnt("d", 12, 51);
            Console.ForegroundColor = ConsoleColor.DarkRed;
            pt.pnt("b", 14, 51);
            Console.ForegroundColor = ConsoleColor.Yellow;
            pt.pnt("y", 15, 51);
            Console.ForegroundColor = ConsoleColor.Red;
            pt.pnt("T", 17, 51);
            Console.ForegroundColor = ConsoleColor.Yellow;
            pt.pnt("e", 18, 51);
            Console.ForegroundColor = ConsoleColor.Green;
            pt.pnt("a", 19, 51);
            Console.ForegroundColor = ConsoleColor.Red;
            pt.pnt("m", 20, 51);
            Console.ForegroundColor = ConsoleColor.Magenta;
            pt.pnt("T", 22, 51);
            Console.ForegroundColor = ConsoleColor.Yellow;
            pt.pnt("™", 23, 51);
            Console.ForegroundColor = ConsoleColor.White;
            #endregion
            Console.ForegroundColor = ConsoleColor.White;
            pt.pnt1("━━━━━━━━━━┳━━━━━━━━━━━━━━━━━━━━┳━━━━━━━━━━━━━━┳━━━━━━━┳━━━━━━━━━━━━━━━━━━━━━━┳━━━━━━━━━━━━━━━━┳━━━━━━━━━━━━━━━┳━━━━━━━━━━━━━━━", 6, 22);
            pt.pnt1("━━━━━━━━━━┻━━━━━━━━━━━━━━━━━━━━┻━━━━━━━━━━━━━━┻━━━━━━━┻━━━━━━━━━━━━━━━━━━━━━━┻━━━━━━━━━━━━━━━━┻━━━━━━━━━━━━━━━┻━━━━━━━━━━━━━━━", 6, 24);

            pt.pnt1("━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━", 6, 42);


            for (int i = 23; i < 24; i++)
            {
                pt.pnt1("┃", 16, i);
                pt.pnt1("┃", 37, i);
                pt.pnt1("┃", 52, i);
                pt.pnt1("┃", 60, i);
                pt.pnt1("┃", 83, i);
                pt.pnt1("┃", 100, i);
                pt.pnt1("┃", 116, i);
            }

            pt.pnt1("DANH SÁCH HỌC SINH ", 61, 20);
            pt.pnt1(" Mã HS ", 8, 23);
            pt.pnt1(" Tên HS", 22, 23);
            pt.pnt1(" Ngày sinh", 40, 23);
            pt.pnt1(" GT", 54, 23);
            pt.pnt1(" Địa chỉ", 67, 23);
            pt.pnt1(" SĐT(bố/mẹ)", 87, 23);
            pt.pnt1(" Năm học", 104, 23);
            pt.pnt1(" Mã lớp", 120, 23);
            Console.ForegroundColor = ConsoleColor.Yellow;
            pt.pnt1("Nhập đầy đủ tên học sinh cần tìm: ", 40, 13);
            Console.ForegroundColor = ConsoleColor.White;
        label: pt.pnt1("", 73, 13);
            string tenhs = Console.ReadLine();
            if (tenhs == "")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                pt.pnt1("Tên không được rỗng ! Nhấn phím bất kỳ nhập lại ", 60, 46);
                pt.pnt1("Nhấn Tab để quay lại  ", 60, 47);
                Console.ForegroundColor = ConsoleColor.White;
                ConsoleKeyInfo kt = Console.ReadKey();
                switch (kt.Key)
                {
                    case ConsoleKey.Tab:
                        Console.Clear();
                        chucnangtimhs();
                        break;
                    default:
                        pt.pnt1("                                                  ", 60, 46);
                        pt.pnt1("                                                  ", 60, 47);
                        goto label;
                }
            }
            HocSinh hs = new HocSinh();
            hs.Tenhs = QLHS.Utility.CongCu.ChuanHoaXau(tenhs);
            if (hsbll.KTtentk(tenhs) == false)
            {
                List<HocSinh> list = hsbll.Timhs(hs);
                for (int i = 0; i < list.Count; ++i)
                {
                    pt.pnt1(list[i].Mahs, 9, 25);
                    pt.pnt1(list[i].Tenhs, 19, 25);
                    pt.pnt1(list[i].Ngaysinh, 40, 25);
                    pt.pnt1(list[i].Gioitinh, 55, 25);
                    pt.pnt1(list[i].Diachi, 67, 25);
                    pt.pnt1(list[i].Sdtbome, 88, 25);
                    pt.pnt1(list[i].Namhoc, 104, 25);
                    pt.pnt1(list[i].Malop, 122, 25);
                }
                pt.pnt1("Nhấn Enter để tìm kiểm tiếp ", 60, 45);
                pt.pnt1("Nhấn S để lưu ra file và tìm tiếp", 60, 46);
                pt.pnt1("Nhấn Tab để quay lại ", 60, 47);
                pt.pnt1("Nhấn ESC để thoát", 60, 48);
            label1:
                ConsoleKeyInfo kt = Console.ReadKey();
                switch (kt.Key)
                {
                    case ConsoleKey.Enter:
                        pt.pnt1("                   ", 73, 13);
                        pt.pnt1("                              ", 60, 45);
                        pt.pnt1("                                     ", 60, 46);
                        pt.pnt1("                       ", 60, 47);
                        pt.pnt1("                   ", 60, 48);

                        pt.pnt1("        ", 9, 25);
                        pt.pnt1("                  ", 19, 25);
                        pt.pnt1("                  ", 40, 25);
                        pt.pnt1("                ", 55, 25);
                        pt.pnt1("                ", 67, 25);
                        pt.pnt1("                 ", 88, 25);
                        pt.pnt1("              ", 104, 25);
                        pt.pnt1("        ", 122, 25);
                        goto label;
                    case ConsoleKey.S:
                        hsda.SearchHS(list);
                        pt.pnt1("                   ", 73, 13);
                        pt.pnt1("                              ", 60, 45);
                        pt.pnt1("                                     ", 60, 46);
                        pt.pnt1("                        ", 60, 47);
                        pt.pnt1("                   ", 60, 48);

                        pt.pnt1("        ", 9, 25);
                        pt.pnt1("                  ", 19, 25);
                        pt.pnt1("                  ", 40, 25);
                        pt.pnt1("                ", 55, 25);
                        pt.pnt1("                ", 67, 25);
                        pt.pnt1("                 ", 88, 25);
                        pt.pnt1("              ", 104, 25);
                        pt.pnt1("        ", 122, 25);
                        goto label;
                    case ConsoleKey.Tab:
                        Console.Clear();
                        chucnangtimhs();
                        break;
                    case ConsoleKey.Escape:
                        return;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        pt.pnt1("Bạn nhập sai ! Nhập lại ", 60, 49);
                        Console.ForegroundColor = ConsoleColor.White;
                        goto label1;
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                pt.pnt1("Tên học sinh không tồn tại ! Nhập lại ", 60, 46);
                pt.pnt1("Nhấn Tab để quay lại ", 60, 47);
                Console.ForegroundColor = ConsoleColor.White;
                ConsoleKeyInfo ktt = Console.ReadKey();
                switch (ktt.Key)
                {
                    case ConsoleKey.Tab:
                        Console.Clear();
                        chucnangtimhs();
                        break;
                    default:
                        pt.pnt1("                                        ", 60, 46);
                        pt.pnt1("                                   ", 60, 47);
                        pt.pnt1("                   ", 73, 13);
                        goto label;
                }
            }
        }
        #endregion
        #region Tìm học sinh theo mã lớp
        public void timhsml()
        {
            Paint pt = new Paint(140, 55);
            // Vẽ trang 
            pt.pnt1("┏", 4, 8);
            pt.pnt1("┗", 4, 52);
            pt.pnt1("┓", 133, 8);
            pt.pnt1("┛", 133, 52);

            pt.pnt1("━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━", 5, 8);
            pt.pnt1("━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━", 5, 52);
            pt.pnt1("                                              TRƯỜNG ĐẠI HỌC SƯ PHẠM KỸ THUẬT HƯNG YÊN ", 0, 1);
            pt.pnt1("                                                      KHOA CÔNG NGHỆ THÔNG TIN ", 1, 2);
            pt.pnt1("                                                     ------- ○○○○ -------", 3, 3);
            for (int i = 9; i < 52; ++i)
            {
                pt.pnt1("┃", 4, i);
                pt.pnt1("┃", 133, i);
            }
            pt.pnt1("━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━", 5, 17);
            pt.pnt1(" Tìm học sinh ", 56, 8);
            pt.pnt1("━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━", 6, 19);
            for (int i = 19; i < 42; i++)
            {
                pt.pnt1("┃", 5, i);
                pt.pnt1("┃", 132, i);
            }

            pt.pnt1("┏", 5, 19);
            pt.pnt1("┗", 5, 42);
            pt.pnt1("┓", 132, 19);
            pt.pnt1("┛", 132, 42);

            pt.pnt1("┠", 4, 17);
            pt.pnt1("┨", 133, 17);
            pt.pnt1("┠", 5, 22);
            pt.pnt1("┠", 5, 24);
            pt.pnt1("┨", 132, 22);
            pt.pnt1("┨", 132, 24);

            Console.ForegroundColor = ConsoleColor.Magenta;
            #region Chữ ký
            Console.ForegroundColor = ConsoleColor.Red;
            pt.pnt("D", 5, 51);
            Console.ForegroundColor = ConsoleColor.White;
            pt.pnt("e", 6, 51);
            Console.ForegroundColor = ConsoleColor.Cyan;
            pt.pnt("s", 7, 51);
            Console.ForegroundColor = ConsoleColor.Green;
            pt.pnt("i", 8, 51);
            Console.ForegroundColor = ConsoleColor.Yellow;
            pt.pnt("g", 9, 51);
            Console.ForegroundColor = ConsoleColor.Gray;
            pt.pnt("n", 10, 51);
            Console.ForegroundColor = ConsoleColor.Magenta;
            pt.pnt("e", 11, 51);
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            pt.pnt("d", 12, 51);
            Console.ForegroundColor = ConsoleColor.DarkRed;
            pt.pnt("b", 14, 51);
            Console.ForegroundColor = ConsoleColor.Yellow;
            pt.pnt("y", 15, 51);
            Console.ForegroundColor = ConsoleColor.Red;
            pt.pnt("T", 17, 51);
            Console.ForegroundColor = ConsoleColor.Yellow;
            pt.pnt("e", 18, 51);
            Console.ForegroundColor = ConsoleColor.Green;
            pt.pnt("a", 19, 51);
            Console.ForegroundColor = ConsoleColor.Red;
            pt.pnt("m", 20, 51);
            Console.ForegroundColor = ConsoleColor.Magenta;
            pt.pnt("T", 22, 51);
            Console.ForegroundColor = ConsoleColor.Yellow;
            pt.pnt("™", 23, 51);
            Console.ForegroundColor = ConsoleColor.White;
            #endregion
            Console.ForegroundColor = ConsoleColor.White;
            pt.pnt1("━━━━━━━━━━┳━━━━━━━━━━━━━━━━━━━━┳━━━━━━━━━━━━━━┳━━━━━━━┳━━━━━━━━━━━━━━━━━━━━━━┳━━━━━━━━━━━━━━━━┳━━━━━━━━━━━━━━━┳━━━━━━━━━━━━━━━", 6, 22);
            pt.pnt1("━━━━━━━━━━┻━━━━━━━━━━━━━━━━━━━━┻━━━━━━━━━━━━━━┻━━━━━━━┻━━━━━━━━━━━━━━━━━━━━━━┻━━━━━━━━━━━━━━━━┻━━━━━━━━━━━━━━━┻━━━━━━━━━━━━━━━", 6, 24);

            pt.pnt1("━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━", 6, 42);


            for (int i = 23; i < 24; i++)
            {
                pt.pnt1("┃", 16, i);
                pt.pnt1("┃", 37, i);
                pt.pnt1("┃", 52, i);
                pt.pnt1("┃", 60, i);
                pt.pnt1("┃", 83, i);
                pt.pnt1("┃", 100, i);
                pt.pnt1("┃", 116, i);
            }

            pt.pnt1("DANH SÁCH HỌC SINH ", 61, 20);
            pt.pnt1(" Mã HS ", 8, 23);
            pt.pnt1(" Tên HS", 22, 23);
            pt.pnt1(" Ngày sinh", 40, 23);
            pt.pnt1(" GT", 54, 23);
            pt.pnt1(" Địa chỉ", 67, 23);
            pt.pnt1(" SĐT(bố/mẹ)", 87, 23);
            pt.pnt1(" Năm học", 104, 23);
            pt.pnt1(" Mã lớp", 120, 23);
            Console.ForegroundColor = ConsoleColor.Yellow;
            pt.pnt1("Nhập mã lớp của học sinh cần tìm: ", 40, 13);
            Console.ForegroundColor = ConsoleColor.White;
        label: pt.pnt1("", 73, 13);
            string malop = Console.ReadLine();
            if (malop == "")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                pt.pnt1("Mã lớp không được rỗng ! Nhấn phím bất kỳ nhập lại ", 60, 46);
                pt.pnt1("Nhấn Tab để quay lại ", 60, 47);
                Console.ForegroundColor = ConsoleColor.White;
                ConsoleKeyInfo kt = Console.ReadKey();
                switch (kt.Key)
                {
                    case ConsoleKey.Tab:
                        Console.Clear();
                        chucnangtimhs();
                        break;
                    default:
                        pt.pnt1("                                                  ", 60, 46);
                        pt.pnt1("                                                  ", 60, 47);
                        goto label;
                }
            }
            HocSinh hs = new HocSinh();
            hs.Malop = malop;
            if (hsbll.KTmalop(malop) == false)
            {
                List<HocSinh> list = hsbll.Timhs(hs);
                int a = 25;
                int tmp = 0;
                for (int i = 0; i < list.Count; ++i)
                {
                    if (tmp < 9)
                    {
                        pt.pnt1(list[i].Mahs, 9, a);
                        pt.pnt1(list[i].Tenhs, 19, a);
                        pt.pnt1(list[i].Ngaysinh, 40, a);
                        pt.pnt1(list[i].Gioitinh, 55, a);
                        pt.pnt1(list[i].Diachi, 67, a);
                        pt.pnt1(list[i].Sdtbome, 88, a);
                        pt.pnt1(list[i].Namhoc, 104, a);
                        pt.pnt1(list[i].Malop, 122, a);
                        tmp++;
                        a += 2;
                    }
                    else break;
                }
                pt.pnt1("Nhấn Enter để tìm kiểm tiếp ", 60, 45);
                pt.pnt1("Nhấn S để lưu ra file và tìm tiếp ", 60, 46);
                pt.pnt1("Nhấn Tab để quay lại ", 60, 47);
                pt.pnt1("Nhấn ESC để thoát", 60, 48);
            label1:
                ConsoleKeyInfo kt = Console.ReadKey();
                switch (kt.Key)
                {
                    case ConsoleKey.Enter:
                        pt.pnt1("                   ", 73, 13);
                        pt.pnt1("                              ", 60, 45);
                        pt.pnt1("                                       ", 60, 46);
                        pt.pnt1("                       ", 60, 47);
                        pt.pnt1("                   ", 60, 48);
                        for (int i = 25; i < 42; ++i)
                        {
                            pt.pnt1("        ", 9, i);
                            pt.pnt1("                  ", 19, i);
                            pt.pnt1("                  ", 40, i);
                            pt.pnt1("                ", 55,i);
                            pt.pnt1("                ", 67, i);
                            pt.pnt1("                 ", 88, i);
                            pt.pnt1("              ", 104, i);
                            pt.pnt1("        ", 122, i);
                        }
                        goto label;
                    case ConsoleKey.S:
                        hsda.SearchHS(list);
                        pt.pnt1("                   ", 73, 13);
                        pt.pnt1("                              ", 60, 45);
                        pt.pnt1("                                       ", 60, 46);
                        pt.pnt1("                       ", 60, 47);
                        pt.pnt1("                   ", 60, 48);
                        for (int i = 25; i < 34; ++i)
                        {
                            pt.pnt1("        ", 9, i);
                            pt.pnt1("                  ", 19, i);
                            pt.pnt1("                  ", 40, i);
                            pt.pnt1("                ", 55, i);
                            pt.pnt1("                ", 67, i);
                            pt.pnt1("                 ", 88, i);
                            pt.pnt1("              ", 104, i);
                            pt.pnt1("        ", 122, i);
                        }
                        goto label;
                    case ConsoleKey.Tab:
                        Console.Clear();
                        chucnangtimhs();
                        break;
                    case ConsoleKey.Escape:
                        return;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        pt.pnt1("Bạn nhập sai ! Nhập lại ", 60, 49);
                        Console.ForegroundColor = ConsoleColor.White;
                        goto label1;
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                pt.pnt1("Mã lớp không tồn tại ! Nhập lại ", 60, 46);
                pt.pnt1("Nhấn Tab để quay lại ", 60, 47);
                Console.ForegroundColor = ConsoleColor.White;
                ConsoleKeyInfo ktt = Console.ReadKey();
                switch (ktt.Key)
                {
                    case ConsoleKey.Tab:
                        Console.Clear();
                        chucnangtimhs();
                        break;
                    default:
                        pt.pnt1("                                        ", 60, 46);
                        pt.pnt1("                                   ", 60, 47);
                        pt.pnt1("                   ", 73, 13);
                        goto label;
                }
            }

        }
        #endregion
        #region Chức năng tìm kiếm giáo viên chủ nhiệm
        public void chucnangtimgv()
        {
            pt.pnt("┏", 4, 8);
            pt.pnt("┗", 4, 33);
            pt.pnt("┓", 95, 8);
            pt.pnt("┛", 95, 33);

            pt.pnt("━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━", 5, 8);
            pt.pnt("━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━", 5, 33);
            pt.pnt("                                TRƯỜNG ĐẠI HỌC SƯ PHẠM KỸ THUẬT HƯNG YÊN ", 0, 4);
            pt.pnt("                                      KHOA CÔNG NGHỆ THÔNG TIN ", 1, 5);
            pt.pnt("                                     ------- ○○○○ -------", 3, 6);
            for (int i = 9; i < 33; ++i)
            {
                pt.pnt("┃", 4, i);
                pt.pnt("┃", 95, i);
            }
            Console.ForegroundColor = ConsoleColor.Red;
            #region Chữ ký
            Console.ForegroundColor = ConsoleColor.Red;
            pt.pnt("D", 5, 32);
            Console.ForegroundColor = ConsoleColor.White;
            pt.pnt("e", 6, 32);
            Console.ForegroundColor = ConsoleColor.Cyan;
            pt.pnt("s", 7, 32);
            Console.ForegroundColor = ConsoleColor.Green;
            pt.pnt("i", 8, 32);
            Console.ForegroundColor = ConsoleColor.Yellow;
            pt.pnt("g", 9, 32);
            Console.ForegroundColor = ConsoleColor.Gray;
            pt.pnt("n", 10, 32);
            Console.ForegroundColor = ConsoleColor.Magenta;
            pt.pnt("e", 11, 32);
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            pt.pnt("d", 12, 32);
            Console.ForegroundColor = ConsoleColor.DarkRed;
            pt.pnt("b", 14, 32);
            Console.ForegroundColor = ConsoleColor.Yellow;
            pt.pnt("y", 15, 32);
            Console.ForegroundColor = ConsoleColor.Red;
            pt.pnt("T", 17, 32);
            Console.ForegroundColor = ConsoleColor.Yellow;
            pt.pnt("e", 18, 32);
            Console.ForegroundColor = ConsoleColor.Green;
            pt.pnt("a", 19, 32);
            Console.ForegroundColor = ConsoleColor.Red;
            pt.pnt("m", 20, 32);
            Console.ForegroundColor = ConsoleColor.Magenta;
            pt.pnt("T", 22, 32);
            Console.ForegroundColor = ConsoleColor.Yellow;
            pt.pnt("™", 23, 32);
            Console.ForegroundColor = ConsoleColor.White;
            #endregion
            Console.ForegroundColor = ConsoleColor.Green;
            pt.pnt(" CHƯƠNG TRÌNH QUẢN LÝ HỌC SINH", 34, 9);
            Console.ForegroundColor = ConsoleColor.White;
            pt.pnt("┏", 19, 14);
            pt.pnt("┓", 79, 14);
            pt.pnt("━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━", 20, 14);
            pt.pnt("┛", 79, 22);
            pt.pnt("┗", 19, 22);
            for (int i = 15; i < 22; ++i)
            {
                pt.pnt("┃", 19, i);
                pt.pnt("┃", 79, i);
            }
            pt.pnt("┠", 19, 18);
            pt.pnt("┠", 19, 20);

            pt.pnt("┨", 79, 18);
            pt.pnt("┨", 79, 20);

            pt.pnt("━━━━━┳━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━", 20, 18);
            pt.pnt("━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━", 20, 20);
            pt.pnt("━━━━━┻━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━", 20, 22);



            for (int i = 19; i < 22; ++i)
            {
                pt.pnt("┃", 25, i);
            }

            pt.pnt("           TÌM KIẾM GIÁO VIÊN CHỦ NHIỆM         ", 25, 16);
            pt.pnt("F1", 22, 19);
            pt.pnt("F2", 22, 21);
            pt.pnt("Tìm kiếm giáo viên theo mã giáo viên", 32, 19);
            pt.pnt("Tìm kiếm giáo viên theo tên ", 32, 21);
            pt.pnt("Nhấn Tab để quay lại ", 60, 29);
            pt.pnt("Thoát khỏi chương trình nhấn Esc", 60, 30);
            pt.pnt("Mời bạn chọn chức năng : ", 60, 31);
        den1: ConsoleKeyInfo kt = Console.ReadKey();
            Console.ForegroundColor = ConsoleColor.White;
            switch (kt.Key)

            {
                case ConsoleKey.F1:
                    Console.Clear();
                    timgvma();
                    break;
                case ConsoleKey.F2:
                    Console.Clear();
                    timgvten();
                    break;
                case ConsoleKey.Tab:
                    Console.Clear();
                    chucnangtk();
                    break;
                case ConsoleKey.Escape:
                    Environment.Exit(0);
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    pt.pnt("Bạn nhập sai xin nhập lại : ", 60, 32);
                    goto den1;
            }
        }
        #endregion
        #region Tìm kiếm giáo viên theo mã
        public void timgvma()
        {
            Paint pt = new Paint(140, 55);
            pt.pnt1("┏", 4, 8);
            pt.pnt1("┗", 4, 52);
            pt.pnt1("┓", 133, 8);
            pt.pnt1("┛", 133, 52);

            pt.pnt1("━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━", 5, 8);
            pt.pnt1("━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━", 5, 52);
            pt.pnt1("                                              TRƯỜNG ĐẠI HỌC SƯ PHẠM KỸ THUẬT HƯNG YÊN ", 0, 1);
            pt.pnt1("                                                      KHOA CÔNG NGHỆ THÔNG TIN ", 1, 2);
            pt.pnt1("                                                     ------- ○○○○ -------", 3, 3);
            for (int i = 9; i < 52; ++i)
            {
                pt.pnt1("┃", 4, i);
                pt.pnt1("┃", 133, i);
            }
            pt.pnt1("━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━", 5, 15);
            pt.pnt1(" Tìm Giáo Viên ", 59, 8);
            pt.pnt1("━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━", 18, 18);
            for (int i = 19; i < 42; i++)
            {
                pt.pnt1("┃", 18, i);
                pt.pnt1("┃", 117, i);
            }

            pt.pnt1("┏", 18, 18);
            pt.pnt1("┗", 18, 42);
            pt.pnt1("┓", 117, 18);
            pt.pnt1("┛", 117, 42);

            pt.pnt1("┣", 4, 15);
            pt.pnt1("┫", 133, 15);
            pt.pnt1("┣", 18, 22);
            pt.pnt1("┣", 18, 24);
            pt.pnt1("┫", 117, 22);
            pt.pnt1("┫", 117, 24);

            Console.ForegroundColor = ConsoleColor.Magenta;
            pt.pnt1("Designed by TeamT ™", 5, 51);
            Console.ForegroundColor = ConsoleColor.White;
            pt.pnt1("━━━━━━━━━━━━━━━━━━━━━┳━━━━━━━━━━━━━━━━━━━━━━━━┳━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┳━━━━━━━━━━━━━━━━━━━━", 19, 22);
            pt.pnt1("━━━━━━━━━━━━━━━━━━━━━┻━━━━━━━━━━━━━━━━━━━━━━━━┻━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┻━━━━━━━━━━━━━━━━━━━━", 19, 24);

            pt.pnt1("━━━━━━━━━━━━━━━━━━━━━┻━━━━━━━━━━━━━━━━━━━━━━━━┻━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┻━━━━━━━━━━━━━━━━━━━━", 19, 42);


            for (int i = 23; i < 42; i++)
            {
                pt.pnt1("┃", 40, i);
                pt.pnt1("┃", 65, i);
                pt.pnt1("┃", 96, i);
            }
            pt.pnt1("DANH SÁCH GIÁO VIÊN CHỦ NHIỆM ", 55, 20);
            pt.pnt1(" Mã GVCN ", 25, 23);
            pt.pnt1(" Tên giáo viên", 47, 23);
            pt.pnt1(" Địa chỉ", 78, 23);
            pt.pnt1(" Số điện thoại ", 100, 23);

            Console.ForegroundColor = ConsoleColor.Yellow;
            pt.pnt1(" Nhập mã giáo viên cần tìm : ", 40, 13);
            Console.ForegroundColor = ConsoleColor.White;
        label: pt.pnt1("", 69, 13);
            string magv = Console.ReadLine();
            if (magv == "")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                pt.pnt1("Mã giáo viên không rỗng ! Nhấn phím bất kỳ nhập lại", 15, 48);
                pt.pnt1("Nhấn Tab để quay lại ", 15, 49);
                Console.ForegroundColor = ConsoleColor.White;
                ConsoleKeyInfo kt = Console.ReadKey();
                switch (kt.Key)
                {
                    case ConsoleKey.Tab:
                        Console.Clear();
                        chucnangtimgv();
                        break;
                    default:
                        pt.pnt1("                                                                    ", 15, 48);
                        pt.pnt1("                                              ", 15, 49);
                        goto label;
                }
            }
            GVCN gv = new GVCN();
            gv.Magv = magv;
            if (gvbll.KTmagv(magv)==false)
            {
                List<GVCN> listgv = gvbll.Timgv(gv);
                for(int i = 0; i < listgv.Count; ++i)
                {
                    pt.pnt1(listgv[i].Magv, 25, 25);
                    pt.pnt1(listgv[i].Tengv, 47, 25);
                    pt.pnt1(listgv[i].Diachi, 78, 25);
                    pt.pnt1(listgv[i].Sdtgv, 100, 25);
                }
                pt.pnt1("Nhấn Enter để tìm kiếm tiếp ", 60, 45);
                pt.pnt1("Nhấn S để lưu ra file và tìm kiếm tiếp ", 60, 46);
                pt.pnt1("Nhấn Tab để quay lại ", 60, 47);
                pt.pnt1("Nhấn ESC để thoát", 60, 48);
            label1:
                ConsoleKeyInfo kt = Console.ReadKey();
                switch (kt.Key)
                {
                    case ConsoleKey.Enter:
                        pt.pnt1("                ", 69, 13);

                        pt.pnt1("                                     ", 60, 45);
                        pt.pnt1("                                        ", 60, 46);
                        pt.pnt1("                         ", 60, 47);
                        pt.pnt1("                         ", 60, 48);

                        pt.pnt1("         ", 25, 25);
                        pt.pnt1("                ", 47, 25);
                        pt.pnt1("               ", 78, 25);
                        pt.pnt1("                ", 100, 25);
                        goto label;
                    case ConsoleKey.S:
                        gvda.SearchGV(listgv);
                        pt.pnt1("                ", 69, 13);

                        pt.pnt1("                                     ", 60, 45);
                        pt.pnt1("                                        ", 60, 46);
                        pt.pnt1("                         ", 60, 47);
                        pt.pnt1("                         ", 60, 48);

                        pt.pnt1("         ", 25, 25);
                        pt.pnt1("                ", 47, 25);
                        pt.pnt1("               ", 78, 25);
                        pt.pnt1("                ", 100, 25);
                        goto label;
                    case ConsoleKey.Tab:
                        Console.Clear();
                        chucnangtimgv();
                        break;
                    case ConsoleKey.Escape:
                        return;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        pt.pnt1("Bạn nhập sai ! Xin nhập lại ", 60, 49);
                        Console.ForegroundColor = ConsoleColor.White;
                        goto label1;
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                pt.pnt1("Mã giáo viên không tồn tại ! Nhấn phím bất kỳ nhập lại", 15, 48);
                Console.ForegroundColor = ConsoleColor.White;
                ConsoleKeyInfo kt = Console.ReadKey();
                switch (kt.Key)
                {
                    default:
                        pt.pnt1("                                                                    ", 15, 48);
                        pt.pnt1("                    ", 69, 13);
                        goto label;
                }
            }

        }
        #endregion
        #region Tìm kiếm giáo viên theo tên
        public void timgvten()
        {
            Paint pt = new Paint(140, 55);
            pt.pnt1("┏", 4, 8);
            pt.pnt1("┗", 4, 52);
            pt.pnt1("┓", 133, 8);
            pt.pnt1("┛", 133, 52);

            pt.pnt1("━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━", 5, 8);
            pt.pnt1("━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━", 5, 52);
            pt.pnt1("                                              TRƯỜNG ĐẠI HỌC SƯ PHẠM KỸ THUẬT HƯNG YÊN ", 0, 1);
            pt.pnt1("                                                      KHOA CÔNG NGHỆ THÔNG TIN ", 1, 2);
            pt.pnt1("                                                     ------- ○○○○ -------", 3, 3);
            for (int i = 9; i < 52; ++i)
            {
                pt.pnt1("┃", 4, i);
                pt.pnt1("┃", 133, i);
            }
            pt.pnt1("━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━", 5, 15);
            pt.pnt1(" Tìm Giáo Viên ", 59, 8);
            pt.pnt1("━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━", 18, 18);
            for (int i = 19; i < 42; i++)
            {
                pt.pnt1("┃", 18, i);
                pt.pnt1("┃", 117, i);
            }

            pt.pnt1("┏", 18, 18);
            pt.pnt1("┗", 18, 42);
            pt.pnt1("┓", 117, 18);
            pt.pnt1("┛", 117, 42);

            pt.pnt1("┣", 4, 15);
            pt.pnt1("┫", 133, 15);
            pt.pnt1("┣", 18, 22);
            pt.pnt1("┣", 18, 24);
            pt.pnt1("┫", 117, 22);
            pt.pnt1("┫", 117, 24);

            Console.ForegroundColor = ConsoleColor.Magenta;
            pt.pnt1("Designed by TeamT ™", 5, 51);
            Console.ForegroundColor = ConsoleColor.White;
            pt.pnt1("━━━━━━━━━━━━━━━━━━━━━┳━━━━━━━━━━━━━━━━━━━━━━━━┳━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┳━━━━━━━━━━━━━━━━━━━━", 19, 22);
            pt.pnt1("━━━━━━━━━━━━━━━━━━━━━┻━━━━━━━━━━━━━━━━━━━━━━━━┻━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┻━━━━━━━━━━━━━━━━━━━━", 19, 24);

            pt.pnt1("━━━━━━━━━━━━━━━━━━━━━┻━━━━━━━━━━━━━━━━━━━━━━━━┻━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┻━━━━━━━━━━━━━━━━━━━━", 19, 42);


            for (int i = 23; i < 42; i++)
            {
                pt.pnt1("┃", 40, i);
                pt.pnt1("┃", 65, i);
                pt.pnt1("┃", 96, i);
            }
            pt.pnt1("DANH SÁCH GIÁO VIÊN CHỦ NHIỆM ", 55, 20);
            pt.pnt1(" Mã GVCN ", 25, 23);
            pt.pnt1(" Tên giáo viên", 47, 23);
            pt.pnt1(" Địa chỉ", 78, 23);
            pt.pnt1(" Số điện thoại ", 100, 23);

            Console.ForegroundColor = ConsoleColor.Yellow;
            pt.pnt1(" Nhập tên giáo viên cần tìm : ", 39, 13);
            Console.ForegroundColor = ConsoleColor.White;
        label: pt.pnt1("", 69, 13);
            string tengv = Console.ReadLine();
            if (tengv == "")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                pt.pnt1("Tên giáo viên không rỗng ! Nhấn phím bất kỳ nhập lại", 15, 48);
                pt.pnt1("Nhấn Tab để quay lại ", 15, 49);
                Console.ForegroundColor = ConsoleColor.White;
                ConsoleKeyInfo kt = Console.ReadKey();
                switch (kt.Key)
                {
                    case ConsoleKey.Tab:
                        Console.Clear();
                        chucnangtimgv();
                        break;
                    default:
                        pt.pnt1("                                                                    ", 15, 48);
                        pt.pnt1("                                             ", 15, 49);
                        goto label;
                }
            }
            GVCN gv = new GVCN();
            gv.Tengv = QLHS.Utility.CongCu.ChuanHoaXau(tengv);
            if (gvbll.KTtengvtk(tengv) == false)
            {
                List<GVCN> listgv = gvbll.Timgv(gv);
                for (int i = 0; i < listgv.Count; ++i)
                {
                    pt.pnt1(listgv[i].Magv, 25, 25);
                    pt.pnt1(listgv[i].Tengv, 47, 25);
                    pt.pnt1(listgv[i].Diachi, 78, 25);
                    pt.pnt1(listgv[i].Sdtgv, 100, 25);
                }
                pt.pnt1("Nhấn Enter để tìm kiểm tiếp ", 60, 45);
                pt.pnt1("Nhấn S để lưu vào file và tìm kiểm tiếp ", 60, 46);
                pt.pnt1("Nhấn Tab để quay lại ", 60, 47);
                pt.pnt1("Nhấn ESC để thoát", 60, 48);
            label1:
                ConsoleKeyInfo kt = Console.ReadKey();
                switch (kt.Key)
                {
                    case ConsoleKey.Enter:
                        pt.pnt1("                ", 69, 13);

                        pt.pnt1("                                     ", 60, 45);
                        pt.pnt1("                                         ", 60, 46);
                        pt.pnt1("                         ", 60, 47);
                        pt.pnt1("                         ", 60, 48);

                        pt.pnt1("         ", 25, 25);
                        pt.pnt1("                ", 47, 25);
                        pt.pnt1("               ", 78, 25);
                        pt.pnt1("                ", 100, 25);
                        goto label;
                    case ConsoleKey.S:
                        gvda.SearchGV(listgv);
                        pt.pnt1("                ", 69, 13);

                        pt.pnt1("                                     ", 60, 45);
                        pt.pnt1("                                         ", 60, 46);
                        pt.pnt1("                         ", 60, 47);
                        pt.pnt1("                         ", 60, 48);

                        pt.pnt1("         ", 25, 25);
                        pt.pnt1("                ", 47, 25);
                        pt.pnt1("               ", 78, 25);
                        pt.pnt1("                ", 100, 25);
                        goto label;
                    case ConsoleKey.Tab:
                        Console.Clear();
                        chucnangtimgv();
                        break;
                    case ConsoleKey.Escape:
                        return;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        pt.pnt1("Bạn nhập sai ! Xin nhập lại ", 60, 49);
                        Console.ForegroundColor = ConsoleColor.White;
                        goto label1;
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                pt.pnt1("Tên giáo viên không tồn tại ! Nhấn phím bất kỳ nhập lại", 15, 48);
                Console.ForegroundColor = ConsoleColor.White;
                ConsoleKeyInfo kt = Console.ReadKey();
                switch (kt.Key)
                {
                    default:
                        pt.pnt1("                                                                    ", 15, 48);
                        pt.pnt1("                    ", 69, 13);
                        goto label;
                }
            }

        }
        #endregion
        #region Chức năng tìm điểm
        public void timdiem()
        {
            Paint pt = new Paint(157, 55);
            pt.pnt2("┏", 4, 8);
            pt.pnt2("┗", 4, 52);
            pt.pnt2("┓", 157, 8);
            pt.pnt2("┛", 157, 52);

            pt.pnt2("━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━", 5, 8);
            pt.pnt2("━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━", 5, 52);
            pt.pnt2("                                                      TRƯỜNG ĐẠI HỌC SƯ PHẠM KỸ THUẬT HƯNG YÊN ", 0, 1);
            pt.pnt2("                                                             KHOA CÔNG NGHỆ THÔNG TIN ", 0, 2);
            pt.pnt2("                                                              ------- oooo -------", 0, 3);
            for (int i = 9; i < 52; ++i)
            {
                pt.pnt2("┃", 4, i);
                pt.pnt2("┃", 157, i);
            }
            pt.pnt2("━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━", 5, 17);
            pt.pnt2(" Tìm điểm ", 66, 8);
            pt.pnt2("━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━", 6, 19);
            for (int i = 19; i < 42; i++)
            {
                pt.pnt2("┃", 5, i);
                pt.pnt2("┃", 156, i);
            }
            pt.pnt2("┏", 5, 19);
            pt.pnt2("┗", 5, 42);
            pt.pnt2("┓", 156, 19);
            pt.pnt2("┛", 156, 42);

            pt.pnt2("┣", 4, 17);
            pt.pnt2("┫", 157, 17);
            pt.pnt2("┣", 5, 22);
            pt.pnt2("┣", 5, 24);
            pt.pnt2("┫", 156, 22);
            pt.pnt2("┫", 156, 24);

            Console.ForegroundColor = ConsoleColor.Magenta;
            pt.pnt2("Designed by TeamT ™", 5, 51);
            Console.ForegroundColor = ConsoleColor.White;
            pt.pnt2("━━━━━━━━━━┳━━━━━━━━━━━━━━━━━━━━┳━━━━━━━━━━━━━━━━━━━┳━━━━━━━━━━━━━━━━━━┳━━━━━━━━━━━━━━━━━━━━━━━┳━━━━━━━━━━━━━━━┳━━━━━━━━━━━━━━━┳━━━━━━━━━━━━━┳━━━━━━━━━", 6, 22);
            pt.pnt2("━━━━━━━━━━┻━━━━━━━━━━━━━━━━━━━━┻━━━━━━━━━━━━━━━━━━━┻━━━━━━━━━━━━━━━━━━┻━━━━━━━━━━━━━━━━━━━━━━━┻━━━━━━━━━━━━━━━┻━━━━━━━━━━━━━━━┻━━━━━━━━━━━━━┻━━━━━━━━━", 6, 24);

            pt.pnt2("━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━", 6, 42);


            for (int i = 23; i < 24; i++)
            {
                pt.pnt2("┃", 16, i);
                pt.pnt2("┃", 37, i);
                pt.pnt2("┃", 57, i);
                pt.pnt2("┃", 76, i);
                pt.pnt2("┃", 100, i);
                pt.pnt2("┃", 116, i);
                pt.pnt2("┃", 132, i);
                pt.pnt2("┃", 146, i);
            }

            pt.pnt2("DANH SÁCH ĐIỂM ", 66, 20);
            pt.pnt2(" Mã HS ", 8, 23);
            pt.pnt2(" Mã lớp", 22, 23);
            pt.pnt2(" Mã môn", 43, 23);
            pt.pnt2(" Điểm giữa kỳ", 60, 23);
            pt.pnt2(" Điểm cuối kỳ", 81, 23);
            pt.pnt2(" Hạnh kiểm kỳ", 102, 23);
            pt.pnt2(" Học kỳ", 120, 23);
            pt.pnt2(" Năm học", 136, 23);
            pt.pnt2(" TBMHK", 148, 23);

            Console.ForegroundColor = ConsoleColor.Yellow;
            pt.pnt2("Nhập mã học sinh cần tìm điểm : ", 40, 13);
            Console.ForegroundColor = ConsoleColor.White;
        label:
            pt.pnt2("", 73, 13);
            string mahs = Console.ReadLine();
            if (mahs == "")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                pt.pnt2("Mã không được rỗng ! Nhập lại ", 15, 47);
                pt.pnt2("Nhấn Tab để quay lại", 15, 48);
                Console.ForegroundColor = ConsoleColor.White;
                ConsoleKeyInfo kt = Console.ReadKey();
                switch (kt.Key)
                {
                    case ConsoleKey.Tab:
                        Console.Clear();
                        chucnangtk();
                        break;
                    default:
                        pt.pnt2("                                      ", 15, 47);
                        pt.pnt2("                                      ", 15, 48);
                        goto label;
                }
            }
            BangDiem bd = new BangDiem();
            bd.Mahs = mahs;
            int a = 25;
            if (bdbll.KTmahs(mahs) == true)
            {
                List<BangDiem> listbd = bdbll.Timbd(bd);
                for (int i = 0; i < listbd.Count; ++i)
                {
                        pt.pnt2(listbd[i].Mahs, 9, a);
                        pt.pnt2(listbd[i].Malop, 23, a);
                        pt.pnt2(listbd[i].Mamon, 46, a);
                        pt.pnt2(Convert.ToString(listbd[i].Diemgiuaky), 67, a);
                        pt.pnt2(Convert.ToString(listbd[i].Diemcuoiky), 85, a);
                        pt.pnt2(listbd[i].Hanhkiemky, 107, a);
                        pt.pnt2(listbd[i].Hocky, 122, a);
                        pt.pnt2(listbd[i].Namhoc, 136, a);
                        pt.pnt2(Convert.ToString(listbd[i].Diemtk), 149, a);
                        a += 2;
                }
                pt.pnt2("Nhấn Enter để tìm tiếp", 60, 45);
                pt.pnt2("Nhấn S để lưu ra file và tìm tiếp", 60, 46);
                pt.pnt2("Nhấn Tab để quay lại ", 60, 47);
                pt.pnt2("Nhấn ESC để thoát ", 60, 48);
            label1: ConsoleKeyInfo kt = Console.ReadKey();
                switch (kt.Key)
                {
                    case ConsoleKey.Enter:
                        pt.pnt2("                ", 73, 13);

                        pt.pnt2("                              ", 60, 45);
                        pt.pnt2("                                          ", 60, 46);
                        pt.pnt2("                              ", 60, 47);
                        pt.pnt2("                              ", 60, 48);

                        for (int i = 25; i < 34; ++i)
                        {
                            pt.pnt2("        ", 9, i);
                            pt.pnt2("              ", 22, i);
                            pt.pnt2("         ", 40, i);
                            pt.pnt2("         ", 60, i);
                            pt.pnt2("              ", 81, i);
                            pt.pnt2("              ", 104, i);
                            pt.pnt2("             ", 120, i);
                            pt.pnt2("            ", 136, i);
                            pt.pnt2("       ", 148, i);
                        }
                        goto label;
                    case ConsoleKey.S:
                        bdda.SearchDiem(listbd);
                        pt.pnt2("                ", 73, 13);

                        pt.pnt2("                              ", 60, 45);
                        pt.pnt2("                                          ", 60, 46);
                        pt.pnt2("                              ", 60, 47);
                        pt.pnt2("                              ", 60, 48);

                        for (int i = 25; i < 34; ++i)
                        {
                            pt.pnt2("        ", 9, i);
                            pt.pnt2("              ", 22, i);
                            pt.pnt2("         ", 40, i);
                            pt.pnt2("         ", 60, i);
                            pt.pnt2("              ", 81, i);
                            pt.pnt2("              ", 104, i);
                            pt.pnt2("             ", 120, i);
                            pt.pnt2("            ", 136, i);
                            pt.pnt2("       ", 148, i);
                        }
                        goto label;
                    case ConsoleKey.Tab:
                        Console.Clear();
                        chucnangtk();
                        break;
                    case ConsoleKey.Escape:
                        return;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        pt.pnt2("Nhập sai ! Xin nhập lại ", 60, 49);
                        Console.ForegroundColor = ConsoleColor.White;
                        goto label1;
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                pt.pnt2("Mã học sinh không tồn tại hoặc học sinh chưa có điểm ! Nhập lại ", 15, 47);
                Console.ForegroundColor = ConsoleColor.White;
                ConsoleKeyInfo kt = Console.ReadKey();
                switch (kt.Key)
                {
                    default:
                        pt.pnt2("                                                                             ", 15, 47);
                        pt.pnt2("                      ", 73, 13);
                        goto label;
                }
            }
        }
        #endregion
        #endregion
    }
}
