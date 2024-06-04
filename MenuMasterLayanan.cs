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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProyekACS
{
    public partial class MenuMasterLayanan : Form
    {
        string username;
        string editID;
        public MenuMasterLayanan(string username)
        {
            this.username = username;
            InitializeComponent();
            txtWelcome.Text = "Selamat datang, " + username + "!";
        }

        private void MenuMasterLayanan_Load(object sender, EventArgs e)
        {
            refreshDGV();

            SqlCommand cmd = new SqlCommand("select * from kategori where status = 1", DB.conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dtTable = new DataTable();
            adapter.Fill(dtTable);

            cbKategori.DataSource = null;
            cbKategori.DataSource = dtTable;
            cbKategori.DisplayMember = "namaKategori";
            cbKategori.ValueMember = "idKategori";
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult confirmation = MessageBox.Show("Apakah anda yakin ingin logout?", "Confirmation", MessageBoxButtons.YesNo);
            if (confirmation == DialogResult.Yes)
            {
                Loginkaryawan f = new Loginkaryawan();
                this.Hide();
                f.ShowDialog();
            }
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
            SqlCommand cmd = new SqlCommand("select l.idLayanan, l.namaLayanan, k.namaKategori, l.deskripsi, l.harga, l.idKategori from Layanan l join Kategori k on k.idKategori = l.idKategori where namaLayanan like '%" + txtSearch.Text + "%' and l.status = 1", DB.conn);
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

            dgvMaster.Columns["idLayanan"].Visible = false;
            dgvMaster.Columns["idKategori"].Visible = false;
        }

        void clearForm()
        {
            txtNama.Text = "";
            txtDes.Text = "";
            nmHarga.Value = nmHarga.Minimum;
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
                txtNama.Text = data.Cells["namaLayanan"].Value.ToString();
                nmHarga.Value = Convert.ToInt32(data.Cells["harga"].Value.ToString());
                txtDes.Text = data.Cells["deskripsi"].Value.ToString();
                cbKategori.Text = data.Cells["namaKategori"].Value.ToString();
                
                editID = dgvMaster.Rows[e.RowIndex].Cells["idLayanan"].Value.ToString();
                btnCancel.Enabled = true;
            }
            else if (e.ColumnIndex == dgvMaster.Columns["btnDelete"].Index && e.RowIndex >= 0)
            {
                DialogResult confirmation = MessageBox.Show("Apakah anda yakin ingin menghapus?", "Confirmation", MessageBoxButtons.YesNo);
                if (confirmation == DialogResult.Yes)
                {
                    SqlCommand cmd = new SqlCommand("UPDATE Layanan set status = 0 where idLayanan = @id", DB.conn);
                    cmd.Parameters.Add(new SqlParameter("@id", dgvMaster.Rows[e.RowIndex].Cells["idLayanan"].Value.ToString()));
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
            if (txtNama.Text.Length > 0 && nmHarga.Value > 0 && txtDes.Text.Length > 0)
            {
                if (btnCancel.Enabled)
                {
                    SqlCommand cmd = new SqlCommand("UPDATE Layanan set namaLayanan = @nama, Deskripsi = @des, harga = @harga, idKategori = @idkat where idLayanan = @id", DB.conn);
                    cmd.Parameters.Add(new SqlParameter("@nama", txtNama.Text));
                    cmd.Parameters.Add(new SqlParameter("@harga", nmHarga.Value));
                    cmd.Parameters.Add(new SqlParameter("@des", txtDes.Text));
                    cmd.Parameters.Add(new SqlParameter("@id", editID));
                    cmd.Parameters.Add(new SqlParameter("@idKat", cbKategori.SelectedValue.ToString()));
                    DB.openConnection();
                    cmd.ExecuteNonQuery();
                    DB.closeConnection();
                }
                else
                {
                    DB.openConnection();
                    SqlCommand cmd = new SqlCommand("INSERT INTO Layanan (namaLayanan,deskripsi,harga,status,idKategori) values (@nama,@des,@harga,1,@id)", DB.conn);
                    cmd.Parameters.Add(new SqlParameter("@nama", txtNama.Text));
                    cmd.Parameters.Add(new SqlParameter("@harga", nmHarga.Value));
                    cmd.Parameters.Add(new SqlParameter("@des", txtDes.Text));
                    cmd.Parameters.Add(new SqlParameter("@id", cbKategori.SelectedValue.ToString()));
                    cmd.ExecuteNonQuery();
                    DB.closeConnection();
                }
            }
            refreshDGV();
            clearForm();
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            MenuMaster m = new MenuMaster(username);
            this.Hide();
            m.ShowDialog();
        }

        private void btnAddon_Click(object sender, EventArgs e)
        {
            MenuMasterAddon m = new MenuMasterAddon(username);
            this.Hide();
            m.ShowDialog();
        }

        private void btnKategori_Click(object sender, EventArgs e)
        {
            MenuMasterKategori m = new MenuMasterKategori(username);
            this.Hide();
            m.ShowDialog();
        }

        private void btnKaryawan_Click(object sender, EventArgs e)
        {
            MenuMasterKaryawan m = new MenuMasterKaryawan(username);
            this.Hide();
            m.ShowDialog();
        }
    }
}
