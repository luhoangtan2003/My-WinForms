namespace Demo_TreeView {
    partial class Form1 {
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.TreeView = new System.Windows.Forms.TreeView();
            this.ImageList = new System.Windows.Forms.ImageList(this.components);
            this.Them_PB = new System.Windows.Forms.Button();
            this.Them_NV = new System.Windows.Forms.Button();
            this.Chinh_Sua = new System.Windows.Forms.Button();
            this.Xoa = new System.Windows.Forms.Button();
            this.Thoat = new System.Windows.Forms.Button();
            this.Doi_Ten_Label = new System.Windows.Forms.Label();
            this.Doi_Ten_TextBox = new System.Windows.Forms.TextBox();
            this.Luu_Ten_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TreeView
            // 
            this.TreeView.ImageIndex = 0;
            this.TreeView.ImageList = this.ImageList;
            this.TreeView.Location = new System.Drawing.Point(12, 12);
            this.TreeView.Name = "TreeView";
            this.TreeView.SelectedImageIndex = 0;
            this.TreeView.Size = new System.Drawing.Size(641, 340);
            this.TreeView.TabIndex = 0;
            // 
            // ImageList
            // 
            this.ImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImageList.ImageStream")));
            this.ImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.ImageList.Images.SetKeyName(0, "Folder Close.jpg");
            this.ImageList.Images.SetKeyName(1, "Folder Open.jpg");
            this.ImageList.Images.SetKeyName(2, "Staff.png");
            // 
            // Them_PB
            // 
            this.Them_PB.Location = new System.Drawing.Point(670, 12);
            this.Them_PB.Name = "Them_PB";
            this.Them_PB.Size = new System.Drawing.Size(100, 50);
            this.Them_PB.TabIndex = 1;
            this.Them_PB.Text = "Thêm PB";
            this.Them_PB.UseVisualStyleBackColor = true;
            this.Them_PB.Click += new System.EventHandler(this.Them_PB_Click);
            // 
            // Them_NV
            // 
            this.Them_NV.Location = new System.Drawing.Point(670, 87);
            this.Them_NV.Name = "Them_NV";
            this.Them_NV.Size = new System.Drawing.Size(100, 50);
            this.Them_NV.TabIndex = 2;
            this.Them_NV.Text = "Thêm NV";
            this.Them_NV.UseVisualStyleBackColor = true;
            this.Them_NV.Click += new System.EventHandler(this.Them_NV_Click);
            // 
            // Chinh_Sua
            // 
            this.Chinh_Sua.Location = new System.Drawing.Point(670, 158);
            this.Chinh_Sua.Name = "Chinh_Sua";
            this.Chinh_Sua.Size = new System.Drawing.Size(100, 50);
            this.Chinh_Sua.TabIndex = 3;
            this.Chinh_Sua.Text = "Chỉnh sửa";
            this.Chinh_Sua.UseVisualStyleBackColor = true;
            this.Chinh_Sua.Click += new System.EventHandler(this.Chinh_Sua_Click);
            // 
            // Xoa
            // 
            this.Xoa.Location = new System.Drawing.Point(670, 233);
            this.Xoa.Name = "Xoa";
            this.Xoa.Size = new System.Drawing.Size(100, 50);
            this.Xoa.TabIndex = 4;
            this.Xoa.Text = "Xóa";
            this.Xoa.UseVisualStyleBackColor = true;
            this.Xoa.Click += new System.EventHandler(this.Xoa_Click);
            // 
            // Thoat
            // 
            this.Thoat.Location = new System.Drawing.Point(670, 302);
            this.Thoat.Name = "Thoat";
            this.Thoat.Size = new System.Drawing.Size(100, 50);
            this.Thoat.TabIndex = 5;
            this.Thoat.Text = "Thoát";
            this.Thoat.UseVisualStyleBackColor = true;
            this.Thoat.Click += new System.EventHandler(this.Thoat_Click);
            // 
            // Doi_Ten_Label
            // 
            this.Doi_Ten_Label.AutoSize = true;
            this.Doi_Ten_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.Doi_Ten_Label.Location = new System.Drawing.Point(12, 391);
            this.Doi_Ten_Label.Name = "Doi_Ten_Label";
            this.Doi_Ten_Label.Size = new System.Drawing.Size(87, 26);
            this.Doi_Ten_Label.TabIndex = 6;
            this.Doi_Ten_Label.Text = "Đổi tên:";
            // 
            // Doi_Ten_TextBox
            // 
            this.Doi_Ten_TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.Doi_Ten_TextBox.Location = new System.Drawing.Point(105, 388);
            this.Doi_Ten_TextBox.Name = "Doi_Ten_TextBox";
            this.Doi_Ten_TextBox.Size = new System.Drawing.Size(249, 32);
            this.Doi_Ten_TextBox.TabIndex = 7;
            // 
            // Luu_Ten_Button
            // 
            this.Luu_Ten_Button.Location = new System.Drawing.Point(360, 388);
            this.Luu_Ten_Button.Name = "Luu_Ten_Button";
            this.Luu_Ten_Button.Size = new System.Drawing.Size(100, 32);
            this.Luu_Ten_Button.TabIndex = 8;
            this.Luu_Ten_Button.Text = "Lưu";
            this.Luu_Ten_Button.UseVisualStyleBackColor = true;
            this.Luu_Ten_Button.Click += new System.EventHandler(this.Luu_Ten_Button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(782, 453);
            this.Controls.Add(this.Luu_Ten_Button);
            this.Controls.Add(this.Doi_Ten_TextBox);
            this.Controls.Add(this.Doi_Ten_Label);
            this.Controls.Add(this.Thoat);
            this.Controls.Add(this.Xoa);
            this.Controls.Add(this.Chinh_Sua);
            this.Controls.Add(this.Them_NV);
            this.Controls.Add(this.Them_PB);
            this.Controls.Add(this.TreeView);
            this.Name = "Form1";
            this.Text = "Tree View";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView TreeView;
        private System.Windows.Forms.Button Them_PB;
        private System.Windows.Forms.Button Them_NV;
        private System.Windows.Forms.Button Chinh_Sua;
        private System.Windows.Forms.Button Xoa;
        private System.Windows.Forms.Button Thoat;
        private System.Windows.Forms.Label Doi_Ten_Label;
        private System.Windows.Forms.TextBox Doi_Ten_TextBox;
        private System.Windows.Forms.Button Luu_Ten_Button;
        private System.Windows.Forms.ImageList ImageList;
    }
}