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
using LIBRARYSYSTEM1202.Reports;

namespace LIBRARYSYSTEM1202
{
    public partial class Frm_historyreport : Form
    {
        DBConnect dbConn = new DBConnect();
        Globals Global = new Globals();
        SqlCommand CMD;
        SqlDataReader Reader;
        SqlDataAdapter da;

        public Frm_historyreport()
        {
            InitializeComponent();
            if (dbConn.connection.State != ConnectionState.Open) dbConn.Open();
        }

        private void Frm_historyreport_Load(object sender, EventArgs e)
        {          
                SqlDataAdapter da = new SqlDataAdapter("select * from TBL_BORROW where LRN = '" + Globals.ID + "'", dbConn.connection);
                MyDS ds = new MyDS();
                da.Fill(ds, "TBL_BORROW");
                Rpt_borrowhistory objRpt = new Rpt_borrowhistory();
                objRpt.SetDataSource(ds.Tables["TBL_BORROW"]);
                CRV.ReportSource = (objRpt);
                CRV.Refresh();          
        }

        private void CRV_Load(object sender, EventArgs e)
        {

        }
    }
}
