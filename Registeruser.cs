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
    public partial class Registeruser : Form
    {
        public Registeruser()
        {
            InitializeComponent();
        }

        private void Registeruser_Load(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string username = userReg.Text;
            string password = passReg.Text;
            string nama = namaReg.Text;
            string email = emailReg.Text;
            SqlCommand cmd = new SqlCommand("SELECT * from Customer where username = @username", DB.conn);
            cmd.Parameters.AddWithValue("@username", username);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable loggedIn = new DataTable();
            adapter.Fill(loggedIn);
            if (loggedIn.Rows.Count == 0)
            {
                cmd = new SqlCommand("insert into Customer (username,password,nama,email) values(@username,@password,@nama,@email)", DB.conn);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);
                cmd.Parameters.AddWithValue("@nama", nama);
                cmd.Parameters.AddWithValue("@email", email);
                DB.openConnection();
                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Sukses register");
                    this.Close();
                }
                catch (Exception exc)
                {
                    throw new Exception(exc.Message);
                }
                DB.closeConnection();
            }
            else
            {
                MessageBox.Show("Username sudah ada");
            }
            userReg.Text = "";
            passReg.Text = "";
            namaReg.Text = "";
            emailReg.Text = "";
        }
    }
}
