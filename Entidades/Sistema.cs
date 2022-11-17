using System.Collections.Generic;

namespace Entidades
{
    public class Sistema
    {
        BaseDeDatos db;

        public Sistema()
        {
            db = new BaseDeDatos();
        }
        public Dictionary<string, EstadoJuego> CargarTablaDeJuegos()
        {
            SerializadoraJSON<Dictionary<string, EstadoJuego>> json = new SerializadoraJSON<Dictionary<string, EstadoJuego>>();
            Dictionary<string, EstadoJuego> dic = json.Leer("tabla");

            if (dic is null)
            {
                CrearTablaDeJuegos();
                dic = CargarTablaDeJuegos();
            }

            return dic;
        }

        public void CrearTablaDeJuegos()
        {
            SerializadoraJSON<Dictionary<string, EstadoJuego>> json = new SerializadoraJSON<Dictionary<string, EstadoJuego>>();
            Dictionary<string, EstadoJuego> juegos = new Dictionary<string, EstadoJuego>()
            {
                {"Al 1",EstadoJuego.Disponible},
                {"Al 2",EstadoJuego.Disponible},
                {"Al 3",EstadoJuego.Disponible},
                {"Al 4",EstadoJuego.Disponible},
                {"Al 5",EstadoJuego.Disponible},
                {"Al 6",EstadoJuego.Disponible},
                {"Escalera",EstadoJuego.Disponible},
                {"Full",EstadoJuego.Disponible},
                {"Poker",EstadoJuego.Disponible},
                {"Generala",EstadoJuego.Disponible},
            };
            json.Escribir(juegos, "tabla");
        }

        public bool VerificarUsuarioContrasenia(string usuario, string contrasenia)
        {
            foreach (Usuario item in db.ObtenerUsuarios())
            {
                if (item.NombreDeUsuario == usuario && item.VerificarPassword(contrasenia))
                {
                    return true;
                }
            }
            return false;
        }


    }
}
