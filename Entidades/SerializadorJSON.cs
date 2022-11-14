using System;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Xml.Serialization;

namespace Entidades
{
    public class SerializadoraJSON<T> : ISerializador<T> where T : new()
    {
        static string ruta;

        static SerializadoraJSON()
        {
            ruta = Environment.CurrentDirectory;
            ruta += @"/Archivos";
        }

        public void Escribir(T info, string archivo)
        {
            string rutaCompleta = ruta + @"/" + archivo + ".xml";

            if (!Directory.Exists(ruta))
            {
                Directory.CreateDirectory(ruta);
            }
            JsonSerializerOptions opciones = new JsonSerializerOptions()
            {
                Converters = { new JsonStringEnumConverter(JsonNamingPolicy.CamelCase) }
            };
            string json = JsonSerializer.Serialize(info, opciones);

            File.WriteAllText(rutaCompleta, json);
        }

        public T Leer(string archivo)
        {
            T info = default;
            string rutaCompleta = ruta + @"/" + archivo + ".xml";

            if (!Directory.Exists(ruta))
            {
                Directory.CreateDirectory(ruta);
            }
            JsonSerializerOptions opciones = new JsonSerializerOptions()
            {
                Converters = { new JsonStringEnumConverter(JsonNamingPolicy.CamelCase) }
            };
            string json = File.ReadAllText(rutaCompleta);

            info = JsonSerializer.Deserialize<T>(json, opciones);
            
            return info;
        }




    }
}
