using System;
using System.Linq;
using System.Text;
using QLHS.Utility;
using QLHS.Entities;
namespace QLHS.Business.Service_Interface
{
    public interface IBangDiemBLL
    {
        List<BangDiem> LayDlbd();
        void Thembd(BangDiem bd);
        void Suabd(BangDiem bd);
        void Xoabd(string mahs,string malop,string mamon,string hocky);
        void XoaAll(string mahs);

        bool KTbd(string mahs,string malop,string mamon,string hocky);
        bool KTmahs(string mahs);
        bool KTmamon(string mamon);
        bool KThockycodiem(string mahs,string hocky);
        bool KThocky2(string hocky);

        int demhanhkiem1t(string malop1, string malop2);
        int demmon(string mahs);
        double diemtkmontoan1(string mahs);
        double diemtkmontv1(string mahs);
        double diemtkmontoan2(string mahs);
        double diemtkmontv2(string mahs);

        double Tinhdiemtbky1(string mahs);
        double Tinhdiemtbky2(string mahs);
        double Tinhdiemtbcn(string mahs);

       // string layhocky(string mahs);
        string layhanhkiem1(string mahs);
        string layhanhkiem2(string mahs);
        List<BangDiem> Timbd(BangDiem bd);
    }
}
