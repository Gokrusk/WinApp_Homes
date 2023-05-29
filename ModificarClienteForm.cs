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
        string PathFile = Application.StartupPath + "\\assets\\files\\";
        ClCliente ClienteObj = new ClCliente();

        DataRow[] VecDatosAux;

        public ModificarClienteForm() {
            InitializeComponent();
        }

        public void MensajeError() {
            MessageBox.Show("Por favor ingrese de nuevo el dato.", "Ha ocurrido un error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static bool ValidarCorreo(string Correo) {
            string formato = @"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$";

            Match match = Regex.Match(Correo, formato);

            return match.Success;
        }

        private void TxtCedulaBus_KeyPress(object sender, KeyPressEventArgs e) {
            if (e.KeyChar == (char)Keys.Enter) {
                dataSetVenta1.ReadXml(PathFile + "clientes.xml");
                DataRow[] VecDatos = dataSetVenta1.TblCliente.Select("Cedula = '"+TxtCedulaBus.Text+"'");

                if (VecDatos.Length > 0) {
                    GbxDatos.Visible = true;
                    ClienteObj.Cedula = VecDatos[0]["Cedula"].ToString();
                    LblCedula.Text = "Cédula: " + ClienteObj.Cedula.ToString();
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

                    VecDatosAux = VecDatos;

                } else {
                    MessageBox.Show("El número de cedula ingresado no existe.", "Cliente no registrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TxtCedulaBus.Clear();
                }
            }
        }

        private void TxtNombre_KeyPress(object sender, KeyPressEventArgs e) {
            if (e.KeyChar == (char)Keys.Enter) {
                try {
                    LblInfoNom.Text = "";
                    ClienteObj.Nombre = TxtNombre.Text;

                    if (ClienteObj.Nombre.Contains(" ")) {
                        LblInfoNom.Text = "No se permite espacios";
                        TxtNombre.Clear();

                    } else if (ClienteObj.Nombre == "") {
                        LblInfoNom.Text = "Dato requerido";

                    } else if (ClienteObj.Nombre.Any(char.IsDigit) || Regex.IsMatch(ClienteObj.Nombre, @"[^\w]")) {
                        LblInfoNom.Text = "Ingrese únicamente el nombre";
                        TxtNombre.Clear();
                    }

                } catch (Exception) {
                    MensajeError();
                    TxtNombre.Clear();
                }
            }
        }

        private void TxtApellido_KeyPress(object sender, KeyPressEventArgs e) {
            if (e.KeyChar == (char)Keys.Enter) {
                try {
                    LblInfoApe.Text = "";
                    ClienteObj.Apellido = TxtApellido.Text;

                    if (ClienteObj.Apellido.Contains(" ")) {
                        LblInfoApe.Text = "No se permite espacios";
                        TxtApellido.Clear();

                    } else if (ClienteObj.Apellido == "") {
                        LblInfoApe.Text = "Dato requerido";

                    } else if (ClienteObj.Apellido.Any(char.IsDigit) || Regex.IsMatch(ClienteObj.Apellido, @"[^\w]")) {
                        LblInfoApe.Text = "Ingrese únicamente el apellido";
                        TxtApellido.Clear();
                    }

                } catch (Exception) {
                    MensajeError();
                    TxtApellido.Clear();
                }
            }
        }

        private void CbxSexo_SelectedIndexChanged(object sender, EventArgs e) {
            if (CbxSexo.SelectedIndex == 0) {
                ClienteObj.Sexo = 'M';
            } else {
                ClienteObj.Sexo = 'F';
            }
        }

        private void DtpFecha_ValueChanged(object sender, EventArgs e) {
            DtpFecha.MaxDate = DateTime.Today.AddYears(-18);
            DtpFecha.MinDate = DateTime.Today.AddYears(-100);

            ClienteObj.FechaNacimiento = DtpFecha.Value;
        }

        private void CbxCiudad_SelectedIndexChanged(object sender, EventArgs e) {
            ClienteObj.Ciudad = CbxCiudad.SelectedItem.ToString();
        }

        private void TxtCorreo_KeyPress(object sender, KeyPressEventArgs e) {
            if (e.KeyChar == (char)Keys.Enter) {
                try {
                    LblInfoCorr.Text = "";
                    ClienteObj.CorreoElec = TxtCorreo.Text;

                    if (!ValidarCorreo(ClienteObj.CorreoElec)) {
                        LblInfoCorr.Text = "Correo invalido";
                        TxtCorreo.Clear();
                    }

                } catch (Exception) {
                    MensajeError();
                    TxtCorreo.Clear();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e) {
            try {
                DialogResult resultado = MessageBox.Show("¿Está seguro/a de modificar los datos?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (resultado == DialogResult.Yes) {
                    VecDatosAux[0]["Cedula"] = ClienteObj.Cedula;
                    VecDatosAux[0]["Nombre"] = ClienteObj.Nombre;
                    VecDatosAux[0]["Apellido"] = ClienteObj.Apellido;
                    VecDatosAux[0]["Sexo"] = ClienteObj.Sexo;
                    VecDatosAux[0]["Ciudad"] = ClienteObj.Ciudad;
                    VecDatosAux[0]["FechaNacimiento"] = ClienteObj.FechaNacimiento;
                    VecDatosAux[0]["Email"] = ClienteObj.CorreoElec;

                    dataSetVenta1.Tables["TblCliente"].ReadXml(PathFile + "clientes.xml");
                    VecDatosAux[0].AcceptChanges();
                    dataSetVenta1.Tables["TblCliente"].WriteXml(PathFile + "clientes.xml");

                    MessageBox.Show("Datos modificados correctamente", "Registro guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                } else if (resultado == DialogResult.No) {
                    this.Close();
                } else {
                    this.Close();
                }

            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }
    }
}