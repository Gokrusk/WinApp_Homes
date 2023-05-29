namespace WinApp_Homes {
    partial class ModificarClienteForm {
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.GbxBuscar = new System.Windows.Forms.GroupBox();
            this.TxtCedulaBus = new System.Windows.Forms.TextBox();
            this.LblCedulaBus = new System.Windows.Forms.Label();
            this.GbxDatos = new System.Windows.Forms.GroupBox();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.LblInfoCorr = new System.Windows.Forms.Label();
            this.LblInfoApe = new System.Windows.Forms.Label();
            this.LblInfoNom = new System.Windows.Forms.Label();
            this.TxtCorreo = new System.Windows.Forms.TextBox();
            this.CbxCiudad = new System.Windows.Forms.ComboBox();
            this.DtpFecha = new System.Windows.Forms.DateTimePicker();
            this.CbxSexo = new System.Windows.Forms.ComboBox();
            this.LblSexo = new System.Windows.Forms.Label();
            this.TxtApellido = new System.Windows.Forms.TextBox();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.LblCorreo = new System.Windows.Forms.Label();
            this.LblFechaNa = new System.Windows.Forms.Label();
            this.LblCiudad = new System.Windows.Forms.Label();
            this.LblApellido = new System.Windows.Forms.Label();
            this.LblNombre = new System.Windows.Forms.Label();
            this.LblCedula = new System.Windows.Forms.Label();
            this.dataSetVenta1 = new WinApp_Homes.DataSetVenta();
            this.dataSetVenta2 = new WinApp_Homes.DataSetVenta();
            this.panel1.SuspendLayout();
            this.GbxBuscar.SuspendLayout();
            this.GbxDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetVenta1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetVenta2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(90)))), ((int)(((byte)(108)))));
            this.panel1.Controls.Add(this.lblTitulo);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(-2, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(885, 78);
            this.panel1.TabIndex = 3;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(209, 23);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(437, 32);
            this.lblTitulo.TabIndex = 2;
            this.lblTitulo.Text = "MODIFICACIÓN DE UN CLIENTE";
            // 
            // GbxBuscar
            // 
            this.GbxBuscar.Controls.Add(this.TxtCedulaBus);
            this.GbxBuscar.Controls.Add(this.LblCedulaBus);
            this.GbxBuscar.ForeColor = System.Drawing.Color.White;
            this.GbxBuscar.Location = new System.Drawing.Point(28, 91);
            this.GbxBuscar.Name = "GbxBuscar";
            this.GbxBuscar.Size = new System.Drawing.Size(455, 83);
            this.GbxBuscar.TabIndex = 4;
            this.GbxBuscar.TabStop = false;
            this.GbxBuscar.Text = "Búsqueda";
            // 
            // TxtCedulaBus
            // 
            this.TxtCedulaBus.Location = new System.Drawing.Point(252, 34);
            this.TxtCedulaBus.Name = "TxtCedulaBus";
            this.TxtCedulaBus.Size = new System.Drawing.Size(184, 26);
            this.TxtCedulaBus.TabIndex = 23;
            this.TxtCedulaBus.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCedulaBus_KeyPress);
            // 
            // LblCedulaBus
            // 
            this.LblCedulaBus.AutoSize = true;
            this.LblCedulaBus.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCedulaBus.ForeColor = System.Drawing.Color.White;
            this.LblCedulaBus.Location = new System.Drawing.Point(22, 37);
            this.LblCedulaBus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblCedulaBus.Name = "LblCedulaBus";
            this.LblCedulaBus.Size = new System.Drawing.Size(221, 18);
            this.LblCedulaBus.TabIndex = 22;
            this.LblCedulaBus.Text = "Ingrese número de cédula:";
            // 
            // GbxDatos
            // 
            this.GbxDatos.Controls.Add(this.BtnCancelar);
            this.GbxDatos.Controls.Add(this.button1);
            this.GbxDatos.Controls.Add(this.LblInfoCorr);
            this.GbxDatos.Controls.Add(this.LblInfoApe);
            this.GbxDatos.Controls.Add(this.LblInfoNom);
            this.GbxDatos.Controls.Add(this.TxtCorreo);
            this.GbxDatos.Controls.Add(this.CbxCiudad);
            this.GbxDatos.Controls.Add(this.DtpFecha);
            this.GbxDatos.Controls.Add(this.CbxSexo);
            this.GbxDatos.Controls.Add(this.LblSexo);
            this.GbxDatos.Controls.Add(this.TxtApellido);
            this.GbxDatos.Controls.Add(this.TxtNombre);
            this.GbxDatos.Controls.Add(this.LblCorreo);
            this.GbxDatos.Controls.Add(this.LblFechaNa);
            this.GbxDatos.Controls.Add(this.LblCiudad);
            this.GbxDatos.Controls.Add(this.LblApellido);
            this.GbxDatos.Controls.Add(this.LblNombre);
            this.GbxDatos.Controls.Add(this.LblCedula);
            this.GbxDatos.ForeColor = System.Drawing.Color.White;
            this.GbxDatos.Location = new System.Drawing.Point(28, 192);
            this.GbxDatos.Name = "GbxDatos";
            this.GbxDatos.Size = new System.Drawing.Size(827, 302);
            this.GbxDatos.TabIndex = 24;
            this.GbxDatos.TabStop = false;
            this.GbxDatos.Text = "Datos";
            this.GbxDatos.Visible = false;
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(3)))), ((int)(((byte)(31)))));
            this.BtnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancelar.ForeColor = System.Drawing.Color.White;
            this.BtnCancelar.Location = new System.Drawing.Point(641, 98);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(155, 43);
            this.BtnCancelar.TabIndex = 25;
            this.BtnCancelar.Text = "CANCELAR";
            this.BtnCancelar.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(198)))), ((int)(((byte)(73)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(641, 35);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 43);
            this.button1.TabIndex = 24;
            this.button1.Text = "GUARDAR";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // LblInfoCorr
            // 
            this.LblInfoCorr.AutoSize = true;
            this.LblInfoCorr.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblInfoCorr.Location = new System.Drawing.Point(211, 283);
            this.LblInfoCorr.Name = "LblInfoCorr";
            this.LblInfoCorr.Size = new System.Drawing.Size(0, 12);
            this.LblInfoCorr.TabIndex = 24;
            // 
            // LblInfoApe
            // 
            this.LblInfoApe.AutoSize = true;
            this.LblInfoApe.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblInfoApe.Location = new System.Drawing.Point(410, 115);
            this.LblInfoApe.Name = "LblInfoApe";
            this.LblInfoApe.Size = new System.Drawing.Size(0, 12);
            this.LblInfoApe.TabIndex = 23;
            // 
            // LblInfoNom
            // 
            this.LblInfoNom.AutoSize = true;
            this.LblInfoNom.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblInfoNom.Location = new System.Drawing.Point(123, 114);
            this.LblInfoNom.Name = "LblInfoNom";
            this.LblInfoNom.Size = new System.Drawing.Size(0, 12);
            this.LblInfoNom.TabIndex = 22;
            // 
            // TxtCorreo
            // 
            this.TxtCorreo.Location = new System.Drawing.Point(213, 245);
            this.TxtCorreo.Name = "TxtCorreo";
            this.TxtCorreo.Size = new System.Drawing.Size(326, 26);
            this.TxtCorreo.TabIndex = 20;
            this.TxtCorreo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCorreo_KeyPress);
            // 
            // CbxCiudad
            // 
            this.CbxCiudad.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbxCiudad.FormattingEnabled = true;
            this.CbxCiudad.Items.AddRange(new object[] {
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
            this.CbxCiudad.Location = new System.Drawing.Point(118, 194);
            this.CbxCiudad.Name = "CbxCiudad";
            this.CbxCiudad.Size = new System.Drawing.Size(150, 25);
            this.CbxCiudad.TabIndex = 19;
            this.CbxCiudad.SelectedIndexChanged += new System.EventHandler(this.CbxCiudad_SelectedIndexChanged);
            // 
            // DtpFecha
            // 
            this.DtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpFecha.Location = new System.Drawing.Point(462, 141);
            this.DtpFecha.Name = "DtpFecha";
            this.DtpFecha.Size = new System.Drawing.Size(135, 26);
            this.DtpFecha.TabIndex = 18;
            this.DtpFecha.Value = new System.DateTime(2023, 5, 28, 10, 35, 34, 0);
            this.DtpFecha.ValueChanged += new System.EventHandler(this.DtpFecha_ValueChanged);
            // 
            // CbxSexo
            // 
            this.CbxSexo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbxSexo.FormattingEnabled = true;
            this.CbxSexo.Items.AddRange(new object[] {
            "Masculino",
            "Femenino"});
            this.CbxSexo.Location = new System.Drawing.Point(101, 141);
            this.CbxSexo.Name = "CbxSexo";
            this.CbxSexo.Size = new System.Drawing.Size(121, 25);
            this.CbxSexo.TabIndex = 17;
            this.CbxSexo.SelectedIndexChanged += new System.EventHandler(this.CbxSexo_SelectedIndexChanged);
            // 
            // LblSexo
            // 
            this.LblSexo.AutoSize = true;
            this.LblSexo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSexo.ForeColor = System.Drawing.Color.White;
            this.LblSexo.Location = new System.Drawing.Point(42, 143);
            this.LblSexo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblSexo.Name = "LblSexo";
            this.LblSexo.Size = new System.Drawing.Size(52, 18);
            this.LblSexo.TabIndex = 13;
            this.LblSexo.Text = "Sexo:";
            // 
            // TxtApellido
            // 
            this.TxtApellido.Location = new System.Drawing.Point(412, 86);
            this.TxtApellido.MaxLength = 20;
            this.TxtApellido.Name = "TxtApellido";
            this.TxtApellido.Size = new System.Drawing.Size(143, 26);
            this.TxtApellido.TabIndex = 12;
            this.TxtApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtApellido_KeyPress);
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(125, 86);
            this.TxtNombre.MaxLength = 20;
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(143, 26);
            this.TxtNombre.TabIndex = 11;
            this.TxtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNombre_KeyPress);
            // 
            // LblCorreo
            // 
            this.LblCorreo.AutoSize = true;
            this.LblCorreo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCorreo.ForeColor = System.Drawing.Color.White;
            this.LblCorreo.Location = new System.Drawing.Point(42, 248);
            this.LblCorreo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblCorreo.Name = "LblCorreo";
            this.LblCorreo.Size = new System.Drawing.Size(164, 18);
            this.LblCorreo.TabIndex = 9;
            this.LblCorreo.Text = "Correo electrónico:";
            // 
            // LblFechaNa
            // 
            this.LblFechaNa.AutoSize = true;
            this.LblFechaNa.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFechaNa.ForeColor = System.Drawing.Color.White;
            this.LblFechaNa.Location = new System.Drawing.Point(276, 144);
            this.LblFechaNa.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblFechaNa.Name = "LblFechaNa";
            this.LblFechaNa.Size = new System.Drawing.Size(179, 18);
            this.LblFechaNa.TabIndex = 8;
            this.LblFechaNa.Text = "Fecha de nacimiento:";
            // 
            // LblCiudad
            // 
            this.LblCiudad.AutoSize = true;
            this.LblCiudad.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCiudad.ForeColor = System.Drawing.Color.White;
            this.LblCiudad.Location = new System.Drawing.Point(42, 196);
            this.LblCiudad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblCiudad.Name = "LblCiudad";
            this.LblCiudad.Size = new System.Drawing.Size(69, 18);
            this.LblCiudad.TabIndex = 7;
            this.LblCiudad.Text = "Ciudad:";
            // 
            // LblApellido
            // 
            this.LblApellido.AutoSize = true;
            this.LblApellido.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblApellido.ForeColor = System.Drawing.Color.White;
            this.LblApellido.Location = new System.Drawing.Point(330, 89);
            this.LblApellido.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblApellido.Name = "LblApellido";
            this.LblApellido.Size = new System.Drawing.Size(77, 18);
            this.LblApellido.TabIndex = 6;
            this.LblApellido.Text = "Apellido:";
            // 
            // LblNombre
            // 
            this.LblNombre.AutoSize = true;
            this.LblNombre.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNombre.ForeColor = System.Drawing.Color.White;
            this.LblNombre.Location = new System.Drawing.Point(42, 89);
            this.LblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(76, 18);
            this.LblNombre.TabIndex = 5;
            this.LblNombre.Text = "Nombre:";
            // 
            // LblCedula
            // 
            this.LblCedula.AutoSize = true;
            this.LblCedula.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCedula.ForeColor = System.Drawing.Color.White;
            this.LblCedula.Location = new System.Drawing.Point(42, 41);
            this.LblCedula.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblCedula.Name = "LblCedula";
            this.LblCedula.Size = new System.Drawing.Size(0, 18);
            this.LblCedula.TabIndex = 4;
            // 
            // dataSetVenta1
            // 
            this.dataSetVenta1.DataSetName = "DataSetVenta";
            this.dataSetVenta1.EnforceConstraints = false;
            this.dataSetVenta1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataSetVenta2
            // 
            this.dataSetVenta2.DataSetName = "DataSetVenta";
            this.dataSetVenta2.EnforceConstraints = false;
            this.dataSetVenta2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ModificarClienteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(58)))), ((int)(((byte)(63)))));
            this.ClientSize = new System.Drawing.Size(884, 511);
            this.Controls.Add(this.GbxDatos);
            this.Controls.Add(this.GbxBuscar);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximumSize = new System.Drawing.Size(900, 550);
            this.MinimumSize = new System.Drawing.Size(900, 550);
            this.Name = "ModificarClienteForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificar cliente";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.GbxBuscar.ResumeLayout(false);
            this.GbxBuscar.PerformLayout();
            this.GbxDatos.ResumeLayout(false);
            this.GbxDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetVenta1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetVenta2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.GroupBox GbxBuscar;
        private System.Windows.Forms.TextBox TxtCedulaBus;
        private System.Windows.Forms.Label LblCedulaBus;
        private System.Windows.Forms.GroupBox GbxDatos;
        private System.Windows.Forms.Label LblInfoCorr;
        private System.Windows.Forms.Label LblInfoApe;
        private System.Windows.Forms.Label LblInfoNom;
        private System.Windows.Forms.TextBox TxtCorreo;
        private System.Windows.Forms.ComboBox CbxCiudad;
        private System.Windows.Forms.DateTimePicker DtpFecha;
        private System.Windows.Forms.ComboBox CbxSexo;
        private System.Windows.Forms.Label LblSexo;
        private System.Windows.Forms.TextBox TxtApellido;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.Label LblCorreo;
        private System.Windows.Forms.Label LblFechaNa;
        private System.Windows.Forms.Label LblCiudad;
        private System.Windows.Forms.Label LblApellido;
        private System.Windows.Forms.Label LblNombre;
        private System.Windows.Forms.Label LblCedula;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button BtnCancelar;
        private DataSetVenta dataSetVenta1;
        private DataSetVenta dataSetVenta2;
    }
}