using Entidades;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generala.Test
{

    [TestClass]
    public class BaseDeDatosShould
    {
        private BaseDeDatos db;

        [TestInitialize]
        public void Initialize()
        {
            db = new BaseDeDatos();
        }

        [TestMethod]
        public void ObtenerUsuarios_Test()
        {
            List<Usuario> usuarios;

            usuarios = db.ObtenerUsuarios();

            Assert.IsTrue(usuarios.Count > 0);
        }

        [TestMethod]
        public void ObtenerUsuariosException_Test()
        {
            db.ForzarErrorDeConeccionTesting();

            Assert.ThrowsException<Exception>(() =>
            {
                List<Usuario> usuarios = db.ObtenerUsuarios();
            });
        }

        [TestMethod]
        public void ObtenerJugadores_Test()
        {
            List<Jugador> jugadores;

            jugadores = db.ObtenerJugadores();

            Assert.IsTrue(jugadores.Count > 0);
        }

        [TestMethod]
        public void ObtenerJugadoresException_Test()
        {
            db.ForzarErrorDeConeccionTesting();
            
            Assert.ThrowsException<Exception>(() =>
            {
                List<Jugador> jugadores = db.ObtenerJugadores();
            });
        }

        [TestMethod]
        public void InformarRankingVictorias_Test()
        {
            List<Jugador> jugadores = db.ObtenerJugadores();
            Dictionary<string, int> ranking;

            ranking = db.InformarRankingVictorias();

            Assert.IsTrue(jugadores.Count == ranking.Keys.Count);
        }

        [TestMethod]
        public void InformarRankingVictoriasException_Test()
        {
            db.ForzarErrorDeConeccionTesting();

            Assert.ThrowsException<Exception>(() =>
            {
                Dictionary<string, int> ranking = db.InformarRankingVictorias();
            });
        }

        [TestMethod]
        public void InformarRankingPuntaje_Test()
        {
            List<Jugador> jugadores = db.ObtenerJugadores();
            Dictionary<string, int> ranking;

            ranking = db.InformarRankingPuntaje();

            Assert.IsTrue(jugadores.Count == ranking.Keys.Count);
        }

        [TestMethod]
        public void InformarRankingPuntajeException_Test()
        {
            db.ForzarErrorDeConeccionTesting();

            Assert.ThrowsException<Exception>(() =>
            {
                Dictionary<string, int> ranking = db.InformarRankingPuntaje();
            });
        }
    }

}
