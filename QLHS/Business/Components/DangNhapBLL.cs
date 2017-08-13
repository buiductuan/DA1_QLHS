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
   public class DangNhapBLL :IDangNhapBLL
    {
        private IDangNhapDAL dnDA = new DangNhapDAL();
        public List<DangNhap> LayUP()
        {
            return dnDA.GetAllData();
        }
        public void XoaUP(string user)
        {
            int i;
            List<DangNhap> listdn = dnDA.GetAllData();
            for( i = 0; i < listdn.Count; ++i)
            {
                if (listdn[i].User == user) break;
            }
            if (i < listdn.Count)
            {
                listdn.RemoveAt(i);
                dnDA.Update(listdn);
            }
            else
                throw new Exception("Du lieu sai ");
        }
        public void ThemUP(DangNhap up)
        {
            if (up.User != "" && up.Pass != "")
            {
                dnDA.Insert(up);
            }
            else
                throw new Exception(" Empty ");
        }
        public bool KTnick(string user,string pass)
        {
            List<DangNhap> list = dnDA.GetAllData();
            bool kt = false;
            for(int i = 0; i < list.Count; ++i)
            {
                if (list[i].User == user && list[i].Pass == pass)
                {
                    kt = true;
                    break;
                }
            }
            return kt;
        }
        public bool KTuser(string user)
        {
            List<DangNhap> list = dnDA.GetAllData();
            bool kt = false;
            for(int i = 0; i < list.Count; ++i)
            {
                if (list[i].User == user)
                {
                    kt = true;
                    break;
                }
            }
            return kt;
        }
    }
}
