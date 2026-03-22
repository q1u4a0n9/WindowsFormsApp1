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
    public partial class Form3 : Form
    {
        DataClasses1DataContext db = new DataClasses1DataContext();

        // Tạo 2 biến toàn cục để lưu lại dữ liệu Form 2 ném sang
        string maLopDuocChon = "";
        string tenLopDuocChon = "";

        // SỬA HÀM TẠO NÀY: Ép nó phải nhận 2 tham số đầu vào
        public Form3(string maLop, string tenLop)
        {
            InitializeComponent();
            maLopDuocChon = maLop;
            tenLopDuocChon = tenLop;

            // Kích hoạt sự kiện Load Form
            this.Load += Form3_Load;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // 1. Gắn tên lớp lên Label Tiêu đề
            lblTieuDe.Text = $"Danh sách sinh viên - Lớp: {maLopDuocChon} - Lớp {tenLopDuocChon}";

            // 2. DÙNG LINQ ĐỂ LỌC: Chỉ lấy những đứa sinh viên thuộc mã lớp này
            // Xóa dòng cũ và thay bằng dòng này:
            var danhSach = db.SinhViens.Where(s => s.Lop == maLopDuocChon || s.Lop == tenLopDuocChon).ToList();

            // 3. Đổ dữ liệu vào lưới
            dgvDSSV.DataSource = danhSach;

            // 4. Đếm xem có bao nhiêu đứa và in ra Label Tổng số
            lblTongSo.Text = $"Tổng số: {danhSach.Count} sinh viên";
        }

        // Nút Đóng (Click đúp vào nút Đóng trên giao diện rồi dán lệnh này)
        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvDSSV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
