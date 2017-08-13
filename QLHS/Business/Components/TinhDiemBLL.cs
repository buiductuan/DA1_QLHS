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
   public class TinhDiemBLL:ITinhDiemBLL
    {
        private ITinhDiemDAL tdDA = new TinhDiemDAL();
        private IBangDiemDAL bdDA = new BangDiemDAL();
        public List<TinhDiem> LayDLTD()
        {
            return tdDA.GetAllData();
        }
        public void themdiem(TinhDiem td)
        {
            if (td.Mahs != "" && td.Hocky != "")
            {
                tdDA.Insert(td);
            }
            else
                throw new Exception("Du lieu sai");
        }
        public bool kiemtradiemky1(string mahs)
        {
            List<TinhDiem> list = tdDA.GetAllData();
            bool kt = false;
            for(int i = 0; i < list.Count; ++i)
            {
                if (list[i].Mahs == mahs)
                {
                    if (list[i].Hocky == "I" && list[i].Diemtb>0)
                    {
                        kt = true;
                        break;
                    }
                }
            }
            return kt;
        }
        public bool kiemtradiemky2(string mahs)
        {
            List<TinhDiem> list = tdDA.GetAllData();
            bool kt = false;
            for (int i = 0; i < list.Count; ++i)
            {
                if (list[i].Mahs == mahs)
                {
                    if (list[i].Hocky == "II" && list[i].Diemtb > 0)
                    {
                        kt = true;
                        break;
                    }
                }
            }
            return kt;
        }
        public bool kiemtradiemcanam(string mahs)
        {
            List<TinhDiem> list = tdDA.GetAllData();
            bool kt = false;
            for (int i = 0; i < list.Count; ++i)
            {
                if (list[i].Mahs == mahs)
                {
                    if (list[i].Hocky.ToLower() == "ca nam".ToLower() && list[i].Diemtb > 0)
                    {
                        kt = true;
                        break;
                    }
                }
            }
            return kt;
        }
        public string layhocky(string mahs)
        {
            List<BangDiem> list = bdDA.GetAllData();
            string kt = "";
            for (int i = 0; i < list.Count; ++i)
            {
                if (list[i].Mahs == mahs&&list[i].Hocky=="I")
                {
                    kt = list[i].Hocky;
                }
            }
            return kt;
        }

        public string layhocky2(string mahs)
        {
            List<BangDiem> list = bdDA.GetAllData();
            string kt = "";
            for (int i = 0; i < list.Count; ++i)
            {
                if (list[i].Mahs == mahs&&list[i].Hocky=="II")
                {
                    kt = list[i].Hocky;
                }
            }
            return kt;
        }
    }
}
