using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLHS.Entities;
using QLHS.Utility;

namespace QLHS.DataAccessLayer.Service_Interface
{
    public interface IGVCNDAL
    {
        List<GVCN> GetAllData();
        void Insert(GVCN gv);
        void Update(List<GVCN> gv);
        void BackUp(List<GVCN> gv);
        void SearchGV(List<GVCN> gv);
    }
}
