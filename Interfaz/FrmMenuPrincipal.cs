using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interfaz
{
    public partial class FrmMenuPrincipal : Form
    {
        List<Partida> mesas;
        //Task logPartida;
        public FrmMenuPrincipal()
        {
            InitializeComponent();
        }
        private void FrmMenuPrincipal_Load(object sender, EventArgs e)
        {
            this.mesas = new List<Partida>();
        }
        private void btn_CrearMesa_Click(object sender, EventArgs e)
        {
            FrmSeleccionJugador frmSeleccionJugador = new FrmSeleccionJugador();
            DialogResult result = frmSeleccionJugador.ShowDialog();
            if (result == DialogResult.OK)
            {

                Partida partida = new Partida(frmSeleccionJugador.J1, frmSeleccionJugador.J2);
                this.mesas.Add(partida);
                partida.salidaLogs += SeleccionarMesa;
            }

            ActualizarListaDeMesas();
        }

        private void ActualizarDatosDePartida(Partida partida)
        {
            BindingSource bsUno = new BindingSource();
            BindingSource bsDos = new BindingSource();

            if (this.InvokeRequired)
            {
                this.Invoke(new Action<Partida>(ActualizarDatosDePartida), partida);     
            }
            else
            {
                this.rtb_LogPartida.Clear();
                this.rtb_LogPartida.Text = partida.LogPartida;
                this.rtb_LogPartida.SelectionStart = this.rtb_LogPartida.Text.Length;
                this.rtb_LogPartida.ScrollToCaret();
                this.dtg_JuegoUno.DataSource = null;
                bsUno.DataSource = partida.JuegoUno.Juegos;
                this.dtg_JuegoUno.DataSource = bsUno;
                this.dtg_JuegoDos.DataSource = null;
                bsDos.DataSource = partida.JuegoDos.Juegos;
                this.dtg_JuegoDos.DataSource = bsDos;
                this.lbl_J1.Text = partida.J1.Nombre;
                this.lbl_J2.Text = partida.J2.Nombre;
                this.lbl_PuntajeJ1.Text = partida.JuegoUno.PuntajeTotal.ToString();
                this.lbl_PuntajeJ2.Text = partida.JuegoDos.PuntajeTotal.ToString();
                if (partida.Cancelacion.IsCancellationRequested)
                {
                    this.lbl_MensajeDeSala.Text = $"La partida terminara {Environment.NewLine}al terminar este turno";
                    this.lbl_MensajeDeSala.Visible = true;
                }
                else
                {
                    this.lbl_MensajeDeSala.Visible = false;
                }
            }

        }
        private void ActualizarListaDeMesas()
        {
            this.dtg_Mesa.DataSource = null;
            this.dtg_Mesa.DataSource = this.mesas;
            this.dtg_Mesa.Columns["JuegoUno"].Visible = false;
            this.dtg_Mesa.Columns["JuegoDos"].Visible = false;
            this.dtg_Mesa.Columns["LogPartida"].Visible = false;
            this.dtg_Mesa.Columns["Cancelacion"].Visible = false;

        }

        private Partida ObtenerMesaSeleccionado()
        {
            return (Partida)dtg_Mesa.CurrentRow.DataBoundItem;
        }

        private void btn_IniciarPartida_Click(object sender, EventArgs e)
        {

            Partida partida = ObtenerMesaSeleccionado();

            partida.IniciarPartida();
        }

        private void SeleccionarMesa()
        {
            ActualizarDatosDePartida(ObtenerMesaSeleccionado());
        }

        private void btn_CancelarPartida_Click(object sender, EventArgs e)
        {
            Partida partida = ObtenerMesaSeleccionado();
            partida.Cancelacion.Cancel();
            //this.lbl_MensajeDeSala.Text = "La partida terminara al terminar este turno";
            //this.lbl_MensajeDeSala.Visible = true;


        }

        private void dtg_Mesa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //this.pnl_Cargando.Visible = true;
            //SeleccionarMesa();
        }

        private void dtg_Mesa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SeleccionarMesa();
            //this.lbl_MensajeDeSala.Visible = false;
        }
    }
}
