namespace Demo_DataGridView {
    partial class Demo_DataGridView {
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
            this.Sheet = new System.Windows.Forms.DataGridView();
            this.GroupBox = new System.Windows.Forms.GroupBox();
            this.SDT_TextBox = new System.Windows.Forms.TextBox();
            this.Email_TextBox = new System.Windows.Forms.TextBox();
            this.DiaChi_TextBox = new System.Windows.Forms.TextBox();
            this.HoTen_TextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.TaoMoi = new System.Windows.Forms.Button();
            this.Luu = new System.Windows.Forms.Button();
            this.Xoa = new System.Windows.Forms.Button();
            this.Thoat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Sheet)).BeginInit();
            this.GroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // Sheet
            // 
            this.Sheet.AllowUserToAddRows = false;
            this.Sheet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Sheet.Location = new System.Drawing.Point(12, 12);
            this.Sheet.Name = "Sheet";
            this.Sheet.RowHeadersWidth = 51;
            this.Sheet.RowTemplate.Height = 24;
            this.Sheet.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Sheet.Size = new System.Drawing.Size(700, 250);
            this.Sheet.TabIndex = 0;
            this.Sheet.Click += new System.EventHandler(this.Sheet_Click);
            // 
            // GroupBox
            // 
            this.GroupBox.Controls.Add(this.SDT_TextBox);
            this.GroupBox.Controls.Add(this.Email_TextBox);
            this.GroupBox.Controls.Add(this.DiaChi_TextBox);
            this.GroupBox.Controls.Add(this.HoTen_TextBox);
            this.GroupBox.Controls.Add(this.label4);
            this.GroupBox.Controls.Add(this.Label3);
            this.GroupBox.Controls.Add(this.Label2);
            this.GroupBox.Controls.Add(this.Label1);
            this.GroupBox.Location = new System.Drawing.Point(12, 268);
            this.GroupBox.Name = "GroupBox";
            this.GroupBox.Size = new System.Drawing.Size(700, 250);
            this.GroupBox.TabIndex = 1;
            this.GroupBox.TabStop = false;
            // 
            // SDT_TextBox
            // 
            this.SDT_TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.SDT_TextBox.Location = new System.Drawing.Point(474, 97);
            this.SDT_TextBox.Name = "SDT_TextBox";
            this.SDT_TextBox.Size = new System.Drawing.Size(220, 32);
            this.SDT_TextBox.TabIndex = 7;
            // 
            // Email_TextBox
            // 
            this.Email_TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.Email_TextBox.Location = new System.Drawing.Point(474, 33);
            this.Email_TextBox.Name = "Email_TextBox";
            this.Email_TextBox.Size = new System.Drawing.Size(220, 32);
            this.Email_TextBox.TabIndex = 6;
            // 
            // DiaChi_TextBox
            // 
            this.DiaChi_TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.DiaChi_TextBox.Location = new System.Drawing.Point(111, 97);
            this.DiaChi_TextBox.Multiline = true;
            this.DiaChi_TextBox.Name = "DiaChi_TextBox";
            this.DiaChi_TextBox.Size = new System.Drawing.Size(220, 100);
            this.DiaChi_TextBox.TabIndex = 5;
            // 
            // HoTen_TextBox
            // 
            this.HoTen_TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.HoTen_TextBox.Location = new System.Drawing.Point(112, 30);
            this.HoTen_TextBox.Name = "HoTen_TextBox";
            this.HoTen_TextBox.Size = new System.Drawing.Size(220, 32);
            this.HoTen_TextBox.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label4.Location = new System.Drawing.Point(362, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 26);
            this.label4.TabIndex = 3;
            this.label4.Text = "SĐT:";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.Label3.Location = new System.Drawing.Point(362, 33);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(84, 26);
            this.Label3.TabIndex = 2;
            this.Label3.Text = "EMAIL:";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.Label2.Location = new System.Drawing.Point(6, 100);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(99, 26);
            this.Label2.TabIndex = 1;
            this.Label2.Text = "ĐỊA CHỈ:";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.Label1.Location = new System.Drawing.Point(6, 33);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(100, 26);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "HỌ TÊN:";
            // 
            // TaoMoi
            // 
            this.TaoMoi.Location = new System.Drawing.Point(12, 542);
            this.TaoMoi.Name = "TaoMoi";
            this.TaoMoi.Size = new System.Drawing.Size(100, 50);
            this.TaoMoi.TabIndex = 2;
            this.TaoMoi.Text = "Tạo mới";
            this.TaoMoi.UseVisualStyleBackColor = true;
            this.TaoMoi.Click += new System.EventHandler(this.TaoMoi_Click);
            // 
            // Luu
            // 
            this.Luu.Location = new System.Drawing.Point(147, 542);
            this.Luu.Name = "Luu";
            this.Luu.Size = new System.Drawing.Size(100, 50);
            this.Luu.TabIndex = 3;
            this.Luu.Text = "Lưu";
            this.Luu.UseVisualStyleBackColor = true;
            this.Luu.Click += new System.EventHandler(this.Luu_Click);
            // 
            // Xoa
            // 
            this.Xoa.Location = new System.Drawing.Point(284, 542);
            this.Xoa.Name = "Xoa";
            this.Xoa.Size = new System.Drawing.Size(100, 50);
            this.Xoa.TabIndex = 4;
            this.Xoa.Text = "Xóa";
            this.Xoa.UseVisualStyleBackColor = true;
            this.Xoa.Click += new System.EventHandler(this.Xoa_Click);
            // 
            // Thoat
            // 
            this.Thoat.Location = new System.Drawing.Point(419, 542);
            this.Thoat.Name = "Thoat";
            this.Thoat.Size = new System.Drawing.Size(100, 50);
            this.Thoat.TabIndex = 5;
            this.Thoat.Text = "Thoát";
            this.Thoat.UseVisualStyleBackColor = true;
            this.Thoat.Click += new System.EventHandler(this.Thoat_Click);
            // 
            // Demo_DataGridView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(722, 653);
            this.Controls.Add(this.Thoat);
            this.Controls.Add(this.Xoa);
            this.Controls.Add(this.Luu);
            this.Controls.Add(this.TaoMoi);
            this.Controls.Add(this.GroupBox);
            this.Controls.Add(this.Sheet);
            this.Name = "Demo_DataGridView";
            this.Text = "Demo_DataGridView";
            this.Load += new System.EventHandler(this.Demo_DataGridView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Sheet)).EndInit();
            this.GroupBox.ResumeLayout(false);
            this.GroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Sheet;
        private System.Windows.Forms.GroupBox GroupBox;
        private System.Windows.Forms.TextBox DiaChi_TextBox;
        private System.Windows.Forms.TextBox HoTen_TextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Label3;
        private System.Windows.Forms.Label Label2;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.TextBox SDT_TextBox;
        private System.Windows.Forms.TextBox Email_TextBox;
        private System.Windows.Forms.Button TaoMoi;
        private System.Windows.Forms.Button Luu;
        private System.Windows.Forms.Button Xoa;
        private System.Windows.Forms.Button Thoat;
    }
}