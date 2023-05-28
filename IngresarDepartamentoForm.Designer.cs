namespace WinApp_Homes
{
    partial class IngresarDepartamentoForm
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
            this.dataSetVentaCasas1 = new WinApp_Homes.DataSetVentaCasas();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetVentaCasas1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataSetVentaCasas1
            // 
            this.dataSetVentaCasas1.DataSetName = "DataSetVentaCasas";
            this.dataSetVentaCasas1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // IngresarDepartamentoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(58)))), ((int)(((byte)(63)))));
            this.ClientSize = new System.Drawing.Size(1179, 629);
            this.Name = "IngresarDepartamentoForm";
            this.Text = "Nuevo Departamento";
            ((System.ComponentModel.ISupportInitialize)(this.dataSetVentaCasas1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataSetVentaCasas dataSetVentaCasas1;
    }
}