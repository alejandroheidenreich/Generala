using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.MemoryMappedFiles;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;

namespace Interfaz
{
    public partial class FrmMenuPrincipal : Form
    {
        List<Partida>? mesas;
        private bool mouseAccion;
        private int mousePosX;
        private int mousePosY;
        //Task logPartida;
        public FrmMenuPrincipal()
        {
            InitializeComponent();
        }
        private void FrmMenuPrincipal_Load(object sender, EventArgs e)
        {
            this.mesas = new List<Partida>();
            //Sistema sistema = new Sistema();
            //sistema.CrearTablaDeJuegos();

            //SerializadoraJSON<Dictionary<string, EstadoJuego>> dic = new SerializadoraJSON<Dictionary<string, EstadoJuego>>();
            //Dictionary<string, EstadoJuego> map = new Dictionary<string, EstadoJuego>();
            //map = dic.Leer("tablita");
            //BindingSource bs = new BindingSource();
            //bs.DataSource = map;
            //dtg_JuegoDos.DataSource = bs;
        }
        private void btn_CrearMesa_Click(object sender, EventArgs e)
        {
            this.lbl_MensajeDeError.Visible = false;
            FrmSeleccionJugador frmSeleccionJugador = new FrmSeleccionJugador(this.mesas!);
            DialogResult result = frmSeleccionJugador.ShowDialog();
            if (result == DialogResult.OK)
            {
                Partida partida = new Partida(frmSeleccionJugador.J1, frmSeleccionJugador.J2, AnunciarGanador, MostrarDados);
                this.mesas!.Add(partida);
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
                if (partida.Cancelacion.IsCancellationRequested && !partida.TerminoPartida)
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
                    this.lbl_Ganador.Text = $"Ganador: {partida.Ganador}";
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
            if (this.mesas!.Count > 0)
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
        }

        private void dtg_Mesa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SeleccionarMesa();
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
                if (ObtenerMesaSeleccionado().Ganador is not null && ObtenerMesaSeleccionado().Ganador.ToString() == mensaje)
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
        private void dtg_JuegoUno_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

            dtg_JuegoUno.ClearSelection();
            foreach (DataGridViewRow fila in dtg_JuegoUno.Rows)
            {
                if ((EstadoJuego)fila.Cells[1].Value == EstadoJuego.Realizado)
                {
                    fila.DefaultCellStyle.BackColor = Color.Green;
                }
                else if ((EstadoJuego)fila.Cells[1].Value == EstadoJuego.Tachado)
                {
                    fila.DefaultCellStyle.BackColor = Color.Red;
                }
                else
                {
                    fila.DefaultCellStyle.BackColor = Color.DimGray;
                }
            }
        }

        private void dtg_JuegoDos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            dtg_JuegoDos.ClearSelection();
            foreach (DataGridViewRow fila in dtg_JuegoDos.Rows)
            {
                if ((EstadoJuego)fila.Cells[1].Value == EstadoJuego.Realizado)
                {
                    fila.DefaultCellStyle.BackColor = Color.Green;
                }
                else if ((EstadoJuego)fila.Cells[1].Value == EstadoJuego.Tachado)
                {
                    fila.DefaultCellStyle.BackColor = Color.Red;
                }
                else
                {
                    fila.DefaultCellStyle.BackColor = Color.DimGray;
                }
            }
        }

        private void btn_IMG_Click(object sender, EventArgs e)
        {
            // TODO: saca esto de aca
            // open file dialog   
            OpenFileDialog open = new OpenFileDialog();
            // image filters  
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp, *.png)|*.jpg; *.jpeg; *.gif; *.bmp; *.png";
            if (open.ShowDialog() == DialogResult.OK)
            {
                // Serializar la imagen y guardarla...
                //MessageBox.Show("Se selecciono una imagen buena");
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

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FrmMenuPrincipal_MouseDown(object sender, MouseEventArgs e)
        {
            this.mouseAccion = true;
            this.mousePosX = e.X;
            this.mousePosY = e.Y;
        }

        private void FrmMenuPrincipal_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseAccion)
            {
                this.SetDesktopLocation(MousePosition.X - mousePosX, MousePosition.Y - mousePosY);
            }
        }

        private void FrmMenuPrincipal_MouseUp(object sender, MouseEventArgs e)
        {
            this.mouseAccion = false;
        }

        private void btn_Estadisticas_Click(object sender, EventArgs e)
        {
            FrmEstadisticas frmEstadisticas = new FrmEstadisticas();
            frmEstadisticas.ShowDialog();
        }

        private void btn_Recargar_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < this.mesas!.Count; i++)
            {
                if (this.mesas[i].TerminoPartida)
                {
                    this.mesas.RemoveAt(i);
                }
            }
            ActualizarListaDeMesas();
            if (this.mesas!.Count > 0)
            {
                SeleccionarMesa();
            }
            else
            {
                ReiniciarVistaPartida();
            }
        }

        private void ReiniciarVistaPartida()
        {
            this.gb_Dados.Visible = false;
            this.dtg_JuegoUno.DataSource = null;
            this.dtg_JuegoDos.DataSource = null;
            this.lbl_J1.Text = "Jugador 1";
            this.lbl_J2.Text = "Jugador 2";
            this.lbl_PuntajeJ1.Text = "0";
            this.lbl_PuntajeJ2.Text = "0";
            this.rtb_LogPartida.Text = "";
            this.lbl_Ganador.Visible = false;
            this.lbl_MensajeDeSala.Visible = false;

        }
    }
}
