using System;
using System.Linq;
using System.Text;
using QLHS.Entities;
using QLHS.Utility;
using QLHS.Business.Components;
using QLHS.DataAccessLayer;
namespace QLHS.Presenations
{
   public class FormMonHoc
    {
        Paint pt = new Paint(140, 55);
        public static MenuChinh mn = new MenuChinh();
        MonHocBLL mhbll = new MonHocBLL();
        MonHocDAL mhda = new MonHocDAL();
        public static FormBangDiem fbd = new FormBangDiem();
        public static FormGVCN fgv = new FormGVCN();
        public static FormHS fhs = new FormHS();
        public static FormTimKiem ff = new FormTimKiem();
        public static FormLop flh = new FormLop();
        public static FormThongKe ftk = new FormThongKe();

        #region Chức nănng quản lý môn học
        public void themmh()
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
            pt.pnt1(" Thêm môn học ", 59, 8);
            pt.pnt1("━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━", 27, 18);
            for (int i = 19; i < 42; i++)
            {
                pt.pnt1("┃", 27, i);
                pt.pnt1("┃", 105, i);
            }

            pt.pnt1("┏", 27, 18);
            pt.pnt1("┗", 27, 42);
            pt.pnt1("┓", 105, 18);
            pt.pnt1("┛", 105, 42);

            pt.pnt1("┣", 4, 15);
            pt.pnt1("┣", 27, 22);
            pt.pnt1("┣", 27, 24);

            pt.pnt1("┫", 133, 15);
            pt.pnt1("┫", 105, 22);
            pt.pnt1("┫", 105, 24);

            Console.ForegroundColor = ConsoleColor.Magenta;
            pt.pnt1("Designed by TeamT ™", 5, 51);
            Console.ForegroundColor = ConsoleColor.White;
            pt.pnt1("━━━━━━━━━━━━━━━━━━━━━┳━━━━━━━━━━━━━━━━━━━━━━━━┳━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━", 28, 22);
            pt.pnt1("━━━━━━━━━━━━━━━━━━━━━┻━━━━━━━━━━━━━━━━━━━━━━━━┻━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━", 28, 24);

            pt.pnt1("━━━━━━━━━━━━━━━━━━━━━┻━━━━━━━━━━━━━━━━━━━━━━━━┻━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━", 28, 42);


            for (int i = 23; i < 42; i++)
            {
                pt.pnt1("┃", 49, i);
                pt.pnt1("┃", 74, i);
            }

            pt.pnt1("DANH SÁCH MÔN HỌC ", 61, 20);
            pt.pnt1(" Mã môn ", 34, 23);
            pt.pnt1(" Tên môn", 56, 23);
            pt.pnt1(" Ghi chú", 87, 23);

            pt.pnt1("Mã môn : ", 18, 10);
            pt.pnt1("Tên môn :", 50, 10);
            pt.pnt1("Ghi chú : ", 89, 10);

            pt.pnt1("1. Thêm môn học", 88, 43);
            pt.pnt1("2. Sửa môn học", 88, 44);
            pt.pnt1("3. Xóa môn học", 88, 45);
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

            // Lấy danh sách môn học
            danhsach: List<MonHoc> listmh = mhbll.LayDLMH();
            mhda.BackUp(listmh);
            int a = 25;
            int tmp = 0;
            for (int i = 0; i < listmh.Count; ++i)
            {
                if (tmp < 9)
                {
                    {
                        pt.pnt1(listmh[i].Mamon, 37, a);
                        pt.pnt1(listmh[i].Tenmon, 58, a);
                        pt.pnt1(listmh[i].Ghichu, 87, a);
                        tmp++;
                        a += 2;
                    }
                }
                else break;
            }
            pt.pnt1("Chọn chức năng : ", 88, 49);
            chucnang: ConsoleKeyInfo ktktt = Console.ReadKey();
            Console.ForegroundColor = ConsoleColor.White;
            switch (ktktt.KeyChar)
            {
                case '1':
                    pt.pnt1(" Thêm môn học ", 58, 8);
                    pt.pnt1("               ", 88, 43);
                    Console.ForegroundColor = ConsoleColor.Green;
                    pt.pnt1("→ 1. Thêm môn học", 88, 43);
                    Console.ForegroundColor = ConsoleColor.White;
                    pt.pnt1("    ", 105, 49);
                    pt.pnt1("                          ", 88, 50);

                    pt.pnt1("                         ", 10, 10);
                    pt.pnt1("                            ", 40, 12);

                    pt.pnt1("Mã môn : ", 18, 10);
                    pt.pnt1("Tên môn :", 50, 10);
                    pt.pnt1("Ghi chú : ", 89, 10);
                    goto themmh;
                case '2':
                    pt.pnt1(" Sửa môn học   ", 58, 8);
                    pt.pnt1("               ", 88, 43);
                    pt.pnt1("               ", 88, 44);
                    pt.pnt1("1. Thêm môn học", 88, 43);
                    Console.ForegroundColor = ConsoleColor.Green;
                    pt.pnt1("→ 2. Sửa môn học", 88, 44);
                    Console.ForegroundColor = ConsoleColor.White;
                    pt.pnt1("    ", 105, 49);
                    pt.pnt1("                          ", 88, 50);

                    pt.pnt1("                ", 18, 10);
                    pt.pnt1("                ", 50, 10);
                    pt.pnt1("                ", 89, 10);

                    pt.pnt1("                            ", 40, 12);

                    Console.ForegroundColor = ConsoleColor.Yellow;
                    pt.pnt1("Nhập mã môn cần sửa : ", 10, 10);
                    Console.ForegroundColor = ConsoleColor.White;
                    pt.pnt1("Tên môn :", 50, 10);
                    pt.pnt1("Ghi chú : ", 89, 10);
                    goto suamh;
                case '3':
                    pt.pnt1(" Xóa môn học   ", 58, 8);
                    pt.pnt1("               ", 88, 43);
                    pt.pnt1("               ", 88, 44);
                    pt.pnt1("               ", 88, 45);
                    pt.pnt1("1. Thêm môn học", 88, 43);
                    pt.pnt1("1. Sửa môn học", 88, 44);
                    Console.ForegroundColor = ConsoleColor.Green;
                    pt.pnt1("→ 3. Xóa môn học", 88, 45);
                    Console.ForegroundColor = ConsoleColor.White;
                    pt.pnt1("    ", 105, 49);
                    pt.pnt1("                          ", 88, 50);

                    pt.pnt1("                ", 18, 10);
                    pt.pnt1("                ", 50, 10);
                    pt.pnt1("                ", 89, 10);

                    pt.pnt1("                       ", 10, 10);
                    pt.pnt1("                ", 50, 10);
                    pt.pnt1("                ", 89, 10);

                    Console.ForegroundColor = ConsoleColor.Yellow;
                    pt.pnt1("Nhập mã môn cần xóa : ", 40, 12);
                    Console.ForegroundColor = ConsoleColor.White;
                    goto Xoamh;
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
                case 'L':
                    Console.Clear();
                    flh.Themlop();
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
                    pt.pnt1("L : Quản lý Lớp học", 52, 6);
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
            #region thêm môn
            themmh:
            string mamon, tenmon, ghichu;
            pt.pnt1("", 26, 10);mamon = Console.ReadLine();
            if (mamon == "")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                pt.pnt1("Mã môn không rỗng ! Nhấn phím bất kỳ nhập lại ", 6, 44);
                pt.pnt1("Nhấn Tab để quay lại ", 6, 45);
                Console.ForegroundColor = ConsoleColor.White;
                ConsoleKeyInfo kt = Console.ReadKey();
                switch (kt.Key)
                {
                    case ConsoleKey.Tab:
                        pt.pnt1("                                                    ", 6, 44);
                        pt.pnt1("                        ", 6, 45);
                        pt.pnt1("1. Thêm môn học    ", 88, 43);
                        pt.pnt1("2. Sửa môn học", 88, 44);
                        pt.pnt1("3. Xóa môn học", 88, 45);
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
                        pt.pnt1("                                                    ", 6, 44);
                        pt.pnt1("                        ", 6, 45);
                        goto themmh;
                }
            }
            if (mhbll.KTMamon(mamon) == true)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                pt.pnt1("Mã môn đã tồn tại ! Nhấn phím bất kỳ nhập lại ", 6, 44);
                Console.ForegroundColor = ConsoleColor.White;
                ConsoleKeyInfo kt = Console.ReadKey();
                switch (kt.Key)
                {
                    case ConsoleKey.Tab:
                        pt.pnt1("                                                    ", 6, 44);
                        pt.pnt1("1. Thêm môn học    ", 88, 43);
                        pt.pnt1("2. Sửa môn học", 88, 44);
                        pt.pnt1("3. Xóa môn học", 88, 45);
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
                        pt.pnt1("                                                    ", 6, 44);
                        pt.pnt1("           ", 26, 10);
                        goto themmh;
                }
            }
        tenmon:
            pt.pnt1("", 60, 10);tenmon = Console.ReadLine();
            if (tenmon == "")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                pt.pnt1("Tên môn không rỗng ! Nhấn phím bất kỳ nhập lại ", 6, 44);
                pt.pnt1("Nhấn Tab để quay lại ", 6, 45);
                Console.ForegroundColor = ConsoleColor.White;
                ConsoleKeyInfo kt = Console.ReadKey();
                switch (kt.Key)
                {
                    case ConsoleKey.Tab:
                        pt.pnt1("                                                    ", 6, 44);
                        pt.pnt1("                        ", 6, 45);
                        pt.pnt1("1. Thêm môn học    ", 88, 43);
                        pt.pnt1("2. Sửa môn học", 88, 44);
                        pt.pnt1("3. Xóa môn học", 88, 45);
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
                        pt.pnt1("                                                    ", 6, 44);
                        pt.pnt1("                        ", 6, 45);
                        goto tenmon;
                }
            }
            if (tenmon.Length < 4)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                pt.pnt1("Tên môn không đúng ! Nhấn phím bất kỳ nhập lại ", 6, 44);
                Console.ForegroundColor = ConsoleColor.White;
                ConsoleKeyInfo kt = Console.ReadKey();
                switch (kt.Key)
                {
                    case ConsoleKey.Tab:
                        pt.pnt1("                                                    ", 6, 44);
                        pt.pnt1("1. Thêm môn học    ", 88, 43);
                        pt.pnt1("2. Sửa môn học", 88, 44);
                        pt.pnt1("3. Xóa môn học", 88, 45);
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
                        pt.pnt1("                                                    ", 6, 44);
                        pt.pnt1("                        ", 60, 10);
                        goto tenmon;
                }
            }
            ghichu:
            pt.pnt1("", 99, 10);ghichu = Console.ReadLine();
            if (ghichu == "")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                pt.pnt1("Ghi chú không rỗng ! Nhấn phím bất kỳ nhập lại ", 6, 44);
                pt.pnt1("Nhấn Tab để quay lại ", 6, 45);
                Console.ForegroundColor = ConsoleColor.White;
                ConsoleKeyInfo kt = Console.ReadKey();
                switch (kt.Key)
                {
                    case ConsoleKey.Tab:
                        pt.pnt1("                                                    ", 6, 44);
                        pt.pnt1("                        ", 6, 45);
                        pt.pnt1("1. Thêm môn học    ", 88, 43);
                        pt.pnt1("2. Sửa môn học", 88, 44);
                        pt.pnt1("3. Xóa môn học", 88, 45);
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
                        pt.pnt1("                                                    ", 6, 44);
                        pt.pnt1("                        ", 6, 45);
                        goto ghichu;
                }
            }
            for(int i = 0; i < ghichu.Length; ++i)
            {
                if (ghichu.Length < 4 || (ghichu[i] != 'b' && ghichu[i] != 'a' && ghichu[i] != 't' && ghichu[i] != 'u' && ghichu[i] != 'o' && ghichu[i] != 'c' && ghichu[i] != 'h' && ghichu[i] != 'n' &&ghichu[i]!=' '))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    pt.pnt1("Ghi chú là : bắt buộc hoặc tự chọn ! Nhấn phím bất kỳ nhập lại ", 15, 47);
                    Console.ForegroundColor = ConsoleColor.White;
                    ConsoleKeyInfo kt = Console.ReadKey();
                    switch (kt.Key)
                    {
                        default:
                            pt.pnt1("                                                                            ", 15, 47);
                            pt.pnt1("                        ", 99, 10);
                            goto ghichu;
                    }
                }
            }
            MonHoc mh = new MonHoc(mamon, tenmon, ghichu);
            pt.pnt1("Nhấn Enter để lưu và thêm tiếp ", 6, 44);
            pt.pnt1("Nhấn Tab để quay lại", 6, 45);
        label4:
            ConsoleKeyInfo ktt = Console.ReadKey();
            switch (ktt.Key)
            {
                case ConsoleKey.Enter:
                    mhbll.ThemMH(mh);
                    Console.Clear();
                    themmh();
                    break;
                case ConsoleKey.Tab:
                    pt.pnt1("                                                    ", 6, 44);
                    pt.pnt1("                        ", 6, 45);
                    pt.pnt1("1. Thêm môn học    ", 88, 43);
                    pt.pnt1("2. Sửa môn học", 88, 44);
                    pt.pnt1("3. Xóa môn học", 88, 45);
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
                    pt.pnt1("Bạn nhập sai ! Xin nhập lại ", 6, 46);
                    Console.ForegroundColor = ConsoleColor.White;
                    goto label4;
            }
            #endregion

            #region sửa môn học
            suamh:
             string mamons, tenmonmoi, ghichumoi;
            pt.pnt1("", 32, 10); mamons = Console.ReadLine();
            do
            {
                if (mamons == "")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    pt.pnt1("Mã môn không rỗng ! Nhấn phím bất kỳ nhập lại ", 6, 44);
                    pt.pnt1("Nhấn Tab để quay lại ", 6, 45);
                    Console.ForegroundColor = ConsoleColor.White;
                    ConsoleKeyInfo kt = Console.ReadKey();
                    switch (kt.Key)
                    {
                        case ConsoleKey.Tab:
                            pt.pnt1("                                                    ", 6, 44);
                            pt.pnt1("                        ", 6, 45);
                            pt.pnt1("1. Thêm môn học    ", 88, 43);
                            pt.pnt1("2. Sửa môn học     ", 88, 44);
                            pt.pnt1("3. Xóa môn học", 88, 45);
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
                            pt.pnt1("                                                    ", 6, 44);
                            pt.pnt1("                        ", 6, 45);
                            goto suamh;
                    }
                }
                if (mhbll.KTMamon(mamons) == true)
                {
                    List<MonHoc> listmhh = mhbll.LayDLMH();
                    for (int i = 0; i < listmhh.Count; ++i)
                    {
                        if (listmhh[i].Mamon == mamons)
                        {
                            pt.pnt1(listmhh[i].Tenmon, 60, 10);
                            pt.pnt1(listmhh[i].Ghichu, 99, 10);
                        }
                    }
                    pt.pnt1("", 60, 10);
                    Console.ReadKey();
                    pt.pnt1("              ", 60, 10);
          tenmonmoi:
                    pt.pnt1("", 60, 10); tenmonmoi = Console.ReadLine();
                    if (tenmonmoi == "")
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        pt.pnt1("Tên môn không rỗng ! Nhấn phím bất kỳ nhập lại ", 6, 44);
                        pt.pnt1("Nhấn Tab để quay lại ", 6, 45);
                        Console.ForegroundColor = ConsoleColor.White;
                        ConsoleKeyInfo kt = Console.ReadKey();
                        switch (kt.Key)
                        {
                            case ConsoleKey.Tab:
                                pt.pnt1("                                                    ", 6, 44);
                                pt.pnt1("                        ", 6, 45);
                                pt.pnt1("1. Thêm môn học    ", 88, 43);
                                pt.pnt1("2. Sửa môn học     ", 88, 44);
                                pt.pnt1("3. Xóa môn học", 88, 45);
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
                                pt.pnt1("                                                    ", 15, 47);
                                pt.pnt1("                        ", 15, 48);
                                goto tenmonmoi;
                        }
                    }
                    if (tenmonmoi.Length < 4)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        pt.pnt1("Tên môn không đúng ! Nhấn phím bất kỳ nhập lại ", 6, 44);
                        Console.ForegroundColor = ConsoleColor.White;
                        ConsoleKeyInfo kt = Console.ReadKey();
                        switch (kt.Key)
                        {
                            case ConsoleKey.Tab:
                                pt.pnt1("                                                    ", 6, 44);
                                pt.pnt1("1. Thêm môn học    ", 88, 43);
                                pt.pnt1("2. Sửa môn học     ", 88, 44);
                                pt.pnt1("3. Xóa môn học", 88, 45);
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
                                pt.pnt1("                                                    ", 15, 47);
                                pt.pnt1("                        ", 60, 10);
                                goto tenmonmoi;
                        }
                    }
                    pt.pnt1("", 99, 10);
                    Console.ReadKey();
                    pt.pnt1("            ", 99, 10);
          ghichumoi:
                    pt.pnt1("", 99, 10); ghichumoi = Console.ReadLine();
                    if (ghichumoi == "")
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        pt.pnt1("Ghi chú không rỗng ! Nhấn phím bất kỳ nhập lại ", 6, 44);
                        pt.pnt1("Nhấn Tab để quay lại ", 6, 45);
                        Console.ForegroundColor = ConsoleColor.White;
                        ConsoleKeyInfo kt = Console.ReadKey();
                        switch (kt.Key)
                        {
                            case ConsoleKey.Tab:
                                pt.pnt1("                                                    ", 6, 44);
                                pt.pnt1("                        ", 6, 45);
                                pt.pnt1("1. Thêm môn học    ", 88, 43);
                                pt.pnt1("2. Sửa môn học     ", 88, 44);
                                pt.pnt1("3. Xóa môn học", 88, 45);
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
                                pt.pnt1("                                                    ", 15, 47);
                                pt.pnt1("                        ", 15, 48);
                                goto ghichumoi;
                        }
                    }
                    for (int i = 0; i < ghichumoi.Length; ++i)
                    {
                        if (ghichumoi.Length < 4 ||( ghichumoi.ToLower()!="bat buoc".ToLower() && ghichumoi.ToLower() != "tu chon".ToLower()))
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            pt.pnt1("Ghi chú là : bắt buộc hoặc tự chọn ! Nhấn phím bất kỳ nhập lại ", 15, 47);
                            Console.ForegroundColor = ConsoleColor.White;
                            ConsoleKeyInfo kt = Console.ReadKey();
                            switch (kt.Key)
                            {
                                default:
                                    pt.pnt1("                                                                            ", 15, 47);
                                    pt.pnt1("                        ", 99, 10);
                                    goto ghichumoi;
                            }
                        }
                    }

                    MonHoc mhnew = new MonHoc(mamons, tenmonmoi, ghichumoi);
                    pt.pnt1("Nhấn Enter để lưu và sửa tiếp ", 6, 44);
                    pt.pnt1("Nhấn Tab để quay lại", 6, 45);
                    den:
                    ConsoleKeyInfo ktty = Console.ReadKey();
                    switch (ktty.Key)
                    {
                        case ConsoleKey.Enter:
                            mhbll.XoaMH(mamons);
                            mhbll.ThemMH(mhnew);
                            pt.pnt1("          ", 32, 10);
                            pt.pnt1("              ", 60, 10);
                            pt.pnt1("              ", 99, 10);

                            pt.pnt1("                                   ", 6, 44);
                            pt.pnt1("                                   ", 6, 45);

                            for (int i = 25; i < 38; ++i)
                            {
                                pt.pnt1("          ", 37, i);
                                pt.pnt1("                   ", 58, i);
                                pt.pnt1("                   ", 87, i);
                            }

                            pt.pnt1("1. Thêm môn học    ", 88, 43);
                            pt.pnt1("2. Sửa môn học     ", 88, 44);
                            pt.pnt1("3. Xóa môn học     ", 88, 45);
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

                            goto danhsach;
                        case ConsoleKey.Tab:
                            pt.pnt1("                                                    ", 6, 44);
                            pt.pnt1("                        ", 6, 45);

                            pt.pnt1("          ", 32, 10);
                            pt.pnt1("              ", 60, 10);
                            pt.pnt1("              ", 99, 10);

                            pt.pnt1("1. Thêm môn học    ", 88, 43);
                            pt.pnt1("2. Sửa môn học     ", 88, 44);
                            pt.pnt1("3. Xóa môn học      ", 88, 45);
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
                            pt.pnt1("Bạn nhập sai ! Xin nhập lại ", 6, 49);
                            Console.ForegroundColor = ConsoleColor.White;
                            goto den;
                    }
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    pt.pnt1("Mã môn không tồn tại ! Nhấn phím bất kỳ nhập lại ", 15, 47);
                    Console.ForegroundColor = ConsoleColor.White;
                    ConsoleKeyInfo kt = Console.ReadKey();
                    switch (kt.Key)
                    {
                        default:
                            pt.pnt1("                                                    ", 15, 47);
                            pt.pnt1("         ", 32, 10);
                            goto suamh;
                    }
                }
            } while (true);
            #endregion

            #region xóa môn 
            Xoamh:
            string mamonx;
            do
            {
                pt.pnt1("", 61, 12); mamonx = Console.ReadLine();
                if (mamonx == "")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    pt.pnt1("Mã môn không rỗng ! Nhấn phím bất kỳ nhập lại ", 6, 44);
                    pt.pnt1("Nhấn Tab để quay lại ", 6, 45);
                    Console.ForegroundColor = ConsoleColor.White;
                    ConsoleKeyInfo kt = Console.ReadKey();
                    switch (kt.Key)
                    {
                        case ConsoleKey.Tab:
                            pt.pnt1("                                                    ", 6, 44);
                            pt.pnt1("                        ", 6, 45);
                            pt.pnt1("1. Thêm môn học    ", 88, 43);
                            pt.pnt1("2. Sửa môn học     ", 88, 44);
                            pt.pnt1("3. Xóa môn học     ", 88, 45);
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
                            pt.pnt1("                                                    ", 15, 47);
                            pt.pnt1("                        ", 15, 48);
                            goto Xoamh;
                    }
                }
                if (mhbll.KTMamon(mamonx) == true)
                {
                    pt.pnt1("Nhấn Enter để lưu và xóa tiếp ", 6, 44);
                    pt.pnt1("Nhấn Tab để quay lại", 6, 45);
                    den2: ConsoleKeyInfo kt = Console.ReadKey();
                    switch (kt.Key)
                    {
                        case ConsoleKey.Enter:
                            mhbll.XoaMH(mamonx);
                            pt.pnt1("      ", 61, 12);
                            pt.pnt1("                                                    ", 6, 44);
                            pt.pnt1("                        ", 6, 45);

                            for (int i = 25; i < 38; ++i)
                            {
                                pt.pnt1("          ", 37, i);
                                pt.pnt1("                   ", 58, i);
                                pt.pnt1("                   ", 87, i);
                            }

                            pt.pnt1("1. Thêm môn học    ", 88, 43);
                            pt.pnt1("2. Sửa môn học   ", 88, 44);
                            pt.pnt1("3. Xóa môn học   ", 88, 45);
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

                            goto danhsach;
                        case ConsoleKey.Tab:
                            pt.pnt1("                                                    ", 6, 44);
                            pt.pnt1("                        ", 6, 45);
                            pt.pnt1("1. Thêm môn học    ", 88, 43);
                            pt.pnt1("2. Sửa môn học     ", 88, 44);
                            pt.pnt1("3. Xóa môn học", 88, 45);
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
                            pt.pnt1("Bạn nhập sai ! Xin nhập lại ", 80, 49);
                            Console.ForegroundColor = ConsoleColor.White;
                            goto den2;
                    }
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    pt.pnt1("Mã môn không tồn tại ! Nhấn phím bất kỳ nhập lại ", 15, 47);
                    Console.ForegroundColor = ConsoleColor.White;
                    ConsoleKeyInfo kt = Console.ReadKey();
                    switch (kt.Key)
                    {
                        default:
                            pt.pnt1("                                                    ", 15, 47);
                            pt.pnt1("                ", 61, 12);
                            goto Xoamh;
                    }
                }
            } while (true);
            #endregion
        }
        #endregion
    }
}
