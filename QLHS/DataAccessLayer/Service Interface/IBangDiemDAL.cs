using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLHS.Entities;
using QLHS.Utility;

namespace QLHS.DataAccessLayer.Service_Interface
{
    public interface IBangDiemDAL
    {
        List<BangDiem> GetAllData();
        void Insert(BangDiem bd);
        void Update(List<BangDiem> bd);
        void BackUp(List<BangDiem> bd);
        void SearchDiem(List<BangDiem> bd);
    }
}
