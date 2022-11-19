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
    public class SerializadoraJsonShould
    {
        private SerializadoraJSON<string> json;
        [TestInitialize]
        public void Initialize()
        {
            json = new SerializadoraJSON<string>();
        }


        [TestMethod]
        public void LeerYEscribir_Test()
        {
            string test = "Roberto";
            string lectura;

            json.Escribir(test, "EscrituraJson_Test");

            lectura = json.Leer("json_Test");

            Assert.IsNotNull(lectura);
            Assert.AreEqual(lectura, test);

        }
    }
}
