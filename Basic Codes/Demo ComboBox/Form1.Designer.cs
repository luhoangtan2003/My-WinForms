namespace Demo_ComboBox {
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.Hoc_Sinh_DDL = new System.Windows.Forms.ComboBox();
            this.Button_DDL = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Hoc_Sinh_DDL
            // 
            this.Hoc_Sinh_DDL.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Hoc_Sinh_DDL.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.Hoc_Sinh_DDL.FormattingEnabled = true;
            this.Hoc_Sinh_DDL.Location = new System.Drawing.Point(43, 42);
            this.Hoc_Sinh_DDL.Name = "Hoc_Sinh_DDL";
            this.Hoc_Sinh_DDL.Size = new System.Drawing.Size(306, 34);
            this.Hoc_Sinh_DDL.TabIndex = 1;
            // 
            // Button_DDL
            // 
            this.Button_DDL.Location = new System.Drawing.Point(403, 42);
            this.Button_DDL.Name = "Button_DDL";
            this.Button_DDL.Size = new System.Drawing.Size(75, 34);
            this.Button_DDL.TabIndex = 3;
            this.Button_DDL.Text = "Đồng ý";
            this.Button_DDL.UseVisualStyleBackColor = true;
            this.Button_DDL.Click += new System.EventHandler(this.Button_DDL_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(529, 121);
            this.Controls.Add(this.Button_DDL);
            this.Controls.Add(this.Hoc_Sinh_DDL);
            this.Name = "Form1";
            this.Text = "Demo Combo Box";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ComboBox Hoc_Sinh_DDL;
        private System.Windows.Forms.Button Button_DDL;
    }
}

