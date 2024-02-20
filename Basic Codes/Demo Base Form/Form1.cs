using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo_Base_Form {
    public partial class DF1 : Form {
        public DF1() {
            InitializeComponent();
        }

        private void Export_Click(object sender, EventArgs e) {
            string Name = FullName.Text;

            DateTime Birth = DateofBirth.Value;

            string Sex;

            if (Male.Checked == false && Female.Checked == false) {
                Sex = "Không tiết lộ";
            } else if (Male.Checked) {
                Sex = Male.Text;
            } else {
                Sex = Female.Text;
            }
            string Interest = "";

            if (A.Checked) {
                Interest += "\n\t" + A.Text;
            }
            if (B.Checked) {
                Interest += "\n\t" + B.Text;
            }
            if (C.Checked) {
                Interest += "\n\t" + C.Text;
            }

            string Information = $"Họ và tên: {Name}.\nNgày sinh: {Birth}.\nGiới tính: {Sex}.\nSở thích: {Interest}";

            MessageBox.Show(Information);
        }

        private void Close_Form_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}