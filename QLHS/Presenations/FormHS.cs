using System;
using System.Linq;
using System.Text;
using QLHS.Utility;
using QLHS.Presenations;
using QLHS.Business.Components;
using QLHS.DataAccessLayer.Service_Interface;
using QLHS.DataAccessLayer;
using QLHS.Entities;
namespace QLHS.Presenations
{
    public class FormHS
    {
        Paint pt = new Paint(140, 55);
        HocSinhBLL hsBLL = new HocSinhBLL();
        IHocSinhDAL hsDA = new HocSinhDAL();
        LopBLL lopbll = new LopBLL();
        BangDiemBLL bdbll = new BangDiemBLL();
        ThongTinPM tt = new ThongTinPM();
        public static FormBangDiem fbd = new FormBangDiem();
        public static FormGVCN fgv = new FormGVCN();
        public static FormLop flop = new FormLop();
        public static FormTimKiem ff = new FormTimKiem();
        public static FormMonHoc fmh = new FormMonHoc();
        public static FormThongKe ftk = new FormThongKe();
        public static MenuChinh mn = new MenuChinh();

        public void themhs()
        {
            top:
            #region Vẽ giao diện
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

            pt.pnt1("━━━━━━━━━━┻━━━━━━━━━━━━━━━━━━━━┻━━━━━━━━━━━━━━┻━━━━━━━┻━━━━━━━━━━━━━━━━━━━━━━┻━━━━━━━━━━━━━━━━┻━━━━━━━━━━━━━━━┻━━━━━━━━━━━━━━━", 6, 42);


            for (int i = 23; i < 42; i++)
            {
                pt.pnt1("┃", 16, i);
                pt.pnt1("┃", 37, i);
                pt.pnt1("┃", 52, i);
                pt.pnt1("┃", 60, i);
                pt.pnt1("┃", 83, i);
                pt.pnt1("┃", 100, i);
                pt.pnt1("┃", 116, i);
            }
            #endregion
            pt.pnt1("DANH SÁCH HỌC SINH ", 61, 20);
            pt.pnt1(" Mã HS ", 8, 23);
            pt.pnt1(" Tên HS", 22, 23);
            pt.pnt1(" Ngày sinh", 40, 23);
            pt.pnt1(" GT", 54, 23);
            pt.pnt1(" Địa chỉ", 67, 23);
            pt.pnt1(" SĐT(bố/mẹ)", 87, 23);
            pt.pnt1(" Năm học", 104, 23);
            pt.pnt1(" Mã lớp", 120, 23);

            pt.pnt1("1. Thêm học sinh", 88, 43);
            pt.pnt1("2. Sửa học sinh", 88, 44);
            pt.pnt1("3. Xóa học sinh", 88, 45);
            pt.pnt1("4. Đưa ra danh sách học sinh", 88, 46);
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

            //Hiện danh sách ra màn hình
            label: List<HocSinh> h = hsBLL.LayDlhs();
            hsDA.BackUp(h);
            int a = 25;
            int tmp = 0;
            for (int i = 0; i < h.Count; ++i)
            {
                if (tmp < 9)
                {
                    pt.pnt1(h[i].Mahs, 9, a);
                    pt.pnt1(h[i].Tenhs, 19, a);
                    pt.pnt1(h[i].Ngaysinh, 40, a);
                    pt.pnt1(h[i].Gioitinh, 55, a);
                    pt.pnt1(h[i].Diachi, 67, a);
                    pt.pnt1(h[i].Sdtbome, 88, a);
                    pt.pnt1(h[i].Namhoc, 104, a);
                    pt.pnt1(h[i].Malop, 122, a);
                    tmp++;
                    a = a + 2;
                }
                else break;
            }
            // danh sách các chức năng quản lý học sinh
            pt.pnt1("Chọn chức năng : ", 88, 50);
        chucnang : ConsoleKeyInfo ktktt = Console.ReadKey();
            Console.ForegroundColor = ConsoleColor.White;
            switch (ktktt.KeyChar)
            {
                case '1':
                    pt.pnt1(" Thêm học sinh ", 56, 8);
                    pt.pnt1("               ", 88, 43);
                    Console.ForegroundColor = ConsoleColor.Green;
                    pt.pnt1("→ 1. Thêm học sinh", 88, 43);
                    Console.ForegroundColor = ConsoleColor.White;
                    pt.pnt1("    ", 105, 50);
                    pt.pnt1("                             ", 88, 51);
                    pt.pnt1("                             ", 6, 16);
                    pt.pnt1("                            ", 47, 13);
                    pt.pnt1("Mã học sinh : ", 18, 10);
                    pt.pnt1("Tên học sinh :", 50, 10);
                    pt.pnt1("Ngày sinh : ", 89, 10);
                    pt.pnt1("Giới tính   : ", 18, 12);
                    pt.pnt1("Địa chỉ      : ", 50, 12);
                    pt.pnt1("SĐT bố/mẹ : ", 89, 12);
                    pt.pnt1("Năm học     : ", 18, 14);
                    pt.pnt1("Mã lớp       : ", 50, 14);
                    goto themhs;
                case '2':
                    pt.pnt1("Sửa  học  sinh  ", 57, 8);
                    pt.pnt1("    ", 104, 50);
                    pt.pnt1("                             ", 88, 51);
                    pt.pnt1("                   ", 18, 10);
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    pt.pnt1(" Nhập mã học sinh cần sửa : ", 6, 16);
                    Console.ForegroundColor = ConsoleColor.White;
                    pt.pnt1("                  ", 88, 43);
                    pt.pnt1("                  ", 88, 44);
                    pt.pnt1("1. Thêm học sinh", 88, 43);
                    Console.ForegroundColor = ConsoleColor.Green;
                    pt.pnt1("→ 2. Sửa học sinh", 88, 44);
                    Console.ForegroundColor = ConsoleColor.White;
                    pt.pnt1("Tên học sinh :", 50, 10);
                    pt.pnt1("Ngày sinh : ", 89, 10);
                    pt.pnt1("Giới tính   : ", 18, 12);
                    pt.pnt1("Địa chỉ      : ", 50, 12);
                    pt.pnt1("SĐT bố/mẹ : ", 89, 12);
                    pt.pnt1("Năm học     : ", 18, 14);
                    pt.pnt1("Mã lớp       : ", 50, 14);
                    pt.pnt1("                            ", 47, 13);
                    goto Suahs;
                case '3':
                    pt.pnt1(" Xóa học sinh  ", 56, 8);
                    pt.pnt1("    ", 104, 50);
                    pt.pnt1("                             ", 88, 51);
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    pt.pnt1("Nhập mã học sinh cần xóa: ", 47, 13);
                    Console.ForegroundColor = ConsoleColor.White;
                    pt.pnt1("              ", 18, 10);
                    pt.pnt1("              ", 50, 10);
                    pt.pnt1("              ", 89, 10);
                    pt.pnt1("              ", 18, 12);
                    pt.pnt1("              ", 50, 12);
                    pt.pnt1("              ", 89, 12);
                    pt.pnt1("              ", 18, 14);
                    pt.pnt1("              ", 50, 14);
                    pt.pnt1("                            ", 6, 16);
                    pt.pnt1("                  ", 88, 43);
                    pt.pnt1("                  ", 88, 44);
                    pt.pnt1("                  ", 88, 45);
                    pt.pnt1("1. Thêm học sinh", 88, 43);
                    pt.pnt1("2. Sửa học sinh", 88, 44);
                    Console.ForegroundColor = ConsoleColor.Green;
                    pt.pnt1("→ 3. Xóa học sinh", 88, 45);
                    Console.ForegroundColor = ConsoleColor.White;
                    goto Xoahs;
                case '4':
                    pt.pnt1("    ", 104, 50);
                    pt.pnt1("                             ", 88, 51);
                    pt.pnt1("", 104, 50);
                    for (int i = 1; i < 53; i++)
                    {
                        pt.pnt1("                                                                                                                                        ", 1, i);
                    }
                    pt.pnt1("                                                                                                                                              ", 1, 52);
                    for(int j= 41; j < 54; j++)
                    {
                        pt.pnt1("   ", 4, j);
                        pt.pnt1("   ", 133, j);
                    }
                    goto hienthi;
                case '5':
                    Console.Clear();
                    mn.MenuChinh1();
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
                case 'L':
                    Console.Clear();
                    flop.Themlop();
                    break;
                case 'H':
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    pt.pnt1("G : Quản lý Giáo Viên", 4, 6);
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
                    Environment.Exit(0);break;
                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    pt.pnt1("      ", 105, 50);
                    pt.pnt1("Bạn nhập sai xin nhập lại", 88, 51);
                    pt.pnt1("", 105, 50);
                    Console.ForegroundColor = ConsoleColor.White;
                    goto chucnang;
            }

        #region  Thêm mới các thông tin của học sinh

        themhs:
            string mahs, tenhs, ngaysinh, gioitinh, diachi, sdtbome, namhoc, malop;
            try
            {

                pt.pnt1("", 32, 10); mahs = Console.ReadLine();
            }
            catch
            {
                Console.ForegroundColor = ConsoleColor.Red;
                pt.pnt1(" Mã học sinh không được trống. Nhấn phím bất kỳ để nhập lại", 15, 46);
                Console.ForegroundColor = ConsoleColor.White;
                ConsoleKeyInfo kths = Console.ReadKey();
                switch (kths.Key)
                {
                    default:
                        Console.ForegroundColor = ConsoleColor.Black;
                        pt.pnt1("                                                                   ", 15, 46);
                        Console.ResetColor();
                        goto themhs;
                }
            }
            if (mahs == "")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                pt.pnt1(" Mã học sinh là bắt buộc ! Nhấn 1 phím bất kỳ để nhập lại ", 6, 44);
                pt.pnt1(" Hoặc nhấn Tab để chọn chức năng khác ", 6, 45);
                Console.ForegroundColor = ConsoleColor.White;
                ConsoleKeyInfo kt = Console.ReadKey();
                switch (kt.Key)
                {
                    case ConsoleKey.Tab:
                        pt.pnt1("              ", 56, 8);
                        pt.pnt1("━━━━━━━━━━━━━━━━", 56, 8);
                        pt.pnt1("              ", 18, 10);
                        pt.pnt1("              ", 50, 10);
                        pt.pnt1("              ", 89, 10);
                        pt.pnt1("              ", 18, 12);
                        pt.pnt1("              ", 50, 12);
                        pt.pnt1("              ", 89, 12);
                        pt.pnt1("              ", 18, 14);
                        pt.pnt1("              ", 50, 14);

                        pt.pnt1("                                                                   ", 6, 44);
                        pt.pnt1("                                                                   ", 6, 45);
                        pt.pnt1("1. Thêm học sinh   ", 88, 43);
                        pt.pnt1("2. Sửa học sinh   ", 88, 44);
                        pt.pnt1("3. Xóa học sinh   ", 88, 45);
                        pt.pnt1("4. Đưa ra danh sách học sinh   ", 88, 46);
                        pt.pnt1("5. Để quay lại menu chính   ", 88, 47);
                        pt.pnt1("6. Để thoát khỏi chương trình   ", 88, 48);
                        pt.pnt1("Nhấn", 88, 49);
                        Console.ForegroundColor = ConsoleColor.Green;
                        pt.pnt1("H", 93, 49);
                        Console.ForegroundColor = ConsoleColor.White;
                        pt.pnt1("để mở thanh công cụ và", 95, 49);
                        Console.ForegroundColor = ConsoleColor.Green;
                        pt.pnt1("E", 118, 49);
                        Console.ForegroundColor = ConsoleColor.White;
                        pt.pnt1("để tắt", 120, 49);
                        pt.pnt1("", 104, 50);
                        goto chucnang;
                    default:
                        Console.ForegroundColor = ConsoleColor.Black;
                        pt.pnt1("                                                                   ", 6, 44);
                        pt.pnt1("                                                                   ", 6, 45);
                        Console.ResetColor();
                        goto themhs;
                }
            }
            if (hsBLL.KTmahs(mahs))
            {
            tenhs:
                pt.pnt1("", 65, 10); tenhs = Console.ReadLine();
                if (tenhs == "")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    pt.pnt1(" Tên không rỗng. Nhấn phím bất kỳ để nhập lại ", 6, 44);
                    pt.pnt1(" Hoặc nhấn Tab để quay lại ", 6, 45);
                    Console.ForegroundColor = ConsoleColor.White;
                    ConsoleKeyInfo ktt = Console.ReadKey();
                    switch (ktt.Key)
                    {
                        case ConsoleKey.Tab:
                            pt.pnt1("                                                                   ", 6, 44);
                            pt.pnt1("                                    ", 6, 45);
                            pt.pnt1("               ", 32, 10);
                            pt.pnt1("1. Thêm học sinh   ", 88, 43);
                            pt.pnt1("2. Sửa học sinh   ", 88, 44);
                            pt.pnt1("3. Xóa học sinh   ", 88, 45);
                            pt.pnt1("4. Đưa ra danh sách học sinh   ", 88, 46);
                            pt.pnt1("5. Để quay lại menu chính   ", 88, 47);
                            pt.pnt1("6. Để thoát khỏi chương trình   ", 88, 48);
                            pt.pnt1("Nhấn", 88, 49);
                            Console.ForegroundColor = ConsoleColor.Green;
                            pt.pnt1("H", 93, 49);
                            Console.ForegroundColor = ConsoleColor.White;
                            pt.pnt1("để mở thanh công cụ và", 95, 49);
                            Console.ForegroundColor = ConsoleColor.Green;
                            pt.pnt1("E", 118, 49);
                            Console.ForegroundColor = ConsoleColor.White;
                            pt.pnt1("để tắt", 120, 49);
                            pt.pnt1("      ", 104, 50);
                            pt.pnt1("", 105, 50);
                            goto chucnang;
                        default:
                            Console.ForegroundColor = ConsoleColor.Black;
                            pt.pnt1("                                                                   ", 6, 44);
                            pt.pnt1("                                                                   ", 6, 45);
                            pt.pnt1("                      ", 65, 10);
                            Console.ResetColor();
                            goto tenhs;
                    }
                }
                else
                {
                    if (hsBLL.KTten(tenhs) == false)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        pt.pnt1(" Tên không chứa kí tự số . Nhấn 1 phím bất kỳ để nhập lại", 6, 44);
                        Console.ForegroundColor = ConsoleColor.White;
                        ConsoleKeyInfo ktt = Console.ReadKey();
                        switch (ktt.Key)
                        {
                            default:
                                Console.ForegroundColor = ConsoleColor.Black;
                                pt.pnt1("                                                                   ", 6, 44);
                                pt.pnt1("                      ", 65, 10);
                                Console.ResetColor();
                                goto tenhs;
                        }
                    }
                    if (tenhs.Length < 6)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        pt.pnt1(" Tên quá ngắn . Nhấn 1 phím bất kỳ để nhập lại", 6, 44);
                        Console.ForegroundColor = ConsoleColor.White;
                        ConsoleKeyInfo ktt = Console.ReadKey();
                        switch (ktt.Key)
                        {
                            default:
                                Console.ForegroundColor = ConsoleColor.Black;
                                pt.pnt1("                                                                   ", 6, 44);
                                pt.pnt1("                      ", 65, 10);
                                Console.ResetColor();
                                goto tenhs;
                        }

                    }
                }
                Console.ForegroundColor = ConsoleColor.White;
            ngaysinh:
                try
                {
                    pt.pnt1("", 100, 10); ngaysinh = Console.ReadLine();
                }
                catch
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    pt.pnt1(" Dữ liệu nhập sai . Nhấn phím bất kỳ nhập lại ", 6, 44);
                    ConsoleKeyInfo ktns = Console.ReadKey();
                    switch (ktns.Key)
                    {
                        default:
                            Console.ForegroundColor = ConsoleColor.Black;
                            pt.pnt1("                                                                   ", 6, 44);
                            pt.pnt1("                 ", 100, 10);
                            Console.ResetColor();
                            goto ngaysinh;
                    }
                }
                if (ngaysinh == "")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    pt.pnt1(" Ngày sinh không rỗng ! Nhấn 1 phím bất kỳ để nhập lại ", 6, 44);
                    Console.ForegroundColor = ConsoleColor.White;
                    ConsoleKeyInfo kt = Console.ReadKey();
                    switch (kt.Key)
                    {
                        default:
                            Console.ForegroundColor = ConsoleColor.Black;
                            pt.pnt1("                                                                   ", 6, 44);
                            pt.pnt1("                 ", 100, 10);
                            Console.ResetColor();
                            goto ngaysinh;
                    }

                }
                if (ngaysinh.Length < 10)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    pt.pnt1(" Dữ liệu sai ! Nhấn phím bất kỳ để nhập lại", 6, 44);
                    Console.ForegroundColor = ConsoleColor.White;
                    ConsoleKeyInfo kt = Console.ReadKey();
                    switch (kt.Key)
                    {
                        default:
                            Console.ForegroundColor = ConsoleColor.Black;
                            pt.pnt1("                                                                   ", 6, 44);
                            pt.pnt1("                 ", 100, 10);
                            Console.ResetColor();
                            goto ngaysinh;
                    }

                }
                for (int i = 0; i < ngaysinh.Length; ++i)
                {
                    if (ngaysinh[i] != '0' && ngaysinh[i] != '1' && ngaysinh[i] != '2' && ngaysinh[i] != '3' && ngaysinh[i] != '4' && ngaysinh[i] != '5' && ngaysinh[i] != '6' && ngaysinh[i] != '7' && ngaysinh[i] != '8' && ngaysinh[i] != '9' && ngaysinh[i] != '/')
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        pt.pnt1(" Nhập sai định dạng ngày sinh dddd/mmmm/yyyy . Nhấn 1 phím bất kỳ để nhập lại", 6, 44);
                        Console.ForegroundColor = ConsoleColor.White;
                        ConsoleKeyInfo ktt = Console.ReadKey();
                        switch (ktt.Key)
                        {
                            default:
                                Console.ForegroundColor = ConsoleColor.Black;
                        pt.pnt1("                                                                              ", 6, 44);
                                pt.pnt1("                 ", 100, 10);
                                Console.ResetColor();
                                goto ngaysinh;
                        }
                    }
                }
                string[] b = ngaysinh.Split('/');
                DateTime ngayhethong = DateTime.Now;
                decimal day = Convert.ToDecimal(b[0]);
                decimal month = Convert.ToDecimal(b[1]);
                decimal year = Convert.ToDecimal(b[2]);
                if ((day > 31 || day < 1) || (month < 1 || month > 12) || ((ngayhethong.Year - year) < 6))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    pt.pnt1(" Học sinh chưa đủ 6 tuổi ! Nhấn 1 phím bất kỳ để nhập lại ", 6, 44);
                    Console.ForegroundColor = ConsoleColor.White;
                    ConsoleKeyInfo kt = Console.ReadKey();
                    switch (kt.Key)
                    {
                        default:
                            Console.ForegroundColor = ConsoleColor.Black;
                            pt.pnt1("                                                                   ", 6, 44);
                            pt.pnt1("                 ", 100, 10);
                            Console.ResetColor();
                            goto ngaysinh;
                    }
                }
                if ((day > 31 || day < 1) || (month < 1 || month > 12) || (ngayhethong.Year - year) > 14)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    pt.pnt1(" Học sinh không thể vượt quá 14 tuổi ! Nhấn 1 phím bất kỳ để nhập lại ", 6, 44);
                    Console.ForegroundColor = ConsoleColor.White;
                    ConsoleKeyInfo kt = Console.ReadKey();
                    switch (kt.Key)
                    {
                        default:
                            Console.ForegroundColor = ConsoleColor.Black;
                            pt.pnt1("                                                                           ", 6, 44);
                            pt.pnt1("                 ", 100, 10);
                            Console.ResetColor();
                            goto ngaysinh;
                    }
                }
                if ((month == 2) && (day >= 30 || day < 1))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    pt.pnt1(" Tháng hai chỉ có tối đa 29 ngày hoặc lớn hơn 1! Nhập lại ", 6, 44);
                    Console.ForegroundColor = ConsoleColor.White;
                    ConsoleKeyInfo kt = Console.ReadKey();
                    switch (kt.Key)
                    {
                        default:
                            Console.ForegroundColor = ConsoleColor.Black;
                            pt.pnt1("                                                                           ", 6, 44);
                            pt.pnt1("                 ", 100, 10);
                            Console.ResetColor();
                            goto ngaysinh;
                    }
                }

            gioitinh:
                pt.pnt1("", 31, 12); gioitinh = Console.ReadLine();
                if (gioitinh.ToLower() != "nam" && gioitinh.ToLower() != "nu")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    pt.pnt1(" Giới tính chỉ có thể là nam(♂) hoặc nữ(♀). Nhấn phím bất kỳ để nhập lại ", 6, 44);
                    Console.ForegroundColor = ConsoleColor.White;
                    ConsoleKeyInfo kt = Console.ReadKey();
                    switch (kt.Key)
                    {
                        default:
                            Console.ForegroundColor = ConsoleColor.Black;
                    pt.pnt1("                                                                             ", 6, 44);
                            pt.pnt1("             ", 31, 12);
                            Console.ResetColor();
                            goto gioitinh;
                    }
                }
            diachi:
                pt.pnt1("", 65, 12); diachi = Console.ReadLine();
                if (diachi == "")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    pt.pnt1(" Địa chỉ không rỗng ! Nhấn phím bất kỳ để nhập lại", 6, 44);
                    Console.ForegroundColor = ConsoleColor.White;
                    ConsoleKeyInfo kt = Console.ReadKey();
                    switch (kt.Key)
                    {
                        default:
                            Console.ForegroundColor = ConsoleColor.Black;
                            pt.pnt1("                                                                   ", 6, 44);
                            pt.pnt1("           ", 65, 12);
                            Console.ResetColor();
                            goto diachi;
                    }
                }
                if (diachi.Length < 5)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    pt.pnt1(" Địa chỉ quá ngắn ! Nhấn phím bất kỳ để nhập lại", 6, 44);
                    Console.ForegroundColor = ConsoleColor.White;
                    ConsoleKeyInfo kt = Console.ReadKey();
                    switch (kt.Key)
                    {
                        default:
                            Console.ForegroundColor = ConsoleColor.Black;
                            pt.pnt1("                                                                   ", 6, 44);
                            pt.pnt1("           ", 65, 12);
                            Console.ResetColor();
                            goto diachi;
                    }

                }
            sdtbome:
                pt.pnt1("", 100, 12); sdtbome = Console.ReadLine();
                if (sdtbome == "")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    pt.pnt1(" Số điện thoại bố/mẹ không rỗng ! Nhấn phím bất kỳ để nhập lại", 6, 44);
                    Console.ForegroundColor = ConsoleColor.White;
                    ConsoleKeyInfo kt = Console.ReadKey();
                    switch (kt.Key)
                    {
                        default:
                            Console.ForegroundColor = ConsoleColor.Black;
                            pt.pnt1("                                                                   ", 6, 44);
                            pt.pnt1("                  ", 100, 12);
                            Console.ResetColor();
                            goto sdtbome;
                    }
                }
                if (sdtbome.Length > 11 || sdtbome.Length < 9)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    pt.pnt1(" Số điện thoại không thể quá 11 số và nhỏ hơn 9 số! Nhấn phím bất kỳ để nhập lại", 6, 44);
                    Console.ForegroundColor = ConsoleColor.White;
                    ConsoleKeyInfo kt = Console.ReadKey();
                    switch (kt.Key)
                    {
                        default:
                            Console.ForegroundColor = ConsoleColor.Black;
                    pt.pnt1("                                                                                 ", 6, 44);
                            pt.pnt1("                   ", 100, 12);
                            Console.ResetColor();
                            goto sdtbome;
                    }

                }
                for (int i = 0; i < sdtbome.Length; ++i)
                {
                    if (sdtbome[i] != '0' && sdtbome[i] != '1' && sdtbome[i] != '2' && sdtbome[i] != '3' && sdtbome[i] != '4' && sdtbome[i] != '5' && sdtbome[i] != '6' && sdtbome[i] != '7' && sdtbome[i] != '8' && sdtbome[i] != '9')
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        pt.pnt1(" Số điện thoại không chứa ký tự ! Nhấn phím bất kỳ để nhập lại",6, 44);
                        Console.ForegroundColor = ConsoleColor.White;
                        ConsoleKeyInfo kt = Console.ReadKey();
                        switch (kt.Key)
                        {
                            default:
                                Console.ForegroundColor = ConsoleColor.Black;
                                pt.pnt1("                                                                   ", 6, 44);
                                pt.pnt1("                    ", 100, 12);
                                Console.ResetColor();
                                goto sdtbome;
                        }

                    }
                }
            namhoc:
                pt.pnt1("", 31, 14); namhoc = Console.ReadLine();
                if (namhoc == "")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    pt.pnt1(" Năm học không rỗng ! Nhấn phím bất kỳ để nhập lại", 6, 44);
                    Console.ForegroundColor = ConsoleColor.White;
                    ConsoleKeyInfo kt = Console.ReadKey();
                    switch (kt.Key)
                    {
                        default:
                            Console.ForegroundColor = ConsoleColor.Black;
                            pt.pnt1("                                                                   ", 6, 44);
                            pt.pnt1("              ", 31, 14);
                            Console.ResetColor();
                            goto namhoc;
                    }

                }
                for (int i = 0; i < namhoc.Length; ++i)
                {
                    if (namhoc[i] != '0' && namhoc[i] != '1' && namhoc[i] != '2' && namhoc[i] != '3' && namhoc[i] != '4' && namhoc[i] != '5' && namhoc[i] != '6' && namhoc[i] != '7' && namhoc[i] != '8' && namhoc[i] != '9' && namhoc[i] != '-')
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        pt.pnt1(" Nhập sai định dạng năm học yyyy - yyyy ! Nhấn phím bất kỳ để nhập lại", 6, 44);
                        Console.ForegroundColor = ConsoleColor.White;
                        ConsoleKeyInfo kt = Console.ReadKey();
                        switch (kt.Key)
                        {
                            default:
                                Console.ForegroundColor = ConsoleColor.Black;
                                pt.pnt1("                                                                         ", 6, 44);
                                pt.pnt1("              ", 31, 14);
                                Console.ResetColor();
                                goto namhoc;
                        }

                    }
                }
                if (namhoc.Length < 7)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    pt.pnt1(" Nhập sai định dạng năm học yyyy - yyyy ! Nhấn phím bất kỳ để nhập lại", 6, 44);
                    Console.ForegroundColor = ConsoleColor.White;
                    ConsoleKeyInfo kt = Console.ReadKey();
                    switch (kt.Key)
                    {
                        default:
                            Console.ForegroundColor = ConsoleColor.Black;
                            pt.pnt1("                                                                                  ", 6, 44);
                            pt.pnt1("              ", 31, 14);
                            Console.ResetColor();
                            goto namhoc;
                    }

                }
                DateTime nht = DateTime.Now;
                string[] nh = namhoc.Split('-');
                decimal nbd = Convert.ToDecimal(nh[0]);
                decimal nkt = Convert.ToDecimal(nh[1]);
                if (nbd > nht.Year || nkt > nht.Year || nbd > nkt)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    pt.pnt1(" Năm học không đúng ! Nhấn phím bất kỳ để nhập lại", 6, 44);
                    Console.ForegroundColor = ConsoleColor.White;
                    ConsoleKeyInfo kt = Console.ReadKey();
                    switch (kt.Key)
                    {
                        default:
                            Console.ForegroundColor = ConsoleColor.Black;
                            pt.pnt1("                                                                   ", 6, 44);
                            pt.pnt1("              ", 31, 14);
                            Console.ResetColor();
                            goto namhoc;
                    }

                }
            malop:
                List<Lop> dslop = lopbll.LayDlLop();
                pt.pnt1("", 65, 14); malop = Console.ReadLine();
                if (malop == "")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    pt.pnt1(" Mã lớp không rỗng ! Nhấn phím bất kỳ để nhập lại", 6, 44);
                    Console.ForegroundColor = ConsoleColor.White;
                    ConsoleKeyInfo kt = Console.ReadKey();
                    switch (kt.Key)
                    {
                        default:
                            Console.ForegroundColor = ConsoleColor.Black;
                            pt.pnt1("                                                                   ", 6, 44);
                            Console.ResetColor();
                            goto malop;
                    }

                }
                if (lopbll.KTmalop(malop) == true)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    pt.pnt1(" Mã lớp không tồn tại trong hệ thống ! Nhấn phím bất kỳ để nhập lại", 6, 44);
                    pt.pnt1(" Nhấn H để lấy ra danh sách các mã lớp ", 6, 45);
                    Console.ForegroundColor = ConsoleColor.White;
                    ConsoleKeyInfo kt = Console.ReadKey();
                    switch (kt.Key)
                    {
                        case ConsoleKey.H:
                            Console.Clear();
                            tt.dsmalop();
                            break;
                        default:
                            Console.ForegroundColor = ConsoleColor.Black;
                            pt.pnt1("                                                                       ", 6, 44);
                            pt.pnt1("                                                                       ", 6, 45);
                            pt.pnt1("            ", 65, 14);
                            Console.ResetColor();
                            goto malop;
                    }
                }
                HocSinh hocs = new HocSinh(mahs, tenhs, ngaysinh, gioitinh, diachi, sdtbome, namhoc, malop);
                pt.pnt1(" Enter để nhập thêm ", 6, 44);
                pt.pnt1(" Nhấn Tab để quay lại ", 6, 45);
            label3: ConsoleKeyInfo ktkt = Console.ReadKey();
                Console.ForegroundColor = ConsoleColor.White;
                switch (ktkt.Key)
                {
                    case ConsoleKey.Enter:
                        if (hsBLL.demhs(malop)>= lopbll.laysiso(malop))
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            pt.pnt1(" Lớp đã đủ học sinh ! Xin sửa lại thông tin lớp để thêm học sinh ", 6, 44);
                            pt.pnt1("                                    ", 6, 45);
                            Console.ForegroundColor = ConsoleColor.White;
                            ConsoleKeyInfo kt = Console.ReadKey();
                            switch (kt.Key)
                            {
                                default:
                                    Console.Clear();
                                    goto top;
                            }
                        }
                        else
                        {
                            Console.Clear();
                            hsBLL.Themhs(hocs);
                            themhs();
                        }
                        break;
                    case ConsoleKey.Tab:
                        pt.pnt1("            ", 32, 10);
                        pt.pnt1("                  ", 65, 10);
                        pt.pnt1("                 ", 100, 10);
                        pt.pnt1("            ", 31, 12);
                        pt.pnt1("                  ", 65, 12);
                        pt.pnt1("                 ", 100, 12);
                        pt.pnt1("            ", 31, 14);
                        pt.pnt1("                  ", 65, 14);
                        pt.pnt1("      ", 100, 14);
                        pt.pnt1("                                                                   ", 6, 44);
                        pt.pnt1("                                    ", 6, 45);
                        pt.pnt1("1. Thêm học sinh   ", 88, 43);
                        pt.pnt1("2. Sửa học sinh   ", 88, 44);
                        pt.pnt1("3. Xóa học sinh   ", 88, 45);
                        pt.pnt1("4. Đưa ra danh sách học sinh   ", 88, 46);
                        pt.pnt1("5. Để quay lại menu chính   ", 88, 47);
                        pt.pnt1("6. Để thoát khỏi chương trình   ", 88, 48);
                        pt.pnt1("Nhấn", 88, 49);
                        Console.ForegroundColor = ConsoleColor.Green;
                        pt.pnt1("H", 93, 49);
                        Console.ForegroundColor = ConsoleColor.White;
                        pt.pnt1("để mở thanh công cụ và", 95, 49);
                        Console.ForegroundColor = ConsoleColor.Green;
                        pt.pnt1("E", 118, 49);
                        Console.ForegroundColor = ConsoleColor.White;
                        pt.pnt1("để tắt", 120, 49);
                        pt.pnt1("      ", 104, 50);
                        pt.pnt1("", 105, 50);
                        goto chucnang;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        pt.pnt1("      ", 97, 50);
                        pt.pnt1(" Bạn nhập sai xin nhập lại", 60, 51);
                        pt.pnt1("", 97, 50);
                        goto label3;
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                pt.pnt1(" Mã học sinh đã tồn tại ! Nhấn 1 phím bất kỳ để nhập lại ", 6, 44);
                Console.ForegroundColor = ConsoleColor.White;
                ConsoleKeyInfo kt = Console.ReadKey();
                switch (kt.Key)
                {
                    default:
                        Console.ForegroundColor = ConsoleColor.Black;
                        pt.pnt1("                                                                     ", 6, 44);
                        pt.pnt1("          ", 32, 10);
                        Console.ResetColor();
                        goto themhs;
                }
            }
            #endregion
        #region Sửa thông tin của học sinh
            Suahs:
            hsDA.BackUp(h); // sao lưu dữ liệu 
            Suahs1: string mahss;
            string tenhsmoi, ngaysinhmoi, gioitinhmoi, diachimoi, sdtbomemoi, namhocmoi, malopmoi;
            do
            {
                pt.pnt1("", 34, 16); mahss = Console.ReadLine();
                if (mahss == "")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    pt.pnt1("Mã học sinh không rỗng ! Nhấn phím bất kỳ nhập lại", 6, 44);
                    pt.pnt1("Nhấn Tab để quay lại ", 6, 45);
                    Console.ForegroundColor = ConsoleColor.White;
                    ConsoleKeyInfo kt = Console.ReadKey();
                    switch (kt.Key)
                    {
                        case ConsoleKey.Tab:
                            pt.pnt1("              ", 56, 8);
                            pt.pnt1("━━━━━━━━━━━━━━━━━━", 56, 8);
                            pt.pnt1("              ", 18, 10);
                            pt.pnt1("              ", 50, 10);
                            pt.pnt1("              ", 89, 10);
                            pt.pnt1("              ", 18, 12);
                            pt.pnt1("              ", 50, 12);
                            pt.pnt1("              ", 89, 12);
                            pt.pnt1("              ", 18, 14);
                            pt.pnt1("              ", 50, 14);
                            pt.pnt1("                            ", 6, 16);

                            pt.pnt1("                                                                   ", 6, 44);
                            pt.pnt1("                                    ", 6, 45);
                            pt.pnt1("1. Thêm học sinh   ", 88, 43);
                            pt.pnt1("2. Sửa học sinh   ", 88, 44);
                            pt.pnt1("3. Xóa học sinh   ", 88, 45);
                            pt.pnt1("4. Đưa ra danh sách học sinh   ", 88, 46);
                            pt.pnt1("5. Để quay lại menu chính   ", 88, 47);
                            pt.pnt1("6. Để thoát khỏi chương trình   ", 88, 48);
                            pt.pnt1("Nhấn", 88, 49);
                            Console.ForegroundColor = ConsoleColor.Green;
                            pt.pnt1("H", 93, 49);
                            Console.ForegroundColor = ConsoleColor.White;
                            pt.pnt1("để mở thanh công cụ và", 95, 49);
                            Console.ForegroundColor = ConsoleColor.Green;
                            pt.pnt1("E", 118, 49);
                            Console.ForegroundColor = ConsoleColor.White;
                            pt.pnt1("để tắt", 120, 49);
                            pt.pnt1("      ", 104, 50);
                            pt.pnt1("", 105, 50);
                            goto chucnang;
                        default:
                            pt.pnt1("                                                                   ", 6, 44);
                            pt.pnt1("                                    ", 6, 45);
                            Console.ResetColor();
                            goto Suahs1;

                    }
                }
                if (hsBLL.KTmahs(mahss) == false)
                {
                    List<HocSinh> list = hsDA.GetAllData();
                    while (list != null)
                    {
                        for (int i = 0; i < list.Count; ++i)
                        {
                            if (list[i].Mahs == mahss)
                            {
                                pt.pnt1(list[i].Tenhs, 67, 10);
                                pt.pnt1(list[i].Ngaysinh, 102, 10);
                                pt.pnt1(list[i].Gioitinh, 34, 12);
                                pt.pnt1(list[i].Diachi, 67, 12);
                                pt.pnt1(list[i].Sdtbome, 102, 12);
                                pt.pnt1(list[i].Namhoc, 34, 14);
                                pt.pnt1(list[i].Malop, 67, 14);
                            }
                        }
                        break;
                    }
                    pt.pnt1("", 67, 10);
                    Console.ReadKey();
                    Console.BackgroundColor = ConsoleColor.Black;
                    pt.pnt1("                  ", 67, 10);
                    Console.ResetColor();
                    pt.pnt1("", 67, 10);
                    hoten:
                    pt.pnt1("", 67, 10); tenhsmoi = Console.ReadLine();
                    if (tenhsmoi == "")
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        pt.pnt1(" Tên không được rỗng ! Nhấn phím bất kỳ để nhập lại ", 6, 44);
                        pt.pnt1(" Hoặc nhấn Tab quay lại ", 6, 45);
                        Console.ForegroundColor = ConsoleColor.White;
                        ConsoleKeyInfo kt = Console.ReadKey();
                        switch (kt.Key)
                        {
                            case ConsoleKey.Tab:
                                pt.pnt1("                                                                   ", 6, 44);
                                pt.pnt1("                                    ", 6, 45);

                                pt.pnt1("                 ", 102, 10);
                                pt.pnt1("         ", 32, 12);
                                pt.pnt1("                ", 67, 12);
                                pt.pnt1("                   ", 102, 12);
                                pt.pnt1("           ", 32, 14);
                                pt.pnt1("         ", 67, 14);
                                pt.pnt1("      ", 34, 16);

                                pt.pnt1("1. Thêm học sinh   ", 88, 43);
                                pt.pnt1("2. Sửa học sinh   ", 88, 44);
                                pt.pnt1("3. Xóa học sinh   ", 88, 45);
                                pt.pnt1("4. Đưa ra danh sách học sinh   ", 88, 46);
                                pt.pnt1("5. Để quay lại menu chính   ", 88, 47);
                                pt.pnt1("6. Để thoát khỏi chương trình   ", 88, 48);
                                pt.pnt1("Nhấn", 88, 49);
                                Console.ForegroundColor = ConsoleColor.Green;
                                pt.pnt1("H", 93, 49);
                                Console.ForegroundColor = ConsoleColor.White;
                                pt.pnt1("để mở thanh công cụ và", 95, 49);
                                Console.ForegroundColor = ConsoleColor.Green;
                                pt.pnt1("E", 118, 49);
                                Console.ForegroundColor = ConsoleColor.White;
                                pt.pnt1("để tắt", 120, 49);
                                pt.pnt1("      ", 104, 50);
                                pt.pnt1("", 105, 50);
                                goto chucnang;
                            default:
                                pt.pnt1("                                                                 ", 6, 44);
                                pt.pnt1("                                                                 ", 6, 45);
                                goto hoten;
                        }
                    }
                    else
                    {
                        if (hsBLL.KTten(tenhsmoi) == false)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            pt.pnt1(" Tên không chứa số ! Nhấn phím bất kỳ để nhập lại ", 6, 44);
                            Console.ForegroundColor = ConsoleColor.White;
                            ConsoleKeyInfo kt = Console.ReadKey();
                            switch (kt.Key)
                            {
                                default:
                                    pt.pnt1("                                                                 ", 6, 44);
                                    pt.pnt1("                     ", 67, 10);
                                    goto hoten;
                            }
                        }
                        if (tenhsmoi.Length < 6)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            pt.pnt1(" Tên quá ngắn ! Nhấn phím bất kỳ để nhập lại ", 6, 44);
                            Console.ForegroundColor = ConsoleColor.White;
                            ConsoleKeyInfo kt = Console.ReadKey();
                            switch (kt.Key)
                            {
                                default:
                                    pt.pnt1("                                                                 ", 6, 44);
                                    pt.pnt1("                     ", 67, 10);
                                    goto hoten;
                            }
                        }
                    }
                    // sua ngay sinh 
                    pt.pnt1("", 102, 10);
                    Console.ReadKey();
                    Console.BackgroundColor = ConsoleColor.Black;
                    pt.pnt1("                   ", 102, 10);
                    pt.pnt1("", 102, 10);
                    ngaysinh:
                    pt.pnt1("", 102, 10); ngaysinhmoi = Console.ReadLine();
                    if (ngaysinhmoi == "")
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        pt.pnt1(" Ngày sinh không rỗng ! Nhấn 1 phím bất kỳ để nhập lại ", 6, 44);
                        Console.ForegroundColor = ConsoleColor.White;
                        ConsoleKeyInfo kt = Console.ReadKey();
                        switch (kt.Key)
                        {
                            default:
                                Console.ForegroundColor = ConsoleColor.Black;
                                pt.pnt1("                                                                   ", 6, 44);
                                pt.pnt1("                   ", 102, 10);
                                Console.ResetColor();
                                goto ngaysinh;
                        }

                    }
                    if (ngaysinhmoi.Length < 10)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        pt.pnt1(" Ngày sinh không đúng định dạng ! Nhấn phím bất kỳ để nhập lại", 6, 44);
                        Console.ForegroundColor = ConsoleColor.White;
                        ConsoleKeyInfo kt = Console.ReadKey();
                        switch (kt.Key)
                        {
                            default:
                                Console.ForegroundColor = ConsoleColor.Black;
                                pt.pnt1("                                                                        ", 6, 44);
                                pt.pnt1("                   ", 102, 10);
                                Console.ResetColor();
                                goto ngaysinh;
                        }

                    }
                    for (int i = 0; i < ngaysinhmoi.Length; ++i)
                    {
                        if (ngaysinhmoi[i] != '0' && ngaysinhmoi[i] != '1' && ngaysinhmoi[i] != '2' && ngaysinhmoi[i] != '3' && ngaysinhmoi[i] != '4' && ngaysinhmoi[i] != '5' && ngaysinhmoi[i] != '6' && ngaysinhmoi[i] != '7' && ngaysinhmoi[i] != '8' && ngaysinhmoi[i] != '9' && ngaysinhmoi[i] != '/')
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            pt.pnt1(" Nhập sai định dạng ngày sinh dddd/mmmm/yyyy . Nhấn 1 phím bất kỳ để nhập lại", 6, 44);
                            Console.ForegroundColor = ConsoleColor.White;
                            ConsoleKeyInfo ktt = Console.ReadKey();
                            switch (ktt.Key)
                            {
                                default:
                                    Console.ForegroundColor = ConsoleColor.Black;
                                    pt.pnt1("                                                                   ", 6, 44);
                                    pt.pnt1("                   ", 102, 10);
                                    Console.ResetColor();
                                    goto ngaysinh;
                            }
                        }
                    }
                    string[] b = ngaysinhmoi.Split('/');
                    DateTime ngayhethong = DateTime.Now;
                    decimal day = Convert.ToDecimal(b[0]);
                    decimal month = Convert.ToDecimal(b[1]);
                    decimal year = Convert.ToDecimal(b[2]);
                    if ((day > 31 || day < 1) || (month < 1 || month > 12) || ((ngayhethong.Year - year) < 6))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        pt.pnt1(" Học sinh chưa đủ 6 tuổi ! Nhấn 1 phím bất kỳ để nhập lại ", 6, 44);
                        Console.ForegroundColor = ConsoleColor.White;
                        ConsoleKeyInfo kt = Console.ReadKey();
                        switch (kt.Key)
                        {
                            default:
                                Console.ForegroundColor = ConsoleColor.Black;
                                pt.pnt1("                                                                   ", 6, 44);
                                pt.pnt1("                   ", 102, 10);
                                Console.ResetColor();
                                goto ngaysinh;
                        }
                    }
                    if ((day > 31 || day < 1) || (month < 1 || month > 12) || (ngayhethong.Year - year) > 14)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        pt.pnt1(" Học sinh không thể vượt quá 14 tuổi ! Nhấn 1 phím bất kỳ để nhập lại ", 6, 44);
                        Console.ForegroundColor = ConsoleColor.White;
                        ConsoleKeyInfo kt = Console.ReadKey();
                        switch (kt.Key)
                        {
                            default:
                                Console.ForegroundColor = ConsoleColor.Black;
                                pt.pnt1("                                                                           ", 6, 44);
                                pt.pnt1("                   ", 102, 10);
                                Console.ResetColor();
                                goto ngaysinh;
                        }
                    }


                    //sua gioi tinh
                    pt.pnt1("", 34, 12);
                    Console.ReadKey();
                    Console.BackgroundColor = ConsoleColor.Black;
                    pt.pnt1("                ", 34, 12);
                    pt.pnt1("", 34, 12);
                    Console.ResetColor();
                    gioitinh:
                    pt.pnt1("", 34, 12);
                    gioitinhmoi = Console.ReadLine();
                    if (gioitinhmoi.ToLower() != "nam" && gioitinhmoi.ToLower() != "nu")
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        pt.pnt1(" Giới tính chỉ có thể là nam(♂) hoặc nữ(♀). Nhấn phím bất kỳ để nhập lại ", 6, 44);
                        Console.ForegroundColor = ConsoleColor.White;
                        ConsoleKeyInfo kt = Console.ReadKey();
                        switch (kt.Key)
                        {
                            default:
                                pt.pnt1("                                                                             ", 6, 44);
                                pt.pnt1("                ", 34, 12);
                                goto gioitinh;
                        }
                    }
                    // sua dia chi 
                    pt.pnt1("", 67, 12);
                    Console.ReadKey();
                    Console.BackgroundColor = ConsoleColor.Black;
                    pt.pnt1("               ", 67, 12);
                    pt.pnt1("", 67, 12);
                    Console.ResetColor();
                    diachi:
                    pt.pnt1("", 67, 12); diachimoi = Console.ReadLine();
                    if (diachimoi == "")
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        pt.pnt1(" Địa chỉ không rỗng . Nhấn phím bất kỳ để nhập lại ", 6, 44);
                        Console.ForegroundColor = ConsoleColor.White;
                        ConsoleKeyInfo kt = Console.ReadKey();
                        switch (kt.Key)
                        {
                            default:
                                pt.pnt1("                                                              ", 6, 44);
                                pt.pnt1("               ", 67, 12);
                                goto diachi;
                        }

                    }
                    if (diachimoi.Length < 3)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        pt.pnt1(" Địa chỉ quá ngắn hoặc sai . Nhấn phím bất kỳ để nhập lại ", 6, 44);
                        Console.ForegroundColor = ConsoleColor.White;
                        ConsoleKeyInfo kt = Console.ReadKey();
                        switch (kt.Key)
                        {
                            default:
                                pt.pnt1("                                                              ", 6, 44);
                                pt.pnt1("               ", 67, 12);
                                goto diachi;
                        }

                    }
                    // sua so dien thoai
                    pt.pnt1("", 102, 12);
                    Console.BackgroundColor = ConsoleColor.Black;
                    pt.pnt1("                    ", 102, 12);
                    pt.pnt1("", 102, 12);
                    Console.ResetColor();
                    sdtbome:
                    pt.pnt1("", 102, 12); sdtbomemoi = Console.ReadLine();
                    if (sdtbomemoi == "")
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        pt.pnt1(" Số điện thoại bố/mẹ không rỗng ! Nhấn phím bất kỳ để nhập lại", 6, 44);
                        Console.ForegroundColor = ConsoleColor.White;
                        ConsoleKeyInfo kt = Console.ReadKey();
                        switch (kt.Key)
                        {
                            default:
                                Console.ForegroundColor = ConsoleColor.Black;
                                pt.pnt1("                                                                   ", 6, 44);
                                pt.pnt1("                    ", 102, 12);
                                Console.ResetColor();
                                goto sdtbome;
                        }
                    }
                    if (sdtbomemoi.Length > 11 || sdtbomemoi.Length < 9)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        pt.pnt1(" Số điện thoại không thể quá 11 số và nhỏ hơn 9 số! Nhấn phím bất kỳ để nhập lại", 6, 44);
                        Console.ForegroundColor = ConsoleColor.White;
                        ConsoleKeyInfo kt = Console.ReadKey();
                        switch (kt.Key)
                        {
                            default:
                                Console.ForegroundColor = ConsoleColor.Black;
                                pt.pnt1("                                                                                  ", 6, 44);
                                pt.pnt1("                    ", 102, 12);
                                Console.ResetColor();
                                goto sdtbome;
                        }
                    }
                    for (int i = 0; i < sdtbomemoi.Length; ++i)
                    {
                        if (sdtbomemoi[i] != '0' && sdtbomemoi[i] != '1' && sdtbomemoi[i] != '2' && sdtbomemoi[i] != '3' && sdtbomemoi[i] != '4' && sdtbomemoi[i] != '5' && sdtbomemoi[i] != '6' && sdtbomemoi[i] != '7' && sdtbomemoi[i] != '8' && sdtbomemoi[i] != '9')
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            pt.pnt1(" Số điện thoại không chứa ký tự ! Nhấn phím bất kỳ để nhập lại", 6, 44);
                            Console.ForegroundColor = ConsoleColor.White;
                            ConsoleKeyInfo kt = Console.ReadKey();
                            switch (kt.Key)
                            {
                                default:
                                    Console.ForegroundColor = ConsoleColor.Black;
                                    pt.pnt1("                                                                   ", 6, 44);
                                    pt.pnt1("                    ", 102, 12);
                                    Console.ResetColor();
                                    goto sdtbome;
                            }

                        }
                    }

                    // sua nam hoc
                    pt.pnt1("", 34, 14);
                    Console.ReadKey();
                    Console.BackgroundColor = ConsoleColor.Black;
                    pt.pnt1("               ", 34, 14);
                    pt.pnt1("", 34, 14);
                    Console.ResetColor();
                    namhoc:
                    pt.pnt1("", 34, 14); namhocmoi = Console.ReadLine();
                    if (namhocmoi == "")
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        pt.pnt1(" Năm học không rỗng ! Nhấn phím bất kỳ để nhập lại", 6, 44);
                        Console.ForegroundColor = ConsoleColor.White;
                        ConsoleKeyInfo kt = Console.ReadKey();
                        switch (kt.Key)
                        {
                            default:
                                Console.ForegroundColor = ConsoleColor.Black;
                                pt.pnt1("                                                                   ", 6, 44);
                                pt.pnt1("               ", 34, 14);
                                Console.ResetColor();
                                goto namhoc;
                        }

                    }
                    for (int i = 0; i < namhocmoi.Length; ++i)
                    {
                        if (namhocmoi[i] != '0' && namhocmoi[i] != '1' && namhocmoi[i] != '2' && namhocmoi[i] != '3' && namhocmoi[i] != '4' && namhocmoi[i] != '5' && namhocmoi[i] != '6' && namhocmoi[i] != '7' && namhocmoi[i] != '8' && namhocmoi[i] != '9' && namhocmoi[i] != '-')
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            pt.pnt1(" Nhập sai định dạng năm học yyyy - yyyy ! Nhấn phím bất kỳ để nhập lại", 6, 44);
                            Console.ForegroundColor = ConsoleColor.White;
                            ConsoleKeyInfo kt = Console.ReadKey();
                            switch (kt.Key)
                            {
                                default:
                                    Console.ForegroundColor = ConsoleColor.Black;
                                    pt.pnt1("                                                                         ", 6, 44);
                                    pt.pnt1("               ", 34, 14);
                                    Console.ResetColor();
                                    goto namhoc;
                            }

                        }
                    }
                    if (namhocmoi.Length < 7)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        pt.pnt1(" Nhập sai định dạng năm học yyyy - yyyy ! Nhấn phím bất kỳ để nhập lại", 6, 44);
                        Console.ForegroundColor = ConsoleColor.White;
                        ConsoleKeyInfo kt = Console.ReadKey();
                        switch (kt.Key)
                        {
                            default:
                                Console.ForegroundColor = ConsoleColor.Black;
                                pt.pnt1("                                                                                  ", 6, 44);
                                pt.pnt1("               ", 34, 14);
                                Console.ResetColor();
                                goto namhoc;
                        }

                    }
                    DateTime nht = DateTime.Now;
                    string[] nh = namhocmoi.Split('-');
                    decimal nbd = Convert.ToDecimal(nh[0]);
                    decimal nkt = Convert.ToDecimal(nh[1]);
                    if (nbd > nht.Year || nkt > nht.Year || nbd > nkt)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        pt.pnt1(" Năm học không đúng ! Nhấn phím bất kỳ để nhập lại", 6, 44);
                        Console.ForegroundColor = ConsoleColor.White;
                        ConsoleKeyInfo kt = Console.ReadKey();
                        switch (kt.Key)
                        {
                            default:
                                Console.ForegroundColor = ConsoleColor.Black;
                                pt.pnt1("                                                                   ", 6, 44);
                                pt.pnt1("               ", 34, 14);
                                Console.ResetColor();
                                goto namhoc;
                        }

                    }
                    // sua ma lop khi hoc sinh chuyen lop 
                    pt.pnt1("", 67, 14);
                    Console.BackgroundColor = ConsoleColor.Black;
                    pt.pnt1("            ", 67, 14);
                    pt.pnt1("", 67, 14);
                    Console.ResetColor();
                    malop:
                    pt.pnt1("", 67, 14); malopmoi = Console.ReadLine();
                    if (malopmoi == "")
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        pt.pnt1(" Mã lớp không rỗng ! Nhấn phím bất kỳ để nhập lại", 6, 44);
                        Console.ForegroundColor = ConsoleColor.White;
                        ConsoleKeyInfo kt = Console.ReadKey();
                        switch (kt.Key)
                        {
                            default:
                                Console.ForegroundColor = ConsoleColor.Black;
                                pt.pnt1("                                                                   ", 6, 44);
                                pt.pnt1("            ", 67, 14);
                                Console.ResetColor();
                                goto malop;
                        }

                    }
                    if (lopbll.KTmalop(malopmoi) == true)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        pt.pnt1(" Mã lớp không tồn tại trong hệ thống ! Nhấn phím bất kỳ để nhập lại", 6, 44);
                        pt.pnt1(" Nhấn H để lấy ra danh sách các mã lớp ", 6, 45);
                        Console.ForegroundColor = ConsoleColor.White;
                        ConsoleKeyInfo kt = Console.ReadKey();
                        switch (kt.Key)
                        {
                            case ConsoleKey.H:
                                Console.Clear();
                                tt.dsmalop();
                                break;
                            default:
                                Console.ForegroundColor = ConsoleColor.Black;
                                pt.pnt1("                                                                       ", 6, 44);
                                pt.pnt1("                                                                       ", 6, 45);
                                pt.pnt1("            ", 67, 14);
                                Console.ResetColor();
                                goto malop;
                        }
                    }
                    HocSinh hocs = new HocSinh(mahss, tenhsmoi, ngaysinhmoi, gioitinhmoi, diachimoi, sdtbomemoi, namhocmoi, malopmoi);
                    pt.pnt1(" Nhấn Enter để sửa tiếp", 6, 44);
                    pt.pnt1(" Nhấn Tab để quay lại ", 6, 45);
                    den: ConsoleKeyInfo ktttt = Console.ReadKey();
                    Console.ForegroundColor = ConsoleColor.White;
                    switch (ktttt.Key)
                    {
                        case ConsoleKey.Enter:
                            hsBLL.Xoahs(mahss);
                            hsBLL.Themhs(hocs);
                            Console.BackgroundColor = ConsoleColor.Black;
                            pt.pnt1("       ", 34, 16);
                            pt.pnt1("                          ", 6, 44);
                            pt.pnt1("                            ", 6, 45);
                            pt.pnt1("                     ", 67, 10);
                            pt.pnt1("                 ", 102, 10);
                            pt.pnt1("         ", 32, 12);
                            pt.pnt1("                ", 67, 12);
                            pt.pnt1("                   ", 102, 12);
                            pt.pnt1("           ", 32, 14);
                            pt.pnt1("         ", 67, 14);
                            pt.pnt1("1. Thêm học sinh   ", 88, 43);
                            pt.pnt1("2. Sửa học sinh   ", 88, 44);
                            pt.pnt1("3. Xóa học sinh   ", 88, 45);
                            pt.pnt1("4. Đưa ra danh sách học sinh   ", 88, 46);
                            pt.pnt1("5. Để quay lại menu chính   ", 88, 47);
                            pt.pnt1("6. Để thoát khỏi chương trình   ", 88, 48);
                            pt.pnt1("Nhấn", 88, 49);
                            Console.ForegroundColor = ConsoleColor.Green;
                            pt.pnt1("H", 93, 49);
                            Console.ForegroundColor = ConsoleColor.White;
                            pt.pnt1("để mở thanh công cụ và", 95, 49);
                            Console.ForegroundColor = ConsoleColor.Green;
                            pt.pnt1("E", 118, 49);
                            Console.ForegroundColor = ConsoleColor.White;
                            pt.pnt1("để tắt", 120, 49);
                            pt.pnt1("", 104, 50);
                            pt.pnt1("", 104, 50);
                            for (int i = 25; i < 42; ++i)
                            {
                                pt.pnt1("       ", 8, i);
                                pt.pnt1("               ", 22, i);
                                pt.pnt1("           ", 40, i);
                                pt.pnt1("      ", 54, i);
                                pt.pnt1("            ", 67, i);
                                pt.pnt1("            ", 88, i);
                                pt.pnt1("          ", 104, i);
                                pt.pnt1("      ", 120, i);
                            }
                            goto label;

                        case ConsoleKey.Tab:
                            pt.pnt1("                          ", 6, 44);
                            pt.pnt1("                            ", 6, 45);
                            pt.pnt1("1. Thêm học sinh   ", 88, 43);
                            pt.pnt1("2. Sửa học sinh   ", 88, 44);
                            pt.pnt1("3. Xóa học sinh   ", 88, 45);
                            pt.pnt1("4. Đưa ra danh sách học sinh   ", 88, 46);
                            pt.pnt1("5. Để quay lại menu chính   ", 88, 47);
                            pt.pnt1("6. Để thoát khỏi chương trình   ", 88, 48);
                            pt.pnt1("Nhấn", 88, 49);
                            Console.ForegroundColor = ConsoleColor.Green;
                            pt.pnt1("H", 93, 49);
                            Console.ForegroundColor = ConsoleColor.White;
                            pt.pnt1("để mở thanh công cụ và", 95, 49);
                            Console.ForegroundColor = ConsoleColor.Green;
                            pt.pnt1("E", 118, 49);
                            Console.ForegroundColor = ConsoleColor.White;
                            pt.pnt1("để tắt", 120, 49);
                            pt.pnt1("", 104, 50);
                            pt.pnt1("", 104, 50);
                            pt.pnt1("", 104, 50);
                            goto Suahs;
                        default:
                            Console.ForegroundColor = ConsoleColor.Red;
                            pt.pnt1("      ", 15, 46);
                            pt.pnt1(" Bạn nhập sai xin nhập lại", 85, 47);
                            pt.pnt1("", 15, 46);
                            goto den;
                    }
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    pt.pnt1(" Mã học sinh không tồn tại ! Nhấn 1 phím bất kỳ để nhập lại ", 6, 44);
                    Console.ForegroundColor = ConsoleColor.White;
                    ConsoleKeyInfo kt = Console.ReadKey();
                    switch (kt.Key)
                    {
                        default:
                            Console.ForegroundColor = ConsoleColor.Black;
                            pt.pnt1("                                                                     ", 6, 44);
                            pt.pnt1("           ", 34, 16);
                            Console.ResetColor();
                            goto Suahs1;
                    }
                }

            } while (true);
            #endregion
        #region Xóa các thông tin của học sinh
            Xoahs:
        Xoahs1: string mahsx;
            do
            {
                try
                {
                    pt.pnt1("", 72, 13); mahsx = Console.ReadLine();
                }
                catch
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    pt.pnt1("Mã học sinh sai ! Nhấn phím bất kỳ nhập lại", 6, 44);
                    Console.ForegroundColor = ConsoleColor.White;
                    ConsoleKeyInfo kt = Console.ReadKey();
                    switch (kt.Key)
                    {
                        default:
                            pt.pnt1("                                                                   ", 6, 44);
                            Console.ResetColor();
                            goto Xoahs1;

                    }
                }
                if (mahsx == "")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    pt.pnt1("Mã học sinh không được rỗng ! Nhấn phím bất kỳ nhập lại", 6, 44);
                    pt.pnt1("Nhấn Tab để quay lại", 6, 45);
                    Console.ForegroundColor = ConsoleColor.White;
                    ConsoleKeyInfo kt = Console.ReadKey();
                    switch (kt.Key)
                    {
                        case ConsoleKey.Tab:
                            pt.pnt1("              ", 56, 8);
                            pt.pnt1("━━━━━━━━━━━━━━━━━━", 56, 8);
                            pt.pnt1("                            ", 47, 13);
                            pt.pnt1("                                                         ", 6, 44);
                            pt.pnt1("                                ", 6, 45);
                            pt.pnt1("1. Thêm học sinh   ", 88, 43);
                            pt.pnt1("2. Sửa học sinh   ", 88, 44);
                            pt.pnt1("3. Xóa học sinh   ", 88, 45);
                            pt.pnt1("4. Đưa ra danh sách học sinh   ", 88, 46);
                            pt.pnt1("5. Để quay lại menu chính   ", 88, 47);
                            pt.pnt1("6. Để thoát khỏi chương trình   ", 88, 48);
                            pt.pnt1("Nhấn", 88, 49);
                            Console.ForegroundColor = ConsoleColor.Green;
                            pt.pnt1("H", 93, 49);
                            Console.ForegroundColor = ConsoleColor.White;
                            pt.pnt1("để mở thanh công cụ và", 95, 49);
                            Console.ForegroundColor = ConsoleColor.Green;
                            pt.pnt1("E", 118, 49);
                            Console.ForegroundColor = ConsoleColor.White;
                            pt.pnt1("để tắt", 120, 49);
                            pt.pnt1("", 104, 50);
                            pt.pnt1("", 104, 50);
                            goto chucnang;
                        default:
                            pt.pnt1("                                                                   ", 6, 44);
                            pt.pnt1("                                   ", 6, 45);
                            Console.ResetColor();
                            goto Xoahs1;

                    }
                }
                if (hsBLL.KTmahs(mahsx) == false)
                {
                    pt.pnt1(" Nhấn Enter để xóa", 6, 44);
                    pt.pnt1(" Nhấn Tab để quay lại chức năng ", 6, 45);
                    ConsoleKeyInfo ktkt = Console.ReadKey();
                    switch (ktkt.Key)
                    {
                        case ConsoleKey.Enter:
                            hsBLL.Xoahs(mahsx);
                            bdbll.XoaAll(mahsx);
                            pt.pnt1("       ", 34, 16);
                            pt.pnt1("                          ", 6, 44);
                            pt.pnt1("                                ", 6, 45);
                            pt.pnt1("                       ", 67, 10);
                            pt.pnt1("                 ", 102, 10);
                            pt.pnt1("         ", 32, 12);
                            pt.pnt1("                ", 67, 12);
                            pt.pnt1("                   ", 102, 12);
                            pt.pnt1("                 ", 32, 14);
                            pt.pnt1("         ", 67, 14);
                            pt.pnt1("         ", 72, 13);
                            pt.pnt1("1. Thêm học sinh   ", 88, 43);
                            pt.pnt1("2. Sửa học sinh   ", 88, 44);
                            pt.pnt1("3. Xóa học sinh   ", 88, 45);
                            pt.pnt1("4. Đưa ra danh sách học sinh   ", 88, 46);
                            pt.pnt1("5. Để quay lại menu chính   ", 88, 47);
                            pt.pnt1("6. Để thoát khỏi chương trình   ", 88, 48);
                            pt.pnt1("Nhấn", 88, 49);
                            Console.ForegroundColor = ConsoleColor.Green;
                            pt.pnt1("H", 93, 49);
                            Console.ForegroundColor = ConsoleColor.White;
                            pt.pnt1("để mở thanh công cụ và", 95, 49);
                            Console.ForegroundColor = ConsoleColor.Green;
                            pt.pnt1("E", 118, 49);
                            Console.ForegroundColor = ConsoleColor.White;
                            pt.pnt1("để tắt", 120, 49);
                            pt.pnt1("", 104, 50);
                            pt.pnt1("", 104, 50);
                            for (int i = 25; i < 42; ++i)
                            {
                                pt.pnt1("    ", 9, i);
                                pt.pnt1("                 ", 19, i);
                                pt.pnt1("           ", 40, i);
                                pt.pnt1("     ", 55, i);
                                pt.pnt1("            ", 67, i);
                                pt.pnt1("            ", 88, i);
                                pt.pnt1("         ", 104, i);
                                pt.pnt1("      ", 122, i);
                            }
                            goto label;
                        case ConsoleKey.Tab:
                            pt.pnt1("              ", 56, 8);
                            pt.pnt1("━━━━━━━━━━━━━━━━━━", 56, 8);
                            pt.pnt1("                            ", 47, 13);
                            pt.pnt1("                          ", 6, 44);
                            pt.pnt1("                                ", 6, 45);
                            pt.pnt1("1. Thêm học sinh   ", 88, 43);
                            pt.pnt1("2. Sửa học sinh   ", 88, 44);
                            pt.pnt1("3. Xóa học sinh   ", 88, 45);
                            pt.pnt1("4. Đưa ra danh sách học sinh   ", 88, 46);
                            pt.pnt1("5. Để quay lại menu chính   ", 88, 47);
                            pt.pnt1("6. Để thoát khỏi chương trình   ", 88, 48);
                            pt.pnt1("Nhấn", 88, 49);
                            Console.ForegroundColor = ConsoleColor.Green;
                            pt.pnt1("H", 93, 49);
                            Console.ForegroundColor = ConsoleColor.White;
                            pt.pnt1("để mở thanh công cụ và", 95, 49);
                            Console.ForegroundColor = ConsoleColor.Green;
                            pt.pnt1("E", 118, 49);
                            Console.ForegroundColor = ConsoleColor.White;
                            pt.pnt1("để tắt", 120, 49);
                            pt.pnt1("", 104, 50);
                            pt.pnt1("", 104, 50);
                            goto chucnang;
                    }
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    pt.pnt1(" Mã học sinh không tồn tại ! Nhấn 1 phím bất kỳ để nhập lại ", 6, 44);
                    Console.ForegroundColor = ConsoleColor.White;
                    ConsoleKeyInfo kt = Console.ReadKey();
                    switch (kt.Key)
                    {
                        default:
                            Console.ForegroundColor = ConsoleColor.Black;
                            pt.pnt1("                                                                     ", 6, 44);
                            pt.pnt1("         ", 72, 13);
                            Console.ResetColor();
                            goto Xoahs1;
                    }
                }

            } while (true);
        #endregion
        #region Hiển thị thông của các học sinh
        hienthi:
            pt.pnt1("┏", 4, 8);
            pt.pnt1("┗", 4, 40);
            pt.pnt1("┓", 133, 8);
            pt.pnt1("━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━", 5, 8);
            pt.pnt1("━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━", 5, 14);
            pt.pnt1("                                              TRƯỜNG ĐẠI HỌC SƯ PHẠM KỸ THUẬT HƯNG YÊN ", 0, 1);
            pt.pnt1("                                                      KHOA CÔNG NGHỆ THÔNG TIN ", 1, 2);
            pt.pnt1("                                                     ------- ○○○○ -------", 3, 3);
            for (int i = 9; i < 40; ++i)
            {
                pt.pnt1("┃", 4, i);
                pt.pnt1("┃", 133, i);
            }
            pt.pnt1("┛", 133, 40);

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
            pt.pnt1("━━━━━━━━━━━━┳━━━━━━━━━━━━━━━━━━━━┳━━━━━━━━━━━━━━┳━━━━━━━┳━━━━━━━━━━━━━━━━━━━━━━┳━━━━━━━━━━━━━━━━┳━━━━━━━━━━━━━━━┳━━━━━━━━━━━━━━━", 5, 11);
            pt.pnt1("━━━━━━━━━━━━┻━━━━━━━━━━━━━━━━━━━━┻━━━━━━━━━━━━━━┻━━━━━━━┻━━━━━━━━━━━━━━━━━━━━━━┻━━━━━━━━━━━━━━━━┻━━━━━━━━━━━━━━━┻━━━━━━━━━━━━━━━", 5, 40);



            for (int i = 12; i < 40; i++)
            {
                pt.pnt1("┃", 17, i);
                pt.pnt1("┃", 38, i);
                pt.pnt1("┃", 53, i);
                pt.pnt1("┃", 61, i);
                pt.pnt1("┃", 84, i);
                pt.pnt1("┃", 101, i);
                pt.pnt1("┃", 117, i);
            }

            pt.pnt1("DANH SÁCH HỌC SINH ", 59, 10);
            pt.pnt1(" Mã HS ", 8, 12);
            pt.pnt1(" Tên HS", 22, 12);
            pt.pnt1(" Ngày sinh", 40, 12);
            pt.pnt1(" GT", 56, 12);
            pt.pnt1(" Địa chỉ", 67, 12);
            pt.pnt1(" SĐT(bố/mẹ)", 87, 12);
            pt.pnt1(" Năm học", 104, 12);
            pt.pnt1(" Mã lớp", 120, 12);
            Console.ForegroundColor = ConsoleColor.Green;
            pt.pnt1("→ 4. Đưa ra danh sách học sinh", 85, 43);
            Console.ForegroundColor = ConsoleColor.White;
            pt.pnt1("Nhấn Tab quay lại 1 ", 85, 44);
            pt.pnt1("Nhấn LeftArrow hoặc RightArrow để chuyển trang", 85, 45);
            List<HocSinh> hs = hsBLL.LayDlhs();
            int slhs = 0;
            for (int i = 0; i < hs.Count; ++i)
            {
                slhs++;
            }
            if (slhs > 0)
            {
                int sd = 13;
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
            label5:
                vetrang(t);
                pt.pnt1("", 5, 7); Console.WriteLine("{0}/{1} trang ◄ {2} ►", t, st, t);
                goto label4;
            label4:
                pt.pnt1("", 132, 45);
                ConsoleKeyInfo p;
                p = Console.ReadKey();
                switch (p.Key)
                {
                    case ConsoleKey.LeftArrow:
                        if (t == 1)
                        {
                            t = 1;
                            pt.pnt1("                                ", 85, 46);
                            goto label4;
                        }
                        else
                        {
                            t--;
                            pt.pnt1("                                ", 85, 46);
                            goto label5;
                        }
                    case ConsoleKey.RightArrow:
                        if (t == st)
                        {
                            t = st;
                            pt.pnt1("                                ", 85, 46);
                            goto label4;
                        }
                        else
                        {
                            t++;
                            pt.pnt1("                                ", 85, 46);
                            goto label5;
                        }
                    case ConsoleKey.Tab:
                        Console.Clear();
                        goto top;
                    case ConsoleKey.Escape:
                        return;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        pt.pnt1("     ", 132, 45);
                        pt.pnt1(" Bạn nhập sai xin nhập lại ", 85, 46);
                        pt.pnt1("", 132, 45);
                        Console.ForegroundColor = ConsoleColor.White;
                        goto label4;
                }

            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                pt.pnt1(" Hệ thống không có sinh viên. Nhấn Tab để quay lại ", 10, 42);
                Console.ForegroundColor = ConsoleColor.White;
            label6: ConsoleKeyInfo ktkt = Console.ReadKey();
                switch (ktkt.Key)
                {
                    case ConsoleKey.Tab:
                        Console.Clear();
                        goto top;
                    default:
                        pt.pnt1("Nhập sai xin nhập lại ", 10, 43);
                        goto label6;
                }
            }
            #endregion

        }
        #region Vẽ trang 
        public void vetrang(int chisotrang)
        {
            for (int i = 15; i < 40; ++i)
            {
                pt.pnt1("       ", 8, i);
                pt.pnt1("                  ", 19, i);
                pt.pnt1("          ", 40, i);
                pt.pnt1("     ", 55, i);
                pt.pnt1("            ", 67, i);
                pt.pnt1("           ", 88, i);
                pt.pnt1("          ", 104, i);
                pt.pnt1("        ", 120, i);
            }
            int a = 15;
            int d1 = 0;
            int sodong = 13;
            List<HocSinh> h = hsBLL.LayDlhs();
            int d = (chisotrang - 1) * sodong + 1;
            for (int i = 0; i < h.Count; ++i)
            {
                d1++;
                if ((d1 >= d) && (d1 <= chisotrang * 13))
                {
                    pt.pnt1(h[i].Mahs, 8, a);
                    pt.pnt1(h[i].Tenhs, 19, a);
                    pt.pnt1(h[i].Ngaysinh, 40, a);
                    pt.pnt1(h[i].Gioitinh, 56, a);
                    pt.pnt1(h[i].Diachi, 67, a);
                    pt.pnt1(h[i].Sdtbome, 88, a);
                    pt.pnt1(h[i].Namhoc, 104, a);
                    pt.pnt1(h[i].Malop, 122, a);
                    a = a + 2;
                }
            }
        }
        #endregion
    }
}
