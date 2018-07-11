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
    class BLSachBanRa
    {
        public DataTable Lay()
        {
            QuanLyNhaSachDataContext qlNS = new QuanLyNhaSachDataContext();
            var hd = from p in qlNS.SachBanRas select p;
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

        public bool Them(string MaHD, string Masach, int Giatien, int soluong, ref string err)
        {
            QuanLyNhaSachDataContext qlNS = new QuanLyNhaSachDataContext();
            SachBanRa s = new SachBanRa();
            s.MaHoaDonBan = MaHD;
            s.MaSach = Masach;
            s.GiaTien = Giatien;
            s.Soluong = soluong;
            qlNS.SachBanRas.InsertOnSubmit(s);

            qlNS.SachBanRas.Context.SubmitChanges();

            return true;
        }
        public bool Xoa(ref string err, string MaHD, string masach)
        {
            QuanLyNhaSachDataContext qlNS = new QuanLyNhaSachDataContext();
            var tpQuery = from k in qlNS.SachBanRas
                          where k.MaHoaDonBan == MaHD && k.MaSach == masach
                          select k;
            qlNS.SachBanRas.DeleteAllOnSubmit(tpQuery);
            qlNS.SubmitChanges();
            return true;
        }
        public bool CapNhat(string MaHD, string Masach, int Giatien, int soluong, ref string err)
        {
            QuanLyNhaSachDataContext qlNS = new QuanLyNhaSachDataContext();
            var sQuery = (from tp in qlNS.SachBanRas
                          where tp.MaHoaDonBan == MaHD && tp.MaSach == Masach
                          select tp).SingleOrDefault();
            if (sQuery != null)
            {

               
                sQuery.MaHoaDonBan = MaHD;
                sQuery.MaSach = Masach;
                sQuery.GiaTien = Giatien;
                sQuery.Soluong = soluong;
                qlNS.SubmitChanges();
            }
            return true;
        }
        public IQueryable timkiem(string ma)
        {
            QuanLyNhaSachDataContext qlSV = new QuanLyNhaSachDataContext();
            var tpQuery = (from t in qlSV.SachBanRas
                           where t.MaSach.Contains(ma) || t.MaHoaDonBan.Contains(ma) 
                           select t);
            return tpQuery;
        }

    }
}
