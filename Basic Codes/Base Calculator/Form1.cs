using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Base_Calculator {
    public partial class May_Tinh : Form {
        public May_Tinh() {
            InitializeComponent();
            Phim_1.Click += new EventHandler(Nhap_So);
            Phim_2.Click += new EventHandler(Nhap_So);
            Phim_3.Click += new EventHandler(Nhap_So);
            Phim_4.Click += new EventHandler(Nhap_So);
            Phim_5.Click += new EventHandler(Nhap_So);
            Phim_6.Click += new EventHandler(Nhap_So);
            Phim_7.Click += new EventHandler(Nhap_So);
            Phim_8.Click += new EventHandler(Nhap_So);
            Phim_9.Click += new EventHandler(Nhap_So);
            Phim_0.Click += new EventHandler(Nhap_So);

            Dau_Cong.Click += new EventHandler(Nhap_Dau);
            Dau_Tru.Click += new EventHandler(Nhap_Dau);
            Dau_Nhan.Click += new EventHandler(Nhap_Dau);
            Dau_Chia.Click += new EventHandler(Nhap_Dau);

            Dau_Bang.Click += new EventHandler(Tinh_Toan);

        }

        private string Phan_Tu_A = "";
        private string Phan_Tu_B = "";
        private string Phep_Tinh = "";
        private string Vi_Tri = "Left";
        private bool Lam_Moi = true;

        private void Nhap_So(object sender, EventArgs e) {
            string Toan_Hang = ((Button)sender).Text;

            if (Lam_Moi == true) Hien_Thi.Text = "";

            Hien_Thi.Text += Toan_Hang;

            if (Vi_Tri == "Left") {
                Phan_Tu_A = Hien_Thi.Text;
            } else {
                Phan_Tu_B = Hien_Thi.Text;
            }
            Lam_Moi = false;
        }

        private void Nhap_Dau(object sender, EventArgs e) {
            if (Phan_Tu_A == "" || Phan_Tu_B != "") {
            } else {
                Phep_Tinh = ((Button)sender).Text;
                Vi_Tri = "Right";
                Lam_Moi = true;
                Hien_Thi.Text = Phep_Tinh;
            }
        }

        private void Tinh_Toan(object sender, EventArgs e) {
            if (Phan_Tu_B == "") {
            } else {
                switch (Phep_Tinh) {
                    case "+": {
                            Hien_Thi.Text = (double.Parse(Phan_Tu_A) + double.Parse(Phan_Tu_B)).ToString();
                        }
                        break;

                    case "-": {
                            Hien_Thi.Text = (double.Parse(Phan_Tu_A) - double.Parse(Phan_Tu_B)).ToString();
                        }
                        break;

                    case "*": {
                            Hien_Thi.Text = (double.Parse(Phan_Tu_A) * double.Parse(Phan_Tu_B)).ToString();
                        }
                        break;

                    case "/": {
                            Hien_Thi.Text = (double.Parse(Phan_Tu_A) / double.Parse(Phan_Tu_B)).ToString();
                        }
                        break;
                }
                Phan_Tu_A = "";
                Phan_Tu_B = "";
                Phep_Tinh = "";
                Vi_Tri = "Left";
                Lam_Moi = true;
            }
        }
    }
}