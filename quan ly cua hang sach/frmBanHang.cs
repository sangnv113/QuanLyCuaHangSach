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
    public partial class frmBanHang : Form
    {
        BLSachBanRa dbS = new BLSachBanRa();
        BLHoaDonBan hdb = new BLHoaDonBan();
        BLBanHang bh = new BLBanHang();
        string err;
        bool Them;
        public frmBanHang()
        {
            InitializeComponent();
        }

        private void dgrNN_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                int r = dgrNN.CurrentCell.RowIndex;
                // Chuyển thông tin lên panel
                this.txtMaHDban.Text =
                dgrNN.Rows[r].Cells[0].Value.ToString();
                this.txtMasach.Text =
                dgrNN.Rows[r].Cells[1].Value.ToString();
                this.txtiatien.Text =
                dgrNN.Rows[r].Cells[2].Value.ToString();
                this.txtsoluong.Text =
                dgrNN.Rows[r].Cells[3].Value.ToString();
            }
            catch
            { }
        }

        private void frmBanHang_Load(object sender, EventArgs e)
        {
           LoadData();
            grbthongtin.Enabled = false;
        }
        void LoadData()
        {
            try
            {
                
                // Đưa dữ liệu lên DataGridView
                dgrNN.DataSource = bh.Lay(txtMaHDban.Text);
                // Thay đổi độ rộng cột
                dgrNN.AutoResizeColumns();
                // Xóa trống các đối tượng trong Panel

                dgrNN_CellClick(null, null);
            }
            catch
            {
                MessageBox.Show("Không có nội dung ");
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
                this.txtMasach.Focus();

            }
            catch
            {
                MessageBox.Show("lỗi");
            }
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            Them = true;
            grbthongtin.Enabled = true;
            grbbtn.Enabled = false;
            // Xóa trống các đối tượng trong Panel
            this.txtMaHDban.ResetText();
            this.txtMasach.ResetText();
            this.txtiatien.ResetText();
            this.txttensach.ResetText();
            this.txtsoluong.Value = 1;
            this.txtMaHDban.Focus();
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            try
            {
                int r = dgrNN.CurrentCell.RowIndex;
                string strma =
                dgrNN.Rows[r].Cells[0].Value.ToString();
                string strmasach =
                dgrNN.Rows[r].Cells[1].Value.ToString();
                DialogResult traloi;
                traloi = MessageBox.Show("Chắc xóa mẫu tin này không?", "Trả lời",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (traloi == DialogResult.Yes)
                {
                    dbS.Xoa(ref err, strma, strmasach);
                    LoadData();
                    MessageBox.Show("Đã xóa xong!");
                    if (hdb.DemMa(txtMaHDban.Text) == 0)
                    {
                        hdb.Xoa(ref err, txtMaHDban.Text);
                    };

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
            this.txtMaHDban.ResetText();
            this.txtMasach.ResetText();
            this.txtiatien.ResetText();
            this.txttensach.ResetText();
            this.txtsoluong.Value = 1;
            dgrNN_CellClick(null, null);
            grbbtn.Enabled = true;
            grbthongtin.Enabled = false;
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            QuanLyNhaSachDataContext s = new QuanLyNhaSachDataContext();
            var vt = from v in s.HoaDonBans select v;
            foreach (var p in vt)
            {
                if (p.MaHoaDonBan.Trim() == txtMaHDban.Text.Trim())
                {
                    DialogResult traloi;
                    traloi = MessageBox.Show("Mã HD đã tồn tại bạn có muốn tiếp tục?", "Trả lời",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (traloi == DialogResult.Yes)
                    {
                      

                    }
                    else
                    {
                        return;
                    }

                }

            }



            if (Them)
            {


                try
                {
                    BLHoaDonBan dbb = new BLHoaDonBan();
                    try
                    {
                        dbb.Them(txtMaHDban.Text, Convert.ToDateTime(this.txtdatetime.Text), ref err);
                    }
                    catch { }
                   
                    dbS.Them(this.txtMaHDban.Text, this.txtMasach.Text, int.Parse(this.txtiatien.Text),  int.Parse(txtsoluong.Value.ToString()), ref err);

                    LoadData();
                   
              
                  
                    txtMaHDban.Enabled = false;
                    try
                    {
                        lbltong.Text = bh.TongTien(txtMaHDban.Text, txtMasach.Text, int.Parse(txtgiamgia.Text)).ToString();
                    }
                    catch { MessageBox.Show("Giá giảm không đúng!"); }
                    MessageBox.Show("Đã thêm xong!");
                   
                    
                }
                catch
                {

                    MessageBox.Show("Mã không đúng!");
                }
            }
            else
            {
                try
                {
                    dbS.CapNhat(this.txtMaHDban.Text, this.txtMasach.Text, int.Parse(this.txtiatien.Text), int.Parse(txtsoluong.Value.ToString()), ref err);
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
            this.txtMaHDban.ResetText();
            this.txtMasach.ResetText();
            this.txtiatien.ResetText();
            this.txttensach.ResetText();
            this.txtsoluong.Value = 1;
            LoadData();
            txtMaHDban.Enabled = true;
          
        }

       

        private void txtMasach_KeyUp(object sender, KeyEventArgs e)
        {
            QuanLyNhaSachDataContext s = new QuanLyNhaSachDataContext();
            var vt = from v in s.GIANIEMYETs select v;
            foreach (var p in vt)
            {
                if(p.MaSach.Trim()==txtMasach.Text.Trim())
                {
                    try{

                        this.txtiatien.Text =( p.GiaTien-p.GiaTien*int.Parse(txtgiamgia.Text)/100).ToString();
                     }
                    catch { MessageBox.Show("Giá giảm không đúng!"); }
                    
                }
                
            }

            var sach = from sa in s.Saches select sa;
            foreach (var ps in sach)
            {
                if (ps.MaSach.Trim() == txtMasach.Text.Trim())
                {
                    this.txttensach.Text = ps.TenSach;

                }

            }
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            dgrNN.DataSource = dbS.timkiem(textBox1.Text);
        }

        private void txtMasach_TextChanged(object sender, EventArgs e)
        {

        }

        private void btntcs_Click(object sender, EventArgs e)
        {
            frmTraCuuSach s = new frmTraCuuSach();
            s.Show();
        }
    }
}
