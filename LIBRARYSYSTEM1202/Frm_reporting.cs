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
using System.IO;

namespace LIBRARYSYSTEM1202
{
    public partial class Frm_reporting : Form
    {
        DBConnect dbConn = new DBConnect();
        Globals Global = new Globals();
        SqlCommand CMD;
        SqlDataReader Reader;
        SqlDataAdapter da;     

        public Frm_reporting()
        {
            InitializeComponent();
            if (dbConn.connection.State != ConnectionState.Open) dbConn.Open();
        }
        #region Functions  
   
        public void DateFilter()
        {
            CMD = new SqlCommand("SELECT * from TBL_BORROW where BORROWDATE between '" + this.dtp_from.Value.ToString("yyyy-MM-dd hh:mm:ss ") + "' and '" + this.dtp_to.Value.ToString("yyyy-MM-dd hh:mm:ss") + "' and STATUS = ''", dbConn.connection);
            Reader = CMD.ExecuteReader();
            dgv_info.AllowUserToAddRows = true;
            while (Reader.Read())
            {
                DataGridViewRow row = (DataGridViewRow)dgv_info.Rows[0].Clone();
                row.Cells[0].Value = Reader["TRANS"];
                row.Cells[1].Value = Reader["LRN"];
                row.Cells[2].Value = Reader["STUDENTNAME"];
                row.Cells[3].Value = Reader["TRACKSTRAND"];
                row.Cells[4].Value = Reader["SECTION"];
                row.Cells[5].Value = Reader["BOOKID"];
                row.Cells[6].Value = Reader["BOOKTITLE"];
                row.Cells[7].Value = Reader["STATUS"];
                row.Cells[8].Value = Reader["BORROWDATE"];


                dgv_info.Rows.Add(row);
            }
            dgv_info.AllowUserToAddRows = false;
        }      

        private void mnuSelectNewStudent_Click(object sender, EventArgs e)
        {

            CMD = new SqlCommand("SELECT * from TBL_BORROW WHERE LRN = '" + dgv_info.Rows[dgv_info.CurrentCell.RowIndex].Cells[1].Value + "'", dbConn.connection);
            Reader = CMD.ExecuteReader();
            if (Reader.Read())
            {
                txt_name.Text = Reader["LRN"].ToString();
            }

        }

        #endregion

        private void Frm_reporting_Load(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cbo_unreturned_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void tsb_save_Click(object sender, EventArgs e)
        {

        }

        private void txt_booktitle_TextChanged(object sender, EventArgs e)
        {
            try
            {
                #region
                SqlCommand comm = new SqlCommand();
                SqlDataAdapter da = new SqlDataAdapter("select * from TBL_BOOKS", dbConn.connection);
                DataTable DT = new DataTable();
                da.Fill(DT);
                DataView HH = DT.DefaultView;
                HH.RowFilter = "TITLE like'" + txt_booktitle.Text + "%'";
                dgv_info.DataSource = HH;
                #endregion
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load Results", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void txt_name_TextChanged(object sender, EventArgs e)
        {          
            try
            {
                #region
                SqlCommand comm = new SqlCommand();
                SqlDataAdapter da = new SqlDataAdapter("select * from TBL_BORROW", dbConn.connection);
                DataTable DT = new DataTable();
                da.Fill(DT);
                DataView HH = DT.DefaultView;
                HH.RowFilter = "LRN like'" + txt_name.Text + "%'";
                dgv_info.DataSource = HH;
                #endregion
            }            
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load Results", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            CMD = new SqlCommand("SELECT * from TBL_BORROW where STATUS = '" + cbo_status.Text + "'", dbConn.connection);
            Reader = CMD.ExecuteReader();

            try
            {
                #region
                SqlCommand comm = new SqlCommand();
                SqlDataAdapter da = new SqlDataAdapter("select * from TBL_BORROW where STATUS = '" + cbo_status.Text + "'", dbConn.connection);
                DataTable DT = new DataTable();
                da.Fill(DT);
                DataView HH = DT.DefaultView;
                HH.RowFilter = "STATUS like'" + cbo_status.Text + "%'";
                dgv_info.DataSource = HH;
                #endregion
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load Results", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void tsb_save_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cbo_status.Text == "Borrowed")
            {
                Globals.proctoprint = "BORROWED";
                Globals.ID = txt_booktitle.Text;
                Frm_Reports2 REPORTS = new Frm_Reports2();
                REPORTS.ShowDialog();
            }

            if (cbo_status.Text == "Returned" )
            { 
                Globals.proctoprint = "RETURNED";           
                Globals.ID = txt_booktitle.Text;
                Frm_Reports2 REPORTS = new Frm_Reports2();
                REPORTS.ShowDialog();
            }

            if (cbo_status.Text == "Lost")
            {
                Globals.proctoprint = "LOST";
                Globals.ID = txt_booktitle.Text;
                Frm_Reports2 REPORTS = new Frm_Reports2();
                REPORTS.ShowDialog();
            }  
        }

        private void btn_gr2_Click(object sender, EventArgs e)
        {
            Globals.ID = txt_name.Text;
            Frm_historyreport reportsfrm = new Frm_historyreport();
            reportsfrm.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            DateFilter();
        }

        private void dgv_info_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            ContextMenuStrip mnu = new ContextMenuStrip();
            if (dgv_info.Rows.Count != 0)
            {
                if (e.Button == MouseButtons.Right)
                {
                    if (e.RowIndex == -1) return;
                    if (e.ColumnIndex == -1) return;

                    dgv_info.CurrentCell = dgv_info.Rows[e.RowIndex].Cells[e.ColumnIndex];
                    dgv_info.Rows[e.RowIndex].Selected = true;
                    dgv_info.Focus();


                    ToolStripMenuItem mnuSelect = new ToolStripMenuItem("Select");
                    mnuSelect.Image = Properties.Resources.arrow_left;

                    mnuSelect.Click += new EventHandler(mnuSelectNewStudent_Click);

                    mnu.Items.AddRange(new ToolStripItem[] { mnuSelect });                  

                    dgv_info.ContextMenuStrip = mnu;
                }
            }
        }

        private void btn_gr3_Click(object sender, EventArgs e)
        {           
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btn_bookprint_Click(object sender, EventArgs e)
        {       
        } 
        
        
    
    }   
}
