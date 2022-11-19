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
    public class SerializadorXMLShould
    {
        private SerializadorXML<Usuario> xml;
        private Usuario usuario;

        [TestInitialize]
        public void Initialize()
        {
            xml = new SerializadorXML<Usuario>();
            usuario = new Usuario(10, "messi", "Eldiego#10");
        }


        [TestMethod]
        public void Escribir_Test()
        {
            Usuario usuarioObtenido;

            xml.Escribir(usuario, "EscrituraXML_Test");

            usuarioObtenido = xml.Leer("EscrituraXML_Test");

            Assert.IsNotNull(usuarioObtenido);
            Assert.IsTrue(usuarioObtenido == usuario);

        }

        [TestMethod]
        public void Leer_Test()
        {
            Usuario usuarioObtenido;

            xml.Escribir(usuario, "EscrituraXML_Test");

            usuarioObtenido = xml.Leer("EscrituraXML_Test");

            Assert.IsNotNull(usuarioObtenido);
            //Assert.IsTrue(usuarioObtenido == usuario);
        }
    }
}
