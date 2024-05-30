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
            txtSubtotal.Text = "Subtotal Layanan: Rp."+ cmd.ExecuteScalar().ToString();
            cmd = new SqlCommand("select sum(a.harga) from Daddon da join Addons a on a.idAddon = da.idAddon join Dtrans dt on dt.id = da.dtransid where dt.nourut = @nourut", DB.conn);
            cmd.Parameters.Add(new SqlParameter("@nourut", nourut));
            txtAddons.Text = "Subtotal Add Ons: Rp." + cmd.ExecuteScalar().ToString();
            DB.closeConnection();
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
            Loginkaryawan f = new Loginkaryawan();
            this.Hide();
            f.ShowDialog();
        }
    }
}
