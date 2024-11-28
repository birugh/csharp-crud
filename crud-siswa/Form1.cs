using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace crud_siswa
{
    public partial class Crud : Form
    {
        public Crud()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-GC4N26G\SQLEXPRESS;Initial Catalog=db_crud;Integrated Security=True;");

        private void Form1_Load(object sender, EventArgs e)
        {
            DisplayData();
        }
        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(txtNama.Text) ||
                string.IsNullOrWhiteSpace(cboxJenisKelamin.Text) ||
                string.IsNullOrWhiteSpace(cboxKelas.Text) ||
                string.IsNullOrWhiteSpace(txtAlamat.Text) ||
                dateTimePicker.Value == null)
            {
                MessageBox.Show("Silakan lengkapi semua data terlebih dahulu.", "Validasi Data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void DisplayData()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM Siswa", conn);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void FindById(string id)
        {
            try
            {
                SqlCommand cmd = new SqlCommand($"SELECT * FROM Siswa WHERE CONCAT(id, nama, kelas, alamat, tanggalLahir) LIKE '%{id}%'", conn);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    txtNomorInduk.Text = dt.Rows[0]["id"].ToString();
                    txtNama.Text = dt.Rows[0]["nama"].ToString();
                    cboxJenisKelamin.Text = dt.Rows[0]["jenisKelamin"].ToString();
                    cboxKelas.Text = dt.Rows[0]["kelas"].ToString();
                    txtAlamat.Text = dt.Rows[0]["alamat"].ToString();
                    dateTimePicker.Value = Convert.ToDateTime(dt.Rows[0]["tanggalLahir"]);
                }
                else
                {
                    MessageBox.Show("Data yang Anda cari tidak ditemukan.", "Pemberitahuan", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTambah_Click_1(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                try
                {
                    string query = "INSERT INTO Siswa (nama, jenisKelamin, kelas, alamat, tanggalLahir) VALUES (@nama, @jenisKelamin, @kelas, @alamat, @tanggalLahir)";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@nama", txtNama.Text);
                    cmd.Parameters.AddWithValue("@jenisKelamin", cboxJenisKelamin.Text);
                    cmd.Parameters.AddWithValue("@kelas", cboxKelas.Text);
                    cmd.Parameters.AddWithValue("@alamat", txtAlamat.Text);
                    cmd.Parameters.AddWithValue("@tanggalLahir", dateTimePicker.Value.ToString("yyyy-MM-dd"));

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();

                    MessageBox.Show("Data berhasil ditambahkan.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DisplayData();
                    ResetForm();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                try
                {
                    string query = "UPDATE Siswa SET nama = @nama, jenisKelamin = @jenisKelamin, kelas = @kelas, alamat = @alamat, tanggalLahir = @tanggalLahir WHERE id = @id";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id", txtNomorInduk.Text);
                    cmd.Parameters.AddWithValue("@nama", txtNama.Text);
                    cmd.Parameters.AddWithValue("@jenisKelamin", cboxJenisKelamin.Text);
                    cmd.Parameters.AddWithValue("@kelas", cboxKelas.Text);
                    cmd.Parameters.AddWithValue("@alamat", txtAlamat.Text);
                    cmd.Parameters.AddWithValue("@tanggalLahir", dateTimePicker.Value.ToString("yyyy-MM-dd"));

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();

                    MessageBox.Show("Data berhasil diperbarui.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DisplayData();
                    ResetForm();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnHapus_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Apakah Anda yakin ingin menghapus data ini?", "Konfirmasi Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    string query = "DELETE FROM Siswa WHERE id = @id";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id", txtNomorInduk.Text);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();

                    MessageBox.Show("Data berhasil dihapus.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DisplayData();
                    ResetForm();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnReset_Click_1(object sender, EventArgs e)
        {
            ResetForm();
        }
        private void ResetForm()
        {
            txtNomorInduk.Clear();
            txtNama.Clear();
            txtAlamat.Clear();
            txtCari.Clear();
            cboxJenisKelamin.SelectedIndex = -1;
            cboxKelas.SelectedIndex = -1;
            dateTimePicker.Value = DateTime.Now;
        }

        private void btnCari_Click_1(object sender, EventArgs e)
        {
            string id = txtCari.Text;
            if (!string.IsNullOrWhiteSpace(id))
            {
                FindById(id);
            }
            else
            {
                MessageBox.Show("Masukkan ID untuk mencari data.", "Pemberitahuan", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
