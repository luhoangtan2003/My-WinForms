using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo_ListView {
    public partial class Trang_Tinh_Form : Form {
        public Trang_Tinh_Form() {
            InitializeComponent();
        }

        private void ListView_Load(object sender, EventArgs e) {
            Bang_DSSV.Columns.Add("Mã nhân viên", 100);
            Bang_DSSV.Columns.Add("Họ và tên", 250);
            Bang_DSSV.Columns.Add("Mức lương", 150);
            Bang_DSSV.View = View.Details;
        }

        private bool Du_Lieu_Hop_Le(Thong_Tin_Form Nhan_Vien) {
            if (string.IsNullOrEmpty(Nhan_Vien.MSNV)) {
                MessageBox.Show("Mã nhân viên rỗng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (string.IsNullOrEmpty(Nhan_Vien.TenNV)) {
                MessageBox.Show("Tên nhân viễn rỗng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (string.IsNullOrEmpty(Nhan_Vien.Luong)) {
                MessageBox.Show("Lương nhân viễn rỗng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void Them_Click(object sender, EventArgs e) {
            Thong_Tin_Form Nhan_Vien = new Thong_Tin_Form();
            if (Nhan_Vien.ShowDialog() == DialogResult.OK) {
                if (Du_Lieu_Hop_Le(Nhan_Vien)) {
                    ListViewItem Line = new ListViewItem();
                    Line.Text = Nhan_Vien.MSNV;
                    Line.SubItems.Add(Nhan_Vien.TenNV);
                    Line.SubItems.Add(Nhan_Vien.Luong);
                    Bang_DSSV.Items.Add(Line);
                } else {
                    Them_Click(sender, e);
                }
            }
        }

        private void Sua_Click(object sender, EventArgs e) {
            Thong_Tin_Form Nhan_Vien = new Thong_Tin_Form();
            if (Bang_DSSV.SelectedItems.Count > 0) {
                Nhan_Vien.MSNV = Bang_DSSV.SelectedItems[0].SubItems[0].Text;
                Nhan_Vien.TenNV = Bang_DSSV.SelectedItems[0].SubItems[1].Text;
                Nhan_Vien.Luong = Bang_DSSV.SelectedItems[0].SubItems[2].Text;
                if (Nhan_Vien.ShowDialog() == DialogResult.OK) {
                    Bang_DSSV.SelectedItems[0].SubItems[0].Text = Nhan_Vien.MSNV;
                    Bang_DSSV.SelectedItems[0].SubItems[1].Text = Nhan_Vien.TenNV;
                    Bang_DSSV.SelectedItems[0].SubItems[2].Text = Nhan_Vien.Luong;
                }
            }
        }

        private void Xoa_Click(object sender, EventArgs e) {
            if (Bang_DSSV.SelectedItems.Count > 0) {
                if (MessageBox.Show("Bạn có chắc muốn xóa", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error) == DialogResult.OK) {
                    Bang_DSSV.Items.Remove(Bang_DSSV.SelectedItems[0]);
                }
            }
        }

        private void Thoat_Click(object sender, EventArgs e) {
            Close();
        }
    }
}