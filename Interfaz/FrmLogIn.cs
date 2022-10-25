using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interfaz
{
    public partial class FrmLogIn : Form
    {
        public FrmLogIn()
        {
            InitializeComponent();
        }

        private void FrmLogIn_Load(object sender, EventArgs e)
        {

        }

        private void btn_Ingresar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txt_usuario.Text))
            {
                MostrarMensajeDeError("Por favor, ingrese un usuario");
            }
            else if (String.IsNullOrEmpty(txt_contrasenia.Text))
            {
                MostrarMensajeDeError("Por favor, ingrese una contraseña");
            }
            else
            {
                try
                {
                    int posicionDelUsuario = 0; /*= Sistema.VerificarUsuarioContrasenia(txt_usuario.Text, txt_contrasenia.Text)*/
                    if (posicionDelUsuario > -1)
                    {
                        //AccederAlMenuPrincipal(posicionDelUsuario);
                    }
                    else
                    {
                        MostrarMensajeDeError("Datos incorrectos");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"No es valido: {ex.Message} es este");
                }

            }
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_BotonAutoCompletado_Click(object sender, EventArgs e)
        {

        }

        private void lbl_recuperarContrasenia_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show($"Contactar a soporte{Environment.NewLine}Se cerrara la aplicacion", "Cerrando Aplicacion", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            Application.Exit();
        }

        private void MostrarMensajeDeError(string mensaje)
        {
            lbl_mensajeDeError.Text = "     " + mensaje;
            lbl_mensajeDeError.Visible = true;
        }
    }
}
