namespace WinApp_Homes {
    partial class RegistroClientes {
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
            this.GbxRegistro = new System.Windows.Forms.GroupBox();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.CbxCiudad = new System.Windows.Forms.ComboBox();
            this.DtpFecha = new System.Windows.Forms.DateTimePicker();
            this.CbxSexo = new System.Windows.Forms.ComboBox();
            this.LblSexo = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.TxtCedula = new System.Windows.Forms.TextBox();
            this.LblCorreo = new System.Windows.Forms.Label();
            this.LblFechaNa = new System.Windows.Forms.Label();
            this.LblCiudad = new System.Windows.Forms.Label();
            this.LblApellido = new System.Windows.Forms.Label();
            this.LblNombre = new System.Windows.Forms.Label();
            this.LblCedula = new System.Windows.Forms.Label();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.GbxRegistro.SuspendLayout();
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
            this.lblTitulo.Size = new System.Drawing.Size(121, 32);
            this.lblTitulo.TabIndex = 2;
            this.lblTitulo.Text = "Clientes";
            // 
            // GbxRegistro
            // 
            this.GbxRegistro.Controls.Add(this.txtCorreo);
            this.GbxRegistro.Controls.Add(this.CbxCiudad);
            this.GbxRegistro.Controls.Add(this.DtpFecha);
            this.GbxRegistro.Controls.Add(this.CbxSexo);
            this.GbxRegistro.Controls.Add(this.LblSexo);
            this.GbxRegistro.Controls.Add(this.textBox2);
            this.GbxRegistro.Controls.Add(this.textBox1);
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
            this.GbxRegistro.Size = new System.Drawing.Size(605, 347);
            this.GbxRegistro.TabIndex = 3;
            this.GbxRegistro.TabStop = false;
            this.GbxRegistro.Text = "Registro";
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(213, 286);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(326, 26);
            this.txtCorreo.TabIndex = 20;
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
            this.CbxCiudad.Location = new System.Drawing.Point(118, 229);
            this.CbxCiudad.Name = "CbxCiudad";
            this.CbxCiudad.Size = new System.Drawing.Size(150, 25);
            this.CbxCiudad.TabIndex = 19;
            // 
            // DtpFecha
            // 
            this.DtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpFecha.Location = new System.Drawing.Point(445, 169);
            this.DtpFecha.Name = "DtpFecha";
            this.DtpFecha.Size = new System.Drawing.Size(135, 26);
            this.DtpFecha.TabIndex = 18;
            this.DtpFecha.Value = new System.DateTime(2023, 5, 28, 10, 35, 34, 0);
            // 
            // CbxSexo
            // 
            this.CbxSexo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbxSexo.FormattingEnabled = true;
            this.CbxSexo.Items.AddRange(new object[] {
            "Masculino",
            "Femenino"});
            this.CbxSexo.Location = new System.Drawing.Point(101, 170);
            this.CbxSexo.Name = "CbxSexo";
            this.CbxSexo.Size = new System.Drawing.Size(121, 25);
            this.CbxSexo.TabIndex = 17;
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
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(391, 110);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(143, 26);
            this.textBox2.TabIndex = 12;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(125, 110);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(143, 26);
            this.textBox1.TabIndex = 11;
            // 
            // TxtCedula
            // 
            this.TxtCedula.Location = new System.Drawing.Point(118, 52);
            this.TxtCedula.Name = "TxtCedula";
            this.TxtCedula.Size = new System.Drawing.Size(143, 26);
            this.TxtCedula.TabIndex = 10;
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
            this.LblFechaNa.Location = new System.Drawing.Point(259, 172);
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
            this.LblApellido.Location = new System.Drawing.Point(309, 113);
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
            this.BtnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(169)))), ((int)(((byte)(143)))));
            this.BtnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGuardar.ForeColor = System.Drawing.Color.White;
            this.BtnGuardar.Location = new System.Drawing.Point(651, 127);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(212, 51);
            this.BtnGuardar.TabIndex = 4;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.UseVisualStyleBackColor = false;
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.BackColor = System.Drawing.Color.Red;
            this.BtnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancelar.ForeColor = System.Drawing.Color.White;
            this.BtnCancelar.Location = new System.Drawing.Point(651, 195);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(212, 51);
            this.BtnCancelar.TabIndex = 5;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = false;
            // 
            // RegistroClientes
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
            this.Name = "RegistroClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro_clientes";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.GbxRegistro.ResumeLayout(false);
            this.GbxRegistro.PerformLayout();
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
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label LblSexo;
        private System.Windows.Forms.ComboBox CbxSexo;
        private System.Windows.Forms.DateTimePicker DtpFecha;
        private System.Windows.Forms.ComboBox CbxCiudad;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.Button BtnCancelar;
    }
}