using Entidades;
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
        Sistema? sistema;
        BaseDeDatos? db;
        private bool mouseAccion;
        private int mousePosX;
        private int mousePosY;

        public FrmLogIn()
        {
            InitializeComponent();
        }

        private void FrmLogIn_Load(object sender, EventArgs e)
        {
            this.sistema = new Sistema();
            this.db = new BaseDeDatos();
            new SerializadorXML<Usuario>().Escribir(new Usuario(10, "messi", "Eldiego#10"), "eduardo");
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
                    if (this.sistema!.VerificarUsuarioContrasenia(txt_usuario.Text, txt_contrasenia.Text))
                    {
                        FrmMenuPrincipal menuPrincipal = new FrmMenuPrincipal();
                        menuPrincipal.Show();
                        this.Hide();
                    }
                    else
                    {
                        MostrarMensajeDeError("Datos incorrectos");
                    }
                }
                catch (Exception ex)
                {
                    InformarErrorFatal(ex);
                }

            }
        }
        private static void InformarErrorFatal(Exception ex)
        {
            DialogResult respuesta = MessageBox.Show($"{ex.Message}. El programa se cerrara", "Error Fatal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            if (respuesta == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_BotonAutoCompletado_Click(object sender, EventArgs e)
        {
            txt_usuario.Text = "admin";
            txt_contrasenia.Text = "Admin!10";
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

        private void FrmLogIn_MouseDown(object sender, MouseEventArgs e)
        {
            this.mouseAccion = true;
            this.mousePosX = e.X;
            this.mousePosY = e.Y;
        }

        private void FrmLogIn_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseAccion)
            {
                this.SetDesktopLocation(MousePosition.X - mousePosX, MousePosition.Y - mousePosY);
            }
        }

        private void FrmLogIn_MouseUp(object sender, MouseEventArgs e)
        {
            this.mouseAccion = false;
        }

        private void pic_Logo_MouseDown(object sender, MouseEventArgs e)
        {
            this.mouseAccion = true;
            this.mousePosX = e.X;
            this.mousePosY = e.Y;
        }

        private void pic_Logo_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseAccion)
            {
                this.SetDesktopLocation(MousePosition.X - mousePosX, MousePosition.Y - mousePosY);
            }
        }

        private void pic_Logo_MouseUp(object sender, MouseEventArgs e)
        {
            this.mouseAccion = false;
        }
    }
}
