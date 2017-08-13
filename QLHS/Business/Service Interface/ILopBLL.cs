using System;
using System.Linq;
using System.Text;
using QLHS.Entities;
using QLHS.Utility;
namespace QLHS.Business.Service_Interface
{
    public interface ILopBLL
    {
        List<Lop> LayDlLop();
        void ThemLop(Lop lop);
        void SuaLop(Lop lop);
        void XoaLop(string malop);
        bool KTmalop(string malop);
        bool KTmagvL(string magv);
        bool KTtenlop(string tenlop);
        int demlop();
        string laytenlop(string malop);
        string laymagv(string malop);
        byte laysiso(string malop);
        List<Lop> TimLop(Lop lop);
    }
}
