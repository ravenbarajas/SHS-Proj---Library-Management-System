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
    public partial class Frm_login : Form
    {
        DBConnect dbConn = new DBConnect();
        Globals Global = new Globals();
        SqlCommand CMD;
        SqlDataReader Reader;
        SqlDataAdapter da;    

        public Frm_login()
        {
            InitializeComponent();
            if (dbConn.connection.State != ConnectionState.Open) dbConn.Open();
        }
      

        private void Frm_login_Load(object sender, EventArgs e)
        {

        }

        private void Frm_login_Load_1(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(180,0,0,0);
            txt_username.BackColor = Color.FromArgb(0, 0, 0);
            txt_pass.BackColor = Color.FromArgb(0, 0, 0);
            cb_hide.Checked = true;

        }

        private void button2_Click(object sender, EventArgs e)
        {

            Frm_signup signfrm = new LIBRARYSYSTEM1202.Frm_signup();
            signfrm.ShowDialog();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
         
        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
 
        }

        private void button7_MouseLeave(object sender, EventArgs e)
        {
            button7.BackColor = Color.FromArgb(64, 64, 64);
        }

        private void button7_MouseMove(object sender, MouseEventArgs e)
        {
            button7.BackColor = Color.FromArgb(255, 0, 0);
        }

        private void txt_username_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

            if (txt_pass.Text == "" || txt_username.Text == "")
            {
                MessageBox.Show("Please Enter Username or Password");
                txt_username.Focus();
                return;
            }
            string pass = Global.base64Encode(txt_pass.Text);
            CMD = new SqlCommand("SELECT * FROM TBL_ACCOUNT WHERE USERNAME = '" + txt_username.Text + "' AND PASSWORD ='" + pass + "'", dbConn.connection);
            Reader = CMD.ExecuteReader();
            if (Reader.Read())
            {               
                this.Close();
            }
            else
            {
                MessageBox.Show("Incorrect Username or password", "Invalid Login", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txt_username.Clear();
                txt_pass.Clear();
                txt_username.Focus();
            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(cb_hide.Checked)
            {
                txt_pass.UseSystemPasswordChar = true;
            }
            else
            {
                txt_pass.UseSystemPasswordChar = false;
            }
        }

        private void txt_pass_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_pass_Enter(object sender, EventArgs e)
        {
            
           
        }

        private void btn_login_Enter(object sender, EventArgs e)
        {
            
        }

        private void Frm_login_Enter(object sender, EventArgs e)
        {
            
        }
    }
}
