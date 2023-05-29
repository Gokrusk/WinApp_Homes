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
    public partial class MenuFormAdmin : Form
    {
        public MenuFormAdmin()
        {
            InitializeComponent();
        }

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
    }
}
