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
    public partial class NhaCungCap : Form
    {
        public NhaCungCap()
        {
            InitializeComponent();
        }
        SqlConnection ketnoi = new SqlConnection(@"Data Source=LAPTOP-NPMJOOFR\SQLEXPRESS;Initial Catalog=CHBDT;Integrated Security=True");
        Class.nhacungcap Obj_NCC = new Class.nhacungcap();
        DataTable tblNCC;
        private void setFont_NCC() // set Font cho các textBox 
        {
            txtBox_mancc_NCC.Font = new Font("Time New Roman", 12);
            txtBox_tenncc_NCC.Font = new Font("Time New Roman", 12);
            MTBox_sdt_NCC.Font = new Font("Time New Roman", 12);
            txtBox_diachi_NCC.Font = new Font("Time New Roman", 12);
        }

        private void ResetValues_NCC() // reset giá trị cho các mục 
        {
            txtBox_mancc_NCC.Text = "";
            txtBox_tenncc_NCC.Text = "";
            MTBox_sdt_NCC.Text = "";
            txtBox_diachi_NCC.Text = "";



            btn_capnhat_NCC.Enabled = false;
            btn_xoa_NCC.Enabled = false;
            btn_luu_NCC.Enabled = false;
            btn_huy_NCC.Enabled = false;
            txtBox_mancc_NCC.Enabled = false;
        }

        private void getData_fromTable_NCC() // lấy dữ liệu từ bảng
        {
            ketnoi.Open();
            string sql = "select * from NHACUNGCAP";
            Obj_NCC.set_mancc(dgv_NCC.CurrentRow.Cells["MANCC"].Value.ToString());
            Obj_NCC.set_tenncc(dgv_NCC.CurrentRow.Cells["TENNCC"].Value.ToString());
            Obj_NCC.set_diachi(dgv_NCC.CurrentRow.Cells["DIACHI"].Value.ToString());
            Obj_NCC.set_sdt(dgv_NCC.CurrentRow.Cells["DIENTHOAI"].Value.ToString());
            ketnoi.Close();  // đóng kết nối
            LoadData_NhaCungCap();
        }

        private void getData_fromTxtBox_NCC() // lấy dữ liệu từ các TextBox
        {
            Obj_NCC.Reset();
            Obj_NCC.set_mancc(txtBox_mancc_NCC.Text.Trim().ToString());
            Obj_NCC.set_tenncc(txtBox_tenncc_NCC.Text.Trim().ToString());
            Obj_NCC.set_sdt(MTBox_sdt_NCC.Text.Trim().ToString());
            Obj_NCC.set_diachi(txtBox_diachi_NCC.Text.Trim().ToString());
        }



        private void LoadData_NhaCungCap() // tải dữ liệu vào DataGridView
        {

            ketnoi.Open();
            string sql = "select * from NHACUNGCAP";  // lay het du lieu trong bang sinh vien
            SqlCommand com = new SqlCommand(sql, ketnoi); //bat dau truy van
            com.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(com); //chuyen du lieu ve
            DataTable dt = new DataTable(); //tạo một kho ảo để lưu trữ dữ liệu
            da.Fill(dt);  // đổ dữ liệu vào kho
            ketnoi.Close();  // đóng kết nối
            dgv_NCC.DataSource = dt; //đổ dữ liệu vào datagridview

            // set Font cho tên cột
            dgv_NCC.Font = new Font("Time New Roman", 13);
            dgv_NCC.Columns[0].HeaderText = "Mã Nhà Cung Cấp";
            dgv_NCC.Columns[1].HeaderText = "Tên Nhà Cung Cấp";
            dgv_NCC.Columns[2].HeaderText = "Số Điện Thoại";
            dgv_NCC.Columns[3].HeaderText = "Địa Chỉ";

            // set Font cho dữ liệu hiển thị trong cột
            dgv_NCC.DefaultCellStyle.Font = new Font("Time New Roman", 12);

            // set kích thước cột
            dgv_NCC.Columns[0].Width = 150;
            dgv_NCC.Columns[1].Width = 200;
            dgv_NCC.Columns[2].Width = 115;
            dgv_NCC.Columns[3].Width = 120;
            
           

            //Không cho người dùng thêm dữ liệu trực tiếp
            dgv_NCC.AllowUserToAddRows = false;
            dgv_NCC.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void dgv_NCC_Click(object sender, EventArgs e) // xử lí khi click vào dataGridView
        {


            // nếu đang ở chế độ thêm mà user click vào DataGridView
            if (btn_them_NCC.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtBox_mancc_NCC.Focus();
                return;
            }

            // set giá trị cho các mục 
            getData_fromTable_NCC();
            txtBox_mancc_NCC.Text = Obj_NCC.get_mancc();
            txtBox_tenncc_NCC.Text = Obj_NCC.get_tenncc();
            MTBox_sdt_NCC.Text = Obj_NCC.get_sdt();
            txtBox_diachi_NCC.Text = Obj_NCC.get_diachi();

            // xử lí enable các nút
            btn_capnhat_NCC.Enabled = true;
            btn_xoa_NCC.Enabled = true;
            btn_huy_NCC.Enabled = true;
        }

        private void btn_them_NCC_Click(object sender, EventArgs e) // xử lí thêm
        {
            ResetValues_NCC();

            // set label thông báo cho người dùng biết là đang ở chế độ thêm
            lb_them_NCC.Text = "*Bạn đang ở chế độ thêm";

            // xử lí enable các nút
            txtBox_mancc_NCC.Enabled = true;
            txtBox_mancc_NCC.Focus();
            btn_huy_NCC.Enabled = true;
            btn_luu_NCC.Enabled = true;
            btn_them_NCC.Enabled = false;
        }

        private void btn_xoa_NCC_Click(object sender, EventArgs e) // xử lí xóa
        {

            // hỏi người dùng có chắc chắn xóa không ?
            if (MessageBox.Show("Bạn có chắc chắn muốn xoá không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ketnoi.Open();

                string sql = "DELETE NHACUNGCAP " +
                    "WHERE MANCC = N'" + txtBox_mancc_NCC.Text + "'";
                SqlCommand com = new SqlCommand(sql, ketnoi); //bat dau truy van
                com.CommandType = CommandType.Text;
                SqlDataAdapter da = new SqlDataAdapter(com); //chuyen du lieu ve
                DataTable dt = new DataTable(); //tạo một kho ảo để lưu trữ dữ liệu
                da.Fill(dt);  // đổ dữ liệu vào kho
                ketnoi.Close();
                LoadData_NhaCungCap();
                ResetValues_NCC();
            }
        }

        private void btn_capnhat_NCC_Click(object sender, EventArgs e) // xử lí cập nhật
        {
            getData_fromTxtBox_NCC();

            // TH chưa nhập đầy đủ dữ liệu
            if (!Obj_NCC.Check_Data())
            {
                MessageBox.Show("Bạn phải nhập đầy đủ dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            ketnoi.Open();
            // xử lí câu lệnh sql cập nhật dữ liệu
            string sql = "UPDATE NHACUNGCAP " +
                "SET TENNCC = N'" + Obj_NCC.get_tenncc() + "'," +
                "DIENTHOAI = '" + Obj_NCC.get_sdt() + "'," +
                "DIACHI = N'" + Obj_NCC.get_diachi() + "'" +
                "WHERE MANCC = '" + Obj_NCC.get_mancc() + "'";

            SqlCommand com = new SqlCommand(sql, ketnoi); //bat dau truy van
            com.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(com); //chuyen du lieu ve
            DataTable dt = new DataTable(); //tạo một kho ảo để lưu trữ dữ liệu
            da.Fill(dt);  // đổ dữ liệu vào kho
            ketnoi.Close();  // đóng kết nối

            LoadData_NhaCungCap();
            ResetValues_NCC();
        }

        private void btn_luu_NCC_Click(object sender, EventArgs e) // khi click vào nút lưu
        {
            getData_fromTxtBox_NCC();

            // TH chưa nhập đầy đủ dữ liệu
            if (!Obj_NCC.Check_Data())
            {
                MessageBox.Show("Bạn phải nhập đầy đủ dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // xử lí khi trùng mã nhân viên
            string sql = "SELECT " +
                "MANCC " +
                "FROM NHACUNGCAP " +
                "WHERE MANCC = N'" + Obj_NCC.get_mancc() + "'";
            if (Class.Functions.CheckKey(sql))
            {
                MessageBox.Show("Mã nhân viên đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtBox_mancc_NCC.Focus();
                return;
            }

            // xử lí câu lệnh sql thêm dữ liệu
            sql = "INSERT INTO NHACUNGCAP " +
                "VALUES('" + Obj_NCC.get_mancc() + "'," +
                "N'" + Obj_NCC.get_tenncc() + "'," +
                "'" + Obj_NCC.get_sdt() + "'," +
                 "N'" + Obj_NCC.get_diachi() + "')";
            SqlCommand com = new SqlCommand(sql, ketnoi); //bat dau truy van
            com.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(com); //chuyen du lieu ve
            DataTable dt = new DataTable(); //tạo một kho ảo để lưu trữ dữ liệu
            da.Fill(dt);  // đổ dữ liệu vào kho

            // tải dữ liệu lên dataGridView
            LoadData_NhaCungCap();
            ResetValues_NCC();

            btn_them_NCC.Enabled = true;
            lb_them_NCC.Text = "";
        }

        private void btn_huy_NCC_Click(object sender, EventArgs e) // xử lí hủy
        {
            // nếu đang ở chế độ thêm
            if (btn_them_NCC.Enabled == false)
                lb_them_NCC.Text = "";
            ResetValues_NCC();
            btn_them_NCC.Enabled = true;
        }

        private void btn_thoat_NCC_Click(object sender, EventArgs e) // xử lí thoát
        {
            this.Close();
        }

        private void tabPage_nhacungcap_Leave(object sender, EventArgs e) // xử lí khi rời tab
        {
            ResetValues_NCC();
            if (btn_them_NCC.Enabled == false)
                lb_them_NCC.Text = "";
            btn_them_NCC.Enabled = true;
        }

        private void dgv_NCC_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {
            LoadData_NhaCungCap();
        }

        private void MTBox_sdt_NCC_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void NhaCungCap_Load(object sender, EventArgs e)
        {

        }
    }
}
