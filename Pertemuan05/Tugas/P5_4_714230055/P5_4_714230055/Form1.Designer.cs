namespace P5_4_714230055
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
            this.Nama = new System.Windows.Forms.TextBox();
            this.JenisKelamin = new System.Windows.Forms.ComboBox();
            this.TanggalLahir = new System.Windows.Forms.DateTimePicker();
            this.PilihanKelas = new System.Windows.Forms.GroupBox();
            this.BuluTangkis = new System.Windows.Forms.CheckBox();
            this.Panahan = new System.Windows.Forms.CheckBox();
            this.Voli = new System.Windows.Forms.CheckBox();
            this.Basket = new System.Windows.Forms.CheckBox();
            this.Yoga = new System.Windows.Forms.CheckBox();
            this.Tenis = new System.Windows.Forms.CheckBox();
            this.Renang = new System.Windows.Forms.CheckBox();
            this.SepakBola = new System.Windows.Forms.CheckBox();
            this.PilihanJadwal = new System.Windows.Forms.GroupBox();
            this.Minggu = new System.Windows.Forms.RadioButton();
            this.SabtuMinggu = new System.Windows.Forms.RadioButton();
            this.SelasaKamis = new System.Windows.Forms.RadioButton();
            this.SeninRabu = new System.Windows.Forms.RadioButton();
            this.Tampilkan = new System.Windows.Forms.Button();
            this.Selesai = new System.Windows.Forms.Button();
            this.Judul = new System.Windows.Forms.Label();
            this.PilihanKelas.SuspendLayout();
            this.PilihanJadwal.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(261, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nama";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(261, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Jenis Kelamin";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(261, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tanggal Lahir";
            // 
            // Nama
            // 
            this.Nama.Location = new System.Drawing.Point(414, 72);
            this.Nama.Name = "Nama";
            this.Nama.Size = new System.Drawing.Size(226, 29);
            this.Nama.TabIndex = 3;
            // 
            // JenisKelamin
            // 
            this.JenisKelamin.FormattingEnabled = true;
            this.JenisKelamin.Location = new System.Drawing.Point(414, 114);
            this.JenisKelamin.Name = "JenisKelamin";
            this.JenisKelamin.Size = new System.Drawing.Size(226, 31);
            this.JenisKelamin.TabIndex = 4;
            // 
            // TanggalLahir
            // 
            this.TanggalLahir.Location = new System.Drawing.Point(414, 155);
            this.TanggalLahir.Name = "TanggalLahir";
            this.TanggalLahir.Size = new System.Drawing.Size(226, 29);
            this.TanggalLahir.TabIndex = 5;
            this.TanggalLahir.ValueChanged += new System.EventHandler(this.TanggalLahir_ValueChanged);
            // 
            // PilihanKelas
            // 
            this.PilihanKelas.BackColor = System.Drawing.Color.Transparent;
            this.PilihanKelas.Controls.Add(this.BuluTangkis);
            this.PilihanKelas.Controls.Add(this.Panahan);
            this.PilihanKelas.Controls.Add(this.Voli);
            this.PilihanKelas.Controls.Add(this.Basket);
            this.PilihanKelas.Controls.Add(this.Yoga);
            this.PilihanKelas.Controls.Add(this.Tenis);
            this.PilihanKelas.Controls.Add(this.Renang);
            this.PilihanKelas.Controls.Add(this.SepakBola);
            this.PilihanKelas.Location = new System.Drawing.Point(34, 218);
            this.PilihanKelas.Name = "PilihanKelas";
            this.PilihanKelas.Size = new System.Drawing.Size(383, 161);
            this.PilihanKelas.TabIndex = 6;
            this.PilihanKelas.TabStop = false;
            this.PilihanKelas.Text = "Pilihan Kelas";
            this.PilihanKelas.Enter += new System.EventHandler(this.PilihanKelas_Enter);
            // 
            // BuluTangkis
            // 
            this.BuluTangkis.AutoSize = true;
            this.BuluTangkis.Location = new System.Drawing.Point(150, 65);
            this.BuluTangkis.Name = "BuluTangkis";
            this.BuluTangkis.Size = new System.Drawing.Size(131, 27);
            this.BuluTangkis.TabIndex = 8;
            this.BuluTangkis.Text = "Bulu Tangkis";
            this.BuluTangkis.UseVisualStyleBackColor = true;
            // 
            // Panahan
            // 
            this.Panahan.AutoSize = true;
            this.Panahan.Location = new System.Drawing.Point(150, 128);
            this.Panahan.Name = "Panahan";
            this.Panahan.Size = new System.Drawing.Size(103, 27);
            this.Panahan.TabIndex = 6;
            this.Panahan.Text = "Panahan";
            this.Panahan.UseVisualStyleBackColor = true;
            // 
            // Voli
            // 
            this.Voli.AutoSize = true;
            this.Voli.Location = new System.Drawing.Point(150, 95);
            this.Voli.Name = "Voli";
            this.Voli.Size = new System.Drawing.Size(64, 27);
            this.Voli.TabIndex = 5;
            this.Voli.Text = "Voli";
            this.Voli.UseVisualStyleBackColor = true;
            // 
            // Basket
            // 
            this.Basket.AutoSize = true;
            this.Basket.Location = new System.Drawing.Point(150, 28);
            this.Basket.Name = "Basket";
            this.Basket.Size = new System.Drawing.Size(86, 27);
            this.Basket.TabIndex = 4;
            this.Basket.Text = "Basket";
            this.Basket.UseVisualStyleBackColor = true;
            // 
            // Yoga
            // 
            this.Yoga.AutoSize = true;
            this.Yoga.Location = new System.Drawing.Point(6, 128);
            this.Yoga.Name = "Yoga";
            this.Yoga.Size = new System.Drawing.Size(74, 27);
            this.Yoga.TabIndex = 3;
            this.Yoga.Text = "Yoga";
            this.Yoga.UseVisualStyleBackColor = true;
            // 
            // Tenis
            // 
            this.Tenis.AutoSize = true;
            this.Tenis.Location = new System.Drawing.Point(6, 98);
            this.Tenis.Name = "Tenis";
            this.Tenis.Size = new System.Drawing.Size(73, 27);
            this.Tenis.TabIndex = 2;
            this.Tenis.Text = "Tenis";
            this.Tenis.UseVisualStyleBackColor = true;
            // 
            // Renang
            // 
            this.Renang.AutoSize = true;
            this.Renang.Location = new System.Drawing.Point(6, 65);
            this.Renang.Name = "Renang";
            this.Renang.Size = new System.Drawing.Size(95, 27);
            this.Renang.TabIndex = 1;
            this.Renang.Text = "Renang";
            this.Renang.UseVisualStyleBackColor = true;
            // 
            // SepakBola
            // 
            this.SepakBola.AutoSize = true;
            this.SepakBola.Location = new System.Drawing.Point(6, 28);
            this.SepakBola.Name = "SepakBola";
            this.SepakBola.Size = new System.Drawing.Size(120, 27);
            this.SepakBola.TabIndex = 0;
            this.SepakBola.Text = "Sepak Bola";
            this.SepakBola.UseVisualStyleBackColor = true;
            // 
            // PilihanJadwal
            // 
            this.PilihanJadwal.BackColor = System.Drawing.Color.Transparent;
            this.PilihanJadwal.Controls.Add(this.Minggu);
            this.PilihanJadwal.Controls.Add(this.SabtuMinggu);
            this.PilihanJadwal.Controls.Add(this.SelasaKamis);
            this.PilihanJadwal.Controls.Add(this.SeninRabu);
            this.PilihanJadwal.Location = new System.Drawing.Point(457, 218);
            this.PilihanJadwal.Name = "PilihanJadwal";
            this.PilihanJadwal.Size = new System.Drawing.Size(372, 161);
            this.PilihanJadwal.TabIndex = 7;
            this.PilihanJadwal.TabStop = false;
            this.PilihanJadwal.Text = "Pilihan Jadwal";
            // 
            // Minggu
            // 
            this.Minggu.AutoSize = true;
            this.Minggu.Location = new System.Drawing.Point(10, 128);
            this.Minggu.Name = "Minggu";
            this.Minggu.Size = new System.Drawing.Size(199, 27);
            this.Minggu.TabIndex = 3;
            this.Minggu.TabStop = true;
            this.Minggu.Text = "Minggu, 13:00 - 20:00";
            this.Minggu.UseVisualStyleBackColor = true;
            // 
            // SabtuMinggu
            // 
            this.SabtuMinggu.AutoSize = true;
            this.SabtuMinggu.Location = new System.Drawing.Point(10, 97);
            this.SabtuMinggu.Name = "SabtuMinggu";
            this.SabtuMinggu.Size = new System.Drawing.Size(275, 27);
            this.SabtuMinggu.TabIndex = 2;
            this.SabtuMinggu.TabStop = true;
            this.SabtuMinggu.Text = "Sabtu s/d Minggu, 09:00 - 11:00\r\n";
            this.SabtuMinggu.UseVisualStyleBackColor = true;
            // 
            // SelasaKamis
            // 
            this.SelasaKamis.AutoSize = true;
            this.SelasaKamis.Location = new System.Drawing.Point(10, 64);
            this.SelasaKamis.Name = "SelasaKamis";
            this.SelasaKamis.Size = new System.Drawing.Size(264, 27);
            this.SelasaKamis.TabIndex = 1;
            this.SelasaKamis.TabStop = true;
            this.SelasaKamis.Text = "Selasa s/d Kamis, 14:00 - 16:00";
            this.SelasaKamis.UseVisualStyleBackColor = true;
            // 
            // SeninRabu
            // 
            this.SeninRabu.AutoSize = true;
            this.SeninRabu.Location = new System.Drawing.Point(10, 27);
            this.SeninRabu.Name = "SeninRabu";
            this.SeninRabu.Size = new System.Drawing.Size(254, 27);
            this.SeninRabu.TabIndex = 0;
            this.SeninRabu.TabStop = true;
            this.SeninRabu.Text = "Senin s/d Rabu, 14:00 - 16:00";
            this.SeninRabu.UseVisualStyleBackColor = true;
            // 
            // Tampilkan
            // 
            this.Tampilkan.Location = new System.Drawing.Point(294, 441);
            this.Tampilkan.Name = "Tampilkan";
            this.Tampilkan.Size = new System.Drawing.Size(90, 38);
            this.Tampilkan.TabIndex = 8;
            this.Tampilkan.Text = "Tampilkan";
            this.Tampilkan.UseVisualStyleBackColor = true;
            this.Tampilkan.Click += new System.EventHandler(this.Tampilkan_Click);
            // 
            // Selesai
            // 
            this.Selesai.Location = new System.Drawing.Point(457, 441);
            this.Selesai.Name = "Selesai";
            this.Selesai.Size = new System.Drawing.Size(88, 38);
            this.Selesai.TabIndex = 9;
            this.Selesai.Text = "Selesai";
            this.Selesai.UseVisualStyleBackColor = true;
            this.Selesai.Click += new System.EventHandler(this.btnSelesai_Click);
            // 
            // Judul
            // 
            this.Judul.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Judul.AutoSize = true;
            this.Judul.BackColor = System.Drawing.Color.Transparent;
            this.Judul.Font = new System.Drawing.Font("Yu Gothic UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Judul.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Judul.Location = new System.Drawing.Point(244, 9);
            this.Judul.Name = "Judul";
            this.Judul.Size = new System.Drawing.Size(438, 55);
            this.Judul.TabIndex = 10;
            this.Judul.Text = "FORM PENDAFTARAN";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(888, 491);
            this.Controls.Add(this.Judul);
            this.Controls.Add(this.Selesai);
            this.Controls.Add(this.Tampilkan);
            this.Controls.Add(this.PilihanJadwal);
            this.Controls.Add(this.PilihanKelas);
            this.Controls.Add(this.TanggalLahir);
            this.Controls.Add(this.JenisKelamin);
            this.Controls.Add(this.Nama);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "Form Pendaftaran";
            this.Load += new System.EventHandler(this.Form_Load);
            this.PilihanKelas.ResumeLayout(false);
            this.PilihanKelas.PerformLayout();
            this.PilihanJadwal.ResumeLayout(false);
            this.PilihanJadwal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Nama;
        private System.Windows.Forms.ComboBox JenisKelamin;
        private System.Windows.Forms.DateTimePicker TanggalLahir;
        private System.Windows.Forms.GroupBox PilihanKelas;
        private System.Windows.Forms.CheckBox BuluTangkis;
        private System.Windows.Forms.CheckBox Panahan;
        private System.Windows.Forms.CheckBox Voli;
        private System.Windows.Forms.CheckBox Basket;
        private System.Windows.Forms.CheckBox Yoga;
        private System.Windows.Forms.CheckBox Tenis;
        private System.Windows.Forms.CheckBox Renang;
        private System.Windows.Forms.CheckBox SepakBola;
        private System.Windows.Forms.GroupBox PilihanJadwal;
        private System.Windows.Forms.RadioButton Minggu;
        private System.Windows.Forms.RadioButton SabtuMinggu;
        private System.Windows.Forms.RadioButton SelasaKamis;
        private System.Windows.Forms.RadioButton SeninRabu;
        private System.Windows.Forms.Button Tampilkan;
        private System.Windows.Forms.Button Selesai;
        private System.Windows.Forms.Label Judul;
    }
}