namespace WinApp_Homes {
    partial class ReportesForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource11 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource12 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource13 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource14 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource15 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.tblClienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetVenta = new WinApp_Homes.DataSetVenta();
            this.TblInmuebleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TblVentaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fKTblInmuebleTblFotoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.LblIntruccion = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.reportViewer2 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.reportViewer3 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.Grafico = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer4 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.reportViewer5 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.tblClienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetVenta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TblInmuebleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TblVentaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKTblInmuebleTblFotoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grafico)).BeginInit();
            this.SuspendLayout();
            // 
            // tblClienteBindingSource
            // 
            this.tblClienteBindingSource.DataMember = "TblCliente";
            this.tblClienteBindingSource.DataSource = this.dataSetVenta;
            // 
            // dataSetVenta
            // 
            this.dataSetVenta.DataSetName = "DataSetVenta";
            this.dataSetVenta.EnforceConstraints = false;
            this.dataSetVenta.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // TblInmuebleBindingSource
            // 
            this.TblInmuebleBindingSource.DataMember = "TblInmueble";
            this.TblInmuebleBindingSource.DataSource = this.dataSetVenta;
            // 
            // TblVentaBindingSource
            // 
            this.TblVentaBindingSource.DataMember = "TblVenta";
            this.TblVentaBindingSource.DataSource = this.dataSetVenta;
            // 
            // fKTblInmuebleTblFotoBindingSource
            // 
            this.fKTblInmuebleTblFotoBindingSource.DataMember = "FK_TblInmueble_TblFoto";
            this.fKTblInmuebleTblFotoBindingSource.DataSource = this.TblInmuebleBindingSource;
            // 
            // LblIntruccion
            // 
            this.LblIntruccion.AutoSize = true;
            this.LblIntruccion.ForeColor = System.Drawing.Color.White;
            this.LblIntruccion.Location = new System.Drawing.Point(21, 27);
            this.LblIntruccion.Name = "LblIntruccion";
            this.LblIntruccion.Size = new System.Drawing.Size(184, 18);
            this.LblIntruccion.TabIndex = 0;
            this.LblIntruccion.Text = "Seleccione el reporte:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Gráfico de Inmuebles",
            "Listado de clientes",
            "Listado de inmuebles",
            "Listado de ventas",
            "Listado de Inmueble Imagen"});
            this.comboBox1.Location = new System.Drawing.Point(211, 24);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(300, 26);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // reportViewer1
            // 
            reportDataSource11.Name = "DataSet1";
            reportDataSource11.Value = this.tblClienteBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource11);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "WinApp_Homes.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(-1, 69);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(887, 443);
            this.reportViewer1.TabIndex = 2;
            this.reportViewer1.Visible = false;
            // 
            // reportViewer2
            // 
            reportDataSource12.Name = "DataSet1";
            reportDataSource12.Value = this.TblInmuebleBindingSource;
            this.reportViewer2.LocalReport.DataSources.Add(reportDataSource12);
            this.reportViewer2.LocalReport.ReportEmbeddedResource = "WinApp_Homes.ReportHomes.rdlc";
            this.reportViewer2.Location = new System.Drawing.Point(-1, 69);
            this.reportViewer2.Name = "reportViewer2";
            this.reportViewer2.ServerReport.BearerToken = null;
            this.reportViewer2.Size = new System.Drawing.Size(887, 443);
            this.reportViewer2.TabIndex = 3;
            this.reportViewer2.Visible = false;
            // 
            // reportViewer3
            // 
            reportDataSource13.Name = "DataSet1";
            reportDataSource13.Value = this.TblVentaBindingSource;
            this.reportViewer3.LocalReport.DataSources.Add(reportDataSource13);
            this.reportViewer3.LocalReport.ReportEmbeddedResource = "WinApp_Homes.Report2.rdlc";
            this.reportViewer3.Location = new System.Drawing.Point(-1, 69);
            this.reportViewer3.Name = "reportViewer3";
            this.reportViewer3.ServerReport.BearerToken = null;
            this.reportViewer3.Size = new System.Drawing.Size(887, 443);
            this.reportViewer3.TabIndex = 4;
            this.reportViewer3.Visible = false;
            // 
            // Grafico
            // 
            this.Grafico.DataMember = "TblInmueble";
            this.Grafico.DataSource = this.dataSetVenta;
            // 
            // reportViewer4
            // 
            reportDataSource14.Name = "DataSet1";
            reportDataSource14.Value = this.TblInmuebleBindingSource;
            reportDataSource15.Name = "DataSet2";
            reportDataSource15.Value = this.fKTblInmuebleTblFotoBindingSource;
            this.reportViewer4.LocalReport.DataSources.Add(reportDataSource14);
            this.reportViewer4.LocalReport.DataSources.Add(reportDataSource15);
            this.reportViewer4.LocalReport.ReportEmbeddedResource = "WinApp_Homes.Report3.rdlc";
            this.reportViewer4.Location = new System.Drawing.Point(-1, 69);
            this.reportViewer4.Name = "reportViewer4";
            this.reportViewer4.ServerReport.BearerToken = null;
            this.reportViewer4.Size = new System.Drawing.Size(887, 443);
            this.reportViewer4.TabIndex = 5;
            this.reportViewer4.Visible = false;
            // 
            // reportViewer5
            // 
            this.reportViewer5.LocalReport.ReportEmbeddedResource = "WinApp_Homes.ReportHomes.rdlc";
            this.reportViewer5.Location = new System.Drawing.Point(-1, 69);
            this.reportViewer5.Name = "reportViewer5";
            this.reportViewer5.ServerReport.BearerToken = null;
            this.reportViewer5.Size = new System.Drawing.Size(887, 443);
            this.reportViewer5.TabIndex = 6;
            this.reportViewer5.Visible = false;
            // 
            // ReportesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(58)))), ((int)(((byte)(63)))));
            this.ClientSize = new System.Drawing.Size(884, 511);
            this.Controls.Add(this.reportViewer5);
            this.Controls.Add(this.reportViewer4);
            this.Controls.Add(this.reportViewer3);
            this.Controls.Add(this.reportViewer2);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.LblIntruccion);
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximumSize = new System.Drawing.Size(900, 550);
            this.MinimumSize = new System.Drawing.Size(900, 550);
            this.Name = "ReportesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReportesForm";
            this.Load += new System.EventHandler(this.ReportesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblClienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetVenta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TblInmuebleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TblVentaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKTblInmuebleTblFotoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grafico)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblIntruccion;
        private System.Windows.Forms.ComboBox comboBox1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource tblClienteBindingSource;
        private DataSetVenta dataSetVenta;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer2;
        private System.Windows.Forms.BindingSource TblInmuebleBindingSource;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer3;
        private System.Windows.Forms.BindingSource TblVentaBindingSource;
        private System.Windows.Forms.BindingSource fKTblInmuebleTblFotoBindingSource;
        private System.Windows.Forms.BindingSource Grafico;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer4;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer5;
    }
}