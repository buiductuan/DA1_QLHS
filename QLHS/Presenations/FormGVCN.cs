using System;
using System.Linq;
using System.Text;
using QLHS.Utility;
using QLHS.Presenations;
using QLHS.Business.Components;
using QLHS.DataAccessLayer.Service_Interface;
using QLHS.DataAccessLayer;
using QLHS.Entities;
using QLHS.Business.Service_Interface;
namespace QLHS.Presenations
{
    public class FormGVCN
    {
        Paint pt = new Paint(140, 55);
        GVCNBLL gvbll = new GVCNBLL();
        GVCNDAL gvda = new GVCNDAL();
        public static MenuChinh mn = new MenuChinh();
        public static ThongTinPM tt = new ThongTinPM();
        public static FormBangDiem fbd = new FormBangDiem();
        public static FormLop flop = new FormLop();
        public static FormTimKiem ff = new FormTimKiem();
        public static FormMonHoc fmh = new FormMonHoc();
        public static FormThongKe ftk = new FormThongKe();
        public static FormHS fhs = new FormHS();
        #region Quản lý giáo viên chủ nhiệm
        public void themgv()
        {
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
            pt.pnt1(" Tên Giáo viên", 46, 23);
            pt.pnt1(" Địa chỉ", 77, 23);
            pt.pnt1(" Điện thoại ", 102, 23);   

            // phần nhập
            //pt.pnt1("Mã GVCN : ", 18, 10);
            //pt.pnt1("Tên Giáo viên :", 50, 10);
            //pt.pnt1("Địa chỉ : ", 89, 10);
            //pt.pnt1("Số điện thoại  : ", 18, 12);

            pt.pnt1("1. Thêm giáo viên", 88, 43);
            pt.pnt1("2. Sửa giáo viên", 88, 44);
            pt.pnt1("3. Xóa giáo viên", 88, 45);
            pt.pnt1("4. Danh sách giáo viên", 88, 46);
            pt.pnt1("5. Để quay lại menu chính", 88, 47);
            pt.pnt1("6. Để thoát khỏi chương trình", 88, 48);
            pt.pnt1("Nhấn", 88, 49);
            Console.ForegroundColor = ConsoleColor.Green;
            pt.pnt1("H", 93, 49);
            Console.ForegroundColor = ConsoleColor.White;
            pt.pnt1("để mở thanh công cụ và", 95, 49);
            Console.ForegroundColor = ConsoleColor.Green;
            pt.pnt1("E", 118, 49);
            Console.ForegroundColor = ConsoleColor.White;
            pt.pnt1("để tắt", 120, 49);
            // hiện danh sách giáo viên
            danhsach: List<GVCN> listgv = gvbll.LayDlgv();
            gvda.BackUp(listgv);
            int a = 25;
            int tmp = 0;
            for (int i = 0; i < listgv.Count; ++i)
            {
                if (tmp < 9)
                {
                    pt.pnt1(listgv[i].Magv, 27, a);
                    pt.pnt1(listgv[i].Tengv, 46, a);
                    pt.pnt1(listgv[i].Diachi, 77, a);
                    pt.pnt1(listgv[i].Sdtgv, 102, a);
                    tmp++;
                    a += 2;
                }
                else break;
            }
            pt.pnt1("Chọn chức năng : ", 88, 50);
        chucnang: ConsoleKeyInfo ktktt = Console.ReadKey();
            Console.ForegroundColor = ConsoleColor.White;
            switch (ktktt.KeyChar)
            {
                case '1':
                    pt.pnt1(" Thêm giáo viên ", 58, 8);
                    pt.pnt1("               ", 88, 43);
                    Console.ForegroundColor = ConsoleColor.Green;
                    pt.pnt1("→ 1. Thêm giáo viên", 88, 43);
                    Console.ForegroundColor = ConsoleColor.White;
                    pt.pnt1("    ", 105, 50);
                    pt.pnt1("                             ", 88, 51);

                    pt.pnt1("                   ", 55, 10);
                    pt.pnt1("                   ", 93, 10);
                    pt.pnt1("                   ", 18, 10);
                    pt.pnt1("                                 ", 10, 14);

                    pt.pnt1("                                   ", 40, 13);

                    pt.pnt1("Mã GVCN : ", 18, 10);
                    pt.pnt1("Tên Giáo viên :", 50, 10);
                    pt.pnt1("Địa chỉ : ", 89, 10);
                    pt.pnt1("Số điện thoại  : ", 18, 12);

                    goto themgv;
                case '2':
                    pt.pnt1(" Sửa giáo viên  ", 58, 8);
                    pt.pnt1("               ", 88, 43);
                    pt.pnt1("               ", 88, 44);
                    pt.pnt1("                             ", 88, 51);
                    pt.pnt1("               ", 18, 10);
                    pt.pnt1("               ", 50, 10);
                    pt.pnt1("               ", 89, 10);
                    pt.pnt1("                 ", 18, 12);
                    pt.pnt1("                                   ", 40, 13);

                    pt.pnt1("Địa chỉ :", 55, 10);
                    pt.pnt1("Số điện thoại : ", 93, 10);
                    pt.pnt1("Tên giáo viên  : ", 18, 10);

                    Console.ForegroundColor = ConsoleColor.Yellow;
                    pt.pnt1(" Nhập mã giáo viên cần sửa : ", 10, 14);
                    Console.ForegroundColor = ConsoleColor.White;
                    pt.pnt1("1. Thêm giáo viên", 88, 43);
                    Console.ForegroundColor = ConsoleColor.Green;
                    pt.pnt1("→ 2. Sửa giáo viên", 88, 44);
                    Console.ForegroundColor = ConsoleColor.White;
                    pt.pnt1("    ", 105, 50);
                    goto suagv;
                case '3':
                    pt.pnt1(" Xóa giáo viên  ", 58, 8);
                    pt.pnt1("               ", 88, 43);
                    pt.pnt1("               ", 88, 44);
                    pt.pnt1("               ", 88, 45);

                    pt.pnt1("               ", 18, 10);
                    pt.pnt1("               ", 50, 10);
                    pt.pnt1("               ", 89, 10);
                    pt.pnt1("                 ", 18, 12);
                    pt.pnt1("  ", 105, 50);

                    pt.pnt1("                   ", 55, 10);
                    pt.pnt1("                   ", 93, 10);
                    pt.pnt1("                   ", 18, 10);
                    pt.pnt1("                                 ", 10, 14);

                    Console.ForegroundColor = ConsoleColor.Yellow;
                    pt.pnt1(" Nhập mã giáo viên cần xóa : ", 40, 13);
                    Console.ForegroundColor = ConsoleColor.White;
                    pt.pnt1("1. Thêm giáo viên", 88, 43);
                    pt.pnt1("2. Sửa giáo viên", 88, 44);
                    Console.ForegroundColor = ConsoleColor.Green;
                    pt.pnt1("→ 3. Xóa giáo viên", 88, 45);
                    Console.ForegroundColor = ConsoleColor.White;
                    goto xoagv;
                case '4':
                    for (int i = 1; i < 54; i++)
                    {
                        pt.pnt1("                                                                                                                                                ", 1, i);
                    }
                    goto hiengv;
                case '5':
                    Console.Clear();
                    mn.MenuChinh1();
                    break;
                case 'S':
                    Console.Clear();
                    fhs.themhs();
                    break;
                case 'D':
                    Console.Clear();
                    fbd.themdiem();
                    break;
                case 'M':
                    Console.Clear();
                    fmh.themmh();
                    break;
                case 'T':
                    Console.Clear();
                    ff.chucnangtk();
                    break;
                case 'K':
                    Console.Clear();
                    ftk.chucnangthk();
                    break;
                case 'L':
                    Console.Clear();
                    flop.Themlop();
                    break;
                case 'H':
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    pt.pnt1("S : Quản lý Học Sinh", 4, 6);
                    pt.pnt1("D : Quản lý Điểm", 30, 6);
                    pt.pnt1("M : Quản lý Môn học", 52, 6);
                    pt.pnt1("T : Tìm kiếm", 76, 6);
                    pt.pnt1("K : Thống kê", 96, 6);
                    pt.pnt1("L : Quản lý Lớp", 114, 6);
                    pt.pnt1("                           ", 88, 51);
                    pt.pnt1("  ", 105, 50);
                    pt.pnt1("", 105, 50);
                    Console.ForegroundColor = ConsoleColor.White;
                    goto chucnang;
                case 'E':
                    pt.pnt1("                       ", 4, 6);
                    pt.pnt1("                       ", 30, 6);
                    pt.pnt1("                       ", 52, 6);
                    pt.pnt1("                       ", 76, 6);
                    pt.pnt1("                       ", 96, 6);
                    pt.pnt1("                       ", 114, 6);
                    pt.pnt1("                          ", 88, 51);
                    pt.pnt1("  ", 105, 50);
                    pt.pnt1("", 105, 50);
                    goto chucnang;
                case '6':
                    Environment.Exit(0); break;
                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    pt.pnt1("      ", 105, 50);
                    pt.pnt1("Bạn nhập sai xin nhập lại", 88, 51);
                    pt.pnt1("", 105, 50);
                    Console.ForegroundColor = ConsoleColor.White;
                    goto chucnang;
            }
        // thêm các dữ liệu

        #region Thêm giáo viên
        themgv:
            string magv, tengv, diachi, sdtgv;
            pt.pnt1("", 28, 10); magv = Console.ReadLine();
            if (magv == "")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                pt.pnt1("Mã giáo viên không thể rỗng ! Nhấn phím bất kỳ để nhập lại ", 6, 44);
                pt.pnt1("Nhấn Tab để quay lại ", 6, 45);
                Console.ForegroundColor = ConsoleColor.White;
                ConsoleKeyInfo kt = Console.ReadKey();
                switch (kt.Key)
                {
                    case ConsoleKey.Tab:
                        pt.pnt1("                                                                ", 6, 44);
                        pt.pnt1("                         ", 6, 45);
                        pt.pnt1("                        ", 58, 8);
                        pt.pnt1("━━━━━━━━━━━━━━━━━━━━━━━━━", 58, 8);
                        pt.pnt1("               ", 18, 10);
                        pt.pnt1("               ", 50, 10);
                        pt.pnt1("               ", 89, 10);
                        pt.pnt1("                 ", 18, 12);
                        pt.pnt1("                   ", 55, 10);
                        pt.pnt1("                   ", 93, 10);
                        pt.pnt1("                   ", 18, 10);
                        pt.pnt1("                                 ", 10, 14);

                        pt.pnt1("                                   ", 40, 13);

                        pt.pnt1("1. Thêm giáo viên    ", 88, 43);
                        pt.pnt1("2. Sửa giáo viên     ", 88, 44);
                        pt.pnt1("3. Xóa giáo viên     ", 88, 45);
                        pt.pnt1("4. Danh sách giáo viên    ", 88, 46);
                        pt.pnt1("5. Để quay lại menu chính", 88, 47);
                        pt.pnt1("6. Để thoát khỏi chương trình", 88, 48);
                        pt.pnt1("Nhấn", 88, 49);
                        Console.ForegroundColor = ConsoleColor.Green;
                        pt.pnt1("H", 93, 49);
                        Console.ForegroundColor = ConsoleColor.White;
                        pt.pnt1("để mở thanh công cụ và", 95, 49);
                        Console.ForegroundColor = ConsoleColor.Green;
                        pt.pnt1("E", 118, 49);
                        Console.ForegroundColor = ConsoleColor.White;
                        pt.pnt1("để tắt", 120, 49);
                        pt.pnt1("", 105, 50);
                        goto chucnang;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        pt.pnt1("                                                                ", 6, 44);
                        pt.pnt1("                         ", 6, 45);
                        pt.pnt1("            ", 28, 10);
                        Console.ForegroundColor = ConsoleColor.White;
                        goto themgv;
                }
            }
            if (gvbll.KTmagv(magv))
            {
                if (magv.Length < 2)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    pt.pnt1("Mã giáo viên quá ngắn ! Nhấn phím bất kỳ để nhập lại ", 6, 44);
                    Console.ForegroundColor = ConsoleColor.White;
                    ConsoleKeyInfo kt = Console.ReadKey();
                    switch (kt.Key)
                    {
                        case ConsoleKey.Tab:
                            pt.pnt1("                                                                ", 6, 44);
                            pt.pnt1("                         ", 6, 45);
                            pt.pnt1("1. Thêm giáo viên    ", 88, 43);
                            pt.pnt1("2. Sửa giáo viên     ", 88, 44);
                            pt.pnt1("3. Xóa giáo viên     ", 88, 45);
                            pt.pnt1("4. Danh sách giáo viên    ", 88, 46);
                            pt.pnt1("5. Để quay lại menu chính", 88, 47);
                            pt.pnt1("6. Để thoát khỏi chương trình", 88, 48);
                            pt.pnt1("Nhấn", 88, 49);
                            Console.ForegroundColor = ConsoleColor.Green;
                            pt.pnt1("H", 93, 49);
                            Console.ForegroundColor = ConsoleColor.White;
                            pt.pnt1("để mở thanh công cụ và", 95, 49);
                            Console.ForegroundColor = ConsoleColor.Green;
                            pt.pnt1("E", 118, 49);
                            Console.ForegroundColor = ConsoleColor.White;
                            pt.pnt1("để tắt", 120, 49);
                            pt.pnt1("", 105, 50);
                            goto chucnang;
                        default:
                            Console.ForegroundColor = ConsoleColor.Red;
                            pt.pnt1("                                                      ", 6, 44);
                            pt.pnt1("            ", 28, 10);
                            Console.ForegroundColor = ConsoleColor.White;
                            goto themgv;
                    }
                }
                for (int i = 0; i < magv.Length; ++i)
                {
                    if (magv[i] != '0' && magv[i] != '1' && magv[i] != '2' && magv[i] != '3' && magv[i] != '4' && magv[i] != '5' && magv[i] != '6' && magv[i] != '7' && magv[i] != '8' && magv[i] != '9' && magv[i] != 'G' && magv[i] != 'V')
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        pt.pnt1("Nhập sai định dạng mã GV ! Nhấn phím bất kỳ để nhập lại ", 6, 44);
                        pt.pnt1("Nhấn H để xem định dạng hợp lệ ", 6, 45);
                        Console.ForegroundColor = ConsoleColor.White;
                        ConsoleKeyInfo kt = Console.ReadKey();
                        switch (kt.Key)
                        {
                            case ConsoleKey.H:
                                Console.Clear();
                                tt.dinhdangmgv();
                                break;
                            default:
                                Console.ForegroundColor = ConsoleColor.Red;
                                pt.pnt1("                                                        ",6, 44);
                                pt.pnt1("                                          ", 6, 45);
                                pt.pnt1("            ", 28, 10);
                                Console.ForegroundColor = ConsoleColor.White;
                                goto themgv;
                        }
                    }
                }
            tengv:
                pt.pnt1("", 66, 10); tengv = Console.ReadLine();
                if (tengv == "")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    pt.pnt1("Tên không được rỗng! Nhấn phím bất kỳ để nhập lại ", 6, 44);
                    Console.ForegroundColor = ConsoleColor.White;
                    ConsoleKeyInfo kt = Console.ReadKey();
                    switch (kt.Key)
                    {
                        case ConsoleKey.Tab:
                            pt.pnt1("                                                                ", 6, 44);
                            pt.pnt1("                         ", 6, 45);
                            pt.pnt1("1. Thêm giáo viên    ", 88, 43);
                            pt.pnt1("2. Sửa giáo viên     ", 88, 44);
                            pt.pnt1("3. Xóa giáo viên     ", 88, 45);
                            pt.pnt1("4. Danh sách giáo viên    ", 88, 46);
                            pt.pnt1("5. Để quay lại menu chính", 88, 47);
                            pt.pnt1("6. Để thoát khỏi chương trình", 88, 48);
                            pt.pnt1("Nhấn", 88, 49);
                            Console.ForegroundColor = ConsoleColor.Green;
                            pt.pnt1("H", 93, 49);
                            Console.ForegroundColor = ConsoleColor.White;
                            pt.pnt1("để mở thanh công cụ và", 95, 49);
                            Console.ForegroundColor = ConsoleColor.Green;
                            pt.pnt1("E", 118, 49);
                            Console.ForegroundColor = ConsoleColor.White;
                            pt.pnt1("để tắt", 120, 49);
                            pt.pnt1("", 105, 50);
                            goto chucnang;
                        default:
                            Console.ForegroundColor = ConsoleColor.Red;
                            pt.pnt1("                                                      ", 6, 44);
                            pt.pnt1("            ", 66, 10);
                            Console.ForegroundColor = ConsoleColor.White;
                            goto tengv;
                    }
                }
                else
                {
                    if (tengv.Length < 6)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        pt.pnt1("Tên quá ngắn hoặc không đầy đủ! Nhấn phím bất kỳ để nhập lại ", 6, 44);
                        Console.ForegroundColor = ConsoleColor.White;
                        ConsoleKeyInfo ktt = Console.ReadKey();
                        switch (ktt.Key)
                        {
                            case ConsoleKey.Tab:
                                pt.pnt1("                                                                ", 6, 44);
                                pt.pnt1("                         ", 6, 45);
                                pt.pnt1("1. Thêm giáo viên    ", 88, 43);
                                pt.pnt1("2. Sửa giáo viên     ", 88, 44);
                                pt.pnt1("3. Xóa giáo viên     ", 88, 45);
                                pt.pnt1("4. Danh sách giáo viên    ", 88, 46);
                                pt.pnt1("5. Để quay lại menu chính", 88, 47);
                                pt.pnt1("6. Để thoát khỏi chương trình", 88, 48);
                                pt.pnt1("Nhấn", 88, 49);
                                Console.ForegroundColor = ConsoleColor.Green;
                                pt.pnt1("H", 93, 49);
                                Console.ForegroundColor = ConsoleColor.White;
                                pt.pnt1("để mở thanh công cụ và", 95, 49);
                                Console.ForegroundColor = ConsoleColor.Green;
                                pt.pnt1("E", 118, 49);
                                Console.ForegroundColor = ConsoleColor.White;
                                pt.pnt1("để tắt", 120, 49);
                                pt.pnt1("", 105, 50);
                                goto chucnang;
                            default:
                                Console.ForegroundColor = ConsoleColor.Red;
                                pt.pnt1("                                                                 ", 6, 44);
                                pt.pnt1("            ", 66, 10);
                                Console.ForegroundColor = ConsoleColor.White;
                                goto tengv;
                        }
                    }
                    if (gvbll.KTtengv(tengv))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        pt.pnt1("Tên không chứa số ! Nhấn phím bất kỳ để nhập lại ", 15, 48);
                        Console.ForegroundColor = ConsoleColor.White;
                        ConsoleKeyInfo kt = Console.ReadKey();
                        switch (kt.Key)
                        {
                            case ConsoleKey.Tab:
                                pt.pnt1("                                                                ", 6, 44);
                                pt.pnt1("                         ", 6, 45);
                                pt.pnt1("1. Thêm giáo viên    ", 88, 43);
                                pt.pnt1("2. Sửa giáo viên     ", 88, 44);
                                pt.pnt1("3. Xóa giáo viên     ", 88, 45);
                                pt.pnt1("4. Danh sách giáo viên    ", 88, 46);
                                pt.pnt1("5. Để quay lại menu chính", 88, 47);
                                pt.pnt1("6. Để thoát khỏi chương trình", 88, 48);
                                pt.pnt1("Nhấn", 88, 49);
                                Console.ForegroundColor = ConsoleColor.Green;
                                pt.pnt1("H", 93, 49);
                                Console.ForegroundColor = ConsoleColor.White;
                                pt.pnt1("để mở thanh công cụ và", 95, 49);
                                Console.ForegroundColor = ConsoleColor.Green;
                                pt.pnt1("E", 118, 49);
                                Console.ForegroundColor = ConsoleColor.White;
                                pt.pnt1("để tắt", 120, 49);
                                pt.pnt1("", 105, 50);
                                goto chucnang;
                            default:
                                Console.ForegroundColor = ConsoleColor.Red;
                                pt.pnt1("                                                                 ", 15, 48);
                                pt.pnt1("            ", 66, 10);
                                Console.ForegroundColor = ConsoleColor.White;
                                goto tengv;
                        }
                    }
                }
            diachi:
                pt.pnt1("", 99, 10); diachi = Console.ReadLine();
                if (diachi == "")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    pt.pnt1("Địa chỉ không được rỗng ! Nhấn phím bất kỳ để nhập lại ", 6, 44);
                    Console.ForegroundColor = ConsoleColor.White;
                    ConsoleKeyInfo kt = Console.ReadKey();
                    switch (kt.Key)
                    {
                        case ConsoleKey.Tab:
                            pt.pnt1("                                                                ", 6, 44);
                            pt.pnt1("                         ", 6, 45);
                            pt.pnt1("1. Thêm giáo viên    ", 88, 43);
                            pt.pnt1("2. Sửa giáo viên     ", 88, 44);
                            pt.pnt1("3. Xóa giáo viên     ", 88, 45);
                            pt.pnt1("4. Danh sách giáo viên    ", 88, 46);
                            pt.pnt1("5. Để quay lại menu chính", 88, 47);
                            pt.pnt1("6. Để thoát khỏi chương trình", 88, 48);
                            pt.pnt1("Nhấn", 88, 49);
                            Console.ForegroundColor = ConsoleColor.Green;
                            pt.pnt1("H", 93, 49);
                            Console.ForegroundColor = ConsoleColor.White;
                            pt.pnt1("để mở thanh công cụ và", 95, 49);
                            Console.ForegroundColor = ConsoleColor.Green;
                            pt.pnt1("E", 118, 49);
                            Console.ForegroundColor = ConsoleColor.White;
                            pt.pnt1("để tắt", 120, 49);
                            pt.pnt1("", 105, 50);
                            goto chucnang;
                        default:
                            Console.ForegroundColor = ConsoleColor.Red;
                            pt.pnt1("                                                                 ", 6, 44);
                            pt.pnt1("            ", 99, 10);
                            Console.ForegroundColor = ConsoleColor.White;
                            goto diachi;
                    }
                }
                else
                {
                    if (diachi.Length < 4)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        pt.pnt1("Địa chỉ quá ngắn ! Nhấn phím bất kỳ để nhập lại ", 6, 44);
                        Console.ForegroundColor = ConsoleColor.White;
                        ConsoleKeyInfo kt = Console.ReadKey();
                        switch (kt.Key)
                        {
                            case ConsoleKey.Tab:
                                pt.pnt1("                                                                ", 6, 44);
                                pt.pnt1("                         ", 6, 45);
                                pt.pnt1("1. Thêm giáo viên    ", 88, 43);
                                pt.pnt1("2. Sửa giáo viên     ", 88, 44);
                                pt.pnt1("3. Xóa giáo viên     ", 88, 45);
                                pt.pnt1("4. Danh sách giáo viên    ", 88, 46);
                                pt.pnt1("5. Để quay lại menu chính", 88, 47);
                                pt.pnt1("6. Để thoát khỏi chương trình", 88, 48);
                                pt.pnt1("Nhấn", 88, 49);
                                Console.ForegroundColor = ConsoleColor.Green;
                                pt.pnt1("H", 93, 49);
                                Console.ForegroundColor = ConsoleColor.White;
                                pt.pnt1("để mở thanh công cụ và", 95, 49);
                                Console.ForegroundColor = ConsoleColor.Green;
                                pt.pnt1("E", 118, 49);
                                Console.ForegroundColor = ConsoleColor.White;
                                pt.pnt1("để tắt", 120, 49);
                                pt.pnt1("", 105, 50);
                                goto chucnang;
                            default:
                                Console.ForegroundColor = ConsoleColor.Red;
                                pt.pnt1("                                                                 ", 6, 44);
                                pt.pnt1("            ", 99, 10);
                                Console.ForegroundColor = ConsoleColor.White;
                                goto diachi;
                        }
                    }
                }
            sdtgv:
                pt.pnt1("", 34, 12); sdtgv = Console.ReadLine();
                if (sdtgv == "")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    pt.pnt1("Số điện thoại không rỗng ! Nhấn phím bất kỳ để nhập lại ", 6, 44);
                    Console.ForegroundColor = ConsoleColor.White;
                    ConsoleKeyInfo kt = Console.ReadKey();
                    switch (kt.Key)
                    {
                        case ConsoleKey.Tab:
                            pt.pnt1("                                                                ", 6, 44);
                            pt.pnt1("                         ", 6, 45);
                            pt.pnt1("1. Thêm giáo viên    ", 88, 43);
                            pt.pnt1("2. Sửa giáo viên     ", 88, 44);
                            pt.pnt1("3. Xóa giáo viên     ", 88, 45);
                            pt.pnt1("4. Danh sách giáo viên    ", 88, 46);
                            pt.pnt1("5. Để quay lại menu chính", 88, 47);
                            pt.pnt1("6. Để thoát khỏi chương trình", 88, 48);
                            pt.pnt1("Nhấn", 88, 49);
                            Console.ForegroundColor = ConsoleColor.Green;
                            pt.pnt1("H", 93, 49);
                            Console.ForegroundColor = ConsoleColor.White;
                            pt.pnt1("để mở thanh công cụ và", 95, 49);
                            Console.ForegroundColor = ConsoleColor.Green;
                            pt.pnt1("E", 118, 49);
                            Console.ForegroundColor = ConsoleColor.White;
                            pt.pnt1("để tắt", 120, 49);
                            pt.pnt1("", 105, 50);
                            goto chucnang;
                        default:
                            Console.ForegroundColor = ConsoleColor.Red;
                            pt.pnt1("                                                                 ", 6, 44);
                            pt.pnt1("            ", 34, 12);
                            Console.ForegroundColor = ConsoleColor.White;
                            goto sdtgv;
                    }
                }
                else
                {
                    for (int i = 0; i < sdtgv.Length; ++i)
                    {
                        if (sdtgv[i] != '0' && sdtgv[i] != '1' && sdtgv[i] != '2' && sdtgv[i] != '3' && sdtgv[i] != '4' && sdtgv[i] != '5' && sdtgv[i] != '6' && sdtgv[i] != '7' && sdtgv[i] != '8' & sdtgv[i] != '9')
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            pt.pnt1("Số điện thoại không chứa ký tự ! Nhấn phím bất kỳ để nhập lại ", 6, 44);
                            Console.ForegroundColor = ConsoleColor.White;
                            ConsoleKeyInfo kt = Console.ReadKey();
                            switch (kt.Key)
                            {
                                case ConsoleKey.Tab:
                                    pt.pnt1("                                                                ", 6, 44);
                                    pt.pnt1("                         ", 6, 45);
                                    pt.pnt1("1. Thêm giáo viên    ", 88, 43);
                                    pt.pnt1("2. Sửa giáo viên     ", 88, 44);
                                    pt.pnt1("3. Xóa giáo viên     ", 88, 45);
                                    pt.pnt1("4. Danh sách giáo viên    ", 88, 46);
                                    pt.pnt1("5. Để quay lại menu chính", 88, 47);
                                    pt.pnt1("6. Để thoát khỏi chương trình", 88, 48);
                                    pt.pnt1("Nhấn", 88, 49);
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    pt.pnt1("H", 93, 49);
                                    Console.ForegroundColor = ConsoleColor.White;
                                    pt.pnt1("để mở thanh công cụ và", 95, 49);
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    pt.pnt1("E", 118, 49);
                                    Console.ForegroundColor = ConsoleColor.White;
                                    pt.pnt1("để tắt", 120, 49);
                                    pt.pnt1("", 105, 50);
                                    goto chucnang;
                                default:
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    pt.pnt1("                                                                 ", 6, 44);
                                    pt.pnt1("            ", 34, 12);
                                    Console.ForegroundColor = ConsoleColor.White;
                                    goto sdtgv;
                            }
                        }
                    }
                    if (sdtgv.Length < 9 || sdtgv.Length > 11)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        pt.pnt1("Số điện thoại không lớn hơn 11 số và nhỏ hơn 11 số ! Nhấn phím bất kỳ để nhập lại", 5, 44);
                        Console.ForegroundColor = ConsoleColor.White;
                        ConsoleKeyInfo kt = Console.ReadKey();
                        switch (kt.Key)
                        {
                            case ConsoleKey.Tab:
                                pt.pnt1("                                                                ", 6, 44);
                                pt.pnt1("                         ", 6, 45);
                                pt.pnt1("1. Thêm giáo viên    ", 88, 43);
                                pt.pnt1("2. Sửa giáo viên     ", 88, 44);
                                pt.pnt1("3. Xóa giáo viên     ", 88, 45);
                                pt.pnt1("4. Danh sách giáo viên    ", 88, 46);
                                pt.pnt1("5. Để quay lại menu chính", 88, 47);
                                pt.pnt1("6. Để thoát khỏi chương trình", 88, 48);
                                pt.pnt1("Nhấn", 88, 49);
                                Console.ForegroundColor = ConsoleColor.Green;
                                pt.pnt1("H", 93, 49);
                                Console.ForegroundColor = ConsoleColor.White;
                                pt.pnt1("để mở thanh công cụ và", 95, 49);
                                Console.ForegroundColor = ConsoleColor.Green;
                                pt.pnt1("E", 118, 49);
                                Console.ForegroundColor = ConsoleColor.White;
                                pt.pnt1("để tắt", 120, 49);
                                pt.pnt1("", 105, 50);
                                goto chucnang;
                            default:
                                Console.ForegroundColor = ConsoleColor.Red;
                        pt.pnt1("                                                                                  ", 5, 44);
                                pt.pnt1("                       ", 34, 12);
                                Console.ForegroundColor = ConsoleColor.White;
                                goto sdtgv;
                        }
                    }
                }
                GVCN gvcn = new GVCN(magv, tengv, diachi, sdtgv);
                pt.pnt1("Nhấn Enter để lưu và nhập tiếp", 6, 44);
                pt.pnt1("Nhấn Tab để quay lại", 6, 45);
            label: ConsoleKeyInfo ktttt = Console.ReadKey();
                switch (ktttt.Key)
                {
                    case ConsoleKey.Enter:
                        Console.Clear();
                        gvbll.Themgv(gvcn);
                        themgv();
                        break;
                    case ConsoleKey.Tab:
                        pt.pnt1("                              ", 6, 44);
                        pt.pnt1("                              ", 6, 45);
                        pt.pnt1("                  ", 28, 10);
                        pt.pnt1("                  ", 65, 10);
                        pt.pnt1("                  ", 99, 10);
                        pt.pnt1("                  ", 34, 12);
                        pt.pnt1("1. Thêm giáo viên   ", 88, 43);
                        pt.pnt1("2. Sửa giáo viên    ", 88, 44);
                        pt.pnt1("3. Xóa giáo viên    ", 88, 45);
                        pt.pnt1("4. Danh sách giáo viên", 88, 46);
                        pt.pnt1("5. Để quay lại menu chính", 88, 47);
                        pt.pnt1("6. Để thoát khỏi chương trình", 88, 48);
                        pt.pnt1("Nhấn", 88, 49);
                        Console.ForegroundColor = ConsoleColor.Green;
                        pt.pnt1("H", 93, 49);
                        Console.ForegroundColor = ConsoleColor.White;
                        pt.pnt1("để mở thanh công cụ và", 95, 49);
                        Console.ForegroundColor = ConsoleColor.Green;
                        pt.pnt1("E", 118, 49);
                        Console.ForegroundColor = ConsoleColor.White;
                        pt.pnt1("để tắt", 120, 49);
                        pt.pnt1("", 105, 50);
                        goto chucnang;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        pt.pnt1(" Bạn nhập sai xin nhập lại ", 6, 45);
                        Console.ForegroundColor = ConsoleColor.White;
                        goto label;
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                pt.pnt1("Mã giáo viên đã tồn tại ! Nhấn phím bất kỳ để nhập lại ", 6, 44);
                Console.ForegroundColor = ConsoleColor.White;
                ConsoleKeyInfo kt = Console.ReadKey();
                switch (kt.Key)
                {
                    case ConsoleKey.Tab:
                        pt.pnt1("                                                                ", 6, 44);
                        pt.pnt1("                         ", 6, 45);
                        pt.pnt1("   ", 28, 10);
                        pt.pnt1("1. Thêm giáo viên    ", 88, 43);
                        pt.pnt1("2. Sửa giáo viên     ", 88, 44);
                        pt.pnt1("3. Xóa giáo viên     ", 88, 45);
                        pt.pnt1("4. Danh sách giáo viên    ", 88, 46);
                        pt.pnt1("5. Để quay lại menu chính", 88, 47);
                        pt.pnt1("6. Để thoát khỏi chương trình", 88, 48);
                        pt.pnt1("Nhấn", 88, 49);
                        Console.ForegroundColor = ConsoleColor.Green;
                        pt.pnt1("H", 93, 49);
                        Console.ForegroundColor = ConsoleColor.White;
                        pt.pnt1("để mở thanh công cụ và", 95, 49);
                        Console.ForegroundColor = ConsoleColor.Green;
                        pt.pnt1("E", 118, 49);
                        Console.ForegroundColor = ConsoleColor.White;
                        pt.pnt1("để tắt", 120, 49);
                        pt.pnt1("", 105, 50);
                        goto chucnang;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        pt.pnt1("                                                      ", 6, 44);
                        pt.pnt1("            ", 28, 10);
                        Console.ForegroundColor = ConsoleColor.White;
                        goto themgv;
                }
            }
        #endregion

        #region Sửa giáo viên
        suagv:
            string magvs;
            string tengvmoi, diachimoi, sdtgvmoi;
            pt.pnt1("", 39, 14); magvs = Console.ReadLine();
            if (magvs == "")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                pt.pnt1("Mã giáo viên không thể rỗng ! Nhấn phím bất kỳ để nhập lại ",6, 44);
                pt.pnt1("Nhấn Tab để quay lại ",6, 45);
                Console.ForegroundColor = ConsoleColor.White;
                ConsoleKeyInfo kt = Console.ReadKey();
                switch (kt.Key)
                {
                    case ConsoleKey.Tab:
                        pt.pnt1("                                                                ", 6, 44);
                        pt.pnt1("                         ", 6, 45);
                        pt.pnt1("                        ", 58, 8);
                        pt.pnt1("━━━━━━━━━━━━━━━━━━━━━━━━━", 58, 8);
                        pt.pnt1("               ", 18, 10);
                        pt.pnt1("               ", 50, 10);
                        pt.pnt1("               ", 89, 10);
                        pt.pnt1("                 ", 18, 12);
                        pt.pnt1("                   ", 55, 10);
                        pt.pnt1("                   ", 93, 10);
                        pt.pnt1("                   ", 18, 10);
                        pt.pnt1("                                 ", 10, 14);

                        pt.pnt1("                                   ", 40, 13);
                        pt.pnt1("1. Thêm giáo viên    ", 88, 43);
                        pt.pnt1("2. Sửa giáo viên     ", 88, 44);
                        pt.pnt1("3. Xóa giáo viên     ", 88, 45);
                        pt.pnt1("4. Danh sách giáo viên    ", 88, 46);
                        pt.pnt1("5. Để quay lại menu chính", 88, 47);
                        pt.pnt1("6. Để thoát khỏi chương trình", 88, 48);
                        pt.pnt1("Nhấn", 88, 49);
                        Console.ForegroundColor = ConsoleColor.Green;
                        pt.pnt1("H", 93, 49);
                        Console.ForegroundColor = ConsoleColor.White;
                        pt.pnt1("để mở thanh công cụ và", 95, 49);
                        Console.ForegroundColor = ConsoleColor.Green;
                        pt.pnt1("E", 118, 49);
                        Console.ForegroundColor = ConsoleColor.White;
                        pt.pnt1("để tắt", 120, 49);
                        pt.pnt1("", 105, 50);
                        goto chucnang;
                    default:
                        pt.pnt1("                                                                ",6, 44);
                        pt.pnt1("                              ", 6, 45);
                        goto suagv;
                }
            }
            if (gvbll.KTmagv(magvs) == false)
            {
                List<GVCN> list = gvbll.LayDlgv();
                while (list != null)
                {
                    for (int i = 0; i < list.Count; ++i)
                    {
                        if (list[i].Magv == magvs)
                        {
                            pt.pnt1(list[i].Tengv, 35, 10);
                            pt.pnt1(list[i].Diachi, 66, 10);
                            pt.pnt1(list[i].Sdtgv, 112, 10);
                        }
                    }
                    break;
                }
                pt.pnt1("", 35, 10);
                Console.ReadKey();
                Console.BackgroundColor = ConsoleColor.Black;
                pt.pnt1("                  ", 35, 10);
            tengv:
                pt.pnt1("", 35, 10); tengvmoi = Console.ReadLine();
                if (tengvmoi == "")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    pt.pnt1("Tên giáo viên không thể rỗng ! Nhấn phím bất kỳ để nhập lại ", 6, 44);
                    Console.ForegroundColor = ConsoleColor.White;
                    ConsoleKeyInfo kt = Console.ReadKey();
                    switch (kt.Key)
                    {
                        case ConsoleKey.Tab:
                            pt.pnt1("                                                                ", 6, 44);
                            pt.pnt1("                         ", 6, 45);
                            pt.pnt1("1. Thêm giáo viên    ", 88, 43);
                            pt.pnt1("2. Sửa giáo viên     ", 88, 44);
                            pt.pnt1("3. Xóa giáo viên     ", 88, 45);
                            pt.pnt1("4. Danh sách giáo viên    ", 88, 46);
                            pt.pnt1("5. Để quay lại menu chính", 88, 47);
                            pt.pnt1("6. Để thoát khỏi chương trình", 88, 48);
                            pt.pnt1("Nhấn", 88, 49);
                            Console.ForegroundColor = ConsoleColor.Green;
                            pt.pnt1("H", 93, 49);
                            Console.ForegroundColor = ConsoleColor.White;
                            pt.pnt1("để mở thanh công cụ và", 95, 49);
                            Console.ForegroundColor = ConsoleColor.Green;
                            pt.pnt1("E", 118, 49);
                            Console.ForegroundColor = ConsoleColor.White;
                            pt.pnt1("để tắt", 120, 49);
                            pt.pnt1("", 105, 50);
                            goto chucnang;
                        default:
                            Console.ForegroundColor = ConsoleColor.Red;
                            pt.pnt1("                                                                ", 6, 44);
                            pt.pnt1("                 ", 35, 10);
                            Console.ForegroundColor = ConsoleColor.White;
                            goto tengv;
                    }
                }
                if (gvbll.KTtengv(tengvmoi))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    pt.pnt1("Tên giáo viên không chứa số ! Nhấn phím bất kỳ để nhập lại ", 6, 44);
                    Console.ForegroundColor = ConsoleColor.White;
                    ConsoleKeyInfo kt = Console.ReadKey();
                    switch (kt.Key)
                    {
                        case ConsoleKey.Tab:
                            pt.pnt1("                                                                ", 6, 44);
                            pt.pnt1("                         ", 6, 45);
                            pt.pnt1("1. Thêm giáo viên    ", 88, 43);
                            pt.pnt1("2. Sửa giáo viên     ", 88, 44);
                            pt.pnt1("3. Xóa giáo viên     ", 88, 45);
                            pt.pnt1("4. Danh sách giáo viên    ", 88, 46);
                            pt.pnt1("5. Để quay lại menu chính", 88, 47);
                            pt.pnt1("6. Để thoát khỏi chương trình", 88, 48);
                            pt.pnt1("Nhấn", 88, 49);
                            Console.ForegroundColor = ConsoleColor.Green;
                            pt.pnt1("H", 93, 49);
                            Console.ForegroundColor = ConsoleColor.White;
                            pt.pnt1("để mở thanh công cụ và", 95, 49);
                            Console.ForegroundColor = ConsoleColor.Green;
                            pt.pnt1("E", 118, 49);
                            Console.ForegroundColor = ConsoleColor.White;
                            pt.pnt1("để tắt", 120, 49);
                            pt.pnt1("", 105, 50);
                            goto chucnang;
                        default:
                            Console.ForegroundColor = ConsoleColor.Red;
                            pt.pnt1("                                                                ", 6, 44);
                            pt.pnt1("               ", 35, 10);
                            Console.ForegroundColor = ConsoleColor.White;
                            goto tengv;
                    }
                }
                if (tengvmoi.Length < 4)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    pt.pnt1("Tên giáo viên quá ngắn ! Nhấn phím bất kỳ để nhập lại ", 6, 44);
                    Console.ForegroundColor = ConsoleColor.White;
                    ConsoleKeyInfo kt = Console.ReadKey();
                    switch (kt.Key)
                    {
                        case ConsoleKey.Tab:
                            pt.pnt1("                                                                ", 6, 44);
                            pt.pnt1("                         ", 6, 45);
                            pt.pnt1("1. Thêm giáo viên    ", 88, 43);
                            pt.pnt1("2. Sửa giáo viên     ", 88, 44);
                            pt.pnt1("3. Xóa giáo viên     ", 88, 45);
                            pt.pnt1("4. Danh sách giáo viên    ", 88, 46);
                            pt.pnt1("5. Để quay lại menu chính", 88, 47);
                            pt.pnt1("6. Để thoát khỏi chương trình", 88, 48);
                            pt.pnt1("Nhấn", 88, 49);
                            Console.ForegroundColor = ConsoleColor.Green;
                            pt.pnt1("H", 93, 49);
                            Console.ForegroundColor = ConsoleColor.White;
                            pt.pnt1("để mở thanh công cụ và", 95, 49);
                            Console.ForegroundColor = ConsoleColor.Green;
                            pt.pnt1("E", 118, 49);
                            Console.ForegroundColor = ConsoleColor.White;
                            pt.pnt1("để tắt", 120, 49);
                            pt.pnt1("", 105, 50);
                            goto chucnang;
                        default:
                            Console.ForegroundColor = ConsoleColor.Red;
                            pt.pnt1("                                                                ", 6, 44);
                            pt.pnt1("            ", 35, 10);
                            Console.ForegroundColor = ConsoleColor.White;
                            goto tengv;
                    }
                }
                pt.pnt1("", 66, 10);
                Console.BackgroundColor = ConsoleColor.Black;
                pt.pnt1("                    ", 66, 10);
            diachi:
                pt.pnt1("", 66, 10); diachimoi = Console.ReadLine();
                if (diachimoi == "")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    pt.pnt1("Địa chỉ không thể rỗng ! Nhấn phím bất kỳ để nhập lại ", 6, 44);
                    Console.ForegroundColor = ConsoleColor.White;
                    ConsoleKeyInfo kt = Console.ReadKey();
                    switch (kt.Key)
                    {
                        case ConsoleKey.Tab:
                            pt.pnt1("                                                                ", 6, 44);
                            pt.pnt1("                         ", 6, 45);
                            pt.pnt1("1. Thêm giáo viên    ", 88, 43);
                            pt.pnt1("2. Sửa giáo viên     ", 88, 44);
                            pt.pnt1("3. Xóa giáo viên     ", 88, 45);
                            pt.pnt1("4. Danh sách giáo viên    ", 88, 46);
                            pt.pnt1("5. Để quay lại menu chính", 88, 47);
                            pt.pnt1("6. Để thoát khỏi chương trình", 88, 48);
                            pt.pnt1("Nhấn", 88, 49);
                            Console.ForegroundColor = ConsoleColor.Green;
                            pt.pnt1("H", 93, 49);
                            Console.ForegroundColor = ConsoleColor.White;
                            pt.pnt1("để mở thanh công cụ và", 95, 49);
                            Console.ForegroundColor = ConsoleColor.Green;
                            pt.pnt1("E", 118, 49);
                            Console.ForegroundColor = ConsoleColor.White;
                            pt.pnt1("để tắt", 120, 49);
                            pt.pnt1("", 105, 50);
                            goto chucnang;
                        default:
                            Console.ForegroundColor = ConsoleColor.Red;
                            pt.pnt1("                                                                ", 6, 44);
                            pt.pnt1("                  ", 66, 10);
                            Console.ForegroundColor = ConsoleColor.White;
                            goto diachi;
                    }
                }
                if (diachimoi.Length < 4)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    pt.pnt1("Địa chỉ quá ngắn ! Nhấn phím bất kỳ để nhập lại ", 6, 44);
                    Console.ForegroundColor = ConsoleColor.White;
                    ConsoleKeyInfo kt = Console.ReadKey();
                    switch (kt.Key)
                    {
                        case ConsoleKey.Tab:
                            pt.pnt1("                                                                ", 6, 44);
                            pt.pnt1("                         ", 6, 45);
                            pt.pnt1("1. Thêm giáo viên    ", 88, 43);
                            pt.pnt1("2. Sửa giáo viên     ", 88, 44);
                            pt.pnt1("3. Xóa giáo viên     ", 88, 45);
                            pt.pnt1("4. Danh sách giáo viên    ", 88, 46);
                            pt.pnt1("5. Để quay lại menu chính", 88, 47);
                            pt.pnt1("6. Để thoát khỏi chương trình", 88, 48);
                            pt.pnt1("Nhấn", 88, 49);
                            Console.ForegroundColor = ConsoleColor.Green;
                            pt.pnt1("H", 93, 49);
                            Console.ForegroundColor = ConsoleColor.White;
                            pt.pnt1("để mở thanh công cụ và", 95, 49);
                            Console.ForegroundColor = ConsoleColor.Green;
                            pt.pnt1("E", 118, 49);
                            Console.ForegroundColor = ConsoleColor.White;
                            pt.pnt1("để tắt", 120, 49);
                            pt.pnt1("", 105, 50);
                            goto chucnang;
                        default:
                            Console.ForegroundColor = ConsoleColor.Red;
                            pt.pnt1("                                                                ", 6, 44);
                            pt.pnt1("                  ", 66, 10);
                            Console.ForegroundColor = ConsoleColor.White;
                            goto diachi;
                    }
                }
                pt.pnt1("", 112, 10);
                Console.BackgroundColor = ConsoleColor.Black;
                pt.pnt1("                  ", 112, 10);
            sdtgv:
                pt.pnt1("", 112, 10); sdtgvmoi = Console.ReadLine();
                if (sdtgvmoi == "")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    pt.pnt1("Số điện thoại không thể rỗng ! Nhấn phím bất kỳ để nhập lại ", 6, 44);
                    Console.ForegroundColor = ConsoleColor.White;
                    ConsoleKeyInfo kt = Console.ReadKey();
                    switch (kt.Key)
                    {
                        case ConsoleKey.Tab:
                            pt.pnt1("                                                                ", 6, 44);
                            pt.pnt1("                         ", 6, 45);
                            pt.pnt1("1. Thêm giáo viên    ", 88, 43);
                            pt.pnt1("2. Sửa giáo viên     ", 88, 44);
                            pt.pnt1("3. Xóa giáo viên     ", 88, 45);
                            pt.pnt1("4. Danh sách giáo viên    ", 88, 46);
                            pt.pnt1("5. Để quay lại menu chính", 88, 47);
                            pt.pnt1("6. Để thoát khỏi chương trình", 88, 48);
                            pt.pnt1("Nhấn", 88, 49);
                            Console.ForegroundColor = ConsoleColor.Green;
                            pt.pnt1("H", 93, 49);
                            Console.ForegroundColor = ConsoleColor.White;
                            pt.pnt1("để mở thanh công cụ và", 95, 49);
                            Console.ForegroundColor = ConsoleColor.Green;
                            pt.pnt1("E", 118, 49);
                            Console.ForegroundColor = ConsoleColor.White;
                            pt.pnt1("để tắt", 120, 49);
                            pt.pnt1("", 105, 50);
                            goto chucnang;
                        default:
                            Console.ForegroundColor = ConsoleColor.Red;
                            pt.pnt1("                                                                ", 6, 44);
                            pt.pnt1("                  ", 112, 10);
                            Console.ForegroundColor = ConsoleColor.White;
                            goto sdtgv;
                    }
                }
                for (int i = 0; i < sdtgvmoi.Length; ++i)
                {
                    if (sdtgvmoi[i] != '0' && sdtgvmoi[i] != '1' && sdtgvmoi[i] != '2' && sdtgvmoi[i] != '3' && sdtgvmoi[i] != '4' && sdtgvmoi[i] != '5' && sdtgvmoi[i] != '6' && sdtgvmoi[i] != '7' && sdtgvmoi[i] != '8' && sdtgvmoi[i] != '9')
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        pt.pnt1("Số điện thoại không chứa ký tự ! Nhấn phím bất kỳ để nhập lại ", 6, 44);
                        Console.ForegroundColor = ConsoleColor.White;
                        ConsoleKeyInfo kt = Console.ReadKey();
                        switch (kt.Key)
                        {
                            case ConsoleKey.Tab:
                                pt.pnt1("                                                                ", 6, 44);
                                pt.pnt1("                         ", 6, 45);
                                pt.pnt1("1. Thêm giáo viên    ", 88, 43);
                                pt.pnt1("2. Sửa giáo viên     ", 88, 44);
                                pt.pnt1("3. Xóa giáo viên     ", 88, 45);
                                pt.pnt1("4. Danh sách giáo viên    ", 88, 46);
                                pt.pnt1("5. Để quay lại menu chính", 88, 47);
                                pt.pnt1("6. Để thoát khỏi chương trình", 88, 48);
                                pt.pnt1("Nhấn", 88, 49);
                                Console.ForegroundColor = ConsoleColor.Green;
                                pt.pnt1("H", 93, 49);
                                Console.ForegroundColor = ConsoleColor.White;
                                pt.pnt1("để mở thanh công cụ và", 95, 49);
                                Console.ForegroundColor = ConsoleColor.Green;
                                pt.pnt1("E", 118, 49);
                                Console.ForegroundColor = ConsoleColor.White;
                                pt.pnt1("để tắt", 120, 49);
                                pt.pnt1("", 105, 50);
                                goto chucnang;
                            default:
                                Console.ForegroundColor = ConsoleColor.Red;
                                pt.pnt1("                                                                         ", 6, 44);
                                pt.pnt1("                    ", 112, 10);
                                Console.ForegroundColor = ConsoleColor.White;
                                goto sdtgv;
                        }
                    }
                }
                if (sdtgvmoi.Length < 9 || sdtgvmoi.Length > 11)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    pt.pnt1("Số điện thoại luôn lớn hơn 9 số và nhỏ hơn 11 số ! Nhấn phím bất kỳ để nhập lại ", 6, 44);
                    Console.ForegroundColor = ConsoleColor.White;
                    ConsoleKeyInfo kt = Console.ReadKey();
                    switch (kt.Key)
                    {
                        case ConsoleKey.Tab:
                            pt.pnt1("                                                                ", 6, 44);
                            pt.pnt1("                         ", 6, 45);
                            pt.pnt1("1. Thêm giáo viên    ", 88, 43);
                            pt.pnt1("2. Sửa giáo viên     ", 88, 44);
                            pt.pnt1("3. Xóa giáo viên     ", 88, 45);
                            pt.pnt1("4. Danh sách giáo viên    ", 88, 46);
                            pt.pnt1("5. Để quay lại menu chính", 88, 47);
                            pt.pnt1("6. Để thoát khỏi chương trình", 88, 48);
                            pt.pnt1("Nhấn", 88, 49);
                            Console.ForegroundColor = ConsoleColor.Green;
                            pt.pnt1("H", 93, 49);
                            Console.ForegroundColor = ConsoleColor.White;
                            pt.pnt1("để mở thanh công cụ và", 95, 49);
                            Console.ForegroundColor = ConsoleColor.Green;
                            pt.pnt1("E", 118, 49);
                            Console.ForegroundColor = ConsoleColor.White;
                            pt.pnt1("để tắt", 120, 49);
                            pt.pnt1("", 105, 50);
                            goto chucnang;
                        default:
                            Console.ForegroundColor = ConsoleColor.Red;
                     pt.pnt1("                                                                                  ", 6, 44);
                            pt.pnt1("                  ", 112, 10);
                            Console.ForegroundColor = ConsoleColor.White;
                            goto sdtgv;
                    }

                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                pt.pnt1("Mã giáo viên không tồn tại ! Nhấn phím bất kỳ để nhập lại ", 6, 44);
                Console.ForegroundColor = ConsoleColor.White;
                ConsoleKeyInfo kt = Console.ReadKey();
                switch (kt.Key)
                {
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        pt.pnt1("                                                                ", 6, 44);
                        pt.pnt1("            ", 39, 14);
                        Console.ForegroundColor = ConsoleColor.White;
                        goto suagv;
                }
            }
            GVCN gv = new GVCN(magvs, tengvmoi, diachimoi, sdtgvmoi);
            pt.pnt1("Nhấn Enter để lưu và sửa tiếp", 6, 44);
            pt.pnt1("Nhấn Tab để quay lại", 6, 45);
        label2: ConsoleKeyInfo kttt = Console.ReadKey();
            switch (kttt.Key)
            {
                case ConsoleKey.Enter:
                    gvbll.Xoagv(magvs);
                    gvbll.Themgv(gv);
                    pt.pnt1("                             ", 6, 44);
                    pt.pnt1("                           ", 6, 45);

                    pt.pnt1("              ", 39, 14);
                    pt.pnt1("                 ", 35, 10);
                    pt.pnt1("                 ", 66, 10);
                    pt.pnt1("                 ", 112, 10);

                    for (int i = 25; i < 34; i++)
                    {
                        pt.pnt1("           ", 27, i);
                        pt.pnt1("                ", 46, i);
                        pt.pnt1("             ", 77, i);
                        pt.pnt1("              ", 102, i);
                    }
                    pt.pnt1("1. Thêm giáo viên    ", 88, 43);
                    pt.pnt1("2. Sửa giáo viên     ", 88, 44);
                    pt.pnt1("3. Xóa giáo viên     ", 88, 45);
                    pt.pnt1("4. Danh sách giáo viên    ", 88, 46);
                    pt.pnt1("5. Để quay lại menu chính", 88, 47);
                    pt.pnt1("6. Để thoát khỏi chương trình", 88, 48);
                    pt.pnt1("Nhấn", 88, 49);
                    Console.ForegroundColor = ConsoleColor.Green;
                    pt.pnt1("H", 93, 49);
                    Console.ForegroundColor = ConsoleColor.White;
                    pt.pnt1("để mở thanh công cụ và", 95, 49);
                    Console.ForegroundColor = ConsoleColor.Green;
                    pt.pnt1("E", 118, 49);
                    Console.ForegroundColor = ConsoleColor.White;
                    pt.pnt1("để tắt", 120, 49);
                    pt.pnt1("", 105, 50);
                    goto danhsach;
                case ConsoleKey.Tab:
                    goto chucnang;
                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    pt.pnt1("Bạn nhập sai ! Xin nhập lại ", 6, 46);
                    Console.ForegroundColor = ConsoleColor.White;
                    goto label2;
            }
        #endregion

        #region Xóa giáo viên
        xoagv:
            string magvx;
            do
            {
                try
                {
                    pt.pnt1("", 69, 13); magvx = Console.ReadLine();
                }
                catch
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    pt.pnt1("Mã giáo viên sai ! Nhấn phím bất kỳ để nhập lại ", 6, 44);
                    Console.ForegroundColor = ConsoleColor.White;
                    ConsoleKeyInfo kt = Console.ReadKey();
                    switch (kt.Key)
                    {
                        default:
                            Console.ForegroundColor = ConsoleColor.Red;
                            pt.pnt1("                                                                ", 6, 44);
                            pt.pnt1("                 ", 69, 13);
                            Console.ForegroundColor = ConsoleColor.White;
                            goto xoagv;
                    }
                }
                if (gvbll.KTmagv(magvx) == false)
                {
                    pt.pnt1("Nhấn Enter để lưu và xóa tiếp", 6, 44);
                    pt.pnt1("Nhấn Tab để quay lại", 6, 45);
                label: ConsoleKeyInfo kt = Console.ReadKey();
                    switch (kt.Key)
                    {
                        case ConsoleKey.Enter:
                            gvbll.Xoagv(magvx);
                            pt.pnt1("                                 ", 6, 44);
                            pt.pnt1("                         ", 6, 45);

                            pt.pnt1("           ", 69, 13);
                             
                            for(int i = 25; i < 40; i++)
                            {
                                pt.pnt1("         ", 27, i);
                                pt.pnt1("                 ", 46, i);
                                pt.pnt1("                ", 77, i);
                                pt.pnt1("              ", 102, i);

                            }
                            pt.pnt1("1. Thêm giáo viên    ", 88, 43);
                            pt.pnt1("2. Sửa giáo viên     ", 88, 44);
                            pt.pnt1("3. Xóa giáo viên     ", 88, 45);
                            pt.pnt1("4. Danh sách giáo viên    ", 88, 46);
                            pt.pnt1("5. Để quay lại menu chính", 88, 47);
                            pt.pnt1("6. Để thoát khỏi chương trình", 88, 48);
                            pt.pnt1("Nhấn", 88, 49);
                            Console.ForegroundColor = ConsoleColor.Green;
                            pt.pnt1("H", 93, 49);
                            Console.ForegroundColor = ConsoleColor.White;
                            pt.pnt1("để mở thanh công cụ và", 95, 49);
                            Console.ForegroundColor = ConsoleColor.Green;
                            pt.pnt1("E", 118, 49);
                            Console.ForegroundColor = ConsoleColor.White;
                            pt.pnt1("để tắt", 120, 49);
                            pt.pnt1("", 105, 50);
                            goto danhsach;
                        case ConsoleKey.Tab:
                            pt.pnt1("                                                                        ", 6, 44);
                            pt.pnt1("                           ", 6, 45);
                            pt.pnt1("                        ", 58, 8);
                            pt.pnt1("━━━━━━━━━━━━━━━━━━━━━━━━━", 58, 8);
                            pt.pnt1("               ", 18, 10);
                            pt.pnt1("               ", 50, 10);
                            pt.pnt1("               ", 89, 10);
                            pt.pnt1("                 ", 18, 12);
                            pt.pnt1("                   ", 55, 10);
                            pt.pnt1("                   ", 93, 10);
                            pt.pnt1("                   ", 18, 10);
                            pt.pnt1("                                 ", 10, 14);

                            pt.pnt1("                                   ", 40, 13);
                            pt.pnt1("   ", 105, 50);
                            pt.pnt1("1. Thêm giáo viên    ", 88, 43);
                            pt.pnt1("2. Sửa giáo viên     ", 88, 44);
                            pt.pnt1("3. Xóa giáo viên     ", 88, 45);
                            pt.pnt1("4. Danh sách giáo viên    ", 88, 46);
                            pt.pnt1("5. Để quay lại menu chính", 88, 47);
                            pt.pnt1("6. Để thoát khỏi chương trình", 88, 48);
                            pt.pnt1("Nhấn", 88, 49);
                            Console.ForegroundColor = ConsoleColor.Green;
                            pt.pnt1("H", 93, 49);
                            Console.ForegroundColor = ConsoleColor.White;
                            pt.pnt1("để mở thanh công cụ và", 95, 49);
                            Console.ForegroundColor = ConsoleColor.Green;
                            pt.pnt1("E", 118, 49);
                            Console.ForegroundColor = ConsoleColor.White;
                            pt.pnt1("để tắt", 120, 49);
                            pt.pnt1("", 105, 50);
                            goto chucnang;
                        default:
                            Console.ForegroundColor = ConsoleColor.Red;
                            pt.pnt1(" Bạn nhập sai ! Xin nhập lại ", 6, 46);
                            Console.ForegroundColor = ConsoleColor.White;
                            goto label;
                    }
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    pt.pnt1("Mã giáo viên không tồn tại ! Nhấn phím bất kỳ để nhập lại ", 6, 44);
                    pt.pnt1("Tab để quay lại ", 6, 45);
                    Console.ForegroundColor = ConsoleColor.White;
                    ConsoleKeyInfo kt = Console.ReadKey();
                    switch (kt.Key)
                    {
                        case ConsoleKey.Tab:
                            pt.pnt1("                                                                        ", 6, 44);
                            pt.pnt1("                 ", 6, 45);
                            pt.pnt1("                        ", 58, 8);
                            pt.pnt1("━━━━━━━━━━━━━━━━━━━━━━━━━", 58, 8);
                            pt.pnt1("               ", 18, 10);
                            pt.pnt1("               ", 50, 10);
                            pt.pnt1("               ", 89, 10);
                            pt.pnt1("                 ", 18, 12);
                            pt.pnt1("                   ", 55, 10);
                            pt.pnt1("                   ", 93, 10);
                            pt.pnt1("                   ", 18, 10);
                            pt.pnt1("                                 ", 10, 14);

                            pt.pnt1("                                   ", 40, 13);
                            pt.pnt1("1. Thêm giáo viên    ", 88, 43);
                            pt.pnt1("2. Sửa giáo viên     ", 88, 44);
                            pt.pnt1("3. Xóa giáo viên     ", 88, 45);
                            pt.pnt1("4. Danh sách giáo viên    ", 88, 46);
                            pt.pnt1("5. Để quay lại menu chính", 88, 47);
                            pt.pnt1("6. Để thoát khỏi chương trình", 88, 48);
                            pt.pnt1("Nhấn", 88, 49);
                            Console.ForegroundColor = ConsoleColor.Green;
                            pt.pnt1("H", 93, 49);
                            Console.ForegroundColor = ConsoleColor.White;
                            pt.pnt1("để mở thanh công cụ và", 95, 49);
                            Console.ForegroundColor = ConsoleColor.Green;
                            pt.pnt1("E", 118, 49);
                            Console.ForegroundColor = ConsoleColor.White;
                            pt.pnt1("để tắt", 120, 49);
                            pt.pnt1("", 105, 50);
                            goto chucnang;
                        default:
                            pt.pnt1("      ", 69, 13);
                            pt.pnt1("                                                                        ", 6, 44);
                            pt.pnt1("                 ", 6, 45);
                            goto xoagv;
                    }
                }
            } while (true);
        #endregion

        #region Hiển thị danh sách giáo viên
        hiengv:
            pt.pnt1("                                              TRƯỜNG ĐẠI HỌC SƯ PHẠM KỸ THUẬT HƯNG YÊN ", 0, 1);
            pt.pnt1("                                                      KHOA CÔNG NGHỆ THÔNG TIN ", 1, 2);
            pt.pnt1("                                                     ------- ○○○○ -------", 3, 3);
            pt.pnt1("━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━", 18, 5);
            for (int i = 6; i < 39; i++)
            {
                pt.pnt1("┃", 18, i);
                pt.pnt1("┃", 117, i);
            }

            pt.pnt1("┏", 18, 5);
            pt.pnt1("┗", 18, 39);
            pt.pnt1("┓", 117, 5);
            pt.pnt1("┛", 117, 39);

            pt.pnt1("┣", 18, 9);
            pt.pnt1("┣", 18, 11);
            pt.pnt1("┫", 117, 9);
            pt.pnt1("┫", 117, 11);

            Console.ForegroundColor = ConsoleColor.Magenta;
            pt.pnt1("Designed by TeamT ™", 5, 51);
            Console.ForegroundColor = ConsoleColor.White;
            pt.pnt1("━━━━━━━━━━━━━━━━━━━━━┳━━━━━━━━━━━━━━━━━━━━━━━━┳━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┳━━━━━━━━━━━━━━━━━━━━", 19, 9);
            pt.pnt1("━━━━━━━━━━━━━━━━━━━━━┻━━━━━━━━━━━━━━━━━━━━━━━━┻━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┻━━━━━━━━━━━━━━━━━━━━", 19, 11);

            pt.pnt1("━━━━━━━━━━━━━━━━━━━━━┻━━━━━━━━━━━━━━━━━━━━━━━━┻━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┻━━━━━━━━━━━━━━━━━━━━", 19, 39);


            for (int i = 10; i < 39; i++)
            {
                pt.pnt1("┃", 40, i);
                pt.pnt1("┃", 65, i);
                pt.pnt1("┃", 96, i);
            }

            pt.pnt1("DANH SÁCH GIÁO VIÊN CHỦ NHIỆM", 52, 7);
            pt.pnt1("Mã giáo viên", 24, 10);
            pt.pnt1("Tên giáo viên", 45, 10);
            pt.pnt1(" Địa chỉ ", 76, 10);
            pt.pnt1("Số điện thoại", 100, 10);
            Console.ForegroundColor = ConsoleColor.Green;
            pt.pnt1("→ 4. Danh sách giáo viên", 85, 41);
            Console.ForegroundColor = ConsoleColor.White;
            pt.pnt1(" Nhấn Tab để quay lại 1 ", 85, 42);
            pt.pnt1(" Nhấn Esc để thoát", 85, 43);
            pt.pnt1(" Bạn chọn phím : ", 85, 44);
            List<GVCN> hs = gvbll.LayDlgv();
            int slhs = 0;
            for (int i = 0; i < hs.Count; ++i)
            {
                slhs++;
            }
            if (slhs > 0)
            {
                int sd = 10;
                int st;
                if (slhs >= sd)
                {
                    st = slhs % sd == 0 ? slhs / sd : slhs / sd + 1;
                }
                else
                {
                    st = 1;
                }
                int t = 1;
                Console.WriteLine();
            label1:
                vetrang(t);
                pt.pnt1("", 18, 40); Console.WriteLine("{0}/{1} trang ◄ {2} ►", t, st, t);
                goto label;
            label:
                pt.pnt1("", 103, 44);
                ConsoleKeyInfo p;
                p = Console.ReadKey();
                switch (p.Key)
                {
                    case ConsoleKey.LeftArrow:
                        if (t == 1)
                        {
                            t = 1;
                            goto label;
                        }
                        else
                        {
                            t--;
                            goto label1;
                        }
                    case ConsoleKey.RightArrow:
                        if (t == st)
                        {
                            t = st;
                            goto label;
                        }
                        else
                        {
                            t++;
                            goto label1;
                        }
                    case ConsoleKey.Tab:
                        Console.Clear();
                        themgv();
                        break;
                    case ConsoleKey.Escape:
                        return;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        pt.pnt1("Bạn nhập sai ! Xin nhập lại ", 85, 45);
                        Console.ForegroundColor = ConsoleColor.White;
                        goto label;

                }

            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                pt.pnt1(" Hệ thống không có giáo viên. Nhấn Tab để quay lại ", 10, 42);
                Console.ForegroundColor = ConsoleColor.White;
            label: ConsoleKeyInfo ktkt = Console.ReadKey();
                switch (ktkt.Key)
                {
                    case ConsoleKey.Tab:
                        pt.pnt1("                                                                ", 6, 44);
                        pt.pnt1("                         ", 6, 45);
                        pt.pnt1("1. Thêm giáo viên    ", 88, 43);
                        pt.pnt1("2. Sửa giáo viên     ", 88, 44);
                        pt.pnt1("3. Xóa giáo viên     ", 88, 45);
                        pt.pnt1("4. Danh sách giáo viên    ", 88, 46);
                        pt.pnt1("5. Để quay lại menu chính", 88, 47);
                        pt.pnt1("6. Để thoát khỏi chương trình", 88, 48);
                        pt.pnt1("Nhấn", 88, 49);
                        Console.ForegroundColor = ConsoleColor.Green;
                        pt.pnt1("H", 93, 49);
                        Console.ForegroundColor = ConsoleColor.White;
                        pt.pnt1("để mở thanh công cụ và", 95, 49);
                        Console.ForegroundColor = ConsoleColor.Green;
                        pt.pnt1("E", 118, 49);
                        Console.ForegroundColor = ConsoleColor.White;
                        pt.pnt1("để tắt", 120, 49);
                        pt.pnt1("", 105, 50);
                        goto chucnang;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        pt.pnt1("Nhập sai xin nhập lại ", 10, 43);
                        Console.ForegroundColor = ConsoleColor.White;
                        goto label;
                }
            }
            #endregion
        }
        public void vetrang(int chisotrang)
        {
            for (int i = 13; i < 37; ++i)
            {
                pt.pnt1("          ", 24, i);
                pt.pnt1("                   ", 45, i);
                pt.pnt1("                   ", 76, i);
                pt.pnt1("           ", 100, i);
            }
            int a = 13;
            int d1 = 0;
            int sodong = 13;
            List<GVCN> gv = gvbll.LayDlgv();
            int d = (chisotrang - 1) * sodong + 1;
            for (int i = 0; i < gv.Count; ++i)
            {
                d1++;
                if ((d1 >= d) && (d1 <= chisotrang * 13))
                {
                    pt.pnt1(gv[i].Magv, 24, a);
                    pt.pnt1(gv[i].Tengv, 45, a);
                    pt.pnt1(gv[i].Diachi, 76, a);
                    pt.pnt1(gv[i].Sdtgv, 100, a);
                    a = a + 2;
                }
            }
        }
        #endregion
    }
}
