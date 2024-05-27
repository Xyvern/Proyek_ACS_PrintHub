using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace ProyekACS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DB db = new DB();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = userLogin.Text;
            string password = passLogin.Text;
            SqlCommand cmd = new SqlCommand("SELECT * from Customer where username = @username", DB.conn);
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
                    Homeuser h = new Homeuser(username);
                    this.Hide();
                    h.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Password salah");
                }
            }
        }

        private void btnswitch_Click(object sender, EventArgs e)
        {
            Loginkaryawan l = new Loginkaryawan();
            this.Hide();
            l.ShowDialog();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Registeruser r = new Registeruser();
            r.ShowDialog();
        }
    }
}
