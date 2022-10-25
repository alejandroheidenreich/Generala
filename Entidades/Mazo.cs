using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Mazo
    {
        List<Carta> cartas;

        public Mazo()
        {
            cartas = new List<Carta>();
            GenerarMazoCartas();

        }

        void GenerarMazoCartas()
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 12; j++)
                {
                    if (j > 7 && j < 10)
                    {
                        continue;
                    }
                    else
                    {
                        cartas.Add(new Carta(j, (Palo)i));
                    }
                }
            }
        }
    }
}
