using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinApp_Homes
{
    public partial class ReportesForm : Form
    {
        readonly string PathFile = Application.StartupPath + "\\assets\\files\\";

        public ReportesForm()
        {
            InitializeComponent();
            dataSetVenta.ReadXml(PathFile + "clientes.xml");
            dataSetVenta.ReadXml(PathFile + "inmuebles.xml");
            dataSetVenta.ReadXml(PathFile + "ventas.xml");
            dataSetVenta.ReadXml(PathFile + "imagenes.xml");
        }

        private void ReportesForm_Load(object sender, EventArgs e)
        {
            this.reportViewer1.RefreshReport();
            this.reportViewer2.RefreshReport();
            this.reportViewer3.RefreshReport();
            this.reportViewer4.RefreshReport();
            this.reportViewer5.RefreshReport();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.ToString() == "Listado de clientes")
            {
                reportViewer1.Visible = true;
                reportViewer2.Visible = false;
                reportViewer3.Visible = false;
                reportViewer4.Visible = false;
                reportViewer5.Visible = false; 

            } else if(comboBox1.SelectedItem.ToString() == "Listado de inmuebles")
            {
                reportViewer1.Visible = false;
                reportViewer2.Visible = true;
                reportViewer3.Visible = false;
                reportViewer4.Visible = false;
                reportViewer5.Visible = false;
            }
            else if (comboBox1.SelectedItem.ToString() == "Listado de ventas")
            {
                reportViewer1.Visible = false;
                reportViewer2.Visible = false;
                reportViewer3.Visible = true;
                reportViewer4.Visible = false;
                reportViewer5.Visible = false;

            }
            else if (comboBox1.SelectedItem.ToString() == "Listado de Inmueble Imagen")
            {
                reportViewer1.Visible = false;
                reportViewer2.Visible = false;
                reportViewer3.Visible = false;
                reportViewer4.Visible = true;
                reportViewer5.Visible = false;
            }
            else if (comboBox1.SelectedItem.ToString() == "Gráfico de Tipos de Inmuebles")
            {
                reportViewer1.Visible = false;
                reportViewer2.Visible = false;
                reportViewer3.Visible = false;
                reportViewer4.Visible = false;
                reportViewer5.Visible = true;
            }
        }
    }
}
