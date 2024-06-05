namespace QLCHXM
{
    partial class fThongKe
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label37 = new System.Windows.Forms.Label();
            this.dgvDonHang = new System.Windows.Forms.DataGridView();
            this.MADH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MAKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MADT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MANCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MANV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SOLUONG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NGAYBAN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TONGTIEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl_sub_thongke = new System.Windows.Forms.TabControl();
            this.tabPage_doanhthu = new System.Windows.Forms.TabPage();
            this.panel11 = new System.Windows.Forms.Panel();
            this.bt_thongke = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_mahh = new System.Windows.Forms.ComboBox();
            this.dtp_thangtk = new System.Windows.Forms.DateTimePicker();
            this.label38 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDonHang)).BeginInit();
            this.tabControl_sub_thongke.SuspendLayout();
            this.tabPage_doanhthu.SuspendLayout();
            this.panel11.SuspendLayout();
            this.SuspendLayout();
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label37.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label37.Location = new System.Drawing.Point(622, 31);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(211, 37);
            this.label37.TabIndex = 1;
            this.label37.Text = "DOANH THU";
            // 
            // dgvDonHang
            // 
            this.dgvDonHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDonHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MADH,
            this.MAKH,
            this.MADT,
            this.MANCC,
            this.MANV,
            this.SOLUONG,
            this.NGAYBAN,
            this.TONGTIEN});
            this.dgvDonHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDonHang.Location = new System.Drawing.Point(0, 354);
            this.dgvDonHang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvDonHang.Name = "dgvDonHang";
            this.dgvDonHang.RowHeadersWidth = 51;
            this.dgvDonHang.RowTemplate.Height = 24;
            this.dgvDonHang.Size = new System.Drawing.Size(1570, 298);
            this.dgvDonHang.TabIndex = 1;
            this.dgvDonHang.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_DThu_CellContentClick);
            // 
            // MADH
            // 
            this.MADH.DataPropertyName = "MADH";
            this.MADH.HeaderText = "MÃ DH";
            this.MADH.MinimumWidth = 6;
            this.MADH.Name = "MADH";
            this.MADH.Width = 125;
            // 
            // MAKH
            // 
            this.MAKH.DataPropertyName = "MAKH";
            this.MAKH.HeaderText = "MÃ KH";
            this.MAKH.MinimumWidth = 6;
            this.MAKH.Name = "MAKH";
            this.MAKH.Width = 125;
            // 
            // MADT
            // 
            this.MADT.DataPropertyName = "MADT";
            this.MADT.HeaderText = "MÃ ĐIỆN THOẠI";
            this.MADT.MinimumWidth = 6;
            this.MADT.Name = "MADT";
            this.MADT.Width = 125;
            // 
            // MANCC
            // 
            this.MANCC.DataPropertyName = "MANCC";
            this.MANCC.HeaderText = "MÃ NCC";
            this.MANCC.MinimumWidth = 6;
            this.MANCC.Name = "MANCC";
            this.MANCC.Width = 125;
            // 
            // MANV
            // 
            this.MANV.DataPropertyName = "MANV";
            this.MANV.HeaderText = "MÃ NV";
            this.MANV.MinimumWidth = 6;
            this.MANV.Name = "MANV";
            this.MANV.Width = 125;
            // 
            // SOLUONG
            // 
            this.SOLUONG.DataPropertyName = "SOLUONG";
            this.SOLUONG.HeaderText = "SỐ LƯỢNG";
            this.SOLUONG.MinimumWidth = 6;
            this.SOLUONG.Name = "SOLUONG";
            this.SOLUONG.Width = 125;
            // 
            // NGAYBAN
            // 
            this.NGAYBAN.DataPropertyName = "NGAYBAN";
            this.NGAYBAN.HeaderText = "NGÀY BÁN";
            this.NGAYBAN.MinimumWidth = 6;
            this.NGAYBAN.Name = "NGAYBAN";
            this.NGAYBAN.Width = 125;
            // 
            // TONGTIEN
            // 
            this.TONGTIEN.DataPropertyName = "TONGTIEN";
            this.TONGTIEN.HeaderText = "TỔNG TIỀN";
            this.TONGTIEN.MinimumWidth = 6;
            this.TONGTIEN.Name = "TONGTIEN";
            this.TONGTIEN.Width = 125;
            // 
            // tabControl_sub_thongke
            // 
            this.tabControl_sub_thongke.Controls.Add(this.tabPage_doanhthu);
            this.tabControl_sub_thongke.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl_sub_thongke.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tabControl_sub_thongke.Location = new System.Drawing.Point(0, 0);
            this.tabControl_sub_thongke.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl_sub_thongke.Name = "tabControl_sub_thongke";
            this.tabControl_sub_thongke.SelectedIndex = 0;
            this.tabControl_sub_thongke.Size = new System.Drawing.Size(1578, 692);
            this.tabControl_sub_thongke.TabIndex = 3;
            // 
            // tabPage_doanhthu
            // 
            this.tabPage_doanhthu.Controls.Add(this.dgvDonHang);
            this.tabPage_doanhthu.Controls.Add(this.panel11);
            this.tabPage_doanhthu.Location = new System.Drawing.Point(4, 36);
            this.tabPage_doanhthu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage_doanhthu.Name = "tabPage_doanhthu";
            this.tabPage_doanhthu.Size = new System.Drawing.Size(1570, 652);
            this.tabPage_doanhthu.TabIndex = 2;
            this.tabPage_doanhthu.Text = "  Doanh Thu  ";
            this.tabPage_doanhthu.UseVisualStyleBackColor = true;
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.bt_thongke);
            this.panel11.Controls.Add(this.label1);
            this.panel11.Controls.Add(this.cmb_mahh);
            this.panel11.Controls.Add(this.dtp_thangtk);
            this.panel11.Controls.Add(this.label38);
            this.panel11.Controls.Add(this.label37);
            this.panel11.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel11.Location = new System.Drawing.Point(0, 0);
            this.panel11.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(1570, 354);
            this.panel11.TabIndex = 0;
            this.panel11.Paint += new System.Windows.Forms.PaintEventHandler(this.panel11_Paint);
            // 
            // bt_thongke
            // 
            this.bt_thongke.Location = new System.Drawing.Point(833, 200);
            this.bt_thongke.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bt_thongke.Name = "bt_thongke";
            this.bt_thongke.Size = new System.Drawing.Size(143, 72);
            this.bt_thongke.TabIndex = 44;
            this.bt_thongke.Text = "Thống kê";
            this.bt_thongke.UseVisualStyleBackColor = true;
            this.bt_thongke.Click += new System.EventHandler(this.bt_thongke_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(226, 226);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 27);
            this.label1.TabIndex = 43;
            this.label1.Text = "Mã sản phẩm";
            // 
            // cmb_mahh
            // 
            this.cmb_mahh.FormattingEnabled = true;
            this.cmb_mahh.Location = new System.Drawing.Point(447, 220);
            this.cmb_mahh.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmb_mahh.Name = "cmb_mahh";
            this.cmb_mahh.Size = new System.Drawing.Size(204, 35);
            this.cmb_mahh.TabIndex = 42;
            // 
            // dtp_thangtk
            // 
            this.dtp_thangtk.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_thangtk.Location = new System.Drawing.Point(447, 122);
            this.dtp_thangtk.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtp_thangtk.Name = "dtp_thangtk";
            this.dtp_thangtk.Size = new System.Drawing.Size(236, 35);
            this.dtp_thangtk.TabIndex = 41;
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label38.ForeColor = System.Drawing.Color.Blue;
            this.label38.Location = new System.Drawing.Point(226, 122);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(78, 27);
            this.label38.TabIndex = 32;
            this.label38.Text = "Tháng ";
            // 
            // fThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1578, 692);
            this.Controls.Add(this.tabControl_sub_thongke);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "fThongKe";
            this.Text = "fThongKe";
            this.Load += new System.EventHandler(this.fThongKe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDonHang)).EndInit();
            this.tabControl_sub_thongke.ResumeLayout(false);
            this.tabPage_doanhthu.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.DataGridView dgvDonHang;
        private System.Windows.Forms.TabControl tabControl_sub_thongke;
        private System.Windows.Forms.TabPage tabPage_doanhthu;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_mahh;
        private System.Windows.Forms.DateTimePicker dtp_thangtk;
        private System.Windows.Forms.Button bt_thongke;
        private System.Windows.Forms.DataGridViewTextBoxColumn MADH;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn MADT;
        private System.Windows.Forms.DataGridViewTextBoxColumn MANCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn MANV;
        private System.Windows.Forms.DataGridViewTextBoxColumn SOLUONG;
        private System.Windows.Forms.DataGridViewTextBoxColumn NGAYBAN;
        private System.Windows.Forms.DataGridViewTextBoxColumn TONGTIEN;
    }
}