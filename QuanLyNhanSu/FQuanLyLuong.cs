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
            bLuong.LayDSLuong(dataGridView1);

            dataGridView1.Columns[0].Width = (int)(dataGridView1.Width * 0.2);
            dataGridView1.Columns[1].Width = (int)(dataGridView1.Width * 0.2);
            dataGridView1.Columns[2].Width = (int)(dataGridView1.Width * 0.3);
            dataGridView1.Columns[3].Width = (int)(dataGridView1.Width * 0.3);
        }

        private void FQuanLyLuong_Load(object sender, EventArgs e)
        {
            HienThiDSLuong();
            bLuong.LayDSChucVu(cbChucVu);
            txtMaLuong.Enabled = false;
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

        private void btThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            try
            {
                int chucVu = int.Parse(cbChucVu.SelectedValue.ToString());
                double luongCoBan = Double.Parse(txtLuongCoBan.Text);
                if (luongCoBan < 1000)
                {
                    MessageBox.Show("Vui lòng nhập lại thông tin!");
                }
                else
                {
                    bool flag = false;  //Chức vụ đã tồn tại trong datagridview chưa

                    //MessageBox.Show(cbChucVu.SelectedValue + " combobox " );
                    //MessageBox.Show("data row[2] " + dataGridView1.Rows[2].Cells["POSITIONID"].Value.ToString());

                    for (int i = 0; i < dataGridView1.Rows.Count; i++)
                    {
                        string positionID = dataGridView1.Rows[i].Cells["POSITIONID"].Value.ToString();

                        if (positionID.Equals(chucVu.ToString()))
                        {
                            flag = true;
                            break;
                        }

                    }

                    if (flag == true)
                    {
                        MessageBox.Show("Chức vụ này đã có.\nHãy chọn chỉnh sửa!");
                    }
                    else
                    {
                        MessageBox.Show("Đang tiến hành thêm...");

                        if (bLuong.TaoLuongChoChucVu(chucVu, luongCoBan))
                        {
                            MessageBox.Show("Thêm thành công!");
                            bLuong.LayDSLuong(dataGridView1);
                        }
                        else
                        {
                            MessageBox.Show("Lỗi khi thêm vào CSDL!");
                        }

                    }

                }


            }
            catch (Exception)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin và đúng định dạng!");
            }
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            try
            {
                int maChucVu = int.Parse(cbChucVu.SelectedValue.ToString());
                double luongCoBan = Double.Parse(txtLuongCoBan.Text);
                if (luongCoBan < 1000)
                {
                    MessageBox.Show("Vui lòng nhập lại thông tin!");
                }
                else
                {
                    SALARY s = new SALARY();
                    s.POSITIONID = maChucVu;
                    s.BASICSALARY = (decimal)luongCoBan;

                    //Gọi sự kiện sửa của BUS
                    if (bLuong.SuaLuongTheoPositionID(s))
                    {
                        MessageBox.Show("Sửa lương theo vị trí thành công!");
                        bLuong.LayDSLuong(dataGridView1);
                    }
                    else
                    {
                        MessageBox.Show("Sửa thất bại!");
     
                    }

                }


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                
                if (ex is System.NullReferenceException)
                {
                    MessageBox.Show("Chức vụ chưa có lương! \nHãy chọn THÊM LƯƠNG.");
                    return;
                }
                if (ex is System.FormatException)
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin và đúng định dạng!");
                    return;
                }
                    

                throw;
            }

            
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            try
            {
                SALARY s = new SALARY();
                s.SALARYID = int.Parse(txtMaLuong.Text);

                //Gọi sự kiện xóa của BUS
                if (bLuong.XoaLuongTheoSalaryID(s))
                {
                    MessageBox.Show("Xóa thành công!");
                    bLuong.LayDSLuong(dataGridView1);
                }
                else
                {
                    MessageBox.Show("Xóa thất bại!");
                    FQuanLyLuong f1 = new FQuanLyLuong();
                    f1.StartPosition = FormStartPosition.CenterScreen;
                    f1.Show();
                    Close();

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                if (ex is System.FormatException)
                {
                    MessageBox.Show("Hãy chọn 1 dòng có sẵn phía dưới!");
                    return;
                }
                
                throw;
            }

        }
    }
}
