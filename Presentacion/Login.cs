using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Domain;
using Presentacion;

namespace GestionClinicaVeterinaria
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        int intentos = 3;

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void tbUsuario_TextChanged(object sender, EventArgs e)
        {

        }
        
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (tbUsuario.Text != ""){
                if (tbContrasena.Text != ""){

                    UserModel user = new UserModel();
                    var validLogin = user.LoginUser(tbUsuario.Text, tbContrasena.Text);
                    if (validLogin == true)
                    {
                        FormMenu mainMenu = new FormMenu();
                        mainMenu.Show();
                        mainMenu.FormClosed += Logout;
                        this.Hide();
                    }
                    else
                    {
                        intentos -= 1;
                        msgError("Usuario o contraseña incorrecto.");
                        tbUsuario.Clear();
                        tbContrasena.Clear();

                        if (intentos == 0) { Application.Exit(); }

                        MessageBox.Show("Usuario y/o contraseña invalido \n Intentos restantes: " + intentos.ToString());
                    }
              
                }
                else msgError("Entre la contraseña.");
            }
            else msgError("Entre el usuario.");
        }
        private void msgError(string msg)
        {
            lblErrorMassage.Text = "     " + msg;
            lblErrorMassage.Visible = true;
        }

        private void Logout (object sender, FormClosedEventArgs e)
        {
            tbUsuario.Clear();
            tbContrasena.Clear();
            lblErrorMassage.Visible = false;
            this.Show();
            tbUsuario.Focus();

        }


    }
}
