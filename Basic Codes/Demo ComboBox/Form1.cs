using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo_ComboBox {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            Hoc_Sinh_DDL.DataSource = Khoi_Tao_Du_Lieu();
            Hoc_Sinh_DDL.DisplayMember = "TenHS";
            Hoc_Sinh_DDL.ValueMember = "MaHS";
        }

        private List<Hoc_Sinh> Khoi_Tao_Du_Lieu() {
            List<Hoc_Sinh> List_HS = new List<Hoc_Sinh>();
            for(int i = 0; i < 5; i++) {
                Hoc_Sinh HS = new Hoc_Sinh();
                HS.MaHS = $"HS{i+1}";
                HS.TenHS = $"Nguyễn Văn {i + 1}";
                List_HS.Add(HS);
            }
            return List_HS;
        }

        private void Button_DDL_Click(object sender, EventArgs e) {
            string Value = $"Mã HS: {Hoc_Sinh_DDL.SelectedValue}\nTên HS: {Hoc_Sinh_DDL.Text}";
            MessageBox.Show(Value, "Kết quả chọn");
        }
    }
}