using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Xml;

namespace Entidades
{
    public class SerializadorXML <T> : IPersistenciaDeDatos<T> where T : class, new()
    {
        public string ruta;

        public SerializadorXML()
        {
            ruta = Environment.CurrentDirectory;
            ruta += @"/Archivos";
        }

        public void Escribir(T info, string archivo)
        {
            string rutaCompleta = ruta + archivo + ".xml";

            if (!Directory.Exists(ruta))
            {
                Directory.CreateDirectory(ruta);
            }

            using (XmlTextWriter writer = new XmlTextWriter(rutaCompleta, Encoding.UTF8))
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));
                xmlSerializer.Serialize(writer, info);
            }
        }

        public T Leer(string archivo)
        {
            T info = default;
            string rutaCompleta = ruta + archivo + ".xml";

            if (Directory.Exists(ruta))
            {
                using (XmlTextReader reader = new XmlTextReader(rutaCompleta))
                {
                    XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));
                    info = (T)xmlSerializer.Deserialize(reader);
                }
            }
            else
            {
                throw new Exception("No existe el archivo");
            }
            return info;
        }




    }
}
