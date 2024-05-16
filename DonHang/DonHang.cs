using QLCHXM.Class;
using QLCHXM.DangNhap;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace QLCHXM
{
    public partial class DonHang : Form
    {
        public DonHang()
        {
            InitializeComponent();
        }
        SqlConnection ketnoi = new SqlConnection(@"Data Source=LAPTOP-NPMJOOFR\SQLEXPRESS;Initial Catalog=CHBDT;Integrated Security=True");
        
        DataTable tblDH;
        Class.donhang Obj_DH = new Class.donhang();
        private static bool mode_find_DH = false;

        int donghh;
        private void setFont_DH() // set Font cho các textBox 
        {
            txtBox_madonhang_DH.Font = new Font("Time New Roman", 12);
            txtBox_mancc_DH.Font = new Font("Time New Roman", 12);
            txtBox_maxe_DH.Font = new Font("Time New Roman", 12);
            txtBox_makh_DH.Font = new Font("Time New Roman", 12);
            txtBox_manv_DH.Font = new Font("Time New Roman", 12);
            dTP_ngayban_DH.Font = new Font("Time New Roman", 12);
            txtBox_tongtien_DH.Font = new Font("Time New Roman", 12);
            txtBox_giamgia_DH.Font = new Font("Time New Roman", 12);
            txtBox_slban_DH.Font = new Font("Time New Roman", 12);
            txtBox_giaban_DH.Font = new Font("Time New Roman", 12);
        }

        private void ResetValues_DH() // reset giá trị cho các mục 
        {
            if (!mode_find_DH)
                cbBox_thang_DH.Text = "";
            txtBox_madonhang_DH.Text = "";
            txtBox_mancc_DH.Text = "";
            txtBox_maxe_DH.Text = "";
            txtBox_makh_DH.Text = "";
            txtBox_manv_DH.Text = "";

            dTP_ngayban_DH.CustomFormat = "dd-MM-yyyy";
            dTP_ngayban_DH.Value = DateTime.Now;

            txtBox_tongtien_DH.Text = "";
            txtBox_slban_DH.Text = "";
            txtBox_giaban_DH.Text = "";
            txtBox_giamgia_DH.Text = "";

            btn_huy_DH.Enabled = false;
            btn_xoa_DH.Enabled = true;
            txtBox_madonhang_DH.Enabled = false;
        }

        private void getData_fromTable_DH() // lấy dữ liệu từ bảng

        {
            ketnoi.Open();
            string sql = "select * from DONHANG";
            Obj_DH.set_madh(dgv_DH.CurrentRow.Cells["MADH"].Value.ToString());
            Obj_DH.set_mancc(dgv_DH.CurrentRow.Cells["MANCC"].Value.ToString());
            Obj_DH.set_maxe(dgv_DH.CurrentRow.Cells["MADT"].Value.ToString());
            Obj_DH.set_makh(dgv_DH.CurrentRow.Cells["MAKH"].Value.ToString());
            Obj_DH.set_manv(dgv_DH.CurrentRow.Cells["MANV"].Value.ToString());
            Obj_DH.set_ngayban(dgv_DH.CurrentRow.Cells["NGAYBAN"].Value.ToString());
            Obj_DH.set_giaban(dgv_DH.CurrentRow.Cells["GIABAN"].Value.ToString());
            Obj_DH.set_soluong(dgv_DH.CurrentRow.Cells["SOLUONG"].Value.ToString());
            Obj_DH.set_giamgia(dgv_DH.CurrentRow.Cells["GIAMGIA"].Value.ToString());
            Obj_DH.set_tongtien(dgv_DH.CurrentRow.Cells["TONGTIEN"].Value.ToString());
            ketnoi.Close();  // đóng kết nối
            LoadData_DonHang();
        }

    
        private void getData_fromTxtBox_DH() // lấy dữ liệu từ các TextBox
        {
            Obj_DH.Reset();

            Obj_DH.set_madh(txtBox_madonhang_DH.Text.Trim().ToString());
            Obj_DH.set_mancc(txtBox_mancc_DH.Text.Trim().ToString());
            Obj_DH.set_maxe(txtBox_maxe_DH.Text.Trim().ToString());
            Obj_DH.set_makh(txtBox_makh_DH.Text.Trim().ToString());
            Obj_DH.set_manv(txtBox_manv_DH.Text.Trim().ToString());
            Obj_DH.set_ngayban(dTP_ngayban_DH.Text.Trim().ToString());
            Obj_DH.set_soluong(txtBox_slban_DH.Text.Trim().ToString());
            Obj_DH.set_giamgia(txtBox_giamgia_DH.Text.Trim().ToString());
            Obj_DH.set_tongtien(txtBox_tongtien_DH.Text.Trim().ToString());
            
            Obj_DH.set_giaban(txtBox_giaban_DH.Text.Trim().ToString());
        }
        private void LoadData_DonHang() // tải dữ liệu vào DataGridView
        {
            string sql = "SELECT DH.MADH, DH.MANCC, DH.MADT, DH.MAKH, DH.MANV, DH.NGAYBAN, DT.GIABAN, DH.SOLUONG, DH.GIAMGIA,  DH.TONGTIEN " +
                "FROM DONHANG DH, DIENTHOAI DT " +
                "WHERE DH.MADT = DT.MADT";
            tblDH = Class.Functions.GetDataToTable(sql); 
            dgv_DH.DataSource = tblDH;

            // set Font cho tên cột
            dgv_DH.Font = new Font("Time New Roman", 13);
            dgv_DH.Columns[0].HeaderText = "Mã Đơn Hàng";
            dgv_DH.Columns[1].HeaderText = "Mã Nhà Cung Cấp";
            dgv_DH.Columns[2].HeaderText = "Mã Điện Thoại";
            dgv_DH.Columns[3].HeaderText = "Mã Khách Hàng";
            dgv_DH.Columns[4].HeaderText = "Mã Nhân Viên";
            dgv_DH.Columns[5].HeaderText = "Ngày Bán";
            dgv_DH.Columns[6].HeaderText = "Giá Bán";
            dgv_DH.Columns[7].HeaderText = "Số Lượng Bán";
            dgv_DH.Columns[8].HeaderText = "Giá giảm";

            dgv_DH.Columns[9].HeaderText = "Tổng Tiền";
            

            // set Font cho dữ liệu hiển thị trong cột
            dgv_DH.DefaultCellStyle.Font = new Font("Time New Roman", 12);

            // set kích thước cột
            dgv_DH.Columns[0].Width = 110;
            dgv_DH.Columns[1].Width = 110;
            dgv_DH.Columns[2].Width = 110;
            dgv_DH.Columns[3].Width = 110;
            dgv_DH.Columns[4].Width = 110;
            dgv_DH.Columns[5].Width = 110;
            dgv_DH.Columns[6].Width = 110;
            dgv_DH.Columns[7].Width = 110;
            dgv_DH.Columns[8].Width = 110;
            dgv_DH.Columns[9].Width = 110;

            //Không cho người dùng thêm dữ liệu trực tiếp
            dgv_DH.AllowUserToAddRows = false;
            dgv_DH.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void LoadData_txtBox()
        {
            txtBox_madonhang_DH.Text = dgv_DH.CurrentRow.Cells["MADH"].Value.ToString();
            txtBox_mancc_DH.Text = dgv_DH.CurrentRow.Cells["MANCC"].Value.ToString();
            txtBox_maxe_DH.Text = dgv_DH.CurrentRow.Cells["MADT"].Value.ToString();
            txtBox_makh_DH.Text = dgv_DH.CurrentRow.Cells["MAKH"].Value.ToString();
            txtBox_manv_DH.Text = dgv_DH.CurrentRow.Cells["MANV"].Value.ToString();
            dTP_ngayban_DH.Text = dgv_DH.CurrentRow.Cells["NGAYBAN"].Value.ToString();
            txtBox_giaban_DH.Text = dgv_DH.CurrentRow.Cells["GIABAN"].Value.ToString();
            txtBox_slban_DH.Text = dgv_DH.CurrentRow.Cells["SOLUONG"].Value.ToString();
            txtBox_slban_DH.Text = dgv_DH.CurrentRow.Cells["GIAMGIA"].Value.ToString();
            txtBox_tongtien_DH.Text = dgv_DH.CurrentRow.Cells["TONGTIEN"].Value.ToString();
            // set giá trị cho tháng bán
            string sql = "SELECT MONTH(NGAYBAN) " +
                "FROM DONHANG " +
                "WHERE MADH = '" + dgv_DH.CurrentRow.Cells["MADH"].Value.ToString() + "' ";
            cbBox_thang_DH.Text = Class.Functions.GetFieldValues(sql);

        }
        private void dgv_DH_Click(object sender, EventArgs e) // khi click vào dataGridView
        {
            

          
        }
        

        private void btn_them_DH_Click(object sender, EventArgs e) // xử lí thêm
        {
            Them t = new Them();
            t.Show();
           
        }
        
        private void btn_xoa_DH_Click(object sender, EventArgs e) // xử lí xóa
        {
            // hỏi người dùng có chắc chắn xóa không ?

            if (MessageBox.Show("Bạn có chắc chắn muốn xoá không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                // thực hiện câu lệnh sql xóa
                ketnoi.Open();
                string sql = "DELETE " +
                    "DONHANG " +
                    "WHERE MADH = '" + txtBox_madonhang_DH.Text + "'";
                SqlCommand com = new SqlCommand(sql, ketnoi); //bat dau truy van
                com.CommandType = CommandType.Text;
                SqlDataAdapter da = new SqlDataAdapter(com); //chuyen du lieu ve
                DataTable dt = new DataTable(); //tạo một kho ảo để lưu trữ dữ liệu
                da.Fill(dt);  // đổ dữ liệu vào kho
                ketnoi.Close();

                // tải dữ liệu lên dataGridView
                LoadData_DonHang();
                ResetValues_DH();
            }
        }

        private void btn_huy_DH_Click(object sender, EventArgs e) // xử lí hủy
        {
            ResetValues_DH();

            // nếu đang ở chế độ tìm kiếm
            if (mode_find_DH)
            {
                LoadData_DonHang();
                mode_find_DH = false;
            }
        }

        private void btn_thoat_DH_Click(object sender, EventArgs e) // xử lí thoát
        {
            this.Close();
        }

        private void tabPage_donhang_Leave(object sender, EventArgs e) // khi rời tab
        {
            ResetValues_DH();
            if (btn_them_DH.Enabled == false)
                lb_them_dh.Text = "";
            btn_them_DH.Enabled = true;
            ResetValues_DH();

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dgv_DH_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {
            LoadData_DonHang();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_luu_DH_Click(object sender, EventArgs e)
        {
            getData_fromTxtBox_DH();

            // TH nếu chưa nhập đầy đủ dữ liệu
            if (!Obj_DH.Check_Data())
            {
                MessageBox.Show("Bạn phải nhập đầy đủ dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // xử lí khi trùng mã DH
            string sql = "SELECT " +
                "MADH " +
                "FROM DONHANG " +
                "WHERE MADH = '" + Obj_DH.get_madh() + "'";
            if (Class.Functions.CheckKey(sql))
            {
                MessageBox.Show("Mã đơn hàng đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtBox_madonhang_DH.Focus();
                return;
            }

            // xử lí câu lệnh sql thêm dữ liệu
            sql = "INSERT INTO DONHANG " +
                "VALUES('" + Obj_DH.get_madh() +
                "','" + Obj_DH.get_makh() +
                "','" + Obj_DH.get_mancc() +
                "','" + Obj_DH.get_maxe() +
                "','" + Obj_DH.get_manv() +
                "','" + Obj_DH.get_soluong() +
                "','" + Obj_DH.get_giamgia() +
                "','" + Obj_DH.get_giaban() +

                "','" + Obj_DH.get_ngayban() +
                "','" + Obj_DH.get_tongtien() + "')";

            SqlCommand com = new SqlCommand(sql, ketnoi); //bat dau truy van
            com.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(com); //chuyen du lieu ve
            DataTable dt = new DataTable(); //tạo một kho ảo để lưu trữ dữ liệu
            da.Fill(dt);  // đổ dữ liệu vào kho

            // tải dữ liệu lên dataGridView
            LoadData_DonHang();
            ResetValues_DH();

            btn_them_DH.Enabled = true;
            lb_them_dh.Text = "";
        }

        private void btn_autotongtien_CTDH_Click(object sender, EventArgs e)
        {
            if (txtBox_giaban_DH.Text.Trim().Length != 0 && txtBox_slban_DH.Text.Trim().Length != 0 &&
                txtBox_giamgia_DH.Text.Trim().Length != 0)
            {
                float giaban = float.Parse(txtBox_giaban_DH.Text.Trim().ToString());
                int soluong = int.Parse(txtBox_slban_DH.Text.Trim().ToString());
                float giamgia = float.Parse(txtBox_giamgia_DH.Text.Trim().ToString());

                float tongtien = (giaban * soluong) - (giaban * soluong * (giamgia / 100));

                txtBox_tongtien_DH.Text = ((int)tongtien).ToString();
            }
        }

      
        private void dgv_DH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            donghh = e.RowIndex;
            if (donghh >= 0)
            {
                txtBox_madonhang_DH.Text = tblDH.Rows[donghh][0].ToString();
                txtBox_mancc_DH.Text = tblDH.Rows[donghh][1].ToString();
                txtBox_maxe_DH.Text = tblDH.Rows[donghh][2].ToString();
                txtBox_makh_DH.Text = tblDH.Rows[donghh][3].ToString();
                txtBox_manv_DH.Text = tblDH.Rows[donghh][4].ToString();
                dTP_ngayban_DH.Text = tblDH.Rows[donghh][5].ToString();
                txtBox_giaban_DH.Text = tblDH.Rows[donghh][6].ToString();
                txtBox_slban_DH.Text = tblDH.Rows[donghh][7].ToString();
                txtBox_giamgia_DH.Text = tblDH.Rows[donghh][8].ToString();

                txtBox_tongtien_DH.Text = tblDH.Rows[donghh][9].ToString();
                txtBox_madonhang_DH.Enabled = false;

              

            }



        }

        private void dTP_ngayban_DH_ValueChanged(object sender, EventArgs e)
        {

        }

        private void DonHang_Load(object sender, EventArgs e)
        {

            // set giá trị cho comboBox
            for (int i = 1; i <= 12; i++)
                cbBox_thang_DH.Items.Add(i.ToString());

            setFont_DH();
            ResetValues_DH();
            LoadData_DonHang();
        }

        private void txtBox_giaban_DH_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
             mode_find_DH = true;

            // TH nếu chưa chọn tháng
            if (cbBox_thang_DH.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa chọn tháng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // TH đã chọn tháng     
            setDaTa_FindMode_DH();

            // nếu tìm ko ra dữ liệu 
            if (tblDH.Rows.Count == 0)
                MessageBox.Show("Không có đơn hàng trong tháng " + cbBox_thang_DH.Text.Trim().ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
       
        private void setDaTa_FindMode_DH() //tải dữ liệu đã tìm được vào dataGridView
        {
            // xử lí câu lệnh sql
            string sql = "SELECT DH.MADH, DH.MANCC, DH.MADT, DH.MAKH, DH.MANV, DH.NGAYBAN, DT.GIABAN, DH.SOLUONG,DH.GIAMGIA, DH.TONGTIEN " +
                "FROM DONHANG DH, DIENTHOAI DT " +
                "WHERE DH.MADT = DT.MADT " +
                "AND MONTH(NGAYBAN) = '" + cbBox_thang_DH.Text.Trim().ToString() + "'";
            tblDH = Class.Functions.GetDataToTable(sql);

            // tải dữ liệu lên dataGridView
            dgv_DH.DataSource = tblDH;

            // reset giá trị cho các mục trừ mục tên hãng điện thoại,xử lí enable các nút       
            ResetValues_DH();
            btn_huy_DH.Enabled = true;
        }
    }
}
