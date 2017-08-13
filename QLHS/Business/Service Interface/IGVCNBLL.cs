using System;
using System.Linq;
using System.Text;
using QLHS.Utility;
using QLHS.Entities;
namespace QLHS.Business.Service_Interface
{
    public interface IGVCNBLL
    {
        List<GVCN> LayDlgv();
        void Themgv(GVCN gv);
        void Suagv(GVCN gv);
        void Xoagv(string magv);
        bool KTmagv(string magv);
        bool KTtengv(string tengv);
        bool KTtengvtk(string tengv);
        string laytengv(string magv);
        List<GVCN> Timgv(GVCN gv);
    }
}
