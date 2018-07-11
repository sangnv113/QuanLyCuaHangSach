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
    class BLTheLoai
    {
        public DataTable Lay()
        {
            QuanLyNhaSachDataContext qlNS = new QuanLyNhaSachDataContext();
            var hd = from p in qlNS.THELOAIs select p;
            DataTable dt = new DataTable();
            dt.Columns.Add("Mã thể loại");
            dt.Columns.Add("Tên thể loại");

            foreach (var p in hd)
            {
                dt.Rows.Add(p.MaTheLoai, p.TheLoai1);
            }
            return dt;
        }

        public bool Them(string Ma, string Ten, ref string err)
        {
            QuanLyNhaSachDataContext qlNS = new QuanLyNhaSachDataContext();
            THELOAI s = new THELOAI();
            s.MaTheLoai = Ma;
            s.TheLoai1 = Ten;

            qlNS.THELOAIs.InsertOnSubmit(s);

            qlNS.THELOAIs.Context.SubmitChanges();

            return true;
        }
        public bool Xoa(ref string err, string Ma)
        {
            QuanLyNhaSachDataContext qlNS = new QuanLyNhaSachDataContext();
            var tpQuery = from k in qlNS.THELOAIs
                          where k.MaTheLoai == Ma
                          select k;
            qlNS.THELOAIs.DeleteAllOnSubmit(tpQuery);
            qlNS.SubmitChanges();
            return true;
        }
        public bool CapNhat(string Ma, string Ten, ref string err)
        {
            QuanLyNhaSachDataContext qlNS = new QuanLyNhaSachDataContext();
            var sQuery = (from tp in qlNS.THELOAIs
                          where tp.MaTheLoai == Ma
                          select tp).SingleOrDefault();
            if (sQuery != null)
            {
                sQuery.MaTheLoai = Ma;
                sQuery.TheLoai1 = Ten;

                qlNS.SubmitChanges();
            }
            return true;
        }
        public IQueryable timkiem(string ma)
        {
            QuanLyNhaSachDataContext qlSV = new QuanLyNhaSachDataContext();
            var tpQuery = (from t in qlSV.THELOAIs
                           where t.MaTheLoai.Contains(ma) || t.TheLoai1.Contains(ma)
                           select t);
            return tpQuery;
        }

    }
}
