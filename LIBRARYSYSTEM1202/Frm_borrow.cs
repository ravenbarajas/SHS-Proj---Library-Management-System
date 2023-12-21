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
    public partial class Frm_borrow : Form
    {
        DBConnect dbConn = new DBConnect();
        Globals Global = new Globals();
        SqlCommand CMD;
        SqlDataReader Reader;
        SqlDataAdapter da;
        String fcode;

        public Frm_borrow()
        {
            InitializeComponent();
            if (dbConn.connection.State != ConnectionState.Open) dbConn.Open();
        }

        #region Functions

        public void UpdateData()
        {
            CMD = new SqlCommand("SELECT * FROM TBL_BCODE  WHERE prefix = 'TRANS'", dbConn.connection);
            Reader = CMD.ExecuteReader();
            if (Reader.Read())
            {
                string pcode = Reader["pcode"].ToString();
                int newcode = Convert.ToInt32(pcode);
                newcode = newcode + 1;
                string ncode = newcode.ToString();
                int nameLength = ncode.Length;
                if (nameLength == 1)
                {
                    fcode = "000000" + ncode;
                }

                if (nameLength == 2)
                {
                    fcode = "00000" + ncode;
                }
                if (nameLength == 3)
                {
                    fcode = "0000" + ncode;
                }
                if (nameLength == 4)
                {
                    fcode = "0000" + ncode;
                }
                CMD = new SqlCommand("UPDATE TBL_BCODE SET pcode =  '" + fcode + "' where prefix = 'TRANS'", dbConn.connection);
                CMD.ExecuteNonQuery();
            }

        }

        public void LoadGrid()
        {
            CMD = new SqlCommand("Select * from TBL_BORROW ", dbConn.connection);
            Reader = CMD.ExecuteReader();
            dgv_borrow.Rows.Clear();
            dgv_borrow.AllowUserToAddRows = true;
            while (Reader.Read())
            {
                DataGridViewRow row = (DataGridViewRow)dgv_borrow.Rows[0].Clone();
                row.Cells[0].Value = Reader["TRANS"];
                row.Cells[1].Value = Reader["LRN"];
                row.Cells[2].Value = Reader["STUDENTNAME"];
                row.Cells[3].Value = Reader["TRACKSTRAND"];
                row.Cells[4].Value = Reader["SECTION"];
                row.Cells[5].Value = Reader["BOOKID"];
                row.Cells[6].Value = Reader["BOOKTITLE"];
                row.Cells[7].Value = Reader["STATUS"];
                row.Cells[8].Value = Reader["BORROWDATE"];
             
             
                dgv_borrow.Rows.Add(row);
            }          
            dgv_borrow.AllowUserToAddRows = false;
        }       

        private void GenerateCode()
        {
            Global.Gen_Code(txt_transac, "TBL_BCODE", "pcode", "TRANS");
        }

        private void mnuSelectNewStudent_Click(object sender, EventArgs e)
        {

            CMD = new SqlCommand("SELECT * from TBL_STUDENT WHERE LRN = '" + dgv_books.Rows[dgv_books.CurrentCell.RowIndex].Cells[0].Value + "'", dbConn.connection);
            Reader = CMD.ExecuteReader();
            if (Reader.Read())
            {
                txt_lrn.Text = Reader["LRN"].ToString();
                txt_sname.Text = Reader["NAME"].ToString();
                cbo_ts.Text = Reader["TRACKSTRAND"].ToString();
                txt_section.Text = Reader["SECTION"].ToString();
                return;
            }

            CMD = new SqlCommand("SELECT * from TBL_BOOKS WHERE BOOKID = '" + dgv_books.Rows[dgv_books.CurrentCell.RowIndex].Cells[0].Value + "'", dbConn.connection);
            Reader = CMD.ExecuteReader();
            if (Reader.Read())
            {
                txt_bookid.Text = Reader["BOOKID"].ToString();
                txt_booktitle.Text = Reader["TITLE"].ToString();
                return;
            }

        }

        private void mnuSelectNewBook_Click(object sender, EventArgs e)
        {

            
        }
       
        #endregion

        public void ClearAll()
        {          
            txt_lrn.Text = "";
            txt_sname.Text = "";
            txt_section.Text = " ";
            txt_status.Text = " ";
            cbo_ts.Text = " ";
            txt_booktitle.Text = "";
            txt_bookid.Text = "";                 
        }

        private void Frm_borrow_Load(object sender, EventArgs e)
        {
            LoadGrid();
            dtp_borrow.Text = DateTime.Now.ToShortDateString();
            Global.Gen_Code(txt_transac, "TBL_BCODE", "pcode", "TRANS");
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

        private void dgv_student_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            if (txt_transac.Text == "" || txt_lrn.Text == "" || txt_sname.Text == "" || cbo_ts.Text == "" || txt_section.Text == "" || txt_bookid.Text == "" || txt_booktitle.Text == "" ||txt_status.Text == "")
            {
                MessageBox.Show("One or more required filed missing pls fill all the required fields");
                txt_bookid.Focus();
                return;
            }

            CMD = new SqlCommand("INSERT INTO TBL_BORROW (TRANS,LRN,STUDENTNAME,TRACKSTRAND,SECTION,BOOKID,BOOKTITLE,STATUS,BORROWDATE)VALUES('" + txt_transac.Text.Replace("'", "''") + "','" + txt_lrn.Text.Replace("'", "''") + "','" + txt_sname.Text.Replace("'", "''") + "','" + cbo_ts.Text.Replace("'", "''") + "','" + txt_section.Text + "','" + txt_bookid.Text.Replace("'", "''") + "','" + txt_booktitle.Text + "','" + txt_status.Text + "','" + this.dtp_borrow.Value.ToString("yyyy-MM-dd") + "')", dbConn.connection);
            CMD.ExecuteNonQuery();
            MessageBox.Show("Transaction Success / Updated", "Confirm Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
            UpdateData();           
            LoadGrid();           
            ClearAll();                  
        }

        private void dtp_borrow_ValueChanged(object sender, EventArgs e)
        {
            DateTime.Now.ToString();
        }

        private void dtp_return_ValueChanged(object sender, EventArgs e)
        {            
        }

        private void cbo_status_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {                                       
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            ClearAll();
            Global.Gen_Code(txt_transac, "tbl_bcode", "pcode", "TRANS");
        }
        private void toolStripButton4_Click(object sender, EventArgs e)
        {           
        }

        private void txt_generate_Click(object sender, EventArgs e)
        {
        }

        private void txt_lrn_TextChanged(object sender, EventArgs e)
        {
           
        }    
      
        private void txt_transac_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_booktitle_TextChanged(object sender, EventArgs e)
        {
            txt_status.Text = "Borrowed".ToString();   
        }

        private void txt_status_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgv_borrow_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            
            
        }          

        private void cbo_lrn_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void cbo_lrn_SelectedValueChanged(object sender, EventArgs e)
        {           
        }

        private void cbo_bookid_SelectedValueChanged(object sender, EventArgs e)
        {
           
        }

        private void cbo_lrn_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void cbo_bookid_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                #region
                SqlCommand comm = new SqlCommand();
                SqlDataAdapter da = new SqlDataAdapter("select * from TBL_STUDENT", dbConn.connection);
                DataTable DT = new DataTable();
                da.Fill(DT);
                DataView HH = DT.DefaultView;
                HH.RowFilter = "LRN like'" + txt_lrn.Text + "%'";
                dgv_books.DataSource = HH;
                #endregion
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load Results", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
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
                dgv_books.DataSource = HH;
                #endregion
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load Results", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void dgv_books_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {         
            ContextMenuStrip mnu = new ContextMenuStrip();
            if (dgv_books.Rows.Count != 0)
            {
                if (e.Button == MouseButtons.Right)
                {
                    if (e.RowIndex == -1) return;
                    if (e.ColumnIndex == -1) return;

                    dgv_books.CurrentCell = dgv_books.Rows[e.RowIndex].Cells[e.ColumnIndex];
                    dgv_books.Rows[e.RowIndex].Selected = true;
                    dgv_books.Focus();


                    ToolStripMenuItem mnuSelect = new ToolStripMenuItem("Select");
                    mnuSelect.Image = Properties.Resources.arrow_left;

                    mnuSelect.Click += new EventHandler(mnuSelectNewStudent_Click);

                    mnuSelect.Click += new EventHandler(mnuSelectNewBook_Click);

                    mnu.Items.AddRange(new ToolStripItem[] { mnuSelect });

                    dgv_books.ContextMenuStrip = mnu;
                }                
            }
        }

        private void tsb_reciept_Click(object sender, EventArgs e)
        {
            
        }

        private void txt_sname_TextChanged(object sender, EventArgs e)
        {
            try
            {
                #region
                SqlCommand comm = new SqlCommand();
                SqlDataAdapter da = new SqlDataAdapter("select * from TBL_STUDENT", dbConn.connection);
                DataTable DT = new DataTable();
                da.Fill(DT);
                DataView HH = DT.DefaultView;
                HH.RowFilter = "NAME like'" + txt_sname.Text + "%'";
                dgv_books.DataSource = HH;
                #endregion
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load Results", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Globals.ID = "Checkout";
            Globals.ID = txt_transac.Text;
            Frm_Reports reportsfrm = new Frm_Reports();
            reportsfrm.ShowDialog();
            GenerateCode();
         
        }

        private void lbl_date_Click(object sender, EventArgs e)
        {

        }          
        

        
    }
}
