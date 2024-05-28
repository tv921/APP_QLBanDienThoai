using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCHXM.Class
{
     public class hanghoa
     {
        private string manhacungcap;
        private string maxe;
        private string tenxe;
        private string soluong;
        private string gianhap;
        private string giaban;
        

        public hanghoa() { }

        public bool Check_Data()
        {
            if (manhacungcap.Length == 0 | maxe.Length == 0 | tenxe.Length == 0 | soluong.Length == 0 |
                gianhap.Length == 0 | giaban.Length == 0 )
                return false;
            return true;
        }

        public void Reset()
        {
            manhacungcap = "";
            maxe = "";
            tenxe = "";
            soluong = "";
            gianhap = "";
            giaban = "";
            
        }

        public string get_manhacungcap() { return manhacungcap; }
        public string get_maxe() { return maxe; }
        public string get_tenxe() { return tenxe; }
        public string get_soluong() { return soluong; }
        public string get_gianhap() { return gianhap; }
        public string get_giaban() { return giaban; }

        public void set_manhacungcap(string value) { manhacungcap = value; }
        public void set_maxe(string value) { maxe = value; }
        public void set_tenxe(string value) { tenxe = value; }
        public void set_soluong(string value) { soluong = value; }
        public void set_gianhap(string value) { gianhap = value; }
        public void set_giaban(string value) { giaban = value; }

    }
}
