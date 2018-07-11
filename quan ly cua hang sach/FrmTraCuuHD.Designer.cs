namespace quan_ly_cua_hang_sach
{
    partial class FrmTraCuuHD
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaHD = new System.Windows.Forms.TextBox();
            this.rdbNhap = new System.Windows.Forms.RadioButton();
            this.rdbBan = new System.Windows.Forms.RadioButton();
            this.dgrNN = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dt2 = new System.Windows.Forms.DateTimePicker();
            this.dt1 = new System.Windows.Forms.DateTimePicker();
            this.cbtk = new System.Windows.Forms.CheckBox();
            this.btntracuu = new System.Windows.Forms.Button();
            this.btnReload = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgrNN)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.OldLace;
            this.label1.Location = new System.Drawing.Point(38, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Nhập mã HD";
            // 
            // txtMaHD
            // 
            this.txtMaHD.Location = new System.Drawing.Point(151, 133);
            this.txtMaHD.Name = "txtMaHD";
            this.txtMaHD.Size = new System.Drawing.Size(100, 20);
            this.txtMaHD.TabIndex = 8;
            this.txtMaHD.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtMaHD_KeyUp);
            // 
            // rdbNhap
            // 
            this.rdbNhap.AutoSize = true;
            this.rdbNhap.ForeColor = System.Drawing.Color.OldLace;
            this.rdbNhap.Location = new System.Drawing.Point(151, 87);
            this.rdbNhap.Name = "rdbNhap";
            this.rdbNhap.Size = new System.Drawing.Size(94, 17);
            this.rdbNhap.TabIndex = 7;
            this.rdbNhap.TabStop = true;
            this.rdbNhap.Text = "Hóa đơn nhập";
            this.rdbNhap.UseVisualStyleBackColor = true;
            // 
            // rdbBan
            // 
            this.rdbBan.AutoSize = true;
            this.rdbBan.ForeColor = System.Drawing.Color.OldLace;
            this.rdbBan.Location = new System.Drawing.Point(41, 87);
            this.rdbBan.Name = "rdbBan";
            this.rdbBan.Size = new System.Drawing.Size(88, 17);
            this.rdbBan.TabIndex = 6;
            this.rdbBan.TabStop = true;
            this.rdbBan.Text = "Hóa đơn bán";
            this.rdbBan.UseVisualStyleBackColor = true;
            this.rdbBan.CheckedChanged += new System.EventHandler(this.rdbBan_CheckedChanged);
            // 
            // dgrNN
            // 
            this.dgrNN.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgrNN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrNN.Location = new System.Drawing.Point(14, 211);
            this.dgrNN.Name = "dgrNN";
            this.dgrNN.Size = new System.Drawing.Size(561, 262);
            this.dgrNN.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Honeydew;
            this.label7.Location = new System.Drawing.Point(181, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(250, 29);
            this.label7.TabIndex = 105;
            this.label7.Text = "TRA CỨU HÓA ĐƠN";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.PaleGreen;
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.dt2);
            this.groupBox4.Controls.Add(this.dt1);
            this.groupBox4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.groupBox4.Location = new System.Drawing.Point(276, 87);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(299, 118);
            this.groupBox4.TabIndex = 111;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Theo Ngày";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Coral;
            this.label8.Location = new System.Drawing.Point(13, 62);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 13);
            this.label8.TabIndex = 108;
            this.label8.Text = "Đến ngày";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Coral;
            this.label3.Location = new System.Drawing.Point(13, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 107;
            this.label3.Text = "Từ ngày";
            // 
            // dt2
            // 
            this.dt2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt2.Location = new System.Drawing.Point(99, 62);
            this.dt2.Name = "dt2";
            this.dt2.Size = new System.Drawing.Size(143, 20);
            this.dt2.TabIndex = 106;
            // 
            // dt1
            // 
            this.dt1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt1.Location = new System.Drawing.Point(99, 19);
            this.dt1.Name = "dt1";
            this.dt1.Size = new System.Drawing.Size(144, 20);
            this.dt1.TabIndex = 105;
            // 
            // cbtk
            // 
            this.cbtk.AutoSize = true;
            this.cbtk.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cbtk.Location = new System.Drawing.Point(276, 60);
            this.cbtk.Name = "cbtk";
            this.cbtk.Size = new System.Drawing.Size(122, 17);
            this.cbtk.TabIndex = 112;
            this.cbtk.Text = "Thống kê theo ngày";
            this.cbtk.UseVisualStyleBackColor = true;
            this.cbtk.CheckedChanged += new System.EventHandler(this.cbtk_CheckedChanged);
            // 
            // btntracuu
            // 
            this.btntracuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntracuu.ForeColor = System.Drawing.Color.Red;
            this.btntracuu.Location = new System.Drawing.Point(51, 170);
            this.btntracuu.Name = "btntracuu";
            this.btntracuu.Size = new System.Drawing.Size(78, 35);
            this.btntracuu.TabIndex = 113;
            this.btntracuu.Text = "OK";
            this.btntracuu.UseVisualStyleBackColor = true;
            this.btntracuu.Click += new System.EventHandler(this.btntracuu_Click);
            // 
            // btnReload
            // 
            this.btnReload.Image = global::quan_ly_cua_hang_sach.Properties.Resources.Refresh;
            this.btnReload.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReload.Location = new System.Drawing.Point(173, 170);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(78, 35);
            this.btnReload.TabIndex = 114;
            this.btnReload.Text = "Reload";
            this.btnReload.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // FrmTraCuuHD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ClientSize = new System.Drawing.Size(587, 485);
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.btntracuu);
            this.Controls.Add(this.cbtk);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMaHD);
            this.Controls.Add(this.rdbNhap);
            this.Controls.Add(this.rdbBan);
            this.Controls.Add(this.dgrNN);
            this.Name = "FrmTraCuuHD";
            this.Text = "FrmTraCuuHD";
            this.Load += new System.EventHandler(this.FrmTraCuuHD_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgrNN)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaHD;
        private System.Windows.Forms.RadioButton rdbNhap;
        private System.Windows.Forms.RadioButton rdbBan;
        private System.Windows.Forms.DataGridView dgrNN;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dt2;
        private System.Windows.Forms.DateTimePicker dt1;
        private System.Windows.Forms.CheckBox cbtk;
        private System.Windows.Forms.Button btntracuu;
        private System.Windows.Forms.Button btnReload;
    }
}