using System;
using System.Linq;
using System.Text;
using QLHS.Utility;
using QLHS.Entities;
namespace QLHS.Business.Service_Interface
{
    public interface ITinhDiemBLL
    {
        List<TinhDiem> LayDLTD();
        void themdiem(TinhDiem td);
        bool kiemtradiemky1(string mahs);
        bool kiemtradiemky2(string mahs);
        bool kiemtradiemcanam(string mahs);
        string layhocky(string mahs);
        string layhocky2(string mahs);
    }
}
