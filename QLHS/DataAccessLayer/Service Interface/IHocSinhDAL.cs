using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLHS.Entities;
using QLHS.Utility;
namespace QLHS.DataAccessLayer.Service_Interface
{
    public interface IHocSinhDAL
    {
        List<HocSinh> GetAllData();
        void Insert(HocSinh hs);
        void Update(List<HocSinh> hs);
        void BackUp(List<HocSinh> hs);
        void SearchHS(List<HocSinh> hs);
    }
}
