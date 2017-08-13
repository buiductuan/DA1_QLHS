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
   public class GVCNBLL :IGVCNBLL
    {
        private IGVCNDAL gvDA = new GVCNDAL();
        public List<GVCN> LayDlgv()
        {
            return gvDA.GetAllData();
        }
        public void Themgv(GVCN gv)
        {
            if (gv.Magv != "" && gv.Tengv != "" && gv.Diachi != "" && gv.Sdtgv != "")
            {
                gv.Tengv = QLHS.Utility.CongCu.ChuanHoaXau(gv.Tengv);
                gv.Diachi = QLHS.Utility.CongCu.ChuanHoaXau(gv.Diachi);
                gvDA.Insert(gv);
            }
            else
                throw new Exception(" Du lieu sai ");
        }
        public void Suagv(GVCN gv)
        {
            int i;
            List<GVCN> list = gvDA.GetAllData();
            for (i = 0; i < list.Count; ++i)
            {
                if (list[i].Magv == gv.Magv) break;
            }
            if (i < list.Count)
            {
                list.RemoveAt(i);
                list.Add(gv, i);
                gvDA.Update(list);
            }
            else
                throw new Exception(" Du lieu sai ");
        }
        public void Xoagv(string magv)
        {
            int i;
            List<GVCN> list = gvDA.GetAllData();
            for (i = 0; i < list.Count; ++i)
            {
                if (list[i].Magv == magv) break;
            }
            if (i < list.Count)
            {
                list.RemoveAt(i);
                gvDA.Update(list);
            }
            else
                throw new Exception(" Du lieu sai ");
        }
        public bool KTmagv(string magv)
        {
            List<GVCN> list = gvDA.GetAllData();
            bool kt = true;
            for (int i = 0; i < list.Count; ++i)
            {
                if (list[i].Magv == magv)
                {
                    kt = false; break;
                }
            }
            return kt;

        }
        public bool KTtengv(string tengv)
        {
            bool kt = false;
            for(int i = 0; i < tengv.Length; ++i)
            {
                if (tengv[i] == '0' || tengv[i] == '1' || tengv[i] == '2' || tengv[i] == '3' || tengv[i] == '4' || tengv[i] == '5' || tengv[i] == '6' || tengv[i] == '7' || tengv[i] == '8' || tengv[i] == '9')
                {
                    kt = true;
                    break;
                }
            }
            return kt;
        }
        public bool KTtengvtk(string tengv)
        {
            List<GVCN> list = gvDA.GetAllData();
            bool kt = true;
            for(int i = 0; i < list.Count; ++i)
            {
                if (list[i].Tengv.ToLower() == tengv.ToLower())
                {
                    kt = false;
                    break;
                }
            }
            return kt;
        }
        public string laytengv(string magv)
        {
            List<GVCN> list = gvDA.GetAllData();
            string s = "";
            for(int i = 0; i < list.Count; ++i)
            {
                if (list[i].Magv == magv)
                {
                    s = list[i].Tengv;
                }
            }
            return s;
        }
        public List<GVCN> Timgv(GVCN gv)
        {
            List<GVCN> list = gvDA.GetAllData();
            List<GVCN> kq = new List<GVCN>();
            if (gv.Magv == null && gv.Tengv == null)
            {
                return kq = list;
            }
            if (gv.Magv != null && gv.Tengv == null)
            {
                for(int i = 0; i < list.Count; ++i)
                {
                    if (list[i].Magv==gv.Magv)
                    {
                        kq.Add(new GVCN(list[i]));
                    }
                }
            }
            else
            {
                if (gv.Magv == null && gv.Tengv != null)
                {
                    for (int i = 0; i < list.Count; ++i)
                    {
                        if (list[i].Tengv.IndexOf(gv.Tengv) >= 0)
                        {
                            kq.Add(new GVCN(list[i]));
                        }
                    }
                }
                else return kq = null;
            }
            return kq;
        }
    }
}
