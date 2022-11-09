﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Entidades
{
    public class Serializadora <T>
    {
        static string ruta;

        static Serializadora()
        {
            ruta = Environment.CurrentDirectory;
            ruta += @"/Archivos";
        }

        public static void EscribirXML(T info, string archivo)
        {
            string rutaCompleta = ruta + @"/" + archivo + ".xml";

            if (!Directory.Exists(ruta))
            {
                Directory.CreateDirectory(ruta);
            }

            using (StreamWriter sw = new StreamWriter(rutaCompleta))
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));
                xmlSerializer.Serialize(sw, info);
            }
        }

        public static T LeerXML(string archivo)
        {
            T info = default;
            string rutaCompleta = ruta + @"/" + archivo + ".xml";

            if (!Directory.Exists(ruta))
            {
                using (StreamReader sr = new StreamReader(rutaCompleta))
                {
                    XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));
                    info = (T)xmlSerializer.Deserialize(sr);
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