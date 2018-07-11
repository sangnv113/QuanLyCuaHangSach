using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quan_ly_cua_hang_sach
{
    public partial class Quản_lý : Form
    {
        public Quản_lý()
        {
            InitializeComponent();
        }

        private void Quản_lý_Load(object sender, EventArgs e)
        {
            if (Form1.QuyenTC == 1)
            {
                lbQuyen.Text = "Admin";
                pictureBox2.Image = Image.FromFile(Application.StartupPath + "\\image\\admin.png");
            }
                
            if (Form1.QuyenTC == 2)
            {
                lbQuyen.Text = "Nhân viên bán hàng";
                pictureBox2.Image = Image.FromFile(Application.StartupPath + "\\image\\nhanvien.png");
                tàiKhoảnTruyCậpToolStripMenuItem.Enabled = false;
                hóaĐơnNhậpToolStripMenuItem.Enabled = false;
                hóaĐơnBánToolStripMenuItem.Enabled = false;
                giáNiêmYếtToolStripMenuItem.Enabled = false;
                thốngKêThuChiToolStripMenuItem.Enabled = false;

                sáchBánRaToolStripMenuItem.Enabled = false;
                sáchMuaVàoToolStripMenuItem.Enabled = false;
            }
                
            if (Form1.QuyenTC == 3)
            {
                lbQuyen.Text = "Nhân viêntrông kho";
                pictureBox2.Image = Image.FromFile(Application.StartupPath + "\\image\\nhanvienkho.png");
                tàiKhoảnTruyCậpToolStripMenuItem.Enabled = false;
               
                giáNiêmYếtToolStripMenuItem.Enabled = false;
                thốngKêThuChiToolStripMenuItem.Enabled = false;

                sáchBánRaToolStripMenuItem.Enabled = false;
                sáchMuaVàoToolStripMenuItem.Enabled = false;
                btnBanhang.Enabled = false;

            }
                
        }

        private void btndangxuat_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f = new Form1();
            f.Show();
           
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void sáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSach s = new frmSach();
            s.Show();
        }

        private void ngônNgữToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNgonNgu s = new frmNgonNgu();
            s.Show();
        }

        private void kệSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmKeSach s = new frmKeSach();
            s.Show();
        }

        private void nXBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNXB s = new frmNXB();
            s.Show();
        }

        private void thểLoạiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTheLoai s = new frmTheLoai();
            s.Show();
        }

        private void nhàCungCấpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNhaCC s = new frmNhaCC();
            s.Show();
        }

        private void tàiKhoảnTruyCậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTaiKhoan s = new frmTaiKhoan();
            s.Show();
        }

        private void hóaĐơnBánToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHoaDonBan s = new frmHoaDonBan();
            s.Show();
        }

        private void hóaĐơnNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmHoaDonNhap s = new FrmHoaDonNhap();
            s.Show();
        }

        private void sáchBánRaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSachBanraa s = new frmSachBanraa();
            s.Show();
        }

        private void sáchToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmTraCuuSach s = new frmTraCuuSach();
            s.Show();
        }

        private void sáchNhậpVềToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTraCuuSachNhapVe s = new FrmTraCuuSachNhapVe();
            s.Show();
        }

        private void giáNiêmYếtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGiaNiemYet s = new frmGiaNiemYet();
            s.Show();
        }

        private void btnBanhang_Click(object sender, EventArgs e)
        {
            frmBanHang s = new frmBanHang();
            s.Show();
        }

        private void sáchMuaVàoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSachMuaVao s = new frmSachMuaVao();
            s.Show();
        }

        private void lbQuyen_Click(object sender, EventArgs e)
        {

        }

        private void thốngKêThuChiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmThuChi s = new frmThuChi();
            s.Show();
        }

        private void tínhHóaĐơnNhậpBánToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTraCuuHD s = new FrmTraCuuHD();
            s.Show();
        }

        private void btnBanhang_MouseHover(object sender, EventArgs e)
        {
            btnBanhang.BackColor = Color.Green;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            btnBanhang.BackColor = Color.SeaGreen;
        }

        private void tínhToánToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
