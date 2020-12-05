
namespace CustomsGestionHoteliere
{
    partial class FrmPreview
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
            this.EasyGestDataSet11 = new CustomsGestionHoteliere.EasyGestDataSet11();
            this.FACTURESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.FACTURESTableAdapter = new CustomsGestionHoteliere.EasyGestDataSet11TableAdapters.FACTURESTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.EasyGestDataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FACTURESBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.FACTURESBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CustomsGestionHoteliere.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // EasyGestDataSet11
            // 
            this.EasyGestDataSet11.DataSetName = "EasyGestDataSet11";
            this.EasyGestDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // FACTURESBindingSource
            // 
            this.FACTURESBindingSource.DataMember = "FACTURES";
            this.FACTURESBindingSource.DataSource = this.EasyGestDataSet11;
            // 
            // FACTURESTableAdapter
            // 
            this.FACTURESTableAdapter.ClearBeforeFill = true;
            // 
            // FrmPreview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrmPreview";
            this.Text = "FrmPreview";
            this.Load += new System.EventHandler(this.FrmPreview_Load);
            ((System.ComponentModel.ISupportInitialize)(this.EasyGestDataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FACTURESBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource FACTURESBindingSource;
        private EasyGestDataSet11 EasyGestDataSet11;
        private EasyGestDataSet11TableAdapters.FACTURESTableAdapter FACTURESTableAdapter;
    }
}