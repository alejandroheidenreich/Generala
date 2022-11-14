using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
            this.lbl_MensajeDeError.Visible = false;
            FrmSeleccionJugador frmSeleccionJugador = new FrmSeleccionJugador(this.mesas);
            DialogResult result = frmSeleccionJugador.ShowDialog();
            if (result == DialogResult.OK)
            {
                Partida partida = new Partida(frmSeleccionJugador.J1, frmSeleccionJugador.J2, AnunciarGanador, MostrarDados);
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
                this.gb_Dados.Visible = true;
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
                MostrarDados(partida.UltimaTirada);
                if (partida.Cancelacion.IsCancellationRequested)
                {
                    this.lbl_MensajeDeSala.Text = $"La partida terminara {Environment.NewLine}al terminar este turno";
                    this.lbl_MensajeDeSala.Visible = true;
                }
                else
                {
                    this.lbl_MensajeDeSala.Visible = false;
                }
                if (partida.Ganador is not null)
                {
                    this.lbl_Ganador.Visible = true;
                }
                else
                {
                    this.lbl_Ganador.Visible = false;
                }
            }
        }
        private void ActualizarListaDeMesas()
        {
            this.dtg_Mesa.DataSource = null;
            if (this.mesas.Count > 0)
            {
                this.dtg_Mesa.DataSource = this.mesas;
                this.dtg_Mesa.Columns["JuegoUno"].Visible = false;
                this.dtg_Mesa.Columns["JuegoDos"].Visible = false;
                this.dtg_Mesa.Columns["LogPartida"].Visible = false;
                this.dtg_Mesa.Columns["Cancelacion"].Visible = false;
                this.dtg_Mesa.Columns["InicioPartida"].Visible = false;
                this.dtg_Mesa.Columns["TerminoPartida"].Visible = false;
                this.dtg_Mesa.Columns["Ganador"].Visible = false;
            }
        }

        private Partida ObtenerMesaSeleccionado()
        {
            return (Partida)dtg_Mesa.CurrentRow.DataBoundItem;
        }

        private void btn_IniciarPartida_Click(object sender, EventArgs e)
        {
            Partida partida = ObtenerMesaSeleccionado();
            if (!partida.InicioPartida)
            {
                partida.IniciarPartida();
                this.lbl_MensajeDeError.Visible = false;
            }   
            else
            {
                this.lbl_MensajeDeError.Text = "Esa partida ya se inicio";
                this.lbl_MensajeDeError.Visible = true;
            }
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

        private void dtg_Mesa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SeleccionarMesa();
            //this.lbl_MensajeDeSala.Visible = false;
        }

        private void AnunciarGanador(string mensaje)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new Action<string>(AnunciarGanador), mensaje);
            }
            else
            {
                this.lbl_Ganador.Text = $"Ganador: {mensaje} !";
                if (ObtenerMesaSeleccionado().Ganador is not null &&
                   ObtenerMesaSeleccionado().Ganador.ToString() == mensaje)
                {
                    this.lbl_Ganador.Visible = true;
                }
                else
                {
                    this.lbl_Ganador.Visible = false;
                }
            }
        }

        private void MostrarDados(int[] dados)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new Action<int[]>(MostrarDados), dados);
            }
            else
            {
                if (!dados.Contains(-1))
                {
                    this.lbl_Dado1.ImageIndex = dados[0] - 1;
                    this.lbl_Dado2.ImageIndex = dados[1] - 1;
                    this.lbl_Dado3.ImageIndex = dados[2] - 1;
                    this.lbl_Dado4.ImageIndex = dados[3] - 1;
                    this.lbl_Dado5.ImageIndex = dados[4] - 1;
                    this.gb_Dados.Visible = true;
                }
                else
                {
                    this.gb_Dados.Visible = false;
                }
            }
        }























        private void btn_IMG_Click(object sender, EventArgs e)
        {
            // open file dialog   
            OpenFileDialog open = new OpenFileDialog();
            // image filters  
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp, *.png)|*.jpg; *.jpeg; *.gif; *.bmp; *.png";
            if (open.ShowDialog() == DialogResult.OK)
            {
                // Serializar la imagen y guardarla...
                MessageBox.Show("Se selecciono una imagen buena");
                // display image in picture box  
                Bitmap imagenDelUsuario = new Bitmap(open.FileName);
                ImageConverter converter = new ImageConverter();
                string bitmapData = Convert.ToBase64String((byte[])converter.ConvertTo(imagenDelUsuario, typeof(byte[])));
                byte[] bytes = Convert.FromBase64String(bitmapData);
                Bitmap bitmap;
                using (var ms = new MemoryStream(bytes))
                {
                    bitmap = new Bitmap(Bitmap.FromStream(ms));
                }
                this.pic_Imagen.Image = bitmap;
                
            }
        }
    }
}
