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
using System.Xml;
using System.Xml.Linq;

namespace WinApp_Homes
{
    public partial class IngresoInmuebleForm : Form
    {
        ClInmueble InmuebleObj = new ClInmueble();

        readonly string PathImage = Application.StartupPath + "\\assets\\images\\";
        readonly string PathFile = "C:\\assets\\files\\";

        private List<string> rutasImagenes = new List<string>();

        public IngresoInmuebleForm()
        {
            InitializeComponent();
        }

        private void IngresoDepartamentoForm_Load(object sender, EventArgs e)
        {
            TxtNombre.Focus();
            CbxTipo.SelectedIndex = 0;
            CbxUbi.SelectedIndex = 0;
        }

        private void BtnCargar_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Multiselect = true;
            openFileDialog.Filter = "Archivos de imagen (*.jpg, *.jpeg, *.png)|*.jpg;*.jpeg;*.png";


            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                foreach (string rutaArchivo in openFileDialog.FileNames)
                {
                    rutasImagenes.Add(rutaArchivo);
                    ListImagenes.Items.Add(Path.GetFileName(rutaArchivo));
                }
            }
            
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if(rutasImagenes.Count > 0)
            {
                GuardarImagenes();
                GuardarDatosXML();
                GuardarImagenesXML();
                MessageBox.Show("Inmueble guardado correctamente", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ReiniciarDatos();
            }
            else
            {
                MessageBox.Show("Debe seleccionar al menos una imagen para el inmueble", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void ReiniciarDatos()
        {
            TxtNombre.Clear();
            TxtDesc.Clear();
            TxtPrecio.Clear();
            CbxTipo.SelectedIndex = 0;
            CbxUbi.SelectedIndex = 0;
            PbxImagen.Image = null;
            ListImagenes.Items.Clear();
            rutasImagenes.Clear();
        }

        private void GuardarImagenes()
        {
            PbxImagen.Image = null;

            foreach (string rutaArchivo in rutasImagenes)
            {
                string nombreArchivo = Path.GetFileName(rutaArchivo);
                string nuevaRutaCompleta = Path.Combine(PathImage, nombreArchivo);

                File.Copy(rutaArchivo, nuevaRutaCompleta, true);
            }
            
        }

        private int ContarTipos()
        {
            dataSetVenta1.Clear();

            DataRow[] dataInmuebles;

            dataSetVenta1.Tables["TblInmueble"].ReadXml(PathFile + "inmuebles.xml");
            dataInmuebles = dataSetVenta1.TblInmueble.Select("Tipo='" + InmuebleObj.tipo + "'");

            return dataInmuebles.Length;
        }
        private void GuardarDatosXML()
        {
            InmuebleObj.nombre = TxtNombre.Text;
            InmuebleObj.precio = float.Parse(TxtPrecio.Text);
            InmuebleObj.tipo = CbxTipo.SelectedItem.ToString();
            InmuebleObj.descripcion = TxtDesc.Text;
            InmuebleObj.ubicacion = CbxUbi.SelectedItem.ToString();

            
            object[] dataInmu = new object[7];

            InmuebleObj.GenerarCodigo(ContarTipos());

            dataInmu[0] = InmuebleObj.codigo;
            dataInmu[1] = InmuebleObj.tipo;
            dataInmu[2] = InmuebleObj.precio;
            dataInmu[3] = InmuebleObj.descripcion;
            dataInmu[4] = InmuebleObj.ubicacion;
            dataInmu[5] = InmuebleObj.estadoVenta;
            dataInmu[6] = InmuebleObj.nombre;

            dataSetVenta1.Clear();
            dataSetVenta1.Tables["TblInmueble"].ReadXml(PathFile + "inmuebles.xml");
            dataSetVenta1.TblInmueble.Rows.Add(dataInmu);
            dataSetVenta1.Tables["TblInmueble"].WriteXml(PathFile + "inmuebles.xml");
        }

        private void GuardarImagenesXML()
        {
            dataSetVenta1.Clear();
            dataSetVenta1.Tables["TblFoto"].ReadXml(PathFile + "imagenes.xml");

            object[] dataFoto = new object[2];

            foreach (string rutaArchivo in rutasImagenes)
            {
                string nombreArchivo = Path.GetFileName(rutaArchivo);
                dataFoto[0] = nombreArchivo;
                dataFoto[1] = InmuebleObj.codigo;

                dataSetVenta1.TblFoto.Rows.Add(dataFoto);
            }
            dataSetVenta1.Tables["TblFoto"].WriteXml(PathFile + "imagenes.xml");
        }

        private void ListImagenes_SelectedValueChanged(object sender, EventArgs e)
        {
            PbxImagen.Image = Image.FromFile(rutasImagenes[ListImagenes.SelectedIndex]);
        }

        private void TxtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;

                if (TxtNombre.Text.Length > 0)
                    CbxTipo.Focus();
                else
                {
                    MessageBox.Show("El nombre del inmueble no puede quedar vacío", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void TxtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                try
                {
                    float precio = float.Parse(TxtPrecio.Text);

                    if (precio > 0)
                    {
                        InmuebleObj.precio = precio;
                        CbxUbi.Focus();
                    }
                    else
                    {
                        MessageBox.Show("El precio no puede ser 0 o negativo", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        TxtPrecio.Clear();
                    }
                }
                catch 
                {
                    MessageBox.Show("El precio del inmueble debe ser numérico", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    TxtPrecio.Clear();
                }
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            string texto = "¿Está seguro de borrar las imágenes cargadas del inmueble?";

            bool opcion = MessageBox.Show(texto, "ADVERTENCIA", MessageBoxButtons.YesNo) == DialogResult.Yes;

            if (opcion)
            {
                ListImagenes.Items.Clear();
                rutasImagenes.Clear();

                PbxImagen.Image = null;

                MessageBox.Show("Imágenes borradas correctamente", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
