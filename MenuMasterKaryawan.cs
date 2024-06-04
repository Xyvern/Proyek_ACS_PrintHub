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
    public partial class MenuMasterKaryawan : Form
    {
        string username;
        public MenuMasterKaryawan(string username)
        {
            this.username = username;
            InitializeComponent();
            txtWelcome.Text = "Selamat datang, " + username + "!";
        }

        private void MenuMasterKaryawan_Load(object sender, EventArgs e)
        {
            loadDGV();
        }
        
        void loadDGV()
        {
            SqlCommand cmd = new SqlCommand("select username, 'hidden' as password, nama, email from Karyawan where username like '%" + txtSearch.Text + "%' and status=1", DB.conn);
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
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            refreshDGV();
        }
        
        void refreshDGV()
        {
            dgvMaster.Columns.Clear();
            SqlCommand cmd = new SqlCommand("select username, 'hidden' as password, nama, email from Customer where username like '%" + txtSearch.Text + "%' and status=1", DB.conn);
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
        }

        private void dgvMaster_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvMaster.Columns["btnEdit"].Index && e.RowIndex >= 0)
            {
                DataGridViewRow data = dgvMaster.Rows[e.RowIndex];
                txtUser.Text = data.Cells["username"].Value.ToString();
                txtPassword.Text = data.Cells["password"].Value.ToString();
                txtNama.Text = data.Cells["nama"].Value.ToString();
                txtEmail.Text = data.Cells["email"].Value.ToString();
                txtUser.Enabled = false;
                txtPassword.Enabled = false;
                btnCancel.Enabled = true;
            }
            else if (e.ColumnIndex == dgvMaster.Columns["btnDelete"].Index && e.RowIndex >= 0)
            {
                DialogResult confirmation = MessageBox.Show("Apakah anda yakin ingin menghapus?", "Confirmation", MessageBoxButtons.YesNo);
                if (confirmation == DialogResult.Yes)
                {
                    SqlCommand cmd = new SqlCommand("UPDATE Karyawan set status = 0 where username = @user", DB.conn);
                    cmd.Parameters.Add(new SqlParameter("@user", dgvMaster.Rows[e.RowIndex].Cells["username"].Value.ToString()));
                    DB.openConnection();
                    cmd.ExecuteNonQuery();
                    DB.closeConnection();
                }
                refreshDGV();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtUser.Text = "";
            txtPassword.Text = "";
            txtNama.Text = "";
            txtEmail.Text = "";
            txtUser.Enabled = true;
            txtPassword.Enabled = true;
            btnCancel.Enabled = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtUser.Text.Length > 0 && txtPassword.Text.Length > 0 && txtNama.Text.Length > 0 && txtEmail.Text.Length > 0)
            {
                if (btnCancel.Enabled)
                {
                    SqlCommand cmd = new SqlCommand("UPDATE Customer set nama = @nama, email = @email where username = @user", DB.conn);
                    cmd.Parameters.Add(new SqlParameter("@nama", txtNama.Text));
                    cmd.Parameters.Add(new SqlParameter("@email", txtEmail.Text));
                    cmd.Parameters.Add(new SqlParameter("@user", txtUser.Text));
                    DB.openConnection();
                    cmd.ExecuteNonQuery();
                    DB.closeConnection();
                }
                else
                {
                    SqlCommand check = new SqlCommand("SELECT count(*) from Customer where username = @user", DB.conn);
                    check.Parameters.Add(new SqlParameter("@user", txtUser.Text));
                    DB.openConnection();
                    int jum = Convert.ToInt32(check.ExecuteScalar().ToString());
                    if (jum == 0)
                    {
                        SqlCommand cmd = new SqlCommand("INSERT INTO Customer (username,password,nama,email) values (@user,@password,@email,@nama)", DB.conn);
                        cmd.Parameters.Add(new SqlParameter("@nama", txtNama.Text));
                        cmd.Parameters.Add(new SqlParameter("@password", txtPassword.Text));
                        cmd.Parameters.Add(new SqlParameter("@email", txtEmail.Text));
                        cmd.Parameters.Add(new SqlParameter("@user", txtUser.Text));
                        cmd.ExecuteNonQuery();
                    }
                    else
                    {
                        MessageBox.Show("Username sudah terdaftar!");
                    }
                    DB.closeConnection();
                }
            }
            refreshDGV();
            txtUser.Text = "";
            txtPassword.Text = "";
            txtNama.Text = "";
            txtEmail.Text = "";
            txtUser.Enabled = true;
            txtPassword.Enabled = true;
            btnCancel.Enabled = false;
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
    }
}
