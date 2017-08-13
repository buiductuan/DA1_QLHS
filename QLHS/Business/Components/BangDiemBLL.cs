using System;
using System.Linq;
using System.Text;
using QLHS.Utility;
using QLHS.Entities;
using QLHS.Business.Service_Interface;
using QLHS.DataAccessLayer;
using QLHS.DataAccessLayer.Service_Interface;

namespace QLHS.Business.Components
{
   public class BangDiemBLL :IBangDiemBLL
    {
        private IBangDiemDAL bdDA = new BangDiemDAL();
        private IHocSinhDAL hsDA = new HocSinhDAL();
        public List<BangDiem> LayDlbd()
        {
            return bdDA.GetAllData();
        }
        public void Thembd(BangDiem bd)
        {
            if (bd.Mahs != "" && bd.Malop != ""&&bd.Mamon!="")
            {
                bd.Hanhkiemky = QLHS.Utility.CongCu.ChuanHoaXau(bd.Hanhkiemky);
                bdDA.Insert(bd);
            }
            else
                throw new Exception(" Du lieu sai ");
        }
        public void Suabd(BangDiem bd)
        {
            int i;
            List<BangDiem> list = bdDA.GetAllData();
            for (i = 0; i < list.Count; ++i)
            {
                if (list[i].Mahs == bd.Mahs) break;
            }
            if (i < list.Count)
            {
                list.RemoveAt(i);
                list.Add(bd, i);
                bdDA.Update(list);
            }
            else
                throw new Exception(" Du lieu sai ");
        }
        public void Xoabd(string mahs,string malop,string mamon,string hocky)
        {
            int i;
            List<BangDiem> list = bdDA.GetAllData();
            for (i = 0; i < list.Count; ++i)
            {
                if (list[i].Mahs == mahs&&list[i].Malop.ToLower()==malop.ToLower()&&list[i].Mamon==mamon&&list[i].Hocky==hocky) break;
            }
            if (i < list.Count)
            {
                list.RemoveAt(i);
                bdDA.Update(list);
            }
            else
                throw new Exception(" Du lieu sai ");
        }
        public void XoaAll(string mahs)
        {
            int i;
            List<BangDiem> list = bdDA.GetAllData();
            for (i = 0; i < list.Count; ++i)
            {
                if (i < list.Count)
                {
                    while (list[i].Mahs == mahs)
                    {
                        list.RemoveAt(i);
                        bdDA.Update(list);
                    }
                }
            }
        }
        public int demhanhkiem1t(string malop1,string malop2)
        {
            List<BangDiem> listbd = bdDA.GetAllData();
            List<HocSinh> lisths = hsDA.GetAllData();
            int dt = 0;
            int j;
            for ( j = 0; j < lisths.Count; j++)
            {
                if (lisths[j].Malop == malop1 && lisths[j].Malop == malop2)
                {
                    break;
                }
            }
            if (j < listbd.Count)
            {
                if (listbd[j].Hocky == "I")
                {
                    if (listbd[j].Hanhkiemky.ToLower() == "tot".ToLower())
                    {
                        dt++;
                    }
                }
                j++;
            }
            return dt;
        }
        public List<BangDiem> Timbd(BangDiem bd)
        {
            List<BangDiem> list = bdDA.GetAllData();
            List<BangDiem> kq = new List<BangDiem>();
            if (bd.Mahs == null)
            {
                return kq = list;
            }
            else
            {
                    for (int i = 0; i < list.Count; ++i)
                    {
                    if (list[i].Mahs.LastIndexOf(bd.Mahs) >= 0)
                    {
                        kq.Add(new BangDiem(list[i]));
                    }
                    }
            }
            return kq;
        }
        public bool KTbd(string mahs,string malop,string mamon,string hocky)
        {
            List<BangDiem> listbd = bdDA.GetAllData();
            bool kt = false;
            for(int i = 0; i < listbd.Count; ++i)
            {
                if (listbd[i].Mahs == mahs&&listbd[i].Malop==malop&&listbd[i].Mamon==mamon&&listbd[i].Hocky==hocky)
                {
                    kt = true;
                    break;
                }
            }
            return kt;
        }
        public bool KThockycodiem(string mahs,string hocky)
        {
            List<BangDiem> listbd = bdDA.GetAllData();
            bool kt = false;
            for (int i = 0; i < listbd.Count; ++i)
            {
                if (listbd[i].Mahs == mahs)
                {
                    if (listbd[i].Hocky == hocky)
                    {
                        if (listbd[i].Diemtk != 0)
                        {
                            kt = true;
                            break;
                        }
                    }
                }
            }
            return kt;
        }
        public bool KTmahs(string mahs)
        {
            List<BangDiem> listbd = bdDA.GetAllData();
            bool kt = false;
            for (int i = 0; i < listbd.Count; ++i)
            {
                if (listbd[i].Mahs==mahs)
                {
                    kt = true;
                    break;
                }
            }
            return kt;
        }
        public bool KTmamon(string mamon)
        {
            List<BangDiem> listbd = bdDA.GetAllData();
            bool kt = false;
            for (int i = 0; i < listbd.Count; ++i)
            {
                if (listbd[i].Mamon==mamon)
                {
                    kt = true;
                    break;
                }
            }
            return kt;
        }
        public int demmon(string mahs)
        {
            List<BangDiem> list = bdDA.GetAllData();
            int d = 0;
            for (int i = 0; i < list.Count; ++i)
            {
                if (list[i].Mahs == mahs)
                {
                    if (list[i].Diemtk!=0)
                    {
                        d++;
                    }
                }
            }
            return d;
        }
        public double diemtkmontoan1(string mahs)
        {
            List<BangDiem> list = bdDA.GetAllData();
            double tb = 0;
            for (int i = 0; i < list.Count; ++i)
            {
                if (list[i].Mahs == mahs)
                {
                    if (list[i].Hocky == "I"&&list[i].Mamon=="T")
                    {
                        tb = list[i].Diemtk;
                    }
                }
            }
            return tb;
        }
        public double diemtkmontv1(string mahs)
        {
            List<BangDiem> list = bdDA.GetAllData();
            double tb = 0;
            for (int i = 0; i < list.Count; ++i)
            {
                if (list[i].Mahs == mahs)
                {
                    if (list[i].Hocky == "I" && list[i].Mamon == "TV")
                    {
                        tb = list[i].Diemtk;
                    }
                }
            }
            return tb;
        }
        public double diemtkmontv2(string mahs)
        {
            List<BangDiem> list = bdDA.GetAllData();
            double tb = 0;
            for (int i = 0; i < list.Count; ++i)
            {
                if (list[i].Mahs == mahs)
                {
                    if (list[i].Hocky == "II" && list[i].Mamon == "TV")
                    {
                        tb = list[i].Diemtk;
                    }
                }
            }
            return tb;
        }
        public double diemtkmontoan2(string mahs)
        {
            List<BangDiem> list = bdDA.GetAllData();
            double tb = 0;
            for (int i = 0; i < list.Count; ++i)
            {
                if (list[i].Mahs == mahs)
                {
                    if (list[i].Hocky == "II" && list[i].Mamon == "T")
                    {
                        tb = list[i].Diemtk;
                    }
                }
            }
            return tb;
        }
        public double Tinhdiemtbky1(string mahs)
        {
            List<BangDiem> list = bdDA.GetAllData();
            double tb = 0;
            for(int i = 0; i < list.Count; ++i)
            {
                if (list[i].Mahs == mahs)
                {
                    if (list[i].Hocky == "I")
                    {
                        tb = (double)Math.Round((diemtkmontoan1(mahs) + diemtkmontv1(mahs)) / 2,2);
                    }
                }
            }
            return tb;
        }
        public double Tinhdiemtbky2(string mahs)
        {
            List<BangDiem> list = bdDA.GetAllData();
            double tb = 0;
            for (int i = 0; i < list.Count; ++i)
            {
                if (list[i].Mahs == mahs)
                {
                    if (list[i].Hocky == "II")
                    {
                        tb = (double)Math.Round((diemtkmontoan2(mahs) + diemtkmontv2(mahs)) / 2, 2);
                    }
                }
            }
            return tb;
        }
        public double Tinhdiemtbcn(string mahs)
        {
            List<BangDiem> list = bdDA.GetAllData();
            double tb = 0;
            for (int i = 0; i < list.Count; ++i)
            {
                if (list[i].Mahs == mahs)
                {

                    tb = (double)Math.Round((Tinhdiemtbky1(mahs) + Tinhdiemtbky2(mahs)) / 2, 2);
                }
            }
            return tb;
        }
        public bool KThocky2(string hocky)
        {
            List<BangDiem> listbd = bdDA.GetAllData();
            bool kt = false;
            hocky = "II";
            for(int i = 0; i < listbd.Count; ++i)
            {
                if (listbd[i].Hocky == hocky)
                {
                    kt = true;
                    break;
                }
            }
            return kt;
        }
        public string layhanhkiem1(string mahs)
        {
            List<BangDiem> list = bdDA.GetAllData();
            string s = "";
            for(int i = 0; i < list.Count; ++i)
            {
                if (list[i].Mahs == mahs&&list[i].Hocky=="I")
                {
                    s = list[i].Hanhkiemky;
                }
            }
            return s;
        }
        public string layhanhkiem2(string mahs)
        {
            List<BangDiem> list = bdDA.GetAllData();
            string s = "";
            for (int i = 0; i < list.Count; ++i)
            {
                if (list[i].Mahs == mahs && list[i].Hocky == "II")
                {
                    s = list[i].Hanhkiemky;
                }
            }
            return s;
        }

    }
}
