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
    public partial class Frm_books : Form
    {
        DBConnect dbConn = new DBConnect();
        Globals Global = new Globals();
        SqlCommand CMD;
        SqlDataReader Reader;
        SqlDataAdapter da;     

        public Frm_books()
        {
            InitializeComponent();
            if (dbConn.connection.State != ConnectionState.Open) dbConn.Open();
        }

#region Functions

        public void updateData()
        {
            
        }

        public void LoadGrid()
        {
        CMD = new SqlCommand("Select * from TBL_BOOKS ", dbConn.connection);
            Reader = CMD.ExecuteReader();
            dgv_books.Rows.Clear();
            dgv_books.AllowUserToAddRows = true;
            while (Reader.Read())
            {
                DataGridViewRow row = (DataGridViewRow)dgv_books.Rows[0].Clone();
                row.Cells[0].Value = Reader["BOOKID"];
                row.Cells[1].Value = Reader["CATEGO"];
                row.Cells[2].Value = Reader["TITLE"];
                row.Cells[3].Value = Reader["AUTHOR"];
                row.Cells[4].Value = Reader["YEARPUB"];
                row.Cells[5].Value = Reader["DESCRIPTION"];
                row.Cells[6].Value = Reader["PRICE"];
                

                dgv_books.Rows.Add(row);
            }
            dgv_books.AllowUserToAddRows = false;
}

        private void mnuDelete_Click(object sender, EventArgs e)
        {
            if (dgv_books.Rows.Count != 0)
            {
                DialogResult dx = MessageBox.Show("Are you sure do you want to remove " + dgv_books.Rows[dgv_books.CurrentCell.RowIndex].Cells[0].Value, "Delete", MessageBoxButtons.YesNo);
                if (dx == DialogResult.Yes)
                {
                    foreach (DataGridViewRow row in dgv_books.SelectedRows)
                    {
                        string xxx = dgv_books.Rows[dgv_books.CurrentCell.RowIndex].Cells[0].Value.ToString();
                        string xcode = xxx.Replace("'", "''");
                        CMD = new SqlCommand("SELECT BOOKID FROM TBL_BOOKS WHERE BOOKID = '" + xcode + "'", dbConn.connection);
                        Reader = CMD.ExecuteReader();
                        if (Reader.Read())
                        {
                            CMD = new SqlCommand("DELETE FROM TBL_BOOKS WHERE BOOKID = '" + xcode + "'", dbConn.connection);
                            CMD.ExecuteNonQuery();
                            if (!row.IsNewRow)
                                dgv_books.Rows.Remove(row);
                        }
                        else
                        {
                            if (!row.IsNewRow)
                                dgv_books.Rows.Remove(row);
                        }
                    }
                }
            }

        }    
#endregion

       
        public void ClearAll()
        {
            txt_bookid.Text = "2019-";
            cbo_category.Text = "";
            txt_title.Text = "";
            txt_author.Text = "";
            txt_yp.Text = "";
            txt_desc.Text = "";
            txt_price.Text = "";
            txt_status.Text = "*Newly Added"; 

        }
        private void mnuSelectNewStudent_Click(object sender, EventArgs e)
        {

            CMD = new SqlCommand("SELECT * from TBL_BOOKS WHERE BOOKID = '" + dgv_books.Rows[dgv_books.CurrentCell.RowIndex].Cells[0].Value + "'", dbConn.connection);
            Reader = CMD.ExecuteReader();
            if (Reader.Read())
            {
                txt_bookid.Text = Reader["BOOKID"].ToString();
                cbo_category.Text = Reader["CATEGO"].ToString();
                txt_title.Text = Reader["TITLE"].ToString();
                txt_author.Text = Reader["AUTHOR"].ToString();
                txt_yp.Text = Reader["YEARPUB"].ToString();
                txt_desc.Text = Reader["DESCRIPTION"].ToString();
                txt_price.Text = Reader["PRICE"].ToString();
                txt_status.Text = Reader["STATUS"].ToString();
            }

        }
        private void Frm_books_Load(object sender, EventArgs e)
        {
            LoadGrid();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {        
        }

        private void dgv_books_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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


                    ToolStripMenuItem mnuSelect = new ToolStripMenuItem("Edit");
                    mnuSelect.Image = Properties.Resources.arrow_left;

                    mnuSelect.Click += new EventHandler(mnuSelectNewStudent_Click);

                    mnu.Items.AddRange(new ToolStripItem[] { mnuSelect });

                    ToolStripMenuItem mnuDelete = new ToolStripMenuItem("Delete");
                    mnuDelete.Image = Properties.Resources.clear;

                    mnuDelete.Click += new EventHandler(mnuDelete_Click);

                    mnu.Items.AddRange(new ToolStripItem[] { mnuDelete });

                    dgv_books.ContextMenuStrip = mnu;
                }
            }
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void button1_Click(object sender, EventArgs e)
        {        
        }

        private void txt_searchbooks_TextChanged(object sender, EventArgs e)
        {         
        }

        private void button2_Click(object sender, EventArgs e)
        {            
        }

        private void tsb_save_Click(object sender, EventArgs e)
        {
           
        }

        private void toolStripSeparator3_Click(object sender, EventArgs e)
        {

        }

        private void tsb_update_Click(object sender, EventArgs e)
        {
            CMD = new SqlCommand("UPDATE TBL_BOOKS SET BOOKID =  '" + txt_bookid.Text.Replace("'", "''") + "',CATEGO ='" + cbo_category.Text.Replace("'", "''") + "',TITLE='" + txt_title.Text.Replace("'", "''") + "',AUTHOR='" + txt_author.Text.Replace("'", "''") + "',YEARPUB='" + txt_yp.Text.Replace("'", "''") + "'  ,DESCRIPTION = '" + txt_desc.Text.Replace("'", "''") + "' ,PRICE = '" + txt_price.Text + "' WHERE BOOKID = '" + txt_bookid.Text + "'", dbConn.connection);
            CMD.ExecuteNonQuery();
            LoadGrid();
            ClearAll();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {           
        }

        private void btn_save_Click(object sender, EventArgs e)
        {         
        }

        private void tsb_save_Click_1(object sender, EventArgs e)
        {
            CMD = new SqlCommand("SELECT * from TBL_BOOKS WHERE BOOKID = '" + txt_bookid.Text + "'", dbConn.connection);
            Reader = CMD.ExecuteReader();
            if (Reader.Read())
            {
                MessageBox.Show("BOOK ID  already exist");
                return;
            }

            if (txt_bookid.Text == "" || cbo_category.Text == "" || txt_title.Text == "" || txt_author.Text == "" || txt_yp.Text == "" || txt_desc.Text == "" || txt_price.Text == "" || txt_status.Text == "")
            {
                MessageBox.Show("One or more required field is missing.Please fill all the required fields");
                txt_bookid.Focus();
                return;
            }

            CMD = new SqlCommand("INSERT INTO TBL_BOOKS(BOOKID,CATEGO,TITLE,AUTHOR,YEARPUB,DESCRIPTION,PRICE,STATUS)VALUES('" + txt_bookid.Text + "','" + cbo_category.Text.Replace("'", "''") + "','" + txt_title.Text.Replace("'", "''") + "','" + txt_author.Text + "','" + txt_yp.Text + "','" + txt_desc.Text.Replace("'", "''") +  "','" + txt_price.Text.Replace("'", "''") + "','" + txt_status.Text.Replace("'", "''") + "')", dbConn.connection);
            CMD.ExecuteNonQuery();
            MessageBox.Show("Book added to database");
            LoadGrid();
            ClearAll();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txt_quantity_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_bookid_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
