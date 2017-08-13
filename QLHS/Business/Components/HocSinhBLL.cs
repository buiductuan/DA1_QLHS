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
  public  class HocSinhBLL : IHocSinhBLL
    {
        private IHocSinhDAL hsDA = new HocSinhDAL();
        public List<HocSinh> LayDlhs()
        {
            return hsDA.GetAllData();
        }
        public void Themhs(HocSinh hs)
        {
            if (hs.Mahs != "" && hs.Tenhs != "" && hs.Ngaysinh != "" && hs.Gioitinh != "" && hs.Diachi != "" && hs.Sdtbome != "" && hs.Namhoc != "" && hs.Malop != "")
            {
                hs.Tenhs = QLHS.Utility.CongCu.ChuanHoaXau(hs.Tenhs);
                hs.Diachi = QLHS.Utility.CongCu.ChuanHoaXau(hs.Diachi);
                hs.Gioitinh = QLHS.Utility.CongCu.ChuanHoaXau(hs.Gioitinh);
                hsDA.Insert(hs);
            }
            else
                throw new Exception(" Du lieu sai ");
        }
        public void Suahs(HocSinh hs)
        {
            int i;
            List<HocSinh> list = hsDA.GetAllData();
            for( i = 0; i < list.Count; ++i)
            {
                if (list[i].Mahs == hs.Mahs) break;
            }
            if (i < list.Count)
            {
                list.RemoveAt(i);
                list.Add(hs, i);
                hsDA.Update(list);
            }
            else
                throw new Exception("  Du lieu sai ");
        }
        public void Xoahs(string mahs)
        {
            int i;
            List<HocSinh> list = hsDA.GetAllData();
            for(i = 0; i < list.Count; ++i)
            {
                if (list[i].Mahs == mahs) break;
            }
            if (i < list.Count)
            {
                list.RemoveAt(i);
                hsDA.Update(list);
            }
            else
                throw new Exception(" Du lieu sai ");

        }
        public string laymalop(string mahs)
        {
            List<HocSinh> list = hsDA.GetAllData();
            string s="";
            for(int i = 0; i < list.Count; ++i)
            {
                if (list[i].Mahs == mahs)
                {
                    s = list[i].Malop;
                }
            }
            return s;
        }
        public bool KTmahs(string mahs)
        {
            List<HocSinh> list = hsDA.GetAllData();
            bool kt = true;
            for (int i = 0; i < list.Count; ++i)
            {
                if (list[i].Mahs == mahs)
                {
                    kt = false; break;
                }
                else
                {
                    if (mahs == "")
                    {
                        kt = false; break;
                    }
                }
            }
            return kt;

        }
        public bool KTten(string tenhs)
        {
            bool kt = true;
            for (int i = 0; i < tenhs.Length; ++i)
            {
                if (tenhs[i] == '0' || tenhs[i] == '1' || tenhs[i] == '2' || tenhs[i] == '3' || tenhs[i] == '4' || tenhs[i] == '5' || tenhs[i] == '6' || tenhs[i] == '7' || tenhs[i] == '8' || tenhs[i] == '9')
                {
                    kt = false; break;
                }
            }
                return kt;
        }
        public bool KTtentk(string tenhs)
        {
            List<HocSinh> list = hsDA.GetAllData();
            bool kt = true;
            for(int i = 0; i < list.Count; ++i)
            {
                if (list[i].Tenhs.ToLower() == tenhs.ToLower())
                {
                    kt = false;
                    break;
                }
            }
            return kt;
        }
        public bool KTmalop(string malop)
        {
            List<HocSinh> list = hsDA.GetAllData();
            bool kt = true;
            for(int i = 0; i < list.Count; ++i)
            {
                if (list[i].Malop == malop)
                {
                    kt = false;
                    break;
                }
            }
            return kt;
        }
        public bool KTnamhoc(string namhoc)
        {
            List<HocSinh> list = hsDA.GetAllData();
            bool kt = false;
            for(int i = 0; i < list.Count; ++i)
            {
                if (list[i].Namhoc == namhoc)
                {
                    kt = true;
                    break;
                }
            }
            return kt;
        }
        public int demhs(string malop)
        {
            List<HocSinh> list = hsDA.GetAllData();
            int d = 0;
            for(int i = 0; i < list.Count; ++i)
            {
                if (list[i].Malop.ToLower() == malop.ToLower())
                {
                    d++;
                }
            }
            return d;
        }
        public int demhsnam(string malop)
        {
            List<HocSinh> list = hsDA.GetAllData();
            int d = 0;
            for (int i = 0; i < list.Count; ++i)
            {
                if (list[i].Malop.ToLower() == malop.ToLower())
                {
                    if (list[i].Gioitinh.ToLower() == "Nam".ToLower())
                    {
                        d++;
                    }
                }
            }
            return d;
        }
        public int demhsnu(string malop)
        {
            List<HocSinh> list = hsDA.GetAllData();
            int d = 0;
            for (int i = 0; i < list.Count; ++i)
            {
                if (list[i].Malop.ToLower() == malop.ToLower())
                {
                    if (list[i].Gioitinh.ToLower() == "Nu".ToLower())
                    {
                        d++;
                    }
                }
            }
            return d;
        }
//
        public int demhslop1(string malop1, string malop2)
        {
            List<HocSinh> lisths = hsDA.GetAllData();
            malop1 = "L1";
            malop2 = "L2";
            int d = 0;
            for (int i = 0; i < lisths.Count; ++i)
            {
                if (lisths[i].Malop==malop1||lisths[i].Malop==malop2)
                {
                        d++;
                }
            }
            return d;
        }
        public int demhslop2(string malop1, string malop2)
        {
            List<HocSinh> lisths = hsDA.GetAllData();
            int d = 0;
            malop1 = "L3";
            malop2 = "L4";
            for (int i = 0; i < lisths.Count; ++i)
            {
                if (lisths[i].Malop == malop1 || lisths[i].Malop == malop2)
                {
                    d++;
                }
            }
            return d;
        }
        public int demhslop3(string malop1, string malop2)
        {
            List<HocSinh> lisths = hsDA.GetAllData();
            int d = 0;
            malop1 = "L6";
            malop2 = "L5";
            for (int i = 0; i < lisths.Count; ++i)
            {
                if (lisths[i].Malop == malop1 || lisths[i].Malop == malop2)
                {
                    d++;
                }
            }
            return d;
        }
        public int demhslop4(string malop1, string malop2)
        {
            List<HocSinh> lisths = hsDA.GetAllData();
            int d = 0;
            malop1 = "L7";
            malop2 = "L8";
            for (int i = 0; i < lisths.Count; ++i)
                {
                    if (lisths[i].Malop == malop1 || lisths[i].Malop == malop2)
                    {
                        d++;
                    }
                }
            return d;
        }
        public  int demhslop5(string malop1, string malop2)
        {
            List<HocSinh> lisths = hsDA.GetAllData();
            int d = 0;
            malop1 = "L9";
            malop2 = "L10";
            for (int i = 0; i < lisths.Count; ++i)
            {
                if (lisths[i].Malop == malop1 || lisths[i].Malop == malop2)
                {
                    d++;
                }
            }
            return d;
        }

//
        public string laytenhocsinh(string mahs)
        {
            string s = "";
            List<HocSinh> list = hsDA.GetAllData();
            for(int i=0; i < list.Count; i++)
            {
                if (list[i].Mahs == mahs)
                {
                    s = list[i].Tenhs;
                }
            }
            return s;
        }
        public List<HocSinh> Timhs(HocSinh hs)
        {
            List<HocSinh> list = hsDA.GetAllData();
            List<HocSinh> kq = new List<HocSinh>();
            if (hs.Mahs == null && hs.Tenhs == null&&hs.Malop==null)
            {
                return kq = list;
            }
            if (hs.Mahs != null && hs.Tenhs == null&&hs.Malop==null)
            {
                for(int i = 0; i < list.Count; ++i)
                {
                    if (list[i].Mahs.IndexOf(hs.Mahs) >= 0)
                    {
                        kq.Add(new HocSinh(list[i]));
                    }
                }
            }
            else
            {
                if (hs.Mahs == null && hs.Tenhs != null&&hs.Malop==null)
                {
                    for (int i = 0; i < list.Count; ++i)
                    {
                        if (list[i].Tenhs.IndexOf(hs.Tenhs) >= 0)
                        {
                            kq.Add(new HocSinh(list[i]));
                        }
                    }
                }
                else
                {
                    if (hs.Mahs == null && hs.Tenhs == null && hs.Malop != null)
                    {
                        for (int i = 0; i < list.Count; ++i)
                        {
                            if (list[i].Malop.IndexOf(hs.Malop) >= 0)
                            {
                                kq.Add(new HocSinh(list[i]));
                            }
                        }
                    }
                    else return kq = null;
                }
            }
            return kq;
        }

    }
}
