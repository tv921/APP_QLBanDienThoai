using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;

namespace QLCHXM
{
    public partial class HangHoa : Form
    {
        public HangHoa()
        {
            InitializeComponent();
        }
        SqlConnection ketnoi = new SqlConnection(@"Data Source=LAPTOP-NPMJOOFR\SQLEXPRESS;Initial Catalog=CHBDT;Integrated Security=True");
        DataTable tblHH; // Chứa dữ liệu bảng DIENTHOAI

        Class.hanghoa Obj_HH = new Class.hanghoa();


        private void setFont_HH() // set Font cho các textBox 
        {
            txtBox_maxe_HH.Font = new Font("Time New Roman", 12);
            txtBox_tenxe_HH.Font = new Font("Time New Roman", 12);
            txtBox_soluong_HH.Font = new Font("Time New Roman", 12);
            txtBox_gianhap_HH.Font = new Font("Time New Roman", 12);
            txtBox_giaban_HH.Font = new Font("Time New Roman", 12);
            txtBox_manhacungcap_HH.Font = new Font("Time New Roman", 12);
        }

        private void ResetValues_HH() // reset giá trị cho các mục 
        {

            txtBox_manhacungcap_HH.Text = "";
            txtBox_maxe_HH.Text = "";
            txtBox_tenxe_HH.Text = "";
            txtBox_soluong_HH.Text = "";
            txtBox_gianhap_HH.Text = "";
            txtBox_giaban_HH.Text = "";


            btn_capnhat_HH.Enabled = false;
            btn_xoa_HH.Enabled = false;
            btn_luu_HH.Enabled = false;
            btn_huy_HH.Enabled = false;
            txtBox_maxe_HH.Enabled = false;
        }

        private void getData_fromTable_HH() // lấy dữ liệu từ bảng
        {
            ketnoi.Open();
            string sql = "select * from DIENTHOAI";

            Obj_HH.set_manhacungcap(dgv_HH.CurrentRow.Cells["MADT"].Value.ToString());
            Obj_HH.set_maxe(dgv_HH.CurrentRow.Cells["TENDT"].Value.ToString());
            Obj_HH.set_tenxe(dgv_HH.CurrentRow.Cells["MANCC"].Value.ToString());
            Obj_HH.set_soluong(dgv_HH.CurrentRow.Cells["SOLUONG"].Value.ToString());
            Obj_HH.set_gianhap(dgv_HH.CurrentRow.Cells["GIANHAP"].Value.ToString());
            Obj_HH.set_giaban(dgv_HH.CurrentRow.Cells["GIABAN"].Value.ToString());

            ketnoi.Close();  // đóng kết nối
            LoadData_HangHoa();
        }

        private void getData_fromTxtBox_HH() // lấy dữ liệu từ các TextBox
        {
            Obj_HH.Reset();

            Obj_HH.set_manhacungcap(txtBox_manhacungcap_HH.Text.Trim().ToString());
            Obj_HH.set_maxe(txtBox_maxe_HH.Text.Trim().ToString());
            Obj_HH.set_tenxe(txtBox_tenxe_HH.Text.Trim().ToString());
            Obj_HH.set_soluong(txtBox_soluong_HH.Text.Trim().ToString());
            Obj_HH.set_gianhap(txtBox_gianhap_HH.Text.Trim().ToString());
            Obj_HH.set_giaban(txtBox_giaban_HH.Text.Trim().ToString());
        }

        private void LoadData_HangHoa() // tải dữ liệu vào DataGridView
        {
            ketnoi.Open();
            string sql = "select * from DIENTHOAI";  // lay het du lieu trong bang sinh vien
            SqlCommand com = new SqlCommand(sql, ketnoi); //bat dau truy van
            com.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(com); //chuyen du lieu ve
            DataTable dt = new DataTable(); //tạo một kho ảo để lưu trữ dữ liệu
            da.Fill(dt);  // đổ dữ liệu vào kho
            ketnoi.Close();  // đóng kết nối
            dgv_HH.DataSource = dt; //đổ dữ liệu vào datagridview

            // set Font cho tên cột
            dgv_HH.Font = new Font("Time New Roman", 13);
            dgv_HH.Columns[0].HeaderText = "Mã Điện Thoại";
            dgv_HH.Columns[1].HeaderText = "Tên Điện Thoại";
            dgv_HH.Columns[2].HeaderText = "Mã Nhà cung cấp";
            dgv_HH.Columns[3].HeaderText = "Số Lượng";
            dgv_HH.Columns[4].HeaderText = "Giá Nhập";
            dgv_HH.Columns[5].HeaderText = "Giá Bán";

            // set Font cho dữ liệu hiển thị trong cột
            dgv_HH.DefaultCellStyle.Font = new Font("Time New Roman", 12);

            // set kích thước cột
            dgv_HH.Columns[0].Width = 155;
            dgv_HH.Columns[1].Width = 160;
            dgv_HH.Columns[2].Width = 115;
            dgv_HH.Columns[3].Width = 115;
            dgv_HH.Columns[4].Width = 110;
            dgv_HH.Columns[5].Width = 100;


            //Không cho người dùng thêm dữ liệu trực tiếp
            dgv_HH.AllowUserToAddRows = false;
            dgv_HH.EditMode = DataGridViewEditMode.EditProgrammatically;

        }

        private void dgv_HH_Click(object sender, EventArgs e) // khi click vào dataGridView
        {


            // nếu đang ở chế độ thêm mà user click vào DataGridView
            if (btn_them_HH.Enabled == false)
            {
                MessageBox.Show("Bạn đang ở chế độ thêm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtBox_maxe_HH.Focus();
                return;
            }

            // set giá trị cho các TextBox, set ảnh
            getData_fromTable_HH();
            txtBox_maxe_HH.Text = Obj_HH.get_maxe();
            txtBox_manhacungcap_HH.Text = Obj_HH.get_manhacungcap();
            txtBox_tenxe_HH.Text = Obj_HH.get_tenxe();
            txtBox_soluong_HH.Text = Obj_HH.get_soluong();
            txtBox_gianhap_HH.Text = Obj_HH.get_gianhap();
            txtBox_giaban_HH.Text = Obj_HH.get_giaban();

            // xử lí enable các nút
            btn_capnhat_HH.Enabled = true;
            btn_xoa_HH.Enabled = true;
            btn_huy_HH.Enabled = true;
        }

        private void btn_them_HH_Click(object sender, EventArgs e) // xử lí thêm
        {
            ResetValues_HH();

            // set label thông báo cho người dùng biết là đang ở chế độ thêm
            lb_them_HH.ForeColor = System.Drawing.Color.Red;
            lb_them_HH.Text = "*Bạn đang ở chế độ thêm";

            // xử lí enable các nút
            txtBox_maxe_HH.Enabled = true;
            txtBox_maxe_HH.Focus();
            btn_huy_HH.Enabled = true;
            btn_luu_HH.Enabled = true;
            btn_them_HH.Enabled = false;
        }

        private void btn_xoa_HH_Click(object sender, EventArgs e) // xử lí xóa
        {
            // hỏi người dùng có chắc chắn xóa không ?
            if (MessageBox.Show("Bạn có chắc chắn muốn xoá không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                // thực hiện câu lệnh sql xóa
                ketnoi.Open();

                string sql = "DELETE DIENTHOAI " +
                    "WHERE MADT = N'" + txtBox_maxe_HH.Text + "'";
                SqlCommand com = new SqlCommand(sql, ketnoi); //bat dau truy van
                com.CommandType = CommandType.Text;
                SqlDataAdapter da = new SqlDataAdapter(com); //chuyen du lieu ve
                DataTable dt = new DataTable(); //tạo một kho ảo để lưu trữ dữ liệu
                da.Fill(dt);  // đổ dữ liệu vào kho
                ketnoi.Close();
                LoadData_HangHoa();
                ResetValues_HH();

            }
        }

        private void btn_capnhat_HH_Click(object sender, EventArgs e) // xử lí cập nhật
        {
            getData_fromTxtBox_HH();

            // TH nếu chưa nhập đầy đủ dữ liệu
            if (!Obj_HH.Check_Data())
            {
                MessageBox.Show("Bạn phải nhập đầy đủ dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            ketnoi.Open();
            // xử lí câu lệnh sql cập nhật dữ liệu

            string sql = "UPDATE DIENTHOAI " +
              "SET TENDT = N'" + Obj_HH.get_tenxe() + "'," +
              "MANCC = N'" + Obj_HH.get_manhacungcap() + "'," +
              "SOLUONG = '" + Obj_HH.get_soluong() + "'," +
              "GIANHAP = '" + Obj_HH.get_gianhap() + "'," +
              "GIABAN = N'" + Obj_HH.get_giaban() + "'" +
              "WHERE MADT = '" + Obj_HH.get_maxe() + "'";
            SqlCommand com = new SqlCommand(sql, ketnoi); //bat dau truy van
            com.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(com); //chuyen du lieu ve
            DataTable dt = new DataTable(); //tạo một kho ảo để lưu trữ dữ liệu
            da.Fill(dt);  // đổ dữ liệu vào kho
            ketnoi.Close();  // đóng kết nối
            LoadData_HangHoa();
            ResetValues_HH();

        }

        private void btn_luu_HH_Click(object sender, EventArgs e) // xử lí lưu
        {
            getData_fromTxtBox_HH();

            // TH nếu chưa nhập đầy đủ dữ liệu
            if (!Obj_HH.Check_Data())
            {
                MessageBox.Show("Bạn phải nhập đầy đủ dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // xử lí khi trùng mã điện thoại
            string sql = "SELECT " +
                "MADT " +
                "FROM DIENTHOAI " +
                "WHERE MADT = '" + Obj_HH.get_maxe() + "'";
            if (Class.Functions.CheckKey(sql))
            {
                MessageBox.Show("Mã điện thoại đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtBox_maxe_HH.Focus();
                return;
            }

            // xử lí câu lệnh sql thêm dữ liệu
            sql = "INSERT INTO DIENTHOAI " +
                "VALUES('" + Obj_HH.get_maxe() +
                "',N'" + Obj_HH.get_tenxe() +
                "','" + Obj_HH.get_manhacungcap() +
                "','" + Obj_HH.get_soluong() +
                "','" + Obj_HH.get_gianhap() +
                "','" + Obj_HH.get_giaban() + "')";

            SqlCommand com = new SqlCommand(sql, ketnoi); //bat dau truy van
            com.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(com); //chuyen du lieu ve
            DataTable dt = new DataTable(); //tạo một kho ảo để lưu trữ dữ liệu
            da.Fill(dt);  // đổ dữ liệu vào kho

            // tải dữ liệu lên dataGridView
            LoadData_HangHoa();
            ResetValues_HH();

            btn_them_HH.Enabled = true;
            lb_them_HH.Text = "";
        }

        private void btn_huy_HH_Click(object sender, EventArgs e) // xử lí hủy
        {
            // nếu đang ở chế độ thêm
            if (btn_them_HH.Enabled == false)
                lb_them_HH.Text = "";

            // nếu đang ở chế độ tìm kiếm

            LoadData_HangHoa();



            ResetValues_HH();
            btn_them_HH.Enabled = true;
        }

        private void btn_thoat_HH_Click(object sender, EventArgs e) // xử lí thoát
        {
            this.Close();
        }

        private void tabPage_hanghoa_Leave(object sender, EventArgs e) // xử lí khi rời tab
        {
            ResetValues_HH();

            if (btn_them_HH.Enabled == false)
                lb_them_HH.Text = "";
            btn_them_HH.Enabled = true;
        }

        private void btn_timkiem_HH_Click(object sender, EventArgs e) // tìm kiếm theo hãng điện thoại
        {

            // nếu đang ở chế độ thêm mà user click vào nút tìm kiếm
            if (btn_them_HH.Enabled == false)
            {
                MessageBox.Show("Bạn đang ở chế độ thêm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtBox_maxe_HH.Focus();
                return;
            }

            // TH nếu chưa chọn tên hãng 
            if (txtBox_manhacungcap_HH.Text.Trim().Length == 0)
            {
                MessageBox.Show("Vui lòng chọn tên hãng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }


            // nếu tìm ko ra dữ liệu 
            if (tblHH.Rows.Count == 0)
                MessageBox.Show("Không có hàng của hãng " + txtBox_manhacungcap_HH.Text, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private void HangHoa_Load(object sender, EventArgs e)
        {

        }

        private void panel_HangHoa_Paint(object sender, PaintEventArgs e)
        {
            LoadData_HangHoa();
        }

        private void txtBox_madt_DT_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_timkiem_NCC_Click(object sender, EventArgs e)
        {

        }

        private void HangHoa_Load_1(object sender, EventArgs e)
        {

        }

        private void dgv_HH_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void bttk_Click(object sender, EventArgs e)
        {

            string searchText = textBox1.Text.Trim().ToLower();

            foreach (DataGridViewRow row in dgv_HH.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value != null && cell.Value.ToString().ToLower().Contains(searchText))
                    {
                        // Hiển thị dòng có giá trị tìm kiếm
                        row.Visible = true;
                        break;
                    }
                    else
                    {
                        // Ẩn dòng không có giá trị tìm kiếm
                        row.Visible = false;
                    }
                }
            }
        }

    }
}


