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
    public partial class FrmTraCuuHD : Form
    {


        QuanLyNhaSachDataContext qlNS = new QuanLyNhaSachDataContext();
        public bool ban = true;
        int ngay = 0;
        public FrmTraCuuHD()
        {
            InitializeComponent();
        }

        private void FrmTraCuuHD_Load(object sender, EventArgs e)
        {

            rdbBan.Checked = true;
            groupBox4.Enabled = false;
            LoadData();
        }
        void LoadData()
        {
            try
            {
                if (ban == true)
                {
                    if(ngay==1)
                    {
                        dgrNN.DataSource = LayHDBanNgay(txtMaHD.Text);
                    }
                    else
                    dgrNN.DataSource = LayHDBan(txtMaHD.Text);
                }
                else
                {
                    if (ngay == 1)
                    {
                        dgrNN.DataSource = LayHDNhapNgay(txtMaHD.Text);
                    }
                    else
                    dgrNN.DataSource = LayHDNhap(txtMaHD.Text);
                }

                // Thay đổi độ rộng cột
                dgrNN.AutoResizeColumns();
                // Xóa trống các đối tượng trong Panel


            }
            catch
            {
                //MessageBox.Show("Không lấy được nội dung ");
            }
        }
        public DataTable LayHDBan(string ma)
        {
            QuanLyNhaSachDataContext qlNS = new QuanLyNhaSachDataContext();
            var hd = from p in qlNS.HoaDonBans
                     where p.MaHoaDonBan.Contains(ma)
                     select p;

            DataTable dt = new DataTable();
            dt.Columns.Add("Hóa đơn bán ");
            dt.Columns.Add("Ngày bán");
            dt.Columns.Add("Giá trị");
            foreach (var p in hd)
            {
                int t = layTongBan(p.MaHoaDonBan);
                dt.Rows.Add(p.MaHoaDonBan, p.NgayBan, t);
            }
            return dt;
        }
        public DataTable LayHDBanNgay(string ma)
        {
            QuanLyNhaSachDataContext qlNS = new QuanLyNhaSachDataContext();
            var hd = from p in qlNS.HoaDonBans
                     where p.MaHoaDonBan.Contains(ma) && p.NgayBan >= DateTime.Parse(dt1.Text) && p.NgayBan <= DateTime.Parse(dt2.Text)
                     select p;

            DataTable dt = new DataTable();
            dt.Columns.Add("Hóa đơn bán ");
            dt.Columns.Add("Ngày bán");
            dt.Columns.Add("Giá trị");
            foreach (var p in hd)
            {
                int t = layTongBan(p.MaHoaDonBan);
                dt.Rows.Add(p.MaHoaDonBan, p.NgayBan, t);
            }
            return dt;
        }
        public DataTable LayHDNhap(string ma)
        {
            QuanLyNhaSachDataContext qlNS = new QuanLyNhaSachDataContext();
            var hd = from p in qlNS.HoaDonNhaps
                     where p.MaHoaDonNhap.Contains(ma)
                     select p;
            DataTable dt = new DataTable();
            dt.Columns.Add("Hóa đơn Nhập ");
            dt.Columns.Add("Ngày Nhập");
            dt.Columns.Add("Nhà cc");
            dt.Columns.Add("Giá trị");

            foreach (var p in hd)
            {
                int t = layTongNhap(p.MaHoaDonNhap);
                dt.Rows.Add(p.MaHoaDonNhap, p.NgayNhap, p.MaNCC, t);
            }
            return dt;
        }
        public DataTable LayHDNhapNgay(string ma)
        {
            QuanLyNhaSachDataContext qlNS = new QuanLyNhaSachDataContext();
            var hd = from p in qlNS.HoaDonNhaps
                     where p.MaHoaDonNhap.Contains(ma) && p.NgayNhap >= DateTime.Parse(dt1.Text) && p.NgayNhap <= DateTime.Parse(dt2.Text)
                     select p;
            DataTable dt = new DataTable();
            dt.Columns.Add("Hóa đơn Nhập ");
            dt.Columns.Add("Ngày Nhập");
            dt.Columns.Add("Nhà cc");
            dt.Columns.Add("Giá trị");

            foreach (var p in hd)
            {
                int t = layTongNhap(p.MaHoaDonNhap);
                dt.Rows.Add(p.MaHoaDonNhap, p.NgayNhap, p.MaNCC, t);
            }
            return dt;
        }


        public int layTongNhap(string ma)
        {
            int tong = 0;
            var s = from p in qlNS.SachMuaVaos
                    where p.MaHoaDonMua == ma
                    select p;
            foreach (var p in s)
            {
                tong = tong + (int)p.Soluong * (int)p.GiaTien;
            }
            return tong;

        }
        public int layTongBan(string ma)
        {
            int tong = 0;
            var s = from p in qlNS.SachBanRas
                    where p.MaHoaDonBan == ma
                    select p;
            foreach (var p in s)
            {
                tong = tong + (int)p.Soluong * (int)p.GiaTien;
            }
            return tong;

        }

        private void rdbBan_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbBan.Checked == true)
            {
                ban = true;
            }
            else
                ban = false;
            LoadData();
        }

        private void txtMaHD_KeyUp(object sender, KeyEventArgs e)
        {
            LoadData();
        }

        private void cbtk_CheckedChanged(object sender, EventArgs e)
        {
            if (cbtk.Checked == true)
            {
                groupBox4.Enabled = true;
              
                ngay = 1;
                return;
            }
            groupBox4.Enabled = false;
          
            ngay = 0;

        }

        private void btntracuu_Click(object sender, EventArgs e)
        {
            try
            {
                LoadData();
            }
            catch
            {

            }
           
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            txtMaHD.ResetText();
            LoadData();
            
        }
    }
}
