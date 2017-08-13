using System;
using System.Linq;
using System.Text;
namespace QLHS.Entities
{
   public  class MonHoc
    {
        #region thành phần dữ liệu
        private string mamon;
        private string tenmon;
        private string ghichu;
        #endregion

        #region Các thuộc tính
        public string Mamon
        {
            get { return mamon; }
            set
            {
                if (value != "") mamon = value;
            }
        }
        public string Tenmon
        {
            get
            {
                return tenmon;
            }
            set
            {
                if (value != "") tenmon = value;
            }
        }
        public string Ghichu
        {
            get
            {
                return ghichu;
            }
            set
            {
                if (value != "") ghichu = value;
            }
        }
        #endregion

        #region Các phương thức
        public MonHoc() { }
        public MonHoc(string mamon,string tenmon,string ghichu)
        {
            this.mamon = mamon;
            this.tenmon = tenmon;
            this.ghichu = ghichu;
        }
        public MonHoc(MonHoc t2)
        {
            this.mamon = string.Copy(t2.mamon);
            this.tenmon = string.Copy(t2.tenmon);
            this.ghichu = string.Copy(t2.ghichu);
        }
        #endregion

    }
}
