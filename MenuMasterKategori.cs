using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyekACS
{
    public partial class MenuMasterKategori : Form
    {
        string username;
        string editID;
        public MenuMasterKategori(string username)
        {
            this.username = username;
            InitializeComponent();
            txtWelcome.Text = "Selamat datang, " + username + "!";
        }

        private void MenuMasterKategori_Load(object sender, EventArgs e)
        {
            refreshDGV();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Loginkaryawan f = new Loginkaryawan();
            this.Hide();
            f.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Homekaryawan h = new Homekaryawan(username);
            this.Hide();
            h.ShowDialog();
        }

        void refreshDGV()
        {
            dgvMaster.Columns.Clear();
            SqlCommand cmd = new SqlCommand("SELECT k.idKategori, k.namaKategori, COUNT(l.namaLayanan) AS 'Jumlah Layanan' FROM Kategori k JOIN Layanan l ON l.idKategori = k.idKategori where k.namaKategori like '%" + txtSearch.Text + "%' and k.status = 1 GROUP BY k.idKategori, k.namaKategori ", DB.conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dtTable = new DataTable();
            adapter.Fill(dtTable);

            dgvMaster.DataSource = null;
            dgvMaster.DataSource = dtTable;

            DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn();
            buttonColumn.Name = "btnEdit";
            buttonColumn.HeaderText = "Edit";
            buttonColumn.Text = "Edit";
            buttonColumn.UseColumnTextForButtonValue = true;
            dgvMaster.Columns.Add(buttonColumn);
            buttonColumn = new DataGridViewButtonColumn();
            buttonColumn.Name = "btnDelete";
            buttonColumn.HeaderText = "Delete";
            buttonColumn.Text = "Delete";
            buttonColumn.UseColumnTextForButtonValue = true;
            dgvMaster.Columns.Add(buttonColumn);

            dgvMaster.Columns["idKategori"].Visible = false;
        }

        void clearForm()
        {
            txtNama.Text = "";
            btnCancel.Enabled = false;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            refreshDGV();
        }

        private void dgvMaster_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvMaster.Columns["btnEdit"].Index && e.RowIndex >= 0)
            {
                DataGridViewRow data = dgvMaster.Rows[e.RowIndex];
                txtNama.Text = data.Cells["namaKategori"].Value.ToString();

                editID = dgvMaster.Rows[e.RowIndex].Cells["idKategori"].Value.ToString();
                btnCancel.Enabled = true;
            }
            else if (e.ColumnIndex == dgvMaster.Columns["btnDelete"].Index && e.RowIndex >= 0)
            {
                DialogResult confirmation = MessageBox.Show("Apakah anda yakin ingin menghapus?", "Confirmation", MessageBoxButtons.YesNo);
                if (confirmation == DialogResult.Yes)
                {
                    SqlCommand cmd = new SqlCommand("UPDATE Kategori set status = 0 where idKategori = @id", DB.conn);
                    cmd.Parameters.Add(new SqlParameter("@id", dgvMaster.Rows[e.RowIndex].Cells["idKategori"].Value.ToString()));
                    DB.openConnection();
                    cmd.ExecuteNonQuery();
                    DB.closeConnection();
                }
                refreshDGV();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            clearForm();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtNama.Text.Length > 0)
            {
                if (btnCancel.Enabled)
                {
                    SqlCommand cmd = new SqlCommand("UPDATE Kategori set namaKategori = @nama where idKategori = @id", DB.conn);
                    cmd.Parameters.Add(new SqlParameter("@nama", txtNama.Text));
                    cmd.Parameters.Add(new SqlParameter("@id", editID));
                    DB.openConnection();
                    cmd.ExecuteNonQuery();
                    DB.closeConnection();
                }
                else
                {
                    DB.openConnection();
                    SqlCommand cmd = new SqlCommand("INSERT INTO Kategori (namaKategori,status) values (@nama,1)", DB.conn);
                    cmd.Parameters.Add(new SqlParameter("@nama", txtNama.Text));
                    cmd.ExecuteNonQuery();
                    DB.closeConnection();
                }
            }
            refreshDGV();
            clearForm();
        }
    }
}
