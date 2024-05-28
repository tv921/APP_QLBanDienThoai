using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCHXM.Class
{
    internal class donhang
    {
        private string madh;
        private string makh;
        private string manv;
        private string maxe;
        private string soluong;
        private string giamgia;
        private string ngayban;
        private string giaban;
        private string mancc;
        private string tongtien;

        public donhang() { }

        public string get_madh() { return madh; }
        public string get_makh() { return makh; }
        public string get_manv() { return manv; }
        public string get_maxe() { return maxe; }
        public string get_soluong() { return soluong; }
        public string get_ngayban() { return ngayban; }
        public string get_giaban() { return ngayban; }
        public string get_giamgia() { return giamgia; }
        public string get_tongtien() { return tongtien; }
        public string get_mancc() { return mancc; }

        public void set_madh(string value) { madh = value; }
        public void set_makh(string value) { makh = value; }
        public void set_manv(string value) { manv = value; }
        public void set_maxe(string value) { maxe = value; }
        public void set_soluong(string value) { soluong = value; }
        public void set_ngayban(string value) { ngayban = value; }
        public void set_giaban(string value) { ngayban = value; }
        public void set_giamgia(string value) { giamgia = value; }
        public void set_tongtien(string value) { tongtien = value; }
        public void set_mancc(string value) { mancc = value; }

        public bool Check_Data()
        {
            if (madh.Length == 0 | makh.Length == 0 | manv.Length == 0 | maxe.Length == 0 | soluong.Length == 0 | giamgia.Length == 0
                | giaban.Length == 0 | mancc.Length == 0 |tongtien.Length == 0)
                return false;
            return true;
        }

        public void Reset()
        {
            madh = "";
            makh = "";
            manv = "";
            maxe = "";
            soluong = "";
            giamgia = "";
            ngayban = "";
            giaban = "";
            mancc = "";
            tongtien = "";
        }

        internal void set_GIABAN(string v)
        {
            throw new NotImplementedException();
        }
    }
}
