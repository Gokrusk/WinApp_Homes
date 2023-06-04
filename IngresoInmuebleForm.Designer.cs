namespace WinApp_Homes
{
    partial class IngresoInmuebleForm
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
            this.GbxInmueble = new System.Windows.Forms.GroupBox();
            this.CbxUbi = new System.Windows.Forms.ComboBox();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.PbxImagen = new System.Windows.Forms.PictureBox();
            this.ListImagenes = new System.Windows.Forms.ListBox();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnCargar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtDesc = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtPrecio = new System.Windows.Forms.TextBox();
            this.LblCedula = new System.Windows.Forms.Label();
            this.CbxTipo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataSetVenta1 = new WinApp_Homes.DataSetVenta();
            this.panel1.SuspendLayout();
            this.GbxInmueble.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbxImagen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetVenta1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(90)))), ((int)(((byte)(108)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1184, 96);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(346, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(491, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "INGRESO DE UN NUEVO INMUEBLE";
            // 
            // GbxInmueble
            // 
            this.GbxInmueble.Controls.Add(this.CbxUbi);
            this.GbxInmueble.Controls.Add(this.TxtNombre);
            this.GbxInmueble.Controls.Add(this.label6);
            this.GbxInmueble.Controls.Add(this.BtnGuardar);
            this.GbxInmueble.Controls.Add(this.PbxImagen);
            this.GbxInmueble.Controls.Add(this.ListImagenes);
            this.GbxInmueble.Controls.Add(this.BtnEliminar);
            this.GbxInmueble.Controls.Add(this.BtnCargar);
            this.GbxInmueble.Controls.Add(this.label5);
            this.GbxInmueble.Controls.Add(this.TxtDesc);
            this.GbxInmueble.Controls.Add(this.label4);
            this.GbxInmueble.Controls.Add(this.label3);
            this.GbxInmueble.Controls.Add(this.TxtPrecio);
            this.GbxInmueble.Controls.Add(this.LblCedula);
            this.GbxInmueble.Controls.Add(this.CbxTipo);
            this.GbxInmueble.Controls.Add(this.label2);
            this.GbxInmueble.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GbxInmueble.ForeColor = System.Drawing.Color.White;
            this.GbxInmueble.Location = new System.Drawing.Point(12, 103);
            this.GbxInmueble.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GbxInmueble.Name = "GbxInmueble";
            this.GbxInmueble.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GbxInmueble.Size = new System.Drawing.Size(1152, 512);
            this.GbxInmueble.TabIndex = 3;
            this.GbxInmueble.TabStop = false;
            this.GbxInmueble.Text = "Registro";
            // 
            // CbxUbi
            // 
            this.CbxUbi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbxUbi.FormattingEnabled = true;
            this.CbxUbi.Items.AddRange(new object[] {
            "Ambato",
            "Atuntaqui",
            "Azogues",
            "Babahoyo",
            "Balzar",
            "Cayambe",
            "Cuenca",
            "Durán",
            "El Carmen",
            "Esmeraldas",
            "Gualaceo",
            "Guaranda",
            "Guayaquil",
            "Huaquillas",
            "Ibarra",
            "Jipijapa",
            "La Libertad",
            "La Troncal",
            "Latacunga",
            "Loja",
            "Machachi",
            "Machala",
            "Manta",
            "Milagro",
            "Montalvo",
            "Montecristi",
            "Naranjal",
            "Nueva Loja (Lago Agrio)",
            "Otavalo",
            "Pasaje",
            "Pedro Carbo",
            "Pelileo",
            "Playas",
            "Portoviejo",
            "Puerto Francisco de Orellana",
            "Puyo",
            "Quevedo",
            "Quito",
            "Riobamba",
            "Salinas",
            "San Lorenzo",
            "Santa Elena",
            "Santa Rosa",
            "Santo Domingo de los Colorados",
            "Tena",
            "Tulcán",
            "Ventanas",
            "Vinces",
            "Yaguachi",
            "Zamora"});
            this.CbxUbi.Location = new System.Drawing.Point(173, 207);
            this.CbxUbi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CbxUbi.Name = "CbxUbi";
            this.CbxUbi.Size = new System.Drawing.Size(332, 26);
            this.CbxUbi.TabIndex = 25;
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(172, 38);
            this.TxtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(332, 26);
            this.TxtNombre.TabIndex = 24;
            this.TxtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNombre_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(8, 42);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 18);
            this.label6.TabIndex = 23;
            this.label6.Text = "Nombre:";
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(198)))), ((int)(((byte)(73)))));
            this.BtnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnGuardar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(169)))), ((int)(((byte)(143)))));
            this.BtnGuardar.FlatAppearance.BorderSize = 0;
            this.BtnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGuardar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardar.ForeColor = System.Drawing.Color.Black;
            this.BtnGuardar.Location = new System.Drawing.Point(13, 441);
            this.BtnGuardar.Margin = new System.Windows.Forms.Padding(4);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(207, 53);
            this.BtnGuardar.TabIndex = 22;
            this.BtnGuardar.Text = "GUARDAR";
            this.BtnGuardar.UseVisualStyleBackColor = false;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // PbxImagen
            // 
            this.PbxImagen.Location = new System.Drawing.Point(569, 158);
            this.PbxImagen.Margin = new System.Windows.Forms.Padding(4);
            this.PbxImagen.Name = "PbxImagen";
            this.PbxImagen.Size = new System.Drawing.Size(333, 308);
            this.PbxImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbxImagen.TabIndex = 21;
            this.PbxImagen.TabStop = false;
            // 
            // ListImagenes
            // 
            this.ListImagenes.FormattingEnabled = true;
            this.ListImagenes.ItemHeight = 18;
            this.ListImagenes.Location = new System.Drawing.Point(569, 57);
            this.ListImagenes.Margin = new System.Windows.Forms.Padding(4);
            this.ListImagenes.Name = "ListImagenes";
            this.ListImagenes.Size = new System.Drawing.Size(573, 58);
            this.ListImagenes.TabIndex = 20;
            this.ListImagenes.SelectedValueChanged += new System.EventHandler(this.ListImagenes_SelectedValueChanged);
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
            this.BtnEliminar.Location = new System.Drawing.Point(924, 406);
            this.BtnEliminar.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(207, 53);
            this.BtnEliminar.TabIndex = 19;
            this.BtnEliminar.Text = "BORRAR IMÁGENES";
            this.BtnEliminar.UseVisualStyleBackColor = false;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // BtnCargar
            // 
            this.BtnCargar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(198)))), ((int)(((byte)(73)))));
            this.BtnCargar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCargar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(169)))), ((int)(((byte)(143)))));
            this.BtnCargar.FlatAppearance.BorderSize = 0;
            this.BtnCargar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCargar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11F);
            this.BtnCargar.ForeColor = System.Drawing.Color.Black;
            this.BtnCargar.Location = new System.Drawing.Point(924, 319);
            this.BtnCargar.Margin = new System.Windows.Forms.Padding(4);
            this.BtnCargar.Name = "BtnCargar";
            this.BtnCargar.Size = new System.Drawing.Size(207, 53);
            this.BtnCargar.TabIndex = 18;
            this.BtnCargar.Text = "CARGAR IMÁGENES";
            this.BtnCargar.UseVisualStyleBackColor = false;
            this.BtnCargar.Click += new System.EventHandler(this.BtnCargar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(800, 26);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 18);
            this.label5.TabIndex = 17;
            this.label5.Text = "Imágenes";
            // 
            // TxtDesc
            // 
            this.TxtDesc.Location = new System.Drawing.Point(173, 277);
            this.TxtDesc.Margin = new System.Windows.Forms.Padding(4);
            this.TxtDesc.Multiline = true;
            this.TxtDesc.Name = "TxtDesc";
            this.TxtDesc.Size = new System.Drawing.Size(331, 137);
            this.TxtDesc.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(9, 281);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 18);
            this.label4.TabIndex = 15;
            this.label4.Text = "Descripción:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(8, 207);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 18);
            this.label3.TabIndex = 13;
            this.label3.Text = "Ubicación:";
            // 
            // TxtPrecio
            // 
            this.TxtPrecio.Location = new System.Drawing.Point(173, 149);
            this.TxtPrecio.Margin = new System.Windows.Forms.Padding(4);
            this.TxtPrecio.Name = "TxtPrecio";
            this.TxtPrecio.Size = new System.Drawing.Size(332, 26);
            this.TxtPrecio.TabIndex = 12;
            this.TxtPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtPrecio_KeyPress);
            // 
            // LblCedula
            // 
            this.LblCedula.AutoSize = true;
            this.LblCedula.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCedula.ForeColor = System.Drawing.Color.White;
            this.LblCedula.Location = new System.Drawing.Point(9, 153);
            this.LblCedula.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LblCedula.Name = "LblCedula";
            this.LblCedula.Size = new System.Drawing.Size(60, 18);
            this.LblCedula.TabIndex = 11;
            this.LblCedula.Text = "Precio";
            // 
            // CbxTipo
            // 
            this.CbxTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbxTipo.DropDownWidth = 250;
            this.CbxTipo.FormattingEnabled = true;
            this.CbxTipo.Items.AddRange(new object[] {
            "CASA",
            "DEPARTAMENTO",
            "OFICINA"});
            this.CbxTipo.Location = new System.Drawing.Point(173, 92);
            this.CbxTipo.Margin = new System.Windows.Forms.Padding(4);
            this.CbxTipo.Name = "CbxTipo";
            this.CbxTipo.Size = new System.Drawing.Size(331, 26);
            this.CbxTipo.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tipo:";
            // 
            // dataSetVenta1
            // 
            this.dataSetVenta1.DataSetName = "DataSetVenta";
            this.dataSetVenta1.EnforceConstraints = false;
            this.dataSetVenta1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // IngresoInmuebleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(58)))), ((int)(((byte)(63)))));
            this.ClientSize = new System.Drawing.Size(1179, 629);
            this.Controls.Add(this.GbxInmueble);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "IngresoInmuebleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = " ";
            this.Load += new System.EventHandler(this.IngresoDepartamentoForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.GbxInmueble.ResumeLayout(false);
            this.GbxInmueble.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbxImagen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetVenta1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox GbxInmueble;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CbxTipo;
        private System.Windows.Forms.TextBox TxtPrecio;
        private System.Windows.Forms.Label LblCedula;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtDesc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtnCargar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox ListImagenes;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.PictureBox PbxImagen;
        private System.Windows.Forms.Button BtnGuardar;
        private DataSetVenta dataSetVenta1;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox CbxUbi;
    }
}