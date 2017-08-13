using System;
using System.Linq;
using System.Text;
using QLHS.Utility;
using QLHS.Presenations;
using QLHS.Business.Components;
namespace QLHS.Presenations
{
    public class ThongTinPM
    {
        #region Thông tin trợ giúp
        Paint pt = new Paint(140, 55);
        public static  FormHS fhs = new FormHS();
        public static FormLop fl = new FormLop();
        public static FormGVCN fgv = new FormGVCN();
        public static MenuChinh mn = new MenuChinh();
        #region Thông tin về phần mềm
        public void thongtinpm()
        {
            pt.pnt("┏", 4, 8);
            pt.pnt("┗", 4, 52);
            pt.pnt("┓", 95, 8);
            pt.pnt("┛", 95, 52);

            pt.pnt("━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━", 5, 8);
            pt.pnt("━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━", 5, 52);
            pt.pnt("                                TRƯỜNG ĐẠI HỌC SƯ PHẠM KỸ THUẬT HƯNG YÊN ", 0, 1);
            pt.pnt("                                      KHOA CÔNG NGHỆ THÔNG TIN ", 1, 2);
            pt.pnt("                                     ------- ○○○○ -------", 3, 3);
            for (int i = 9; i < 52; ++i)
            {
                pt.pnt("┃", 4, i);
                pt.pnt("┃", 95, i);
            }
            pt.pnt("              ┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┓", 12,10);
            pt.pnt("              ┃        Thông Tin Phần Mềm Quản Lý Học Sinh     ┃", 12, 11);
            pt.pnt("              ┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┛", 12, 12);
            Console.ForegroundColor = ConsoleColor.Green;
            pt.pnt(" GIỚI THIỆU : ", 10, 14);
            pt.pnt("━━━━━━━━━━━━", 10, 15);
            Console.ForegroundColor=ConsoleColor.White;
            pt.pnt(" Đây là phần mềm phục vụ cho công tác quản lý học sinh cấp tiếu học.", 12, 16);
            pt.pnt(" Hiện nay nhiều nhà trường còn quản lý học sinh bằng giấy tờ, sổ sách", 12, 17);
            pt.pnt(" cách làm này vừa thiếu chính xác vừa lãng phí thời gian và công sức ", 12, 18);
            pt.pnt(" của giáo viên. Vì vậy nhóm đề tài của chúng em đã xây dựng ý tưởng tạo",12,19);
            pt.pnt(" nên phần mềm quản lý học sinh,nhằm đáp ứng hai yêu cầu : ",12,20);
            pt.pnt(" - Đơn giản,dễ sử dụng . Phần mềm cho phép giáo viên có khả năng tin", 13, 21);
            pt.pnt("   học ở mức soạn thảo văn bản cũng có thể sử dụng được. ",13,22);
            pt.pnt(" - Hiệu quả. Phần mềm giải quyết được một cách đầy đủ các yêu cầu thiết yếu", 13, 23);
            pt.pnt("   trong công tác quản lý của nhà trường ",13,24);
            Console.ForegroundColor = ConsoleColor.Green;
            pt.pnt(" CÁC CHỨC NĂNG CHÍNH : ",10,26);
            pt.pnt("━━━━━━━━━━━━━━━━━━━━━", 10, 27);
            Console.ForegroundColor = ConsoleColor.White;
            pt.pnt("-Quản lý học sinh ", 17, 28);
            pt.pnt(" Quản lý sơ yếu lý lịch của học sinh ", 12, 29);
            pt.pnt(" Công cụ tìm kiếm học sinh theo mã,tên,địa chỉ.. ", 12, 30);
            pt.pnt("-Quản lý giáo viên chủ nhiệm ",17,31);
            pt.pnt(" Quản lý thông tin cơ bản về giáo viên chủ nhiệm của mỗi lớp",12,32);
            pt.pnt(" Công cụ tìm kiếm giáo viên chủ nhiệm theo mã,tên", 12, 33);
            pt.pnt("-Quản lý điểm", 17, 34);
            pt.pnt(" Tự động tính điểm trung bình môn,xếp loại môn", 12, 35);
            pt.pnt(" In ra bảng điểm của từng học sinh ", 12, 36);
            pt.pnt(" -Thống kê",17,37);
            pt.pnt(" Thống kê danh sách học sinh giỏi,khá ",12,38);
            pt.pnt(" Thống kê danh sách học sinh lưu ban ", 12, 39);
            pt.pnt(" Thống kê hạnh kiểm ",12,40);
            Console.ForegroundColor = ConsoleColor.Green;
            pt.pnt(" NHÓM PHÁT TRIỂN : ",10,42);
            pt.pnt("━━━━━━━━━━━━━━━━━", 10, 43);
            Console.ForegroundColor = ConsoleColor.White;
            pt.pnt("  1. Bùi Đức Tuân     (Email: buiductuan811@gmail.com)",12,44);
            pt.pnt("  2. Đinh Công Trường (Email: dctruong2101@gmail.com) ", 12, 45);
            pt.pnt("  Dưới sự hướng dẫn của ThS. Trần Đỗ Thu Hà",12,46);
            Console.ForegroundColor = ConsoleColor.Red;
            pt.pnt("Designed by TeamT ™ ", 5, 51);
            Console.ForegroundColor = ConsoleColor.Green;
            pt.pnt(" CHƯƠNG TRÌNH QUẢN LÝ HỌC SINH", 34, 7);
            Console.ForegroundColor = ConsoleColor.White;
            pt.pnt("Nhấn",61,48);
            Console.ForegroundColor = ConsoleColor.Green;
            pt.pnt("Tab", 66, 48);
            Console.ForegroundColor = ConsoleColor.White;
            pt.pnt("để quay lại", 70, 48);
            pt.pnt("Nhấn",61,49);
            Console.ForegroundColor = ConsoleColor.Green;
            pt.pnt("ESC", 66, 49);
            Console.ForegroundColor = ConsoleColor.White;
            pt.pnt("để thoát", 70, 49);
            pt.pnt("Bạn chọn phím : ",61,50);
            label1: ConsoleKeyInfo kt = Console.ReadKey();
            Console.ForegroundColor = ConsoleColor.White;
            switch (kt.Key)
            {
                case ConsoleKey.Tab:
                    Console.Clear();
                    mn.MenuChinh1();
                    break;
                case ConsoleKey.Escape:
                    Environment.Exit(0);break;
                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    pt.pnt("     ", 77, 50);
                    pt.pnt("Bạn nhập sai xin nhập lại",61,51);
                    pt.pnt("", 78, 50);
                    goto label1;
            }
        }
        #endregion
        #region danh mục tài liệu tham khảo
        public void tailieutk()
        {
            pt.pnt("┏", 4, 8);
            pt.pnt("┗", 4, 28);
            pt.pnt("┓", 95, 8);
            pt.pnt("┛", 95, 28);

            pt.pnt("━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━", 5, 8);
            pt.pnt("━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━", 5, 28);
            pt.pnt("                                TRƯỜNG ĐẠI HỌC SƯ PHẠM KỸ THUẬT HƯNG YÊN ", 0, 1);
            pt.pnt("                                      KHOA CÔNG NGHỆ THÔNG TIN ", 1, 2);
            pt.pnt("                                     ------- ○○○○ -------", 3, 3);
            for (int i = 9; i < 28; ++i)
            {
                pt.pnt("┃", 4, i);
                pt.pnt("┃", 95, i);
            }
            pt.pnt("              ┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┓", 12, 10);
            pt.pnt("              ┃                 Tài liệu tham khảo             ┃", 12, 11);
            pt.pnt("              ┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┛", 12, 12);
            Console.ForegroundColor = ConsoleColor.Green;
            pt.pnt(" TÀI LIỆU : ", 10, 14);
            pt.pnt("━━━━━━━━━━━━", 10, 15);
            Console.ForegroundColor = ConsoleColor.White;
            pt.pnt(" -Các ví dụ mẫu của Thầy : Nguyễn Hữu Đông ", 12, 16);
            pt.pnt("  về tổ chức dữ liệu theo mô hình 3 lớp",12,17);
            Console.ForegroundColor = ConsoleColor.Green;
            pt.pnt(" PHẦN MỀM : ", 10, 19);
            pt.pnt("━━━━━━━━━━━━", 10, 20);
            Console.ForegroundColor = ConsoleColor.White;
            pt.pnt(" Tham khảo một số phần mềm đồ án 1 của những khóa trước ", 12, 21);
            Console.ForegroundColor = ConsoleColor.Red;
            pt.pnt("Designed by TeamT ™ ", 5, 27);
            Console.ForegroundColor = ConsoleColor.Green;
            pt.pnt(" CHƯƠNG TRÌNH QUẢN LÝ HỌC SINH", 34, 7);
            Console.ForegroundColor = ConsoleColor.White;
            pt.pnt("Nhấn", 61, 24);
            Console.ForegroundColor = ConsoleColor.Green;
            pt.pnt("Tab", 66, 24);
            Console.ForegroundColor = ConsoleColor.White;
            pt.pnt("để quay lại", 70, 24);
            pt.pnt("Nhấn", 61, 25);
            Console.ForegroundColor = ConsoleColor.Green;
            pt.pnt("ESC", 66, 25);
            Console.ForegroundColor = ConsoleColor.White;
            pt.pnt("để thoát", 70, 25);
            pt.pnt("Bạn chọn phím : ", 61, 26);
        label1: ConsoleKeyInfo kt = Console.ReadKey();
            Console.ForegroundColor = ConsoleColor.White;
            switch (kt.Key)
            {
                case ConsoleKey.Tab:
                    Console.Clear();
                    mn.MenuChinh1();
                    break;
                case ConsoleKey.Escape:
                    Environment.Exit(0);break;
                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    pt.pnt("   ", 77, 26);
                    pt.pnt("Bạn nhập sai xin nhập lại", 61, 27);
                    pt.pnt("", 77, 26);
                    goto label1;
            }

        }
        #endregion
        #region hướng dẫn sử dụng 
        public void huongdansd()
        {
            pt.pnt("┏", 4, 8);
            pt.pnt("┗", 4, 31);
            pt.pnt("┓", 95, 8);
            pt.pnt("┛", 95, 31);

            pt.pnt("━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━", 5, 8);
            pt.pnt("━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━", 5, 31);
            pt.pnt("                                TRƯỜNG ĐẠI HỌC SƯ PHẠM KỸ THUẬT HƯNG YÊN ", 0, 1);
            pt.pnt("                                      KHOA CÔNG NGHỆ THÔNG TIN ", 1, 2);
            pt.pnt("                                     ------- ○○○○ -------", 3, 3);
            for (int i = 9; i < 31; ++i)
            {
                pt.pnt("┃", 4, i);
                pt.pnt("┃", 95, i);
            }
            pt.pnt("              ┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┓", 12, 10);
            pt.pnt("              ┃            Hướng dẫn sử dụng phần mềm          ┃", 12, 11);
            pt.pnt("              ┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┛", 12, 12);

            Console.ForegroundColor = ConsoleColor.Green;
            pt.pnt(" HƯỚNG DẪN:", 10, 14);
            pt.pnt("━━━━━━━━━━━━", 10, 15);
            Console.ForegroundColor = ConsoleColor.Red;
            pt.pnt("Designed by TeamT ™ ", 5, 30);
            Console.ForegroundColor = ConsoleColor.White;
            pt.pnt("+ Phần mềm quản lý học sinh thao tác với dữ liệu trên file *txt", 10,16);
            pt.pnt(" để sử dụng phần mềm đầu tiên cần phải tạo các dữ liệu trên file *txt", 12, 17);
            pt.pnt(" khi đã tạo ra các file dữ liệu thì phải lưu vào đường dẫn có dạng sau : ", 12, 18);
            pt.pnt(@"    - Nơi chứa Project\Projects\QLHS\bin\Debug",13,19);
            pt.pnt(" Ví dụ : Nơi chứa Project trong ổ D thì đường dẫn như sau  ", 12, 21);
            pt.pnt(@"    - D:\Projects\QLHS\bin\Debug", 13, 22);
            pt.pnt("+ Khi có đầy đủ các dữ liệu ban đầu thì có thể sử dụng các chức năng của phần mềm", 10, 23);
            Console.ForegroundColor = ConsoleColor.Green;
            pt.pnt(" CHƯƠNG TRÌNH QUẢN LÝ HỌC SINH", 34, 7);
            Console.ForegroundColor = ConsoleColor.White;
            pt.pnt("Nhấn", 61, 27);
            Console.ForegroundColor = ConsoleColor.Green;
            pt.pnt("Tab", 66, 27);
            Console.ForegroundColor = ConsoleColor.White;
            pt.pnt("để quay lại", 70, 27);
            pt.pnt("Nhấn", 61, 28);
            Console.ForegroundColor = ConsoleColor.Green;
            pt.pnt("ESC", 66, 28);
            Console.ForegroundColor = ConsoleColor.White;
            pt.pnt("để thoát", 70, 28);
            pt.pnt("Bạn chọn phím : ", 61, 29);
        label1: ConsoleKeyInfo kt = Console.ReadKey();
            Console.ForegroundColor = ConsoleColor.White;
            switch (kt.Key)
            {
                case ConsoleKey.Tab:
                    Console.Clear();
                    mn.MenuChinh1();
                    break;
                case ConsoleKey.Escape:
                    Environment.Exit(0);break;
                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    pt.pnt("     ", 77, 29);
                    pt.pnt("Bạn nhập sai xin nhập lại", 61, 30);
                    pt.pnt("", 77, 29);
                    goto label1;
            }


        }
        #endregion
        #region danh sách mã lớp hợp lệ
        public void dsmalop()
        {
            pt.pnt("┏", 4, 8);
            pt.pnt("┗", 4, 31);
            pt.pnt("┓", 95, 8);
            pt.pnt("┛", 95, 31);
            Console.ForegroundColor = ConsoleColor.Magenta;
            pt.pnt1("CỬA SỔ TRỢ GIÚP (Help)", 6, 7);
            Console.ForegroundColor = ConsoleColor.White;
            pt.pnt1("━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━", 5, 8);
            pt.pnt1("━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━", 5, 31);
            pt.pnt1("                                TRƯỜNG ĐẠI HỌC SƯ PHẠM KỸ THUẬT HƯNG YÊN ", 0, 1);
            pt.pnt1("                                      KHOA CÔNG NGHỆ THÔNG TIN ", 1, 2);
            pt.pnt1("                                     ------- ○○○○ -------", 3, 3);
            for (int i = 9; i < 31; ++i)
            {
                pt.pnt1("┃", 4, i);
                pt.pnt1("┃", 95, i);
            }
            pt.pnt("              ┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┓", 12, 10);
            pt.pnt("              ┃           Danh sách các mã lớp hợp lệ          ┃", 12, 11);
            pt.pnt("              ┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┛", 12, 12);

            Console.ForegroundColor = ConsoleColor.Green;
            pt.pnt1(" MÃ LỚP ", 10, 14);
            pt.pnt1("━━━━━━━", 10,15);
            Console.ForegroundColor = ConsoleColor.White;
            pt.pnt1("- L1 : lớp 1A", 12, 16);
            pt.pnt1("- L2 : lớp 1B", 12, 17);
            pt.pnt1("- L3 : lớp 2A", 12, 18);
            pt.pnt1("- L4 : lớp 2B", 12, 19);
            pt.pnt1("- L5 : lớp 3A", 12, 20);
            pt.pnt1("- L6 : lớp 3B", 12, 21);
            pt.pnt1("- L7 : lớp 4A", 12, 22);
            pt.pnt1("- L8 : lớp 4B", 12, 23);
            pt.pnt1("- L9 : lớp 5A", 12, 24);
            pt.pnt1("- L10: lớp 5B", 12, 25);
            pt.pnt1(" Nhấn H để quay lại trung tâm trợ giúp ", 55, 26);
            pt.pnt1(" Nhấn B để quay lại sửa lớp ", 55, 27);
            pt.pnt1(" Nhấn Tab để quay lại thêm lớp ",55,28);
        label:
            ConsoleKeyInfo kt = Console.ReadKey();
            Console.ForegroundColor = ConsoleColor.White;
            switch (kt.Key)
            {
                case ConsoleKey.H:
                    Console.Clear();
                    trungtamtrogiup();
                    break;
                case ConsoleKey.Tab:
                    Console.Clear();
                    fhs.themhs();
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    pt.pnt1(" Nhập sai xin nhập lại ",55,29);
                    goto label;
            }
        }
        #endregion
        #region định dạng hợp lệ của tên lớp
        public void dinhdangtl()
        {
            pt.pnt("┏", 4, 8);
            pt.pnt("┗", 4, 31);
            pt.pnt("┓", 95, 8);
            pt.pnt("┛", 95, 31);
            Console.ForegroundColor = ConsoleColor.Magenta;
            pt.pnt1("CỬA SỔ TRỢ GIÚP (Help)", 6, 7);
            Console.ForegroundColor = ConsoleColor.White;
            pt.pnt1("━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━", 5, 8);
            pt.pnt1("━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━", 5, 31);
            pt.pnt("                                TRƯỜNG ĐẠI HỌC SƯ PHẠM KỸ THUẬT HƯNG YÊN ", 0, 1);
            pt.pnt("                                      KHOA CÔNG NGHỆ THÔNG TIN ", 1, 2);
            pt.pnt("                                     ------- ○○○○ -------", 3, 3);
            for (int i = 9; i < 31; ++i)
            {
                pt.pnt1("┃", 4, i);
                pt.pnt1("┃", 95, i);
            }
            pt.pnt("              ┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┓", 12, 10);
            pt.pnt("              ┃           Định dạng hợp lệ của tên lớp         ┃", 12, 11);
            pt.pnt("              ┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┛", 12, 12);

            Console.ForegroundColor = ConsoleColor.Green;
            pt.pnt(" ĐỊNH DẠNG TÊN LỚP ", 10, 14);
            pt.pnt("━━━━━━━━━━━━━━━━━━━", 10, 15);
            Console.ForegroundColor = ConsoleColor.White;
            pt.pnt("- Theo quy định của nhà trường tên của lớp sẽ có định dạng như sau : ", 12, 16);
            pt.pnt("- tên lớp : MN ", 13, 17);
            pt.pnt(" - Trong đó :    + M là số từ 1 đến 5", 13, 18);
            pt.pnt("                 + N là chữ cái từ A đến Z",13,19);
            Console.ForegroundColor = ConsoleColor.Magenta;
            pt.pnt("Nhấn B để quay lại cửa sổ trợ giúp", 55, 27);
            Console.ForegroundColor = ConsoleColor.White;
            pt.pnt("Nhấn Tab để quay lại mục thêm lớp ", 55, 28);
        label:
            ConsoleKeyInfo kt = Console.ReadKey();
            Console.ForegroundColor = ConsoleColor.White;
            switch (kt.Key)
            {
                case ConsoleKey.B:
                    Console.Clear();
                    trungtamtrogiup();
                    break;
                case ConsoleKey.Tab:
                    Console.Clear();
                    fl.Themlop();
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    pt.pnt(" Nhập sai xin nhập Tab để quay lại ", 65, 29);
                    goto label;
            }
        }
        #endregion
        #region định dạng hợp lệ của mã giáo viên 
        public void dinhdangmgv()
        {
            pt.pnt("┏", 4, 8);
            pt.pnt("┗", 4, 31);
            pt.pnt("┓", 95, 8);
            pt.pnt("┛", 95, 31);
            Console.ForegroundColor = ConsoleColor.Magenta;
            pt.pnt1("CỬA SỔ TRỢ GIÚP (Help)", 6, 7);
            Console.ForegroundColor = ConsoleColor.White;
            pt.pnt1("━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━", 5, 8);
            pt.pnt1("━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━", 5, 31);
            pt.pnt("                                TRƯỜNG ĐẠI HỌC SƯ PHẠM KỸ THUẬT HƯNG YÊN ", 0, 1);
            pt.pnt("                                      KHOA CÔNG NGHỆ THÔNG TIN ", 1, 2);
            pt.pnt("                                     ------- ○○○○ -------", 3, 3);
            for (int i = 9; i < 31; ++i)
            {
                pt.pnt1("┃", 4, i);
                pt.pnt1("┃", 95, i);
            }
            pt.pnt("              ┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┓", 12, 10);
            pt.pnt("              ┃         Định dạng hợp lệ của mã giáo viên      ┃", 12, 11);
            pt.pnt("              ┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┛", 12, 12);


            Console.ForegroundColor = ConsoleColor.Green;
            pt.pnt(" ĐỊNH DẠNG MÃ GIÁO VIÊN ", 10, 14);
            pt.pnt("━━━━━━━━━━━━━━━━━━━━━━━━", 10, 15);
            Console.ForegroundColor = ConsoleColor.White;
            pt.pnt("- Theo quy định của nhà trường mã của giáo viên sẽ có định dạng như sau : ", 12, 18);
            pt.pnt("- mã giáo viên : GVi ", 13, 19);
            pt.pnt(" - Trong đó :    + i là số lớn hơn hoặc bằng 1", 13, 20);
            Console.ForegroundColor = ConsoleColor.Magenta;
            pt.pnt("Nhấn B để quay lại cửa sổ trợ giúp", 55, 27);
            Console.ForegroundColor = ConsoleColor.White;
            pt.pnt(" Nhấn Tab để quay lại mục thêm lớp ", 55, 28);
            pt.pnt(" Nhấn G để quay lại mục thêm GVCN ", 55, 29);
        label:
            ConsoleKeyInfo kt = Console.ReadKey();
            Console.ForegroundColor = ConsoleColor.White;
            switch (kt.Key)
            {
                case ConsoleKey.B:
                    Console.Clear();
                    trungtamtrogiup();
                    break;
                case ConsoleKey.G:
                    Console.Clear();
                    fgv.themgv();
                    break;
                case ConsoleKey.Tab:
                    Console.Clear();
                    fl.Themlop();
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    pt.pnt(" Nhập sai xin nhập Tab để quay lại ", 65, 29);
                    goto label;
            }
        }
        #endregion
        #region định dạng hợp lệ của mã lớp
        public void dinhdangml()
        {
            pt.pnt("┏", 4, 8);
            pt.pnt("┗", 4, 31);
            pt.pnt("┓", 95, 8);
            pt.pnt("┛", 95, 31);
            Console.ForegroundColor = ConsoleColor.Magenta;
            pt.pnt1("CỬA SỔ TRỢ GIÚP (Help)", 6, 7);
            Console.ForegroundColor = ConsoleColor.White;
            pt.pnt1("━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━", 5, 8);
            pt.pnt1("━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━", 5, 31);
            pt.pnt("                                TRƯỜNG ĐẠI HỌC SƯ PHẠM KỸ THUẬT HƯNG YÊN ", 0, 1);
            pt.pnt("                                      KHOA CÔNG NGHỆ THÔNG TIN ", 1, 2);
            pt.pnt("                                     ------- ○○○○ -------", 3, 3);
            for (int i = 9; i < 31; ++i)
            {
                pt.pnt1("┃", 4, i);
                pt.pnt1("┃", 95, i);
            }
            pt.pnt("              ┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┓", 12, 10);
            pt.pnt("              ┃            Định dạng hợp lệ của mã lớp         ┃", 12, 11);
            pt.pnt("              ┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┛", 12, 12);


            Console.ForegroundColor = ConsoleColor.Green;
            pt.pnt(" ĐỊNH DẠNG MÃ LỚP ", 10, 14);
            pt.pnt("━━━━━━━━━━━━━━━━━━", 10, 15);
            Console.ForegroundColor = ConsoleColor.White;
            pt.pnt("- Theo quy định của nhà trường mã của lớp sẽ có định dạng như sau : ", 12, 18);
            pt.pnt("- mã lớp : Li ", 13, 19);
            pt.pnt(" - Trong đó :    + i là số lớn hơn hoặc bằng 1", 13, 20);
            Console.ForegroundColor = ConsoleColor.Magenta;
            pt.pnt("Nhấn B để quay lại cửa sổ trợ giúp",55,27);
            Console.ForegroundColor = ConsoleColor.White;
            pt.pnt(" Nhấn Tab để quay lại mục thêm lớp ", 55, 28);
        label:
            ConsoleKeyInfo kt = Console.ReadKey();
            Console.ForegroundColor = ConsoleColor.White;
            switch (kt.Key)
            {
                case ConsoleKey.B:
                    Console.Clear();
                    trungtamtrogiup();
                    break;
                case ConsoleKey.Tab:
                    Console.Clear();
                    fl.Themlop();
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    pt.pnt(" Nhập sai xin nhập Tab để quay lại ", 65, 29);
                    goto label;
            }
        }
        #endregion
        #region định dạng của năm học
        public void dinhdangnamhoc()
        {
            pt.pnt("┏", 4, 8);
            pt.pnt("┗", 4, 24);
            pt.pnt("┓", 95, 8);
            pt.pnt("┛", 95, 24);
            Console.ForegroundColor = ConsoleColor.Magenta;
            pt.pnt1("CỬA SỔ TRỢ GIÚP (Help)", 6, 7);
            Console.ForegroundColor = ConsoleColor.White;
            pt.pnt1("━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━", 5, 8);
            pt.pnt1("━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━", 5, 24);
            pt.pnt("                                TRƯỜNG ĐẠI HỌC SƯ PHẠM KỸ THUẬT HƯNG YÊN ", 0, 1);
            pt.pnt("                                      KHOA CÔNG NGHỆ THÔNG TIN ", 1, 2);
            pt.pnt("                                     ------- ○○○○ -------", 3, 3);
            for (int i = 9; i < 24; ++i)
            {
                pt.pnt1("┃", 4, i);
                pt.pnt1("┃", 95, i);
            }
            pt.pnt("              ┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┓", 12, 10);
            pt.pnt("              ┃            Định dạng hợp lệ của năm học        ┃", 12, 11);
            pt.pnt("              ┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┛", 12, 12);

            Console.ForegroundColor = ConsoleColor.Green;
            pt.pnt("ĐỊNH DẠNG NĂM HỌC",9,14);
            Console.ForegroundColor = ConsoleColor.White;
            pt.pnt("─────────────────", 9, 15);
            pt.pnt("Theo quy định của nhà trường khi nhập dữ liệu năm học thì sẽ có dạng như sau : ",12,16);
            pt.pnt(" - Năm học : yyyy1-yyyy2",14,17);
            pt.pnt(" - Trong đó :", 14, 18);
            pt.pnt(" + yyyy1: năm bắt đầu và yyyy1<yyyy2", 17, 19);
            pt.pnt(" + yyyy2: năm kết thúc và yyyy2<= năm hiện tại", 17, 20);
            pt.pnt(" - Ví dụ : năm học 2014-2015 là hợp lệ", 14, 21);
            Console.ForegroundColor = ConsoleColor.Magenta;
            pt.pnt("CỬA SỔ TRỢ GIÚP (Help)", 6, 7);
            pt.pnt(" Nhấn B để quay lại trung tâm trợ giúp",54,22);
            Console.ForegroundColor = ConsoleColor.White;
        label: ConsoleKeyInfo kt = Console.ReadKey();
            switch (kt.Key)
            {
                case ConsoleKey.B:
                    Console.Clear();
                    trungtamtrogiup();
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    pt.pnt(" Nhập sai xin nhập lại ", 54, 23);
                    Console.ForegroundColor = ConsoleColor.White;
                    goto label;
            }
        }
        #endregion
        #region Nhập đúng sl học sinh
        public void slhocsinh()
        {
            pt.pnt("┏", 4, 8);
            pt.pnt("┗", 4, 20);
            pt.pnt("┓", 95, 8);
            pt.pnt("┛", 95, 20);
            Console.ForegroundColor = ConsoleColor.Magenta;
            pt.pnt1("CỬA SỔ TRỢ GIÚP (Help)", 6, 7);
            Console.ForegroundColor = ConsoleColor.White;
            pt.pnt1("━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━", 5, 8);
            pt.pnt1("━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━", 5, 20);
            pt.pnt("                                TRƯỜNG ĐẠI HỌC SƯ PHẠM KỸ THUẬT HƯNG YÊN ", 0, 1);
            pt.pnt("                                      KHOA CÔNG NGHỆ THÔNG TIN ", 1, 2);
            pt.pnt("                                     ------- ○○○○ -------", 3, 3);
            for (int i = 9; i < 20; ++i)
            {
                pt.pnt1("┃", 4, i);
                pt.pnt1("┃", 95, i);
            }
            pt.pnt("              ┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┓", 12, 10);
            pt.pnt("              ┃           Quy định về số lượng học sinh        ┃", 12, 11);
            pt.pnt("              ┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┛", 12, 12);

            Console.ForegroundColor = ConsoleColor.Green;
            pt.pnt("SỐ LƯỢNG HỌC SINH", 9, 14);
            Console.ForegroundColor = ConsoleColor.White;
            pt.pnt("─────────────────", 9, 15);
            pt.pnt("Theo quy định của nhà trường số lượng học sinh của một lớp sẽ như sau : ", 12, 16);
            pt.pnt(" - Một lớp học có tối thiểu là 25 học sinh và tối đa là 36 học sinh", 14, 17);
            Console.ForegroundColor = ConsoleColor.Magenta;
            pt.pnt("CỬA SỔ TRỢ GIÚP (Help)", 6, 7);
            pt.pnt(" Nhấn B để quay lại trung tâm trợ giúp", 54, 18);
            Console.ForegroundColor = ConsoleColor.White;
        label: ConsoleKeyInfo kt = Console.ReadKey();
            switch (kt.Key)
            {
                case ConsoleKey.B:
                    Console.Clear();
                    trungtamtrogiup();
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    pt.pnt(" Nhập sai xin nhập lại ", 54, 19);
                    Console.ForegroundColor = ConsoleColor.White;
                    goto label;
            }
        }
        #endregion
        #region Cách tạo file txt cho đúng 
        public void taofiletxt()
        {
            pt.pnt("┏", 4, 8);
            pt.pnt("┗", 4, 25);
            pt.pnt("┓", 95, 8);
            pt.pnt("┛", 95, 25);
            Console.ForegroundColor = ConsoleColor.Magenta;
            pt.pnt1("CỬA SỔ TRỢ GIÚP (Help)", 6, 7);
            Console.ForegroundColor = ConsoleColor.White;
            pt.pnt1("━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━", 5, 8);
            pt.pnt1("━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━", 5, 25);
            pt.pnt("                                TRƯỜNG ĐẠI HỌC SƯ PHẠM KỸ THUẬT HƯNG YÊN ", 0, 1);
            pt.pnt("                                      KHOA CÔNG NGHỆ THÔNG TIN ", 1, 2);
            pt.pnt("                                     ------- ○○○○ -------", 3, 3);
            for (int i = 9; i < 25; ++i)
            {
                pt.pnt1("┃", 4, i);
                pt.pnt1("┃", 95, i);
            }
            pt.pnt("              ┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┓", 12, 10);
            pt.pnt("              ┃        Cách tạo đúng định dạng file text       ┃", 12, 11);
            pt.pnt("              ┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┛", 12, 12);

            Console.ForegroundColor = ConsoleColor.Green;
            pt.pnt("TẠO FILE *TXT", 9, 14);
            Console.ForegroundColor = ConsoleColor.White;
            pt.pnt("──────────────", 9, 15);
            pt.pnt("- Theo quy định của phần mềm khi tạo dữ liệu trên file *txt phải có dạng như sau :",11,16);
            pt.pnt(" các thành phần dữ liệu phải cách nhau bởi dấu '#' ", 11, 17);
            pt.pnt("- Ví dụ : Lớp có các thành phần dữ liệu là : malop,tenlop,siso,magv",11,18);
            pt.pnt("dữ liệu khi lưu vào file *txt sẽ được tổ chức như sau :",11,19);
            pt.pnt(" malop#tenlop#siso#magv",14,20);
            Console.ForegroundColor = ConsoleColor.Magenta;
            pt.pnt("CỬA SỔ TRỢ GIÚP (Help)", 6, 7);
            pt.pnt(" Nhấn B để quay lại trung tâm trợ giúp", 54, 22);
            Console.ForegroundColor = ConsoleColor.White;
        label: ConsoleKeyInfo kt = Console.ReadKey();
            switch (kt.Key)
            {
                case ConsoleKey.B:
                    Console.Clear();
                    trungtamtrogiup();
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    pt.pnt(" Nhập sai xin nhập lại ", 54, 23);
                    Console.ForegroundColor = ConsoleColor.White;
                    goto label;
            }
        }
        #endregion
        #region tạo trung tâm trợ giúp
        public void trungtamtrogiup()
        {
            pt.pnt("┏", 4, 8);
            pt.pnt("┗", 4, 29);
            pt.pnt("┓", 95, 8);
            pt.pnt("┛", 95, 29);
            pt.pnt1("━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━", 5, 8);
            pt.pnt1("━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━", 5, 29);
            pt.pnt("                                TRƯỜNG ĐẠI HỌC SƯ PHẠM KỸ THUẬT HƯNG YÊN ", 0, 1);
            pt.pnt("                                      KHOA CÔNG NGHỆ THÔNG TIN ", 1, 2);
            pt.pnt("                                     ------- ○○○○ -------", 3, 3);
            for (int i = 9; i < 29; ++i)
            {
                pt.pnt1("┃", 4, i);
                pt.pnt1("┃", 95, i);
            }
            Console.ForegroundColor = ConsoleColor.Magenta;
            pt.pnt("              ┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┓", 12, 10);
            pt.pnt("              ┃                TRUNG TÂM TRỢ GIÚP              ┃", 12, 11);
            pt.pnt("              ┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┛", 12, 12);

            Console.ForegroundColor = ConsoleColor.Green;
            pt.pnt("NHỮNG CÂU HỎI THƯỜNG GẶP",9,14);
            Console.ForegroundColor = ConsoleColor.White;
            pt.pnt("────────────────────────", 9, 15);
            pt.pnt(" 1. Làm sao để nhập đúng định dạng mã lớp ?", 14, 16);
            pt.pnt(" 2. Làm thế nào để nhập đúng định dạng tên lớp ?",14,17);
            pt.pnt(" 3. Làm cách nào để nhập đúng định dạng mã giáo viên ? ",14,18);
            pt.pnt(" 4. Làm thế nào để nhập đúng định dạng năm học ?",14,19);
            pt.pnt(" 5. Tôi nhập số lượng học sinh của một lớp không được ?",14,20);
            pt.pnt(" 6. Cách tạo file *txt như thế nào là đúng ?", 14, 21);
            pt.pnt1("   ....", 14, 22);
            pt.pnt("Trong quá trình sử dụng phần mềm,nếu có gì thắc mắc và góp ý về", 8, 23);
            pt.pnt("phần mềm của chúng tôi thì xin liên hệ với nhóm phát triển", 8, 24);
            pt.pnt("-Hòm thư hỗ trợ :hotro.teamt@gmail.com", 6,27);
            pt.pnt("-Hotline        :0168.308.1609", 6, 28);
            Console.ForegroundColor = ConsoleColor.Green;
            pt.pnt("Nhấn Tab để quay lại", 52, 26);
            pt.pnt("Nhấn số tương ứng để xem trợ giúp : ", 52, 27);
            Console.ForegroundColor = ConsoleColor.White;
         label:   ConsoleKeyInfo kt = Console.ReadKey();
            switch (kt.Key)
            {
                case ConsoleKey.Tab:
                    Console.Clear();
                    mn.MenuChinh1();
                    break;
                case ConsoleKey.NumPad1:
                    Console.Clear();
                    dinhdangml();
                    break;
                case ConsoleKey.NumPad2:
                    Console.Clear();
                    dinhdangtl();
                    break;
                case ConsoleKey.NumPad3:
                    Console.Clear();
                    dinhdangmgv();
                    break;
                case ConsoleKey.NumPad4:
                    Console.Clear();
                    dinhdangnamhoc();
                    break;
                case ConsoleKey.NumPad5:
                    Console.Clear();
                    slhocsinh();
                    break;
                case ConsoleKey.NumPad6:
                    Console.Clear();
                    taofiletxt();
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    pt.pnt("Nhập sai xin nhập lại : ",52,28);
                    Console.ForegroundColor = ConsoleColor.White;
                    goto label;
            }
        }
        #endregion
        #endregion
    }
}
