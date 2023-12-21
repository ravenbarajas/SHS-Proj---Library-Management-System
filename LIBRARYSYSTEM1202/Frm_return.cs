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
    public partial class Frm_return : Form
    {
        DBConnect dbConn = new DBConnect();
        Globals Global = new Globals();
        SqlCommand CMD;
        SqlDataReader Reader;
        SqlDataAdapter da; 

        public Frm_return()
        {
            InitializeComponent();
            if (dbConn.connection.State != ConnectionState.Open) dbConn.Open();
        }

        #region Functions     

        private void mnuDelete_Click(object sender, EventArgs e)
        {
            if (dgv_borrow.Rows.Count != 0)
            {
                DialogResult dx = MessageBox.Show("Are you sure do you want to remove " + dgv_borrow.Rows[dgv_borrow.CurrentCell.RowIndex].Cells[0].Value, "Delete", MessageBoxButtons.YesNo);
                if (dx == DialogResult.Yes)
                {
                    foreach (DataGridViewRow row in dgv_borrow.SelectedRows)
                    {
                        string xxx = dgv_borrow.Rows[dgv_borrow.CurrentCell.RowIndex].Cells[0].Value.ToString();
                        string xcode = xxx.Replace("'", "''");
                        CMD = new SqlCommand("SELECT BOOKID FROM TBL_BORROW WHERE TRANSAC = '" + xcode + "'", dbConn.connection);
                        Reader = CMD.ExecuteReader();
                        if (Reader.Read())
                        {
                            CMD = new SqlCommand("DELETE FROM TBL_BORROW WHERE TRANSAC = '" + xcode + "'", dbConn.connection);
                            CMD.ExecuteNonQuery();
                            if (!row.IsNewRow)
                                dgv_borrow.Rows.Remove(row);
                        }
                        else
                        {
                            if (!row.IsNewRow)
                                dgv_borrow.Rows.Remove(row);
                        }
                    }
                }
            }

        }

        public void ClearAll()
        {
            txt_transac.Text = "";
            txt_lrn.Text = "";
            txt_sname.Text = "";           
            txt_status.Text = " ";         
            txt_booktitle.Text = "";
            txt_bookid.Text = "";
            txt_due.Text = "";
            lblfine.Text = "0 php";
        }

        private void mnuSelectNewStudent_Click(object sender, EventArgs e)
        {
            CMD = new SqlCommand("SELECT * from TBL_BORROW WHERE TRANS = '" + dgv_borrow.Rows[dgv_borrow.CurrentCell.RowIndex].Cells[0].Value + "'", dbConn.connection);
            Reader = CMD.ExecuteReader();
            if (Reader.Read())
            {
                txt_transac.Text = Reader["TRANS"].ToString();
                txt_lrn.Text = Reader["LRN"].ToString();
                txt_sname.Text = Reader["STUDENTNAME"].ToString();
                txt_bookid.Text = Reader["BOOKID"].ToString();
                txt_booktitle.Text = Reader["BOOKTITLE"].ToString();
                dtp_borrow.Text = Reader["BORROWDATE"].ToString();
            }

        }
        #endregion

        private void dtp_return_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Frm_return_Load(object sender, EventArgs e)
        {           
            dtp_return.Text = DateTime.Now.ToShortDateString();
            txt_sname.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbo_lrn_SelectedValueChanged(object sender, EventArgs e)
        {
            
        }

        private void cbo_bookid_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbo_bookid_SelectedValueChanged(object sender, EventArgs e)
        {
         
        }

        private void dtp_return_ValueChanged_1(object sender, EventArgs e)
        {
            
        }

        private void cbo_lrn_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tsb_save_Click(object sender, EventArgs e)
        {

            CMD = new SqlCommand("UPDATE TBL_BORROW SET TRANS =  '" + txt_transac.Text.Replace("'", "''") + "',LRN ='" + txt_lrn.Text.Replace("'", "''") + "',STUDENTNAME ='" + txt_sname.Text.Replace("'", "''") + "',BOOKID='" + txt_bookid.Text.Replace("'", "''") + "',BOOKTITLE='" + txt_booktitle.Text.Replace("'", "''") + "' ,STATUS='" + txt_status.Text.Replace("'", "''") + "' ,BORROWDATE='" + this.dtp_borrow.Value.ToString("yyyy-MM-dd") + "'  ,RETURNDATE = '" + this.dtp_return.Value.ToString("yyyy-MM-dd") + "',DUE = '" + txt_due.Text.Replace("'", "''") + "',FINE ='" + lblfine.Text.Replace("'", "''") + "' WHERE TRANS = '" + txt_transac.Text + "'", dbConn.connection);
            CMD.ExecuteNonQuery();           
            ClearAll();
        }

        private void dtp_borrow_ValueChanged(object sender, EventArgs e)
        {          
            DateTime sdt = dtp_borrow.Value.Date;
            DateTime rdt = dtp_return.Value.Date;

            TimeSpan ts = rdt - sdt;

            int days = ts.Days;           
            if (days<=10)
            {               
                txt_status.Text = "Returned";
                txt_due.ForeColor = Color.Blue;
                txt_due.Text = "On-time";
                lblfine.Text = "0 php";
            }
            if (days <= 60 && days >= 11)
            {
                lblfine.Text = ((days - 10) * 5).ToString() + " php";
                txt_status.Text = "Returned";
                txt_due.ForeColor = Color.Red;
                txt_due.Text = (days - 10).ToString() + " Days Overdue";  
            }            
        }

        private void dgv_borrow_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            ContextMenuStrip mnu = new ContextMenuStrip();
            if (dgv_borrow.Rows.Count != 0)
            {
                if (e.Button == MouseButtons.Right)
                {
                    if (e.RowIndex == -1) return;
                    if (e.ColumnIndex == -1) return;

                    dgv_borrow.CurrentCell = dgv_borrow.Rows[e.RowIndex].Cells[e.ColumnIndex];
                    dgv_borrow.Rows[e.RowIndex].Selected = true;
                    dgv_borrow.Focus();


                    ToolStripMenuItem mnuSelect = new ToolStripMenuItem("Select");
                    mnuSelect.Image = Properties.Resources.arrow_left;

                    mnuSelect.Click += new EventHandler(mnuSelectNewStudent_Click);

                    mnu.Items.AddRange(new ToolStripItem[] { mnuSelect });

                    ToolStripMenuItem mnuDelete = new ToolStripMenuItem("Delete");
                    mnuDelete.Image = Properties.Resources.clear;

                    mnuDelete.Click += new EventHandler(mnuDelete_Click);

                    mnu.Items.AddRange(new ToolStripItem[] { mnuDelete });

                    dgv_borrow.ContextMenuStrip = mnu;
                }
            }
        }

        private void txt_transac_TextChanged(object sender, EventArgs e)
        {         
        }

        private void txt_booktitle_TextChanged(object sender, EventArgs e)
        {

        }

        private void tsb_clear_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void txt_lrn_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_sname_TextChanged(object sender, EventArgs e)
        {
            try
            {              
                    #region
                    SqlCommand comm = new SqlCommand();
                    SqlDataAdapter da = new SqlDataAdapter("select * from TBL_BORROW", dbConn.connection);
                    DataTable DT = new DataTable();
                    da.Fill(DT);
                    DataView HH = DT.DefaultView;
                    HH.RowFilter = "STUDENTNAME like'" + txt_sname.Text + "%'";
                    dgv_borrow.DataSource = HH;
                    #endregion
                }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load Results", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void dgv_borrow_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgv_borrow_CellMouseDown_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            ContextMenuStrip mnu = new ContextMenuStrip();
            if (dgv_borrow.Rows.Count != 0)
            {
                if (e.Button == MouseButtons.Right)
                {
                    if (e.RowIndex == -1) return;
                    if (e.ColumnIndex == -1) return;

                    dgv_borrow.CurrentCell = dgv_borrow.Rows[e.RowIndex].Cells[e.ColumnIndex];
                    dgv_borrow.Rows[e.RowIndex].Selected = true;
                    dgv_borrow.Focus();


                    ToolStripMenuItem mnuSelect = new ToolStripMenuItem("Select");
                    mnuSelect.Image = Properties.Resources.arrow_left;

                    mnuSelect.Click += new EventHandler(mnuSelectNewStudent_Click);

                    mnu.Items.AddRange(new ToolStripItem[] { mnuSelect });

                    ToolStripMenuItem mnuDelete = new ToolStripMenuItem("Delete");
                    mnuDelete.Image = Properties.Resources.clear;

                    mnuDelete.Click += new EventHandler(mnuDelete_Click);

                    mnu.Items.AddRange(new ToolStripItem[] { mnuDelete });

                    dgv_borrow.ContextMenuStrip = mnu;
                }
            }      
        }

        private void btn_report_Click(object sender, EventArgs e)
        {
            Frm_lost lostfrm = new Frm_lost();
            lostfrm.Show();
        }

        private void dgv_borrow_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txt_due_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblfine_Click(object sender, EventArgs e)
        {

        }

    }
}
