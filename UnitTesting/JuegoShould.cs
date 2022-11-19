using Entidades;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Generala.Test
{
    
    [TestClass]
    public class JuegoShould
    {
        Jugador jugador;
        Juego juego;

        [TestInitialize]
        public void Initialize()
        {
            jugador = new Jugador("Roberto");
            juego = new Juego(jugador);
        }

        [DataRow(1, 2, 3, 4, 5, "Escalera")]
        [DataRow(2, 2, 1, 1, 1, "Full")]
        [DataRow(3, 3, 3, 3, 3, "Generala")]
        [DataRow(2, 4, 4, 4, 4, "Poker")]
        [TestMethod]
        public void RealizarJuego_Test(int n1, int n2, int n3, int n4, int n5, string resultado)
        {
            int[] dados = { n1, n2, n3, n4, n5 };
            juego.Jugador.Dados = dados;

            juego.RealizarJuego(resultado);

            Assert.AreEqual(juego.Juegos[resultado], EstadoJuego.Realizado);
        }

        [DataRow(1, 2, 3, 4, 5, "Escalera")]
        [DataRow(2, 2, 1, 1, 1, "Full")]
        [DataRow(3, 3, 3, 3, 3, "Generala")]
        [DataRow(2, 4, 4, 4, 4, "Poker")]
        [TestMethod]
        public void RealizarJuegoCuandoNoEstaDisponibleElJuego_Test(int n1, int n2, int n3, int n4, int n5, string resultado)
        {
            Dictionary<string, EstadoJuego> juegosTest = new Dictionary<string, EstadoJuego>()
            {
                {"Al 1",EstadoJuego.Tachado},
                {"Al 2",EstadoJuego.Realizado},
                {"Al 3",EstadoJuego.Tachado},
                {"Al 4",EstadoJuego.Realizado},
                {"Al 5",EstadoJuego.Tachado},
                {"Al 6",EstadoJuego.Realizado},
                {"Escalera",EstadoJuego.Tachado},
                {"Full",EstadoJuego.Realizado},
                {"Poker",EstadoJuego.Tachado},
                {"Generala",EstadoJuego.Realizado},
            };
            int[] dados = { n1, n2, n3, n4, n5 };
            juego.Jugador.Dados = dados;
            juego.Juegos = juegosTest;

            Assert.ThrowsException<Exception>(() =>
            {
                juego.RealizarJuego(resultado);
            });
            
        }

        [DataRow("Escalera")]
        [DataRow("Full")]
        [DataRow("Generala")]
        [DataRow("Poker")]
        [TestMethod]
        public void TacharJuego_Test(string resultado)
        {
            juego.TacharJuego(resultado);

            Assert.AreEqual(juego.Juegos[resultado], EstadoJuego.Tachado);
        }

        [DataRow("Escalera")]
        [DataRow("Full")]
        [DataRow("Generala")]
        [DataRow("Poker")]
        [TestMethod]
        public void TacharJuegoCuandoNoEstaDisponibleElJuego_Test(string resultado)
        {
            Dictionary<string, EstadoJuego> juegosTest = new Dictionary<string, EstadoJuego>()
            {
                {"Al 1",EstadoJuego.Tachado},
                {"Al 2",EstadoJuego.Realizado},
                {"Al 3",EstadoJuego.Tachado},
                {"Al 4",EstadoJuego.Realizado},
                {"Al 5",EstadoJuego.Tachado},
                {"Al 6",EstadoJuego.Realizado},
                {"Escalera",EstadoJuego.Tachado},
                {"Full",EstadoJuego.Realizado},
                {"Poker",EstadoJuego.Tachado},
                {"Generala",EstadoJuego.Realizado},
            };
            juego.Juegos = juegosTest;

            Assert.ThrowsException<Exception>(() =>
            {
                juego.RealizarJuego(resultado);
            });

        }


        [DataRow(2, 2, 1, 1, 1, "Full", "Al 2", "Al 1")]
        [DataRow(2, 4, 4, 4, 4, "Poker", "Al 4", "Al 2")]
        [TestMethod]
        public void EncontrarJuego_Test(int n1, int n2, int n3, int n4, int n5, string resultadoUno, string resultadoDos, string resultadoTres)
        {
            int[] dados = { n1, n2, n3, n4, n5 };
            juego.Jugador.Dados = dados;

            List<string> juegosEncontrados = juego.EncontrarJuegos();

            Assert.IsNotNull(juegosEncontrados);
            Assert.IsTrue(juegosEncontrados.Contains(resultadoUno) && juegosEncontrados.Contains(resultadoDos) && juegosEncontrados.Contains(resultadoTres));
        }

        [DataRow(1, 2, 3, 4, 5, "Escalera", 20)]
        [DataRow(2, 2, 1, 1, 1, "Full", 30)]
        [DataRow(3, 3, 3, 3, 3, "Generala", 60)]
        [DataRow(2, 4, 4, 4, 4, "Poker", 40)]
        [TestMethod]
        public void AcumularPuntaje_Test(int n1, int n2, int n3, int n4, int n5, string resultado, int puntaje)
        {
            int[] dados = { n1, n2, n3, n4, n5 };
            juego.Jugador.Dados = dados;

            juego.AcumularPuntaje(resultado);

            Assert.AreEqual(juego.PuntajeTotal, puntaje);
        }

        [DataRow(1, 2, 3, 4, 5, "Escalera")]
        [DataRow(2, 2, 1, 1, 1, "Full")]
        [DataRow(2, 2, 3, 3, 5, "")]
        [DataRow(2, 4, 4, 4, 4, "Poker")]
        [TestMethod]
        public void TieneJuegoImportante_Test(int n1, int n2, int n3, int n4, int n5, string juegoEsperado)
        {
            int[] dados = { n1, n2, n3, n4, n5 };
            juego.Jugador.Dados = dados;

            string juegoImportante = juego.TieneJuegoImportante();

            Assert.AreEqual(juegoImportante, juegoEsperado);
        }

        [DataRow(1, 4, 4, 2, 5, "Al 4")]
        [DataRow(2, 1, 5, 5, 5, "Al 5")]
        [DataRow(2, 2, 3, 3, 1, "Al 3")]
        [DataRow(1, 1, 1, 2, 6, "Al 6")]
        [TestMethod]
        public void ElegirMejorJugadaAlNumero_Test(int n1, int n2, int n3, int n4, int n5, string juegoEsperado)
        {
            int[] dados = { n1, n2, n3, n4, n5 };
            juego.Jugador.Dados = dados;

            string juegoElegido = juego.ElegirMejorJugadaAlNumero();

            Assert.AreEqual(juegoElegido, juegoEsperado);
        }


        [TestMethod]
        public void TacharLaMasDificil_Test()
        {
            Dictionary<string, EstadoJuego> juegosTest = new Dictionary<string, EstadoJuego>()
            {
                {"Al 1",EstadoJuego.Tachado},
                {"Al 2",EstadoJuego.Realizado},
                {"Al 3",EstadoJuego.Tachado},
                {"Al 4",EstadoJuego.Realizado},
                {"Al 5",EstadoJuego.Tachado},
                {"Al 6",EstadoJuego.Realizado},
                {"Escalera",EstadoJuego.Tachado},
                {"Full",EstadoJuego.Realizado},
                {"Poker",EstadoJuego.Disponible},
                {"Generala",EstadoJuego.Realizado},
            };
            juego.Juegos = juegosTest;

            string juegoTachado = juego.TacharLaMasDificil();

            Assert.AreEqual(juegoTachado, "Poker");
        }

        [DataRow(1, 1, 1, 1, 1, 2, 0)]
        [DataRow(2, 2, 1, 1, 1, 2, 4)]
        [DataRow(3, 3, 3, 2, 3, 3 , 12)]
        [DataRow(2, 4, 4, 4, 6, 4, 12)]
        [DataRow(4, 6, 6, 1, 4, 6, 12)]
        [TestMethod]
        public void JugarAlNumero_Test(int n1, int n2, int n3, int n4, int n5, int numero, int resultado)
        {
            int puntaje;
            int[]dados = { n1,n2,n3,n4,n5};
            puntaje = juego.JugarAlNumero(dados, numero);

            Assert.AreEqual(resultado, puntaje);
        }

        [DataRow(4, 4, 6, 6, 4)]
        [DataRow(1, 1, 1, 2, 2)]
        [DataRow(2, 2, 1, 1, 1)]
        [DataRow(3, 5, 3, 5, 3)]
        [DataRow(6, 4, 4, 4, 6)]
        [TestMethod]
        public void EsFull_Test(int n1, int n2, int n3, int n4, int n5)
        {
            bool esFull;
            int[] dados = { n1, n2, n3, n4, n5 };

            esFull = juego.Full(dados);
            Console.Write(esFull);
            Assert.IsTrue(esFull);
        }

        [DataRow(1, 3, 1, 2, 2)]
        [DataRow(1, 1, 1, 1, 1)]
        [DataRow(1, 2, 3, 4, 5)]
        [DataRow(6, 4, 4, 4, 4)]        
        [DataRow(4, 4, 6, 6, 3)]
        [TestMethod]
        public void NoEsFull_Test(int n1, int n2, int n3, int n4, int n5)
        {
            bool esFull;
            int[] dados = { n1, n2, n3, n4, n5 };

            esFull = juego.Full(dados);

            Assert.IsFalse(esFull);
        }

        [DataRow(new int[1] { 1 })]
        [DataRow(new int[2] { 1, 2 })]
        [DataRow(new int[3] { 1, 2, 3 })]
        [DataRow(new int[4] { 1, 2, 3, 4 })]
        [DataRow(new int[6] { 1, 2, 6, 5, 4, 5 })]
        [TestMethod]
        public void NoEsDadoValidosFull_Test(int[] dados)
        {
            Assert.ThrowsException<Exception>(() =>
            {
                juego.Full(dados);
            });
        }

        [DataRow(3, 3, 3, 3, 1)]
        [DataRow(2, 5, 5, 5, 5)]
        [DataRow(4, 4, 4, 4, 4)]
        [DataRow(6, 6, 6, 4, 6)]
        [DataRow(2, 4, 2, 2, 2)]
        [TestMethod]
        public void EsPoker_Test(int n1, int n2, int n3, int n4, int n5)
        {
            bool esPoker;
            int[] dados = { n1, n2, n3, n4, n5 };

            esPoker = juego.Poker(dados);

            Assert.IsTrue(esPoker);
        }

        [DataRow(3, 2, 1, 3, 3)]
        [DataRow(1, 2, 3, 1, 1)]
        [DataRow(4, 4, 4, 1, 5)]
        [DataRow(6, 4, 5, 4, 6)]
        [DataRow(6, 4, 1, 6, 6)]
        [TestMethod]
        public void NoEsPoker_Test(int n1, int n2, int n3, int n4, int n5)
        { 
            bool esPoker;
            int[] dados = { n1, n2, n3, n4, n5 };

            esPoker = juego.Poker(dados);

            Assert.IsFalse(esPoker);
        }

        [DataRow(new int[1] { 1 })]
        [DataRow(new int[2] { 1, 2 })]
        [DataRow(new int[3] { 1, 2, 3 })]
        [DataRow(new int[4] { 1, 2, 3, 4 })]
        [DataRow(new int[6] { 1, 2, 6, 5, 4, 5 })]
        [TestMethod]
        public void NoEsDadoValidosPoker_Test(int[] dados)
        {
            Assert.ThrowsException<Exception>(() =>
            {
                juego.Poker(dados);
            });
        }

        [DataRow(1, 2, 3, 4, 5)]
        [DataRow(2, 3, 4, 5, 6)]
        [DataRow(3, 4, 5, 6, 1)]
        [DataRow(6, 1, 5, 4, 3)]
        [DataRow(2, 5, 1, 3, 4)]
        [TestMethod]
        public void EsEscalera_Test(int n1, int n2, int n3, int n4, int n5)
        {
            bool esEscalera;
            int[] dados = { n1, n2, n3, n4, n5 };

            esEscalera = juego.Escalera(dados);

            Assert.IsTrue(esEscalera);
        }

        [DataRow(1, 2, 5, 6, 4)]
        [DataRow(2, 3, 4, 5, 5)]
        [DataRow(3, 3, 5, 6, 1)]
        [DataRow(6, 1, 5, 4, 2)]
        [DataRow(2, 6, 1, 3, 4)]
        [TestMethod]
        public void NoEsEscalera_Test(int n1, int n2, int n3, int n4, int n5)
        {
            bool esEscalera;
            int[] dados = { n1, n2, n3, n4, n5 };

            esEscalera = juego.Escalera(dados);

            Assert.IsFalse(esEscalera);
        }

        [DataRow(new int[1] { 1 })]
        [DataRow(new int[1] { 2 })]
        [TestMethod]
        public void NoEsDadoValidosEscalera_Test(int[] dados)
        {
            Assert.ThrowsException<Exception>(() =>
            {
                juego.Escalera(dados);

            });
        }

        [DataRow(1, 1, 1, 1, 1)]
        [DataRow(2, 2, 2, 2, 2)]
        [DataRow(3, 3, 3, 3, 3)]
        [DataRow(4, 4, 4, 4, 4)]
        [DataRow(5, 5, 5, 5, 5)]
        [DataRow(6, 6, 6, 6, 6)]
        [TestMethod]
        public void EsGenerala_Test(int n1, int n2, int n3, int n4, int n5)
        {
            bool esGenerala;
            int[] dados = { n1, n2, n3, n4, n5 };

            esGenerala = juego.Generala(dados);

            Assert.IsTrue(esGenerala);
        }

        [DataRow(1, 1, 1, 1, 2)]
        [DataRow(2, 2, 3, 2, 2)]
        [DataRow(3, 4, 3, 3, 3)]
        [DataRow(4, 4, 4, 4, 5)]
        [DataRow(6, 5, 5, 5, 5)]
        [DataRow(6, 6, 6, 6, 1)]
        [TestMethod]
        public void NoEsGenerala_Test(int n1, int n2, int n3, int n4, int n5)
        {
            bool esGenerala;
            int[] dados = { n1, n2, n3, n4, n5 };

            esGenerala = juego.Generala(dados);

            Assert.IsFalse(esGenerala);
        }

        
        [DataRow(new int[1] { 1 })]
        [DataRow(new int[2] { 1,2 })]
        [DataRow(new int[3] { 1,2,3 })]
        [DataRow(new int[4] { 1,2,3,4 })]
        [DataRow(new int[6] { 1,2,6,5,4,5})]
        [TestMethod]
        public void NoEsDadoValidosGenerala_Test(int[] dados)
        {
            Assert.ThrowsException<Exception>(() =>
            {
                juego.Generala(dados);
            });
        }

    }
}
