namespace LIBRARYSYSTEM1202
{
    partial class Frm_user
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_user));
            this.button_image = new System.Windows.Forms.ImageList(this.components);
            this.dgv_student = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_contact = new System.Windows.Forms.TextBox();
            this.lrn = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_pcontact = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_pname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_section = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_address = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_lrn = new System.Windows.Forms.TextBox();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.tsb_save = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tsb_update = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.tsb_clear = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.label9 = new System.Windows.Forms.Label();
            this.cbo_ts = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_student)).BeginInit();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
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
            // dgv_student
            // 
            this.dgv_student.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgv_student.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_student.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9});
            this.dgv_student.Location = new System.Drawing.Point(3, 96);
            this.dgv_student.Name = "dgv_student";
            this.dgv_student.ReadOnly = true;
            this.dgv_student.Size = new System.Drawing.Size(835, 445);
            this.dgv_student.TabIndex = 116;
            this.dgv_student.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_student_CellContentClick);
            this.dgv_student.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_student_CellMouseDown);
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
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "ADDRESS";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "CONTACT #";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
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
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.HeaderText = "PARENT NAME";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.HeaderText = "PARENT CONTACT #";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // txt_contact
            // 
            this.txt_contact.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_contact.Location = new System.Drawing.Point(1077, 266);
            this.txt_contact.MaxLength = 11;
            this.txt_contact.Name = "txt_contact";
            this.txt_contact.Size = new System.Drawing.Size(206, 27);
            this.txt_contact.TabIndex = 108;
            // 
            // lrn
            // 
            this.lrn.AutoSize = true;
            this.lrn.Font = new System.Drawing.Font("Century Gothic", 14.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lrn.ForeColor = System.Drawing.Color.Black;
            this.lrn.Location = new System.Drawing.Point(853, 93);
            this.lrn.Name = "lrn";
            this.lrn.Size = new System.Drawing.Size(54, 23);
            this.lrn.TabIndex = 96;
            this.lrn.Text = "•LRN";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(853, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 23);
            this.label1.TabIndex = 97;
            this.label1.Text = "•Name";
            // 
            // txt_pcontact
            // 
            this.txt_pcontact.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pcontact.Location = new System.Drawing.Point(1077, 487);
            this.txt_pcontact.MaxLength = 11;
            this.txt_pcontact.Name = "txt_pcontact";
            this.txt_pcontact.Size = new System.Drawing.Size(206, 27);
            this.txt_pcontact.TabIndex = 113;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(853, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 23);
            this.label2.TabIndex = 98;
            this.label2.Text = "•Address";
            // 
            // txt_pname
            // 
            this.txt_pname.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pname.Location = new System.Drawing.Point(1077, 421);
            this.txt_pname.MaxLength = 50;
            this.txt_pname.Name = "txt_pname";
            this.txt_pname.Size = new System.Drawing.Size(206, 27);
            this.txt_pname.TabIndex = 112;
            this.txt_pname.TextChanged += new System.EventHandler(this.txt_pname_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(853, 268);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 23);
            this.label3.TabIndex = 99;
            this.label3.Text = "•Contact Number";
            // 
            // txt_section
            // 
            this.txt_section.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_section.Location = new System.Drawing.Point(1077, 371);
            this.txt_section.MaxLength = 10;
            this.txt_section.Name = "txt_section";
            this.txt_section.Size = new System.Drawing.Size(206, 27);
            this.txt_section.TabIndex = 111;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 14.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(853, 325);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(149, 23);
            this.label5.TabIndex = 101;
            this.label5.Text = "•Track / Strand";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 14.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(853, 373);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 23);
            this.label6.TabIndex = 102;
            this.label6.Text = "•Section";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 14.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(853, 423);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(192, 46);
            this.label7.TabIndex = 103;
            this.label7.Text = "•Parent / Guardian \r\nName";
            // 
            // txt_address
            // 
            this.txt_address.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_address.Location = new System.Drawing.Point(1077, 182);
            this.txt_address.MaxLength = 100;
            this.txt_address.Multiline = true;
            this.txt_address.Name = "txt_address";
            this.txt_address.Size = new System.Drawing.Size(206, 64);
            this.txt_address.TabIndex = 107;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 14.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(853, 487);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(192, 46);
            this.label8.TabIndex = 104;
            this.label8.Text = "•Parent / Guardian \r\nContact";
            // 
            // txt_name
            // 
            this.txt_name.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_name.Location = new System.Drawing.Point(1077, 136);
            this.txt_name.MaxLength = 50;
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(206, 27);
            this.txt_name.TabIndex = 106;
            // 
            // txt_lrn
            // 
            this.txt_lrn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_lrn.Location = new System.Drawing.Point(1077, 91);
            this.txt_lrn.MaxLength = 12;
            this.txt_lrn.Name = "txt_lrn";
            this.txt_lrn.Size = new System.Drawing.Size(206, 27);
            this.txt_lrn.TabIndex = 105;
            // 
            // toolStrip2
            // 
            this.toolStrip2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.Right;
            this.toolStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsb_save,
            this.toolStripSeparator4,
            this.tsb_update,
            this.toolStripSeparator5,
            this.tsb_clear,
            this.toolStripSeparator6});
            this.toolStrip2.Location = new System.Drawing.Point(1293, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(49, 543);
            this.toolStrip2.TabIndex = 198;
            this.toolStrip2.Text = "toolStrip2";
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
            this.tsb_save.Click += new System.EventHandler(this.toolStripButton1_Click_1);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(46, 6);
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
            this.tsb_update.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(46, 6);
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
            this.tsb_clear.Click += new System.EventHandler(this.toolStripButton3_Click_1);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(46, 6);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label9.ImageKey = "user_label.png";
            this.label9.ImageList = this.button_image;
            this.label9.Location = new System.Drawing.Point(463, 19);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(420, 44);
            this.label9.TabIndex = 115;
            this.label9.Text = "     Student Information";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.cbo_ts.Location = new System.Drawing.Point(1077, 321);
            this.cbo_ts.Name = "cbo_ts";
            this.cbo_ts.Size = new System.Drawing.Size(206, 27);
            this.cbo_ts.TabIndex = 220;
            // 
            // Frm_user
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1342, 543);
            this.Controls.Add(this.cbo_ts);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.dgv_student);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txt_contact);
            this.Controls.Add(this.lrn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_pcontact);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_pname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_section);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_address);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.txt_lrn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_user";
            this.Load += new System.EventHandler(this.Frm_user_Load);
            this.Enter += new System.EventHandler(this.Frm_user_Enter);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Frm_user_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_student)).EndInit();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ImageList button_image;
        private System.Windows.Forms.DataGridView dgv_student;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_contact;
        private System.Windows.Forms.Label lrn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_pcontact;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_pname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_section;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_address;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.TextBox txt_lrn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton tsb_save;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton tsb_update;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton tsb_clear;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ComboBox cbo_ts;
    }
}