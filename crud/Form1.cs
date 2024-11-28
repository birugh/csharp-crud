using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace crud
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-GC4N26G\SQLEXPRESS;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False");
        SqlCommand cmd;
        SqlDataReader read;
        SqlDataAdapter drr;
        bool mood = true;
        string sql;

        private void Form1_Load(object sender, EventArgs e)
        {
            displayData();
        }

        private void displayData()
        {
            SqlCommand cmd = new SqlCommand("select * from Siswa", conn);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView.DataSource = dt;
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            String Id = txtNomorInduk.Text;
            String Nama = txtNama.Text;
            String JK = cboxJenisKelamin.Text;
            String Kelas = cboxKelas.Text;
            String TglLahir = dateTimePicker.Value.ToString("yyyy-MM-dd");
            String Alamat = txtAlamat.Text;

            if (mood)
            {
                SqlCommand cmd = new SqlCommand($"insert into siswa(id, nama, jenisKelamin, kelas, tanggalLahir)values" + $"('{Id}', '{Nama}', '{JK}', '{Alamat}', '{TglLahir}')", conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Data berhasil di catat");
                displayData();
            }
            else
            {
                MessageBox.Show("Data Tidak Terdaftar");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            String Id = txtNomorInduk.Text;
            String Nama = txtNama.Text;
            String JK = cboxJenisKelamin.Text;
            String Kelas = cboxKelas.Text;
            DateTime TglLahir = dateTimePicker.Value;
            String Alamat = txtAlamat.Text;

            if (mood)
            {
                SqlCommand cmd = new SqlCommand($"update Siswa set nama = '{Nama}', jenisKelamin =  '{JK}', " + $"kelas = '{Kelas}', alamat='{Alamat}', tanggalLahir='{TglLahir}' where id = '{Id}'", conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Data terupdate");
                displayData();
            }
            else
            {
                MessageBox.Show("Data tidak terupdate");
            }
        }
        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Yakin ingin menghapus data ini?", "Information Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                String Id = txtNomorInduk.Text;
                SqlCommand cmd = new SqlCommand($"delete from Siswa where Id = '{Id}'", conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Berhasil menghapus data");
                displayData();

            }
            else
            {
                MessageBox.Show("Gagal menghapus data");
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtNomorInduk.Text = "";
            txtNama.Text = "";
            txtAlamat.Text = "";
            txtCari.Text = "";
            cboxJenisKelamin.SelectedIndex = -1;
            cboxKelas.SelectedIndex = -1;
        }

        private void btnCari_Click(object sender, EventArgs e)
        {
            string id = txtCari.Text.ToString();
            findById(id);
        }

        public void findById(string id)
        {
            SqlDataAdapter sda = new SqlDataAdapter($"select * from Siswa where concat" + $"(id, nama, kelas, alamat, tanggalLahir) like '%{id}%'", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView.DataSource = dt;
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("Data yang anda cari tidak ada");
            }
        }
    }
}
