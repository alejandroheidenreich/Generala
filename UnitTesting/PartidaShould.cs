using Entidades;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Threading;

namespace Generala.Test
{
    
    [TestClass]
    public class PartidaShould
    {
        private Partida partida;
        private Jugador jugadorUno;
        private Jugador jugadorDos;


        [TestInitialize]
        public void Initialize()
        {
            jugadorUno = new Jugador(1,"Roberto");
            jugadorDos = new Jugador(2,"Juan Carlos");
            this.partida = new Partida(jugadorUno, jugadorDos, MetodoTest, MetodoTest);
        }

        private void MetodoTest(string test)
        {
        }
        private void MetodoTest(int[] test)
        {
        }

        [TestMethod]
        public void Turno_Test()
        {
            bool cambio = false;
            Dictionary<string, EstadoJuego> juegosInicio = new Dictionary<string, EstadoJuego>()
            {
                {"Al 1",EstadoJuego.Disponible},
                {"Al 2",EstadoJuego.Disponible},
                {"Al 3",EstadoJuego.Disponible},
                {"Al 4",EstadoJuego.Disponible},
                {"Al 5",EstadoJuego.Disponible},
                {"Al 6",EstadoJuego.Disponible},
                {"Escalera",EstadoJuego.Disponible},
                {"Full",EstadoJuego.Disponible},
                {"Poker",EstadoJuego.Disponible},
                {"Generala",EstadoJuego.Disponible},
            };


            partida.Turno(partida.JuegoUno);


            foreach (KeyValuePair<string,EstadoJuego> item in partida.JuegoUno.Juegos)
            {
                if (item.Value != juegosInicio[item.Key])
                {
                    cambio = true;
                    break;
                }
            }

            Assert.IsTrue(cambio);
        }

        [TestMethod]
        public void SimularPartida_Test()
        {
            CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();
            this.partida.SimularPartida(cancellationTokenSource.Token);

            Assert.IsNotNull(partida.Ganador);
            Assert.IsTrue(partida.Ganador == jugadorUno || partida.Ganador == jugadorDos);
        }

        [TestMethod]
        public void VerificarJugadorDisponibleVerdadero_Test()
        {
            List<Partida> partidas = new List<Partida>();
            partidas.Add(partida);

            bool exite = Partida.VerificarJugadorDisponible(partidas, jugadorUno);

            Assert.IsTrue(exite);
        }

        [TestMethod]
        public void VerificarJugadorDisponibleFalse_Test()
        {
            List<Partida> partidas = new List<Partida>();
            partidas.Add(partida);

            bool exite = Partida.VerificarJugadorDisponible(partidas, new Jugador(3,"Edudardo"));

            Assert.IsFalse(exite);
        }
    }
}
