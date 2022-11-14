using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public interface ISerializador<T>
    {
        public void Escribir(T info, string archivo);

        public T Leer(string archivo);
    }
}
