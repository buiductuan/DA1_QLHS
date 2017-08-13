using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLHS.Entities
{
   public class DangNhap
    {
        private string user, pass;
        public DangNhap() { }
        public DangNhap(DangNhap t2)
        {
            this.user = string.Copy(t2.user);
            this.pass = string.Copy(t2.pass);
        }
        public DangNhap(string user,string pass)
        {
            this.user = user;
            this.pass = pass;
        }
        public string User
        {
            get
            {
                return user;
            }
            set
            {
                if (user != "") user = value;
            }
        }
        public string Pass
        {
            get
            {
                return pass;
            }
            set
            {
                if (pass != "") pass = value;
            }
        }
    }
}
