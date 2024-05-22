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
    public partial class fKhachHang : Form
    {
        public fKhachHang()
        {
            InitializeComponent();
        }
        SqlConnection cnn = new SqlConnection(@"Data Source=LAPTOP-NPMJOOFR\SQLEXPRESS;Initial Catalog=CHBDT;Integrated Security=True");
        Class.khachhang Obj_KH = new Class.khachhang();
        DataTable tblKH;

        private void FKhachHang_Load(object sender, EventArgs e)
        {

            


        }

    
        private void setFont_KH() // set Font cho các textBox 
        {
            txtBox_makh_KH.Font = new Font("Time New Roman", 12);
            txtBox_tenkh_KH.Font = new Font("Time New Roman", 12);
            MTBox_sdt_KH.Font = new Font("Time New Roman", 12);
            txtBox_diachi_KH.Font = new Font("Time New Roman", 12);
        }

        private void ResetValues_KH() // reset giá trị cho các mục 
        {
            txtBox_makh_KH.Text = "";
            txtBox_tenkh_KH.Text = "";
            MTBox_sdt_KH.Text = "";
            txtBox_diachi_KH.Text = "";

            btn_capnhat_KH.Enabled = false;
            btn_xoa_KH.Enabled = false;
            btn_luu_KH.Enabled = false;
            btn_huy_KH.Enabled = false;
            txtBox_makh_KH.Enabled = false;
        }

        private void getData_fromTable_KH() // lấy dữ liệu từ bảng
        {
            cnn.Open();
            string sql = "select * from KHACHHANG";
            Obj_KH.set_makh(dgv_KH.CurrentRow.Cells["MAKH"].Value.ToString());
            Obj_KH.set_tenkh(dgv_KH.CurrentRow.Cells["TENKH"].Value.ToString());
            Obj_KH.set_sdt(dgv_KH.CurrentRow.Cells["DIENTHOAI"].Value.ToString());
            Obj_KH.set_diachi(dgv_KH.CurrentRow.Cells["DIACHI"].Value.ToString());

            cnn.Close();  // đóng kết nối
            LoadData_KH();
        }

        private void getData_fromTxtBox_KH() // lấy dữ liệu từ các TextBox
        {
            Obj_KH.Reset();

            Obj_KH.set_makh(txtBox_makh_KH.Text.Trim().ToString());
            Obj_KH.set_tenkh(txtBox_tenkh_KH.Text.Trim().ToString());
            Obj_KH.set_sdt(MTBox_sdt_KH.Text.Trim().ToString());
            Obj_KH.set_diachi(txtBox_diachi_KH.Text.Trim().ToString());
        }

        private void LoadData_KH() // tải dữ liệu vào DataGridView
        {
            cnn.Open();
            string sql = "select * from KHACHHANG";  // lay het du lieu trong bang sinh vien
            SqlCommand com = new SqlCommand(sql, cnn); //bat dau truy van
            com.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(com); //chuyen du lieu ve
            DataTable dt = new DataTable(); //tạo một kho ảo để lưu trữ dữ liệu
            da.Fill(dt);  // đổ dữ liệu vào kho
            cnn.Close();  // đóng kết nối
            dgv_KH.DataSource = dt; //đổ dữ liệu vào datagridview

            // set Font cho tên cột
            dgv_KH.Font = new Font("Time New Roman", 13);
            dgv_KH.Columns[0].HeaderText = "Mã Khách Hàng";
            dgv_KH.Columns[1].HeaderText = "Tên Khách Hàng";
            dgv_KH.Columns[2].HeaderText = "Số Điện Thoại";
            dgv_KH.Columns[3].HeaderText = "Địa Chỉ";

            // set Font cho dữ liệu hiển thị trong cột
            dgv_KH.DefaultCellStyle.Font = new Font("Time New Roman", 12);

            // set kích thước cột
            dgv_KH.Columns[0].Width = 220;
            dgv_KH.Columns[1].Width = 220;
            dgv_KH.Columns[2].Width = 220;
            dgv_KH.Columns[3].Width = 350;

            //Không cho người dùng thêm dữ liệu trực tiếp
            dgv_KH.AllowUserToAddRows = false;
            dgv_KH.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void dgv_KH_Click(object sender, EventArgs e) // xử lí khi click vào dataGridView
        {

            // nếu đang ở chế độ thêm mà user click vào DataGridView
            if (btn_them_KH.Enabled == false)
            {
                MessageBox.Show("Bạn đang ở chế độ thêm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtBox_makh_KH.Focus();
                return;
            }

            // set giá trị cho các mục 
            getData_fromTable_KH();
            txtBox_makh_KH.Text = Obj_KH.get_makh();
            txtBox_tenkh_KH.Text = Obj_KH.get_tenkh();
            MTBox_sdt_KH.Text = Obj_KH.get_sdt();
            txtBox_diachi_KH.Text = Obj_KH.get_diachi();

            // xử lí enable các nút
            btn_capnhat_KH.Enabled = true;
            btn_xoa_KH.Enabled = true;
            btn_huy_KH.Enabled = true;
        }

        private void btn_them_KH_Click(object sender, EventArgs e) // xử lí thêm
        {
            ResetValues_KH();

            // set label thông báo cho người dùng biết là đang ở chế độ thêm
            lb_them_KH.ForeColor = System.Drawing.Color.Red;
            lb_them_KH.Text = "*Bạn đang ở chế độ thêm";

            // xử lí enable các nút
            txtBox_makh_KH.Enabled = true;
            txtBox_makh_KH.Focus();
            btn_huy_KH.Enabled = true;
            btn_luu_KH.Enabled = true;
            btn_them_KH.Enabled = false;
        }

        private void btn_xoa_KH_Click(object sender, EventArgs e) // xử lí xóa
        {
            // hỏi người dùng có chắc chắn xóa không ?
            if (MessageBox.Show("Bạn có chắc chắn muốn xoá không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                cnn.Open();
                string sql = "DELETE KHACHHANG " +
                    "WHERE MAKH = '" + txtBox_makh_KH.Text + "'";
                SqlCommand com = new SqlCommand(sql, cnn); //bat dau truy van
                com.CommandType = CommandType.Text;
                SqlDataAdapter da = new SqlDataAdapter(com); //chuyen du lieu ve
                DataTable dt = new DataTable(); //tạo một kho ảo để lưu trữ dữ liệu
                da.Fill(dt);  // đổ dữ liệu vào kho
                cnn.Close();
                LoadData_KH();
                ResetValues_KH();
            }
        }

        private void btn_capnhat_KH_Click(object sender, EventArgs e) // xử lí cập nhật
        {
            getData_fromTxtBox_KH();

            // TH chưa nhập đầy đủ dữ liệu
            if (!Obj_KH.Check_Data())
            {
                MessageBox.Show("Bạn phải nhập đầy đủ dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // xử lí câu lệnh sql cập nhật dữ liệu
            cnn.Open();
            string sql = "UPDATE KHACHHANG " +
                "SET TENKH = N'" + Obj_KH.get_tenkh() + "'," +
                "DIENTHOAI = '" + Obj_KH.get_sdt() + "'," +
                "DIACHI = N'" + Obj_KH.get_diachi() + "'" +
                "WHERE MAKH = '" + Obj_KH.get_makh() + "'";
            
            SqlCommand com = new SqlCommand(sql, cnn); //bat dau truy van
            com.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(com); //chuyen du lieu ve
            DataTable dt = new DataTable(); //tạo một kho ảo để lưu trữ dữ liệu
            da.Fill(dt);  // đổ dữ liệu vào kho
            cnn.Close();

            LoadData_KH();
            ResetValues_KH();
        }

        private void btn_luu_KH_Click(object sender, EventArgs e) // xử lí lưu
        {
            getData_fromTxtBox_KH();

            // TH chưa nhập đầy đủ dữ liệu
            if (!Obj_KH.Check_Data())
            {
                MessageBox.Show("Bạn phải nhập đầy đủ dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // xử lí khi trùng mã khách hàng
            string sql = "SELECT " +
                "MAKH " +
                "FROM KHACHHANG " +
                "WHERE MAKH = '" + Obj_KH.get_makh() + "'";
            if (Class.Functions.CheckKey(sql))
            {
                MessageBox.Show("Mã khách hàng đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtBox_makh_KH.Focus();
                return;
            }

            // xử lí câu lệnh sql thêm dữ liệu
            sql = "INSERT INTO KHACHHANG " +
                "VALUES('" + Obj_KH.get_makh() + "'," +
                "N'" + Obj_KH.get_tenkh() + "'," +
                "'" + Obj_KH.get_sdt() + "'," +
                "N'" + Obj_KH.get_diachi() + "')";
            SqlCommand com = new SqlCommand(sql, cnn); //bat dau truy van
            com.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(com); //chuyen du lieu ve
            DataTable dt = new DataTable(); //tạo một kho ảo để lưu trữ dữ liệu
            da.Fill(dt);  // đổ dữ liệu vào kho


            // tải dữ liệu lên dataGridView
            LoadData_KH();
            ResetValues_KH();

            btn_them_KH.Enabled = true;
            lb_them_KH.Text = "";
        }

        private void btn_huy_KH_Click(object sender, EventArgs e) // xử lí hủy
        {
            // nếu đang ở chế độ thêm
            if (btn_them_KH.Enabled == false)
                lb_them_KH.Text = "";
            ResetValues_KH();
            btn_them_KH.Enabled = true;
        }
        private void btn_thoat_KH_Click(object sender, EventArgs e) // xử lí thoát
        {
            this.Close();
        }

        private void tabPage_khachhang_Leave(object sender, EventArgs e) // xử lí khi rời tab
        {
            ResetValues_KH();
            if (btn_them_KH.Enabled == false)
                lb_them_KH.Text = "";
            btn_them_KH.Enabled = true;
        }
        private void panel5_Paint(object sender, PaintEventArgs e)
        {
            LoadData_KH();
            
        }

        private void btn_reset_KH_Click(object sender, EventArgs e)
        {
            this.Hide();
            fKhachHang kh = new fKhachHang();
            kh.ShowDialog();
        }

        private void fKhachHang_Load_1(object sender, EventArgs e)
        {

        }
    }
}
