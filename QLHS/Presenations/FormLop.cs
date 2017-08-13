using System;
using System.Linq;
using System.Text;
using QLHS.Utility;
using QLHS.Presenations;
using QLHS.Entities;
using QLHS.DataAccessLayer;
using QLHS.Business.Components;
namespace QLHS.Presenations
{
    public class FormLop
    {
        Paint pt = new Paint(140, 55);
        LopBLL lopbll = new LopBLL();
        GVCNBLL gvbll = new GVCNBLL();
        LopDAL lopda = new LopDAL();
        public static ThongTinPM tt = new ThongTinPM();
        public static MenuChinh mn = new MenuChinh();
        public static FormBangDiem fbd = new FormBangDiem();
        public static FormGVCN fgv = new FormGVCN();
        public static FormHS fhs = new FormHS();
        public static FormTimKiem ff = new FormTimKiem();
        public static FormMonHoc fmh = new FormMonHoc();
        public static FormThongKe ftk = new FormThongKe();
        #region Quản lý lớp
        public void Themlop()
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
            pt.pnt1("┣", 18, 22);
            pt.pnt1("┣", 18, 24);

            pt.pnt1("┫", 133, 15);
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

            pt.pnt1("DANH SÁCH LỚP HỌC ", 61, 20);
            pt.pnt1(" Mã Lớp ", 25, 23);
            pt.pnt1(" Tên Lớp", 47, 23);
            pt.pnt1(" Sĩ số", 78, 23);
            pt.pnt1(" Mã GVCN ", 102, 23);

           
            pt.pnt1("1. Thêm lớp học", 88, 43);
            pt.pnt1("2. Sửa lớp học", 88, 44);
            pt.pnt1("3. Xóa lớp học", 88, 45);
            pt.pnt1("4. Để quay lại menu chính", 88, 46);
            pt.pnt1("5. Để thoát khỏi chương trình", 88, 47);
            pt.pnt1("Nhấn", 88, 48);
            Console.ForegroundColor = ConsoleColor.Green;
            pt.pnt1("H", 93, 48);
            Console.ForegroundColor = ConsoleColor.White;
            pt.pnt1("để mở thanh công cụ và", 95, 48);
            Console.ForegroundColor = ConsoleColor.Green;
            pt.pnt1("E", 118, 48);
            Console.ForegroundColor = ConsoleColor.White;
            pt.pnt1("để tắt", 120, 48);
            // lấy danh sách lớp học
   danhsach: List<Lop> lop = lopbll.LayDlLop();
            lopda.BackUp(lop);
            int a = 25;
            int tmp = 0;
            for (int i = 0; i < lop.Count; ++i)
            {
                if (tmp < 9)
                {
                    pt.pnt1(lop[i].Malop, 25, a);
                    pt.pnt1(lop[i].Tenlop, 47, a);
                    pt.pnt1(Convert.ToString(lop[i].Siso), 78, a);
                    pt.pnt1(lop[i].Magv, 102, a);
                    tmp++;
                    a = a + 2;
                }
                else break;
            }
            pt.pnt1("Chọn chức năng : ", 88, 49);
   chucnang: ConsoleKeyInfo ktktt = Console.ReadKey();
            Console.ForegroundColor = ConsoleColor.White;
            switch (ktktt.KeyChar)
            {
                case '1':
                    pt.pnt1(" Thêm lớp học ", 58, 8);
                    pt.pnt1("               ", 88, 43);
                    Console.ForegroundColor = ConsoleColor.Green;
                    pt.pnt1("→ 1. Thêm lớp học", 88, 43);
                    Console.ForegroundColor = ConsoleColor.White;
                    pt.pnt1("    ", 105, 49);
                    pt.pnt1("                             ", 88, 50);
                    pt.pnt1("                             ", 10, 14);
                    pt.pnt1("                            ", 47, 13);
                    pt.pnt1("                             ", 50, 13);

                    pt.pnt1("                   ", 55, 10);
                    pt.pnt1("                  ", 93, 10);
                    pt.pnt1("                 ", 18, 10);

                    pt.pnt1("Mã lớp : ", 18, 10);
                    pt.pnt1("Tên lớp :", 50, 10);
                    pt.pnt1("Sĩ số : ", 89, 10);
                    pt.pnt1("Mã GVCN: ", 18, 12);
                    goto Themlop;
                case '2':
                    pt.pnt1(" Sửa lớp học  ", 58, 8);
                    pt.pnt1("              ", 18, 10);
                    pt.pnt1("              ", 50, 10);
                    pt.pnt1("              ", 89, 10);
                    pt.pnt1("              ", 18, 12);
                    pt.pnt1("                             ", 50, 13);
                    pt.pnt1("                              ", 88, 50);
                    pt.pnt1("     ", 105, 49);
                    pt.pnt1("Tên lớp :", 55, 10);
                    pt.pnt1("Sĩ số : ", 93, 10);
                    pt.pnt1("Mã GVCN   : ", 18, 10);
                    pt.pnt1("1. Thêm lớp học", 88, 43);
                    Console.ForegroundColor = ConsoleColor.Green;
                    pt.pnt1("→ 2. Sửa lớp học", 88, 44);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    pt.pnt1("Nhập mã lớp cần sửa : ", 10, 14);
                    Console.ForegroundColor = ConsoleColor.White;
                    goto Sualop;
                case '3':
                    pt.pnt1(" Xoá lớp học ", 59, 8);
                    pt.pnt1("              ", 18, 10);
                    pt.pnt1("              ", 50, 10);
                    pt.pnt1("              ", 89, 10);
                    pt.pnt1("              ", 18, 12);
                    pt.pnt1("                                 ", 10, 14);
                    pt.pnt1("   ", 105, 49);
                    pt.pnt1("1. Thêm lớp học", 88, 43);
                    pt.pnt1("2. Sửa lớp học", 88, 44);
                    Console.ForegroundColor = ConsoleColor.Green;
                    pt.pnt1("→ 3. Xóa lớp học", 88, 45);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    pt.pnt1("Nhập mã lớp cần xóa : ", 50, 13);
                    Console.ForegroundColor = ConsoleColor.White;
                    goto Xoalop;
                case '4':
                    Console.Clear();
                    mn.MenuChinh1();
                    break;
                case '5':
                    Environment.Exit(0);
                    break;
                case 'G':
                    Console.Clear();
                    fgv.themgv();
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
                case 'S':
                    Console.Clear();
                    fhs.themhs();
                    break;
                case 'H':
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    pt.pnt1("G : Quản lý Giáo Viên", 4, 6);
                    pt.pnt1("D : Quản lý Điểm", 30, 6);
                    pt.pnt1("M : Quản lý Môn học", 52, 6);
                    pt.pnt1("T : Tìm kiếm", 76, 6);
                    pt.pnt1("K : Thống kê", 96, 6);
                    pt.pnt1("S : Quản lý học sinh", 114, 6);
                    pt.pnt1("                           ", 88, 51);
                    pt.pnt1("  ", 105, 49);
                    pt.pnt1("", 105, 49);
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
                    pt.pnt1("  ", 105, 49);
                    pt.pnt1("", 105, 49);
                    goto chucnang;
                case '6':
                    Environment.Exit(0); break;
                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    pt.pnt1("      ", 105, 49);
                    pt.pnt1("Bạn nhập sai xin nhập lại", 88, 50);
                    pt.pnt1("", 105, 49);
                    Console.ForegroundColor = ConsoleColor.White;
                    goto chucnang;
            }
        #region Thêm lớp 
        // thêm vào dữ liệu của một lớp
        Themlop:
            string malop, tenlop, magv;
            string siso;
            pt.pnt1("", 27, 10); malop = Console.ReadLine();
            if (malop == "")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                pt.pnt1(" Mã lớp không được rỗng ! Nhấn phím bất kỳ để nhập lại", 6, 44);
                pt.pnt1(" Nhấn Tab để quay lại", 6, 45);
                Console.ForegroundColor = ConsoleColor.White;
                ConsoleKeyInfo kt = Console.ReadKey();
                switch (kt.Key)
                {
                    case ConsoleKey.Tab:
                        pt.pnt1("                                                       ", 6, 44);
                        pt.pnt1("                            ", 6, 45);
                        pt.pnt1("                    ", 58, 8);
                        pt.pnt1("━━━━━━━━━━━━━━━━━━━━━━━━━", 58, 8);
                        pt.pnt1("              ", 18, 10);
                        pt.pnt1("              ", 50, 10);
                        pt.pnt1("              ", 89, 10);
                        pt.pnt1("              ", 18, 12);

                        pt.pnt1("1. Thêm lớp học   ", 88, 43);
                        pt.pnt1("2. Sửa lớp học   ", 88, 44);
                        pt.pnt1("3. Xóa lớp học   ", 88, 45);
                        pt.pnt1("4. Để quay lại menu chính   ", 88, 46);
                        pt.pnt1("5. Để thoát khỏi chương trình   ", 88, 47);
                        pt.pnt1("Nhấn", 88, 48);
                        Console.ForegroundColor = ConsoleColor.Green;
                        pt.pnt1("H", 93, 48);
                        Console.ForegroundColor = ConsoleColor.White;
                        pt.pnt1("để mở thanh công cụ và", 95, 48);
                        Console.ForegroundColor = ConsoleColor.Green;
                        pt.pnt1("E", 118, 48);
                        Console.ForegroundColor = ConsoleColor.White;
                        pt.pnt1("để tắt", 120, 48);
                        pt.pnt1("", 105, 49);
                        goto chucnang;
                    default:
                        pt.pnt1("                                                            ", 6, 44);
                        pt.pnt1("                                 ", 6, 45);
                        goto Themlop;
                }
            }
            for (int i = 0; i < malop.Length; ++i)
            {
                if (malop[i] != '1' && malop[i] != '2' && malop[i] != '3' && malop[i] != '4' && malop[i] != '5' && malop[i] != '6' && malop[i] != '7' && malop[i] != '8' && malop[i] != 9 && malop[i] != 'L')
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    pt.pnt1(" Mã lớp nhập sai định dạng ! Nhấn phím bất kỳ để nhập lại", 6, 44);
                    pt.pnt1(" Nhấn H để xem định dạng của mã lớp", 6, 45);
                    Console.ForegroundColor = ConsoleColor.White;
                    ConsoleKeyInfo kt = Console.ReadKey();
                    switch (kt.Key)
                    {
                        case ConsoleKey.H:
                            Console.Clear();
                            tt.dinhdangml();
                            break;
                        default:
                            pt.pnt1("                                                             ", 6, 44);
                            pt.pnt1("                                         ", 6, 45);
                            pt.pnt1("    ", 27, 10);
                            goto Themlop;
                    }
                }
            }
            if (lopbll.KTmalop(malop))
            {
                if (lopbll.demlop() < 10)
                {
                tenlop:
                    pt.pnt1("", 59, 10); tenlop = Console.ReadLine();
                    if (lopbll.KTtenlop(tenlop))
                    {
                        if (tenlop == "")
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            pt.pnt1(" Tên lớp không được rỗng ! Nhấn phím bất kỳ để nhập lại", 6, 44);
                            pt.pnt1(" Hoặc nhấn Tab để quay lại", 6, 45);
                            Console.ForegroundColor = ConsoleColor.White;
                            ConsoleKeyInfo kt = Console.ReadKey();
                            switch (kt.Key)
                            {
                                case ConsoleKey.Tab:
                                    pt.pnt1("                                                              ", 6, 44);
                                    pt.pnt1("                                                              ", 6, 45);
                                    pt.pnt1("1. Thêm lớp học   ", 88, 43);
                                    pt.pnt1("2. Sửa lớp học    ", 88, 44);
                                    pt.pnt1("3. Xóa lớp học    ", 88, 45);
                                    pt.pnt1("4. Để quay lại menu chính", 88, 46);
                                    pt.pnt1("5. Để thoát khỏi chương trình", 88, 47);
                                    pt.pnt1("Nhấn", 88, 48);
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    pt.pnt1("H", 93, 48);
                                    Console.ForegroundColor = ConsoleColor.White;
                                    pt.pnt1("để mở thanh công cụ và", 95, 48);
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    pt.pnt1("E", 118, 48);
                                    Console.ForegroundColor = ConsoleColor.White;
                                    pt.pnt1("để tắt", 120, 48);
                                    pt.pnt1("", 105, 49);
                                    goto chucnang;
                                default:
                                    pt.pnt1("                                                         ", 6, 44);
                                    pt.pnt1("                                 ", 6, 45);
                                    goto tenlop;
                            }
                        }
                        if (tenlop.Length <= 1)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            pt.pnt1(" Tên lớp quá ngắn ! Nhấn phím bất kỳ để nhập lại", 6, 44);
                            Console.ForegroundColor = ConsoleColor.White;
                            ConsoleKeyInfo kt = Console.ReadKey();
                            switch (kt.Key)
                            {
                                default:
                                    pt.pnt1("                                                   ", 6, 44);
                                    pt.pnt1("     ", 59, 10);
                                    goto tenlop;
                            }

                        }
                        string s = "ABCDEFGHIJKLMNOPQWXYZ";
                        for (int i = 0; i < tenlop.Length; ++i)
                        {
                            if (tenlop[i] != '1' && tenlop[i] != '2' && tenlop[i] != '3' && tenlop[i] != '4' && tenlop[i] != '5' && tenlop[i] != s[0] && tenlop[i] != s[1] && tenlop[i] != s[2] && tenlop[i] != s[3] && tenlop[i] != s[4] && tenlop[i] != s[5] && tenlop[i] != s[6] && tenlop[i] != s[7] && tenlop[i] != s[8] && tenlop[i] != s[9] && tenlop[i] != s[10] && tenlop[i] != s[11] && tenlop[i] != s[12] && tenlop[i] != s[13] && tenlop[i] != s[14] && tenlop[i] != s[15] && tenlop[i] != s[16] && tenlop[i] != s[17] && tenlop[i] != s[18] && tenlop[i] != s[19])
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                pt.pnt1(" Sai định dạng tên lớp ! Nhấn phím bất kỳ để nhập lại", 6, 44);
                                pt.pnt1(" Nhấn H để xem định dạng hợp lệ ", 6, 45);
                                Console.ForegroundColor = ConsoleColor.White;
                                ConsoleKeyInfo kt = Console.ReadKey();
                                switch (kt.Key)
                                {
                                    case ConsoleKey.H:
                                        Console.Clear();
                                        tt.dinhdangtl();
                                        break;
                                    default:
                                        pt.pnt1("                                                         ", 6, 44);
                                        pt.pnt1("                                                         ", 6, 45);
                                        pt.pnt1("     ", 59, 10);
                                        goto tenlop;
                                }
                            }
                        }
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        pt.pnt1(" Tên lớp đã tồn tại ! Nhấn phím bất kỳ để nhập lại ", 6, 44);
                        Console.ForegroundColor = ConsoleColor.White;
                        ConsoleKeyInfo kt = Console.ReadKey();
                        switch (kt.Key)
                        {
                            default:
                                pt.pnt1("                                                                          ", 6, 44);
                                pt.pnt1("          ", 59, 10);
                                goto tenlop;
                        }

                    }
                siso:
                    pt.pnt1("", 99, 10); siso = Console.ReadLine();
                    if (siso == "")
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        pt.pnt1(" Sĩ số không thể bằng 0 ! Nhấn phím bất kỳ để nhập lại", 6, 44);
                        pt.pnt1(" Hoặc nhấn Tab để quay lại ", 6, 45);
                        Console.ForegroundColor = ConsoleColor.White;
                        ConsoleKeyInfo kt = Console.ReadKey();
                        switch (kt.Key)
                        {
                            case ConsoleKey.Tab:
                                pt.pnt1("                                                              ", 6, 44);
                                pt.pnt1("                                                              ", 6, 45);
                                pt.pnt1("1. Thêm lớp học   ", 88, 43);
                                pt.pnt1("2. Sửa lớp học    ", 88, 44);
                                pt.pnt1("3. Xóa lớp học    ", 88, 45);
                                pt.pnt1("4. Để quay lại menu chính", 88, 46);
                                pt.pnt1("5. Để thoát khỏi chương trình", 88, 47);
                                pt.pnt1("Nhấn", 88, 48);
                                Console.ForegroundColor = ConsoleColor.Green;
                                pt.pnt1("H", 93, 48);
                                Console.ForegroundColor = ConsoleColor.White;
                                pt.pnt1("để mở thanh công cụ và", 95, 48);
                                Console.ForegroundColor = ConsoleColor.Green;
                                pt.pnt1("E", 118, 48);
                                Console.ForegroundColor = ConsoleColor.White;
                                pt.pnt1("để tắt", 120, 48);
                                pt.pnt1("", 105, 49);
                                goto chucnang;
                            default:
                                pt.pnt1("                                                                 ", 6, 44);
                                pt.pnt1("                                                    ", 6, 45);
                                pt.pnt1("          ", 99, 10);
                                goto siso;
                        }
                    }
                    for (int i = 0; i < siso.Length; ++i)
                    {
                        if (siso[i] != '0' && siso[i] != '1' && siso[i] != '2' && siso[i] != '3' && siso[i] != '4' && siso[i] != '5' && siso[i] != '6' && siso[i] != '7' && siso[i] != '8' && siso[i] != '9')
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            pt.pnt1(" Sĩ số không chứa ký tự ! Nhấn phím bất kỳ để nhập lại", 6, 44);
                            Console.ForegroundColor = ConsoleColor.White;
                            ConsoleKeyInfo kt = Console.ReadKey();
                            switch (kt.Key)
                            {
                                default:
                                    pt.pnt1("                                                            ", 6, 44);
                                    pt.pnt1("          ", 99, 10);
                                    goto siso;
                            }
                        }
                    }
                    if (Convert.ToByte(siso) < 25 || Convert.ToByte(siso) > 36)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        pt.pnt1(" Sĩ số của lớp tối thiểu là 25 và tối đa là 36 ! Nhấn phím bất kỳ để nhập lại", 6, 44);
                        Console.ForegroundColor = ConsoleColor.White;
                        ConsoleKeyInfo kt = Console.ReadKey();
                        switch (kt.Key)
                        {
                            default:
                                pt.pnt1("                                                                             ", 6, 44);
                                pt.pnt1("          ", 99, 10);
                                goto siso;
                        }
                    }
                magv:
                    List<GVCN> gv = gvbll.LayDlgv();
                    pt.pnt1("", 29, 12); magv = Console.ReadLine();
                    if (lopbll.KTmagvL(magv))
                    {
                        if (magv == "")
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            pt.pnt1(" Mã giáo viên không rỗng ! Nhấn phím bất kỳ để nhập lại ", 6, 44);
                            Console.ForegroundColor = ConsoleColor.White;
                            ConsoleKeyInfo kt = Console.ReadKey();
                            switch (kt.Key)
                            {
                                default:
                                    pt.pnt1("                                                       ", 6, 44);
                                    goto magv;
                            }

                        }
                        if (gvbll.KTmagv(magv))
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            pt.pnt1(" Mã giáo viên không có trong hệ thống ! Nhấn phím bất kỳ để nhập lại ", 6, 44);
                            Console.ForegroundColor = ConsoleColor.White;
                            ConsoleKeyInfo kt = Console.ReadKey();
                            switch (kt.Key)
                            {
                                default:
                                    pt.pnt1("                                                                    ", 6, 44);
                                    pt.pnt1("       ", 29, 12);
                                    goto magv;
                            }
                        }
                        for (int i = 0; i < magv.Length; ++i)
                        {
                            if (magv[i] != '1' && magv[i] != '2' && magv[i] != '3' && magv[i] != '4' && magv[i] != '5' && magv[i] != '6' && magv[i] != '7' && magv[i] != '8' && magv[i] != '9' && magv[i] != 'G' && magv[i] != 'V')
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                pt.pnt1(" Mã giáo viên sai định dạng ! Nhấn phím bất kỳ để nhập lại ", 6, 44);
                                Console.ForegroundColor = ConsoleColor.White;
                                ConsoleKeyInfo kt = Console.ReadKey();
                                switch (kt.Key)
                                {
                                    default:
                                        pt.pnt1("                                                                        ", 6, 44);
                                        pt.pnt1("       ", 29, 12);
                                        goto magv;
                                }


                            }
                        }
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        pt.pnt1(" Giáo viên đã có lớp ! Nhấn phím bất kỳ để nhập lại ", 6, 44);
                        Console.ForegroundColor = ConsoleColor.White;
                        ConsoleKeyInfo kt = Console.ReadKey();
                        switch (kt.Key)
                        {
                            default:
                                pt.pnt1("                                                                          ", 6, 44);
                                pt.pnt1("          ", 29, 12);
                                goto magv;
                        }
                    }
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    pt.pnt1(" Lớp học tối đa là 10 lớp ! Nhấn phím bất kỳ để nhập lại ", 6, 44);
                    Console.ForegroundColor = ConsoleColor.White;
                    ConsoleKeyInfo kt = Console.ReadKey();
                    switch (kt.Key)
                    {
                        default:
                            pt.pnt1("                                                                    ", 6, 44);
                            pt.pnt1("       ", 27, 10);
                            goto Themlop;
                    }
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                pt.pnt1(" Mã lớp đã tồn tại ! Nhấn phím bất kỳ để nhập lại ", 6, 44);
                Console.ForegroundColor = ConsoleColor.White;
                ConsoleKeyInfo kt = Console.ReadKey();
                switch (kt.Key)
                {
                    default:
                        pt.pnt1("                                                       ", 6, 44);
                        pt.pnt1("       ", 27, 10);
                        goto Themlop;
                }
            }
            Lop l = new Lop(malop, tenlop, Convert.ToByte(siso), magv);
            pt.pnt1(" Nhấn Enter để nhập tiếp ", 6, 44);
            pt.pnt1(" Nhấn Tab để quay lại", 6, 45);
        label: ConsoleKeyInfo ktkt = Console.ReadKey();
            switch (ktkt.Key)
            {
                case ConsoleKey.Enter:
                    Console.Clear();
                    lopbll.ThemLop(l);
                    Themlop();
                    break;
                case ConsoleKey.Tab:
                    Console.Clear();
                    Themlop();
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    pt.pnt1("      ", 105, 45);
                    pt.pnt1(" Nhập sai xin nhập lại ", 6, 46);
                    Console.ForegroundColor = ConsoleColor.White;
                    pt.pnt1("", 105, 45);
                    goto label;
            }
        #endregion

        #region Sửa lớp
        Sualop:
            lopda.BackUp(lop);
        Sualop1: string malops, magvmoi, tenlopmoi;
            string sisomoi;

            pt.pnt1("", 34, 14); malops = Console.ReadLine();
            if (malops == "")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                pt.pnt1(" Mã lớp không rỗng ! Nhấn phím bất kỳ để nhập lại", 6, 44);
                pt.pnt1(" Nhấn Tab để quay lại", 6, 45);
                Console.ForegroundColor = ConsoleColor.White;
                ConsoleKeyInfo kt = Console.ReadKey();
                switch (kt.Key)
                {
                    case ConsoleKey.Tab:
                        pt.pnt1("                                                   ", 6, 44);
                        pt.pnt1("                                           ", 6, 45);
                        pt.pnt1("                    ", 58, 8);
                        pt.pnt1("━━━━━━━━━━━━━━━━━━━━━━━━━", 58, 8);
                        pt.pnt1("              ", 18, 10);
                        pt.pnt1("              ", 50, 10);
                        pt.pnt1("              ", 89, 10);
                        pt.pnt1("              ", 18, 12);
                        pt.pnt1("                                 ", 10, 14);
                        pt.pnt1("1. Thêm lớp học  ", 88, 43);
                        pt.pnt1("2. Sửa lớp học   ", 88, 44);
                        pt.pnt1("3. Xóa lớp học   ", 88, 45);
                        pt.pnt1("4. Để quay lại menu chính", 88, 46);
                        pt.pnt1("5. Để thoát khỏi chương trình", 88, 47);
                        pt.pnt1("Nhấn", 88, 48);
                        Console.ForegroundColor = ConsoleColor.Green;
                        pt.pnt1("H", 93, 48);
                        Console.ForegroundColor = ConsoleColor.White;
                        pt.pnt1("để mở thanh công cụ và", 95, 48);
                        Console.ForegroundColor = ConsoleColor.Green;
                        pt.pnt1("E", 118, 48);
                        Console.ForegroundColor = ConsoleColor.White;
                        pt.pnt1("để tắt", 120, 48);
                        pt.pnt1("", 105, 49);
                        goto chucnang;
                    default:
                        pt.pnt1("                                                   ", 6, 44);
                        pt.pnt1("                                           ", 6, 45);
                        goto Sualop1;
                }
            }
            if (lopbll.KTmalop(malops) == false)
            {
                List<Lop> list = lopbll.LayDlLop();
                while (list != null)
                {
                    for (int i = 0; i < list.Count; ++i)
                    {
                        if (list[i].Malop == malops)
                        {
                            pt.pnt1(list[i].Magv, 32, 10);
                            pt.pnt1(list[i].Tenlop, 65, 10);
                            pt.pnt1(Convert.ToString(list[i].Siso), 102, 10);
                        }
                    }
                    break;
                }
                pt.pnt1("", 32, 10);
                Console.ReadKey();
                Console.BackgroundColor = ConsoleColor.Black;
                pt.pnt1("            ", 32, 10);
            magv:
                List<GVCN> gv = gvbll.LayDlgv();
                pt.pnt1("", 32, 10); magvmoi = Console.ReadLine();
                if (magvmoi == "")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    pt.pnt1(" Mã giáo viên không rỗng ! Nhấn phím bất kỳ để nhập lại ", 6, 44);
                    Console.ForegroundColor = ConsoleColor.White;
                    ConsoleKeyInfo kt = Console.ReadKey();
                    switch (kt.Key)
                    {
                        default:
                            pt.pnt1("                                                       ", 6, 44);
                            pt.pnt1("       ", 32, 10);
                            goto magv;
                    }

                }
                if (gvbll.KTmagv(magvmoi))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    pt.pnt1(" Mã giáo viên không có trong hệ thống ! Nhấn phím bất kỳ để nhập lại ", 6, 44);
                    Console.ForegroundColor = ConsoleColor.White;
                    ConsoleKeyInfo kt = Console.ReadKey();
                    switch (kt.Key)
                    {
                        default:
                            pt.pnt1("                                                                    ", 6, 44);
                            pt.pnt1("       ", 32, 10);
                            goto magv;
                    }
                }
                for (int i = 0; i < magvmoi.Length; ++i)
                {
                    if (magvmoi[i] != '1' && magvmoi[i] != '2' && magvmoi[i] != '3' && magvmoi[i] != '4' && magvmoi[i] != '5' && magvmoi[i] != '6' && magvmoi[i] != '7' && magvmoi[i] != '8' && magvmoi[i] != '9' && magvmoi[i] != 'G' && magvmoi[i] != 'V'&&magvmoi[i]!='0')
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        pt.pnt1(" Mã giáo viên sai định dạng ! Nhấn phím bất kỳ để nhập lại ", 6, 44);
                        Console.ForegroundColor = ConsoleColor.White;
                        ConsoleKeyInfo kt = Console.ReadKey();
                        switch (kt.Key)
                        {
                            default:
                                pt.pnt1("                                                                        ", 6, 44);
                                pt.pnt1("       ", 32, 12);
                                goto magv;
                        }
                    }
                }

                pt.pnt1("", 65, 10);
                Console.ReadKey();
                Console.BackgroundColor = ConsoleColor.Black;
                pt.pnt1("            ", 65, 10);
            tenlop:
                pt.pnt1("", 65, 10); tenlopmoi = Console.ReadLine();
                if (tenlopmoi == "")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    pt.pnt1(" Tên lớp không được rỗng ! Nhấn phím bất kỳ để nhập lại", 6, 44);
                    pt.pnt1(" Hoặc nhấn Tab để quay lại", 6, 45);
                    Console.ForegroundColor = ConsoleColor.White;
                    ConsoleKeyInfo kt = Console.ReadKey();
                    switch (kt.Key)
                    {
                        case ConsoleKey.Tab:
                            pt.pnt1("                                                              ", 6, 44);
                            pt.pnt1("                                                              ", 6, 45);
                            pt.pnt1("1. Thêm lớp học   ", 88, 43);
                            pt.pnt1("2. Sửa lớp học    ", 88, 44);
                            pt.pnt1("3. Xóa lớp học    ", 88, 45);
                            pt.pnt1("4. Để quay lại menu chính", 88, 46);
                            pt.pnt1("5. Để thoát khỏi chương trình", 88, 47);
                            pt.pnt1("Nhấn", 88, 48);
                            Console.ForegroundColor = ConsoleColor.Green;
                            pt.pnt1("H", 93, 48);
                            Console.ForegroundColor = ConsoleColor.White;
                            pt.pnt1("để mở thanh công cụ và", 95, 48);
                            Console.ForegroundColor = ConsoleColor.Green;
                            pt.pnt1("E", 118, 48);
                            Console.ForegroundColor = ConsoleColor.White;
                            pt.pnt1("để tắt", 120, 48);
                            pt.pnt1("", 105, 49);
                            goto chucnang;
                        default:
                            pt.pnt1("                                                       ", 6, 44);
                            pt.pnt1("                                 ", 6, 45);
                            goto tenlop;
                    }
                }
                if (tenlopmoi.Length <= 1)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    pt.pnt1(" Tên lớp quá ngắn ! Nhấn phím bất kỳ để nhập lại", 6, 44);
                    Console.ForegroundColor = ConsoleColor.White;
                    ConsoleKeyInfo kt = Console.ReadKey();
                    switch (kt.Key)
                    {
                        default:
                            pt.pnt1("                                                   ", 6, 45);
                            pt.pnt1("     ", 65, 10);
                            goto tenlop;
                    }

                }
                string s = "ABCDEFGHIJKLMNOPQWXYZ";
                for (int i = 0; i < tenlopmoi.Length; ++i)
                {
                    if (tenlopmoi[i] != '1' && tenlopmoi[i] != '2' && tenlopmoi[i] != '3' && tenlopmoi[i] != '4' && tenlopmoi[i] != '5' && tenlopmoi[i] != s[0] && tenlopmoi[i] != s[1] && tenlopmoi[i] != s[2] && tenlopmoi[i] != s[3] && tenlopmoi[i] != s[4] && tenlopmoi[i] != s[5] && tenlopmoi[i] != s[6] && tenlopmoi[i] != s[7] && tenlopmoi[i] != s[8] && tenlopmoi[i] != s[9] && tenlopmoi[i] != s[10] && tenlopmoi[i] != s[11] && tenlopmoi[i] != s[12] && tenlopmoi[i] != s[13] && tenlopmoi[i] != s[14] && tenlopmoi[i] != s[15] && tenlopmoi[i] != s[16] && tenlopmoi[i] != s[17] && tenlopmoi[i] != s[18] && tenlopmoi[i] != s[19])
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        pt.pnt1(" Sai định dạng tên lớp ! Nhấn phím bất kỳ để nhập lại", 6, 44);
                        pt.pnt1(" Nhấn H để xem định dạng hợp lệ ", 6, 45);
                        Console.ForegroundColor = ConsoleColor.White;
                        ConsoleKeyInfo kt = Console.ReadKey();
                        switch (kt.Key)
                        {
                            case ConsoleKey.H:
                                Console.Clear();
                                tt.dinhdangtl();
                                break;
                            default:
                                pt.pnt1("                                                         ", 6, 44);
                                pt.pnt1("                                                         ", 6, 45);
                                pt.pnt1("        ", 65, 10);
                                goto tenlop;
                        }
                    }
                }

                pt.pnt1("", 102, 10);
                Console.ReadKey();
                Console.BackgroundColor = ConsoleColor.Black;
                pt.pnt1("          ", 102, 10);
            siso:
                pt.pnt1("", 102, 10); sisomoi = Console.ReadLine();
                if (sisomoi == "")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    pt.pnt1(" Sĩ số không thể rỗng ! Nhấn phím bất kỳ để nhập lại", 6, 44);
                    pt.pnt1(" Hoặc nhấn Tab để quay lại ", 6, 45);
                    Console.ForegroundColor = ConsoleColor.White;
                    ConsoleKeyInfo kt = Console.ReadKey();
                    switch (kt.Key)
                    {
                        case ConsoleKey.Tab:
                            pt.pnt1("                                                              ", 6, 44);
                            pt.pnt1("                                                              ", 6, 45);
                            pt.pnt1("1. Thêm lớp học   ", 88, 43);
                            pt.pnt1("2. Sửa lớp học    ", 88, 44);
                            pt.pnt1("3. Xóa lớp học    ", 88, 45);
                            pt.pnt1("4. Để quay lại menu chính", 88, 46);
                            pt.pnt1("5. Để thoát khỏi chương trình", 88, 47);
                            pt.pnt1("Nhấn", 88, 48);
                            Console.ForegroundColor = ConsoleColor.Green;
                            pt.pnt1("H", 93, 48);
                            Console.ForegroundColor = ConsoleColor.White;
                            pt.pnt1("để mở thanh công cụ và", 95, 48);
                            Console.ForegroundColor = ConsoleColor.Green;
                            pt.pnt1("E", 118, 48);
                            Console.ForegroundColor = ConsoleColor.White;
                            pt.pnt1("để tắt", 120, 48);
                            pt.pnt1("", 105, 49);
                            goto chucnang;
                        default:
                            pt.pnt1("                                                                 ", 6, 44);
                            pt.pnt1("                                                    ", 6, 45);
                            pt.pnt1("          ", 102, 10);
                            goto siso;
                    }
                }
                if (Convert.ToByte(sisomoi) < 25 || Convert.ToByte(sisomoi) > 36)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    pt.pnt1(" Sĩ số của lớp tối thiểu là 25 và tối đa là 36 ! Nhấn phím bất kỳ để nhập lại", 6, 44);
                    Console.ForegroundColor = ConsoleColor.White;
                    ConsoleKeyInfo kt = Console.ReadKey();
                    switch (kt.Key)
                    {
                        default:
                            pt.pnt1("                                                                             ", 6, 44);
                            pt.pnt1("          ", 102, 10);
                            goto siso;
                    }
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                pt.pnt1(" Mã lớp không có trong hệ thống ! Nhấn phím bất kỳ để nhập lại ", 6, 44);
                Console.ForegroundColor = ConsoleColor.White;
                ConsoleKeyInfo kt = Console.ReadKey();
                switch (kt.Key)
                {
                    default:
                        pt.pnt1("                                                                          ", 6, 44);
                        pt.pnt1("          ", 32, 14);
                        goto Sualop1;
                }

            }
            Lop lm = new Lop(malops, tenlopmoi, Convert.ToByte(sisomoi), magvmoi);
            pt.pnt1(" Nhấn Enter để sửa tiếp", 6, 44);
            pt.pnt1(" Nhấn Tab để quay lại ", 6, 45);
        den: ConsoleKeyInfo key = Console.ReadKey();
            switch (key.Key)
            {
                case ConsoleKey.Enter:
                    lopbll.XoaLop(malops);
                    lopbll.ThemLop(lm);
                    Console.BackgroundColor = ConsoleColor.Black;
                    pt.pnt1("      ", 34, 14);
                    pt.pnt1("          ", 32, 10);
                    pt.pnt1("          ", 65, 10);
                    pt.pnt1("          ", 102, 10);

                    pt.pnt1("                   ", 55, 10);
                    pt.pnt1("                  ", 93, 10);
                    pt.pnt1("                 ", 18, 10);

                    pt.pnt1("                          ", 6, 44);
                    pt.pnt1("                          ", 6, 45);
                    pt.pnt1("                          ", 10, 14);

                    pt.pnt1("                                                              ", 6, 44);
                    pt.pnt1("                                                              ", 6, 45);
                    pt.pnt1("                                                              ", 6, 46);
                    pt.pnt1("1. Thêm lớp học   ", 88, 43);
                    pt.pnt1("2. Sửa lớp học    ", 88, 44);
                    pt.pnt1("3. Xóa lớp học    ", 88, 45);
                    pt.pnt1("4. Để quay lại menu chính", 88, 46);
                    pt.pnt1("5. Để thoát khỏi chương trình", 88, 47);
                    pt.pnt1("Nhấn", 88, 48);
                    Console.ForegroundColor = ConsoleColor.Green;
                    pt.pnt1("H", 93, 48);
                    Console.ForegroundColor = ConsoleColor.White;
                    pt.pnt1("để mở thanh công cụ và", 95, 48);
                    Console.ForegroundColor = ConsoleColor.Green;
                    pt.pnt1("E", 118, 48);
                    Console.ForegroundColor = ConsoleColor.White;
                    pt.pnt1("để tắt", 120, 48);
                    pt.pnt1("", 105, 49);
                    for (int i = 25; i < 42; ++i)
                    {
                        pt.pnt1("     ", 25, i);
                        pt.pnt1("     ", 47, i);
                        pt.pnt1("        ", 78, i);
                        pt.pnt1("       ", 102, i);
                    }
                    goto danhsach;
                case ConsoleKey.Tab:
                    pt.pnt1("                                                              ", 6, 44);
                    pt.pnt1("                                                              ", 6, 45);
                    pt.pnt1("                                                              ", 6, 46);
                    pt.pnt1("1. Thêm lớp học   ", 88, 43);
                    pt.pnt1("2. Sửa lớp học    ", 88, 44);
                    pt.pnt1("3. Xóa lớp học    ", 88, 45);
                    pt.pnt1("4. Để quay lại menu chính", 88, 46);
                    pt.pnt1("5. Để thoát khỏi chương trình", 88, 47);
                    pt.pnt1("Nhấn", 88, 48);
                    Console.ForegroundColor = ConsoleColor.Green;
                    pt.pnt1("H", 93, 48);
                    Console.ForegroundColor = ConsoleColor.White;
                    pt.pnt1("để mở thanh công cụ và", 95, 48);
                    Console.ForegroundColor = ConsoleColor.Green;
                    pt.pnt1("E", 118, 48);
                    Console.ForegroundColor = ConsoleColor.White;
                    pt.pnt1("để tắt", 120, 48);
                    pt.pnt1("", 105, 49);
                    goto chucnang;
                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    pt.pnt1(" Bạn nhập sai xin nhập lại : ", 6, 46);
                    goto den;
            }
        #endregion

        #region Xóa lơp
        Xoalop:
            string malopx;
            do
            {
                try
                {
                    pt.pnt1("", 73, 13); malopx = Console.ReadLine();
                }
                catch
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    pt.pnt1(" Mã lớp sai ! Nhấn phím bất kỳ để nhập lại ", 6, 44);
                    Console.ForegroundColor = ConsoleColor.White;
                    ConsoleKeyInfo kt = Console.ReadKey();
                    switch (kt.Key)
                    {
                        default:
                            pt.pnt1("                                                                          ", 6, 44);
                            pt.pnt1("          ", 73, 13);
                            goto Xoalop;
                    }
                }
                if (lopbll.KTmalop(malopx) == false)
                {
                    pt.pnt1(" Nhấn Enter để xóa tiếp ", 6, 44);
                    pt.pnt1(" Nhấn Tab để quay lại ", 6, 45);
                    ConsoleKeyInfo ktktkt = Console.ReadKey();
                    switch (ktktkt.Key)
                    {
                        case ConsoleKey.Enter:
                            lopbll.XoaLop(malopx);
                            Console.BackgroundColor = ConsoleColor.Black;
                            pt.pnt1("            ", 27, 10);
                            pt.pnt1("            ", 59, 10);
                            pt.pnt1("            ", 99, 10);
                            pt.pnt1("            ", 32, 12);

                            pt.pnt1("                          ", 6, 44);
                            pt.pnt1("                            ", 6, 45);

                            for (int i = 25; i < 40; ++i)
                            {
                                pt.pnt1("       ", 25, i);
                                pt.pnt1("        ", 47, i);
                                pt.pnt1("        ", 78, i);
                                pt.pnt1("         ", 102, i);
                            }
                            pt.pnt1("1. Thêm lớp học   ", 88, 43);
                            pt.pnt1("2. Sửa lớp học    ", 88, 44);
                            pt.pnt1("3. Xóa lớp học    ", 88, 45);
                            pt.pnt1("4. Để quay lại menu chính", 88, 46);
                            pt.pnt1("5. Để thoát khỏi chương trình", 88, 47);
                            pt.pnt1("Nhấn", 88, 48);
                            Console.ForegroundColor = ConsoleColor.Green;
                            pt.pnt1("H", 93, 48);
                            Console.ForegroundColor = ConsoleColor.White;
                            pt.pnt1("để mở thanh công cụ và", 95, 48);
                            Console.ForegroundColor = ConsoleColor.Green;
                            pt.pnt1("E", 118, 48);
                            Console.ForegroundColor = ConsoleColor.White;
                            pt.pnt1("để tắt", 120, 48);
                            pt.pnt1("    ", 73, 13);
                            goto danhsach;
                        case ConsoleKey.Tab:
                            pt.pnt1("                                                              ", 6, 44);
                            pt.pnt1("                                                              ", 6, 45);
                            pt.pnt1("                             ", 50, 13);
                            pt.pnt1("                    ", 58, 8);
                            pt.pnt1("━━━━━━━━━━━━━━━━━━━━━━━━━", 58, 8);
                            pt.pnt1("1. Thêm lớp học   ", 88, 43);
                            pt.pnt1("2. Sửa lớp học    ", 88, 44);
                            pt.pnt1("3. Xóa lớp học    ", 88, 45);
                            pt.pnt1("4. Để quay lại menu chính", 88, 46);
                            pt.pnt1("5. Để thoát khỏi chương trình", 88, 47);
                            pt.pnt1("Nhấn", 88, 48);
                            Console.ForegroundColor = ConsoleColor.Green;
                            pt.pnt1("H", 93, 48);
                            Console.ForegroundColor = ConsoleColor.White;
                            pt.pnt1("để mở thanh công cụ và", 95, 48);
                            Console.ForegroundColor = ConsoleColor.Green;
                            pt.pnt1("E", 118, 48);
                            Console.ForegroundColor = ConsoleColor.White;
                            pt.pnt1("để tắt", 120, 48);
                            pt.pnt1("", 105, 49);
                            goto chucnang;
                    }
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    pt.pnt1(" Mã không tồn tại ! Nhấn phím bất kỳ để nhập lại ", 6, 44);
                    pt.pnt1(" Hoặc nhấn Tab để quay lại ", 6, 45);
                    Console.ForegroundColor = ConsoleColor.White;
                    ConsoleKeyInfo kt = Console.ReadKey();
                    switch (kt.Key)
                    {
                        case ConsoleKey.Tab:
                            pt.pnt1("                                                              ", 6, 44);
                            pt.pnt1("                                                              ", 6, 45);
                            pt.pnt1("                             ", 50, 13);
                            pt.pnt1("                    ", 58, 8);
                            pt.pnt1("━━━━━━━━━━━━━━━━━━━━━━━━━", 58, 8);
                            pt.pnt1("1. Thêm lớp học   ", 88, 43);
                            pt.pnt1("2. Sửa lớp học    ", 88, 44);
                            pt.pnt1("3. Xóa lớp học    ", 88, 45);
                            pt.pnt1("4. Để quay lại menu chính", 88, 46);
                            pt.pnt1("5. Để thoát khỏi chương trình", 88, 47);
                            pt.pnt1("Nhấn", 88, 48);
                            Console.ForegroundColor = ConsoleColor.Green;
                            pt.pnt1("H", 93, 48);
                            Console.ForegroundColor = ConsoleColor.White;
                            pt.pnt1("để mở thanh công cụ và", 95, 48);
                            Console.ForegroundColor = ConsoleColor.Green;
                            pt.pnt1("E", 118, 48);
                            Console.ForegroundColor = ConsoleColor.White;
                            pt.pnt1("để tắt", 120, 48);
                            pt.pnt1("", 105, 49);
                            goto chucnang;
                        default:
                            pt.pnt1("                                                       ", 6, 44);
                            pt.pnt1("                                                       ", 6, 45);
                            pt.pnt1("          ", 73, 13);
                            goto Xoalop;
                    }
                }
            } while (true);
            #endregion

        }
        #endregion
    }
}
