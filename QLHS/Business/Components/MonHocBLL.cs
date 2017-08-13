using System;
using System.Linq;
using System.Text;
using QLHS.Entities;
using QLHS.Utility;
using QLHS.DataAccessLayer.Service_Interface;
using QLHS.DataAccessLayer;
using QLHS.Business.Service_Interface;
namespace QLHS.Business.Components
{
   public class MonHocBLL: IMonHocBLL
    {
        private IMonHocDAL mhDA = new MonHocDAL();
        public List<MonHoc> LayDLMH()
        {
            return mhDA.GetAllData();
        }
        public void ThemMH(MonHoc mh)
        {
            if (mh.Mamon != "" && mh.Tenmon != "")
            {
                mh.Tenmon = QLHS.Utility.CongCu.ChuanHoaXau(mh.Tenmon);
                mh.Ghichu = QLHS.Utility.CongCu.ChuanHoaXau(mh.Ghichu);
                mhDA.Insert(mh);
            }
            else
                throw new Exception("Du lieu sai");
        }
        public void SuaMH(MonHoc mh)
        {
            int i;
            List<MonHoc> list = mhDA.GetAllData();
            for (i = 0; i < list.Count; ++i)
            {
                if (list[i].Mamon == mh.Mamon) break;
            }
            if (i < list.Count)
            {
                list.RemoveAt(i);
                list.Add(mh, i);
                mhDA.Update(list);
            }
            else
                throw new Exception("Du lieu sai");
        }
        public void XoaMH(string mamon)
        {
            int i;
            List<MonHoc> list = mhDA.GetAllData();
            for (i = 0; i < list.Count; ++i)
            {
                if (list[i].Mamon == mamon) break;
            }
            if (i < list.Count)
            {
                list.RemoveAt(i);
                mhDA.Update(list);
            }
            else
                throw new Exception("Du lieu sai ");
        }
        public bool KTMamon(string mamon)
        {
            List<MonHoc> list = mhDA.GetAllData();
            bool kt = false;
            for(int i = 0; i < list.Count; ++i)
            {
                if (list[i].Mamon == mamon)
                {
                    kt = true;
                    break;
                }
            }
            return kt;
        }
    }
}
