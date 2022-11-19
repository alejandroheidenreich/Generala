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
    public partial class FrmCrearJugador : Form
    {
        BaseDeDatos db;
        public FrmCrearJugador()
        {
            InitializeComponent();
            this.db = new BaseDeDatos();
        }

        private void btn_Crear_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_Nombre.Text))
            {
                MostrarError("Ingrese un nombre");
            }
            else
            {
                try
                {
                    db.AgregarJugador(new Jugador(txt_Nombre.Text));
                    this.Close();
                }
                catch (Exception ex)
                {
                    MostrarError(ex.Message);
                }

            }
        }

        private void MostrarError(string msj)
        {
            this.lbl_mensajeDeError.Visible = true;
            this.lbl_mensajeDeError.Text = msj;
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
