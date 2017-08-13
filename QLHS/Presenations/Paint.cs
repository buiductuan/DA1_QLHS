#region Hàm vẽ 
using System;
using System.Linq;
using System.Text;
namespace QLHS.Presenations
{
    public class Paint
    {
        public Paint(int a, int b)
        {
            Console.SetWindowSize(a, b);
        }
        public void pnt(string s, int x, int y)
        {
            Console.SetWindowSize(100, 55);
            Console.SetCursorPosition(x, y);
            Console.Write(s);
        }
        public void pnt1(string s, int x, int y)
        {
            Console.SetWindowSize(135, 55);
            Console.SetCursorPosition(x, y);
            Console.Write(s);
        }
        public void pnt2(string s,int x,int y)
        {
            Console.SetWindowSize(160, 55);
            Console.SetCursorPosition(x, y);
            Console.Write(s);
        }
    }
}
#endregion