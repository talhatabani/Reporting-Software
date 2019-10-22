using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.Reporting.WinForms;

namespace Reporting_soft
{
    public partial class SalesReportDashboard : Form
    {
        public SalesReportDashboard()
        {
            InitializeComponent();
        }

        private void generate_report_Click(object sender, EventArgs e)
        {
            SqlCommand sc = new SqlCommand("Report_AllData", ConnectionString.GetConnection());
            sc.CommandType = CommandType.StoredProcedure;
            sc.Parameters.AddWithValue("@ParamTable1", from.Value.Date);
            sc.Parameters.AddWithValue("@ParamTable2", to.Value.Date);
            SqlDataAdapter sda = new SqlDataAdapter(sc);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            new Form1(new ReportDataSource[] { new ReportDataSource("DataSet1", dt) }, "Reporting_soft.Allsale.rdlc", "Sale Orders Detail").Show();
        }
    }
}
