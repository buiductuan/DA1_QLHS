using System;
using System.Linq;
using System.Text;
using QLHS.Utility;
using QLHS.Presenations;
using QLHS.Entities;
using QLHS.Business.Components;
using QLHS.Business.Service_Interface;
using QLHS.DataAccessLayer.Service_Interface;
using QLHS.DataAccessLayer;
namespace QLHS.Presenations
{
    public class FormBangDiem
    {
        #region Giao diện và chức năng bảng điểm
        Paint pt = new Paint(150, 55);
        BangDiemBLL bdbll = new BangDiemBLL();
        HocSinhBLL hsbll = new HocSinhBLL();
        BangDiemDAL bdda = new BangDiemDAL();
        LopBLL lopbll = new LopBLL();
        MonHocBLL mhbll = new MonHocBLL();
        TinhDiemBLL tdbll = new TinhDiemBLL();
        public static FormHS fhs = new FormHS();
        public static FormGVCN fgv = new FormGVCN();
        public static FormLop flop = new FormLop();
        public static FormTimKiem ff = new FormTimKiem();
        public static FormMonHoc fmh = new FormMonHoc();
        public static FormThongKe ftk = new FormThongKe();
        public static MenuChinh mn = new MenuChinh();
        #region Chức năng quản lý điểm học sinh
        public void themdiem()
        {
            top:
            pt.pnt2("┏", 4, 8);
            pt.pnt2("┗", 4, 54);
            pt.pnt2("┓", 157, 8);
            pt.pnt2("┛", 157, 54);

            pt.pnt2("━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━", 5, 8);
            pt.pnt2("━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━", 5, 54);
            pt.pnt2("                                                      TRƯỜNG ĐẠI HỌC SƯ PHẠM KỸ THUẬT HƯNG YÊN ", 0, 1);
            pt.pnt2("                                                             KHOA CÔNG NGHỆ THÔNG TIN ", 0, 2);
            pt.pnt2("                                                              ------- oooo -------", 0, 3);
            for (int i = 9; i < 54; ++i)
            {
                pt.pnt2("┃", 4, i);
                pt.pnt2("┃", 157, i);
            }
            pt.pnt2("━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━", 5, 17);
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
            pt.pnt2("Designed by TeamT ™", 5, 53);
            Console.ForegroundColor = ConsoleColor.White;
            pt.pnt2("━━━━━━━━━━┳━━━━━━━━━━━━━━━━━━━━┳━━━━━━━━━━━━━━━━━━━┳━━━━━━━━━━━━━━━━━━┳━━━━━━━━━━━━━━━━━━━━━━━┳━━━━━━━━━━━━━━━┳━━━━━━━━━━━━━━━┳━━━━━━━━━━━━━┳━━━━━━━━━", 6, 22);
            pt.pnt2("━━━━━━━━━━┻━━━━━━━━━━━━━━━━━━━━┻━━━━━━━━━━━━━━━━━━━┻━━━━━━━━━━━━━━━━━━┻━━━━━━━━━━━━━━━━━━━━━━━┻━━━━━━━━━━━━━━━┻━━━━━━━━━━━━━━━┻━━━━━━━━━━━━━┻━━━━━━━━━", 6, 24);

            pt.pnt2("━━━━━━━━━━┻━━━━━━━━━━━━━━━━━━━━┻━━━━━━━━━━━━━━━━━━━┻━━━━━━━━━━━━━━━━━━┻━━━━━━━━━━━━━━━━━━━━━━━┻━━━━━━━━━━━━━━━┻━━━━━━━━━━━━━━━┻━━━━━━━━━━━━━┻━━━━━━━━━", 6, 42);


            for (int i = 23; i < 42; i++)
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

            pt.pnt2("1. Thêm bảng điểm", 115, 43);
            pt.pnt2("2. Sửa bảng điểm", 115, 44);
            pt.pnt2("3. Xóa bảng điểm", 115, 45);
            pt.pnt2("4. Đưa ra danh sách bảng điểm", 115, 46);
            pt.pnt2("5. Tính điểm tổng kết", 115, 47);
            pt.pnt2("6. Để quay lại menu chính", 115, 48);
            pt.pnt2("7. Để thoát khỏi chương trình", 115, 49);
            pt.pnt2("Nhấn", 115, 50);
            Console.ForegroundColor = ConsoleColor.Green;
            pt.pnt2("H", 120, 50);
            Console.ForegroundColor = ConsoleColor.White;
            pt.pnt2("để mở thanh công cụ và", 122, 50);
            Console.ForegroundColor = ConsoleColor.Green;
            pt.pnt2("E", 145, 50);
            Console.ForegroundColor = ConsoleColor.White;
            pt.pnt2("để tắt", 147, 50);

            // Lấy danh sách điểm
            danhsach: List<BangDiem> listbd = bdbll.LayDlbd();
            bdda.BackUp(listbd);
            int a = 25;
            int tmp = 0;
            for (int i = 0; i < listbd.Count; ++i)
            {
                if (tmp < 9)
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
                    tmp++;
                    a += 2;
                }
                else
                    break;
            }
            pt.pnt2("Chọn chức năng : ", 115, 51);
            chucnang: ConsoleKeyInfo ktktt = Console.ReadKey();
            Console.ForegroundColor = ConsoleColor.White;
            switch (ktktt.KeyChar)
            {
                case '1':
                    pt.pnt2(" Thêm bảng điểm ", 62, 8);
                    pt.pnt2("               ", 115, 43);
                    Console.ForegroundColor = ConsoleColor.Green;
                    pt.pnt2("→ 1. Thêm bảng điểm", 115, 43);
                    Console.ForegroundColor = ConsoleColor.White;
                    pt.pnt2("    ", 132, 51);
                    pt.pnt2("                             ", 115, 52);

                    pt.pnt2("                             ", 10, 10);
                    pt.pnt2("                             ", 54, 10);
                    pt.pnt2("                              ", 88, 10);
                    pt.pnt2("                             ", 18, 14);
                    pt.pnt2("                              ", 54, 14);
                    pt.pnt2("                              ", 96, 14);
                    pt.pnt2("                              ", 120, 10);
                    pt.pnt2("                             ", 18, 16);

                    pt.pnt2("                          ", 10, 14);
                    pt.pnt2("                          ", 54, 14);
                    pt.pnt2("                          ", 88, 14);
                    pt.pnt2("                          ", 120, 14);


                    pt.pnt2("Mã học sinh   : ", 18, 10);
                    pt.pnt2("Mã lớp        :", 54, 10);
                    pt.pnt2("Mã môn       : ", 96, 10);
                    pt.pnt2("Học kỳ        : ", 18, 12);
                    pt.pnt2("Điểm giữa kỳ  : ", 54, 12);
                    pt.pnt2("Điểm cuối kỳ : ", 96, 12);
                    pt.pnt2("Hạnh kiểm kỳ  : ", 18, 14);
                    pt.pnt2("Năm học       :", 54, 14);
                    goto themdiem;
                case '2':
                    pt.pnt2(" Sửa bảng điểm ", 62, 8);
                    pt.pnt2("               ", 115, 43);
                    pt.pnt2("               ", 115, 44);
                    pt.pnt2("1. Thêm bảng điểm", 115, 43);
                    Console.ForegroundColor = ConsoleColor.Green;
                    pt.pnt2("→ 2. Sửa bảng điểm", 115, 44);
                    Console.ForegroundColor = ConsoleColor.White;
                    pt.pnt2("    ", 132, 51);
                    pt.pnt2("                             ", 115, 52);

                    pt.pnt2("                    ", 18, 10);
                    pt.pnt2("                    ", 54, 10);
                    pt.pnt2("                     ", 96, 10);
                    pt.pnt2("                     ", 18, 12);
                    pt.pnt2("                     ", 54, 12);
                    pt.pnt2("                     ", 96, 12);
                    pt.pnt2("                     ", 18, 14);
                    pt.pnt2("                    ", 54, 14);

                    pt.pnt2("                          ", 10, 14);
                    pt.pnt2("                          ", 54, 14);
                    pt.pnt2("                          ", 88, 14);
                    pt.pnt2("                          ", 120, 14);

                    Console.ForegroundColor = ConsoleColor.Yellow;
                    pt.pnt2("Mã học sinh cần sửa   : ", 10, 10);
                    pt.pnt2("Mã lớp        :", 54, 10);
                    pt.pnt2("Mã môn cần sửa       : ", 88, 10);
                    pt.pnt2("Học kỳ        : ", 120, 10);
                    Console.ForegroundColor = ConsoleColor.White;
                    pt.pnt2("Điểm giữa kỳ  : ", 18, 14);
                    pt.pnt2("Điểm cuối kỳ  : ", 54, 14);
                    pt.pnt2("Hạnh kiểm kỳ : ", 96, 14);
                    pt.pnt2("Năm học       :", 18, 16);

                    goto suadiem;
                case '3':
                    pt.pnt2(" Xóa bảng điểm ", 62, 8);
                    pt.pnt2("               ", 115, 43);
                    pt.pnt2("               ", 115, 44);
                    pt.pnt2("1. Thêm bảng điểm", 115, 43);
                    pt.pnt2("2. Sửa bảng điểm", 115, 44);
                    Console.ForegroundColor = ConsoleColor.Green;
                    pt.pnt2("→ 3. Xóa bảng điểm", 115, 45);
                    Console.ForegroundColor = ConsoleColor.White;
                    pt.pnt2("    ", 132, 51);
                    pt.pnt2("                             ", 115, 52);

                    pt.pnt2("                    ", 18, 10);
                    pt.pnt2("                    ", 54, 10);
                    pt.pnt2("                     ", 96, 10);
                    pt.pnt2("                     ", 18, 12);
                    pt.pnt2("                     ", 54, 12);
                    pt.pnt2("                     ", 96, 12);
                    pt.pnt2("                     ", 18, 14);
                    pt.pnt2("                    ", 54, 14);

                    pt.pnt2("                             ", 10, 10);
                    pt.pnt2("                             ", 54, 10);
                    pt.pnt2("                              ", 88, 10);
                    pt.pnt2("                             ", 18, 14);
                    pt.pnt2("                              ", 54, 14);
                    pt.pnt2("                              ", 96, 14);
                    pt.pnt2("                              ", 120, 10);
                    pt.pnt2("                             ", 18, 16);

                    Console.ForegroundColor = ConsoleColor.Yellow;
                    pt.pnt2("Mã học sinh cần xóa   : ", 10, 14);
                    pt.pnt2("Mã lớp        :", 54, 14);
                    pt.pnt2("Mã môn cần xóa       : ", 88, 14);
                    pt.pnt2("Nhập học kỳ cần xóa : ", 120, 14);
                    Console.ForegroundColor = ConsoleColor.White;
                    goto xoadiem;
                case '4':
                    Console.Clear();
                    goto hiendiem;
                case '5':
                    Console.Clear();
                    tinhdiemtbky1();
                    break;
                case '6':
                    Console.Clear();
                    mn.MenuChinh1();
                    break;
                case 'G':
                    Console.Clear();
                    fgv.themgv();
                    break;
                case 'S':
                    Console.Clear();
                    fhs.themhs();
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
                    pt.pnt2("G : Quản lý Giáo Viên", 4, 6);
                    pt.pnt2("S : Quản lý Học sinh", 30, 6);
                    pt.pnt2("M : Quản lý Môn học", 52, 6);
                    pt.pnt2("T : Tìm kiếm", 76, 6);
                    pt.pnt2("K : Thống kê", 96, 6);
                    pt.pnt2("L : Quản lý Lớp", 114, 6);
                    pt.pnt2("                           ", 88, 51);
                    pt.pnt2("  ", 132, 51);
                    pt.pnt2("", 132, 51);
                    Console.ForegroundColor = ConsoleColor.White;
                    goto chucnang;
                case 'E':
                    pt.pnt2("                       ", 4, 6);
                    pt.pnt2("                       ", 30, 6);
                    pt.pnt2("                       ", 52, 6);
                    pt.pnt2("                       ", 76, 6);
                    pt.pnt2("                       ", 96, 6);
                    pt.pnt2("                       ", 114, 6);
                    pt.pnt2("                          ", 88, 51);
                    pt.pnt2("  ", 132, 51);
                    pt.pnt2("", 132, 51);
                    goto chucnang;
                case '7':
                    Environment.Exit(0); break;
                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    pt.pnt2("      ", 132, 51);
                    pt.pnt2("Bạn nhập sai xin nhập lại", 115, 52);
                    pt.pnt2("", 132, 51);
                    Console.ForegroundColor = ConsoleColor.White;
                    goto chucnang;
            }

            #region Thêm điểm
            themdiem:
            string mahs, malop, mamon, diemgiuaky, diemcuoiky, hanhkiemky, hocky, namhoc;
            pt.pnt2("", 33, 10); mahs = Console.ReadLine();
            if (mahs == "")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                pt.pnt2("Mã không rỗng ! Nhấn phím bất kỳ để nhập lại ", 15, 44);
                pt.pnt2("Tab để quay lại", 15, 45);
                Console.ForegroundColor = ConsoleColor.White;
                ConsoleKeyInfo kt = Console.ReadKey();
                switch (kt.Key)
                {
                    case ConsoleKey.Tab:
                        pt.pnt2("                                            ", 15, 44);
                        pt.pnt2("                                            ", 15, 45);

                        pt.pnt2("                    ", 18, 10);
                        pt.pnt2("                    ", 54, 10);
                        pt.pnt2("                     ", 96, 10);
                        pt.pnt2("                     ", 18, 12);
                        pt.pnt2("                     ", 54, 12);
                        pt.pnt2("                     ", 96, 12);
                        pt.pnt2("                     ", 18, 14);
                        pt.pnt2("                    ", 54, 14);
                        pt.pnt2("                        ", 62, 8);
                        pt.pnt2("━━━━━━━━━━━━━━━━━━━━━━━━", 62, 8);
                        pt.pnt2("1. Thêm bảng điểm     ", 115, 43);
                        pt.pnt2("2. Sửa bảng điểm", 115, 44);
                        pt.pnt2("3. Xóa bảng điểm", 115, 45);
                        pt.pnt2("4. Đưa ra danh sách bảng điểm", 115, 46);
                        pt.pnt2("5. Tính điểm tổng kết", 115, 47);
                        pt.pnt2("6. Để quay lại menu chính", 115, 48);
                        pt.pnt2("7. Để thoát khỏi chương trình", 115, 49);
                        pt.pnt2("Nhấn", 115, 50);
                        Console.ForegroundColor = ConsoleColor.Green;
                        pt.pnt2("H", 120, 50);
                        Console.ForegroundColor = ConsoleColor.White;
                        pt.pnt2("để mở thanh công cụ và", 122, 50);
                        Console.ForegroundColor = ConsoleColor.Green;
                        pt.pnt2("E", 145, 50);
                        Console.ForegroundColor = ConsoleColor.White;
                        pt.pnt2("để tắt", 147, 50);
                        pt.pnt2("", 132, 51);
                        goto chucnang;
                    default:
                        pt.pnt2("                                            ", 15, 44);
                        pt.pnt2("                                            ", 15, 45);
                        pt.pnt2("             ", 33, 10);
                        goto themdiem;
                }
            }
            if (hsbll.KTmahs(mahs) == false)
            {
                // tự động lấy mã lớp tương ứng
                pt.pnt2(hsbll.laymalop(mahs), 69, 10); malop = hsbll.laymalop(mahs);

            mamon:
                pt.pnt2("", 110, 10); mamon = Console.ReadLine();
                if (mamon == "")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    pt.pnt2("Mã môn không rỗng ! Nhấn phím bất kỳ để nhập lại ", 15, 45);
                    Console.ForegroundColor = ConsoleColor.White;
                    ConsoleKeyInfo kt = Console.ReadKey();
                    switch (kt.Key)
                    {
                        default:
                            pt.pnt2("                                                         ", 15, 45);
                            goto mamon;
                    }
                }
                if (mhbll.KTMamon(mamon) == false)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    pt.pnt2("Mã môn không tồn tại ! Nhấn phím bất kỳ để nhập lại ", 15, 45);
                    Console.ForegroundColor = ConsoleColor.White;
                    ConsoleKeyInfo kt = Console.ReadKey();
                    switch (kt.Key)
                    {
                        default:
                    pt.pnt2("                                                         ", 15, 45);
                            pt.pnt2("        ", 110, 10);
                            goto mamon;
                    }
                }
                hocky:
                pt.pnt2("", 33, 12); hocky = Console.ReadLine();
                if (hocky == "")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    pt.pnt2("Học kỳ không rỗng ! Nhấn phím bất kỳ để nhập lại ", 15, 45);
                    Console.ForegroundColor = ConsoleColor.White;
                    ConsoleKeyInfo kt = Console.ReadKey();
                    switch (kt.Key)
                    {
                        default:
                            pt.pnt2("                                                                               ", 15, 45);
                            goto hocky;
                    }
                }
                else
                {
                    for (int i = 0; i < hocky.Length; ++i)
                    {
                        if (hocky.Length > 3 || hocky[i] != 'I')
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            pt.pnt2("Sai định dạng học kỳ ! Nhấn phím bất kỳ để nhập lại ", 15, 48);
                            Console.ForegroundColor = ConsoleColor.White;
                            ConsoleKeyInfo kt = Console.ReadKey();
                            switch (kt.Key)
                            {
                                default:
                                    pt.pnt2("                                                                               ", 15, 48);
                                    pt.pnt2("             ", 33, 12);
                                    goto hocky;
                            }
                        }
                    }
                }
                if (bdbll.KTbd(mahs, hsbll.laymalop(mahs), mamon,hocky) == true)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    pt.pnt2("Môn này học sinh đã có điểm ! Nhấn phím bất kỳ để nhập lại ", 15, 45);
                    Console.ForegroundColor = ConsoleColor.White;
                    ConsoleKeyInfo kt = Console.ReadKey();
                    switch (kt.Key)
                    {
                        default:
                            pt.pnt2("                                                                               ", 15, 45);
                            pt.pnt2("                 ", 33, 12);
                            pt.pnt2("           ", 110, 10);
                            goto mamon;
                    }
                }
                if (mhbll.KTMamon(mamon) == false)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    pt.pnt2("Mã môn không tồn tại ! Nhấn phím bất kỳ để nhập lại ", 15, 45);
                    Console.ForegroundColor = ConsoleColor.White;
                    ConsoleKeyInfo kt = Console.ReadKey();
                    switch (kt.Key)
                    {
                        default:
                            pt.pnt2("                                                                               ", 15, 45);
                            pt.pnt2("                        ", 110, 10);
                            goto mamon;
                    }
                }
            diemgiuaky:
                pt.pnt2("", 69, 12); diemgiuaky = Console.ReadLine();
                if (diemgiuaky == "")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    pt.pnt2("Điểm không rỗng ! Nhấn phím bất kỳ để nhập lại ", 15, 45);
                    Console.ForegroundColor = ConsoleColor.White;
                    ConsoleKeyInfo kt = Console.ReadKey();
                    switch (kt.Key)
                    {
                        default:
                            pt.pnt2("                                                                               ", 15, 45);
                            goto diemgiuaky;
                    }

                }
                else
                {
                    for (int i = 0; i < diemgiuaky.Length; ++i)
                    {
                        if (diemgiuaky[i] != '0' && diemgiuaky[i] != '1' && diemgiuaky[i] != '2' && diemgiuaky[i] != '3' && diemgiuaky[i] != '4' && diemgiuaky[i] != '5' && diemgiuaky[i] != '6' && diemgiuaky[i] != '7' && diemgiuaky[i] != '8' && diemgiuaky[i] != '9')
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            pt.pnt2("Điểm không chứa ký tự ! Nhấn phím bất kỳ để nhập lại ", 15, 45);
                            Console.ForegroundColor = ConsoleColor.White;
                            ConsoleKeyInfo kt = Console.ReadKey();
                            switch (kt.Key)
                            {
                                default:
                                    pt.pnt2("                                                                               ", 15, 45);
                                    pt.pnt2("           ", 69, 12);
                                    goto diemgiuaky;
                            }
                        }
                    }
                    if (Convert.ToDouble(diemgiuaky) < 0 || Convert.ToDouble(diemgiuaky) > 10)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        pt.pnt2("Điểm không nhỏ hơn 0 và lớn hơn 10 ! Nhấn phím bất kỳ để nhập lại ", 15, 45);
                        Console.ForegroundColor = ConsoleColor.White;
                        ConsoleKeyInfo kt = Console.ReadKey();
                        switch (kt.Key)
                        {
                            default:
                                pt.pnt2("                                                                               ", 15, 45);
                                pt.pnt2("           ", 69, 12);
                                goto diemgiuaky;
                        }
                    }
                }
            diemcuoiky:
                pt.pnt2("", 110, 12); diemcuoiky = Console.ReadLine();
                if (diemcuoiky == "")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    pt.pnt2("Điểm không rỗng! Nhấn phím bất kỳ để nhập lại ", 15, 45);
                    Console.ForegroundColor = ConsoleColor.White;
                    ConsoleKeyInfo kt = Console.ReadKey();
                    switch (kt.Key)
                    {
                        default:
                            pt.pnt2("                                                                               ", 15, 48);
                            pt.pnt2("           ", 110, 12);
                            goto diemcuoiky;
                    }
                }
                else
                {
                    for (int i = 0; i < diemcuoiky.Length; ++i)
                    {
                        if (diemcuoiky[i] != '0' && diemcuoiky[i] != '1' && diemcuoiky[i] != '2' && diemcuoiky[i] != '3' && diemcuoiky[i] != '4' && diemcuoiky[i] != '5' && diemcuoiky[i] != '6' && diemcuoiky[i] != '7' && diemcuoiky[i] != '8' && diemcuoiky[i] != '9')
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            pt.pnt2("Điểm không chứa ký tự! Nhấn phím bất kỳ để nhập lại ", 15, 45);
                            Console.ForegroundColor = ConsoleColor.White;
                            ConsoleKeyInfo kt = Console.ReadKey();
                            switch (kt.Key)
                            {
                                default:
                                    pt.pnt2("                                                                               ", 15, 45);
                                    pt.pnt2("           ", 110, 12);
                                    goto diemcuoiky;
                            }
                        }
                    }
                    if (Convert.ToDouble(diemcuoiky) < 0 || Convert.ToDouble(diemcuoiky) > 10)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        pt.pnt2("Điểm không nhỏ hơn 0 và lớn hơn 10 Nhấn phím bất kỳ để nhập lại ", 15, 45);
                        Console.ForegroundColor = ConsoleColor.White;
                        ConsoleKeyInfo kt = Console.ReadKey();
                        switch (kt.Key)
                        {
                            default:
                                pt.pnt2("                                                                                      ", 15, 45);
                                pt.pnt2("           ", 110, 12);
                                goto diemcuoiky;
                        }
                    }
                }
            hanhkiemky:
                pt.pnt2("", 33, 14); hanhkiemky = Console.ReadLine();
                if (hanhkiemky == "")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    pt.pnt2("Hạnh kiểm không rỗng! Nhấn phím bất kỳ để nhập lại ", 15, 45);
                    Console.ForegroundColor = ConsoleColor.White;
                    ConsoleKeyInfo kt = Console.ReadKey();
                    switch (kt.Key)
                    {
                        default:
                            pt.pnt2("                                                                               ", 15, 45);
                            pt.pnt2("           ", 33, 14);
                            goto hanhkiemky;
                    }
                }
                else
                {
                    for (int i = 0; i < hanhkiemky.Length; ++i)
                    {
                        if (hanhkiemky[i] == '0' || hanhkiemky[i] == '1' || hanhkiemky[i] == '2' || hanhkiemky[i] == '3' || hanhkiemky[i] == '4' || hanhkiemky[i] == '5' || hanhkiemky[i] == '6' || hanhkiemky[i] == '7' || hanhkiemky[i] == '8' || hanhkiemky[i] == '9')
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            pt.pnt2("Hạnh kiểm không chứa số ! Nhấn phím bất kỳ để nhập lại ", 15, 45);
                            Console.ForegroundColor = ConsoleColor.White;
                            ConsoleKeyInfo kt = Console.ReadKey();
                            switch (kt.Key)
                            {
                                default:
                                    pt.pnt2("                                                                               ", 15, 45);
                                    pt.pnt2("           ", 33, 14);
                                    goto hanhkiemky;
                            }
                        }
                    }
                    if (hanhkiemky.Length < 3)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        pt.pnt2("Hạnh kiểm sai ! Nhấn phím bất kỳ để nhập lại ", 15, 45);
                        Console.ForegroundColor = ConsoleColor.White;
                        ConsoleKeyInfo kt = Console.ReadKey();
                        switch (kt.Key)
                        {
                            default:
                                pt.pnt2("                                                                               ", 15, 45);
                                pt.pnt2("           ", 33, 14);
                                goto hanhkiemky;
                        }
                    }
                }
            namhoc:

                pt.pnt2("", 69, 14); namhoc = Console.ReadLine();
                if (namhoc == "")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    pt.pnt2("Năm học không rỗng ! Nhấn phím bất kỳ để nhập lại ", 15, 45);
                    Console.ForegroundColor = ConsoleColor.White;
                    ConsoleKeyInfo kt = Console.ReadKey();
                    switch (kt.Key)
                    {
                        default:
                            pt.pnt2("                                                                               ", 15, 45);
                            goto namhoc;
                    }
                }
                else
                {
                    if (hsbll.KTnamhoc(namhoc) == false)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        pt.pnt2("Năm học không tồn tại ! Nhấn phím bất kỳ để nhập lại ", 15, 45);
                        Console.ForegroundColor = ConsoleColor.White;
                        ConsoleKeyInfo kt = Console.ReadKey();
                        switch (kt.Key)
                        {
                            default:
                                pt.pnt2("                                                                               ", 15, 45);
                                pt.pnt2("                 ", 69, 14);
                                goto namhoc;
                        }
                    }
                }

            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                pt.pnt2("Mã học sinh không tồn tại ! Nhấn phím bất kỳ để nhập lại ", 15, 45);
                Console.ForegroundColor = ConsoleColor.White;
                ConsoleKeyInfo kt = Console.ReadKey();
                switch (kt.Key)
                {
                    default:
                        pt.pnt2("                                                                               ", 15, 45);
                        pt.pnt2("                 ", 33, 10);
                        goto themdiem;
                }
            }
            BangDiem bd = new BangDiem(mahs, malop, mamon, Convert.ToDouble(diemgiuaky), Convert.ToDouble(diemcuoiky), hanhkiemky, hocky, namhoc);
            pt.pnt2("Nhấn Enter để lưu và nhập tiếp ", 6, 44);
            pt.pnt2("Nhấn Tab để quay lại ", 6, 45);
        label7: ConsoleKeyInfo ktt = Console.ReadKey();
            switch (ktt.Key)
            {
                case ConsoleKey.Enter:
                    Console.Clear();
                    bdbll.Thembd(bd);
                    themdiem();
                    break;
                case ConsoleKey.Tab:
                   

                case ConsoleKey.Escape:
                    return;
                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    pt.pnt2("Bạn nhập sai ! Xin nhập lại ", 6, 46);
                    Console.ForegroundColor = ConsoleColor.White;
                    goto label7;
            }
            #endregion

            #region Sửa điểm
            suadiem:
             string mahss, malops, mamons, hockys, diemgiuakymoi, diemcuoikymoi, hanhkiemkymoi, namhocmoi;
            pt.pnt2("", 34, 10); mahss = Console.ReadLine();
            if (mahss == "")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                pt.pnt2("Mã không được rỗng ! Nhấn phím bất kỳ nhập lại ", 15, 44);
                pt.pnt2("Nhấn Tab để quay lại ", 15, 45);
                Console.ForegroundColor = ConsoleColor.White;
                ConsoleKeyInfo kt = Console.ReadKey();
                switch (kt.Key)
                {
                    case ConsoleKey.Tab:
                        pt.pnt2("                                                         ", 15, 44);
                        pt.pnt2("                               ", 15, 45);
                        pt.pnt2("                             ", 10, 10);
                        pt.pnt2("                             ", 54, 10);
                        pt.pnt2("                              ", 88, 10);
                        pt.pnt2("                             ", 18, 14);
                        pt.pnt2("                              ", 54, 14);
                        pt.pnt2("                              ", 96, 14);
                        pt.pnt2("                              ", 120, 10);
                        pt.pnt2("                             ", 18, 16);
                        pt.pnt2("                        ", 62, 8);
                        pt.pnt2("━━━━━━━━━━━━━━━━━━━━━━━━", 62, 8);

                        pt.pnt2("1. Thêm bảng điểm     ", 115, 43);
                        pt.pnt2("2. Sửa bảng điểm     ", 115, 44);
                        pt.pnt2("3. Xóa bảng điểm", 115, 45);
                        pt.pnt2("4. Đưa ra danh sách bảng điểm", 115, 46);
                        pt.pnt2("5. Tính điểm tổng kết", 115, 47);
                        pt.pnt2("6. Để quay lại menu chính", 115, 48);
                        pt.pnt2("7. Để thoát khỏi chương trình", 115, 49);
                        pt.pnt2("Nhấn", 115, 50);
                        Console.ForegroundColor = ConsoleColor.Green;
                        pt.pnt2("H", 120, 50);
                        Console.ForegroundColor = ConsoleColor.White;
                        pt.pnt2("để mở thanh công cụ và", 122, 50);
                        Console.ForegroundColor = ConsoleColor.Green;
                        pt.pnt2("E", 145, 50);
                        Console.ForegroundColor = ConsoleColor.White;
                        pt.pnt2("để tắt", 147, 50);
                        pt.pnt2("", 132, 51);
                        goto chucnang;
                    default:
                        pt.pnt2("                                                         ", 15, 44);
                        pt.pnt2("                               ", 15, 45);
                        goto suadiem;
                }
            }
            if (bdbll.KTmahs(mahss) == true)
            {
                pt.pnt2(hsbll.laymalop(mahss), 70, 10); malops = hsbll.laymalop(mahss);

                mamon:
                pt.pnt2("", 111, 10); mamons = Console.ReadLine();
                if (mamons == "")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    pt.pnt2("Mã môn không được rỗng ! Nhấn phím bất kỳ nhập lại ", 15, 48);
                    pt.pnt2("Nhấn Tab để quay lại ", 15, 49);
                    Console.ForegroundColor = ConsoleColor.White;
                    ConsoleKeyInfo kt = Console.ReadKey();
                    switch (kt.Key)
                    {
                        case ConsoleKey.Tab:
                            pt.pnt2("                                                         ", 15, 44);
                            pt.pnt2("                               ", 15, 45);

                            pt.pnt2("1. Thêm bảng điểm     ", 115, 43);
                            pt.pnt2("2. Sửa bảng điểm     ", 115, 44);
                            pt.pnt2("3. Xóa bảng điểm", 115, 45);
                            pt.pnt2("4. Đưa ra danh sách bảng điểm", 115, 46);
                            pt.pnt2("5. Tính điểm tổng kết", 115, 47);
                            pt.pnt2("6. Để quay lại menu chính", 115, 48);
                            pt.pnt2("7. Để thoát khỏi chương trình", 115, 49);
                            pt.pnt2("Nhấn", 115, 50);
                            Console.ForegroundColor = ConsoleColor.Green;
                            pt.pnt2("H", 120, 50);
                            Console.ForegroundColor = ConsoleColor.White;
                            pt.pnt2("để mở thanh công cụ và", 122, 50);
                            Console.ForegroundColor = ConsoleColor.Green;
                            pt.pnt2("E", 145, 50);
                            Console.ForegroundColor = ConsoleColor.White;
                            pt.pnt2("để tắt", 147, 50);
                            pt.pnt2("", 132, 51);
                            goto chucnang;
                        default:
                            pt.pnt2("                                                         ", 15, 48);
                            pt.pnt2("                               ", 15, 49);
                            goto mamon;
                    }
                }
                if (bdbll.KTmamon(mamons) == true)
                {
                    hocky:
                    pt.pnt2("", 137, 10); hockys = Console.ReadLine();
                    if (hockys == "")
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        pt.pnt2("Học kỳ không rõng ! Nhấn phím bất kỳ để nhập lại ", 15, 44);
                        Console.ForegroundColor = ConsoleColor.White;
                        ConsoleKeyInfo kt = Console.ReadKey();
                        switch (kt.Key)
                        {
                            default:
                                pt.pnt2("                                                                               ", 15, 44);
                                goto hocky;
                        }
                    }
                    else
                    {
                        for (int i = 0; i < hockys.Length; ++i)
                        {
                            if (hockys.Length > 3 || hockys[i] != 'I')
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                pt.pnt2("Sai định dạng học kỳ ! Nhấn phím bất kỳ để nhập lại ", 15, 44);
                                Console.ForegroundColor = ConsoleColor.White;
                                ConsoleKeyInfo kt = Console.ReadKey();
                                switch (kt.Key)
                                {
                                    default:
                                        pt.pnt2("                                                                               ", 15, 44);
                                        pt.pnt2("             ", 137, 10);
                                        goto hocky;
                                }
                            }
                        }
                    }
                    if (bdbll.KTbd(mahss, malops, mamons, hockys) == true)
                    {
                        List<BangDiem> list = bdbll.LayDlbd();
                        while (list != null)
                        {
                            for (int i = 0; i < list.Count; ++i)
                            {
                                if (list[i].Mahs == mahss && list[i].Malop == malops && list[i].Mamon == mamons && list[i].Hocky == hockys)
                                {
                                    pt.pnt2(Convert.ToString(list[i].Diemgiuaky), 34, 14);
                                    pt.pnt2(Convert.ToString(list[i].Diemcuoiky), 70, 14);
                                    pt.pnt2(list[i].Hanhkiemky, 111, 14);
                                    pt.pnt2(list[i].Namhoc, 34, 16);
                                }
                            }
                            break;
                        }
                        pt.pnt2("", 34, 14);
                        Console.ReadKey();
                        Console.BackgroundColor = ConsoleColor.Black;
                        pt.pnt2("          ", 34, 14);
                        diemgiuaky:
                        pt.pnt2("", 34, 14); diemgiuakymoi = Console.ReadLine();
                        if (diemgiuakymoi == "")
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            pt.pnt2(" Điểm không rỗng ! Nhấn phím bất kỳ nhập lại ", 15, 48);
                            Console.ForegroundColor = ConsoleColor.White;
                            ConsoleKeyInfo kt = Console.ReadKey();
                            switch (kt.Key)
                            {
                                case ConsoleKey.Tab:
                                    pt.pnt2("                                                         ", 15, 44);
                                    pt.pnt2("                               ", 15, 45);

                                    pt.pnt2("1. Thêm bảng điểm     ", 115, 43);
                                    pt.pnt2("2. Sửa bảng điểm     ", 115, 44);
                                    pt.pnt2("3. Xóa bảng điểm", 115, 45);
                                    pt.pnt2("4. Đưa ra danh sách bảng điểm", 115, 46);
                                    pt.pnt2("5. Tính điểm tổng kết", 115, 47);
                                    pt.pnt2("6. Để quay lại menu chính", 115, 48);
                                    pt.pnt2("7. Để thoát khỏi chương trình", 115, 49);
                                    pt.pnt2("Nhấn", 115, 50);
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    pt.pnt2("H", 120, 50);
                                    Console.ForegroundColor = ConsoleColor.White;
                                    pt.pnt2("để mở thanh công cụ và", 122, 50);
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    pt.pnt2("E", 145, 50);
                                    Console.ForegroundColor = ConsoleColor.White;
                                    pt.pnt2("để tắt", 147, 50);
                                    pt.pnt2("", 132, 51);
                                    goto chucnang;
                                default:
                                    pt.pnt2("                                                                                  ", 15, 48);
                                    pt.pnt2("                   ", 34, 14);
                                    goto diemgiuaky;
                            }
                        }
                        else
                        {
                            for (int i = 0; i < diemgiuakymoi.Length; ++i)
                            {
                                if (diemgiuakymoi[i] != '0' && diemgiuakymoi[i] != '1' && diemgiuakymoi[i] != '2' && diemgiuakymoi[i] != '3' && diemgiuakymoi[i] != '4' && diemgiuakymoi[i] != '5' && diemgiuakymoi[i] != '6' && diemgiuakymoi[i] != '7' && diemgiuakymoi[i] != '8' && diemgiuakymoi[i] != '9')
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    pt.pnt2("Điểm không chứa ký tự ! Nhấn phím bất kỳ để nhập lại ", 15, 45);
                                    Console.ForegroundColor = ConsoleColor.White;
                                    ConsoleKeyInfo kt = Console.ReadKey();
                                    switch (kt.Key)
                                    {
                                        default:
                                            pt.pnt2("                                                                               ", 15, 45);
                                            pt.pnt2("           ", 34, 14);
                                            goto diemgiuaky;
                                    }
                                }
                            }
                            if (Convert.ToDouble(diemgiuakymoi) < 0 || Convert.ToDouble(diemgiuakymoi) > 10)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                pt.pnt2("Điểm không nhỏ hơn 0 và lớn hơn 10 ! Nhấn phím bất kỳ để nhập lại ", 15, 45);
                                Console.ForegroundColor = ConsoleColor.White;
                                ConsoleKeyInfo kt = Console.ReadKey();
                                switch (kt.Key)
                                {
                                    default:
                                        pt.pnt2("                                                                               ", 15, 45);
                                        pt.pnt2("           ", 34, 14);
                                        goto diemgiuaky;
                                }
                            }
                        }
                        pt.pnt2("", 70, 14);
                        Console.ReadKey();
                        Console.BackgroundColor = ConsoleColor.Black;
                        pt.pnt2("           ", 70, 14);
                        diemcuoiky:
                        pt.pnt2("", 70, 14); diemcuoikymoi = Console.ReadLine();
                        if (diemcuoikymoi == "")
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            pt.pnt2(" Điểm không rỗng ! Nhấn phím bất kỳ nhập lại ", 15, 48);
                            Console.ForegroundColor = ConsoleColor.White;
                            ConsoleKeyInfo kt = Console.ReadKey();
                            switch (kt.Key)
                            {
                                case ConsoleKey.Tab:
                                    pt.pnt2("                                                         ", 15, 44);
                                    pt.pnt2("                               ", 15, 45);

                                    pt.pnt2("1. Thêm bảng điểm     ", 115, 43);
                                    pt.pnt2("2. Sửa bảng điểm     ", 115, 44);
                                    pt.pnt2("3. Xóa bảng điểm", 115, 45);
                                    pt.pnt2("4. Đưa ra danh sách bảng điểm", 115, 46);
                                    pt.pnt2("5. Tính điểm tổng kết", 115, 47);
                                    pt.pnt2("6. Để quay lại menu chính", 115, 48);
                                    pt.pnt2("7. Để thoát khỏi chương trình", 115, 49);
                                    pt.pnt2("Nhấn", 115, 50);
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    pt.pnt2("H", 120, 50);
                                    Console.ForegroundColor = ConsoleColor.White;
                                    pt.pnt2("để mở thanh công cụ và", 122, 50);
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    pt.pnt2("E", 145, 50);
                                    Console.ForegroundColor = ConsoleColor.White;
                                    pt.pnt2("để tắt", 147, 50);
                                    pt.pnt2("", 132, 51);
                                    goto chucnang;
                                default:
                                    pt.pnt2("                                                                                  ", 15, 48);
                                    pt.pnt2("                   ", 70, 14);
                                    goto diemcuoiky;
                            }
                        }
                        else
                        {
                            for (int i = 0; i < diemcuoikymoi.Length; ++i)
                            {
                                if (diemcuoikymoi[i] != '0' && diemcuoikymoi[i] != '1' && diemcuoikymoi[i] != '2' && diemcuoikymoi[i] != '3' && diemcuoikymoi[i] != '4' && diemcuoikymoi[i] != '5' && diemcuoikymoi[i] != '6' && diemcuoikymoi[i] != '7' && diemcuoikymoi[i] != '8' && diemcuoikymoi[i] != '9')
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    pt.pnt2("Điểm không chứa ký tự ! Nhấn phím bất kỳ để nhập lại ", 15, 45);
                                    Console.ForegroundColor = ConsoleColor.White;
                                    ConsoleKeyInfo kt = Console.ReadKey();
                                    switch (kt.Key)
                                    {
                                        default:
                                            pt.pnt2("                                                                               ", 15, 45);
                                            pt.pnt2("           ", 70, 14);
                                            goto diemcuoiky;
                                    }
                                }
                            }
                            if (Convert.ToDouble(diemcuoikymoi) < 0 || Convert.ToDouble(diemcuoikymoi) > 10)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                pt.pnt2("Điểm không nhỏ hơn 0 và lớn hơn 10 ! Nhấn phím bất kỳ để nhập lại ", 15, 45);
                                Console.ForegroundColor = ConsoleColor.White;
                                ConsoleKeyInfo kt = Console.ReadKey();
                                switch (kt.Key)
                                {
                                    default:
                                        pt.pnt2("                                                                               ", 15, 45);
                                        pt.pnt2("           ", 70, 14);
                                        goto diemcuoiky;
                                }
                            }
                        }
                        pt.pnt2("", 111, 14);
                        Console.ReadKey();
                        Console.BackgroundColor = ConsoleColor.Black;
                        pt.pnt2("           ", 111, 14);
                        hanhkiemky:
                        pt.pnt2("", 111, 14); hanhkiemkymoi = Console.ReadLine();
                        if (hanhkiemkymoi == "")
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            pt.pnt2("Hạnh kiểm không rỗng ! Nhấn phím bất kỳ để nhập lại ", 15, 45);
                            Console.ForegroundColor = ConsoleColor.White;
                            ConsoleKeyInfo kt = Console.ReadKey();
                            switch (kt.Key)
                            {
                                default:
                                    pt.pnt2("                                                                               ", 15, 45);
                                    goto hanhkiemky;
                            }
                        }
                        else
                        {
                            for (int i = 0; i < hanhkiemkymoi.Length; ++i)
                            {
                                if (hanhkiemkymoi[i] == '0' || hanhkiemkymoi[i] == '1' || hanhkiemkymoi[i] == '2' || hanhkiemkymoi[i] == '3' || hanhkiemkymoi[i] == '4' || hanhkiemkymoi[i] == '5' || hanhkiemkymoi[i] == '6' || hanhkiemkymoi[i] == '7' || hanhkiemkymoi[i] == '8' || hanhkiemkymoi[i] == '9')
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    pt.pnt2("Hạnh kiểm không chứa số ! Nhấn phím bất kỳ để nhập lại ", 15, 45);
                                    Console.ForegroundColor = ConsoleColor.White;
                                    ConsoleKeyInfo kt = Console.ReadKey();
                                    switch (kt.Key)
                                    {
                                        default:
                                            pt.pnt2("                                                                               ", 15, 45);
                                            pt.pnt2("           ", 111, 14);
                                            goto hanhkiemky;
                                    }
                                }
                            }
                            if (hanhkiemkymoi.Length < 3)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                pt.pnt2("Hạnh kiểm sai ! Nhấn phím bất kỳ để nhập lại ", 15, 45);
                                Console.ForegroundColor = ConsoleColor.White;
                                ConsoleKeyInfo kt = Console.ReadKey();
                                switch (kt.Key)
                                {
                                    default:
                                        pt.pnt2("                                                                               ", 15, 45);
                                        pt.pnt2("           ", 111, 14);
                                        goto hanhkiemky;
                                }
                            }
                        }

                        pt.pnt2("", 34, 16);
                        Console.ReadKey();
                        Console.BackgroundColor = ConsoleColor.Black;
                        pt.pnt2("           ", 34, 16);
                        namhoc:
                        pt.pnt2("", 34, 16); namhocmoi = Console.ReadLine();
                        if (namhocmoi == "")
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            pt.pnt2("Năm học không rỗng ! Nhấn phím bất kỳ để nhập lại ", 15, 48);
                            Console.ForegroundColor = ConsoleColor.White;
                            ConsoleKeyInfo kt = Console.ReadKey();
                            switch (kt.Key)
                            {
                                default:
                                    pt.pnt2("                                                                               ", 15, 48);
                                    goto namhoc;
                            }
                        }
                        else
                        {
                            if (hsbll.KTnamhoc(namhocmoi) == false)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                pt.pnt2("Năm học không tồn tại ! Nhấn phím bất kỳ để nhập lại ", 15, 45);
                                Console.ForegroundColor = ConsoleColor.White;
                                ConsoleKeyInfo kt = Console.ReadKey();
                                switch (kt.Key)
                                {
                                    default:
                                        pt.pnt2("                                                                               ", 15, 45);
                                        pt.pnt2("                 ", 34, 16);
                                        goto namhoc;
                                }
                            }
                        }
                        BangDiem bdnew = new BangDiem(mahss, malops, mamons, Convert.ToDouble(diemgiuakymoi), Convert.ToDouble(diemcuoikymoi), hanhkiemkymoi, hockys, namhocmoi);
                        pt.pnt2("Nhấn Enter để lưu và sửa tiếp", 15, 44);
                        pt.pnt2("Nhấn Tab để quay lại", 15, 45);
                        label2: ConsoleKeyInfo kttt = Console.ReadKey();
                        switch (kttt.Key)
                        {
                            case ConsoleKey.Enter:
                                bdbll.Xoabd(mahss, malops, mamons, hockys);
                                bdbll.Thembd(bdnew);
                                pt.pnt2("                                ", 15, 44);
                                pt.pnt2("                                ", 15, 45);

                                pt.pnt2("                 ", 34, 10);
                                pt.pnt2("                 ", 34, 16);
                                pt.pnt2("                 ", 34, 14);
                                pt.pnt2("                 ", 70, 10);
                                pt.pnt2("                 ", 70, 14);
                                pt.pnt2("                 ", 111, 10);
                                pt.pnt2("                 ", 111, 14);
                                pt.pnt2("                 ", 70, 16);

                                for (int i = 25; i < 40; ++i)
                                {
                                    pt.pnt2("      ", 9, i);
                                    pt.pnt2("       ", 23, i);
                                    pt.pnt2("         ", 46, i);
                                    pt.pnt2("         ", 67, i);
                                    pt.pnt2("         ", 85, i);
                                    pt.pnt2("         ", 107, i);
                                    pt.pnt2("        ", 122, i);
                                    pt.pnt2("       ", 136, i);
                                    pt.pnt2("      ", 149, i);
                                }
                                goto danhsach;
                            case ConsoleKey.Tab:
                                pt.pnt2("                                                         ", 15, 44);
                                pt.pnt2("                               ", 15, 45);

                                pt.pnt2("1. Thêm bảng điểm     ", 115, 43);
                                pt.pnt2("2. Sửa bảng điểm     ", 115, 44);
                                pt.pnt2("3. Xóa bảng điểm", 115, 45);
                                pt.pnt2("4. Đưa ra danh sách bảng điểm", 115, 46);
                                pt.pnt2("5. Tính điểm tổng kết", 115, 47);
                                pt.pnt2("6. Để quay lại menu chính", 115, 48);
                                pt.pnt2("7. Để thoát khỏi chương trình", 115, 49);
                                pt.pnt2("Nhấn", 115, 50);
                                Console.ForegroundColor = ConsoleColor.Green;
                                pt.pnt2("H", 120, 50);
                                Console.ForegroundColor = ConsoleColor.White;
                                pt.pnt2("để mở thanh công cụ và", 122, 50);
                                Console.ForegroundColor = ConsoleColor.Green;
                                pt.pnt2("E", 145, 50);
                                Console.ForegroundColor = ConsoleColor.White;
                                pt.pnt2("để tắt", 147, 50);
                                pt.pnt2("", 132, 51);
                                goto chucnang;
                            default:
                                Console.ForegroundColor = ConsoleColor.Red;
                                pt.pnt2("Nhập sai , nhập lại :", 90, 49);
                                Console.ForegroundColor = ConsoleColor.White;
                                goto label2;
                        }
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        pt.pnt2("Học sinh chưa có điểm môn này hoặc kỳ học này ! Nhấn phím bất kỳ nhập lại ", 15, 44);
                        Console.ForegroundColor = ConsoleColor.White;
                        ConsoleKeyInfo kt = Console.ReadKey();
                        switch (kt.Key)
                        {
                            case ConsoleKey.Tab:
                        pt.pnt2("                                                                          ", 15, 44);

                                pt.pnt2("1. Thêm bảng điểm     ", 115, 43);
                                pt.pnt2("2. Sửa bảng điểm     ", 115, 44);
                                pt.pnt2("3. Xóa bảng điểm", 115, 45);
                                pt.pnt2("4. Đưa ra danh sách bảng điểm", 115, 46);
                                pt.pnt2("5. Tính điểm tổng kết", 115, 47);
                                pt.pnt2("6. Để quay lại menu chính", 115, 48);
                                pt.pnt2("7. Để thoát khỏi chương trình", 115, 49);
                                pt.pnt2("Nhấn", 115, 50);
                                Console.ForegroundColor = ConsoleColor.Green;
                                pt.pnt2("H", 120, 50);
                                Console.ForegroundColor = ConsoleColor.White;
                                pt.pnt2("để mở thanh công cụ và", 122, 50);
                                Console.ForegroundColor = ConsoleColor.Green;
                                pt.pnt2("E", 145, 50);
                                Console.ForegroundColor = ConsoleColor.White;
                                pt.pnt2("để tắt", 147, 50);
                                pt.pnt2("", 132, 51);
                                goto chucnang;
                            default:
                       pt.pnt2("                                                                               ", 15, 44);
                                pt.pnt2("         ", 34, 10);
                                pt.pnt2("         ", 70, 10);
                                pt.pnt2("         ", 111, 10);
                                pt.pnt2("         ", 137, 10);
                                goto suadiem;
                        }
                    }
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    pt.pnt2(" Môn học không tồn tại ! Nhấn phím bất kỳ nhập lại ", 15, 44);
                    Console.ForegroundColor = ConsoleColor.White;
                    ConsoleKeyInfo kt = Console.ReadKey();
                    switch (kt.Key)
                    {
                        case ConsoleKey.Tab:
                    pt.pnt2("                                                    ", 15, 44);

                            pt.pnt2("1. Thêm bảng điểm     ", 115, 43);
                            pt.pnt2("2. Sửa bảng điểm     ", 115, 44);
                            pt.pnt2("3. Xóa bảng điểm", 115, 45);
                            pt.pnt2("4. Đưa ra danh sách bảng điểm", 115, 46);
                            pt.pnt2("5. Tính điểm tổng kết", 115, 47);
                            pt.pnt2("6. Để quay lại menu chính", 115, 48);
                            pt.pnt2("7. Để thoát khỏi chương trình", 115, 49);
                            pt.pnt2("Nhấn", 115, 50);
                            Console.ForegroundColor = ConsoleColor.Green;
                            pt.pnt2("H", 120, 50);
                            Console.ForegroundColor = ConsoleColor.White;
                            pt.pnt2("để mở thanh công cụ và", 122, 50);
                            Console.ForegroundColor = ConsoleColor.Green;
                            pt.pnt2("E", 145, 50);
                            Console.ForegroundColor = ConsoleColor.White;
                            pt.pnt2("để tắt", 147, 50);
                            pt.pnt2("", 132, 51);
                            goto chucnang;
                        default:
                   pt.pnt2("                                                                 ", 15, 44);
                            pt.pnt2("       ", 111, 10);
                            goto mamon;
                    }
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                pt.pnt2("Mã học sinh không có trong bảng điểm ! Nhấn phím bất kỳ nhập lại ", 15, 48);
                Console.ForegroundColor = ConsoleColor.White;
                ConsoleKeyInfo kt = Console.ReadKey();
                switch (kt.Key)
                {
                    case ConsoleKey.Tab:
                pt.pnt2("                                                                 ", 15, 48);

                        pt.pnt2("1. Thêm bảng điểm     ", 115, 43);
                        pt.pnt2("2. Sửa bảng điểm     ", 115, 44);
                        pt.pnt2("3. Xóa bảng điểm", 115, 45);
                        pt.pnt2("4. Đưa ra danh sách bảng điểm", 115, 46);
                        pt.pnt2("5. Tính điểm tổng kết", 115, 47);
                        pt.pnt2("6. Để quay lại menu chính", 115, 48);
                        pt.pnt2("7. Để thoát khỏi chương trình", 115, 49);
                        pt.pnt2("Nhấn", 115, 50);
                        Console.ForegroundColor = ConsoleColor.Green;
                        pt.pnt2("H", 120, 50);
                        Console.ForegroundColor = ConsoleColor.White;
                        pt.pnt2("để mở thanh công cụ và", 122, 50);
                        Console.ForegroundColor = ConsoleColor.Green;
                        pt.pnt2("E", 145, 50);
                        Console.ForegroundColor = ConsoleColor.White;
                        pt.pnt2("để tắt", 147, 50);
                        pt.pnt2("", 132, 51);
                        goto chucnang;
                    default:
                        pt.pnt2("                                                                                  ", 15, 48);
                        pt.pnt2("         ", 34, 10);
                        goto suadiem;
                }
            }
            #endregion

            #region Xóa điểm
            xoadiem:
            string mahsx, malopx, mamonx, hockyx;
            do
            {
                pt.pnt2("", 34, 14); mahsx = Console.ReadLine();
                if (mahsx == "")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    pt.pnt2(" Mã không rỗng ! Nhấn phím bất kỳ nhập lại ", 15, 48);
                    pt.pnt2(" Nhấn Tab để quay lại ", 15, 49);
                    Console.ForegroundColor = ConsoleColor.White;
                    ConsoleKeyInfo kt = Console.ReadKey();
                    switch (kt.Key)
                    {
                        case ConsoleKey.Tab:
                            pt.pnt2("                                            ", 15, 44);
                            pt.pnt2("                                            ", 15, 45);
                            pt.pnt2("                                                   ", 15, 48);
                            pt.pnt2("                             ", 15, 49);
                            pt.pnt2("                          ", 10, 14);
                            pt.pnt2("                          ", 54, 14);
                            pt.pnt2("                          ", 88, 14);
                            pt.pnt2("                          ", 120, 14);
                            pt.pnt2("                        ", 62, 8);
                            pt.pnt2("━━━━━━━━━━━━━━━━━━━━━━━━", 62, 8);

                            pt.pnt2("1. Thêm bảng điểm     ", 115, 43);
                            pt.pnt2("2. Sửa bảng điểm     ", 115, 44);
                            pt.pnt2("3. Xóa bảng điểm     ", 115, 45);
                            pt.pnt2("4. Đưa ra danh sách bảng điểm", 115, 46);
                            pt.pnt2("5. Tính điểm tổng kết", 115, 47);
                            pt.pnt2("6. Để quay lại menu chính", 115, 48);
                            pt.pnt2("7. Để thoát khỏi chương trình", 115, 49);
                            pt.pnt2("Nhấn", 115, 50);
                            Console.ForegroundColor = ConsoleColor.Green;
                            pt.pnt2("H", 120, 50);
                            Console.ForegroundColor = ConsoleColor.White;
                            pt.pnt2("để mở thanh công cụ và", 122, 50);
                            Console.ForegroundColor = ConsoleColor.Green;
                            pt.pnt2("E", 145, 50);
                            Console.ForegroundColor = ConsoleColor.White;
                            pt.pnt2("để tắt", 147, 50);
                            pt.pnt2("", 132, 51);

                            goto chucnang;
                        default:
                            pt.pnt2("                                                   ", 15, 48);
                            pt.pnt2("                             ", 15, 49);
                            goto xoadiem;
                    }
                }
                if (bdbll.KTmahs(mahsx) == true)
                {
                    pt.pnt2(hsbll.laymalop(mahsx), 70, 14); malopx = hsbll.laymalop(mahsx);
                    mamon:
                    pt.pnt2("", 111, 14); mamonx = Console.ReadLine();
                    if (mamonx == "")
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        pt.pnt2(" Tên môn không rỗng ! Nhấn phím bất kỳ nhập lại ", 15, 44);
                        pt.pnt2(" Nhấn Tab để quay lại ", 15, 45);
                        Console.ForegroundColor = ConsoleColor.White;
                        ConsoleKeyInfo kt = Console.ReadKey();
                        switch (kt.Key)
                        {
                            case ConsoleKey.Tab:
                                pt.pnt2("                                                         ", 15, 44);
                                pt.pnt2("                               ", 15, 45);

                                pt.pnt2("1. Thêm bảng điểm     ", 115, 43);
                                pt.pnt2("2. Sửa bảng điểm     ", 115, 44);
                                pt.pnt2("3. Xóa bảng điểm", 115, 45);
                                pt.pnt2("4. Đưa ra danh sách bảng điểm", 115, 46);
                                pt.pnt2("5. Tính điểm tổng kết", 115, 47);
                                pt.pnt2("6. Để quay lại menu chính", 115, 48);
                                pt.pnt2("7. Để thoát khỏi chương trình", 115, 49);
                                pt.pnt2("Nhấn", 115, 50);
                                Console.ForegroundColor = ConsoleColor.Green;
                                pt.pnt2("H", 120, 50);
                                Console.ForegroundColor = ConsoleColor.White;
                                pt.pnt2("để mở thanh công cụ và", 122, 50);
                                Console.ForegroundColor = ConsoleColor.Green;
                                pt.pnt2("E", 145, 50);
                                Console.ForegroundColor = ConsoleColor.White;
                                pt.pnt2("để tắt", 147, 50);
                                pt.pnt2("", 132, 51);
                                goto chucnang;
                            default:
                                pt.pnt2("                                                   ", 15, 48);
                                pt.pnt2("                             ", 15, 49);
                                goto mamon;
                        }
                    }
                    if (bdbll.KTmamon(mamonx) == true)
                    {
                        hocky:
                        pt.pnt2("", 141, 14); hockyx = Console.ReadLine();
                        if (hockyx == "")
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            pt.pnt2(" Học kỳ không rỗng ! Nhấn phím bất kỳ nhập lại ", 15, 44);
                            pt.pnt2(" Nhấn Tab để quay lại ", 15, 45);
                            Console.ForegroundColor = ConsoleColor.White;
                            ConsoleKeyInfo kt = Console.ReadKey();
                            switch (kt.Key)
                            {
                                case ConsoleKey.Tab:
                                    pt.pnt2("                                                         ", 15, 44);
                                    pt.pnt2("                               ", 15, 45);

                                    pt.pnt2("1. Thêm bảng điểm     ", 115, 43);
                                    pt.pnt2("2. Sửa bảng điểm     ", 115, 44);
                                    pt.pnt2("3. Xóa bảng điểm", 115, 45);
                                    pt.pnt2("4. Đưa ra danh sách bảng điểm", 115, 46);
                                    pt.pnt2("5. Tính điểm tổng kết", 115, 47);
                                    pt.pnt2("6. Để quay lại menu chính", 115, 48);
                                    pt.pnt2("7. Để thoát khỏi chương trình", 115, 49);
                                    pt.pnt2("Nhấn", 115, 50);
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    pt.pnt2("H", 120, 50);
                                    Console.ForegroundColor = ConsoleColor.White;
                                    pt.pnt2("để mở thanh công cụ và", 122, 50);
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    pt.pnt2("E", 145, 50);
                                    Console.ForegroundColor = ConsoleColor.White;
                                    pt.pnt2("để tắt", 147, 50);
                                    pt.pnt2("", 132, 51);
                                    goto chucnang;
                                default:
                                    pt.pnt2("                                                   ", 15, 44);
                                    pt.pnt2("                             ", 15, 45);
                                    goto hocky;
                            }
                        }
                        pt.pnt2("Nhấn Enter lưu lại và xóa tiếp ", 15, 45);
                        pt.pnt2("Nhấn Tab quay lại ", 15, 46);
                        label1: ConsoleKeyInfo ktttt = Console.ReadKey();
                        switch (ktttt.Key)
                        {
                            case ConsoleKey.Enter:
                                bdbll.Xoabd(mahsx, malopx, mamonx, hockyx);
                                pt.pnt2("                                ", 15, 45);
                                pt.pnt2("                                ", 15, 46);

                                pt.pnt2("            ", 34, 14);
                                pt.pnt2("            ", 70, 14);
                                pt.pnt2("        ", 111, 14);
                                pt.pnt2("         ", 141, 14);
                              

                                for (int i = 25; i < 40; ++i)
                                {
                                    pt.pnt2("      ", 9, i);
                                    pt.pnt2("       ", 23, i);
                                    pt.pnt2("         ", 46, i);
                                    pt.pnt2("         ", 67, i);
                                    pt.pnt2("         ", 85, i);
                                    pt.pnt2("         ", 107, i);
                                    pt.pnt2("        ", 122, i);
                                    pt.pnt2("       ", 136, i);
                                    pt.pnt2("      ", 149, i);
                                }
                                pt.pnt2("1. Thêm bảng điểm     ", 115, 43);
                                pt.pnt2("2. Sửa bảng điểm     ", 115, 44);
                                pt.pnt2("3. Xóa bảng điểm     ", 115, 45);
                                pt.pnt2("4. Đưa ra danh sách bảng điểm", 115, 46);
                                pt.pnt2("5. Tính điểm tổng kết", 115, 47);
                                pt.pnt2("6. Để quay lại menu chính", 115, 48);
                                pt.pnt2("7. Để thoát khỏi chương trình", 115, 49);
                                pt.pnt2("Nhấn", 115, 50);
                                Console.ForegroundColor = ConsoleColor.Green;
                                pt.pnt2("H", 120, 50);
                                Console.ForegroundColor = ConsoleColor.White;
                                pt.pnt2("để mở thanh công cụ và", 122, 50);
                                Console.ForegroundColor = ConsoleColor.Green;
                                pt.pnt2("E", 145, 50);
                                Console.ForegroundColor = ConsoleColor.White;
                                pt.pnt2("để tắt", 147, 50);
                                pt.pnt2("", 132, 51);

                                goto danhsach;
                            case ConsoleKey.Tab:
                                goto chucnang;
                            default:
                                Console.ForegroundColor = ConsoleColor.Red;
                                pt.pnt2("Nhập sai ! Xin nhập lại :  ", 15, 47);
                                Console.ForegroundColor = ConsoleColor.White;
                                goto label1;
                        }
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        pt.pnt2(" Mã môn không đúng ! Nhấn phím bất kỳ nhập lại ", 15, 48);
                        Console.ForegroundColor = ConsoleColor.White;
                        ConsoleKeyInfo kt = Console.ReadKey();
                        switch (kt.Key)
                        {
                            default:
                                pt.pnt2("                                                   ", 15, 48);
                                pt.pnt2("       ", 111, 10);
                                goto mamon;
                        }
                    }
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    pt.pnt2(" Mã không có trong bảng điểm ! Nhấn phím bất kỳ nhập lại ", 15, 48);
                    Console.ForegroundColor = ConsoleColor.White;
                    ConsoleKeyInfo kt = Console.ReadKey();
                    switch (kt.Key)
                    {
                        default:
                            pt.pnt2("                                                                 ", 15, 48);
                            pt.pnt2("            ", 68, 10);
                            goto xoadiem;
                    }
                }
            } while (true);
            #endregion

            #region danh sách điểm học sinh
            hiendiem:
            pt.pnt2("┏", 4, 8);
            pt.pnt2("┗", 4, 45);
            pt.pnt2("┓", 157, 8);
            pt.pnt2("┛", 157, 45);

            pt.pnt2("━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━", 5, 8);
            pt.pnt2("━━━━━━━━━━━┻━━━━━━━━━━━━━━━━━━━━┻━━━━━━━━━━━━━━━━━━━┻━━━━━━━━━━━━━━━━━━┻━━━━━━━━━━━━━━━━━━━━━━━┻━━━━━━━━━━━━━━━┻━━━━━━━━━━━━━━━┻━━━━━━━━━━━━━┻━━━━━━━━━━", 5, 45);
            pt.pnt2("                                                      TRƯỜNG ĐẠI HỌC SƯ PHẠM KỸ THUẬT HƯNG YÊN ", 0, 1);
            pt.pnt2("                                                             KHOA CÔNG NGHỆ THÔNG TIN ", 0, 2);
            pt.pnt2("                                                              ------- ○○○○ -------", 0, 3);
            for (int i = 9; i < 45; ++i)
            {
                pt.pnt2("┃", 4, i);
                pt.pnt2("┃", 157, i);
            }

            pt.pnt2("┣", 4, 11);
            pt.pnt2("┣", 4, 13);
            pt.pnt2("┫", 157, 11);
            pt.pnt2("┫", 157, 13);

            Console.ForegroundColor = ConsoleColor.Magenta;
            pt.pnt2("Designed by TeamT ™", 5, 46);
            Console.ForegroundColor = ConsoleColor.White;
            pt.pnt2("━━━━━━━━━━━┳━━━━━━━━━━━━━━━━━━━━┳━━━━━━━━━━━━━━━━━━━┳━━━━━━━━━━━━━━━━━━┳━━━━━━━━━━━━━━━━━━━━━━━┳━━━━━━━━━━━━━━━┳━━━━━━━━━━━━━━━┳━━━━━━━━━━━━━┳━━━━━━━━━━", 5, 11);
            pt.pnt2("━━━━━━━━━━━┻━━━━━━━━━━━━━━━━━━━━┻━━━━━━━━━━━━━━━━━━━┻━━━━━━━━━━━━━━━━━━┻━━━━━━━━━━━━━━━━━━━━━━━┻━━━━━━━━━━━━━━━┻━━━━━━━━━━━━━━━┻━━━━━━━━━━━━━┻━━━━━━━━━━", 5, 13);



            for (int i = 12; i < 45; i++)
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

            pt.pnt2("DANH SÁCH ĐIỂM", 68, 10);
            pt.pnt2(" Mã HS ", 7, 12);
            pt.pnt2(" Mã Lớp", 21, 12);
            pt.pnt2(" Mã môn", 43, 12);
            pt.pnt2(" Điểm giữa kỳ", 60, 12);
            pt.pnt2(" Điểm cuối kỳ", 81, 12);
            pt.pnt2(" Hạnh kiểm kỳ", 102, 12);
            pt.pnt2(" Học kỳ", 120, 12);
            pt.pnt2(" Năm học", 135, 12);
            pt.pnt2(" TBMHK", 148, 12);

            pt.pnt2(" Nhấn Tab để quay lại ", 125, 46);
            pt.pnt2(" Bạn chọn phím : ", 125, 47);
            List<BangDiem> hs = bdbll.LayDlbd();
            int slhs = 0;
            for (int i = 0; i < hs.Count; ++i)
            {
                slhs++;
            }
            if (slhs > 0)
            {
                int sd = 15;
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
                label3:
                vetrang(t);
                pt.pnt2("", 5, 7); Console.WriteLine("{0}/{1} trang ◄ {2} ►", t, st, t);
                goto label2;
                label2:
                pt.pnt2("", 141, 47);
                ConsoleKeyInfo p;
               den: p = Console.ReadKey();
                switch (p.Key)
                {
                    case ConsoleKey.LeftArrow:
                        if (t == 1)
                        {
                            t = 1;
                            pt.pnt2("                                  ", 125, 48);
                            goto label2;
                        }
                        else
                        {
                            t--;
                            pt.pnt2("                                   ", 125, 48);
                            goto label3;
                        }
                    case ConsoleKey.RightArrow:
                        if (t == st)
                        {
                            t = st;
                            pt.pnt2("                                   ", 125, 48);
                            goto label2;
                        }
                        else
                        {
                            t++;
                            pt.pnt2("                                   ", 125, 48);
                            goto label3;
                        }
                    case ConsoleKey.Tab:
                        Console.Clear();
                        goto top;
                    default:
                        pt.pnt2("    ", 141, 47);
                        Console.ForegroundColor = ConsoleColor.Red;
                        pt.pnt2(" Bạn nhập sai! Xin mời nhập lại", 125, 48);
                        Console.ForegroundColor = ConsoleColor.White;
                        pt.pnt2("", 141, 47);
                        goto den;
                }

            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                pt.pnt2(" Hệ thống không có điểm. Nhấn Tab để quay lại ", 10, 47);
                Console.ForegroundColor = ConsoleColor.White;
                label5: ConsoleKeyInfo ktkt = Console.ReadKey();
                switch (ktkt.Key)
                {
                    case ConsoleKey.Tab:
                        pt.pnt2("                                                         ", 15, 47);

                        pt.pnt2("1. Thêm bảng điểm     ", 115, 43);
                        pt.pnt2("2. Sửa bảng điểm     ", 115, 44);
                        pt.pnt2("3. Xóa bảng điểm", 115, 45);
                        pt.pnt2("4. Đưa ra danh sách bảng điểm", 115, 46);
                        pt.pnt2("5. Tính điểm tổng kết", 115, 47);
                        pt.pnt2("6. Để quay lại menu chính", 115, 48);
                        pt.pnt2("7. Để thoát khỏi chương trình", 115, 49);
                        pt.pnt2("Nhấn", 115, 50);
                        Console.ForegroundColor = ConsoleColor.Green;
                        pt.pnt2("H", 120, 50);
                        Console.ForegroundColor = ConsoleColor.White;
                        pt.pnt2("để mở thanh công cụ và", 122, 50);
                        Console.ForegroundColor = ConsoleColor.Green;
                        pt.pnt2("E", 145, 50);
                        Console.ForegroundColor = ConsoleColor.White;
                        pt.pnt2("để tắt", 147, 50);
                        pt.pnt2("", 132, 51);
                        goto chucnang;
                    default:
                        pt.pnt2("Nhập sai xin nhập lại ", 10, 48);
                        goto label5;
                }
            }

        }
        #endregion
        public void vetrang(int chisotrang)
        {
            for (int i = 15; i < 45; ++i)
            {
                pt.pnt2("       ", 8, i);
                pt.pnt2("       ", 25, i);
                pt.pnt2("         ", 46, i);
                pt.pnt2("       ", 67, i);
                pt.pnt2("         ", 87, i);
                pt.pnt2("        ", 108, i);
                pt.pnt2("         ", 123, i);
                pt.pnt2("         ", 135, i);
                pt.pnt2("       ", 149, i);
            }
            int a = 15;
            int d1 = 0;
            int sodong = 15;
            List<BangDiem> h = bdbll.LayDlbd();
            int d = (chisotrang - 1) * sodong + 1;
            for (int i = 0; i < h.Count; ++i)
            {
                d1++;
                if ((d1 >= d) && (d1 <= chisotrang * 15))
                {
                    pt.pnt2(h[i].Mahs, 8, a);
                    pt.pnt2(h[i].Malop, 25, a);
                    pt.pnt2(h[i].Mamon, 46, a);
                    pt.pnt2(Convert.ToString(h[i].Diemgiuaky), 67, a);
                    pt.pnt2(Convert.ToString(h[i].Diemcuoiky), 87, a);
                    pt.pnt2(h[i].Hanhkiemky, 108, a);
                    pt.pnt2(h[i].Hocky, 123, a);
                    pt.pnt2(h[i].Namhoc, 135, a);
                    pt.pnt2(Convert.ToString(h[i].Diemtk), 149, a);
                    a = a + 2;
                }
            }
        }
        #endregion
        #region Chức năng tính điểm
        public void tinhdiemtbky1()
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

            pt.pnt1("DANH SÁCH ĐIỂM ", 61, 20);
            pt.pnt1(" Mã học sinh ", 33, 23);
            pt.pnt1(" Học kỳ", 57, 23);
            pt.pnt1(" Điểm trung bình", 82, 23);

            pt.pnt1("1. Tính điểm trung bình học kỳ I", 78, 44);
            pt.pnt1("2. Tính điểm trung bình học kỳ II", 78, 45);
            pt.pnt1("3. Tính điểm trung bình cả năm", 78, 46);
            pt.pnt1("4. Quay lại quản lý điểm", 78, 47);
            pt.pnt1("Nhấn", 78, 49);
            Console.ForegroundColor = ConsoleColor.Green;
            pt.pnt1("H", 83, 49); pt.pnt1("E",108,49);
            Console.ForegroundColor = ConsoleColor.White;
            pt.pnt1("để mở thanh công cụ và", 85, 49);
            pt.pnt1("để tắt", 110, 49);
            pt.pnt1("5. Để thoát chương trình", 78, 48);


            List<TinhDiem> listtd = tdbll.LayDLTD();
            int a = 25;
            int tmp = 0;
            for(int i = 0; i < listtd.Count; ++i)
            {
                if (tmp < 9)
                {
                    pt.pnt1(listtd[i].Mahs, 37, a);
                    pt.pnt1(listtd[i].Hocky, 60, a);
                    pt.pnt1(Convert.ToString(listtd[i].Diemtb), 89, a);
                    tmp++;
                    a += 2;
                }
                else break;
            }
            pt.pnt1("Chọn chức năng : ", 78, 50);
          chucnang:  ConsoleKeyInfo key = Console.ReadKey();
            switch (key.KeyChar)
            {
                case '1':
                    pt.pnt1("    ", 94, 50);
                    pt.pnt1("                                 ", 78, 51);
                    pt.pnt1("Tính điểm trung bình học kỳ I ", 54, 8);
                    pt.pnt1("                                 ", 78, 44);
                    Console.ForegroundColor = ConsoleColor.Green;
                    pt.pnt1("→ 1. Tính điểm trung bình học kỳ I", 78, 44);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    pt.pnt1("Nhập mã học sinh cần tính điểm : ", 38, 12);
                    Console.ForegroundColor = ConsoleColor.White;
                    goto tinhdiemtbky1;
                case '2':
                    pt.pnt1("    ", 94, 50);
                    pt.pnt1("                                 ", 78, 51);
                    pt.pnt1("Tính điểm trung bình học kỳ II ", 54, 8);
                    pt.pnt1("                                 ", 78, 44);
                    pt.pnt1("                                 ", 78, 45);

                    pt.pnt1("1. Tính điểm trung bình học kỳ I", 78, 44);
                    Console.ForegroundColor = ConsoleColor.Green;
                    pt.pnt1("→ 2. Tính điểm trung bình học kỳ II", 78, 45);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    pt.pnt1("Nhập mã học sinh cần tính điểm : ", 38, 12);
                    Console.ForegroundColor = ConsoleColor.White;
                    goto tinhdiemtbky2;
                case '3':
                    pt.pnt1("    ", 94, 50);
                    pt.pnt1("                                 ", 78, 51);
                    pt.pnt1("Tính điểm trung bình cả năm ", 54, 8);
                    pt.pnt1("                                 ", 78, 44);
                    pt.pnt1("                                 ", 78, 45);
                    pt.pnt1("                                 ", 78, 46);
                    pt.pnt1("1. Tính điểm trung bình học kỳ I", 78, 44);
                    pt.pnt1("2. Tính điểm trung bình học kỳ II", 78, 45);
                    Console.ForegroundColor = ConsoleColor.Green;
                    pt.pnt1("→ 3. Tính điểm trung bình cả năm", 78, 46);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    pt.pnt1("Nhập mã học sinh cần tính điểm : ", 38, 12);
                    Console.ForegroundColor = ConsoleColor.White;
                    goto tinhdiemtbcn;
                case '4':
                    Console.Clear();
                    themdiem();
                    break;
                case '5':
                    Environment.Exit(0);
                    break;
                case 'G':
                    Console.Clear();
                    fgv.themgv();
                    break;
                case 'S':
                    Console.Clear();
                    fhs.themhs();
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
                    pt.pnt1("                           ", 78, 51);
                    pt.pnt1("  ", 94, 50);
                    pt.pnt1("", 94, 50);
                    Console.ForegroundColor = ConsoleColor.White;
                    goto chucnang;
                case 'E':
                    pt.pnt1("                       ", 4, 6);
                    pt.pnt1("                       ", 30, 6);
                    pt.pnt1("                       ", 52, 6);
                    pt.pnt1("                       ", 76, 6);
                    pt.pnt1("                       ", 96, 6);
                    pt.pnt1("                       ", 114, 6);
                    pt.pnt1("                           ", 78, 51);
                    pt.pnt1("  ", 94, 50);
                    pt.pnt1("", 94, 50);
                    goto chucnang;
                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    pt.pnt1("   ", 94, 50);
                    pt.pnt1("Bạn nhập sai ! Xin nhập lại ", 78, 51);
                    Console.ForegroundColor = ConsoleColor.White;
                    pt.pnt1("", 94, 50);
                    goto chucnang;
            }
            #region Tính điểm trung bình kỳ 1
            tinhdiemtbky1:
            string mahs;
            double diemtb;
            string hocky = "I";
        mahs:
            pt.pnt1("", 70, 12);mahs = Console.ReadLine();
            if (mahs == "")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                pt.pnt1("Mã học sinh không rỗng ! Nhấn phím bất kỳ nhập lại ", 15, 45);
                pt.pnt1("Nhấn Tab để quay lại", 15, 46);
                Console.ForegroundColor = ConsoleColor.White;
                ConsoleKeyInfo kt = Console.ReadKey();
                switch (kt.Key)
                {
                    case ConsoleKey.Tab:
                pt.pnt1("                                                     ", 15, 45);
                        pt.pnt1("                                  ", 15, 46);
                        pt.pnt1("                              ", 54, 8);
                        pt.pnt1("━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━", 54, 8);
                        pt.pnt1("                                 ", 38, 12);
                        pt.pnt1("1. Tính điểm trung bình học kỳ I         ", 78, 44);
                        pt.pnt1("2. Tính điểm trung bình học kỳ II", 78, 45);
                        pt.pnt1("3. Tính điểm trung bình cả năm", 78, 46);
                        pt.pnt1("4. Quay lại quản lý điểm", 78, 47);
                        pt.pnt1("5. Để thoát chương trình", 78, 48);
                        pt.pnt1("", 94, 50);
                        goto chucnang;
                    default:
                        pt.pnt1("                                                     ", 15, 45);
                        pt.pnt1("                                  ", 15, 46);
                        goto mahs;
                }
            }
            if (bdbll.KTmahs(mahs) == true)
            {
                if (tdbll.kiemtradiemky1(mahs) == false)
                {
                    if (tdbll.layhocky(mahs) == "I")
                    {
                        diemtb = bdbll.Tinhdiemtbky1(mahs);
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        pt.pnt1("Học sinh chưa có điểm trong kỳ I", 15, 45);
                        pt.pnt1("Nhấn phím bất kỳ để nhập lại ", 15, 46);
                        Console.ForegroundColor = ConsoleColor.White;
                        ConsoleKeyInfo kt = Console.ReadKey();
                        switch (kt.Key)
                        {
                            default:
                                pt.pnt1("                                                            ", 15, 45);
                                pt.pnt1("                                   ", 15, 46);
                                pt.pnt1("           ", 70, 12);
                                goto mahs;
                        }
                    }
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    pt.pnt1("Học sinh đã tính điểm TB trong kỳ I! Nhấn phím bất kỳ nhập lại", 13, 45);
                    Console.ForegroundColor = ConsoleColor.White;
                    ConsoleKeyInfo kt = Console.ReadKey();
                    switch (kt.Key)
                    {
                        default:
                    pt.pnt1("                                                               ", 13, 45);
                            pt.pnt1("           ", 70, 12);
                            goto mahs;
                    }
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                pt.pnt1("Mã học sinh không tồn tại hoặc học sinh chưa có điểm", 15, 45);
                pt.pnt1("Nhấn phím bất kỳ nhập lại", 15, 46);
                Console.ForegroundColor = ConsoleColor.White;
                ConsoleKeyInfo kt = Console.ReadKey();
                switch (kt.Key)
                {
                    default:
                pt.pnt1("                                                      ", 15, 45);
                        pt.pnt1("                                 ", 15, 46);
                        pt.pnt1("           ", 70, 12);
                        goto mahs;
                }
            }
            TinhDiem td = new TinhDiem(mahs, hocky, diemtb);
            pt.pnt1("Nhấn Enter để tính tiếp", 10, 45);
            pt.pnt1("Nhấn Tab để quay lại",10,46);
            pt.pnt1("Nhấn ESC để thoát", 10, 47);
        label:
            ConsoleKeyInfo ktt = Console.ReadKey();
            switch (ktt.Key)
            {
                case ConsoleKey.Enter:
                    tdbll.themdiem(td);
                    Console.Clear();
                    tinhdiemtbky1();
                    break;
                case ConsoleKey.Tab:
                    pt.pnt1("                                                     ", 10, 45);
                    pt.pnt1("                                  ", 10, 46);
                    pt.pnt1("                           ", 10, 47);
                    pt.pnt1("       ", 70, 12);
                    pt.pnt1("                              ", 54, 8);
                    pt.pnt1("━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━", 54, 8);
                    pt.pnt1("                                 ", 38, 12);
                    pt.pnt1("1. Tính điểm trung bình học kỳ I         ", 78, 44);
                    pt.pnt1("2. Tính điểm trung bình học kỳ II", 78, 45);
                    pt.pnt1("3. Tính điểm trung bình cả năm", 78, 46);
                    pt.pnt1("4. Quay lại quản lý điểm", 78, 47);
                    pt.pnt1("5. Để thoát chương trình", 78, 48);
                    pt.pnt1("", 94, 49);
                    goto chucnang;
                case ConsoleKey.Escape:
                    Environment.Exit(0);
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    pt.pnt1("      ", 78, 47);
                    pt.pnt1("Bạn nhập sai ! Xin nhập lại ", 60, 48);
                    pt.pnt1("", 78, 47);
                    goto label;
            }
            #endregion
            #region Tính điểm trung bình kỳ 2
            tinhdiemtbky2:
            string mahs2;
            double diemtb2;
            string hocky2 = "II";
            mahs2:
            pt.pnt1("", 70, 12); mahs2 = Console.ReadLine();
            if (mahs2 == "")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                pt.pnt1("Mã học sinh không rỗng ! Nhấn phím bất kỳ nhập lại ", 15, 45);
                pt.pnt1("Nhấn Tab để quay lại", 15, 46);
                Console.ForegroundColor = ConsoleColor.White;
                ConsoleKeyInfo kt = Console.ReadKey();
                switch (kt.Key)
                {
                    case ConsoleKey.Tab:
                        pt.pnt1("                                                     ", 15, 45);
                        pt.pnt1("                                  ", 15, 46);
                        pt.pnt1("                              ", 54, 8);
                        pt.pnt1("━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━", 54, 8);
                        pt.pnt1("                                 ", 38, 12);
                        pt.pnt1("1. Tính điểm trung bình học kỳ I         ", 78, 44);
                        pt.pnt1("2. Tính điểm trung bình học kỳ II         ", 78, 45);
                        pt.pnt1("3. Tính điểm trung bình cả năm", 78, 46);
                        pt.pnt1("4. Quay lại quản lý điểm", 78, 47);
                        pt.pnt1("5. Để thoát chương trình", 78, 48);
                        pt.pnt1("", 94, 49);
                        goto chucnang;
                    default:
                        pt.pnt1("                                                     ", 15, 45);
                        pt.pnt1("                                  ", 15, 46);
                        goto mahs2;
                }
            }
            if (bdbll.KTmahs(mahs2) == true)
            {
                if (bdbll.KThocky2(hocky2) == true)
                {
                    if (tdbll.kiemtradiemky2(mahs2) == false)
                    {
                        if (tdbll.layhocky2(mahs2).ToLower() == "II".ToLower())
                        {
                            diemtb2 = bdbll.Tinhdiemtbky2(mahs2);
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            pt.pnt1("Học sinh chưa có điểm kỳ II ! Yêu cầu nhập điểm ", 15, 45);
                            pt.pnt1("Nhấn phím bất kỳ để nhập lại", 15, 46);
                            Console.ForegroundColor = ConsoleColor.White;
                            ConsoleKeyInfo kt = Console.ReadKey();
                            switch (kt.Key)
                            {
                                default:
                                    pt.pnt1("                                                             ", 15, 45);
                                    pt.pnt1("                                        ", 15, 46);
                                    pt.pnt1("           ", 70, 12);
                                    goto mahs2;
                            }
                        }
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        pt.pnt1("Học sinh đã tính điểm kỳ II ", 15, 45);
                        pt.pnt1("Nhấn phím bất kỳ để nhập lại", 15, 46);
                        Console.ForegroundColor = ConsoleColor.White;
                        ConsoleKeyInfo kt = Console.ReadKey();
                        switch (kt.Key)
                        {
                            default:
                                pt.pnt1("                                        ", 15, 45);
                                pt.pnt1("                                        ", 15, 46);
                                pt.pnt1("           ", 70, 12);
                                goto mahs2;
                        }
                    }
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    pt.pnt1("Mã học sinh không tồn tại hoặc học sinh chưa có điểm ! Nhấn phím bất kỳ nhập lại ", 15, 45);
                    Console.ForegroundColor = ConsoleColor.White;
                    ConsoleKeyInfo kt = Console.ReadKey();
                    switch (kt.Key)
                    {
                        default:
                    pt.pnt1("                                                                                     ", 15, 45);
                            pt.pnt1("           ", 70, 12);
                            goto mahs2;
                    }
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                pt.pnt1("Mã học sinh không tồn tại hoặc học sinh chưa có điểm !", 15, 45);
                pt.pnt1("Nhấn phím bất kỳ nhập lại ", 15, 46);
                Console.ForegroundColor = ConsoleColor.White;
                ConsoleKeyInfo kt = Console.ReadKey();
                switch (kt.Key)
                {
                    default:
                pt.pnt1("                                                         ", 15, 45);
                        pt.pnt1("                                   ", 15, 46);
                        pt.pnt1("           ", 70, 12);
                        goto mahs2;
                }
            }
            TinhDiem td2 = new TinhDiem(mahs2, hocky2, diemtb2);
            pt.pnt1("Nhấn Enter để tính tiếp", 10, 45);
            pt.pnt1("Nhấn Tab để quay lại", 10, 46);
            pt.pnt1("Nhấn ESC để thoát", 10, 47);
            label2:
            ConsoleKeyInfo kttt = Console.ReadKey();
            switch (kttt.Key)
            {
                case ConsoleKey.Enter:
                    tdbll.themdiem(td2);
                    Console.Clear();
                    tinhdiemtbky1();
                    break;
                case ConsoleKey.Tab:
                    pt.pnt1("                                                     ", 10, 45);
                    pt.pnt1("                                  ", 10, 46);
                    pt.pnt1("                           ", 10, 47);
                    pt.pnt1("       ", 70, 12);
                    pt.pnt1("                              ", 54, 8);
                    pt.pnt1("━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━", 54, 8);
                    pt.pnt1("                                 ", 38, 12);
                    pt.pnt1("1. Tính điểm trung bình học kỳ I         ", 78, 44);
                    pt.pnt1("2. Tính điểm trung bình học kỳ II        ", 78, 45);
                    pt.pnt1("3. Tính điểm trung bình cả năm", 78, 46);
                    pt.pnt1("4. Quay lại quản lý điểm", 78, 47);
                    pt.pnt1("5. Để thoát chương trình", 78, 48);
                    pt.pnt1("", 94, 49);
                    goto chucnang;
                case ConsoleKey.Escape:
                    return;
                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    pt.pnt1("      ", 78, 47);
                    pt.pnt1("Bạn nhập sai ! Xin nhập lại ", 60, 48);
                    pt.pnt1("", 78, 47);
                    goto label2;
            }
            #endregion
            #region Tính điểm trung bình cả năm
            tinhdiemtbcn:
            string mahsc;
            double diemtbc;
            string hockyc = "Ca nam";
            mahsc:
            pt.pnt1("", 70, 12); mahsc = Console.ReadLine();
            if (mahsc == "")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                pt.pnt1("Mã học sinh không rỗng ! Nhấn phím bất kỳ nhập lại ", 15, 45);
                pt.pnt1("Nhấn Tab để quay lại", 15, 46);
                Console.ForegroundColor = ConsoleColor.White;
                ConsoleKeyInfo kt = Console.ReadKey();
                switch (kt.Key)
                {
                    case ConsoleKey.Tab:
                        pt.pnt1("                                                     ", 15, 45);
                        pt.pnt1("                                  ", 15, 46);
                        pt.pnt1("                              ", 54, 8);
                        pt.pnt1("━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━", 54, 8);
                        pt.pnt1("                                 ", 38, 12);
                        pt.pnt1("1. Tính điểm trung bình học kỳ I         ", 78, 44);
                        pt.pnt1("2. Tính điểm trung bình học kỳ II         ", 78, 45);
                        pt.pnt1("3. Tính điểm trung bình cả năm         ", 78, 46);
                        pt.pnt1("4. Quay lại quản lý điểm", 78, 47);
                        pt.pnt1("5. Để thoát chương trình", 78, 48);
                        pt.pnt1("", 94, 50);
                        goto chucnang;
                    default:
                        pt.pnt1("                                                     ", 15, 45);
                        pt.pnt1("                                  ", 15, 46);
                        goto mahsc;
                }
            }
            if (bdbll.KTmahs(mahsc) == true)
            {
                if (tdbll.kiemtradiemcanam(mahsc) == false)
                {
                    if (tdbll.kiemtradiemky1(mahsc) == true)
                    {
                        if (tdbll.kiemtradiemky2(mahsc) == true)
                        {
                            diemtbc = bdbll.Tinhdiemtbcn(mahsc);
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            pt.pnt1("Học sinh chưa tính điểm kỳ II ! Yêu cầu tính điểm", 15, 45);
                            pt.pnt1("Nhấn phím bất kỳ để nhập lại", 15, 46);
                            Console.ForegroundColor = ConsoleColor.White;
                            ConsoleKeyInfo kt = Console.ReadKey();
                            switch (kt.Key)
                            {
                                default:
                                    pt.pnt1("                                                  ", 15, 45);
                                    pt.pnt1("                                                  ", 15, 46);
                                    pt.pnt1("           ", 70, 12);
                                    goto mahsc;
                            }
                        }
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        pt.pnt1("Học sinh chưa tính điểm kỳ I! Yêu cầu tính điểm", 15, 45);
                        pt.pnt1("Nhấn phím bất kỳ để nhập lại", 15, 46);
                        Console.ForegroundColor = ConsoleColor.White;
                        ConsoleKeyInfo kt = Console.ReadKey();
                        switch (kt.Key)
                        {
                            default:
                                pt.pnt1("                                                  ", 15, 45);
                                pt.pnt1("                                                  ", 15, 46);
                                pt.pnt1("           ", 70, 12);
                                goto mahsc;
                        }
                    }
                }
                else
                {

                    Console.ForegroundColor = ConsoleColor.Red;
                    pt.pnt1("Học sinh đã tính điểm trung bình cả năm !", 15, 45);
                    pt.pnt1("Nhấn phím bất kỳ để nhập lại", 15, 46);
                    Console.ForegroundColor = ConsoleColor.White;
                    ConsoleKeyInfo kt = Console.ReadKey();
                    switch (kt.Key)
                    {
                        default:
                            pt.pnt1("                                                  ", 15, 45);
                            pt.pnt1("                                                  ", 15, 46);
                            pt.pnt1("           ", 70, 12);
                            goto mahsc;
                    }
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                pt.pnt1("Mã học sinh không tồn tại hoặc học sinh chưa có điểm !", 15, 45);
                pt.pnt1(" Nhấn phím bất kỳ nhập lại ", 15, 46);
                Console.ForegroundColor = ConsoleColor.White;
                ConsoleKeyInfo kt = Console.ReadKey();
                switch (kt.Key)
                {
                    default:
               pt.pnt1("                                                           ", 15, 45);
                        pt.pnt1("                                ", 15, 46);
                        pt.pnt1("           ", 70, 12);
                        goto mahsc;
                }
            }
            TinhDiem tdc = new TinhDiem(mahsc, hockyc, diemtbc);
            pt.pnt1("Nhấn Enter để tính tiếp", 10, 45);
            pt.pnt1("Nhấn Tab để quay lại", 10, 46);
            pt.pnt1("Nhấn ESC để thoát", 10, 47);
            label3:
            ConsoleKeyInfo ktttt = Console.ReadKey();
            switch (ktttt.Key)
            {
                case ConsoleKey.Enter:
                    tdbll.themdiem(tdc);
                    Console.Clear();
                    tinhdiemtbky1();
                    break;
                case ConsoleKey.Tab:
                    pt.pnt1("                                                     ", 10, 45);
                    pt.pnt1("                                  ", 10, 46);
                    pt.pnt1("                           ", 10, 47);
                    pt.pnt1("       ", 70, 12);
                    pt.pnt1("                              ", 54, 8);
                    pt.pnt1("━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━", 54, 8);
                    pt.pnt1("                                 ", 38, 12);
                    pt.pnt1("1. Tính điểm trung bình học kỳ I         ", 78, 44);
                    pt.pnt1("2. Tính điểm trung bình học kỳ II", 78, 45);
                    pt.pnt1("3. Tính điểm trung bình cả năm    ", 78, 46);
                    pt.pnt1("4. Quay lại quản lý điểm", 78, 47);
                    pt.pnt1("5. Để thoát chương trình", 78, 48);
                    pt.pnt1("", 94, 50);
                    goto chucnang;
                case ConsoleKey.Escape:
                    Environment.Exit(0);
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    pt.pnt1("      ", 78, 47);
                    pt.pnt1("Bạn nhập sai ! Xin nhập lại ", 60, 48);
                    pt.pnt1("", 78, 47);
                    goto label3;
            }
            #endregion
        }
        #endregion
        #endregion
    }
}
