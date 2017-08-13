using System;
using System.Linq;
using System.Text;
using QLHS.Presenations;
namespace QLHS
{
    class Program
    {
        #region Hàm Main
        static void Main(string[] args)
        {
            try
            {
                Console.OutputEncoding = Encoding.UTF8;
                Console.Title = "                                    CHƯƠNG TRÌNH QUẢN LÝ HỌC SINH";
                FormBia f = new FormBia();
                f.KhoiDong();
                Console.ReadKey();
            }
            catch
            {
                Console.WriteLine("Screen Error , Please setting screen font-size : 12pt");
                Console.ReadKey();
            }
        }
        #endregion
    }
}
