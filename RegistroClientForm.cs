using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinApp_Homes {
    public partial class RegistroClientForm: Form {
        ClCliente ClienteObj = new ClCliente();

        private bool ModCed;
        private bool ModNom;
        private bool ModApe;
        private bool ModCor;

        string PathFile = Application.StartupPath + "\\assets\\files\\";

        public RegistroClientForm() {
            InitializeComponent();
            TxtCedula.Focus();
        }

        private bool ValidarCedula(string Cedula) {
            if (Cedula.Length != 10 || !int.TryParse(Cedula, out int n)) {
                LblInfoCed.Text = "Número inválido";
                TxtCedula.Clear();
                return false;
            }

            int sum = 0;

            for (int i = 0; i < 9; i++) {
                int digit = int.Parse(Cedula[i].ToString());
                int coef = (i % 2 == 0) ? 2 : 1;
                int product = digit * coef;
                sum += (product >= 10) ? (product - 9) : product;
            }

            int lastDigit = int.Parse(Cedula[9].ToString());
            int calculatedDigit = (sum % 10 == 0) ? 0 : (10 - (sum % 10));

            if (lastDigit == calculatedDigit)
                return true;

            else {
                LblInfoCed.Text = "Cédula inválida";
                TxtCedula.Clear();
                return false;
            }
        }

        public static bool ValidarCorreo(string Correo) {
            string formato = @"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$";

            Match match = Regex.Match(Correo, formato);

            return match.Success;
        }

        public void MensajeError() {
            MessageBox.Show("Por favor ingrese de nuevo el dato.", "Ha ocurrido un error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void TxtCedula_TextChanged(object sender, EventArgs e) {
            ModCed = false;
        }

        private void TxtCedula_KeyPress(object sender, KeyPressEventArgs e) {
            if (e.KeyChar == (char)Keys.Enter) {
                try {
                    LblInfoCed.Text = "";
                    ClienteObj.Cedula = TxtCedula.Text;

                    if(ClienteObj.Cedula != "") {
                        if (ValidarCedula(ClienteObj.Cedula)) {
                            TxtCedula.ForeColor = Color.Black;
                            TxtNombre.Enabled = true;
                            ModCed = true;
                            TxtNombre.Focus();
                        }

                    }else {
                        LblInfoCed.Text = "Dato requerido";
                    }

                } catch (Exception) {
                    MensajeError();
                    TxtCedula.Clear();
                }
            }
        }

        private void TxtNombre_TextChanged(object sender, EventArgs e) {
            ModNom = false;
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

                    } else {
                        TxtNombre.ForeColor = Color.Black;
                        TxtApellido.Enabled = true;
                        ModNom = true;
                        TxtApellido.Focus();
                    }

                } catch (Exception) {
                    MensajeError();
                    TxtNombre.Clear();
                }
            }
        }

        private void TxtApellido_TextChanged(object sender, EventArgs e) {
            ModApe = false;
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

                    } else {
                        TxtApellido.ForeColor = Color.Black;
                        CbxSexo.Enabled = true;
                        ModApe = true;
                    }

                } catch (Exception) {
                    MensajeError();
                    TxtApellido.Clear();
                }
            }
        }

        private void CbxSexo_SelectedIndexChanged(object sender, EventArgs e) {
            if(CbxSexo.SelectedIndex == 0) {
                ClienteObj.Sexo = 'M';
            }else {
                ClienteObj.Sexo = 'F';
            }

            TxtCorreo.Focus();
            DtpFecha.Enabled = true;
        }

        private void DtpFecha_ValueChanged(object sender, EventArgs e) {
            DtpFecha.MaxDate = DateTime.Today.AddYears(-18);
            DtpFecha.MinDate = DateTime.Today.AddYears(-100);

            ClienteObj.FechaNacimiento = DtpFecha.Value;
            CbxCiudad.Enabled = true;
        }

        private void CbxCiudad_SelectedIndexChanged(object sender, EventArgs e) {
            ClienteObj.Ciudad = CbxCiudad.SelectedItem.ToString();

            TxtCorreo.Enabled = true;
            TxtCorreo.Focus();
        }

        private void TxtCorreo_TextChanged(object sender, EventArgs e) {
            ModCor = false;
        }

        private void TxtCorreo_KeyPress(object sender, KeyPressEventArgs e) {
            if (e.KeyChar == (char)Keys.Enter) {
                try {
                    LblInfoCorr.Text = "";
                    ClienteObj.CorreoElec = TxtCorreo.Text;

                    if (ValidarCorreo(ClienteObj.CorreoElec)) {
                        TxtCorreo.ForeColor = Color.Black;
                        BtnGuardar.Enabled = true;
                        BtnGuardar.Focus();
                        ModCor = true;
                    } else {
                        LblInfoCorr.Text = "Correo invalido";
                        TxtCorreo.Clear();
                    }

                } catch (Exception) {
                    MensajeError();
                    TxtCorreo.Clear();
                }
            }
        }

        private void BtnGuardar_Click(object sender, EventArgs e) {
            try {
                if (ModCed && ModNom && ModApe && ModCor) {
                    dataSetVenta1.Tables["TblCliente"].ReadXml(PathFile + "clientes.xml");
                    object[] dataClient = new object[7];

                    dataClient[0] = ClienteObj.Cedula;
                    dataClient[1] = ClienteObj.Nombre;
                    dataClient[2] = ClienteObj.Apellido;
                    dataClient[3] = ClienteObj.Sexo;
                    dataClient[4] = ClienteObj.Ciudad;
                    dataClient[5] = ClienteObj.FechaNacimiento;
                    dataClient[6] = ClienteObj.CorreoElec;

                    dataSetVenta1.TblCliente.Rows.Add(dataClient);
                    dataSetVenta1.Tables["TblCliente"].WriteXml(PathFile + "clientes.xml");

                    MessageBox.Show("Cliente registrado correctamente.", "Registro guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                } else {
                    MessageBox.Show("Por favor asegúrese de dar Enter al modificar un dato para su respectiva validación.", "Dato no validado", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    if (!ModCed) {
                        TxtCedula.ForeColor = Color.Red;
                    }

                    if (!ModNom) {
                        TxtNombre.ForeColor = Color.Red;
                    }

                    if (!ModApe) {
                        TxtApellido.ForeColor = Color.Red;
                    }

                    if (!ModCor) {
                        TxtCorreo.ForeColor = Color.Red;
                    }
                }
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}