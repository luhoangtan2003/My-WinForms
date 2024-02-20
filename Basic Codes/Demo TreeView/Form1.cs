using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo_TreeView {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private int MaPB = 0;
        private int MaNV = 0;

        private void Them_PB_Click(object sender, EventArgs e) {
            MaPB++;
            TreeNode Phong_Ban = new TreeNode();
            Phong_Ban.Name = $"MaPB {MaPB}";
            Phong_Ban.Text = $"Phòng ban {MaPB}";
            Phong_Ban.ImageIndex = 0;
            Phong_Ban.SelectedImageIndex = 1;
            TreeView.Nodes.Add(Phong_Ban);
        }

        private void Them_NV_Click(object sender, EventArgs e) {
            if(TreeView.SelectedNode != null) {
                MaNV++;
                TreeNode Nhan_Vien = new TreeNode();
                Nhan_Vien.Name = $"MaNV {MaNV}";
                Nhan_Vien.Text = $"Nhân viên {MaNV}";
                Nhan_Vien.ImageIndex = 2;
                Nhan_Vien.SelectedImageIndex = 2;
                TreeView.SelectedNode.Nodes.Add(Nhan_Vien);
            }
        }

        private void Chinh_Sua_Click(object sender, EventArgs e) {
            if(TreeView.SelectedNode != null) {
                Doi_Ten_TextBox.Text = TreeView.SelectedNode.Text; 
            }
        }

        private void Luu_Ten_Button_Click(object sender, EventArgs e) {
            if (TreeView.SelectedNode != null) {
                TreeView.SelectedNode.Text = Doi_Ten_TextBox.Text;
            }
        }

        private void Xoa_Click(object sender, EventArgs e) {
            if (TreeView.SelectedNode != null) {
                TreeView.SelectedNode.Remove();
            }
        }

        private void Thoat_Click(object sender, EventArgs e) {
            Close();
        }
    }
}