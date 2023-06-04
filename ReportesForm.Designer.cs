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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.tblClienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetVenta = new WinApp_Homes.DataSetVenta();
            this.LblIntruccion = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.tblClienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetVenta)).BeginInit();
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
            "Listado de clientes",
            "Promedio de precio"});
            this.comboBox1.Location = new System.Drawing.Point(211, 24);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(183, 26);
            this.comboBox1.TabIndex = 1;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.tblClienteBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "WinApp_Homes.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(-1, 69);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(887, 443);
            this.reportViewer1.TabIndex = 2;
            // 
            // ReportesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(58)))), ((int)(((byte)(63)))));
            this.ClientSize = new System.Drawing.Size(884, 511);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblIntruccion;
        private System.Windows.Forms.ComboBox comboBox1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource tblClienteBindingSource;
        private DataSetVenta dataSetVenta;
    }
}