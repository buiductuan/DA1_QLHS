using System;
using System.Linq;
using System.Text;
using QLHS.Utility;
using QLHS.Entities;
namespace QLHS.Business.Service_Interface
{
    public interface IMonHocBLL
    {
        List<MonHoc> LayDLMH();
        void ThemMH(MonHoc mh);
        void SuaMH(MonHoc mh);
        void XoaMH(string mamon);
        bool KTMamon(string mamon);
    }
}
