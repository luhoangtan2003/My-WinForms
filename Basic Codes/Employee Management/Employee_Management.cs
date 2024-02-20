using Student_Management;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employee_Management {
    public partial class Quan_Ly_Nhan_Vien : Form {
        public Quan_Ly_Nhan_Vien() {
            InitializeComponent();
        }


        private void Quan_Ly_Nhan_Vien_Load(object sender, EventArgs e) {
            Khoi_Tao_Nghanh_Nghe();
            Khoi_Tao_ListView_NV();
        }

        private void Khoi_Tao_Nghanh_Nghe() {
            Nghanh_CB.DataSource = Nganh_Nghe.Khoi_Tao_Cong_Viec();
            Nghanh_CB.DisplayMember = "Ten_Nganh";
            Nghanh_CB.ValueMember = "Ma_Nganh";
        }

        private void Khoi_Tao_ListView_NV() {
            DanhSachNhanVien.Columns.Add("Mã Nhân Viên", 100);
            DanhSachNhanVien.Columns.Add("Họ Và Tên", 200);
            DanhSachNhanVien.Columns.Add("Giới Tính", 75);
            DanhSachNhanVien.Columns.Add("Ngày Sinh", 100);
            DanhSachNhanVien.Columns.Add("Ngành Nghề", 200);
            DanhSachNhanVien.Columns.Add("Mức Lương", 150);
            DanhSachNhanVien.View = View.Details;
        }

        private void Nghanh_CB_SelectedIndexChanged(object sender, EventArgs e) {
            ComboBox Temp = (ComboBox)sender;
            Nganh_Nghe NN = (Nganh_Nghe)Temp.SelectedItem;
            MucLuong_TB.Text = NN.Muc_Luong.ToString("#,#");
        }

        private bool Is_Valid_HoTen(string Name) {
            if (Name.All(c => char.IsLetter(c) || char.IsWhiteSpace(c))) {
                return true;
            }
            return false;
        }

        private void HoTen_TB_TextChanged(object sender, EventArgs e) {
            if (Is_Valid_HoTen(HoTen_TB.Text) == false) {
                Notice_Valid_Name.Text = "Tên không chứa các ký tự đặc biệt và số";
                Notice_Valid_Name.ForeColor = Color.Red;
            } else {
                Notice_Valid_Name.Text = "";
                Notice_Valid_Name.ForeColor = Color.Black;
            }
        }

        private bool Is_Valid_MSNV(string MSNV) {
            if (MSNV.Contains(" ")) {
                return false;
            }
            Regex Is_Regex = new Regex("^[a-zA-Z0-9_]*$");
            return Is_Regex.IsMatch(MSNV);
        }

        private void MSNV_TB_TextChanged(object sender, EventArgs e) {
            if (Is_Valid_MSNV(MSNV_TB.Text) == false) {
                Notice_Valid_MSNV.Text = "Mã số không chứa khoảng trắng và dấu";
                Notice_Valid_MSNV.ForeColor = Color.Red;
            } else {
                Notice_Valid_MSNV.Text = "";
                Notice_Valid_MSNV.ForeColor = Color.Black;
            }
        }

        private bool Valid_HoTen_And_MSNV_Them() {
            if (string.IsNullOrEmpty(MSNV_TB.Text) || string.IsNullOrEmpty(HoTen_TB.Text)) {
                MessageBox.Show("Mã số nhân viên hoặc họ và tên của họ đang rỗng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (Notice_Valid_MSNV.ForeColor == Color.Red || Notice_Valid_Name.ForeColor == Color.Red) {
                MessageBox.Show("Mã số nhân viên hoặc họ và tên của họ không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            foreach (ListViewItem Line in DanhSachNhanVien.Items) {
                if (MSNV_TB.Text == Line.SubItems[0].Text) {
                    MessageBox.Show($"Mã số nhân viên trùng với {Line.SubItems[1].Text}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }
            return true;
        }

        private void Them_Click(object sender, EventArgs e) {
            string Get_MSNV = MSNV_TB.Text;
            string Get_Ten = HoTen_TB.Text;
            string Get_GioiTinh;
            if (LGBT.Checked == true) {
                Get_GioiTinh = "Không";
            } else if (DanOng.Checked == true) {
                Get_GioiTinh = "Nam";
            } else {
                Get_GioiTinh = "Nữ";
            }
            string Get_NgaySinh = NgaySinh.Value.ToShortDateString();
            string Get_Nganh = Nghanh_CB.Text;
            string Get_Luong = $"{MucLuong_TB.Text} {ML_Label.Text}";
            if (Valid_HoTen_And_MSNV_Them()) {
                ListViewItem Line = new ListViewItem();
                Line.Text = Get_MSNV;
                Line.SubItems.Add(Get_Ten);
                Line.SubItems.Add(Get_GioiTinh);
                Line.SubItems.Add(Get_NgaySinh);
                Line.SubItems.Add(Get_Nganh);
                Line.SubItems.Add(Get_Luong);
                DanhSachNhanVien.Items.Add(Line);
            }
        }

        private void Xoa_Click(object sender, EventArgs e) {
            if (DanhSachNhanVien.SelectedItems.Count != 0) {
                if (MessageBox.Show("Bạn có chắc muốn xóa?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK) {
                    DanhSachNhanVien.Items[0].Remove();
                }
            }
        }

        private void Thoat_Click(object sender, EventArgs e) {
            if (MessageBox.Show("Thoát chương trình?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK) {
                Close();
            }
        }

        private void DanhSachNhanVien_SelectedIndexChanged(object sender, EventArgs e) {
            if (DanhSachNhanVien.SelectedItems.Count != 0) {

                Them.Enabled = false;
                Luu.Enabled = true;
                Xoa.Enabled = true;

                MSNV_TB.Text = DanhSachNhanVien.SelectedItems[0].SubItems[0].Text;
                HoTen_TB.Text = DanhSachNhanVien.SelectedItems[0].SubItems[1].Text;
                if (DanhSachNhanVien.SelectedItems[0].SubItems[2].Text == "Không") {
                    LGBT.Checked = true;
                } else if (DanhSachNhanVien.SelectedItems[0].SubItems[2].Text == "Nam") {
                    DanOng.Checked = true;
                } else {
                    PhuNu.Checked = true;
                }
                NgaySinh.Text = DanhSachNhanVien.SelectedItems[0].SubItems[3].Text;
                Nghanh_CB.Text = DanhSachNhanVien.SelectedItems[0].SubItems[4].Text;
            } else {
                Them.Enabled = true;
                Luu.Enabled = false;
                Xoa.Enabled = false;
            }
        }

        private bool Valid_HoTen_And_MSNV_Luu() {
            if (string.IsNullOrEmpty(MSNV_TB.Text) || string.IsNullOrEmpty(HoTen_TB.Text)) {
                MessageBox.Show("Mã số nhân viên hoặc họ và tên của họ đang rỗng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (Notice_Valid_MSNV.ForeColor == Color.Red || Notice_Valid_Name.ForeColor == Color.Red) {
                MessageBox.Show("Mã số nhân viên hoặc họ và tên của họ không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            foreach (ListViewItem Line in DanhSachNhanVien.Items) {
                if (!Line.Selected) {
                    if (MSNV_TB.Text == Line.SubItems[0].Text) {
                        MessageBox.Show($"Mã số nhân viên trùng với {Line.SubItems[1].Text}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;
                    }
                }
            }
            return true;
        }

        private void Luu_Click(object sender, EventArgs e) {
            if (DanhSachNhanVien.SelectedItems.Count != 0) {
                if (Valid_HoTen_And_MSNV_Luu()) {
                    DanhSachNhanVien.SelectedItems[0].SubItems[0].Text = MSNV_TB.Text;
                    DanhSachNhanVien.SelectedItems[0].SubItems[1].Text = HoTen_TB.Text;
                    if (LGBT.Checked == true) {
                        DanhSachNhanVien.SelectedItems[0].SubItems[2].Text = "Không";
                    } else if (DanOng.Checked == true) {
                        DanhSachNhanVien.SelectedItems[0].SubItems[2].Text = "Nam";
                    } else {
                        DanhSachNhanVien.SelectedItems[0].SubItems[2].Text = "Nữ";
                    }
                    DanhSachNhanVien.SelectedItems[0].SubItems[3].Text = NgaySinh.Text;
                    DanhSachNhanVien.SelectedItems[0].SubItems[4].Text = Nghanh_CB.Text;
                    DanhSachNhanVien.SelectedItems[0].SubItems[5].Text = $"{MucLuong_TB.Text} {ML_Label.Text}";
                }
            }
        }
    }
}