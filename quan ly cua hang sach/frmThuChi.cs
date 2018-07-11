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
    public partial class frmThuChi : Form
    {
        public int ngay = 1;
        public string day1="1/1/2017";
        public string day2="31/12/2017";
        QuanLyNhaSachDataContext qlNS = new QuanLyNhaSachDataContext();
        public frmThuChi()
        {
            InitializeComponent();
        }

      
        public int layTongThu()
        {

            int tong = 0;
            var s1 = from p1 in qlNS.HoaDonBans
                     where p1.NgayBan >= DateTime.Parse(day1) && p1.NgayBan <= DateTime.Parse(day2)
                     select p1;
            var s = from p in qlNS.SachBanRas       select p;
            foreach (var p1 in s1)
            {
               
                foreach (var p in s)
                {
                    if(p.MaHoaDonBan==p1.MaHoaDonBan)
                    {
                        tong = tong + (int)p.Soluong * (int)p.GiaTien;
                    }
                    
                }
            }
            
            return tong;

        }
        public int layTongNhap()
        {

            int tong = 0;

            var s1 = from p1 in qlNS.HoaDonNhaps
                     where p1.NgayNhap >= DateTime.Parse(day1) && p1.NgayNhap <= DateTime.Parse(day2)
                     select p1;
            var s = from p in qlNS.SachMuaVaos select p;
            foreach (var p1 in s1)
            {

                foreach (var p in s)
                {
                    if (p.MaHoaDonMua == p1.MaHoaDonNhap)
                    {
                        tong = tong + (int)p.Soluong * (int)p.GiaTien;
                    }

                }
            }

            
            return tong;

        }
        public int laySoLuongHDBan()
        {



            int tong = 0;
            var s = from p in qlNS.HoaDonBans
                    where p.NgayBan >= DateTime.Parse(day1) && p.NgayBan <= DateTime.Parse(day2)
                    select p;
            foreach (var p in s)
            {
                tong = tong + 1;
            }
            return tong;

        }
        public int laySoLuongHDMua()
        {
            int tong = 0;
            var s = from p in qlNS.HoaDonNhaps
                    where p.NgayNhap >= DateTime.Parse(day1) && p.NgayNhap <= DateTime.Parse(day2)
                    select p;
            foreach (var p in s)
            {
                tong = tong + 1;
            }
            return tong;

        }
        private string intien(string sotien)
        {
            int n = sotien.Length - 1;
            int s = 0;
            string tienphu = null;
            while (n >= 0)
            {
                if (s == 3)
                {
                    s = 0;
                    tienphu = tienphu + ",";
                }
                tienphu = tienphu + sotien[n];
                s++;
                n--;

            }
            sotien = null;
            for (int i = tienphu.Length - 1; i >= 0; i--)
            {
                sotien = sotien + tienphu[i];
            }
            if (sotien[0] == '-' && sotien[1] == ',')
            {
                string st = sotien;
                sotien = "-";
                for (int i = 2; i <= st.Length - 1; i++)
                {
                    sotien = sotien + st[i];
                }
            }
            return sotien+" VND";
        }

        private void frmThuChi_Load_1(object sender, EventArgs e)
        {

            cbtk.Checked = true;
            cbtk_CheckedChanged(sender, e);
        }

        private void btnok_Click(object sender, EventArgs e)
        {
            try
            {


                if (ngay == 0)
                {

                    switch (int.Parse(cbbquy.Text))
                    {
                        case 1:
                            day1 = "1/1/" + cbbnam.Text;
                            day2 = "3/31/" + cbbnam.Text;
                            break;
                        case 2:
                            day1 = "4/1/" + cbbnam.Text;
                            day2 = "6/30/" + cbbnam.Text;
                            break;
                        case 3:
                            day1 = "7/1/" + cbbnam.Text;
                            day2 = "9/30/" + cbbnam.Text;
                            break;
                        case 4:
                            day1 = "10/10/" + cbbnam.Text;
                            day2 = "12/31/" + cbbnam.Text;
                            break;

                    }


                }
                if (ngay == 1)
                {
                    day1 = dt1.Text;
                    day2 = dt2.Text;
                }
                //MessageBox.Show(day1);
                lblHDBTổng.Text = intien(layTongThu().ToString());
                lblHDNTong.Text = intien(layTongNhap().ToString());
                lblTonglai.Text = intien((layTongThu() - layTongNhap()).ToString());

                lblHDBSLuong.Text = laySoLuongHDBan().ToString();
                lblHDNSLuong.Text = laySoLuongHDMua().ToString();
            }
            catch
            {

            }
        }

        private void cbtk_CheckedChanged(object sender, EventArgs e)
        {
            if( cbtk.Checked == true)
            {
                groupBox4.Enabled = true;
                groupBox5.Enabled = false;
                ngay = 1;
                return;
            }
            groupBox4.Enabled = false;
            groupBox5.Enabled = true;
            ngay = 0;
        }


    }
}
