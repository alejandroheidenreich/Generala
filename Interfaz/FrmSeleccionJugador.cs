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
    public partial class FrmSeleccionJugador : Form
    {
        private Jugador? j1;
        private Jugador? j2;
        private List<Partida> partidas;
        private BaseDeDatos db;
        public FrmSeleccionJugador(List<Partida> partidas)
        {
            InitializeComponent();
            this.partidas = partidas;
            this.db = new BaseDeDatos();
        }

        public Jugador J1
        {
            get => j1!;
        }
        public Jugador J2
        {
            get => j2!;
        }

        private void FrmSeleccionJugador_Load(object sender, EventArgs e)
        {
            ActualizarJugadores();
        }

        private void ActualizarJugadores()
        {
            try
            {
                cmb_JugadorUno.DataSource = this.db.ObtenerJugadores();
                cmb_JugadorDos.DataSource = this.db.ObtenerJugadores();
            }
            catch (Exception ex)
            {
                MostrarError(ex.Message);
            }
        }
        private void MostrarError(string msj)
        {
            this.lbl_mensajeDeError.Visible = true;
            this.lbl_mensajeDeError.Text = msj;
        }

        private void btn_Salir_Click_1(object sender, EventArgs e)
        {
            this.Close();
            DialogResult = DialogResult.Cancel;
        }

        private void btn_Seleccionar_Click_1(object sender, EventArgs e)
        {
            if (cmb_JugadorUno.SelectedItem.Equals(cmb_JugadorDos.SelectedItem))
            {
                MostrarError("Los jugadores no pueden ser iguales");
            }
            else if (cmb_JugadorUno.SelectedItem is null || cmb_JugadorDos.SelectedItem is null)
            {
                MostrarError("El jugador no puede estar vacio");
            }
            else if (Partida.VerificarJugadorDisponible(this.partidas, (Jugador)cmb_JugadorUno.SelectedItem) ||
                    Partida.VerificarJugadorDisponible(this.partidas, (Jugador)cmb_JugadorDos.SelectedItem))
            {
                MostrarError("Uno de los jugadores ya esta en una partida");
            }
            else
            {
                this.j1 = (Jugador)cmb_JugadorUno.SelectedItem;
                this.j2 = (Jugador)cmb_JugadorDos.SelectedItem;
                DialogResult = DialogResult.OK;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btn_AgregarJugador_Click(object sender, EventArgs e)
        {
            FrmCrearJugador frmCrearJugador = new FrmCrearJugador();
            frmCrearJugador.ShowDialog();

            ActualizarJugadores();
        }
    }
}
