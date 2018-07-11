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
    class BLNhaCC
    {
        public DataTable Lay()
        {
            QuanLyNhaSachDataContext qlNS = new QuanLyNhaSachDataContext();
            var hd = from p in qlNS.NHACCs select p;
            DataTable dt = new DataTable();
            dt.Columns.Add("Mã nhà cung cấp");
            dt.Columns.Add("Tên nhà cung cấp");

            foreach (var p in hd)
            {
                dt.Rows.Add(p.MaNCC, p.NhaCC1);
            }
            return dt;
        }

        public bool Them(string Ma, string Ten, ref string err)
        {
            QuanLyNhaSachDataContext qlNS = new QuanLyNhaSachDataContext();
            NHACC s = new NHACC();
            s.MaNCC = Ma;
            s.NhaCC1 = Ten;

            qlNS.NHACCs.InsertOnSubmit(s);

            qlNS.NHACCs.Context.SubmitChanges();

            return true;
        }
        public bool Xoa(ref string err, string Ma)
        {
            QuanLyNhaSachDataContext qlNS = new QuanLyNhaSachDataContext();
            var tpQuery = from k in qlNS.NHACCs
                          where k.MaNCC == Ma
                          select k;
            qlNS.NHACCs.DeleteAllOnSubmit(tpQuery);
            qlNS.SubmitChanges();
            return true;
        }
        public bool CapNhat(string Ma, string Ten, ref string err)
        {
            QuanLyNhaSachDataContext qlNS = new QuanLyNhaSachDataContext();
            var sQuery = (from tp in qlNS.NHACCs
                          where tp.MaNCC == Ma
                          select tp).SingleOrDefault();
            if (sQuery != null)
            {
                sQuery.MaNCC = Ma;
                sQuery.NhaCC1 = Ten;

                qlNS.SubmitChanges();
            }
            return true;
        }
        public IQueryable timkiem(string ma)
        {
            QuanLyNhaSachDataContext qlSV = new QuanLyNhaSachDataContext();
            var tpQuery = (from t in qlSV.NHACCs
                           where t.MaNCC.Contains(ma) || t.NhaCC1.Contains(ma)
                           select t);
            return tpQuery;
        }

    }
}
