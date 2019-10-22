using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace Reporting_soft
{
    public partial class Form1 : Form
    {

        private ReportDataSource[] rptDataSource;
        private string reportName;
        private string reportTitle;

        public Form1(ReportDataSource[] rds, string rn, string rt)
        {
            InitializeComponent();
            rptDataSource = rds;
            reportName = rn;
            reportTitle = rt;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.Text = reportTitle;
            for (int i = 0; i < rptDataSource.Length; i++)
            {
                this.reportViewer1.LocalReport.DataSources.Add(rptDataSource[i]);
            }
            this.reportViewer1.LocalReport.ReportEmbeddedResource = reportName;
            this.reportViewer1.RefreshReport();
        }
    }
}
