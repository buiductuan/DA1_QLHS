using System;
using System.Linq;
using System.Text;
using QLHS.Utility;
using QLHS.Entities;
namespace QLHS.Business.Service_Interface
{
    public interface IHocSinhBLL
    {
        List<HocSinh> LayDlhs();
        void Themhs(HocSinh hs);
        void Suahs(HocSinh hs);
        void Xoahs(string mahs);
        //
        bool KTmahs(string mahs);
        bool KTten(string tenhs);
        bool KTnamhoc(string namhoc);
        bool KTtentk(string tenhs);
        bool KTmalop(string malop);
        //
        int demhs(string malop);
        int demhsnam(string malop);
        int demhsnu(string malop);
        string laymalop(string mahs);
        int demhslop1(string malop1, string malop2);
        int demhslop2(string malop1, string malop2);
        int demhslop3(string malop1, string malop2);
        int demhslop4(string malop1, string malop2);
        int demhslop5(string malop1, string malop2);
        //
        string laytenhocsinh(string mahs);
        List<HocSinh> Timhs(HocSinh hs);
    }
}
