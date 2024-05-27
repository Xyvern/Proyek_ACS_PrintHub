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
    public partial class Loginkaryawan : Form
    {
        public Loginkaryawan()
        {
            InitializeComponent();
        }

        private void btnswitch_Click(object sender, EventArgs e)
        {
            Form1 l = new Form1();
            this.Hide();
            l.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = userLogin.Text;
            string password = passLogin.Text;
            SqlCommand cmd = new SqlCommand("SELECT * from Karyawan where username = @username", DB.conn);
            cmd.Parameters.AddWithValue("@username", username);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable loggedIn = new DataTable();
            adapter.Fill(loggedIn);
            if (loggedIn.Rows.Count == 0)
            {
                MessageBox.Show("Username tidak terdaftar");
            }
            else
            {
                if (password == loggedIn.Rows[0]["password"].ToString())
                {
                    Homekaryawan h = new Homekaryawan(username);
                    this.Hide();
                    h.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Password salah");
                }
            }
        }
    }
}
