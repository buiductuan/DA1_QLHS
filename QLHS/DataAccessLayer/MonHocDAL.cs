using System;
using System.Linq;
using System.Text;
using QLHS.Entities;
using QLHS.Utility;
using QLHS.DataAccessLayer.Service_Interface;
using System.IO;
namespace QLHS.DataAccessLayer
{
   public class MonHocDAL: IMonHocDAL
    {
        private string filetxt = @"Data\MonHoc.txt";
        public List<MonHoc> GetAllData()
        {
            List<MonHoc> mh = new List<MonHoc>();
            StreamReader sr = File.OpenText(filetxt);
            string s = sr.ReadLine();
            while (s != null)
            {
                if (s != "")
                {
                    string[] a = s.Split('#');
                    mh.AddHead(new MonHoc(a[0], a[1], a[2]));
                }
                s = sr.ReadLine();
            }
            sr.Close();
            return mh;
        }
        public void Insert(MonHoc mh)
        {
            StreamWriter sw = File.AppendText(filetxt);
            sw.WriteLine();
            sw.WriteLine(mh.Mamon + "#" + mh.Tenmon + "#" + mh.Ghichu);
            sw.Close();
        }
        public void Update(List<MonHoc> mh)
        {
            StreamWriter sw = File.CreateText(filetxt);
            for(int i=0; i < mh.Count; ++i)
            {
                sw.WriteLine(mh[i].Mamon + "#" + mh[i].Tenmon + "#" + mh[i].Ghichu);
            }
            sw.Close();
        }
        public void BackUp(List<MonHoc> mh)
        {
            StreamWriter sw = File.AppendText(@"BackUp\MonHoc_BackUp.txt");
            DateTime dt = DateTime.Now;
            sw.WriteLine("- Thời điểm sao lưu : " + dt.ToString("dd/MM/yyyy"));
            for (int i = 0; i < mh.Count; ++i)
            {
                sw.WriteLine(mh[i].Mamon + "#" + mh[i].Tenmon + "#" + mh[i].Ghichu);
            }
            sw.Close();
        }
    }
}
