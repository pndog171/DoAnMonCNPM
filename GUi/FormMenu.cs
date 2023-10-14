using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GUi
{
    public partial class FormMenu : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void btnXeHoi_Click(object sender, EventArgs e)
        {
            pnXeHoi.Visible = true;
            pnXeMay.Visible = false;
            pnHoaDon.Visible = false;
        }


        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult DR = MessageBox.Show("Bạn có muốn thoát không", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DR == DialogResult.Yes)
                this.Close();
        }

        private void btnXeMay_Click(object sender, EventArgs e)
        {
            pnXeHoi.Visible = false;
            pnXeMay.Visible = true;
            pnHoaDon.Visible = false;
        }

        private void accordionControlElement5_Click(object sender, EventArgs e)
        {
            pnXeHoi.Visible = false;
            pnXeMay.Visible = false;
            pnHoaDon.Visible = true;
        }
    }
}
