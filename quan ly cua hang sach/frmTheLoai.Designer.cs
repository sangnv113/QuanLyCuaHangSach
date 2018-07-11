namespace quan_ly_cua_hang_sach
{
    partial class frmTheLoai
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
            this.btnReload = new System.Windows.Forms.Button();
            this.btnthoat = new System.Windows.Forms.Button();
            this.grbbtn = new System.Windows.Forms.GroupBox();
            this.btnthem = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.dgrNN = new System.Windows.Forms.DataGridView();
            this.grbthongtin = new System.Windows.Forms.GroupBox();
            this.btnhuy = new System.Windows.Forms.Button();
            this.btnluu = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTen = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtMa = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.grbbtn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrNN)).BeginInit();
            this.grbthongtin.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnReload
            // 
            this.btnReload.Image = global::quan_ly_cua_hang_sach.Properties.Resources.Refresh;
            this.btnReload.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReload.Location = new System.Drawing.Point(385, 348);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(75, 36);
            this.btnReload.TabIndex = 64;
            this.btnReload.Text = "Reload";
            this.btnReload.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // btnthoat
            // 
            this.btnthoat.Image = global::quan_ly_cua_hang_sach.Properties.Resources.exit1;
            this.btnthoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnthoat.Location = new System.Drawing.Point(466, 348);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(75, 36);
            this.btnthoat.TabIndex = 62;
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
            this.grbbtn.Location = new System.Drawing.Point(8, 281);
            this.grbbtn.Name = "grbbtn";
            this.grbbtn.Size = new System.Drawing.Size(327, 61);
            this.grbbtn.TabIndex = 63;
            this.grbbtn.TabStop = false;
            this.grbbtn.Text = "Chức Năng";
            // 
            // btnthem
            // 
            this.btnthem.Image = global::quan_ly_cua_hang_sach.Properties.Resources.plus;
            this.btnthem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnthem.Location = new System.Drawing.Point(6, 19);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(75, 33);
            this.btnthem.TabIndex = 41;
            this.btnthem.Text = "Thêm";
            this.btnthem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Image = global::quan_ly_cua_hang_sach.Properties.Resources.exit1;
            this.btnxoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnxoa.Location = new System.Drawing.Point(234, 19);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(75, 33);
            this.btnxoa.TabIndex = 42;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnsua
            // 
            this.btnsua.Image = global::quan_ly_cua_hang_sach.Properties.Resources.edit;
            this.btnsua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsua.Location = new System.Drawing.Point(121, 18);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(75, 34);
            this.btnsua.TabIndex = 1;
            this.btnsua.Text = "sửa";
            this.btnsua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // dgrNN
            // 
            this.dgrNN.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgrNN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrNN.Location = new System.Drawing.Point(341, 100);
            this.dgrNN.Name = "dgrNN";
            this.dgrNN.Size = new System.Drawing.Size(200, 242);
            this.dgrNN.TabIndex = 60;
            this.dgrNN.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrNN_CellClick);
            // 
            // grbthongtin
            // 
            this.grbthongtin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.grbthongtin.Controls.Add(this.btnhuy);
            this.grbthongtin.Controls.Add(this.btnluu);
            this.grbthongtin.Controls.Add(this.label5);
            this.grbthongtin.Controls.Add(this.txtTen);
            this.grbthongtin.Controls.Add(this.label9);
            this.grbthongtin.Controls.Add(this.txtMa);
            this.grbthongtin.Location = new System.Drawing.Point(8, 100);
            this.grbthongtin.Name = "grbthongtin";
            this.grbthongtin.Size = new System.Drawing.Size(327, 175);
            this.grbthongtin.TabIndex = 61;
            this.grbthongtin.TabStop = false;
            this.grbthongtin.Text = "Thông Tin Thể Loại Sách";
            // 
            // btnhuy
            // 
            this.btnhuy.Image = global::quan_ly_cua_hang_sach.Properties.Resources.exit2;
            this.btnhuy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnhuy.Location = new System.Drawing.Point(9, 97);
            this.btnhuy.Name = "btnhuy";
            this.btnhuy.Size = new System.Drawing.Size(75, 33);
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
            this.btnluu.Location = new System.Drawing.Point(234, 97);
            this.btnluu.Name = "btnluu";
            this.btnluu.Size = new System.Drawing.Size(75, 33);
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
            this.label5.Location = new System.Drawing.Point(59, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Mã thể loại";
            // 
            // txtTen
            // 
            this.txtTen.FormattingEnabled = true;
            this.txtTen.Location = new System.Drawing.Point(194, 61);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(115, 21);
            this.txtTen.TabIndex = 31;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(59, 64);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 13);
            this.label9.TabIndex = 27;
            this.label9.Text = "Tên thể loại";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // txtMa
            // 
            this.txtMa.Location = new System.Drawing.Point(196, 28);
            this.txtMa.Name = "txtMa";
            this.txtMa.Size = new System.Drawing.Size(113, 20);
            this.txtMa.TabIndex = 33;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(302, 69);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(200, 20);
            this.textBox1.TabIndex = 83;
            this.textBox1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(137, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 13);
            this.label2.TabIndex = 82;
            this.label2.Text = "Tìm kiếm theo  mã hoặc tên";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Honeydew;
            this.label7.Location = new System.Drawing.Point(205, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(129, 29);
            this.label7.TabIndex = 103;
            this.label7.Text = "THỂ LOẠI";
            // 
            // frmTheLoai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ClientSize = new System.Drawing.Size(553, 393);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.grbbtn);
            this.Controls.Add(this.dgrNN);
            this.Controls.Add(this.grbthongtin);
            this.Name = "frmTheLoai";
            this.Text = "frmTheLoai";
            this.Load += new System.EventHandler(this.frmTheLoai_Load);
            this.grbbtn.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgrNN)).EndInit();
            this.grbthongtin.ResumeLayout(false);
            this.grbthongtin.PerformLayout();
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
        private System.Windows.Forms.DataGridView dgrNN;
        private System.Windows.Forms.GroupBox grbthongtin;
        private System.Windows.Forms.Button btnhuy;
        private System.Windows.Forms.Button btnluu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox txtTen;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtMa;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
    }
}