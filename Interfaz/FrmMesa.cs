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
    public partial class FrmMesa : Form
    {
        private Partida partida;
        private Juego juegoUno;
        private Juego juegoDos;
        private int cantidadDeTiros;
        
        public FrmMesa(Partida partida)
        {
            InitializeComponent();
        }
        private void Mesa_Load(object sender, EventArgs e)
        {
            //this.partida = new Partida();
            juegoUno = partida.JuegoUno;
            juegoDos = partida.JuegoDos;
            this.lbl_Puntaje.Text = juegoUno.PuntajeTotal.ToString();
            //ActualizarJuegos(Juego juego)
        }
        private void btn_TirarDados_Click(object sender, EventArgs e)
        {
            this.lbl_mensajeDeError.Visible = false;
            if (gb_Dados.Visible == false)
            {
                juegoUno.Jugador.TirarDados();
                cantidadDeTiros = 2;
                gb_Dados.Visible = true;
            }
            else
            {
                if (cantidadDeTiros > 0)
                {
                    ElegirSegundaTirada();
                }
                else
                {
                    MostrarMensajeDeError("Se terminaron las tiradas, realice o tache juego");
                }
            }
            ModificarDados(juegoUno.Jugador.Dados);
            this.lbl_InfoDados.Text = juegoUno.Jugador.ToString();
            NotificarJuegosPosibles(juegoUno);
            ActualizarJuegos(juegoUno);
            ReiniciarSeleccionDado();
        }

        private void ElegirSegundaTirada()
        {
            int dado1 = -1;
            int dado2 = -1;
            int dado3 = -1;
            int dado4 = -1;
            int dado5 = -1;

            //int indexDado = 0;
            bool seleccionDado = false;

            //foreach (Control item in this.gb_Dados.Controls)
            //{
            //    if (lbl_Dado1.BackColor == Color.LightGreen)
            //    {
            //        dado1 = 0;
            //        seleccionDado = true;
            //    }
            //}

            if (lbl_Dado1.BackColor == Color.LightGreen)
            {
                dado1 = 0;
                seleccionDado = true;
            }
            if (lbl_Dado2.BackColor == Color.LightGreen)
            {
                dado2 = 1;
                seleccionDado = true;
            }
            if (lbl_Dado3.BackColor == Color.LightGreen)
            {
                dado3 = 2;
                seleccionDado = true;
            }
            if (lbl_Dado4.BackColor == Color.LightGreen)
            {
                dado4 = 3;
                seleccionDado = true;
            }
            if (lbl_Dado5.BackColor == Color.LightGreen)
            {
                dado5 = 4;
                seleccionDado = true;
            }
            if (seleccionDado)
            {
                juegoUno.Jugador.TirarDados(dado1, dado2, dado3, dado4, dado5);
            }
            else
            {
                juegoUno.Jugador.TirarDados();
            }
            cantidadDeTiros--;
        }

        private void ModificarDados(int[] dados)
        {
            this.lbl_Dado1.ImageIndex = dados[0]-1;
            this.lbl_Dado2.ImageIndex = dados[1]-1;
            this.lbl_Dado3.ImageIndex = dados[2]-1;
            this.lbl_Dado4.ImageIndex = dados[3]-1;
            this.lbl_Dado5.ImageIndex = dados[4]-1;
        }

        private void NotificarJuegosPosibles(Juego juego)
        {
            this.lst_JuegosPosibles.DataSource = null;
            this.lst_JuegosPosibles.DataSource = juego.EncontrarJuegos();
        }
        private void ActualizarJuegos(Juego juego)
        {
            BindingSource bs = new BindingSource();
            this.dtg_Juegos.DataSource = null;
            bs.DataSource = juego.Juegos;
            this.dtg_Juegos.DataSource = bs;
        }

        private void btn_Tachar_Click(object sender, EventArgs e)
        {
            try
            {
                juegoUno.TacharJuego(ObtenerJuegoSeleccionado());
                ActualizarJuegos(juegoUno);
                this.cantidadDeTiros = 3;
                gb_Dados.Visible = false;
                lbl_mensajeDeError.Visible = false;
                ReiniciarSeleccionDado();
                this.lst_JuegosPosibles.DataSource = null;
                if (juegoUno.Completo)
                    TerminarPartida();
                
            }
            catch (Exception ex)
            {
                MostrarMensajeDeError(ex.Message);
            }
        }

        private void SimularTurno()
        {

        }
        private string ObtenerJuegoSeleccionado()
        {
            KeyValuePair<string, EstadoJuego> juego = (KeyValuePair<string, EstadoJuego>)dtg_Juegos.CurrentRow.DataBoundItem;
            return juego.Key;
        }

        private void MostrarMensajeDeError(string mensaje)
        {
            lbl_mensajeDeError.Text = "     " + mensaje;
            lbl_mensajeDeError.Visible = true;
        }

        private void btn_Realizar_Click(object sender, EventArgs e)
        {
            try
            {
                juegoUno.RealizarJuego(ObtenerJuegoSeleccionado());
                ActualizarJuegos(juegoUno);
                this.cantidadDeTiros = 3;
                gb_Dados.Visible = false;
                lbl_mensajeDeError.Visible = false;
                ReiniciarSeleccionDado();
                this.lbl_Puntaje.Text = juegoUno.PuntajeTotal.ToString();
                this.lst_JuegosPosibles.DataSource = null;
                if (juegoUno.Completo)
                {
                    TerminarPartida();
                }
            }
            catch (Exception ex)
            {
                MostrarMensajeDeError(ex.Message);
                
            }
        }

        private void TerminarPartida()
        {
            this.pnl_FinPartida.Visible = true;
            this.lbl_PuntajeFinal.Text = this.juegoUno.PuntajeTotal.ToString();
        }
        private void ReiniciarSeleccionDado()
        {
            lbl_Dado1.BackColor = Color.WhiteSmoke;
            lbl_Dado2.BackColor = Color.WhiteSmoke;
            lbl_Dado3.BackColor = Color.WhiteSmoke;
            lbl_Dado4.BackColor = Color.WhiteSmoke;
            lbl_Dado5.BackColor = Color.WhiteSmoke;
            
        }
        private void lbl_Dado1_Click(object sender, EventArgs e)
        {
            CambiarColorDado(this.lbl_Dado1);
        }

        private void lbl_Dado2_Click(object sender, EventArgs e)
        {
            CambiarColorDado(this.lbl_Dado2);
        }

        private void lbl_Dado3_Click(object sender, EventArgs e)
        {
            CambiarColorDado(this.lbl_Dado3);
        }

        private void lbl_Dado4_Click(object sender, EventArgs e)
        {
            CambiarColorDado(this.lbl_Dado4);
        }

        private void lbl_Dado5_Click(object sender, EventArgs e)
        {
            CambiarColorDado(this.lbl_Dado5);
        }

        private void CambiarColorDado(Label dado)
        {
            if (dado.BackColor == Color.WhiteSmoke)
            {
                dado.BackColor = Color.LightGreen;
            }
            else
            {
                dado.BackColor = Color.WhiteSmoke;
            }
        }
        private void btn_SalirDePartida_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_ReiniciarPartida_Click(object sender, EventArgs e)
        {
            ReiniciarPartida();
        }

        private void ReiniciarPartida()
        {
            //this.partida = new Partida();
            juegoUno = partida.JuegoUno;
            juegoDos = partida.JuegoDos;
            this.lbl_Puntaje.Text = juegoUno.PuntajeTotal.ToString();
            this.pnl_FinPartida.Visible = false;
            ActualizarJuegos(juegoUno);
            this.lbl_InfoDados.Text = "";
        }

        public string NombreDeMesa()
        {
            return "Mesita";
        }
    }
}
