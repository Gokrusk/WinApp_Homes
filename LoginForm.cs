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
        string PathFile = Application.StartupPath + "\\assets\\files\\";

        private void LoginForm_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Bienvenido a nuestra aplicación!", "Bienvenido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            dataSetVenta1.ReadXml(PathFile + "\\admin.xml");
            DataRow[] data;
            data = dataSetVenta1.TblUsuarios.Select("usuario='" + TxtUser.Text + "'");
            if (data.Length > 0)
            {
                if (data[0]["usuario"].ToString() == TxtUser.Text)
                {
                    if (TxtUser.Text == "administrar")
                    {
                        if (data[0]["pass"].ToString() == TxtPsw.Text)
                        {
                            Form1 obj = new Form1();
                            obj.ShowDialog();
                        }
                        else
                        {
                            MessageBox.Show("Contraseña incorrecta", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    // else if (TxtUser.Text == "nigell")
                    // {
                    //     if (data[0]["pass"].ToString() == TxtPsw.Text)
                    //     {
                    //         Form1 obj = new Form1();
                    //         obj.ShowDialog();
                    //     }
                    //     else
                    //     {
                    //         MessageBox.Show("Contraseña incorrecta", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //     }
                    // }
                    // else
                    // {
                    //     MessageBox.Show("No se encuentra el usuario", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // }
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

        private void TxtUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter)
            {
                TxtPsw.Focus();
            }
        }

        private void TxtPsw_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter)
            {
                BtnLogin_Click(sender, e);
            }
        }
    }
}
