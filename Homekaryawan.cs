using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        }

        private void Homekaryawan_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MenuMaster h = new MenuMaster(username);
            this.Hide();
            h.ShowDialog();
        }
    }
}
