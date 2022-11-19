using System;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Xml.Serialization;

namespace Entidades
{
    public class SerializadoraJSON<T> : IPersistenciaDeDatos<T> where T : class
    {
        static string ruta;

        static SerializadoraJSON()
        {
            ruta = Environment.CurrentDirectory;
            ruta += @"/Archivos";
        }

        public void Escribir(T info, string archivo)
        {
            string rutaCompleta = ruta + @"/" + archivo + ".json";

            try
            {
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
            catch (Exception)
            {

                throw new Exception("Error de escritura archivo .json");
            }
        }

        public T Leer(string archivo)
        {
            T info = default;
            string rutaCompleta = ruta + @"/" + archivo + ".json";

            try
            {
                JsonSerializerOptions opciones = new JsonSerializerOptions()
                {
                    Converters = { new JsonStringEnumConverter(JsonNamingPolicy.CamelCase) }
                };
                if (File.Exists(rutaCompleta))
                {  
                    string json = File.ReadAllText(rutaCompleta);
                    info = JsonSerializer.Deserialize<T>(json, opciones);
                }
            }
            catch (Exception)
            {

                throw new Exception ("Error de lectura archivo .json");
            }
            
            return info;
        }




    }
}
