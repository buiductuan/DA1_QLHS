using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLHS.Entities
{
   public class HocSinh
    {
        #region Cac thanh phan du lieu
        private string mahs;
        private string tenhs;
        private string ngaysinh;
        private string gioitinh;
        private string diachi;
        private string sdtbome;
        private string namhoc;
        private string malop;
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
        public string Tenhs
        {
            get
            {
                return tenhs;
            }
            set
            {
                if (tenhs != "") tenhs = value;
            }
        }
        public string Ngaysinh
        {
            get
            {
                return ngaysinh;
            }
            set
            {
                if (ngaysinh != "") ngaysinh = value;
            }
        }
        public string Gioitinh
        {
            get
            {
                return gioitinh;
            }
            set
            {
                if (gioitinh != "") gioitinh = value;
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
        public string Sdtbome
        {
            get
            {
                return sdtbome;
            }
            set
            {
                if (sdtbome != "") sdtbome = value;
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
        #endregion

        #region Cac phuong thuc
        public HocSinh()
        {
        }
        public HocSinh(string mahs,string tenhs, string ngaysinh,string gioitinh, string diachi, string sdtbome,string namhoc,string malop)
        {
            this.mahs = mahs;
            this.tenhs = tenhs;
            this.ngaysinh = ngaysinh;
            this.gioitinh = gioitinh;
            this.diachi = diachi;
            this.sdtbome = sdtbome;
            this.namhoc = namhoc;
            this.malop = malop;
        }
        public HocSinh(HocSinh t2) // Phương thức thiết lập sao chép
        {
            this.mahs = string.Copy(t2.mahs);
            this.tenhs = string.Copy(t2.tenhs);
            this.ngaysinh = string.Copy(t2.ngaysinh);
            this.gioitinh = string.Copy(t2.gioitinh);
            this.diachi = string.Copy(t2.diachi);
            this.sdtbome = string.Copy(t2.sdtbome);
            this.namhoc = string.Copy(t2.namhoc);
            this.malop = string.Copy(t2.malop);
        }
        #endregion

    }
}
