using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.IO;
using System.Data;
using System.Windows.Forms;
namespace quan_ly_cua_hang_sach.BS_Layer
{

    class BLTraCuusachNhap
    {
        QuanLyNhaSachDataContext qlNS = new QuanLyNhaSachDataContext();
        int gia1 = 0, gia2 = 0;
        public DataTable Laysach()
        {


            var sa = from p in qlNS.Saches select p;
            var nxb = from nx in qlNS.NXBs select nx;
            var nn = from n in qlNS.NGONNGUs select n;
            var tl = from t in qlNS.THELOAIs select t;
            var vt = from v in qlNS.KeSaches select v;
            var gt = from g in qlNS.SachMuaVaos select g;
            DataTable dt = new DataTable();
            dt.Columns.Add("MaSach");
            dt.Columns.Add("Tên sách");
            dt.Columns.Add("Giá tiền");
            dt.Columns.Add("Tác giả");
            dt.Columns.Add("Nhà xuất bản");
            dt.Columns.Add("Số trang");
            dt.Columns.Add("Ngôn ngữ");
            dt.Columns.Add("Thể loại");
            dt.Columns.Add("Tình trạng");
            dt.Columns.Add("Vị trí");
            foreach (var p in sa)
            {
                string varnxb = "";
                string varnn = "";
                string vartl = "";
                string varvitri = "";
                int vargt = 0;
                foreach (var nx in nxb)
                {
                    if (nx.MaNXB == p.NhaXuatBan)
                    {
                        varnxb = nx.TenNXB;
                    }
                }
                foreach (var n in nn)
                {
                    if (n.MaNgonNgu == p.NgonNgu)
                    {
                        varnn = n.NgonNgu1;
                    }
                }
                foreach (var t in tl)
                {
                    if (t.MaTheLoai == p.TheLoai)
                    {
                        vartl = t.TheLoai1;
                    }
                }
                foreach (var v in vt)
                {
                    if (v.TenKeSach == p.ViTri)
                    {
                        varvitri = v.TenKeSach;
                    }
                }
                foreach (var g in gt)
                {
                    if (g.MaSach == p.MaSach)
                    {
                        vargt =(int) g.GiaTien;
                    }
                }
                dt.Rows.Add(p.MaSach, p.TenSach, vargt, p.TacGia, varnxb, p.SoTrang, varnn, vartl, p.TinhTrang, varvitri);
            }
            return dt;
        }
        public DataTable timkiem(string ma, string mnxb, string mtl, string mnn, string tacgia, string Tgia1, string Tgia2, bool gia)
        {
            try
            {
                this.gia1 = int.Parse(Tgia1);
                this.gia2 = int.Parse(Tgia2);
            }
            catch { }

            //QuanLyNhaSachDataContext s = new QuanLyNhaSachDataContext();
            //if(frmTraCuuSach.ch_Ten==1)
            //{

            //}
            //else
            //{
            //    if (frmTraCuuSach.ch_Ten == 0)
            //    {

            //    }
            //}
            var maQuery = (from s1 in qlNS.Saches
                           where
                           s1.TenSach.Contains(ma) && s1.NhaXuatBan.Contains(laynxb(mnxb))
                           && s1.TheLoai.Contains(laytheloai(mtl)) && s1.NgonNgu.Contains(layngonngu(mnn)) && s1.TacGia.Contains(tacgia)

                           || s1.MaSach.Contains(ma) && s1.NhaXuatBan.Contains(laynxb(mnxb))
                           && s1.TheLoai.Contains(laytheloai(mtl)) && s1.NgonNgu.Contains(layngonngu(mnn)) && s1.TacGia.Contains(tacgia)
                           select s1
                               );

            var giaQR = from gi in qlNS.SachMuaVaos where gi.GiaTien >= gia1 && gi.GiaTien <= gia2 select gi;


            var nxb = from nx in qlNS.NXBs select nx;
            var nn = from n in qlNS.NGONNGUs select n;
            var tl = from t in qlNS.THELOAIs select t;
            var vt = from v in qlNS.KeSaches select v;
            var gt = from g in qlNS.SachMuaVaos select g;
            DataTable dt = new DataTable();
            dt.Columns.Add("MaSach");
            dt.Columns.Add("Tên sách");
            dt.Columns.Add("Giá tiền");
            dt.Columns.Add("Tác giả");
            dt.Columns.Add("Nhà xuất bản");
            dt.Columns.Add("Số trang");
            dt.Columns.Add("Ngôn ngữ");
            dt.Columns.Add("Thể loại");
            dt.Columns.Add("Tình trạng");
            dt.Columns.Add("Vị trí");
            foreach (var p in maQuery)
            {
                string varnxb = "";
                string varnn = "";
                string vartl = "";
                string varvitri = "";
                int vargt = 0;
                foreach (var nx in nxb)
                {
                    if (nx.MaNXB == p.NhaXuatBan)
                    {
                        varnxb = nx.TenNXB;
                    }
                }
                foreach (var n in nn)
                {
                    if (n.MaNgonNgu == p.NgonNgu)
                    {
                        varnn = n.NgonNgu1;
                    }
                }
                foreach (var t in tl)
                {
                    if (t.MaTheLoai == p.TheLoai)
                    {
                        vartl = t.TheLoai1;
                    }
                }
                foreach (var v in vt)
                {
                    if (v.TenKeSach == p.ViTri)
                    {
                        varvitri = v.TenKeSach;
                    }
                }
                foreach (var g in gt)
                {
                    if (g.MaSach == p.MaSach)
                    {
                        vargt = (int)g.GiaTien;
                    }
                }
                if (gia == true)
                {
                    foreach (var gi in giaQR)
                    {
                        if (p.MaSach == gi.MaSach)
                        {
                            dt.Rows.Add(p.MaSach, p.TenSach, vargt, p.TacGia, varnxb, p.SoTrang, varnn, vartl, p.TinhTrang, varvitri);
                        }
                    }
                }
                else
                {
                    dt.Rows.Add(p.MaSach, p.TenSach, vargt, p.TacGia, varnxb, p.SoTrang, varnn, vartl, p.TinhTrang, varvitri);
                }

            }
            return dt;
        }

        public string laynxb(string Ten)
        {
            string Ma = "";
            var nxb = from nx in qlNS.NXBs select nx;
            foreach (var nx in nxb)
            {
                if (nx.TenNXB.Trim() == Ten)
                {
                    Ma = nx.MaNXB;
                }
            }
            return Ma.Trim();
        }
        public string laytheloai(string Ten)
        {
            string Ma = "";
            var tl = from t in qlNS.THELOAIs select t;
            foreach (var t in tl)
            {
                if (t.TheLoai1.Trim() == Ten)
                {
                    Ma = t.MaTheLoai;
                }
            }
            return Ma.Trim();
        }
        public string layngonngu(string Ten)
        {
            string Ma = "";
            var nn = from n in qlNS.NGONNGUs select n;
            foreach (var nx in nn)
            {
                if (nx.NgonNgu1.Trim() == Ten)
                {
                    Ma = nx.MaNgonNgu;
                }
            }
            return Ma.Trim();
        }
      

    }
}
