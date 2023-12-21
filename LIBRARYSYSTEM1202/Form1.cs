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
    public partial class Form1 : Form
    {
        DBConnect dbConn = new DBConnect();
        Globals Global = new Globals();
        SqlCommand CMD;
        SqlDataReader Reader;
        SqlDataAdapter da;     

        public Form1()
        {
            InitializeComponent();
            if (dbConn.connection.State != ConnectionState.Open) dbConn.Open();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Frm_login logfrm = new Frm_login();
            logfrm.ShowDialog();           
            lbl_date.Text = DateTime.Now.ToString("MM / dd / yyyy");                   
            clock_timer.Start();

           
        }
        #region Functions


        
        #endregion

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {           
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            btn_users.BackColor = System.Drawing.Color.DarkSeaGreen;
            btn_books.BackColor = System.Drawing.Color.White;
            btn_borrow.BackColor = System.Drawing.Color.White;
            btn_return.BackColor = System.Drawing.Color.White;
            btn_archive.BackColor = System.Drawing.Color.White;

            panel4.Controls.Clear();
            Frm_user userfrm = new Frm_user();
            userfrm.TopLevel = false;
            userfrm.Dock = DockStyle.None;
            panel4.Controls.Add(userfrm);
            userfrm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            btn_users.BackColor = System.Drawing.Color.White;
            btn_books.BackColor = System.Drawing.Color.DarkSeaGreen;
            btn_borrow.BackColor = System.Drawing.Color.White;
            btn_return.BackColor = System.Drawing.Color.White;
            btn_archive.BackColor = System.Drawing.Color.White;

            panel4.Controls.Clear();
            Frm_books booksfrm = new Frm_books();
            booksfrm.TopLevel = false;
            booksfrm.Dock = DockStyle.None;
            panel4.Controls.Add(booksfrm);
            booksfrm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            btn_users.BackColor = System.Drawing.Color.White;
            btn_books.BackColor = System.Drawing.Color.White;
            btn_borrow.BackColor = System.Drawing.Color.DarkSeaGreen;
            btn_return.BackColor = System.Drawing.Color.White;
            btn_archive.BackColor = System.Drawing.Color.White;

            panel4.Controls.Clear();
            Frm_borrow borrowfrm = new Frm_borrow();
            borrowfrm.TopLevel = false;
            borrowfrm.Dock = DockStyle.None;
            panel4.Controls.Add(borrowfrm);
            borrowfrm.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {

        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void button7_MouseHover(object sender, EventArgs e)
        {           
        }

        private void button7_MouseLeave(object sender, EventArgs e)
        {           
        }

        private void button5_Click(object sender, EventArgs e)
        {
            btn_users.BackColor = System.Drawing.Color.White;
            btn_books.BackColor = System.Drawing.Color.White;
            btn_borrow.BackColor = System.Drawing.Color.White;
            btn_return.BackColor = System.Drawing.Color.DarkSeaGreen;
            btn_archive.BackColor = System.Drawing.Color.White;

            panel4.Controls.Clear();
            Frm_return returnfrm = new Frm_return();
            returnfrm.TopLevel = false;
            returnfrm.Dock = DockStyle.None;
            panel4.Controls.Add(returnfrm);
            returnfrm.Show();
        }

        private void button6_Click_1(object sender, EventArgs e)
        {          
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Frm_about aboutfrm = new Frm_about();
            aboutfrm.Show();
        }

        private void button8_MouseHover(object sender, EventArgs e)
        {           
        }

        private void button8_MouseLeave(object sender, EventArgs e)
        {           
        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            Frm_login loginfrm = new Frm_login();
            loginfrm.Show();
            this.Hide();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void btn_about_Click(object sender, EventArgs e)
        {
            Frm_about aboutfrm = new Frm_about();
            aboutfrm.Show();
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_about_MouseHover(object sender, EventArgs e)
        {
            btn_about.BackColor = Color.FromArgb(0, 0, 255);
        }

        private void btn_exit_MouseHover(object sender, EventArgs e)
        {
            btn_exit.BackColor = Color.FromArgb(255, 0, 0);
        }

        private void btn_exit_MouseLeave(object sender, EventArgs e)
        {
            btn_exit.BackColor = Color.FromArgb(64, 64, 64 );
        }

        private void btn_about_MouseLeave(object sender, EventArgs e)
        {
            btn_about.BackColor = Color.FromArgb(64, 64, 64);
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
        }

        private void btn_minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void btn_search_Click(object sender, EventArgs e)
        {           
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void clock_timer_Tick(object sender, EventArgs e)
        {
            lbl_time.Text = DateTime.Now.ToString("hh : mm : ss tt");
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            btn_users.BackColor = System.Drawing.Color.White;
            btn_books.BackColor = System.Drawing.Color.White;
            btn_borrow.BackColor = System.Drawing.Color.White;
            btn_return.BackColor = System.Drawing.Color.White;
            btn_archive.BackColor = System.Drawing.Color.DarkSeaGreen;

            panel4.Controls.Clear();
            Frm_reporting reportingfrm = new Frm_reporting();
            reportingfrm.TopLevel = false;
            reportingfrm.Dock = DockStyle.None;
            panel4.Controls.Add(reportingfrm);
            reportingfrm.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lbl_user_Click(object sender, EventArgs e)
        {

        }
    }
}
