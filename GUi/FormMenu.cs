using DevExpress.XtraBars;
using DevExpress.XtraPrinting.NativeBricks;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DAL.Entities;
using BUS.Service;

namespace GUi
{
    public partial class FormMenu : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        private readonly Model1 context = new Model1();
        private  Xe xe = new Xe();
        private readonly Phuongtien pt = new Phuongtien();
        private readonly Loaiphuongtien lpt = new Loaiphuongtien();
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

        private void pnXeMay_Paint(object sender, PaintEventArgs e)
        {
            try
            {
                var listTheloai = lpt.GetAll();
                var listXe = pt.GetAll();
                FillTypeofXeCombobox(listTheloai);
                BindGridXeMay(listXe);
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dtGVXemay_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dtGVXemay.CurrentRow.Index != -1)
            {
                xe.MaXe = dtGVXemay.CurrentRow.Cells[0].Value.ToString();
                using (Model1 db = new Model1())
                {
                    xe = db.Xes.Where(x => x.MaXe == xe.MaXe).FirstOrDefault();
                    txtMaXM.Text = xe.MaXe.ToString();
                    txtTenXeMay.Text = xe.TenXe.ToString();
                    txtMauSacXeMay.Text = xe.Mau.ToString();
                    foreach(var item in cbLoai.Items)
                    {
                        if (((LoaiXe)item).TenLoai == dtGVXemay.Rows[dtGVXemay.CurrentRow.Index].Cells[2].Value.ToString())
                        {
                            cbLoai.SelectedItem = item;
                            break;
                        }  
                    }
                }
            }
        }

        private int getSelectedRow(string maxe) //GETSELECTEDROW
        {
            for(int i = 0;i <dtGVXemay.Rows.Count;i++)
            {
                if (dtGVXemay.Rows[i].Cells[0].Value.ToString() == maxe)
                {
                    return i;
                }
            }
            return -1;
        }
        private void getValue() //GETVALUE
        {
            string selectedTheloaixe = (string)cbLoai.SelectedValue;
            xe.MaXe = txtMaXM.Text;
            xe.TenXe = txtTenXeMay.Text;
            xe.Mau = txtMauSacXeMay.Text;
            xe.DonGia = decimal.Parse(txtDonGiaXeMay.Text);
            xe.MaLoai = selectedTheloaixe;
        }
        private void BindGridXeMay(List<Xe> xe) //BINDGRID
        {
            dtGVXemay.Rows.Clear();
            foreach (Xe x in xe)
            {
                int index = dtGVXemay.Rows.Add(x);
                dtGVXemay.Rows[index].Cells[0].Value = x.MaXe;
                dtGVXemay.Rows[index].Cells[1].Value = x.TenXe;
                if (x.LoaiXe != null)
                {
                    dtGVXemay.Rows[index].Cells[2].Value = x.LoaiXe.TenLoai;
                }
                dtGVXemay.Rows[index].Cells[3].Value = x.Mau;
                dtGVXemay.Rows[index].Cells[6].Value = x.DonGia;
            }
        }
        private void FillTypeofXeCombobox(List<LoaiXe> loaiXes) //FILL
        {
            loaiXes.Insert(0, new LoaiXe());
            this.cbLoai.DataSource = loaiXes;
            this.cbLoai.DisplayMember = "TenLoai";
            this.cbLoai.ValueMember = "TenLoai";
        }
    }
}
