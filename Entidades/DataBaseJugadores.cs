using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    internal class DataBaseJugadores : IPersistenciaDeDatos<Jugador>
    {
        public void Escribir(Jugador info, string archivo)
        {
            
        }


        public Jugador Leer(string archivo)
        {
            return new Jugador();
        }
    }
}
