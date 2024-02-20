namespace Demo_ListView {
    partial class Thong_Tin_Form {
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
            this.MSNV_Label = new System.Windows.Forms.Label();
            this.TNV_Label = new System.Windows.Forms.Label();
            this.ML_Label = new System.Windows.Forms.Label();
            this.TextBox_MSNV = new System.Windows.Forms.TextBox();
            this.TextBox_TNV = new System.Windows.Forms.TextBox();
            this.TextBox_ML = new System.Windows.Forms.TextBox();
            this.Dong_Y = new System.Windows.Forms.Button();
            this.Huy_Bo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MSNV_Label
            // 
            this.MSNV_Label.AutoSize = true;
            this.MSNV_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.MSNV_Label.Location = new System.Drawing.Point(12, 42);
            this.MSNV_Label.Name = "MSNV_Label";
            this.MSNV_Label.Size = new System.Drawing.Size(161, 26);
            this.MSNV_Label.TabIndex = 0;
            this.MSNV_Label.Text = "Mã nhân viên:";
            // 
            // TNV_Label
            // 
            this.TNV_Label.AutoSize = true;
            this.TNV_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.TNV_Label.Location = new System.Drawing.Point(12, 96);
            this.TNV_Label.Name = "TNV_Label";
            this.TNV_Label.Size = new System.Drawing.Size(168, 26);
            this.TNV_Label.TabIndex = 1;
            this.TNV_Label.Text = "Tên nhân viên:";
            // 
            // ML_Label
            // 
            this.ML_Label.AutoSize = true;
            this.ML_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.ML_Label.Location = new System.Drawing.Point(12, 147);
            this.ML_Label.Name = "ML_Label";
            this.ML_Label.Size = new System.Drawing.Size(128, 26);
            this.ML_Label.TabIndex = 2;
            this.ML_Label.Text = "Mức lương:";
            // 
            // TextBox_MSNV
            // 
            this.TextBox_MSNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.TextBox_MSNV.Location = new System.Drawing.Point(196, 42);
            this.TextBox_MSNV.Name = "TextBox_MSNV";
            this.TextBox_MSNV.Size = new System.Drawing.Size(274, 32);
            this.TextBox_MSNV.TabIndex = 0;
            // 
            // TextBox_TNV
            // 
            this.TextBox_TNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.TextBox_TNV.Location = new System.Drawing.Point(196, 96);
            this.TextBox_TNV.Name = "TextBox_TNV";
            this.TextBox_TNV.Size = new System.Drawing.Size(274, 32);
            this.TextBox_TNV.TabIndex = 1;
            // 
            // TextBox_ML
            // 
            this.TextBox_ML.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.TextBox_ML.Location = new System.Drawing.Point(196, 147);
            this.TextBox_ML.Name = "TextBox_ML";
            this.TextBox_ML.Size = new System.Drawing.Size(274, 32);
            this.TextBox_ML.TabIndex = 2;
            // 
            // Dong_Y
            // 
            this.Dong_Y.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Dong_Y.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Dong_Y.Location = new System.Drawing.Point(124, 223);
            this.Dong_Y.Name = "Dong_Y";
            this.Dong_Y.Size = new System.Drawing.Size(100, 50);
            this.Dong_Y.TabIndex = 3;
            this.Dong_Y.Text = "Đồng ý";
            this.Dong_Y.UseVisualStyleBackColor = false;
            // 
            // Huy_Bo
            // 
            this.Huy_Bo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Huy_Bo.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Huy_Bo.Location = new System.Drawing.Point(264, 223);
            this.Huy_Bo.Name = "Huy_Bo";
            this.Huy_Bo.Size = new System.Drawing.Size(100, 50);
            this.Huy_Bo.TabIndex = 4;
            this.Huy_Bo.Text = "Huỷ bỏ";
            this.Huy_Bo.UseVisualStyleBackColor = false;
            // 
            // Thong_Tin_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(482, 291);
            this.Controls.Add(this.Huy_Bo);
            this.Controls.Add(this.Dong_Y);
            this.Controls.Add(this.TextBox_ML);
            this.Controls.Add(this.TextBox_TNV);
            this.Controls.Add(this.TextBox_MSNV);
            this.Controls.Add(this.ML_Label);
            this.Controls.Add(this.TNV_Label);
            this.Controls.Add(this.MSNV_Label);
            this.Name = "Thong_Tin_Form";
            this.Text = "Thông tin cá nhân";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label MSNV_Label;
        private System.Windows.Forms.Label TNV_Label;
        private System.Windows.Forms.Label ML_Label;
        private System.Windows.Forms.TextBox TextBox_MSNV;
        private System.Windows.Forms.TextBox TextBox_TNV;
        private System.Windows.Forms.TextBox TextBox_ML;
        private System.Windows.Forms.Button Dong_Y;
        private System.Windows.Forms.Button Huy_Bo;
    }
}