using Entidades;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NuGet.Frameworks;
using System;
using System.Collections.Generic;

namespace Generala.Test
{
    [TestClass]
    public class UsuarioShould
    {
        private Usuario usuario;

        [TestInitialize]
        public void Initialize()
        {
            this.usuario = new Usuario("messi", "Eldiego#10");
        }

        [TestMethod]
        public void VerificarPasswordVerdadero_Test()
        {
            bool verificado = usuario.VerificarPassword("Eldiego#10");

            Assert.IsTrue(verificado);
        }

        [TestMethod]
        public void VerificarPasswordFalse_Test()
        {
            bool verificado = usuario.VerificarPassword("asd123");

            Assert.IsFalse(verificado);
        }

        [DataRow("asd123")]
        [DataRow("aaa")]
        [DataRow("Eduardo")]
        [DataRow("Juan Cruz")]
        [TestMethod]
        public void ValidarStringExitoso_Test(string test)
        {
            string retorno;

            Usuario.ValidarString(test,out retorno, "");

            Assert.IsNotNull(retorno);
            Assert.AreEqual(test, retorno);
        }

        [DataRow("")]
        [DataRow(null)]
        [TestMethod]
        public void ValidarStringFallido_Test(string test)
        {
            string retorno;

            Assert.ThrowsException<ArgumentNullException>(() =>
            {
                Usuario.ValidarString(test, out retorno, "");
            });
        }

        [DataRow("Admin123##")]
        [DataRow("!rob3rtO")]
        [DataRow("AAAAAA!!!!!1111111aaaaaa")]
        [DataRow("123asd!#$ASD")]
        [TestMethod]
        public void ValidarPasswordExitoso_Test(string test)
        {
            string retorno;

            Usuario.ValidarPassword(test, out retorno);

            Assert.IsNotNull(retorno);
            Assert.AreEqual(test, retorno);
        }

        [DataRow("Ab1#")]
        [DataRow("a1#as23aaa")]
        [DataRow("a1aas23aaa")]
        [DataRow("a#aas%%%%aaa")]
        [DataRow("A#AAAA%%%%AAA")]
        [TestMethod]
        public void ValidarPasswordFallido_Test(string test)
        {
            string retorno;

            Assert.ThrowsException<FormatException>(() =>
            {
                Usuario.ValidarPassword(test, out retorno);
            });
        }
        [DataRow("")]
        [DataRow(null)]
        [TestMethod]
        public void ValidarPasswordNull_Test(string test)
        {
            string retorno;
            Assert.ThrowsException<ArgumentNullException>(() =>
            {
                Usuario.ValidarPassword(test, out retorno);
            });
        }

        [DataRow("AAAAAAAAAAAAAAAAa")]
        [DataRow("123123#!#!#12AaA12312312asdA")]
        [TestMethod]
        public void ValidarContieneMinusExitoso_Test(string test)
        {
            bool retorno;

            retorno = Usuario.ValidarContieneMinus(test);

            Assert.IsTrue(retorno);
        }

        [DataRow("BAAAAAAABAAAAAAAAAAAAA")]
        [DataRow("123123#!#!#12A12312312SDGSDF")]
        [TestMethod]
        public void ValidarContieneMinusFallido_Test(string test)
        {
            bool retorno;

            retorno = Usuario.ValidarContieneMinus(test);

            Assert.IsFalse(retorno);
        }

        [DataRow("aaaaaaaaaaaaaaaaaaA")]
        [DataRow("123123#!#!#12HJaA12312312asdA")]
        [TestMethod]
        public void ValidarContieneMayusExitoso_Test(string test)
        {
            bool retorno;

            retorno = Usuario.ValidarContieneMayus(test);

            Assert.IsTrue(retorno);
        }

        [DataRow("21344221345tgfdg23f")]
        [DataRow("ase21jnk3434$%&rdfgdfgwqef")]
        [TestMethod]
        public void ValidarContieneMayusFallido_Test(string test)
        {
            bool retorno;

            retorno = Usuario.ValidarContieneMayus(test);

            Assert.IsFalse(retorno);
        }


        [DataRow("asdasd!54&%Ysdfa")]
        [DataRow("jidshflksdjflks234uasdhfjdo1e")]
        [TestMethod]
        public void ValidarContieneNumericoExitoso_Test(string test)
        {
            bool retorno;

            retorno = Usuario.ValidarContieneNumerico(test);

            Assert.IsTrue(retorno);
        }

        [DataRow("FGIJSDNLKJFLGS/&(/&)ytusdfefs/&(&/ASDASD")]
        [DataRow("HJgjhGHJgHKj/&(%&/&(/)/(%&")]
        [TestMethod]
        public void ValidarContieneNumericoFallido_Test(string test)
        {
            bool retorno;

            retorno = Usuario.ValidarContieneNumerico(test);

            Assert.IsFalse(retorno);
        }

        [DataRow("KJHjkh&%/%&HKK12389&/(12U983jjkGK")]
        [DataRow("jidshflksdjflks234u67(&//(asdhfjdo1e")]
        [TestMethod]
        public void ValidarContieneSimboloExitoso_Test(string test)
        {
            bool retorno;

            retorno = Usuario.ValidarContieneSimbolo(test);

            Assert.IsTrue(retorno);
        }

        [DataRow("asdasdasdasdasd")]
        [DataRow("asdasdsadasd123123")]
        [TestMethod]
        public void ValidarContieneSimboloFallido_Test(string test)
        {
            bool retorno;

            retorno = Usuario.ValidarContieneSimbolo(test);

            Assert.IsFalse(retorno);
        }
    }
}
