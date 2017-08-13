using System;
using System.Linq;
using System.Text;
using QLHS.Entities;
using QLHS.Utility;
namespace QLHS.Business.Service_Interface
{
    public interface IDangNhapBLL
    {
        List<DangNhap> LayUP();
        void ThemUP(DangNhap up);
        void XoaUP(string user);
        bool KTnick(string user, string pass);
        bool KTuser(string user);
    }
}
