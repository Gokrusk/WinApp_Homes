namespace WinApp_Homes
{
    partial class RegistroClientForm
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.GbxRegistro = new System.Windows.Forms.GroupBox();
            this.LblInfoCorr = new System.Windows.Forms.Label();
            this.LblInfoApe = new System.Windows.Forms.Label();
            this.LblInfoNom = new System.Windows.Forms.Label();
            this.LblInfoCed = new System.Windows.Forms.Label();
            this.TxtCorreo = new System.Windows.Forms.TextBox();
            this.CbxCiudad = new System.Windows.Forms.ComboBox();
            this.CbxSexo = new System.Windows.Forms.ComboBox();
            this.LblSexo = new System.Windows.Forms.Label();
            this.TxtApellido = new System.Windows.Forms.TextBox();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.TxtCedula = new System.Windows.Forms.TextBox();
            this.LblCorreo = new System.Windows.Forms.Label();
            this.LblFechaNa = new System.Windows.Forms.Label();
            this.LblCiudad = new System.Windows.Forms.Label();
            this.LblApellido = new System.Windows.Forms.Label();
            this.LblNombre = new System.Windows.Forms.Label();
            this.LblCedula = new System.Windows.Forms.Label();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.dataSetVenta1 = new WinApp_Homes.DataSetVenta();
            this.DtpFecha = new System.Windows.Forms.DateTimePicker();
            this.panel1.SuspendLayout();
            this.GbxRegistro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetVenta1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(90)))), ((int)(((byte)(108)))));
            this.panel1.Controls.Add(this.lblTitulo);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(-4, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(888, 78);
            this.panel1.TabIndex = 2;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(26, 23);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(150, 32);
            this.lblTitulo.TabIndex = 2;
            this.lblTitulo.Text = "CLIENTES";
            // 
            // GbxRegistro
            // 
            this.GbxRegistro.Controls.Add(this.DtpFecha);
            this.GbxRegistro.Controls.Add(this.LblInfoCorr);
            this.GbxRegistro.Controls.Add(this.LblInfoApe);
            this.GbxRegistro.Controls.Add(this.LblInfoNom);
            this.GbxRegistro.Controls.Add(this.LblInfoCed);
            this.GbxRegistro.Controls.Add(this.TxtCorreo);
            this.GbxRegistro.Controls.Add(this.CbxCiudad);
            this.GbxRegistro.Controls.Add(this.CbxSexo);
            this.GbxRegistro.Controls.Add(this.LblSexo);
            this.GbxRegistro.Controls.Add(this.TxtApellido);
            this.GbxRegistro.Controls.Add(this.TxtNombre);
            this.GbxRegistro.Controls.Add(this.TxtCedula);
            this.GbxRegistro.Controls.Add(this.LblCorreo);
            this.GbxRegistro.Controls.Add(this.LblFechaNa);
            this.GbxRegistro.Controls.Add(this.LblCiudad);
            this.GbxRegistro.Controls.Add(this.LblApellido);
            this.GbxRegistro.Controls.Add(this.LblNombre);
            this.GbxRegistro.Controls.Add(this.LblCedula);
            this.GbxRegistro.ForeColor = System.Drawing.Color.White;
            this.GbxRegistro.Location = new System.Drawing.Point(28, 120);
            this.GbxRegistro.Name = "GbxRegistro";
            this.GbxRegistro.Size = new System.Drawing.Size(654, 347);
            this.GbxRegistro.TabIndex = 3;
            this.GbxRegistro.TabStop = false;
            this.GbxRegistro.Text = "Registro";
            // 
            // LblInfoCorr
            // 
            this.LblInfoCorr.AutoSize = true;
            this.LblInfoCorr.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblInfoCorr.Location = new System.Drawing.Point(211, 315);
            this.LblInfoCorr.Name = "LblInfoCorr";
            this.LblInfoCorr.Size = new System.Drawing.Size(0, 12);
            this.LblInfoCorr.TabIndex = 24;
            // 
            // LblInfoApe
            // 
            this.LblInfoApe.AutoSize = true;
            this.LblInfoApe.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblInfoApe.Location = new System.Drawing.Point(410, 140);
            this.LblInfoApe.Name = "LblInfoApe";
            this.LblInfoApe.Size = new System.Drawing.Size(0, 12);
            this.LblInfoApe.TabIndex = 23;
            // 
            // LblInfoNom
            // 
            this.LblInfoNom.AutoSize = true;
            this.LblInfoNom.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblInfoNom.Location = new System.Drawing.Point(123, 138);
            this.LblInfoNom.Name = "LblInfoNom";
            this.LblInfoNom.Size = new System.Drawing.Size(0, 12);
            this.LblInfoNom.TabIndex = 22;
            // 
            // LblInfoCed
            // 
            this.LblInfoCed.AutoSize = true;
            this.LblInfoCed.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblInfoCed.Location = new System.Drawing.Point(116, 80);
            this.LblInfoCed.Name = "LblInfoCed";
            this.LblInfoCed.Size = new System.Drawing.Size(0, 12);
            this.LblInfoCed.TabIndex = 21;
            // 
            // TxtCorreo
            // 
            this.TxtCorreo.Enabled = false;
            this.TxtCorreo.Location = new System.Drawing.Point(213, 286);
            this.TxtCorreo.Name = "TxtCorreo";
            this.TxtCorreo.Size = new System.Drawing.Size(326, 26);
            this.TxtCorreo.TabIndex = 20;
            this.TxtCorreo.TextChanged += new System.EventHandler(this.TxtCorreo_TextChanged);
            this.TxtCorreo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCorreo_KeyPress);
            // 
            // CbxCiudad
            // 
            this.CbxCiudad.Enabled = false;
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
            this.CbxCiudad.Location = new System.Drawing.Point(118, 229);
            this.CbxCiudad.Name = "CbxCiudad";
            this.CbxCiudad.Size = new System.Drawing.Size(150, 25);
            this.CbxCiudad.TabIndex = 19;
            this.CbxCiudad.SelectedIndexChanged += new System.EventHandler(this.CbxCiudad_SelectedIndexChanged);
            // 
            // CbxSexo
            // 
            this.CbxSexo.Enabled = false;
            this.CbxSexo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbxSexo.FormattingEnabled = true;
            this.CbxSexo.Items.AddRange(new object[] {
            "Masculino",
            "Femenino"});
            this.CbxSexo.Location = new System.Drawing.Point(101, 170);
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
            this.LblSexo.Location = new System.Drawing.Point(42, 172);
            this.LblSexo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblSexo.Name = "LblSexo";
            this.LblSexo.Size = new System.Drawing.Size(52, 18);
            this.LblSexo.TabIndex = 13;
            this.LblSexo.Text = "Sexo:";
            // 
            // TxtApellido
            // 
            this.TxtApellido.Enabled = false;
            this.TxtApellido.Location = new System.Drawing.Point(412, 111);
            this.TxtApellido.MaxLength = 20;
            this.TxtApellido.Name = "TxtApellido";
            this.TxtApellido.Size = new System.Drawing.Size(143, 26);
            this.TxtApellido.TabIndex = 12;
            this.TxtApellido.TextChanged += new System.EventHandler(this.TxtApellido_TextChanged);
            this.TxtApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtApellido_KeyPress);
            // 
            // TxtNombre
            // 
            this.TxtNombre.Enabled = false;
            this.TxtNombre.Location = new System.Drawing.Point(125, 110);
            this.TxtNombre.MaxLength = 20;
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(143, 26);
            this.TxtNombre.TabIndex = 11;
            this.TxtNombre.TextChanged += new System.EventHandler(this.TxtNombre_TextChanged);
            this.TxtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNombre_KeyPress);
            // 
            // TxtCedula
            // 
            this.TxtCedula.Location = new System.Drawing.Point(118, 52);
            this.TxtCedula.Name = "TxtCedula";
            this.TxtCedula.Size = new System.Drawing.Size(143, 26);
            this.TxtCedula.TabIndex = 10;
            this.TxtCedula.TextChanged += new System.EventHandler(this.TxtCedula_TextChanged);
            this.TxtCedula.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCedula_KeyPress);
            // 
            // LblCorreo
            // 
            this.LblCorreo.AutoSize = true;
            this.LblCorreo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCorreo.ForeColor = System.Drawing.Color.White;
            this.LblCorreo.Location = new System.Drawing.Point(42, 289);
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
            this.LblFechaNa.Location = new System.Drawing.Point(280, 173);
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
            this.LblCiudad.Location = new System.Drawing.Point(42, 231);
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
            this.LblApellido.Location = new System.Drawing.Point(330, 114);
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
            this.LblNombre.Location = new System.Drawing.Point(42, 113);
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
            this.LblCedula.Location = new System.Drawing.Point(42, 55);
            this.LblCedula.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblCedula.Name = "LblCedula";
            this.LblCedula.Size = new System.Drawing.Size(69, 18);
            this.LblCedula.TabIndex = 4;
            this.LblCedula.Text = "Cédula:";
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(198)))), ((int)(((byte)(73)))));
            this.BtnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnGuardar.Enabled = false;
            this.BtnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGuardar.ForeColor = System.Drawing.Color.White;
            this.BtnGuardar.Location = new System.Drawing.Point(705, 128);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(155, 43);
            this.BtnGuardar.TabIndex = 4;
            this.BtnGuardar.Text = "GUARDAR";
            this.BtnGuardar.UseVisualStyleBackColor = false;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(3)))), ((int)(((byte)(31)))));
            this.BtnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancelar.ForeColor = System.Drawing.Color.White;
            this.BtnCancelar.Location = new System.Drawing.Point(705, 196);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(155, 43);
            this.BtnCancelar.TabIndex = 5;
            this.BtnCancelar.Text = "CANCELAR";
            this.BtnCancelar.UseVisualStyleBackColor = false;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // dataSetVenta1
            // 
            this.dataSetVenta1.DataSetName = "DataSetVenta";
            this.dataSetVenta1.EnforceConstraints = false;
            this.dataSetVenta1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // DtpFecha
            // 
            this.DtpFecha.CustomFormat = "dd/MM/yyyy";
            this.DtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DtpFecha.Location = new System.Drawing.Point(466, 170);
            this.DtpFecha.Name = "DtpFecha";
            this.DtpFecha.Size = new System.Drawing.Size(136, 26);
            this.DtpFecha.TabIndex = 25;
            this.DtpFecha.ValueChanged += new System.EventHandler(this.DtpFecha_ValueChanged);
            // 
            // RegistroClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(58)))), ((int)(((byte)(63)))));
            this.ClientSize = new System.Drawing.Size(884, 511);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.GbxRegistro);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximumSize = new System.Drawing.Size(900, 550);
            this.MinimumSize = new System.Drawing.Size(900, 550);
            this.Name = "RegistroClientForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro de Clientes";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.GbxRegistro.ResumeLayout(false);
            this.GbxRegistro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetVenta1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.GroupBox GbxRegistro;
        private System.Windows.Forms.Label LblFechaNa;
        private System.Windows.Forms.Label LblCiudad;
        private System.Windows.Forms.Label LblApellido;
        private System.Windows.Forms.Label LblNombre;
        private System.Windows.Forms.Label LblCedula;
        private System.Windows.Forms.TextBox TxtCedula;
        private System.Windows.Forms.Label LblCorreo;
        private System.Windows.Forms.TextBox TxtApellido;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.Label LblSexo;
        private System.Windows.Forms.ComboBox CbxSexo;
        private System.Windows.Forms.ComboBox CbxCiudad;
        private System.Windows.Forms.TextBox TxtCorreo;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Label LblInfoCed;
        private System.Windows.Forms.Label LblInfoCorr;
        private System.Windows.Forms.Label LblInfoApe;
        private System.Windows.Forms.Label LblInfoNom;
        private DataSetVenta dataSetVenta1;
        private System.Windows.Forms.DateTimePicker DtpFecha;
    }
}