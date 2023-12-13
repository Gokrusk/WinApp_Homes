using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml;
using System.Collections;
using System.IO;

namespace WinApp_Homes
{
    public partial class CargaFotosForm : Form
    {
        string PathFile = Application.StartupPath + "\\..\\..\\assets\\files\\";
        string PathImages = Application.StartupPath + "\\..\\..\\assets\\images\\";
        List<string> Fotos = new List<string>();

        int contador = 0;

        string cod;



        public CargaFotosForm(string codigoInmueble)
        {
            InitializeComponent();
            cod = codigoInmueble;
        }

        private void CargaFotosForm_Load(object sender, EventArgs e)
        {
            dataSetVenta1.Clear();

            XmlDocument docImg = new XmlDocument();
            docImg.Load(PathFile + "imagenes.xml");

            dataSetVenta1.Clear();
            dataSetVenta1.ReadXml(PathFile + "imagenes.xml");

            DataRow[] vectorFotos = dataSetVenta1.TblFoto.Select("CodigoInmueble ='" + cod + "'");

            foreach (DataRow row in vectorFotos)
            {
                Fotos.Add(PathImages + row["NombreFoto"]);
            }


            FileStream fs = new FileStream(Fotos[0], FileMode.Open, FileAccess.Read);
            PbxFoto.Image = System.Drawing.Image.FromStream(fs);
            fs.Close();


            if (Fotos.Count == 1)
            {
                PbxAntes.Visible = false;
                PbxSig.Visible = false;
            }
            else
                PbxAntes.Visible = false;
        }

        private void PbxSig_Click(object sender, EventArgs e)
        {
            contador++;

            if (contador == Fotos.Count - 1)
                PbxSig.Visible = false;

            if (contador > 0)
                PbxAntes.Visible = true;

            FileStream fs = new FileStream(Fotos[contador], FileMode.Open, FileAccess.Read);
            PbxFoto.Image = System.Drawing.Image.FromStream(fs);
            fs.Close();
        }

        private void PbxAntes_Click(object sender, EventArgs e)
        {
            contador--;

            if (contador == 0)
                PbxAntes.Visible = false;
                
            if (contador < Fotos.Count - 1)
                PbxSig.Visible = true;

            FileStream fs = new FileStream(Fotos[contador], FileMode.Open, FileAccess.Read);
            PbxFoto.Image = System.Drawing.Image.FromStream(fs);
            fs.Close();
        }

        private void CargaFotosForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            PbxAntes.Image = null;
            PbxSig.Image = null;
            PbxFoto.Image = null;
            Fotos.Clear();

            this.Dispose(true);
        }
    }
}
