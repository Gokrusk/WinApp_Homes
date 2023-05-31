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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace WinApp_Homes
{
    public partial class VentaForm : Form
    {
        readonly string PathFile = Application.StartupPath + "\\assets\\files\\";
        float precio;
        DataRow dataInmuebleVenta;

        DataRow[] dataInmuebles;
        DataRow[] dataClientes;
        List<string> clientes = new List<string>();


        public VentaForm()
        {
            InitializeComponent();
        }

        private void VentaForm_Load(object sender, EventArgs e)
        {
            dataSetVenta1.Clear();
            dataSetVenta1.ReadXml(PathFile + "inmuebles.xml");
            dataInmuebles = dataSetVenta1.TblInmueble.Select();
            foreach (DataRow inmu in dataInmuebles)
                CbxInmueble.Items.Add(inmu["NombreInmueble"]);
            
            dataSetVenta1.Clear();
            dataSetVenta1.ReadXml(PathFile + "clientes.xml");
            dataClientes = dataSetVenta1.TblCliente.Select();
            foreach (DataRow cliente in dataClientes)
            {
                CbxCliente.Items.Add(cliente["Nombre"] + " " + cliente["Apellido"]);
                clientes.Add(cliente["Cedula"].ToString());
            }
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            dataSetVenta1.Clear();

            XmlDocument docIn = new XmlDocument();
            docIn.Load(PathFile + "inmuebles.xml");

            XmlDocument docCli = new XmlDocument();
            docCli.Load(PathFile + "clientes.xml");

            string inmu = dataInmuebleVenta["Codigo"].ToString();
            string ced = clientes[CbxCliente.SelectedIndex];

            dataSetVenta1.Tables["TblInmueble"].ReadXml(PathFile + "ventas.xml");
            object[] dataVenta = new object[3];

            dataVenta[0] = inmu;
            dataVenta[1] = TxtMensualidad.Text;
            dataVenta[2] = ced;
            dataVenta[3] = TxtMeses.Text;

            dataSetVenta1.TblVenta.Rows.Add(dataVenta);
            dataSetVenta1.Tables["TblVenta"].WriteXml(PathFile + "ventas.xml");
        }

        private void TxtMensualidad_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int meses = int.Parse(Math.Round(double.Parse(dataInmuebleVenta["Precio"].ToString()) / double.Parse(TxtMensualidad.Text)).ToString());
                TxtMeses.Text = meses.ToString();
            }
            catch
            {

            }
        }

        private void CbxInmueble_SelectionChangeCommitted(object sender, EventArgs e)
        {
            dataSetVenta1.Clear();
            dataSetVenta1.ReadXml(PathFile + "inmuebles.xml");

            dataInmuebleVenta = dataSetVenta1.TblInmueble.Select("NombreInmueble='" + CbxInmueble.SelectedItem.ToString() + "'")[0];

            LblPrecio.Text = "Precio: $" + dataInmuebleVenta["Precio"].ToString();
        }

        private void CbxCliente_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int sele = CbxCliente.SelectedIndex;

            
        }
    }
}
