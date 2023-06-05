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

namespace WinApp_Homes
{
    public partial class CargaFotosForm : Form
    {
        string PathFile = Application.StartupPath + "\\assets\\files\\";
        string PathImages = Application.StartupPath + "\\assets\\images\\";
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

            foreach (XmlNode n1 in docImg.DocumentElement.ChildNodes)
            {

                if (n1.HasChildNodes)
                {
                    foreach (XmlNode n2 in n1.ChildNodes)
                    {
                        if (n2.Name == "NombreFoto")
                            Fotos.Add(n2.InnerText);

                        if (n2.Name == "CodigoInmueble" && n2.InnerText != cod)
                            Fotos.RemoveAt(Fotos.Count - 1);
                    }
                }
            }

            PbxFoto.Image = Image.FromFile(PathImages + Fotos[0]);
            PbxAntes.Visible = false;
        }

        private void PbxSig_Click(object sender, EventArgs e)
        {
            contador++;

            if (contador == Fotos.Count - 1)
                PbxSig.Visible = false;

            if (contador > 0)
                PbxAntes.Visible = true;
            
            PbxFoto.Image = Image.FromFile(PathImages + Fotos[contador]);
        }

        private void PbxAntes_Click(object sender, EventArgs e)
        {
            contador--;

            if (contador == 0)
                PbxAntes.Visible = false;
                
            if (contador < Fotos.Count - 1)
                PbxSig.Visible = true;

            PbxFoto.Image = Image.FromFile(PathImages + Fotos[contador]);
        }

        private void CargaFotosForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            PbxFoto.Image = null;
        }
    }
}
