using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.IO;
using System.Data;
namespace quan_ly_cua_hang_sach.BS_Layer
{
    class BLBanHang
    {
        QuanLyNhaSachDataContext qlNS = new QuanLyNhaSachDataContext();
        public DataTable Lay(string ma)
        {
           
            var hd = from p in qlNS.SachBanRas
                     where p.MaHoaDonBan==ma
                     select p;
            DataTable dt = new DataTable();
            dt.Columns.Add("Mã hóa đơn bán");
            dt.Columns.Add("Mấ sách");
            dt.Columns.Add("Giá tiền");
            dt.Columns.Add("Số lượng");
            foreach (var p in hd)
            {
                dt.Rows.Add(p.MaHoaDonBan, p.MaSach, p.GiaTien, p.Soluong);
            }
            return dt;
        }
        //public string sinhma()
        //{
        //    string ma;
        //    int ss;
        //    var hd = from p in qlNS.HoaDonBans
                     
        //             select p;
        //    foreach(var p in hd)
        //    {

        //    }

        //}
        //int TachSo(string MaHD)
        //{
        //    for(int i=0; i<MaHD.Length; i++)
        //    {

        //    }
        //}
        public int TongTien(string mahd, string masach, int giagiam)
        {
            int tong = 0;
            var s = from p in qlNS.SachBanRas
                    where p.MaHoaDonBan == mahd 
                     select p;
            foreach (var p in s)
            {
                tong = tong + (int)p.Soluong * ((int)p.GiaTien);
            }
            return tong;
        }
       
    }
}
