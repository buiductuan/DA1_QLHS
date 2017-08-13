using System;
using System.Linq;
using System.Text;
using QLHS.Utility;
using QLHS.Entities;
using QLHS.Business.Components;
using QLHS.Presenations;
using System.Threading;
namespace QLHS.Presenations
{
   public class FormBia
    {
        #region Trang bìa
        //Choose Date 
        DateTime t = DateTime.Now;
        //Create object paint
        Paint pt = new Paint(100, 45);
        //Create object Menu
        MenuChinh menu = new MenuChinh();
        //Create object SignIn
        public static   FormDN dn = new FormDN();
        #region thiết kế bìa
        public void KhoiDong()
        {
            // Hide Scrollbar
            Console.BufferWidth = Console.WindowWidth = 35;
            Console.BufferHeight = Console.WindowHeight;
            // Setting text color :white
            Console.ForegroundColor = ConsoleColor.White;

            pt.pnt("                          TRƯỜNG ĐẠI HỌC SƯ PHẠM KỸ THUẬT HƯNG YÊN ",3,1);
            pt.pnt("                                KHOA CÔNG NGHỆ THÔNG TIN ", 3, 2);
            pt.pnt("                                  ------- oooo -------", 3,3);
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            pt.pnt("┏", 4, 5);
            Console.ForegroundColor = ConsoleColor.Magenta;
            pt.pnt("┗", 4, 50);
            Console.ForegroundColor = ConsoleColor.Cyan;
            pt.pnt("┓", 95, 5);
            Console.ForegroundColor = ConsoleColor.Blue;
            pt.pnt("┛", 95, 50);
            Console.ForegroundColor = ConsoleColor.Blue;
            pt.pnt("━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━", 5, 5);
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            pt.pnt("━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━", 5, 50);
            #region Chữ ký
            Console.ForegroundColor = ConsoleColor.Red;
            pt.pnt("D", 5, 49);
            Console.ForegroundColor = ConsoleColor.White;
            pt.pnt("e", 6, 49);
            Console.ForegroundColor = ConsoleColor.Cyan;
            pt.pnt("s", 7, 49);
            Console.ForegroundColor = ConsoleColor.Green;
            pt.pnt("i", 8, 49);
            Console.ForegroundColor = ConsoleColor.Yellow;
            pt.pnt("g", 9, 49);
            Console.ForegroundColor = ConsoleColor.Gray;
            pt.pnt("n", 10, 49);
            Console.ForegroundColor = ConsoleColor.Magenta;
            pt.pnt("e", 11, 49);
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            pt.pnt("d", 12, 49);
            Console.ForegroundColor = ConsoleColor.DarkRed;
            pt.pnt("b", 14, 49);
            Console.ForegroundColor = ConsoleColor.Yellow;
            pt.pnt("y", 15, 49);
            Console.ForegroundColor = ConsoleColor.Red;
            pt.pnt("T", 17, 49);
            Console.ForegroundColor = ConsoleColor.Yellow;
            pt.pnt("u", 18, 49);
            Console.ForegroundColor = ConsoleColor.Green;
            pt.pnt("a", 19, 49);
            Console.ForegroundColor = ConsoleColor.Red;
            pt.pnt("n", 20, 49);
            Console.ForegroundColor = ConsoleColor.Yellow;
            pt.pnt("™", 23, 49);
            Console.ForegroundColor = ConsoleColor.Green;
            pt.pnt("- "+t.ToShortDateString(), 25, 49);
            Console.ForegroundColor = ConsoleColor.White;
            #endregion
            Console.ForegroundColor = ConsoleColor.Green;
            pt.pnt(" CHƯƠNG TRÌNH QUẢN LÝ HỌC SINH ",34,6);
            pt.pnt("━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━", 30, 7);
            Console.ForegroundColor = ConsoleColor.White;
            for (int i = 6; i < 50; ++i)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                pt.pnt("┃", 4, i);
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                pt.pnt("┃", 95, i);
                Console.ForegroundColor = ConsoleColor.White;
            }
            Console.ForegroundColor = ConsoleColor.Cyan;
                pt.pnt("┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┓ ", 12,13);
                pt.pnt("┃                      ╱╲  ╲              ╱                                ┃ ", 12,14);
                pt.pnt("┃  ┏━━━━━━━━━━━┓   ┏━━━━━━━━━┓      ┏━━━━━━━━━┓     ┏━┓     ┏━┓  ┏━━━━━━┓  ┃ ", 12,15);
                pt.pnt("┃  ┃  ┏━━━━━━┓ ┃   ┃ ┏━━━━━┓ ┃      ┃ ┏━━━━━┓ ┃     ┃ ┃╲    ┃ ┃  ┗━━━┓  ┃  ┃ ", 12,16);
                pt.pnt("┃  ┃  ┃      ┃ ┃   ┃ ┃     ┃ ┃      ┃ ┃     ┃ ┃     ┃ ┃ ╲   ┃ ┃      ┃  ┃  ┃ ", 12,17);
                pt.pnt("┃ ━━━━━━     ┃ ┃   ┃ ┃     ┃ ┃      ┃ ┣━━━━━┫ ┃     ┃ ┃  ╲  ┃ ┃      ┃  ┃  ┃ ", 12,18);
                pt.pnt("┃  ┃  ┃      ┃ ┃   ┃ ┃     ┃ ┃      ┃ ┃     ┃ ┃     ┃ ┃   ╲ ┃ ┃      ┃  ┃  ┃ ", 12,19);
                pt.pnt("┃  ┃  ┗━━━━━━┛ ┃   ┃ ┗━━━━━┛ ┃      ┃ ┃     ┃ ┃     ┃ ┃    ╲┃ ┃      ┃  ┃  ┃ ", 12,20);
                pt.pnt("┃  ┗━━━━━━━━━━━┛   ┗━━━━━━━━━┛      ┗━┛     ┗━┛     ┗━┛     ┗━┛      ┗━━┛  ┃ ", 12,21);
                pt.pnt("┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┛ ", 12,22);
            Console.ForegroundColor = ConsoleColor.White;

            pt.pnt(" Giáo viên hướng dẫn :  ThS. Trần Đỗ Thu Hà",30,28);
            pt.pnt(" Nhóm thực hiện      : ",30,30);
            pt.pnt(" Bùi Đức Tuân ",53,30);
            pt.pnt("Đinh Công Trường ",54,31);
            pt.pnt(" Lớp                 :  TK12.4",30,32);
            pt.pnt(" Nhấn",58,48);
            Console.ForegroundColor = ConsoleColor.Green;
            pt.pnt("Enter", 64, 48);
            Console.ForegroundColor = ConsoleColor.White;
            pt.pnt("để tiếp tục", 70, 48);
            pt.pnt(" Nhấn",58,49);
            Console.ForegroundColor = ConsoleColor.Green;
            pt.pnt("Esc", 64, 49);
            Console.ForegroundColor = ConsoleColor.White;
            pt.pnt1("để thoát khỏi chương trình", 68, 49);
            pt.pnt("", 81, 48);
            den1: ConsoleKeyInfo kt = Console.ReadKey();
            Console.ForegroundColor = ConsoleColor.White;
            switch (kt.Key)
            {
                case ConsoleKey.Enter:
                    Console.Clear();
                    dn.dangnhap();
                    break;
                case ConsoleKey.Escape:
                    Environment.Exit(0);
                    break;
                default:
                    pt.pnt("      ", 81, 48);
                    pt.pnt("", 81, 48);
                    goto den1;
            }
        }
        #endregion
        #endregion
    }
}
