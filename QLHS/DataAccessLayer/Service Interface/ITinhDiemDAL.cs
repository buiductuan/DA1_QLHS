using System;
using System.Linq;
using System.Text;
using QLHS.Utility;
using QLHS.Entities;
namespace QLHS.DataAccessLayer.Service_Interface
{
    public interface ITinhDiemDAL
    {
        List<TinhDiem> GetAllData();
        void Insert(TinhDiem td);
    }
}
