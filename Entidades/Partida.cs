using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Entidades
{
    public class Partida
    {
        private int id;
        private Juego juegoUno;
        private Juego juegoDos;
        private string logPartida;
        private bool inicioPartida;
        private bool terminoPartida;
        private Jugador ganador;
        private int[] ultimaTirada;
        CancellationTokenSource cancelacion;
        public event Action salidaLogs;
        Action<string> anunciarGanador;
        Action<int[]> mostrarDados;

        public Partida(Jugador jugadorUno, Jugador jugadorDos, Action<string> anunciarGanador, Action<int[]> mostrarDados)
        {
            this.juegoUno = new Juego(jugadorUno);
            this.juegoDos = new Juego(jugadorDos);
            this.cancelacion = new CancellationTokenSource();
            this.inicioPartida = false;
            this.terminoPartida = false;
            this.ganador = null;
            this.anunciarGanador = anunciarGanador;
            this.mostrarDados = mostrarDados;
            this.ultimaTirada = new int[5] {-1,-1,-1,-1,-1 };
        }

        public Jugador J1
        {
            get
            {
                return juegoUno.Jugador;
            }
        }
        public Jugador J2
        {
            get
            {
                return juegoDos.Jugador;
            }
        }
        public Juego JuegoUno
        {
            get => juegoUno;
        }

        public Juego JuegoDos
        {
            get => juegoDos;
        }
        public string LogPartida
        {
            get => logPartida;
        }
        public CancellationTokenSource Cancelacion
        {
            get => cancelacion;
        }
        public bool InicioPartida
        {
            get => inicioPartida;
            set => inicioPartida = value;
        }
        public bool TerminoPartida
        {
            get => terminoPartida;
            set => terminoPartida = value;
        }
        public Jugador Ganador
        {
            get => ganador;
            set => ganador = value;
        }
        public int[] UltimaTirada
        {
            get => ultimaTirada;
            set => ultimaTirada = value;
        }

        public void IniciarPartida()
        {
            this.inicioPartida = true;
            Task simulacion = Task.Run(() =>SimularPartida(this.cancelacion.Token));
        }

        public void SimularPartida(CancellationToken cancellation)
        {
            while (true)
            {
                if(!cancellation.IsCancellationRequested && (!juegoUno.Completo && !juegoDos.Completo)) 
                {
                    Turno(juegoUno);
                    Turno(juegoDos);
                }
                else
                {
                    this.logPartida += $"Partida Finalizada";
                    salidaLogs?.Invoke();
                    break;
                }
            }
            this.terminoPartida = true;
            this.ganador = this.J2;
            if (juegoUno.PuntajeTotal > juegoDos.PuntajeTotal)
                this.ganador = this.J1;

            anunciarGanador.Invoke(this.ganador.ToString());
            salidaLogs?.Invoke();

            BaseDeDatos baseDeDatos = new BaseDeDatos();
            baseDeDatos.AgregarPartida(this);
        }

        public void Turno(Juego juego)
        {
            Random random = new Random();
            int tiradas = 0;
            string juegoDelTurno;
            
            if (!juego.Completo)
            {
                juego.Jugador.TirarDados();
                this.ultimaTirada = juego.Jugador.Dados;
                mostrarDados.Invoke(this.ultimaTirada);
                tiradas++;
                this.logPartida += $"{juego.Jugador.Nombre} tiro: {juego.Jugador.MostrarDados()}{Environment.NewLine}";
                salidaLogs?.Invoke();
                Thread.Sleep(random.Next(2000, 3000));
                while (tiradas < 3)
                {
                    juegoDelTurno = juego.TieneJuegoImportante();
                    if (!string.IsNullOrEmpty(juegoDelTurno))
                    {
                        juego.RealizarJuego(juegoDelTurno);
                        this.logPartida += $"{juego.Jugador.Nombre} realizo el juego: {juegoDelTurno} {Environment.NewLine}";
                        this.logPartida += $"{Environment.NewLine}";
                        salidaLogs?.Invoke();
                        return;
                    }
                    else
                    {
                        juego.Jugador.TirarDados(ElegirDadoAleatorio(0), ElegirDadoAleatorio(1), ElegirDadoAleatorio(2), ElegirDadoAleatorio(3), ElegirDadoAleatorio(4));
                        this.ultimaTirada = juego.Jugador.Dados;
                        mostrarDados.Invoke(this.ultimaTirada);
                        this.logPartida += $"{juego.Jugador.Nombre} volvio a tirar: {juego.Jugador.MostrarDados()}{Environment.NewLine}";
                        tiradas++;
                        salidaLogs?.Invoke();
                        Thread.Sleep(random.Next(2000, 5000));
                    }
                }
                juegoDelTurno = juego.ElegirMejorJugada();
                if (!string.IsNullOrEmpty(juegoDelTurno))
                {
                    juego.RealizarJuego(juegoDelTurno);
                    this.logPartida += $"{juego.Jugador.Nombre} realizo el juego: {juegoDelTurno}{Environment.NewLine}";
                    salidaLogs?.Invoke();
                }
                else
                {
                    juegoDelTurno = juego.TacharLaMasDificil();
                    this.logPartida += $"{juego.Jugador.Nombre} tacho el juego: {juegoDelTurno}{Environment.NewLine}";
                    salidaLogs?.Invoke();
                }
                this.logPartida += $"{Environment.NewLine}";
                salidaLogs?.Invoke();
                Thread.Sleep(2000);
            }
        }

        private int ElegirDadoAleatorio(int dado)
        {
            Random random = new Random();
            if (random.Next(1, 10) < 5)
            {
                return dado;
            }
            return -1;
        }

        public static bool VerificarJugadorDisponible(List<Partida> partidas, Jugador j)
        {
            //TODO: SACAR DE ACA
            foreach (Partida item in partidas)
            {
                if (item==j)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool operator ==(Partida p, Jugador j)
        {
            return p.J1.Equals(j) || p.J2.Equals(j);
        }
        public static bool operator !=(Partida p, Jugador j)
        {
            return !(p == j);
        }

        public override string ToString()
        {
            return "Mesa";
        }

    }
}
