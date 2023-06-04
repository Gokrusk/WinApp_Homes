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
        }

        private void ReportesForm_Load(object sender, EventArgs e)
        {
            this.reportViewer1.RefreshReport();
            this.reportViewer2.RefreshReport();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.ToString() == "Listado de clientes")
            {
                reportViewer1.Visible = true; 

            } else if(comboBox1.SelectedItem.ToString() == "Listado de inmuebles")
            {
                reportViewer1.Visible = false;
                reportViewer2.Visible = true;
            }
        }
    }
}
