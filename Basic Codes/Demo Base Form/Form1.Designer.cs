namespace Demo_Base_Form {
    partial class DF1 {
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
            this.Info = new System.Windows.Forms.GroupBox();
            this.C = new System.Windows.Forms.CheckBox();
            this.B = new System.Windows.Forms.CheckBox();
            this.A = new System.Windows.Forms.CheckBox();
            this.Female = new System.Windows.Forms.RadioButton();
            this.Male = new System.Windows.Forms.RadioButton();
            this.DateofBirth = new System.Windows.Forms.DateTimePicker();
            this.FullName = new System.Windows.Forms.TextBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.Export = new System.Windows.Forms.Button();
            this.Close_Form = new System.Windows.Forms.Button();
            this.Info.SuspendLayout();
            this.SuspendLayout();
            // 
            // Info
            // 
            this.Info.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Info.Controls.Add(this.C);
            this.Info.Controls.Add(this.B);
            this.Info.Controls.Add(this.A);
            this.Info.Controls.Add(this.Female);
            this.Info.Controls.Add(this.Male);
            this.Info.Controls.Add(this.DateofBirth);
            this.Info.Controls.Add(this.FullName);
            this.Info.Controls.Add(this.Label4);
            this.Info.Controls.Add(this.Label3);
            this.Info.Controls.Add(this.Label2);
            this.Info.Controls.Add(this.Label1);
            this.Info.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.Info.Location = new System.Drawing.Point(12, 12);
            this.Info.Name = "Info";
            this.Info.Size = new System.Drawing.Size(785, 311);
            this.Info.TabIndex = 0;
            this.Info.TabStop = false;
            this.Info.Text = "Thông tin";
            // 
            // C
            // 
            this.C.AutoSize = true;
            this.C.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.C.Location = new System.Drawing.Point(520, 257);
            this.C.Name = "C";
            this.C.Size = new System.Drawing.Size(118, 30);
            this.C.TabIndex = 10;
            this.C.Text = "Thể thao";
            this.C.UseVisualStyleBackColor = true;
            // 
            // B
            // 
            this.B.AutoSize = true;
            this.B.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.B.Location = new System.Drawing.Point(520, 198);
            this.B.Name = "B";
            this.B.Size = new System.Drawing.Size(125, 30);
            this.B.TabIndex = 9;
            this.B.Text = "Đọc sách";
            this.B.UseVisualStyleBackColor = true;
            // 
            // A
            // 
            this.A.AutoSize = true;
            this.A.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.A.Location = new System.Drawing.Point(520, 145);
            this.A.Name = "A";
            this.A.Size = new System.Drawing.Size(140, 30);
            this.A.TabIndex = 8;
            this.A.Text = "Chơi game";
            this.A.UseVisualStyleBackColor = true;
            // 
            // Female
            // 
            this.Female.AutoSize = true;
            this.Female.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.Female.Location = new System.Drawing.Point(271, 145);
            this.Female.Name = "Female";
            this.Female.Size = new System.Drawing.Size(63, 30);
            this.Female.TabIndex = 7;
            this.Female.Text = "Nữ";
            this.Female.UseVisualStyleBackColor = true;
            // 
            // Male
            // 
            this.Male.AutoSize = true;
            this.Male.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.Male.Location = new System.Drawing.Point(155, 145);
            this.Male.Name = "Male";
            this.Male.Size = new System.Drawing.Size(83, 30);
            this.Male.TabIndex = 6;
            this.Male.Text = "Nam";
            this.Male.UseVisualStyleBackColor = true;
            // 
            // DateofBirth
            // 
            this.DateofBirth.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.DateofBirth.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateofBirth.Location = new System.Drawing.Point(530, 68);
            this.DateofBirth.Name = "DateofBirth";
            this.DateofBirth.Size = new System.Drawing.Size(200, 32);
            this.DateofBirth.TabIndex = 5;
            // 
            // FullName
            // 
            this.FullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.FullName.Location = new System.Drawing.Point(134, 68);
            this.FullName.Name = "FullName";
            this.FullName.Size = new System.Drawing.Size(200, 32);
            this.FullName.TabIndex = 4;
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.Label4.Location = new System.Drawing.Point(399, 145);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(106, 26);
            this.Label4.TabIndex = 3;
            this.Label4.Text = "Sở thích:";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.Label3.Location = new System.Drawing.Point(41, 145);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(108, 26);
            this.Label3.TabIndex = 2;
            this.Label3.Text = "Giới tính:";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.Label2.Location = new System.Drawing.Point(399, 74);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(125, 26);
            this.Label2.TabIndex = 1;
            this.Label2.Text = "Ngày sinh:";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.Label1.Location = new System.Drawing.Point(41, 74);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(89, 26);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "Họ tên:";
            // 
            // Export
            // 
            this.Export.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.Export.Location = new System.Drawing.Point(416, 345);
            this.Export.Name = "Export";
            this.Export.Size = new System.Drawing.Size(216, 42);
            this.Export.TabIndex = 1;
            this.Export.Text = "Xuất thông tin";
            this.Export.UseVisualStyleBackColor = true;
            this.Export.Click += new System.EventHandler(this.Export_Click);
            // 
            // Close_Form
            // 
            this.Close_Form.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.Close_Form.Location = new System.Drawing.Point(649, 345);
            this.Close_Form.Name = "Close_Form";
            this.Close_Form.Size = new System.Drawing.Size(148, 42);
            this.Close_Form.TabIndex = 2;
            this.Close_Form.Text = "Thoát";
            this.Close_Form.UseVisualStyleBackColor = true;
            this.Close_Form.Click += new System.EventHandler(this.Close_Form_Click);
            // 
            // DF1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 404);
            this.Controls.Add(this.Close_Form);
            this.Controls.Add(this.Export);
            this.Controls.Add(this.Info);
            this.Name = "DF1";
            this.Text = "Thông tin cá nhân";
            this.Info.ResumeLayout(false);
            this.Info.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Info;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Label Label3;
        private System.Windows.Forms.Label Label2;
        private System.Windows.Forms.Label Label4;
        private System.Windows.Forms.TextBox FullName;
        private System.Windows.Forms.DateTimePicker DateofBirth;
        private System.Windows.Forms.RadioButton Male;
        private System.Windows.Forms.CheckBox A;
        private System.Windows.Forms.RadioButton Female;
        private System.Windows.Forms.CheckBox C;
        private System.Windows.Forms.CheckBox B;
        private System.Windows.Forms.Button Export;
        private System.Windows.Forms.Button Close_Form;
    }
}