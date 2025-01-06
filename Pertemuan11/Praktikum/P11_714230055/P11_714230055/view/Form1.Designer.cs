using Org.BouncyCastle.Asn1.Crmf;
using static System.Net.Mime.MediaTypeNames;
using System.Drawing.Printing;
using System.Drawing;
using System.Windows.Forms;
using System.Xml.Linq;

namespace P11_714230055
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
            this.gbTabel = new System.Windows.Forms.GroupBox();
            this.dataMahasiswa = new System.Windows.Forms.DataGridView();
            this.gbForm = new System.Windows.Forms.GroupBox();
            this.comboBoxAngkatan = new System.Windows.Forms.ComboBox();
            this.textBoxHP = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxAlamat = new System.Windows.Forms.TextBox();
            this.textBoxNama = new System.Windows.Forms.TextBox();
            this.textBoxNPM = new System.Windows.Forms.TextBox();
            this.labelHP = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelAlamat = new System.Windows.Forms.Label();
            this.labelAngkatan = new System.Windows.Forms.Label();
            this.labelNama = new System.Windows.Forms.Label();
            this.labelNPM = new System.Windows.Forms.Label();
            this.gbAction = new System.Windows.Forms.GroupBox();
            this.buttonRubah = new System.Windows.Forms.Button();
            this.buttonHapus = new System.Windows.Forms.Button();
            this.buttonSimpan = new System.Windows.Forms.Button();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.gbPencarian = new System.Windows.Forms.GroupBox();
            this.cariData = new System.Windows.Forms.Label();
            this.textBoxPencarian = new System.Windows.Forms.TextBox();
            this.gbTabel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataMahasiswa)).BeginInit();
            this.gbForm.SuspendLayout();
            this.gbAction.SuspendLayout();
            this.gbPencarian.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbTabel
            // 
            this.gbTabel.Controls.Add(this.dataMahasiswa);
            this.gbTabel.Location = new System.Drawing.Point(20, 10);
            this.gbTabel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbTabel.Name = "gbTabel";
            this.gbTabel.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbTabel.Size = new System.Drawing.Size(860, 280);
            this.gbTabel.TabIndex = 0;
            this.gbTabel.TabStop = false;
            this.gbTabel.Text = "Tabel Data Mahasiswa";
            // 
            // dataMahasiswa
            // 
            this.dataMahasiswa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataMahasiswa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataMahasiswa.Location = new System.Drawing.Point(15, 25);
            this.dataMahasiswa.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataMahasiswa.Name = "dataMahasiswa";
            this.dataMahasiswa.RowHeadersWidth = 51;
            this.dataMahasiswa.Size = new System.Drawing.Size(819, 230);
            this.dataMahasiswa.TabIndex = 0;
            dataMahasiswa.CellClick += dataMahasiswa_CellClick;
            // 
            // gbForm
            // 
            this.gbForm.Controls.Add(this.comboBoxAngkatan);
            this.gbForm.Controls.Add(this.textBoxHP);
            this.gbForm.Controls.Add(this.textBoxEmail);
            this.gbForm.Controls.Add(this.textBoxAlamat);
            this.gbForm.Controls.Add(this.textBoxNama);
            this.gbForm.Controls.Add(this.textBoxNPM);
            this.gbForm.Controls.Add(this.labelHP);
            this.gbForm.Controls.Add(this.labelEmail);
            this.gbForm.Controls.Add(this.labelAlamat);
            this.gbForm.Controls.Add(this.labelAngkatan);
            this.gbForm.Controls.Add(this.labelNama);
            this.gbForm.Controls.Add(this.labelNPM);
            this.gbForm.Location = new System.Drawing.Point(20, 300);
            this.gbForm.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbForm.Name = "gbForm";
            this.gbForm.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbForm.Size = new System.Drawing.Size(420, 300);
            this.gbForm.TabIndex = 1;
            this.gbForm.TabStop = false;
            this.gbForm.Text = "Form Data Mahasiswa";
            // 
            // comboBoxAngkatan
            // 
            this.comboBoxAngkatan.FormattingEnabled = true;
            this.comboBoxAngkatan.Items.AddRange(new object[] {
            "2018",
            "2019",
            "2020",
            "2021",
            "2022",
            "2023",
            "2024"});
            this.comboBoxAngkatan.Location = new System.Drawing.Point(120, 100);
            this.comboBoxAngkatan.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.comboBoxAngkatan.Name = "comboBoxAngkatan";
            this.comboBoxAngkatan.Size = new System.Drawing.Size(260, 24);
            this.comboBoxAngkatan.TabIndex = 11;
            // 
            // textBoxHP
            // 
            this.textBoxHP.Location = new System.Drawing.Point(120, 240);
            this.textBoxHP.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxHP.Name = "textBoxHP";
            this.textBoxHP.Size = new System.Drawing.Size(260, 22);
            this.textBoxHP.TabIndex = 10;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(120, 200);
            this.textBoxEmail.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(260, 22);
            this.textBoxEmail.TabIndex = 9;
            // 
            // textBoxAlamat
            // 
            this.textBoxAlamat.Location = new System.Drawing.Point(120, 140);
            this.textBoxAlamat.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxAlamat.Multiline = true;
            this.textBoxAlamat.Name = "textBoxAlamat";
            this.textBoxAlamat.Size = new System.Drawing.Size(260, 50);
            this.textBoxAlamat.TabIndex = 8;
            // 
            // textBoxNama
            // 
            this.textBoxNama.Location = new System.Drawing.Point(120, 60);
            this.textBoxNama.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxNama.Name = "textBoxNama";
            this.textBoxNama.Size = new System.Drawing.Size(260, 22);
            this.textBoxNama.TabIndex = 7;
            // 
            // textBoxNPM
            // 
            this.textBoxNPM.Location = new System.Drawing.Point(120, 20);
            this.textBoxNPM.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxNPM.Name = "textBoxNPM";
            this.textBoxNPM.Size = new System.Drawing.Size(260, 22);
            this.textBoxNPM.TabIndex = 6;
            // 
            // labelHP
            // 
            this.labelHP.AutoSize = true;
            this.labelHP.Location = new System.Drawing.Point(20, 240);
            this.labelHP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelHP.Name = "labelHP";
            this.labelHP.Size = new System.Drawing.Size(47, 16);
            this.labelHP.TabIndex = 5;
            this.labelHP.Text = "No HP";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(20, 200);
            this.labelEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(41, 16);
            this.labelEmail.TabIndex = 4;
            this.labelEmail.Text = "Email";
            // 
            // labelAlamat
            // 
            this.labelAlamat.AutoSize = true;
            this.labelAlamat.Location = new System.Drawing.Point(20, 140);
            this.labelAlamat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAlamat.Name = "labelAlamat";
            this.labelAlamat.Size = new System.Drawing.Size(49, 16);
            this.labelAlamat.TabIndex = 3;
            this.labelAlamat.Text = "Alamat";
            // 
            // labelAngkatan
            // 
            this.labelAngkatan.AutoSize = true;
            this.labelAngkatan.Location = new System.Drawing.Point(20, 100);
            this.labelAngkatan.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAngkatan.Name = "labelAngkatan";
            this.labelAngkatan.Size = new System.Drawing.Size(64, 16);
            this.labelAngkatan.TabIndex = 2;
            this.labelAngkatan.Text = "Angkatan";
            // 
            // labelNama
            // 
            this.labelNama.AutoSize = true;
            this.labelNama.Location = new System.Drawing.Point(20, 60);
            this.labelNama.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNama.Name = "labelNama";
            this.labelNama.Size = new System.Drawing.Size(44, 16);
            this.labelNama.TabIndex = 1;
            this.labelNama.Text = "Nama";
            // 
            // labelNPM
            // 
            this.labelNPM.AutoSize = true;
            this.labelNPM.Location = new System.Drawing.Point(20, 20);
            this.labelNPM.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNPM.Name = "labelNPM";
            this.labelNPM.Size = new System.Drawing.Size(37, 16);
            this.labelNPM.TabIndex = 0;
            this.labelNPM.Text = "NPM";
            // 
            // gbAction
            // 
            this.gbAction.Controls.Add(this.buttonRubah);
            this.gbAction.Controls.Add(this.buttonHapus);
            this.gbAction.Controls.Add(this.buttonSimpan);
            this.gbAction.Controls.Add(this.buttonRefresh);
            this.gbAction.Location = new System.Drawing.Point(460, 388);
            this.gbAction.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbAction.Name = "gbAction";
            this.gbAction.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbAction.Size = new System.Drawing.Size(360, 200);
            this.gbAction.TabIndex = 2;
            this.gbAction.TabStop = false;
            this.gbAction.Text = "Tabel Action";
            // 
            // buttonRubah
            // 
            this.buttonRubah.Location = new System.Drawing.Point(40, 101);
            this.buttonRubah.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonRubah.Name = "buttonRubah";
            this.buttonRubah.Size = new System.Drawing.Size(280, 30);
            this.buttonRubah.TabIndex = 3;
            this.buttonRubah.Text = "Rubah";
            this.buttonRubah.UseVisualStyleBackColor = true;
            buttonRubah.Click += buttonRubah_Click;
            // 
            // buttonHapus
            // 
            this.buttonHapus.Location = new System.Drawing.Point(40, 141);
            this.buttonHapus.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonHapus.Name = "buttonHapus";
            this.buttonHapus.Size = new System.Drawing.Size(280, 30);
            this.buttonHapus.TabIndex = 2;
            this.buttonHapus.Text = "Hapus";
            this.buttonHapus.UseVisualStyleBackColor = true;
            buttonHapus.Click += buttonHapus_Click;
            // 
            // buttonSimpan
            // 
            this.buttonSimpan.Location = new System.Drawing.Point(40, 61);
            this.buttonSimpan.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonSimpan.Name = "buttonSimpan";
            this.buttonSimpan.Size = new System.Drawing.Size(280, 30);
            this.buttonSimpan.TabIndex = 1;
            this.buttonSimpan.Text = "Simpan";
            this.buttonSimpan.UseVisualStyleBackColor = true;
            buttonSimpan.Click += buttonSimpan_Click;
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Location = new System.Drawing.Point(40, 21);
            this.buttonRefresh.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(280, 30);
            this.buttonRefresh.TabIndex = 0;
            this.buttonRefresh.Text = "Refresh";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            buttonRefresh.Click += buttonRefresh_Click;
            // 
            // gbPencarian
            // 
            this.gbPencarian.Controls.Add(this.cariData);
            this.gbPencarian.Controls.Add(this.textBoxPencarian);
            this.gbPencarian.Location = new System.Drawing.Point(460, 302);
            this.gbPencarian.Name = "gbPencarian";
            this.gbPencarian.Size = new System.Drawing.Size(420, 80);
            this.gbPencarian.TabIndex = 3;
            this.gbPencarian.TabStop = false;
            this.gbPencarian.Text = "Form Pencarian";
            // 
            // cariData
            // 
            this.cariData.AutoSize = true;
            this.cariData.Location = new System.Drawing.Point(25, 35);
            this.cariData.Name = "cariData";
            this.cariData.Size = new System.Drawing.Size(63, 16);
            this.cariData.TabIndex = 1;
            this.cariData.Text = "Cari Data";
            // 
            // textBoxPencarian
            // 
            this.textBoxPencarian.Location = new System.Drawing.Point(120, 30);
            this.textBoxPencarian.Name = "textBoxPencarian";
            this.textBoxPencarian.Size = new System.Drawing.Size(274, 22);
            this.textBoxPencarian.TabIndex = 0;
            textBoxPencarian.TextChanged += textBoxPencarian_TextChanged;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 600);
            this.Controls.Add(this.gbPencarian);
            this.Controls.Add(this.gbAction);
            this.Controls.Add(this.gbForm);
            this.Controls.Add(this.gbTabel);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form Data Mahasiswa";
            Load += Form1_Load;
            this.gbTabel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataMahasiswa)).EndInit();
            this.gbForm.ResumeLayout(false);
            this.gbForm.PerformLayout();
            this.gbAction.ResumeLayout(false);
            this.gbPencarian.ResumeLayout(false);
            this.gbPencarian.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbTabel;
        private System.Windows.Forms.GroupBox gbForm;
        private System.Windows.Forms.GroupBox gbAction;
        private System.Windows.Forms.Label labelHP;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelAlamat;
        private System.Windows.Forms.Label labelAngkatan;
        private System.Windows.Forms.Label labelNama;
        private System.Windows.Forms.Label labelNPM;
        private System.Windows.Forms.TextBox textBoxHP;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxAlamat;
        private System.Windows.Forms.TextBox textBoxNama;
        private System.Windows.Forms.TextBox textBoxNPM;
        private System.Windows.Forms.ComboBox comboBoxAngkatan;
        private System.Windows.Forms.DataGridView dataMahasiswa;
        private System.Windows.Forms.Button buttonRubah;
        private System.Windows.Forms.Button buttonHapus;
        private System.Windows.Forms.Button buttonSimpan;
        private System.Windows.Forms.Button buttonRefresh;
        private GroupBox gbPencarian;
        private Label cariData;
        private TextBox textBoxPencarian;
    }
}
