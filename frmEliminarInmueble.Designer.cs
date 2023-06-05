namespace WinApp_Homes
{
    partial class frmEliminarInmueble
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LblTipoMostrar = new System.Windows.Forms.Label();
            this.LblNombreMostrar = new System.Windows.Forms.Label();
            this.LblDescMostrar = new System.Windows.Forms.Label();
            this.LblUbicacionMostrar = new System.Windows.Forms.Label();
            this.LblPrecioMostrar = new System.Windows.Forms.Label();
            this.LblCodigo = new System.Windows.Forms.Label();
            this.lblCodigoMostrar = new System.Windows.Forms.Label();
            this.txtDescripcionMostrar = new System.Windows.Forms.TextBox();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.dataSetVenta1 = new WinApp_Homes.DataSetVenta();
            this.btnVerFotos = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetVenta1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(55, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(900, 39);
            this.label1.TabIndex = 2;
            this.label1.Text = "CONFIRMACIÓN DE ELIMINACIÓN DE UN INMUEBLE";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(90)))), ((int)(((byte)(108)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(-1, 1);
            this.panel1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1017, 96);
            this.panel1.TabIndex = 3;
            // 
            // LblTipoMostrar
            // 
            this.LblTipoMostrar.AutoSize = true;
            this.LblTipoMostrar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTipoMostrar.ForeColor = System.Drawing.Color.White;
            this.LblTipoMostrar.Location = new System.Drawing.Point(117, 215);
            this.LblTipoMostrar.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LblTipoMostrar.Name = "LblTipoMostrar";
            this.LblTipoMostrar.Size = new System.Drawing.Size(164, 23);
            this.LblTipoMostrar.TabIndex = 49;
            this.LblTipoMostrar.Text = "Tipo: __________";
            // 
            // LblNombreMostrar
            // 
            this.LblNombreMostrar.AutoSize = true;
            this.LblNombreMostrar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNombreMostrar.ForeColor = System.Drawing.Color.White;
            this.LblNombreMostrar.Location = new System.Drawing.Point(117, 171);
            this.LblNombreMostrar.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LblNombreMostrar.Name = "LblNombreMostrar";
            this.LblNombreMostrar.Size = new System.Drawing.Size(200, 23);
            this.LblNombreMostrar.TabIndex = 47;
            this.LblNombreMostrar.Text = "Nombre: __________";
            // 
            // LblDescMostrar
            // 
            this.LblDescMostrar.AutoSize = true;
            this.LblDescMostrar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDescMostrar.ForeColor = System.Drawing.Color.White;
            this.LblDescMostrar.Location = new System.Drawing.Point(120, 364);
            this.LblDescMostrar.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LblDescMostrar.Name = "LblDescMostrar";
            this.LblDescMostrar.Size = new System.Drawing.Size(134, 23);
            this.LblDescMostrar.TabIndex = 45;
            this.LblDescMostrar.Text = "Descripción:";
            // 
            // LblUbicacionMostrar
            // 
            this.LblUbicacionMostrar.AutoSize = true;
            this.LblUbicacionMostrar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUbicacionMostrar.ForeColor = System.Drawing.Color.White;
            this.LblUbicacionMostrar.Location = new System.Drawing.Point(117, 309);
            this.LblUbicacionMostrar.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LblUbicacionMostrar.Name = "LblUbicacionMostrar";
            this.LblUbicacionMostrar.Size = new System.Drawing.Size(219, 23);
            this.LblUbicacionMostrar.TabIndex = 44;
            this.LblUbicacionMostrar.Text = "Ubicación: __________";
            // 
            // LblPrecioMostrar
            // 
            this.LblPrecioMostrar.AutoSize = true;
            this.LblPrecioMostrar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPrecioMostrar.ForeColor = System.Drawing.Color.White;
            this.LblPrecioMostrar.Location = new System.Drawing.Point(117, 262);
            this.LblPrecioMostrar.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LblPrecioMostrar.Name = "LblPrecioMostrar";
            this.LblPrecioMostrar.Size = new System.Drawing.Size(184, 23);
            this.LblPrecioMostrar.TabIndex = 42;
            this.LblPrecioMostrar.Text = "Precio: __________";
            // 
            // LblCodigo
            // 
            this.LblCodigo.AutoSize = true;
            this.LblCodigo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCodigo.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.LblCodigo.Location = new System.Drawing.Point(321, 119);
            this.LblCodigo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblCodigo.Name = "LblCodigo";
            this.LblCodigo.Size = new System.Drawing.Size(0, 23);
            this.LblCodigo.TabIndex = 40;
            // 
            // lblCodigoMostrar
            // 
            this.lblCodigoMostrar.AutoSize = true;
            this.lblCodigoMostrar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoMostrar.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblCodigoMostrar.Location = new System.Drawing.Point(117, 119);
            this.lblCodigoMostrar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCodigoMostrar.Name = "lblCodigoMostrar";
            this.lblCodigoMostrar.Size = new System.Drawing.Size(191, 23);
            this.lblCodigoMostrar.TabIndex = 39;
            this.lblCodigoMostrar.Text = "Código: __________";
            // 
            // txtDescripcionMostrar
            // 
            this.txtDescripcionMostrar.Location = new System.Drawing.Point(276, 361);
            this.txtDescripcionMostrar.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescripcionMostrar.Multiline = true;
            this.txtDescripcionMostrar.Name = "txtDescripcionMostrar";
            this.txtDescripcionMostrar.Size = new System.Drawing.Size(327, 127);
            this.txtDescripcionMostrar.TabIndex = 50;
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(3)))), ((int)(((byte)(31)))));
            this.BtnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnEliminar.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.BtnEliminar.FlatAppearance.BorderSize = 0;
            this.BtnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEliminar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminar.ForeColor = System.Drawing.Color.White;
            this.BtnEliminar.Location = new System.Drawing.Point(276, 555);
            this.BtnEliminar.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(207, 53);
            this.BtnEliminar.TabIndex = 54;
            this.BtnEliminar.Text = "ELIMINAR";
            this.BtnEliminar.UseVisualStyleBackColor = false;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.White;
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.Black;
            this.btnCancelar.Location = new System.Drawing.Point(540, 555);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(207, 53);
            this.btnCancelar.TabIndex = 55;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // dataSetVenta1
            // 
            this.dataSetVenta1.DataSetName = "DataSetVenta";
            this.dataSetVenta1.EnforceConstraints = false;
            this.dataSetVenta1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnVerFotos
            // 
            this.btnVerFotos.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F);
            this.btnVerFotos.Location = new System.Drawing.Point(724, 396);
            this.btnVerFotos.Margin = new System.Windows.Forms.Padding(4);
            this.btnVerFotos.Name = "btnVerFotos";
            this.btnVerFotos.Size = new System.Drawing.Size(207, 53);
            this.btnVerFotos.TabIndex = 56;
            this.btnVerFotos.Text = "Ver Fotos";
            this.btnVerFotos.UseVisualStyleBackColor = true;
            this.btnVerFotos.Click += new System.EventHandler(this.btnVerFotos_Click);
            // 
            // frmEliminarInmueble
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(58)))), ((int)(((byte)(63)))));
            this.ClientSize = new System.Drawing.Size(1015, 690);
            this.Controls.Add(this.btnVerFotos);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.txtDescripcionMostrar);
            this.Controls.Add(this.LblTipoMostrar);
            this.Controls.Add(this.LblNombreMostrar);
            this.Controls.Add(this.LblDescMostrar);
            this.Controls.Add(this.LblUbicacionMostrar);
            this.Controls.Add(this.LblPrecioMostrar);
            this.Controls.Add(this.LblCodigo);
            this.Controls.Add(this.lblCodigoMostrar);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmEliminarInmueble";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Confirmar eliminar inmueble";
            this.Load += new System.EventHandler(this.frmEliminarInmueble_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetVenta1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LblTipoMostrar;
        private System.Windows.Forms.Label LblNombreMostrar;
        private System.Windows.Forms.Label LblDescMostrar;
        private System.Windows.Forms.Label LblUbicacionMostrar;
        private System.Windows.Forms.Label LblPrecioMostrar;
        private System.Windows.Forms.Label LblCodigo;
        private System.Windows.Forms.Label lblCodigoMostrar;
        private System.Windows.Forms.TextBox txtDescripcionMostrar;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button btnCancelar;
        private DataSetVenta dataSetVenta1;
        private System.Windows.Forms.Button btnVerFotos;
    }
}