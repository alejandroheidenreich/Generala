using Entidades;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

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
            jugadorUno = new Jugador("Roberto");
            jugadorDos = new Jugador("Juan Carlos");
            this.partida = new Partida(jugadorUno, jugadorDos);
        }

        //TODO: VER
        //[ClassInitialize]
        //public void Clasecita()
        //{

        //}

        
        [TestMethod]
        public void Turno_Test()
        {
            partida.Turno(partida.JuegoUno);

            Console.WriteLine(partida.LogPartida);
        }

        [TestMethod]
        public void SimularPartida_Test()
        {

            //this.partida.SimularPartida();

            Console.WriteLine(partida.LogPartida);
        }

    }
}
