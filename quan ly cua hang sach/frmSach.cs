using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.Linq;
using System.Data.Linq.Mapping;

using System.Drawing.Imaging;
using quan_ly_cua_hang_sach.BS_Layer;
using System.IO;

namespace quan_ly_cua_hang_sach
{
   
    public partial class frmSach : Form
    {
        BL_Sach dbS = new BL_Sach();
        string err;
        bool Them ;
        string manxb = "";
        string mathetloai = "";
        string mangonngu = "";
        public frmSach()
        {
            InitializeComponent();
        }
    
     void LoadData()
        {
            try
            {

                // Đưa dữ liệu lên DataGridView
                dgrSach.DataSource = dbS.Laysach();
                // Thay đổi độ rộng cột
                dgrSach.AutoResizeColumns();
                // Xóa trống các đối tượng trong Panel

                dgrSach_CellClick(null, null);
            }
            catch
            {
                MessageBox.Show("Không lấy được nội dung trong table Nha Cung cap");
            }
        }

     private void dgrSach_CellClick(object sender, DataGridViewCellEventArgs e)
     {
         try
         {
            
             int r = dgrSach.CurrentCell.RowIndex;
             // Chuyển thông tin lên panel
             this.txtmasach.Text =
             dgrSach.Rows[r].Cells[0].Value.ToString();
             this.txttensach.Text =
             dgrSach.Rows[r].Cells[1].Value.ToString();
             this.txttacgia.Text =
           dgrSach.Rows[r].Cells[2].Value.ToString();
             manxb =
             dgrSach.Rows[r].Cells[3].Value.ToString();

             this.txtsotrang.Text = 
           dgrSach.Rows[r].Cells[4].Value.ToString();
             mangonngu =
             dgrSach.Rows[r].Cells[5].Value.ToString();
             mathetloai =
              dgrSach.Rows[r].Cells[6].Value.ToString();

             this.txttinhtrang.Text = 
           dgrSach.Rows[r].Cells[7].Value.ToString();
             this.txtvitri.Text =
             dgrSach.Rows[r].Cells[8].Value.ToString();
             loadma();
         }
         catch
         { }
     }
     private void loadma()
     {
         QuanLyNhaSachDataContext s = new QuanLyNhaSachDataContext();
         var nxb = from nx in s.NXBs where manxb == nx.MaNXB select nx;
         var nn = from n in s.NGONNGUs where mangonngu == n.MaNgonNgu select n;
         var tl = from t in s.THELOAIs where mathetloai == t.MaTheLoai select t;
         foreach (var nx in nxb)
         {
             txtnxb.Text = nx.TenNXB;
         }
         foreach (var n in nn)
         {
             txtngonngu.Text = n.NgonNgu1;
         }
         foreach (var t in tl)
         {
             txttheloai.Text = t.TheLoai1;
         }
     }

     private void sach_Load(object sender, EventArgs e)
     {
         QuanLyNhaSachDataContext s = new QuanLyNhaSachDataContext();
         var nxb = from nx in s.NXBs select nx;
         var nn = from n in s.NGONNGUs select n;
         var tl = from t in s.THELOAIs select t;
         var vt = from v in s.KeSaches select v;
         foreach (var nx in nxb)
         {
             this.txtnxb.Items.AddRange(new object[] { nx.TenNXB });
         }
         foreach (var n in nn)
         {
             this.txtngonngu.Items.AddRange(new object[] { n.NgonNgu1 });
         }
         foreach (var t in tl)
         {
             this.txttheloai.Items.AddRange(new object[] { t.TheLoai1 });
         }
         foreach (var v in vt)
         {
             this.txtvitri.Items.AddRange(new object[] { v.TenKeSach });
         }
         LoadData();
         grbthongtin.Enabled = false;
     }

     private void btnsua_Click(object sender, EventArgs e)
     {
         try
         {
             grbthongtin.Enabled = true;
             Them = false;

             grbbtn.Enabled = false;
             dgrSach_CellClick(null, null);
             this.grbbtn.Enabled = false;
             this.txttensach.Focus();

         }
       catch
         {
             MessageBox.Show("loi");
         }
            
     }

     private void btnthoat_Click(object sender, EventArgs e)
     {
         DialogResult traloi;
         // Hiện hộp thoại hỏi đáp
         traloi = MessageBox.Show("Thoát?", "Trả lời",
         MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
         // Kiểm tra có nhắp chọn nút Ok không?
         if (traloi == DialogResult.OK) this.Close();
     }

     private void btnthem_Click(object sender, EventArgs e)
     {
         Them = true;
         grbthongtin.Enabled = true;
         grbbtn.Enabled = false;
         // Xóa trống các đối tượng trong Panel
         this.txttensach.ResetText();
         this.txttacgia.ResetText();
         this.txtnxb.ResetText();
         this.txtngonngu.ResetText();
         this.txttheloai.ResetText();
         this.txttinhtrang.ResetText();
         this.txtvitri.ResetText();
         this.txtmasach.ResetText();
         
         this.txttensach.Focus();
     }

     private void btnxoa_Click(object sender, EventArgs e)
     {
         try
         {
             int r = dgrSach.CurrentCell.RowIndex;
             string strmasach =
             dgrSach.Rows[r].Cells[0].Value.ToString();
             DialogResult traloi;
             traloi = MessageBox.Show("Chắc xóa mẫu tin này không?", "Trả lời",
             MessageBoxButtons.YesNo, MessageBoxIcon.Question);
             if (traloi == DialogResult.Yes)
             {
                 dbS.XoaSach(ref err, strmasach);
                 LoadData();
                 MessageBox.Show("Đã xóa xong!");
             }
             else
             {
                 MessageBox.Show("Không thực hiện việc xóa mẫu tin!");
             }
         }
         catch
         {
             MessageBox.Show("Không xóa được!");
         }
     }

     private void btnhuy_Click(object sender, EventArgs e)
     {

         this.txttensach.ResetText();
         this.txttacgia.ResetText();
         this.txtnxb.ResetText();
         this.txtsotrang.ResetText();
         this.txtngonngu.ResetText();
         this.txttheloai.ResetText();
         this.txttinhtrang.ResetText();
         this.txtvitri.ResetText();
         dgrSach_CellClick(null, null);
         grbbtn.Enabled = true;
         grbthongtin.Enabled = false;
     }

     private void btnluu_Click(object sender, EventArgs e)
     {
         layma();
         if (Them)
         {

           
             try
             {
                 dbS.ThemSach(this.txtmasach.Text, this.txttensach.Text, this.txttacgia.Text, manxb,
                 int.Parse(this.txtsotrang.Text.Trim()), mangonngu, mathetloai, this.txttinhtrang.Text, this.txtvitri.Text, ref err);

                 LoadData();
                
                 // Thông báo
                 MessageBox.Show("Đã thêm xong!");
             }
             catch
             {

                 MessageBox.Show("Không thêm được!");
             }
         }
         else
         {
             try
             {
                 


                 dbS.CapNhatSach(this.txtmasach.Text, this.txttensach.Text, this.txttacgia.Text, manxb,
                 int.Parse(this.txtsotrang.Text.Trim()), mangonngu, mathetloai, this.txttinhtrang.Text, this.txtvitri.Text, ref err);
                 LoadData();
                 // Thông báo
                 MessageBox.Show("Đã sửa xong!");
                 grbthongtin.Enabled = false;
                 grbbtn.Enabled = true;
             }
             catch
             {
                 MessageBox.Show("Không sửa được!");
             }

         }
     }

     private void layma()
     {
         QuanLyNhaSachDataContext s = new QuanLyNhaSachDataContext();
         var nxb = from nx in s.NXBs  where txtnxb.Text.Trim()==nx.TenNXB select nx;
         var nn = from n in s.NGONNGUs where txtngonngu.Text.Trim()==n.NgonNgu1 select n;
         var tl = from t in s.THELOAIs where txttheloai.Text.Trim() == t.TheLoai1 select t;
         foreach (var nx in nxb)
         {
             manxb = nx.MaNXB;
         }
         foreach (var n in nn)
         {
             mangonngu = n.MaNgonNgu;
         }
         foreach (var t in tl)
         {
             mathetloai = t.MaTheLoai;
         }
        

     }
     private void btnReload_Click(object sender, EventArgs e)
     {
         LoadData();
         textBox1.ResetText();
     }

     private void textBox1_KeyUp(object sender, KeyEventArgs e)
     {
         dgrSach.DataSource = dbS.timkiem(textBox1.Text);
     }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txttensach_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
