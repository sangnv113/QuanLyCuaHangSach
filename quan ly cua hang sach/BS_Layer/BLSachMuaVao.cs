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
    class BLSachMuaVao
    {
        public DataTable Lay()
        {
            QuanLyNhaSachDataContext qlNS = new QuanLyNhaSachDataContext();
            var hd = from p in qlNS.SachMuaVaos select p;
            DataTable dt = new DataTable();
            dt.Columns.Add("Mã hóa đơn mua");
            dt.Columns.Add("Mấ sách");
            dt.Columns.Add("Giá tiền");
            dt.Columns.Add("Số lượng");
            foreach (var p in hd)
            {
                dt.Rows.Add(p.MaHoaDonMua, p.MaSach, p.GiaTien, p.Soluong);
            }
            return dt;
        }

        public bool Them(string MaHD, string Masach, int Giatien,int soluong, ref string err)
        {
            QuanLyNhaSachDataContext qlNS = new QuanLyNhaSachDataContext();
            SachMuaVao s = new SachMuaVao();
            s.MaHoaDonMua = MaHD;
            s.MaSach = Masach;
            s.GiaTien = Giatien;
            s.Soluong = soluong;
            qlNS.SachMuaVaos.InsertOnSubmit(s);

            qlNS.SachMuaVaos.Context.SubmitChanges();

            return true;
        }
        public bool Xoa(ref string err, string MaHD, string masach)
        {
            QuanLyNhaSachDataContext qlNS = new QuanLyNhaSachDataContext();
            var tpQuery = from k in qlNS.SachMuaVaos
                          where k.MaHoaDonMua == MaHD && k.MaSach == masach
                          select k;
            qlNS.SachMuaVaos.DeleteAllOnSubmit(tpQuery);
            qlNS.SubmitChanges();
            return true;
        }
        public bool CapNhat(string MaHD, string Masach, int Giatien,int soluong, ref string err)
        {
            QuanLyNhaSachDataContext qlNS = new QuanLyNhaSachDataContext();
            var sQuery = (from tp in qlNS.SachMuaVaos
                          where tp.MaHoaDonMua == MaHD && tp.MaSach == Masach
                          select tp).SingleOrDefault();
            if (sQuery != null)
            {


                sQuery.MaHoaDonMua = MaHD;
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
                           where t.MaHoaDonBan.Contains(ma) || t.MaSach.Contains(ma)
                           select t);
            return tpQuery;
        }

    }
}
