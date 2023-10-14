using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        private void picThoat_Click(object sender, EventArgs e)
        {
            DialogResult DR = MessageBox.Show("Bạn có muốn thoát không", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DR == DialogResult.Yes)
            {   
                this.Close();        
                FormDangNhap f = new FormDangNhap();
                f.Visible = true;
            }
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            this.Close();
            FormDangNhap f = new FormDangNhap();
            f.Visible = true;
        }
    }
}
