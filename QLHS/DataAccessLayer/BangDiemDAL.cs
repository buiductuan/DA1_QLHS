using System;
using System.Linq;
using System.Text;
using QLHS.Entities;
using QLHS.Utility;
using QLHS.DataAccessLayer.Service_Interface;
using System.IO;
namespace QLHS.DataAccessLayer
{
  public  class BangDiemDAL :IBangDiemDAL
    {
        private string filetxt = @"Data\BangDiem.txt";
        public List<BangDiem> GetAllData()
        {
            List<BangDiem> bd = new List<BangDiem>();
            StreamReader sr = File.OpenText(filetxt);
            string s = sr.ReadLine();
            while (s != null)
            {
                if (s != "")
                {
                    string[] a = s.Split('#');
                    bd.AddHead(new BangDiem(a[0], a[1],a[2], double.Parse(a[3]), double.Parse(a[4]), a[5], a[6], a[7]));
                }
                s = sr.ReadLine();
            }
            sr.Close();
            return bd;
        }
        public void Insert(BangDiem bd)
        {
            StreamWriter sw = File.AppendText(filetxt);
            sw.WriteLine();
            sw.Write(bd.Mahs + "#" + bd.Malop+"#"+bd.Mamon + "#" + bd.Diemgiuaky + "#" + bd.Diemcuoiky + "#" + bd.Hanhkiemky + "#" + bd.Hocky + "#" + bd.Namhoc+'#'+bd.Diemtk+'#'+bd.Diemtbcn);
            sw.Close();
        }
        public void Update(List<BangDiem> bd)
        {
            StreamWriter sw = File.CreateText(filetxt);
            for (int i = 0; i < bd.Count; ++i)
            {
                sw.WriteLine(bd[i].Mahs + "#" + bd[i].Malop+"#"+bd[i].Mamon + "#" + bd[i].Diemgiuaky + "#" + bd[i].Diemcuoiky + "#" + bd[i].Hanhkiemky + "#" + bd[i].Hocky + "#" + bd[i].Namhoc+'#'+bd[i].Diemtk+"#"+bd[i].Diemtbcn);
            }
            sw.Close();

        }
        public void BackUp(List<BangDiem> bd)
        {
            StreamWriter sw = File.AppendText(@"BackUp\BangDiem_BackUp.txt");
            DateTime dt = DateTime.Now;
            sw.WriteLine(" - Thời gian sao lưu : " + dt.ToString("dd/MM/yyyy"));
            for (int i = 0; i < bd.Count; ++i)
            {
                sw.WriteLine(bd[i].Mahs + "#" + bd[i].Malop+"#"+bd[i].Mamon + "#" + bd[i].Diemgiuaky + "#" + bd[i].Diemcuoiky + "#" + bd[i].Hanhkiemky + "#" + bd[i].Hocky + "#" + bd[i].Namhoc+"#"+bd[i].Diemtk);
            }
            sw.Close();
        }
        public void SearchDiem(List<BangDiem> bd)
        {
            StreamWriter sw = File.AppendText(@"Search\Search_Diem.txt");
            DateTime dt = DateTime.Now;
            sw.WriteLine(" - Thời gian tìm kiếm : " + dt.ToString("dd/MM/yyyy"));
            for (int i = 0; i < bd.Count; ++i)
            {
                sw.WriteLine(bd[i].Mahs + "#" + bd[i].Malop+"#"+bd[i].Mamon + "#" + bd[i].Diemgiuaky + "#" + bd[i].Diemcuoiky + "#" + bd[i].Hanhkiemky + "#" + bd[i].Hocky + "#" + bd[i].Namhoc + "#" + bd[i].Diemtk);
            }
            sw.Close();
        }
    }
}
