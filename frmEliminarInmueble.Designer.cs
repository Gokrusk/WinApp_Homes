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
            this.txtCodInmueble = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.LblTipoMostrar = new System.Windows.Forms.Label();
            this.LblNombreMostrar = new System.Windows.Forms.Label();
            this.LblDescMostrar = new System.Windows.Forms.Label();
            this.LblUbicacionMostrar = new System.Windows.Forms.Label();
            this.LblPrecioMostrar = new System.Windows.Forms.Label();
            this.LblCodigo = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDescripcionMostrar = new System.Windows.Forms.TextBox();
            this.PbxImagen = new System.Windows.Forms.PictureBox();
            this.ListImagenes = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbxImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(155, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(440, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "ELIMINACIÓN DE UN INMUEBLE";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(90)))), ((int)(((byte)(108)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(-1, 1);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(763, 78);
            this.panel1.TabIndex = 3;
            // 
            // txtCodInmueble
            // 
            this.txtCodInmueble.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.txtCodInmueble.Location = new System.Drawing.Point(258, 96);
            this.txtCodInmueble.Name = "txtCodInmueble";
            this.txtCodInmueble.Size = new System.Drawing.Size(194, 26);
            this.txtCodInmueble.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Location = new System.Drawing.Point(68, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 18);
            this.label2.TabIndex = 8;
            this.label2.Text = "Código del Inmueble:";
            // 
            // LblTipoMostrar
            // 
            this.LblTipoMostrar.AutoSize = true;
            this.LblTipoMostrar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTipoMostrar.ForeColor = System.Drawing.Color.White;
            this.LblTipoMostrar.Location = new System.Drawing.Point(89, 244);
            this.LblTipoMostrar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblTipoMostrar.Name = "LblTipoMostrar";
            this.LblTipoMostrar.Size = new System.Drawing.Size(131, 18);
            this.LblTipoMostrar.TabIndex = 49;
            this.LblTipoMostrar.Text = "Tipo: __________";
            // 
            // LblNombreMostrar
            // 
            this.LblNombreMostrar.AutoSize = true;
            this.LblNombreMostrar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNombreMostrar.ForeColor = System.Drawing.Color.White;
            this.LblNombreMostrar.Location = new System.Drawing.Point(89, 208);
            this.LblNombreMostrar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblNombreMostrar.Name = "LblNombreMostrar";
            this.LblNombreMostrar.Size = new System.Drawing.Size(160, 18);
            this.LblNombreMostrar.TabIndex = 47;
            this.LblNombreMostrar.Text = "Nombre: __________";
            // 
            // LblDescMostrar
            // 
            this.LblDescMostrar.AutoSize = true;
            this.LblDescMostrar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDescMostrar.ForeColor = System.Drawing.Color.White;
            this.LblDescMostrar.Location = new System.Drawing.Point(89, 361);
            this.LblDescMostrar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblDescMostrar.Name = "LblDescMostrar";
            this.LblDescMostrar.Size = new System.Drawing.Size(109, 18);
            this.LblDescMostrar.TabIndex = 45;
            this.LblDescMostrar.Text = "Descripción:";
            // 
            // LblUbicacionMostrar
            // 
            this.LblUbicacionMostrar.AutoSize = true;
            this.LblUbicacionMostrar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUbicacionMostrar.ForeColor = System.Drawing.Color.White;
            this.LblUbicacionMostrar.Location = new System.Drawing.Point(89, 320);
            this.LblUbicacionMostrar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblUbicacionMostrar.Name = "LblUbicacionMostrar";
            this.LblUbicacionMostrar.Size = new System.Drawing.Size(177, 18);
            this.LblUbicacionMostrar.TabIndex = 44;
            this.LblUbicacionMostrar.Text = "Ubicación: __________";
            // 
            // LblPrecioMostrar
            // 
            this.LblPrecioMostrar.AutoSize = true;
            this.LblPrecioMostrar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPrecioMostrar.ForeColor = System.Drawing.Color.White;
            this.LblPrecioMostrar.Location = new System.Drawing.Point(89, 282);
            this.LblPrecioMostrar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblPrecioMostrar.Name = "LblPrecioMostrar";
            this.LblPrecioMostrar.Size = new System.Drawing.Size(149, 18);
            this.LblPrecioMostrar.TabIndex = 42;
            this.LblPrecioMostrar.Text = "Precio: __________";
            // 
            // LblCodigo
            // 
            this.LblCodigo.AutoSize = true;
            this.LblCodigo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCodigo.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.LblCodigo.Location = new System.Drawing.Point(242, 166);
            this.LblCodigo.Name = "LblCodigo";
            this.LblCodigo.Size = new System.Drawing.Size(0, 18);
            this.LblCodigo.TabIndex = 40;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label3.Location = new System.Drawing.Point(89, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 18);
            this.label3.TabIndex = 39;
            this.label3.Text = "Código: __________";
            // 
            // txtDescripcionMostrar
            // 
            this.txtDescripcionMostrar.Location = new System.Drawing.Point(206, 358);
            this.txtDescripcionMostrar.Multiline = true;
            this.txtDescripcionMostrar.Name = "txtDescripcionMostrar";
            this.txtDescripcionMostrar.Size = new System.Drawing.Size(246, 104);
            this.txtDescripcionMostrar.TabIndex = 50;
            // 
            // PbxImagen
            // 
            this.PbxImagen.Location = new System.Drawing.Point(482, 208);
            this.PbxImagen.Name = "PbxImagen";
            this.PbxImagen.Size = new System.Drawing.Size(250, 250);
            this.PbxImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbxImagen.TabIndex = 51;
            this.PbxImagen.TabStop = false;
            // 
            // ListImagenes
            // 
            this.ListImagenes.FormattingEnabled = true;
            this.ListImagenes.Location = new System.Drawing.Point(482, 166);
            this.ListImagenes.Name = "ListImagenes";
            this.ListImagenes.Size = new System.Drawing.Size(250, 30);
            this.ListImagenes.TabIndex = 53;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(571, 145);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 18);
            this.label5.TabIndex = 52;
            this.label5.Text = "Imágenes";
            // 
            // frmEliminarInmueble
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(58)))), ((int)(((byte)(63)))));
            this.ClientSize = new System.Drawing.Size(761, 511);
            this.Controls.Add(this.ListImagenes);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.PbxImagen);
            this.Controls.Add(this.txtDescripcionMostrar);
            this.Controls.Add(this.LblTipoMostrar);
            this.Controls.Add(this.LblNombreMostrar);
            this.Controls.Add(this.LblDescMostrar);
            this.Controls.Add(this.LblUbicacionMostrar);
            this.Controls.Add(this.LblPrecioMostrar);
            this.Controls.Add(this.LblCodigo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCodInmueble);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Name = "frmEliminarInmueble";
            this.Text = "frmEliminarInmueble";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbxImagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtCodInmueble;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LblTipoMostrar;
        private System.Windows.Forms.Label LblNombreMostrar;
        private System.Windows.Forms.Label LblDescMostrar;
        private System.Windows.Forms.Label LblUbicacionMostrar;
        private System.Windows.Forms.Label LblPrecioMostrar;
        private System.Windows.Forms.Label LblCodigo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDescripcionMostrar;
        private System.Windows.Forms.PictureBox PbxImagen;
        private System.Windows.Forms.ListBox ListImagenes;
        private System.Windows.Forms.Label label5;
    }
}