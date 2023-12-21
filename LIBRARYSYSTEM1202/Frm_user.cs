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
    public partial class Frm_user : Form
    {
        DBConnect dbConn = new DBConnect();
        Globals Global = new Globals();
        SqlCommand CMD;
        SqlDataReader Reader;
        SqlDataAdapter da;
        
        public Frm_user()
        {
            InitializeComponent();
            if (dbConn.connection.State != ConnectionState.Open) dbConn.Open();
            
        }

        #region Functions
        public void LoadGrid()
        {
            CMD = new SqlCommand("Select * from TBL_STUDENT ", dbConn.connection);
            Reader = CMD.ExecuteReader();
            dgv_student.Rows.Clear();
            dgv_student.AllowUserToAddRows = true;
            while (Reader.Read())
            {
                DataGridViewRow row = (DataGridViewRow)dgv_student.Rows[0].Clone();
                row.Cells[0].Value = Reader["LRN"];
                row.Cells[1].Value = Reader["NAME"];
                row.Cells[2].Value = Reader["ADDRESS"];
                row.Cells[3].Value = Reader["CONTACTN"];
                row.Cells[4].Value = Reader["TRACKSTRAND"];
                row.Cells[5].Value = Reader["SECTION"];
                row.Cells[6].Value = Reader["PARENTNAME"];
                row.Cells[7].Value = Reader["PARENTCONTACT"];


                dgv_student.Rows.Add(row);
            }
            dgv_student.AllowUserToAddRows = false;
        }

        private void mnuDelete_Click(object sender, EventArgs e)
        {
            if (dgv_student.Rows.Count != 0)
            {
                DialogResult dx = MessageBox.Show("Are you sure do you want to remove " + dgv_student.Rows[dgv_student.CurrentCell.RowIndex].Cells[0].Value, "Delete", MessageBoxButtons.YesNo);
                if (dx == DialogResult.Yes)
                {
                    foreach (DataGridViewRow row in dgv_student.SelectedRows)
                    {
                        string xxx = dgv_student.Rows[dgv_student.CurrentCell.RowIndex].Cells[0].Value.ToString();
                        string xcode = xxx.Replace("'", "''");
                        CMD = new SqlCommand("SELECT LRN FROM TBL_STUDENT WHERE LRN = '" + xcode + "'", dbConn.connection);
                        Reader = CMD.ExecuteReader();
                        if (Reader.Read())
                        {
                            CMD = new SqlCommand("DELETE FROM TBL_STUDENT WHERE LRN = '" + xcode + "'", dbConn.connection);
                            CMD.ExecuteNonQuery();
                            if (!row.IsNewRow)
                                dgv_student.Rows.Remove(row);
                        }
                        else
                        {
                            if (!row.IsNewRow)
                                dgv_student.Rows.Remove(row);
                        }
                    }
                }
            }

        }       
        #endregion

        public void ClearAll()
        {
            txt_lrn.Text = "";
            txt_name.Text = "";
            txt_address.Text = "";
            txt_contact.Text = "";
            cbo_ts.Text = "";
            txt_section.Text = "";
            txt_pname.Text = "";
            txt_pcontact.Text = "";
            txt_lrn.Focus();
        }

        private void mnuSelectNewStudent_Click(object sender, EventArgs e)
        {

            CMD = new SqlCommand("SELECT * from TBL_STUDENT WHERE LRN = '" + dgv_student.Rows[dgv_student.CurrentCell.RowIndex].Cells[0].Value + "'", dbConn.connection);
            Reader = CMD.ExecuteReader();
            if (Reader.Read())
            {              
                txt_lrn.Text = Reader["LRN"].ToString();
                txt_name.Text = Reader["NAME"].ToString();
                txt_address.Text = Reader["ADDRESS"].ToString();
                txt_contact.Text = Reader["CONTACTN"].ToString();              
                cbo_ts.Text = Reader["TRACKSTRAND"].ToString();
                txt_section.Text = Reader["SECTION"].ToString();
                txt_pname.Text = Reader["PARENTNAME"].ToString();
                txt_pcontact.Text = Reader["PARENTCONTACT"].ToString();

            }

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Frm_user_Load(object sender, EventArgs e)
        {
            LoadGrid();
        } 

        private void btn_student_Click(object sender, EventArgs e)
        {
            
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
             
        }

        private void dgv_student_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Frm_user_MouseDown(object sender, MouseEventArgs e)
        {
            
            
        }       

        private void dgv_student_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {           
            ContextMenuStrip mnu = new ContextMenuStrip();
            if (dgv_student.Rows.Count != 0)
            {
                if (e.Button == MouseButtons.Right)
                {
                    if (e.RowIndex == -1) return;
                    if (e.ColumnIndex == -1) return;

                    dgv_student.CurrentCell = dgv_student.Rows[e.RowIndex].Cells[e.ColumnIndex];
                    dgv_student.Rows[e.RowIndex].Selected = true;
                    dgv_student.Focus();


                    ToolStripMenuItem mnuSelect = new ToolStripMenuItem("Edit");
                    mnuSelect.Image = Properties.Resources.arrow_left;

                    mnuSelect.Click += new EventHandler(mnuSelectNewStudent_Click);

                    mnu.Items.AddRange(new ToolStripItem[] { mnuSelect });

                    ToolStripMenuItem mnuDelete = new ToolStripMenuItem("Delete");
                    mnuDelete.Image = Properties.Resources.clear;

                    mnuDelete.Click += new EventHandler(mnuDelete_Click);

                    mnu.Items.AddRange(new ToolStripItem[] { mnuDelete });

                    dgv_student.ContextMenuStrip = mnu;
                
            }
        }

        }

        private void button1_Click(object sender, EventArgs e)
        {                
        }

        private void txt_searchusers_TextChanged(object sender, EventArgs e)
        {          
        }

        private void rbd_student_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void tsb_clear_Click(object sender, EventArgs e)
        {
            
        }

        private void tsb_load_Click(object sender, EventArgs e)
        {
            LoadGrid();
        }

        private void toolStripSeparator4_Click(object sender, EventArgs e)
        {

        }

        private void tsb_update_Click(object sender, EventArgs e)
        {
               
        }

        private void txt_pname_TextChanged(object sender, EventArgs e)
        {

        }

        private void toolStripButton3_Click_1(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            CMD = new SqlCommand("UPDATE TBL_STUDENT SET LRN =  '" + txt_lrn.Text.Replace("'", "''") + "',NAME ='" + txt_name.Text.Replace("'", "''") + "',ADDRESS='" + txt_address.Text.Replace("'", "''") + "',TRACKSTRAND='" + cbo_ts.Text.Replace("'", "''") + "' ,SECTION = '" + txt_section.Text + "' ,PARENTNAME = '" + txt_pname.Text + "' ,PARENTCONTACT = '" + txt_pcontact.Text + "' WHERE LRN = '" + txt_lrn.Text + "'", dbConn.connection);
            CMD.ExecuteNonQuery();
            LoadGrid();
            ClearAll();
        }

        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {

            CMD = new SqlCommand("SELECT * from TBL_STUDENT WHERE LRN = '" + txt_lrn.Text + "'", dbConn.connection);
            Reader = CMD.ExecuteReader();
            if (Reader.Read())
            {
                MessageBox.Show("Student LRN already exist");
                return;
            }

            if (txt_lrn.Text == "" || txt_name.Text == "" || txt_address.Text == "" || txt_contact.Text == "" || cbo_ts.Text == "" || txt_section.Text == "" || txt_pname.Text == "" || txt_pcontact.Text == "")
            {
                MessageBox.Show("One or more required field is missing.Please fill all the required fields");
                txt_lrn.Focus();
                return;
            }

            CMD = new SqlCommand("INSERT INTO TBL_student(LRN,NAME,ADDRESS,CONTACTN,TRACKSTRAND,SECTION,PARENTNAME,PARENTCONTACT)VALUES('" + txt_lrn.Text.Replace("'", "''") + "','" + txt_name.Text.Replace("'", "''") + "','" + txt_address.Text.Replace("'", "''") + "','" + txt_contact.Text + "','" + cbo_ts.Text + "','" + txt_section.Text + "','" + txt_pname.Text + "','" + txt_pcontact.Text + "')", dbConn.connection);
            CMD.ExecuteNonQuery();
            MessageBox.Show("Student added to Database");
            LoadGrid();
            ClearAll();
        }

        private void Frm_user_Enter(object sender, EventArgs e)
        {

        }
    }
}
