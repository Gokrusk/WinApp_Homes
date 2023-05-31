namespace WinApp_Homes
{
    partial class CargaFotosForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CargaFotosForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.PbxFoto = new System.Windows.Forms.PictureBox();
            this.PbxAntes = new System.Windows.Forms.PictureBox();
            this.PbxSig = new System.Windows.Forms.PictureBox();
            this.dataSetVenta1 = new WinApp_Homes.DataSetVenta();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbxFoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxAntes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxSig)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetVenta1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(90)))), ((int)(((byte)(108)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(885, 78);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(240, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(420, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "FOTOGRAFÍAS DEL INMUEBLE";
            // 
            // PbxFoto
            // 
            this.PbxFoto.Location = new System.Drawing.Point(250, 100);
            this.PbxFoto.Name = "PbxFoto";
            this.PbxFoto.Size = new System.Drawing.Size(400, 400);
            this.PbxFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbxFoto.TabIndex = 2;
            this.PbxFoto.TabStop = false;
            // 
            // PbxAntes
            // 
            this.PbxAntes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PbxAntes.Image = ((System.Drawing.Image)(resources.GetObject("PbxAntes.Image")));
            this.PbxAntes.Location = new System.Drawing.Point(100, 225);
            this.PbxAntes.Name = "PbxAntes";
            this.PbxAntes.Size = new System.Drawing.Size(70, 70);
            this.PbxAntes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbxAntes.TabIndex = 3;
            this.PbxAntes.TabStop = false;
            this.PbxAntes.Click += new System.EventHandler(this.PbxAntes_Click);
            // 
            // PbxSig
            // 
            this.PbxSig.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PbxSig.Image = ((System.Drawing.Image)(resources.GetObject("PbxSig.Image")));
            this.PbxSig.Location = new System.Drawing.Point(730, 225);
            this.PbxSig.Name = "PbxSig";
            this.PbxSig.Size = new System.Drawing.Size(70, 70);
            this.PbxSig.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbxSig.TabIndex = 4;
            this.PbxSig.TabStop = false;
            this.PbxSig.Click += new System.EventHandler(this.PbxSig_Click);
            // 
            // dataSetVenta1
            // 
            this.dataSetVenta1.DataSetName = "DataSetVenta";
            this.dataSetVenta1.EnforceConstraints = false;
            this.dataSetVenta1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // CargaFotosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(58)))), ((int)(((byte)(63)))));
            this.ClientSize = new System.Drawing.Size(884, 511);
            this.Controls.Add(this.PbxSig);
            this.Controls.Add(this.PbxAntes);
            this.Controls.Add(this.PbxFoto);
            this.Controls.Add(this.panel1);
            this.Name = "CargaFotosForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CargaFotosForm";
            this.Load += new System.EventHandler(this.CargaFotosForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbxFoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxAntes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxSig)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetVenta1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox PbxFoto;
        private System.Windows.Forms.PictureBox PbxAntes;
        private System.Windows.Forms.PictureBox PbxSig;
        private DataSetVenta dataSetVenta1;
    }
}