using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinApp_Homes
{
    public partial class MenuFormAdmin : Form
    {	
        public MenuFormAdmin()
        {
            InitializeComponent();
        }
        string PathFile = Application.StartupPath + "\\assets\\files\\";

        private void button1_Click(object sender, EventArgs e)
        {
            IngresoInmuebleForm obj = new IngresoInmuebleForm();
            obj.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RegistroClientForm obj = new RegistroClientForm();
            obj.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormBuscar obj = new FormBuscar();
            obj.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        { 
            ModificarInmuebleForm obj = new ModificarInmuebleForm();
            obj.ShowDialog();
        }

        private void MenuFormAdmin_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(PathFile + "\\help.html");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            VentaForm obj = new VentaForm();
            obj.ShowDialog();
        }

        private void btnModificarCli_Click(object sender, EventArgs e) {
            ModificarClienteForm ModificarCliObj = new ModificarClienteForm();
            ModificarCliObj.ShowDialog();
        }

        private void BtnReportes_Click(object sender, EventArgs e) {
            ReportesForm ReportesObj = new ReportesForm();
            ReportesObj.ShowDialog();
        }

        private void MenuFormAdmin_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
    }
}
