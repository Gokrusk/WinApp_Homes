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
    public partial class IngresoDepartamentoForm : Form
    {
        ClDepartamento DepartamentoObj = new ClDepartamento();

        string PathImage = Application.StartupPath + "\\assets\\images";
        string PathFile = Application.StartupPath + "\\assets\\files\\";

        private List<string> rutasImagenes = new List<string>();

        public IngresoDepartamentoForm()
        {
            InitializeComponent();
        }

        private void IngresoDepartamentoForm_Load(object sender, EventArgs e)
        {
            TxtNombre.Focus();
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
                //PbxImagen.Image = Image.FromFile(PathImage + "\\" + ListImagenes.Items[0]);
            }
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            foreach (string rutaArchivo in rutasImagenes)
            {
                string nombreArchivo = Path.GetFileName(rutaArchivo);
                string nuevaRutaCompleta = Path.Combine(PathImage, nombreArchivo);

                File.Copy(rutaArchivo, nuevaRutaCompleta, true);
            }

            DepartamentoObj.descripcion = TxtDesc.Text;

            DepartamentoObj.ubicacion = TxtUbi.Text;

            dataSetVenta1.Tables["TblInmueble"].ReadXml(PathFile + "departamentos.xml");
            object[] dataInmu = new object[7];

            DepartamentoObj.GenerarCodigo();

            dataInmu[0] = DepartamentoObj.codigo;
            dataInmu[1] = DepartamentoObj.tipo;
            dataInmu[2] = DepartamentoObj.precio;
            dataInmu[3] = DepartamentoObj.descripcion;
            dataInmu[4] = DepartamentoObj.ubicacion;
            dataInmu[5] = DepartamentoObj.estadoVenta;
            dataInmu[6] = DepartamentoObj.nombre;


            dataSetVenta1.TblInmueble.Rows.Add(dataInmu);
            dataSetVenta1.Tables["TblInmueble"].WriteXml(PathFile + "departamentos.xml");

            dataSetVenta1.Tables["TblFoto"].ReadXml(PathFile + "imagenes.xml");
            object[] dataFoto = new object[2];
            foreach (string rutaArchivo in rutasImagenes)
            {
                string nombreArchivo = Path.GetFileName(rutaArchivo);
                dataFoto[0] = nombreArchivo;
                dataFoto[1] = DepartamentoObj.codigo;

                dataSetVenta1.TblFoto.Rows.Add(dataFoto);   
            }
            dataSetVenta1.Tables["TblFoto"].WriteXml(PathFile + "imagenes.xml");

            MessageBox.Show("Inmueble guardado correctamente", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ListImagenes_SelectedValueChanged(object sender, EventArgs e)
        {
            PbxImagen.Image = Image.FromFile(PathImage + "\\" + ListImagenes.SelectedItem);
        }

        private void TxtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                if (TxtNombre.Text.Length >= 5)
                {
                    DepartamentoObj.nombre = TxtNombre.Text;
                    CbxTipo.Focus();
                }
            }
        }

        private void CbxTipo_SelectionChangeCommitted(object sender, EventArgs e)
        {
            DepartamentoObj.tipo = CbxTipo.SelectedItem.ToString();
        }

        private void TxtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                float precio = float.Parse(TxtPrecio.Text);

                if (precio > 0)
                {
                    DepartamentoObj.precio = precio;
                    TxtUbi.Focus();
                }
            }
        }

    }
}
