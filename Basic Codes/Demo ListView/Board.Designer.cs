namespace Demo_ListView {
    partial class Trang_Tinh_Form {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.Bang_DSSV = new System.Windows.Forms.ListView();
            this.Them = new System.Windows.Forms.Button();
            this.Sua = new System.Windows.Forms.Button();
            this.Xoa = new System.Windows.Forms.Button();
            this.Thoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Bang_DSSV
            // 
            this.Bang_DSSV.FullRowSelect = true;
            this.Bang_DSSV.HideSelection = false;
            this.Bang_DSSV.Location = new System.Drawing.Point(12, 27);
            this.Bang_DSSV.Name = "Bang_DSSV";
            this.Bang_DSSV.Size = new System.Drawing.Size(633, 346);
            this.Bang_DSSV.TabIndex = 0;
            this.Bang_DSSV.UseCompatibleStateImageBehavior = false;
            // 
            // Them
            // 
            this.Them.Location = new System.Drawing.Point(670, 27);
            this.Them.Name = "Them";
            this.Them.Size = new System.Drawing.Size(100, 50);
            this.Them.TabIndex = 1;
            this.Them.Text = "Thêm";
            this.Them.UseVisualStyleBackColor = true;
            this.Them.Click += new System.EventHandler(this.Them_Click);
            // 
            // Sua
            // 
            this.Sua.Location = new System.Drawing.Point(670, 101);
            this.Sua.Name = "Sua";
            this.Sua.Size = new System.Drawing.Size(100, 50);
            this.Sua.TabIndex = 2;
            this.Sua.Text = "Sửa";
            this.Sua.UseVisualStyleBackColor = true;
            this.Sua.Click += new System.EventHandler(this.Sua_Click);
            // 
            // Xoa
            // 
            this.Xoa.Location = new System.Drawing.Point(670, 175);
            this.Xoa.Name = "Xoa";
            this.Xoa.Size = new System.Drawing.Size(100, 50);
            this.Xoa.TabIndex = 3;
            this.Xoa.Text = "Xóa";
            this.Xoa.UseVisualStyleBackColor = true;
            this.Xoa.Click += new System.EventHandler(this.Xoa_Click);
            // 
            // Thoat
            // 
            this.Thoat.Location = new System.Drawing.Point(670, 255);
            this.Thoat.Name = "Thoat";
            this.Thoat.Size = new System.Drawing.Size(100, 50);
            this.Thoat.TabIndex = 4;
            this.Thoat.Text = "Thoát";
            this.Thoat.UseVisualStyleBackColor = true;
            this.Thoat.Click += new System.EventHandler(this.Thoat_Click);
            // 
            // Trang_Tinh_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(782, 401);
            this.Controls.Add(this.Thoat);
            this.Controls.Add(this.Xoa);
            this.Controls.Add(this.Sua);
            this.Controls.Add(this.Them);
            this.Controls.Add(this.Bang_DSSV);
            this.Name = "Trang_Tinh_Form";
            this.Text = "Trang tính";
            this.Load += new System.EventHandler(this.ListView_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView Bang_DSSV;
        private System.Windows.Forms.Button Them;
        private System.Windows.Forms.Button Sua;
        private System.Windows.Forms.Button Xoa;
        private System.Windows.Forms.Button Thoat;
    }
}