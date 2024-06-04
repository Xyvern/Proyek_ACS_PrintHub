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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace ProyekACS
{
    public partial class MenuMasterAddon : Form
    {
        string username;
        string editID;
        public MenuMasterAddon(string username)
        {
            this.username = username;
            InitializeComponent();
            txtWelcome.Text = "Selamat datang, " + username + "!";
        }

        private void MenuMasterAddon_Load(object sender, EventArgs e)
        {
            refreshDGV();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Homekaryawan h = new Homekaryawan(username);
            this.Hide();
            h.ShowDialog();
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
        void refreshDGV()
        {
            dgvMaster.Columns.Clear();
            SqlCommand cmd = new SqlCommand("select idAddon, namaAddon,deskripsi,harga from addons where namaAddon like '%" + txtSearch.Text + "%' and status = 1", DB.conn);
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
            dgvMaster.Columns["idAddon"].Visible = false;
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
                txtNama.Text = data.Cells["namaAddon"].Value.ToString();
                nmHarga.Value = Convert.ToInt32(data.Cells["harga"].Value.ToString());
                txtDes.Text = data.Cells["deskripsi"].Value.ToString();
                editID = dgvMaster.Rows[e.RowIndex].Cells["idAddon"].Value.ToString();
                btnCancel.Enabled = true;
            }
            else if (e.ColumnIndex == dgvMaster.Columns["btnDelete"].Index && e.RowIndex >= 0)
            {
                DialogResult confirmation = MessageBox.Show("Apakah anda yakin ingin menghapus?", "Confirmation", MessageBoxButtons.YesNo);
                if (confirmation == DialogResult.Yes)
                {
                    SqlCommand cmd = new SqlCommand("UPDATE Addons set status = 0 where idAddon = @id", DB.conn);
                    cmd.Parameters.Add(new SqlParameter("@id", dgvMaster.Rows[e.RowIndex].Cells["idAddon"].Value.ToString()));
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
                    SqlCommand cmd = new SqlCommand("UPDATE Addons set namaAddon = @nama, Deskripsi = @des, harga = @harga where idAddon = @id", DB.conn);
                    cmd.Parameters.Add(new SqlParameter("@nama", txtNama.Text));
                    cmd.Parameters.Add(new SqlParameter("@harga", nmHarga.Value));
                    cmd.Parameters.Add(new SqlParameter("@des", txtDes.Text));
                    cmd.Parameters.Add(new SqlParameter("@id", editID));
                    DB.openConnection();
                    cmd.ExecuteNonQuery();
                    DB.closeConnection();
                }
                else
                {
                    DB.openConnection();
                    SqlCommand cmd = new SqlCommand("INSERT INTO Addons (namaAddon,deskripsi,harga,status) values (@nama,@des,@harga,1)", DB.conn);
                    cmd.Parameters.Add(new SqlParameter("@nama", txtNama.Text));
                    cmd.Parameters.Add(new SqlParameter("@harga", nmHarga.Value));
                    cmd.Parameters.Add(new SqlParameter("@des", txtDes.Text));
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

        private void btnLayanan_Click(object sender, EventArgs e)
        {
            MenuMasterLayanan m = new MenuMasterLayanan(username);
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
