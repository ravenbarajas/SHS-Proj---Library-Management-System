namespace LIBRARYSYSTEM1202
{
    partial class Frm_historyreport
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
            this.rpt_borrowhistory1 = new LIBRARYSYSTEM1202.Reports.Rpt_borrowhistory();
            this.SuspendLayout();
            // 
            // CRV
            // 
            this.CRV.ActiveViewIndex = -1;
            this.CRV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CRV.Cursor = System.Windows.Forms.Cursors.Default;
            this.CRV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CRV.Location = new System.Drawing.Point(0, 0);
            this.CRV.Margin = new System.Windows.Forms.Padding(2);
            this.CRV.Name = "CRV";
            this.CRV.Size = new System.Drawing.Size(815, 596);
            this.CRV.TabIndex = 1;
            this.CRV.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            this.CRV.Load += new System.EventHandler(this.CRV_Load);
            // 
            // Frm_historyreport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 596);
            this.Controls.Add(this.CRV);
            this.Name = "Frm_historyreport";
            this.Text = "Frm_historyreport";
            this.Load += new System.EventHandler(this.Frm_historyreport_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Reports.Rpt_borrowhistory rpt_borrowhistory1;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer CRV;
    }
}