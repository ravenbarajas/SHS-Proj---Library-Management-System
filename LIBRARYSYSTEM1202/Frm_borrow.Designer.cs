namespace LIBRARYSYSTEM1202
{
    partial class Frm_borrow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_borrow));
            this.label10 = new System.Windows.Forms.Label();
            this.txt_section = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dgv_borrow = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_sname = new System.Windows.Forms.TextBox();
            this.txt_booktitle = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsb_save = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsb_clear = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.txt_transac = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_status = new System.Windows.Forms.TextBox();
            this.dgv_books = new System.Windows.Forms.DataGridView();
            this.txt_lrn = new System.Windows.Forms.TextBox();
            this.txt_bookid = new System.Windows.Forms.TextBox();
            this.img_icons1 = new System.Windows.Forms.ImageList(this.components);
            this.dtp_borrow = new System.Windows.Forms.DateTimePicker();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btn_checkout = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.cbo_ts = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_borrow)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_books)).BeginInit();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 14.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(852, 240);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(89, 23);
            this.label10.TabIndex = 193;
            this.label10.Text = "•Section";
            // 
            // txt_section
            // 
            this.txt_section.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_section.Location = new System.Drawing.Point(1004, 240);
            this.txt_section.MaxLength = 20;
            this.txt_section.Name = "txt_section";
            this.txt_section.Size = new System.Drawing.Size(265, 27);
            this.txt_section.TabIndex = 192;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 14.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(852, 192);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(149, 23);
            this.label9.TabIndex = 191;
            this.label9.Text = "•Track / Strand";
            // 
            // dgv_borrow
            // 
            this.dgv_borrow.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgv_borrow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_borrow.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.Column2,
            this.Column3,
            this.Column7,
            this.Column5,
            this.Column6});
            this.dgv_borrow.Location = new System.Drawing.Point(3, 325);
            this.dgv_borrow.Name = "dgv_borrow";
            this.dgv_borrow.ReadOnly = true;
            this.dgv_borrow.Size = new System.Drawing.Size(839, 206);
            this.dgv_borrow.TabIndex = 189;
            this.dgv_borrow.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_student_CellContentClick);
            this.dgv_borrow.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_borrow_CellMouseDown);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "TRANSAC NO.";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "LRN";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "NAME";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "TRACK / STRAND";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "SECTION";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "BOOK ID";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "TITLE";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "STATUS";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "ISSUE DATE";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "RETURN DATE";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 14.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(852, 394);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 23);
            this.label7.TabIndex = 187;
            this.label7.Text = "•Status";
            // 
            // txt_sname
            // 
            this.txt_sname.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_sname.Location = new System.Drawing.Point(1004, 138);
            this.txt_sname.MaxLength = 50;
            this.txt_sname.Name = "txt_sname";
            this.txt_sname.Size = new System.Drawing.Size(265, 27);
            this.txt_sname.TabIndex = 184;
            this.txt_sname.TextChanged += new System.EventHandler(this.txt_sname_TextChanged);
            // 
            // txt_booktitle
            // 
            this.txt_booktitle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_booktitle.Location = new System.Drawing.Point(1004, 345);
            this.txt_booktitle.MaxLength = 50;
            this.txt_booktitle.Name = "txt_booktitle";
            this.txt_booktitle.Size = new System.Drawing.Size(265, 27);
            this.txt_booktitle.TabIndex = 183;
            this.txt_booktitle.TextChanged += new System.EventHandler(this.txt_booktitle_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 14.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(852, 439);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 23);
            this.label5.TabIndex = 179;
            this.label5.Text = "•Issue Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(855, 343);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 23);
            this.label4.TabIndex = 178;
            this.label4.Text = "•Book Title";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(851, 292);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 23);
            this.label3.TabIndex = 177;
            this.label3.Text = "•Book Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(852, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 23);
            this.label2.TabIndex = 176;
            this.label2.Text = "•Student Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(853, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 23);
            this.label1.TabIndex = 175;
            this.label1.Text = "•LRN";
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Right;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsb_save,
            this.toolStripSeparator1,
            this.tsb_clear,
            this.toolStripSeparator2});
            this.toolStrip1.Location = new System.Drawing.Point(1293, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(49, 543);
            this.toolStrip1.TabIndex = 196;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
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
            this.tsb_save.ToolTipText = "Save";
            this.tsb_save.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(46, 6);
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
            this.tsb_clear.ToolTipText = "Clear";
            this.tsb_clear.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(46, 6);
            // 
            // txt_transac
            // 
            this.txt_transac.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_transac.Location = new System.Drawing.Point(1004, 39);
            this.txt_transac.MaxLength = 50;
            this.txt_transac.Name = "txt_transac";
            this.txt_transac.ReadOnly = true;
            this.txt_transac.Size = new System.Drawing.Size(265, 27);
            this.txt_transac.TabIndex = 198;
            this.txt_transac.TextChanged += new System.EventHandler(this.txt_transac_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 14.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(852, 42);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(143, 23);
            this.label8.TabIndex = 199;
            this.label8.Text = "•Transaction #";
            // 
            // txt_status
            // 
            this.txt_status.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_status.Location = new System.Drawing.Point(1004, 394);
            this.txt_status.MaxLength = 50;
            this.txt_status.Name = "txt_status";
            this.txt_status.Size = new System.Drawing.Size(265, 27);
            this.txt_status.TabIndex = 204;
            this.txt_status.TextChanged += new System.EventHandler(this.txt_status_TextChanged);
            // 
            // dgv_books
            // 
            this.dgv_books.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_books.Location = new System.Drawing.Point(3, 105);
            this.dgv_books.Name = "dgv_books";
            this.dgv_books.Size = new System.Drawing.Size(839, 206);
            this.dgv_books.TabIndex = 207;
            this.dgv_books.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_books_CellMouseDown);
            // 
            // txt_lrn
            // 
            this.txt_lrn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_lrn.Location = new System.Drawing.Point(1004, 88);
            this.txt_lrn.Name = "txt_lrn";
            this.txt_lrn.Size = new System.Drawing.Size(265, 27);
            this.txt_lrn.TabIndex = 210;
            this.txt_lrn.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txt_bookid
            // 
            this.txt_bookid.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_bookid.Location = new System.Drawing.Point(1004, 292);
            this.txt_bookid.MaxLength = 20;
            this.txt_bookid.Name = "txt_bookid";
            this.txt_bookid.Size = new System.Drawing.Size(265, 27);
            this.txt_bookid.TabIndex = 211;
            this.txt_bookid.TextChanged += new System.EventHandler(this.txt_bookid_TextChanged);
            // 
            // img_icons1
            // 
            this.img_icons1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_icons1.ImageStream")));
            this.img_icons1.TransparentColor = System.Drawing.Color.Transparent;
            this.img_icons1.Images.SetKeyName(0, "book_label.png");
            this.img_icons1.Images.SetKeyName(1, "borrow_label.png");
            this.img_icons1.Images.SetKeyName(2, "calendar_from.png");
            this.img_icons1.Images.SetKeyName(3, "calendar_to.png");
            this.img_icons1.Images.SetKeyName(4, "logout.png");
            this.img_icons1.Images.SetKeyName(5, "print.png");
            this.img_icons1.Images.SetKeyName(6, "return_label.png");
            this.img_icons1.Images.SetKeyName(7, "search_label.png");
            this.img_icons1.Images.SetKeyName(8, "user_label.png");
            // 
            // dtp_borrow
            // 
            this.dtp_borrow.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_borrow.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_borrow.Location = new System.Drawing.Point(1004, 439);
            this.dtp_borrow.Margin = new System.Windows.Forms.Padding(2);
            this.dtp_borrow.Name = "dtp_borrow";
            this.dtp_borrow.Size = new System.Drawing.Size(265, 30);
            this.dtp_borrow.TabIndex = 218;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "book_label.png");
            this.imageList1.Images.SetKeyName(1, "borrow_label.png");
            this.imageList1.Images.SetKeyName(2, "calendar_from.png");
            this.imageList1.Images.SetKeyName(3, "calendar_to.png");
            this.imageList1.Images.SetKeyName(4, "logout.png");
            this.imageList1.Images.SetKeyName(5, "print.png");
            this.imageList1.Images.SetKeyName(6, "return_label.png");
            this.imageList1.Images.SetKeyName(7, "search_label.png");
            this.imageList1.Images.SetKeyName(8, "user_label.png");
            // 
            // btn_checkout
            // 
            this.btn_checkout.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_checkout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_checkout.ImageKey = "print.png";
            this.btn_checkout.ImageList = this.imageList1;
            this.btn_checkout.Location = new System.Drawing.Point(1107, 486);
            this.btn_checkout.Name = "btn_checkout";
            this.btn_checkout.Size = new System.Drawing.Size(149, 32);
            this.btn_checkout.TabIndex = 216;
            this.btn_checkout.Text = "        Print Reciept";
            this.btn_checkout.UseVisualStyleBackColor = true;
            this.btn_checkout.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label6.ImageKey = "borrow_label.png";
            this.label6.ImageList = this.img_icons1;
            this.label6.Location = new System.Drawing.Point(463, 19);
            this.label6.Margin = new System.Windows.Forms.Padding(3);
            this.label6.Name = "label6";
            this.label6.Padding = new System.Windows.Forms.Padding(2);
            this.label6.Size = new System.Drawing.Size(339, 48);
            this.label6.TabIndex = 214;
            this.label6.Text = "        Borrow Books";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbo_ts
            // 
            this.cbo_ts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_ts.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_ts.FormattingEnabled = true;
            this.cbo_ts.Items.AddRange(new object[] {
            "ABM",
            "ICT",
            "GAS",
            "HE",
            "SPORTS TRACK",
            "STEM"});
            this.cbo_ts.Location = new System.Drawing.Point(1007, 192);
            this.cbo_ts.Name = "cbo_ts";
            this.cbo_ts.Size = new System.Drawing.Size(262, 27);
            this.cbo_ts.TabIndex = 219;
            // 
            // Frm_borrow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1342, 543);
            this.Controls.Add(this.cbo_ts);
            this.Controls.Add(this.dtp_borrow);
            this.Controls.Add(this.btn_checkout);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_bookid);
            this.Controls.Add(this.txt_lrn);
            this.Controls.Add(this.dgv_books);
            this.Controls.Add(this.txt_status);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_transac);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txt_section);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dgv_borrow);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_sname);
            this.Controls.Add(this.txt_booktitle);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_borrow";
            this.Load += new System.EventHandler(this.Frm_borrow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_borrow)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_books)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_section;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dgv_borrow;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_sname;
        private System.Windows.Forms.TextBox txt_booktitle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsb_save;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.TextBox txt_transac;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ToolStripButton tsb_clear;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.TextBox txt_status;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridView dgv_books;
        private System.Windows.Forms.TextBox txt_lrn;
        private System.Windows.Forms.TextBox txt_bookid;
        private System.Windows.Forms.ImageList img_icons1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_checkout;
        private System.Windows.Forms.DateTimePicker dtp_borrow;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ComboBox cbo_ts;
    }
}