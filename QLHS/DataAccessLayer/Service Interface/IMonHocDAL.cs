using System;
using System.Linq;
using System.Text;
using QLHS.Utility;
using QLHS.Entities;
namespace QLHS.DataAccessLayer.Service_Interface
{
    public interface IMonHocDAL
    {
        List<MonHoc> GetAllData();
        void Insert(MonHoc mh);
        void Update(List<MonHoc> mh);
        void BackUp(List<MonHoc> mh);
    }
}
