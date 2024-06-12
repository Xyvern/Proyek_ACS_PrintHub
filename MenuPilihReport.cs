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
        public MenuPilihReport()
        {
            InitializeComponent();
        }

        private void MenuPilihReport_Load(object sender, EventArgs e)
        {
            DailySalesReport report = new DailySalesReport();
            crystalReportViewer1.ReportSource = null;
            crystalReportViewer1.ReportSource = report;
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            DailySalesReport report = new DailySalesReport();
            crystalReportViewer1.ReportSource = null;
            crystalReportViewer1.ReportSource = report;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
