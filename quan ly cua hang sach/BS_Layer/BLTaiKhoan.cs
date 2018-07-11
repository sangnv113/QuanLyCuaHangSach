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
    class BLTaiKhoan
    {
        public DataTable Lay()
        {
            QuanLyNhaSachDataContext qlNS = new QuanLyNhaSachDataContext();
            var hd = from p in qlNS.TaiKhoanTruyCaps select p;
            DataTable dt = new DataTable();
            dt.Columns.Add("Tên tài khoản");
            dt.Columns.Add("Mật khẩu");
            dt.Columns.Add("Quyền truy cập");
            foreach (var p in hd)
            {
                dt.Rows.Add(p.TenTaiKhoan, p.MatKhau, p.QuyenTruyCap);
            }
            return dt;
        }

        public bool Them(string Ten, string matkhau, string quyen, ref string err)
        {
            QuanLyNhaSachDataContext qlNS = new QuanLyNhaSachDataContext();
            TaiKhoanTruyCap s = new TaiKhoanTruyCap();
            s.TenTaiKhoan = Ten;
            s.MatKhau = matkhau;
            s.QuyenTruyCap = quyen;

            qlNS.TaiKhoanTruyCaps.InsertOnSubmit(s);

            qlNS.TaiKhoanTruyCaps.Context.SubmitChanges();

            return true;
        }
        public bool Xoa(ref string err, string tentruycap)
        {
            QuanLyNhaSachDataContext qlNS = new QuanLyNhaSachDataContext();
            var tpQuery = from k in qlNS.TaiKhoanTruyCaps
                          where k.TenTaiKhoan == tentruycap
                          select k;
            qlNS.TaiKhoanTruyCaps.DeleteAllOnSubmit(tpQuery);
            qlNS.SubmitChanges();
            return true;
        }
        public bool CapNhat(string Ten, string matkhau, string quyen, ref string err)
        {
            QuanLyNhaSachDataContext qlNS = new QuanLyNhaSachDataContext();
            var sQuery = (from tp in qlNS.TaiKhoanTruyCaps
                          where tp.TenTaiKhoan == Ten
                          select tp).SingleOrDefault();
            if (sQuery != null)
            {
                sQuery.TenTaiKhoan = Ten;
                sQuery.MatKhau = matkhau;
                sQuery.QuyenTruyCap = quyen;
                qlNS.SubmitChanges();
            }
            return true;
        }
        public IQueryable timkiem(string ma)
        {
            QuanLyNhaSachDataContext qlSV = new QuanLyNhaSachDataContext();
            var tpQuery = (from t in qlSV.TaiKhoanTruyCaps
                           where t.TenTaiKhoan.Contains(ma) || t.QuyenTruyCap.Contains(ma)
                           select t);
            return tpQuery;
        }

    }
}
