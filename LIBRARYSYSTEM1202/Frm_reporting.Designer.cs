namespace LIBRARYSYSTEM1202
{
    partial class Frm_reporting
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_reporting));
            this.lbl_images = new System.Windows.Forms.ImageList(this.components);
            this.dgv_info = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_booktitle = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbo_status = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dtp_from = new System.Windows.Forms.DateTimePicker();
            this.dtp_to = new System.Windows.Forms.DateTimePicker();
            this.btn_gr1 = new System.Windows.Forms.Button();
            this.btn_gr2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_info)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_images
            // 
            this.lbl_images.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("lbl_images.ImageStream")));
            this.lbl_images.TransparentColor = System.Drawing.Color.Transparent;
            this.lbl_images.Images.SetKeyName(0, "book_label.png");
            this.lbl_images.Images.SetKeyName(1, "borrow_label.png");
            this.lbl_images.Images.SetKeyName(2, "calendar_from.png");
            this.lbl_images.Images.SetKeyName(3, "calendar_to.png");
            this.lbl_images.Images.SetKeyName(4, "logout.png");
            this.lbl_images.Images.SetKeyName(5, "print.png");
            this.lbl_images.Images.SetKeyName(6, "return_label.png");
            this.lbl_images.Images.SetKeyName(7, "search_label.png");
            this.lbl_images.Images.SetKeyName(8, "user_label.png");
            // 
            // dgv_info
            // 
            this.dgv_info.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_info.Location = new System.Drawing.Point(3, 96);
            this.dgv_info.Name = "dgv_info";
            this.dgv_info.Size = new System.Drawing.Size(858, 445);
            this.dgv_info.TabIndex = 5;
            this.dgv_info.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_info_CellMouseDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.ImageKey = "Calendar.png";
            this.label3.Location = new System.Drawing.Point(881, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(226, 33);
            this.label3.TabIndex = 6;
            this.label3.Text = "Filter Selection : ";
            // 
            // txt_name
            // 
            this.txt_name.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_name.Location = new System.Drawing.Point(1087, 363);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(204, 31);
            this.txt_name.TabIndex = 12;
            this.txt_name.TextChanged += new System.EventHandler(this.txt_name_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(882, 364);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(158, 30);
            this.label5.TabIndex = 13;
            this.label5.Text = "Student\'s Lrn";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(882, 447);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 30);
            this.label6.TabIndex = 82;
            this.label6.Text = "Book Title";
            // 
            // txt_booktitle
            // 
            this.txt_booktitle.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_booktitle.Location = new System.Drawing.Point(1087, 446);
            this.txt_booktitle.Name = "txt_booktitle";
            this.txt_booktitle.Size = new System.Drawing.Size(204, 31);
            this.txt_booktitle.TabIndex = 81;
            this.txt_booktitle.TextChanged += new System.EventHandler(this.txt_booktitle_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label4.ImageKey = "search_label.png";
            this.label4.ImageList = this.lbl_images;
            this.label4.Location = new System.Drawing.Point(463, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(195, 44);
            this.label4.TabIndex = 11;
            this.label4.Text = "     Search";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.ImageKey = "calendar_to.png";
            this.label2.ImageList = this.lbl_images;
            this.label2.Location = new System.Drawing.Point(892, 177);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 33);
            this.label2.TabIndex = 4;
            this.label2.Text = "       Date To :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.ImageKey = "calendar_from.png";
            this.label1.ImageList = this.lbl_images;
            this.label1.Location = new System.Drawing.Point(892, 132);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 33);
            this.label1.TabIndex = 3;
            this.label1.Text = "       Date From :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // cbo_status
            // 
            this.cbo_status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_status.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_status.FormattingEnabled = true;
            this.cbo_status.Items.AddRange(new object[] {
            "Borrowed",
            "Returned",
            "Lost"});
            this.cbo_status.Location = new System.Drawing.Point(1087, 281);
            this.cbo_status.Margin = new System.Windows.Forms.Padding(2);
            this.cbo_status.Name = "cbo_status";
            this.cbo_status.Size = new System.Drawing.Size(204, 30);
            this.cbo_status.TabIndex = 83;
            this.cbo_status.SelectedValueChanged += new System.EventHandler(this.comboBox1_SelectedValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(882, 281);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 30);
            this.label7.TabIndex = 84;
            this.label7.Text = "Status";
            // 
            // dtp_from
            // 
            this.dtp_from.CalendarFont = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_from.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_from.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_from.Location = new System.Drawing.Point(1137, 132);
            this.dtp_from.Name = "dtp_from";
            this.dtp_from.Size = new System.Drawing.Size(153, 33);
            this.dtp_from.TabIndex = 0;
            // 
            // dtp_to
            // 
            this.dtp_to.CalendarFont = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_to.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_to.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_to.Location = new System.Drawing.Point(1137, 177);
            this.dtp_to.Name = "dtp_to";
            this.dtp_to.Size = new System.Drawing.Size(153, 33);
            this.dtp_to.TabIndex = 1;
            // 
            // btn_gr1
            // 
            this.btn_gr1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_gr1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_gr1.ImageKey = "print.png";
            this.btn_gr1.ImageList = this.lbl_images;
            this.btn_gr1.Location = new System.Drawing.Point(1141, 313);
            this.btn_gr1.Margin = new System.Windows.Forms.Padding(0);
            this.btn_gr1.Name = "btn_gr1";
            this.btn_gr1.Size = new System.Drawing.Size(150, 41);
            this.btn_gr1.TabIndex = 85;
            this.btn_gr1.Text = "         Print Monthly";
            this.btn_gr1.UseVisualStyleBackColor = true;
            this.btn_gr1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_gr2
            // 
            this.btn_gr2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_gr2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_gr2.ImageKey = "print.png";
            this.btn_gr2.ImageList = this.lbl_images;
            this.btn_gr2.Location = new System.Drawing.Point(1141, 397);
            this.btn_gr2.Margin = new System.Windows.Forms.Padding(0);
            this.btn_gr2.Name = "btn_gr2";
            this.btn_gr2.Size = new System.Drawing.Size(150, 41);
            this.btn_gr2.TabIndex = 86;
            this.btn_gr2.Text = "        Print Student";
            this.btn_gr2.UseVisualStyleBackColor = true;
            this.btn_gr2.Click += new System.EventHandler(this.btn_gr2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1198, 223);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 26);
            this.button1.TabIndex = 88;
            this.button1.Text = "Filter Date";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Frm_reporting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1342, 543);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_gr2);
            this.Controls.Add(this.btn_gr1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbo_status);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_booktitle);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgv_info);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtp_to);
            this.Controls.Add(this.dtp_from);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_reporting";
            this.Text = "Frm_reporting";
            this.Load += new System.EventHandler(this.Frm_reporting_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_info)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ImageList lbl_images;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgv_info;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_booktitle;
        private System.Windows.Forms.ComboBox cbo_status;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtp_from;
        private System.Windows.Forms.DateTimePicker dtp_to;
        private System.Windows.Forms.Button btn_gr1;
        private System.Windows.Forms.Button btn_gr2;
        private System.Windows.Forms.Button button1;
    }
}