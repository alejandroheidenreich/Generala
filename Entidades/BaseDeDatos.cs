using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class BaseDeDatos
    {

        private string connectionString;
        private SqlConnection connection;
        private SqlCommand command;

        public BaseDeDatos()
        {
            connectionString = @"Server =.; Database = Generala ;Trusted_Connection=True; ";
            connection = new SqlConnection(connectionString);
            command = new SqlCommand();

            command.Connection = connection;
            command.CommandType = CommandType.Text;
        }

        public List<Usuario> ObtenerUsuarios()
        {
            List<Usuario> usuarios = new List<Usuario>();

            try
            {
                connection.Open();
                command.CommandText = "SELECT * FROM Usuarios";

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    int id = reader.GetInt32(0);
                    string usuario = reader.GetString(1);
                    string contraseña = reader.GetString(2);

                    Usuario usuarioLeido = new Usuario(id, usuario, contraseña);
                    usuarios.Add(usuarioLeido);
                }
            }
            catch (Exception)
            {

                throw new Exception("Error en Base de Datos");
            }
            finally
            {
                CerrarConneccionBaseDeDatos();
            }

            return usuarios;
        }
        public List<Jugador> ObtenerJugadores()
        {
            List<Jugador> jugadores = new List<Jugador>();

            try
            {
                connection.Open();
                command.CommandText = "SELECT * FROM Jugadores";

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    int id = reader.GetInt32(0);
                    string nombre = reader.GetString(1);

                    Jugador jugadorLeido = new Jugador(id, nombre);
                    jugadores.Add(jugadorLeido);
                }
            }
            catch (Exception)
            {
                throw new Exception("Error en Base de Datos");
            }
            finally
            {
                CerrarConneccionBaseDeDatos();
            }
            return jugadores;
        }

        public void AgregarPartida(Partida partida)
        {
            int idJuegoUno;
            int idJuegoDos;
            try
            {
                idJuegoUno = AgregarJuego(partida.JuegoUno);
                idJuegoDos = AgregarJuego(partida.JuegoDos);

                if (idJuegoUno != -1 && idJuegoDos != -1)
                {
                    connection.Open();

                    command.CommandText = $"INSERT INTO Partida VALUES (@idJuegoUno, @idJuegoDos, @idGanador) ";
                    command.Parameters.AddWithValue("@idJuegoUno", idJuegoUno);
                    command.Parameters.AddWithValue("@idJuegoDos", idJuegoDos);
                    command.Parameters.AddWithValue("@idGanador", partida.Ganador.Id);

                    command.ExecuteNonQuery();
                }
            }
            catch (Exception)
            {
                throw new Exception("Error en Base de Datos");
            }
            finally
            {
                CerrarConneccionBaseDeDatos();
            }
        }

        private int AgregarJuego(Juego juego)
        {
            int id = -1;

            try
            {
                connection.Open();
                command.CommandText = $"INSERT INTO Juego VALUES (@idJugador, @puntaje) ";
                command.Parameters.AddWithValue("@idJugador", juego.Jugador.Id);
                command.Parameters.AddWithValue("@puntaje", juego.PuntajeTotal);
                
                command.ExecuteNonQuery();
                command.Parameters.Clear();

                command.CommandText = "select MAX(id) as 'id' from Juego";

                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    id = reader.GetInt32("id");
                }

            }
            catch (Exception)
            {
                throw new Exception("Error en Base de Datos");
            }
            finally
            {
                CerrarConneccionBaseDeDatos();
            }
            return id;
        }
        public void AgregarJugador(Jugador jugador)
        {
            try
            {
                connection.Open();

                command.CommandText = $"INSERT INTO Jugadores VALUES (@nombre) ";
                command.Parameters.AddWithValue("@nombre", jugador.Nombre);

                command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw new Exception("Error en Base de Datos");
            }
            finally
            {
                CerrarConneccionBaseDeDatos();
            }
        }


        public Dictionary<string, int> InformarRankingVictorias()
        {
            Dictionary<string,int> ranking = new Dictionary<string, int>();

            try
            {
                connection.Open();
                command.CommandText = "SELECT Jugadores.nombre, COUNT(Partida.idGanador) AS victorias FROM Jugadores LEFT JOIN Partida ON (Jugadores.id = Partida.idGanador) GROUP BY Jugadores.nombre ORDER BY victorias DESC";

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    string nombre = reader.GetString(0);
                    int victorias = reader.GetInt32(1);
                    ranking[nombre] = victorias;
                }
            }
            catch (Exception)
            {

                throw new Exception("Error en Base de Datos");
            }
            finally
            {
                CerrarConneccionBaseDeDatos();
            }

            return ranking;
        }

        public Dictionary<string, int> InformarRankingPuntaje()
        {
            Dictionary<string, int> ranking = new Dictionary<string, int>();

            try
            {
      
                connection.Open();
                command.CommandText = "SELECT Jugadores.nombre,COALESCE(SUM(Juego.puntaje),0) AS Puntaje FROM Jugadores LEFT JOIN Juego on Juego.idJugador = Jugadores.id GROUP BY Jugadores.nombre ORDER BY Puntaje desc";

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    string nombre = reader.GetString(0);
                    int puntaje = reader.GetInt32(1);
                    ranking[nombre] = puntaje;
                }
            }
            catch (Exception)
            {

                throw new Exception("Error en Base de Datos");
            }
            finally
            {
                CerrarConneccionBaseDeDatos();
            }

            return ranking;
        }
        private void CerrarConneccionBaseDeDatos()
        {
            if (this.connection.State == ConnectionState.Open)
            {
                this.connection.Close();
            }
        }

        public void ForzarErrorDeConeccionTesting()
        {
            connection = new SqlConnection("");
            command = new SqlCommand();
            command.Connection = connection;
        }
    }
}
