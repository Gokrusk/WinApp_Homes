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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace WinApp_Homes
{
    public partial class ModificarInmuebleForm : Form
    {
        string etiqueta, original;

        DataRow[] vector; //otra forma de declarar un vector

        readonly string PathFile = Application.StartupPath + "\\assets\\files\\";

        public ModificarInmuebleForm()
        {
            InitializeComponent();
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
            CbxUbi.Visible = false;
            TxtPrecio.Visible = false;
            label3.Visible = false;

            dataSetVenta1.ReadXml(PathFile + "inmuebles.xml");
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                   //dataSetVenta1.ReadXml(PathFile + "inmuebles.xml");
            
                vector[0]["Codigo"] = LblCodigo.Text;
                vector[0]["Tipo"] = CbxTipo.SelectedItem.ToString();
                vector[0]["Precio"] = TxtPrecio.Text;
                vector[0]["Descripcion"] = TxtDesc.Text;
                vector[0]["Ubicacion"] = CbxUbi.SelectedItem.ToString();
                vector[0]["NombreInmueble"] = TxtNombre.Text;

                vector[0].AcceptChanges();
                dataSetVenta1.WriteXml(PathFile + "inmuebles.xml");

                this.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

                throw;
            }
            
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            string texto = "¿Está seguro de no guardar sus modificaciones?";

            bool opcion = MessageBox.Show(texto, "ADVERTENCIA", MessageBoxButtons.YesNo) == DialogResult.Yes;

            if (opcion)
            {
                MessageBox.Show("No se realizó ninguna modificación en la información", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                try
                {
                    e.Handled = true;
                    etiqueta = comboBox1.SelectedItem.ToString() + "='";

                    vector = dataSetVenta1.TblInmueble.Select(etiqueta + textBox1.Text + "'"); //+...+ para concatenar y no hay que poner espacios

                    LblCodigo.Text = vector[0]["Codigo"].ToString();
                    CbxTipo.Text = vector[0]["Tipo"].ToString();
                    TxtPrecio.Text = vector[0]["Precio"].ToString();
                    TxtDesc.Text = vector[0]["Descripcion"].ToString();
                    CbxUbi.Text = vector[0]["Ubicacion"].ToString();
                    TxtNombre.Text = vector[0]["NombreInmueble"].ToString();
                    original = LblCodigo.Text;

                    LblCodigo.Visible = true;
                    LblDesc.Visible = true;
                    LblNombre.Visible = true;
                    LblPrecio.Visible = true;
                    LblTipo.Visible = true;
                    LblUbi.Visible = true;
                    CbxTipo.Visible = true;
                    TxtDesc.Visible = true;
                    TxtNombre.Visible = true;
                    TxtPrecio.Visible = true;
                    CbxUbi.Visible = true;
                    TxtPrecio.Visible = true;
                    label3.Visible = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    MessageBox.Show("No exite un inmueble que coincida con su campo de búsqueda");
                }
            }
        }


        private void CbxTipo_SelectionChangeCommitted(object sender, EventArgs e)
        {
            DataRow[] dataInmuebles;

            dataInmuebles = dataSetVenta1.TblInmueble.Select("Tipo='" + CbxTipo.SelectedItem.ToString() + "'");

            int num = dataInmuebles.Length;

            if (CbxTipo.SelectedItem.ToString() == original)
                LblCodigo.Text = original;
            else
                LblCodigo.Text = CbxTipo.SelectedItem.ToString() + "_" + num.ToString();
        }
    }
}
