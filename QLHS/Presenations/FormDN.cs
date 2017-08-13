using System;
using System.Linq;
using System.Text;
using QLHS.Utility;
using QLHS.Entities;
using QLHS.Business.Service_Interface;
using QLHS.Business.Components;
using QLHS.DataAccessLayer;
using QLHS.DataAccessLayer.Service_Interface;
using System.Threading;
namespace QLHS.Presenations
{
  public class FormDN
    {
        #region Tạo cửa sổ đăng nhập 
        Paint pt = new Paint(100, 40);
        public static MenuChinh mn = new MenuChinh();
        FormBia fb = new FormBia();
        DangNhapBLL dnbll = new DangNhapBLL();
        DangNhapDAL dnDA = new DangNhapDAL();
        #region Form đăng nhập
        public void dangnhap()
        {
            string user, pass;
            pt.pnt("┏", 4, 8);
            pt.pnt("┗", 4, 40);
            pt.pnt("┓", 95, 8);
            pt.pnt("┛", 95, 40);
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.ForegroundColor = ConsoleColor.White;
            pt.pnt("━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━", 5, 8);
            pt.pnt("━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━", 5, 40);
            pt.pnt("                                TRƯỜNG ĐẠI HỌC SƯ PHẠM KỸ THUẬT HƯNG YÊN ", 0, 1);
            pt.pnt("                                      KHOA CÔNG NGHỆ THÔNG TIN ", 1, 2);
            pt.pnt("                                     ------- ○○○○ -------", 3, 3);
            for (int i = 9; i < 40; ++i)
            {
                pt.pnt("┃", 4, i);
                pt.pnt("┃", 95, i);
            }
            pt.pnt("            ┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┓", 12, 10);
            pt.pnt("            ┃                    ĐĂNG NHẬP                   ┃", 12, 11);
            pt.pnt("            ┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┛", 12, 12);

            pt.pnt("━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━", 20, 14);
            pt.pnt("━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━", 20, 32);

            pt.pnt("┏", 19, 14);
            pt.pnt("┓", 76, 14);
            pt.pnt("┗", 19, 32);
            pt.pnt("┛", 76, 32);

            #region Chữ ký
            Console.ForegroundColor = ConsoleColor.Red;
            pt.pnt("D", 5, 39);
            Console.ForegroundColor = ConsoleColor.White;
            pt.pnt("e", 6, 39);
            Console.ForegroundColor = ConsoleColor.Cyan;
            pt.pnt("s", 7, 39);
            Console.ForegroundColor = ConsoleColor.Green;
            pt.pnt("i", 8, 39);
            Console.ForegroundColor = ConsoleColor.Yellow;
            pt.pnt("g", 9, 39);
            Console.ForegroundColor = ConsoleColor.Gray;
            pt.pnt("n", 10, 39);
            Console.ForegroundColor = ConsoleColor.Magenta;
            pt.pnt("e", 11, 39);
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            pt.pnt("d", 12, 39);
            Console.ForegroundColor = ConsoleColor.DarkRed;
            pt.pnt("b", 14, 39);
            Console.ForegroundColor = ConsoleColor.Yellow;
            pt.pnt("y", 15, 39);
            Console.ForegroundColor = ConsoleColor.Red;
            pt.pnt("T", 17, 39);
            Console.ForegroundColor = ConsoleColor.Yellow;
            pt.pnt("e", 18, 39);
            Console.ForegroundColor = ConsoleColor.Green;
            pt.pnt("a", 19, 39);
            Console.ForegroundColor = ConsoleColor.Red;
            pt.pnt("m", 20, 39);
            Console.ForegroundColor = ConsoleColor.Magenta;
            pt.pnt("T", 22, 39);
            Console.ForegroundColor = ConsoleColor.Yellow;
            pt.pnt("™", 23, 39);
            Console.ForegroundColor = ConsoleColor.White;
            #endregion

            for (int i = 15; i < 32; ++i)
            {
                pt.pnt("┃", 19, i);
                pt.pnt("┃", 76, i);
            }
            pt.pnt("USER      : ", 24, 20);
            pt.pnt("PASSWORD  :", 24, 22);
        label:
            Console.BackgroundColor = ConsoleColor.Gray;
            string s = "                                 ";
            pt.pnt(s, 35, 20);
            pt.pnt(s, 35, 22);
            pt.pnt("", 35, 20);
            Console.ForegroundColor = ConsoleColor.Black;
            user = Console.ReadLine();
            Console.ResetColor();
            pt.pnt("", 35, 22); pass = Nhappass();
            if (dnbll.KTnick(user, pass) == false)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                pt.pnt("Bạn nhập sai tài khoản ", 46, 24);
                Console.ForegroundColor = ConsoleColor.White;
                pt.pnt("Nhấn",20,26);
                Console.ForegroundColor = ConsoleColor.Green;
                pt.pnt("Enter ",25,26);
                Console.ForegroundColor = ConsoleColor.White;
                pt.pnt("để nhập lại", 31, 26);
                pt.pnt("Nhấn",20,27);
                Console.ForegroundColor = ConsoleColor.Green;
                pt.pnt("N",27,27);
                Console.ForegroundColor = ConsoleColor.White;
                pt.pnt("để tạo tài khoản mới", 31, 27);
                pt.pnt("Nhấn",20,28);
                Console.ForegroundColor = ConsoleColor.Green;
                pt.pnt("Q", 27, 28);
                Console.ForegroundColor = ConsoleColor.White;
                pt.pnt("nếu bạn quên mật khẩu", 31, 28);
                pt.pnt("Nhấn",20,29);
                Console.ForegroundColor = ConsoleColor.Green;
                pt.pnt("X",27,29);
                Console.ForegroundColor = ConsoleColor.White;
                pt.pnt("nếu bạn muốn xóa tài khoản", 31, 29);
                pt.pnt("Nhấn",20,30);
                Console.ForegroundColor = ConsoleColor.Green;
                pt.pnt("ESC",25,30);
                Console.ForegroundColor = ConsoleColor.White;
                pt.pnt("để thoát khỏi chương trình", 31, 30);
                string s2 = " ";
                pt.pnt(s2, 57, 30);
                Console.ResetColor();
            label1:
                Console.ForegroundColor = ConsoleColor.Red;
                Console.ResetColor();
                ConsoleKeyInfo ktt = Console.ReadKey();
                switch (ktt.Key)
                {
                    case ConsoleKey.Enter:
                        Console.BackgroundColor = ConsoleColor.Black;
                        string s1 = "                                      ";
                        pt.pnt("                        ", 46, 24);
                        pt.pnt(s1, 20, 26);
                        pt.pnt(s1, 20, 27);
                        pt.pnt(s1, 20, 28);
                        pt.pnt(s1, 20, 29);
                        pt.pnt(s1, 20, 30);
                        string s3 = "                                             ";
                        pt.pnt(s3, 20, 31);
                        Console.ResetColor();
                        goto label;
                    case ConsoleKey.N:
                        Console.ResetColor();
                        Console.Clear();
                        taotaikhoan();
                        break;
                    case ConsoleKey.Q:
                        Console.ResetColor();
                        Console.Clear();
                        quenmatkhau();
                        break;
                    case ConsoleKey.X:
                        Console.ResetColor();
                        Console.Clear();
                        RemoveAccount();
                        break;
                    case ConsoleKey.Escape:
                        Environment.Exit(0);
                        break;
                    case ConsoleKey.Tab:
                        Console.Clear();
                        fb.KhoiDong();
                        break;
                    default:
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.ForegroundColor = ConsoleColor.Red;
                        pt.pnt("           ", 48, 29);
                        pt.pnt("Bạn nhập sai . Nhấn Enter để nhập lại", 20, 31);
                        goto label1;
                }
            }
            else
            {
                pt.pnt(" Tài khoản hợp lệ ! Đang lấy dữ liệu hệ thống ...",7,33);
                pt.pnt(" Xin chờ trong giây lát ", 7, 35);
                Console.BackgroundColor = ConsoleColor.Gray;
                //pt.pnt("                                ", 34, 35);
                pt.pnt("", 0, 0);
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Blue;
                pt.pnt("┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┓", 32, 34);
                pt.pnt("┃", 32, 35);              pt.pnt("┃", 66, 35);
                pt.pnt("┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┛", 32, 36);
                Console.ForegroundColor = ConsoleColor.Green;
                System.Threading.Thread.Sleep(1000);
                pt.pnt("█", 34, 35);
                pt.pnt(" 12% ", 68, 35); pt.pnt("", 0, 0);

                System.Threading.Thread.Sleep(1000);
                pt.pnt("███", 35, 35);
                pt.pnt(" 22% ", 68, 35); pt.pnt("", 0, 0);

                System.Threading.Thread.Sleep(1000);
                pt.pnt("███████", 36, 35);
                pt.pnt(" 35% ", 68, 35); pt.pnt("", 0, 0);

                System.Threading.Thread.Sleep(1000);
                pt.pnt("██████████", 37, 35);
                pt.pnt(" 42% ", 68, 35); pt.pnt("", 0, 0);

                System.Threading.Thread.Sleep(1000);
                pt.pnt("███████████", 38, 35);
                pt.pnt(" 58% ", 68, 35); pt.pnt("", 0, 0);

                System.Threading.Thread.Sleep(1000);
                pt.pnt("█████████████", 39, 35);
                pt.pnt(" 68% ", 68, 35); pt.pnt("", 0, 0);

                System.Threading.Thread.Sleep(1000);
                pt.pnt("██████████████", 40, 35);
                pt.pnt(" 72% ", 68, 35); pt.pnt("", 0, 0);

                System.Threading.Thread.Sleep(1000);
                pt.pnt("████████████████", 45, 35);
                pt.pnt(" 89% ", 68, 35); pt.pnt("", 0, 0);

                System.Threading.Thread.Sleep(1000);
                pt.pnt("██████████████████", 42, 35);
                pt.pnt(" 95% ", 68, 35); pt.pnt("", 0, 0);

                System.Threading.Thread.Sleep(1000);
                pt.pnt("██████████████████████", 43, 35);
                pt.pnt(" 100% ", 68, 35); pt.pnt("", 0, 0);

                Console.ForegroundColor = ConsoleColor.White;
                pt.pnt("", 0, 0);
                System.Threading.Thread.Sleep(2200);
                Console.Clear();
                mn.MenuChinh1();
            }
        }
        public string Nhappass()
        {
            string s = null;
            ConsoleKeyInfo kt;
            do
            {
                kt = Console.ReadKey(true);
                if (kt.Key != ConsoleKey.Enter)
                {
                    Console.Write("*");
                    s = s + kt.KeyChar.ToString();
                }
                else break;
            } while (true);
            return s;
        }
        #endregion
        #region Tạo tài khoản đăng nhập
        public void taotaikhoan()
        {
           string user, pass1,pass2;
            pt.pnt("┏", 4, 8);
            pt.pnt("┗", 4, 40);
            pt.pnt("┓", 95, 8);
            pt.pnt("┛", 95, 40);
            Console.ResetColor();
            pt.pnt("━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━", 5, 8);
            pt.pnt("━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━", 5, 40);
            pt.pnt("                                TRƯỜNG ĐẠI HỌC SƯ PHẠM KỸ THUẬT HƯNG YÊN ", 0, 1);
            pt.pnt("                                      KHOA CÔNG NGHỆ THÔNG TIN ", 1, 2);
            pt.pnt("                                     ------- ○○○○ -------", 3, 3);
            for (int i = 9; i < 40; ++i)
            {
                pt.pnt("┃", 4, i);
                pt.pnt("┃", 95, i);
            }
            pt.pnt("            ┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┓", 12, 10);
            pt.pnt("            ┃             TẠO TÀI KHOẢN ĐĂNG NHẬP            ┃", 12, 11);
            pt.pnt("            ┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┛", 12, 12);

            pt.pnt("━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━", 20, 14);
            pt.pnt("━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━", 20, 32);

            pt.pnt("┏", 19, 14);
            pt.pnt("┓", 76, 14);
            pt.pnt("┗", 19, 32);
            pt.pnt("┛", 76, 32);

            for (int i = 15; i < 32; ++i)
            {
                pt.pnt("┃", 19, i);
                pt.pnt("┃", 76, i);
            }
            pt.pnt("Tạo tên đăng nhập  : ", 24, 20);
            pt.pnt("Tạo mật khẩu       :", 24, 22);
            pt.pnt("Nhập lại mật khẩu  :", 24, 24);


          user:
            pt.pnt("", 45, 20); user = Console.ReadLine();
            if (user == "")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                pt.pnt("Phần này không được rỗng ", 45, 20);
                pt.pnt("Hoặc nhấn Tab để quay lại",50,31);
                Console.ForegroundColor = ConsoleColor.White;
                ConsoleKeyInfo kt = Console.ReadKey();
                switch (kt.Key)
                {
                    case ConsoleKey.Tab:
                        Console.Clear();
                        dangnhap();
                        break;
                    default:
                        pt.pnt("                            ", 45, 20);
                        pt.pnt("                         ", 50, 31);
                        goto user;
                }
            }
            if (dnbll.KTuser(user))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                pt.pnt("Tên đăng nhập đã tồn tại ", 45, 20);
                pt.pnt("Hoặc nhấn Tab để quay lại", 50, 31);
                Console.ForegroundColor = ConsoleColor.White;
                ConsoleKeyInfo kt = Console.ReadKey();
                switch (kt.Key)
                {
                    case ConsoleKey.Tab:
                        Console.Clear();
                        dangnhap();
                        break;
                    default:
                        pt.pnt("                            ", 45, 20);
                        pt.pnt("                         ", 50, 31);
                        goto user;
                }
            }
        pass1:
            pt.pnt("", 45, 22);pass1 = Console.ReadLine();
            if (pass1=="")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                pt.pnt("Phần này không được rỗng ", 45, 22);
                pt.pnt("Hoặc nhấn Tab để quay lại", 50, 31);
                Console.ForegroundColor = ConsoleColor.White;
                ConsoleKeyInfo kt = Console.ReadKey();
                switch (kt.Key)
                {
                    case ConsoleKey.Tab:
                        Console.Clear();
                        dangnhap();
                        break;
                    default:
                        pt.pnt("                            ", 45, 22);
                        pt.pnt("                         ", 50, 31);
                        goto pass1;
                }
            }
            pass2:
            pt.pnt("", 45, 24); pass2 = Console.ReadLine();
            if (pass1 != pass2)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                pt.pnt("Mã không khớp", 45, 24);
                Console.ForegroundColor = ConsoleColor.White;
                ConsoleKeyInfo kt = Console.ReadKey();
                switch (kt.Key)
                {
                    default:
                        pt.pnt("                            ", 45, 24);
                        goto pass2;
                }
            }
        DangNhap dnn = new DangNhap(user, pass1);
            pt.pnt("Bạn đã tạo thành công ",45,30);
            pt.pnt("Nhấn Enter để lưu và trở lại", 45, 31);
         label:   ConsoleKeyInfo ktt = Console.ReadKey();
            switch (ktt.Key)
            {
                case ConsoleKey.Enter:
                    dnbll.ThemUP(dnn);
                    Console.Clear();
                    dangnhap();
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    pt.pnt(" Nhấn sai xin nhập lại ",45,32);
                    Console.ForegroundColor = ConsoleColor.White;
                    goto label;
            }
        }
        #endregion
        #region Lấy lại mật khẩu
        public void quenmatkhau()
        {
            string user;
            pt.pnt("┏", 4, 8);
            pt.pnt("┗", 4, 40);
            pt.pnt("┓", 95, 8);
            pt.pnt("┛", 95, 40);
            Console.ResetColor();
            pt.pnt("━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━", 5, 8);
            pt.pnt("━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━", 5, 40);
            pt.pnt("                                TRƯỜNG ĐẠI HỌC SƯ PHẠM KỸ THUẬT HƯNG YÊN ", 0, 1);
            pt.pnt("                                      KHOA CÔNG NGHỆ THÔNG TIN ", 1, 2);
            pt.pnt("                                     ------- ○○○○ -------", 3, 3);
            for (int i = 9; i < 40; ++i)
            {
                pt.pnt("┃", 4, i);
                pt.pnt("┃", 95, i);
            }
            pt.pnt("            ┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┓", 12, 10);
            pt.pnt("            ┃            LẤY LẠI TÀI KHOẢN ĐĂNG NHẬP         ┃", 12, 11);
            pt.pnt("            ┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┛", 12, 12);

            pt.pnt("━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━", 20, 14);
            pt.pnt("━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━", 20, 32);

            pt.pnt("┏", 19, 14);
            pt.pnt("┓", 76, 14);
            pt.pnt("┗", 19, 32);
            pt.pnt("┛", 76, 32);

            for (int i = 15; i < 32; ++i)
            {
                pt.pnt("┃", 19, i);
                pt.pnt("┃", 76, i);
            }
            pt.pnt("Nhập tên đăng nhập của bạn : ", 24, 20);user = Console.ReadLine();
            if (dnbll.KTuser(user) == true)
            {
                List<DangNhap> list = dnDA.GetAllData();
                for (int i = 0; i < list.Count; ++i)
                {
                    if (list[i].User == user)
                    {
                        pt.pnt(list[i].Pass, 53, 22);
                    }
                }
                pt.pnt("Mật khẩu của bạn là        :", 24, 22);
                pt.pnt("Nhấn Enter để quay lại ", 24, 28);
                Console.ForegroundColor = ConsoleColor.White;
            Label: ConsoleKeyInfo kttt = Console.ReadKey();
                switch (kttt.Key)
                {
                    case ConsoleKey.Enter:
                        Console.Clear();
                        dangnhap();
                        break;
                    default:
                        pt.pnt(" Bạn nhập sai. Xin nhập lại ", 24, 30);
                        Console.ForegroundColor = ConsoleColor.White;
                        goto Label;
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                pt.pnt(" Tên đăng nhập không tồn tại trong hệ thống ", 24, 28);
                pt.pnt(" Xin bạn kiểm tra lại hoặc nhấn N để tạo mới", 24, 29);
                //pt.pnt(" Enter để quay lại", 24, 28);
                Console.ForegroundColor = ConsoleColor.White;
            Label1: ConsoleKeyInfo kttt = Console.ReadKey();
                switch (kttt.Key)
                {
                    case ConsoleKey.N:
                        Console.Clear();
                        taotaikhoan();
                        break;
                    case ConsoleKey.Enter:
                        Console.Clear();
                        dangnhap();
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        pt.pnt(" Bạn nhập sai. Xin nhập lại ", 24, 30);
                        Console.ForegroundColor = ConsoleColor.White;
                        goto Label1;
                }
            }

        }
        #endregion
        #region Xóa tài khoản khỏi hệ thống
        public void RemoveAccount()
        {
            string user,pass;
            pt.pnt("┏", 4, 8);
            pt.pnt("┗", 4, 40);
            pt.pnt("┓", 95, 8);
            pt.pnt("┛", 95, 40);
            Console.ResetColor();
            pt.pnt("━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━", 5, 8);
            pt.pnt("━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━", 5, 40);
            pt.pnt("                                TRƯỜNG ĐẠI HỌC SƯ PHẠM KỸ THUẬT HƯNG YÊN ", 0, 1);
            pt.pnt("                                      KHOA CÔNG NGHỆ THÔNG TIN ", 1, 2);
            pt.pnt("                                     ------- ○○○○ -------", 3, 3);
            for (int i = 9; i < 40; ++i)
            {
                pt.pnt("┃", 4, i);
                pt.pnt("┃", 95, i);
            }
            pt.pnt("            ┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┓", 12, 10);
            pt.pnt("            ┃       XÓA TÀI KHOẢN ĐĂNG NHẬP KHỎI HỆ THỐNG    ┃", 12, 11);
            pt.pnt("            ┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┛", 12, 12);

            pt.pnt("━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━", 20, 14);
            pt.pnt("━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━", 20, 32);

            pt.pnt("┏", 19, 14);
            pt.pnt("┓", 76, 14);
            pt.pnt("┗", 19, 32);
            pt.pnt("┛", 76, 32);

            for (int i = 15; i < 32; ++i)
            {
                pt.pnt("┃", 19, i);
                pt.pnt("┃", 76, i);
            }
            pt.pnt(" User     : ", 24, 20);
            pt.pnt(" Password : ", 24, 21);
            pt.pnt("", 36, 20);
            user = Console.ReadLine();
            pt.pnt("", 36, 21);
            pass = Console.ReadLine();
            if (dnbll.KTnick(user,pass) == true)
            {
                pt.pnt("Tài khoản xóa thành công ", 24, 27);
                pt.pnt("Nhấn Enter để quay lại ", 24, 28);
                Console.ForegroundColor = ConsoleColor.White;
            Label: ConsoleKeyInfo kttt = Console.ReadKey();
                switch (kttt.Key)
                {
                    case ConsoleKey.Enter:
                        dnbll.XoaUP(user);
                        Console.Clear();
                        dangnhap();
                        break;
                    default:
                        pt.pnt(" Bạn nhập sai. Xin nhập lại ", 24, 30);
                        Console.ForegroundColor = ConsoleColor.White;
                        goto Label;
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                pt.pnt(" Tài khoản không tồn tại trong hệ thống ", 24, 28);
                pt.pnt(" Xin bạn kiểm tra lại hoặc nhấn N để tạo mới", 24, 29);
                //pt.pnt(" Enter để quay lại", 24, 28);
                Console.ForegroundColor = ConsoleColor.White;
            Label1: ConsoleKeyInfo kttt = Console.ReadKey();
                switch (kttt.Key)
                {
                    case ConsoleKey.N:
                        Console.Clear();
                        taotaikhoan();
                        break;
                    case ConsoleKey.Enter:
                        Console.Clear();
                        dangnhap();
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        pt.pnt(" Bạn nhập sai. Xin nhập lại ", 24, 30);
                        Console.ForegroundColor = ConsoleColor.White;
                        goto Label1;
                }
            }
        }
        #endregion
        #endregion
    }
}
