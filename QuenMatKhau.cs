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
    public partial class QuenMatKhau : Form
    {
        public QuenMatKhau()
        {
            InitializeComponent();
            label2.Text = "";
        }
        Modify modify = new Modify();
        private void QuenMatKhau_Load(object sender, EventArgs e)
        {

        }

        private void bt_laylaimk_Click(object sender, EventArgs e)
        {
           
        }

        private void bt_laylaimk_Click_1(object sender, EventArgs e)
        {
            string email = tb_emaildk.Text;
            if (email.Trim() == "") { MessageBox.Show("Vui nhập email của tài khoản bạn muốn lấy lại mật khẩu!"); }
            else
            {
                string query = "Select * from TaiKhoan where Email = '" + email + "'";
                if (modify.TaiKhoans(query).Count != 0)
                {
                    label2.ForeColor = Color.Blue;
                    label2.Text = "Mật khẩu: " + modify.TaiKhoans(query)[0].MatKhau;
                }
                else
                {
                    label2.ForeColor = Color.Red;
                    label2.Text = "Email này chưa được đăng ký!";
                }
            }
        }

        private void QuenMatKhau_Load_1(object sender, EventArgs e)
        {

        }
    }
}
