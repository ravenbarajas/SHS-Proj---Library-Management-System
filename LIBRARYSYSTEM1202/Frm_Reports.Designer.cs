namespace LIBRARYSYSTEM1202
{
    partial class Frm_Reports
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
            this.CRV = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.rpt_Borrowing1 = new LIBRARYSYSTEM1202.Reports.Rpt_Borrowing();
            this.rpt_borrowed1 = new LIBRARYSYSTEM1202.Reports.Rpt_borrowed();
            this.SuspendLayout();
            // 
            // CRV
            // 
            this.CRV.ActiveViewIndex = -1;
            this.CRV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CRV.Cursor = System.Windows.Forms.Cursors.Default;
            this.CRV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CRV.Location = new System.Drawing.Point(0, 0);
            this.CRV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CRV.Name = "CRV";
            this.CRV.Size = new System.Drawing.Size(1087, 734);
            this.CRV.TabIndex = 0;
            this.CRV.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            this.CRV.Load += new System.EventHandler(this.CRV_Load);
            // 
            // rpt_Borrowing1
            // 
            this.rpt_Borrowing1.InitReport += new System.EventHandler(this.rpt_Borrowing1_InitReport);
            // 
            // Frm_Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1087, 734);
            this.Controls.Add(this.CRV);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Frm_Reports";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_Reports";
            this.Load += new System.EventHandler(this.Frm_Reports_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer CRV;
        private Reports.Rpt_Borrowing rpt_Borrowing1;
        private Reports.Rpt_borrowed rpt_borrowed1;
    }
}