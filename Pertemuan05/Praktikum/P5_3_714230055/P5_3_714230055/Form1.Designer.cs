namespace P5_3_714230055
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMerkHP = new System.Windows.Forms.TextBox();
            this.rb_android = new System.Windows.Forms.RadioButton();
            this.rb_ios = new System.Windows.Forms.RadioButton();
            this.cbYa = new System.Windows.Forms.CheckBox();
            this.btnTampilkan = new System.Windows.Forms.Button();
            this.btnKeluar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Merk HP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "OS";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Sudah Diperbaiki?";
            // 
            // txtMerkHP
            // 
            this.txtMerkHP.Location = new System.Drawing.Point(180, 39);
            this.txtMerkHP.Name = "txtMerkHP";
            this.txtMerkHP.Size = new System.Drawing.Size(227, 26);
            this.txtMerkHP.TabIndex = 3;
            // 
            // rb_android
            // 
            this.rb_android.AutoSize = true;
            this.rb_android.Location = new System.Drawing.Point(180, 79);
            this.rb_android.Name = "rb_android";
            this.rb_android.Size = new System.Drawing.Size(89, 24);
            this.rb_android.TabIndex = 4;
            this.rb_android.TabStop = true;
            this.rb_android.Text = "Android";
            this.rb_android.UseVisualStyleBackColor = true;
            // 
            // rb_ios
            // 
            this.rb_ios.AutoSize = true;
            this.rb_ios.Location = new System.Drawing.Point(347, 79);
            this.rb_ios.Name = "rb_ios";
            this.rb_ios.Size = new System.Drawing.Size(60, 24);
            this.rb_ios.TabIndex = 5;
            this.rb_ios.TabStop = true;
            this.rb_ios.Text = "iOS";
            this.rb_ios.UseVisualStyleBackColor = true;
            // 
            // cbYa
            // 
            this.cbYa.AutoSize = true;
            this.cbYa.Location = new System.Drawing.Point(180, 115);
            this.cbYa.Name = "cbYa";
            this.cbYa.Size = new System.Drawing.Size(55, 24);
            this.cbYa.TabIndex = 6;
            this.cbYa.Text = "Ya";
            this.cbYa.UseVisualStyleBackColor = true;
            // 
            // btnTampilkan
            // 
            this.btnTampilkan.Location = new System.Drawing.Point(80, 166);
            this.btnTampilkan.Name = "btnTampilkan";
            this.btnTampilkan.Size = new System.Drawing.Size(92, 36);
            this.btnTampilkan.TabIndex = 7;
            this.btnTampilkan.Text = "Tampilkan";
            this.btnTampilkan.UseVisualStyleBackColor = true;
            this.btnTampilkan.Click += new System.EventHandler(this.btnTampilkan_Click);
            // 
            // btnKeluar
            // 
            this.btnKeluar.Location = new System.Drawing.Point(259, 166);
            this.btnKeluar.Name = "btnKeluar";
            this.btnKeluar.Size = new System.Drawing.Size(92, 36);
            this.btnKeluar.TabIndex = 8;
            this.btnKeluar.Text = "Keluar";
            this.btnKeluar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(444, 259);
            this.Controls.Add(this.btnKeluar);
            this.Controls.Add(this.btnTampilkan);
            this.Controls.Add(this.cbYa);
            this.Controls.Add(this.rb_ios);
            this.Controls.Add(this.rb_android);
            this.Controls.Add(this.txtMerkHP);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Service HP";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMerkHP;
        private System.Windows.Forms.RadioButton rb_android;
        private System.Windows.Forms.RadioButton rb_ios;
        private System.Windows.Forms.CheckBox cbYa;
        private System.Windows.Forms.Button btnTampilkan;
        private System.Windows.Forms.Button btnKeluar;
    }
}

