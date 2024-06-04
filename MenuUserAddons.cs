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
    public partial class MenuUserAddons : Form
    {
        int dtransid;
        public MenuUserAddons(int dtransid)
        {
            this.dtransid = dtransid;
            InitializeComponent();
        }

        private void MenuUserAddons_Load(object sender, EventArgs e)
        {
            refreshDGV();
        }

        private void dgvAddons_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex == dgvAddons.Columns["Add"].Index)
                {
                    if (dgvAddons.Rows[e.RowIndex].DefaultCellStyle.BackColor == Color.LightGreen)
                    {
                        DB.openConnection();
                        SqlCommand cmd = new SqlCommand("delete from daddon where dtransid = @dtransid and idaddon = @idaddon", DB.conn);
                        cmd.Parameters.Add(new SqlParameter("@idaddon", dgvAddons.Rows[e.RowIndex].Cells["idaddon"].Value.ToString()));
                        cmd.Parameters.Add(new SqlParameter("@dtransid", dtransid.ToString()));
                        cmd.ExecuteNonQuery();
                        DB.closeConnection();
                    }
                    else
                    {
                        DB.openConnection();
                        SqlCommand cmd = new SqlCommand("insert into daddon values(@dtransid,@idaddon)", DB.conn);
                        cmd.Parameters.Add(new SqlParameter("@idaddon", dgvAddons.Rows[e.RowIndex].Cells["idaddon"].Value.ToString()));
                        cmd.Parameters.Add(new SqlParameter("@dtransid", dtransid.ToString()));
                        cmd.ExecuteNonQuery();
                        DB.closeConnection();
                    }
                }
                txtDeskripsi.Text = dgvAddons.Rows[e.RowIndex].Cells["deskripsi"].Value.ToString();
                refreshDGV();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        void refreshDGV()
        {
            dgvAddons.Columns.Clear();
            DB.openConnection();
            SqlCommand cmd = new SqlCommand("select * from Addons where status = 1", DB.conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dtProduk = new DataTable();
            adapter.Fill(dtProduk);
            dgvAddons.DataSource = null;
            dgvAddons.DataSource = dtProduk;

            DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn();
            buttonColumn.Name = "Add";
            buttonColumn.HeaderText = "Action";
            buttonColumn.Text = "Add / Remove";
            buttonColumn.UseColumnTextForButtonValue = true;
            dgvAddons.Columns.Add(buttonColumn);

            dgvAddons.Columns["idAddon"].Visible = false;
            dgvAddons.Columns["status"].Visible = false;
            dgvAddons.Columns["deskripsi"].Visible = false;

            foreach (DataGridViewRow row in dgvAddons.Rows)
            {
                cmd = new SqlCommand("select count(*) from Daddon where idAddon = @id and dtransid = @trans", DB.conn);
                cmd.Parameters.Add(new SqlParameter("@id", row.Cells["idAddon"].Value.ToString()));
                cmd.Parameters.Add(new SqlParameter("@trans", dtransid.ToString()));
                int result = Convert.ToInt32(cmd.ExecuteScalar().ToString());
                if (result > 0)
                {
                    row.DefaultCellStyle.BackColor = Color.LightGreen;
                }
            }
            DB.closeConnection();
        }
    }
}
