using System;
using System.Linq;
using System.Text;

namespace QLHS.Entities
{
   public class TinhDiem
    {
        #region  thành phần dữ liệu
        private string mahs;
        private string hocky;
        private double diemtb;
        #endregion
        #region các thuộc tính
        public  string Mahs
        {
            get
            {
                return mahs;
            }
            set
            {
                if (value != "") mahs = value;
            }
        }
        public string Hocky
        {
            get
            {
                return hocky;
            }
            set
            {
                if (value != "") hocky = value;
            }
        }
        public double Diemtb
        {
            get
            {
                return diemtb;
            }
            set
            {
                if (value >= 0 && value <= 10) diemtb = value;
            }
        }
        #endregion
        #region các phương thức
        public TinhDiem() { }
        public TinhDiem(string mahs, string hocky, double diemtb)
        {
            this.mahs = mahs;
            this.hocky = hocky;
            this.diemtb = diemtb;
        }
        public TinhDiem(TinhDiem t2)
        {
            this.mahs = string.Copy(t2.mahs);
            this.hocky = string.Copy(t2.hocky);
            this.diemtb = t2.diemtb;
        }
        #endregion
    }
}
