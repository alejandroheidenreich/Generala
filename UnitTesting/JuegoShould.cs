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
            jugador = new Jugador("Ale");
            juego = new Juego(jugador);
        }

        //TODO: VER
        //[ClassInitialize]
        //public void Clasecita()
        //{

        //}

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


        [TestMethod]
        public void ElegirMejorJugada_Test()
        {
            int[] dados;

            this.juego.Jugador.TirarDados();

            dados = this.juego.Jugador.Dados;

            Console.WriteLine($"Dados: {this.juego.Jugador}   Mejor: {this.juego.ElegirMejorJugada()}");
        }

        [TestMethod]
        public void TacharLaMasDificil_Test()
        {
            Dictionary<string, EstadoJuego> juegos = new Dictionary<string, EstadoJuego>()
            {
                {"Al 1",EstadoJuego.Disponible},
                {"Al 2",EstadoJuego.Disponible},
                {"Al 3",EstadoJuego.Disponible},
                {"Al 4",EstadoJuego.Disponible},
                {"Al 5",EstadoJuego.Tachado},
                {"Al 6",EstadoJuego.Disponible},
                {"Escalera",EstadoJuego.Disponible},
                {"Full",EstadoJuego.Disponible},
                {"Poker",EstadoJuego.Realizado},
                {"Generala",EstadoJuego.Realizado},
            };

            this.juego.Juegos = juegos;

            this.juego.TacharLaMasDificil();


            Console.WriteLine($"Antes: {juegos["Full"]}   Despues: {this.juego.Juegos["Full"]}");


            Assert.IsTrue(juego.Juegos["Full"] == EstadoJuego.Tachado);
        }

    }
}
