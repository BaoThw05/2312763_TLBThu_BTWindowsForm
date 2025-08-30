using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTWindowsFormCau3
{
    public partial class frmBai1 : Form
    {
        public frmBai1()
        {
            InitializeComponent();
        }

        private void frmBai1_Load(object sender, EventArgs e)
        {
            NhanVien nv=new NhanVien();
            nv.MaNV = "2312763";
            nv.HoTen = "Trần Lê Bảo Thư";
            nv.NgaySinh = new DateTime(2005, 06, 05);
            nv.HeSoLuong = 3;
            nv.HeSoPhuCap = 4;
            lblThongTin.Text = nv.HienThi();
        }
    }
}
