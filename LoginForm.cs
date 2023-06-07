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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        //string PathFile = Application.StartupPath + "\\..\\..\\assets\\files\\";
        string PathFile = "C:\\assets\\files\\";

        private void LoginForm_Load(object sender, EventArgs e)
        {
            MessageBox.Show("BIENVENIDO A NUESTRO APLICATIVO", "BIENVENIDA", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            try
            {

                dataSetVenta1.ReadXml(PathFile + "admin.xml");
                DataRow[] admin;
                admin = dataSetVenta1.TblUsuarios.Select("usuario='" + TxtUser.Text + "'");

                if (admin.Length > 0)
                {
                    if (admin[0]["usuario"].ToString() == TxtUser.Text)
                    {
                        if (TxtUser.Text == "administrar")
                        {
                            if (admin[0]["pass"].ToString() == TxtPsw.Text)
                            {
                                LoginForm principal = new LoginForm();
                                this.Hide();
                                MenuFormAdmin obj = new MenuFormAdmin();
                                obj.ShowDialog();
                                principal.Show();
                            }
                            else
                            {
                                MessageBox.Show("Contraseña incorrecta", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("No se encuentra el usuario", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("No se encuentra el usuario", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch //(Exception ex)
            {
                //MessageBox.Show(ex.Message);
                MessageBox.Show("No se puede leer el archivo de registros", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void TxtUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                TxtPsw.Focus();
            }
        }

        private void TxtPsw_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                BtnLogin_Click(sender, e);
            }
        }

        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(PathFile);
            LoginForm principal = new LoginForm();
            this.Hide();
            MenuFormAdmin obj = new MenuFormAdmin();
            obj.ShowDialog();
            principal.Show();
        }
    }
}
