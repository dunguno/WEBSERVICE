namespace WindowsForms
{
    partial class InDonHang_Form
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DataSetDonHang = new WindowsForms.DataSetDonHang();
            this.InDonHangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.InDonHang_TableAdapter = new WindowsForms.DataSetDonHangTableAdapters.InDonHang_TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetDonHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InDonHangBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DonHang";
            reportDataSource1.Value = this.InDonHangBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "WindowsForms.Report.ReportDonHang.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(680, 414);
            this.reportViewer1.TabIndex = 0;
            // 
            // DataSetDonHang
            // 
            this.DataSetDonHang.DataSetName = "DataSetDonHang";
            this.DataSetDonHang.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // InDonHangBindingSource
            // 
            this.InDonHangBindingSource.DataMember = "InDonHang";
            this.InDonHangBindingSource.DataSource = this.DataSetDonHang;
            // 
            // InDonHang_TableAdapter
            // 
            this.InDonHang_TableAdapter.ClearBeforeFill = true;
            // 
            // InDonHang_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 414);
            this.Controls.Add(this.reportViewer1);
            this.Name = "InDonHang_Form";
            this.Text = "InDonHang_Form";
            this.Load += new System.EventHandler(this.InDonHang_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataSetDonHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InDonHangBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource InDonHangBindingSource;
        private DataSetDonHang DataSetDonHang;
        private DataSetDonHangTableAdapters.InDonHang_TableAdapter InDonHang_TableAdapter;

    }
}