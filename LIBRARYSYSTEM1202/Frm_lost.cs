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
    public partial class Frm_lost : Form
    {
        DBConnect dbConn = new DBConnect();
        Globals Global = new Globals();
        SqlCommand CMD;
        SqlDataReader Reader;
        SqlDataAdapter da; 

        public Frm_lost()
        {
            InitializeComponent();
            if (dbConn.connection.State != ConnectionState.Open) dbConn.Open();
        }

        private void Frm_lost_Load(object sender, EventArgs e)
        {
            txt_sname.Focus();
        }
        #region Funtions

        public void ClearAll()
        {
            txt_transac.Text = "";
            txt_lrn.Text = "";
            txt_sname.Text = "";
            txt_status.Text = " ";
            txt_booktitle.Text = "";
            txt_bookid.Text = "";          
            txt_fine.Text = "0 php";
        }
        private void mnuSelectNewStudent_Click(object sender, EventArgs e)
        {
            CMD = new SqlCommand("SELECT * from TBL_BORROW WHERE TRANS = '" + dgv_info.Rows[dgv_info.CurrentCell.RowIndex].Cells[0].Value + "'", dbConn.connection);
            Reader = CMD.ExecuteReader();
            if (Reader.Read())
            {
                txt_transac.Text = Reader["TRANS"].ToString();
                txt_lrn.Text = Reader["LRN"].ToString();
                txt_sname.Text = Reader["STUDENTNAME"].ToString();               
                txt_booktitle.Text = Reader["BOOKTITLE"].ToString();
                return;                    
            }

            CMD = new SqlCommand("SELECT * from TBL_BOOKS WHERE BOOKID = '" + dgv_info.Rows[dgv_info.CurrentCell.RowIndex].Cells[0].Value + "'", dbConn.connection);
            Reader = CMD.ExecuteReader();
            if (Reader.Read())
            {
                txt_bookid.Text = Reader["BOOKID"].ToString();
                txt_fine.Text = Reader["PRICE"].ToString();
                return;
            }       
        }
        private void mnuSelectNewBook_Click(object sender, EventArgs e)
        {
            
        }      


        #endregion

        private void txt_booktitle_TextChanged(object sender, EventArgs e)
        {
            txt_status.Text = "Lost";
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
                dgv_info.DataSource = HH;
                #endregion
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load Results", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            CMD = new SqlCommand("UPDATE TBL_BORROW SET TRANS =  '" + txt_transac.Text.Replace("'", "''") + "',LRN ='" + txt_lrn.Text.Replace("'", "''") + "',STUDENTNAME ='" + txt_sname.Text.Replace("'", "''") + "',BOOKID='" + txt_bookid.Text.Replace("'", "''") + "',BOOKTITLE='" + txt_booktitle.Text.Replace("'", "''") + "' ,STATUS='" + txt_status.Text.Replace("'", "''") + "',FINE ='" + txt_fine.Text.Replace("'", "''") + "' WHERE TRANS = '" + txt_transac.Text + "'", dbConn.connection);
            CMD.ExecuteNonQuery();
            MessageBox.Show("Lost Book Reported!");
            ClearAll();
        }

        private void dgv_borrow_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
         
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_bookid_TextChanged(object sender, EventArgs e)
        {
            try
            {
                #region
                SqlCommand comm = new SqlCommand();
                SqlDataAdapter da = new SqlDataAdapter("select * from TBL_BOOKS", dbConn.connection);
                DataTable DT = new DataTable();
                da.Fill(DT);
                DataView HH = DT.DefaultView;
                HH.RowFilter = "BOOKID like'" + txt_bookid.Text + "%'";
                dgv_info.DataSource = HH;
                #endregion
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load Results", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void dgv_info_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
          
        }

        private void btn_exit_MouseHover(object sender, EventArgs e)
        {
            btn_exit.BackColor = Color.FromArgb(255, 0, 0);
        }

        private void btn_exit_MouseLeave(object sender, EventArgs e)
        {
            btn_exit.BackColor = Color.WhiteSmoke;
        }

        private void txt_status_TextChanged(object sender, EventArgs e)
        {
            try
            {
                #region
                SqlCommand comm = new SqlCommand();
                SqlDataAdapter da = new SqlDataAdapter("select * from TBL_BOOKS", dbConn.connection);
                DataTable DT = new DataTable();
                da.Fill(DT);
                DataView HH = DT.DefaultView;
                HH.RowFilter = "BOOKID like'" + txt_bookid.Text + "%'";
                dgv_info.DataSource = HH;
                #endregion
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load Results", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void txt_fine_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgv_info_CellMouseDown_1(object sender, DataGridViewCellMouseEventArgs e)
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


                    ToolStripMenuItem mnuSelect = new ToolStripMenuItem("Edit");
                    mnuSelect.Image = Properties.Resources.arrow_left;

                    mnuSelect.Click += new EventHandler(mnuSelectNewStudent_Click);

                    mnu.Items.AddRange(new ToolStripItem[] { mnuSelect });

                    dgv_info.ContextMenuStrip = mnu;
                }
            }
        }

        private void dgv_info_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txt_lrn_TextChanged(object sender, EventArgs e)
        {

        }
      
    }
}
