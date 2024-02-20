using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo_DataGridView {
    public partial class Demo_DataGridView : Form {
        public Demo_DataGridView() {
            InitializeComponent();
        }

        private void Demo_DataGridView_Load(object sender, EventArgs e) {
            Sheet.Columns.Add("HoTen", "Họ Tên");
            Sheet.Columns.Add("DiaChi", "Địa Chỉ");
            Sheet.Columns.Add("Email", "Email");
            Sheet.Columns.Add("SoDienThoai", "Số Điện Thoại");
        }

        private void TaoMoi_Click(object sender, EventArgs e) {
            DataGridViewRow Row = new DataGridViewRow {
                Cells = {
                    new DataGridViewTextBoxCell { Value = HoTen_TextBox.Text },
                    new DataGridViewTextBoxCell { Value = DiaChi_TextBox.Text },
                    new DataGridViewTextBoxCell { Value = Email_TextBox.Text },
                    new DataGridViewTextBoxCell { Value = SDT_TextBox.Text },
                }
            };
            Sheet.Rows.Add(Row);
        }

        private void Luu_Click(object sender, EventArgs e) {
            if(Sheet.SelectedRows.Count != 0) {
                DataGridViewRow Get_Row = Sheet.SelectedRows[0];
                Get_Row.Cells["HoTen"].Value = HoTen_TextBox.Text;
                Get_Row.Cells["DiaChi"].Value = DiaChi_TextBox.Text;
                Get_Row.Cells["Email"].Value = Email_TextBox.Text;
                Get_Row.Cells["SoDienThoai"].Value = SDT_TextBox.Text;
            }
        }

        private void Xoa_Click(object sender, EventArgs e) {
            if(Sheet.SelectedRows.Count != 0) {
                DataGridViewRow Get_Row = Sheet.SelectedRows[0];
                Sheet.Rows.Remove(Get_Row);
            }
        }

        private void Thoat_Click(object sender, EventArgs e) {
            Close();
        }

        private void Sheet_Click(object sender, EventArgs e) {
            if (Sheet.SelectedRows.Count != 0) {
                DataGridViewRow Get_Row = Sheet.SelectedRows[0];
                HoTen_TextBox.Text = Get_Row.Cells["HoTen"].Value.ToString();
                DiaChi_TextBox.Text = Get_Row.Cells["DiaChi"].Value.ToString();
                Email_TextBox.Text = Get_Row.Cells["Email"].Value.ToString();
                SDT_TextBox.Text = Get_Row.Cells["SoDienThoai"].Value.ToString();
            }
        }
    }
}