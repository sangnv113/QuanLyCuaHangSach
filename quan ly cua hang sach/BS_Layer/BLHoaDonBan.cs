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
    class BLHoaDonBan
    {
        public DataTable Lay()
        {
            QuanLyNhaSachDataContext qlNS = new QuanLyNhaSachDataContext();
            var hd = from p in qlNS.HoaDonBans select p;
            DataTable dt = new DataTable();
            dt.Columns.Add("Mã hóa đơn bán");
            dt.Columns.Add("Ngày bán");

            foreach (var p in hd)
            {
                dt.Rows.Add(p.MaHoaDonBan, p.NgayBan);
            }
            return dt;
        }

        public bool Them(string Ma, DateTime ngay, ref string err)
        {
            QuanLyNhaSachDataContext qlNS = new QuanLyNhaSachDataContext();
            HoaDonBan s = new HoaDonBan();
            s.MaHoaDonBan = Ma;
            s.NgayBan = ngay;

            qlNS.HoaDonBans.InsertOnSubmit(s);

            qlNS.HoaDonBans.Context.SubmitChanges();

            return true;
        }
        public bool Xoa(ref string err, string Ma)
        {
            QuanLyNhaSachDataContext qlNS = new QuanLyNhaSachDataContext();
            var tpQuery = from k in qlNS.HoaDonBans
                          where k.MaHoaDonBan == Ma
                          select k;
            qlNS.HoaDonBans.DeleteAllOnSubmit(tpQuery);
            qlNS.SubmitChanges();
            return true;
        }
        public bool Xoacthdb(ref string err, string MaHD)
        {
            QuanLyNhaSachDataContext qlNS = new QuanLyNhaSachDataContext();
            var tpQuery = from k in qlNS.SachBanRas
                          where k.MaHoaDonBan == MaHD 
                          select k;
            qlNS.SachBanRas.DeleteAllOnSubmit(tpQuery);
            qlNS.SubmitChanges();
            return true;
        }
        public bool CapNhat(string Ma, DateTime Ngay, ref string err)
        {
            QuanLyNhaSachDataContext qlNS = new QuanLyNhaSachDataContext();
            var sQuery = (from tp in qlNS.HoaDonBans
                          where tp.MaHoaDonBan == Ma
                          select tp).SingleOrDefault();
            if (sQuery != null)
            {
                sQuery.MaHoaDonBan = Ma;
                sQuery.NgayBan = Ngay;

                qlNS.SubmitChanges();
            }
            return true;
        }
        public IQueryable timkiem(string ma)
        {
            QuanLyNhaSachDataContext qlSV = new QuanLyNhaSachDataContext();
            var tpQuery = (from t in qlSV.HoaDonBans
                           where t.MaHoaDonBan.Contains(ma)
                           select t);
            return tpQuery;
        }
         public int DemMa(string maHD)
         {
             int tong = 0;
             QuanLyNhaSachDataContext qlNS = new QuanLyNhaSachDataContext();

             var tpQuery = from d in qlNS.HoaDonBans
                            where d.MaHoaDonBan==maHD
                            select d;
             foreach(var d in tpQuery)
             {
                 tong++;
             }

             return tong;
         }
    }
}
