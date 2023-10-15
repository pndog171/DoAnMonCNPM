using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DevExpress.Skins.SolidColorHelper;

namespace GUi
{
    public partial class FormDangKy : Form
    {
        public FormDangKy()
        {
            InitializeComponent();
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {

        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            FormDangKy formDangKy = new FormDangKy();
            string TenNguoidung = txtTenNguoiDung.Text;
            string TenTaikoan = txtTenTK.Text;
            string matKhau = txtMatKhau.Text;
            string nhaplaiMatkhau = txtNhapLaiMatKhau.Text;
            string email = txtEmail.Text;
            string sodienthoai = txtSoDienThoai.Text;

            int tenTaiKhoanToiThieu = 8;
            int matKhauToiThieu = 8;
            int tenTaiKhoanToiDa = 22;
            int matKhauToiDa = 15;

            if (string.IsNullOrWhiteSpace(TenNguoidung) || string.IsNullOrWhiteSpace(TenTaikoan) ||
                string.IsNullOrWhiteSpace(matKhau) || string.IsNullOrWhiteSpace(nhaplaiMatkhau) ||
                string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(sodienthoai))
            {
                MessageBox.Show("Vui lòng hãy điền đầy đủ thông tin ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (TenTaikoan.Length < tenTaiKhoanToiThieu)
            {
                MessageBox.Show($"Tên tài khoản phải có ít nhất {tenTaiKhoanToiThieu} ký tự.\nHãy nhập lại !", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (TenTaikoan.Length > tenTaiKhoanToiDa)
            {
                MessageBox.Show($"Tên tài khoản tối đa có {tenTaiKhoanToiDa} ký tự.\nHãy nhập lại!!!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (matKhau.Length > matKhauToiDa)
            {
                MessageBox.Show($"Mật khẩu có tối đa là {matKhauToiDa} ký tự.\nHãy nhập lại !", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (matKhau.Length < matKhauToiThieu)
            {
                MessageBox.Show($"Mật khẩu có it nhất là {matKhauToiThieu} ký tự.\nHãy nhập lại !", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (matKhau != nhaplaiMatkhau)
            {
                MessageBox.Show("Mật khẩu và nhập lại mật khẩu không khớp.\nVui lòng kiểm tra và nhập lại", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Đăng ký đã thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void picThoat_Click(object sender, EventArgs e)
        {

            DialogResult DR = MessageBox.Show("Bạn có muốn thoát không", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DR == DialogResult.Yes)
                this.Close();
            FormDangNhap formDangNhap = new FormDangNhap();
            this.Hide();
            formDangNhap.ShowDialog();
        }
        private string imagePath = null;
        private void pictureBoxAnh_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
                openFileDialog.Title = "Chọn ảnh";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    imagePath = openFileDialog.FileName;
                    pictureBoxAnh.Image = new Bitmap(imagePath);
                }
            }
        }
    }
}
