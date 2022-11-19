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
    public class SerializadoraJasonShould
    {
        private SerializadoraJSON<string> json;
        [TestInitialize]
        public void Initialize()
        {
            json = new SerializadoraJSON<string>();
        }


        [TestMethod]
        public void Escribir_Test()
        {
            string test = "Roberto";
            string lectura;

            json.Escribir(test, "EscrituraJson_Test");

            lectura = json.Leer("json_Test");

            Assert.IsNotNull(lectura);
            Assert.AreEqual(lectura, test);

        }

        [TestMethod]
        public void Leer_Test()
        {
            string test = "Eduardo";
            string lectura;

            json.Escribir(test, "LecturaJson_Test");

            lectura = json.Leer("LecturaJson_Test");

            Assert.IsNotNull(lectura);
            Assert.AreEqual(lectura, test);
        }
    }
}
