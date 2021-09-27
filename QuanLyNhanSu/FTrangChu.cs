using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhanSu
{
    public partial class FTrangChu : Form
    {
        public FTrangChu()
        {
            InitializeComponent();
        }

        private void thongtinNVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FQuanLyNhanVien f = new FQuanLyNhanVien();
            f.MdiParent = this;
            f.StartPosition = FormStartPosition.CenterScreen;
            f.Show();
        }

        private void FTrangChu_Load(object sender, EventArgs e)
        {
        }

        private void timKiemNVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FTimKiemNV f = new FTimKiemNV();
            f.MdiParent = this;
            f.StartPosition = FormStartPosition.CenterScreen;
            f.Show();
        }

        private void quảnLýPhòngBanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FQuanLyPhongBan f = new FQuanLyPhongBan();
            f.MdiParent = this;
            f.StartPosition = FormStartPosition.CenterScreen;
            f.Show();
        }

        private void quảnLýChứcVụToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FQuanLyChucVu f = new FQuanLyChucVu();
            f.MdiParent = this;
            f.StartPosition = FormStartPosition.CenterScreen;
            f.Show();
        }

        private void quảnLýLươngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FQuanLyLuong f = new FQuanLyLuong();
            f.MdiParent = this;
            f.StartPosition = FormStartPosition.CenterScreen;
            f.Show();
        }
    }
}
