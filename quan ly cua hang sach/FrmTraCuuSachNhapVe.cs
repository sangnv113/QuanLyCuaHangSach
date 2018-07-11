using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Linq;
using System.Data.Linq.Mapping;

using System.Drawing.Imaging;
using quan_ly_cua_hang_sach.BS_Layer;
using System.IO;

namespace quan_ly_cua_hang_sach
{
    public partial class FrmTraCuuSachNhapVe : Form
    {
        BLTraCuusachNhap dbS = new BLTraCuusachNhap();

        QuanLyNhaSachDataContext s = new QuanLyNhaSachDataContext();

        public bool BGia = false;
        public FrmTraCuuSachNhapVe()
        {
            InitializeComponent();
        }
        void LoadData()
        {
            try
            {

                // Đưa dữ liệu lên DataGridView
                dgvTTS.DataSource = dbS.Laysach();
                // Thay đổi độ rộng cột
                dgvTTS.AutoResizeColumns();

            }
            catch
            {
                MessageBox.Show("Không lấy được nội dung ");
            }
        }

        private void FrmTraCuuSachNhapVe_Load(object sender, EventArgs e)
        {
            var nxb = from nx in s.NXBs select nx;
            var nn = from n in s.NGONNGUs select n;
            var tl = from t in s.THELOAIs select t;
            foreach (var nx in nxb)
            {
                this.cbbnxb.Items.AddRange(new object[] { nx.TenNXB });
            }
            foreach (var n in nn)
            {
                this.cbbngonngu.Items.AddRange(new object[] { n.NgonNgu1 });
            }
            foreach (var t in tl)
            {
                this.cbbtheloai.Items.AddRange(new object[] { t.TheLoai1 });
            }

            LoadData();
            panegia.Enabled = false;
        }

        private void txtmasach_KeyUp(object sender, KeyEventArgs e)
        {
            btntk_Click(sender, e);
        }

        private void btntk_Click(object sender, EventArgs e)
        {
            try
            {
                if (int.Parse(txtgia1.Text.Trim()) > int.Parse(txtgia2.Text.Trim()))
                {
                    MessageBox.Show("Nhập giá từ thấp đến cao!!");
                }
            }
            catch
            {
                if (txtgia1.Text.Trim() != "" || txtgia2.Text.Trim() != "")
                {
                    MessageBox.Show("Giá không hợp lệ");
                }
            }
            dgvTTS.DataSource =
               dbS.timkiem(txtmasach.Text, cbbnxb.Text.Trim(), cbbtheloai.Text.Trim(), cbbngonngu.Text.Trim(),
               txttacgia.Text, txtgia1.Text.Trim(), txtgia2.Text.Trim(), BGia);
        }

        private void btnrefresh_Click(object sender, EventArgs e)
        {
            txtgia1.ResetText();
            txtgia2.ResetText();
            cbbnxb.ResetText();
            txttacgia.ResetText();
            cbbtheloai.ResetText();
            cbbngonngu.ResetText();
            txtmasach.ResetText();
            LoadData();
            panegia.Enabled = false;
            chbgia.Checked = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txttacgia_KeyUp(object sender, KeyEventArgs e)
        {
            btntk_Click(sender, e);
        }

        private void cbbnxb_KeyUp(object sender, KeyEventArgs e)
        {
            btntk_Click(sender, e);
        }

        private void cbbnxb_SelectedIndexChanged(object sender, EventArgs e)
        {
            btntk_Click(sender, e);
        }

        private void cbbtheloai_KeyUp(object sender, KeyEventArgs e)
        {
            btntk_Click(sender, e);
        }

        private void cbbtheloai_SelectedIndexChanged(object sender, EventArgs e)
        {
            btntk_Click(sender, e);
        }

        private void cbbngonngu_SelectedIndexChanged(object sender, EventArgs e)
        {
            btntk_Click(sender, e);
        }

        private void cbbngonngu_KeyUp(object sender, KeyEventArgs e)
        {
            btntk_Click(sender, e);
        }

        private void chbgia_CheckedChanged(object sender, EventArgs e)
        {
            if (chbgia.Checked == true)
            {
                BGia = true;
                panegia.Enabled = true;
            }
            else
            {
                BGia = false;
                panegia.Enabled = false;
            }
        }
    }
}
