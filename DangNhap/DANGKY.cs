using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBDT.DangNhap
{
    public partial class DANGKY : Form
    {
        public DANGKY()
        {
            InitializeComponent();
        }
        private static string stringConnection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\DoAnCSN-8.1.2023-HT da sua\QLCHXM\Database2.mdf"";Integrated Security=True";
        public static SqlConnection GetSqlConnection()
        {

            return new SqlConnection(stringConnection);
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
        public bool checkAccount(string acc)//check mat khau va ten tai khoan
        {
            return Regex.IsMatch(acc, "^[a-zA-Z0-9]{3,24}$");
        }
        public bool checkEmail(string em)//check email
        {
            return Regex.IsMatch(em, @"^[a-zA-Z0-9_.]{3,20}@gmail.com(.vn|)$");
        }
        Modify modify = new Modify();
        private void bt_dangky_Click(object sender, EventArgs e)
        {


        }

        private void bt_dangky_Click_1(object sender, EventArgs e)
        {
           
        }

        private void bt_dangky_Click_2(object sender, EventArgs e)
        {
            string tentk = tb_tentaikhoan.Text;
            string matkhau = tb_matkhau.Text;
            string xacnhan = tb_xacnhanmk.Text;
            string email = tb_email.Text;
            if (!checkAccount(tentk)) { MessageBox.Show("Vui lòng nhập tên tài khoản dài từ 3 -> 24 ký tự, với các ký tự chữ (hoa, thường) và số!"); return; }
            if (!checkAccount(matkhau)) { MessageBox.Show("Vui lòng nhập mật khẩu dài từ 3 -> 24 ký tự, với các ký tự chữ (hoa, thường) và số!"); return; }
            if (xacnhan != matkhau) { MessageBox.Show("Vui lòng nhập chính xác mật khẩu đã nhập!"); return; }
            if (!checkEmail(email)) { MessageBox.Show("Vui lòng nhập đúng định dạng email!"); return; }
            if (modify.TaiKhoans("Select * from TaiKhoan where Email = '" + email + "'").Count != 0) { MessageBox.Show("Email này đã được đăng ký, vui lòng sử dụng email khác!"); return; }
            try
            {
                string query = "Insert into TaiKhoan values('" + tentk + "','" + matkhau + "','" + email + "')";
                modify.Command(query);
                if (MessageBox.Show("Đăng ký thành công! Bạn có muốn đăng nhập luôn không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    this.Close();
                }
            }
            catch
            {
                MessageBox.Show("Tên này đã được dùng, vui lòng nhập tên tài khoản khác!");
            }
        }

        private void DANGKY_Load(object sender, EventArgs e)
        {

        }
    }
}
