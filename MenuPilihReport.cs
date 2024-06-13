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
    public partial class MenuPilihReport : Form
    {
        string username;
        public MenuPilihReport(string username)
        {
            InitializeComponent();
            this.username = username;
        }

        private void MenuPilihReport_Load(object sender, EventArgs e)
        {
            DailySalesReport report = new DailySalesReport();
            crystalReportViewer1.ReportSource = null;
            crystalReportViewer1.ReportSource = report;
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            btnReport.BackColor = Color.LightGreen;
            btnOrderCustomer.BackColor = Color.LightGray;
            DailySalesReport report = new DailySalesReport();
            crystalReportViewer1.ReportSource = null;
            crystalReportViewer1.ReportSource = report;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            btnReport.BackColor = Color.LightGray;
            btnOrderCustomer.BackColor = Color.LightGreen;
            CustomerOrderReport report = new CustomerOrderReport();
            crystalReportViewer1.ReportSource = null;
            crystalReportViewer1.ReportSource = report;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Homekaryawan h = new Homekaryawan(username);
            this.Hide();
            h.Show();
        }
    }
}
