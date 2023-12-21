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
    public partial class Frm_Reports2 : Form
    {
        DBConnect dbConn = new DBConnect();
        Globals Global = new Globals();
        SqlCommand CMD;
        SqlDataReader Reader;
        SqlDataAdapter da;   

        public Frm_Reports2()
        {
            InitializeComponent();
            if (dbConn.connection.State != ConnectionState.Open) dbConn.Open();
        }

        private void Frm_Reports2_Load(object sender, EventArgs e)
        {           
            if (Globals.proctoprint == "BORROWED")
            {
                SqlDataAdapter da = new SqlDataAdapter("select * from TBL_BORROW where STATUS = 'Borrowed'", dbConn.connection);
                MyDS ds = new MyDS();
                da.Fill(ds, "TBL_BORROW");
                Rpt_borrowed objRpt = new Rpt_borrowed();
                objRpt.SetDataSource(ds.Tables["TBL_BORROW"]);
                CRV.ReportSource = (objRpt);
                CRV.Refresh();
            }
            if (Globals.proctoprint == "RETURNED")
            {
                SqlDataAdapter da = new SqlDataAdapter("select * from TBL_BORROW where STATUS = 'Returned'", dbConn.connection);
                MyDS ds = new MyDS();
                da.Fill(ds, "TBL_BORROW");
                Rpt_borrowed objRpt = new Rpt_borrowed();
                objRpt.SetDataSource(ds.Tables["TBL_BORROW"]);
                CRV.ReportSource = (objRpt);
                CRV.Refresh();
            }
            if (Globals.proctoprint == "LOST")
            {
                SqlDataAdapter da = new SqlDataAdapter("select * from TBL_BORROW where STATUS = 'Lost'", dbConn.connection);
                MyDS ds = new MyDS();
                da.Fill(ds, "TBL_BORROW");
                Rpt_borrowed objRpt = new Rpt_borrowed();
                objRpt.SetDataSource(ds.Tables["TBL_BORROW"]);
                CRV.ReportSource = (objRpt);
                CRV.Refresh();
            }       
        }
    }
}
