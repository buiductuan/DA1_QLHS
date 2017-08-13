using System;
using System.Linq;
using System.Text;
using QLHS.Utility;
using QLHS.Presenations;
using QLHS.Entities;
using QLHS.Business.Components;
using QLHS.DataAccessLayer;
using System.IO;
namespace QLHS.Presenations
{
    public class FormThongKe
    {
        #region Giao diện và chức năng thống kê
        Paint pt = new Paint(140, 55);
        private string maloptk;
        LopBLL lopbll = new LopBLL();
        HocSinhBLL hsbll = new HocSinhBLL();
        BangDiemBLL bdbll = new BangDiemBLL();
        TinhDiemBLL tdbll = new TinhDiemBLL();
        GVCNBLL gvbll = new GVCNBLL();
        public static MenuChinh mn = new MenuChinh();
        #region chức năng quản lý thống kê
        public void chucnangthk()
        {
            pt.pnt("┏", 4, 8);
            pt.pnt("┗", 4, 37);
            pt.pnt("┓", 95, 8);
            pt.pnt("┛", 95, 37);

            pt.pnt("━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━", 5, 8);
            pt.pnt("━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━", 5, 37);
            pt.pnt("                                TRƯỜNG ĐẠI HỌC SƯ PHẠM KỸ THUẬT HƯNG YÊN ", 0, 4);
            pt.pnt("                                      KHOA CÔNG NGHỆ THÔNG TIN ", 1, 5);
            pt.pnt("                                     ------- ○○○○ -------", 3, 6);
            for (int i = 9; i < 37; ++i)
            {
                pt.pnt("┃", 4, i);
                pt.pnt("┃", 95, i);
            }
            Console.ForegroundColor = ConsoleColor.Red;
            #region Chữ ký
            Console.ForegroundColor = ConsoleColor.Red;
            pt.pnt("D", 5, 36);
            Console.ForegroundColor = ConsoleColor.White;
            pt.pnt("e", 6, 36);
            Console.ForegroundColor = ConsoleColor.Cyan;
            pt.pnt("s", 7, 36);
            Console.ForegroundColor = ConsoleColor.Green;
            pt.pnt("i", 8, 36);
            Console.ForegroundColor = ConsoleColor.Yellow;
            pt.pnt("g", 9, 36);
            Console.ForegroundColor = ConsoleColor.Gray;
            pt.pnt("n", 10, 36);
            Console.ForegroundColor = ConsoleColor.Magenta;
            pt.pnt("e", 11, 36);
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            pt.pnt("d", 12, 36);
            Console.ForegroundColor = ConsoleColor.DarkRed;
            pt.pnt("b", 14, 36);
            Console.ForegroundColor = ConsoleColor.Yellow;
            pt.pnt("y", 15, 36);
            Console.ForegroundColor = ConsoleColor.Red;
            pt.pnt("T", 17, 36);
            Console.ForegroundColor = ConsoleColor.Yellow;
            pt.pnt("e", 18, 36);
            Console.ForegroundColor = ConsoleColor.Green;
            pt.pnt("a", 19, 36);
            Console.ForegroundColor = ConsoleColor.Red;
            pt.pnt("m", 20, 36);
            Console.ForegroundColor = ConsoleColor.Magenta;
            pt.pnt("T", 22, 36);
            Console.ForegroundColor = ConsoleColor.Yellow;
            pt.pnt("™", 23, 36);
            Console.ForegroundColor = ConsoleColor.White;
            #endregion
            Console.ForegroundColor = ConsoleColor.Green;
            pt.pnt(" CHƯƠNG TRÌNH QUẢN LÝ HỌC SINH", 34, 9);
            Console.ForegroundColor = ConsoleColor.White;
            //=============================================
            pt.pnt("┏", 19, 14);
            pt.pnt("┓", 79, 14);
            pt.pnt("━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━", 20, 14);
            pt.pnt("┛", 79, 30);
            pt.pnt("┗", 19, 30);
            for (int i = 15; i < 30; ++i)
            {
                pt.pnt("┃", 19, i);
                pt.pnt("┃", 79, i);
            }
            pt.pnt("┣", 19, 18);
            pt.pnt("┣", 19, 20);
            pt.pnt("┣", 19, 22);
            pt.pnt("┣", 19, 24);
            pt.pnt("┣", 19, 26);
            pt.pnt("┣", 19, 28);


            pt.pnt("┫", 79, 18);
            pt.pnt("┫", 79, 20);
            pt.pnt("┫", 79, 22);
            pt.pnt("┫", 79, 24);
            pt.pnt("┫", 79, 26);
            pt.pnt("┫", 79, 28);

            pt.pnt("━━━━━┳━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━", 20, 18);
            pt.pnt("━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━", 20, 20);
            pt.pnt("━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━", 20, 22);
            pt.pnt("━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━", 20, 24);
            pt.pnt("━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━", 20, 26);
            pt.pnt("━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━", 20, 28);
            pt.pnt("━━━━━┻━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━", 20, 30);



            for (int i = 19; i < 30; ++i)
            {
                pt.pnt("┃", 25, i);
            }

            Console.ForegroundColor = ConsoleColor.Yellow;
            pt.pnt("                CHỨC NĂNG THỐNG KÊ               ", 25, 16);
            Console.ForegroundColor = ConsoleColor.Magenta;
            pt.pnt("F1", 22, 19);
            pt.pnt("F2", 22, 21);
            pt.pnt("F3", 22, 23);
            pt.pnt("F4", 22, 25);
            pt.pnt("F5", 22, 27);
            pt.pnt("F6", 22, 29);
            Console.ForegroundColor = ConsoleColor.White;
            pt.pnt("Thống kê danh sách học sinh giỏi", 32, 19);
            pt.pnt("Thống kê danh sách học sinh khá ", 32, 21);
            pt.pnt("Thống kê danh sách học sinh lưu ban", 32, 23);
            pt.pnt("Thống kê hạnh kiểm ", 32, 25);
            pt.pnt("Thống kê số lượng học sinh của toàn trường ", 32, 27);
            pt.pnt("Thống kê kết quả gửi cho phụ huynh học sinh", 32, 29);
            Console.ForegroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Yellow;
            pt.pnt("Hoặc ↓↑", 60, 33);
            Console.ForegroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.White;
            pt.pnt("Nhấn", 60, 34);
            Console.ForegroundColor = ConsoleColor.Green;
            pt.pnt("Tab", 65, 34);
            Console.ForegroundColor = ConsoleColor.White;
            pt.pnt("để quay lại", 69, 34);
            pt.pnt("Nhấn", 60, 35);
            Console.ForegroundColor = ConsoleColor.Green;
            pt.pnt("Esc", 65, 35);
            Console.ForegroundColor = ConsoleColor.White;
            pt.pnt("để thoát khỏi chương trình", 69, 35);
            pt.pnt("Mời bạn chọn chức năng : ", 60, 32);

        den1: ConsoleKeyInfo kt = Console.ReadKey();
            Console.ForegroundColor = ConsoleColor.White;
            switch (kt.Key)
            {
                case ConsoleKey.F1:
                    Console.Clear();
                    danhsachhocsinhgioi();
                    break;
                case ConsoleKey.F2:
                    Console.Clear();
                    danhsachhocsinhkha();
                    break;
                case ConsoleKey.F3:
                    Console.Clear();
                    danhsachhocsinhluuban();
                    break;
                case ConsoleKey.F4:
                    Console.Clear();
                    chucnangthongkehanhkiem();
                    break;
                case ConsoleKey.F5:
                    Console.Clear();
                    thongkesoluonghs();
                    break;
                case ConsoleKey.F6:
                    Console.Clear();
                    thongbaoketquahoctap();
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
                    pt.pnt("       ", 85, 32);
                    pt.pnt("Bạn nhập sai xin nhập lại", 60, 36);
                    pt.pnt("", 85, 32);
                    Console.ForegroundColor = ConsoleColor.White;
                    goto den1;
            }
        }
        #endregion
        #region Thống kê số lượng học sinh
        public void thongkesoluonghs()
        {
            Console.Clear();
            Paint pt = new Paint(137, 55);
            pt.pnt1("━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━", 4,2);
            pt.pnt1("━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━", 4, 48);
            pt.pnt1("PHÒNG GIÁO DỤC VÀ ĐÀO TẠO .................", 5, 3);
            pt.pnt1("TRƯỜNG TIỂU HỌC ................. ", 11, 4);
            pt.pnt1("THỐNG KÊ SỐ LƯỢNG HỌC SINH ", 55, 8);
            DateTime dtnh = DateTime.Now;
            pt.pnt1("NĂM HỌC", 59, 9);
            pt.pnt1(Convert.ToString(dtnh.Year - 1) + "-" + Convert.ToString(dtnh.Year), 67, 9);
            for (int i = 13; i < 37; i++)
            {
                pt.pnt1("┃", 18, i);
                pt.pnt1("┃", 117, i);
            }

            for (int i = 3; i < 48; i++)
            {
                pt.pnt1("┃", 3, i);
                pt.pnt1("┃", 132, i);
            }

            pt.pnt1("┏", 3, 2);
            pt.pnt1("┗", 3, 48);
            pt.pnt1("┓", 132, 2);
            pt.pnt1("┛", 132, 48);

            pt.pnt1("┏", 18, 12);
            pt.pnt1("┗", 18, 37);
            pt.pnt1("┓", 117, 12);
            pt.pnt1("┛", 117, 37);


            Console.ForegroundColor = ConsoleColor.Magenta;
            pt.pnt1("Designed by TeamT ™", 5, 47);
            Console.ForegroundColor = ConsoleColor.White;
            pt.pnt1("━━━━━━━┳━━━━━━━━━━━━━━━━━━━━━━━━┳━━━━━━━━━━━━━━━━┳━━━━━━━━━━━┳━━━━━━━━━━━┳━━━━━━━━━━━━━━━━━━━━━━━━", 19, 12);
            pt.pnt1("━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━", 19, 14);
            pt.pnt1("━━━━━━━┻━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━", 19, 35);

            pt.pnt1("━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┻━━━━━━━━━━━━━━━━┻━━━━━━━━━━━┻━━━━━━━━━━━┻━━━━━━━━━━━━━━━━━━━━━━━━", 19, 37);


            for(int i = 13; i < 35; ++i)
            {
                pt.pnt1("┃", 26, i);

            }
            for (int i = 13; i < 37; i++)
            {
                pt.pnt1("┃", 51, i);

                pt.pnt1("┃", 68, i);
                pt.pnt1("┃", 80, i);
                pt.pnt1("┃", 92, i);

            }
            pt.pnt1("STT", 21, 13);
            pt.pnt1("LỚP", 37, 13);
            pt.pnt1("SỐ HS", 58, 13);
            pt.pnt1("NAM", 73, 13);
            pt.pnt1("NỮ", 85, 13);
            pt.pnt1("GHI CHÚ", 102, 13);
            pt.pnt1("TỔNG", 33, 36);
            List<Lop> listl = lopbll.LayDlLop();
            int a = 15;
            int d = 1;
            int shs =0;
            int shsnam = 0;
            int shsnu = 0;
            int tongshs = 0;
            int tonghsnam = 0;
            int tonghsnu = 0;
            for(int i = 0; i < listl.Count; ++i)
            {
                pt.pnt1(listl[i].Tenlop, 37, a);
                pt.pnt1(Convert.ToString(d), 21, a);
                d++;
                // số lượng học sinh của mỗi lớp
                shs = hsbll.demhs(listl[i].Malop);
                pt.pnt1(Convert.ToString(shs), 58, a);

                // tổng số học sinh của toàn trường
                tongshs += shs;
                pt.pnt1(Convert.ToString(tongshs), 58, 36);

                // số học sinh nam của 1 lớp
                shsnam = hsbll.demhsnam(listl[i].Malop);
                pt.pnt1(Convert.ToString(shsnam), 73, a);

                // số lượng học sinh nữ của 1 lớp
                shsnu = hsbll.demhsnu(listl[i].Malop);
                pt.pnt1(Convert.ToString(shsnu), 85, a);

                //Tổng học sinh nữ của toàn trường
                tonghsnu += shsnu;
                pt.pnt1(Convert.ToString(tonghsnu), 85, 36);

                //Tổng số học sinh nam của toàn trường
                tonghsnam += shsnam;
                pt.pnt1(Convert.ToString(tonghsnam), 73, 36);
                a += 2;
            }
            DateTime dt = DateTime.Now;
            pt.pnt1("Số liệu được cập nhật hàng ngày trong năm học 2014-2015", 70, 39);
            pt.pnt1("..... ngày "+Convert.ToString(dt.Day)+"  tháng  "+Convert.ToString(dt.Month)+"  năm  "+Convert.ToString(dt.Year), 75, 40);
            pt.pnt1("HIỆU TRƯỞNG", 88, 42);
            pt.pnt1("Nhấn Tab để quay lại ", 110, 47);
          label:  ConsoleKeyInfo kt = Console.ReadKey();
            switch (kt.Key)
            {
                case ConsoleKey.Tab:
                    Console.Clear();
                    chucnangthk();
                    break;
                default:
                    pt.pnt1("", 131, 47);
                    goto label;
            }
        }
        #endregion
        #region Chức năng thống kê hạnh kiểm
        public void chucnangthongkehanhkiem()
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
            pt.pnt("Designed by TeamT ™ ", 5, 32);
            Console.ForegroundColor = ConsoleColor.White;
            //=============================================
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
            pt.pnt("┣", 19, 18);
            pt.pnt("┣", 19, 20);
            pt.pnt("┣", 19, 22);

            pt.pnt("┫", 79, 18);
            pt.pnt("┫", 79, 20);
            pt.pnt("┫", 79, 22);

            pt.pnt("━━━━━┳━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━", 20, 18);
            pt.pnt("━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━", 20, 20);
            pt.pnt("━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━", 20, 22);
            pt.pnt("━━━━━┻━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━", 20, 24);



            for (int i = 19; i < 24; ++i)
            {
                pt.pnt("┃", 25, i);
            }

            pt.pnt("                 THỐNG KÊ HẠNH KIỂM              ", 25, 16);
            pt.pnt("F1", 22, 19);
            pt.pnt("F2", 22, 21);
            pt.pnt("F3", 22, 23);
            pt.pnt("Thống kê hạnh kiểm kỳ I", 32, 19);
            pt.pnt("Thống kê hạnh kiểm kỳ II ", 32, 21);
            pt.pnt("Thống kê hạnh kiểm cả năm", 32, 23);
            pt.pnt("Nhấn Tab để quay lại ", 60, 29);
            pt.pnt("Thoát khỏi chương trình nhấn Esc", 60, 30);
            pt.pnt("Mời bạn chọn chức năng : ", 60, 31);
        den1: ConsoleKeyInfo kt = Console.ReadKey();
            Console.ForegroundColor = ConsoleColor.White;
            switch (kt.Key)

            {
                case ConsoleKey.F1:
                    Console.Clear();
                    hanhkiem1();
                    break;
                case ConsoleKey.F2:
                    Console.Clear();
                    hanhkiem2();
                    break;
                case ConsoleKey.F3:
                    Console.Clear();
                    hanhkiemcn();
                    break;
                case ConsoleKey.Tab:
                    Console.Clear();
                    chucnangthk();
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
        #region Thống kê hạnh kiểm kỳ I
        public void hanhkiem1()
        {
            Console.Clear();
            Paint pt = new Paint(137, 55);
            pt.pnt1("━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━", 4, 2);
            pt.pnt1("━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━", 4, 38);
            pt.pnt1("PHÒNG GIÁO DỤC VÀ ĐÀO TẠO .................", 5, 3);
            pt.pnt1("TRƯỜNG TIỂU HỌC ................. ", 11, 4);
            pt.pnt1("THỐNG KÊ HẠNH KIỂM KỲ I ", 55, 8);
            pt.pnt1("NĂM HỌC 2014-2015", 59, 9);

            for (int i = 13; i < 22; i++)
            {
                pt.pnt1("┃", 9, i);
                pt.pnt1("┃", 127, i);
            }

            for (int i = 3; i < 38; i++)
            {
                pt.pnt1("┃", 3, i);
                pt.pnt1("┃", 132, i);
            }

            pt.pnt1("┏", 3, 2);
            pt.pnt1("┗", 3, 38);
            pt.pnt1("┓", 132, 2);
            pt.pnt1("┛", 132, 38);

            pt.pnt1("┏", 9, 12);
            pt.pnt1("┗", 9, 22);
            pt.pnt1("┓", 127, 12);
            pt.pnt1("┛", 127, 22);

            Console.ForegroundColor = ConsoleColor.Magenta;
            pt.pnt1("Designed by TeamT ™", 5, 37);
            Console.ForegroundColor = ConsoleColor.White;
            pt.pnt1("━━━━━━━━━━━━━━━━━━━━━━━━┳━━━━━━━━━━━━━━━━━━━━━┳━━━━━━━━━━━━━━━━━━━━━━━┳━━━━━━━━━━━━━━━━━━━━━━━━━┳━━━━━━━━━━━━━━━━━━━━", 10, 12);
            pt.pnt1("━━━━━━━━┳━━━━━━━━━┳━━━━━━━━━━━━┳━━━━━━━┳━━━━━━━━━━━━━━━┳━━━━━━━┳━━━━━━━━━━━━━━┳━━━━━━━━┳━━━━━━━━━━━━━━━┳━━━━━━━┳━━━━━", 10, 14);
            pt.pnt1("━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━", 10, 16);
            pt.pnt1("━━━━━━━━┻━━━━━━━━━┻━━━━━┻━━━━━━┻━━━━━━━┻━━━━━━┻━━━━━━━━┻━━━━━━━┻━━━━━━┻━━━━━━━┻━━━━━━━━┻━━━━━━━━┻━━━━━━┻━━━━━━━┻━━━━━", 10, 22);


            for (int i = 13; i < 22; i++)
            {
                pt.pnt1("┃", 34, i);
                pt.pnt1("┃", 56, i);
                pt.pnt1("┃", 80, i);
                pt.pnt1("┃", 106, i);

            }

            for (int i = 15; i < 22; i++)
            {
                pt.pnt1("┃", 18, i);
                pt.pnt1("┃", 28, i);
                pt.pnt1("┃", 41, i);
                pt.pnt1("┃", 49, i);
                pt.pnt1("┃", 65, i);
                pt.pnt1("┃", 73, i);
                pt.pnt1("┃", 88, i);
                pt.pnt1("┃", 97, i);
                pt.pnt1("┃", 113, i);
                pt.pnt1("┃", 121, i);

            }
            pt.pnt1("LỚP 1", 21, 13);
            pt.pnt1("LỚP 2", 44, 13);
            pt.pnt1("LỚP 3", 66, 13);
            pt.pnt1("LỚP 4", 91, 13);
            pt.pnt1("LỚP 5", 115, 13);

            pt.pnt1("Tổng", 12, 15);
            pt.pnt1("Tốt", 22, 15);
            pt.pnt1("Khá", 30, 15);

            pt.pnt1("Tổng", 36, 15);
            pt.pnt1("Tốt", 44, 15);
            pt.pnt1("Khá", 52, 15);

            pt.pnt1("Tổng", 59, 15);
            pt.pnt1("Tốt", 68, 15);
            pt.pnt1("Khá", 75, 15);

            pt.pnt1("Tổng", 83, 15);
            pt.pnt1("Tốt", 92, 15);
            pt.pnt1("Khá", 100, 15);

            pt.pnt1("Tổng", 108, 15);
            pt.pnt1("Tốt", 116, 15);
            pt.pnt1("Khá", 123, 15);

            pt.pnt1("Tổng số học sinh     : ", 10, 24);
            pt.pnt1("Xếp loại hạnh kiểm    ", 10, 25);
            pt.pnt1("Tốt : ", 27, 26); pt.pnt1("  ,  Tỉ lệ : ", 40, 26);pt.pnt1("%", 60, 26);
            pt.pnt1("Khá : ", 27, 27); pt.pnt1("  ,  Tỉ lệ : ", 40, 27); pt.pnt1("%", 60, 27);
            pt.pnt1("......", 90, 25);pt.pnt1("ngày", 98, 25);pt.pnt1("tháng", 106, 25);pt.pnt1("năm", 115, 25);
            pt.pnt1("HIỆU TRƯỞNG", 102, 27);
            int hs1 = 0;
            int hs2 = 0;
            int hs3 = 0;
            int hs4 = 0;
            int hs5 = 0;
            int ths = 0;
            List<HocSinh> lisths = hsbll.LayDlhs();
            for (int i = 0; i < lisths.Count; ++i)
            {
                ths =hs1+hs2+hs3+hs4+hs5;
                pt.pnt1(Convert.ToString(ths), 33, 24);
                hs1 = hsbll.demhslop1("L1","L2");
                pt.pnt1(Convert.ToString(hs1), 14, 19);

                hs2 = hsbll.demhslop2("L3","L4");
                pt.pnt1(Convert.ToString(hs2), 37, 19);

                hs3 = hsbll.demhslop3("L5","L6");
                pt.pnt1(Convert.ToString(hs3), 61, 19);

                hs4 = hsbll.demhslop4("L8","L7");
                pt.pnt1(Convert.ToString(hs4), 84, 19);

                hs5 = hsbll.demhslop5("L9","L10");
                pt.pnt1(Convert.ToString(hs5), 110, 19);
            }
            int dt1 = 0;
            List<BangDiem> listbd = bdbll.LayDlbd();
            for(int i = 0; i < listbd.Count; i++)
            {
                pt.pnt1(Convert.ToString(dt1), 23, 19);
                dt1 = bdbll.demhanhkiem1t("L1", "L2");
            }
            pt.pnt1("Nhấn Tab để quay lại", 107, 36);
         label:   ConsoleKeyInfo kt = Console.ReadKey();
            switch (kt.Key)
            {
                case ConsoleKey.Tab:
                    Console.Clear();
                    chucnangthongkehanhkiem();
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    pt.pnt1("    ", 127, 36);
                    pt.pnt1("Bạn nhập sai Xin nhập lại", 107, 37);
                    pt.pnt1("", 127, 36);
                    Console.ForegroundColor = ConsoleColor.White;
                    goto label;

            }
        }
   
        #endregion
        #region Thống kê hạnh kiểm kỳ II
        public void hanhkiem2()
        {

        }
        #endregion
        #region Thống kê hạnh kiểm cả năm 
        public void hanhkiemcn()
        {

        }
        #endregion
        #region Danh sách học sinh giỏi
        public void danhsachhocsinhgioi()
        {
            pt.pnt1("━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━", 4, 2);
            pt.pnt1("━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━", 4, 48);
            pt.pnt1("┏", 3, 2);
            pt.pnt1("┗", 3, 48);
            pt.pnt1("┓", 131, 2);
            pt.pnt1("┛", 131, 48);
            for (int i = 3; i < 48; i++)
            {
                pt.pnt1("┃", 3, i);
                pt.pnt1("┃", 131, i);
            }

            pt.pnt1("PHÒNG GIÁO DỤC VÀ ĐÀO TẠO .................", 5, 3);
            pt.pnt1("TRƯỜNG TIỂU HỌC ................. ", 11, 4);
            pt.pnt1("THỐNG KÊ DANH SÁCH HỌC SINH GIỎI CỦA TOÀN TRƯỜNG ", 44, 8);
            pt.pnt1("NĂM HỌC 2014-2015", 59, 9);

            pt.pnt1("━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━", 18, 12);
            for (int i = 13; i < 36; i++)
            {
                pt.pnt1("┃", 18, i);
                pt.pnt1("┃", 117, i);
            }

            pt.pnt1("┏", 18, 12);
            pt.pnt1("┗", 18, 36);
            pt.pnt1("┓", 117, 12);
            pt.pnt1("┛", 117, 36);

            pt.pnt1("┣", 18, 16);
            pt.pnt1("┣", 18, 18);

            pt.pnt1("┫", 117, 16);
            pt.pnt1("┫", 117, 18);

            Console.ForegroundColor = ConsoleColor.Magenta;
            pt.pnt1("Designed by TeamT ™", 5, 47);
            Console.ForegroundColor = ConsoleColor.White;
            pt.pnt1("━━━━━━━━━━━━━━━━━━━━━┳━━━━━━━━━━━━━━━━━━━━━━━━┳━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┳━━━━━━━━━━━━━━━━━━━━", 19, 16);
            pt.pnt1("━━━━━━━━━━━━━━━━━━━━━┻━━━━━━━━━━━━━━━━━━━━━━━━┻━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┻━━━━━━━━━━━━━━━━━━━━", 19, 18);

            pt.pnt1("━━━━━━━━━━━━━━━━━━━━━┻━━━━━━━━━━━━━━━━━━━━━━━━┻━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┻━━━━━━━━━━━━━━━━━━━━", 19, 36);


            for (int i = 17; i < 36; i++)
            {
                pt.pnt1("┃", 40, i);
                pt.pnt1("┃", 65, i);
                pt.pnt1("┃", 96, i);
            }

            pt.pnt1("DANH SÁCH HỌC SINH GIỎI ", 59, 14);
            pt.pnt1(" Mã học sinh ", 23, 17);
            pt.pnt1(" Tên học sinh", 46, 17);
            pt.pnt1(" Điểm trung bình", 74, 17);
            pt.pnt1(" Mã Lớp ", 102, 17);
            pt.pnt1(".....", 82, 38);
            pt.pnt1("ngày", 89, 38); pt.pnt1("  tháng", 93, 38); pt.pnt1("  năm 2015", 100, 38);
            pt.pnt1("HIỆU TRƯỞNG", 93, 40);
            pt.pnt1("Nhấn S để lưu kết quả ra file text ", 8, 38);
            pt.pnt1("Nhấn Tab để quay lại", 8, 39);
            List<TinhDiem> td = tdbll.LayDLTD();
            int slhs = 0;
            for (int i = 0; i < td.Count; ++i)
            {
                if (td[i].Diemtb >= 8&&td[i].Hocky.ToLower()=="ca nam".ToLower())
                {
                    slhs++;
                }
            }
            if (slhs > 0)
            {
                int sd = 9;
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
                vetranggioi(t);
                pt.pnt1("", 99, 11); Console.WriteLine("{0}/{1} trang ◄ {2} ►", t, st, t);
                goto label4;
                label4:
                pt.pnt1("", 28, 39);
                ConsoleKeyInfo p;
                p = Console.ReadKey();
                switch (p.Key)
                {
                    case ConsoleKey.LeftArrow:
                        if (t == 1)
                        {
                            t = 1;
                            goto label4;
                        }
                        else
                        {
                            t--;
                            goto label5;
                        }
                    case ConsoleKey.RightArrow:
                        if (t == st)
                        {
                            t = st;
                            goto label4;
                        }
                        else
                        {
                            t++;
                            goto label5;
                        }
                    case ConsoleKey.S:
                        duarafilegioi(td);
                        Console.Clear();
                        chucnangthk();
                        break;
                    case ConsoleKey.Tab:
                        Console.Clear();
                        chucnangthk();
                        break;
                    case ConsoleKey.Escape:
                        return;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        pt.pnt1("     ", 28, 39);
                        pt.pnt1("Bạn nhập sai xin nhập lại ", 8, 40);
                        pt.pnt1("", 28, 39);
                        Console.ForegroundColor = ConsoleColor.White;
                        goto label4;
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                pt.pnt1(" Không có học sinh giỏi . Nhấn Tab để quay lại ", 10, 42);
                Console.ForegroundColor = ConsoleColor.White;
                label6: ConsoleKeyInfo ktkt = Console.ReadKey();
                switch (ktkt.Key)
                {
                    case ConsoleKey.Tab:
                        Console.Clear();
                        chucnangthk();
                        break;
                    default:
                        pt.pnt1("Nhập sai xin nhập lại ", 10, 43);
                        goto label6;
                }
            }

        }
        public void vetranggioi(int chisotrang)
        {
            for (int i = 19; i < 36; ++i)
            {
                pt.pnt1("       ", 23, i);
                pt.pnt1("                 ", 46, i);
                pt.pnt1("        ", 102, i);
            }
            int a = 19;
            int d1 = 0;
            int sodong = 9;
            List<TinhDiem> td = tdbll.LayDLTD();
            int d = (chisotrang - 1) * sodong + 1;
            for (int j = 0; j < td.Count; j++)
            {
                    if (td[j].Diemtb >= 8 && td[j].Hocky == "Ca nam")
                    {
                        d1++;
                        if ((d1 >= d) && (d1 <= chisotrang * 9))
                        {
                            pt.pnt1(td[j].Mahs, 27, a);
                            pt.pnt1(hsbll.laytenhocsinh(td[j].Mahs), 45, a);
                            pt.pnt1(Convert.ToString(td[j].Diemtb), 79, a);
                            pt.pnt1(hsbll.laymalop(td[j].Mahs), 105, a);
                            a = a + 2;
                        }
                    }
            }
        }
        public void duarafilegioi(List<TinhDiem> list)
        {
            StreamWriter sw = File.CreateText(@"ThongKeXepLoai\HSGioi.txt");
            for(int i = 0; i < list.Count; ++i)
            {
                if (list[i].Diemtb >= 8 && list[i].Hocky=="Ca nam")
                {
                    sw.WriteLine(list[i].Mahs + "#" + hsbll.laytenhocsinh(list[i].Mahs) + "#" + list[i].Diemtb + "#" + hsbll.laymalop(list[i].Mahs));
                }
            }
            sw.Close();
        }
        #endregion
        #region Danh sách học sinh khá
        public void danhsachhocsinhkha()
        {
            pt.pnt1("━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━", 4, 2);
            pt.pnt1("━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━", 4, 48);
            pt.pnt1("┏", 3, 2);
            pt.pnt1("┗", 3, 48);
            pt.pnt1("┓", 131, 2);
            pt.pnt1("┛", 131, 48);
            for (int i = 3; i < 48; i++)
            {
                pt.pnt1("┃", 3, i);
                pt.pnt1("┃", 131, i);
            }

            pt.pnt1("PHÒNG GIÁO DỤC VÀ ĐÀO TẠO .................", 5, 3);
            pt.pnt1("TRƯỜNG TIỂU HỌC ................. ", 11, 4);
            pt.pnt1("THỐNG KÊ DANH SÁCH HỌC SINH KHÁ CỦA TOÀN TRƯỜNG ", 44, 8);
            pt.pnt1("NĂM HỌC 2014-2015", 59, 9);

            pt.pnt1("━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━", 18, 12);
            for (int i = 13; i < 36; i++)
            {
                pt.pnt1("┃", 18, i);
                pt.pnt1("┃", 117, i);
            }

            pt.pnt1("┏", 18, 12);
            pt.pnt1("┗", 18, 36);
            pt.pnt1("┓", 117, 12);
            pt.pnt1("┛", 117, 36);

            pt.pnt1("┣", 18, 16);
            pt.pnt1("┣", 18, 18);

            pt.pnt1("┫", 117, 16);
            pt.pnt1("┫", 117, 18);

            Console.ForegroundColor = ConsoleColor.Magenta;
            pt.pnt1("Designed by TeamT ™", 5, 47);
            Console.ForegroundColor = ConsoleColor.White;
            pt.pnt1("━━━━━━━━━━━━━━━━━━━━━┳━━━━━━━━━━━━━━━━━━━━━━━━┳━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┳━━━━━━━━━━━━━━━━━━━━", 19, 16);
            pt.pnt1("━━━━━━━━━━━━━━━━━━━━━┻━━━━━━━━━━━━━━━━━━━━━━━━┻━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┻━━━━━━━━━━━━━━━━━━━━", 19, 18);

            pt.pnt1("━━━━━━━━━━━━━━━━━━━━━┻━━━━━━━━━━━━━━━━━━━━━━━━┻━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┻━━━━━━━━━━━━━━━━━━━━", 19, 36);


            for (int i = 17; i < 36; i++)
            {
                pt.pnt1("┃", 40, i);
                pt.pnt1("┃", 65, i);
                pt.pnt1("┃", 96, i);
            }

            pt.pnt1("DANH SÁCH HỌC SINH KHÁ ", 59, 14);
            pt.pnt1(" Mã học sinh ", 23, 17);
            pt.pnt1(" Tên học sinh", 46, 17);
            pt.pnt1(" Điểm trung bình", 74, 17);
            pt.pnt1(" Mã Lớp ", 102, 17);
            pt.pnt1(".....", 82, 38);
            pt.pnt1("ngày", 89, 38); pt.pnt1("  tháng", 93, 38); pt.pnt1("  năm 2015", 100, 38);
            pt.pnt1("HIỆU TRƯỞNG", 93, 40);
            pt.pnt1("Nhấn S để lưu kết quả ra file text ", 8, 38);
            pt.pnt1("Nhấn Tab để quay lại", 8, 39);

            List<TinhDiem> td = tdbll.LayDLTD();
            int slhs = 0;
            for (int i = 0; i < td.Count; ++i)
            {
                if (td[i].Diemtb <=7 && td[i].Diemtb<8&&td[i].Hocky.ToLower()=="ca nam".ToLower())
                {
                    slhs++;
                }
            }
            if (slhs > 0)
            {
                int sd = 9;
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
                vetrangkha(t);
                pt.pnt1("", 99, 11); Console.WriteLine("{0}/{1} trang ◄ {2} ►", t, st, t);
                goto label4;
                label4:
                pt.pnt1("", 28, 39);
                ConsoleKeyInfo p;
                p = Console.ReadKey();
                switch (p.Key)
                {
                    case ConsoleKey.LeftArrow:
                        if (t == 1)
                        {
                            t = 1;
                            goto label4;
                        }
                        else
                        {
                            t--;
                            goto label5;
                        }
                    case ConsoleKey.RightArrow:
                        if (t == st)
                        {
                            t = st;
                            goto label4;
                        }
                        else
                        {
                            t++;
                            goto label5;
                        }
                    case ConsoleKey.S:
                        duarafilekha(td);
                        Console.Clear();
                        chucnangthk();
                        break;
                    case ConsoleKey.Tab:
                        Console.Clear();
                        chucnangthk();
                        break;
                    case ConsoleKey.Escape:
                        return;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        pt.pnt1("     ", 28, 39);
                        pt.pnt1("Bạn nhập sai xin nhập lại ", 8, 40);
                        pt.pnt1("", 28, 39);
                        Console.ForegroundColor = ConsoleColor.White;
                        goto label4;
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                pt.pnt1(" Không có học sinh khá . Nhấn Tab để quay lại ", 10, 42);
                Console.ForegroundColor = ConsoleColor.White;
                label6: ConsoleKeyInfo ktkt = Console.ReadKey();
                switch (ktkt.Key)
                {
                    case ConsoleKey.Tab:
                        Console.Clear();
                        chucnangthk();
                        break;
                    default:
                        pt.pnt1("Nhập sai xin nhập lại ", 10, 43);
                        goto label6;
                }
            }

        }
        public void vetrangkha(int chisotrang)
        {
            for (int i = 19; i < 36; ++i)
            {
                pt.pnt1("       ", 23, i);
                pt.pnt1("                 ", 46, i);
                pt.pnt1("        ", 102, i);
            }
            int a = 19;
            int d1 = 0;
            int sodong = 9;
            List<TinhDiem> td = tdbll.LayDLTD();
            int d = (chisotrang - 1) * sodong + 1;
            for (int j = 0; j < td.Count; j++)
            {
                if (td[j].Diemtb >= 7 && td[j].Diemtb <8 && td[j].Hocky == "Ca nam")
                {
                    d1++;
                    if ((d1 >= d) && (d1 <= chisotrang * 9))
                    {
                        pt.pnt1(td[j].Mahs, 27, a);
                        pt.pnt1(hsbll.laytenhocsinh(td[j].Mahs), 45, a);
                        pt.pnt1(Convert.ToString(td[j].Diemtb), 79, a);
                        pt.pnt1(hsbll.laymalop(td[j].Mahs), 105, a);
                        a = a + 2;
                    }
                }
            }
        }
        public void duarafilekha(List<TinhDiem> list)
        {
            StreamWriter sw = File.CreateText(@"ThongKeXepLoai\HSKha.txt");
            for (int i = 0; i < list.Count; ++i)
            {
                if (list[i].Diemtb >= 7 && list[i].Diemtb <8 && list[i].Hocky == "Ca nam")
                {
                    sw.WriteLine(list[i].Mahs + "#" + hsbll.laytenhocsinh(list[i].Mahs) + "#" + list[i].Diemtb + "#" + hsbll.laymalop(list[i].Mahs));
                }
            }
            sw.Close();
        }

        #endregion
        #region Danh sách học sinh lưu ban
        public void danhsachhocsinhluuban()
        {
            pt.pnt1("━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━", 4, 2);
            pt.pnt1("━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━", 4, 48);
            pt.pnt1("┏", 3, 2);
            pt.pnt1("┗", 3, 48);
            pt.pnt1("┓", 131, 2);
            pt.pnt1("┛", 131, 48);
            for (int i = 3; i < 48; i++)
            {
                pt.pnt1("┃", 3, i);
                pt.pnt1("┃", 131, i);
            }

            pt.pnt1("PHÒNG GIÁO DỤC VÀ ĐÀO TẠO .................", 5, 3);
            pt.pnt1("TRƯỜNG TIỂU HỌC ................. ", 11, 4);
            pt.pnt1("THỐNG KÊ DANH SÁCH HỌC SINH LƯU CỦA TOÀN TRƯỜNG ", 44, 8);
            pt.pnt1("NĂM HỌC 2014-2015", 59, 9);

            pt.pnt1("━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━", 18, 12);
            for (int i = 13; i < 36; i++)
            {
                pt.pnt1("┃", 18, i);
                pt.pnt1("┃", 117, i);
            }

            pt.pnt1("┏", 18, 12);
            pt.pnt1("┗", 18, 36);
            pt.pnt1("┓", 117, 12);
            pt.pnt1("┛", 117, 36);

            pt.pnt1("┣", 18, 16);
            pt.pnt1("┣", 18, 18);

            pt.pnt1("┫", 117, 16);
            pt.pnt1("┫", 117, 18);

            Console.ForegroundColor = ConsoleColor.Magenta;
            pt.pnt1("Designed by TeamT ™", 5, 47);
            Console.ForegroundColor = ConsoleColor.White;
            pt.pnt1("━━━━━━━━━━━━━━━━━━━━━┳━━━━━━━━━━━━━━━━━━━━━━━━┳━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┳━━━━━━━━━━━━━━━━━━━━", 19, 16);
            pt.pnt1("━━━━━━━━━━━━━━━━━━━━━┻━━━━━━━━━━━━━━━━━━━━━━━━┻━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┻━━━━━━━━━━━━━━━━━━━━", 19, 18);

            pt.pnt1("━━━━━━━━━━━━━━━━━━━━━┻━━━━━━━━━━━━━━━━━━━━━━━━┻━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┻━━━━━━━━━━━━━━━━━━━━", 19, 36);


            for (int i = 17; i < 36; i++)
            {
                pt.pnt1("┃", 40, i);
                pt.pnt1("┃", 65, i);
                pt.pnt1("┃", 96, i);
            }

            pt.pnt1("DANH SÁCH HỌC SINH LƯU BAN ", 59, 14);
            pt.pnt1(" Mã học sinh ", 23, 17);
            pt.pnt1(" Tên học sinh", 46, 17);
            pt.pnt1(" Điểm trung bình", 74, 17);
            pt.pnt1(" Mã Lớp ", 102, 17);
            pt.pnt1(".....", 82, 38);
            pt.pnt1("ngày", 89, 38);pt.pnt1("  tháng", 93, 38);pt.pnt1("  năm 2015", 100, 38);
            pt.pnt1("HIỆU TRƯỞNG", 93, 40);
            pt.pnt1("Nhấn S để lưu kết quả ra file text ",8,38);
            pt.pnt1("Nhấn Tab để quay lại", 8, 39);
            List<TinhDiem> td = tdbll.LayDLTD();
            int slhs = 0;
            for (int i = 0; i < td.Count; ++i)
            {
                if (td[i].Diemtb  < 4 &&td[i].Hocky.ToLower()=="ca nam".ToLower())
                {
                    slhs++;
                }
            }
            if (slhs > 0)
            {
                int sd = 9;
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
                vetrangluuban(t);
                pt.pnt1("", 99, 11); Console.WriteLine("{0}/{1} trang ◄ {2} ►", t, st, t);
                goto label4;
                label4:
                pt.pnt1("", 28, 39);
                ConsoleKeyInfo p;
                p = Console.ReadKey();
                switch (p.Key)
                {
                    case ConsoleKey.LeftArrow:
                        if (t == 1)
                        {
                            t = 1;
                            goto label4;
                        }
                        else
                        {
                            t--;
                            goto label5;
                        }
                    case ConsoleKey.RightArrow:
                        if (t == st)
                        {
                            t = st;
                            goto label4;
                        }
                        else
                        {
                            t++;
                            goto label5;
                        }
                    case ConsoleKey.S:
                        duarafileluuban(td);
                        Console.Clear();
                        chucnangthk();
                        break;
                    case ConsoleKey.Tab:
                        Console.Clear();
                        chucnangthk();
                        break;
                    case ConsoleKey.Escape:
                        return;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        pt.pnt1("     ", 28, 39);
                        pt.pnt1("Bạn nhập sai xin nhập lại ", 8, 40);
                        pt.pnt1("", 28, 39);
                        Console.ForegroundColor = ConsoleColor.White;
                        goto label4;
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                pt.pnt1(" Không có học sinh lưu ban . Nhấn Tab để quay lại ", 10, 42);
                Console.ForegroundColor = ConsoleColor.White;
                label6: ConsoleKeyInfo ktkt = Console.ReadKey();
                switch (ktkt.Key)
                {
                    case ConsoleKey.Tab:
                        Console.Clear();
                        chucnangthk();
                        break;
                    default:
                        pt.pnt1("Nhập sai xin nhập lại ", 10, 43);
                        goto label6;
                }
            }

        }
        public void vetrangluuban(int chisotrang)
        {
            for (int i = 19; i < 36; ++i)
            {
                pt.pnt1("       ", 23, i);
                pt.pnt1("                 ", 46, i);
                pt.pnt1("        ", 102, i);
            }
            int a = 19;
            int d1 = 0;
            int sodong = 9;
            List<TinhDiem> td = tdbll.LayDLTD();
            int d = (chisotrang - 1) * sodong + 1;
            for (int j = 0; j < td.Count; j++)
            {
                if (td[j].Diemtb < 4 && td[j].Hocky == "Ca nam")
                {
                    d1++;
                    if ((d1 >= d) && (d1 <= chisotrang * 9))
                    {
                        pt.pnt1(td[j].Mahs, 27, a);
                        pt.pnt1(hsbll.laytenhocsinh(td[j].Mahs), 48, a);
                        pt.pnt1(Convert.ToString(td[j].Diemtb), 79, a);
                        pt.pnt1(hsbll.laymalop(td[j].Mahs), 105, a);
                        a = a + 2;
                    }
                }
            }
        }
        public void duarafileluuban(List<TinhDiem> list)
        {
            StreamWriter sw = File.CreateText(@"ThongKeXepLoai\HSLuuBan.txt");
            for (int i = 0; i < list.Count; ++i)
            {
                if (list[i].Diemtb <4 && list[i].Hocky == "Ca nam")
                {
                    sw.WriteLine(list[i].Mahs + "#" + hsbll.laytenhocsinh(list[i].Mahs) + "#" + list[i].Diemtb + "#" + hsbll.laymalop(list[i].Mahs));
                }
            }
            sw.Close();
        }
        #endregion
        #region Đưa ra bảng tổng kết gửi cho phụ huynh học sinh
        public void thongbaoketquahoctap()
        {
            pt.pnt("┏", 4, 8);
            pt.pnt("┗", 4, 35);
            pt.pnt("┓", 95, 8);
            pt.pnt("┛", 95, 35);

            pt.pnt("━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━", 5, 8);
            pt.pnt("━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━", 5, 35);
            pt.pnt("                                TRƯỜNG ĐẠI HỌC SƯ PHẠM KỸ THUẬT HƯNG YÊN ", 0, 4);
            pt.pnt("                                      KHOA CÔNG NGHỆ THÔNG TIN ", 1, 5);
            pt.pnt("                                     ------- ○○○○ -------", 3, 6);
            for (int i = 9; i < 35; ++i)
            {
                pt.pnt("┃", 4, i);
                pt.pnt("┃", 95, i);
            }
            Console.ForegroundColor = ConsoleColor.Red;
            #region Chữ ký
            Console.ForegroundColor = ConsoleColor.Red;
            pt.pnt("D", 5, 34);
            Console.ForegroundColor = ConsoleColor.White;
            pt.pnt("e", 6, 34);
            Console.ForegroundColor = ConsoleColor.Cyan;
            pt.pnt("s", 7, 34);
            Console.ForegroundColor = ConsoleColor.Green;
            pt.pnt("i", 8, 34);
            Console.ForegroundColor = ConsoleColor.Yellow;
            pt.pnt("g", 9, 34);
            Console.ForegroundColor = ConsoleColor.Gray;
            pt.pnt("n", 10, 34);
            Console.ForegroundColor = ConsoleColor.Magenta;
            pt.pnt("e", 11, 34);
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            pt.pnt("d", 12, 34);
            Console.ForegroundColor = ConsoleColor.DarkRed;
            pt.pnt("b", 14, 34);
            Console.ForegroundColor = ConsoleColor.Yellow;
            pt.pnt("y", 15, 34);
            Console.ForegroundColor = ConsoleColor.Red;
            pt.pnt("T", 17, 34);
            Console.ForegroundColor = ConsoleColor.Yellow;
            pt.pnt("e", 18, 34);
            Console.ForegroundColor = ConsoleColor.Green;
            pt.pnt("a", 19, 34);
            Console.ForegroundColor = ConsoleColor.Red;
            pt.pnt("m", 20, 34);
            Console.ForegroundColor = ConsoleColor.Magenta;
            pt.pnt("T", 22, 34);
            Console.ForegroundColor = ConsoleColor.Yellow;
            pt.pnt("™", 23, 34);
            Console.ForegroundColor = ConsoleColor.White;
            #endregion
            Console.ForegroundColor = ConsoleColor.Green;
            pt.pnt(" CHƯƠNG TRÌNH QUẢN LÝ HỌC SINH", 34, 9);
            Console.ForegroundColor = ConsoleColor.White;
            //=============================================
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
            pt.pnt("┣", 19, 18);
            pt.pnt("┣", 19, 20);
            pt.pnt("┣", 19, 22);


            pt.pnt("┫", 79, 18);
            pt.pnt("┫", 79, 20);
            pt.pnt("┫", 79, 22);
            pt.pnt("━━━━━┳━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━", 20, 18);
            pt.pnt("━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━", 20, 20);
            pt.pnt("━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━", 20, 22);
            pt.pnt("━━━━━┻━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━", 20, 24);



            for (int i = 19; i <24; ++i)
            {
                pt.pnt("┃", 25, i);
            }
            Console.ForegroundColor = ConsoleColor.Red;
            pt.pnt("       CHỨC NĂNG THỐNG KÊ KẾT QUẢ HỌC TẬP    ", 25, 16);
            Console.ForegroundColor = ConsoleColor.Magenta;
            pt.pnt("F1", 22, 19);
            pt.pnt("F2", 22, 21);
            pt.pnt("F3", 22, 23);
            Console.ForegroundColor = ConsoleColor.White;
            pt.pnt("Thống kê kết quả học tập kỳ I", 32, 19);
            pt.pnt("Thống kê kết quả học tập kỳ II ", 32, 21);
            pt.pnt("Thống kê kết quả học cả năm học", 32, 23);
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
            den: ConsoleKeyInfo kt = Console.ReadKey();
            switch (kt.Key)
            {
                case ConsoleKey.F1:
                    Console.Clear();
                    ketquaky1();
                    break;
                case ConsoleKey.F2:
                    Console.Clear();
                    ketquaky2();
                    break;
                case ConsoleKey.F3:
                    Console.Clear();
                    ketquacanam();
                    break;
                case ConsoleKey.Tab:
                    Console.Clear();
                    chucnangthk();
                    break;
                case ConsoleKey.Escape:
                    Environment.Exit(0);
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    pt.pnt("       ", 85, 28);
                    pt.pnt("Bạn nhập sai xin nhập lại", 60, 32);
                    pt.pnt("", 85, 28);
                    Console.ForegroundColor = ConsoleColor.White;
                    goto den;
            }
        }
        #region Thông báo kết quả học tập kỳ I
        public void ketquaky1()
        {
            pt.pnt1("━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━", 4, 2);
            pt.pnt1("━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━", 4, 48);
            pt.pnt1("┏", 3, 2);
            pt.pnt1("┗", 3, 48);
            pt.pnt1("┓", 131, 2);
            pt.pnt1("┛", 131, 48);
            for (int i = 3; i < 48; i++)
            {
                pt.pnt1("┃", 3, i);
                pt.pnt1("┃", 131, i);
            }
            pt.pnt1("BÁO CÁO KẾT QUẢ HỌC TẬP KỲ I", 55, 4);
            pt.pnt1("Năm học 2014-2015", 60, 5);
            pt.pnt1("Trường tiểu học .......", 5, 4);
            pt.pnt1("Lớp :", 5, 6);
            pt.pnt1("━━━━━━━━━┳━━━━━━━━━━━━━━━━━━━┳━━━━━━━━━━━━━━━━━━━━┳━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┳━━━━━━━━━━━━━━━━━┳━━━━━━━━━━━━━━━━", 6, 7);
            pt.pnt1("━━━━━━━━━┻━━━━━━━━━━━━━━━━━━━┻━━━━━━━━━━━━━━━━━━━━┻━━━━━━━━━━━━━━━━━━┻━━━━━━━━━━━━━━━━━━┻━━━━━━━━━━━━━━━━━┻━━━━━━━━━━━━━━━━", 6, 40);
            pt.pnt1("┏", 5, 7);
            pt.pnt1("┗", 5, 40);
            pt.pnt1("┓", 128, 7);
            pt.pnt1("┛", 128, 40);
            for (int i = 8; i < 40; i++)
            {
                pt.pnt1("┃", 5, i);
                pt.pnt1("┃", 128, i);
            }
            pt.pnt1("━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━", 6, 12);
            pt.pnt1("┣", 5, 12);
            pt.pnt1("┫", 128, 12);

            pt.pnt1("━━━━━━━━━━━━━━━━━━━┳━━━━━━━━━━━━━━━━━━", 56, 9);
            for (int i = 8; i < 40; i++)
            {
                pt.pnt1("┃", 15, i);
                pt.pnt1("┃", 35, i);
                pt.pnt1("┃", 56, i);
                pt.pnt1("┃", 94, i);
                pt.pnt1("┃", 112, i);
            }
            for (int i = 10; i < 40; i++)
            {
                pt.pnt1("┃", 75, i);

            }

            pt.pnt1("Mã HS", 8, 9);
            pt.pnt1("Tên học sinh", 19, 9);
            pt.pnt1("Ngày sinh", 41, 9);
            pt.pnt1("Điểm học lực môn", 69, 8);
            pt.pnt1("Môn Toán", 62, 10);
            pt.pnt1("Môn Văn", 81, 10);
            pt.pnt1("Hạnh kiểm kỳ ", 98, 9);
            pt.pnt1("TBHK", 119, 9);

            pt.pnt1(".... ngày      tháng      năm  ", 95, 41);
            pt.pnt1("Giáo viên chủ nhiệm", 102, 42);

            pt.pnt1("Nhập mã lớp cần báo cáo :", 5, 42);
            malop:  maloptk = Console.ReadLine();
            if (maloptk == "")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                pt.pnt1("Mã lớp không được rỗng ! Nhấn phím bất kỳ nhập lại", 5, 45);
                pt.pnt1("Nhấn Tab để quay lại", 5, 46);
                Console.ForegroundColor = ConsoleColor.White;
                ConsoleKeyInfo kt = Console.ReadKey();
                switch (kt.Key)
                {
                    case ConsoleKey.Tab:
                        Console.Clear();
                        chucnangthk();
                        break;
                    default:
                        pt.pnt1("   ", 30, 42);
                        pt.pnt1("                                                     ", 5, 45);
                        pt.pnt1("                                 ", 5, 46);
                        pt.pnt1("", 30, 42);
                        goto malop;
                }
            }
            if (lopbll.KTmalop(maloptk) == false)
            {
                pt.pnt1(lopbll.laytenlop(maloptk), 11, 6);
                pt.pnt1(gvbll.laytengv(lopbll.laymagv(maloptk)), 104, 46);
                pt.pnt1("Nhấn S để lấy kết quả ra tệp", 5, 45);
                pt.pnt1("Nhấn Tab để lấy lớp mới ", 5, 46);
                List<HocSinh> hs = hsbll.LayDlhs();
                int slhs = 0;
                for (int i = 0; i < hs.Count; ++i)
                {
                    if (hs[i].Malop == maloptk)
                    {
                        slhs++;
                    }
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
                    vetrangketqua1(t);
                    pt.pnt1("", 112, 6); Console.WriteLine("{0}/{1} trang ◄ {2} ►", t, st, t);
                    goto label4;
                    label4:
                    pt.pnt1("", 29, 46);
                    ConsoleKeyInfo p;
                    p = Console.ReadKey();
                    switch (p.Key)
                    {
                        case ConsoleKey.LeftArrow:
                            if (t == 1)
                            {
                                t = 1;
                                goto label4;
                            }
                            else
                            {
                                t--;
                                goto label5;
                            }
                        case ConsoleKey.RightArrow:
                            if (t == st)
                            {
                                t = st;
                                goto label4;
                            }
                            else
                            {
                                t++;
                                goto label5;
                            }
                        case ConsoleKey.S:
                            duakqky1rafile(hs);
                            Console.Clear();
                            chucnangthk();
                            break;
                        case ConsoleKey.Tab:
                            for (int i = 14; i < 40; ++i)
                            {
                                pt.pnt1("       ", 8, i);
                                pt.pnt1("                  ", 17, i);
                                pt.pnt1("          ", 41, i);
                                pt.pnt1("       ", 102, i);
                                pt.pnt1("       ", 100, i);
                                pt.pnt1("       ", 64, i);
                                pt.pnt1("       ", 83, i);
                                pt.pnt1("       ", 120, i);
                            }
                            pt.pnt1("                              ", 5, 45);
                            pt.pnt1("                              ", 5, 47);
                            pt.pnt1("                              ", 5, 46);
                            pt.pnt1("      ", 11, 6);
                            pt.pnt1("                     ", 102, 46);
                            pt.pnt1("   ", 30, 42);
                            pt.pnt1("", 30, 42);
                            goto malop;
                        default:
                            Console.ForegroundColor = ConsoleColor.Red;
                            pt.pnt1("     ", 29, 46);
                            pt.pnt1(" Bạn nhập sai xin nhập lại ", 5, 47);
                            pt.pnt1("", 29, 46);
                            Console.ForegroundColor = ConsoleColor.White;
                            goto label4;
                    }

                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    pt.pnt1("Lớp không có học sinh", 5, 45);
                    Console.ForegroundColor = ConsoleColor.White;
                    ConsoleKeyInfo kt = Console.ReadKey();
                    switch (kt.Key)
                    {
                        default:
                            pt.pnt1("   ", 30, 42);
                            pt.pnt1("                                                     ", 5, 45);
                            pt.pnt1("", 30, 42);
                            goto malop;
                    }
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                pt.pnt1("Mã lớp không tồn tại trong hệ thống", 5, 45);
                Console.ForegroundColor = ConsoleColor.White;
                ConsoleKeyInfo kt = Console.ReadKey();
                switch (kt.Key)
                {
                    case ConsoleKey.Tab:
                        Console.Clear();
                        chucnangthk();
                        break;
                    default:
                        pt.pnt1("   ", 30, 42);
                        pt.pnt1("                                                     ", 5, 45);
                        pt.pnt1("", 30, 42);
                        goto malop;
                }
            }
        }
        public void vetrangketqua1(int chisotrang)
        {
            for (int i = 14; i < 40; ++i)
            {
                pt.pnt1("       ", 8, i);
                pt.pnt1("                  ", 17, i);
                pt.pnt1("          ", 41, i);
                pt.pnt1("       ", 102, i);
                pt.pnt1("       ", 100, i);
                pt.pnt1("       ", 64, i);
                pt.pnt1("       ", 83, i);
                pt.pnt1("       ", 120, i);
            }
            int a = 14;
            int d1 = 0;
            int sodong = 13;
            List<HocSinh> lisths = hsbll.LayDlhs();
            int d = (chisotrang - 1) * sodong + 1;
            for (int i = 0; i < lisths.Count; ++i)
            {
                d1++;
                if ((d1 >= d) && (d1 <= chisotrang * 13))
                {
                    if (lisths[i].Malop == maloptk)
                    {
                        pt.pnt1(lisths[i].Mahs, 8, a);
                        pt.pnt1(lisths[i].Tenhs, 17, a);
                        pt.pnt1(lisths[i].Ngaysinh, 41, a);
                        if (bdbll.layhanhkiem1(lisths[i].Mahs) != "")
                        {
                            pt.pnt1(bdbll.layhanhkiem1(lisths[i].Mahs), 102, a);
                        }
                        else
                        {
                            pt.pnt1("Chua co", 100, a);
                        }
                        pt.pnt1(Convert.ToString(bdbll.diemtkmontoan1(lisths[i].Mahs)), 64, a);
                        pt.pnt1(Convert.ToString(bdbll.diemtkmontv1(lisths[i].Mahs)), 83, a);
                        pt.pnt1(Convert.ToString((double)Math.Round(((bdbll.diemtkmontoan1(lisths[i].Mahs) + bdbll.diemtkmontv1(lisths[i].Mahs)) / 2), 2)), 120, a);
                        a = a + 2;
                   }
                }
            }
        }
        public void duakqky1rafile(List<HocSinh> hs)
        {
            StreamWriter sw = File.CreateText(@"ThongBaoVeNha\ketquaky1.txt");
            for(int i = 0; i < hs.Count; ++i)
            {
                sw.WriteLine(hs[i].Mahs + "#" + hs[i].Tenhs + "#" + hs[i].Ngaysinh + "#" + Convert.ToString(bdbll.diemtkmontoan1(hs[i].Mahs)) + "#" + Convert.ToString(bdbll.diemtkmontv1(hs[i].Mahs)) + "#" + bdbll.layhanhkiem1(hs[i].Mahs) + "#" + Convert.ToString((double)Math.Round(((bdbll.diemtkmontoan1(hs[i].Mahs) + bdbll.diemtkmontv1(hs[i].Mahs)) / 2), 2))+"#"+hs[i].Malop);
            }
            sw.Close();
        }
        #endregion

        #region Thông báo kết quả kỳ II
        public void ketquaky2()
        {
            pt.pnt1("━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━", 4, 2);
            pt.pnt1("━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━", 4, 48);
            pt.pnt1("┏", 3, 2);
            pt.pnt1("┗", 3, 48);
            pt.pnt1("┓", 131, 2);
            pt.pnt1("┛", 131, 48);
            for (int i = 3; i < 48; i++)
            {
                pt.pnt1("┃", 3, i);
                pt.pnt1("┃", 131, i);
            }
            pt.pnt1("BÁO CÁO KẾT QUẢ HỌC TẬP KỲ II", 55, 4);
            pt.pnt1("Năm học 2014-2015", 60, 5);
            pt.pnt1("Trường tiểu học .......", 5, 4);
            pt.pnt1("Lớp :", 5, 6);
            pt.pnt1("━━━━━━━━━┳━━━━━━━━━━━━━━━━━━━┳━━━━━━━━━━━━━━━━━━━━┳━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┳━━━━━━━━━━━━━━━━━┳━━━━━━━━━━━━━━━━", 6, 7);
            pt.pnt1("━━━━━━━━━┻━━━━━━━━━━━━━━━━━━━┻━━━━━━━━━━━━━━━━━━━━┻━━━━━━━━━━━━━━━━━━┻━━━━━━━━━━━━━━━━━━┻━━━━━━━━━━━━━━━━━┻━━━━━━━━━━━━━━━━", 6, 40);
            pt.pnt1("┏", 5, 7);
            pt.pnt1("┗", 5, 40);
            pt.pnt1("┓", 128, 7);
            pt.pnt1("┛", 128, 40);
            for (int i = 8; i < 40; i++)
            {
                pt.pnt1("┃", 5, i);
                pt.pnt1("┃", 128, i);
            }
            pt.pnt1("━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━", 6, 12);
            pt.pnt1("┣", 5, 12);
            pt.pnt1("┫", 128, 12);

            pt.pnt1("━━━━━━━━━━━━━━━━━━━┳━━━━━━━━━━━━━━━━━━", 56, 9);
            for (int i = 8; i < 40; i++)
            {
                pt.pnt1("┃", 15, i);
                pt.pnt1("┃", 35, i);
                pt.pnt1("┃", 56, i);
                pt.pnt1("┃", 94, i);
                pt.pnt1("┃", 112, i);
            }
            for (int i = 10; i < 40; i++)
            {
                pt.pnt1("┃", 75, i);

            }

            pt.pnt1("Mã HS", 8, 9);
            pt.pnt1("Tên học sinh", 19, 9);
            pt.pnt1("Ngày sinh", 41, 9);
            pt.pnt1("Điểm học lực môn", 69, 8);
            pt.pnt1("Môn Toán", 62, 10);
            pt.pnt1("Môn Văn", 81, 10);
            pt.pnt1("Hạnh kiểm kỳ ", 98, 9);
            pt.pnt1("TBHK", 119, 9);

            pt.pnt1(".... ngày      tháng      năm  ", 95, 41);
            pt.pnt1("Giáo viên chủ nhiệm", 102, 42);

            pt.pnt1("Nhập mã lớp cần báo cáo :", 5, 42);
            malop: maloptk = Console.ReadLine();
            if (maloptk == "")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                pt.pnt1("Mã lớp không được rỗng ! Nhấn phím bất kỳ nhập lại", 5, 45);
                pt.pnt1("Nhấn Tab để quay lại", 5, 46);
                Console.ForegroundColor = ConsoleColor.White;
                ConsoleKeyInfo kt = Console.ReadKey();
                switch (kt.Key)
                {
                    case ConsoleKey.Tab:
                        Console.Clear();
                        chucnangthk();
                        break;
                    default:
                        pt.pnt1("   ", 30, 42);
                        pt.pnt1("                                                     ", 5, 45);
                        pt.pnt1("                                 ", 5, 46);
                        pt.pnt1("", 30, 42);
                        goto malop;
                }
            }
            if (lopbll.KTmalop(maloptk) == false)
            {
                pt.pnt1(lopbll.laytenlop(maloptk), 11, 6);
                pt.pnt1(gvbll.laytengv(lopbll.laymagv(maloptk)), 104, 46);
                pt.pnt1("Nhấn S để lấy kết quả ra tệp", 5, 45);
                pt.pnt1("Nhấn Tab để lấy lớp mới ", 5, 46);
                List<HocSinh> hs = hsbll.LayDlhs();
                int slhs = 0;
                for (int i = 0; i < hs.Count; ++i)
                {
                    if (hs[i].Malop == maloptk)
                    {
                        slhs++;
                    }
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
                    vetrangketqua2(t);
                    pt.pnt1("", 112, 6); Console.WriteLine("{0}/{1} trang ◄ {2} ►", t, st, t);
                    goto label4;
                    label4:
                    pt.pnt1("", 29, 46);
                    ConsoleKeyInfo p;
                    p = Console.ReadKey();
                    switch (p.Key)
                    {
                        case ConsoleKey.LeftArrow:
                            if (t == 1)
                            {
                                t = 1;
                                goto label4;
                            }
                            else
                            {
                                t--;
                                goto label5;
                            }
                        case ConsoleKey.RightArrow:
                            if (t == st)
                            {
                                t = st;
                                goto label4;
                            }
                            else
                            {
                                t++;
                                goto label5;
                            }
                        case ConsoleKey.S:
                            duakqky2rafile(hs);
                            Console.Clear();
                            chucnangthk();
                            break;
                        case ConsoleKey.Tab:
                            for (int i = 14; i < 40; ++i)
                            {
                                pt.pnt1("       ", 8, i);
                                pt.pnt1("                  ", 17, i);
                                pt.pnt1("          ", 41, i);
                                pt.pnt1("       ", 102, i);
                                pt.pnt1("       ", 100, i);
                                pt.pnt1("       ", 64, i);
                                pt.pnt1("       ", 83, i);
                                pt.pnt1("       ", 120, i);
                            }
                            pt.pnt1("                              ", 5, 45);
                            pt.pnt1("                              ", 5, 47);
                            pt.pnt1("                              ", 5, 46);
                            pt.pnt1("      ", 11, 6);
                            pt.pnt1("                     ", 102, 46);
                            pt.pnt1("   ", 30, 42);
                            pt.pnt1("", 30, 42);
                            goto malop;
                        default:
                            Console.ForegroundColor = ConsoleColor.Red;
                            pt.pnt1("     ", 29, 46);
                            pt.pnt1(" Bạn nhập sai xin nhập lại ", 5, 47);
                            pt.pnt1("", 29, 46);
                            Console.ForegroundColor = ConsoleColor.White;
                            goto label4;
                    }

                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    pt.pnt1("Lớp không có học sinh", 5, 45);
                    Console.ForegroundColor = ConsoleColor.White;
                    ConsoleKeyInfo kt = Console.ReadKey();
                    switch (kt.Key)
                    {
                        default:
                            pt.pnt1("   ", 30, 42);
                            pt.pnt1("                                                     ", 5, 45);
                            pt.pnt1("", 30, 42);
                            goto malop;
                    }
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                pt.pnt1("Mã lớp không tồn tại trong hệ thống", 5, 45);
                Console.ForegroundColor = ConsoleColor.White;
                ConsoleKeyInfo kt = Console.ReadKey();
                switch (kt.Key)
                {
                    case ConsoleKey.Tab:
                        Console.Clear();
                        chucnangthk();
                        break;
                    default:
                        pt.pnt1("   ", 30, 42);
                        pt.pnt1("                                                     ", 5, 45);
                        pt.pnt1("", 30, 42);
                        goto malop;
                }
            }
        }
        public void vetrangketqua2(int chisotrang)
        {
            for (int i = 14; i < 40; ++i)
            {
                pt.pnt1("       ", 8, i);
                pt.pnt1("                  ", 17, i);
                pt.pnt1("          ", 41, i);
                pt.pnt1("       ", 102, i);
                pt.pnt1("       ", 100, i);
                pt.pnt1("       ", 64, i);
                pt.pnt1("       ", 83, i);
                pt.pnt1("       ", 120, i);
            }
            int a = 14;
            int d1 = 0;
            int sodong = 13;
            List<HocSinh> lisths = hsbll.LayDlhs();
            int d = (chisotrang - 1) * sodong + 1;
            for (int i = 0; i < lisths.Count; ++i)
            {
                d1++;
                if ((d1 >= d) && (d1 <= chisotrang * 13))
                {
                    if (lisths[i].Malop == maloptk)
                    {
                        pt.pnt1(lisths[i].Mahs, 8, a);
                        pt.pnt1(lisths[i].Tenhs, 17, a);
                        pt.pnt1(lisths[i].Ngaysinh, 41, a);
                        if (bdbll.layhanhkiem2(lisths[i].Mahs) != "")
                        {
                            pt.pnt1(bdbll.layhanhkiem2(lisths[i].Mahs), 102, a);
                        }
                        else
                        {
                            pt.pnt1("Chua co", 100, a);
                        }
                        pt.pnt1(Convert.ToString(bdbll.diemtkmontoan2(lisths[i].Mahs)), 64, a);
                        pt.pnt1(Convert.ToString(bdbll.diemtkmontv2(lisths[i].Mahs)), 83, a);
                        pt.pnt1(Convert.ToString((double)Math.Round(((bdbll.diemtkmontoan2(lisths[i].Mahs) + bdbll.diemtkmontv2(lisths[i].Mahs)) / 2), 2)), 120, a);
                        a = a + 2;
                    }
                }
            }
        }
        public void duakqky2rafile(List<HocSinh> hs)
        {
            StreamWriter sw = File.CreateText(@"ThongBaoVeNha\ketquaky2.txt");
            for (int i = 0; i < hs.Count; ++i)
            {
                sw.WriteLine(hs[i].Mahs + "#" + hs[i].Tenhs + "#" + hs[i].Ngaysinh + "#" + Convert.ToString(bdbll.diemtkmontoan2(hs[i].Mahs)) + "#" + Convert.ToString(bdbll.diemtkmontv2(hs[i].Mahs)) + "#" + bdbll.layhanhkiem2(hs[i].Mahs) + "#" + Convert.ToString((double)Math.Round(((bdbll.diemtkmontoan2(hs[i].Mahs) + bdbll.diemtkmontv2(hs[i].Mahs)) / 2), 2)) + "#" + hs[i].Malop);
            }
            sw.Close();
        }
        #endregion

        #region Thông báo kết quả cả năm học
        public void ketquacanam()
        {
            pt.pnt1("━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━", 4, 2);
            pt.pnt1("━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━", 4, 48);
            pt.pnt1("┏", 3, 2);
            pt.pnt1("┗", 3, 48);
            pt.pnt1("┓", 131, 2);
            pt.pnt1("┛", 131, 48);
            for (int i = 3; i < 48; i++)
            {
                pt.pnt1("┃", 3, i);
                pt.pnt1("┃", 131, i);
            }
            pt.pnt1("BÁO CÁO KẾT QUẢ HỌC TẬP CẢ NĂM HỌC", 53, 4);
            pt.pnt1("Năm học 2014-2015", 60, 5);
            pt.pnt1("Trường tiểu học .......", 5, 4);
            pt.pnt1("Lớp :", 5, 6);
            pt.pnt1("━━━━━━━━━┳━━━━━━━━━━━━━━━━━━━┳━━━━━━━━━━━━━━━━━━━━┳━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┳━━━━━━━━━━━━━━━━━┳━━━━━━━━━━━━━━━━", 6, 7);
            pt.pnt1("━━━━━━━━━┻━━━━━━━━━━━━━━━━━━━┻━━━━━━━━━━━━━━━━━━━━┻━━━━━━━━━━━━━━━━━━┻━━━━━━━━━━━━━━━━━━┻━━━━━━━━━━━━━━━━━┻━━━━━━━━━━━━━━━━", 6, 40);
            pt.pnt1("┏", 5, 7);
            pt.pnt1("┗", 5, 40);
            pt.pnt1("┓", 128, 7);
            pt.pnt1("┛", 128, 40);
            for (int i = 8; i < 40; i++)
            {
                pt.pnt1("┃", 5, i);
                pt.pnt1("┃", 128, i);
            }
            pt.pnt1("━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━", 6, 12);
            pt.pnt1("┣", 5, 12);
            pt.pnt1("┫", 128, 12);

            pt.pnt1("━━━━━━━━━━━━━━━━━━━┳━━━━━━━━━━━━━━━━━━", 56, 9);
            for (int i = 8; i < 40; i++)
            {
                pt.pnt1("┃", 15, i);
                pt.pnt1("┃", 35, i);
                pt.pnt1("┃", 56, i);
                pt.pnt1("┃", 94, i);
                pt.pnt1("┃", 112, i);
            }
            for (int i = 10; i < 40; i++)
            {
                pt.pnt1("┃", 75, i);

            }

            pt.pnt1("Mã HS", 8, 9);
            pt.pnt1("Tên học sinh", 19, 9);
            pt.pnt1("Ngày sinh", 41, 9);
            pt.pnt1("Điểm học lực môn", 69, 8);
            pt.pnt1("Môn Toán", 62, 10);
            pt.pnt1("Môn Văn", 81, 10);
            pt.pnt1("Hạnh kiểm kỳ ", 98, 9);
            pt.pnt1("TBCN", 119, 9);

            pt.pnt1(".... ngày      tháng      năm  ", 95, 41);
            pt.pnt1("Giáo viên chủ nhiệm", 102, 42);

            pt.pnt1("Nhập mã lớp cần báo cáo :", 5, 42);
            malop: maloptk = Console.ReadLine();
            if (maloptk == "")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                pt.pnt1("Mã lớp không được rỗng ! Nhấn phím bất kỳ nhập lại", 5, 45);
                pt.pnt1("Nhấn Tab để quay lại", 5, 46);
                Console.ForegroundColor = ConsoleColor.White;
                ConsoleKeyInfo kt = Console.ReadKey();
                switch (kt.Key)
                {
                    case ConsoleKey.Tab:
                        Console.Clear();
                        chucnangthk();
                        break;
                    default:
                        pt.pnt1("   ", 30, 42);
                        pt.pnt1("                                                     ", 5, 45);
                        pt.pnt1("                                 ", 5, 46);
                        pt.pnt1("", 30, 42);
                        goto malop;
                }
            }
            if (lopbll.KTmalop(maloptk) == false)
            {
                pt.pnt1(lopbll.laytenlop(maloptk), 11, 6);
                pt.pnt1(gvbll.laytengv(lopbll.laymagv(maloptk)), 104, 46);
                pt.pnt1("Nhấn S để lấy kết quả ra tệp", 5, 45);
                pt.pnt1("Nhấn Tab để lấy lớp mới ", 5, 46);
                List<HocSinh> hs = hsbll.LayDlhs();
                int slhs = 0;
                for (int i = 0; i < hs.Count; ++i)
                {
                    if (hs[i].Malop == maloptk)
                    {
                        slhs++;
                    }
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
                    vetrangketquacanam(t);
                    pt.pnt1("", 112, 6); Console.WriteLine("{0}/{1} trang ◄ {2} ►", t, st, t);
                    goto label4;
                    label4:
                    pt.pnt1("", 29, 46);
                    ConsoleKeyInfo p;
                    p = Console.ReadKey();
                    switch (p.Key)
                    {
                        case ConsoleKey.LeftArrow:
                            if (t == 1)
                            {
                                t = 1;
                                goto label4;
                            }
                            else
                            {
                                t--;
                                goto label5;
                            }
                        case ConsoleKey.RightArrow:
                            if (t == st)
                            {
                                t = st;
                                goto label4;
                            }
                            else
                            {
                                t++;
                                goto label5;
                            }
                        case ConsoleKey.S:
                            duakqcanamrafile(hs);
                            Console.Clear();
                            chucnangthk();
                            break;
                        case ConsoleKey.Tab:
                            for (int i = 14; i < 40; ++i)
                            {
                                pt.pnt1("       ", 8, i);
                                pt.pnt1("                  ", 17, i);
                                pt.pnt1("          ", 41, i);
                                pt.pnt1("       ", 102, i);
                                pt.pnt1("       ", 100, i);
                                pt.pnt1("       ", 64, i);
                                pt.pnt1("       ", 83, i);
                                pt.pnt1("       ", 120, i);
                            }
                            pt.pnt1("                              ", 5, 45);
                            pt.pnt1("                              ", 5, 47);
                            pt.pnt1("                              ", 5, 46);
                            pt.pnt1("      ", 11, 6);
                            pt.pnt1("                     ", 102, 46);
                            pt.pnt1("   ", 30, 42);
                            pt.pnt1("", 30, 42);
                            goto malop;
                        default:
                            Console.ForegroundColor = ConsoleColor.Red;
                            pt.pnt1("     ", 29, 46);
                            pt.pnt1(" Bạn nhập sai xin nhập lại ", 5, 47);
                            pt.pnt1("", 29, 46);
                            Console.ForegroundColor = ConsoleColor.White;
                            goto label4;
                    }

                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    pt.pnt1("Lớp không có học sinh", 5, 45);
                    Console.ForegroundColor = ConsoleColor.White;
                    ConsoleKeyInfo kt = Console.ReadKey();
                    switch (kt.Key)
                    {
                        default:
                            pt.pnt1("   ", 30, 42);
                            pt.pnt1("                                                     ", 5, 45);
                            pt.pnt1("", 30, 42);
                            goto malop;
                    }
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                pt.pnt1("Mã lớp không tồn tại trong hệ thống", 5, 45);
                Console.ForegroundColor = ConsoleColor.White;
                ConsoleKeyInfo kt = Console.ReadKey();
                switch (kt.Key)
                {
                    case ConsoleKey.Tab:
                        Console.Clear();
                        chucnangthk();
                        break;
                    default:
                        pt.pnt1("   ", 30, 42);
                        pt.pnt1("                                                     ", 5, 45);
                        pt.pnt1("", 30, 42);
                        goto malop;
                }
            }
        }
        public void vetrangketquacanam(int chisotrang)
        {
            for (int i = 14; i < 40; ++i)
            {
                pt.pnt1("       ", 8, i);
                pt.pnt1("                  ", 17, i);
                pt.pnt1("          ", 41, i);
                pt.pnt1("       ", 102, i);
                pt.pnt1("       ", 100, i);
                pt.pnt1("       ", 64, i);
                pt.pnt1("       ", 83, i);
                pt.pnt1("       ", 120, i);
            }
            double tb = 0;
            int a = 14;
            int d1 = 0;
            int sodong = 13;
            List<HocSinh> lisths = hsbll.LayDlhs();
            int d = (chisotrang - 1) * sodong + 1;
            for (int i = 0; i < lisths.Count; ++i)
            {
                d1++;
                if ((d1 >= d) && (d1 <= chisotrang * 13))
                {
                    if (lisths[i].Malop == maloptk)
                    {
                        pt.pnt1(lisths[i].Mahs, 8, a);
                        pt.pnt1(lisths[i].Tenhs, 17, a);
                        pt.pnt1(lisths[i].Ngaysinh, 41, a);
                        if (bdbll.layhanhkiem2(lisths[i].Mahs) != "")
                        {
                            pt.pnt1(bdbll.layhanhkiem2(lisths[i].Mahs), 102, a);
                        }
                        else
                        {
                            pt.pnt1("Chua co", 100, a);
                        }
                        tb = ((double)Math.Round((bdbll.diemtkmontoan2(lisths[i].Mahs) + bdbll.diemtkmontoan1(lisths[i].Mahs)) / 2,2) + ((double)Math.Round((bdbll.diemtkmontv1(lisths[i].Mahs) + bdbll.diemtkmontv2(lisths[i].Mahs)) / 2,2)));
                        pt.pnt1(Convert.ToString((double)Math.Round((bdbll.diemtkmontoan2(lisths[i].Mahs)+bdbll.diemtkmontoan1(lisths[i].Mahs))/2,2)), 64, a);
                        pt.pnt1(Convert.ToString((double)Math.Round((bdbll.diemtkmontv1(lisths[i].Mahs) + bdbll.diemtkmontv2(lisths[i].Mahs))/2, 2)), 83, a);
                        pt.pnt1(Convert.ToString((double)Math.Round(tb/2,2)), 120, a);
                        a = a + 2;
                    }
                }
            }
        }
        public void duakqcanamrafile(List<HocSinh> hs)
        {
            StreamWriter sw = File.CreateText(@"ThongBaoVeNha\ketquacanam.txt");
            for (int i = 0; i < hs.Count; ++i)
            {
                sw.WriteLine(hs[i].Mahs + "#" + hs[i].Tenhs + "#" + hs[i].Ngaysinh + "#" + Convert.ToString((double)Math.Round((bdbll.diemtkmontoan2(hs[i].Mahs) + bdbll.diemtkmontoan1(hs[i].Mahs)) / 2, 2)) + "#" + Convert.ToString((double)Math.Round(((double)Math.Round((bdbll.diemtkmontoan2(hs[i].Mahs) + bdbll.diemtkmontoan1(hs[i].Mahs)) / 2, 2) + ((double)Math.Round((bdbll.diemtkmontv1(hs[i].Mahs) + bdbll.diemtkmontv2(hs[i].Mahs)) / 2, 2))) / 2,2)) + "#" + bdbll.layhanhkiem2(hs[i].Mahs) + "#" + Convert.ToString((double)Math.Round(((bdbll.diemtkmontoan2(hs[i].Mahs) + bdbll.diemtkmontv2(hs[i].Mahs)) / 2), 2)) + "#" + hs[i].Malop);
            }
            sw.Close();
        }
        #endregion

        #endregion
    }
    #endregion
}