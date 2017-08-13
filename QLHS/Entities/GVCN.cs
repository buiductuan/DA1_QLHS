using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLHS.Entities
{
  public  class GVCN
    {
        #region Cac thanh phan du lieu
        private string magv;
        private string tengv;
        private string diachi;
        private string sdtgv;
        #endregion

        #region Cac thuoc tinh
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
        public string Tengv
        {
            get
            {
                return tengv;
            }
            set
            {
                if (tengv != "") tengv = value;
            }
        }
        public string Diachi
        {
            get
            {
                return diachi;
            }
            set
            {
                if (diachi != "") diachi = value;
            }
        }
        public string Sdtgv
        {
            get
            {
                return sdtgv;
            }
            set
            {
                if (sdtgv != "") sdtgv = value;
            }
        }

        #endregion

        #region Cac phuong thuc
        public GVCN() { }
        public GVCN(string magv, string tengv, string diachi, string sdtgv)
        {
            this.magv = magv;
            this.tengv = tengv;
            this.diachi = diachi;
            this.sdtgv = sdtgv;
        }
        public GVCN(GVCN t2)
        {
            this.magv = string.Copy(t2.magv);
            this.tengv = string.Copy(t2.tengv);
            this.diachi = string.Copy(t2.diachi);
            this.sdtgv = string.Copy(t2.sdtgv);
        }
        #endregion

    }
}
