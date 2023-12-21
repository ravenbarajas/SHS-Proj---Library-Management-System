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
    public partial class Frm_Reports : Form
    {
        DBConnect dbConn = new DBConnect();
        Globals Global = new Globals();
        SqlCommand CMD;
        SqlDataReader Reader;
        SqlDataAdapter da;   
        public Frm_Reports()
        {
            InitializeComponent();
            if (dbConn.connection.State != ConnectionState.Open) dbConn.Open();
        }

        private void Frm_Reports_Load(object sender, EventArgs e)
        {
                SqlDataAdapter da = new SqlDataAdapter("select * from TBL_BORROW where TRANS= '" + Globals.ID + "'", dbConn.connection);
                MyDS ds = new MyDS();
                da.Fill(ds, "TBL_BORROW");
                Rpt_Borrowing objRpt = new Rpt_Borrowing();
                objRpt.SetDataSource(ds.Tables["TBL_BORROW"]);
                CRV.ReportSource = (objRpt);
                CRV.Refresh();          
        }

        private void CRV_Load(object sender, EventArgs e)
        {          
        }

        private void rpt_Borrowing1_InitReport(object sender, EventArgs e)
        {

        }
    }
}
