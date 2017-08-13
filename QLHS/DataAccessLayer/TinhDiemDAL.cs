using System;
using System.Linq;
using System.Text;
using System.IO;
using QLHS.Utility;
using QLHS.Entities;
using QLHS.DataAccessLayer.Service_Interface;
namespace QLHS.DataAccessLayer
{
  public  class TinhDiemDAL : ITinhDiemDAL
    {
        private string filetxt = @"Score\DiemTB.txt";
        public List<TinhDiem> GetAllData()
        {
            List<TinhDiem> kq = new List<TinhDiem>();
            StreamReader sr = File.OpenText(filetxt);
            string s = sr.ReadLine();
            while (s != null)
            {
                if (s != "")
                {
                    string[] a = s.Split('#');
                    kq.AddHead(new TinhDiem(a[0], a[1], double.Parse(a[2])));
                }
                s = sr.ReadLine();
            }
            sr.Close();
            return kq;
        }
        public void Insert(TinhDiem td)
        {
            StreamWriter sw = File.AppendText(filetxt);
            sw.WriteLine();
            sw.Write(td.Mahs + "#" + td.Hocky + "#" + td.Diemtb);
            sw.Close();
        }
    }
}
