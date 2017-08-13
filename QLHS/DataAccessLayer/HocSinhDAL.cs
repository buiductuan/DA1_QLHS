using System;
using System.Linq;
using System.Text;
using QLHS.Entities;
using QLHS.Utility;
using QLHS.DataAccessLayer.Service_Interface;
using System.IO;
namespace QLHS.DataAccessLayer
{
   public class HocSinhDAL:IHocSinhDAL
    {
        private string filetxt = @"Data\HocSinh.txt";
        public List<HocSinh> GetAllData()
        {
            List<HocSinh> hs = new List<HocSinh>();
            StreamReader sr = File.OpenText(filetxt);
            string s = sr.ReadLine();
            while (s != null)
            {
                if (s != "")
                {
                    string[] a = s.Split('#');
                    hs.AddHead(new HocSinh(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7]));
                }
                s = sr.ReadLine();
            }
            sr.Close();
            return hs;
        }
        public void Insert(HocSinh hs)
        {
            StreamWriter sw = File.AppendText(filetxt);
            sw.WriteLine();
            sw.Write(hs.Mahs + "#" + hs.Tenhs + "#" + hs.Ngaysinh + "#" + hs.Gioitinh + "#" + hs.Diachi + "#" + hs.Sdtbome + "#" + hs.Namhoc + "#" + hs.Malop);
            sw.Close();
        }
        public void Update(List<HocSinh> hs)
        {
            StreamWriter sw = File.CreateText(filetxt);
            for(int i = 0; i < hs.Count; ++i)
            {
                sw.WriteLine(hs[i].Mahs + "#" + hs[i].Tenhs + "#" + hs[i].Ngaysinh + "#" + hs[i].Gioitinh + "#" + hs[i].Diachi + "#" + hs[i].Sdtbome + "#" + hs[i].Namhoc + "#" + hs[i].Malop);
            }
            sw.Close();
        }
        public void BackUp(List<HocSinh> hs)
        {
            StreamWriter sb = File.AppendText(@"BackUp\HS_BackUp.txt");
            DateTime dt = DateTime.Now;
            sb.WriteLine(" -Thời gian sao lưu : " + dt.ToString("dd/MM/yyyy"));
            for(int i = 0; i < hs.Count; ++i)
            {
                sb.WriteLine(hs[i].Mahs + "#" + hs[i].Tenhs + "#" + hs[i].Ngaysinh + "#" + hs[i].Gioitinh + "#" + hs[i].Diachi + "#" + hs[i].Sdtbome + "#" + hs[i].Namhoc + "#" + hs[i].Malop);
            }
            sb.Close();
        }
        public void SearchHS(List<HocSinh> hs)
        {
            StreamWriter sb = File.AppendText(@"Search\Search_HS.txt");
            DateTime dt = DateTime.Now;
            sb.WriteLine(" -Thời gian tìm kiếm : " + dt.ToString("dd/MM/yyyy"));
            for (int i = 0; i < hs.Count; ++i)
            {
                sb.WriteLine(hs[i].Mahs + "#" + hs[i].Tenhs + "#" + hs[i].Ngaysinh + "#" + hs[i].Gioitinh + "#" + hs[i].Diachi + "#" + hs[i].Sdtbome + "#" + hs[i].Namhoc + "#" + hs[i].Malop);
            }
            sb.Close();
        }
    }
}
