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
    public partial class Frm_signup : Form
    {
        DBConnect dbConn = new DBConnect();
        Globals Global = new Globals();
        SqlCommand CMD;
        SqlDataReader Reader;
        SqlDataAdapter da;    

        public Frm_signup()
        {
            InitializeComponent();
            if (dbConn.connection.State != ConnectionState.Open) dbConn.Open();
        }

        private void Frm_signup_Load(object sender, EventArgs e)
        {
            txt_firstname.Focus();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            
        }

        private void button4_Click(object sender, EventArgs e)
        {

            if (txt_username.Text == "" || txt_pass.Text == "" || txt_confirm.Text == "" || txt_firstname.Text == "" || txt_lastname.Text == "")
            {
                MessageBox.Show("One or more Required fields Missing");
                return;
            }

            CMD = new SqlCommand("SELECT * FROM TBL_ACCOUNT WHERE USERNAME = '" + txt_username.Text.Replace("'", "''") + "'", dbConn.connection);
            Reader = CMD.ExecuteReader();
            if (Reader.Read())
            {

                MessageBox.Show("User " + txt_username.Text + " Already Exist", "User Creation failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_username.Text = "";
                txt_pass.Text = "";
                txt_confirm.Text = "";
            }
            else
            {
                string tempPass = txt_pass.Text;
                CMD = new SqlCommand("INSERT INTO TBL_ACCOUNT(USERNAME,PASSWORD,FIRSTNAME,LASTNAME)VALUES('" + txt_username.Text.Replace("'", "''") + "','" + Global.base64Encode(tempPass) + "','" + txt_firstname.Text.Replace("'", "''") + "','" + txt_lastname.Text.Replace("'", "''") + "')", dbConn.connection);
                CMD.ExecuteNonQuery();
                MessageBox.Show("User " + txt_username.Text + " has been added to database", "User Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_username.Text = "";
                txt_pass.Text = "";
                txt_confirm.Text = "";
                txt_firstname.Text = "";
                txt_lastname.Text = "";
                this.Close();
            }   
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cb_hide_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_hide.Checked)
            {
                txt_pass.UseSystemPasswordChar = true;
                txt_confirm.UseSystemPasswordChar = true;
            }
            else
            {
                txt_pass.UseSystemPasswordChar = false;
                txt_confirm.UseSystemPasswordChar = false;
            }
        }
    }
}
