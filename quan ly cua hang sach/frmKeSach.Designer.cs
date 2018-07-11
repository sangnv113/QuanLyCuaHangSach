namespace quan_ly_cua_hang_sach
{
    partial class frmKeSach
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKeSach));
            this.btnReload = new System.Windows.Forms.Button();
            this.btnluu = new System.Windows.Forms.Button();
            this.btnthoat = new System.Windows.Forms.Button();
            this.btnhuy = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTheloai = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnthem = new System.Windows.Forms.Button();
            this.txtMaKe = new System.Windows.Forms.TextBox();
            this.btnxoa = new System.Windows.Forms.Button();
            this.grbbtn = new System.Windows.Forms.GroupBox();
            this.btnsua = new System.Windows.Forms.Button();
            this.dgrNN = new System.Windows.Forms.DataGridView();
            this.grbthongtin = new System.Windows.Forms.GroupBox();
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
            this.btnReload.Location = new System.Drawing.Point(483, 340);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(78, 35);
            this.btnReload.TabIndex = 54;
            this.btnReload.Text = "Reload";
            this.btnReload.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // btnluu
            // 
            this.btnluu.Image = global::quan_ly_cua_hang_sach.Properties.Resources.save;
            this.btnluu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnluu.Location = new System.Drawing.Point(304, 24);
            this.btnluu.Name = "btnluu";
            this.btnluu.Size = new System.Drawing.Size(66, 43);
            this.btnluu.TabIndex = 39;
            this.btnluu.Text = "Lưu";
            this.btnluu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnluu.UseVisualStyleBackColor = true;
            this.btnluu.Click += new System.EventHandler(this.btnluu_Click);
            // 
            // btnthoat
            // 
            this.btnthoat.Image = global::quan_ly_cua_hang_sach.Properties.Resources.exit2;
            this.btnthoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnthoat.Location = new System.Drawing.Point(567, 340);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(73, 35);
            this.btnthoat.TabIndex = 52;
            this.btnthoat.Text = "Đóng";
            this.btnthoat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // btnhuy
            // 
            this.btnhuy.Image = global::quan_ly_cua_hang_sach.Properties.Resources.exit2;
            this.btnhuy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnhuy.Location = new System.Drawing.Point(304, 73);
            this.btnhuy.Name = "btnhuy";
            this.btnhuy.Size = new System.Drawing.Size(66, 39);
            this.btnhuy.TabIndex = 40;
            this.btnhuy.Text = "Hủy";
            this.btnhuy.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnhuy.UseVisualStyleBackColor = true;
            this.btnhuy.Click += new System.EventHandler(this.btnhuy_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(14, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Tên kệ sách";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtTheloai
            // 
            this.txtTheloai.FormattingEnabled = true;
            this.txtTheloai.Location = new System.Drawing.Point(116, 73);
            this.txtTheloai.Name = "txtTheloai";
            this.txtTheloai.Size = new System.Drawing.Size(121, 21);
            this.txtTheloai.TabIndex = 31;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(14, 81);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 13);
            this.label9.TabIndex = 27;
            this.label9.Text = "Thể loại";
            // 
            // btnthem
            // 
            this.btnthem.Image = global::quan_ly_cua_hang_sach.Properties.Resources.plus;
            this.btnthem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnthem.Location = new System.Drawing.Point(17, 15);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(83, 39);
            this.btnthem.TabIndex = 41;
            this.btnthem.Text = "Thêm";
            this.btnthem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // txtMaKe
            // 
            this.txtMaKe.Location = new System.Drawing.Point(116, 24);
            this.txtMaKe.Name = "txtMaKe";
            this.txtMaKe.Size = new System.Drawing.Size(121, 20);
            this.txtMaKe.TabIndex = 33;
            // 
            // btnxoa
            // 
            this.btnxoa.Image = global::quan_ly_cua_hang_sach.Properties.Resources.exit1;
            this.btnxoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnxoa.Location = new System.Drawing.Point(304, 15);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(83, 39);
            this.btnxoa.TabIndex = 42;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // grbbtn
            // 
            this.grbbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.grbbtn.Controls.Add(this.btnthem);
            this.grbbtn.Controls.Add(this.btnxoa);
            this.grbbtn.Controls.Add(this.btnsua);
            this.grbbtn.Location = new System.Drawing.Point(25, 259);
            this.grbbtn.Name = "grbbtn";
            this.grbbtn.Size = new System.Drawing.Size(403, 75);
            this.grbbtn.TabIndex = 53;
            this.grbbtn.TabStop = false;
            this.grbbtn.Text = "Chức Năng";
            // 
            // btnsua
            // 
            this.btnsua.Image = global::quan_ly_cua_hang_sach.Properties.Resources.edit;
            this.btnsua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsua.Location = new System.Drawing.Point(154, 15);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(83, 40);
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
            this.dgrNN.Location = new System.Drawing.Point(434, 90);
            this.dgrNN.Name = "dgrNN";
            this.dgrNN.Size = new System.Drawing.Size(206, 244);
            this.dgrNN.TabIndex = 50;
            this.dgrNN.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrNN_CellClick);
            // 
            // grbthongtin
            // 
            this.grbthongtin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.grbthongtin.Controls.Add(this.btnhuy);
            this.grbthongtin.Controls.Add(this.btnluu);
            this.grbthongtin.Controls.Add(this.label5);
            this.grbthongtin.Controls.Add(this.txtTheloai);
            this.grbthongtin.Controls.Add(this.label9);
            this.grbthongtin.Controls.Add(this.txtMaKe);
            this.grbthongtin.Location = new System.Drawing.Point(25, 90);
            this.grbthongtin.Name = "grbthongtin";
            this.grbthongtin.Size = new System.Drawing.Size(403, 155);
            this.grbthongtin.TabIndex = 51;
            this.grbthongtin.TabStop = false;
            this.grbthongtin.Text = "Thông Tin Kệ Sách";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Honeydew;
            this.label7.Location = new System.Drawing.Point(280, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 29);
            this.label7.TabIndex = 97;
            this.label7.Text = "KỆ SÁCH";
            // 
            // frmKeSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ClientSize = new System.Drawing.Size(645, 376);
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.grbbtn);
            this.Controls.Add(this.dgrNN);
            this.Controls.Add(this.grbthongtin);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmKeSach";
            this.Text = "frmKeSach";
            this.Load += new System.EventHandler(this.frmKeSach_Load);
            this.grbbtn.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgrNN)).EndInit();
            this.grbthongtin.ResumeLayout(false);
            this.grbthongtin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.Button btnluu;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.Button btnhuy;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox txtTheloai;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.TextBox txtMaKe;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.GroupBox grbbtn;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.DataGridView dgrNN;
        private System.Windows.Forms.GroupBox grbthongtin;
        private System.Windows.Forms.Label label7;
    }
}