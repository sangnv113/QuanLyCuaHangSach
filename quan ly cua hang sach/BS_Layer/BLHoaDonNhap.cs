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
    class BLHoaDonNhap
    {

        public DataTable Lay()
        {
            QuanLyNhaSachDataContext qlNS = new QuanLyNhaSachDataContext();
            var hd = from p in qlNS.HoaDonNhaps select p;
            DataTable dt = new DataTable();
            dt.Columns.Add("Mã hóa đơn Nhập");
            dt.Columns.Add("Ngày Nhập");
            dt.Columns.Add("Mã nhà cung cấp");
            foreach (var p in hd)
            {
                dt.Rows.Add(p.MaHoaDonNhap, p.NgayNhap, p.MaNCC);
            }
            return dt;
        }

        public bool Them(string Ma, DateTime ngay, string MaNCC, ref string err)
        {
            QuanLyNhaSachDataContext qlNS = new QuanLyNhaSachDataContext();
            HoaDonNhap s = new HoaDonNhap();
            s.MaHoaDonNhap = Ma;
            s.NgayNhap = ngay;
            s.MaNCC = MaNCC;
            qlNS.HoaDonNhaps.InsertOnSubmit(s);

            qlNS.HoaDonNhaps.Context.SubmitChanges();

            return true;
        }
        public bool Xoa(ref string err, string Ma)
        {
            QuanLyNhaSachDataContext qlNS = new QuanLyNhaSachDataContext();
            var tpQuery = from k in qlNS.HoaDonNhaps
                          where k.MaHoaDonNhap == Ma
                          select k;
            qlNS.HoaDonNhaps.DeleteAllOnSubmit(tpQuery);
            qlNS.SubmitChanges();
            return true;
        }
        public bool CapNhat(string Ma, DateTime Ngay, string MaNCC, ref string err)
        {
            QuanLyNhaSachDataContext qlNS = new QuanLyNhaSachDataContext();
            var sQuery = (from tp in qlNS.HoaDonNhaps
                          where tp.MaHoaDonNhap == Ma
                          select tp).SingleOrDefault();
            if (sQuery != null)
            {
               
                sQuery.MaHoaDonNhap = Ma;
                sQuery.NgayNhap = Ngay;
                sQuery.MaNCC = MaNCC;
                qlNS.SubmitChanges();
            }
            return true;
        }
        public IQueryable timkiem(string ma)
        {
            QuanLyNhaSachDataContext qlSV = new QuanLyNhaSachDataContext();
            var tpQuery = (from t in qlSV.HoaDonNhaps
                           where t.MaHoaDonNhap.Contains(ma) || t.MaNCC.Contains(ma)
                           select t);
            return tpQuery;
        }
    }
}
