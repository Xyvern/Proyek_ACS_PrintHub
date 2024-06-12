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
    public partial class History : Form
    {
        public History()
        {
            InitializeComponent();
        }

        private void History_Load(object sender, EventArgs e)
        {
            dgvHistory.Columns.Clear();
            SqlCommand cmd = new SqlCommand("select nourut from Htrans where status = 2", DB.conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dtTable = new DataTable();
            adapter.Fill(dtTable);

            dgvHistory.DataSource = null;
            dgvHistory.DataSource = dtTable;
        }

        private void dgvHistory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            NotaUser nota = new NotaUser(dgvHistory.Rows[e.RowIndex].Cells[0].Value.ToString());
            nota.ShowDialog();
        }
    }
}
