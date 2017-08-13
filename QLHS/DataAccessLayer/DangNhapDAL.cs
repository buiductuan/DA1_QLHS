using System;
using System.Linq;
using System.Text;
using System.IO;
using QLHS.Entities;
using QLHS.Utility;
using QLHS.DataAccessLayer.Service_Interface;
namespace QLHS.DataAccessLayer
{
 public class DangNhapDAL:IDangNhapDAL
    {
     private string filetxt = @"User\UP.txt";
     public  List<DangNhap> GetAllData()
        {
            List<DangNhap> dn = new List<DangNhap>();
            StreamReader sr = File.OpenText(filetxt);
            string s = sr.ReadLine();
            while (s != null)
            {
                if (s != "")
                {
                    string[] a = s.Split('#');
                    dn.Add(new DangNhap(a[0], a[1]));
                }
                s = sr.ReadLine();
            }
            sr.Close();
            return dn;
        }
        public void Insert(DangNhap up)
        {
            StreamWriter sw = File.AppendText(filetxt);
            sw.WriteLine();
            sw.Write(up.User + "#" + up.Pass);
            sw.Close();
        }
        public void Update(List<DangNhap> listdn)
        {
            StreamWriter sw = File.CreateText(filetxt);
            for(int i = 0; i < listdn.Count; ++i)
            {
                sw.WriteLine(listdn[i].User + "#" + listdn[i].Pass);
            }
            sw.Close();
        }
    }
}
