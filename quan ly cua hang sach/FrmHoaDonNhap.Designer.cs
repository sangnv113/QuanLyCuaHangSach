namespace quan_ly_cua_hang_sach
{
    partial class FrmHoaDonNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHoaDonNhap));
            this.btnReload = new System.Windows.Forms.Button();
            this.btnthoat = new System.Windows.Forms.Button();
            this.grbbtn = new System.Windows.Forms.GroupBox();
            this.btnthem = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.grbthongtin = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtmaNCC = new System.Windows.Forms.TextBox();
            this.txtNgaynhap = new System.Windows.Forms.DateTimePicker();
            this.btnhuy = new System.Windows.Forms.Button();
            this.btnluu = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtMa = new System.Windows.Forms.TextBox();
            this.dgrNN = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.grbbtn.SuspendLayout();
            this.grbthongtin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrNN)).BeginInit();
            this.SuspendLayout();
            // 
            // btnReload
            // 
            this.btnReload.Image = global::quan_ly_cua_hang_sach.Properties.Resources.Refresh;
            this.btnReload.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReload.Location = new System.Drawing.Point(517, 412);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(75, 37);
            this.btnReload.TabIndex = 79;
            this.btnReload.Text = "Reload";
            this.btnReload.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // btnthoat
            // 
            this.btnthoat.Image = global::quan_ly_cua_hang_sach.Properties.Resources.exit;
            this.btnthoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnthoat.Location = new System.Drawing.Point(598, 411);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(75, 38);
            this.btnthoat.TabIndex = 77;
            this.btnthoat.Text = "Đóng";
            this.btnthoat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // grbbtn
            // 
            this.grbbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.grbbtn.Controls.Add(this.button1);
            this.grbbtn.Controls.Add(this.btnthem);
            this.grbbtn.Controls.Add(this.btnxoa);
            this.grbbtn.Controls.Add(this.btnsua);
            this.grbbtn.Location = new System.Drawing.Point(37, 330);
            this.grbbtn.Name = "grbbtn";
            this.grbbtn.Size = new System.Drawing.Size(258, 75);
            this.grbbtn.TabIndex = 78;
            this.grbbtn.TabStop = false;
            this.grbbtn.Text = "Chức Năng";
            // 
            // btnthem
            // 
            this.btnthem.Image = global::quan_ly_cua_hang_sach.Properties.Resources.plus;
            this.btnthem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnthem.Location = new System.Drawing.Point(11, 19);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(75, 37);
            this.btnthem.TabIndex = 41;
            this.btnthem.Text = "Thêm";
            this.btnthem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(282, 34);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(75, 23);
            this.btnxoa.TabIndex = 42;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnsua
            // 
            this.btnsua.Image = global::quan_ly_cua_hang_sach.Properties.Resources.edit;
            this.btnsua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsua.Location = new System.Drawing.Point(177, 18);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(75, 38);
            this.btnsua.TabIndex = 1;
            this.btnsua.Text = "sửa";
            this.btnsua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // grbthongtin
            // 
            this.grbthongtin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.grbthongtin.Controls.Add(this.label1);
            this.grbthongtin.Controls.Add(this.txtmaNCC);
            this.grbthongtin.Controls.Add(this.txtNgaynhap);
            this.grbthongtin.Controls.Add(this.btnhuy);
            this.grbthongtin.Controls.Add(this.btnluu);
            this.grbthongtin.Controls.Add(this.label5);
            this.grbthongtin.Controls.Add(this.label9);
            this.grbthongtin.Controls.Add(this.txtMa);
            this.grbthongtin.Location = new System.Drawing.Point(37, 91);
            this.grbthongtin.Name = "grbthongtin";
            this.grbthongtin.Size = new System.Drawing.Size(258, 222);
            this.grbthongtin.TabIndex = 76;
            this.grbthongtin.TabStop = false;
            this.grbthongtin.Text = "Thông Tin Hóa Đơn Nhập";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(8, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 42;
            this.label1.Text = "Mã nhà cung cấp";
            // 
            // txtmaNCC
            // 
            this.txtmaNCC.Location = new System.Drawing.Point(105, 120);
            this.txtmaNCC.Name = "txtmaNCC";
            this.txtmaNCC.Size = new System.Drawing.Size(146, 20);
            this.txtmaNCC.TabIndex = 43;
            // 
            // txtNgaynhap
            // 
            this.txtNgaynhap.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtNgaynhap.Location = new System.Drawing.Point(104, 72);
            this.txtNgaynhap.Name = "txtNgaynhap";
            this.txtNgaynhap.Size = new System.Drawing.Size(147, 20);
            this.txtNgaynhap.TabIndex = 41;
            // 
            // btnhuy
            // 
            this.btnhuy.Image = global::quan_ly_cua_hang_sach.Properties.Resources.exit2;
            this.btnhuy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnhuy.Location = new System.Drawing.Point(176, 161);
            this.btnhuy.Name = "btnhuy";
            this.btnhuy.Size = new System.Drawing.Size(75, 35);
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
            this.btnluu.Location = new System.Drawing.Point(11, 161);
            this.btnluu.Name = "btnluu";
            this.btnluu.Size = new System.Drawing.Size(75, 35);
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
            this.label5.Location = new System.Drawing.Point(8, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Mã hóa đơn nhập";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(8, 72);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 13);
            this.label9.TabIndex = 27;
            this.label9.Text = "Ngày nhập";
            // 
            // txtMa
            // 
            this.txtMa.Location = new System.Drawing.Point(106, 29);
            this.txtMa.Name = "txtMa";
            this.txtMa.Size = new System.Drawing.Size(145, 20);
            this.txtMa.TabIndex = 33;
            // 
            // dgrNN
            // 
            this.dgrNN.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgrNN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrNN.Location = new System.Drawing.Point(319, 91);
            this.dgrNN.Name = "dgrNN";
            this.dgrNN.Size = new System.Drawing.Size(354, 314);
            this.dgrNN.TabIndex = 75;
            this.dgrNN.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrNN_CellClick);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(344, 65);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(200, 20);
            this.textBox1.TabIndex = 81;
            this.textBox1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(111, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(217, 13);
            this.label2.TabIndex = 80;
            this.label2.Text = "Tìm Kiếm Theo  Mã Hóa Đơn Hoăc Mã NCC";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Honeydew;
            this.label7.Location = new System.Drawing.Point(231, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(208, 29);
            this.label7.TabIndex = 96;
            this.label7.Text = "HÓA ĐƠN NHẬP";
            // 
            // button1
            // 
            this.button1.Image = global::quan_ly_cua_hang_sach.Properties.Resources.exit1;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(92, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 36);
            this.button1.TabIndex = 43;
            this.button1.Text = "Xóa";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmHoaDonNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ClientSize = new System.Drawing.Size(698, 455);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.grbbtn);
            this.Controls.Add(this.grbthongtin);
            this.Controls.Add(this.dgrNN);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmHoaDonNhap";
            this.Text = "frmHoaDonNhap";
            this.Load += new System.EventHandler(this.frmSachBanRa_Load);
            this.grbbtn.ResumeLayout(false);
            this.grbthongtin.ResumeLayout(false);
            this.grbthongtin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrNN)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.GroupBox grbbtn;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.GroupBox grbthongtin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtmaNCC;
        private System.Windows.Forms.DateTimePicker txtNgaynhap;
        private System.Windows.Forms.Button btnhuy;
        private System.Windows.Forms.Button btnluu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtMa;
        private System.Windows.Forms.DataGridView dgrNN;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
    }
}