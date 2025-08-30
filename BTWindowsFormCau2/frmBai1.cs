using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTWindowsFormCau2
{
    public partial class frmBai1 : Form
    {
        public frmBai1()
        {
            InitializeComponent();
        }

        private void frmBai1_Load(object sender, EventArgs e)
        {
            ThietBi tb = new ThietBi();
            tb.MaThietBi = "M01";
            tb.TenThietBi = "Máy tính";
            tb.NuocSanXuat = "Mỹ";
            tb.SoLuong = 1;
            tb.DonGia = 20000000;

            lblThongTin.Text = tb.HienThi();
        }
    }
}
