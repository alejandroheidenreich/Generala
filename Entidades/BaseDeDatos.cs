using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class BaseDeDatos
    {
        static List<Partida> partidas;

        private static string connectionString;
        private static SqlConnection connection;
        private static SqlCommand command;

        static BaseDeDatos()
        {
            connectionString = @"Server =.; Database = Generala ;Trusted_Connection=True; ";

            connection = new SqlConnection(connectionString);
            command = new SqlCommand();

            command.Connection = connection;
            command.CommandType = CommandType.Text;
        }
        public static List<Jugador> ObtenerJugadores()
        {
            List<Jugador> jugadores = new List<Jugador>();

            connection.Open();

            command.CommandText = "SELECT * FROM Jugadores";

            SqlDataReader reader = command.ExecuteReader();


            while (reader.Read())
            {
                int id = reader.GetInt32(0);
                string nombre = reader.GetString(1);
                int puntos = reader.GetInt32(2);
                int victorias = reader.GetInt32(3);

                Jugador jugadorLeido = new Jugador(id, nombre, puntos, victorias);
                jugadores.Add(jugadorLeido);
            }

            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }

            return jugadores;
        }

        public static void AgregarJugador(Jugador jugador)
        {
            try
            {
                connection.Open();

                command.CommandText = $"INSERT INTO Jugadores VALUES (@nombre, @puntos, @victorias) ";
                command.Parameters.AddWithValue("@nombre", jugador.Nombre);
                command.Parameters.AddWithValue("@puntos", jugador.PuntajeAcumulado);
                command.Parameters.AddWithValue("@victorias", jugador.CantidadDeVictorias);

                command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                command.Parameters.Clear();
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }
        public static void ModificarJugador(Jugador jugador)
        {
            try
            {
                connection.Open();

                command.CommandText = "UPDATE Jugadores SET nombre = @nombre, puntos = @puntos, victorias = @victorias WHERE Id = @id";
                command.Parameters.AddWithValue("@nombre", jugador.Nombre);
                command.Parameters.AddWithValue("@dir", jugador.PuntajeAcumulado);
                command.Parameters.AddWithValue("@dir", jugador.CantidadDeVictorias);
                command.Parameters.AddWithValue("@id", jugador.Id);

                command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                command.Parameters.Clear();
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }
        public static void BorrarJugador(Jugador jugador)
        {
            try
            {
                connection.Open();

                command.CommandText = "DELETE Jugadores WHERE Id = @id";
                command.Parameters.AddWithValue("@id", jugador.Id);

                command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                command.Parameters.Clear();
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }
    }
}
