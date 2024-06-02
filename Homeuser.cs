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
    public partial class Homeuser : Form
    {
        string username;
        int nourut;
        public Homeuser(string username)
        {
            InitializeComponent();
            this.username = username;
        }

        private void Homeuser_Load(object sender, EventArgs e)
        {
            this.nourut = createNota();
            txtWelcome.Text = "Welcome, " + username + "("+this.nourut.ToString()+")";
            loadMaster();

            SqlCommand cmd = new SqlCommand("select * from kategori where status = 1", DB.conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dtTable = new DataTable();
            adapter.Fill(dtTable);

            DataRow newRow = dtTable.NewRow();
            newRow["idKategori"] = -1;
            newRow["namaKategori"] = "All";
            dtTable.Rows.InsertAt(newRow, 0);

            cbKategori.DataSource = null;
            cbKategori.DataSource = dtTable;
            cbKategori.DisplayMember = "namaKategori";
            cbKategori.ValueMember = "idKategori";

            dgvAddons.Columns.Clear();
            cmd = new SqlCommand("SELECT l.namaLayanan, a.namaAddon, a.harga FROM Daddon da join Dtrans dt on dt.id = da.dtransid join Addons a on a.idAddon = da.idAddon join Layanan l on l.idLayanan = dt.idLayanan where dt.nourut = @nourut", DB.conn);
            cmd.Parameters.Add(new SqlParameter("@nourut", this.nourut));
            adapter = new SqlDataAdapter(cmd);
            DataTable dtProduk = new DataTable();
            adapter.Fill(dtProduk);

            dgvAddons.DataSource = null;
            dgvAddons.DataSource = dtProduk;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            this.Hide();
            f.ShowDialog();
        }

        private void dgvLayanan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtDeskripsi.Text = dgvLayanan.Rows[e.RowIndex].Cells["deskripsi"].Value.ToString();
            }
        }

        private void dgvLayanan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvLayanan.Columns["Action"].Index && e.RowIndex >= 0)
            {
                DB.openConnection();
                SqlCommand cmd = new SqlCommand("insert into dtrans (nourut,idlayanan) values(@nourut,@idlayanan)",DB.conn);
                cmd.Parameters.Add(new SqlParameter("@nourut", this.nourut));
                cmd.Parameters.Add(new SqlParameter("@idlayanan", dgvLayanan.Rows[e.RowIndex].Cells["idlayanan"].Value.ToString()));
                cmd.ExecuteNonQuery();
                DB.closeConnection();
                loadMaster();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            dgvLayanan.Columns.Clear();
            if (cbKategori.SelectedValue.ToString() != "-1")
            {
                SqlCommand cmd = new SqlCommand("select l.idLayanan, l.namaLayanan, k.namaKategori, l.deskripsi, l.harga from Layanan l join Kategori k on k.idKategori = l.idKategori where l.namalayanan like '%" + txtSearch.Text + "%' and l.idKategori like '%" + cbKategori.SelectedValue.ToString() + "%'", DB.conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dtProduk = new DataTable();
                adapter.Fill(dtProduk);
                dgvLayanan.DataSource = null;
                dgvLayanan.DataSource = dtProduk;
            }
            else
            {
                SqlCommand cmd = new SqlCommand("select l.idLayanan, l.namaLayanan, k.namaKategori, l.deskripsi, l.harga from Layanan l join Kategori k on k.idKategori = l.idKategori where l.namalayanan like '%" + txtSearch.Text + "%'", DB.conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dtProduk = new DataTable();
                adapter.Fill(dtProduk);

                dgvLayanan.DataSource = null;
                dgvLayanan.DataSource = dtProduk;
            }
        }

        private void cbKategori_SelectionChangeCommitted(object sender, EventArgs e)
        {
            dgvLayanan.Columns.Clear();
            if (cbKategori.SelectedValue.ToString() != "-1")
            {
                SqlCommand cmd = new SqlCommand("select l.idLayanan, l.namaLayanan, k.namaKategori, l.deskripsi, l.harga from Layanan l join Kategori k on k.idKategori = l.idKategori where l.namalayanan like '%" + txtSearch.Text + "%' and l.idKategori like '%" + cbKategori.SelectedValue.ToString() + "%'", DB.conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dtProduk = new DataTable();
                adapter.Fill(dtProduk);
                dgvLayanan.DataSource = null;
                dgvLayanan.DataSource = dtProduk;
            }
            else
            {
                SqlCommand cmd = new SqlCommand("select l.idLayanan, l.namaLayanan, k.namaKategori, l.deskripsi, l.harga from Layanan l join Kategori k on k.idKategori = l.idKategori where l.namalayanan like '%" + txtSearch.Text + "%'", DB.conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dtProduk = new DataTable();
                adapter.Fill(dtProduk);

                dgvLayanan.DataSource = null;
                dgvLayanan.DataSource = dtProduk;
            }
            DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn();
            buttonColumn.Name = "Action";
            buttonColumn.HeaderText = "Action";
            buttonColumn.Text = "Add to Cart";
            buttonColumn.UseColumnTextForButtonValue = true;
            dgvLayanan.Columns.Add(buttonColumn);

            dgvLayanan.Columns["idLayanan"].Visible = false;
            dgvLayanan.Columns["deskripsi"].Visible = false;


        }

        void loadMaster()
        {
            //DGV LAYANAN
            dgvLayanan.Columns.Clear();
            SqlCommand cmd = new SqlCommand("select l.idLayanan, l.namaLayanan, k.namaKategori, l.deskripsi, l.harga from Layanan l join Kategori k on k.idKategori = l.idKategori", DB.conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dtProduk = new DataTable();
            adapter.Fill(dtProduk);

            dgvLayanan.DataSource = null;
            dgvLayanan.DataSource = dtProduk;

            DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn();
            buttonColumn.Name = "Action";
            buttonColumn.HeaderText = "Action";
            buttonColumn.Text = "Add to Cart";
            buttonColumn.UseColumnTextForButtonValue = true;
            dgvLayanan.Columns.Add(buttonColumn);

            dgvLayanan.Columns["idLayanan"].Visible = false;
            dgvLayanan.Columns["deskripsi"].Visible = false;

            //DGV CART
            dgvCart.Columns.Clear();
            cmd = new SqlCommand("SELECT dt.id, l.namaLayanan, l.harga, ISNULL(l.harga, 0) + ISNULL((SELECT SUM(a.harga) FROM Daddon da JOIN Addons a ON a.idAddon = da.idAddon WHERE da.dtransid = dt.id), 0) AS subtotal FROM Dtrans dt JOIN Layanan l ON l.idLayanan = dt.idLayanan join Htrans on Htrans.nourut = Dt.nourut WHERE Htrans.nourut = @id;", DB.conn);
            cmd.Parameters.Add(new SqlParameter("@id", this.nourut));
            adapter = new SqlDataAdapter(cmd);
            dtProduk = new DataTable();
            adapter.Fill(dtProduk);

            dgvCart.DataSource = null;
            dgvCart.DataSource = dtProduk;

            buttonColumn = new DataGridViewButtonColumn();
            buttonColumn.Name = "add";
            buttonColumn.HeaderText = "Add Ons";
            buttonColumn.Text = "Add Add Ons";
            buttonColumn.UseColumnTextForButtonValue = true;
            dgvCart.Columns.Add(buttonColumn);

            buttonColumn = new DataGridViewButtonColumn();
            buttonColumn.Name = "remove";
            buttonColumn.HeaderText = "Remove";
            buttonColumn.Text = "Remove";
            buttonColumn.UseColumnTextForButtonValue = true;
            dgvCart.Columns.Add(buttonColumn);
            dgvCart.Columns["id"].Visible = false;

            //Hitung total
            int total = 0;
            foreach (DataGridViewRow row in dgvCart.Rows)
            {
                total += Convert.ToInt32(row.Cells["subtotal"].Value.ToString());
            }
            txtTotal.Text = "Total: Rp."+total.ToString();
        }

        int createNota()
        {
            int nonota;
            int total = 0;
            int status = 0;
            DB.openConnection();
            SqlCommand cmd = new SqlCommand("select max(nourut) from Htrans", DB.conn);
            nonota = Convert.ToInt32(cmd.ExecuteScalar().ToString()) + 1;
            cmd = new SqlCommand("insert into Htrans (customer,total,status) values(@customer,@total,@status)", DB.conn);
            cmd.Parameters.Add(new SqlParameter("@customer", this.username));
            cmd.Parameters.Add(new SqlParameter("@total", total));
            cmd.Parameters.Add(new SqlParameter("@status", status));
            cmd.ExecuteNonQuery();
            DB.closeConnection();
            return nonota;
        }

        private void dgvCart_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvCart.Columns["remove"].Index && e.RowIndex >= 0)
            {
                int nourut = Convert.ToInt32(dgvCart.Rows[e.RowIndex].Cells["id"].Value.ToString());
                DB.openConnection();
                SqlCommand cmd = new SqlCommand("delete from daddon where dtransid = @id", DB.conn);
                cmd.Parameters.Add(new SqlParameter("@id", nourut));
                cmd.ExecuteNonQuery();
                
                cmd = new SqlCommand("delete from dtrans where id = @id", DB.conn);
                cmd.Parameters.Add(new SqlParameter("@id", nourut));
                cmd.ExecuteNonQuery();
                DB.closeConnection();
                loadMaster();
            }
            else if (e.ColumnIndex == dgvCart.Columns["add"].Index && e.RowIndex >= 0)
            {
                MenuUserAddons m = new MenuUserAddons(Convert.ToInt32(dgvCart.Rows[e.RowIndex].Cells["id"].Value.ToString()));
                m.ShowDialog();
                loadMaster();
            }
            else
            {
                refreshAddons(dgvCart.Rows[e.RowIndex].Cells["id"].Value.ToString());
            }
        }

        void refreshAddons(string id)
        {
            dgvAddons.Columns.Clear();
            SqlCommand cmd = new SqlCommand("SELECT l.namaLayanan, a.namaAddon, a.harga FROM Daddon da join Dtrans dt on dt.id = da.dtransid join Addons a on a.idAddon = da.idAddon join Layanan l on l.idLayanan = dt.idLayanan where dt.id = @id", DB.conn);
            cmd.Parameters.Add(new SqlParameter("@id", id));
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dtProduk = new DataTable();
            adapter.Fill(dtProduk);

            dgvAddons.DataSource = null;
            dgvAddons.DataSource = dtProduk;
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this.nourut.ToString());
            int total = 0;
            foreach (DataGridViewRow row in dgvCart.Rows)
            {
                total += Convert.ToInt32(row.Cells["subtotal"].Value.ToString());
            }
            SqlCommand cmd = new SqlCommand("update htrans set status = 1, total = @total where nourut = @nourut", DB.conn);
            cmd.Parameters.Add(new SqlParameter("@nourut", this.nourut));
            cmd.Parameters.Add(new SqlParameter("@total", total));
            DB.openConnection();
            cmd.ExecuteNonQuery();
            DB.closeConnection();
            resetAll();
            this.nourut = createNota();
            txtWelcome.Text = "Welcome, " + username + "(" + this.nourut.ToString() + ")";
        }

        void resetAll()
        {
            dgvCart.Columns.Clear();
            dgvAddons.Columns.Clear();
            txtDeskripsi.Text = string.Empty;
            txtSearch.Text = string.Empty;
            cbKategori.SelectedIndex = 0;
            txtTotal.Text = "Total: Rp.";
            dgvLayanan.Columns.Clear();
            SqlCommand cmd = new SqlCommand("select l.idLayanan, l.namaLayanan, k.namaKategori, l.deskripsi, l.harga from Layanan l join Kategori k on k.idKategori = l.idKategori", DB.conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dtProduk = new DataTable();
            adapter.Fill(dtProduk);

            dgvLayanan.DataSource = null;
            dgvLayanan.DataSource = dtProduk;

            DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn();
            buttonColumn.Name = "Action";
            buttonColumn.HeaderText = "Action";
            buttonColumn.Text = "Add to Cart";
            buttonColumn.UseColumnTextForButtonValue = true;
            dgvLayanan.Columns.Add(buttonColumn);

            dgvLayanan.Columns["idLayanan"].Visible = false;
            dgvLayanan.Columns["deskripsi"].Visible = false;
        }
    }
}
