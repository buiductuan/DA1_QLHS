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
   public class LopBLL:ILopBLL
    {
        private ILopDAL lopDA = new LopDAL();
        public List<Lop> LayDlLop()
        {
            return lopDA.GetAllData();
        }
        public void ThemLop(Lop lop)
        {
            if (lop.Malop != "" && lop.Tenlop != "" && lop.Magv != "")
            {
                lopDA.Insert(lop);
            }
            else
                throw new Exception(" Du lieu sai ");
        }
        public void SuaLop(Lop lop)
        {
            int i;
            List<Lop> list = lopDA.GetAllData();
            for (i = 0; i < list.Count; ++i)
            {
                if (list[i].Malop == lop.Malop) break;
            }
            if (i < list.Count)
            {
                list.RemoveAt(i);
                list.Add(lop, i);
                lopDA.Update(list);
            }
            else
                throw new Exception(" Du lieu sai ");
        }
        public int demlop()
        {
            List<Lop> listl = lopDA.GetAllData();
            int d = 0;
            for(int i = 0; i < listl.Count; ++i)
            {
                d++;
            }
            return d;
        }
        public void XoaLop(string malop)
        {
            int i;
            List<Lop> list = lopDA.GetAllData();
            for (i = 0; i < list.Count; ++i)
            {
                if (list[i].Malop == malop) break;
            }
            if (i < list.Count)
            {
                list.RemoveAt(i);
                lopDA.Update(list);
            }
            else
                throw new Exception(" Du lieu sai ");
        }
        public byte laysiso(string malop)
        {
            List<Lop> list = lopDA.GetAllData();
            byte s = 0;
            for(int i = 0; i < list.Count; ++i)
            {
                if (list[i].Malop == malop)
                {
                    s = list[i].Siso;
                }
            }
            return s;
        }
        public bool KTmalop(string malop)
        {
            List<Lop> list = lopDA.GetAllData();
            bool kt = true;
            for (int i = 0; i < list.Count; ++i)
            {
                if (list[i].Malop == malop)
                {
                    kt = false; break;
                }
            }
            return kt;
        }
        public bool KTmagvL(string magv)
        {
            List<Lop> list = lopDA.GetAllData();
            bool kt = true;
            for(int i = 0; i < list.Count; ++i)
            {
                if (string.Compare(list[i].Magv,magv)==0)
                {
                    kt = false;
                    break;
                }
            }
            return kt;
        }
        public string laytenlop(string malop)
        {
            List<Lop> list = lopDA.GetAllData();
            string s = "";
            for(int i = 0; i < list.Count; ++i)
            {
                if (list[i].Malop == malop)
                {
                    s = list[i].Tenlop;
                }
            }
            return s;
        }
        public string laymagv(string malop)
        {
            List<Lop> list = lopDA.GetAllData();
            string s = "";
            for (int i = 0; i < list.Count; ++i)
            {
                if (list[i].Malop == malop)
                {
                    s = list[i].Magv;
                }
            }
            return s;
        }
        public bool KTtenlop(string tenlop)
        {
            List<Lop> list = lopDA.GetAllData();
            bool kt = true;
            for(int i = 0; i < list.Count; ++i)
            {
                if (string.Compare(list[i].Tenlop,tenlop)==0)
                {
                    kt = false;
                    break;
                }
            }
            return kt;
        }
        public List<Lop> TimLop(Lop lop)
        {
            List<Lop> list = lopDA.GetAllData();
            List<Lop> kq = new List<Lop>();
            if (lop.Malop == null && lop.Tenlop == null)
            {
                return kq = list;
            }
            if (lop.Malop != null && lop.Tenlop == null)
            {
                for (int i = 0; i < list.Count; ++i)
                {
                    if (list[i].Malop.IndexOf(lop.Malop) >= 0)
                    {
                        kq.Add(new Lop(list[i]));
                    }
                }
            }
            else
            {
                if (lop.Malop == null && lop.Tenlop != null)
                {
                    for (int i = 0; i < list.Count; ++i)
                    {
                        if (list[i].Malop.IndexOf(lop.Malop) >= 0)
                        {
                            kq.Add(new Lop(list[i]));
                        }
                    }
                }
                else return kq = null;
            }
            return kq;
        }
    }
}
