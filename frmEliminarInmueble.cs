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
using static System.Net.Mime.MediaTypeNames;

namespace WinApp_Homes
{
    public partial class frmEliminarInmueble : Form
    {
        string codigo;
        public frmEliminarInmueble(System.Data.DataRow[] vDatosInmueble, string codigo)
        {
            InitializeComponent();
            lblCodigoMostrar.Text = "Código: " + vDatosInmueble[0]["Codigo"].ToString();
            LblNombreMostrar.Text = "Nombre: " + vDatosInmueble[0]["NombreInmueble"].ToString();
            LblTipoMostrar.Text = "Tipo: " + vDatosInmueble[0]["Tipo"].ToString();
            LblPrecioMostrar.Text = "Precio: " + vDatosInmueble[0]["Precio"].ToString();
            LblUbicacionMostrar.Text = "Ubicación: " + vDatosInmueble[0]["Ubicacion"].ToString();
            txtDescripcionMostrar.Text = vDatosInmueble[0]["Descripcion"].ToString();
            txtDescripcionMostrar.Enabled = false;

            this.codigo = codigo;
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Seguro que desea eliminar el inmueble " + lblCodigoMostrar.Text + "?", "Confirmación", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                MessageBox.Show($"Inmueble Eliminado", "Eliminación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
            }
            else if (result == DialogResult.No)
            {
                MessageBox.Show($"El inmueble no ha sido eliminado", "Eliminación", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmEliminarInmueble_Load(object sender, EventArgs e)
        {

        }

        private void btnVerFotos_Click(object sender, EventArgs e)
        {
            CargaFotosForm objFotos = new CargaFotosForm(codigo);
            objFotos.ShowDialog();

            
        }

    }
}
