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
    public partial class ModificarInmuebleForm : Form
    {
        readonly string PathFile = Application.StartupPath + "\\assets\\files\\";
        public ModificarInmuebleForm()
        {
            InitializeComponent();

            dataSetVenta1.ReadXml(PathFile + "inmuebles.xml");

            System.Data.DataRow[] vector, vecModificado; //otra forma de declarar un vector

            vector = dataSetVenta1.TblInmueble.Select(etiqueta + txtCodigo.Text + "'"); //+...+ para concatenar y no hay que poner espacios
            vecModificado = vecDatos;

            LblCodigo.Text = vector[0]["Codigo"].ToString();
            CbxTipo.SelectedText = vector[0]["Tipo"].ToString();
            LblPrecio.Text = vector[0]["Preci"].ToString();
            LblDesc.Text = vector[0]["Descripcion"].ToString();
            LblUbi.Text = vector[0]["Ubicacion"].ToString();
            LblNombre.Text = vector[0]["Nombre"].ToString();
        }

        private void ModificarInmuebleForm_Load(object sender, EventArgs e)
        {
            LblCodigo.Visible = false;
            LblDesc.Visible = false;
            LblNombre.Visible = false;
            LblPrecio.Visible = false;
            LblTipo.Visible = false;    
            LblUbi.Visible = false;
            CbxTipo.Visible = false;
            TxtDesc.Visible = false;
            TxtNombre.Visible = false;
            TxtPrecio.Visible = false;
            TxtUbi.Visible = false;
            TxtPrecio.Visible = false;
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
