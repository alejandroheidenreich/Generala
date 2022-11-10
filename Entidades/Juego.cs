using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace Entidades
{
    public enum EstadoJuego
    {
        Disponible, Realizado, Tachado
    }
    public class Juego
    {
        private Dictionary<string, EstadoJuego> juegos;
        private int puntajeTotal;
        private Jugador jugador;

        public Juego(Jugador jugador)
        {
            this.jugador = jugador;
            this.puntajeTotal = 0;
            this.juegos = new Dictionary<string, EstadoJuego>()
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
        }

        public bool Completo
        {
            get
            {
                foreach (EstadoJuego item in this.juegos.Values)
                {
                    if (item == EstadoJuego.Disponible)
                    {
                        return false;
                    }
                }
                return true;
            }
        }

        public Jugador Jugador
        {
            get => jugador;
        }
        public Dictionary<string, EstadoJuego> Juegos
        {
            get => juegos;
            set => juegos = value;
        }
        public int PuntajeTotal
        {
            get => puntajeTotal;
            set => puntajeTotal = value;
        }

        public void RealizarJuego(string juego)
        {
            if (this.juegos.ContainsKey(juego) && this.juegos[juego] == EstadoJuego.Disponible && EncontrarJuegos().Contains(juego))
            {
                this.juegos[juego] = EstadoJuego.Realizado;
                AcumularPuntaje(juego);
            }
            else
            {
                if (this.juegos[juego] == EstadoJuego.Realizado)
                {
                    throw new Exception("El juego ya fue realizado");
                }
                else if (this.juegos[juego] == EstadoJuego.Tachado)
                {
                    throw new Exception("El juego ya fue tachado");
                }
                else
                {
                    throw new Exception("Usted no tiene este juego");
                }
            }
        }
        public void TacharJuego(string juego)
        {
            if (this.juegos.ContainsKey(juego) && this.juegos[juego] == EstadoJuego.Disponible)
            {
                this.juegos[juego] = EstadoJuego.Tachado;
            }
            else
            {
                throw new Exception("Ya esta realizado o tachado");
            }
        }
        public List<string> EncontrarJuegos()
        {
            List<string> juegosDisponibles = new List<string>();
            int verificar;

            for (int i = 1; i < 7; i++)
            {
                verificar = JugarAlNumero(this.jugador.Dados, i);
                if (!juegosDisponibles.Contains($"Al {i}") && verificar > 0)
                {
                    juegosDisponibles.Add($"Al {i}");
                }
            }
            if (Escalera(this.jugador.Dados))
            {
                juegosDisponibles.Add("Escalera");
            }
            if (Full(this.jugador.Dados))
            {
                juegosDisponibles.Add("Full");
            }
            if (Poker(this.jugador.Dados))
            {
                juegosDisponibles.Add("Poker");
            }
            if (Generala(this.jugador.Dados))
            {
                juegosDisponibles.Add("Generala");
            }
            return juegosDisponibles;
        }
        public void AcumularPuntaje(string juego)
        {
            switch (juego)
            {
                case "Al 1":
                    puntajeTotal += JugarAlNumero(jugador.Dados, 1);
                    break;
                case "Al 2":
                    puntajeTotal += JugarAlNumero(jugador.Dados, 2);
                    break;
                case "Al 3":
                    puntajeTotal += JugarAlNumero(jugador.Dados, 3);
                    break;
                case "Al 4":
                    puntajeTotal += JugarAlNumero(jugador.Dados, 4);
                    break;
                case "Al 5":
                    puntajeTotal += JugarAlNumero(jugador.Dados, 5);
                    break;
                case "Al 6":
                    puntajeTotal += JugarAlNumero(jugador.Dados, 6);
                    break;
                case "Escalera":
                    puntajeTotal += 20;
                    break;
                case "Full":
                    puntajeTotal += 30;
                    break;
                case "Poker":
                    puntajeTotal += 40;
                    break;
                case "Generala":
                    puntajeTotal += 60;
                    break;
            }
        }

        public string TieneJuegoImportante()
        {
            List<string> juegosDisponibles = EncontrarJuegos();
            foreach (string item in juegosDisponibles)
            {
                if (this.juegos[item] == EstadoJuego.Disponible && 
                    (item == "Escalera" ||
                    item == "Full" ||
                    item == "Poker" ||
                    item == "Generala"))
                {
                    return item;
                }
            }
            return null;
        }

        public string ElegirMejorJugada()
        {
            List<string> juegosDisponibles = EncontrarJuegos();
            int mejorPuntaje = -1;
            int puntaje;
            string juego = string.Empty;

            foreach (string item in juegosDisponibles)
            {
                if (this.juegos[item] == EstadoJuego.Disponible && item.Contains("Al"))
                {
                    puntaje = JugarAlNumero(this.jugador.Dados, int.Parse(item.Split(" ")[1]));
                    if (mejorPuntaje == -1 || puntaje > mejorPuntaje)
                    {
                        mejorPuntaje = puntaje;
                        juego = item;
                    }
                }
            }
            return juego;     
        }

        public string TacharLaMasDificil()
        {
            KeyValuePair<string,EstadoJuego>[] arrayDeJuegos = new KeyValuePair<string,EstadoJuego>[10];

            arrayDeJuegos = this.juegos.ToArray();
            Array.Reverse(arrayDeJuegos);

            for (int i = 0; i < arrayDeJuegos.Length; i++)
            {
                if (arrayDeJuegos[i].Value == EstadoJuego.Disponible)
                {
                    Console.WriteLine(arrayDeJuegos[i].Key);
                    this.juegos[arrayDeJuegos[i].Key] = EstadoJuego.Tachado;
                    return arrayDeJuegos[i].Key;
                }
            }
            return null;
        }
        public int JugarAlNumero(int[] dados, int numero)
        {
            int contadorPuntaje = 0;
            if (dados.Length == 5 && dados.Count<int>() == 5)
            {
                for (int i = 0; i < dados.Length; i++)
                {
                    if (dados[i] == numero)
                        contadorPuntaje += dados[i];
                }
            }
            else
            {
                throw new Exception("Error dados insuficientes");
            }
            return contadorPuntaje;
        }
        public bool Escalera(int[] dados)
        {
            if (dados.Length == 5 && dados.Count<int>() == 5)
            {
                int[] aux = (int[])dados.Clone();
                Array.Sort(aux);
                if (aux[0] == 1 && aux[1] == 2 && aux[2] == 3 && aux[3] == 4 && aux[4] == 5 ||
                    aux[0] == 2 && aux[1] == 3 && aux[2] == 4 && aux[3] == 5 && aux[4] == 6 ||
                    aux[0] == 1 && aux[1] == 3 && aux[2] == 4 && aux[3] == 5 && aux[4] == 6)
                {
                    return true;
                }
            }
            else
            {
                throw new Exception("Error dados insuficientes");
            }
            return false;
        }

        public bool Full(int[] dados)
        {
            int contadorDeIguales;
            bool pierna = false;
            bool par = false;
            if (dados.Length == 5 && dados.Count<int>() == 5)
            {
                for (int i = 0; i < dados.Length; i++)
                {
                    contadorDeIguales = 0;
                    for (int j = 0; j < dados.Length; j++)
                    {
                        if (dados[i] == dados[j])
                        {
                            contadorDeIguales++;
                        }
                    }
                    switch (contadorDeIguales)
                    {
                        case 2:
                            par = true;
                            break;
                        case 3:
                            pierna = true;
                            break;
                    }
                    if (pierna && par)
                    {
                        return true;
                    }
                }
            }
            else
            {
                throw new Exception("Error dados insuficientes");
            }
            return false;
        }

        public bool Poker(int[] dados)
        {
            int contadorDeIguales;
            if (dados.Length == 5 && dados.Count<int>() == 5)
            {
                for (int i = 0; i < 5; i++)
                {
                    contadorDeIguales = 0;
                    for (int j = 0; j < 5; j++)
                    {
                        if (dados[i] == dados[j])
                        {
                            contadorDeIguales++;
                        }
                    }
                    if (contadorDeIguales >= 4)
                    {
                        return true;
                    }
                }
            }
            else
            {
                throw new Exception("Error dados insuficientes");
            }
            return false;
        }

        public bool Generala(int[] dados)
        {
            if (dados.Length == 5 && dados.Count<int>() == 5)
            {
                for (int i = 1; i < dados.Length; i++)
                {
                    if (dados[0] != dados[i])
                    {
                        return false;
                    }
                }
            }
            else
            {
                throw new Exception("Error dados insuficientes");
            }
            return true;
        }


        public override string ToString()
        {
            return "Juego";
        }
    }
}
