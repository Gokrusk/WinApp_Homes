namespace WinApp_Homes
{
    partial class VentaForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.CbxInmueble = new System.Windows.Forms.ComboBox();
            this.CbxCliente = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtMensualidad = new System.Windows.Forms.TextBox();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.dataSetVenta1 = new WinApp_Homes.DataSetVenta();
            this.TxtMeses = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.LblPrecio = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetVenta1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(90)))), ((int)(((byte)(108)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(888, 78);
            this.panel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(390, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "VENTA";
            // 
            // CbxInmueble
            // 
            this.CbxInmueble.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbxInmueble.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbxInmueble.FormattingEnabled = true;
            this.CbxInmueble.Location = new System.Drawing.Point(30, 136);
            this.CbxInmueble.Name = "CbxInmueble";
            this.CbxInmueble.Size = new System.Drawing.Size(355, 26);
            this.CbxInmueble.TabIndex = 4;
            this.CbxInmueble.SelectionChangeCommitted += new System.EventHandler(this.CbxInmueble_SelectionChangeCommitted);
            // 
            // CbxCliente
            // 
            this.CbxCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbxCliente.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbxCliente.FormattingEnabled = true;
            this.CbxCliente.Location = new System.Drawing.Point(491, 136);
            this.CbxCliente.Name = "CbxCliente";
            this.CbxCliente.Size = new System.Drawing.Size(318, 26);
            this.CbxCliente.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(26, 111);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "Inmueble";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(487, 111);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 22);
            this.label3.TabIndex = 6;
            this.label3.Text = "Cliente";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(26, 272);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(181, 22);
            this.label4.TabIndex = 7;
            this.label4.Text = "Mensualidad         $";
            // 
            // TxtMensualidad
            // 
            this.TxtMensualidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtMensualidad.Location = new System.Drawing.Point(215, 271);
            this.TxtMensualidad.Name = "TxtMensualidad";
            this.TxtMensualidad.Size = new System.Drawing.Size(170, 26);
            this.TxtMensualidad.TabIndex = 8;
            this.TxtMensualidad.TextChanged += new System.EventHandler(this.TxtMensualidad_TextChanged);
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(198)))), ((int)(((byte)(73)))));
            this.BtnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnGuardar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(169)))), ((int)(((byte)(143)))));
            this.BtnGuardar.FlatAppearance.BorderSize = 0;
            this.BtnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGuardar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardar.ForeColor = System.Drawing.Color.Black;
            this.BtnGuardar.Location = new System.Drawing.Point(370, 456);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(155, 43);
            this.BtnGuardar.TabIndex = 23;
            this.BtnGuardar.Text = "GENERAR VENTA";
            this.BtnGuardar.UseVisualStyleBackColor = false;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // dataSetVenta1
            // 
            this.dataSetVenta1.DataSetName = "DataSetVenta";
            this.dataSetVenta1.EnforceConstraints = false;
            this.dataSetVenta1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // TxtMeses
            // 
            this.TxtMeses.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtMeses.Location = new System.Drawing.Point(617, 267);
            this.TxtMeses.Name = "TxtMeses";
            this.TxtMeses.ReadOnly = true;
            this.TxtMeses.Size = new System.Drawing.Size(157, 26);
            this.TxtMeses.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(487, 268);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 22);
            this.label5.TabIndex = 24;
            this.label5.Text = "Meses Plazo";
            // 
            // LblPrecio
            // 
            this.LblPrecio.AutoSize = true;
            this.LblPrecio.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPrecio.ForeColor = System.Drawing.Color.White;
            this.LblPrecio.Location = new System.Drawing.Point(26, 192);
            this.LblPrecio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblPrecio.Name = "LblPrecio";
            this.LblPrecio.Size = new System.Drawing.Size(69, 22);
            this.LblPrecio.TabIndex = 26;
            this.LblPrecio.Text = "Precio";
            // 
            // VentaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(58)))), ((int)(((byte)(63)))));
            this.ClientSize = new System.Drawing.Size(884, 511);
            this.Controls.Add(this.LblPrecio);
            this.Controls.Add(this.TxtMeses);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.TxtMensualidad);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CbxCliente);
            this.Controls.Add(this.CbxInmueble);
            this.Controls.Add(this.panel1);
            this.Name = "VentaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Venta a cliente";
            this.Load += new System.EventHandler(this.VentaForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetVenta1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CbxInmueble;
        private System.Windows.Forms.ComboBox CbxCliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private DataSetVenta dataSetVenta1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtMensualidad;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.TextBox TxtMeses;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label LblPrecio;
    }
}