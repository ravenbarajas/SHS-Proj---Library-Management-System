namespace LIBRARYSYSTEM1202
{
    partial class Frm_books
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_books));
            this.txt_desc = new System.Windows.Forms.TextBox();
            this.txt_yp = new System.Windows.Forms.TextBox();
            this.txt_author = new System.Windows.Forms.TextBox();
            this.txt_title = new System.Windows.Forms.TextBox();
            this.txt_bookid = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_books = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsb_save = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsb_update = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tsb_clear = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.button_image = new System.Windows.Forms.ImageList(this.components);
            this.cbo_category = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_price = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_status = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_books)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_desc
            // 
            this.txt_desc.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_desc.Location = new System.Drawing.Point(1047, 341);
            this.txt_desc.MaxLength = 300;
            this.txt_desc.Multiline = true;
            this.txt_desc.Name = "txt_desc";
            this.txt_desc.Size = new System.Drawing.Size(231, 82);
            this.txt_desc.TabIndex = 67;
            // 
            // txt_yp
            // 
            this.txt_yp.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_yp.Location = new System.Drawing.Point(1047, 293);
            this.txt_yp.MaxLength = 20;
            this.txt_yp.Name = "txt_yp";
            this.txt_yp.Size = new System.Drawing.Size(231, 27);
            this.txt_yp.TabIndex = 66;
            // 
            // txt_author
            // 
            this.txt_author.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_author.Location = new System.Drawing.Point(1047, 245);
            this.txt_author.MaxLength = 50;
            this.txt_author.Name = "txt_author";
            this.txt_author.Size = new System.Drawing.Size(231, 27);
            this.txt_author.TabIndex = 65;
            // 
            // txt_title
            // 
            this.txt_title.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_title.Location = new System.Drawing.Point(1047, 194);
            this.txt_title.MaxLength = 100;
            this.txt_title.Name = "txt_title";
            this.txt_title.Size = new System.Drawing.Size(231, 27);
            this.txt_title.TabIndex = 64;
            // 
            // txt_bookid
            // 
            this.txt_bookid.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txt_bookid.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.txt_bookid.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_bookid.Location = new System.Drawing.Point(1047, 84);
            this.txt_bookid.MaxLength = 12;
            this.txt_bookid.Name = "txt_bookid";
            this.txt_bookid.Size = new System.Drawing.Size(231, 27);
            this.txt_bookid.TabIndex = 62;
            this.txt_bookid.Text = "2019-";
            this.txt_bookid.TextChanged += new System.EventHandler(this.txt_bookid_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 14.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(851, 341);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 23);
            this.label6.TabIndex = 61;
            this.label6.Text = "•Description";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 14.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(851, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 23);
            this.label5.TabIndex = 60;
            this.label5.Text = "•Category";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(851, 293);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 23);
            this.label4.TabIndex = 59;
            this.label4.Text = "•Year Published";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(851, 245);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 23);
            this.label3.TabIndex = 58;
            this.label3.Text = "•Author";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(851, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 23);
            this.label2.TabIndex = 57;
            this.label2.Text = "•Title";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(851, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 23);
            this.label1.TabIndex = 56;
            this.label1.Text = "•Book ID";
            // 
            // dgv_books
            // 
            this.dgv_books.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_books.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8});
            this.dgv_books.Location = new System.Drawing.Point(3, 96);
            this.dgv_books.Name = "dgv_books";
            this.dgv_books.Size = new System.Drawing.Size(835, 445);
            this.dgv_books.TabIndex = 55;
            this.dgv_books.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_books_CellContentClick);
            this.dgv_books.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_books_CellMouseDown);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "BOOK ID";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "CATEGORY";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "TITLE";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "AUTHOR";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "YEAR PUBLISHED";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "DESCRIPTION";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "PRICE";
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.HeaderText = "STATUS";
            this.Column8.Name = "Column8";
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Right;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsb_save,
            this.toolStripSeparator1,
            this.tsb_update,
            this.toolStripSeparator4,
            this.tsb_clear,
            this.toolStripSeparator2});
            this.toolStrip1.Location = new System.Drawing.Point(1293, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(49, 543);
            this.toolStrip1.TabIndex = 78;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsb_save
            // 
            this.tsb_save.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_save.Image = global::LIBRARYSYSTEM1202.Properties.Resources.save;
            this.tsb_save.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_save.Margin = new System.Windows.Forms.Padding(7);
            this.tsb_save.Name = "tsb_save";
            this.tsb_save.Padding = new System.Windows.Forms.Padding(5);
            this.tsb_save.Size = new System.Drawing.Size(32, 34);
            this.tsb_save.Text = "toolStripButton1";
            this.tsb_save.Click += new System.EventHandler(this.tsb_save_Click_1);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(46, 6);
            // 
            // tsb_update
            // 
            this.tsb_update.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_update.Image = global::LIBRARYSYSTEM1202.Properties.Resources.update;
            this.tsb_update.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_update.Margin = new System.Windows.Forms.Padding(7);
            this.tsb_update.Name = "tsb_update";
            this.tsb_update.Padding = new System.Windows.Forms.Padding(5);
            this.tsb_update.Size = new System.Drawing.Size(32, 34);
            this.tsb_update.Text = "tsb_update";
            this.tsb_update.ToolTipText = "Update";
            this.tsb_update.Click += new System.EventHandler(this.tsb_update_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(46, 6);
            // 
            // tsb_clear
            // 
            this.tsb_clear.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_clear.Image = global::LIBRARYSYSTEM1202.Properties.Resources.clear;
            this.tsb_clear.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_clear.Margin = new System.Windows.Forms.Padding(7);
            this.tsb_clear.Name = "tsb_clear";
            this.tsb_clear.Padding = new System.Windows.Forms.Padding(5);
            this.tsb_clear.Size = new System.Drawing.Size(32, 34);
            this.tsb_clear.Text = "tsb_clear";
            this.tsb_clear.ToolTipText = "Clear";
            this.tsb_clear.Click += new System.EventHandler(this.toolStripButton4_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(46, 6);
            // 
            // button_image
            // 
            this.button_image.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("button_image.ImageStream")));
            this.button_image.TransparentColor = System.Drawing.Color.Transparent;
            this.button_image.Images.SetKeyName(0, "book_label.png");
            this.button_image.Images.SetKeyName(1, "borrow_label.png");
            this.button_image.Images.SetKeyName(2, "calendar_from.png");
            this.button_image.Images.SetKeyName(3, "calendar_to.png");
            this.button_image.Images.SetKeyName(4, "logout.png");
            this.button_image.Images.SetKeyName(5, "print.png");
            this.button_image.Images.SetKeyName(6, "return_label.png");
            this.button_image.Images.SetKeyName(7, "search_label.png");
            this.button_image.Images.SetKeyName(8, "user_label.png");
            // 
            // cbo_category
            // 
            this.cbo_category.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_category.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_category.FormattingEnabled = true;
            this.cbo_category.Items.AddRange(new object[] {
            "000-Computer Science, Information & General works",
            "100-Philosophy & Psychology",
            "200-Religion",
            "300-Social Sciences",
            "400-Language",
            "500-Science",
            "600-Technology",
            "700-Arts & Recreation",
            "800-Literature",
            "900-History & Geography"});
            this.cbo_category.Location = new System.Drawing.Point(1047, 139);
            this.cbo_category.MaxLength = 50;
            this.cbo_category.Name = "cbo_category";
            this.cbo_category.Size = new System.Drawing.Size(231, 29);
            this.cbo_category.TabIndex = 63;
            this.cbo_category.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 14.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(851, 443);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 23);
            this.label7.TabIndex = 96;
            this.label7.Text = "•Price";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(1164, 456);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 19);
            this.label10.TabIndex = 99;
            this.label10.Text = "php";
            // 
            // txt_price
            // 
            this.txt_price.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_price.Location = new System.Drawing.Point(1047, 444);
            this.txt_price.Name = "txt_price";
            this.txt_price.Size = new System.Drawing.Size(100, 27);
            this.txt_price.TabIndex = 100;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 14.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(851, 495);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 23);
            this.label8.TabIndex = 101;
            this.label8.Text = "•Status";
            // 
            // txt_status
            // 
            this.txt_status.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_status.Location = new System.Drawing.Point(1047, 492);
            this.txt_status.MaxLength = 50;
            this.txt_status.Name = "txt_status";
            this.txt_status.Size = new System.Drawing.Size(231, 27);
            this.txt_status.TabIndex = 102;
            this.txt_status.Text = "*Newly Added";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label9.ImageKey = "book_label.png";
            this.label9.ImageList = this.button_image;
            this.label9.Location = new System.Drawing.Point(463, 19);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(373, 44);
            this.label9.TabIndex = 95;
            this.label9.Text = "     Book Information";
            // 
            // Frm_books
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1342, 543);
            this.Controls.Add(this.txt_status);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_price);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbo_category);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.txt_desc);
            this.Controls.Add(this.txt_yp);
            this.Controls.Add(this.txt_author);
            this.Controls.Add(this.txt_title);
            this.Controls.Add(this.txt_bookid);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_books);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_books";
            this.Text = "Frm_books";
            this.Load += new System.EventHandler(this.Frm_books_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_books)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txt_desc;
        private System.Windows.Forms.TextBox txt_yp;
        private System.Windows.Forms.TextBox txt_author;
        private System.Windows.Forms.TextBox txt_title;
        private System.Windows.Forms.TextBox txt_bookid;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_books;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ToolStripButton tsb_update;
        private System.Windows.Forms.ToolStripButton tsb_clear;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ImageList button_image;
        private System.Windows.Forms.ToolStripButton tsb_save;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        protected System.Windows.Forms.ComboBox cbo_category;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_price;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_status;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
    }
}