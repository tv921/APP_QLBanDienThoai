namespace QLCHXM.DangNhap
{
    partial class QuenMatKhau
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
            this.bt_laylaimk = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_emaildk = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_laylaimk
            // 
            this.bt_laylaimk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.bt_laylaimk.Location = new System.Drawing.Point(302, 509);
            this.bt_laylaimk.Name = "bt_laylaimk";
            this.bt_laylaimk.Size = new System.Drawing.Size(213, 51);
            this.bt_laylaimk.TabIndex = 26;
            this.bt_laylaimk.Text = "Lấy Lại Mật Khẩu";
            this.bt_laylaimk.UseVisualStyleBackColor = true;
            this.bt_laylaimk.Click += new System.EventHandler(this.bt_laylaimk_Click_1);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(70, 466);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(552, 40);
            this.label2.TabIndex = 25;
            this.label2.Text = "Kết quả:";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(70, 391);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 37);
            this.label1.TabIndex = 24;
            this.label1.Text = "Email đăng ký";
            // 
            // tb_emaildk
            // 
            this.tb_emaildk.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_emaildk.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tb_emaildk.Location = new System.Drawing.Point(273, 380);
            this.tb_emaildk.Name = "tb_emaildk";
            this.tb_emaildk.Size = new System.Drawing.Size(350, 44);
            this.tb_emaildk.TabIndex = 23;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QLCHXM.Properties.Resources.ve_moto_chi_bi_cartoon_de_thuong_motosaigon_7;
            this.pictureBox1.Location = new System.Drawing.Point(273, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(351, 315);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // QuenMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(694, 605);
            this.Controls.Add(this.bt_laylaimk);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_emaildk);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "QuenMatKhau";
            this.Text = "QuenMatKhau";
            this.Load += new System.EventHandler(this.QuenMatKhau_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_laylaimk;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_emaildk;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}