using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinApp_Homes {
    public partial class ModificarClienteForm : Form {
        readonly string PathFile = Application.StartupPath + "\\assets\\files\\";
        System.Data.DataRow[] VecDatos;

        public ModificarClienteForm() {
            InitializeComponent();
        }

        private void TxtCedulaBus_KeyPress(object sender, KeyPressEventArgs e) {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

            if (e.KeyChar == (char)Keys.Enter) {
                dataSetVenta1.ReadXml(PathFile + "clientes.xml");
                VecDatos = dataSetVenta1.TblCliente.Select("Cedula = '"+TxtCedulaBus.Text+"'");

                if (VecDatos.Length > 0) {
                    GbxDatos.Visible = true;

                    LblCedula.Text = "Cédula: " + VecDatos[0]["Cedula"].ToString();
                    TxtNombre.Text = VecDatos[0]["Nombre"].ToString();
                    TxtApellido.Text = VecDatos[0]["Apellido"].ToString();

                    if (VecDatos[0]["Sexo"].ToString() == "M") {
                        CbxSexo.SelectedIndex = 0;
                    } else {
                        CbxSexo.SelectedIndex = 1;
                    }

                    CbxCiudad.SelectedItem = VecDatos[0]["Ciudad"].ToString();
                    DtpFecha.Value = Convert.ToDateTime(VecDatos[0]["FechaNacimiento"]);
                    TxtCorreo.Text = VecDatos[0]["Email"].ToString();

                } else {
                    MessageBox.Show("El número de cedula ingresado no existe.", "Cliente no registrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TxtCedulaBus.Clear();
                }
            }
        }

        private void BtnGuardar_Click(object sender, EventArgs e) {
            try {
                DialogResult resultado = MessageBox.Show("¿Está seguro/a de modificar los datos?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (resultado == DialogResult.Yes) {
                    VecDatos[0]["Nombre"] = TxtNombre.Text;
                    VecDatos[0]["Apellido"] = TxtApellido.Text;
                    VecDatos[0]["Sexo"] = CbxSexo.SelectedItem.ToString();
                    VecDatos[0]["Ciudad"] = CbxCiudad.SelectedItem.ToString();
                    VecDatos[0]["FechaNacimiento"] = DtpFecha.Value;
                    VecDatos[0]["Email"] = TxtCorreo.Text;

                    VecDatos[0].AcceptChanges();
                    dataSetVenta1.Tables["TblCliente"].WriteXml(PathFile + "clientes.xml");

                    MessageBox.Show("Datos modificados correctamente", "Registro guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                } else if (resultado == DialogResult.No) {
                    this.Close();
                } else {
                    this.Close();
                }

            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}