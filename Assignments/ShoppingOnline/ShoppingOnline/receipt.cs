using Microsoft.Reporting.WinForms;
using ShoppingOnline.DAO;
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

namespace ShoppingOnline
{
    public partial class receipt : Form
    {
        public receipt()
        {
            InitializeComponent();
            
        }

        private void receipt_Load(object sender, EventArgs e)
        {
            LoadReport();
            this.reportViewer1.RefreshReport();
        }

        private void LoadReport()
        {
            string query = "SELECT * FROM SHOPPINGPRODUCT";

            Data_Provider dp = new Data_Provider();
            DataTable f_dt = dp.ExecuteQuery(query);
            //-------------------------------------

            DataSet ds = new DataSet();
            ds.Tables.Add(f_dt);
            //-------------------------------------
            reportViewer1.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local;
            reportViewer1.LocalReport.ReportPath = "Report1.rdlc";
            if (ds.Tables[0].Rows.Count > 0)
            {
                ReportDataSource rds = new ReportDataSource();
                rds.Name = "dataset_report";
                rds.Value = ds.Tables[0];

                //------------------------------------------
                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.DataSources.Add(rds);
                //reportViewer1.RefreshReport();
            }
        }

        private void receipt_form_closing(object sender, FormClosingEventArgs e)
        {
            
        }
        private void ResetDB()
        {
            string connectionString = "Data Source=DESKTOP-IUEIHA4;Initial Catalog=ShoppingOnline;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            string query = "TRUNCATE TABLE SHOPPINGPRODUCT";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.ExecuteNonQuery();
        }
    }
}
