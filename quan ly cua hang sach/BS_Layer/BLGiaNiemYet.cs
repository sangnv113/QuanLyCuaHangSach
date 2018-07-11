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
    class BLGiaNiemYet
    {

        public DataTable Lay()
        {
            QuanLyNhaSachDataContext qlNS = new QuanLyNhaSachDataContext();
            var hd = from p in qlNS.GIANIEMYETs select p;
            DataTable dt = new DataTable();
            dt.Columns.Add("Mã sách");
            dt.Columns.Add("Giá");

            foreach (var p in hd)
            {
                dt.Rows.Add(p.MaSach, p.GiaTien);
            }
            return dt;
        }

        public bool Them(string Ma, int gia, ref string err)
        {
            QuanLyNhaSachDataContext qlNS = new QuanLyNhaSachDataContext();
            GIANIEMYET s = new GIANIEMYET();
            s.MaSach = Ma;
            s.GiaTien = gia;

            qlNS.GIANIEMYETs.InsertOnSubmit(s);

            qlNS.GIANIEMYETs.Context.SubmitChanges();

            return true;
        }
        public bool Xoa(ref string err, string Ma)
        {
            QuanLyNhaSachDataContext qlNS = new QuanLyNhaSachDataContext();
            var tpQuery = from k in qlNS.GIANIEMYETs
                          where k.MaSach == Ma
                          select k;
            qlNS.GIANIEMYETs.DeleteAllOnSubmit(tpQuery);
            qlNS.SubmitChanges();
            return true;
        }
        public bool CapNhat(string Ma, int gia, ref string err)
        {
            QuanLyNhaSachDataContext qlNS = new QuanLyNhaSachDataContext();
            var sQuery = (from tp in qlNS.GIANIEMYETs
                          where tp.MaSach == Ma
                          select tp).SingleOrDefault();
            if (sQuery != null)
            {
                sQuery.MaSach = Ma;
                sQuery.GiaTien = gia;

                qlNS.SubmitChanges();
            }
            return true;
        }
        public IQueryable timkiem(string ma)
        {
            QuanLyNhaSachDataContext qlSV = new QuanLyNhaSachDataContext();
            var tpQuery = (from t in qlSV.GIANIEMYETs
                           where t.MaSach.Contains(ma)
                           select t);
            return tpQuery;
        }

    }
}
