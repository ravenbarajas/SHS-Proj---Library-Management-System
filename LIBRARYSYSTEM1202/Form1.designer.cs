namespace LIBRARYSYSTEM1202
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.img_icons = new System.Windows.Forms.ImageList(this.components);
            this.panel6 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_user = new System.Windows.Forms.Label();
            this.lbl_date = new System.Windows.Forms.Label();
            this.lbl_time = new System.Windows.Forms.Label();
            this.btn_out = new System.Windows.Forms.Button();
            this.img_icons1 = new System.Windows.Forms.ImageList(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_maximize = new System.Windows.Forms.Button();
            this.btn_minimize = new System.Windows.Forms.Button();
            this.btn_about = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.clock_timer = new System.Windows.Forms.Timer(this.components);
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btn_books = new System.Windows.Forms.Button();
            this.btn_users = new System.Windows.Forms.Button();
            this.btn_return = new System.Windows.Forms.Button();
            this.btn_borrow = new System.Windows.Forms.Button();
            this.btn_archive = new System.Windows.Forms.Button();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // img_icons
            // 
            this.img_icons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_icons.ImageStream")));
            this.img_icons.TransparentColor = System.Drawing.Color.Transparent;
            this.img_icons.Images.SetKeyName(0, "books.png");
            this.img_icons.Images.SetKeyName(1, "borrow.png");
            this.img_icons.Images.SetKeyName(2, "return.png");
            this.img_icons.Images.SetKeyName(3, "Search.png");
            this.img_icons.Images.SetKeyName(4, "users.png");
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.DimGray;
            this.panel6.Controls.Add(this.label2);
            this.panel6.Controls.Add(this.lbl_user);
            this.panel6.Controls.Add(this.lbl_date);
            this.panel6.Controls.Add(this.lbl_time);
            this.panel6.Controls.Add(this.btn_out);
            this.panel6.Location = new System.Drawing.Point(-1, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(275, 143);
            this.panel6.TabIndex = 0;
            this.panel6.Paint += new System.Windows.Forms.PaintEventHandler(this.panel6_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(8, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 25;
            this.label2.Text = "Welcome !";
            // 
            // lbl_user
            // 
            this.lbl_user.AutoSize = true;
            this.lbl_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_user.ForeColor = System.Drawing.Color.White;
            this.lbl_user.Location = new System.Drawing.Point(7, 41);
            this.lbl_user.Name = "lbl_user";
            this.lbl_user.Size = new System.Drawing.Size(49, 24);
            this.lbl_user.TabIndex = 25;
            this.lbl_user.Text = "User";
            this.lbl_user.Click += new System.EventHandler(this.lbl_user_Click);
            // 
            // lbl_date
            // 
            this.lbl_date.AutoSize = true;
            this.lbl_date.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_date.ForeColor = System.Drawing.Color.White;
            this.lbl_date.Location = new System.Drawing.Point(7, 79);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(69, 25);
            this.lbl_date.TabIndex = 8;
            this.lbl_date.Text = "Date :";
            // 
            // lbl_time
            // 
            this.lbl_time.AutoSize = true;
            this.lbl_time.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_time.ForeColor = System.Drawing.Color.White;
            this.lbl_time.Location = new System.Drawing.Point(7, 114);
            this.lbl_time.Name = "lbl_time";
            this.lbl_time.Size = new System.Drawing.Size(71, 25);
            this.lbl_time.TabIndex = 7;
            this.lbl_time.Text = "Time :";
            this.lbl_time.Click += new System.EventHandler(this.label4_Click);
            // 
            // btn_out
            // 
            this.btn_out.BackColor = System.Drawing.Color.Transparent;
            this.btn_out.FlatAppearance.BorderSize = 0;
            this.btn_out.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_out.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_out.ForeColor = System.Drawing.Color.White;
            this.btn_out.ImageKey = "logout.png";
            this.btn_out.ImageList = this.img_icons1;
            this.btn_out.Location = new System.Drawing.Point(214, 3);
            this.btn_out.Margin = new System.Windows.Forms.Padding(0);
            this.btn_out.Name = "btn_out";
            this.btn_out.Size = new System.Drawing.Size(58, 60);
            this.btn_out.TabIndex = 0;
            this.btn_out.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_out.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_out.UseVisualStyleBackColor = false;
            this.btn_out.Click += new System.EventHandler(this.button9_Click_1);
            // 
            // img_icons1
            // 
            this.img_icons1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_icons1.ImageStream")));
            this.img_icons1.TransparentColor = System.Drawing.Color.Transparent;
            this.img_icons1.Images.SetKeyName(0, "logout.png");
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.panel2.Location = new System.Drawing.Point(274, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1094, 10);
            this.panel2.TabIndex = 2;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // btn_maximize
            // 
            this.btn_maximize.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_maximize.BackColor = System.Drawing.Color.Transparent;
            this.btn_maximize.FlatAppearance.BorderSize = 0;
            this.btn_maximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_maximize.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_maximize.ForeColor = System.Drawing.Color.White;
            this.btn_maximize.Location = new System.Drawing.Point(1028, 3);
            this.btn_maximize.Name = "btn_maximize";
            this.btn_maximize.Size = new System.Drawing.Size(30, 33);
            this.btn_maximize.TabIndex = 24;
            this.btn_maximize.Text = "□";
            this.btn_maximize.UseVisualStyleBackColor = false;
            this.btn_maximize.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // btn_minimize
            // 
            this.btn_minimize.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_minimize.BackColor = System.Drawing.Color.Transparent;
            this.btn_minimize.FlatAppearance.BorderSize = 0;
            this.btn_minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_minimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_minimize.ForeColor = System.Drawing.Color.White;
            this.btn_minimize.Location = new System.Drawing.Point(992, 3);
            this.btn_minimize.Name = "btn_minimize";
            this.btn_minimize.Size = new System.Drawing.Size(30, 33);
            this.btn_minimize.TabIndex = 23;
            this.btn_minimize.Text = "_";
            this.btn_minimize.UseVisualStyleBackColor = false;
            this.btn_minimize.Click += new System.EventHandler(this.btn_minimize_Click);
            // 
            // btn_about
            // 
            this.btn_about.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_about.BackColor = System.Drawing.Color.Transparent;
            this.btn_about.FlatAppearance.BorderSize = 0;
            this.btn_about.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_about.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_about.ForeColor = System.Drawing.Color.White;
            this.btn_about.Location = new System.Drawing.Point(959, 5);
            this.btn_about.Name = "btn_about";
            this.btn_about.Size = new System.Drawing.Size(30, 33);
            this.btn_about.TabIndex = 22;
            this.btn_about.Text = "?";
            this.btn_about.UseVisualStyleBackColor = false;
            this.btn_about.Click += new System.EventHandler(this.btn_about_Click);
            this.btn_about.MouseLeave += new System.EventHandler(this.btn_about_MouseLeave);
            this.btn_about.MouseHover += new System.EventHandler(this.btn_about_MouseHover);
            // 
            // btn_exit
            // 
            this.btn_exit.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_exit.BackColor = System.Drawing.Color.Transparent;
            this.btn_exit.FlatAppearance.BorderSize = 0;
            this.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit.ForeColor = System.Drawing.Color.White;
            this.btn_exit.Location = new System.Drawing.Point(1064, 3);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(30, 33);
            this.btn_exit.TabIndex = 21;
            this.btn_exit.Text = "X";
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            this.btn_exit.MouseLeave += new System.EventHandler(this.btn_exit_MouseLeave);
            this.btn_exit.MouseHover += new System.EventHandler(this.btn_exit_MouseHover);
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel5.Controls.Add(this.btn_exit);
            this.panel5.Controls.Add(this.btn_maximize);
            this.panel5.Controls.Add(this.pictureBox1);
            this.panel5.Controls.Add(this.btn_minimize);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.btn_about);
            this.panel5.Controls.Add(this.label1);
            this.panel5.Location = new System.Drawing.Point(274, 6);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1094, 137);
            this.panel5.TabIndex = 5;
            this.panel5.Paint += new System.Windows.Forms.PaintEventHandler(this.panel5_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = global::LIBRARYSYSTEM1202.Properties.Resources.MNHS_Logo;
            this.pictureBox1.Location = new System.Drawing.Point(797, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(146, 117);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(442, 82);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(356, 31);
            this.label3.TabIndex = 6;
            this.label3.Text = "Learning Resource Center";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(57, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(752, 55);
            this.label1.TabIndex = 5;
            this.label1.Text = "MNHS-Main Senior High School ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // clock_timer
            // 
            this.clock_timer.Tick += new System.EventHandler(this.clock_timer_Tick);
            // 
            // panel4
            // 
            this.panel4.AutoSize = true;
            this.panel4.BackColor = System.Drawing.SystemColors.Control;
            this.panel4.BackgroundImage = global::LIBRARYSYSTEM1202.Properties.Resources._2069874;
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel4.Controls.Add(this.pictureBox2);
            this.panel4.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.panel4.Location = new System.Drawing.Point(12, 213);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1342, 543);
            this.panel4.TabIndex = 4;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::LIBRARYSYSTEM1202.Properties.Resources._1551511921468;
            this.pictureBox2.Location = new System.Drawing.Point(523, 405);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(302, 122);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // btn_books
            // 
            this.btn_books.BackColor = System.Drawing.Color.White;
            this.btn_books.FlatAppearance.BorderColor = System.Drawing.Color.DarkOliveGreen;
            this.btn_books.FlatAppearance.BorderSize = 0;
            this.btn_books.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_books.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_books.ForeColor = System.Drawing.Color.Black;
            this.btn_books.ImageKey = "books.png";
            this.btn_books.ImageList = this.img_icons;
            this.btn_books.Location = new System.Drawing.Point(274, 142);
            this.btn_books.Name = "btn_books";
            this.btn_books.Size = new System.Drawing.Size(273, 65);
            this.btn_books.TabIndex = 7;
            this.btn_books.Text = "   Books";
            this.btn_books.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_books.UseVisualStyleBackColor = false;
            this.btn_books.Click += new System.EventHandler(this.button3_Click);
            // 
            // btn_users
            // 
            this.btn_users.BackColor = System.Drawing.Color.White;
            this.btn_users.FlatAppearance.BorderColor = System.Drawing.Color.DarkOliveGreen;
            this.btn_users.FlatAppearance.BorderSize = 0;
            this.btn_users.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_users.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_users.ForeColor = System.Drawing.Color.Black;
            this.btn_users.ImageIndex = 4;
            this.btn_users.ImageList = this.img_icons;
            this.btn_users.Location = new System.Drawing.Point(0, 142);
            this.btn_users.Name = "btn_users";
            this.btn_users.Size = new System.Drawing.Size(274, 65);
            this.btn_users.TabIndex = 6;
            this.btn_users.Text = "   Users";
            this.btn_users.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_users.UseVisualStyleBackColor = false;
            this.btn_users.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_return
            // 
            this.btn_return.BackColor = System.Drawing.Color.White;
            this.btn_return.FlatAppearance.BorderColor = System.Drawing.Color.DarkOliveGreen;
            this.btn_return.FlatAppearance.BorderSize = 0;
            this.btn_return.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_return.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_return.ForeColor = System.Drawing.Color.Black;
            this.btn_return.ImageKey = "return.png";
            this.btn_return.ImageList = this.img_icons;
            this.btn_return.Location = new System.Drawing.Point(820, 142);
            this.btn_return.Name = "btn_return";
            this.btn_return.Size = new System.Drawing.Size(273, 65);
            this.btn_return.TabIndex = 9;
            this.btn_return.Text = "   Return";
            this.btn_return.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_return.UseVisualStyleBackColor = false;
            this.btn_return.Click += new System.EventHandler(this.button5_Click);
            // 
            // btn_borrow
            // 
            this.btn_borrow.BackColor = System.Drawing.Color.White;
            this.btn_borrow.FlatAppearance.BorderColor = System.Drawing.Color.DarkOliveGreen;
            this.btn_borrow.FlatAppearance.BorderSize = 0;
            this.btn_borrow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_borrow.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_borrow.ForeColor = System.Drawing.Color.Black;
            this.btn_borrow.ImageKey = "borrow.png";
            this.btn_borrow.ImageList = this.img_icons;
            this.btn_borrow.Location = new System.Drawing.Point(547, 142);
            this.btn_borrow.Name = "btn_borrow";
            this.btn_borrow.Size = new System.Drawing.Size(273, 65);
            this.btn_borrow.TabIndex = 8;
            this.btn_borrow.Text = "   Borrow";
            this.btn_borrow.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_borrow.UseVisualStyleBackColor = false;
            this.btn_borrow.Click += new System.EventHandler(this.button4_Click);
            // 
            // btn_archive
            // 
            this.btn_archive.BackColor = System.Drawing.Color.White;
            this.btn_archive.FlatAppearance.BorderColor = System.Drawing.Color.DarkOliveGreen;
            this.btn_archive.FlatAppearance.BorderSize = 0;
            this.btn_archive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_archive.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_archive.ForeColor = System.Drawing.Color.Black;
            this.btn_archive.ImageKey = "Search.png";
            this.btn_archive.ImageList = this.img_icons;
            this.btn_archive.Location = new System.Drawing.Point(1093, 142);
            this.btn_archive.Name = "btn_archive";
            this.btn_archive.Size = new System.Drawing.Size(273, 65);
            this.btn_archive.TabIndex = 11;
            this.btn_archive.Text = "   Archive";
            this.btn_archive.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_archive.UseVisualStyleBackColor = false;
            this.btn_archive.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.btn_books);
            this.Controls.Add(this.btn_users);
            this.Controls.Add(this.btn_return);
            this.Controls.Add(this.btn_borrow);
            this.Controls.Add(this.btn_archive);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_return;
        private System.Windows.Forms.Button btn_borrow;
        private System.Windows.Forms.Button btn_books;
        private System.Windows.Forms.Button btn_users;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btn_out;
        private System.Windows.Forms.ImageList img_icons1;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_about;
        private System.Windows.Forms.Button btn_maximize;
        private System.Windows.Forms.Button btn_minimize;
        private System.Windows.Forms.ImageList img_icons;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_time;
        private System.Windows.Forms.Timer clock_timer;
        private System.Windows.Forms.Label lbl_date;
        private System.Windows.Forms.Button btn_archive;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_user;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

