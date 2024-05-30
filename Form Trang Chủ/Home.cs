using QLCHXM.DangNhap;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using System.Security.Cryptography;

namespace QLCHXM
{
    public partial class Home : Form
    {

        
        public Home()
        {
            InitializeComponent();
 
           
        }
        private Form activeform = null;
        private void openChildForm(Form childForm)
        {
            if (activeform != null)
                activeform.Close();
            activeform = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm_AD.Controls.Add(childForm);
            panelChildForm_AD.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private Button currentButton;
        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = ColorTranslator.FromHtml("#4169E1");
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                }
            }
        }
        private void DisableButton()
        {
            foreach (Control previousBtn in panelMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(39, 39, 58);
                    previousBtn.ForeColor = Color.Gainsboro;
                }
            }
        }
        private void Home_Load(object sender, EventArgs e)
        {
            Class.Functions.Connect();

            btn_hanghoa_AD.PerformClick();

            
        }

        private void iconButtonThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn đăng xuất!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                this.Hide();
                Form_Dang_Nhap form_Dang_Nhap = new Form_Dang_Nhap();
                form_Dang_Nhap.ShowDialog();
            }
        }
        
        
        private void resetHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home home = new Home();
            home.ShowDialog();
        }

        private void btn_hanghoa_AD_Click_1(object sender, EventArgs e)
        {
            ActivateButton(sender);
            openChildForm(new HangHoa());
        }

        private void btn_donhang_AD_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            openChildForm(new DonHang());
        }

        private void btn_khachhang_AD_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            openChildForm(new fKhachHang());
        }

        private void btn_nhanvien_AD_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            openChildForm(new NhanVien());
        }

        private void btn_thongke_AD_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            openChildForm(new fThongKe());
        }

        private void btn_nhacungcap_AD_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            openChildForm(new NhaCungCap());
        }

        private void panelChildForm_AD_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
