namespace LIBRARYSYSTEM1202
{
    partial class Frm_return
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_return));
            this.dtp_return = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.dtp_borrow = new System.Windows.Forms.DateTimePicker();
            this.txt_sname = new System.Windows.Forms.TextBox();
            this.txt_booktitle = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsb_update = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsb_clear = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.txt_status = new System.Windows.Forms.TextBox();
            this.txt_due = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_transac = new System.Windows.Forms.TextBox();
            this.txt_lrn = new System.Windows.Forms.TextBox();
            this.txt_bookid = new System.Windows.Forms.TextBox();
            this.lblfine = new System.Windows.Forms.Label();
            this.dgv_borrow = new System.Windows.Forms.DataGridView();
            this.btn_report = new System.Windows.Forms.Button();
            this.img_icons1 = new System.Windows.Forms.ImageList(this.components);
            this.label10 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_borrow)).BeginInit();
            this.SuspendLayout();
            // 
            // dtp_return
            // 
            this.dtp_return.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_return.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_return.Location = new System.Drawing.Point(1004, 307);
            this.dtp_return.Name = "dtp_return";
            this.dtp_return.Size = new System.Drawing.Size(265, 27);
            this.dtp_return.TabIndex = 143;
            this.dtp_return.ValueChanged += new System.EventHandler(this.dtp_return_ValueChanged_1);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 14.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(852, 354);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 23);
            this.label8.TabIndex = 144;
            this.label8.Text = "•Status";
            // 
            // dtp_borrow
            // 
            this.dtp_borrow.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_borrow.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_borrow.Location = new System.Drawing.Point(1004, 265);
            this.dtp_borrow.Name = "dtp_borrow";
            this.dtp_borrow.Size = new System.Drawing.Size(265, 27);
            this.dtp_borrow.TabIndex = 142;
            this.dtp_borrow.ValueChanged += new System.EventHandler(this.dtp_borrow_ValueChanged);
            // 
            // txt_sname
            // 
            this.txt_sname.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_sname.Location = new System.Drawing.Point(1004, 131);
            this.txt_sname.MaxLength = 50;
            this.txt_sname.Name = "txt_sname";
            this.txt_sname.Size = new System.Drawing.Size(265, 27);
            this.txt_sname.TabIndex = 141;
            this.txt_sname.TextChanged += new System.EventHandler(this.txt_sname_TextChanged);
            // 
            // txt_booktitle
            // 
            this.txt_booktitle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_booktitle.Location = new System.Drawing.Point(1004, 221);
            this.txt_booktitle.MaxLength = 50;
            this.txt_booktitle.Name = "txt_booktitle";
            this.txt_booktitle.Size = new System.Drawing.Size(265, 27);
            this.txt_booktitle.TabIndex = 139;
            this.txt_booktitle.TextChanged += new System.EventHandler(this.txt_booktitle_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 14.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(852, 312);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 23);
            this.label6.TabIndex = 137;
            this.label6.Text = "•Return Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 14.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(852, 265);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 23);
            this.label5.TabIndex = 136;
            this.label5.Text = "•Issue Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(852, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 23);
            this.label4.TabIndex = 135;
            this.label4.Text = "•Book Title";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(852, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 23);
            this.label3.TabIndex = 134;
            this.label3.Text = "•Book Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(852, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 23);
            this.label2.TabIndex = 133;
            this.label2.Text = "•Student Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(852, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 23);
            this.label1.TabIndex = 132;
            this.label1.Text = "•LRN";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(861, 444);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 23);
            this.label7.TabIndex = 130;
            this.label7.Text = "Fine";
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Right;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsb_update,
            this.toolStripSeparator1,
            this.tsb_clear,
            this.toolStripSeparator2,
            this.toolStripButton4});
            this.toolStrip1.Location = new System.Drawing.Point(1293, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(49, 543);
            this.toolStrip1.TabIndex = 197;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsb_update
            // 
            this.tsb_update.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_update.Image = global::LIBRARYSYSTEM1202.Properties.Resources.save;
            this.tsb_update.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_update.Margin = new System.Windows.Forms.Padding(7);
            this.tsb_update.Name = "tsb_update";
            this.tsb_update.Padding = new System.Windows.Forms.Padding(5);
            this.tsb_update.Size = new System.Drawing.Size(32, 34);
            this.tsb_update.ToolTipText = "Save";
            this.tsb_update.Click += new System.EventHandler(this.tsb_save_Click);
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
            this.tsb_clear.Click += new System.EventHandler(this.tsb_clear_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(46, 6);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Margin = new System.Windows.Forms.Padding(7);
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Padding = new System.Windows.Forms.Padding(5);
            this.toolStripButton4.Size = new System.Drawing.Size(32, 14);
            this.toolStripButton4.Text = "tsp_clear";
            // 
            // txt_status
            // 
            this.txt_status.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_status.Location = new System.Drawing.Point(1004, 354);
            this.txt_status.MaxLength = 50;
            this.txt_status.Name = "txt_status";
            this.txt_status.Size = new System.Drawing.Size(265, 27);
            this.txt_status.TabIndex = 198;
            this.txt_status.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txt_due
            // 
            this.txt_due.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_due.Location = new System.Drawing.Point(1004, 399);
            this.txt_due.Name = "txt_due";
            this.txt_due.Size = new System.Drawing.Size(265, 27);
            this.txt_due.TabIndex = 203;
            this.txt_due.TextChanged += new System.EventHandler(this.txt_due_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 14.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(852, 401);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(152, 23);
            this.label9.TabIndex = 204;
            this.label9.Text = "•Days Overdue";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 14.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(852, 42);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(143, 23);
            this.label11.TabIndex = 207;
            this.label11.Text = "•Transaction #";
            // 
            // txt_transac
            // 
            this.txt_transac.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_transac.Location = new System.Drawing.Point(1004, 42);
            this.txt_transac.MaxLength = 12;
            this.txt_transac.Name = "txt_transac";
            this.txt_transac.ReadOnly = true;
            this.txt_transac.Size = new System.Drawing.Size(265, 27);
            this.txt_transac.TabIndex = 206;
            this.txt_transac.TextChanged += new System.EventHandler(this.txt_transac_TextChanged);
            // 
            // txt_lrn
            // 
            this.txt_lrn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_lrn.Location = new System.Drawing.Point(1004, 87);
            this.txt_lrn.MaxLength = 12;
            this.txt_lrn.Name = "txt_lrn";
            this.txt_lrn.Size = new System.Drawing.Size(265, 27);
            this.txt_lrn.TabIndex = 208;
            this.txt_lrn.TextChanged += new System.EventHandler(this.txt_lrn_TextChanged);
            // 
            // txt_bookid
            // 
            this.txt_bookid.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_bookid.Location = new System.Drawing.Point(1004, 175);
            this.txt_bookid.MaxLength = 12;
            this.txt_bookid.Name = "txt_bookid";
            this.txt_bookid.Size = new System.Drawing.Size(265, 27);
            this.txt_bookid.TabIndex = 209;
            // 
            // lblfine
            // 
            this.lblfine.AutoSize = true;
            this.lblfine.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfine.Location = new System.Drawing.Point(1000, 444);
            this.lblfine.Name = "lblfine";
            this.lblfine.Size = new System.Drawing.Size(63, 23);
            this.lblfine.TabIndex = 210;
            this.lblfine.Text = "0 php";
            this.lblfine.Click += new System.EventHandler(this.lblfine_Click);
            // 
            // dgv_borrow
            // 
            this.dgv_borrow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_borrow.Location = new System.Drawing.Point(3, 96);
            this.dgv_borrow.Name = "dgv_borrow";
            this.dgv_borrow.Size = new System.Drawing.Size(835, 445);
            this.dgv_borrow.TabIndex = 211;
            this.dgv_borrow.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_borrow_CellContentClick_1);
            this.dgv_borrow.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_borrow_CellMouseDown_1);
            // 
            // btn_report
            // 
            this.btn_report.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_report.Location = new System.Drawing.Point(1123, 470);
            this.btn_report.Margin = new System.Windows.Forms.Padding(0);
            this.btn_report.Name = "btn_report";
            this.btn_report.Size = new System.Drawing.Size(141, 32);
            this.btn_report.TabIndex = 212;
            this.btn_report.Text = "Report Lost Book";
            this.btn_report.UseVisualStyleBackColor = true;
            this.btn_report.Click += new System.EventHandler(this.btn_report_Click);
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
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label10.ImageKey = "return_label.png";
            this.label10.ImageList = this.img_icons1;
            this.label10.Location = new System.Drawing.Point(463, 19);
            this.label10.Margin = new System.Windows.Forms.Padding(3);
            this.label10.Name = "label10";
            this.label10.Padding = new System.Windows.Forms.Padding(2);
            this.label10.Size = new System.Drawing.Size(310, 48);
            this.label10.TabIndex = 213;
            this.label10.Text = "      Return Books";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Frm_return
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1342, 543);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btn_report);
            this.Controls.Add(this.dgv_borrow);
            this.Controls.Add(this.lblfine);
            this.Controls.Add(this.txt_bookid);
            this.Controls.Add(this.txt_lrn);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txt_transac);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txt_due);
            this.Controls.Add(this.txt_status);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dtp_return);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dtp_borrow);
            this.Controls.Add(this.txt_sname);
            this.Controls.Add(this.txt_booktitle);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label7);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_return";
            this.Load += new System.EventHandler(this.Frm_return_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_borrow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtp_return;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtp_borrow;
        private System.Windows.Forms.TextBox txt_sname;
        private System.Windows.Forms.TextBox txt_booktitle;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsb_update;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsb_clear;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.TextBox txt_status;
        private System.Windows.Forms.TextBox txt_due;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_transac;
        private System.Windows.Forms.TextBox txt_lrn;
        private System.Windows.Forms.TextBox txt_bookid;
        private System.Windows.Forms.Label lblfine;
        private System.Windows.Forms.DataGridView dgv_borrow;
        private System.Windows.Forms.Button btn_report;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ImageList img_icons1;
    }
}