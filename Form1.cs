using System;
using System.Data;
using System.Globalization;
using System.Windows.Forms;
using System.Data.SQLite;

namespace Ulangan.walahi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Panggil fungsi bikin database
            BuatDatabase();

            // Tambahin daftar mapel ke ComboBox
            comboBoxListTugas.Items.Add("Matematika");
            comboBoxListTugas.Items.Add("Bahasa Indonesia");
            comboBoxListTugas.Items.Add("Bahasa Jawa");
            comboBoxListTugas.Items.Add("Bk");
            comboBoxListTugas.Items.Add("Bahasa Inggris");
            comboBoxListTugas.Items.Add("KIK-A");
            comboBoxListTugas.Items.Add("KIK-B");
            comboBoxListTugas.Items.Add("MK1-A");
            comboBoxListTugas.Items.Add("MK2-B");
            comboBoxListTugas.Items.Add("MK3-A");
            comboBoxListTugas.Items.Add("MK4-A");
            comboBoxListTugas.Items.Add("MP1-A");
            comboBoxListTugas.Items.Add("PJOK");
            comboBoxListTugas.Items.Add("MK4-A");
            comboBoxListTugas.Items.Add("Sejarah");

            // Tambahin kolom ke DataGridView
            dataGridViewTugas.Columns.Add("Mapel", "Mapel");
            dataGridViewTugas.Columns.Add("Deskripsi", "Deskripsi");
            dataGridViewTugas.Columns.Add("Deadline", "Deadline");
            dataGridViewTugas.Columns.Add("Status", "Status");

            // Load data dari database
            LoadData();
        }

        // Tombol Accept = tambah tugas baru
        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (comboBoxListTugas.SelectedItem == null || string.IsNullOrWhiteSpace(txtDeskripsi.Text))
            {
                MessageBox.Show("Pilih mapel dan isi deskripsi tugas dulu!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string mapel = comboBoxListTugas.SelectedItem.ToString();
            string deskripsi = txtDeskripsi.Text;
            string deadline = dateDeadline.Value.ToShortDateString();
            string status = "Belum Selesai";

            // Tambah ke DataGridView
            dataGridViewTugas.Rows.Add(mapel, deskripsi, deadline, status);

            // Tambah ke database SQLite
            using (var conn = new SQLiteConnection("Data Source=tugas.db;Version=3;"))
            {
                conn.Open();
                string sql = "INSERT INTO Tugas (Mapel, Deskripsi, Deadline, Status) VALUES (@mapel, @deskripsi, @deadline, @status)";
                using (var cmd = new SQLiteCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@mapel", mapel);
                    cmd.Parameters.AddWithValue("@deskripsi", deskripsi);
                    cmd.Parameters.AddWithValue("@deadline", deadline);
                    cmd.Parameters.AddWithValue("@status", status);
                    cmd.ExecuteNonQuery();
                }
            }

            // Reset input
            comboBoxListTugas.SelectedIndex = -1;
            txtDeskripsi.Clear();
        }

        // Tombol Cancel = hapus tugas
        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (dataGridViewTugas.CurrentRow != null)
            {
                string deskripsi = dataGridViewTugas.CurrentRow.Cells["Deskripsi"].Value.ToString();

                // Hapus dari database
                using (var conn = new SQLiteConnection("Data Source=tugas.db;Version=3;"))
                {
                    conn.Open();
                    string sql = "DELETE FROM Tugas WHERE Deskripsi = @deskripsi";
                    using (var cmd = new SQLiteCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@deskripsi", deskripsi);
                        cmd.ExecuteNonQuery();
                    }
                }

                // Hapus dari DataGridView
                dataGridViewTugas.Rows.Remove(dataGridViewTugas.CurrentRow);
            }
            else
            {
                MessageBox.Show("Pilih tugas yang mau dihapus.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // Tombol Done = ubah status jadi selesai
        private void btnDone_Click(object sender, EventArgs e)
        {
            if (dataGridViewTugas.CurrentRow != null)
            {
                string deskripsi = dataGridViewTugas.CurrentRow.Cells["Deskripsi"].Value.ToString();

                // Update database
                using (var conn = new SQLiteConnection("Data Source=tugas.db;Version=3;"))
                {
                    conn.Open();
                    string sql = "UPDATE Tugas SET Status = 'Selesai ✅' WHERE Deskripsi = @deskripsi";
                    using (var cmd = new SQLiteCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@deskripsi", deskripsi);
                        cmd.ExecuteNonQuery();
                    }
                }

                // Update DataGridView
                dataGridViewTugas.CurrentRow.Cells["Status"].Value = "Selesai ✅";

                MessageBox.Show("Tugas sudah ditandai selesai!", "Notifikasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Pilih tugas dulu yang mau ditandai selesai.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Fungsi bikin database
        private void BuatDatabase()
        {
            if (!System.IO.File.Exists("tugas.db"))
            {
                SQLiteConnection.CreateFile("tugas.db");

                using (var conn = new SQLiteConnection("Data Source=tugas.db;Version=3;"))
                {
                    conn.Open();
                    string sql = @"CREATE TABLE Tugas (
                                Id INTEGER PRIMARY KEY AUTOINCREMENT,
                                Mapel TEXT,
                                Deskripsi TEXT,
                                Deadline TEXT,
                                Status TEXT)";
                    SQLiteCommand cmd = new SQLiteCommand(sql, conn);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        // Load data dari database ke DataGridView
        private void LoadData()
        {
            dataGridViewTugas.Rows.Clear();

            using (var conn = new SQLiteConnection("Data Source=tugas.db;Version=3;"))
            {
                conn.Open();
                string sql = "SELECT Mapel, Deskripsi, Deadline, Status FROM Tugas";
                using (var cmd = new SQLiteCommand(sql, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        dataGridViewTugas.Rows.Add(
                            reader["Mapel"].ToString(),
                            reader["Deskripsi"].ToString(),
                            reader["Deadline"].ToString(),
                            reader["Status"].ToString()
                        );
                    }
                }
            }
        }
    }
}
