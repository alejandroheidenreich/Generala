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
    public partial class FrmMenuPrincipal : Form
    {
        List<Partida> mesas;
        Task logPartida;
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
                partida.salidaLogs += btn_SeleccioanrMesa_Click;
            }

            ActualizarListaDeMesas();
        }

        private void ActualizarDatosDePartida(Partida partida)
        {
            BindingSource bsUno = new BindingSource();
            BindingSource bsDos = new BindingSource();
            if (this.rtb_LogPartida.InvokeRequired)
            {
                this.rtb_LogPartida.Invoke(new Action<Partida>(ActualizarDatosDePartida), partida);
            }
            else
            {
                this.rtb_LogPartida.Clear();
                this.rtb_LogPartida.Text = partida.LogPartida;
            }

            if (this.dtg_JuegoUno.InvokeRequired)
            {
                this.dtg_JuegoUno.Invoke(new Action<Partida>(ActualizarDatosDePartida), partida);
            }
            else
            {
                this.dtg_JuegoUno.DataSource = null;
                bsUno.DataSource = partida.JuegoUno.Juegos;
                this.dtg_JuegoUno.DataSource = bsUno;
            }

            if (this.dtg_JuegoDos.InvokeRequired)
            {
                this.dtg_JuegoDos.Invoke(new Action<Partida>(ActualizarDatosDePartida), partida);
            }
            else
            {
                this.dtg_JuegoDos.DataSource = null;
                bsDos.DataSource = partida.JuegoDos.Juegos;
                this.dtg_JuegoDos.DataSource = bsDos;
            }

            if (this.lbl_J1.InvokeRequired)
            {
                this.lbl_J1.Invoke(new Action<Partida>(ActualizarDatosDePartida), partida);
            }
            else
            {
                this.lbl_J1.Text = partida.J1.Nombre;
            }
            if (this.lbl_J2.InvokeRequired)
            {
                this.lbl_J2.Invoke(new Action<Partida>(ActualizarDatosDePartida), partida);
            }
            else
            {
                this.lbl_J2.Text = partida.J2.Nombre;
            }

            if (this.lbl_PuntajeJ1.InvokeRequired)
            {
                this.lbl_PuntajeJ1.Invoke(new Action<Partida>(ActualizarDatosDePartida), partida);
            }
            else
            {
                this.lbl_PuntajeJ1.Text = partida.JuegoUno.PuntajeTotal.ToString();
            }
            if (this.lbl_PuntajeJ2.InvokeRequired)
            {
                this.lbl_PuntajeJ2.Invoke(new Action<Partida>(ActualizarDatosDePartida), partida);
            }
            else
            {
                this.lbl_PuntajeJ2.Text = partida.JuegoDos.PuntajeTotal.ToString();
            }

        }
        private void ActualizarListaDeMesas()
        {
            this.dtg_Mesa.DataSource = null;
            this.dtg_Mesa.DataSource = this.mesas;
            this.dtg_Mesa.Columns["JuegoUno"].Visible = false;
            this.dtg_Mesa.Columns["JuegoDos"].Visible = false;
            this.dtg_Mesa.Columns["LogPartida"].Visible = false;

        }

        private Partida ObtenerMesaSeleccionado()
        {
            return (Partida)dtg_Mesa.CurrentRow.DataBoundItem;
        }

        private void btn_EntrarSala_Click(object sender, EventArgs e)
        {

            Partida partida = ObtenerMesaSeleccionado();
            ActualizarDatosDePartida(partida);
            partida.IniciarPartida();
            //FrmMesa mesa = new FrmMesa(partida);
            //mesa.ShowDialog();
        }

        private void btn_SeleccioanrMesa_Click(object sender, EventArgs e)
        {
            ActualizarDatosDePartida(ObtenerMesaSeleccionado());
        }
    }
}
