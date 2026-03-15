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

            btnSua.Click += btnSua_Click;         // Nối nút Sửa
            btnXoa.Click += btnXoa_Click;         // Nối nút Xóa
            btnLamMoi.Click += btnLamMoi_Click;   // Nối nút Làm mới

            dgvSinhVien.CellClick += dgvSinhVien_CellClick;

            this.FormClosed += Form2_FormClosed;

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
                // 1. Kiểm tra rỗng
                if (string.IsNullOrWhiteSpace(txtId.Text) || string.IsNullOrWhiteSpace(txtHoTen.Text))
                {
                    MessageBox.Show("Vui lòng nhập đủ ID và Họ tên!");
                    return;
                }

                // 2. Kiểm tra trùng ID
                var kiemTraTrung = db.SinhViens.FirstOrDefault(s => s.Id == txtId.Text);
                if (kiemTraTrung != null)
                {
                    MessageBox.Show("Mã Sinh Viên (ID) đã tồn tại, vui lòng nhập ID khác!");
                    return;
                }

                // 3. Kiểm tra nhập Điểm có đúng là số không
                if (!float.TryParse(txtDiem.Text, out float diemKiemTra))
                {
                    MessageBox.Show("Điểm phải là một số hợp lệ!");
                    return;
                }

                SinhVien sv = new SinhVien();
                sv.Id = txtId.Text;
                sv.HoTen = txtHoTen.Text;
                sv.NgaySinh = dtpNgaySinh.Value;
                sv.Lop = cbbLop.Text;
                sv.Diem = diemKiemTra; // Dùng luôn biến đã tryParse thành công

                db.SinhViens.InsertOnSubmit(sv);
                db.SubmitChanges();

                LoadData();
                ClearInputs();
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
            try
            {
                var sv = db.SinhViens.FirstOrDefault(s => s.Id == txtId.Text);
                if (sv != null)
                {
                    // Kiểm tra điểm đầu vào
                    if (!float.TryParse(txtDiem.Text, out float diemKiemTra))
                    {
                        MessageBox.Show("Điểm phải là một số hợp lệ!");
                        return;
                    }

                    sv.HoTen = txtHoTen.Text;
                    sv.NgaySinh = dtpNgaySinh.Value;
                    sv.Lop = cbbLop.Text;
                    sv.Diem = diemKiemTra;

                    db.SubmitChanges();
                    ClearInputs();
                    LoadData();
                    MessageBox.Show("Sửa thành công!");
                }
                else
                {
                    MessageBox.Show("Không tìm thấy Sinh viên có ID này!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi sửa: " + ex.Message);
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
                ClearInputs();
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
            cbbLop.SelectedIndex = -1; // Bỏ chọn danh sách xổ xuống
            cbbLop.Text = "";          // Xóa chữ đang hiển thị trên ô nhập
            txtDiem.Clear();
            dtpNgaySinh.Value = DateTime.Now;
            txtId.Focus();
        }

        // Tùy chọn thêm: Click vào dòng trên DataGridView thì dữ liệu nhảy lên Textbox
        private void dgvSinhVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Bỏ qua nếu người dùng bấm vào dòng tiêu đề (Header)
            if (e.RowIndex >= 0)
            {
                // Lấy cái hàng mà người dùng vừa click chuột vào
                DataGridViewRow row = dgvSinhVien.Rows[e.RowIndex];

                // Đổ dữ liệu từ hàng đó ngược ra Textbox
                txtId.Text = row.Cells["Id"].Value?.ToString();
                txtHoTen.Text = row.Cells["HoTen"].Value?.ToString();

                // Kiểm tra và gán ngày sinh (sử dụng DateTime.TryParse để chống lỗi crash)
                if (row.Cells["NgaySinh"].Value != null)
                {
                    if (DateTime.TryParse(row.Cells["NgaySinh"].Value.ToString(), out DateTime parsedDate))
                    {
                        dtpNgaySinh.Value = parsedDate;
                    }
                }

                cbbLop.Text = row.Cells["Lop"].Value?.ToString();
                txtDiem.Text = row.Cells["Diem"].Value?.ToString();
            }
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Lệnh này ép tắt toàn bộ chương trình (giải phóng luôn Form 1 đang ẩn)
            Application.Exit();
        }

        private void ClearInputs()
        {
            txtId.Clear();
            txtHoTen.Clear();
            txtDiem.Clear();
            cbbLop.SelectedIndex = -1; // Đưa ComboBox về trạng thái trống (chưa chọn gì)
            cbbLop.Text = "";          // Xóa chữ đang hiển thị
            dtpNgaySinh.Value = DateTime.Now;
            txtId.Focus();             // Đưa con trỏ chuột về lại ô ID cho người dùng gõ tiếp
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string tuKhoa = txtTimKiem.Text.Trim().ToLower(); // Cắt dấu cách thừa và chuyển về chữ thường để dễ tìm

            if (string.IsNullOrEmpty(tuKhoa))
            {
                // Nếu ô tìm kiếm trống mà bấm nút, thì load lại toàn bộ danh sách
                LoadData();
            }
            else
            {
                // LINQ tìm kiếm: Nếu Mã chứa từ khóa HOẶC Tên chứa từ khóa HOẶC Lớp chứa từ khóa
                var ketQua = db.SinhViens.Where(s =>
                                s.Id.ToLower().Contains(tuKhoa) ||
                                s.HoTen.ToLower().Contains(tuKhoa) ||
                                s.Lop.ToLower().Contains(tuKhoa)
                             ).ToList();

                // Đổ dữ liệu tìm được lên DataGridView
                dgvSinhVien.DataSource = ketQua;

                // Tùy chọn: Thông báo nếu không tìm thấy ai
                if (ketQua.Count == 0)
                {
                    MessageBox.Show("Không tìm thấy kết quả nào phù hợp!", "Thông báo");
                }
            }
        }
    }
}
