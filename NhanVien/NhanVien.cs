﻿using QLCHXM.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCHXM
{
    public partial class NhanVien : Form
    {
        public NhanVien()
        {
            InitializeComponent();
        }
        SqlConnection ketnoi = new SqlConnection(@"Data Source=LAPTOP-NPMJOOFR\SQLEXPRESS;Initial Catalog=CHBDT;Integrated Security=True");
        Class.nhanvien Obj_NV = new Class.nhanvien();
        DataTable tblNV;
        private void setFont_NV() // set Font cho các textBox 
        {
            txtBox_manv_NV.Font = new Font("Time New Roman", 12);
            txtBox_tennv_NV.Font = new Font("Time New Roman", 12);
            txtBox_gioitinh_NV.Font = new Font("Time New Roman", 12);
            MTBox_sdt_NV.Font = new Font("Time New Roman", 12);
            txtBox_namsinh_NV.Font = new Font("Time New Roman", 12);
            txtBox_diachi_NV.Font = new Font("Time New Roman", 12);
        }

        private void ResetValues_NV() // reset giá trị cho các mục 
        {
            txtBox_manv_NV.Text = "";
            txtBox_tennv_NV.Text = "";
            txtBox_gioitinh_NV.Text = "";
            MTBox_sdt_NV.Text = "";
            txtBox_diachi_NV.Text = "";

            

            btn_capnhat_NV.Enabled = false;
            btn_xoa_NV.Enabled = false;
            btn_luu_NV.Enabled = false;
            btn_huy_NV.Enabled = false;
            txtBox_manv_NV.Enabled = false;
        }

        private void getData_fromTable_NV() // lấy dữ liệu từ bảng
        {
            ketnoi.Open();
            string sql = "select * from NHANVIEN";
            Obj_NV.set_manv(dgv_NV.CurrentRow.Cells["MANV"].Value.ToString());
            Obj_NV.set_tennv(dgv_NV.CurrentRow.Cells["TENNV"].Value.ToString());
            Obj_NV.set_gioitinh(dgv_NV.CurrentRow.Cells["GIOITINH"].Value.ToString());
            Obj_NV.set_namsinh(dgv_NV.CurrentRow.Cells["NAMSINH"].Value.ToString());
            Obj_NV.set_diachi(dgv_NV.CurrentRow.Cells["DIACHI"].Value.ToString());
            Obj_NV.set_sdt(dgv_NV.CurrentRow.Cells["DIENTHOAI"].Value.ToString());
            ketnoi.Close();  // đóng kết nối
            LoadData_NhanVien();
        }

        private void getData_fromTxtBox_NV() // lấy dữ liệu từ các TextBox
        {
            Obj_NV.Reset();

            Obj_NV.set_manv(txtBox_manv_NV.Text.Trim().ToString());
            Obj_NV.set_tennv(txtBox_tennv_NV.Text.Trim().ToString());
            Obj_NV.set_gioitinh(txtBox_gioitinh_NV.Text.Trim().ToString());
            Obj_NV.set_sdt(MTBox_sdt_NV.Text.Trim().ToString());
            Obj_NV.set_namsinh(txtBox_namsinh_NV.Text.Trim().ToString());
            Obj_NV.set_diachi(txtBox_diachi_NV.Text.Trim().ToString());
        }



        private void LoadData_NhanVien() // tải dữ liệu vào DataGridView
        {
            
            ketnoi.Open();
            string sql = "select * from NHANVIEN";  // lay het du lieu trong bang sinh vien
            SqlCommand com = new SqlCommand(sql, ketnoi); //bat dau truy van
            com.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(com); //chuyen du lieu ve
            DataTable dt = new DataTable(); //tạo một kho ảo để lưu trữ dữ liệu
            da.Fill(dt);  // đổ dữ liệu vào kho
            ketnoi.Close();  // đóng kết nối
            dgv_NV.DataSource = dt; //đổ dữ liệu vào datagridview

            // set Font cho tên cột
            dgv_NV.Font = new Font("Time New Roman", 13);
            dgv_NV.Columns[0].HeaderText = "Mã Nhân Viên";
            dgv_NV.Columns[1].HeaderText = "Tên Nhân Viên";
            dgv_NV.Columns[2].HeaderText = "Giới Tính";
            dgv_NV.Columns[3].HeaderText = "Năm Sinh";
            dgv_NV.Columns[4].HeaderText = "Số Điện Thoại";
            dgv_NV.Columns[5].HeaderText = "Địa Chỉ";

            // set Font cho dữ liệu hiển thị trong cột
            dgv_NV.DefaultCellStyle.Font = new Font("Time New Roman", 12);

            // set kích thước cột
            dgv_NV.Columns[0].Width = 150;
            dgv_NV.Columns[1].Width = 200;
            dgv_NV.Columns[2].Width = 115;
            dgv_NV.Columns[3].Width = 120;
            dgv_NV.Columns[5].Width = 350;
            dgv_NV.Columns[4].Width = 150;

            //Không cho người dùng thêm dữ liệu trực tiếp
            dgv_NV.AllowUserToAddRows = false;
            dgv_NV.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void dgv_NV_Click(object sender, EventArgs e) // xử lí khi click vào dataGridView
        {
            

            // nếu đang ở chế độ thêm mà user click vào DataGridView
            if (btn_them_NV.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtBox_manv_NV.Focus();
                return;
            }

            // set giá trị cho các mục 
            getData_fromTable_NV();
            txtBox_manv_NV.Text = Obj_NV.get_manv();
            txtBox_tennv_NV.Text = Obj_NV.get_tennv();
            txtBox_gioitinh_NV.Text = Obj_NV.get_gioitinh();
            MTBox_sdt_NV.Text = Obj_NV.get_sdt();
            txtBox_namsinh_NV.Text = Obj_NV.get_namsinh();
            txtBox_diachi_NV.Text = Obj_NV.get_diachi();

            // xử lí enable các nút
            btn_capnhat_NV.Enabled = true;
            btn_xoa_NV.Enabled = true;
            btn_huy_NV.Enabled = true;
        }

        private void btn_them_NV_Click(object sender, EventArgs e) // xử lí thêm
        {
            ResetValues_NV();

            // set label thông báo cho người dùng biết là đang ở chế độ thêm
            lb_them_NV.Text = "*Bạn đang ở chế độ thêm";

            // xử lí enable các nút
            txtBox_manv_NV.Enabled = true;
            txtBox_manv_NV.Focus();
            btn_huy_NV.Enabled = true;
            btn_luu_NV.Enabled = true;
            btn_them_NV.Enabled = false;
        }

        private void btn_xoa_NV_Click(object sender, EventArgs e) // xử lí xóa
        {

            // hỏi người dùng có chắc chắn xóa không ?
            if (MessageBox.Show("Bạn có chắc chắn muốn xoá không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ketnoi.Open();
               
                string sql = "DELETE NHANVIEN " +
                    "WHERE MANV = N'" + txtBox_manv_NV.Text + "'";
            SqlCommand com = new SqlCommand(sql, ketnoi); //bat dau truy van
            com.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(com); //chuyen du lieu ve
            DataTable dt = new DataTable(); //tạo một kho ảo để lưu trữ dữ liệu
            da.Fill(dt);  // đổ dữ liệu vào kho
                ketnoi.Close();
                LoadData_NhanVien();
                ResetValues_NV();
            }
        }

        private void btn_capnhat_NV_Click(object sender, EventArgs e) // xử lí cập nhật
        {
            getData_fromTxtBox_NV();

            // TH chưa nhập đầy đủ dữ liệu
            if (!Obj_NV.Check_Data())
            {
                MessageBox.Show("Bạn phải nhập đầy đủ dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            ketnoi.Open();
            // xử lí câu lệnh sql cập nhật dữ liệu
            string sql = "UPDATE NHANVIEN " +
                "SET TENNV = N'" + Obj_NV.get_tennv() + "'," +
                "GIOITINH = N'" + Obj_NV.get_gioitinh() + "'," +
                "NAMSINH = '" + Obj_NV.get_namsinh() + "'," +
                "DIENTHOAI = '" + Obj_NV.get_sdt() + "'," +
                "DIACHI = N'" + Obj_NV.get_diachi() + "'" +
                "WHERE MANV = '" + Obj_NV.get_manv() + "'";
           
            SqlCommand com = new SqlCommand(sql, ketnoi); //bat dau truy van
            com.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(com); //chuyen du lieu ve
            DataTable dt = new DataTable(); //tạo một kho ảo để lưu trữ dữ liệu
            da.Fill(dt);  // đổ dữ liệu vào kho
            ketnoi.Close();  // đóng kết nối
           
            LoadData_NhanVien();
            ResetValues_NV();
        }

        private void btn_luu_NV_Click(object sender, EventArgs e) // khi click vào nút lưu
        {
            getData_fromTxtBox_NV();

            // TH chưa nhập đầy đủ dữ liệu
            if (!Obj_NV.Check_Data())
            {
                MessageBox.Show("Bạn phải nhập đầy đủ dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // xử lí khi trùng mã nhân viên
            string sql = "SELECT " +
                "MANV " +
                "FROM NHANVIEN " +
                "WHERE MANV = N'" + Obj_NV.get_manv() + "'";
            if (Class.Functions.CheckKey(sql))
            {
                MessageBox.Show("Mã nhân viên đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtBox_manv_NV.Focus();
                return;
            }

            // xử lí câu lệnh sql thêm dữ liệu
            sql = "INSERT INTO NHANVIEN " +
                "VALUES('" + Obj_NV.get_manv() + "'," +
                "N'" + Obj_NV.get_tennv() + "'," +
                "N'" + Obj_NV.get_gioitinh() + "'," +
                "'" + Obj_NV.get_namsinh() +
                "','" + Obj_NV.get_sdt() + "'," +
                 "N'" + Obj_NV.get_diachi() + "')" ;
            SqlCommand com = new SqlCommand(sql, ketnoi); //bat dau truy van
            com.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(com); //chuyen du lieu ve
            DataTable dt = new DataTable(); //tạo một kho ảo để lưu trữ dữ liệu
            da.Fill(dt);  // đổ dữ liệu vào kho

            // tải dữ liệu lên dataGridView
            LoadData_NhanVien();
            ResetValues_NV();

            btn_them_NV.Enabled = true;
            lb_them_NV.Text = "";
        }

        private void btn_huy_NV_Click(object sender, EventArgs e) // xử lí hủy
        {
            // nếu đang ở chế độ thêm
            if (btn_them_NV.Enabled == false)
                lb_them_NV.Text = "";
            ResetValues_NV();
            btn_them_NV.Enabled = true;
        }

        private void btn_thoat_NV_Click(object sender, EventArgs e) // xử lí thoát
        {
            this.Close();
        }

        private void tabPage_nhanvien_Leave(object sender, EventArgs e) // xử lí khi rời tab
        {
            ResetValues_NV();
            if (btn_them_NV.Enabled == false)
                lb_them_NV.Text = "";
            btn_them_NV.Enabled = true;
        }

        private void dgv_NV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            LoadData_NhanVien();
        }
        private void btn_luu_NV_Clic(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void NhanVien_Load(object sender, EventArgs e)
        {

        }
    }
}
