namespace crud_siswa
{
    partial class Crud
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
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnHapus = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnTambah = new System.Windows.Forms.Button();
            this.txtCari = new System.Windows.Forms.TextBox();
            this.cboxKelas = new System.Windows.Forms.ComboBox();
            this.txtAlamat = new System.Windows.Forms.TextBox();
            this.txtNama = new System.Windows.Forms.TextBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.cboxJenisKelamin = new System.Windows.Forms.ComboBox();
            this.btnCari = new System.Windows.Forms.Button();
            this.txtNomorInduk = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(321, 57);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(201, 25);
            this.label7.TabIndex = 39;
            this.label7.Text = "CRUD Data Siswa";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(423, 213);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 13);
            this.label6.TabIndex = 38;
            this.label6.Text = "Tanggal Lahir";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(423, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 37;
            this.label5.Text = "Alamat";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(423, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 36;
            this.label4.Text = "Kelas";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(71, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 35;
            this.label3.Text = "Jenis Kelamin";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 34;
            this.label2.Text = "Nama";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(370, 294);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 33;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click_1);
            // 
            // btnHapus
            // 
            this.btnHapus.Location = new System.Drawing.Point(269, 294);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(75, 23);
            this.btnHapus.TabIndex = 32;
            this.btnHapus.Text = "Hapus";
            this.btnHapus.UseVisualStyleBackColor = true;
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click_1);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(167, 294);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 31;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click_1);
            // 
            // btnTambah
            // 
            this.btnTambah.Location = new System.Drawing.Point(74, 294);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(75, 23);
            this.btnTambah.TabIndex = 30;
            this.btnTambah.Text = "Tambah";
            this.btnTambah.UseVisualStyleBackColor = true;
            this.btnTambah.Click += new System.EventHandler(this.btnTambah_Click_1);
            // 
            // txtCari
            // 
            this.txtCari.Location = new System.Drawing.Point(536, 297);
            this.txtCari.Name = "txtCari";
            this.txtCari.Size = new System.Drawing.Size(151, 20);
            this.txtCari.TabIndex = 29;
            // 
            // cboxKelas
            // 
            this.cboxKelas.FormattingEnabled = true;
            this.cboxKelas.Items.AddRange(new object[] {
            "X",
            "XI",
            "XII"});
            this.cboxKelas.Location = new System.Drawing.Point(512, 120);
            this.cboxKelas.Name = "cboxKelas";
            this.cboxKelas.Size = new System.Drawing.Size(256, 21);
            this.cboxKelas.TabIndex = 28;
            // 
            // txtAlamat
            // 
            this.txtAlamat.Location = new System.Drawing.Point(512, 165);
            this.txtAlamat.Name = "txtAlamat";
            this.txtAlamat.Size = new System.Drawing.Size(256, 20);
            this.txtAlamat.TabIndex = 27;
            // 
            // txtNama
            // 
            this.txtNama.Location = new System.Drawing.Point(157, 162);
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(220, 20);
            this.txtNama.TabIndex = 26;
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(74, 335);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.Size = new System.Drawing.Size(694, 410);
            this.dataGridView.TabIndex = 25;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(512, 211);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(256, 20);
            this.dateTimePicker.TabIndex = 24;
            // 
            // cboxJenisKelamin
            // 
            this.cboxJenisKelamin.FormattingEnabled = true;
            this.cboxJenisKelamin.Items.AddRange(new object[] {
            "Laki - laki",
            "Perempuan"});
            this.cboxJenisKelamin.Location = new System.Drawing.Point(157, 207);
            this.cboxJenisKelamin.Name = "cboxJenisKelamin";
            this.cboxJenisKelamin.Size = new System.Drawing.Size(220, 21);
            this.cboxJenisKelamin.TabIndex = 23;
            // 
            // btnCari
            // 
            this.btnCari.Location = new System.Drawing.Point(693, 294);
            this.btnCari.Name = "btnCari";
            this.btnCari.Size = new System.Drawing.Size(75, 23);
            this.btnCari.TabIndex = 22;
            this.btnCari.Text = "Cari";
            this.btnCari.UseVisualStyleBackColor = true;
            this.btnCari.Click += new System.EventHandler(this.btnCari_Click_1);
            // 
            // txtNomorInduk
            // 
            this.txtNomorInduk.Enabled = false;
            this.txtNomorInduk.Location = new System.Drawing.Point(157, 120);
            this.txtNomorInduk.Name = "txtNomorInduk";
            this.txtNomorInduk.Size = new System.Drawing.Size(220, 20);
            this.txtNomorInduk.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Nomor Induk";
            // 
            // Crud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 802);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnHapus);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnTambah);
            this.Controls.Add(this.txtCari);
            this.Controls.Add(this.cboxKelas);
            this.Controls.Add(this.txtAlamat);
            this.Controls.Add(this.txtNama);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.cboxJenisKelamin);
            this.Controls.Add(this.btnCari);
            this.Controls.Add(this.txtNomorInduk);
            this.Controls.Add(this.label1);
            this.Name = "Crud";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnTambah;
        private System.Windows.Forms.TextBox txtCari;
        private System.Windows.Forms.ComboBox cboxKelas;
        private System.Windows.Forms.TextBox txtAlamat;
        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.ComboBox cboxJenisKelamin;
        private System.Windows.Forms.Button btnCari;
        private System.Windows.Forms.TextBox txtNomorInduk;
        private System.Windows.Forms.Label label1;
    }
}

