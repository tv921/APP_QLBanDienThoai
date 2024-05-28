using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCHXM.Class
{
    public class nhacungcap
    {
        private string mancc;
        private string tenncc;
        private string diachi;
        private string sdt;

        public nhacungcap() { }

        public string get_mancc() { return mancc; }
        public string get_tenncc() { return tenncc; }
        public string get_sdt() { return sdt; }
        public string get_diachi() { return diachi; }

        public void set_mancc(string value) { mancc = value; }
        public void set_tenncc(string value) { tenncc = value; }
        public void set_sdt(string value) { sdt = value; }
        public void set_diachi(string value) { diachi = value; }

        public bool Check_Data()
        {
            if (mancc.Length == 0 | tenncc.Length == 0 | sdt.Length == 0 | diachi.Length == 0)
                return false;
            return true;
        }

        public void Reset()
        {
            mancc = "";
            tenncc = "";
            diachi = "";
            sdt = "";
        }

    }
}
