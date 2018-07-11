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
    class BLNXB
    {
        public DataTable LayKe()
        {
            QuanLyNhaSachDataContext qlNS = new QuanLyNhaSachDataContext();
            var hd = from p in qlNS.NXBs select p;
            DataTable dt = new DataTable();
            dt.Columns.Add("Mã NXB");
            dt.Columns.Add("Tên NXB");

            foreach (var p in hd)
            {
                dt.Rows.Add(p.MaNXB, p.TenNXB);
            }
            return dt;
        }

        public bool Them(string Ma, string Ten, ref string err)
        {
            QuanLyNhaSachDataContext qlNS = new QuanLyNhaSachDataContext();
            NXB s = new NXB();
            s.MaNXB = Ma;
            s.TenNXB = Ten;

            qlNS.NXBs.InsertOnSubmit(s);

            qlNS.NXBs.Context.SubmitChanges();

            return true;
        }
        public bool Xoa(ref string err, string MaNXB)
        {
            QuanLyNhaSachDataContext qlNS = new QuanLyNhaSachDataContext();
            var tpQuery = from k in qlNS.NXBs
                          where k.MaNXB == MaNXB
                          select k;
            qlNS.NXBs.DeleteAllOnSubmit(tpQuery);
            qlNS.SubmitChanges();
            return true;
        }
        public bool CapNhat(string MaNXB, string TenNXB, ref string err)
        {
            QuanLyNhaSachDataContext qlNS = new QuanLyNhaSachDataContext();
            var sQuery = (from tp in qlNS.NXBs
                          where tp.MaNXB == MaNXB
                          select tp).SingleOrDefault();
            if (sQuery != null)
            {
                sQuery.MaNXB = MaNXB;
                sQuery.TenNXB = TenNXB;

                qlNS.SubmitChanges();
            }
            return true;
        }
        public IQueryable timkiem(string ma)
        {
            QuanLyNhaSachDataContext qlSV = new QuanLyNhaSachDataContext();
            var tpQuery = (from t in qlSV.NXBs
                           where t.MaNXB.Contains(ma) || t.TenNXB.Contains(ma)
                           select t);
            return tpQuery;
        }

    }
}
