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
        Task simulacion;
        CancellationTokenSource cancelacion;
        //public event Action<object,EventArgs> salidaLogs;
        public event Action salidaLogs;



        public Partida(Jugador jugadorUno, Jugador jugadorDos)
        {
            this.juegoUno = new Juego(jugadorUno);
            this.juegoDos = new Juego(jugadorDos);
            this.cancelacion = new CancellationTokenSource();

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
            set => juegoUno = value;
        }

        public Juego JuegoDos
        {
            get => juegoDos;
            set => juegoDos = value;
        }
        public string LogPartida
        {
            get => logPartida;
        }
        //public CancellationTokenSource Cancelacion
        //{
        //    get => cancelacion;
        //}

        public void IniciarPartida()
        {
            this.simulacion = Task.Run(SimularPartida);
        }

        public void SimularPartida()
        {
            while (true)
            {
                if ((!juegoUno.Completo && !juegoDos.Completo) || !this.cancelacion.IsCancellationRequested)
                {
                    Turno(juegoUno);
              
                    Turno(juegoDos);
                }
                else
                {
                    break;
                    
                }
            }

        }

        public void Turno(Juego juego)
        {
            Random random = new Random();
            int tiradas = 0;
            string juegoDelTurno;
            
            if (!juego.Completo)
            {
                juego.Jugador.TirarDados();
                tiradas++;
                this.logPartida += $"{juego.Jugador.Nombre} tiro: {juego.Jugador.MostrarDados()}{Environment.NewLine}";
                salidaLogs?.Invoke();
                Thread.Sleep(random.Next(2000, 3000));
                //Task.Delay(random.Next(2000, 3000));
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
                        this.logPartida += $"{juego.Jugador.Nombre} volvio a tirar: {juego.Jugador.MostrarDados()}{Environment.NewLine}";
                        tiradas++;
                        salidaLogs?.Invoke();
                        Thread.Sleep(random.Next(2000, 5000));
                        //Task.Delay(random.Next(2000, 3000));
                    }
                }
                juegoDelTurno = juego.TieneJuegoImportante();
                if (!string.IsNullOrEmpty(juegoDelTurno))
                {
                    juego.RealizarJuego(juegoDelTurno);
                    this.logPartida += $"{juego.Jugador.Nombre} realizo el juego: {juegoDelTurno} {Environment.NewLine}";
                    salidaLogs?.Invoke();
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
                Thread.Sleep(2000);
                //Task.Delay(random.Next(2000, 3000));
                this.logPartida += $"{Environment.NewLine}";
                salidaLogs?.Invoke();
            }
        }

        private int ElegirDadoAleatorio(int dado)
        {
            Random random = new Random();
            if (random.Next(1, 10) > 5)
            {
                return dado;
            }
            return -1;
        }

        //public Jugador InformarJugadorGanador()
        //{
        //    if (this.puntajeUno > this.puntajeDos)
        //    {
        //        return jugadorUno;
        //    }
        //    else if (this.puntajeUno < this.puntajeDos)
        //    {
        //        return jugadorDos;
        //    }
        //    return null;
        //}

        public override string ToString()
        {
            return "Mesa";
        }

    }
}
