using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLHS.Entities
{
   public class Lop
    {
        #region Cac thanh phan du lieu
        private string malop;
        private string tenlop;
        private byte siso;
        private string magv;
        #endregion

        #region Cac thuoc tinh
        public string Malop
        {
            get
            {
                return malop;
            }
            set
            {
                if (malop != "") malop = value;
            }
        }
        public string Tenlop
        {
            get
            {
                return tenlop;
            }
            set
            {
                if (tenlop != "") tenlop = value;
            }
        }
        public byte Siso
        {
            get
            {
                return siso;
            }
            set
            {
                if (value >= 25 && value <= 36) siso = value;
            }
        }
        public string Magv
        {
            get
            {
                return magv;
            }
            set
            {
                if (magv != "") magv = value;
            }
        }
        #endregion

        #region Cac phuong thuc
        public Lop() { }
        public Lop(string malop, string tenlop, byte siso,string magv)
        {
            this.malop = malop;
            this.tenlop = tenlop;
            this.siso = siso;
            this.magv = magv;
        }
        public Lop(Lop t2) // Phương thức thiết lập sao chép
        {
            this.malop = string.Copy(t2.malop);
            this.tenlop = string.Copy(t2.tenlop);
            this.siso = t2.siso;
            this.magv = string.Copy(t2.magv);
        }
        #endregion

    }
}
