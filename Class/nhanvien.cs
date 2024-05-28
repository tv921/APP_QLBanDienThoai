﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCHXM.Class
{
    internal class nhanvien
    {
        private string manv;
        private string tennv;
        private string sdt;
        private string diachi;
        private string gioitinh;
        private string namsinh;

        public nhanvien() { }

        public string get_manv() { return manv; }
        public string get_tennv() { return tennv; }
        public string get_sdt() { return sdt; }
        public string get_diachi() { return diachi; }
        public string get_gioitinh() { return gioitinh; }
        public string get_namsinh() { return namsinh; }

        public void set_manv(string value) { manv = value; }
        public void set_tennv(string value) { tennv = value; }
        public void set_sdt(string value) { sdt = value; }
        public void set_diachi(string value) { diachi = value; }
        public void set_gioitinh(string value) { gioitinh = value; }
        public void set_namsinh(string value) { namsinh = value; }

        public bool Check_Data()
        {
            if (manv.Length == 0 | tennv.Length == 0 | sdt.Length == 0 | diachi.Length == 0
                | gioitinh.Length == 0 | namsinh.Length == 0)
                return false;
            return true;
        }

        public void Reset()
        {
            manv = "";
            tennv = "";
            sdt = "";
            diachi = "";
            gioitinh = "";
            namsinh = "";
        }
    }
}

