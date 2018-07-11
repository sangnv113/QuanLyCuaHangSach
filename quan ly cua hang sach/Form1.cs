using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace quan_ly_cua_hang_sach
{
    public partial class Form1 : Form
    {
        public static int QuyenTC = 0;
        QuanLyNhaSachDataContext ns = new QuanLyNhaSachDataContext();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            int t = 0;
            var getpass = from k in ns.TaiKhoanTruyCaps
                          where  k.TenTaiKhoan== txtuser.Text
                          select k;
            foreach (var k in getpass)
            {
                t++;
            }
            if(t==0)
            {
                MessageBox.Show(" Tên đăng nhập sai!!");
            }
            foreach (var k in getpass)
                if (k.MatKhau.Trim() == txtpass.Text.Trim())
                {
                    QuyenTC =int.Parse(k.QuyenTruyCap);
                    this.Hide();
                     Quản_lý ql=new Quản_lý();
                     ql.Show();
                }
                   
                else
                {
                    MessageBox.Show("Mật khẩu sai!!");
                    
                }
        }
    }
}
