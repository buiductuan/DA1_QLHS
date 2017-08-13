using System;
using System.Linq;
using System.Text;
using QLHS.Entities;
using QLHS.Utility;
namespace QLHS.DataAccessLayer.Service_Interface
{
    public interface  IDangNhapDAL
    {
        List<DangNhap> GetAllData();
        void Insert(DangNhap up);
        void Update(List<DangNhap> listdn);
    }
}
