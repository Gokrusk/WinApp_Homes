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
    public partial class frmEliminarCliente : Form
    {
        public frmEliminarCliente(System.Data.DataRow[] vDatosCliente)
        {
            InitializeComponent();
            lblCedulaMostrar.Text = "Cédula: " + vDatosCliente[0]["Cedula"].ToString();
            lblNombreMostrar.Text = "Nombre: " + vDatosCliente[0]["Nombre"].ToString();
            lblApellidoMostrar.Text = "Apellido: " + vDatosCliente[0]["Apellido"].ToString();
            lblSexoMostrar.Text = "Sexo: " + vDatosCliente[0]["Sexo"].ToString();
            lblCiudadMostrar.Text = "Ciudad: " + vDatosCliente[0]["Ciudad"].ToString();
            lblFechanacimientoMostrar.Text = "Fecha de Nacimiento: " + vDatosCliente[0]["FechaNacimiento"].ToString();
            lblCorreoMostrar.Text = "Correo electrónico: " + vDatosCliente[0]["Email"].ToString();

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Seguro que desea eliminar al cliente " + lblCedulaMostrar.Text + "?", "Confirmación", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                MessageBox.Show($"Cliente Eliminado", "Eliminación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
            this.Close();
        }
    }
}
