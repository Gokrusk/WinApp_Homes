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
<<<<<<< HEAD
            System.Diagnostics.Process.Start(PathFile + "\\help.html");
=======
            IngresoInmuebleForm obj = new IngresoInmuebleForm();
            obj.ShowDialog();
>>>>>>> da584d72ebe0c6e9061a144fae95d524f76dce15
        }
    }
}
