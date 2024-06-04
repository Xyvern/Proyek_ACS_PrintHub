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
    public partial class Homekaryawan : Form
    {
        string username;
        string nourut;
        public Homekaryawan(string username)
        {
            this.username = username;
            InitializeComponent();
            txtWelcome.Text = "Selamat datang, " + username + "!";
        }

        private void Homekaryawan_Load(object sender, EventArgs e)
        {
            loadDGV();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MenuMaster h = new MenuMaster(username);
            this.Hide();
            h.ShowDialog();
        }

        void loadDGV()
        {
            dgvNota.Columns.Clear();
            SqlCommand cmd = new SqlCommand("select nourut from Htrans where status = 1", DB.conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dtTable = new DataTable();
            adapter.Fill(dtTable);

            dgvNota.DataSource = null;
            dgvNota.DataSource = dtTable;
        }
        void refreshNota(string nourut)
        {
            dgvDetail.Columns.Clear();
            SqlCommand cmd = new SqlCommand("select dt.id, l.namaLayanan,k.namaKategori,l.harga from dtrans dt join layanan l on l.idlayanan = dt.idlayanan join Kategori k on k.idKategori = l.idKategori where dt.nourut = @nourut", DB.conn);
            cmd.Parameters.Add(new SqlParameter("@nourut", nourut));
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dtTable = new DataTable();
            adapter.Fill(dtTable);

            dgvDetail.DataSource = null;
            dgvDetail.DataSource = dtTable;
            dgvDetail.Columns["id"].Visible = false;

            DB.openConnection();
            cmd = new SqlCommand("select sum(l.harga) from Dtrans dt join Layanan l on l.idLayanan = dt.idLayanan where dt.nourut = @nourut", DB.conn);
            cmd.Parameters.Add(new SqlParameter("@nourut", nourut));
            int subtotal = Convert.ToInt32(cmd.ExecuteScalar().ToString());
            cmd = new SqlCommand("SELECT COALESCE(SUM(a.harga), 0) FROM Daddon da JOIN Addons a ON a.idAddon = da.idAddon JOIN Dtrans dt ON dt.id = da.dtransid WHERE dt.nourut = @nourut;", DB.conn);
            cmd.Parameters.Add(new SqlParameter("@nourut", nourut));
            int addons = Convert.ToInt32(cmd.ExecuteScalar().ToString());
            cmd = new SqlCommand("select total from htrans where nourut = @nourut", DB.conn);
            cmd.Parameters.Add(new SqlParameter("@nourut", nourut));
            int grandtotal = Convert.ToInt32(cmd.ExecuteScalar().ToString());
            DB.closeConnection();

            txtNota.Text = "Nomor Urut: " + nourut;
            this.nourut = nourut;
            btnAccept.Enabled = true;
            txtSubtotal.Text = "Subtotal Layanan: Rp." + subtotal.ToString();
            txtAddons.Text = "Subtotal Add Ons: Rp." + addons.ToString();
            txtGrandtotal.Text = "Grandotal: Rp." + grandtotal.ToString();
        }

        void refreshAddons(string dtransid)
        {
            dgvAddon.Columns.Clear();
            SqlCommand cmd = new SqlCommand("select a.namaAddon,a.harga from Daddon da join Addons a on a.idAddon = da.idAddon where da.dtransid = @dtransid", DB.conn);
            cmd.Parameters.Add(new SqlParameter("@dtransid", dtransid));
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dtTable = new DataTable();
            adapter.Fill(dtTable);

            dgvAddon.DataSource = null;
            dgvAddon.DataSource = dtTable;
        }
        void clearDGV()
        {
            dgvAddon.Columns.Clear();
            dgvDetail.Columns.Clear();
            txtNota.Text = "Nomor Urut: ";
            txtAddons.Text = "Subtotal Add Ons: ";
            txtGrandtotal.Text = "Grandtotal: ";
            txtSubtotal.Text = "Subtotal Layanan: ";
            btnAccept.Enabled = false;
        }

        private void dgvNota_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            refreshNota(dgvNota.Rows[e.RowIndex].Cells["nourut"].Value.ToString());
        }

        private void dgvDetail_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            refreshAddons(dgvDetail.Rows[e.RowIndex].Cells["id"].Value.ToString());
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

        private void btnAccept_Click(object sender, EventArgs e)
        {
            DB.openConnection();
            SqlCommand cmd = new SqlCommand("update htrans set status = 2, karyawan = @username where nourut = @nourut", DB.conn);
            cmd.Parameters.Add(new SqlParameter("@nourut", nourut));
            cmd.Parameters.Add(new SqlParameter("@username", username));
            cmd.ExecuteScalar();
            DB.closeConnection();
            loadDGV();
            clearDGV();
            MessageBox.Show("Berhasil menyelesaikan transaksi");
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            History h = new History();
            h.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult confirmation = MessageBox.Show("Aksi ini akan menghapus semua nota yang tidak valid dan tidak dapat dikembalikan. Apakah anda yakin ingin menghapus?", "Confirmation", MessageBoxButtons.YesNo);
            if (confirmation == DialogResult.Yes)
            {
                DB.openConnection();
                SqlCommand cmd = new SqlCommand("delete from Daddon where Daddon.dtransid in (select da.dtransid from Daddon da where da.dtransid in (select dt.id from Dtrans dt where dt.nourut in (select ht.nourut from Htrans ht where status = 0)))", DB.conn);
                cmd.ExecuteNonQuery();
                cmd = new SqlCommand("delete from Dtrans where Dtrans.nourut in (select ht.nourut from Htrans ht where status = 0)", DB.conn);
                cmd.ExecuteNonQuery();
                cmd = new SqlCommand("delete from Htrans where status = 0", DB.conn);
                cmd.ExecuteNonQuery();
                DB.closeConnection();
                MessageBox.Show("Berhasil menghapus nota tidak valid.");
            }
        }
    }
}
