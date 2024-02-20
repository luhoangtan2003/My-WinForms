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
    public partial class Thong_Tin_Form : Form {
        public string MSNV {
            set { TextBox_MSNV.Text = value; }
            get { return TextBox_MSNV.Text; }
        }
        public string TenNV {
            set { TextBox_TNV.Text = value; }
            get { return TextBox_TNV.Text; }
        }
        public string Luong {
            set { TextBox_ML.Text = value; }
            get { return TextBox_ML.Text; }
        }
        public Thong_Tin_Form() {
            InitializeComponent();
        }
    }
}