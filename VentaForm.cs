using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace WinApp_Homes
{
    public partial class VentaForm : Form
    {
        readonly string PathFile = Application.StartupPath + "\\assets\\files\\";

        
        public VentaForm()
        {
            InitializeComponent();
        }

        private void VentaForm_Load(object sender, EventArgs e)
        {
            XmlDocument docIn = new XmlDocument();
            docIn.Load(PathFile + "inmuebles.xml");

            XmlDocument docCli = new XmlDocument();
            docCli.Load(PathFile + "clientes.xml");

            foreach (XmlNode n1 in docIn.DocumentElement.ChildNodes)
            {
                if (n1.HasChildNodes)
                {
                    foreach (XmlNode n2 in n1.ChildNodes)
                    {
                        if(n2.Name == "NombreInmueble")
                            comboBox1.Items.Add(n2.InnerText);
                    }
                }
            }

            foreach (XmlNode n1 in docCli.DocumentElement.ChildNodes)
            {
                if (n1.HasChildNodes)
                {
                    foreach (XmlNode n2 in n1.ChildNodes)
                    {
                        if (n2.Name == "Nombre")
                            comboBox2.Items.Add(n2.InnerText);
                    }
                }
            }
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            dataSetVenta1.Clear();

            XmlDocument docIn = new XmlDocument();
            docIn.Load(PathFile + "inmuebles.xml");

            XmlDocument docCli = new XmlDocument();
            docCli.Load(PathFile + "clientes.xml");

            string inmu = "";
            string ced = "";
            foreach (XmlNode n1 in docIn.DocumentElement.ChildNodes)
            {
                if (n1.HasChildNodes)
                {
                    foreach (XmlNode n2 in n1.ChildNodes)
                    {
                        if (n2.Name == "Codigo")
                            inmu = n2.InnerText;

                        if (n2.InnerText == comboBox1.SelectedItem.ToString())
                            break;
                    }
                }
            }

            foreach (XmlNode n1 in docCli.DocumentElement.ChildNodes)
            {
                if (n1.HasChildNodes)
                {
                    foreach (XmlNode n2 in n1.ChildNodes)
                    {
                        if (n2.Name == "Cedula")
                            ced = n2.InnerText;

                        if (n2.InnerText == comboBox2.SelectedItem.ToString())
                            break;
                    }
                }
            }

            dataSetVenta1.Tables["TblInmueble"].ReadXml(PathFile + "ventas.xml");
            object[] dataVenta = new object[3];

            dataVenta[0] = inmu;
            dataVenta[1] = textBox1.Text;
            dataVenta[2] = ced;

            dataSetVenta1.TblVenta.Rows.Add(dataVenta);
            dataSetVenta1.Tables["TblVenta"].WriteXml(PathFile + "ventas.xml");
        }
    }
}
