using System;
using System.Linq;
using System.Text;
using QLHS.Entities;
using QLHS.Utility;
using QLHS.DataAccessLayer.Service_Interface;
using System.IO;
namespace QLHS.DataAccessLayer
{
   public class GVCNDAL:IGVCNDAL
    {
        private string filetxt = @"Data\GVCN.txt";
        public List<GVCN> GetAllData()
        {
            List<GVCN> gv = new List<GVCN>();
            StreamReader sr = File.OpenText(filetxt);
            string s = sr.ReadLine();
            while (s != null)
            {
                if (s != "")
                {
                    string[] a = s.Split('#');
                    gv.AddHead(new GVCN(a[0], a[1], a[2], a[3]));
                }
                s = sr.ReadLine();
            }
            sr.Close();
            return gv;
        }
        public void Insert(GVCN gv)
        {
            StreamWriter sw = File.AppendText(filetxt);
            sw.WriteLine();
            sw.Write(gv.Magv + "#" + gv.Tengv + "#" + gv.Diachi + "#" + gv.Sdtgv);
            sw.Close();
        }
        public void Update(List<GVCN> gv)
        {
            StreamWriter sw = File.CreateText(filetxt);
            for(int i = 0; i < gv.Count; ++i)
            {
                sw.WriteLine(gv[i].Magv + "#" + gv[i].Tengv + "#" + gv[i].Diachi + "#" + gv[i].Sdtgv);
            }
            sw.Close();
        }
        public void BackUp(List<GVCN> gv)
        {
            StreamWriter sw = File.AppendText(@"BackUp\GVCN_BackUp.txt");
            DateTime dt = DateTime.Now;
            sw.WriteLine(" - Thời gian sao lưu : " + dt.ToString("dd/MM/yyyy"));
            for (int i = 0; i < gv.Count; ++i)
            {
                sw.WriteLine(gv[i].Magv + "#" + gv[i].Tengv + "#" + gv[i].Diachi + "#" + gv[i].Sdtgv);
            }
            sw.Close();
        }
        public void SearchGV(List<GVCN> gv)
        {
            StreamWriter sw = File.AppendText(@"Search\Search_GVCN.txt");
            DateTime dt = DateTime.Now;
            sw.WriteLine(" - Thời gian tìm kiếm : " + dt.ToString("dd/MM/yyyy"));
            for (int i = 0; i < gv.Count; ++i)
            {
                sw.WriteLine(gv[i].Magv + "#" + gv[i].Tengv + "#" + gv[i].Diachi + "#" + gv[i].Sdtgv);
            }
            sw.Close();
        }
    }
}
