namespace QLCHXM.DangNhap
{
    partial class Form_Dang_Nhap
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
            this.btnThoat = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bt_dangnhap = new System.Windows.Forms.Button();
            this.linkLabel_Dangky = new System.Windows.Forms.LinkLabel();
            this.linkLabel_Quenmatkhau = new System.Windows.Forms.LinkLabel();
            this.tb_matkhau = new System.Windows.Forms.TextBox();
            this.tb_tentaikhoan = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(306, 559);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(147, 60);
            this.btnThoat.TabIndex = 28;
            this.btnThoat.Text = "Exit";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click_2);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(165, 429);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 29);
            this.label2.TabIndex = 27;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(165, 340);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 29);
            this.label1.TabIndex = 26;
            this.label1.Text = "User name";
            // 
            // bt_dangnhap
            // 
            this.bt_dangnhap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bt_dangnhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_dangnhap.Location = new System.Drawing.Point(543, 559);
            this.bt_dangnhap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_dangnhap.Name = "bt_dangnhap";
            this.bt_dangnhap.Size = new System.Drawing.Size(170, 60);
            this.bt_dangnhap.TabIndex = 25;
            this.bt_dangnhap.Text = "Login";
            this.bt_dangnhap.UseVisualStyleBackColor = false;
            this.bt_dangnhap.Click += new System.EventHandler(this.bt_dangnhap_Click_2);
            // 
            // linkLabel_Dangky
            // 
            this.linkLabel_Dangky.ActiveLinkColor = System.Drawing.Color.Maroon;
            this.linkLabel_Dangky.AutoSize = true;
            this.linkLabel_Dangky.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.linkLabel_Dangky.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.linkLabel_Dangky.Location = new System.Drawing.Point(300, 481);
            this.linkLabel_Dangky.Name = "linkLabel_Dangky";
            this.linkLabel_Dangky.Size = new System.Drawing.Size(99, 29);
            this.linkLabel_Dangky.TabIndex = 24;
            this.linkLabel_Dangky.TabStop = true;
            this.linkLabel_Dangky.Text = "Sign Up";
            this.linkLabel_Dangky.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_Dangky_LinkClicked_2);
            // 
            // linkLabel_Quenmatkhau
            // 
            this.linkLabel_Quenmatkhau.AutoSize = true;
            this.linkLabel_Quenmatkhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.linkLabel_Quenmatkhau.Location = new System.Drawing.Point(537, 481);
            this.linkLabel_Quenmatkhau.Name = "linkLabel_Quenmatkhau";
            this.linkLabel_Quenmatkhau.Size = new System.Drawing.Size(183, 29);
            this.linkLabel_Quenmatkhau.TabIndex = 23;
            this.linkLabel_Quenmatkhau.TabStop = true;
            this.linkLabel_Quenmatkhau.Text = "Forget pasword";
            this.linkLabel_Quenmatkhau.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_Quenmatkhau_LinkClicked_1);
            // 
            // tb_matkhau
            // 
            this.tb_matkhau.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_matkhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tb_matkhau.Location = new System.Drawing.Point(318, 419);
            this.tb_matkhau.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_matkhau.Name = "tb_matkhau";
            this.tb_matkhau.PasswordChar = '*';
            this.tb_matkhau.Size = new System.Drawing.Size(410, 44);
            this.tb_matkhau.TabIndex = 22;
            // 
            // tb_tentaikhoan
            // 
            this.tb_tentaikhoan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_tentaikhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tb_tentaikhoan.Location = new System.Drawing.Point(318, 330);
            this.tb_tentaikhoan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_tentaikhoan.Name = "tb_tentaikhoan";
            this.tb_tentaikhoan.Size = new System.Drawing.Size(410, 44);
            this.tb_tentaikhoan.TabIndex = 21;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QLCHXM.Properties.Resources.icon_user_slide__1_;
            this.pictureBox1.Location = new System.Drawing.Point(360, 14);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(315, 282);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // Form_Dang_Nhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(882, 629);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt_dangnhap);
            this.Controls.Add(this.linkLabel_Dangky);
            this.Controls.Add(this.linkLabel_Quenmatkhau);
            this.Controls.Add(this.tb_matkhau);
            this.Controls.Add(this.tb_tentaikhoan);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form_Dang_Nhap";
            this.Text = "Form_Dang_Nhap";
            this.Load += new System.EventHandler(this.Form_Dang_Nhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_dangnhap;
        private System.Windows.Forms.LinkLabel linkLabel_Dangky;
        private System.Windows.Forms.LinkLabel linkLabel_Quenmatkhau;
        private System.Windows.Forms.TextBox tb_matkhau;
        private System.Windows.Forms.TextBox tb_tentaikhoan;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}