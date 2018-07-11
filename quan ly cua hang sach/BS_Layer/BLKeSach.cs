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
    class BLKeSach
    {
        public DataTable LayKe()
        {
            QuanLyNhaSachDataContext qlNS = new QuanLyNhaSachDataContext();
            var hd = from p in qlNS.KeSaches select p;
            DataTable dt = new DataTable();
            dt.Columns.Add("Tên Kệ");
            dt.Columns.Add("Thể loại");

            foreach (var p in hd)
            {
                dt.Rows.Add(p.TenKeSach, p.TheLoai);
            }
            return dt;
        }

        public bool ThemKe(string tenke, string theloai, ref string err)
        {
            QuanLyNhaSachDataContext qlNS = new QuanLyNhaSachDataContext();
            KeSach s = new KeSach();
            s.TenKeSach = tenke;
            s.TheLoai = theloai;

            qlNS.KeSaches.InsertOnSubmit(s);

            qlNS.KeSaches.Context.SubmitChanges();

            return true;
        }
        public bool XoaKe(ref string err, string tenke)
        {
            QuanLyNhaSachDataContext qlNS = new QuanLyNhaSachDataContext();
            var tpQuery = from k in qlNS.KeSaches
                          where k.TenKeSach == tenke
                          select k;
            qlNS.KeSaches.DeleteAllOnSubmit(tpQuery);
            qlNS.SubmitChanges();
            return true;
        }
        public bool CapNhatKe(string tenke, string theloai, ref string err)
        {
            QuanLyNhaSachDataContext qlNS = new QuanLyNhaSachDataContext();
            var sQuery = (from tp in qlNS.KeSaches
                          where tp.TenKeSach == tenke
                          select tp).SingleOrDefault();
            if (sQuery != null)
            {
                sQuery.TenKeSach = tenke;
                sQuery.TheLoai = theloai;

                qlNS.SubmitChanges();
            }
            return true;
        }
    }
}
