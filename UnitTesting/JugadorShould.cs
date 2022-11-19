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
    public class JugadorShould
    {
        Jugador jugador;
        [TestInitialize]
        public void Initialize()
        {
            jugador = new Jugador(10,"Messi");
        }

        [TestMethod]
        public void TirarDados_Test()
        {
            int[] dados;
            bool dadoValido = true;

            jugador.TirarDados();
            dados = jugador.Dados;

            foreach (int dado in dados)
            {
                if (dado < 1 || dado > 6)
                {
                    dadoValido = false;
                }
            }

            Assert.IsNotNull(dados);
            Assert.IsTrue(dadoValido);
        }

        [DataRow(0, 1, 2, 3, 4)]
        [DataRow(0, 1, -1, -1, 4)]
        [DataRow(0, -1, 2, -1, 4)]
        [TestMethod]
        public void TirarDadosConParametros_Test(int n1, int n2, int n3, int n4, int n5)
        {
            bool dadoValido = false;
            jugador.TirarDados();
            int[] dados = new int[5] { jugador.Dados[0], jugador.Dados[1], jugador.Dados[2], jugador.Dados[3], jugador.Dados[4] };

            jugador.TirarDados(n1,n2,n3,n4,n5);

            for (int i = 0; i < jugador.Dados.Length; i++)
            {
                if (dados[i] != jugador.Dados[i])
                {
                    dadoValido = true;
                    break;
                }
            }

            Assert.IsTrue(dadoValido);
        }
    }
}
