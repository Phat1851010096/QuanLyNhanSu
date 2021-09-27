using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyNhanSu.BUS;

namespace QuanLyNhanSu
{
    public partial class FQuanLyLuong : Form
    {
        BUS_Luong bLuong;
        public FQuanLyLuong()
        {
            InitializeComponent();
            bLuong = new BUS_Luong();
        }

        public void HienThiDSLuong()
        {
            dataGridView1.DataSource = null;
            bLuong.LayDSSanPham(dataGridView1);

            dataGridView1.Columns[0].Width = (int)(dataGridView1.Width * 0.2);
            dataGridView1.Columns[1].Width = (int)(dataGridView1.Width * 0.4);
            dataGridView1.Columns[2].Width = (int)(dataGridView1.Width * 0.4);
        }

        private void FQuanLyLuong_Load(object sender, EventArgs e)
        {
            HienThiDSLuong();
            bLuong.LayDSChucVu(cbChucVu);

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.RowCount)
            {
                txtMaLuong.Enabled = false;
                txtMaLuong.Text = dataGridView1.Rows[e.RowIndex].Cells["SalaryID"].Value.ToString();
                cbChucVu.Text = dataGridView1.Rows[e.RowIndex].Cells["NAME"].Value.ToString();
                txtLuongCoBan.Text = dataGridView1.Rows[e.RowIndex].Cells["BASICSALARY"].Value.ToString();
                
            }
        }
    }
}
