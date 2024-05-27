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
    public partial class Homeuser : Form
    {
        string username;
        public Homeuser(string username)
        {
            InitializeComponent();
            this.username = username;
        }

        private void Homeuser_Load(object sender, EventArgs e)
        {
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

            DataGridViewTextBoxColumn idColumn = new DataGridViewTextBoxColumn();
            idColumn.Name = "nomerCart";
            idColumn.HeaderText = "Nomer";

            DataGridViewTextBoxColumn namaColumn = new DataGridViewTextBoxColumn();
            namaColumn.Name = "namaLayanan";
            namaColumn.HeaderText = "Nama Layanan";

            DataGridViewTextBoxColumn hargaColumn = new DataGridViewTextBoxColumn();
            hargaColumn.Name = "harga";
            hargaColumn.HeaderText = "Harga";

            DataGridViewTextBoxColumn subtotalColumn = new DataGridViewTextBoxColumn();
            subtotalColumn.Name = "subtotal";
            subtotalColumn.HeaderText = "Subtotal";

            dgvCart.Columns.Add(idColumn);
            dgvCart.Columns.Add(namaColumn);
            dgvCart.Columns.Add(hargaColumn);
            dgvCart.Columns.Add(subtotalColumn);

            DataGridViewButtonColumn removeColumn = new DataGridViewButtonColumn();
            removeColumn.Name = "remove";
            removeColumn.HeaderText = "Remove";
            removeColumn.Text = "Remove";
            removeColumn.UseColumnTextForButtonValue = true;
            dgvCart.Columns.Add(removeColumn);

            dgvCart.Columns["nomerCart"].Visible = false;

            cmd = new SqlCommand("select * from addons", DB.conn);
            adapter = new SqlDataAdapter(cmd);
            dtProduk = new DataTable();
            adapter.Fill(dtProduk);

            dgvAddon.DataSource = null;
            dgvAddon.DataSource = dtProduk;
            dgvAddon.Columns["deskripsi"].Visible = false;

            DataGridViewButtonColumn addColumn = new DataGridViewButtonColumn();
            addColumn.Name = "add";
            addColumn.HeaderText = "Action";
            addColumn.Text = "Add";
            addColumn.UseColumnTextForButtonValue = true;
            dgvAddon.Columns.Add(addColumn);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            this.Hide();
            f.ShowDialog();
        }

        private void dgvLayanan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtDeskripsi.Text = dgvLayanan.Rows[e.RowIndex].Cells["deskripsi"].Value.ToString();
        }

        private void dgvLayanan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvLayanan.Columns["Action"].Index && e.RowIndex >= 0)
            {
                int max = 1;
                foreach (DataGridViewRow row in dgvCart.Rows)
                {
                    if (row.Cells["nomerCart"].Value != null)
                    {
                        int nomer = Convert.ToInt32(row.Cells["nomerCart"].Value);
                        if (nomer > max)
                        {
                            max = nomer;
                        }
                    }
                }
                dgvCart.Rows.Add(max, dgvLayanan.Rows[e.RowIndex].Cells["namaLayanan"].Value.ToString(), dgvLayanan.Rows[e.RowIndex].Cells["harga"].Value.ToString(), dgvLayanan.Rows[e.RowIndex].Cells["harga"].Value.ToString());
            }
        }

        private void dgvAddon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtDeskripsi.Text = dgvAddon.Rows[e.RowIndex].Cells["deskripsi"].Value.ToString();
        }

        private void dgvAddon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvAddon.Columns["add"].Index && e.RowIndex >= 0)
            {
                if (dgvAddon.Rows[e.RowIndex].DefaultCellStyle.BackColor != Color.LightGreen)
                {
                    dgvAddon.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightGreen;
                }
                else
                {
                    dgvAddon.Rows[e.RowIndex].DefaultCellStyle.BackColor = dgvAddon.DefaultCellStyle.BackColor;
                }
            }
        }
    }
}
