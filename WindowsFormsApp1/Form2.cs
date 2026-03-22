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

        int trangHienTai = 1;
        int soDongTrenTrang = 10; // Cứ 5 sinh viên thì qua trang mới (bạn có thể đổi thành 10, 20 tùy ý)
        int tongSoTrang = 0;
        public Form2()
        {
            InitializeComponent();
            this.Load += Form2_Load;

            btnSua.Click += btnSua_Click;         // Nối nút Sửa
            btnXoa.Click += btnXoa_Click;         // Nối nút Xóa
            btnLamMoi.Click += btnLamMoi_Click;   // Nối nút Làm mới

            dgvSinhVien.CellClick += dgvSinhVien_CellClick;

            dgvLopHoc.CellClick += dgvLopHoc_CellClick;
            
  
           

            this.FormClosed += Form2_FormClosed;

        }

        private void DgvLopHoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }



        private void LoadData()
        {
            // 1. Đếm xem có tổng cộng bao nhiêu sinh viên trong Database
            int tongSoDong = db.SinhViens.Count();

            // 2. Tính tổng số trang (Ví dụ: 12 dòng / 5 = 2.4 -> Làm tròn lên là 3 trang)
            tongSoTrang = (int)Math.Ceiling((double)tongSoDong / soDongTrenTrang);

            // Chống lỗi: Nếu xóa hết sinh viên ở trang cuối thì lùi về trang trước đó
            if (trangHienTai > tongSoTrang && tongSoTrang > 0) trangHienTai = tongSoTrang;
            if (trangHienTai == 0 && tongSoTrang > 0) trangHienTai = 1;

            // 3. Sức mạnh của LINQ (Skip và Take)
            var danhSachPhanTrang = db.SinhViens
                                        .Skip((trangHienTai - 1) * soDongTrenTrang)
                                        .Take(soDongTrenTrang)
                                        .ToList();

            // 4. Đổ dữ liệu đã cắt xén lên lưới
            dgvSinhVien.DataSource = danhSachPhanTrang;

            // 5. Hiện thông số trang và Bật/Tắt các nút bấm cho logic
            if (tongSoTrang > 0)
            {
                lblTrang.Text = $"Trang {trangHienTai} / {tongSoTrang}";
            }
            else
            {
                lblTrang.Text = "Không có dữ liệu";
            }

            // Đang ở trang 1 thì tắt nút Trước, đang ở trang cuối thì tắt nút Sau
            btnTrangTruoc.Enabled = (trangHienTai > 1);
            btnTrangSau.Enabled = (trangHienTai < tongSoTrang);
        }

        private void Form2_Load(object sender, EventArgs e)
        {

            LoadData();          // Tải danh sách Sinh viên (Tab 1)
            LoadDataLop();       // Tải danh sách Lớp (Tab 2)
            LoadComboBoxLop();   // Đổ danh sách lớp vào cái ComboBox ở Tab 1
        }

        // Tạo 1 hàm riêng để chuyên làm nhiệm vụ tải dữ liệu

        private void btnTrangTruoc_Click(object sender, EventArgs e)
        {
            if (trangHienTai > 1)
            {
                trangHienTai--; // Lùi lại 1 trang
                LoadData();     // Tải lại lưới
            }
        }

        private void btnTrangSau_Click(object sender, EventArgs e)
        {
            if (trangHienTai < tongSoTrang)
            {
                trangHienTai++; // Tiến tới 1 trang
                LoadData();     // Tải lại lưới
            }
        }


        //code cho Tab Sinh Vien



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
                // Nếu nút Nam được tích thì lưu chữ "Nam", ngược lại lưu chữ "Nữ"
                sv.GioiTinh = radNam.Checked ? "Nam" : "Nữ";
                sv.Id = txtId.Text;
                sv.HoTen = txtHoTen.Text;
                sv.NgaySinh = dtpNgaySinh.Value;
                sv.Lop = cbbLop.SelectedValue.ToString();
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
                    sv.Lop = cbbLop.SelectedValue.ToString();
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

                // Thêm đoạn này vào dưới cùng của hàm CellClick
                if (row.Cells["GioiTinh"].Value != null)
                {
                    string gt = row.Cells["GioiTinh"].Value.ToString();
                    if (gt == "Nam")
                    {
                        radNam.Checked = true;
                    }
                    else if (gt == "Nữ")
                    {
                        radNu.Checked = true;
                    }
                }

            }
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Lệnh này ép tắt toàn bộ chương trình (giải phóng luôn Form 1 đang ẩn)
            Application.Exit();
        }

        private void ClearInputs()
        {
            radNam.Checked = true;
            txtId.Clear();
            txtHoTen.Clear();
            txtDiem.Clear();
            cbbLop.SelectedIndex = -1; // Đưa ComboBox về trạng thái trống (chưa chọn gì)
            cbbLop.Text = "";          // Xóa chữ đang hiển thị
            dtpNgaySinh.Value = DateTime.Now;
            txtId.Focus();             // Đưa con trỏ chuột về lại ô ID cho người dùng gõ tiếp
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



        //End code Tab SinhVien


        //code cho Tab Lophoc
        // ==========================================================
        // KHU VỰC CODE DÀNH RIÊNG CHO TAB 2 (QUẢN LÝ LỚP HỌC)
        // ==========================================================

        private void LoadDataLop()
        {
            dgvLopHoc.DataSource = db.LopHocs.ToList();
        }

        private void ClearInputsLop()
        {
            txtMaLop.Clear();
            txtTenLop.Clear();
            txtMaLop.Focus();
        }

        // Hàm này cực kỳ quan trọng: Lấy danh sách lớp đổ vào ComboBox ở Tab 1
        private void LoadComboBoxLop()
        {
            cbbLop.DataSource = db.LopHocs.ToList();
            cbbLop.DisplayMember = "TenLop"; // Hiện tên lớp cho người dùng chọn
            cbbLop.ValueMember = "MaLop";    // Ngầm lưu mã lớp ở dưới
            cbbLop.SelectedIndex = -1;       // Để trống lúc ban đầu
        }

        // 1. Nút Thêm Lớp
        private void btnThemLop_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtMaLop.Text) || string.IsNullOrWhiteSpace(txtTenLop.Text))
                {
                    MessageBox.Show("Vui lòng nhập đủ Mã lớp và Tên lớp!"); return;
                }

                var check = db.LopHocs.FirstOrDefault(l => l.MaLop == txtMaLop.Text);
                if (check != null)
                {
                    MessageBox.Show("Mã lớp này đã tồn tại!"); return;
                }

                LopHoc lop = new LopHoc();
                lop.MaLop = txtMaLop.Text;
                lop.TenLop = txtTenLop.Text;

                db.LopHocs.InsertOnSubmit(lop);
                db.SubmitChanges();

                LoadDataLop();
                LoadComboBoxLop(); // Cập nhật lại ComboBox bên Tab 1
                ClearInputsLop();
                MessageBox.Show("Thêm lớp thành công!");
            }
            catch (Exception ex) { MessageBox.Show("Lỗi: " + ex.Message); }
        }

        // 2. Nút Sửa Lớp
        private void btnSuaLop_Click(object sender, EventArgs e)
        {
            try
            {
                var lop = db.LopHocs.FirstOrDefault(l => l.MaLop == txtMaLop.Text);
                if (lop != null)
                {
                    lop.TenLop = txtTenLop.Text; // Thường người ta chỉ sửa Tên lớp, không cho sửa Mã
                    db.SubmitChanges();

                    LoadDataLop();
                    LoadComboBoxLop(); // Cập nhật lại ComboBox bên Tab 1
                    ClearInputsLop();
                    MessageBox.Show("Sửa lớp thành công!");
                }
                else { MessageBox.Show("Không tìm thấy lớp để sửa!"); }
            }
            catch (Exception ex) { MessageBox.Show("Lỗi: " + ex.Message); }
        }

        // 3. Nút Xóa Lớp
        private void btnXoaLop_Click(object sender, EventArgs e)
        {
            try
            {
                var lop = db.LopHocs.FirstOrDefault(l => l.MaLop == txtMaLop.Text);
                if (lop != null)
                {
                    db.LopHocs.DeleteOnSubmit(lop);
                    db.SubmitChanges();

                    LoadDataLop();
                    LoadComboBoxLop(); // Cập nhật lại ComboBox bên Tab 1
                    ClearInputsLop();
                    MessageBox.Show("Xóa lớp thành công!");
                }
                else { MessageBox.Show("Không tìm thấy lớp để xóa!"); }
            }
            catch (Exception ex) { MessageBox.Show("Lỗi: " + ex.Message); }
        }

        // 4. Nút Làm mới Lớp
        private void btnLamMoiLop_Click(object sender, EventArgs e)
        {
            ClearInputsLop();
        }

        // 5. Click vào DataGridView Lớp Học
        private void dgvLopHoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvLopHoc.Rows[e.RowIndex];
                txtMaLop.Text = row.Cells["MaLop"].Value?.ToString();
                txtTenLop.Text = row.Cells["TenLop"].Value?.ToString();
            }
        }

        private void btnTimKiemLop_Click(object sender, EventArgs e)
        {
            string tuKhoa = txtTimKiemLop.Text.Trim().ToLower(); // Cắt dấu cách thừa và chuyển về chữ thường để dễ tìm

            if (string.IsNullOrEmpty(tuKhoa))
            {
                // Nếu ô tìm kiếm trống mà bấm nút, thì load lại toàn bộ danh sách
                LoadDataLop();
            }
            else
            {
                // LINQ tìm kiếm: Nếu Mã chứa từ khóa HOẶC Tên chứa từ khóa HOẶC Lớp chứa từ khóa
                var ketQua = db.LopHocs.Where(s =>
                                s.MaLop.ToLower().Contains(tuKhoa) ||
                                s.TenLop.ToLower().Contains(tuKhoa) 
                             ).ToList();

                // Đổ dữ liệu tìm được lên DataGridView
                dgvLopHoc.DataSource = ketQua;

                // Tùy chọn: Thông báo nếu không tìm thấy ai
                if (ketQua.Count == 0)
                {
                    MessageBox.Show("Không tìm thấy kết quả nào phù hợp!", "Thông báo");
                }
            }
        }

        private void btnXemDSSV_Click(object sender, EventArgs e)
        {
            // 1. Kiểm tra xem người dùng đã bấm chọn lớp nào trên lưới chưa
            // (Dựa vào ô txtMaLop xem có trống không)
            if (string.IsNullOrWhiteSpace(txtMaLop.Text))
            {
                MessageBox.Show("Vui lòng click chọn một Lớp trên lưới để xem danh sách!", "Thông báo");
                return;
            }

            // 2. Lấy mã lớp và tên lớp đang hiển thị ở Textbox
            string maLop = txtMaLop.Text;
            string tenLop = txtTenLop.Text;

            // 3. Gọi Form 3 ra, NÉM mã lớp và tên lớp sang cho nó qua dấu ngoặc tròn
            Form3 f3 = new Form3(maLop, tenLop);

            // 4. Mở Form 3 lên dưới dạng Popup
            f3.ShowDialog();
        }

        private void Form2_Load_1(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}
