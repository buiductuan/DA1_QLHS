using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLHS.Entities;
using QLHS.Utility;
namespace QLHS.DataAccessLayer.Service_Interface
{
    public interface ILopDAL
    {
        List<Lop> GetAllData();
        void Insert(Lop lop);
        void Update(List<Lop> lop);
        void BackUp(List<Lop> lop);
    }
}
