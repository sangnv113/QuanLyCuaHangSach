namespace quan_ly_cua_hang_sach
{
    partial class frmBanHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBanHang));
            this.dgrNN = new System.Windows.Forms.DataGridView();
            this.txtMasach = new System.Windows.Forms.TextBox();
            this.btnsua = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnthem = new System.Windows.Forms.Button();
            this.btnthoat = new System.Windows.Forms.Button();
            this.grbbtn = new System.Windows.Forms.GroupBox();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnReload = new System.Windows.Forms.Button();
            this.txtiatien = new System.Windows.Forms.TextBox();
            this.btnhuy = new System.Windows.Forms.Button();
            this.btnluu = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtMaHDban = new System.Windows.Forms.TextBox();
            this.grbthongtin = new System.Windows.Forms.GroupBox();
            this.lbltong = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtdatetime = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txtsoluong = new System.Windows.Forms.NumericUpDown();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtgiamgia = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btntcs = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.txttensach = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgrNN)).BeginInit();
            this.grbbtn.SuspendLayout();
            this.grbthongtin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtsoluong)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgrNN
            // 
            this.dgrNN.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgrNN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrNN.Location = new System.Drawing.Point(359, 82);
            this.dgrNN.Name = "dgrNN";
            this.dgrNN.Size = new System.Drawing.Size(391, 367);
            this.dgrNN.TabIndex = 77;
            this.dgrNN.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrNN_CellClick);
            // 
            // txtMasach
            // 
            this.txtMasach.Location = new System.Drawing.Point(95, 62);
            this.txtMasach.Name = "txtMasach";
            this.txtMasach.Size = new System.Drawing.Size(110, 20);
            this.txtMasach.TabIndex = 44;
            this.txtMasach.TextChanged += new System.EventHandler(this.txtMasach_TextChanged);
            this.txtMasach.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtMasach_KeyUp);
            // 
            // btnsua
            // 
            this.btnsua.Image = global::quan_ly_cua_hang_sach.Properties.Resources.edit;
            this.btnsua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsua.Location = new System.Drawing.Point(130, 15);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(75, 34);
            this.btnsua.TabIndex = 1;
            this.btnsua.Text = "sửa";
            this.btnsua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(7, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 42;
            this.label1.Text = "Giá tiền";
            // 
            // btnthem
            // 
            this.btnthem.Image = global::quan_ly_cua_hang_sach.Properties.Resources.plus;
            this.btnthem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnthem.Location = new System.Drawing.Point(9, 13);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(75, 35);
            this.btnthem.TabIndex = 41;
            this.btnthem.Text = "Thêm";
            this.btnthem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // btnthoat
            // 
            this.btnthoat.Image = global::quan_ly_cua_hang_sach.Properties.Resources.exit2;
            this.btnthoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnthoat.Location = new System.Drawing.Point(675, 455);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(75, 40);
            this.btnthoat.TabIndex = 79;
            this.btnthoat.Text = "Đóng";
            this.btnthoat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // grbbtn
            // 
            this.grbbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.grbbtn.Controls.Add(this.btnthem);
            this.grbbtn.Controls.Add(this.btnxoa);
            this.grbbtn.Controls.Add(this.btnsua);
            this.grbbtn.Location = new System.Drawing.Point(15, 385);
            this.grbbtn.Name = "grbbtn";
            this.grbbtn.Size = new System.Drawing.Size(338, 64);
            this.grbbtn.TabIndex = 80;
            this.grbbtn.TabStop = false;
            this.grbbtn.Text = "Chức Năng";
            // 
            // btnxoa
            // 
            this.btnxoa.Image = global::quan_ly_cua_hang_sach.Properties.Resources.exit1;
            this.btnxoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnxoa.Location = new System.Drawing.Point(245, 13);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(75, 36);
            this.btnxoa.TabIndex = 42;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnReload
            // 
            this.btnReload.Image = global::quan_ly_cua_hang_sach.Properties.Resources.Refresh;
            this.btnReload.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReload.Location = new System.Drawing.Point(594, 455);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(75, 40);
            this.btnReload.TabIndex = 81;
            this.btnReload.Text = "Reload";
            this.btnReload.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // txtiatien
            // 
            this.txtiatien.Enabled = false;
            this.txtiatien.Location = new System.Drawing.Point(95, 144);
            this.txtiatien.Name = "txtiatien";
            this.txtiatien.Size = new System.Drawing.Size(110, 20);
            this.txtiatien.TabIndex = 43;
            // 
            // btnhuy
            // 
            this.btnhuy.Image = global::quan_ly_cua_hang_sach.Properties.Resources.exit2;
            this.btnhuy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnhuy.Location = new System.Drawing.Point(247, 151);
            this.btnhuy.Name = "btnhuy";
            this.btnhuy.Size = new System.Drawing.Size(73, 42);
            this.btnhuy.TabIndex = 40;
            this.btnhuy.Text = "Hủy";
            this.btnhuy.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnhuy.UseVisualStyleBackColor = true;
            this.btnhuy.Click += new System.EventHandler(this.btnhuy_Click);
            // 
            // btnluu
            // 
            this.btnluu.Image = global::quan_ly_cua_hang_sach.Properties.Resources.save;
            this.btnluu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnluu.Location = new System.Drawing.Point(245, 84);
            this.btnluu.Name = "btnluu";
            this.btnluu.Size = new System.Drawing.Size(75, 43);
            this.btnluu.TabIndex = 39;
            this.btnluu.Text = "Lưu";
            this.btnluu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnluu.UseVisualStyleBackColor = true;
            this.btnluu.Click += new System.EventHandler(this.btnluu_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(6, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Mã hóa đơn bán";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(7, 69);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 13);
            this.label9.TabIndex = 27;
            this.label9.Text = "Mã Sách";
            // 
            // txtMaHDban
            // 
            this.txtMaHDban.Location = new System.Drawing.Point(95, 25);
            this.txtMaHDban.Name = "txtMaHDban";
            this.txtMaHDban.Size = new System.Drawing.Size(110, 20);
            this.txtMaHDban.TabIndex = 33;
            // 
            // grbthongtin
            // 
            this.grbthongtin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.grbthongtin.Controls.Add(this.txttensach);
            this.grbthongtin.Controls.Add(this.label11);
            this.grbthongtin.Controls.Add(this.lbltong);
            this.grbthongtin.Controls.Add(this.label6);
            this.grbthongtin.Controls.Add(this.label4);
            this.grbthongtin.Controls.Add(this.txtdatetime);
            this.grbthongtin.Controls.Add(this.label3);
            this.grbthongtin.Controls.Add(this.txtsoluong);
            this.grbthongtin.Controls.Add(this.txtMasach);
            this.grbthongtin.Controls.Add(this.label1);
            this.grbthongtin.Controls.Add(this.txtiatien);
            this.grbthongtin.Controls.Add(this.btnhuy);
            this.grbthongtin.Controls.Add(this.btnluu);
            this.grbthongtin.Controls.Add(this.label5);
            this.grbthongtin.Controls.Add(this.label9);
            this.grbthongtin.Controls.Add(this.txtMaHDban);
            this.grbthongtin.Location = new System.Drawing.Point(15, 86);
            this.grbthongtin.Name = "grbthongtin";
            this.grbthongtin.Size = new System.Drawing.Size(338, 293);
            this.grbthongtin.TabIndex = 78;
            this.grbthongtin.TabStop = false;
            this.grbthongtin.Text = "Thông Tin Bán Hàng";
            // 
            // lbltong
            // 
            this.lbltong.AutoSize = true;
            this.lbltong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltong.ForeColor = System.Drawing.Color.Crimson;
            this.lbltong.Location = new System.Drawing.Point(224, 261);
            this.lbltong.Name = "lbltong";
            this.lbltong.Size = new System.Drawing.Size(16, 16);
            this.lbltong.TabIndex = 52;
            this.lbltong.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(92, 259);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 18);
            this.label6.TabIndex = 51;
            this.label6.Text = "Tổng cộng:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(8, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 50;
            this.label4.Text = "Ngày hiện tại";
            // 
            // txtdatetime
            // 
            this.txtdatetime.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtdatetime.Location = new System.Drawing.Point(95, 219);
            this.txtdatetime.Name = "txtdatetime";
            this.txtdatetime.Size = new System.Drawing.Size(110, 20);
            this.txtdatetime.TabIndex = 49;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(8, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 48;
            this.label3.Text = "Số lượng";
            // 
            // txtsoluong
            // 
            this.txtsoluong.Location = new System.Drawing.Point(95, 184);
            this.txtsoluong.Name = "txtsoluong";
            this.txtsoluong.Size = new System.Drawing.Size(110, 20);
            this.txtsoluong.TabIndex = 47;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(303, 53);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(200, 20);
            this.textBox1.TabIndex = 92;
            this.textBox1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(191, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 91;
            this.label2.Text = "Tìm kiếm theo  mã ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Honeydew;
            this.label7.Location = new System.Drawing.Point(255, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(144, 29);
            this.label7.TabIndex = 93;
            this.label7.Text = "BÁN HÀNG";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Teal;
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtgiamgia);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(606, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(144, 67);
            this.groupBox1.TabIndex = 94;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Giảm giá";
            // 
            // txtgiamgia
            // 
            this.txtgiamgia.Location = new System.Drawing.Point(46, 25);
            this.txtgiamgia.Name = "txtgiamgia";
            this.txtgiamgia.Size = new System.Drawing.Size(47, 26);
            this.txtgiamgia.TabIndex = 53;
            this.txtgiamgia.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(26, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(14, 20);
            this.label8.TabIndex = 54;
            this.label8.Text = "-";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(99, 28);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(23, 20);
            this.label10.TabIndex = 55;
            this.label10.Text = "%";
            // 
            // btntcs
            // 
            this.btntcs.Location = new System.Drawing.Point(24, 13);
            this.btntcs.Name = "btntcs";
            this.btntcs.Size = new System.Drawing.Size(83, 44);
            this.btntcs.TabIndex = 95;
            this.btntcs.Text = "Tra cứu sách";
            this.btntcs.UseVisualStyleBackColor = true;
            this.btntcs.Click += new System.EventHandler(this.btntcs_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(7, 114);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 13);
            this.label11.TabIndex = 53;
            this.label11.Text = "Tên sách";
            // 
            // txttensach
            // 
            this.txttensach.Enabled = false;
            this.txttensach.Location = new System.Drawing.Point(95, 107);
            this.txttensach.Name = "txttensach";
            this.txttensach.Size = new System.Drawing.Size(110, 20);
            this.txttensach.TabIndex = 54;
            // 
            // frmBanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ClientSize = new System.Drawing.Size(762, 496);
            this.Controls.Add(this.btntcs);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.dgrNN);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.grbbtn);
            this.Controls.Add(this.grbthongtin);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmBanHang";
            this.Text = "frmBanHang";
            this.Load += new System.EventHandler(this.frmBanHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgrNN)).EndInit();
            this.grbbtn.ResumeLayout(false);
            this.grbthongtin.ResumeLayout(false);
            this.grbthongtin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtsoluong)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgrNN;
        private System.Windows.Forms.TextBox txtMasach;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.GroupBox grbbtn;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.TextBox txtiatien;
        private System.Windows.Forms.Button btnhuy;
        private System.Windows.Forms.Button btnluu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtMaHDban;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.GroupBox grbthongtin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown txtsoluong;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker txtdatetime;
        private System.Windows.Forms.Label lbltong;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtgiamgia;
        private System.Windows.Forms.Button btntcs;
        private System.Windows.Forms.TextBox txttensach;
        private System.Windows.Forms.Label label11;
    }
}