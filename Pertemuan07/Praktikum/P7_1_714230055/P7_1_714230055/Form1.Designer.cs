namespace P7_1_714230055
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
            this.Nama = new System.Windows.Forms.Label();
            this.Angkatan = new System.Windows.Forms.Label();
            this.Kelas = new System.Windows.Forms.Label();
            this.textBoxNama = new System.Windows.Forms.TextBox();
            this.textBoxKelas = new System.Windows.Forms.TextBox();
            this.comboBoxAngkatan = new System.Windows.Forms.ComboBox();
            this.buttonCek = new System.Windows.Forms.Button();
            this.buttonTutup = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButtonWeekDay = new System.Windows.Forms.RadioButton();
            this.radioButtonWeekEnd = new System.Windows.Forms.RadioButton();
            this.checkBoxKuliah = new System.Windows.Forms.CheckBox();
            this.checkBoxTidur = new System.Windows.Forms.CheckBox();
            this.checkBoxLiburan = new System.Windows.Forms.CheckBox();
            this.buttonCetak = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Nama
            // 
            this.Nama.AutoSize = true;
            this.Nama.Location = new System.Drawing.Point(11, 13);
            this.Nama.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Nama.Name = "Nama";
            this.Nama.Size = new System.Drawing.Size(35, 13);
            this.Nama.TabIndex = 0;
            this.Nama.Text = "Nama";
            this.Nama.Click += new System.EventHandler(this.label1_Click);
            // 
            // Angkatan
            // 
            this.Angkatan.AutoSize = true;
            this.Angkatan.Location = new System.Drawing.Point(11, 48);
            this.Angkatan.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Angkatan.Name = "Angkatan";
            this.Angkatan.Size = new System.Drawing.Size(53, 13);
            this.Angkatan.TabIndex = 1;
            this.Angkatan.Text = "Angkatan";
            this.Angkatan.Click += new System.EventHandler(this.label2_Click);
            // 
            // Kelas
            // 
            this.Kelas.AutoSize = true;
            this.Kelas.Location = new System.Drawing.Point(13, 83);
            this.Kelas.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Kelas.Name = "Kelas";
            this.Kelas.Size = new System.Drawing.Size(33, 13);
            this.Kelas.TabIndex = 2;
            this.Kelas.Text = "Kelas";
            // 
            // textBoxNama
            // 
            this.textBoxNama.Location = new System.Drawing.Point(67, 9);
            this.textBoxNama.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxNama.Name = "textBoxNama";
            this.textBoxNama.Size = new System.Drawing.Size(137, 20);
            this.textBoxNama.TabIndex = 3;
            // 
            // textBoxKelas
            // 
            this.textBoxKelas.Location = new System.Drawing.Point(67, 83);
            this.textBoxKelas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxKelas.Multiline = true;
            this.textBoxKelas.Name = "textBoxKelas";
            this.textBoxKelas.Size = new System.Drawing.Size(137, 78);
            this.textBoxKelas.TabIndex = 5;
            this.textBoxKelas.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // comboBoxAngkatan
            // 
            this.comboBoxAngkatan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAngkatan.FormattingEnabled = true;
            this.comboBoxAngkatan.Items.AddRange(new object[] {
            "2020",
            "2021",
            "2022",
            "2023",
            "2023",
            "2024"});
            this.comboBoxAngkatan.Location = new System.Drawing.Point(67, 46);
            this.comboBoxAngkatan.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxAngkatan.Name = "comboBoxAngkatan";
            this.comboBoxAngkatan.Size = new System.Drawing.Size(137, 21);
            this.comboBoxAngkatan.TabIndex = 6;
            // 
            // buttonCek
            // 
            this.buttonCek.Location = new System.Drawing.Point(67, 177);
            this.buttonCek.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonCek.Name = "buttonCek";
            this.buttonCek.Size = new System.Drawing.Size(51, 21);
            this.buttonCek.TabIndex = 7;
            this.buttonCek.Text = "Cek";
            this.buttonCek.UseVisualStyleBackColor = true;
            this.buttonCek.Click += new System.EventHandler(this.buttonCek_Click);
            // 
            // buttonTutup
            // 
            this.buttonTutup.Location = new System.Drawing.Point(153, 177);
            this.buttonTutup.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonTutup.Name = "buttonTutup";
            this.buttonTutup.Size = new System.Drawing.Size(51, 21);
            this.buttonTutup.TabIndex = 8;
            this.buttonTutup.Text = "Tutup";
            this.buttonTutup.UseVisualStyleBackColor = true;
            this.buttonTutup.Click += new System.EventHandler(this.buttonTutup_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(63, 213);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 26);
            this.label1.TabIndex = 9;
            this.label1.Text = "Kegiatan";
            // 
            // radioButtonWeekDay
            // 
            this.radioButtonWeekDay.AutoSize = true;
            this.radioButtonWeekDay.Location = new System.Drawing.Point(13, 255);
            this.radioButtonWeekDay.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioButtonWeekDay.Name = "radioButtonWeekDay";
            this.radioButtonWeekDay.Size = new System.Drawing.Size(91, 17);
            this.radioButtonWeekDay.TabIndex = 10;
            this.radioButtonWeekDay.TabStop = true;
            this.radioButtonWeekDay.Text = "Senin - Jum\'at";
            this.radioButtonWeekDay.UseVisualStyleBackColor = true;
            this.radioButtonWeekDay.CheckedChanged += new System.EventHandler(this.radioButtonWeekDay_CheckedChanged);
            // 
            // radioButtonWeekEnd
            // 
            this.radioButtonWeekEnd.AutoSize = true;
            this.radioButtonWeekEnd.Location = new System.Drawing.Point(13, 274);
            this.radioButtonWeekEnd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioButtonWeekEnd.Name = "radioButtonWeekEnd";
            this.radioButtonWeekEnd.Size = new System.Drawing.Size(97, 17);
            this.radioButtonWeekEnd.TabIndex = 11;
            this.radioButtonWeekEnd.TabStop = true;
            this.radioButtonWeekEnd.Text = "Sabtu - Minggu";
            this.radioButtonWeekEnd.UseVisualStyleBackColor = true;
            this.radioButtonWeekEnd.CheckedChanged += new System.EventHandler(this.radioButtonWeekEnd_CheckedChanged);
            // 
            // checkBoxKuliah
            // 
            this.checkBoxKuliah.AutoSize = true;
            this.checkBoxKuliah.Location = new System.Drawing.Point(15, 306);
            this.checkBoxKuliah.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkBoxKuliah.Name = "checkBoxKuliah";
            this.checkBoxKuliah.Size = new System.Drawing.Size(55, 17);
            this.checkBoxKuliah.TabIndex = 12;
            this.checkBoxKuliah.Text = "Kuliah";
            this.checkBoxKuliah.UseVisualStyleBackColor = true;
            // 
            // checkBoxTidur
            // 
            this.checkBoxTidur.AutoSize = true;
            this.checkBoxTidur.Location = new System.Drawing.Point(15, 326);
            this.checkBoxTidur.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkBoxTidur.Name = "checkBoxTidur";
            this.checkBoxTidur.Size = new System.Drawing.Size(50, 17);
            this.checkBoxTidur.TabIndex = 13;
            this.checkBoxTidur.Text = "Tidur";
            this.checkBoxTidur.UseVisualStyleBackColor = true;
            // 
            // checkBoxLiburan
            // 
            this.checkBoxLiburan.AutoSize = true;
            this.checkBoxLiburan.Location = new System.Drawing.Point(15, 345);
            this.checkBoxLiburan.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkBoxLiburan.Name = "checkBoxLiburan";
            this.checkBoxLiburan.Size = new System.Drawing.Size(61, 17);
            this.checkBoxLiburan.TabIndex = 14;
            this.checkBoxLiburan.Text = "Liburan";
            this.checkBoxLiburan.UseVisualStyleBackColor = true;
            // 
            // buttonCetak
            // 
            this.buttonCetak.Location = new System.Drawing.Point(68, 378);
            this.buttonCetak.Name = "buttonCetak";
            this.buttonCetak.Size = new System.Drawing.Size(75, 23);
            this.buttonCetak.TabIndex = 15;
            this.buttonCetak.Text = "Cetak";
            this.buttonCetak.UseVisualStyleBackColor = true;
            this.buttonCetak.Click += new System.EventHandler(this.buttonCetak_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(149, 378);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(75, 23);
            this.buttonReset.TabIndex = 16;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(236, 413);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonCetak);
            this.Controls.Add(this.checkBoxLiburan);
            this.Controls.Add(this.checkBoxTidur);
            this.Controls.Add(this.checkBoxKuliah);
            this.Controls.Add(this.radioButtonWeekEnd);
            this.Controls.Add(this.radioButtonWeekDay);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonTutup);
            this.Controls.Add(this.buttonCek);
            this.Controls.Add(this.comboBoxAngkatan);
            this.Controls.Add(this.textBoxKelas);
            this.Controls.Add(this.textBoxNama);
            this.Controls.Add(this.Kelas);
            this.Controls.Add(this.Angkatan);
            this.Controls.Add(this.Nama);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Nama;
        private System.Windows.Forms.Label Angkatan;
        private System.Windows.Forms.Label Kelas;
        private System.Windows.Forms.TextBox textBoxNama;
        private System.Windows.Forms.TextBox textBoxKelas;
        private System.Windows.Forms.ComboBox comboBoxAngkatan;
        private System.Windows.Forms.Button buttonCek;
        private System.Windows.Forms.Button buttonTutup;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButtonWeekDay;
        private System.Windows.Forms.RadioButton radioButtonWeekEnd;
        private System.Windows.Forms.CheckBox checkBoxKuliah;
        private System.Windows.Forms.CheckBox checkBoxTidur;
        private System.Windows.Forms.CheckBox checkBoxLiburan;
        private System.Windows.Forms.Button buttonCetak;
        private System.Windows.Forms.Button buttonReset;
    }
}

