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
    class BLNgonNgu
    {

          public DataTable Layngonngu()
        {
            QuanLyNhaSachDataContext qlNS = new QuanLyNhaSachDataContext();
            var hd = from p in qlNS.NGONNGUs select p;
            DataTable dt = new DataTable();
            dt.Columns.Add("Mã ngôn ngữ");
            dt.Columns.Add("Ngôn ngữ");
           
            foreach (var p in hd)
            {
                dt.Rows.Add(p.MaNgonNgu, p.NgonNgu1 );
            }
            return dt;
        }

        public bool ThemNgonNgu(string maNN, string NN,ref string err)
        {
            QuanLyNhaSachDataContext qlNS = new QuanLyNhaSachDataContext();
            NGONNGU s = new NGONNGU();
            s.MaNgonNgu = maNN;
            s.NgonNgu1 = NN;

            qlNS.NGONNGUs.InsertOnSubmit(s);

            qlNS.NGONNGUs.Context.SubmitChanges();

            return true;
        }
        public bool XoaNgonNgu(ref string err, string MaNN)
        {
            QuanLyNhaSachDataContext qlNS = new QuanLyNhaSachDataContext();
            var tpQuery = from k in qlNS.NGONNGUs
                          where k.MaNgonNgu == MaNN
                          select k;
            qlNS.NGONNGUs.DeleteAllOnSubmit(tpQuery);
            qlNS.SubmitChanges();
            return true;
        }
        public bool CapNhatNN(string maNN, string NN, ref string err)
        {
            QuanLyNhaSachDataContext qlNS = new QuanLyNhaSachDataContext();
            var sQuery = (from tp in qlNS.NGONNGUs
                          where tp.MaNgonNgu == maNN
                           select tp).SingleOrDefault();
            if (sQuery != null)
            {
                sQuery.MaNgonNgu = maNN;
                sQuery.NgonNgu1 = NN;
               
                qlNS.SubmitChanges();
            }
            return true;
        }
        public IQueryable timkiem(string ma)
        {
            QuanLyNhaSachDataContext qlSV = new QuanLyNhaSachDataContext();
            var tpQuery = (from t in qlSV.NGONNGUs
                           where t.MaNgonNgu.Contains(ma) || t.NgonNgu1.Contains(ma)
                           select t);
            return tpQuery;
        }

    
    }
}
