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
    public partial class frmTheLoai : Form
    {
        BLTheLoai dbS = new BLTheLoai();
        string err;
        bool Them;
        public frmTheLoai()
        {
            InitializeComponent();
        }

        private void dgrNN_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                int r = dgrNN.CurrentCell.RowIndex;
                // Chuyển thông tin lên panel
                this.txtMa.Text =
                dgrNN.Rows[r].Cells[0].Value.ToString();
                this.txtTen.Text =
                dgrNN.Rows[r].Cells[1].Value.ToString();
            }
            catch
            { }
        }

        private void frmTheLoai_Load(object sender, EventArgs e)
        {
            LoadData();
            grbthongtin.Enabled = false;
        }
        void LoadData()
        {
            try
            {

                // Đưa dữ liệu lên DataGridView
                dgrNN.DataSource = dbS.Lay();
                // Thay đổi độ rộng cột
                dgrNN.AutoResizeColumns();
                // Xóa trống các đối tượng trong Panel

                dgrNN_CellClick(null, null);
            }
            catch
            {
                MessageBox.Show("Không lấy được nội dung trong table Ngôn ngữ");
            }
        }

        private void btnsua_Click(object sender, EventArgs e)
        {

            try
            {
                grbthongtin.Enabled = true;
                Them = false;

                grbbtn.Enabled = false;
                dgrNN_CellClick(null, null);
                this.grbbtn.Enabled = false;
                this.txtTen.Focus();

            }
            catch
            {
                MessageBox.Show("ngu người");
            }
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {

            DialogResult traloi;
            // Hiện hộp thoại hỏi đáp
            traloi = MessageBox.Show("Thoát?", "Trả lời",
            MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            // Kiểm tra có nhắp chọn nút Ok không?
            if (traloi == DialogResult.OK) this.Close();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            Them = true;
            grbthongtin.Enabled = true;
            grbbtn.Enabled = false;
            // Xóa trống các đối tượng trong Panel
            this.txtMa.ResetText();
            this.txtTen.ResetText();


            this.txtMa.Focus();
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {

            try
            {
                int r = dgrNN.CurrentCell.RowIndex;
                string strma =
                dgrNN.Rows[r].Cells[0].Value.ToString();
                DialogResult traloi;
                traloi = MessageBox.Show("Chắc xóa mẫu tin này không?", "Trả lời",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (traloi == DialogResult.Yes)
                {
                    dbS.Xoa(ref err, strma);
                    LoadData();
                    MessageBox.Show("Đã xóa xong!");
                }
                else
                {
                    MessageBox.Show("Không thực hiện việc xóa mẫu tin!");
                }
            }
            catch
            {
                MessageBox.Show("Không xóa được!");
            }
        }

        private void btnhuy_Click(object sender, EventArgs e)
        {

            this.txtMa.ResetText();
            this.txtTen.ResetText();

            dgrNN_CellClick(null, null);
            grbbtn.Enabled = true;
            grbthongtin.Enabled = false;
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            if (Them)
            {


                try
                {
                    dbS.Them(this.txtMa.Text, this.txtTen.Text, ref err);

                    LoadData();

                    // Thông báo
                    MessageBox.Show("Đã thêm xong!");
                }
                catch
                {

                    MessageBox.Show("Không thêm được!");
                }
            }
            else
            {
                try
                {


                    dbS.CapNhat(this.txtMa.Text, this.txtTen.Text, ref err);
                    LoadData();
                    // Thông báo
                    MessageBox.Show("Đã sửa xong!");
                    grbthongtin.Enabled = false;
                    grbbtn.Enabled = true;
                }
                catch
                {
                    MessageBox.Show("Không sửa được!");
                }

            }
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            LoadData();
            textBox1.ResetText();
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            dgrNN.DataSource = dbS.timkiem(textBox1.Text);
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
