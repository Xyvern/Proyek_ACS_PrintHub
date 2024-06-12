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
    public partial class NotaUser : Form
    {
        string nourut;
        public NotaUser(string nourut)
        {
            InitializeComponent();
            this.nourut = nourut;
        }

        private void NotaUser_Load(object sender, EventArgs e)
        {
            ReportNotaUser report = new ReportNotaUser();
            report.SetParameterValue("NoUrut", this.nourut);
            crystalReportViewer1.ReportSource = null;
            crystalReportViewer1.ReportSource = report;
        }
    }
}
