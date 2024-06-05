using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBDT.DangNhap
{
    public partial class Form_Dang_Nhap : Form
    {
        public Form_Dang_Nhap()
        {
            InitializeComponent();
        }

        private void Form_Đăng_Nhập_Load(object sender, EventArgs e)
        {
            // KetNoiDuLieu ketnoi = new KetNoiDuLieu();
            //  DataTable bangtam = new DataTable();
            //  string sql = "select* from " 

        }

      

        private void linkLabel_Dangky_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DANGKY dANGKY = new DANGKY();
            dANGKY.ShowDialog();
        }
        Modify modify = new Modify();

        private void bt_dangnhap_Click_2(object sender, EventArgs e)
        {
            string tentk = tb_tentaikhoan.Text;
            string matkhau = tb_matkhau.Text;
            if (tentk.Trim() == "") { MessageBox.Show("Vui lòng nhập tên tài khoản!"); return; }
            else if (matkhau.Trim() == "") { MessageBox.Show("Vui lòng nhập mật khẩu!"); return; }
            else
            {
                string query = "Select * from TaiKhoan where TenTaiKhoan = '" + tentk + "'and MatKhau = '" + matkhau + "' ";
                if (modify.TaiKhoans(query).Count != 0)
                {
                    MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    Home haha = new Home();
                    haha.ShowDialog();
                    this.Close();

                }
                else
                {
                    MessageBox.Show("Tên tài khoản hoặc mật khẩu không chính xác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

        }

        private void btnThoat_Click_2(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void linkLabel_Quenmatkhau_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            QuenMatKhau quenMatKhau = new QuenMatKhau();
            quenMatKhau.ShowDialog();
        }

        private void linkLabel_Dangky_LinkClicked_2(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DANGKY dANGKY = new DANGKY();
            dANGKY.ShowDialog();
        }

        private void Form_Dang_Nhap_Load(object sender, EventArgs e)
        {

        }
    }
}
