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
    class BL_Sach
    {
        public DataTable Laysach()
        {
            QuanLyNhaSachDataContext qlNS = new QuanLyNhaSachDataContext();
            var hd = from p in qlNS.Saches select p;
            DataTable dt = new DataTable();
            dt.Columns.Add("Mã sách");
            dt.Columns.Add("Tên sách");
            dt.Columns.Add("Tác giả");
            dt.Columns.Add("Nhà xuất bản");
            dt.Columns.Add("Số trang");
            dt.Columns.Add("Ngôn ngữ");
            dt.Columns.Add("Thể loại");
            dt.Columns.Add("Tình trạng");
            dt.Columns.Add("Vị trí");
            foreach (var p in hd)
            {
                dt.Rows.Add(p.MaSach, p.TenSach, p.TacGia, p.NhaXuatBan, p.SoTrang, p.NgonNgu, p.TheLoai,p.TinhTrang, p.ViTri);
            }
            return dt;
        }

        public bool ThemSach(string maSach, string tensach, string TacGia, string NXB, int SoTrang,
        string NgonNgu, string TheLoai,  string TinhTrang, string ViTri, ref string err)
        {
            QuanLyNhaSachDataContext qlNS = new QuanLyNhaSachDataContext();
            Sach s = new Sach();
            s.MaSach = maSach;
            s.TenSach = tensach;
            s.TacGia = TacGia;
            s.NhaXuatBan = NXB;

            s.SoTrang = SoTrang;
            s.NgonNgu = NgonNgu;
            s.TheLoai = TheLoai;
            s.TinhTrang = TinhTrang;
            s.ViTri = ViTri;
            qlNS.Saches.InsertOnSubmit(s);

            qlNS.Saches.Context.SubmitChanges();

            return true;
        }
        public bool XoaSach(ref string err, string MaSach)
        {
            QuanLyNhaSachDataContext qlNS = new QuanLyNhaSachDataContext();
            var tpQuery = from k in qlNS.Saches
                          where k.MaSach == MaSach
                          select k;
            qlNS.Saches.DeleteAllOnSubmit(tpQuery);
            qlNS.SubmitChanges();
            return true;
        }
        public bool CapNhatSach(string maSach,
        string tensach, string TacGia, string NXB, int SoTrang,
        string NgonNgu, string TheLoai, string TinhTrang, string ViTri, ref string err)
        {
            QuanLyNhaSachDataContext qlNS = new QuanLyNhaSachDataContext();
            var sQuery = (from tp in qlNS.Saches
                           where tp.MaSach == maSach
                           select tp).SingleOrDefault();
            if (sQuery != null)
            {
                
                sQuery.MaSach = maSach;
                sQuery.TenSach = tensach;
                sQuery.TacGia = TacGia;
                sQuery.NhaXuatBan = NXB;

                sQuery.SoTrang = SoTrang;
                sQuery.NgonNgu = NgonNgu;
                sQuery.TheLoai = TheLoai;
                sQuery.TinhTrang = TinhTrang;
                sQuery.ViTri = ViTri;
                qlNS.SubmitChanges();
            }
            return true;
        }
        public IQueryable timkiem(string ma)
        {
            QuanLyNhaSachDataContext qlSV = new QuanLyNhaSachDataContext();
            var tpQuery = (from t in qlSV.Saches
                           where t.MaSach.Contains(ma) || t.TenSach.Contains(ma)
                           select t);
            return tpQuery;
        }
    }
}
