using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
   
    public partial class Form2 : Form
    {
        DataClasses1DataContext db = new DataClasses1DataContext();
        public Form2()
        {
            InitializeComponent();
            this.Load += Form2_Load;
        }

        private void LoadData()
        {
            dgvSinhVien.DataSource = db.SinhViens.ToList();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            LoadData(); // Vừa vào form là gọi hàm này luôn
        }

        // Tạo 1 hàm riêng để chuyên làm nhiệm vụ tải dữ liệu
        

        // 1. Nút Thêm
        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                SinhVien sv = new SinhVien();
                sv.Id = txtId.Text;
                sv.HoTen = txtHoTen.Text;
                sv.NgaySinh = dtpNgaySinh.Value;
                sv.Lop = txtLop.Text;
                sv.Diem = float.Parse(txtDiem.Text);

                db.SinhViens.InsertOnSubmit(sv);
                db.SubmitChanges();

                LoadData();
                MessageBox.Show("Thêm thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        // 2. Nút Sửa
        private void btnSua_Click(object sender, EventArgs e)
        {
            // Tìm sinh viên theo ID
            var sv = db.SinhViens.FirstOrDefault(s => s.Id == txtId.Text);
            if (sv != null)
            {
                sv.HoTen = txtHoTen.Text;
                sv.NgaySinh = dtpNgaySinh.Value;
                sv.Lop = txtLop.Text;
                sv.Diem = float.Parse(txtDiem.Text);

                db.SubmitChanges();
                LoadData();
                MessageBox.Show("Sửa thành công!");
            }
            else
            {
                MessageBox.Show("Không tìm thấy Sinh viên có ID này!");
            }
        }

        // 3. Nút Xóa
        private void btnXoa_Click(object sender, EventArgs e)
        {
            var sv = db.SinhViens.FirstOrDefault(s => s.Id == txtId.Text);
            if (sv != null)
            {
                db.SinhViens.DeleteOnSubmit(sv);
                db.SubmitChanges();
                LoadData();
                MessageBox.Show("Xóa thành công!");
            }
            else
            {
                MessageBox.Show("Không tìm thấy Sinh viên để xóa!");
            }
        }

        // 4. Nút Làm mới (Clear textboxes)
        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtId.Clear();
            txtHoTen.Clear();
            txtLop.Clear();
            txtDiem.Clear();
            dtpNgaySinh.Value = DateTime.Now;
            txtId.Focus();
        }

        // Tùy chọn thêm: Click vào dòng trên DataGridView thì dữ liệu nhảy lên Textbox
        private void dgvSinhVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvSinhVien.Rows[e.RowIndex];
                txtId.Text = row.Cells["Id"].Value?.ToString();
                txtHoTen.Text = row.Cells["HoTen"].Value?.ToString();
                if (row.Cells["NgaySinh"].Value != null)
                    dtpNgaySinh.Value = Convert.ToDateTime(row.Cells["NgaySinh"].Value);
                txtLop.Text = row.Cells["Lop"].Value?.ToString();
                txtDiem.Text = row.Cells["Diem"].Value?.ToString();
            }
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Lệnh này ép tắt toàn bộ chương trình (giải phóng luôn Form 1 đang ẩn)
            Application.Exit();
        }


    }
}
