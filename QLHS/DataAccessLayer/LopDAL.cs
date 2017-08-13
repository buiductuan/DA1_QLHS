using System;
using System.Linq;
using System.Text;
using QLHS.Entities;
using QLHS.Utility;
using System.IO;
using QLHS.DataAccessLayer.Service_Interface;
namespace QLHS.DataAccessLayer
{
    // Triển khai giao diện từ Service Interface
   public class LopDAL:ILopDAL
    {
        private string filetxt = @"Data\Lop.txt";
        public List<Lop> GetAllData()
        {
            List<Lop> lop = new List<Lop>();
            StreamReader sr = File.OpenText(filetxt);
            string s = sr.ReadLine();
            while (s != null)
            {
                if (s != "")
                {
                    string[] a = s.Split('#');
                    lop.AddHead(new Lop(a[0], a[1], byte.Parse(a[2]), a[3]));
                }
                s = sr.ReadLine();
            }
            sr.Close();
            return lop;
        }
        public void Insert(Lop lop)
        {
            StreamWriter sw = File.AppendText(filetxt);
            sw.WriteLine();
            sw.Write(lop.Malop + "#" + lop.Tenlop + "#" + lop.Siso + "#" + lop.Magv);
            sw.Close();
        }
        public void Update(List<Lop> lop)
        {
            StreamWriter sw = File.CreateText(filetxt);
            for(int i = 0; i < lop.Count; ++i)
            {
                sw.WriteLine(lop[i].Malop + "#" + lop[i].Tenlop + "#" + lop[i].Siso + "#" + lop[i].Magv);
            }
            sw.Close();
        }
        public void BackUp(List<Lop> lop)
        {
            StreamWriter sw = File.AppendText(@"BackUp\Lop_BackUp.txt");
            DateTime dt = DateTime.Now;
            sw.WriteLine(" - Thời gian sao lưu : " + dt.ToString("dd/MM/yyyy"));
            for (int i = 0; i < lop.Count; ++i)
            {
                sw.WriteLine(lop[i].Malop + "#" + lop[i].Tenlop + "#" + lop[i].Siso + "#" + lop[i].Magv);
            }
            sw.Close();
        }
    }
}
