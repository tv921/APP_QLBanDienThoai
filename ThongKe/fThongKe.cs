using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCHXM
{
    public partial class fThongKe : Form
    {
        public fThongKe()
        {
            InitializeComponent();
        }
        KetNoiDuLieu ketnoi = new KetNoiDuLieu();
        SqlDataAdapter bodocghi = new SqlDataAdapter();
        DataTable banghd = new DataTable();
        void Load_cmb_MAHH()
        {
            string sql = "select* from DONHANG";
            cmb_mahh.DataSource = ketnoi.DocDuLieu(sql);
            cmb_mahh.DisplayMember = "MADT";
            cmb_mahh.ValueMember = "MADT";

        }
        void HienThiDuLieu()
        {
            string sql = "select * from DONHANG";
            banghd = ketnoi.DocDuLieu(sql);
            bodocghi = ketnoi.docghi;
            dgvDonHang.DataSource = banghd;
        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel11_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bt_thongke_Click(object sender, EventArgs e)
        {
            // Lấy mã hàng hóa được chọn từ ComboBox
            string maSanPham = cmb_mahh.SelectedValue.ToString();

            // Lấy ngày tháng được chọn từ DateTimePicker
            DateTime selectedDate = dtp_thangtk.Value;

            // Định dạng lại ngày tháng theo yyyy-MM-dd
            string formattedDate = selectedDate.ToString("dd-MM-yyyy");

            // Lọc DataTable dựa trên mã hàng hóa và ngày tháng đã được định dạng lại
            DataRow[] filteredRows = banghd.Select($"MADT = '{maSanPham}' AND NGAYBAN = #{formattedDate}#");

            // Tính tổng số lượng và tổng tiền
            int totalQuantity = 0;
            decimal totalAmount = 0;

            foreach (DataRow row in filteredRows)
            {
                int soluong = Convert.ToInt32(row["SOLUONG"]);
                decimal tongtien = Convert.ToDecimal(row["TONGTIEN"]);

                totalQuantity += soluong;
                totalAmount += tongtien;
            }

            // Hiển thị kết quả thống kê trong MessageBox
            string report = $"Báo cáo: Số lượng sản phẩm '{maSanPham}' đã bán trong ngày {selectedDate.ToString("dd/MM/yyyy")}:\n\n";
            report += $"Số lượng: {totalQuantity}\n";
            report += $"Tổng tiền: {totalAmount}\n";

            MessageBox.Show(report, "Báo Cáo Số Lượng Sản Phẩm");

        }
    
    

        private void fThongKe_Load(object sender, EventArgs e)
        {
            Load_cmb_MAHH();
            HienThiDuLieu();
        }

        private void dgv_DThu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
