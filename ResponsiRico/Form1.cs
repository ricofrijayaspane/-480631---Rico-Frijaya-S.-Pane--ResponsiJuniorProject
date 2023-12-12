
using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ResponsiRico
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        private NpgsqlConnection conn;
        string connstring = "Host=localhost;Port=5432;Username=postgres;Password=informatika;Database=responsi-rico";
        public DataTable dt;
        public static NpgsqlCommand cmd;
        private string sql = null;
        private DataGridViewRow r;

        private void Form1_Load(object sender, EventArgs e)
        {
            conn = new NpgsqlConnection(connstring);

        }

        private void btnLoadData_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                dgvData.DataSource = null;
                sql = "select * from users_select()";
                cmd = new NpgsqlCommand(sql, conn);
                dt = new DataTable();
                NpgsqlDataReader dr = cmd.ExecuteReader();
                dt.Load(dr);
                dgvData.DataSource = dt;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message, "FAILL!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                sql = @"select * from users_insert(@_nama, @_id_dep)";
                cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@_nama", txtNama.Text);
                cmd.Parameters.AddWithValue("@_id_dep", txtDep.Text);
                if ((int)cmd.ExecuteScalar() == 1) ;
                {
                    MessageBox.Show("Data Karyawan Berhasil diinputkan", "Well Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    conn.Close();
                    btnLoadData.PerformClick();
                    txtNama.Text = txtDep.Text = null;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message, "FAILL!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void dgvData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                r = dgvData.Rows[e.RowIndex];
                txtNama.Text = r.Cells["_nama"].Value.ToString();
                txtDep.Text = r.Cells["_id_dep"].Value.ToString();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (r == null)
            {
                MessageBox.Show("Mohon pilih baris data yang ingin diedit", "Good!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            try
            {
                conn.Open();
                sql = @"select * from users_update(:_id_karyawan,:_nama,:_id_dep)";
                cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("_id_karyawan", r.Cells["_id_karyawan"].Value.ToString());
                cmd.Parameters.AddWithValue("_nama", txtNama.Text);
                cmd.Parameters.AddWithValue("_id_dep", txtDep.Text);
                if ((int)cmd.ExecuteScalar() == 1)
                {
                    MessageBox.Show("Data Karyawan Berhasil diedit", "Well Done!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    conn.Close();
                    btnLoadData.PerformClick();
                    txtNama.Text = txtDep.Text = null;
                    r = null;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message, "Edit FAILL!!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (r == null)
            {
                MessageBox.Show("Mohon pilih baris data yang ingin dihapus", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Apakah benar anda ingin menghapus data" + r.Cells["_nama"].Value.ToString() + "?", "Hapus data terkonfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                try
                {
                    conn.Open();
                    sql = @"select * from users_delete(:_id_karyawan)";
                    cmd = new NpgsqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("_id_karyawan", r.Cells["_id_karyawan"].Value.ToString());
                    if ((int)cmd.ExecuteScalar() == 1)
                    {
                        MessageBox.Show("Data Karyawan Berhasil dihapus", "Well Done!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        conn.Close();
                        btnLoadData.PerformClick();
                        txtNama.Text = txtDep.Text = null;
                        r = null;
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error:" + ex.Message, "Delete FAILL!!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

        }
    }
}
