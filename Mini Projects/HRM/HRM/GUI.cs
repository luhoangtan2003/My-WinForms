using BLL;
using DTL;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace HRM {
    public partial class HRM_Form : Form {
        public HRM_Form() {
            InitializeComponent();
        }

        private void HRM_Form_Load(object sender, EventArgs e) {
            ChucVu.DataSource = CHUCVU_BLL.CHUCVU_Load();
            ChucVu.ValueMember = "MSCV";
            ChucVu.DisplayMember = "TENCV";
            HRM_Sheet.DataSource = NHANSU_BLL.HRM_Sheet_Load();
            HRM_Sheet.ClearSelection();
        }
        private void HRM_Form_Click(object sender, EventArgs e) {
            HRM_Sheet.ClearSelection();
            MSNV.Enabled = true;
        }

        private void HRM_Sheet_Click(object sender, EventArgs e) {
            if (HRM_Sheet.SelectedRows.Count == 0) { return; }
            MSNV.Enabled = false;
            DataGridViewRow Row = HRM_Sheet.SelectedRows[0];
            HoTen.Text = Row.Cells["HOVATEN"].Value.ToString();
            MSNV.Text = Row.Cells["MSNV"].Value.ToString();
            if (Row.Cells["GIOITINH"].Value.ToString() == "Nam") {
                Nam.Checked = true;
            } else {
                Nu.Checked = true;
            }
            NamSinh.Value = (DateTime)Row.Cells["NAMSINH"].Value;
            ChucVu.SelectedValue = Row.Cells["MSCV"].Value;
            QueQuan.Text = Row.Cells["QUEQUAN"].Value.ToString();
            Email.Text = Row.Cells["EMAIL"].Value.ToString();
            DienThoai.Text = Row.Cells["DIENTHOAI"].Value.ToString();
        }

        private void Them_Click(object sender, EventArgs e) {
            if(KiemTraTinhHopLeDuLieu(1) == false) { return; }
            NHANSU_DTL NHANSU = new NHANSU_DTL();
            NHANSU.HOVATEN = HoTen.Text.Trim();
            NHANSU.MSNV = MSNV.Text.Trim();
            NHANSU.GIOITINH = (Nam.Checked) ? "Nam" : "Nữ";
            NHANSU.NAMSINH = NamSinh.Value;
            NHANSU.MSCV = ChucVu.SelectedValue.ToString();
            NHANSU.QUEQUAN = QueQuan.Text.Trim();
            NHANSU.EMAIL = Email.Text.Trim();
            NHANSU.DIENTHOAI = DienThoai.Text.Trim();
            if (NHANSU_BLL.ThemNhanVien(NHANSU) == false) {
                return;
            }
            HRM_Sheet.DataSource = NHANSU_BLL.HRM_Sheet_Load();
        }

        private void Sua_Click(object sender, EventArgs e) {
            if (HRM_Sheet.SelectedRows.Count == 0) { return; }
            if (KiemTraTinhHopLeDuLieu(2) == false) { return; }
            NHANSU_DTL NHANSU = new NHANSU_DTL();
            NHANSU.HOVATEN = HoTen.Text.Trim();
            NHANSU.MSNV = MSNV.Text.Trim();
            NHANSU.GIOITINH = (Nam.Checked) ? "Nam" : "Nữ";
            NHANSU.NAMSINH = NamSinh.Value;
            NHANSU.MSCV = ChucVu.SelectedValue.ToString();
            NHANSU.QUEQUAN = QueQuan.Text.Trim();
            NHANSU.EMAIL = Email.Text.Trim();
            NHANSU.DIENTHOAI = DienThoai.Text.Trim();
            if (NHANSU_BLL.SuaNhanVien(NHANSU) == false) {
                return;
            }
            HRM_Sheet.DataSource = NHANSU_BLL.HRM_Sheet_Load();
        }

        private void Xoa_Click(object sender, EventArgs e) {
            if (HRM_Sheet.SelectedRows.Count != 0) {
                if (MessageBox.Show("Bạn có chắc xóa?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK) {
                    if (NHANSU_BLL.XoaNhanVien(MSNV.Text)) {
                        HRM_Sheet.DataSource = NHANSU_BLL.HRM_Sheet_Load();
                    }
                }
            }
        }

        private void Thoat_Click(object sender, EventArgs e) {
            if(MessageBox.Show("Bạn có muốn thoát không?","Thông báo",MessageBoxButtons.OKCancel,MessageBoxIcon.Question) == DialogResult.OK) {
                Close();
            }
        }

        private void KetQua_Click(object sender, EventArgs e) {
            string Key = TimKiem.Text.Trim();
            if (Key == "") {
                HRM_Sheet.DataSource = NHANSU_BLL.HRM_Sheet_Load();
                return;
            }
            List<NHANSU_DTL> KetQua = NHANSU_BLL.TimNhanVien(Key);
            if (KetQua != null) {
                HRM_Sheet.DataSource = KetQua;
            }
        }

        private bool IsNameValid(string Name) => Name.All(c => c == ' ' || char.IsLetter(c));

        private void HoTen_TextChanged(object sender, EventArgs e) {
            if (IsNameValid(HoTen.Text.Trim())) {
                Valid_Name.ForeColor = Color.Black;
                Valid_Name.Text = "";
            } else {
                Valid_Name.ForeColor = Color.Red;
                Valid_Name.Text = "Không hợp lệ";
            }
            if(HoTen.Text.Trim() == "") {
                Valid_Name.ForeColor = Color.Red;
            }
        }

        private bool IsMaSoValid(string MSNV) => new Regex("^[0-9a-zA-Z]*$").IsMatch(MSNV);

        private void MSNV_TextChanged(object sender, EventArgs e) {
            if(IsMaSoValid(MSNV.Text.Trim())) {
                Valid_MSNV.ForeColor = Color.Black;
                Valid_MSNV.Text = "";
            } else {
                Valid_MSNV.ForeColor = Color.Red;
                Valid_MSNV.Text = "Không hợp lệ";
            }
            if(MSNV.Text.Trim() == "") {
                Valid_MSNV.ForeColor = Color.Red;
            }
        }

        private bool KiemTraTinhHopLeDuLieu(int x) {            
            if(x is 1 || x is 2) {
                if (Valid_Name.ForeColor == Color.Red || Valid_MSNV.ForeColor == Color.Red) {
                    MessageBox.Show("Tên hoặc mã số nhân viên là rỗng hoặc không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            if(x is 1) {
                foreach (DataGridViewRow Row in HRM_Sheet.Rows) {
                    if (MSNV.Text.Trim() == Row.Cells["MSNV"].Value.ToString()) {
                        MessageBox.Show($"Mã số trùng với {Row.Cells["HOVATEN"].Value}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
            }
            return true;
        }
    }
}