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
        public ModificarInmuebleForm(System.Data.DataRow[] vector)
        {
            InitializeComponent();

            LblCodigo.Text = vector[0]["Codigo"].ToString();
            CbxTipo.SelectedText = vector[0]["Tipo"].ToString();
            LblPrecio.Text = vector[0]["Preci"].ToString();
            LblDesc.Text = vector[0]["Descripcion"].ToString();
            LblUbi.Text = vector[0]["Ubicacion"].ToString();
            LblNombre.Text = vector[0]["Nombre"].ToString();

            labelCod.Text = vector[0]["Codigo"].ToString();
            textBoxNombre.Text = vector[0]["Nombre"].ToString();
            textBoxApellido.Text = vector[0]["Apellido"].ToString();
            numericUpDown1.Value = Convert.ToDecimal(vector[0]["Edad"]);
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
