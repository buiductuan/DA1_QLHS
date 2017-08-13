using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLHS.Entities
{
  public  class BangDiem
    {
        #region Cac thanh phan du lieu
        private string mahs;
        private string malop;
        private string mamon;
        private double diemgiuaky;
        private double diemcuoiky;
        private double diemtbcn;
        private string hanhkiemky;
        private string hocky;
        private string namhoc;
        #endregion

        #region Cac thuoc tinh
        public string Mahs
        {
            get
            {
                return mahs;
            }
            set
            {
                if (mahs != "") mahs = value;
            }
        }
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
        public string Mamon
        {
            get
            {
                return mamon;
            }
            set
            {
                if (value != "") mamon = value;
            }
        }
        public double Diemgiuaky
        {
            get
            {
                return diemgiuaky;
            }
            set
            {
                if (value>=0&&value<=10) diemgiuaky = value;
            }
        }
        public double Diemcuoiky
        {
            get
            {
                return diemcuoiky;
            }
            set
            {
                if (value >= 0 && value <= 10) diemcuoiky = value;
            }
        }
        public string Hanhkiemky
        {
            get
            {
                return hanhkiemky;
            }
            set
            {
                if (hanhkiemky != "") hanhkiemky = value;
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
                if (hocky != "") hocky = value;
            }
        }
        public string Namhoc
        {
            get
            {
                return namhoc;
            }
            set
            {
                if (namhoc != "") namhoc = value;
            }
        }
        public double Diemtbcn
        {
            get
            {
                return diemtbcn;
            }
            set
            {
                if (value > 0) diemtbcn = value;
            }
        }
        public double Diemtk
        {
            get
            {
                return (double)Math.Round(((diemcuoiky * 2 + diemgiuaky) / 3),2);
            }
        }
        #endregion

        #region Cac phuong thuc
        public BangDiem() { }
        public BangDiem(string mahs, string malop,string mamon, double diemgiuaky, double diemcuoiky, string hanhkiemky, string hocky, string namhoc)
        {
            this.mahs = mahs;
            this.malop = malop;
            this.mamon = mamon;
            this.diemgiuaky = diemgiuaky;
            this.diemcuoiky = diemcuoiky;
            this.hanhkiemky = hanhkiemky;
            this.hocky = hocky;
            this.namhoc = namhoc;
        }
        public BangDiem(BangDiem t2)
        {
            this.mahs = string.Copy(t2.mahs);
            this.malop = string.Copy(t2.malop);
            this.mamon = string.Copy(t2.mamon);
            this.diemgiuaky = t2.diemgiuaky;
            this.diemcuoiky = t2.diemcuoiky;
            this.hanhkiemky = string.Copy(t2.hanhkiemky);
            this.hocky = string.Copy(t2.hocky);
            this.namhoc = string.Copy(t2.namhoc);
        }
        #endregion

    }
}
