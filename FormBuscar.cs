using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinApp_Homes
{
    public partial class FormBuscar : Form
    {
        public FormBuscar()
        {
            InitializeComponent();
        }
        string PathFile = Application.StartupPath + "\\assets\\files\\";

        private void FormBuscar_Load(object sender, EventArgs e)
        {
            dataSetVenta.ReadXml(PathFile + "\\inmuebles.xml");
        }

        static string RemoverTildes(string texto)
        {
            string normalizedString = texto.Normalize(NormalizationForm.FormD);
            StringBuilder stringBuilder = new StringBuilder();

            foreach (char c in normalizedString)
            {
                if (CharUnicodeInfo.GetUnicodeCategory(c) != UnicodeCategory.NonSpacingMark)
                    stringBuilder.Append(c);
            }

            return stringBuilder.ToString();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            dataSetVenta.Clear();
            dataSetVenta.ReadXml(PathFile + "\\inmuebles.xml");
            string item = comboBox1.SelectedItem.ToString();
            item = RemoverTildes(item);

            DataRow[] data;
            data = dataSetVenta.TblInmueble.Select(item + "='" + TxtItem.Text + "'");

            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Codigo", typeof(string));
            dataTable.Columns.Add("Tipo", typeof(string));
            dataTable.Columns.Add("Precio", typeof(string));
            dataTable.Columns.Add("Descripcion", typeof(string));
            dataTable.Columns.Add("Ubicacion", typeof(string));
            dataTable.Columns.Add("EstadoVenta", typeof(string));
            dataTable.Columns.Add("NombreInmueble", typeof(string));
            
            foreach (DataRow row in data)
            {
                dataTable.Rows.Add(row["Codigo"], row["Tipo"], row["Precio"], row["Descripcion"], row["Ubicacion"], row["EstadoVenta"], row["NombreInmueble"]);
            }

            dataGridView1.DataSource = dataTable;

        }
    }
}
